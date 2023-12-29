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
        Domicilio.Text = ""

        nombre.Text = ""


        Comunidad.Text = ""
        Colonia.Text = ""
        total.Text = "$0.00"
        Try
            If cuentaAnte.Text <> "" And cuentatxt.Text = "" Then ' para cuenta anterior
                cadenadecarga = "Select cuenta from usuario where ubicacion  ='" & cuentaAnte.Text & "'"
                Dim dr2 As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
                If dr2.Read() = True Then
                    cuentatxt.Text = dr2("cuenta")
                End If

            End If

            If cuentatxt.Text <> "" Then
                Dim c As Integer = Integer.Parse(cuentatxt.Text)
                cargardatos(c, False)
            End If
            total.Text = Control.totaldeudaconsumo + Control.totaldeudaalcantarillado + Control.totaldescuentorecargo + Control.totaldeudaotros
            nuevoadeudo.Text = total.Text
        Catch ex As Exception
            MsgBox("No existe registro")
            Domicilio.Text = ""
            cuentatxt.Text = ""
            nombre.Text = ""
            cuentaAnte.Text = ""
            total.Text = ""
            Comunidad.Text = ""
            Colonia.Text = ""

            fecha.Text = 0
            Try
                dataConv.Rows.Clear()
            Catch ex2 As Exception
                MsgBox(ex2.Message)
            End Try

        End Try
        If nodeperiodos <6 Then
            MessageBox.Show("El usuario debe solo " & Control.desgloseconsumo.Count + Control.desgloserezago.Count & " meses, No puedes convenir si el adeudo es menor a 6 meses")
        End If
        If nodeperiodos >= 6 Then
            cbnoperiodos.Items.Add(2)
            cbnoperiodos.Items.Add(3)
            cbnoperiodos.Items.Add(4)

        End If
        If nodeperiodos >= 12 Then

            cbnoperiodos.Items.Add(6)

        End If
        If nodeperiodos >= 24 Then

            cbnoperiodos.Items.Add(8)

        End If
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
                If nuevoadeudo.Text = "" Then
                    nuevoadeudo.Text = 0
                End If
                If nuevoadeudo.Text = "0" Then
                    MessageBoxEx.Show("No has ingresado el porcentaje de descuento, si es 0 solo presiona enter", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Try

                    If nuevoadeudo.Text <> 0 Then
                        Ejecucion("insert into encConvenio (idCuenta, Nombre, telefono,total, fechasolicitud, TotalOriginal) values(" & cuentatxt.Text & ",'" & nombre.Text & "','" & TxtTel.Text & "'," & nuevoadeudo.Text & ",'" & hoy.ToShortDateString & "'," & total.Text & ")")
                        idencconvenio = Integer.Parse(obtenerCampo("select idencconvenio from encconvenio where idcuenta=" & cuentatxt.Text & " order by idencconvenio desc limit 1", "idencconvenio"))
                    End If

                    Ejecucion("update usuario set convenio= '1' where cuenta=" & cuentatxt.Text)
                    Porcentajes()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                cbnoperiodos.Visible = True
                fecha.Visible = True
                BtnCalcular.Visible = True
                dataConv.Visible = True

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


            pago.calcula(False)
            lista.lista.Clear()
            DataGridViewX1.Rows.Clear()
            '' aqui desglozamos para poder calcular los montos de los pagos de convenio
            Dim primero As Boolean = True
            For i = 1 To Control.desgloserezago.Count
                Dim nodo As New mesescon
                Dim que As clsunidadmes = DirectCast(Control.desgloserezago(i), clsunidadmes)

                nodo.mes = que.mes
                nodo.iva = que.totaliva
                nodo.an_per = que.periodo
                nodo.consumo = que.total
                If primero Then
                    nodo.otros = Control.totaldeudaotros
                    nodo.iva = nodo.iva
                    primero = False
                End If

                For J = 1 To Control.desglosealcantarillado.Count
                    Dim queALCA As clsunidadmes = DirectCast(Control.desglosealcantarillado(J), clsunidadmes)
                    If queALCA.mes = nodo.mes And nodo.an_per = queALCA.periodo Then
                        nodo.alcantarillado = queALCA.total
                        nodo.iva = nodo.iva + queALCA.totaliva
                    End If

                Next

                For J = 1 To Control.desglosesaneamiento.Count
                    Dim quesane As clsunidadmes = DirectCast(Control.desglosesaneamiento(J), clsunidadmes)
                    If quesane.mes = nodo.mes And nodo.an_per = quesane.periodo Then
                        nodo.saneamiento = quesane.total
                        nodo.iva = nodo.iva + quesane.totaliva
                    End If

                Next

                For J = 1 To Control.desgloserecargo.Count
                    Dim quereca As clsunidadmes = DirectCast(Control.desgloserecargo(J), clsunidadmes)
                    If quereca.mes = nodo.mes And nodo.an_per = quereca.periodo Then
                        nodo.recargo = quereca.total

                    End If

                Next
                lista.lista.Add(nodo)
                DataGridViewX1.Rows.Add(nodo.mes, nodo.an_per, nodo.consumo, nodo.alcantarillado, nodo.saneamiento, nodo.recargo, nodo.otros, nodo.Total, nodo.iva)
            Next

            For i = 1 To Control.desgloseconsumo.Count
                Dim nodo As New mesescon
                Dim que As clsunidadmes = DirectCast(Control.desgloseconsumo(i), clsunidadmes)
                nodo.mes = que.mes
                nodo.an_per = que.periodo
                nodo.consumo = que.total
                nodo.iva = que.totaliva
                If primero Then
                    nodo.otros = Control.totaldeudaotros
                    nodo.iva = nodo.iva
                    primero = False
                End If

                For J = 1 To Control.desglosealcantarillado.Count
                    Dim queALCA As clsunidadmes = DirectCast(Control.desglosealcantarillado(J), clsunidadmes)
                    If queALCA.mes = nodo.mes And nodo.an_per = queALCA.periodo Then
                        nodo.alcantarillado = queALCA.total
                        nodo.iva = nodo.iva + queALCA.totaliva
                    End If

                Next

                For J = 1 To Control.desglosesaneamiento.Count
                    Dim quesane As clsunidadmes = DirectCast(Control.desglosesaneamiento(J), clsunidadmes)
                    If quesane.mes = nodo.mes And nodo.an_per = quesane.periodo Then
                        nodo.saneamiento = quesane.total
                        nodo.iva = nodo.iva + quesane.totaliva
                    End If

                Next

                For J = 1 To Control.desgloserecargo.Count
                    Dim quereca As clsunidadmes = DirectCast(Control.desgloserecargo(J), clsunidadmes)
                    If quereca.mes = nodo.mes And nodo.an_per = quereca.periodo Then
                        nodo.recargo = quereca.total

                    End If

                Next

                lista.lista.Add(nodo)


                DataGridViewX1.Rows.Add(nodo.mes, nodo.an_per, nodo.consumo, nodo.alcantarillado, nodo.saneamiento, nodo.recargo, nodo.otros, nodo.Total, nodo.iva)
            Next



            x.conexion.Dispose()
            Ejecucion("update encconvenio set porceConsumoActual= " & des.porceConsumoActual & ",porceConsumoRezago=" & des.porceConsumoRezago & ", porceAlcantarilladoActual=" & des.porceAlcantarilladoActual & ", porceAlcantarilladoRezago=" & des.porceAlcantarilladoRezago & ",  porceRecargosActual= " & des.porceRecargosActual & ",  porceRecargosRezago= " & des.porceRecargosRezago & ",  porceSaneamientoActual=" & des.porceSaneamientoActual & ", porceSaneamientoRezago=" & des.porceSaneamientoRezago & ", porceOtros= " & des.porceOtros & ", porceIva=" & des.porceIva & "  where idcuenta=" & cuentatxt.Text)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbnoperiodos.Visible = True
        fecha.Visible = False
        BtnCalcular.Visible = False
        dataConv.Visible = False

        Label6.Visible = False
        'descuento.Text = 0
        fecha.Text = 0
        cbnoperiodos.Text = ""
        ButtonX1.Visible = False

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
                cbnoperiodos.Enabled = False
                cbnoperiodos.Visible = True
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


        Try



            Porcentajes()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click






        If cbnoperiodos.Text = 0 Then
            MessageBoxEx.Show("Aún no meciona el número de pagos", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If cbnoperiodos.Text = "1" Then
            MessageBoxEx.Show("no hay convenio a un solo pago", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        If fecha.Text = 0 Then
            MessageBoxEx.Show("no hay puesto dias de aplazamiento", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Ejecucion("delete  From detconvenio  Where idencconvenio= " & idencconvenio)

        If Val(cbnoperiodos.Text) > 1 Then
            ButtonX1.Visible = True
            Buttoncerrar.Visible = True
            calcular()



            Dim adeudototal As Decimal = Decimal.Parse(nuevoadeudo.Text)
            Dim pago1 As Decimal = Decimal.Parse(iiprimerpago.Value)
            Dim adeudoatrabajar As Decimal = adeudototal - pago1

            Dim nudepago As Integer = Val(cbnoperiodos.Text)

            '' vamos a calcular cuantos meses pagara en cada pago

            Dim division = (Control.desgloserezago.Count + Control.desgloseconsumo.Count) \ nudepago

            '' con la dision entera veremos como distibuirlo en el nupago
            '' restemos el numero de meses totales - nudepago * division
            Dim resta As Integer = (Control.desgloserezago.Count + Control.desgloseconsumo.Count) - (division * nudepago)

            ' calculamos el numero de periodos en el primer pago 
            '

            Dim nodeperiodosapagarprimervuelta As Int16 = division + resta
            Dim periodosagar As Int16 = division



            'MsgBox(monto)
            Dim fechaCalcular As Date = Now



            Try

                Dim pago As String
                'MsgBox(hoy)
                Dim valor2() As String = fecha.Text.Split
                Dim contadordeperiodos As Int16 = 1
                Dim yapaselaprimeravuelta As Boolean = False
                Dim pagar As Decimal = 0
                Dim v As Integer = CInt(valor2(0))
                For i = 0 To lista.lista.Count - 1
                    If yapaselaprimeravuelta = False And contadordeperiodos < nodeperiodosapagarprimervuelta Then
                        pagar += lista.lista(i).Total

                    End If
                    If yapaselaprimeravuelta = False And contadordeperiodos = nodeperiodosapagarprimervuelta Then
                        pagar += lista.lista(i).Total
                        Try
                            pago = "pagar " & nodeperiodosapagarprimervuelta & " meses. Pagar hasta " & lista.lista(i).mes & " " & lista.lista(i).an_per
                            Ejecucion("INSERT INTO detconvenio (fecha,  Concepto, Monto, Estado, idencconvenio, cuenta,mesapagar,periodoapagar) VALUES ('" & UnixDateFormat(fechaCalcular.ToShortDateString) & "','" & pago & "'," & pagar & ",'Activo'," & idencconvenio & "," & cuentatxt.Text & ",'" & lista.lista(i).mes & "'," & lista.lista(i).an_per & ")")
                            fechaCalcular = fechaCalcular.AddDays(+v)
                            yapaselaprimeravuelta = True
                            contadordeperiodos = 0
                            pagar = 0
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If

                    If yapaselaprimeravuelta = True And contadordeperiodos > 0 And contadordeperiodos < periodosagar Then
                        pagar += lista.lista(i).Total

                    End If
                    If yapaselaprimeravuelta = True And contadordeperiodos > 0 And contadordeperiodos = periodosagar Then
                        pagar += lista.lista(i).Total
                        Try
                            pago = "pagar " & periodosagar & " meses. Pagar hasta " & lista.lista(i).mes & " " & lista.lista(i).an_per
                            Ejecucion("INSERT INTO detconvenio (fecha,  Concepto, Monto, Estado, idencconvenio, cuenta,mesapagar,periodoapagar) VALUES ('" & UnixDateFormat(fechaCalcular.ToShortDateString) & "','" & pago & "'," & pagar & ",'Activo'," & idencconvenio & "," & cuentatxt.Text & ",'" & lista.lista(i).mes & "'," & lista.lista(i).an_per & ")")
                            fechaCalcular = fechaCalcular.AddDays(+v)
                            pagar = 0
                            contadordeperiodos = 0
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If


                    contadordeperiodos += 1

                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        consultaGrid()

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
        If cuentatxt.Text = "" And cbnoperiodos.Visible = False And fecha.Visible = False Then
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
            cbnoperiodos.Visible = False
            fecha.Visible = False
            BtnCalcular.Visible = False
            dataConv.Visible = False

            Label6.Visible = False
            Label9.Visible = False
            descuento.Text = 0

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
            cbnoperiodos.Visible = False
            fecha.Visible = False
            BtnCalcular.Visible = False
            dataConv.Visible = False

            Label6.Visible = False
            descuento.Text = 0
            Buttoncerrar.Visible = False
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

        cbnoperiodos.Text = "0"
        fecha.Text = 0




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
            cbnoperiodos.Visible = True
            fecha.Visible = False
            BtnCalcular.Visible = False
            dataConv.Visible = False

            Label6.Visible = False
            descuento.Text = 0

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
        Dim conve As New Convenio
        conve.GenerarConvenio(idencconvenio)
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
        cbnoperiodos.Text = "0"
        fecha.Text = 0
        ButtonX1.Visible = False

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
            cbnoperiodos.Text = "0"
            fecha.Text = 0
            nodeperiodos = 0
        Else
            Dim totald As Decimal
            totald = Control.totaldeudaconsumo + Control.totaldeudaalcantarillado + Control.totaldeudasaneamiento + Control.totaldeudarecargos + Control.totaldeudaotros + Control.totaldeudaiva
            total.Text = totald
            nodeperiodos = Control.desgloserezago.Count()
        End If

        cbnoperiodos.Text = "0"
        fecha.Text = 0
        ButtonX1.Visible = False

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
                    cbnoperiodos.Visible = True
                    fecha.Visible = False
                    BtnCalcular.Visible = False
                    dataConv.Visible = False

                    Label6.Visible = False
                    descuento.Text = 0

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