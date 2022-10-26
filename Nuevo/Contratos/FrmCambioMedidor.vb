Public Class FrmCambioMedidor
    Public Cuenta As Double, Comunidad As String
    Private Sub FrmCambioMedidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbMarMed, "descripcion", "Select descripcion from marcasmedidor")
        llenarCombo(cmbDiamMed, "descripcion", "select * from diametros")

        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "' ").ExecuteReader
        cons.Read()
        LblCuenta.Text = Cuenta
        LblComunidad.Text = Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("colonia") & "   " & cons("calle") & "  " & cons("numext") & "  " & cons("numint")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")
        LblMarcaAntes.Text = obtenerCampo("select descripcion from marcasmedidor where id_marca = '" & cons("marcamedidor") & "'", "descripcion")
        LblFechaAntes.Text = cons("fechainst")
        LblNumAntes.Text = cons("nodemedidor")
        LblDiametroAntes.Text = obtenerCampo("select descripcion from diametros where id_diametro = '" & cons("diammedidor") & "'", "descripcion")

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim diammed As String = "", MarcaAntes As String, DiametroAntes As String
        If cmbDiamMed.SelectedItem <> "" Then
            diammed = obtenerCampo("select id_diametro from diametros where descripcion=""" & cmbDiamMed.SelectedItem & """ ", "id_diametro")
        End If

        Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")
        Dim idrepm As IDataReader = ConsultaSql("select * from usuario,marcasmedidor where marcasmedidor.id_marca=usuario.marcamedidor and marcasmedidor.descripcion=""" & cmbMarMed.Text & """ and usuario.nodemedidor=""" & txtnumerodemedidor.Text & """ and NOT (usuario.cuenta =" & Cuenta & " and usuario.id_comunidad=""" & Com & """)").ExecuteReader()
        If idrepm.Read() Then
            MessageBox.Show("El número de medidor ya existe para la cuenta=" & idrepm("cuenta") & " de la comunidad= " & idrepm("comunidad") & "", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim mmed As String = obtenerCampo("select id_marca from marcasmedidor where descripcion=""" & cmbMarMed.Text & """", "id_marca")
        Dim num As Double = Val(obtenerCampo("Select max(clave) as mayor from cambiomedidor", "mayor")) + 1

        MarcaAntes = obtenerCampo("select id_marca from marcasmedidor where descripcion='" & LblMarcaAntes.Text & "'", "id_marca")
        DiametroAntes = obtenerCampo("select id_diametro from diametros where descripcion=""" & LblDiametroAntes.Text & """ ", "id_diametro")

        Ejecucion("update usuario set marcamedidor='" & mmed & "', nodemedidor='" & txtnumerodemedidor.Text & "', diammedidor='" & diammed & "' where cuenta=" & Cuenta & " and id_comunidad='" & Com & "'")
        Ejecucion("insert into cambiomedidor (clave, cuenta, comunidad, medidorantes, marcaantes, diametroantes, medidor, marca, diametro, fechainstalacion, fecha, observaciones, usuario, ultimalectura) values (" & num & ", " & Cuenta & ", '" & Com & "', '" & LblNumAntes.Text & "', '" & MarcaAntes & "', '" & DiametroAntes & "', '" & txtnumerodemedidor.Text & "', '" & mmed & "', '" & diammed & "', '" & UnixDateFormat(dtInsta.Value) & "', '" & UnixDateFormat(Now) & "', '" & TxtMotivo.Text & "', '" & NumUser & "', " & Val(TxtUltimaLectura.Text) & ")")
        MessageBox.Show("Datos guardados satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ButtonX1.Enabled = True
        cmdGenCob.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim Impr As New FrmTipoImprContrato(Cuenta, Comunidad)
        Impr.CambioNombre = FrmTipoImprContrato.Posibilidades.Cambio_tarifa
        Impr.ShowDialog()
    End Sub

    Private Sub cmdGenCob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenCob.Click
        Dim frm As New frmagrmov(eve.CambioMedidor, Val(LblCuenta.Text), LblNombre.Text, LblComunidad.Text)
        frm.ShowDialog()
    End Sub
End Class