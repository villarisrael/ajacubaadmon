Imports System.Data.Odbc
Imports DevComponents.DotNetBar

Public Class frmConvenio

    Protected _vengo As _vengode
    Public mestado As Estado
    Public Control As Clscontrolpago
    Dim des As Desglose = New Desglose

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
        Control = New Clscontrolpago
    End Sub

    Dim hoy As Date = Date.Now
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        carga()
    End Sub
    Private Sub carga()
        Dim cadenadecarga As String
        Try
            If cuentaAnte.Text = "" And cuentatxt.Text <> "" Then ' para cuando es cuenta
                Dim c As Integer = Integer.Parse(cuentatxt.Text)
                cargardatos(c, False)
            End If
            If cuentatxt.Text = "" And cuentaAnte.Text <> "" Then ' para cuenta anterior
                cadenadecarga = "Select cuenta from usuario where cuentaAnterior  ='" & cuentaAnte.Text & "'"
                Dim dr2 As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                If dr2.Read() = True Then
                    Dim c As Integer = Integer.Parse(dr2("cuenta"))
                    cargardatos(c, False)
                End If
            End If

            If cuentatxt.Text <> "" And cuentaAnte.Text <> "" Then ' tiene los dos
                Dim c As Integer = Integer.Parse(cuentatxt.Text)
                cargardatos(c, False)
            End If

        Catch ex As Exception
            MsgBox("No existe registro")
            Domicilio.Text = ""
            cuentatxt.Text = ""
            nombre.Text = ""
            cuentaAnte.Text = ""
            total.Text = ""
            Comunidad.Text = ""
            Colonia.Text = ""
            pagos.Text = 0
            fecha.Text = 0
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
                cadenadecarga = "Select convenio from usuario where cuenta =" & cuentatxt.Text
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
                    If nuevoadeudo.Text = "" Then
                        nuevoadeudo.Text = 0
                    End If
                    If nuevoadeudo.Text <> 0 Then
                        Ejecucion("insert into encConvenio (idCuenta, Nombre, telefono,total, fechasolicitud, TotalOriginal) values(" & cuentatxt.Text & ",'" & nombre.Text & "','" & TxtTel.Text & "'," & nuevoadeudo.Text & ",'" & hoy.ToShortDateString & "'," & total.Text & ")")
                    End If
                    If nuevoadeudo.Text = 0 Then
                        Ejecucion("insert into encConvenio (idCuenta, Nombre, telefono,total, fechasolicitud, TotalOriginal) values(" & cuentatxt.Text & ",'" & nombre.Text & "','" & TxtTel.Text & "'," & total.Text & ",'" & hoy.ToShortDateString & "'," & total.Text & ")")
                    End If
                    Ejecucion("update usuario set convenio= " & 1 & " where cuenta=" & cuentatxt.Text)
                    Porcentajes()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                pagos.Visible = True
                fecha.Visible = True
                BtnCalcular.Visible = True
                dataConv.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                ButtonX5.Visible = True

            End If
            If convenio = 1 Then
                MsgBox("El usuario ya cuenta con un Convenio")
                Domicilio.Text = ""
                cuentatxt.Text = ""
                nombre.Text = ""
                total.Text = ""
                Comunidad.Text = ""
                Colonia.Text = ""
                pagos.Text = 0
                fecha.Text = 0
                cuentaAnte.Text = ""
                TxtTel.Clear()
                dataConv.DataSource = Nothing
            End If
            ButtonX3.Enabled = False
        Catch ex As Exception
            MsgBox("Sin datos")
        End Try
    End Sub
    Public Sub Porcentajes()
        Dim x As New base
        Dim datos As Odbc.OdbcDataReader
        datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento) where cuenta=" & cuentatxt.Text & "")
        datos.Read()
        Try
            Dim cuenta As Integer
            cuenta = datos("cuenta")
            Dim pago As New Clscontrolpago
            pago.cuenta = cuenta
            pago.Tarifa = datos("Tarifa").ToString()
            pago.Fechafinal = Now.AddMonths(-1)
            pago.Fechainicio = datos("deudafec")
            'pasar los parametros si contiene descuento, alcantarrillado y saneamiento
            pago.saneamiento = datos("Saneamiento")
            pago.alcantarillado = datos("alcantarillado")
            pago.valvulista = datos("idCuotaValvulista")

            If datos("idDescuento") > 0 Then
                ''------ Descuentos
                Try
                    pago.descontartodoslosperiodosdeconsumo = True
                Catch ex As Exception

                End Try

                Try
                    pago.periodoscondescuentodeconsumo = Month(Now)
                Catch ex As Exception

                End Try

                Try
                    pago.descuentoaconsumo = datos("nPctDsct")
                Catch ex As Exception

                End Try
                ''------
            Else
                Try
                    pago.descontartodoslosperiodosdeconsumo = False
                Catch ex As Exception

                End Try

                Try
                    pago.periodoscondescuentodeconsumo = 0
                Catch ex As Exception

                End Try

                Try
                    pago.descuentoaconsumo = 0
                Catch ex As Exception

                End Try
            End If

            pago.calcula(False)

            Dim concepto As New Clsconcepto
            Dim acumiva As Double = 0
            For index = 1 To pago.Listadeconceptos.Count
                Dim conce As New Clsconcepto
                conce = pago.Listadeconceptos(index)
                If conce.IVA > 0 Then
                    conce.IVA = Math.Round((conce.Cantidad * conce.Preciounitario) * (VARIABLE_IVA / 100), 2)
                Else
                    conce.IVA = 0
                End If
                acumiva += conce.IVA
            Next
            des.Calcula(Control)
            x.conexion.Dispose()
            Ejecucion("update encconvenio set porceConsumoActual= " & des.porceConsumoActual & ",porceConsumoRezago=" & des.porceConsumoRezago & ", porceAlcantarilladoActual=" & des.porceAlcantarilladoActual & ", porceAlcantarilladoRezago=" & des.porceAlcantarilladoRezago & ",  porceRecargosActual= " & des.porceRecargosActual & ",  porceRecargosRezago= " & des.porceRecargosRezago & ",  porceSaneamientoActual=" & des.porceSaneamientoActual & ", porceSaneamientoRezago=" & des.porceSaneamientoRezago & ", porceOtros= " & des.porceOtros & ", porceIva=" & des.porceIva & "  where idcuenta=" & cuentatxt.Text)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagos.Visible = False
        fecha.Visible = False
        BtnCalcular.Visible = False
        dataConv.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        'descuento.Text = 0
        fecha.Text = 0
        pagos.Text = 0
        ButtonX1.Visible = False
        ButtonX2.Visible = False
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
                fecha.Enabled = False
                pagos.Enabled = False
                nuevoadeudo.Enabled = False
                descuento.Enabled = False
                dataConv.Visible = True
                btnEditar.Visible = True
                ButtonX6.Visible = True
                llenadorr()
                ButtonX3.Enabled = False

        End Select
    End Sub
    Private Sub llenadorr()
        Dim Flist = New ListConvenios
        Dim idConvenio As Integer
        Dim cadenadecarga As String

        cadenadecarga = "select idEncConvenio from EncConvenio where idcuenta =" & cuentatxt.Text
        Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
        dr.Read()
        idConvenio = dr("idEncConvenio")

        Dim CONSULTA As String
        Try
            CONSULTA = "select cuenta, vencimiento, concepto, round(total,2) as monto, if (pagado=0, ""No"", ""Si"") as Pagado FROM otrosconceptos where cuenta =" & cuentatxt.Text & " and id_concepto= '" & My.Settings.claveConvenio & "'"
            llenaGrid(dataConv, CONSULTA)
            dataConv.Columns("Cuenta").Width = 70
            dataConv.Columns("vencimiento").Width = 100
            dataConv.Columns("concepto").Width = 100
            dataConv.Columns("monto").Width = 100
            'dataConv.Columns("resta").Width = 100
            dataConv.Columns("pagado").Width = 100
            dataConv.AllowUserToAddRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub calcular()
        Dim cadenadecarga As String
        Dim idcuenta As Integer
        Dim idConvenio As Integer

        Dim cadena As String
        cadenadecarga = "select idcuenta from EncConvenio where idcuenta =" & cuentatxt.Text
        Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
        dr.Read()
        Try
            If Not IsDBNull(dr("idcuenta")) Then
                idcuenta = dr("idcuenta")
            End If
            cadena = "select idEncConvenio from EncConvenio where idcuenta =" & cuentatxt.Text
            Dim dra As IDataReader = ConsultaSql(cadena).ExecuteReader()
            dra.Read()
            If Not IsDBNull(dra("idEncConvenio")) Then
                idConvenio = dra("idEncConvenio")
            End If
            Ejecucion("delete  From EncConvenio  Where idcuenta =" & idcuenta)
            Dim valor() As String = nuevoadeudo.Text.Split
            Dim deuda As Double = Convert.ToDouble(valor(0))
            Dim dias As Integer = CInt(fecha.Text)
            If nuevoadeudo.Text <> 0 Then
                Ejecucion("insert into encConvenio (idCuenta, Nombre, telefono,total,pagos, aplazamiento, fechasolicitud, TotalOriginal) values(" & cuentatxt.Text & ",'" & nombre.Text & "','" & TxtTel.Text & "'," & nuevoadeudo.Text & "," & pagos.Text & ",'" & dias & " días','" & hoy.ToShortDateString & "'," & total.Text & ")")
            End If
            If nuevoadeudo.Text = 0 Then
                Ejecucion("insert into encConvenio (idCuenta, Nombre, telefono,total,pagos, aplazamiento, fechasolicitud, TotalOriginal) values(" & cuentatxt.Text & ",'" & nombre.Text & "','" & TxtTel.Text & "'," & total.Text & "," & pagos.Text & ",'" & dias & " días','" & hoy.ToShortDateString & "'," & total.Text & ")")
            End If

            Porcentajes()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim cadenadecarga1 As String
        Dim idcuenta As Integer

        cadenadecarga1 = "select idcuenta from EncConvenio where idcuenta =" & cuentatxt.Text
        Dim dr1 As IDataReader = ConsultaSql(cadenadecarga1).ExecuteReader()
        dr1.Read()

        If Not IsDBNull(dr1("idcuenta")) Then
            idcuenta = dr1("idcuenta")

        End If
        Ejecucion("delete  From otrosconceptos Where cuenta= " & idcuenta & " and id_concepto ='" & My.Settings.claveConvenio & "'")
        If pagos.Text = 0 Then
            MessageBoxEx.Show("Aún no meciona el número de pagos", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf pagos.Text = 1 Then

            Dim fecha1 As Date = Date.Now
            Dim F() As String = fecha.Text.Split
            Dim agregaDias As Integer
            agregaDias = CInt(F(0))
            fecha1 = fecha1.AddDays(+agregaDias)
            ButtonX1.Visible = True
            ButtonX2.Visible = True
            calcular()

            Dim fechaCalcular As Date = Date.Now
            Dim valor1() As String = pagos.Text.Split
            Dim pagar As Double
            If nuevoadeudo.Text = 0 Then
                Dim valor() As String = total.Text.Split
                pagar = Convert.ToDouble(valor(0)) / Convert.ToDouble(valor1(0))
            Else
                Dim valor() As String = nuevoadeudo.Text.Split
                pagar = Convert.ToDouble(valor(0)) / Convert.ToDouble(valor1(0))
            End If

            Dim idConvenio As Integer
            Dim cadenadecarga As String
            Try
                cadenadecarga = "select idEncConvenio from EncConvenio where idcuenta =" & cuentatxt.Text
                Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                dr.Read()
                If Not IsDBNull(dr("idEncConvenio")) Then
                    idConvenio = dr("idEncConvenio")
                End If
                Dim pago As String
                Dim valor2() As String = fecha.Text.Split
                Dim v As Integer = CInt(valor2(0))
                For i = 1 To CInt(valor1(0))
                    pago = "Pago" & i & "/" & pagos.Text

                    Try
                        Ejecucion("INSERT INTO otrosconceptos (Cuenta, Concepto, Total, Subtotal, IVA, Pagado, vencimiento, tabla, folio, Estado, Fec_apli, Fec_alta, fecha_baja, fecha_ult_camb, Resta, tipo_mov, MES_PERIODo, AN_PER,  SubTotResta, IVAResta, Id_Concepto) VALUES (" & cuentatxt.Text & ", '" & pago & "'," & pagar & ", 0, 0, " & False & ", '" & UnixDateFormat(fecha1.ToShortDateString) & "','todos', " & idConvenio & ",'pendiente', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', " & pagar & ", 'cargo', '" & NOMBREDEMES3CAR(hoy.Month) & "', " & Year(Now) & "," & pagar & ", 0, '" & My.Settings.claveConvenio & "')")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    fechaCalcular = fechaCalcular.AddDays(+v)
                Next
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
            consultaGrid()

        ElseIf pagos.Text = 1 And fecha.Text = 0 Then

            Dim fecha1 As Date = Date.Now
            Dim F() As String = fecha.Text.Split
            Dim agregaDias As Integer
            agregaDias = CInt(F(0))
            'fecha.Visible = False
            'Label6.Visible = False
            fecha1 = fecha1.AddDays(+agregaDias)
            ButtonX1.Visible = True
            ButtonX2.Visible = True
            calcular()
            Dim fechaCalcular As Date = Date.Now
            Dim valor1() As String = pagos.Text.Split
            Dim pagar As Double
            If nuevoadeudo.Text = 0 Then
                Dim valor() As String = total.Text.Split
                pagar = Convert.ToDouble(valor(0)) / Convert.ToDouble(valor1(0))
            Else
                Dim valor() As String = nuevoadeudo.Text.Split
                pagar = Convert.ToDouble(valor(0)) / Convert.ToDouble(valor1(0))
            End If
            Dim idConvenio As Integer
            Dim cadenadecarga As String

            Try
                cadenadecarga = "Select idEncConvenio from EncConvenio where idcuenta =" & cuentatxt.Text
                Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                dr.Read()
                If Not IsDBNull(dr("idEncConvenio")) Then
                    idConvenio = dr("idEncConvenio")
                End If
                Dim pago As String
                'MsgBox(hoy)
                Dim valor2() As String = fecha.Text.Split
                Dim v As Integer = CInt(valor2(0))
                For i = 1 To CInt(valor1(0))
                    pago = "Pago" & i & "/" & pagos.Text

                    Try
                        Ejecucion("INSERT INTO otrosconceptos (Cuenta, Concepto, Total, Subtotal, IVA, Pagado, vencimiento, tabla, folio, Estado, Fec_apli, Fec_alta, fecha_baja, fecha_ult_camb, Resta, tipo_mov, MES_PERIODo, AN_PER,  SubTotResta, IVAResta, Id_Concepto) VALUES (" & cuentatxt.Text & ", '" & pago & "'," & pagar & ", 0, 0, " & False & ", '" & UnixDateFormat(fecha1.ToShortDateString) & "','todos', " & idConvenio & ",'pendiente', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', " & pagar & ", 'cargo', '" & NOMBREDEMES3CAR(hoy.Month) & "', " & Year(Now) & "," & pagar & ", 0, '" & My.Settings.claveConvenio & "')")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    fechaCalcular = fechaCalcular.AddDays(+v)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            consultaGrid()

        Else
            ButtonX1.Visible = True
            ButtonX2.Visible = True
            calcular()
            Dim fechaCalcular As Date = Date.Now
            Dim valor1() As String = pagos.Text.Split

            Dim pagar As Double
            If nuevoadeudo.Text = 0 Then
                Dim valor() As String = total.Text.Split
                pagar = Convert.ToDouble(valor(0)) / Convert.ToDouble(valor1(0))
            Else
                Dim valor() As String = nuevoadeudo.Text.Split
                pagar = Convert.ToDouble(valor(0)) / Convert.ToDouble(valor1(0))
            End If
            'MsgBox(monto)
            Dim idConvenio As Integer
            Dim cadenadecarga As String

            Try
                cadenadecarga = "select idEncConvenio from EncConvenio where idcuenta =" & cuentatxt.Text
                Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                dr.Read()
                If Not IsDBNull(dr("idEncConvenio")) Then
                    idConvenio = dr("idEncConvenio")
                End If
                Dim pago As String
                'MsgBox(hoy)
                Dim valor2() As String = fecha.Text.Split
                Dim v As Integer = CInt(valor2(0))
                For i = 1 To CInt(valor1(0))
                    pago = "Pago" & i & "/" & pagos.Text

                    Try
                        Ejecucion("INSERT INTO otrosconceptos (Cuenta, Concepto, Total, Subtotal, IVA, Pagado, vencimiento, tabla, folio, Estado, Fec_apli, Fec_alta, fecha_baja, fecha_ult_camb, Resta, tipo_mov, MES_PERIODo, AN_PER,  SubTotResta, IVAResta, Id_Concepto) VALUES (" & cuentatxt.Text & ", '" & pago & "'," & pagar & ", 0, 0, " & False & ", '" & UnixDateFormat(fechaCalcular.ToShortDateString) & "','todos'," & idConvenio & ",'pendiente', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', " & pagar & ", 'cargo', '" & NOMBREDEMES3CAR(hoy.Month) & "', " & Year(Now) & "," & pagar & ", 0, '" & My.Settings.claveConvenio & "')")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    fechaCalcular = fechaCalcular.AddDays(+v)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            consultaGrid()
        End If
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
            CONSULTA = "Select cuenta, vencimiento, concepto, round(total, 2) As monto, If (pagado= 0, ""No"", ""Si"") As Pagado FROM otrosconceptos where cuenta =" & cuentatxt.Text & " And id_concepto= '" & My.Settings.claveConvenio & "'"
            llenaGrid(dataConv, CONSULTA)
            dataConv.Columns("Cuenta").Width = 70
            dataConv.Columns("vencimiento").Width = 100
            dataConv.Columns("concepto").Width = 100
            dataConv.Columns("monto").Width = 100
            'dataConv.Columns("resta").Width = 100
            dataConv.Columns("Pagado").Width = 100
            dataConv.AllowUserToAddRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        validarSalida()
        If cuentatxt.Text = "" And pagos.Visible = False And fecha.Visible = False Then
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

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim l As New ListConvenios
        ConfirmarConvenio()
        l.llenargrid()
    End Sub
    Public Sub ConfirmarConvenio()

        If nuevoadeudo.Text <> 0 Then
            tablaModifConvenio()
            abrirAuto()

            Try
                Dim c As Integer
                c = Convert.ToInt16(cuentatxt.Text)
                Dim acceso As New Confirmacion
                acceso.metodo(c)
                If acceso.autorizacion = "cancelar" Then
                    'MsgBox("nada")
                    CancelarConvenio()
                Else
                    Ejecucion("update usuario set deudafec = '" & Now.Year - 1 & "/12/31" & "' where cuenta= " & cuentatxt.Text)
                    Ejecucion("update lecturas set pagado=1 where cuenta=" & cuentatxt.Text & " and an_per <" & Now.Year)
                    Ejecucion("update otrosconceptos set resta= 0, subtotresta=0,ivaresta=0,pagado=1, estado= 'Convenido' where cuenta= " & cuentatxt.Text & " and id_concepto <>'" & My.Settings.claveConvenio & "'")

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Domicilio.Text = ""
            cuentatxt.Text = ""
            nombre.Text = ""
            total.Text = ""
            cuentaAnte.Text = ""
            nuevoadeudo.Text = ""
            Comunidad.Text = ""
            Colonia.Text = ""
            pagos.Visible = False
            fecha.Visible = False
            BtnCalcular.Visible = False
            dataConv.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label9.Visible = False
            descuento.Text = 0
            ButtonX2.Visible = False
            ButtonX1.Visible = False
            TxtTel.Text = ""
            Label1.Visible = False
            Label3.Visible = False
            nuevoadeudo.Visible = False
            descuento.Visible = False
            ButtonX5.Visible = False

        ElseIf nuevoadeudo.Text = 0 Then
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

                Ejecucion("update usuario set deudafec = '" & Now.Year - 1 & "/12/31" & "' where cuenta= " & cuentatxt.Text)
                Ejecucion("update lecturas set pagado=1 where cuenta=" & cuentatxt.Text & " and an_per <" & Now.Year)
                Ejecucion("update otrosconceptos set resta= 0, subtotresta=0,ivaresta=0,pagado=1, estado= 'Convenido' where cuenta= " & cuentatxt.Text & " and id_concepto <>'" & My.Settings.claveConvenio & "'")
                Ejecucion("insert into ConvModif (cuenta, idConvenio, fecha, Usuario, TotalAnt, Justificacion) values (" & cuentatxt.Text & "," & idConvenio & ",'" & UnixDateFormat(hoy.ToShortDateString) & "','" & nombreUsu & "'," & total.Text & ",'SIN DESCUENTO')")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Tu convenio a sido guardado satisfactoriamente")
            Domicilio.Text = ""
            cuentatxt.Text = ""
            nombre.Text = ""
            total.Text = ""
            cuentaAnte.Text = ""
            nuevoadeudo.Text = ""
            Comunidad.Text = ""
            Colonia.Text = ""
            pagos.Visible = False
            fecha.Visible = False
            BtnCalcular.Visible = False
            dataConv.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            descuento.Text = 0
            ButtonX2.Visible = False
            ButtonX1.Visible = False
            TxtTel.Text = ""
            Label9.Visible = False
            Label1.Visible = False
            Label3.Visible = False
            nuevoadeudo.Visible = False
            descuento.Visible = False

        End If
    End Sub
    Public Sub abrirAuto()
        Dim acceso As New Confirmacion
        acceso.ShowDialog()
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        CancelarConvenio()
        ButtonX3.Enabled = True
    End Sub
    Public Sub CancelarConvenio()
        Try
            dataConv = New DataGridView
            dataConv.Rows.Clear()
        Catch ex As Exception

        End Try

        pagos.Text = 0
        fecha.Text = 0
        Dim cadenadecarga As String
        Dim idcuenta As Integer
        cadenadecarga = "select idcuenta from EncConvenio where idcuenta =" & cuentatxt.Text
        Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
        dr.Read()
        Try
            If Not IsDBNull(dr("idcuenta")) Then
                idcuenta = dr("idcuenta")
            End If

            Ejecucion("delete from ConvModif where cuenta=" & idcuenta)
            Ejecucion("update usuario set convenio= 0 where cuenta=" & idcuenta)
            Ejecucion("delete  From otrosconceptos Where cuenta= " & idcuenta & " and id_concepto ='" & My.Settings.claveConvenio & "'")
            Ejecucion("delete  From EncConvenio  Where idcuenta =" & idcuenta)

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
            pagos.Visible = False
            fecha.Visible = False
            BtnCalcular.Visible = False
            dataConv.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            descuento.Text = 0
            ButtonX2.Visible = False
            ButtonX1.Visible = False
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

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Dim ccon = New frmConvenio
        Dim Frm As New frmReporte(frmReporte.Lista.Convenio, "{vusuario1.cuenta} = " & cuentatxt.Text & " and {otrosconceptos1.Id_Concepto} = '" & My.Settings.claveConvenio & "'")
        Frm.MdiParent = My.Forms.MDIPrincipal
        Frm.Show()
        Frm.WindowState = FormWindowState.Maximized
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
    Public Sub cargardatos(cuenta As Integer, Optional ByVal permitiradelanto As Boolean = False) ' pueden o no estableces si quieren pagar efectivo por defecto es no

        Dim concepto As New Clsconcepto
        Dim dts As OdbcDataReader

        Dim basem As New base
        If My.Settings.CombodeCalles = "NO" Then
            dts = basem.consultasql("select usuario.cuenta, usuario.cuentaAnterior, usuario.NOMBRE,  usuario.domicilio AS `Direccion`, Comunidad, ubicacion, Colonia, deudafec, descripcion_cuota,  tarifa, idcuotavalvulista, observacion, nodemedidor ,usuario.idDescuento as id_Descuento, descuentos.nPctDsct as Porcentaje, descuentos.xDescrip, usuario.alcantarillado, usuario.Saneamiento, usuario.credito, cuotas.medido, ultimalectura(" & cuenta & ") as ultimalectura, estadotoma.mostrar,estadotoma.descripcion as estado from usuario as usuario inner join comunidades ON (comunidades.Id_comunidad = usuario.id_comunidad) inner join colonia ON (colonia.ID_COLONIA = usuario.ID_COLONIA) inner join cuotas ON (cuotas.id_tarifa = usuario.tarifa) inner join descuentos ON (usuario.idDescuento = descuentos.idDescuento) inner join estadotoma on (usuario.estado=estadotoma.clave)  where cuenta =" & cuenta & "  and cuotas.id_tarifa = usuario.tarifa ;")
        Else
            dts = basem.consultasql("select usuario.cuenta, usuario.cuentaAnterior, usuario.NOMBRE, CONCAT(CALLES.NOMBRE, "" "", usuario.numext,"" "" ,usuario.numint) AS `Direccion`, Comunidad, ubicacion, Colonia, deudafec, descripcion_cuota,  tarifa, idcuotavalvulista, observacion, nodemedidor ,usuario.idDescuento as id_Descuento, descuentos.nPctDsct as Porcentaje, descuentos.xDescrip, usuario.alcantarillado, usuario.Saneamiento, usuario.credito, cuotas.medido, ultimalectura(" & cuenta & ") as ultimalectura, estadotoma.mostrar,estadotoma.descripcion as estado from usuario as usuario inner join comunidades ON (comunidades.Id_comunidad = usuario.id_comunidad) inner join colonia ON (colonia.ID_COLONIA = usuario.ID_COLONIA) inner join cuotas ON (cuotas.id_tarifa = usuario.tarifa) inner join descuentos ON (usuario.idDescuento = descuentos.idDescuento) inner join estadotoma on (usuario.estado=estadotoma.clave) inner join calles on (usuario.id_Calle= calles.id_Calle) where cuenta =" & cuenta & "  and cuotas.id_tarifa = usuario.tarifa ;")
        End If

        dts.Read()

        If dts.RecordsAffected = 0 Then

        End If

        If Not IsDBNull(dts("cuentaAnterior")) Then
            cuentaAnte.Text = dts("cuentaAnterior")
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
        pagos.Text = 0
        fecha.Text = 0
        ButtonX1.Visible = False
        ButtonX2.Visible = False
        dataConv.DataSource = Nothing

        Try
            Control.Tarifa = dts(My.Settings.campousuariotarifa)
        Catch ex As Exception

        End Try
        Try
            Control.Fechainicio = dts("DEUDAFEC")
        Catch ex As Exception

        End Try
        Try
            Control.Fechafinal = Date.Parse(Now.Year & "-" & Now.Month & "-" & Now.Day)
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


        If dts("id_Descuento") > 0 Then

            ''------ Descuentos
            Try
                Control.descontartodoslosperiodosdeconsumo = True
            Catch ex As Exception

            End Try

            Try
                Control.periodoscondescuentodeconsumo = Month(Now)
            Catch ex As Exception

            End Try

            Try
                Control.descuentoaconsumo = dts("Porcentaje")
            Catch ex As Exception

            End Try

        End If

        If dts("id_Descuento") = 0 And Control.descuentoaconsumo > 0 Then

            Try
                Control.periodoscondescuentodeconsumo = 0
            Catch ex As Exception

            End Try

            Try
                Control.descuentoaconsumo = Control.descuentoaconsumo
            Catch ex As Exception

            End Try

        End If

        If dts("mostrar") = 0 Then

            MessageBox.Show("la cuenta tiene un estado que no puede cobrarse")

            basem.conexion.Dispose()
            Exit Sub

        End If
        Control.periodo = ""
        Try
            Control.calcula(False)
        Catch ex As Exception

        End Try
        Dim observalectura As String = ""
        If Control.Listadeconceptos.Count = 0 Then
            MsgBox("No cuenta con ningún adeudo")
            Domicilio.Text = ""
            cuentatxt.Text = ""
            nombre.Text = ""
            total.Text = 0
            cuentaAnte.Text = ""
            Comunidad.Text = ""
            Colonia.Text = ""
            pagos.Text = 0
            fecha.Text = 0
        Else
            Dim totald As Decimal
            totald = Control.totaldeudaconsumo + Control.totaldeudaalcantarillado + Control.totaldeudasaneamiento + Control.totaldeudarecargos + Control.totaldeudaotros + Control.totaldeudaiva
            total.Text = totald

        End If

        pagos.Text = 0
        fecha.Text = 0
        ButtonX1.Visible = False
        ButtonX2.Visible = False
        dataConv.DataSource = Nothing
        basem.conexion.Dispose()
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
            Dim cadenadecarga As String
            Dim idcuenta As Integer
            cadenadecarga = "select idcuenta from EncConvenio where idcuenta =" & cuentatxt.Text
            Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
            dr.Read()
            Try
                If Not IsDBNull(dr("idcuenta")) Then
                    idcuenta = dr("idcuenta")
                End If
                Ejecucion("update encconvenio set Telefono='" & TxtTel.Text & "' where idcuenta =" & idcuenta & "")
            Catch
            End Try
        End If

    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        Dim cadena As String
        Dim estado As String
        cadena = "select estado from otrosconceptos where cuenta =" & cuentatxt.Text & " and id_concepto='" & My.Settings.claveConvenio & "'"
        Dim dr1 As IDataReader = ConsultaSql(cadena).ExecuteReader()
        dr1.Read()
        estado = dr1("estado")
        If estado = "Aplicado" Then
            MsgBox("No se puede cancelar convenio")
        Else
            If MessageBoxEx.Show("¿Seguro que desea cancelar el convenio?", "Salir de Convenios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim cadenadecarga As String
                Dim idcuenta As Integer
                cadenadecarga = "select idcuenta from EncConvenio where idcuenta =" & cuentatxt.Text
                Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                dr.Read()
                Try
                    If Not IsDBNull(dr("idcuenta")) Then
                        idcuenta = dr("idcuenta")
                    End If
                    Ejecucion("update otrosconceptos set pagado= 0, resta= " & total.Text & ", subtotresta= " & total.Text & " where cuenta=" & idcuenta & " and id_concepto ='AANTE'")
                    Ejecucion("delete from ConvModif where cuenta=" & idcuenta)
                    Ejecucion("update usuario set convenio= 0 where cuenta=" & idcuenta)
                    Ejecucion("delete  From otrosconceptos Where cuenta= " & idcuenta & " and id_concepto ='" & My.Settings.claveConvenio & "'")
                    Ejecucion("delete  From EncConvenio  Where idcuenta =" & idcuenta)
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
                    pagos.Visible = False
                    fecha.Visible = False
                    BtnCalcular.Visible = False
                    dataConv.Visible = False
                    Label5.Visible = False
                    Label6.Visible = False
                    descuento.Text = 0
                    ButtonX2.Visible = False
                    ButtonX1.Visible = False
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
End Class