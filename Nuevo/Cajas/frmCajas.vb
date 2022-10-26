Public Class frmCajas
    Public OPC As Integer
    Dim CONSULTA, CONSULTA2, CONSULTA3, D_PERIODOFACTURADO, D_COMUNIDADES, D_REZAGO As IDataReader
    Dim DID_COMUNIDAD As String
    Public D_COMUNIDAD As String
    Public siimprime As Boolean

#Region "Variables"
    Dim Descu, tdescuento As Double
    Dim PiniMes As String = "", PiniAn As String = ""
    Dim PFinMes As String = "", PFinAn As String = ""
    Dim IvAnti As Double, Tar As String = ""
    Dim clrecibo As New Clsrecibo
    Dim ConsumoAnti, AlcaAnti, SaneaAnti, IvaAnti As Double
    Dim MesesAnti As Integer
    Dim Convenio As Boolean
    Dim Vista As DataView
    Dim Fil As New BindingSource
    Dim VisSol As DataView
    Dim FilSol As New BindingSource
    Dim Ubicacion As String, Medidor As String, idComu As String
    Dim _ID_CROAPE As String, RemSistema As Boolean = True, Calcular As Boolean = False
    Public VieneApertura As Boolean = False
    Dim RRezago, RConsumo, RAlcanta, RSanea, RRecargos, RAnti, ROtros, RRecaOtros, RDescuento, RRedondeo As Double
    'Dim clrecibo As New Clsrecibo
    Dim RSubTot, RIva, RTotal, RFacti As Double
    Dim Conce As Collection
    Dim idUsu As IDataReader
    Dim idPag As IDataReader
    Public Shared recibo As Double = 0
    Public Shared porDesc As Int16 = 0
    Public Shared _serie As Char = ""
    Public Shared _cod_ofi As String = " "
    Public Shared _caja As String
    Public Shared _ope As Integer = 0
    Public Shared _fol_ini As Double = 0
    Public Shared _fol_fin As Double = 0
    Public Shared _sal_ini As Double = 0
    Public Shared _fec_ape As Date
    Public Shared _ing_tot As Double = 0
    Public Shared _num_ope As Integer
    Public Tipo_Caja As String
    Public cap_recibo As Boolean
    Public Shared porce As Double
#End Region

    Private Sub cmdExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExt.Click
        Me.Close()
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmCajas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.TabCajas.Select()
        'ComboRob1.Desplegar(0)
    End Sub

        Private Sub frmCajas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyAscii As Keys = e.KeyData
        Dim s As Object = Nothing, e1 As System.EventArgs = Nothing
        Select Case keyAscii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.F5
                'If Mes() = 12 And Anio() = Year(Now) Then
                '    llenatotanti(Mes, Anio)
                'Else
                '    llenatot(Mes, Anio)
                'End If
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

#Region "Carga caja"
    Private Sub frmCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbComu, "select id_comunidad,comunidad from comunidades order by comunidad")
        llenarCombo(CmbComunidad, "select id_comunidad,comunidad from comunidades order by comunidad")
        llenarCombo(CmbFormaPago, "Select ccodpago, cdespago from fpago order by cdespago")
        If VieneApertura = True Then
            recibo = _fol_ini
        Else
            recibo = _fol_ini + 1
        End If
        LblRecibo.Text = recibo
        LblSerie.Text = _serie
        'LblFecha.Text = Now.Day & " / " & UCase(MonthName(Now.Month)) & " / " & Now.Year
        DTFecha.Value = Now
        LblCaja.Text = "OFICINA: " & obtenerCampo("Select nombre from oficinas where cod_ofi = '" & _cod_ofi & "'", "nombre") & "  CAJA: " & obtenerCampo("Select descripcion from cajas where id_caja = '" & _caja & "' and cod_ofi = '" & _cod_ofi & "'", "descripcion")
        NumCaja = _caja
        Oficina = _cod_ofi
        If siimprime = True Then
            txtCuenta.Select()
        Else
            cmbComu.Text = D_COMUNIDAD
        End If
        _ID_CROAPE = _cod_ofi & "-" & _caja & "-" & _serie & "-" & UnixDateFormat(Now.Date)
        'CmbPeriodos.Text = UCase(MonthName(Now.Month, True)) & " " & Now.Year
        'ActualizaVista()
        ExBus.Expanded = False
        Dim fecha, today As Date
        Dim tabla As String
        tabla = obtenerCampo("SELECT * FROM empresa", "fecha_des")
        fecha = tabla
        today = ConvertDate(Now)
    End Sub
#End Region

#Region "Llena periodos"

    Private Sub LlenaPeriodos(ByVal cuenta As Double, ByVal comu As String)
        Dim Mesini As Int16, Anini As Int16, Fec_Ini As Date, FechaFin As Date
        Dim MesFin As Int16, Anfin As Int16
        Dim Sinp As Boolean
        Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & comu & "'", "id_comunidad")
        Dim an_pago As Integer = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and anticipo>0  and cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "ano_fin")
        Dim mespago As String = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and anticipo>0 and cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "per_fin")
        Dim mesp As Integer
        mesp = NumeroMes(mespago)
        Mesini = mesp + 1
        Anini = an_pago
        Dim Per As IDataReader
        Per = ConsultaSql("Select mes_periodo, an_per, valornummes(mes_periodo, an_per) as ordenado from estados where cuenta = " & cuenta & " and id_comunidad = '" & Com & "' and pagado = 0 order by ordenado asc limit 1").ExecuteReader
        CmbPeriodos.Items.Clear()
        If Per.Read Then
            Mesini = NumeroMes(Per("mes_periodo"))
            Anini = Per("an_per")
            Sinp = True
        Else
            'If Mesini = 0 Then
            '    Sinp = False
            '    Dim Per2 As IDataReader
            '    Per2 = ConsultaSql("Select mes_periodo, an_per, valornummes(mes_periodo, an_per) as ordenado from estados where cuenta = " & cuenta & " and id_comunidad = '" & Com & "' and ultimo= 1 order by ordenado asc limit 1").ExecuteReader
            '    If Per2.Read Then
            '        Mesini = NumeroMes(Per2("mes_periodo")) + 1
            '        Anini = Per2("an_per")
            '    End If
            'End If
            an_pago = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "ano_fin")
            mespago = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "per_fin")
            mesp = NumeroMes(mespago)
            Mesini = mesp + 1
            Anini = an_pago
            If Mesini > 12 Then
                Mesini = 1
                Anini = an_pago + 1
            End If
            If mesp = 12 And an_pago = Year(Now) Then
                Mesini = 12
                Anini = Year(Now)
                MessageBox.Show("Existe un pago que esta cubriendo todo el año")
            End If
            If mesp = 0 And an_pago = 0 Then
                Dim siesta As IDataReader
                siesta = ConsultaSql("Select mes_periodo, an_per from estados where cuenta = " & cuenta & " and id_comunidad = '" & Com & "' and ultimo = 1").ExecuteReader
                If siesta.Read Then
                    Mesini = NumeroMes(siesta("mes_periodo")) + 1
                    Anini = siesta("an_per")
                    If Mesini > 12 Then
                        Mesini = 1
                        Anini += 1
                    End If
                Else
                    Mesini = Month(Now)
                    Anini = Year(Now)
                End If
            End If
        End If
        'If mesp > Mesini And Now.Year = an_pago Then Mesini = mesp + 1
        If Mesini > 12 And Anini = Now.Year - 1 Then
            Mesini = 1
            Anini = Now.Year
            ' If Anini < an_pago Then Anini = an_pago
        End If
        If Mesini = 1 And Anini = 0 Then
            an_pago = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "ano_fin")
            mespago = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "per_fin")
            mesp = NumeroMes(mespago)
            Mesini = mesp + 1
            Anini = an_pago
            If Mesini > 12 Then
                Mesini = 1
                Anini = an_pago + 1
            End If
        End If
        If Mesini = 0 And Anini = 0 Then
            Mesini = Now.Month
            Anini = Now.Year
        End If
        Fec_Ini = CDate("01/" & Mesini & "/" & Anini)
        'Per = ConsultaSql("Select mes_periodo, an_per, valornummes(mes_periodo, an_per) as ordenado from estados where cuenta = " & cuenta & " and id_comunidad = '" & Com & "' and pagado = 0 order by ordenado desc limit 1").ExecuteReader
        'If Per.Read Then
        'MesFin = NumeroMes(Per("mes_periodo"))
        'Anfin = Per("an_per")
        'Sinp = True
        'Else
        MesFin = Now.Month
        Anfin = Now.Year
        'Sinp = False
        'End If
        'aqui checo si tiene anticipo ya no lleno el combo

        Dim ChkAnti As IDataReader = ConsultaSql("Select concepto from otrosconceptos where concepto = 'Anticipo' and cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and pagado = 0 and estado <> 'Cancelado' ").ExecuteReader
        If ChkAnti.Read Then
            FechaFin = CDate("01/12/" & Anfin)
            Sinp = True
            'If Mes() = 12 And Anio() = Year(Now) Then Fec_Ini = CDate("01/01/" & Now.Year)
        Else
            ' If Mes() = 12 And Anio() = Year(Now) Then
            FechaFin = CDate("01/12/" & Now.Year)
            Sinp = True
            'Else
            'FechaFin = CDate("01/12/" & Now.Year)
            ' Fec_Ini = CDate("01/" & Now.Month & "/" & Now.Year)
            ' Sinp = True
            ' End If
        End If

        'If Sinp = False Then Exit Sub
        Do While Fec_Ini <= FechaFin
            CmbPeriodos.Items.Add(UCase(MonthName(Fec_Ini.Month, True)) & " " & Fec_Ini.Year)
            Fec_Ini = DateAdd(DateInterval.Month, 1, Fec_Ini)
        Loop
        'If Mes() = 12 And Anio() = Year(Now) Then
        '    Dim an, month As String
        '    an = obtenerCampo("Select * from estados where cuenta = " & cuenta & " and id_comunidad = '" & Com & "' and pagado = 0 and ultimo=1 ", "an_per")
        '    month = obtenerCampo("Select * from estados where cuenta = " & cuenta & " and id_comunidad = '" & Com & "' and pagado = 0 and ultimo=1 ", "mes_periodo")
        '    If an = "0" Then
        '        CmbPeriodos.Text = ""
        '    Else
        '        CmbPeriodos.Text = month(Mes) & " " & an
        '    End If
        'Else
        'CmbPeriodos.Text = MonthName(MesFin, True) & " " & Anfin
        'End If
    End Sub

#End Region

