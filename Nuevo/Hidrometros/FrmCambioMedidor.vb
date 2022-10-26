Imports DevComponents.DotNetBar

Public Class FrmCambioMedidor
    Public Cuenta As Double, Comunidad As String

    Private Sub FrmCambioMedidor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmCambioMedidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbMarMed, "descripcion", "Select descripcion from marcasmedidor")
        llenarCombo(cmbDiamMed, "descripcion", "select * from diametros")

        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "' ").ExecuteReader
        cons.Read()
        LblCuenta.Text = Cuenta
        LblComunidad.Text = Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("Direccion")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")
        LblMarcaAntes.Text = obtenerCampo("select descripcion from marcasmedidor where id_marca = '" & cons("marcamedidor") & "'", "descripcion")
        LblFechaAntes.Text = cons("fechainst")
        dtInsta.MinDate = DateAdd(DateInterval.Day, 1, CDate(cons("fechainst")))
        LblNumAntes.Text = cons("nodemedidor")
        LblDiametroAntes.Text = obtenerCampo("select descripcion from diametros where id_diametro = '" & cons("diammedidor") & "'", "descripcion")
        Dim com As String = obtenerCampo("select id_comunidad from comunidades where comunidad='" & Comunidad & "'", "id_comunidad")
        Dim le As IDataReader = ConsultaSql("Select lectura , valornummes(mes, an_per) as ordenado  from lecturas where cuenta = " & Cuenta & " order by ordenado desc limit 1").ExecuteReader
        If le.Read() Then
            lblLecAnt.Text = le("lectura")
        Else
            lblLecAnt.Text = "0"
        End If
        TxtUltimaLectura.Focus()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim diammed As String = "", MarcaAntes As String, DiametroAntes As String
        If txtnumerodemedidor.Text = "" Then
            MessageBoxEx.Show("Establezca el número de medidor, por favor", "Cambio de medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnumerodemedidor.Select()
            Exit Sub
        End If
        If TxtUltimaLectura.Value = 0 Then
            MessageBoxEx.Show("Establezca la ultima lectura que registro el medidor anterior", "Cambio de medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtUltimaLectura.Select()
            Exit Sub
        End If

        If cmbMarMed.Text = "" Then
            MessageBoxEx.Show("Establezca la marca del medidor nuevo", "Cambio de medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbMarMed.Select()
            Exit Sub
        End If
        If cmbDiamMed.Text = "" Then
            MessageBoxEx.Show("Establezca el diametro del medidor nuevo", "Cambio de medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbDiamMed.Select()
            Exit Sub
        End If
        If dtInsta.Text = "" Then
            MessageBoxEx.Show("Establezca la fecha de instalacion del medidor nuevo", "Cambio de medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtInsta.Select()
            Exit Sub
        End If

        If cmbDiamMed.SelectedItem <> "" Then
            diammed = obtenerCampo("select id_diametro from diametros where descripcion=""" & cmbDiamMed.SelectedItem & """ ", "id_diametro")
        End If

        Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")
        Dim idrepm As IDataReader = ConsultaSql("select * from usuario,marcasmedidor where marcasmedidor.id_marca=usuario.marcamedidor and marcasmedidor.descripcion=""" & cmbMarMed.Text & """ and usuario.nodemedidor=""" & txtnumerodemedidor.Text & """ and NOT (usuario.cuenta =" & Cuenta & " and usuario.id_comunidad=""" & Com & """)").ExecuteReader()
        If idrepm.Read() Then
            MessageBox.Show("El número de medidor ya existe para la cuenta=" & idrepm("cuenta") & " de la comunidad= " & idrepm("id_comunidad") & "", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim mmed As String = obtenerCampo("select id_marca from marcasmedidor where descripcion=""" & cmbMarMed.Text & """", "id_marca")
        Dim num As Double = Val(obtenerCampo("Select max(clave) as mayor from cambiomedidor", "mayor")) + 1

        MarcaAntes = obtenerCampo("select id_marca from marcasmedidor where descripcion='" & LblMarcaAntes.Text & "'", "id_marca")
        DiametroAntes = obtenerCampo("select id_diametro from diametros where descripcion='" & LblDiametroAntes.Text & "' ", "id_diametro")
        Dim uconsu As Double = 0, ul As Double = 0
        Dim le As IDataReader = ConsultaSql("Select lectura , valornummes(mes, an_per) as ordenado  from lecturas where cuenta = " & Cuenta & "  order by ordenado desc limit 1").ExecuteReader
        Dim obj As New ClsLecturas()

        If le.Read() Then
            If (Val(TxtUltimaLectura.Text) - le("lectura")) < 0 Then
                obj.Cuenta = Cuenta
                obj.Comunidad = Com
                obj.Lec1 = le("lectura")
                obj.Lectura = Val(TxtUltimaLectura.Text)
                uconsu = obj.Vuelta()
            Else
                uconsu = Val(TxtUltimaLectura.Text) - le("lectura")
            End If

            ul = le("lectura")
        Else
            uconsu = Val(TxtUltimaLectura.Text)
            ul = 0
        End If
        Ejecucion("update usuario set marcamedidor='" & mmed & "', nodemedidor='" & txtnumerodemedidor.Text & "', diammedidor='" & diammed & "', cammed=true where cuenta=" & Cuenta)
        Ejecucion("insert into cambiomedidor ( cuenta, comunidad, medidorantes, marcaantes, diametroantes, medidor, marca, diametro, fechainstalacion, fecha, observaciones, usuario, ultimalectura,lectura_anterior,ultimo_consumo) values (" & Cuenta & ", '" & Com & "', '" & LblNumAntes.Text & "', '" & MarcaAntes & "', '" & DiametroAntes & "', '" & txtnumerodemedidor.Text & "', '" & mmed & "', '" & diammed & "', '" & UnixDateFormat(dtInsta.Value) & "', '" & UnixDateFormat(Now) & "', '" & TxtMotivo.Text & "', '" & NumUser & "', " & Val(TxtUltimaLectura.Text) & "," & ul & "," & uconsu & ")")


        Dim nombre_Host As String = Net.Dns.GetHostName()
        Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
        Dim direccion_Ip As String = este_Host.AddressList(0).ToString

        Try
            Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','Cambio Medidor'," & Cuenta & "," & NumUser & ",'Medidor: " & txtnumerodemedidor.Text & "','" & direccion_Ip & "','" & TxtMotivo.Text & "')")

            ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ButtonX1.Enabled = True

            'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
            '  BtnAceptar.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
        End Try



        MessageBoxEx.Show("Cambio de medidor realizado satisfactoriamente", "Cambio de medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ButtonX1.Enabled = True
        cmdGenCob.Enabled = True
        BtnAceptar.Enabled = False
        'Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim Impr As New FrmTipoImprContrato(Cuenta, Comunidad)
        Impr.CambioNombre = FrmTipoImprContrato.Posibilidades.Cambio_Tarifa
        Impr.ShowDialog()
    End Sub

    Private Sub cmdGenCob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenCob.Click
        Dim frm As New frmagrmov(eve.CambioMedidor, Val(LblCuenta.Text), LblNombre.Text, LblComunidad.Text)
        frm.ShowDialog()
    End Sub

    Private Sub cmbMarMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMarMed.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbDiamMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDiamMed.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub


    Private Sub BtnCancelar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.GotFocus
        BtnCancelar.Pulse()
        BtnCancelar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnCancelar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.LostFocus
        BtnCancelar.StopPulse()
    End Sub

    Private Sub BtnAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.GotFocus
        BtnAceptar.Pulse()
        BtnAceptar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.LostFocus
        BtnAceptar.StopPulse()
    End Sub

    Private Sub cmdGenCob_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGenCob.GotFocus
        cmdGenCob.Pulse()
        cmdGenCob.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdGenCob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGenCob.LostFocus
        cmdGenCob.StopPulse()
    End Sub

    Private Sub ButtonX1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.GotFocus
        ButtonX1.Pulse()
        ButtonX1.StopPulseOnMouseOver = False
    End Sub
    Private Sub ButtonX1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.LostFocus
        ButtonX1.StopPulse()
    End Sub
    Private Sub txtnumerodemedidor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumerodemedidor.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    'Private Sub dtInsta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtInsta.LostFocus
    '    If dtInsta.Value < CDate(LblFechaAntes.Text) Then
    '        dtInsta.Select()
    '        MessageBoxEx.Show("No puede introdocir una fecha de instalación menor a la fecha anterior de instalación", "Cambio de medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

End Class