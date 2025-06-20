Imports System.Data.Odbc
Imports DevComponents.DotNetBar

Public Class frmConvenio

    Protected _vengo As _vengode
    Public mestado As Estado
    Public Control As Clscontrolpago
    Dim des As Desglose = New Desglose
    Public idencconvenio As Int32
    Public nodeperiodos As Int32
    Public lista As New desglozeconvenio

    Private repositorio As New RepositorioConvenios()
    Private convenioActual As ConvenioPago

    Private usuario As UsuarioDTO
    'Private repositoriousuario As New VUsuarioRepository()
    'Dim repositorioFormatos As New FormatosUsuarioRepositorio()

    Enum Estado
        Nuevo
        Cancelar
        Visualizar
    End Enum

    Enum _vengode
        nuevocont
        solicitud
    End Enum

    Public Sub New(ByVal vengo As _vengode)
        InitializeComponent()
        _vengo = vengo
        'MO(_vengo)
    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub

    Dim hoy As Date = Date.Now
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        carga()
    End Sub
    Private Sub carga()
        Dim cadenadecarga As String


        Domicilio.Text = ""

        nombre.Text = ""


        Comunidad.Text = ""
        Colonia.Text = ""
        total.Text = "$0.00"
        Try

            If cuentaAnte.Text <> "" And cuentatxt.Text = "" Then ' para cuenta anterior
                convenioActual = repositorio.ObtenerConvenioPorUbicacion(cuentaAnte.Text)

                cuentatxt.Text = convenioActual.IdCuenta.ToString()


            End If

            If cuentatxt.Text <> "" Then
                Dim c As Integer = Integer.Parse(cuentatxt.Text)

                convenioActual = repositorio.ObtenerConvenioPorCuenta(c)
                cuentaAnte.Text = convenioActual.Ubicacion

            End If

            If convenioActual.convenio Then
                MessageBox.Show("El usuario tiene un convenio actual")
                Return
            End If
            total.Text = convenioActual.TotalDeuda.ToString("C")
            nombre.Text = convenioActual.Nombre
            Domicilio.Text = convenioActual.Domicilio
            Colonia.Text = convenioActual.Colonia

            Colonia.Text = convenioActual.Colonia
            lblnodeperiodos.Text = convenioActual.PeriodosAdeudados.ToString()

            lblperiodopagado.Text = "Cuando pague el mes de: " & convenioActual.Mes & " " & convenioActual.Periodo & " se dara por pagado el convenio"

            '' voy a llenar el grid de la deuda

            usuario = repositoriousuario.ObtenerUsuarioPorCuenta(cuentatxt.Text)

            DataGridViewX1.Rows.Clear()
            DataGridViewX1.Rows.Add(usuario.Consumo.ToString("C"), usuario.DeudaAgua.ToString("C"), usuario.Alcantarillado.ToString("C"), usuario.DeudaAlcantarillado.ToString("C"), usuario.Saneamiento.ToString("C"), usuario.Recargos, usuario.Otros.ToString("C"), usuario.IVA.ToString("C"), usuario.Total.ToString("C"), usuario.Credito.ToString("C"))


        Catch ex As Exception
            MsgBox("No existe registro")
            Domicilio.Text = ""
            cuentatxt.Text = ""
            nombre.Text = ""
            cuentaAnte.Text = ""
            total.Text = ""
            Comunidad.Text = ""
            Colonia.Text = ""


            Try
                dataConv.Rows.Clear()
            Catch ex2 As Exception
                MsgBox(ex2.Message)
            End Try

        End Try

    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Try
            Try
                dataConv = New DataGridView
                dataConv.Rows.Clear()
            Catch ex As Exception

            End Try
            Dim convenio As Integer
            Try

                Dim cadenadecarga As String
                cadenadecarga = "Select convenio from usuario where cuenta =" & cuentatxt.Text & " "
                Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                dr.Read()
                If Not IsDBNull(dr("convenio")) Then
                    convenio = dr("convenio")
                Else
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If convenio = 0 Then

                If TxtTel.MaskFull = False Then
                    MessageBoxEx.Show("Falta especificar el Telefono", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If nombre.Text = "" Then
                    MessageBoxEx.Show("No a seleccionado ningún usuario", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Try
                    If convenioActual IsNot Nothing Then
                        repositorio.GuardarConvenio(convenioActual, dataConv)
                        MessageBox.Show("Convenio guardado correctamente.")
                    Else
                        MessageBox.Show("No hay datos para guardar.")
                    End If

                    Ejecucion("update usuario set convenio= '1' where cuenta=" & cuentatxt.Text)


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            End If
            If convenio = 1 Then
                MsgBox("El usuario ya cuenta con un Convenio")
                Domicilio.Text = ""
                cuentatxt.Text = ""
                nombre.Text = ""
                total.Text = ""
                Comunidad.Text = ""
                Colonia.Text = ""


                cuentaAnte.Text = ""
                TxtTel.Clear()
                dataConv.DataSource = Nothing
            End If
            ButtonX3.Enabled = False
        Catch ex As Exception
            MsgBox("Sin convenioActual")
        End Try
    End Sub

    Private Sub frmConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IInodepagos.Visible = True

        BtnCalcular.Visible = True
        dataConv.Visible = False

        Label6.Visible = True
        'descuento.Text = 0


        iiprimerpago.Value = 1


        ButtonX4.Visible = False

        Select Case mestado
            Case Estado.Visualizar
                Dim list As ListConvenios = New ListConvenios

                ButtonX4.Visible = True
                btnExaminar.Enabled = False
                cuentatxt.Enabled = False
                cuentaAnte.Enabled = False
                total.Enabled = False
                TxtTel.Enabled = True

                IInodepagos.Enabled = True

                nuevoadeudo.Enabled = False
                descuento.Enabled = False
                dataConv.Visible = True
                btnEditar.Visible = True

                llenadorr()
                ButtonX3.Enabled = False

        End Select
    End Sub
    Private Sub llenadorr()
        Dim Flist = New ListConvenios


        Dim CONSULTA As String
        Try
            CONSULTA = "select cuenta, FECHA as vencimiento, concepto, round(MONTO,2) as monto, Estado  FROM detconvenio where idencconvenio =" & idencconvenio
            llenaGrid(dataConv, CONSULTA)
            dataConv.Columns("Cuenta").Width = 70
            dataConv.Columns("vencimiento").Width = 100
            dataConv.Columns("concepto").Width = 100
            dataConv.Columns("monto").Width = 100
            'dataConv.Columns("resta").Width = 100
            dataConv.Columns("Estado").Width = 100
            dataConv.AllowUserToAddRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub calcular()



    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click


        If IInodepagos.Value <= 1 Then
            MessageBoxEx.Show("No hay convenio menor o igual a un solo pago", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If iiprimerpago.Value = 0 Then
            MessageBoxEx.Show("No puede haber un pago sin un pago inicial", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If IIdiasdeaplazamiento.Value = 0 Then
            MessageBoxEx.Show("No se han establecido días de aplazamiento", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Variables necesarias
        Dim fechaInicial As DateTime = DateTime.Now
        Dim montoInicial As Decimal = iiprimerpago.Value
        Dim numeroPagos As Integer = IInodepagos.Value
        Dim diasAplazamiento As Integer = IIdiasdeaplazamiento.Value
        Dim montoRestante As Decimal = convenioActual.TotalDeuda - montoInicial
        Dim montoMensual As Decimal = montoRestante / (numeroPagos - 1)
        Dim fechaPago As DateTime = fechaInicial

        convenioActual.NumeroPagos = numeroPagos
        convenioActual.Aplazamiento = diasAplazamiento

        ' Limpiar el Grid antes de llenarlo
        dataConv.Visible = True
        dataConv.Rows.Clear()

        ' Agregar el pago inicial (1/total)
        dataConv.Rows.Add(fechaPago.ToShortDateString(), $"1/{numeroPagos}", montoInicial.ToString("C"))

        ' Generar los pagos restantes
        For i As Integer = 2 To numeroPagos
            ' Sumar los días de aplazamiento
            fechaPago = fechaPago.AddDays(diasAplazamiento)

            ' Agregar la fila al Grid con la nueva fecha y el monto
            dataConv.Rows.Add(fechaPago.ToShortDateString(), $"{i}/{numeroPagos}", montoMensual.ToString("C"))
        Next

        ' Mensaje de confirmación
        MessageBox.Show("Pagos calculados correctamente.", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Sub tablaModifConvenio()

        Dim motivo As String = ""
        Dim frm As New frmMotivoCont()
        frm.ShowDialog()
        motivo = frm.motivo
        Dim valor() As String = total.Text.Split
        Dim valor1() As String = nuevoadeudo.Text.Split
        Dim diferencia As Double
        diferencia = Convert.ToDouble(valor(0)) - Convert.ToDouble(valor1(0))
        Dim idConvenio As Integer
        Dim cadenadecarga As String
        Dim cadena As String
        Dim nombreUsu As String
        cadenadecarga = "select idEncConvenio from EncConvenio where idcuenta =" & cuentatxt.Text
        Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
        dr.Read()
        If Not IsDBNull(dr("idEncConvenio")) Then
            idConvenio = dr("idEncConvenio")
        End If
        Try
            cadena = "select Nombre from letras where ccodUsuario= " & NumUser.ToString()
            Dim dr2 As IDataReader = ConsultaSql(cadena).ExecuteReader()
            dr2.Read()
            If Not IsDBNull(dr2("Nombre")) Then
                nombreUsu = dr2("Nombre")
            End If
            Ejecucion("insert into ConvModif (cuenta, idConvenio, fecha, Usuario, TotalAnt, Descuento, TotalConv, Diferencia, Justificacion) values (" & cuentatxt.Text & "," & idConvenio & ",'" & UnixDateFormat(hoy.ToShortDateString) & "','" & nombreUsu & "'," & total.Text & "," & descuento.Text & "," & nuevoadeudo.Text & "," & diferencia & ",'" & motivo & "')")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub consultaGrid()
        Dim CONSULTA As String
        Try
            CONSULTA = "Select cuenta, fecha as Vencimiento, concepto, round(monto, 2) As monto, Estado  FROM detconvenio where idencconvenio =" & idencconvenio & ""
            llenaGrid(dataConv, CONSULTA)
            dataConv.Columns("Cuenta").Width = 70
            dataConv.Columns("vencimiento").Width = 100
            dataConv.Columns("concepto").Width = 100
            dataConv.Columns("monto").Width = 100
            'dataConv.Columns("resta").Width = 100
            dataConv.Columns("Estado").Width = 100
            dataConv.AllowUserToAddRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        validarSalida()
        If cuentatxt.Text = "" And IInodepagos.Visible = False Then

            Me.Close()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles descuento.KeyDown
        If e.KeyCode = Keys.Enter Then

            'If nuevoadeudo.Text = 0 Then
            Dim valor() As String = total.Text.Split
            Dim deuda As Double = Convert.ToDouble(valor(0))
            Dim valor4() As String = descuento.Text.Split
            'Dim valor5() As String = adeudon.Text.Split
            Dim des As Double
            des = valor4(0) / 100
            Dim vAdeudo As Double
            vAdeudo = deuda * des
            Dim NAdeudo As Double
            NAdeudo = deuda - vAdeudo
            nuevoadeudo.Text = NAdeudo

        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        ConfirmarConvenio()
        Dim l As New ListConvenios   'CLICK PARA CONFIRMAR CONVENIO

        l.llenargrid()
    End Sub
    Public Sub ConfirmarConvenio()


        Try

            Dim idConvenio As Integer
            Dim cadenadecarga As String
            Dim cadena As String
            Dim nombreUsu As String = ""
            Try
                cadenadecarga = "select idEncConvenio from EncConvenio where idcuenta =" & cuentatxt.Text
                Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                dr.Read()
                If Not IsDBNull(dr("idEncConvenio")) Then
                    idConvenio = dr("idEncConvenio")
                End If

                cadena = "select Nombre from letras where ccodUsuario= " & NumUser.ToString()
                Dim dr2 As IDataReader = ConsultaSql(cadena).ExecuteReader()
                dr2.Read()
                If Not IsDBNull(dr2("Nombre")) Then
                    nombreUsu = dr2("Nombre")
                End If
            Catch ex As Exception

            End Try





        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
            MsgBox("Tu convenio a sido guardado satisfactoriamente")
            Close()

    End Sub
    Public Sub abrirAuto()
        Dim acceso As New Confirmacion
        acceso.ShowDialog()
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles Buttoncerrar.Click
        ' CancelarConvenio()
        Close()
    End Sub
    Public Sub CancelarConvenio()
        Try
            dataConv = New DataGridView
            dataConv.Rows.Clear()
        Catch ex As Exception

        End Try

        IInodepagos.Text = "0"





        Try


            Ejecucion("delete from ConvModif where cuenta=" & cuentatxt.Text)
            Ejecucion("update usuario set convenio= 0 where cuenta=" & cuentatxt.Text)

            Ejecucion("update EncConvenio set Estado='Cancelado'  Where idencconvenio =" & idencconvenio)
            Ejecucion("update detConvenio set Estado='Cancelado'  Where idencconvenio =" & idencconvenio)

            Domicilio.Text = ""
            cuentatxt.Text = ""
            nombre.Text = ""
            total.Text = ""
            nuevoadeudo.Text = ""
            Comunidad.Text = ""
            Label9.Visible = False
            cuentaAnte.Text = ""
            Colonia.Text = ""
            cuentaAnte.Text = ""
            IInodepagos.Visible = True

            BtnCalcular.Visible = False
            dataConv.Visible = False

            Label6.Visible = False
            descuento.Text = 0


            TxtTel.Text = ""
            Label1.Visible = False
            descuento.Visible = False
            Label3.Visible = False
            nuevoadeudo.Visible = False
            ButtonX5.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub cuentatxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cuentatxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            carga()
        End If
    End Sub
    Private Sub cuentaAnte_KeyDown(sender As Object, e As KeyEventArgs) Handles cuentaAnte.KeyDown
        If e.KeyCode = Keys.Enter Then
            carga()
        End If
    End Sub
    Private Sub ButtonX5_Click(sender As Object, e As EventArgs) Handles ButtonX5.Click
        Label1.Visible = True
        descuento.Visible = True
        Label3.Visible = True
        Label9.Visible = True
        nuevoadeudo.Visible = True
    End Sub
    Public Sub cargarconvenioActual(cuenta As Integer, Optional ByVal permitiradelanto As Boolean = False) ' pueden o no estableces si quieren pagar efectivo por defecto es no

        Dim concepto As New Clsconcepto
        Dim dts As OdbcDataReader


        dts = ConsultaSql("select * from vusuario where cuenta =" & cuenta & "  ;").ExecuteReader

        dts.Read()

        If dts.RecordsAffected = 0 Then
            Exit Sub
        End If

        If Not IsDBNull(dts("Ubicacion")) Then
            cuentaAnte.Text = dts("ubicacion")
        Else
            cuentaAnte.Text = Nothing
        End If
        If Not IsDBNull(dts("cuenta")) Then
            cuentatxt.Text = dts("cuenta")
        Else
            cuentatxt.Text = Nothing
        End If
        If Not IsDBNull(dts("nombre")) Then
            nombre.Text = dts("nombre")
        Else
            nombre.Text = Nothing
        End If
        If Not IsDBNull(dts("comunidad")) Then
            Comunidad.Text = dts("comunidad")
        Else
            Comunidad.Text = Nothing
        End If
        If Not IsDBNull(dts("colonia")) Then
            Colonia.Text = dts("colonia")
        Else
            Colonia.Text = Nothing
        End If
        If Not IsDBNull(dts("direccion")) Then
            Domicilio.Text = dts("direccion")
        Else
            Domicilio.Text = Nothing
        End If
        IInodepagos.Text = "0"



        dataConv.DataSource = Nothing

        Try
            Control.Tarifa = dts("tarifa")
        Catch ex As Exception

        End Try
        Try
            Control.Fechainicio = dts("DEUDAFEC")
        Catch ex As Exception

        End Try
        Try
            Control.Fechafinal = Now
        Catch ex As Exception

        End Try
        Try
            Control.cuenta = cuenta
        Catch ex As Exception

        End Try
        Try
            Control.valvulista = dts("idcuotavalvulista")
        Catch ex As Exception
            Control.valvulista = 0
        End Try

        Try
            Control.alcantarillado = dts("alcantarillado")
        Catch ex As Exception

        End Try

        Try
            Control.saneamiento = dts("Saneamiento")
        Catch ex As Exception

        End Try


        Try
            Control.credito = dts("Credito")

        Catch ex As Exception

        End Try

        Try
            Control.EsMEdido = dts("medido")
        Catch ex As Exception

        End Try





        If dts("mostrar") = 0 Then

            MessageBox.Show("la cuenta tiene un estado que no puede cobrarse")


            Exit Sub

        End If
        ' Control.periodo = ""
        Try
            '  Control.calcula(False)
        Catch ex As Exception

        End Try
        Dim observalectura As String = ""
        If dts("Total") = 0 Then
            MsgBox("No cuenta con ningún adeudo")

            IInodepagos.Text = "0"

            nodeperiodos = 0
        Else

            '  totald = Control.totaldeudaconsumo + Control.totaldeudaalcantarillado + Control.totaldeudasaneamiento + Control.totaldeudarecargos + Control.totaldeudaotros + Control.totaldeudaiva

            total.Text = dts("Total").ToString()
            nodeperiodos = dts("Nodeperiodo")
            ' ButtonX5.Visible = True
        End If


        dataConv.DataSource = Nothing

    End Sub
    Dim Sesion As Boolean
    Private Sub frmConvenio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Sesion = False Then
            If MessageBoxEx.Show("¿Desea salir de Convenios?", "Salir de Convenios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                validarSalida()
                e.Cancel = False

            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Public Sub validarSalida()
        Dim cadenadecarga As String
        Dim cadenadecarga2 As String
        Dim idcuenta As Integer
        Dim idconvenio As Integer
        Dim cuenta As Integer

        If cuentatxt.Text <> "" Then
            cadenadecarga = "select idcuenta, idencconvenio from EncConvenio where idcuenta =" & cuentatxt.Text
            Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
            If dr.Read() Then
                Try
                    idcuenta = dr("idcuenta")
                    idconvenio = dr("idencconvenio")
                    cadenadecarga2 = "select cuenta, folio from otrosconceptos where cuenta =" & cuentatxt.Text
                    Dim dr1 As IDataReader = ConsultaSql(cadenadecarga2).ExecuteReader()
                    If dr1.Read() Then
                        Try
                            cuenta = dr1("cuenta") 'hay convenio completo
                        Catch ex As Exception
                            'no existe detalle

                            Ejecucion("delete from encconvenio where idencconvenio=" & idconvenio)
                        End Try
                    End If
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        TxtTel.Enabled = True
        If TxtTel.MaskFull = False Then
            MessageBoxEx.Show("Teléfono incompleto", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                Ejecucion("update usuario set Telefono='" & TxtTel.Text & "' where cuenta =" & cuentatxt.Text & "")
            Catch Ex As Exception

            End Try
        End If

    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs)
        Dim cadena As String
        Dim estado As String
        cadena = "select *  from encconvenio where idencconvenio =" & idencconvenio & ""
        Dim dr1 As IDataReader = ConsultaSql(cadena).ExecuteReader()
        dr1.Read()
        estado = dr1("estado")
        If estado = "Aplicado" Or estado = "Pagado" Then
            MsgBox("No se puede cancelar convenio")
            Exit Sub
        Else
            If MessageBoxEx.Show("¿Seguro que desea cancelar el convenio?", "Salir de Convenios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then




                Try

                    Ejecucion("update detconvenio set Estado='Cancelado' where idencconvenio=" & idencconvenio & "")
                    'Ejecucion("delete from ConvModif where cuenta=" & idcuenta)
                    Ejecucion("update usuario set convenio= 0 where cuenta=" & cuentatxt.Text)

                    Ejecucion("update   EncConvenio set Estado='Cancelado' Where idencconvenio =" & idencconvenio)
                    Domicilio.Text = ""
                    cuentatxt.Text = ""
                    nombre.Text = ""
                    total.Text = ""
                    nuevoadeudo.Text = ""
                    Comunidad.Text = ""
                    Label9.Visible = False
                    cuentaAnte.Text = ""
                    Colonia.Text = ""
                    cuentaAnte.Text = ""
                    IInodepagos.Visible = True

                    BtnCalcular.Visible = False
                    dataConv.Visible = False

                    Label6.Visible = False
                    descuento.Text = 0


                    TxtTel.Text = ""
                    Label1.Visible = False
                    descuento.Visible = False
                    Label3.Visible = False
                    nuevoadeudo.Visible = False
                    ButtonX5.Visible = False

                    Dim li As ListConvenios
                    li = New ListConvenios
                    li.llenargrid()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub TabControlPanel1_Click(sender As Object, e As EventArgs) Handles TabControlPanel1.Click

    End Sub
End Class



Public Class mesescon
    Public consumo As Decimal
    Public alcantarillado As Decimal
    Public saneamiento As Decimal
    Public recargo As Decimal
    Public otros As Decimal
    Public iva As Decimal
    Public mes As String
    Public an_per As Integer

    Private _total As Decimal

    ' Propiedad con acceso (get y set)
    Public Property Total() As Decimal
        Get
            Return consumo + alcantarillado + saneamiento + recargo + otros
        End Get
        Set(value As Decimal)
            _total = consumo + alcantarillado + saneamiento + recargo + otros
        End Set
    End Property
End Class

Public Class desglozeconvenio
    Public lista As New List(Of mesescon)()
End Class