#Region "llena datos generales del usuario"
    Private Sub llenarDatos(ByVal cuenta As Double, ByVal comu As String)
        Convenio = False
        If RBFactibilidades.Checked = True Then
            idUsu = ConsultaSql("select pagfac, estado, nombre, colonia, comunidad, num_int, num_ext, cp, rfc, calle from vsolicitud where numero=" & cuenta & "").ExecuteReader()
            If idUsu.Read() Then
                If idUsu("pagfac") = "s" Then
                    MessageBoxEx.Show("La factibilidad ya fue pagada, verifique sus datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    Exit Sub
                Else
                    Calcular = False
                    ChkConsumo.Checked = False
                    chkOtros.Checked = False
                    ChkConsumo.Visible = False
                    chkOtros.Visible = False
                    CmbPeriodos.Visible = False
                    ComboRob1.Visible = False
                    Calcular = True
                    If idUsu("estado") <> "PENDIENTE" Then
                        MessageBoxEx.Show("La factibilidad ya fue procesada, verifique sus datos", "Factibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiar()
                        Exit Sub
                    End If
                    txtNombre.Text = idUsu("nombre")
                    txtCol.Text = idUsu("Colonia")
                    txtCom.Text = idUsu("comunidad")
                    txtNumInt.Text = idUsu("num_int")
                    txtNumExt.Text = idUsu("num_ext")
                    txtCp.Text = idUsu("cp")
                    txtRfc.Text = idUsu("rfc")
                    txtCalle.Text = idUsu("calle")
                End If
            Else
                MessageBoxEx.Show("Solicitud no encontrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf RBUsuarios.Checked = True Then
            idUsu = ConsultaSql("select id_comunidad, nodemedidor, sector, ruta, manzana, lote, region, lecturaact, lecturaant, dirfis, datosfis1, datosfis2, datosfis3, datosfis4, estado, nombre, colonia, comunidad, numint, numext, cp, rfc, descripcion_cuota, calle, tarifa, convenio from vusuario where cuenta=" & txtCuenta.Text & " and comunidad='" & comu & "'").ExecuteReader()
            If idUsu.Read() Then
                CmbPeriodos.Visible = True
                Calcular = False
                ChkConsumo.Visible = True
                ChkConsumo.Checked = True
                If UCase(idUsu("estado")) <> "ACTIVO" Then
                    ChkConsumo.Checked = False
                    CmbPeriodos.Visible = False
                    ChkConsumo.Visible = False
                End If
                Calcular = True
                txtNombre.Text = idUsu("nombre")
                txtCol.Text = idUsu("Colonia")
                txtCom.Text = idUsu("comunidad")
                txtNumInt.Text = idUsu("numint")
                txtNumExt.Text = idUsu("numext")
                txtCp.Text = idUsu("cp")
                txtRfc.Text = idUsu("rfc")
                txtTarifa.Text = idUsu("descripcion_cuota")
                Tar = idUsu("tarifa")
                txtCalle.Text = idUsu("calle")
                TxtLecActual.Text = idUsu("lecturaAct")
                TxtLecAnterior.Text = idUsu("lecturaAnt")
                idComu = idUsu("id_comunidad")
                Medidor = idUsu("nodemedidor")
                If CBool(idUsu("dirfis")) Then
                    ChkDirFis.Checked = True
                Else
                    ChkDirFis.Checked = False
                End If
                lblDirFis1.Text = idUsu("datosfis1")
                lblDirFis2.Text = idUsu("datosfis2")
                LblDirFis3.Text = idUsu("datosfis3")
                LblDirFis4.Text = idUsu("datosfis4")

                Ubicacion = idUsu("region") & "-" & idUsu("ruta") & "-" & idUsu("manzana") & "-" & idUsu("lote")
                If CBool(idUsu("convenio")) = True Then
                    MessageBoxEx.Show("El usuario tiene un convenio por realizar, para proceder debera pagar el anticipo del convenio", "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Convenio = True
                End If

                D_COMUNIDADES = ConsultaSql("SELECT * FROM COMUNIDADES WHERE COMUNIDAD='" & Trim(cmbComu.Text) & "'").ExecuteReader
                If D_COMUNIDADES.Read() Then
                    If Convenio <> True Then
                        LlenaPeriodos(cuenta, comu)
                        ComboRob1.cadsql = "select clave as Clave, concepto as Concepto, Resta as Resta, tipo_mov as Tipo, IvaResta as Iva, SubtotResta as Subtot, vencimiento, Tabla, motivo, TotRec, id_concepto from otrosconceptos where cuenta=" & txtCuenta.Text & " and ID_COMUNIDAD='" & Trim(D_COMUNIDADES("ID_COMUNIDAD")) & "' and pagado=False and estado<>'Cancelado' and concepto <> 'Anticipo'" 'and resta>0 
                    Else
                        ComboRob1.cadsql = "select clave as Clave, concepto as Concepto, Resta as Resta, tipo_mov as Tipo, IvaResta as Iva, SubtotResta as Subtot, vencimiento, Tabla, motivo, TotRec, id_concepto from otrosconceptos where cuenta=" & txtCuenta.Text & " and ID_COMUNIDAD='" & Trim(D_COMUNIDADES("ID_COMUNIDAD")) & "' and pagado=False and estado<>'Cancelado' and concepto='ANTICIPO DE CONVENIO'" 'and resta>0
                    End If
                End If

        Else
            MessageBoxEx.Show("Usuario no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ElseIf RBNoPadron.Checked = True Then
            idUsu = ConsultaSql("select nombre, colonia, comunidad, numint, numext, cp, rfc, direccion from nousuarios where clave = " & cuenta & " ").ExecuteReader()
            If idUsu.Read() Then
                txtNombre.Text = idUsu("nombre")
                txtCol.Text = idUsu("Colonia")
                txtCom.Text = idUsu("comunidad")
                txtNumInt.Text = idUsu("numint")
                txtNumExt.Text = idUsu("numext")
                txtCp.Text = idUsu("cp")
                txtRfc.Text = idUsu("rfc")
                txtCalle.Text = idUsu("Direccion")
                chkOtros.Checked = False
            Else
                MessageBoxEx.Show("Persona o empresa no encontrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

#End Region

#Region "Llena datos monetarios"
    Public Sub llenatot(Optional ByVal mes As Int32 = 0, Optional ByVal ani As Int16 = 0)
        If Calcular = False Then Exit Sub
        PiniMes = ""
        PiniAn = "0"
        PFinMes = ""
        PFinAn = "0"
        txtPer.Text = ""
        MesesAnti = 0
        TxtRedondeo.Text = FormatCurrency(0, 2)
        clrecibo.limpiar()
        clrecibo.aplicaconsumo = ChkConsumo.Checked
        clrecibo.aplicaotros = chkOtros.Checked
        clrecibo.redondear = ChkRedondeo.Checked
        RRezago = 0
        RConsumo = 0
        RAlcanta = 0
        RSanea = 0
        RRecargos = 0
        RAnti = 0
        ROtros = 0
        RRecaOtros = 0
        RDescuento = 0
        RRedondeo = 0
        RSubTot = 0
        RIva = 0
        RTotal = 0
        RFacti = 0
        Conce = New Collection
        If RBNoPadron.Checked = True Then
            clrecibo.limpiar()
            ChkRedondeo.Checked = False
            Dim Subtot, Iva, Tot As Double
            RemSistema = True
            For r = 1 To dgCob.RowCount
                Try
                    dgCob.Rows.Remove(dgCob.CurrentRow)
                Catch
                End Try
            Next
            RemSistema = False
            Dim rs As IDataReader
            rs = ConsultaSql("select id_concepto,concepto, subtotal, iva, total from conceptosnousuario where nousuario=" & CmbNousuarios.SelectedValue.ToString & "").ExecuteReader
            Do While rs.Read
                'If rs.RecordsAffected = 2 Then Stop
                dgCob.Rows.Add(rs("id_concepto"), "Cargo", 1, rs("concepto"), rs("subtotal"), 0, rs("iva"), rs("total"))
                'Conce.Add(New ConceptosCaja(0, "Cargo", 1, rs("concepto"), rs("Subtotal"), 0, rs("iva"), rs("total"), "NoUsuario"))
                Subtot += rs("subtotal")
                Iva += rs("iva")
                Tot += rs("total")
                'If dgCob.RowCount = 2 Then Stop
            Loop
            clrecibo.aplicaotros = True
            clrecibo.redondear = False
            clrecibo.aplicaconsumo = False
            clrecibo.otros = Subtot
            clrecibo.IVA = Iva
            clrecibo.Total = clrecibo.Total
            dgCob.Enabled = False
            ChkRedondeo.Checked = False
            ' clrecibo.redondear = False
            'txtSubTot.Text = FormatCurrency(Subtot, 2)
            txtSubTot.Text = clrecibo.Subtotal
            'txtIva.Text = FormatCurrency(Iva, 2)
            txtIva.Text = clrecibo.IVA
            'txtTotal.Text = FormatCurrency(Tot, 2)
            txtTotal.Text = FormatCurrency(clrecibo.Total, 2)
            txtOtros.Text = clrecibo.otros
            RSubTot = Subtot
            RIva = Iva
            RTotal = Tot

        ElseIf RBUsuarios.Checked = True Then
            Descu = 0 ' ASIGNACION EN CERO DESCUENTO
            Dim mess As String = ""
            Dim otros, ivotr, RecOtros As Double 'Descu
            Dim i As Int16
            Dim AlgOtros As Boolean = False, AlgCon As Boolean = False
            If Convenio = True Then
                PanFactibilidad.Visible = False
                PanUsuarios.Visible = False
                ChkConsumo.Visible = False
                chkOtros.Visible = False
                CmbPeriodos.Visible = False
                ComboRob1.Visible = False
                Calcular = False
                ChkConsumo.Checked = False
                chkOtros.Checked = True
                ChkRedondeo.Checked = False
                ChkRedondeo.Visible = False
                ckarriba.Visible = False
                Calcular = True
                Dim rs As IDataReader = ConsultaSql("Select subtotResta, Ivaresta, resta from otrosconceptos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and concepto = 'ANTICIPO DE CONVENIO' and abonos = 0 and estado = 'Pendiente'").ExecuteReader
                rs.Read()
                clrecibo.otros = rs("SubtotResta")
                clrecibo.IVA = rs("IVAResta")
                clrecibo.aplicaconsumo = False
                clrecibo.aplicaotros = True
                txtSubTot.Text = FormatCurrency(clrecibo.Subtotal, 2)

                txtIva.Text = FormatCurrency(clrecibo.IVA, 2)
                'txtTotal.Text = FormatCurrency(rs("resta"), 2)
                txtTotal.Text = FormatCurrency(clrecibo.Total, 2)
                RSubTot = clrecibo.Subtotal
                RIva = clrecibo.IVA
                RTotal = clrecibo.Total
            Else

                If chkOtros.Checked = True Then
                    For i = 0 To dgCob.Rows.Count - 1
                        If dgCob.Item(1, i).Value = "Cargo" Then
                            otros += dgCob.Item("subTot", i).Value
                            ivotr += dgCob.Item("iva", i).Value
                            RecOtros += dgCob.Item("Recargos", i).Value
                        Else
                            Descu += dgCob.Item("Total", i).Value
                        End If
                        AlgOtros = True
                        'clrecibo.aplicaotros = True
                        'Conce.Add(New ConceptosCaja(dgCob.Item("clave", i).Value, dgCob.Item("Tipo", i).Value, dgCob.Item("cantidad", i).Value, dgCob.Item("concepto", i).Value, dgCob.Item("resta", i).Value, dgCob.Item("recargos", i).Value, dgCob.Item("iva", i).Value, dgCob.Item("total", i).Value, dgCob.Item("tabla", i).Value))
                    Next
                    clrecibo.otros = otros
                    clrecibo.IVA = ivotr
                    clrecibo.descuento = Descu
                    clrecibo.recargosotros = RecOtros
                    If Descu > 0 Then
                        txtDescu.Text = Descu
                    End If
                    txtDescu.Text = FormatCurrency(Descu, 2)
                    RDescuento = Descu
                End If
                Dim IvCon As Double
                If ChkConsumo.Checked = True Then
                    Dim fecha, today As Date
                    Dim tabla As String
                    tabla = obtenerCampo("SELECT * FROM empresa", "fecha_des")
                    fecha = tabla
                    today = CDate(Now)
                    'SACA EL DESCUENTO DE EMPRESA
                    Dim DES As Double
                    DES = obtenerCampo("select * from empresa", "porc_des") / 100
                    If mes = 0 Then
                        GoTo SalirConsumos
                    End If
                    mess = UCase(MonthName(mes, True))
                    Dim Consumo, Alcanta, Sanea, Rezago, Anti As Double
                    idPag = ConsultaSql("select reca_acu_total, Consumo-(((Consumo / TOTALCONSUMO(CUENTA,ID_COMUNIDAD,MES_PERIODO,AN_PER)) * ANTICIPO)) as consumo, drenaje-(((drenaje /  TOTALCONSUMO(CUENTA,ID_COMUNIDAD,MES_PERIODO,AN_PER)) * ANTICIPO)) as drenaje ,ANTICIPO, descuento, iva-(((iva /  TOTALCONSUMO(CUENTA,ID_COMUNIDAD,MES_PERIODO,AN_PER)) * ANTICIPO)) AS IVA, total_a_hoy, mes_periodo, an_per,per_ini, ano_ini,per_fin, saneamiento-(((saneamiento /  TOTALCONSUMO(CUENTA,ID_COMUNIDAD,MES_PERIODO,AN_PER)) * ANTICIPO)) as saneamiento,an_fin, valornummes(mes_periodo, an_per) as ordenado, ultimo from estados where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and pagado=0 order by ordenado asc").ExecuteReader()
                    Do While idPag.Read()
                        If PiniAn = "0" Then PiniAn = idPag("an_per")
                        If PiniMes = "" Then PiniMes = idPag("mes_periodo")
                        PFinMes = idPag("mes_periodo")
                        PFinAn = idPag("an_per")
                        If idPag("ultimo") = 1 Then 'UCase(idPag("mes_periodo")) = UCase(MonthName(Month(DateAdd(DateInterval.Month, -1, Now)), True)) And idPag("an_per") = DateAdd(DateInterval.Month, -1, Now).Year Then
                            Consumo = idPag("Consumo")
                            clrecibo.Consumo = Consumo
                            Alcanta = idPag("drenaje")
                            clrecibo.Alcantarillado = Alcanta
                            Sanea = idPag("Saneamiento")
                            clrecibo.Saneamiento = Sanea
                            IvCon += idPag("iva")
                            clrecibo.IVA = IvCon
                            'If idPag("Anticipo") > 0 Then
                            '    txtDescu.Text = FormatCurrency(idPag("Anticipo"), 2)
                            '    Descu = idPag("ANTICIPO")
                            'End If
                        Else
                            Rezago += idPag("Consumo") + idPag("drenaje") + idPag("Saneamiento")
                            clrecibo.rezagos = Rezago
                            IvCon += idPag("iva")
                            clrecibo.IVA = IvCon
                        End If
                        AlgCon = True
                        clrecibo.aplicaconsumo = True
                        If UCase(idPag("mes_periodo")) = UCase(MonthName(mes, True)) And ani = idPag("an_per") Then Exit Do
                    Loop
                    Dim recatxt As Double = FormatCurrency(obtenerCampo("select acumularecargos('" & UCase(MonthName(mes, True)) & "'," & ani & ",'" & cmbComu.SelectedValue.ToString & "'," & txtCuenta.Text & ") as Reca", "Reca"), 2)
                    txtReca.Text = FormatCurrency(recatxt, 2)
                    clrecibo.recargos = recatxt

                    'Aqui calculo el anticipo
                    'Aqui calculo el anticipo
                    'Aqui calculo el anticipo
                    'Aqui calculo el anticipo
                    'Aqui calculo el anticipo
                    ' If UltimoDia(CDate("01/" & mes & "/" & ani)) > CDate("01/" & Now.Month & "/" & Now.Year) Then
                    'Dim ChkAnti As IDataReader = ConsultaSql("Select concepto from otrosconceptos where concepto = 'Anticipo' and cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and pagado = 0 and estado <> 'Cancelado' ").ExecuteReader
                    'If ChkAnti.Read Then
                    'aqui va si ya tiene un anticipo, solo hay que agregarlo
                    'MessageBoxEx.Show("Ya existe un anticipo para esta cuenta, espere a que sea aplicado en su totalidad para poder realizar otro", "Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '
                    '
                    'Anti = 0
                    'IvAnti = 0
                    'MesesAnti = 0
                    'Else
                    'If PiniMes = "" Then
                    'PiniMes = UCase(MonthName(Now.Month, True))
                    'End If
                    'If PiniAn = "0" Then
                    'PiniAn = Now.Year
                    'End If
                    PiniMes = Mid(CmbPeriodos.Items.Item(0), 1, 3)
                    PiniAn = Mid(CmbPeriodos.Items.Item(0), 5, 4)
                    PFinMes = Mid(CmbPeriodos.Text, 1, 3) 'UCase(MonthName(dt1.Value.Month, True))
                    PFinAn = Mid(CmbPeriodos.Text, 5, 4) 'dt1.Value.Year

                    'Dim AplAnti As IDataReader = ConsultaSql("Select mes_periodo from estados where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and mes_periodo = '" & MonthName(Now.Month, True) & "' and an_per = " & Now.Year & " ").ExecuteReader
                    Dim AplAnti As IDataReader = ConsultaSql("Select mes_periodo from estados where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and mes_periodo = '" & PFinMes & "' and an_per = " & PFinAn & " ").ExecuteReader
                    Dim MesAnticipo As Integer

                    Dim mesta As String = obtenerCampo("select * from estados where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and ultimo=1", "mes_periodo")
                    Dim anesta As Integer = obtenerCampo("select * from estados where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and ultimo=1", "an_per")
                    Dim mespago As String = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and Cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "per_fin")
                    Dim annopago As String = obtenerCampo("select * from pagos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and Cancelado='A' order by fecha_act+VALORNUMMES(PER_FIN,ANO_FIN) DESC limit 1", "ano_fin") 'yo la adicione
                    'Dim mesesp As Integer
                    If AplAnti.Read Then
                        MesAnticipo = 0
                    Else
                        'MesAnticipo = DateDiff(DateInterval.Month, Now, CDate("01/" & mes & "/" & ani)) + 1
                        'If annopago <> Year(Now) And mespago = "DIC" Then
                        '    MesAnticipo = DateDiff(DateInterval.Month, CDate("01/" & NumeroMes(mespago) & "/" & annopago), CDate("01/" & mes & "/" & ani)) + 1
                        'Else
                        Dim tmpestados As IDataReader
                        tmpestados = ConsultaSql("select mes_periodo,an_per,valornummes(mes_periodo,an_per) as ordenado from estados where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and pagado=0 and ultimo=1 order by ordenado desc limit 1").ExecuteReader()
                        Dim siesta As Boolean
                        If tmpestados.Read Then
                            siesta = True
                        Else
                            siesta = False
                        End If
                        If (NumeroMes(mespago) = 0 And annopago = 0) Or siesta Then
                            If siesta Then
                                Dim mesesta, anoesta, incrementa As Integer
                                mesesta = NumeroMes(tmpestados("mes_periodo")) + 1
                                anoesta = tmpestados("an_per")
                                If mesesta > 12 Then
                                    mesesta = 1
                                    anoesta += 1
                                    incrementa = 1
                                Else
                                    incrementa = 0
                                End If
                                MesAnticipo = DateDiff(DateInterval.Month, CDate("01/" & mesesta & "/" & anoesta), CDate("01/" & mes & "/" & ani)) + incrementa
                            Else
                                If (mesta = "DIC" And anesta = Year(Now) - 1) Or (NumeroMes(mesta) = 0 And anesta = 0) Then
                                    MesAnticipo = DateDiff(DateInterval.Month, CDate("01/" & Month(Now) & "/" & Year(Now)), CDate("01/" & mes & "/" & ani)) + 1
                                Else
                                    MesAnticipo = DateDiff(DateInterval.Month, CDate("01/" & Month(Now) & "/" & Year(Now)), CDate("01/" & mes & "/" & ani))
                                End If
                            End If
                        Else
                            MesAnticipo = DateDiff(DateInterval.Month, CDate("01/" & NumeroMes(mespago) & "/" & annopago), CDate("01/" & mes & "/" & ani))
                        End If
                        'End If
                        'If Not mesta = "0" Then
                        '    MesAnticipo = DateDiff(DateInterval.Month, CDate("01/" & NumeroMes(mesta) & "/" & anesta), CDate("01/" & mes & "/" & ani))
                        '    PiniMes = mesta
                        'End If
                        'If Not mespago = "0" Then
                        '    mesesp = DateDiff(DateInterval.Month, CDate("01/" & NumeroMes(mespago) & "/" & anesta), CDate("01/" & mes & "/" & ani))
                        '    If mesesp <= MesAnticipo Then
                        '        MesAnticipo = mesesp

                        '        PiniMes = obtenerCampo("Select mes_periodo, an_per, valornummes(mes_periodo, an_per) as ordenado from estados where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and pagado=0 order by ordenado asc limit 1", "mes_periodo")
                        '        If PiniMes = "0" Then PiniMes = Mid(NOMBREDEMES(NumeroMes(mespago) + 1), 1, 3)
                        '    End If
                        'Else
                        '    Dim peri As String = obtenerCampo("Select mes_periodo, an_per, valornummes(mes_periodo, an_per) as ordenado from estados where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and pagado=0 order by ordenado asc limit 1", "mes_periodo")
                        '    If peri <> "0" Then PiniMes = peri
                        'End If
                    End If
                    If MesAnticipo > 0 Then
                        '------------------------------------------------------------------------
                        'calculo anticipo
                        MesesAnti = MesAnticipo
                        'MesAnticipo += 2
                        Dim IrAnti As IDataReader = ConsultaSql("Select CalcAnticipo(" & MesAnticipo & ", " & txtCuenta.Text & ", '" & cmbComu.SelectedValue.ToString & "') as AntiConsu, CalcAnticipoAlca(" & MesAnticipo & ", " & txtCuenta.Text & ", '" & cmbComu.SelectedValue.ToString & "') as AntiAlca, CalcAnticipoSanea(" & MesAnticipo & ", " & txtCuenta.Text & ", '" & cmbComu.SelectedValue.ToString & "') as AntiSanea").ExecuteReader
                        IrAnti.Read()
                        ConsumoAnti = IrAnti("AntiConsu") 'obtenerCampo("Select CalcAnticipo(" & MesAnticipo & ", " & txtCuenta.Text & ", '" & cmbComu.SelectedValue.ToString & "') as x", "x")
                        AlcaAnti = IrAnti("AntiAlca") 'obtenerCampo("Select CalcAnticipoAlca(" & MesAnticipo & ", " & txtCuenta.Text & ", '" & cmbComu.SelectedValue.ToString & "') as x", "x")
                        SaneaAnti = IrAnti("AntiSanea") 'obtenerCampo("Select CalSaneaAnticipo(" & MesAnticipo & ", " & txtCuenta.Text & ", '" & cmbComu.SelectedValue.ToString & "') as x", "x")
                        Anti = ConsumoAnti + AlcaAnti + SaneaAnti ' + ANTICIPOULTIMO

                        If fecha >= today Then
                            If mes = 12 And Anio() = Year(Now) Then
                                IvAnti = obtenerCampo("select ivamedidos(" & ConsumoAnti - (ConsumoAnti * DES) & "," & SaneaAnti - (SaneaAnti * DES) & "," & AlcaAnti - (AlcaAnti * DES) & ",'" & Tar & "')as X", "X")
                            Else
                                IvAnti = obtenerCampo("Select ivamedidos(" & ConsumoAnti & ", " & SaneaAnti & ", " & AlcaAnti & ",'" & Tar & "') as x", "x") 'Anti * 0.15 
                            End If
                        Else
                            IvAnti = obtenerCampo("Select ivamedidos(" & ConsumoAnti & ", " & SaneaAnti & ", " & AlcaAnti & ",'" & Tar & "') as x", "x") 'Anti * 0.15 
                        End If
                        'IvAnti = 0
                        AlgCon = True
                        clrecibo.aplicaconsumo = True
                    Else
                        ConsumoAnti = 0
                        SaneaAnti = 0
                        SaneaAnti = 0
                        Anti = 0
                        IvAnti = 0
                        MesesAnti = 0
                    End If
                        'End If
                        'Else
                        '   
                        '  
                        ' Anti = 0
                        'IvAnti = 0
                        'MesesAnti = 0
                        'End If
                        'Aqui calculo el anticipo
                        'Aqui calculo el anticipo
                        'Aqui calculo el anticipo
                        'Aqui calculo el anticipo
                        'Aqui calculo el anticipo
                        If mes = 12 And Anio() = Year(Now) Then
                            'Consumo = 0
                            'Alcanta = 0
                            'Sanea = 0
                            'Rezago = 0
                        End If
                        PiniMes = Mid(CmbPeriodos.Items.Item(0), 1, 3)
                        PiniAn = Mid(CmbPeriodos.Items.Item(0), 5, 4)
                        PFinMes = Mid(CmbPeriodos.Text, 1, 3)
                        PFinAn = Mid(CmbPeriodos.Text, 5, 4)
                        txtPer.Text = String.Concat(PiniMes, " ", PiniAn, " - ", PFinMes, " ", PFinAn)
                        clrecibo.anticipo = Anti
                        TxtAnticipo.Text = FormatCurrency(clrecibo.anticipo, 2)
                        RAnti = Anti
                        txtReza.Text = FormatCurrency(Rezago, 2)
                        clrecibo.rezagos = Rezago
                        RRezago = Rezago
                        txtConsumo.Text = FormatCurrency(Consumo, 2)
                        clrecibo.Consumo = Consumo
                        RConsumo = Consumo
                        txtAlcanta.Text = FormatCurrency(Alcanta, 2)
                        RAlcanta = Alcanta
                        clrecibo.Alcantarillado = Alcanta
                        txtSaneamiento.Text = FormatCurrency(Sanea, 2)
                        clrecibo.Saneamiento = Sanea
                        RSanea = Sanea
                        RRecargos = CDbl(txtReca.Text)
                        clrecibo.recargosotros = RecOtros
                    End If
SalirConsumos:
                If AlgCon And AlgOtros Then
                    'txtOtros.Text = FormatCurrency(otros, 2) 
                    txtOtros.Text = FormatCurrency(clrecibo.otros, 2)
                    ROtros = otros
                    'TxtRecargoOtros.Text = FormatCurrency(RecOtros, 2)
                    TxtRecargoOtros.Text = FormatCurrency(clrecibo.recargosotros, 2)
                    RRecaOtros = otros
                    clrecibo.IVA = ivotr + IvCon + IvAnti
                ElseIf AlgCon = True And AlgOtros = False Then
                    clrecibo.otros = 0
                    clrecibo.recargosotros = 0
                    txtOtros.Text = FormatCurrency(0, 2)
                    TxtRecargoOtros.Text = FormatCurrency(0, 2)
                    clrecibo.IVA = IvCon + IvAnti
                ElseIf AlgOtros = True And AlgCon = False Then
                    txtReza.Text = FormatCurrency(0, 2)
                    clrecibo.rezagos = 0
                    txtConsumo.Text = FormatCurrency(0, 2)
                    clrecibo.Consumo = 0
                    txtAlcanta.Text = FormatCurrency(0, 2)
                    clrecibo.Alcantarillado = 0
                    txtSaneamiento.Text = FormatCurrency(0, 2)
                    clrecibo.recargos = 0
                    TxtAnticipo.Text = FormatCurrency(0, 2)
                    clrecibo.anticipo = 0
                    txtReca.Text = FormatCurrency(0, 2)
                    txtPer.Text = ""
                    txtOtros.Text = FormatCurrency(otros, 2)
                    clrecibo.otros = otros
                    TxtRecargoOtros.Text = FormatCurrency(RecOtros, 2)
                ElseIf AlgOtros = False And AlgCon = False Then
                    lblRedondeo.Visible = False
                    TxtRedondeo.Visible = False
                    TxtRedondeo.Text = FormatCurrency(0, 2)
                    TxtRecargoOtros.Text = FormatCurrency(0, 2)
                    clrecibo.limpiar()
                    txtReza.Text = FormatCurrency(0, 2)
                    txtConsumo.Text = FormatCurrency(0, 2)
                    txtAlcanta.Text = FormatCurrency(0, 2)
                    txtSaneamiento.Text = FormatCurrency(0, 2)
                    TxtAnticipo.Text = FormatCurrency(0, 2)
                    txtReca.Text = FormatCurrency(0, 2)
                    txtPer.Text = ""
                    txtOtros.Text = FormatCurrency(0, 2)
                    txtIva.Text = FormatCurrency(0, 2)
                    txtSubTot.Text = FormatCurrency(0, 2)
                    txtTotal.Text = FormatCurrency(0, 2)
                End If

                If Not ChkRedondeo.Checked Then
                    lblRedondeo.Visible = False
                    TxtRedondeo.Visible = False
                Else
                    lblRedondeo.Visible = True
                    TxtRedondeo.Visible = True
                End If
                TxtRedondeo.Text = clrecibo.redondeo
                txtIva.Text = FormatCurrency(clrecibo.IVA, 2)
                txtSubTot.Text = FormatCurrency(clrecibo.Subtotal, 2)
                txtTotal.Text = FormatCurrency(clrecibo.Total, 2)
                RRedondeo = CDbl(TxtRedondeo.Text)
                RIva = CDbl(txtIva.Text)
                RSubTot = CDbl(txtSubTot.Text)
                RTotal = CDbl(txtTotal.Text)
                RTotal = CDbl(txtTotal.Text)
            End If
        ElseIf RBFactibilidades.Checked = True Then
            Dim Miva As New Collection
            Dim irSol As IDataReader = ConsultaSql("Select montofactibilidad, montomateriales from solicitud where numero = " & TxtSolicitud.Text & "").ExecuteReader
            If irSol.Read Then
                Miva = regIva(irSol("montofactibilidad"))
                TxtFactibilidad.Text = FormatCurrency(Miva(1), 2)
                clrecibo.aplicaconsumo = False
                clrecibo.redondear = False
                clrecibo.aplicaotros = True
                clrecibo.otros = Miva(1)
                clrecibo.IVA = Miva(2)
                RFacti = CDbl(TxtFactibilidad.Text)
                'txtSubTot.Text = FormatCurrency(Miva(1), 2)
                txtSubTot.Text = FormatCurrency(clrecibo.Subtotal, 2)
                RSubTot = CDbl(txtSubTot.Text)
                txtIva.Text = FormatCurrency(clrecibo.IVA, 2)
                RIva = CDbl(txtIva.Text)
                ' txtTotal.Text = FormatCurrency(irSol("montofactibilidad"), 2)
                txtTotal.Text = FormatCurrency(clrecibo.Total, 2)
                RTotal = CDbl(txtTotal.Text)
            End If
        End If
        If (CDbl(txtTotal.Text) > 0 And CDbl(txtSubTot.Text) > 0) And siimprime = True Then
            BtnAceptar.Enabled = True
        Else
            BtnAceptar.Enabled = False
            txtIva.Text = FormatCurrency(0, 2)
            txtSubTot.Text = FormatCurrency(0, 2)
            txtTotal.Text = FormatCurrency(0, 2)
        End If
    End Sub

#End Region

#Region "Limpiar"
    Private Sub limpiar()
        BtnAceptar.Enabled = False
        txtNombre.Text = ""
        txtCol.Text = ""
        txtCom.Text = ""
        txtNumExt.Text = ""
        txtCalle.Text = ""
        txtNumInt.Text = ""
        txtPer.Text = ""
        txtTarifa.Text = ""
        txtCp.Text = ""
        txtRfc.Text = ""
        TxtAnticipo.Text = FormatCurrency(0, 2)
        txtReza.Text = FormatCurrency(0, 2)
        txtConsumo.Text = FormatCurrency(0, 2)
        txtSaneamiento.Text = FormatCurrency(0, 2)
        txtAlcanta.Text = FormatCurrency(0, 2)
        txtOtros.Text = FormatCurrency(0, 2)
        txtDescu.Text = FormatCurrency(0, 2)
        txtSubTot.Text = FormatCurrency(0, 2)
        txtIva.Text = FormatCurrency(0, 2)
        txtReca.Text = FormatCurrency(0, 2)
        TxtAnticipo.Text = FormatCurrency(0, 2)
        txtTotal.Text = FormatCurrency(0, 2)
        TxtFactibilidad.Text = FormatCurrency(0, 2)
        TxtRecargoOtros.Text = FormatCurrency(0, 2)
        ComboRob1.cadsql = ""
        RemSistema = True
        For r = 1 To dgCob.RowCount
            dgCob.Rows.Remove(dgCob.CurrentRow)
        Next
        RemSistema = False
        Calcular = False
        ChkConsumo.Checked = True
        chkOtros.Checked = True
        Calcular = True
        ComboRob1.Visible = True
        chkOtros.Visible = True
        Convenio = False
        CmbFormaPago.Text = "EFECTIVO"
        TxtReferencia.Text = ""
        TxtObservacion.Text = ""
        'CmbPeriodos.Text = ""
        lblDirFis1.Text = ""
        lblDirFis2.Text = ""
        LblDirFis3.Text = ""
        LblDirFis4.Text = ""
        LabelX7.Text = ""
        TxtLecActual.Text = ""
        TxtLecAnterior.Text = ""
        ChkDirFis.Checked = False
        TxtRedondeo.Visible = False
        lblRedondeo.Visible = False
        TxtRedondeo.Text = FormatCurrency(0, 2)
        ValidaTipo()
    End Sub
#End Region

    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.TextChanged
        limpiar()
    End Sub

    Public Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        limpiar()
        If RBFactibilidades.Checked Then
            TxtFactibilidad.Text = ""
            TxtFactibilidad.Select()
        ElseIf RBNoPadron.Checked Then
            CmbNousuarios.Text = ""
        ElseIf RBUsuarios.Checked Then
            txtCuenta.Text = ""
            cmbComu.Text = ""
            txtCuenta.Select()
        End If
    End Sub
    Public Sub actualiza_iva()
        Dim id As String
        id = obtenerCampo("SELECT * FROM usuario where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "'", "tarifa")
        Ejecucion("update estados set iva=calcanticipoiva(consumo,saneamiento,drenaje,'" & id & "')  where id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and cuenta = " & txtCuenta.Text)
    End Sub
#Region "Aceptar la busqueda"
    Public Sub AceptarBusqueda()
        Try
            Convenio = False
            'ValidaTipo()
            If RBUsuarios.Checked = True Then
                limpiar()
                If txtCuenta.Text <> "" Then
                    Ejecucion("CALL REC_OTROS('" & cmbComu.SelectedValue.ToString & "'," & txtCuenta.Text & ",'" & UnixDateFormat(DTFecha.Value) & "')")
                    Dim an As String
                    an = Year(Now)
                    Dim a As New classcierre
                    a.act_recargos(cmbComu.SelectedValue.ToString, txtCuenta.Text, Mid(NOMBREDEMES(Month(Now)), 1, 3), an)
                    actualiza_iva()
                    llenarDatos(CDbl(txtCuenta.Text), cmbComu.Text)
                    CmbPeriodos.Select()
                    If Convenio <> True Then
                        desc_porc()
                        gastos()
                    End If
                End If
            ElseIf RBFactibilidades.Checked = True Then
                If TxtSolicitud.Text <> "" Then
                    llenarDatos(CDbl(TxtSolicitud.Text), cmbComu.Text)
                End If
            ElseIf RBNoPadron.Checked = True Then
                If CmbNousuarios.Text <> "" Then
                    llenarDatos(CmbNousuarios.SelectedValue.ToString, cmbComu.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
#End Region

    Public Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If cmbComu.Text = "" And RBUsuarios.Checked Then
            MessageBoxEx.Show("Especifique la comunidad, por favor", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbComu.Select()
            Exit Sub
        End If
        If RBUsuarios.Checked = True Then
            LlenaPeriodos(txtCuenta.Text, cmbComu.Text)
            D_COMUNIDADES = ConsultaSql("SELECT * FROM COMUNIDADES WHERE COMUNIDAD='" & Trim(cmbComu.Text) & "'").ExecuteReader
            If D_COMUNIDADES.Read() Then
                DID_COMUNIDAD = Trim(D_COMUNIDADES("ID_COMUNIDAD"))
                D_PERIODOFACTURADO = ConsultaSql("SELECT * FROM ESTADOS WHERE CUENTA=" & Val(txtCuenta.Text) & " AND ID_COMUNIDAD='" & DID_COMUNIDAD & "' and pagado=0 and ULTIMO=1").ExecuteReader
                If D_PERIODOFACTURADO.Read() Then
                    CmbPeriodos.Text = D_PERIODOFACTURADO("MES_PERIODO") & " " & D_PERIODOFACTURADO("AN_PER")
                Else
                    CmbPeriodos.SelectedIndex = 0 'CmbPeriodos.Items.Count - 1
                End If
            End If
            dgCob.Enabled = True
        End If
        If RBNoPadron.Checked = True Then
            dgCob.Enabled = False
        End If
        AceptarBusqueda()
        CALCULO()
        'If Mes() = 12 And Anio() = Year(Now) Then
        '    MessageBoxEx.Show("Esta Cobrando Consumo Anual Anticipado por " + txtTotal.Text, "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Frmbusclav.Show()
        'If RBUsuarios.Checked = True Then
        'Dim frmbus As New frmBusUsuario(eve.Cobros)
        'frmbus.filtro("select cuenta as Cuenta, nombre as Nombre , comunidad as Comunidad, colonia as Colonia, Calle, numext as Número_exterior, numint as Número_interior  from vusuario order by cuenta, comunidad ")
        'frmbus.ShowDialog()
        'frmbus.WindowState = FormWindowState.Maximized
        'ElseIf RBFactibilidades.Checked = True Then
        'ElseIf RBNoPadron.Checked = True Then
        'End If
    End Sub

    Public Sub dgCob_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgCob.CellBeginEdit
        If dgCob.Item("Tipo", dgCob.CurrentRow.Index).Value = "Abono" Then
            dgCob.Item("total", dgCob.CurrentRow.Index).ReadOnly = True
        Else
            dgCob.Item("total", dgCob.CurrentRow.Index).ReadOnly = False
        End If

    End Sub

    Private Sub dgCob_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCob.CellEndEdit
        Dim TotResta, TotReca, TotIva, Tot As Double
        Dim Resta, Reca, Iva As Double
        Dim PorcResta, PorcReca, PorcIva As Double
        Dim Abono As Double
        Dim otr As IDataReader = ConsultaSql("select SubTotResta, resta, TotRec, Iva, (subtotresta + totrec + iva) as Total from otrosconceptos where clave=" & dgCob.Item("clave", dgCob.CurrentRow.Index).Value & "").ExecuteReader
        If otr.Read() Then
            TotResta = otr("SubTotResta")
            TotIva = otr("iva")
            TotReca = otr("TotRec")
            Tot = otr("Total")
        Else
            TotResta = 0
            TotIva = 0
            TotReca = 0
            Tot = 0
        End If
        Dim _total As Double
        _total = 0
        Try
            If Tot < dgCob.Item("Total", dgCob.CurrentRow.Index).Value Then
                MessageBoxEx.Show("El total a pagar es mayor al total que se adeuda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Throw New Exception
            End If

            If dgCob.Item("Total", dgCob.CurrentRow.Index).Value <= 0 Then
                MessageBoxEx.Show("El total debe ser mayor a 0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Throw New Exception
            End If

            Abono = dgCob.Item("Total", dgCob.CurrentRow.Index).Value
            PorcResta = TotResta / Tot
            PorcIva = TotIva / Tot
            PorcReca = TotReca / Tot

            Resta = Math.Round((PorcResta * Abono), 2)
            Reca = Math.Round((PorcReca * Abono), 2)
            Iva = Math.Round((PorcIva * Abono), 2)
            dgCob.Item("subTot", dgCob.CurrentRow.Index).Value = Resta
            dgCob.Item("Recargos", dgCob.CurrentRow.Index).Value = Reca
            dgCob.Item("iva", dgCob.CurrentRow.Index).Value = Iva
        Catch ex As Exception
            dgCob.Item("Total", dgCob.CurrentRow.Index).Value = Tot
            dgCob.Item("subTot", dgCob.CurrentRow.Index).Value = TotResta
            dgCob.Item("Recargos", dgCob.CurrentRow.Index).Value = TotReca
            dgCob.Item("iva", dgCob.CurrentRow.Index).Value = TotIva
            Exit Sub
        End Try
        CALCULO()
    End Sub

    Private Sub cmdAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAct.Click
        Dim frmact As New frmActRec(_cod_ofi, _caja, _serie, _ope, DTFecha.Value)
        frmact.ShowDialog()
    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Dim frmact As New frmCanRec(_cod_ofi, _caja, _serie, DTFecha.Value)
        frmact.ShowDialog()
    End Sub

    Public Function Mes() As Integer
        Return NumeroMes(Mid(CmbPeriodos.Text, 1, 3))
    End Function

    Public Function Anio() As Integer
        Return Val(Mid(CmbPeriodos.Text, 5, 4))
    End Function

    Private Sub TxtSolicitud_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSolicitud.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#Region "Valida Tipo"
    Private Sub TxtSolicitud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSolicitud.TextChanged
        limpiar()
        'limpiar()
    End Sub

    Private Sub RBUsuarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBUsuarios.CheckedChanged
        limpiar()
        'ValidaTipo()
    End Sub

    Private Sub RBFactibilidades_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBFactibilidades.CheckedChanged
        Try
            limpiar()
            'ValidaTipo()
        Catch EX As Exception
        End Try
    End Sub

    Private Sub RBNoPadron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNoPadron.CheckedChanged
        limpiar()
        'ValidaTipo()
    End Sub

    Private Sub ValidaTipo()
        Try
            'limpiar()
            PanFactibilidad.Top = 70
            PanUsuarios.Top = 70
            If RBFactibilidades.Checked = True Then
                LblTitulo.Text = "Factibilidad:"
                LblTitulo.Visible = True
                TxtSolicitud.Visible = True
                cmbComu.Visible = False
                txtCuenta.Visible = False
                PanFactibilidad.Visible = True
                PanUsuarios.Visible = False
                ChkConsumo.Visible = False
                chkOtros.Visible = False
                CmbPeriodos.Visible = False
                ComboRob1.Visible = False
                cmdAceptar.Visible = True
                CmbNousuarios.Visible = False
                gpGrid.Visible = True
                Factibilidadex.Visible = True
                ExBus.Visible = False
                ExBus.Expanded = False
                ChkRedondeo.Enabled = False
            ElseIf RBUsuarios.Checked = True Then
                LblTitulo.Text = "Cuenta del Usuario:"
                LblTitulo.Visible = True
                cmbComu.Visible = True
                TxtSolicitud.Visible = False
                TxtSolicitud.Text = ""
                txtCuenta.Visible = True
                PanFactibilidad.Visible = False
                PanUsuarios.Visible = True
                ChkConsumo.Visible = True
                chkOtros.Visible = True
                CmbPeriodos.Visible = True
                ComboRob1.Visible = True
                cmdAceptar.Visible = True
                CmbNousuarios.Visible = False
                gpGrid.Visible = True
                Factibilidadex.Visible = False
                Factibilidadex.Expanded = False
                ExBus.Visible = True
                ChkRedondeo.Enabled = True
            ElseIf RBNoPadron.Checked = True Then
                LblTitulo.Visible = True
                LblTitulo.Text = "Selecciona:"
                CmbNousuarios.WatermarkText = "Usuarios Fuera del Padrón"
                TxtSolicitud.Visible = False
                txtCuenta.Visible = False
                cmbComu.Visible = False
                PanFactibilidad.Visible = False
                PanUsuarios.Visible = False
                ChkConsumo.Visible = False
                chkOtros.Visible = False
                CmbPeriodos.Visible = False
                ComboRob1.Visible = False
                gpGrid.Visible = True
                cmdAceptar.Visible = True
                CmbNousuarios.Visible = True
                llenarCombo(CmbNousuarios, "Select clave, nombre from nousuarios where activo = 1")
                CmbNousuarios.SelectedIndex = -1
                CmbNousuarios.Text = ""
                Factibilidadex.Visible = False
                ExBus.Visible = False
                ExBus.Expanded = False
                ChkRedondeo.Enabled = False
            End If
        Catch EX As Exception
        End Try
    End Sub
#End Region

    Private Sub dgCob_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgCob.CellFormatting
        If dgCob.Item("Tipo", e.RowIndex).Value = "Cargo" Then
            dgCob.Item(1, e.RowIndex).Style.BackColor = Color.LightYellow
            dgCob.Item(2, e.RowIndex).Style.BackColor = Color.LightYellow
            dgCob.Item(3, e.RowIndex).Style.BackColor = Color.LightYellow
            dgCob.Item(4, e.RowIndex).Style.BackColor = Color.LightYellow
            dgCob.Item(5, e.RowIndex).Style.BackColor = Color.LightYellow
            dgCob.Item(6, e.RowIndex).Style.BackColor = Color.LightYellow
        Else
            dgCob.Item(1, e.RowIndex).Style.BackColor = Color.LimeGreen
            dgCob.Item(2, e.RowIndex).Style.BackColor = Color.LimeGreen
            dgCob.Item(3, e.RowIndex).Style.BackColor = Color.LimeGreen
            dgCob.Item(4, e.RowIndex).Style.BackColor = Color.LimeGreen
            dgCob.Item(5, e.RowIndex).Style.BackColor = Color.LimeGreen
            dgCob.Item(6, e.RowIndex).Style.BackColor = Color.LimeGreen
        End If
    End Sub

#Region "Activar convenio"
    Private Sub ActivarConvenio()
        Ejecucion("update pagos set otros = subtotal where recibo = " & recibo & " and serie = '" & _serie & "'")
        Dim NumCon As String = obtenerCampo("Select no_convenio from convenios where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and status = 'Pendiente'", "no_convenio")
        'Desmarcar con convenio al usuario
        Ejecucion("Update usuario set convenio = 0 where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' ")
        'Dar de alta el convenio
        Ejecucion("update convenios set Status = 'Activo'  where no_convenio = '" & NumCon & "' ")
        Dim Claotro As String = obtenerCampo("Select clave,id_concepto from otrosconceptos where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and concepto = 'ANTICIPO DE CONVENIO' and abonos = 0", "clave")
        ' Dim Claotro As String = "000ACO"
        'Crea en el usuario un concepto por anticipo de convenio
        'Ejecucion("insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & txtCuenta.Text & ",'" & _
        '                    cmbComu.SelectedValue.ToString & "'," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
        '                    "000ACO','ANTICIPO DE CONVENIO',1,0," & CDbl(txtSubTot.Text) & "," & _
        '                    CDbl(txtIva.Text) & "," & CDbl(txtTotal.Text) & ",'A','CO','" & TxtReferencia.Text & "', 'Cargo')")

        'Esta funcion actualiza los otros conceptos, aun no concibo como le hare para la caja movil
        Dim CADENACONVENIO As String
        CADENACONVENIO = "update otrosconceptos set pagado=1, resta = 0, abonos = " & CDbl(txtTotal.Text) & " where  clave=" & Claotro & ""
        Ejecucion("update otrosconceptos set pagado=1, resta = 0, abonos = " & CDbl(txtTotal.Text) & " where clave=" & Claotro & "")

        If Tipo_Caja = "Remota" Then
            GuardarTxt("Update usuario set convenio = 0 where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' ")
            GuardarTxt("update convenios set Status = 'Activo'  where no_convenio = '" & NumCon & "' ")
            'GuardarTxt("insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & txtCuenta.Text & ",'" & _
            '                    cmbComu.SelectedValue.ToString & "'," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
            '                     "000ACO','ANTICIPO DE CONVENIO',1,0," & CDbl(txtSubTot.Text) & "," & _
            '                    CDbl(txtIva.Text) & "," & CDbl(txtTotal.Text) & ",'A','CO','" & TxtReferencia.Text & "', 'Cargo')")
            GuardarTxt("update otrosconceptos set pagado=1,resta=0,abonos=" & CDbl(txtTotal.Text) & " where clave=" & Claotro & "")
        End If

        'Lee los pagares para crearlos en otrosconceptos
        Dim ClaAbo As Double = Val(obtenerCampo("Select max(clave) as mayor from otrosconceptos", "mayor")) + 1
        Dim pag As IDataReader = ConsultaSql("select convenio, nopagare, monto, fecha, Consumo, drenaje, Sanea, recargos, iva, otros from pagares where convenio = '" & NumCon & "'").ExecuteReader
        Do While pag.Read
            Ejecucion("insert into otrosconceptos (clave,cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, Consumo, drenaje, Saneamiento, recargos, repiva, otros, subtotresta, ivaresta,ID_CONCEPTO) values (" & ClaAbo & ", " & txtCuenta.Text & ", '" & NumCon & "  " & pag("nopagare") & "' , " & pag("monto") & ", " & pag("monto") - pag("iva") & "," & pag("iva") & " ,0,'" & UnixDateFormat(pag("fecha")) & "', 'CONVENIOS', 0, 'PENDIENTE', '" & pag("nopagare") & "', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & pag("monto") & ", 'Cargo','" & UCase(MonthName(Month(pag("fecha")), True)) & "', " & Year(pag("fecha")) & ", " & pag("Consumo") & ", " & pag("drenaje") & "," & pag("Sanea") & "," & pag("recargos") & "," & pag("iva") & ", " & pag("otros") & ", " & pag("monto") - pag("iva") & "," & pag("iva") & ",'110PAG')")
            If Tipo_Caja = "Remota" Then
                GuardarTxt("insert into otrosconceptos (cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, Consumo, drenaje, Saneamiento, recargos, repiva, otros, subtotresta, ivaresta,ID_CONCEPTO) values (" & txtCuenta.Text & ",'" & NumCon & "  " & pag("nopagare") & "' , " & pag("monto") & ", " & pag("monto") - pag("iva") & "," & pag("iva") & " ,0,'" & UnixDateFormat(pag("fecha")) & "', 'CONVENIOS', 0, 'PENDIENTE', '" & pag("nopagare") & "', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & pag("monto") & ", 'Cargo','" & UCase(MonthName(Month(pag("fecha")), True)) & "', " & Year(pag("fecha")) & ", " & pag("Consumo") & ", " & pag("drenaje") & "," & pag("Sanea") & "," & pag("recargos") & "," & pag("iva") & ", " & pag("otros") & ", " & pag("monto") - pag("iva") & "," & pag("iva") & ",'110PAG')")
            End If
            ClaAbo += 1
        Loop
        ' '' ''Da por pagado los conceptos seleccionados
        pag = ConsultaSql("select convenio, mes, anio from convenioconsumo where convenio = '" & NumCon & "'").ExecuteReader
        Do While pag.Read
            Ejecucion("Update estados set pagado = 1, cod_usu = " & NumUser & ", convenio = '" & NumCon & "' where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and mes_periodo = '" & pag("mes") & "' and an_per = " & pag("anio") & " ")
            If Tipo_Caja = "Remota" Then
                GuardarTxt("Update estados set pagado = 1, cod_usu = " & NumUser & ", convenio = '" & NumCon & "' where cuenta = " & txtCuenta.Text & " and id_comunidad = '" & cmbComu.SelectedValue.ToString & "' and mes_periodo = '" & pag("mes") & "' and an_per = " & pag("anio") & " ")
            End If
        Loop
        'Crea en conveniootros los valores de manera temporal para los otros conceptos
        pag = ConsultaSql("select convenio, clave from conveniootros").ExecuteReader
        Do While pag.Read
            Ejecucion("update otrosconceptos set pagado=1,fec_apli='" & UnixDateFormat(DTFecha.Value) & "',abonos=abonos + resta,convenio='" & NumCon & "' where clave=" & pag("clave") & "")
            Ejecucion("update otrosconceptos set resta = 0, subtotResta = 0, ivaResta = 0  where clave = " & pag("clave") & "")
            If Tipo_Caja = "Remota" Then
                GuardarTxt("update otrosconceptos set pagado=1,fec_apli='" & UnixDateFormat(DTFecha.Value) & "',abonos=abonos + resta,convenio='" & NumCon & "'  where clave=" & pag("clave") & "")
                GuardarTxt("update otrosconceptos set resta=0,subtotResta=0,ivaResta=0 where clave=" & pag("clave") & "")
            End If
        Loop
    End Sub
#End Region
    Private Sub cmdImpCort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImpCort.Click
        If obtenerCampo("select count(*) as tot from pagos where cod_ofi='" & _cod_ofi & "' and id_caja='" & _caja & "' and fecha_act='" & UnixDateFormat(DTFecha.Value) & "'", "tot") > 0 Then
            Dim per As String
            per = "'Pagos del dia " & DTFecha.Value.Day & " de " & MonthName(DTFecha.Value.Month) & " del " & DTFecha.Value.Year & "'"
            Dim Impr As New frmReporte(frmReporte.Lista.Reporte_Ingresos, "{pagos1.cod_Ofi} = '" & _cod_ofi & "' and {pagos1.id_caja} = '" & _caja & "' and {pagos1.fecha_Act} = Date (" & DTFecha.Value.Year & ", " & DTFecha.Value.Month & " , " & DTFecha.Value.Day & " )", "Titulo, " & per, "Encabezado, '" & LblCaja.Text & "'")
            Impr.MdiParent = MDIPrincipal
            Impr.Show()
        Else
            MessageBoxEx.Show("No se han realizado pagos en esta caja para este día", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TxtCodBar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodBar.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                If txtCuenta.Text <> "" Then
                    txtCuenta.Text = Val(Mid(TxtCodBar.Text, 1, 5))
                    cmbComu.SelectedValue = Mid(TxtCodBar.Text, 7, 3)
                    Dim MES1 As String, ANIO1 As Double
                    MES1 = Mid(TxtCodBar.Text, 9, 3)
                    ANIO1 = Mid(TxtCodBar.Text, 12, 4)
                    CmbPeriodos.Text = MES1 & " " & ANIO1
                    llenarDatos(CDbl(txtCuenta.Text), cmbComu.Text)
                End If
            End If
        Catch ex As Exception
            txtCuenta.Text = ""
        End Try
    End Sub
    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        CALCULO()
    End Sub

    Public Sub CALCULO()
        Dlgproceso.Visible = True
        'For r = 1 To dgCob.RowCount
        '    dgCob.Rows.Remove(dgCob.CurrentRow)
        'Next
        'AceptarBusqueda()
        ivagrid()
        desc_porc()
        llenatot(Mes, Anio)
        If RBUsuarios.Checked = True Then
            descupronto()
            If MesesAnti > 0 Then
                LabelX7.Text = Str(MesesAnti) + " PERIODO(S) ANTICIPADO"
                LabelX7.ForeColor = Color.DarkGreen
            Else
                If CmbPeriodos.Text = "" Then
                    LabelX7.Text = "NO HAY PERIODOS POR PAGAR"
                    LabelX7.ForeColor = Color.Red
                Else
                    LabelX7.Text = "PERIODO FACTURADO"
                    LabelX7.ForeColor = Color.Red
                End If
            End If
        End If
        BtnAceptar.Select()
        Dlgproceso.Visible = False
    End Sub

    Private Sub DGBus_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGBus.DoubleClick
        txtCuenta.Text = DGBus.Item(0, DGBus.CurrentRow.Index).Value
        cmbComu.Text = DGBus.Item(3, DGBus.CurrentRow.Index).Value
        AceptarBusqueda()
        ExBus.Expanded = False
    End Sub

#Region "Grabar Datos del recibo"
    Private Sub AceptarRecibo()
        Dim i As Int16
        Dim resta As Double = 0
        Dim ivam As New Collection
        Dim FrmPag As New DlgCambioCobro
        Dim idconvenio2 As IDataReader = Nothing
        Dim matti() As String = Nothing
        Dim Anticipo As Double = 0
        CALCULO()
        If CDbl(txtTotal.Text) = 0 Then
            MessageBoxEx.Show("No se puede realizar el cobro debido a que el usuario no presenta deuda alguna", "Cobros", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        'FrmPag.Total = CDbl(txtTotal.Text)
        FrmPag.Total = clrecibo.Total
        OPC = 0
        FrmPag.ShowDialog()
        If OPC = 1 Then
            If FrmPag.Respuesta = True Then
                BtnAceptar.Enabled = False
                _num_ope += 1

                If CHKIMPRIMIR.Checked = True Then
                    'Do While True
                    'Imprimir el recibo

                    Dim x As Integer
                    LblRecibo.Text = recibo
                    'Dialogcaja.ShowDialog()
                    x = 1
                    'If x = System.Windows.Forms.DialogResult.Cancel Then
                    Dim cadenapasa As New StringBuilder
volvercancelar:
                    'LblRecibo.Text = recibo
                    'Try
                    'cadenapasa.Remove(0, cadenapasa.Length)
                    'cadenapasa.Append("insert into pagos (fecha_act,  serie, recibo, cancelado, cod_ofi, id_caja, hora, num_ope , can_usu, can_fec, can_motivo) values (")
                    'cadenapasa.Append("'" & UnixDateFormat(DTFecha.Value) & "','" & _serie & "'," & recibo & ",'C','" & _cod_ofi & "','" & _caja & "', CURTIME()," & _num_ope & "," & NumUser & ",'" & UnixDateFormat(DTFecha.Value) & "','PROBLEMAS DE IMPRESION')")
                    'Ejecucion(cadenapasa.ToString)
                    'If Tipo_Caja = "Remota" Then
                    'GuardarTxt(cadenapasa.ToString)
                    'End If

                    '   Catch ex As Exception
                    'If InStr(ex.Message(), "Duplicate") Then
                    'recibo += 1
                    'LblRecibo.Text = recibo
                    'MessageBoxEx.Show("El folio que se selecciono ya existe, INTENTARE CON EL FOLIO: " & recibo, "Cambio de folio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'GoTo volvercancelar
                End If
                'MessageBox.Show(ex.Message())
                'MessageBox.Show("No puedo cancelar el recibo" & vbCrLf & " sal de cajas y vuelve intentar cobrar")
                'Exit Sub
                '   End Try

                'llenatot(Mes, Anio)

                '_num_ope += 1
                'recibo += 1
                'LblRecibo.Text = recibo
                'MessageBox.Show("IMPRIMIRE EN EL FOLIO " & recibo)


                ' Loop
            End If
            If RBUsuarios.Checked = True Then
                Dim pasa As Integer = 0
volver:
                Try
                    Dim cadenaparapago As New StringBuilder
                    cadenaparapago.Remove(0, cadenaparapago.Length)
                    If txtDescu.Visible = False Then txtDescu.Text = "0"
                    'TxtAnticipo.Text = "0"
                    Dim vreca As Double = CDbl(TxtRecargoOtros.Text) + CDbl(txtReca.Text)
                    Dim TARI As String
                    TARI = obtenerCampo("SELECT * FROM USUARIO WHERE CUENTA=" & txtCuenta.Text & " AND ID_COMUNIDAD='" & cmbComu.SelectedValue & "'", "tarifa")
                    cadenaparapago.Append("insert into pagos values('" & UnixDateFormat(DTFecha.Value) & "'," & txtCuenta.Text & ",'" & cmbComu.SelectedValue.ToString & "','" & PiniMes & "',")
                    cadenaparapago.Append(PiniAn & ",'" & PFinMes & "'," & PFinAn & "," & CDbl(txtReza.Text) & "," & CDbl(txtConsumo.Text) & ",")
                    cadenaparapago.Append(CDbl(vreca) & "," & clrecibo.otros + clrecibo.redondeo + CDbl(txtDescu.Text * -1) & "," & CDbl(txtIva.Text) & "," & CDbl(txtAlcanta.Text) & "," & CDbl(txtSaneamiento.Text) & ",")
                    cadenaparapago.Append(CDbl(txtSubTot.Text) & "," & CDbl(txtDescu.Text) & "," & CDbl(txtTotal.Text) & ",'" & txtNombre.Text & "'," & recibo & ",'A'," & porDesc & ",' ','")
                    cadenaparapago.Append(_serie & "'," & _ope & ",'" & TARI & "','CO','" & TxtReferencia.Text & "',False,0,'N','" & _cod_ofi & "','" & _caja & "', " & CDbl(TxtAnticipo.Text) & ", '" & TxtObservacion.Text & "', '" & TimeString & "', " & _num_ope & ", 'Usuarios', null, null, null, null, '" & _ID_CROAPE & "')")
                    Ejecucion(cadenaparapago.ToString)

                    Try
                        ' Ejecucion("update usuario set requeri=0 where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "'")
                    Catch ex As Exception

                    End Try
                    Try
                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(cadenaparapago.ToString)
                            '  GuardarTxt("update usuario set requeri=0 where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "'")
                        End If
                    Catch ex As Exception
                    End Try

                Catch ex As Exception

                    If InStr(ex.Message(), "Duplicate") Then
                        recibo += 1
                        LblRecibo.Text = recibo
                        MessageBoxEx.Show("El folio que se selecciono ya existe, INTENTARE CON EL FOLIO: " & recibo, "Cambio de folio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pasa += 1
                        If pasa = 1 Then
                            frmcambiofolio.StartPosition = FormStartPosition.CenterScreen
                            frmcambiofolio.ShowDialog()

                            pasa = 0
                        End If
                        GoTo volver
                    End If

                    MessageBox.Show(ex.Message())
                    MessageBox.Show("No grabé el pago, sal de caja y vuelve intentar hacer el pago")

                End Try

                Try
                    'Verificar si trae convenio, si es verdadero activarlo
                    If Convenio = True Then
                        ActivarConvenio()
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                If ChkConsumo.Checked = True Then
                    Try
                        'Aqui actualizo los estados
                        'If Mes() = 12 And Anio() = Year(Now) Then
                        Ejecucion("update estados set pagado=1, fechafac = '" & UnixDateFormat(DTFecha.Value) & "', factura=" & recibo & ",serie='" & _serie.ToString & "', caja='" & _caja & "', OFI_PAGO='" & _cod_ofi & "',cod_usu=" & _ope & " where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and valornummes(mes_periodo,an_per) <= valornummes('" & PFinMes & "'," & PFinAn & ") and pagado = 0")
                        If Tipo_Caja = "Remota" Then
                            GuardarTxt("update estados set pagado=1, fechafac = '" & UnixDateFormat(DTFecha.Value) & "', factura=" & recibo & ",serie='" & _serie.ToString & "', caja='" & _caja & "', OFI_PAGO='" & _cod_ofi & "',cod_usu=" & _ope & " where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and valornummes(mes_periodo,an_per) <= valornummes('" & PFinMes & "'," & PFinAn & ") and pagado = 0")
                        End If
                    Catch ex As Exception
                        MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    'Aqui se graban los anticipos
                    Anticipo = CDbl(TxtAnticipo.Text) + IvAnti
                    If Anticipo > 0 Then
                        Try
                            If Tipo_Caja = "Remota" Then
                                GuardarTxt("insert into otrosconceptos (cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, consumo, drenaje, saneamiento,repiva,factura,serie,caja,cod_ofi,id_concepto,fec_alta) values (" & txtCuenta.Text & ", 'Anticipo', " & CDbl(TxtAnticipo.Text) + IvAnti & ", " & CDbl(TxtAnticipo.Text) & ", " & IvAnti & ",0,'" & UnixDateFormat(DTFecha.Value) & "', 'ANTICIPO', '" & String.Concat(Now.Year, _serie, recibo, "A") & "', 'PENDIENTE', 'ANTICIPO', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & CDbl(TxtAnticipo.Text) + IvAnti & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & ConsumoAnti & ", " & AlcaAnti & ", " & SaneaAnti & ", " & IvAnti & "," & recibo & ",'" & _serie & "','" & _caja & "','" & _cod_ofi & "','018NSR','" & UnixDateFormat(Now.Date) & "')")
                            End If
                            Ejecucion("insert into otrosconceptos (cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, consumo, drenaje, saneamiento,repiva,factura,serie,caja,cod_ofi,id_concepto,fec_alta) values (" & txtCuenta.Text & ", 'Anticipo', " & CDbl(TxtAnticipo.Text) + IvAnti & ", " & CDbl(TxtAnticipo.Text) & ", " & IvAnti & ",0,'" & UnixDateFormat(DTFecha.Value) & "', 'ANTICIPO', '" & String.Concat(Now.Year, _serie, recibo, "A") & "', 'PENDIENTE', 'ANTICIPO', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & CDbl(TxtAnticipo.Text) + IvAnti & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & ConsumoAnti & ", " & AlcaAnti & ", " & SaneaAnti & ", " & IvAnti & "," & recibo & ",'" & _serie & "','" & _caja & "','" & _cod_ofi & "','018NSR','" & UnixDateFormat(Now.Date) & "')")

                        Catch ex As Exception

                            Try
                                Dim nmax As Double = Val(obtenerCampo("Select max(clave) as mayor from otrosconceptos", "mayor")) + 1
                                'Ejecucion("ALTER TABLE `baseagua`.`otrosconceptos` AUTO_INCREMENT = " & nmax & "")

                                'If Mes() = 12 And Anio() = Year(Now) Then
                                Dim saldo As Double
                                saldo = obtenerCampo("select saldo from estados where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and ultimo=1 and pagado = 0", "saldo")
                                If saldo < CDbl(TxtAnticipo.Text) Then
                                    Ejecucion("update estados set pagado=1, fechafac = '" & UnixDateFormat(DTFecha.Value) & "', factura=" & recibo & ",serie='" & _serie.ToString & "', caja='" & _caja & "', OFI_PAGO='" & _cod_ofi & "',cod_usu=" & _ope & " where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and valornummes(mes_periodo,an_per) <= valornummes('" & PFinMes & "'," & PFinAn & ") and pagado = 0")
                                    Ejecucion("insert into otrosconceptos (clave,cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, consumo, drenaje, saneamiento,repiva,factura,serie,caja,cod_ofi,id_concepto,fec_alta,subtotresta) values (" & nmax & "," & txtCuenta.Text & ", 'Anticipo', " & CDbl(TxtAnticipo.Text) + IvAnti & ", " & CDbl(TxtAnticipo.Text) & ", " & IvAnti & ",0,'" & UnixDateFormat(DTFecha.Value) & "', 'ANTICIPO', '" & String.Concat(Now.Year, _serie, recibo, "A") & "', 'PENDIENTE', 'ANTICIPO', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "'," & saldo & "," & CDbl(TxtAnticipo.Text) + IvAnti - saldo & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & ConsumoAnti & ", " & AlcaAnti & ", " & SaneaAnti & ", " & IvAnti & "," & recibo & ",'" & _serie & "','" & _caja & "','" & _cod_ofi & "','018NSR','" & UnixDateFormat(Now.Date) & "',-" & saldo & ")")
                                Else
                                    Ejecucion("insert into otrosconceptos (clave,cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, consumo, drenaje, saneamiento,repiva,factura,serie,caja,cod_ofi,id_concepto,fec_alta) values (" & nmax & "," & txtCuenta.Text & ", 'Anticipo', " & CDbl(TxtAnticipo.Text) + IvAnti & ", " & CDbl(TxtAnticipo.Text) & ", " & IvAnti & ",0,'" & UnixDateFormat(DTFecha.Value) & "', 'ANTICIPO', '" & String.Concat(Now.Year, _serie, recibo, "A") & "', 'PENDIENTE', 'ANTICIPO', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & CDbl(TxtAnticipo.Text) + IvAnti & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & ConsumoAnti & ", " & AlcaAnti & ", " & SaneaAnti & ", " & IvAnti & "," & recibo & ",'" & _serie & "','" & _caja & "','" & _cod_ofi & "','018NSR','" & UnixDateFormat(Now.Date) & "')")
                                End If
                                'Else
                                '    Ejecucion("insert into otrosconceptos (clave,cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, consumo, drenaje, saneamiento,repiva,factura,serie,caja,cod_ofi,id_concepto,fec_alta) values (" & nmax & "," & txtCuenta.Text & ", 'Anticipo', " & CDbl(TxtAnticipo.Text) + IvAnti & ", " & CDbl(TxtAnticipo.Text) & ", " & IvAnti & ",0,'" & UnixDateFormat(DTFecha.Value) & "', 'ANTICIPO', '" & String.Concat(Now.Year, _serie, recibo, "A") & "', 'PENDIENTE', 'ANTICIPO', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & CDbl(TxtAnticipo.Text) + IvAnti & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & ConsumoAnti & ", " & AlcaAnti & ", " & SaneaAnti & ", " & IvAnti & "," & recibo & ",'" & _serie & "','" & _caja & "','" & _cod_ofi & "','018NSR','" & UnixDateFormat(Now.Date) & "')")
                                'End If
                            Catch ex2 As Exception
                            End Try
                        End Try
                        Try
                            If Tipo_Caja = "Remota" Then
                                GuardarTxt("insert into anticipos (cuenta, id_comunidad, idmov, ofi_pago, Caja, Status, Monto, Meses, Serie, Recibo, Fecha) values (" & txtCuenta.Text & ",'" & cmbComu.SelectedValue.ToString & "', '" & Now.Year & _serie & recibo & "', '" & _cod_ofi & "', '" & _caja & "', 'A', " & CDbl(TxtAnticipo.Text) + IvAnti & "," & MesesAnti & ", '" & _serie & "'," & recibo & ", '" & UnixDateFormat(DTFecha.Value) & "' )")
                            End If
                            Ejecucion("insert into anticipos (cuenta, id_comunidad, idmov, ofi_pago, Caja, Status, Monto, Meses, Serie, Recibo, Fecha) values (" & txtCuenta.Text & ",'" & cmbComu.SelectedValue.ToString & "', '" & Now.Year & _serie & recibo & "', '" & _cod_ofi & "', '" & _caja & "', 'A', " & CDbl(TxtAnticipo.Text) + IvAnti & "," & MesesAnti & ", '" & _serie & "'," & recibo & ", '" & UnixDateFormat(DTFecha.Value) & "' )")
                        Catch ex As Exception
                            If ex.Message.Contains("ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-6.0.5-alpha-community]Duplicate") Then
                                Ejecucion("ALTER TABLE anticipos AUTO_INCREMENT =" & CDbl(obtenerCampo("select max(clave) as m from anticipos", "m")) & "")
                                Ejecucion("insert into anticipos (cuenta, id_comunidad, idmov, ofi_pago, Caja, Status, Monto, Meses, Serie, Recibo, Fecha) values (" & txtCuenta.Text & ",'" & cmbComu.SelectedValue.ToString & "', '" & Now.Year & _serie & recibo & "', '" & _cod_ofi & "', '" & _caja & "', 'A', " & CDbl(TxtAnticipo.Text) + IvAnti & "," & MesesAnti & ", '" & _serie & "'," & recibo & ", '" & UnixDateFormat(DTFecha.Value) & "' )")
                            Else
                                MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Try
                    End If
                    'Aqui se grabaron los anticipos
                    'Aqui se grabaron los anticipos
                    'Aqui se grabaron los anticipos
                    'Aqui se grabaron los anticipos
                End If
                Try
                    Dim cadenaredondeopadron As String = ""
                    If clrecibo.redondeo < 0 And clrecibo.redondear = True Then
                        '  If RRedondeo < 0.5 And RRedondeo > 0 Then
                        'CENTAVOS A CREDITO'
                        cadenaredondeopadron = "insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & txtCuenta.Text & ",'" & cmbComu.SelectedValue.ToString & "'," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
                        "024CCR','" & "CENTAVOS A CREDITO',1" & _
                        ",0," & clrecibo.redondeo & ",0," & clrecibo.redondeo & _
                        ",'A','CO','" & TxtReferencia.Text & "','abono')"
                        Ejecucion(cadenaredondeopadron)

                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(cadenaredondeopadron)
                        End If

                    ElseIf clrecibo.redondeo > 0 And clrecibo.redondear = True Then
                        '    'CENTAVOS A ABONO'
                        cadenaredondeopadron = "insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & txtCuenta.Text & ",'" & cmbComu.SelectedValue.ToString & "'," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
                       "023CCA','" & "CENTAVOS A FAVOR',1" & _
                       ",0," & clrecibo.redondeo & ",0," & clrecibo.redondeo & _
                       ",'A','CO','" & TxtReferencia.Text & "','cargo')"
                        Ejecucion(cadenaredondeopadron)

                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(cadenaredondeopadron)
                        End If
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                If chkOtros.Checked = True Then
                    For i = 0 To dgCob.Rows.Count - 1
                        Try
                            Dim subo As Double = 0, ivao As Double = 0, toto As Double = 0, cantidad As Double = 0

                            If dgCob.Item("Tipo", i).Value = "Abono" Then
                                subo = dgCob.Item("subTot", i).Value * -1
                                ivao = dgCob.Item("iva", i).Value * -1
                                toto = dgCob.Item("Total", i).Value * -1
                            Else
                                subo = dgCob.Item("subTot", i).Value
                                ivao = dgCob.Item("iva", i).Value
                                toto = dgCob.Item("Total", i).Value
                            End If
                            Dim idconcepto As String
                            If dgCob.Item("ID_CONCEPTO", i).Value = "" Then
                                idconcepto = obtenerCampo("select id_concepto from otrosconceptos where clave='" & dgCob.Item("Clave", i).Value & "'", "id_concepto")
                            Else
                                idconcepto = dgCob.Item("ID_CONCEPTO", i).Value
                            End If
                            cantidad = dgCob.Item("cantidad", i).Value

                            Ejecucion("insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov, Recargos,id_concepto) " & _
                            " values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & txtCuenta.Text & ",'" & _
                            cmbComu.SelectedValue.ToString & "'," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
                            idconcepto & "','" & dgCob.Item("concepto", i).Value & "'," & _
                            cantidad & ",0," & subo & "," & _
                            ivao & "," & toto & ",'A','CO','" & TxtReferencia.Text & "','" & dgCob.Item("Tipo", i).Value & "', " & dgCob.Item("Recargos", i).Value & "," & dgCob.Item("Clave", i).Value & ")")

                            If Tipo_Caja = "Remota" Then
                                GuardarTxt("insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov, Recargos,id_concepto) " & _
                                " values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & txtCuenta.Text & ",'" & _
                                cmbComu.SelectedValue.ToString & "'," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
                                idconcepto & "','" & dgCob.Item("concepto", i).Value & "'," & _
                                dgCob.Item("cantidad", i).Value & ",0," & subo & "," & _
                                ivao & "," & toto & ",'A','CO','" & TxtReferencia.Text & "','" & dgCob.Item("Tipo", i).Value & "', " & dgCob.Item("Recargos", i).Value & "," & dgCob.Item("Clave", i).Value & ")")
                            End If


                        Catch ex As Exception
                            MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                        Try
                            'Esta funcion actualiza los otros conceptos, aun no concibo como le hare para la caja movil
                            resta = obtenerCampo("select (resta + totrec) as resta from otrosconceptos where clave=" & dgCob.Item("clave", i).Value & "", "resta")
                            If resta = dgCob.Item("Total", i).Value Then
                                Ejecucion("update otrosconceptos set pagado=1,estado='Aplicado',resta=0, subtotResta=0,IvaResta=0,abonos=abonos + " & CDbl(dgCob.Item("Total", i).Value) & ",totrec=0 where clave=" & dgCob.Item("clave", i).Value & "")
                                If Tipo_Caja = "Remota" Then
                                    GuardarTxt("update otrosconceptos set pagado=1,resta=0,subtotResta=0,IvaResta=0,abonos=abonos+" & CDbl(dgCob.Item("Total", i).Value) & " where clave=" & dgCob.Item("clave", i).Value & "")
                                End If
                            Else
                                resta -= CDbl(dgCob.Item("Total", i).Value)
                                Ejecucion("update otrosconceptos set vencimiento='" & UnixDateFormat(DateAdd(DateInterval.Day, 8, DTFecha.Value)) & "',resta=" & resta & ",estado='Abonado',subtotResta=subtotResta-" & CDbl(dgCob.Item("SubTot", i).Value) & ", IvaResta = IvaResta - " & CDbl(dgCob.Item("IVA", i).Value) & ", abonos = abonos + " & CDbl(dgCob.Item("Total", i).Value) & " where clave=" & dgCob.Item("clave", i).Value & "")
                                If Tipo_Caja = "Remota" Then
                                    GuardarTxt("update otrosconceptos set vencimiento='" & UnixDateFormat(DateAdd(DateInterval.Day, 8, DTFecha.Value)) & "', resta=" & resta & ", subtotResta = subtotResta - " & CDbl(dgCob.Item("SubTot", i).Value) & ",IvaResta=IvaResta-" & CDbl(dgCob.Item("IVA", i).Value) & ",abonos=abonos+" & CDbl(dgCob.Item("Total", i).Value) & " where clave=" & dgCob.Item("clave", i).Value & "")
                                End If
                            End If
                            If dgCob.Item("Tipo", i).Value = "Abono" Then
                                Ejecucion("Update abonos set facApli = " & recibo & ", serapli = '" & _serie & "', fecApli = '" & UnixDateFormat(Now.Date) & "' where idmov = " & dgCob.Item("clave", i).Value & " ")
                                If Tipo_Caja = "Remota" Then
                                    GuardarTxt("Update abonos set facApli = " & recibo & ", serapli = '" & _serie & "', fecApli = '" & UnixDateFormat(Now.Date) & "' where idmov = " & dgCob.Item("clave", i).Value & " ")
                                End If
                            End If
                        Catch ex As Exception
                            MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                        'Da por pagado el convenio
                        If obtenerCampo("select tabla from otrosconceptos where clave=" & dgCob.Item("clave", i).Value & "", "tabla") = "CONVENIOS" Then
                            Try
                                idconvenio2 = ConsultaSql("select sum(subtotresta+ ivaresta)  as ok from otrosconceptos where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and id_concepto='110PAG'").ExecuteReader()
                                idconvenio2.Read()
                                matti = Split(dgCob.Item("concepto", i).Value)
                                If idconvenio2("ok") <= 0 Then
                                    Ejecucion("update convenios set status='Pagado', resta=0 where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and status='Activo' and no_convenio='" & matti(0) & "'")
                                Else
                                    Ejecucion("update convenios set resta=" & idconvenio2("ok") & " where cuenta=" & txtCuenta.Text & " and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and status='Activo' and no_convenio='" & matti(0) & "'")
                                End If
                            Catch ex As Exception
                            End Try
                        End If
                    Next
                End If

                If TxtRedondeo.Visible = True Then
                    Dim CADENACENTAVOS As String = ""
                    ' If CDbl(TxtRedondeo.Text) < 0.5 And CDbl(TxtRedondeo.Text) > 0 Then
                    If clrecibo.redondeo < 0 And clrecibo.redondear = True Then
                        CADENACENTAVOS = "insert into otrosconceptos (cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, subtotresta,ID_CONCEPTO)" & _
                            "values(" & txtCuenta.Text & ", 'CENTAVOS A CREDITO', " & Math.Abs(CDbl(TxtRedondeo.Text)) & ", " & Math.Abs(CDbl(TxtRedondeo.Text)) & ", 0,0,'" & UnixDateFormat(DTFecha.Value) & "', 'CENTAVOS A CREDITO', '" & Now.Year & _serie & recibo & "', 'PENDIENTE', 'REDONDEO', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & Math.Abs(CDbl(TxtRedondeo.Text)) & ", 'Cargo','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & Math.Abs(CDbl(TxtRedondeo.Text)) & ",'024CCR')"
                        Try
                            Ejecucion(CADENACENTAVOS)
                        Catch ex As Exception
                            If ex.Message.Contains("Duplicate") Then
                                Ejecucion("alter table otrosconceptos AUTO_INCREMENT=" & obtenerCampo("select max(clave) as m from otrosconceptos", "m") & "")
                                Ejecucion(CADENACENTAVOS)
                            Else
                                MessageBoxEx.Show(ex.Message, "CAJAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Try
                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(CADENACENTAVOS)
                        End If
                    ElseIf clrecibo.redondeo > 0 And clrecibo.redondear = True Then
                        CADENACENTAVOS = "insert into otrosconceptos (cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, subtotresta,ID_CONCEPTO)" & _
                                   " values (" & txtCuenta.Text & ", 'CENTAVOS A FAVOR', " & CDbl(TxtRedondeo.Text) & ", " & CDbl(TxtRedondeo.Text) & ", 0,0,'" & UnixDateFormat(DTFecha.Value) & "', 'CENTAVOS A ABONO', '" & Now.Year & _serie & recibo & "', 'PENDIENTE', 'REDONDEO', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & CDbl(TxtRedondeo.Text) & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & CDbl(TxtRedondeo.Text) & ",'023CCA')"
                        Try
                            Ejecucion(CADENACENTAVOS)
                        Catch ex As Exception
                            If ex.Message.Contains("ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-6.0.5-alpha-community]Duplicate") Then
                                Ejecucion("alter table otrosconceptos AUTO_INCREMENT=" & obtenerCampo("select max(clave) as m from otrosconceptos", "m") & "")
                                Ejecucion(CADENACENTAVOS)
                            Else
                                MessageBoxEx.Show(ex.Message, "CAJAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Try

                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(CADENACENTAVOS)
                        End If
                    End If
                End If
            ElseIf RBFactibilidades.Checked = True Then
volver2:
                Try
                    'Registrar pago en el sistema y en caso de ser caja remota actualizar archivo 
                    Ejecucion("insert into pagos values('" & UnixDateFormat(DTFecha.Value.Date) & "'," & TxtSolicitud.Text & ",'','',0,'',0,0,0,0," & CDbl(txtSubTot.Text) & "," & CDbl(txtIva.Text) & ",0,0," & _
                    CDbl(txtSubTot.Text) & ",0," & CDbl(txtTotal.Text) & ",'" & txtNombre.Text & "'," & recibo & ",'A'," & porDesc & ",' ','" & _
                    _serie & "'," & _ope & ",'" & Tar & "','CO','" & TxtReferencia.Text & "',False,0,'N','" & _cod_ofi & "','" & _caja & "', 0, '" & TxtObservacion.Text & "', '" & TimeString & "', " & _num_ope & ", 'Factibilidad', null, null, null, null, '" & _ID_CROAPE & "')")

                    If Tipo_Caja = "Remota" Then
                        GuardarTxt("insert into pagos values('" & UnixDateFormat(DTFecha.Value.Date) & "'," & TxtSolicitud.Text & ",'','',0,'',0,0,0,0," & CDbl(txtSubTot.Text) & "," & CDbl(txtIva.Text) & ",0,0," & _
                        CDbl(txtSubTot.Text) & ",0," & CDbl(txtTotal.Text) & ",'" & txtNombre.Text & "'," & recibo & ",'A'," & porDesc & ",' ','" & _
                        _serie & "'," & _ope & ",'" & Tar & "','CO','" & TxtReferencia.Text & "',False,0,'N','" & _cod_ofi & "','" & _caja & "', 0, '" & TxtObservacion.Text & "', '" & TimeString & "', " & _num_ope & ", 'Factibilidad', null, null, null, null, '" & _ID_CROAPE & "')")
                    End If
                Catch ex As Exception
                    recibo = obtenerCampo("Select max(recibo) as rec from pagos where serie = '" & _serie & "'", "rec") + 1
                    MessageBoxEx.Show("El folio que se selecciono ya existe, su folio siguiente es el: " & recibo, "Cambio de folio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo volver2
                End Try
                Try
                    'Registrar pago en el esclavo de pagos por concepto de factibilidad 
                    Ejecucion("insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & TxtSolicitud.Text & ",' '," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','000FAC','ESTUDIO DE FACTIBILIDAD',1,0," & CDbl(TxtFactibilidad.Text) & "," & _
                    CDbl(TxtFactibilidad.Text) * 0.16 & "," & CDbl(TxtFactibilidad.Text) * 1.16 & ",'A','CO','" & TxtReferencia.Text & "', 'Cargo')")
                    'Actualizar la factibilidad si ya pago 
                    Ejecucion("update solicitud set pagfac = 's', estadosolicitud = 'EN PROCESO' where numero = " & TxtSolicitud.Text & "")

                    If Tipo_Caja = "Remota" Then
                        GuardarTxt("insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & TxtSolicitud.Text & ",' '," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','000FAC','ESTUDIO DE FACTIBILIDAD',1,0," & CDbl(TxtFactibilidad.Text) & "," & _
                        CDbl(TxtFactibilidad.Text) * 0.16 & "," & CDbl(TxtFactibilidad.Text) * 1.16 & ",'A','CO','" & TxtReferencia.Text & "', 'Cargo')")
                        GuardarTxt("update solicitud set pagfac = 's' where numero = " & TxtSolicitud.Text & "")
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
Volver3:
                Try
                    'Registrar el pago
                    Ejecucion("insert into pagos values('" & UnixDateFormat(DTFecha.Value) & "'," & CmbNousuarios.SelectedValue.ToString & ",'','',0,'',0,0,0,0," & CDbl(txtSubTot.Text) & "," & CDbl(txtIva.Text) & ",0,0," & _
                    CDbl(txtSubTot.Text) & ",0," & CDbl(txtTotal.Text) & ",'" & txtNombre.Text & "'," & recibo & ",'A'," & porDesc & ",' ','" & _
                    _serie & "'," & _ope & ",'" & Tar & "','CO','" & TxtReferencia.Text & "',False,0,'N','" & _cod_ofi & "','" & _caja & "', 0, '" & TxtObservacion.Text & "', '" & TimeString & "', " & _num_ope & ", 'NoUsuario', null, null, null, null, '" & _ID_CROAPE & "')")

                    'Si es caja remota agregarlo al archivo temporal
                    If Tipo_Caja = "Remota" Then
                        GuardarTxt("insert into pagos values('" & UnixDateFormat(DTFecha.Value) & "'," & CmbNousuarios.SelectedValue.ToString & ",'','',0,'',0,0,0,0," & CDbl(txtSubTot.Text) & "," & CDbl(txtIva.Text) & ",0,0," & _
                        CDbl(txtSubTot.Text) & ",0," & CDbl(txtTotal.Text) & ",'" & txtNombre.Text & "'," & recibo & ",'A'," & porDesc & ",' ','" & _
                        _serie & "'," & _ope & ",'" & Tar & "','CO','" & TxtReferencia.Text & "',False,0,'N','" & _cod_ofi & "','" & _caja & "', 0, '" & TxtObservacion.Text & "', '" & TimeString & "', " & _num_ope & ", 'NoUsuario', null, null, null, null, '" & _ID_CROAPE & "')")
                    End If

                Catch ex As Exception
                    recibo = obtenerCampo("Select max(recibo) as rec from pagos where serie = '" & _serie & "'", "rec") + 1
                    MessageBoxEx.Show("El folio que se selecciono ya existe, su folio siguiente es el: " & recibo, "Cambio de folio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo volver3
                End Try
                'Agregar los otros cargos
                For i = 0 To dgCob.Rows.Count - 1
                    Try
                        Dim cadenanousuario As New StringBuilder
                        cadenanousuario.Append("insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov )")
                        cadenanousuario.Append(" values (" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & CmbNousuarios.SelectedValue.ToString & ",''," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','")
                        cadenanousuario.Append(dgCob.Item("clave", i).Value & "','" & dgCob.Item("concepto", i).Value & "',")
                        cadenanousuario.Append(dgCob.Item("cantidad", i).Value & ",0," & dgCob.Item("subTot", i).Value & ",")
                        cadenanousuario.Append(dgCob.Item("iva", i).Value & "," & dgCob.Item("Total", i).Value & ",'A','CO','" & TxtReferencia.Text & "','" & dgCob.Item("Tipo", i).Value & "')")
                        Ejecucion(cadenanousuario.ToString)
                        'Agregar los otros cargos a pagos temporal
                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(cadenanousuario.ToString)
                        End If
                    Catch ex As Exception
                        MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    'añado el pago del redondeo
                Next
                Try
                    Dim cadenaredondeopadron As String = ""
                    If clrecibo.redondeo < 0 And clrecibo.redondear = True Then
                        'If RRedondeo < 0.5 And RRedondeo > 0 Then
                        'CENTAVOS A CREDITO'
                        cadenaredondeopadron = "insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & CmbNousuarios.SelectedValue.ToString & ",''," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
                        "024CCR','" & "CENTAVOS A CREDITO',1" & _
                        ",0," & clrecibo.redondeo & ",0," & clrecibo.redondeo & _
                        ",'A','CO','" & TxtReferencia.Text & "','abono',0)"
                        Ejecucion(cadenaredondeopadron)

                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(cadenaredondeopadron)
                        End If

                    ElseIf clrecibo.redondeo > 0 And clrecibo.redondear = True Then
                        ''CENTAVOS A ABONO'
                        cadenaredondeopadron = "insert into pagotros (Recibo, COD_OFI, id_caja, serie, Cuenta, ID_COMUNIDAD, Usuario, Fecha, NumConcepto, Concepto, Cantidad, pDesc, SubTotal, IVA, Total, Cancelado, Ccodpago, Referencia, Tipo_Mov) values(" & recibo & ",'" & _cod_ofi & "','" & _caja & "','" & _serie & "'," & CmbNousuarios.SelectedValue.ToString & ",''," & _ope & ",'" & UnixDateFormat(DTFecha.Value) & "','" & _
                       "023CCA','" & "CENTAVOS A FAVOR',1" & _
                       ",0," & clrecibo.redondeo & ",0," & clrecibo.redondeo & _
                       ",'A','CO','" & TxtReferencia.Text & "','cargo',0)"
                        Ejecucion(cadenaredondeopadron)

                        If Tipo_Caja = "Remota" Then
                            GuardarTxt(cadenaredondeopadron)
                        End If
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                Try
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Try
                    'Desactivar cuenta
                    Ejecucion("delete from conceptosnousuario where nousuario = " & CmbNousuarios.SelectedValue.ToString & "")
                    Ejecucion("update nousuarios set activo = 0 where clave = " & CmbNousuarios.SelectedValue.ToString & "")
                    If Tipo_Caja = "Remota" Then
                        GuardarTxt("delete from conceptosnousuario where nousuario = " & CmbNousuarios.SelectedValue.ToString & "")
                        GuardarTxt("update nousuarios set activo = 0 where clave = " & CmbNousuarios.SelectedValue.ToString & "")
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            Try
                Ejecucion("update croape set num_ope = " & _num_ope & ", fol_fin = " & recibo & ", ing_tot= ing_tot + " & CDbl(txtTotal.Text) & " where maquina = '" & My.Computer.Name & "' and fec_ape = curdate() and statusa = 'A'")
                Ejecucion("update cajas set folio=" & recibo & " where id_caja='" & _caja & "' and cod_ofi='" & _cod_ofi & "'")

                If Tipo_Caja = "Remota" Then
                    GuardarTxt("update croape set num_ope = " & _num_ope & ", fol_fin = " & recibo & ", ing_tot= ing_tot + " & CDbl(txtTotal.Text) & " where maquina = '" & My.Computer.Name & "'and fec_ape = curdate() and statusa = 'A'")
                    GuardarTxt("update cajas set folio=" & recibo & " where id_caja='" & _caja & "' and cod_ofi='" & _cod_ofi & "'")
                End If
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            crea_detallepago(recibo)
            ImprimirFactura()

            'Falta el de la caja remota



            '  Threading.Thread.Sleep(2000)
            recibo += 1
            LblRecibo.Text = recibo
            LblSerie.Text = _serie

            'MessageBoxEx.Show("Cobro Guardado correctamente", "Cobros", MessageBoxButtons.OK, MessageBoxIcon.Information) 
            'CmbPeriodos.Text = "" 
            'AceptarBusqueda() 
        End If
        If OPC = 2 Then
            txtCuenta.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim com As String = ""
        If Not RBNoPadron.Checked Then
            com = cmbComu.SelectedValue.ToString
        End If
        AceptarRecibo()
        cmdAgr_Click(New Object, New System.EventArgs)
        ExFpago.Expanded = False
        cmbComu.SelectedValue = com
        cmbComu.Text = obtenerCampo("select comunidad from comunidades where id_comunidad='" & com & "'", "comunidad")
    End Sub
#End Region

    Private Sub chkOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOtros.CheckedChanged
        'If Mes() = 12 And Anio() = Year(Now) Then
        '    llenatotanti(Mes, Anio)
        'Else
        '    llenatot(Mes, Anio)
        'End If
        CALCULO()
    End Sub

#Region "impresión de facturas Israel"
    Private Sub ImprimirFactura2()
        Dim clrecibo2 As New Clsrecibo
        clrecibo2 = clrecibo
        Dim cadena As String = "", direc As String = "", direc2 As String = "", direc3 As String = "", Nom As String = ""
        Dim Validacion As String = _ope & "/" & "/" & _caja & "/" & _num_ope & "/" & Now.Date & "/" & Now.Hour & "/" & CDbl(txtTotal.Text)
        Dim idest As IDataReader = Nothing
        Dim cont As Double = 0, dret As Double = 0, sant As Double = 0, rect As Double = 0, ivat As Double = 0, otrt As Double = 0, anti As Double = 0
        Dim UFpago As Date = Nothing
        Dim cuad As Int16 = 0
        Dim c1 As Integer = 0, f1 As Integer = 0
        Dim impUbi As Boolean = False

        Dim imp As New clsImpMili(c1, f1, , 8, 75, 75)
        Dim datos As IDataReader = Nothing

        For cuad = 1 To 1
            If cuad = 1 Then
                c1 = 0
                f1 = 0
            Else
                c1 = 5850
                f1 = 0
            End If
            imp.Columna = c1
            imp.Fila = f1

            Nom = txtNombre.Text
            direc = txtCalle.Text & " " & txtNumExt.Text & " " & txtNumInt.Text
            direc2 = txtCol.Text
            direc3 = txtCom.Text
            If RBUsuarios.Checked = True And ChkDirFis.Checked = True Then
                Nom = lblDirFis1.Text
                direc = lblDirFis2.Text
                direc3 = LblDirFis3.Text
                direc2 = LblDirFis4.Text
            End If
            imp.Imprimir(5000, 200, _serie & "   " & recibo)
            imp.Imprimir(13800, 1400, _serie & "   " & recibo, , 7)
            'Cuenta
            If RBUsuarios.Checked = True Then
                imp.Imprimir(3900, 800, idComu & "  " & txtCuenta.Text, , 7)
                imp.Imprimir(2000, 800, obtenerCampo("SELECT * FROM usuario WHERE cuenta=" & txtCuenta.Text & " and id_comunidad='" & idComu & "'", "clave_predial"), , 7)
                imp.Imprimir(12800, 1400, idComu & "  " & txtCuenta.Text, , 7)
                imp.Imprimir(11050, 1400, obtenerCampo("SELECT * FROM usuario WHERE cuenta=" & txtCuenta.Text & " and id_comunidad='" & idComu & "'", "clave_predial"), , 7)
            ElseIf RBFactibilidades.Checked = True Then
                imp.Imprimir(1000, 800, TxtSolicitud.Text, , 7)
            ElseIf RBNoPadron.Checked = True Then
                imp.Imprimir(1000, 800, CmbNousuarios.SelectedValue.ToString, , 7)
            End If

            'Dim codgir As String
            'Dim m3, M33 As Integer
            'codgir = obtenerCampo("SELECT * FROM usuario WHERE cuenta=" & txtCuenta.Text & " and id_comunidad='" & idComu & "'", "cod_gir")
            'm3 = obtenerCampo("select * from giro where codgir='" + codgir + "'", "pro_anual")

            Dim M3 As Integer
            CONSULTA = ConsultaSql("SELECT sum(CON_M3) AS SM3 FROM ESTADOS WHERE CUENTA='" & Trim(txtCuenta.Text) & "'AND AN_PER='" & Val(Year(Now) - 1) & "'").ExecuteReader
            If CONSULTA.Read() Then
                If Not DBNull.Value.Equals(CONSULTA("SM3")) Then
                    M3 = CONSULTA("SM3") / 12
                Else
                    M3 = 0
                End If
            End If

            'Fecha de pago
            imp.Imprimir(1000, 800, Now.Date, , 7)
            imp.Imprimir(10100, 1400, Now.Date, , 7)

            'Nombre
            imp.Imprimir(4950, 800, Nom, , 7)
            imp.Imprimir(10100, 6200, Nom, , 7)
            'Dirección
            imp.Imprimir(4950, 1000, direc, , 7)
            imp.Imprimir(10100, 800, direc, , 7)


            'Colonia
            imp.Imprimir(4950, 1200, direc2, , 7)
            'Comunidad
            imp.Imprimir(4950, 1400, direc3, , 7)

            'RFC
            imp.Imprimir(4950, 1600, txtRfc.Text, , 7)

            If RBUsuarios.Checked = True Then

                'Ubicacion
                'imp.Imprimir(5400, 2050, Ubicacion)

                'Tarifa
                If cuad = 1 Then
                    imp.Imprimir(3700, 2050, Tar, , 7)
                    imp.Imprimir(14100, 1900, Tar, , 7)
                Else
                    imp.Imprimir(3800, 2000, Tar, , 7)
                End If


                'Periodo de consumo
                If LabelX7.Text = "PERIODO FACTURADO" Then
                    imp.Imprimir(1000, 2050, txtPer.Text, , 7)
                    imp.Imprimir(10100, 2050, txtPer.Text, , 7)
                End If

                'Texto de Validacion
                'imp.Imprimir(3500, 4000, Validacion)





                Dim ok() As String = Nothing
                Try
                    ok = Split(txtPer.Text, "-")
                Catch ex As Exception

                End Try

                Dim lecan As Double = 0, lecac As Double = 0, conl As Double = 0
                Try
                    lecan = obtenerCampo("select lecturaant from lecturas where cuenta=" & txtCuenta.Text & " and comunidad='" & cmbComu.SelectedValue.ToString & "' and ucase(concat(mes,' ',an_per))='" & ok(0).Trim & "'", "lecturaant")
                    lecac = obtenerCampo("select lectura from lecturas where cuenta=" & txtCuenta.Text & " and comunidad='" & cmbComu.SelectedValue.ToString & "' and ucase(concat(mes,' ',an_per))='" & ok(1).Trim & "'", "lectura")
                Catch ex As Exception

                End Try





                'Lectura Anterior
                imp.Imprimir(1700, 1400, lecac, , 7)

                'Lectura Actual
                imp.Imprimir(2800, 1400, lecan, , 7)
                'Consumo en metros cúbicos
                imp.Imprimir(3700, 1400, lecac - lecan, , 7)
                'Numero de medidor
                'If Medidor = "0" Or Medidor = "" Then Medidor = "S/M"
                'imp.Imprimir(2600, 1400, Medidor, , 7)

            End If
            Dim LINEAIMPORTE As Integer = 8500
            Dim LINEAIMPORTE2 As Integer = 14200
            If cuad = 2 Then
                LINEAIMPORTE = 400
            End If


            Dim y As Integer
            If RBUsuarios.Checked = True Then
                If Convenio = True Then
                    y = 2700
                    imp.Imprimir(700, y, "ANTICIPO DE CONVENIO", , 7)
                    imp.Imprimir(LINEAIMPORTE, y, FormatCurrency(clrecibo2.Subtotal, 2), , 7)
                    imp.Imprimir(10100, y, "ANTICIPO DE CONVENIO", , 7)
                    imp.Imprimir(LINEAIMPORTE2, y, FormatCurrency(clrecibo2.Subtotal, 2), , 7)
                Else
                    If ChkConsumo.CheckState = CheckState.Checked Then
                        y = 2700
                        'Rezagos
                        If CDbl(txtReza.Text) <> 0 Then
                            imp.Imprimir(700, y, "REZAGOS", , 7)
                            imp.Imprimir(LINEAIMPORTE, y, txtReza.Text, , 7, clsImpMili.Alineación.Derecha)
                            imp.Imprimir(10100, y, "REZAGOS", , 7)
                            imp.Imprimir(LINEAIMPORTE2, y, txtReza.Text, , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        End If
                        'Consumo
                        If CDbl(txtConsumo.Text) <> 0 Then
                            imp.Imprimir(700, y, "CONSUMO", , 7)
                            imp.Imprimir(LINEAIMPORTE, y, txtConsumo.Text, , 7, clsImpMili.Alineación.Derecha)
                            imp.Imprimir(10100, y, "CONSUMO", , 7)
                            imp.Imprimir(LINEAIMPORTE2, y, txtConsumo.Text, , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        End If
                        'Drenaje
                        If CDbl(txtAlcanta.Text) <> 0 Then
                            imp.Imprimir(700, y, "DRENAJE", , 7)
                            imp.Imprimir(LINEAIMPORTE, y, txtAlcanta.Text, , 7, clsImpMili.Alineación.Derecha)
                            imp.Imprimir(10100, y, "DRENAJE", , 7)
                            imp.Imprimir(LINEAIMPORTE2, y, txtAlcanta.Text, , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        End If
                        'Saneamiento
                        If CDbl(txtSaneamiento.Text) <> 0 Then
                            imp.Imprimir(700, y, "SANEAMIENTO", , 7)
                            imp.Imprimir(LINEAIMPORTE, y, txtSaneamiento.Text, , 7, clsImpMili.Alineación.Derecha)
                            imp.Imprimir(10100, y, "SANEAMIENTO", , 7)
                            imp.Imprimir(LINEAIMPORTE2, y, txtSaneamiento.Text, , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        End If
                        'Recargos
                        If CDbl(txtReca.Text) <> 0 Then
                            imp.Imprimir(700, y, "RECARGOS", , 7)
                            imp.Imprimir(LINEAIMPORTE, y, txtReca.Text, , 7, clsImpMili.Alineación.Derecha)
                            imp.Imprimir(700, y, "RECARGOS", , 7)
                            imp.Imprimir(LINEAIMPORTE2, y, txtReca.Text, , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        End If
                        'Anticipo
                        If CDbl(TxtAnticipo.Text) <> 0 Then
                            Dim medido As Integer = obtenerCampo("select medido from cuotas where id_tarifa='" & Tar & "'", "medido")
                            If medido = 0 Then
                                imp.Imprimir(700, y, "ANTICIPO CONSUMO ESTIMADO HASTA EL MES DE" & CmbPeriodos.Text, , 7)
                                imp.Imprimir(LINEAIMPORTE, y, TxtAnticipo.Text, , 7, clsImpMili.Alineación.Derecha)
                            Else
                                imp.Imprimir(700, y, "ANTICIPO CONSUMO ESTIMADO DE AGUA " & M3 & " M3 MESUALES", , 7)
                                imp.Imprimir(LINEAIMPORTE, y, TxtAnticipo.Text, , 7, clsImpMili.Alineación.Derecha)
                            End If

                            imp.Imprimir(10100, y, "ANTICIPO ", , 7)
                            imp.Imprimir(LINEAIMPORTE2, y, TxtAnticipo.Text, , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        End If

                        If TxtRedondeo.Visible = True And Val(TxtRedondeo.Text) <> 0 Then
                            If clrecibo2.redondeo < 0 And clrecibo2.redondear = True Then
                                '  If RRedondeo < 0.5 And RRedondeo > 0 Then
                                'CENTAVOS A CREDITO'
                                imp.Imprimir(700, y, "CENTAVOS A CREDITO")
                                'imp.Imprimir(8650, y, TxtRedondeo.Text, , , clsImpMili.Alineación.Derecha)
                                imp.Imprimir(LINEAIMPORTE, y, FormatCurrency(clrecibo2.redondeo, 2), , , clsImpMili.Alineación.Derecha)
                            ElseIf clrecibo2.redondeo > 0 And clrecibo2.redondear = True Then
                                '    'CENTAVOS A ABONO'
                                imp.Imprimir(2600, y, "CENTAVOS A FAVOR")
                                ' imp.Imprimir(8650, y, TxtRedondeo.Text, , , clsImpMili.Alineación.Derecha)
                                imp.Imprimir(LINEAIMPORTE, y, FormatCurrency(clrecibo2.redondeo), , , clsImpMili.Alineación.Derecha)
                            End If
                            'End If
                            y += 200
                        End If
                    Else

                        y = 2700
                    End If
                    If chkOtros.CheckState = CheckState.Checked Then
                        If CDbl(TxtRecargoOtros.Text) <> 0 Then
                            imp.Imprimir(700, y, "RECARGOS DE OTROS CONCEPTOS", , 7)
                            imp.Imprimir(LINEAIMPORTE, y, TxtRecargoOtros.Text, , , clsImpMili.Alineación.Derecha)
                            imp.Imprimir(10100, y, "RECARGOS ", , 7)
                            imp.Imprimir(LINEAIMPORTE2, y, TxtRecargoOtros.Text, , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        End If

                        For m = 0 To dgCob.RowCount - 1
                            imp.Imprimir(700, y, dgCob.Item("Concepto", m).Value)
                            imp.Imprimir(LINEAIMPORTE, y, FormatCurrency(dgCob.Item("Subtot", m).Value, 2), , 7, clsImpMili.Alineación.Derecha)
                            imp.Imprimir(10100, y, dgCob.Item("Concepto", m).Value)
                            imp.Imprimir(LINEAIMPORTE2, y, FormatCurrency(dgCob.Item("Subtot", m).Value, 2), , 7, clsImpMili.Alineación.Derecha)
                            y += 200
                        Next
                    End If
                End If
            ElseIf RBFactibilidades.Checked = True Then
                y = 5400
                'Pago de la factibilidad
                imp.Imprimir(700, 4300, "FACTIBILIDAD")
                imp.Imprimir(LINEAIMPORTE, 4300, TxtFactibilidad.Text, , , clsImpMili.Alineación.Derecha)
                imp.Imprimir(700, 4300, "FACTIBILIDAD")
                imp.Imprimir(LINEAIMPORTE2, 4300, TxtFactibilidad.Text, , , clsImpMili.Alineación.Derecha)
            ElseIf RBNoPadron.Checked = True Then
                y = 5400
                For m = 0 To dgCob.RowCount - 1
                    imp.Imprimir(2600, y, Mid(dgCob.Item("Concepto", m).Value, 1, 18))
                    imp.Imprimir(LINEAIMPORTE, y, FormatCurrency(dgCob.Item("Subtot", m).Value, 2), , 7, clsImpMili.Alineación.Derecha)
                    imp.Imprimir(10100, y, Mid(dgCob.Item("Concepto", m).Value, 1, 18))
                    imp.Imprimir(LINEAIMPORTE2, y, FormatCurrency(dgCob.Item("Subtot", m).Value, 2), , 7, clsImpMili.Alineación.Derecha)
                    y += 200
                Next
            End If

            '********************************
            'Totales
            '********************************
            'Monto en letra
            imp.Imprimir(400, 5500, "(" & ConvertCurrencyToSpanish(txtTotal.Text, "Pesos", False) & ")", , 7)
            imp.Imprimir(10100, 4500, "(" & ConvertCurrencyToSpanish(txtTotal.Text, "Pesos", False) & ")", , 7)

            'Subtotal
            imp.Imprimir(8500, 5050, FormatCurrency(clrecibo2.Subtotal, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            imp.Imprimir(14200, 5050, FormatCurrency(clrecibo2.Subtotal, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            'Iva
            imp.Imprimir(8500, 5350, FormatCurrency(clrecibo2.IVA, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            imp.Imprimir(14200, 5350, FormatCurrency(clrecibo2.IVA, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            'Total a pagar
            imp.Imprimir(8500, 5650, FormatCurrency(clrecibo2.Total, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            imp.Imprimir(14200, 5650, FormatCurrency(clrecibo2.Total, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            'Texto de Agradecimiento
            imp.Imprimir(800, 6200, "GRACIAS POR SU PAGO", , 7.5)
            'If cuad = 2 Then
            imp.MandarDocumento()
            Exit Sub
            'End If
        Next
        '  limpiar()
    End Sub

#End Region

#Region "Impresión de facturas Robert"

    'Private Sub ImprimirFactura()
    '    Dim cadena As String = "", direc As String = "", direc2 As String = "", direc3 As String = "", Nom As String = ""
    '    Dim Validacion As String = _ope & "/" & _caja & "/" & _num_ope & "/" & Now.Date & "/" & Now.Hour & "/" & CDbl(txtTotal.Text)
    '    Dim idest As IDataReader = Nothing
    '    Dim cont As Double = 0, dret As Double = 0, sant As Double = 0, rect As Double = 0, ivat As Double = 0, otrt As Double = 0, anti As Double = 0
    '    Dim UFpago As Date = Nothing
    '    Dim cuad As Int16 = 0
    '    Dim c1 As Integer = 1450, f1 As Integer = -300
    '    Dim impUbi As Boolean = False

    '    'Dim RecSubtot, RecIva, RecTot As Double

    '    'RecSubtot = CDbl(txtSubTot.Text)
    '    'RecIva = CDbl(txtIva.Text)
    '    'RecTot = CDbl(txtTotal.Text)


    '    Dim imp As New clsImpMili(c1, f1, "Draft", , 75, 75)
    '    Dim datos As IDataReader = Nothing

    '    'For cuad = 1 To 2
    '    '    If cuad = 1 Then
    '    '        c1 = 0
    '    '        f1 = 0
    '    '    Else
    '    '        c1 = 6500
    '    '        f1 = 0
    '    '    End If
    '    imp.Columna = c1
    '    imp.Fila = f1

    '    Nom = txtNombre.Text
    '    direc = txtCalle.Text & " " & txtNumExt.Text & " " & txtNumInt.Text
    '    direc2 = txtCol.Text
    '    direc3 = txtCom.Text
    '    If RBUsuarios.Checked = True And ChkDirFis.Checked = True Then
    '        Nom = lblDirFis1.Text
    '        direc = lblDirFis2.Text
    '        direc3 = LblDirFis3.Text
    '        direc2 = LblDirFis4.Text
    '    End If
    '    '¿?
    '    'imp.Imprimir(1050, 800, _serie & "   " & recibo)
    '    'Cuenta
    '    If RBUsuarios.Checked = True Then
    '        imp.Imprimir(2200, 1050, Chr(14) & idComu & "    " & txtCuenta.Text)
    '    ElseIf RBFactibilidades.Checked = True Then
    '        imp.Imprimir(2200, 1050, TxtSolicitud.Text)
    '    ElseIf RBNoPadron.Checked = True Then
    '        imp.Imprimir(2200, 1050, CmbNousuarios.SelectedValue.ToString)
    '    End If

    '    'Fecha de pago
    '    imp.Imprimir(7600, 1050, Now.Date)

    '    'Nombre
    '    imp.Imprimir(2200, 1400, Nom)
    '    'Dirección
    '    imp.Imprimir(2200, 1700, direc, ",", direc2)
    '    ''Colonia
    '    'imp.Imprimir(0, 2600, direc2)
    '    ''Comunidad
    '    'imp.Imprimir(0, 2800, direc3)

    '    'Comunidad
    '    imp.Imprimir(2200, 2200, direc3)
    '    ''RFC
    '    imp.Imprimir(6500, 2450, txtRfc.Text)

    '    If RBUsuarios.Checked = True Then

    '        'Ubicacion
    '        'imp.Imprimir(5700, 2150, Ubicacion)

    '        'Tarifa
    '        'imp.Imprimir(6100, 3300, Tar)

    '        'Periodo de consumo
    '        imp.Imprimir(2500, 2850, txtPer.Text)

    '        ''Texto de Validacion
    '        'imp.Imprimir(3500, 4700, Validacion)

    '        ''Texto de Agradecimiento
    '        'imp.Imprimir(3500, 4900, "GRACIAS POR SU PAGO")

    '        'Lectura Anterior
    '        imp.Imprimir(1950, 3900, TxtLecAnterior.Text)
    '        'Lectura Actual
    '        imp.Imprimir(800, 3900, TxtLecActual.Text)
    '        'Consumo en metros cúbicos
    '        imp.Imprimir(3500, 3900, CDbl(TxtLecActual.Text) - CDbl(TxtLecAnterior.Text))
    '        'Numero de medidor
    '        'If Medidor = "0" Or Medidor = "" Then Medidor = "SIN MEDIDOR"
    '        'imp.Imprimir(2450, 4900, Medidor)
    '    End If


    '    Dim y As Integer
    '    If RBUsuarios.Checked = True Then
    '        If Convenio = True Then
    '            y = 5200
    '            imp.Imprimir(1500, y, "ANTICIPO DE CONVENIO")
    '            'imp.Imprimir(8650, y, FormatCurrency(txtSubTot.Text, 2))
    '            imp.Imprimir(8650, y, FormatCurrency(RSubTot, 2))
    '        Else
    '            If ChkConsumo.CheckState = CheckState.Checked Then
    '                y = 5200
    '                'Rezagos
    '                If RRezago > 0 Then
    '                    imp.Imprimir(1500, y, "REZAGOS")
    '                    'imp.Imprimir(8650, y, txtReza.Text, , , clsImpMili.Alineación.Derecha)
    '                    imp.Imprimir(8650, y, FormatCurrency(RRezago, 2), , , clsImpMili.Alineación.Derecha)
    '                    y += 200
    '                End If
    '                'Consumo
    '                If RConsumo > 0 Then
    '                    imp.Imprimir(1500, y, "CONSUMO")
    '                    'imp.Imprimir(8650, y, txtConsumo.Text, , , clsImpMili.Alineación.Derecha)
    '                    imp.Imprimir(8650, y, FormatCurrency(RConsumo, 2), , , clsImpMili.Alineación.Derecha)
    '                    y += 200
    '                End If
    '                'Drenaje
    '                If RAlcanta > 0 Then
    '                    imp.Imprimir(1500, y, "DRENAJE")
    '                    'imp.Imprimir(8650, y, txtAlcanta.Text, , , clsImpMili.Alineación.Derecha)
    '                    imp.Imprimir(8650, y, FormatCurrency(RAlcanta, 2), , , clsImpMili.Alineación.Derecha)
    '                    y += 200
    '                End If
    '                'Saneamiento
    '                If RSanea > 0 Then
    '                    imp.Imprimir(1500, y, "SANEAMIENTO")
    '                    'imp.Imprimir(8650, y, txtSaneamiento.Text, , , clsImpMili.Alineación.Derecha)
    '                    imp.Imprimir(8650, y, FormatCurrency(RSanea, 2), , , clsImpMili.Alineación.Derecha)
    '                    y += 200
    '                End If
    '                'Recargos
    '                If RRecargos > 0 Then
    '                    imp.Imprimir(1500, y, "RECARGOS")
    '                    'imp.Imprimir(8650, y, txtReca.Text, , , clsImpMili.Alineación.Derecha)
    '                    imp.Imprimir(8650, y, FormatCurrency(RRecargos, 2), , , clsImpMili.Alineación.Derecha)
    '                    y += 200
    '                End If
    '                'Anticipo
    '                If RAnti > 0 Then
    '                    imp.Imprimir(1500, y, "ANTICIPO")
    '                    'imp.Imprimir(8650, y, TxtAnticipo.Text, , , clsImpMili.Alineación.Derecha)
    '                    imp.Imprimir(8650, y, FormatCurrency(RAnti, 2), , , clsImpMili.Alineación.Derecha)
    '                    y += 200
    '                End If
    '                If TxtRedondeo.Visible = True And Val(TxtRedondeo.Text) <> 0 Then
    '                    If clrecibo.redondeo < 0 And clrecibo.redondear = True Then
    '                        '  If RRedondeo < 0.5 And RRedondeo > 0 Then
    '                        'CENTAVOS A CREDITO'
    '                        imp.Imprimir(1500, y, "CENTAVOS A CREDITO")
    '                        'imp.Imprimir(8650, y, TxtRedondeo.Text, , , clsImpMili.Alineación.Derecha)
    '                        imp.Imprimir(8650, y, FormatCurrency(clrecibo.redondeo, 2), , , clsImpMili.Alineación.Derecha)
    '                    ElseIf clrecibo.redondeo > 0 And clrecibo.redondear = True Then
    '                        '    'CENTAVOS A ABONO'
    '                        imp.Imprimir(1500, y, "CENTAVOS A FAVOR")
    '                        ' imp.Imprimir(8650, y, TxtRedondeo.Text, , , clsImpMili.Alineación.Derecha)
    '                        imp.Imprimir(8650, y, FormatCurrency(clrecibo.redondeo, 2), , , clsImpMili.Alineación.Derecha)
    '                    End If
    '                    'End If
    '                    y += 200
    '                End If
    '            Else
    '                y = 5200
    '        End If
    '        If chkOtros.CheckState = CheckState.Checked Then
    '            For m = 0 To dgCob.RowCount - 1
    '                imp.Imprimir(1500, y, dgCob.Item("Concepto", m).Value)
    '                imp.Imprimir(8650, y, FormatCurrency(dgCob.Item("Subtot", m).Value, 2), , , clsImpMili.Alineación.Derecha)
    '                y += 200
    '            Next
    '        End If
    '            End If
    '    ElseIf RBFactibilidades.Checked = True Then
    '        'Pago de la factibilidad
    '        imp.Imprimir(1500, 5200, "FACTIBILIDAD")
    '        'imp.Imprimir(8650, 5200, TxtFactibilidad.Text, , , clsImpMili.Alineación.Derecha)
    '        imp.Imprimir(8650, 5200, FormatCurrency(RFacti, 2), , , clsImpMili.Alineación.Derecha)
    '    ElseIf RBNoPadron.Checked = True Then
    '        y = 5200
    '        For m = 0 To dgCob.RowCount - 1
    '            imp.Imprimir(1500, y, dgCob.Item("Concepto", m).Value)
    '            imp.Imprimir(8650, y, FormatCurrency(dgCob.Item("Subtot", m).Value, 2), , , clsImpMili.Alineación.Derecha)
    '            y += 200
    '        Next
    '    End If

    '    '********************************
    '    'Totales
    '    '********************************
    '    'Monto en letra
    '    'imp.Imprimir(200, 7650, "(" & ConvertCurrencyToSpanish(txtTotal.Text, "Pesos", False) & ")")
    '    imp.Imprimir(200, 7650, "(" & ConvertCurrencyToSpanish(clrecibo.Total, "Pesos", False) & ")")
    '    'Subtotal
    '    'imp.Imprimir(8650, 7950, txtSubTot.Text, , , clsImpMili.Alineación.Derecha)
    '    'imp.Imprimir(8650, 7950, FormatCurrency(RSubTot, 2), , , clsImpMili.Alineación.Derecha)
    '    imp.Imprimir(8650, 7950, FormatCurrency(clrecibo.Subtotal, 2), , , clsImpMili.Alineación.Derecha)
    '    'Iva
    '    'imp.Imprimir(8650, 8250, txtIva.Text, , , clsImpMili.Alineación.Derecha)
    '    'imp.Imprimir(8650, 8250, FormatCurrency(RIva, 2), , , clsImpMili.Alineación.Derecha)
    '    imp.Imprimir(8650, 8250, FormatCurrency(clrecibo.IVA, 2), , , clsImpMili.Alineación.Derecha)
    '    'Total a pagar
    '    'imp.Imprimir(8650, 8550, txtTotal.Text & Chr(18), , , clsImpMili.Alineación.Derecha)
    '    'imp.Imprimir(8650, 8550, FormatCurrency(RTotal, 2) & Chr(18), , , clsImpMili.Alineación.Derecha)
    '    imp.Imprimir(8650, 8550, FormatCurrency(clrecibo.Total, 2) & Chr(18), , , clsImpMili.Alineación.Derecha)
    '    'If cuad = 2 Then
    '    imp.MandarDocumento()
    '    'Exit Sub
    '    'End If
    '    'Next
    'End Sub

#End Region

#Region "impresión de facturas Cesar"
    Private Sub ImprimirFactura()
        Dim clrecibo2 As New Clsrecibo
        clrecibo2 = clrecibo
        Dim cadena As String = "", direc As String = "", direc2 As String = "", direc3 As String = "", Nom As String = ""
        Dim Validacion As String = _ope & "/" & "/" & _caja & "/" & _num_ope & "/" & Now.Date & "/" & Now.Hour & "/" & CDbl(txtTotal.Text)
        Dim idest As IDataReader = Nothing
        Dim cont As Double = 0, dret As Double = 0, sant As Double = 0, rect As Double = 0, ivat As Double = 0, otrt As Double = 0, anti As Double = 0
        Dim UFpago As Date = Nothing
        Dim cuad As Int16 = 0
        Dim c1 As Integer = 0, f1 As Integer = 0
        Dim impUbi As Boolean = False

        Dim imp As New clsImpMili(c1, f1, , 8, 75, 75)
        Dim datos As IDataReader = Nothing

        For cuad = 1 To 1
            If cuad = 1 Then
                c1 = 0
                f1 = 0
            Else
                c1 = 5850
                f1 = 0
            End If
            imp.Columna = c1
            imp.Fila = f1

            Nom = txtNombre.Text
            direc = txtCalle.Text & " " & txtNumExt.Text & " " & txtNumInt.Text
            direc2 = txtCol.Text
            direc3 = txtCom.Text
            If RBUsuarios.Checked = True And ChkDirFis.Checked = True Then
                Nom = lblDirFis1.Text
                direc = lblDirFis2.Text
                direc3 = LblDirFis3.Text
                direc2 = LblDirFis4.Text
            End If
            imp.Imprimir(5000, 200, _serie & "   " & recibo)
            imp.Imprimir(13800, 1400, _serie & "   " & recibo, , 7)
            'Cuenta
            If RBUsuarios.Checked = True Then
                imp.Imprimir(3900, 800, idComu & "  " & txtCuenta.Text, , 7)
                imp.Imprimir(2000, 800, obtenerCampo("SELECT * FROM usuario WHERE cuenta=" & txtCuenta.Text & " and id_comunidad='" & idComu & "'", "clave_predial"), , 7)
                imp.Imprimir(12800, 1400, idComu & "  " & txtCuenta.Text, , 7)
                imp.Imprimir(11050, 1400, obtenerCampo("SELECT * FROM usuario WHERE cuenta=" & txtCuenta.Text & " and id_comunidad='" & idComu & "'", "clave_predial"), , 7)
            ElseIf RBFactibilidades.Checked = True Then
                imp.Imprimir(1000, 800, TxtSolicitud.Text, , 7)
            ElseIf RBNoPadron.Checked = True Then
                imp.Imprimir(1000, 800, CmbNousuarios.SelectedValue.ToString, , 7)
            End If
            Dim codgir As String
            Dim m3 As Integer
            codgir = obtenerCampo("SELECT * FROM usuario WHERE cuenta=" & txtCuenta.Text & " and id_comunidad='" & idComu & "'", "cod_gir")
            m3 = obtenerCampo("select * from giro where codgir='" + codgir + "'", "pro_anual")

            'Fecha de pago
            imp.Imprimir(1000, 800, Now.Date, , 7)
            imp.Imprimir(10100, 1400, Now.Date, , 7)

            'Nombre
            imp.Imprimir(4950, 800, Nom, , 7)
            imp.Imprimir(10100, 6200, Nom, , 7)
            'Dirección
            imp.Imprimir(4950, 1000, direc, , 7)
            imp.Imprimir(10100, 800, direc, , 7)


            'Colonia
            imp.Imprimir(4950, 1200, direc2, , 7)
            'Comunidad
            imp.Imprimir(4950, 1400, direc3, , 7)

            'RFC
            imp.Imprimir(4950, 1600, txtRfc.Text, , 7)

            If RBUsuarios.Checked = True Then

                'Ubicacion
                'imp.Imprimir(5400, 2050, Ubicacion)

                'Tarifa
                If cuad = 1 Then
                    imp.Imprimir(3700, 2050, Tar, , 7)
                    imp.Imprimir(14100, 1900, Tar, , 7)
                Else
                    imp.Imprimir(3800, 2000, Tar, , 7)
                End If


                'Periodo de consumo
                ' If LabelX7.Text = "PERIODO FACTURADO" Then
                imp.Imprimir(1000, 2050, txtPer.Text, , 7)
                imp.Imprimir(10100, 2050, txtPer.Text, , 7)
                'End If

                'Texto de Validacion
                'imp.Imprimir(3500, 4000, Validacion)





                Dim ok() As String = Nothing
                Try
                    ok = Split(txtPer.Text, "-")
                Catch ex As Exception

                End Try

                Dim lecan As Double = 0, lecac As Double = 0, conl As Double = 0
                Try
                    lecan = obtenerCampo("select lecturaant from lecturas where cuenta=" & txtCuenta.Text & " and comunidad='" & cmbComu.SelectedValue.ToString & "' and ucase(concat(mes,' ',an_per))='" & ok(0).Trim & "'", "lecturaant")
                    lecac = obtenerCampo("select lectura from lecturas where cuenta=" & txtCuenta.Text & " and comunidad='" & cmbComu.SelectedValue.ToString & "' and ucase(concat(mes,' ',an_per))='" & ok(1).Trim & "'", "lectura")
                Catch ex As Exception

                End Try





                'Lectura Anterior
                imp.Imprimir(1700, 1400, lecac, , 7)

                'Lectura Actual
                imp.Imprimir(2800, 1400, lecan, , 7)
                'Consumo en metros cúbicos
                imp.Imprimir(3700, 1400, lecac - lecan, , 7)
                'Numero de medidor
                'If Medidor = "0" Or Medidor = "" Then Medidor = "S/M"
                'imp.Imprimir(2600, 1400, Medidor, , 7)

            End If
            Dim LINEAIMPORTE As Integer = 8500
            Dim LINEAIMPORTE2 As Integer = 14600
            If cuad = 2 Then
                LINEAIMPORTE = 400
            End If
            Dim y As Integer


            y = 2700
            Dim pagares As Boolean = False
            Dim movimientos As IDataReader = ConsultaSql("SELECT cta_cont,descripcion,sum(total)as total,concepto FROM detalle_pago,conceptoscxc where id_concepto=numconcepto and total<>0 and recibo=" & recibo & " group by descripcion order by cta_cont").ExecuteReader
            While movimientos.Read()
                'imp.Imprimir(700, y, movimientos("cta_cont"))
                imp.Imprimir(700, y, movimientos("descripcion"))
                imp.Imprimir(LINEAIMPORTE, y, FormatCurrency(movimientos("total"), 2), , 7, clsImpMili.Alineación.Derecha)
                imp.Imprimir(10100, y, Mid(movimientos("descripcion"), 1, 27), , 7)
                imp.Imprimir(LINEAIMPORTE2, y, FormatCurrency(movimientos("total"), 2), , 7, clsImpMili.Alineación.Derecha)

                If movimientos("concepto") = "ANTICIPO DE CONVENIO AGUA" Then
                    imp.Imprimir(400, 5000, movimientos("concepto"))
                End If


                If Mid(movimientos("concepto"), 1, 13) = "PAGO CONVENIO" Then
                    pagares = True
                End If
                y += 200
            End While

            If pagares Then
                Dim paga As IDataReader = ConsultaSql("SELECT o.concepto FROM otrosconceptos as o, pagotros as p where o.clave=p.id_concepto and recibo=" & recibo).ExecuteReader
                Dim x As Integer = 1500
                imp.Imprimir(400, 5000, "PAGARES")
                While paga.Read()
                    imp.Imprimir(x, 5000, paga("concepto"))
                    x += 1100

                End While
            End If


            '********************************
            'Totales
            '********************************
            'Monto en letra
            imp.Imprimir(400, 5500, "(" & ConvertCurrencyToSpanish(txtTotal.Text, "Pesos", False) & ")", , 7)
            imp.Imprimir(10100, 5200, "(" & ConvertCurrencyToSpanish(txtTotal.Text, "Pesos", False) & ")", , 7)

            'Total a pagar
            imp.Imprimir(8500, 5650, FormatCurrency(clrecibo2.Total, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            imp.Imprimir(14200, 5650, FormatCurrency(clrecibo2.Total, 2), "Arial", 8, clsImpMili.Alineación.Derecha)
            'Texto de Agradecimiento
            imp.Imprimir(800, 6200, "GRACIAS POR SU PAGO", , 7.5)
            'If cuad = 2 Then
            imp.MandarDocumento()
            Exit Sub
            'End If
        Next
        '  limpiar()
    End Sub

#End Region

    Private Sub cmbComu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbComu.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbNousuarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbNousuarios.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub Filtrar()
        If txtbusNombre.Text <> "" Then
            If CmbComunidad.Text = "" Then
                If RBCuenta.CheckState = CheckState.Checked Then
                    llenaGrid(DGBus, "Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario where cuenta = " & Val(txtbusNombre.Text) & "  order by cuenta ")
                ElseIf RBDomicilio.CheckState = CheckState.Checked Then
                    llenaGrid(DGBus, "Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario where concat(calle,' ', numext, ' ', numint, ' ', colonia) like '%" & txtbusNombre.Text & "%' order by cuenta ")
                ElseIf RBNombre.CheckState = CheckState.Checked Then
                    llenaGrid(DGBus, "Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario where nombre like '%" & txtbusNombre.Text & "%' order by cuenta ")
                End If
            Else
                If RBCuenta.CheckState = CheckState.Checked Then
                    llenaGrid(DGBus, "Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario where cuenta = " & Val(txtbusNombre.Text) & " and comunidad = '" & CmbComunidad.Text & "' order by cuenta ")
                ElseIf RBDomicilio.CheckState = CheckState.Checked Then
                    llenaGrid(DGBus, "Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario where concat(calle,' ', numext, ' ', numint, ' ', colonia) like '%" & txtbusNombre.Text & "%' and comunidad = '" & CmbComunidad.Text & "' order by cuenta ")
                ElseIf RBNombre.CheckState = CheckState.Checked Then
                    llenaGrid(DGBus, "Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario where nombre like '%" & txtbusNombre.Text & "%' and comunidad = '" & CmbComunidad.Text & "' order by cuenta ")
                End If
            End If
        End If
    End Sub

    Private Sub dgCob_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgCob.CellMouseClick

    End Sub

    Private Sub dgCob_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgCob.RowsRemoved
        'If RemSistema = False Then
        '    If Mes() = 12 And Anio() = Year(Now) Then
        '        llenatotanti(Mes, Anio)
        '    Else
        '        llenatot(Mes, Anio)
        '    End If
        'End If
    End Sub

    Private Sub ComboRob1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboRob1.LostFocus
        'ComboRob1.Desplegar(0)
    End Sub

    Private Sub frmCajas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If RBUsuarios.Checked And txtCuenta.Text <> "" Then
            If ComboRob1.Height > 21 Then
                'ComboRob1.Desplegar(0)
            End If
        End If
    End Sub

    Private Sub FiltraSol()

        If TxtBusSol.Text <> "" Then
            Try
                If RBCueSol.CheckState = CheckState.Checked Then
                    llenaGrid(DGBusSol, "select numero as Cuenta, nombre,  concat(calle,' ', num_ext, ' ', num_int, ' ', colonia) as domicilio, comunidad from vsolicitud where estado ='PENDIENTE' and cuenta = " & Val(TxtBusSol.Text) & " ")
                ElseIf RBDomSol.CheckState = CheckState.Checked Then
                    llenaGrid(DGBusSol, "select numero as Cuenta, nombre,  concat(calle,' ', num_ext, ' ', num_int, ' ', colonia) as domicilio, comunidad from vsolicitud where estado ='PENDIENTE' and concat(calle,' ', num_ext, ' ', num_int, ' ', colonia) like '%" & TxtBusSol.Text & "%'")
                ElseIf RBComNom.CheckState = CheckState.Checked Then
                    llenaGrid(DGBusSol, "select numero as Cuenta, nombre,  concat(calle,' ', num_ext, ' ', num_int, ' ', colonia) as domicilio, comunidad from vsolicitud where estado ='PENDIENTE' and nombre like '%" & TxtBusSol.Text & "%'")
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub DGBusSol_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGBusSol.DoubleClick
        Try
            TxtSolicitud.Text = DGBusSol.Item(0, DGBusSol.CurrentRow.Index).Value
            AceptarBusqueda()
            Factibilidadex.Expanded = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ActualizaVista()
        Vista = llenarVista("Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario order by cuenta")
        Fil.DataSource = Vista
        DGBus.DataSource = Fil
        VisSol = llenarVista("select numero as Cuenta, nombre,  concat(calle,' ', num_ext, ' ', num_int, ' ', colonia) as domicilio, comunidad from vsolicitud where estado ='PENDIENTE'")
        FilSol.DataSource = VisSol
        DGBusSol.DataSource = FilSol
        ExFpago.Expanded = False
        ExBus.Expanded = False
    End Sub

    Private Sub BtnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusqueda.Click
        Filtrar()
    End Sub

    Private Sub BtnBusSol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusSol.Click
        FiltraSol()
    End Sub

    Private Sub cmbComu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbComu.LostFocus
        limpiar()
    End Sub

    Private Sub ChkRedondeo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRedondeo.CheckedChanged
        'If Mes() = 12 And Anio() = Year(Now) Then
        '    llenatotanti(Mes, Anio)
        'Else
        '    llenatot(Mes, Anio)
        'End If
    End Sub

    Private Sub ckarriba_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckarriba.CheckedChanged
        clrecibo.arriba = ckarriba.Checked
        'If Mes() = 12 And Anio() = Year(Now) Then
        '    llenatotanti(Mes, Anio)
        'Else
        '    llenatot(Mes, Anio)
        'End If
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        frmcambiofolio.StartPosition = FormStartPosition.CenterScreen
        frmcambiofolio.ShowDialog()
    End Sub

    Private Sub descupronto()
        Dim CON_CONCEPTOSCXC, CON_OTROSCONCEPTOS As IDataReader
        Dim SUMAFAC, SUMAANT, DESANTI, TOT_AGUA, TOT_DRENAJE, TOT_SANEAMIENTO, d12, porc As Double
        Dim opcagrega As Integer = 0
        Dim r, OPC_APLICA As Integer
        Dim fecha, today As Date
        Dim MesF, Añof As Integer
        OPC_APLICA = 0
        TOT_AGUA = 0
        TOT_DRENAJE = 0
        TOT_SANEAMIENTO = 0
        SUMAANT = 0
        SUMAFAC = 0
        DESANTI = 0
        d12 = 0
        porc = 0
        tdescuento = 0
        MesF = Mes()
        Añof = Anio()
        CON_CONCEPTOSCXC = ConsultaSql("SELECT * FROM CONCEPTOSCXC WHERE TIPO='Abono' AND EVENTO='Abonos' AND ACCIONDESCUENTO='Monto'").ExecuteReader
        Do While CON_CONCEPTOSCXC.Read() And OPC_APLICA = 0
            CON_OTROSCONCEPTOS = ConsultaSql("SELECT * FROM OTROSCONCEPTOS WHERE CUENTA='" & Trim(txtCuenta.Text) & "' AND ID_CONCEPTO='" & CON_CONCEPTOSCXC("ID_CONCEPTO") & "' AND PAGADO=0").ExecuteReader
            If CON_OTROSCONCEPTOS.Read Then
                OPC_APLICA = 1
            End If
        Loop
        If MesF = 12 And Añof = Year(Now) Then
            If OPC_APLICA = 0 Then
                fecha = obtenerCampo("SELECT * FROM empresa", "fecha_des")
                today = ConvertDate(Now)
                If fecha >= today Then
                    porc = Val(obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='120DPP'", "porcentaje")) / 100
                    'EN LA VARIABLE DE MESESANTI SABEMOS SI HAY MESES ANTICIPADOS
                    If MesesAnti > 0 Then
                        SUMAANT = ConsumoAnti + AlcaAnti + SaneaAnti
                        If MesesAnti >= 12 Then
                            DESANTI = ((SUMAANT / MesesAnti) * porc) * 12
                        Else
                            DESANTI = ((SUMAANT / MesesAnti) * porc) * MesesAnti
                        End If
                    Else
                        DESANTI = 0
                    End If

                    CONSULTA2 = ConsultaSql("SELECT sum(CONSUMO) AS TCONSUMO_ACTUAL,sum(DRENAJE) AS TDRENAJE_ACTUAL,sum(SANEAMIENTO) AS TSANEAMIENTO_ACTUAL FROM ESTADOS WHERE CUENTA='" & Trim(txtCuenta.Text) & "' AND AN_PER='" & Val(Year(Now)) & "'").ExecuteReader
                    If CONSULTA2.Read() Then
                        If Not DBNull.Value.Equals(CONSULTA2("TCONSUMO_ACTUAL")) Then
                            TOT_AGUA = Val(CONSULTA2("TCONSUMO_ACTUAL"))
                        Else
                            TOT_AGUA = 0
                        End If
                        If Not DBNull.Value.Equals(CONSULTA2("TDRENAJE_ACTUAL")) Then
                            TOT_DRENAJE = Val(CONSULTA2("TDRENAJE_ACTUAL"))
                        Else
                            TOT_DRENAJE = 0
                        End If
                        If Not DBNull.Value.Equals(CONSULTA2("TSANEAMIENTO_ACTUAL")) Then
                            TOT_SANEAMIENTO = Val(CONSULTA2("TSANEAMIENTO_ACTUAL"))
                        Else
                            TOT_SANEAMIENTO = 0
                        End If
                    Else
                        TOT_SANEAMIENTO = 0
                        TOT_DRENAJE = 0
                        TOT_AGUA = 0
                    End If
                    SUMAFAC = (TOT_AGUA + TOT_DRENAJE + TOT_SANEAMIENTO) * porc
                    d12 = SUMAFAC + DESANTI
                    'Elimino el registro del descuento del 12% que se genera temporalmente
                    For i = 0 To dgCob.Rows.Count - 1
                        If dgCob.Item(9, i).Value = "120DPP" And dgCob.Item(0, i).Value = 0 Then
                            dgCob.Rows.Remove(dgCob.Rows(i))
                        End If
                    Next
                    'For i = 0 To dgCob.Rows.Count - 1
                    '    If dgCob.Item(9, i).Value = "120DPP" Then
                    '        opcagrega = 1
                    '    End If
                    'Next
                    'If opcagrega = 0 Then
                    If d12 <> 0 Then
                        With dgCob
                            r = .RowCount()
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = 0
                            .Rows(r).Cells(1).Value = obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='120DPP'", "id_concepto")
                            .Rows(r).Cells(2).Value = FormatNumber(d12, 2)
                            .Rows(r).Cells(3).Value = obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='120DPP'", "descripcion")
                            .Rows(r).Cells(4).Value = FormatNumber(d12, 2)
                            .Rows(r).Cells(5).Value = 0
                            .Rows(r).Cells(6).Value = 0
                            .Rows(r).Cells(7).Value = FormatNumber(d12, 2)
                            .Rows(r).Cells(9).Value = "120DPP"
                            .Rows(r).Cells("Tipo").Value = "Abono"
                            ' Ejecucion("insert into otrosconceptos (cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, consumo, drenaje, saneamiento,repiva,factura,serie,caja,cod_ofi,id_concepto,fec_alta) values (" _
                            '   & txtCuenta.Text & ", '" & .Rows(r).Cells(3).Value & "', " & .Rows(r).Cells(7).Value & ", " & .Rows(r).Cells(4).Value & ", 0,0,'" & UnixDateFormat(DTFecha.Value) & "', '', '" & String.Concat(Now.Year, _serie, recibo, "A") & "', 'PENDIENTE', '" & .Rows(r).Cells(3).Value & "', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & CDbl(TxtAnticipo.Text) + IvAnti & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & ConsumoAnti & ", " & AlcaAnti & ", " & SaneaAnti & ", " & IvAnti & "," & recibo & ",'" & _serie & "','" & _caja & "','" & _cod_ofi & "','018NSR','" & UnixDateFormat(Now.Date) & "')")
                        End With
                    End If
                    'End If
                    dgCob.Refresh()
                    'editgrid()
                End If
            End If
        Else
            'Elimino el registro del descuento del 12% que se genera temporalmente
            For i = 0 To dgCob.Rows.Count - 1
                If dgCob.Item(9, i).Value = "120DPP" And dgCob.Item(0, i).Value = 0 Then
                    dgCob.Rows.Remove(dgCob.Rows(i))
                End If
            Next
        End If
        tdescuento = (SUMAFAC + DESANTI) + Descu
        clrecibo.descuento = tdescuento
        txtDescu.Text = FormatCurrency(tdescuento, 2)
        TxtRedondeo.Text = clrecibo.redondeo
        txtIva.Text = FormatCurrency(clrecibo.IVA, 2)
        txtSubTot.Text = FormatCurrency(clrecibo.Subtotal, 2)
        txtTotal.Text = FormatCurrency(clrecibo.Total, 2)
    End Sub

    Public Sub editgrid()
        Dim TotResta, TotReca, TotIva, Tot As Double
        Dim Resta, Reca, Iva As Double
        Dim PorcResta, PorcReca, PorcIva As Double
        Dim Abono As Double
        Dim otr As IDataReader = ConsultaSql("select SubTotResta, resta, TotRec, Iva, (subtotresta + totrec + iva) as Total from otrosconceptos where clave=" & dgCob.Item("clave", dgCob.CurrentRow.Index).Value & "").ExecuteReader
        If otr.Read() Then
            TotResta = otr("SubTotResta")
            TotIva = otr("iva")
            TotReca = otr("TotRec")
            Tot = otr("Total")
        Else
            TotResta = 0
            TotIva = 0
            TotReca = 0
            Tot = 0
        End If
        Dim _total As Double
        _total = 0

        Try
            If Tot < dgCob.Item("Total", dgCob.CurrentRow.Index).Value Then
                MessageBoxEx.Show("El total a pagar es mayor al total que se adeuda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Throw New Exception
            End If

            If dgCob.Item("Total", dgCob.CurrentRow.Index).Value <= 0 Then
                MessageBoxEx.Show("El total debe ser mayor a 0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Throw New Exception
            End If

            Abono = dgCob.Item("Total", dgCob.CurrentRow.Index).Value
            PorcResta = TotResta / Tot
            PorcIva = TotIva / Tot
            PorcReca = TotReca / Tot

            Resta = Math.Round((PorcResta * Abono), 2)
            Reca = Math.Round((PorcReca * Abono), 2)
            Iva = Math.Round((PorcIva * Abono), 2)

            dgCob.Item("subTot", dgCob.CurrentRow.Index).Value = Resta
            dgCob.Item("Recargos", dgCob.CurrentRow.Index).Value = Reca
            dgCob.Item("iva", dgCob.CurrentRow.Index).Value = Iva

        Catch ex As Exception
            dgCob.Item("Total", dgCob.CurrentRow.Index).Value = Tot
            dgCob.Item("subTot", dgCob.CurrentRow.Index).Value = TotResta
            dgCob.Item("Recargos", dgCob.CurrentRow.Index).Value = TotReca
            dgCob.Item("iva", dgCob.CurrentRow.Index).Value = TotIva
            Exit Sub
        End Try
        CALCULO()
    End Sub

    Private Function ConvertDate(ByVal value As String) As Date

        ' Converts a date in YYYYMMDD format to MM/DD/YYYY format.
        '    If Not value.Length = 10 Then
        'Throw New ArgumentException("Invalid length")
        'End IF

        'If Not IsNumeric(value) Then
        'Throw New ArgumentException("Not a valid 8-digit number.")
        'End If
        Dim theYear As String = value.Substring(6, 4)
        Dim theMonth As String = value.Substring(0, 2)
        Dim theDay As String = value.Substring(3, 2)
        Dim result As String = theMonth & "/" & theDay & "/" & theYear
        If Not IsDate(result) Then
            Throw New ArgumentException("value cannot be converted to a date.")
        End If
        Return CDate(result)
    End Function

    Public Sub desc_porc()
        Dim ultimo, cont As Integer
        Dim clave As String
        Dim suma, tot As Double
        Dim rezago As Double
        Dim accion As String
        cont = 0
        ultimo = dgCob.RowCount
        Do While (cont <= ultimo - 1) And (chkOtros.Checked = True)
            clave = obtenerCampo("select * from otrosconceptos where clave='" & dgCob.Rows(cont).Cells(0).Value & "'", "id_concepto")
            porce = obtenerCampo("select * from conceptoscxc where id_concepto='" & clave & "'", "porcentaje") / 100
            accion = obtenerCampo("select * from conceptoscxc where id_concepto='" & clave & "'", "Acciondescuento")
            'rezago = obtenerCampo("SELECT sum(consumo + drenaje + saneamiento)as rez FROM estados where cuenta=" & txtCuenta.Text & " and pagado=0 and ultimo=0 and valormesnum(MES_PERIODO)<=" & Val(Mes()) & " and AN_PER=" & Now.Year & "", "rez")
            If Anio() = Now.Year Then
                D_REZAGO = ConsultaSql("SELECT sum(consumo + drenaje + saneamiento)as REZ,AN_PER FROM ESTADOS WHERE CUENTA='" & Trim(txtCuenta.Text) & "' AND ID_COMUNIDAD='" & DID_COMUNIDAD & "' AND PAGADO=0 and ULTIMO=0 and valormesnum(MES_PERIODO)<=" & Val(Mes()) & " and AN_PER=" & Now.Year & "").ExecuteReader
                If D_REZAGO.Read() Then
                    If Not DBNull.Value.Equals(D_REZAGO("REZ")) Then
                        rezago = Val(D_REZAGO("REZ"))
                    Else
                        rezago = 0
                    End If
                Else
                    rezago = 0
                End If
            Else
                rezago = 0
            End If
            If clave = "100MUL" Then
                porce = 0
            End If
            If porce > 0 Or dgCob.Rows(cont).Cells(9).Value = "100GDC" Then
                If porce = 0 Then
                    'porce = Val(obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='120DPP'", "porcentaje")) / 100
                    suma = clrecibo.anticipo
                    If dgCob.Rows(cont).Cells(9).Value = "100GDC" Then
                        'este linea estaba comentada antes 'porce = Val(obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='100GDC'", "porcentaje")) / 100
                        'esta linea estaba comentada antes 'suma = obtenerCampo("select sum(consumo + drenaje + saneamiento)as rez from vrezagos where cuenta=" & txtCuenta.Text & " and mes<'" & Now.Year & "-01-01' and mes<=concat('" & Mid(CmbPeriodos.Text, 5, 4) & "-',mesnum('" & Mid(CmbPeriodos.Text, 1, 3) & "'),'-01') and id_comunidad='" & cmbComu.SelectedValue.ToString & "'", "rez")
                        'Dim req As IDataReader
                        'Dim anno As Integer
                        'Dim mes As String

                        'req = ConsultaSql("select * from requerimiento where cancelado=0 and cuenta=" & Val(txtCuenta.Text) & " order by fec_emi_req desc limit 1").ExecuteReader()
                        'If req.Read() Then
                        '    anno = req("anno_fin")
                        '    mes = req("mes_fin")

                        '    ' ir a buscar a la tabla empresa el campo de clv_gto_req para ir a la tabla de conceptoscxc y buscar ese valor para saber el porcentaje

                        '    porce = Val(obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='100GDC'", "porcentaje")) / 100
                        '    suma = obtenerCampo("select sum(consumo + drenaje + saneamiento)as rez from vrezagos where cuenta=" & txtCuenta.Text & " and mes<=concat('" & anno & "-',mesnum('" & mes & "'),'-01') and mes<=concat('" & Mid(CmbPeriodos.Text, 5, 4) & "-',mesnum('" & Mid(CmbPeriodos.Text, 1, 3) & "'),'-01') and id_comunidad='" & cmbComu.SelectedValue.ToString & "'", "rez")
                        '    'suma = obtenerCampo("select sum(consumo + drenaje + saneamiento)as rez from vrezagos where cuenta=" & Val(txtCuenta.Text) & " and mes<=concat('" & anno & "-',mesnum('" & mes & "'),'-01') and id_comunidad='" & cmbComu.SelectedValue.ToString & "'", "rez")
                        'End If
                        Dim req, d_gastos As IDataReader
                        Dim aa As Integer
                        Dim mm As String
                        req = ConsultaSql("select * from requerimiento where cancelado=0 and cuenta=" & Val(txtCuenta.Text) & " order by fec_emi_req desc limit 1").ExecuteReader()
                        If req.Read() Then
                            aa = req("anno_fin")
                            mm = req("mes_fin")
                        Else
                            aa = Year(Now) - 1
                            mm = "DIC"
                        End If
                        d_gastos = ConsultaSql("SELECT SUM(CONSUMO + DRENAJE + SANEAMIENTO - ANTICIPO) AS MONTO FROM ESTADOS WHERE CUENTA=" & Val(txtCuenta.Text) & " AND PAGADO=0 and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and valornummes(MES_PERIODO,AN_PER)<=" & Mid(CmbPeriodos.Text, 5, 4) & NumeroMes(Mid(CmbPeriodos.Text, 1, 3)) + 10 & " and valornummes(MES_PERIODO,AN_PER)<=" & Convert.ToInt32(Convert.ToString(aa) & Convert.ToString(NumeroMes(mm) + 10))).ExecuteReader()
                        If d_gastos.Read Then
                            If Not DBNull.Value.Equals(d_gastos("MONTO")) Then
                                suma = d_gastos("MONTO")
                                porce = Val(obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='100GDC'", "porcentaje")) / 100
                            Else
                                suma = 0
                                porce = 0
                            End If
                        End If
                    End If
                    tot = suma * porce
                    'If tot = 0 Then tot = 0
                    dgCob.Rows(cont).Cells(2).Value = FormatNumber(tot, 2)
                    dgCob.Rows(cont).Cells(4).Value = FormatNumber(tot, 2)
                    dgCob.Rows(cont).Cells(7).Value = FormatNumber(tot, 2)
                    dgCob.Rows(cont).Cells(6).Value = 0
                Else
                    Select Case accion
                        Case "Monto"
                            suma = clrecibo.anticipo + clrecibo.Consumo + clrecibo.Alcantarillado + clrecibo.Saneamiento + rezago
                        Case "Recargos"
                            suma = clrecibo.recargos + clrecibo.recargosotros
                        Case "Consumo"
                            suma = clrecibo.Consumo
                    End Select
                    tot = suma * porce
                    If tot = 0 Then tot = 0
                    dgCob.Rows(cont).Cells(2).Value = FormatNumber(tot, 2)
                    dgCob.Rows(cont).Cells(4).Value = FormatNumber(tot, 2)
                    dgCob.Rows(cont).Cells(7).Value = FormatNumber(tot, 2)
                    dgCob.Rows(cont).Cells(9).Value = clave
                    dgCob.Rows(cont).Cells(6).Value = 0
                    Ejecucion("update otrosconceptos set total=" & tot & ",subtotal=" & tot & ",resta=" & tot & " where clave='" & dgCob.Rows(cont).Cells(0).Value & "'")
                End If
            End If
            cont += 1
        Loop
    End Sub


    Public Sub ivagrid()
        Dim TotResta, TotReca, TotIva, Tot As Double
        Dim Resta, Reca, Iva As Double
        Dim PorcResta, PorcReca, PorcIva As Double
        Dim Abono As Double
        If dgCob.RowCount > 0 And RBNoPadron.Checked = False Then
            Dim ultimo, cont As Integer
            ultimo = dgCob.RowCount
            cont = 0
            Do While cont <= ultimo - 1
                'dgCob.Rows(cont).Cells("Tipo").Value = "Cargo" And
                If dgCob.Rows(cont).Cells(9).Value <> "100GDC" Then
                    Dim otr As IDataReader = ConsultaSql("select SubTotResta, resta, TotRec, Iva, (subtotresta + totrec + iva) as Total from otrosconceptos where clave=" & dgCob.Item("clave", cont).Value & "").ExecuteReader
                    If otr.Read() Then
                        TotResta = otr("SubTotResta")
                        TotIva = otr("iva")
                        TotReca = otr("TotRec")
                        Tot = otr("Total")
                    Else
                        TotResta = 0
                        TotIva = 0
                        TotReca = 0
                        Tot = 0
                    End If

                    Dim _total As Double
                    _total = 0
                    Try
                        If Tot < dgCob.Item("Total", cont).Value Then
                            'MessageBoxEx.Show("El total a pagar es mayor al total que se adeuda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Throw New Exception
                        End If

                        If dgCob.Item("Total", cont).Value <= 0 Then
                            ' MessageBoxEx.Show("El total debe ser mayor a 0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Throw New Exception
                        End If

                        Abono = dgCob.Item("Total", cont).Value
                        PorcResta = TotResta / Tot
                        PorcIva = TotIva / Tot
                        PorcReca = TotReca / Tot

                        Resta = Math.Round((PorcResta * Abono), 2)
                        Reca = Math.Round((PorcReca * Abono), 2)
                        Iva = Math.Round((PorcIva * Abono), 2)

                        dgCob.Item("subTot", cont).Value = Resta
                        dgCob.Item("Recargos", cont).Value = Reca
                        dgCob.Item("iva", cont).Value = Iva

                    Catch ex As Exception
                        dgCob.Item("Total", cont).Value = Tot
                        dgCob.Item("subTot", cont).Value = TotResta
                        dgCob.Item("Recargos", cont).Value = TotReca
                        dgCob.Item("iva", cont).Value = TotIva

                        'Exit Sub
                    End Try
                End If
                cont += 1
            Loop
        End If
    End Sub

    Public Sub gastos()
        Dim gastos, d12, porc As Double
        Dim r As Integer
        Dim ClaAbo As Double = Val(obtenerCampo("Select max(clave) as mayor from otrosconceptos", "mayor")) + 1
        Dim ultimo, aplica As Integer
        ultimo = dgCob.RowCount
        aplica = Val(obtenerCampo("Select requeri from usuario where cuenta=" & Val(txtCuenta.Text), "requeri"))
        If aplica > 0 Then
            'Dim req As IDataReader
            'Dim anno As Integer
            'Dim mes As String
            'req = ConsultaSql("select * from requerimiento where cancelado=0 and cuenta=" & Val(txtCuenta.Text) & " order by fec_emi_req desc limit 1").ExecuteReader()
            'If req.Read() Then
            '    anno = req("anno_fin")
            '    mes = req("mes_fin")

            '    ' ir a buscar a la tabla empresa el campo de clv_gto_req para ir a la tabla de conceptoscxc y buscar ese valor para saber el porcentaje

            '    gastos = obtenerCampo("select sum(consumo + drenaje + saneamiento)as rez from vrezagos where cuenta=" & txtCuenta.Text & " and mes<=concat('" & anno & "-',mesnum('" & mes & "'),'-01') and mes<=concat('" & Mid(CmbPeriodos.Text, 5, 4) & "-',mesnum('" & Mid(CmbPeriodos.Text, 1, 3) & "'),'-01') and id_comunidad='" & cmbComu.SelectedValue.ToString & "'", "rez")
            'Else
            '    gastos = obtenerCampo("select sum(consumo + drenaje + saneamiento)as rez from vrezagos where cuenta=" & Val(txtCuenta.Text) & " and mes<'" & Now.Year & "-01-01' and mes<=concat('" & Mid(CmbPeriodos.Text, 5, 4) & "-',mesnum('" & Mid(CmbPeriodos.Text, 1, 3) & "'),'-01') and id_comunidad='" & cmbComu.SelectedValue.ToString & "'", "rez")
            '    'gastos = 0
            'End If
            Dim req, d_gastos As IDataReader
            Dim aa As Integer
            Dim mm As String
            req = ConsultaSql("select * from requerimiento where cancelado=0 and cuenta=" & Val(txtCuenta.Text) & " order by fec_emi_req desc limit 1").ExecuteReader()
            If req.Read() Then
                aa = req("anno_fin")
                mm = req("mes_fin")
            Else
                aa = Year(Now) - 1
                mm = "DIC"
            End If
            D_GASTOS = ConsultaSql("SELECT SUM(CONSUMO + DRENAJE + SANEAMIENTO - ANTICIPO) AS MONTO FROM ESTADOS WHERE CUENTA=" & Val(txtCuenta.Text) & " AND PAGADO=0 and id_comunidad='" & cmbComu.SelectedValue.ToString & "' and valornummes(MES_PERIODO,AN_PER)<=" & Convert.ToInt32(Convert.ToString(aa) & Convert.ToString(NumeroMes(mm) + 10))).ExecuteReader()
            If D_GASTOS.Read Then
                If Not DBNull.Value.Equals(D_GASTOS("MONTO")) Then
                    gastos = d_gastos("MONTO")
                Else
                    gastos = 0
                End If
            End If
        End If
        porc = Val(obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='100GDC'", "porcentaje")) / 100
        'gastos = obtenerCampo("select sum(consumo + drenaje + saneamiento)as rez from vrezagos where cuenta=" & Val(txtCuenta.Text) & " and mes<'" & Now.Year & "-01-01' and mes<=concat('" & Mid(CmbPeriodos.Text, 5, 4) & "-',mesnum('" & Mid(CmbPeriodos.Text, 1, 3) & "'),'-01') and id_comunidad='" & cmbComu.SelectedValue.ToString & "'", "rez")
        If aplica > 0 And gastos > 0 Then
            'porc = 4 / 100
            d12 = gastos * porc
            With dgCob
                r = .RowCount()
                .Rows.Add()
                .Rows(r).Cells(0).Value = 0
                .Rows(r).Cells(1).Value = obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='100GDC'", "id_concepto")
                .Rows(r).Cells(2).Value = FormatNumber(d12, 2)
                .Rows(r).Cells(3).Value = obtenerCampo("SELECT * FROM conceptoscxc where id_concepto='100GDC'", "descripcion")
                .Rows(r).Cells(4).Value = FormatNumber(d12, 2)
                .Rows(r).Cells(5).Value = 0
                .Rows(r).Cells(6).Value = 0
                .Rows(r).Cells(7).Value = FormatNumber(d12, 2)
                .Rows(r).Cells(9).Value = "100GDC"
                .Rows(r).Cells("Tipo").Value = "Cargo"
                ' Ejecucion("insert into otrosconceptos (cuenta, concepto, total, subtotal, iva, pagado, vencimiento, tabla, folio, estado, motivo, FEC_APLI, id_comunidad, abonos, resta, tipo_mov, mes_periodo, an_per, consumo, drenaje, saneamiento,repiva,factura,serie,caja,cod_ofi,id_concepto,fec_alta) values (" _
                '   & txtCuenta.Text & ", '" & .Rows(r).Cells(3).Value & "', " & .Rows(r).Cells(7).Value & ", " & .Rows(r).Cells(4).Value & ", 0,0,'" & UnixDateFormat(DTFecha.Value) & "', '', '" & String.Concat(Now.Year, _serie, recibo, "A") & "', 'PENDIENTE', '" & .Rows(r).Cells(3).Value & "', '" & UnixDateFormat(DTFecha.Value) & "', '" & cmbComu.SelectedValue.ToString & "',0," & CDbl(TxtAnticipo.Text) + IvAnti & ", 'Abono','" & UCase(MonthName(DTFecha.Value.Month, True)) & "', " & DTFecha.Value.Year & ", " & ConsumoAnti & ", " & AlcaAnti & ", " & SaneaAnti & ", " & IvAnti & "," & recibo & ",'" & _serie & "','" & _caja & "','" & _cod_ofi & "','018NSR','" & UnixDateFormat(Now.Date) & "')")
            End With
        End If
    End Sub

    Private Sub CmbPeriodos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPeriodos.SelectedIndexChanged
        If RBUsuarios.Checked = True Then
            CALCULO()
            CALCULO()
        End If
    End Sub

    Private Sub ChkConsumo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkConsumo.CheckedChanged
        If RBUsuarios.Checked = True Then
            CALCULO()
        End If
    End Sub

    Private Sub cmbComu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComu.SelectedIndexChanged

    End Sub

    Private Sub dgCob_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCob.CellContentClick

    End Sub

    Private Sub CmbNousuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNousuarios.SelectedIndexChanged

    End Sub
End Class
