Public Class cierre
    Public Mes As String, Año As Integer, Cuenta As Double, Comunidad As String
    '*****************************
    Private _ultimo As Boolean = False
    Private idult As IDataReader, idusu As IDataReader = Nothing
    Private rez_con As String = "", rez_alca As String = "", rez_san As String = "", rez_rec As String = "", rez_iva As String = ""
    Private act_con As String = "", act_alca As String = "", act_san As String = "", act_rec As String = "", act_iva As String = ""
    Private t_con As String = "", t_alca As String = "", t_san As String = "", t_rec As String = "", t_iva As String = ""
    Private tot_consua As String = "", tot_consun As String = "", tot_gen1 As String = "", otr_cargos As String = "", cargomconsumo As String = "", abodescu As String = "", totalmenosab As String = "", totalfinal As String = ""



    Dim PagadoUl As Boolean = False

#Region "Modificadores"
    Public Property _rez_con() As String
        Get
            Return FormatCurrency(CDbl(rez_con), 2)
        End Get
        Set(ByVal value As String)
            rez_con = value
        End Set
    End Property

    Public Property _rez_alca() As String
        Get
            Return FormatCurrency(CDbl(rez_alca), 2)
        End Get
        Set(ByVal value As String)
            rez_alca = value
        End Set
    End Property

    Public Property _rez_san() As String
        Get
            Return FormatCurrency(CDbl(rez_san), 2)
        End Get
        Set(ByVal value As String)
            rez_san = value
        End Set
    End Property

    Public Property _rez_rec() As String
        Get
            Return FormatCurrency(CDbl(rez_rec), 2)
        End Get
        Set(ByVal value As String)
            rez_rec = value
        End Set
    End Property

    Public Property _rez_iva() As String
        Get
            Return FormatCurrency(CDbl(rez_iva), 2)
        End Get
        Set(ByVal value As String)
            rez_iva = value
        End Set
    End Property

    Public Property _act_con() As String
        Get
            Return FormatCurrency(CDbl(act_con), 2)
        End Get
        Set(ByVal value As String)
            act_con = value
        End Set
    End Property

    Public Property _act_alca() As String
        Get
            Return FormatCurrency(CDbl(act_alca), 2)
        End Get
        Set(ByVal value As String)
            act_alca = value
        End Set
    End Property

    Public Property _act_san() As String
        Get
            Return FormatCurrency(CDbl(act_san), 2)
        End Get
        Set(ByVal value As String)
            act_san = value
        End Set
    End Property

    Public Property _act_rec() As String
        Get
            Return FormatCurrency(CDbl(act_rec), 2)
        End Get
        Set(ByVal value As String)
            act_rec = value
        End Set
    End Property

    Public Property _act_iva() As String
        Get
            Return FormatCurrency(CDbl(act_iva), 2)
        End Get
        Set(ByVal value As String)
            act_iva = value
        End Set
    End Property

    Public Property _tot_consua() As String
        Get
            Return FormatCurrency(CDbl(tot_consua), 2)
        End Get
        Set(ByVal value As String)
            tot_consua = value
        End Set
    End Property

    Public Property _tot_consun() As String
        Get
            Return FormatCurrency(CDbl(tot_consun), 2)
        End Get
        Set(ByVal value As String)
            tot_consun = value
        End Set
    End Property

    Public Property _tot_gen1() As String
        Get
            Return FormatCurrency(CDbl(tot_gen1), 2)
        End Get
        Set(ByVal value As String)
            tot_gen1 = value
        End Set
    End Property

    Public Property _otr_cargos() As String
        Get
            Return FormatCurrency(CDbl(otr_cargos), 2)
        End Get
        Set(ByVal value As String)
            otr_cargos = value
        End Set
    End Property

    Public Property _cargomconsumo() As String
        Get
            Try
                Return FormatCurrency(CDbl(cargomconsumo), 2)
            Catch ex As Exception
                Return FormatCurrency(0, 2)
            End Try

        End Get
        Set(ByVal value As String)
            cargomconsumo = value
        End Set
    End Property

    Public Property _abodescu() As String
        Get
            Return FormatCurrency(CDbl(abodescu), 2)
        End Get
        Set(ByVal value As String)
            abodescu = value
        End Set
    End Property

    Public Property _totalmenosab() As String
        Get
            Return FormatCurrency(CDbl(totalmenosab), 2)
        End Get
        Set(ByVal value As String)
            totalmenosab = value
        End Set
    End Property

    Public Property ultimo() As Boolean
        Get
            Return _ultimo
        End Get
        Set(ByVal value As Boolean)
            If value Then
                idult = ConsultaSql("select mes_periodo, an_per, pagado from estados where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "' and ultimo=1").ExecuteReader()
                If idult.Read() Then
                    Mes = idult("mes_periodo")
                    Año = idult("an_per")

                    'TreeDesglose.Nodes(0).NodesColumns(1).Visible = False
                    'TreeDesglose.Nodes(0).NodesColumns(2).Visible = False
                    LblPeriodo.Visible = False
                    lblmesconsultando.Visible = False
                    lblanoconsultando.Visible = False

                    TreeDesglose.Nodes(0).Nodes(8).Visible = True
                    TreeDesglose.Nodes(0).Nodes(9).Visible = True
                    TabItem2.Text = "Saldo al día"
                    TabItem1.Visible = False
                    TabLectura.Visible = False
                    TabPAGADO.Visible = False
                    PagadoUl = CBool(idult("Pagado"))
                Else
                    PagadoUl = False
                End If
            End If
            _ultimo = value

        End Set
    End Property

    Public Property _t_con() As String
        Get
            Return FormatCurrency(CDbl(t_con), 2)
        End Get
        Set(ByVal value As String)
            t_con = value
        End Set
    End Property

    Public Property _t_alca() As String
        Get
            Return FormatCurrency(CDbl(t_alca), 2)
        End Get
        Set(ByVal value As String)
            t_alca = value
        End Set
    End Property

    Public Property _t_san() As String
        Get
            Return FormatCurrency(CDbl(t_san), 2)
        End Get
        Set(ByVal value As String)
            t_san = value
        End Set
    End Property

    Public Property _t_rec() As String
        Get
            Return FormatCurrency(CDbl(t_rec), 2)
        End Get
        Set(ByVal value As String)
            t_rec = value
        End Set
    End Property

    Public Property _t_iva() As String
        Get
            Return FormatCurrency(CDbl(t_iva), 2)
        End Get
        Set(ByVal value As String)
            t_iva = value
        End Set
    End Property

    Public Property _totalfinal() As String
        Get
            Return FormatCurrency(CDbl(totalfinal), 2)
        End Get
        Set(ByVal value As String)
            totalfinal = value
        End Set
    End Property
#End Region

    Public Sub Mostrar()
        LBLSERIE.Text = ""
        lblseriefacturaanticipo.Text = ""
        lblfechafactura.Text = ""
        lblfechaanticipo.Text = ""
        oficina.Text = ""
        lbloficinaanticipo.Text = ""
        lblmontoanticipo.Text = ""
        lblcaja.Text = ""
        lblcajaanticipo.Text = ""
        If _ultimo Then ' *************** Es saldo al dia
            Me.llenaultimo()
        Else  '************ es consulta de periodos
            Me.llenaperiodo()

        End If ' en if del consultador de periodos

    End Sub



    Private Sub llenaultimo()
        Dim CierreAnt As IDataReader = Nothing
        Dim CierreAntHoy As IDataReader = Nothing
        Dim rconsumo As Double = 0, rrecargo As Double = 0, rsan As Double = 0, ralca As Double = 0, riva As Double = 0
        Dim LOLEYO As Boolean = False

        Try
            CierreAntHoy = ConsultaSql("select rezagoalcanta('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as alcanta, rezagoconsumo('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as consumo, rezagoiva('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as iva, rezagootros('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as otros, rezagorecargos('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as recargos, rezagosanea('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as sanea").ExecuteReader()
            CierreAntHoy.Read()
            CierreAnt = ConsultaSql("select * from estados where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "' and ULTIMO=1").ExecuteReader  'mes_periodo='" & Mes & "' and an_per=" & Año & "").ExecuteReader
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Periodos de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Not CierreAnt.Read() Then
            rconsumo = 0
            rrecargo = 0
            rsan = 0
            ralca = 0
            riva = 0

        Else ' si lo leyo el ultimo periodo

            If Not CBool(CierreAnt("pagado")) Then
                rconsumo = CierreAnt("consumo")
                rrecargo = CierreAnt("REZ_REC")
                rsan = CierreAnt("saneamiento")
                ralca = CierreAnt("DRENAJE")
                riva = CierreAnt("IVA")
            Else
                rconsumo = 0
                rrecargo = 0
                rsan = 0
                ralca = 0
                riva = 0
            End If
            Dim Tarifa As String = ""
            Try
                Tarifa = obtenerCampo("Select descripcion_cuota from  cuotas where id_tarifa='" & CierreAnt("tarifa") & "'", "descripcion_cuota")
            Catch ex As Exception

            End Try

            Dim Comu As String = ""
            Try
                Comu = obtenerCampo("Select comunidad from comunidades where id_comunidad ='" & CierreAnt("id_comunidad") & "'", "comunidad")
            Catch ex As Exception

            End Try

            idusu = ConsultaSql("select * from usuario where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "'").ExecuteReader()
            idusu.Read()

            txtUbi.Text = String.Concat(idusu("Region"), " - ", idusu("ruta"), " - ", idusu("manzana"), " - ", idusu("lote"))

            Tarifa = obtenerCampo("Select descripcion_cuota from  cuotas where id_tarifa='" & idusu("tarifa") & "'", "descripcion_cuota")
            Comu = obtenerCampo("Select comunidad from comunidades where id_comunidad ='" & idusu("id_comunidad") & "'", "comunidad")


            LblCuenta.Text = Cuenta
            LblComunidad.Text = Comu
            LBLNOMBRE.Text = idusu("nombre")
            LBLCUOTA.Text = Tarifa
            If LBLCUOTA.Text = "0" Then
                LBLCUOTA.Text = ""
            End If
            Try
                Dim act As Date = DateAdd(DateInterval.Month, -1, Now)
                Dim mact As String = UCase(MonthName(act.Month, True))
                Dim aact As Integer = act.Year
                Dim mact1 As String = UCase(MonthName(Now.Month, True))
                Dim aact1 As Integer = Now.Year

                If Not obtenerCampo("select MESINICIALDEUDA('" & Comunidad & "'," & Cuenta & ",'NOP',1900) as m", "m") = "NOP" Then
                    lbmesini.Text = obtenerCampo("select MESINICIALDEUDA('" & Comunidad & "'," & Cuenta & ",'ENE',1900) as m", "m")
                    lbanoini.Text = obtenerCampo("select ANOINICIALDEUDA('" & Comunidad & "'," & Cuenta & ",'ENE',1900) as m", "m")

                    lbmesfin.Text = mact
                    lbanofin.Text = aact
                Else
                    lbmesini.Text = ""
                    lbanoini.Text = ""

                    lbmesfin.Text = ""
                    lbanofin.Text = ""
                End If

               

                LBLMESREZAGO.Text = CierreAnt("MES_REZ")
            Catch ex As Exception
            End Try

            Try
                LBLTIPOSERVICIO.Text = obtenerCampo("Select descripcion_cuota as descripcion from cuotas where id_tarifa = '" & CierreAnt("TARIFA") & "'", "descripcion")
            Catch ex As Exception
                LBLTIPOSERVICIO.Text = obtenerCampo("Select descripcion_cuota as descripcion from cuotas where id_tarifa = '" & idusu("TARIFA") & "'", "descripcion")
            End Try

            If LBLTIPOSERVICIO.Text = "0" Then
                LBLTIPOSERVICIO.Text = ""
            End If
            Try
                LblFServ.Text = obtenerCampo("Select descripcion from formas_servicio where id_forma_servicio = '" & CierreAnt("COD_HOR") & "'", "descripcion")
            Catch ex As Exception
                LblFServ.Text = obtenerCampo("Select descripcion from formas_servicio where id_forma_servicio = '" & idusu("ID_FORMA_SERVICIO") & "'", "descripcion")
            End Try

            If LblFServ.Text = "0" Then
                LblFServ.Text = ""
            End If

            Try
                LBLGIRO.Text = obtenerCampo("Select descripcION from  GIRO where CODGIR='" & CierreAnt("COD_GIR") & "'", "descripcion")
            Catch ex As Exception
                LBLGIRO.Text = obtenerCampo("Select descripcION from  GIRO where CODGIR='" & idusu("COD_GIR") & "'", "descripcion")
            End Try

            If LBLGIRO.Text = "0" Then
                LBLGIRO.Text = ""
            End If
            LBLMEDIDOR.Text = idusu("nodemedidor")
            lblmesconsultando.Text = UCase(Mes)
            lblanoconsultando.Text = Año
            '***************************************

            Dim SUMA1 As Double, SUMA2 As Double

            If PagadoUl = False Then ' si no esta pagado

                'Consumo Anterior
                TreeDesglose.Nodes(0).Nodes(0).Cells(1).HostedControl = monedatext(CierreAntHoy("consumo"))
                rez_con = CierreAntHoy("consumo")
                'Recargo Anterior
                TreeDesglose.Nodes(0).Nodes(3).Cells(1).HostedControl = monedatext(CierreAntHoy("recargos"))
                rez_rec = CierreAntHoy("recargos")
                'Saneamiento Anterior
                TreeDesglose.Nodes(0).Nodes(2).Cells(1).HostedControl = monedatext(CierreAntHoy("sanea"))
                rez_san = CierreAntHoy("sanea")
                'Alcantarillado Anterior
                TreeDesglose.Nodes(0).Nodes(1).Cells(1).HostedControl = monedatext(CierreAntHoy("alcanta"))
                rez_alca = CierreAntHoy("alcanta")
                'IVA Anterior
                TreeDesglose.Nodes(0).Nodes(4).Cells(1).HostedControl = monedatext(CierreAntHoy("iva"))
                rez_iva = CierreAntHoy("iva")

                'Consumo Actual
                TreeDesglose.Nodes(0).Nodes(0).Cells(2).HostedControl = monedatext(rconsumo)
                act_con = rconsumo
                'Recargo Actual
                TreeDesglose.Nodes(0).Nodes(3).Cells(2).HostedControl = monedatext(0)
                act_rec = 0
                'Saneamiento Actual
                TreeDesglose.Nodes(0).Nodes(2).Cells(2).HostedControl = monedatext(rsan)
                act_san = rsan
                'IVA Actual
                TreeDesglose.Nodes(0).Nodes(4).Cells(2).HostedControl = monedatext(riva)
                act_iva = riva
                'Alcantarilado Actual
                TreeDesglose.Nodes(0).Nodes(1).Cells(2).HostedControl = monedatext(ralca)
                act_alca = ralca


                'TOTALES
                'Total Consumo 
                TreeDesglose.Nodes(0).Nodes(0).Cells(3).HostedControl = monedatext(rconsumo + CierreAntHoy("consumo"))
                t_con = rconsumo + CierreAntHoy("consumo")

                'Total RECARGO
                TreeDesglose.Nodes(0).Nodes(3).Cells(3).HostedControl = monedatext(CierreAntHoy("recargos"))
                t_rec = CierreAntHoy("recargos")

                'Total IVA
                TreeDesglose.Nodes(0).Nodes(4).Cells(3).HostedControl = monedatext(CierreAntHoy("iva") + riva)
                t_iva = CierreAntHoy("iva") + riva

                'Total Saneamiento 
                TreeDesglose.Nodes(0).Nodes(2).Cells(3).HostedControl = monedatext(rsan + CierreAntHoy("sanea"))
                t_san = rsan + CierreAntHoy("sanea")

                'Total Alcantarilado
                TreeDesglose.Nodes(0).Nodes(1).Cells(3).HostedControl = monedatext(ralca + CierreAntHoy("alcanta"))
                t_alca = ralca + CierreAntHoy("alcanta")

                ' Totales abajo
                SUMA1 = CierreAntHoy("consumo") + CierreAntHoy("alcanta") + CierreAntHoy("sanea") + CierreAntHoy("recargos") + CierreAntHoy("iva")
                SUMA2 = rconsumo + ralca + rsan + riva
                tot_consua = SUMA1
                tot_consun = SUMA2

                'If Not ultimo Then
                TreeDesglose.Nodes(0).Nodes(5).Cells(1).HostedControl = monedatext(SUMA1)
                TreeDesglose.Nodes(0).Nodes(5).Cells(2).HostedControl = monedatext(SUMA2)
                ' GRAN TOTAL
                TreeDesglose.Nodes(0).Nodes(5).Cells(3).HostedControl = monedatext(SUMA1 + SUMA2)
                tot_gen1 = SUMA1 + SUMA2



            Else ' si esta pagado
                'Consumo Anterior
                TreeDesglose.Nodes(0).Nodes(0).Cells(1).HostedControl = monedatext(0)
                rez_con = 0
                'Recargo Anterior
                TreeDesglose.Nodes(0).Nodes(3).Cells(1).HostedControl = monedatext(0)
                rez_rec = 0
                'Saneamiento Anterior
                TreeDesglose.Nodes(0).Nodes(2).Cells(1).HostedControl = monedatext(0)
                rez_san = 0
                'Alcantarillado Anterior
                TreeDesglose.Nodes(0).Nodes(1).Cells(1).HostedControl = monedatext(0)
                rez_alca = 0
                'IVA Anterior
                TreeDesglose.Nodes(0).Nodes(4).Cells(1).HostedControl = monedatext(0)
                rez_iva = 0

                'Total Consumo 

                TreeDesglose.Nodes(0).Nodes(0).Cells(2).HostedControl = monedatext(0)
                act_con = 0
                'Total RECARGO
                TreeDesglose.Nodes(0).Nodes(3).Cells(2).HostedControl = monedatext(0)
                act_rec = 0
                'Total IVA
                TreeDesglose.Nodes(0).Nodes(4).Cells(2).HostedControl = monedatext(0)
                act_iva = 0
                'Total Saneamiento 
                TreeDesglose.Nodes(0).Nodes(2).Cells(2).HostedControl = monedatext(0)
                act_san = 0
                'Total Alcantarilado
                TreeDesglose.Nodes(0).Nodes(1).Cells(2).HostedControl = monedatext(0)
                act_alca = 0

                'Total Consumo 
                TreeDesglose.Nodes(0).Nodes(0).Cells(3).HostedControl = monedatext(0)
                t_con = 0
                'Total RECARGO
                TreeDesglose.Nodes(0).Nodes(3).Cells(3).HostedControl = monedatext(0)
                t_rec = 0
                'Total IVA
                TreeDesglose.Nodes(0).Nodes(4).Cells(3).HostedControl = monedatext(0)
                t_iva = 0
                'Total Saneamiento 
                TreeDesglose.Nodes(0).Nodes(2).Cells(3).HostedControl = monedatext(0)
                t_san = 0
                'Total Alcantarilado
                TreeDesglose.Nodes(0).Nodes(1).Cells(3).HostedControl = monedatext(0)
                t_alca = 0
                ' Totales abajo
                Try
                    SUMA1 = 0 'CierreAnt("REZ_CON") + CierreAnt("REZ_DRE") + CierreAnt("REZ_SAN") + CierreAnt("REZ_REC") + CierreAnt("REZ_IVA")
                    SUMA2 = 0 'CierreAnt("CONSUMO") + CierreAnt("DRENAJE") + CierreAnt("SANEAMIENTO") + CierreAnt("IVA")
                    tot_consua = 0
                    tot_consun = 0
                Catch ex As Exception

                End Try

                'If Not ultimo Then
                TreeDesglose.Nodes(0).Nodes(5).Cells(1).HostedControl = monedatext(0)
                TreeDesglose.Nodes(0).Nodes(5).Cells(2).HostedControl = monedatext(0)
                ' GRAN TOTAL

                TreeDesglose.Nodes(0).Nodes(5).Cells(3).HostedControl = monedatext(0)
                tot_gen1 = 0
            End If


            Dim otrosAct As Double = 0

            Try
                otrosAct = obtenerCampo("select sum(resta+TOTREC) as  toto from otrosconceptos where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "' and pagado=false and tipo_mov='Cargo' and not estado='Cancelado' and fec_apli<='" & UnixDateFormat(Now) & "'", "toto")
            Catch ex As Exception
                otrosAct = 0
            End Try

            otr_cargos = otrosAct


            TreeDesglose.Nodes(0).Nodes(6).Cells(3).HostedControl = monedatext(otrosAct)
            TreeDesglose.Nodes(0).Nodes(7).Cells(3).HostedControl = monedatext(SUMA1 + SUMA2 + otrosAct)
            cargomconsumo = SUMA1 + SUMA2 + otrosAct
            Dim monAnti As Double = 0, MONTIANTICIPO As Double = 0, MONTIABONOS As Double = 0


            Try

                If obtenerCampo("select sum(resta) as  toto from otrosconceptos where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "' and pagado=false and tipo_mov='Abono' and not estado='Cancelado' and fec_apli<='" & UnixDateFormat(Now) & "' ", "toto") = "0" Then
                    monAnti = 0
                Else
                    monAnti = Val(obtenerCampo("select sum(resta) as  toto from otrosconceptos where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "' and pagado=false and tipo_mov='Abono' AND CONCEPTO='ANTICIPO' and not estado='Cancelado' and fec_apli<='" & UnixDateFormat(Now) & "' ", "toto"))
                    MONTIABONOS = Val(obtenerCampo("select sum(resta) as  toto from otrosconceptos where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "' and pagado=false and tipo_mov='Abono' AND CONCEPTO<>'ANTICIPO' and not estado='Cancelado' and fec_apli<='" & UnixDateFormat(Now) & "' ", "toto"))
                End If
                If IsDBNull(CierreAnt("ANTICIPO")) Then
                    MONTIANTICIPO = 0
                Else
                    MONTIANTICIPO = CierreAnt("ANTICIPO")

                End If

                If monAnti > 0 And CierreAnt("PAGADO") = 1 Then
                    monAnti += MONTIABONOS
                End If

                If MONTIANTICIPO > 0 And CierreAnt("PAGADO") = 0 Then
                    monAnti = MONTIANTICIPO + MONTIABONOS
                End If
                If monAnti = 0 And MONTIABONOS > 0 And CierreAnt("PAGADO") = 0 Then
                    monAnti = MONTIABONOS
                End If



            Catch ex As Exception
                MessageBoxEx.Show(ex.Message)
                monAnti = 0
            End Try
            monAnti *= -1

            TreeDesglose.Nodes(0).Nodes(8).Cells(3).HostedControl = monedatext(monAnti)
            abodescu = monAnti

            Try
                TreeDesglose.Nodes(0).Nodes(9).Cells(3).HostedControl = monedatext(SUMA1 + SUMA2 + otrosAct + monAnti)
                totalfinal = SUMA1 + SUMA2 + otrosAct + monAnti
            Catch ex As Exception

            End Try
            If CierreAnt("PAGADO") = 0 Then
                TabPAGADO.Visible = False
                If CierreAnt("pagado") = 0 And CierreAnt("anticipo") > 0 Then
                    TabPAGADO.Visible = True
                    TabPAGADO.Text = "Anticipo"
                End If
            Else

                TabPAGADO.Visible = True

            End If
            Dim i As Integer
            'Detalles de Convenio
            For i = 0 To TreeMovimientos.Nodes(1).Nodes.Count - 1
                TreeMovimientos.Nodes(1).Nodes.Remove(TreeMovimientos.Nodes(1).Nodes.Item(0))
            Next i
            i = 1
            Dim Movi As IDataReader
            If Not ultimo Then
                Movi = ConsultaSql("select * from otrosconceptos where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "' and mes_periodo = '" & Mes & "' and an_per = " & Año & " and Tipo_Mov = 'Cargo' and not estado='Cancelado'").ExecuteReader
            Else
                Movi = ConsultaSql("select * from otrosconceptos where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'  and Tipo_Mov = 'Cargo' and pagado=False and not estado='Cancelado' and fec_apli<='" & UnixDateFormat(Now) & "'").ExecuteReader
            End If

            TreeMovimientos.Nodes(0).Nodes.Clear()
            Do While Movi.Read

                TreeMovimientos.Nodes(0).Nodes.Add(New DevComponents.AdvTree.Node())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(0).Text = Movi("Concepto")
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                Try
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(1).Text = (Movi("Fec_apli"))
                Catch ex As Exception
                End Try
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(2).HostedControl = monedatext(Movi("Total"))
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(3).HostedControl = monedatext(Movi("Resta"))
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(4).HostedControl = monedatext(Movi("totrec"))
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                If Movi("Pagado") = 0 Then
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).Text = "No"
                Else
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).Text = "Si"
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).CheckBoxStyle = eCheckBoxStyle.CheckBox
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).CheckBoxVisible = True
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).Checked = True
                End If

                i += 1
            Loop
            Movi.Close()
            i = 1
            Movi = ConsultaSql("select * from otrosconceptos where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'  and Tipo_Mov = 'Abono' and pagado=false and not estado='Cancelado' and fec_apli<='" & UnixDateFormat(Now) & "'").ExecuteReader

            TreeMovimientos.Nodes(1).Nodes.Clear()
            Do While Movi.Read

                TreeMovimientos.Nodes(1).Nodes.Add(New DevComponents.AdvTree.Node())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(0).Text = Movi("Concepto")
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(1).Text = "" & Movi("Fec_alta")
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(2).HostedControl = monedatext(Movi("Total"))
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(3).HostedControl = monedatext(Movi("Resta"))
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                If Movi("Pagado") = 0 Then
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Text = "No"
                    'TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxStyle = eCheckBoxStyle.CheckBox
                    'TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxVisible = True
                    'TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Checked = False
                Else
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Text = "Si"
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxStyle = eCheckBoxStyle.CheckBox
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxVisible = True
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Checked = True
                End If
                i += 1
            Loop
            Movi.Close()

            Dim labelpagado As New Label, labelpagado2 As New Label
            labelpagado.Text = "Pagado"
            labelpagado.BackColor = Color.GreenYellow
            labelpagado.ForeColor = Color.Black
            labelpagado.Height = 15
            labelpagado2.Height = 15


            If CierreAnt("pagado") = 1 Then
                AdvACTUALIZADO.Nodes(0).Cells(1).HostedControl = labelpagado
            Else
                AdvACTUALIZADO.Nodes(0).Cells(1).HostedControl = labelpagado2
            End If



            AdvACTUALIZADO.Nodes(0).Nodes(0).Cells(1).HostedControl = monedatext(CierreAnt("CONSUMO"))
            AdvACTUALIZADO.Nodes(0).Nodes(1).Cells(1).HostedControl = monedatext(CierreAnt("DRENAJE"))
            AdvACTUALIZADO.Nodes(0).Nodes(2).Cells(1).HostedControl = monedatext(CierreAnt("SANEAMIENTO"))
            AdvACTUALIZADO.Nodes(0).Nodes(3).Cells(1).HostedControl = monedatext(CierreAnt("RECA_ACU_TOTAL"))
            AdvACTUALIZADO.Nodes(0).Nodes(4).Cells(1).HostedControl = monedatext((CierreAnt("baseconsumo") + CierreAnt("baserecargo")) * VARIABLE_IVA)
            AdvACTUALIZADO.Nodes(0).Nodes(5).Cells(1).HostedControl = monedatext(CierreAnt("CONSUMO") + CierreAnt("DRENAJE") + CierreAnt("SANEAMIENTO") + CierreAnt("RECA_ACU_TOTAL") + ((CierreAnt("baseconsumo") + CierreAnt("baserecargo")) * VARIABLE_IVA))


            ' SI HAY ANTICIPO AGREGA LA RESTA
            If CierreAnt("anticipo") > 0 And CierreAnt("pagado") = 0 Then
                'AdvACTUALIZADO.Nodes(0).Nodes.Add(New DevComponents.AdvTree.Node())
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(0).Text = "Anticipo"
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(1).HostedControl = monedatext(CierreAnt("anticipo") * -1)
            End If
            If CierreAnt("pagado") = 1 Then
                'AdvACTUALIZADO.Nodes(0).Nodes.Add(New DevComponents.AdvTree.Node())
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(0).Text = ""
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(1).HostedControl = Nothing

            End If

            If CierreAnt("anticipo") = 0 Then
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(0).Text = ""
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(1).HostedControl = Nothing
            End If

            AdvACTUALIZADO.Nodes(0).Nodes(7).Cells(1).HostedControl = monedatext(CierreAnt("Saldo"))


            ' llenado pagado con
            If CierreAnt("pagado") = 1 Then
                If IsDBNull(CierreAnt("SERIE")) Then
                    LBLSERIE.Text = " "
                Else
                    LBLSERIE.Text = CierreAnt("SERIE")
                End If

                If IsDBNull(CierreAnt("FACTURA")) Then
                    LBLNUMERO.Text = " "
                Else
                    LBLNUMERO.Text = CierreAnt("FACTURA")
                End If

                If IsDBNull(CierreAnt("OFI_PAGO")) Then
                    oficina.Text = " "
                Else
                    oficina.Text = CierreAnt("OFI_PAGO")
                    Dim nomofi As String
                    nomofi = obtenerCampo("select nombre from oficinas where cod_ofi='" & CierreAnt("OFI_PAGO") & "'", "nombre")
                    If nomofi <> "0" Then
                        oficina.Text = oficina.Text & " " & nomofi
                    End If

                End If

                If IsDBNull(CierreAnt("caja")) Then
                    lblcaja.Text = " "
                Else
                    lblcaja.Text = CierreAnt("caja")
                End If

                If IsDBNull(CierreAnt("fechafac")) Then
                    lblcaja.Text = " "
                Else
                    lblfechafactura.Text = CierreAnt("fechafac")
                End If
            End If
            ' factura del anticipo sí es que hubo

            If CierreAnt("anticipo") > 0 Then
                lblmontoanticipo2.Text = Format(CierreAnt("anticipo"), "###,##0.00")

                Dim tablaanticipo As IDataReader
                tablaanticipo = Nothing
                Try
                    tablaanticipo = ConsultaSql("select * from anticipos where idmov='" & CierreAnt("idanticipo") & "'").ExecuteReader

                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message)
                    MessageBoxEx.Show("El error anterior no permitió cargar los datos del anticipo")
                End Try

                If tablaanticipo.Read() Then
                    lblfacturaanticipo.Text = tablaanticipo("recibo")
                    lblseriefacturaanticipo.Text = tablaanticipo("serie")
                    lblcajaanticipo.Text = tablaanticipo("caja")
                    lblmontoanticipo2.Text = CierreAnt("anticipo")
                    lblfechaanticipo.Text = tablaanticipo("fecha")
                End If
            End If


        End If ' end if de si lo leyo


    End Sub

    Private Sub llenaperiodo()
        Dim CierreAnt As IDataReader = Nothing
        Dim CierreAntHoy As IDataReader = Nothing
        Dim rconsumo As Double = 0, rrecargo As Double = 0, rsan As Double = 0, ralca As Double = 0, riva As Double = 0
        Dim LOLEYO As Boolean = False

        lblubi.Visible = False
        txtUbi.Visible = False
        Try
            CierreAnt = ConsultaSql("select * from estados where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "' and mes_periodo='" & Mes & "' and an_per=" & Año).ExecuteReader
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Periodos de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Not CierreAnt.Read() Then
            MessageBoxEx.Show("El periodo de facturacion para este contrato no existe", "Periodos de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else ' si lo leyo
            If Not CBool(CierreAnt("pagado")) Then
                rconsumo = CierreAnt("consumo")
                rrecargo = CierreAnt("REZ_REC")
                rsan = CierreAnt("saneamiento")
                ralca = CierreAnt("DRENAJE")
                riva = CierreAnt("IVA")
            Else
                rconsumo = 0
                rrecargo = 0
                rsan = 0
                ralca = 0
                riva = 0
            End If
            Dim Tarifa As String = ""
            Try
                Tarifa = obtenerCampo("Select descripcion_cuota from  cuotas where id_tarifa='" & CierreAnt("tarifa") & "'", "descripcion_cuota")
            Catch ex As Exception

            End Try

            Dim Comu As String = ""
            Try
                Comu = obtenerCampo("Select comunidad from comunidades where id_comunidad ='" & CierreAnt("id_comunidad") & "'", "comunidad")
            Catch ex As Exception

            End Try
            LBLNOMBRE.Text = CierreAnt("Nombre")
            LBLCUOTA.Text = Tarifa
            LblCuenta.Text = Cuenta
            LblComunidad.Text = Comu
            If LBLCUOTA.Text = "0" Then
                LBLCUOTA.Text = ""
            End If
            Try
                lbmesini.Text = CierreAnt("per_ini")
                lbanoini.Text = CierreAnt("aNo_ini")
                lbmesfin.Text = CierreAnt("per_fin")
                lbanofin.Text = CierreAnt("an_fin")
                LBLMESREZAGO.Text = CierreAnt("MES_REZ")
            Catch ex As Exception
            End Try

            Try
                LBLTIPOSERVICIO.Text = obtenerCampo("Select descripcion_cuota as descripcion from cuotas where id_tarifa = '" & CierreAnt("TARIFA") & "'", "descripcion")
            Catch ex As Exception
                LBLTIPOSERVICIO.Text = obtenerCampo("Select descripcion_cuota as descripcion from cuotas where id_tarifa = '" & idusu("TARIFA") & "'", "descripcion")
            End Try

            If LBLTIPOSERVICIO.Text = "0" Then
                LBLTIPOSERVICIO.Text = ""
            End If
            Try
                LblFServ.Text = obtenerCampo("Select descripcion from formas_servicio where id_forma_servicio = '" & CierreAnt("COD_HOR") & "'", "descripcion")
            Catch ex As Exception
                LblFServ.Text = obtenerCampo("Select descripcion from formas_servicio where id_forma_servicio = '" & idusu("ID_FORMA_SERVICIO") & "'", "descripcion")
            End Try

            If LblFServ.Text = "0" Then
                LblFServ.Text = ""
            End If

            Try
                LBLGIRO.Text = obtenerCampo("Select descripcION from  GIRO where CODGIR='" & CierreAnt("COD_GIR") & "'", "descripcion")
            Catch ex As Exception
                LBLGIRO.Text = obtenerCampo("Select descripcION from  GIRO where CODGIR='" & idusu("COD_GIR") & "'", "descripcion")
            End Try

            If LBLGIRO.Text = "0" Then
                LBLGIRO.Text = ""
            End If
            LBLMEDIDOR.Text = CierreAnt("MEDIDOR")
            lblmesconsultando.Text = UCase(Mes)
            lblanoconsultando.Text = Año
            '***************************************

            Dim SUMA1 As Double, SUMA2 As Double

            If PagadoUl = False Then ' si no esta pagado


                'Consumo Anterior
                TreeDesglose.Nodes(0).Nodes(0).Cells(1).HostedControl = monedatext(CierreAnt("REZ_CON"))
                'Recargo Anterior
                TreeDesglose.Nodes(0).Nodes(3).Cells(1).HostedControl = monedatext(CierreAnt("REZ_REC"))
                'Saneamiento Anterior
                TreeDesglose.Nodes(0).Nodes(2).Cells(1).HostedControl = monedatext(CierreAnt("REZ_SAN"))
                'Alcantarillado Anterior
                TreeDesglose.Nodes(0).Nodes(1).Cells(1).HostedControl = monedatext(CierreAnt("REZ_DRE"))
                'IVA Anterior
                TreeDesglose.Nodes(0).Nodes(4).Cells(1).HostedControl = monedatext(CierreAnt("REZ_IVA"))




                'Consumo Actual
                If IsDBNull(CierreAnt("consumo")) Then
                    TreeDesglose.Nodes(0).Nodes(0).Cells(2).HostedControl = monedatext(0)
                Else
                    TreeDesglose.Nodes(0).Nodes(0).Cells(2).HostedControl = monedatext(CierreAnt("consumo"))
                End If


                'Recargo Actual
                TreeDesglose.Nodes(0).Nodes(3).Cells(2).HostedControl = monedatext(0)
                'Saneamiento Actual
                If IsDBNull(CierreAnt("SANEAMIENTO")) Then
                    TreeDesglose.Nodes(0).Nodes(2).Cells(2).HostedControl = monedatext(0)
                Else
                    TreeDesglose.Nodes(0).Nodes(2).Cells(2).HostedControl = monedatext(CierreAnt("saneamiento"))
                End If

                'IVA Actual
                If IsDBNull(CierreAnt("IVA_HIS")) Then
                    TreeDesglose.Nodes(0).Nodes(4).Cells(2).HostedControl = monedatext(0)
                Else
                    TreeDesglose.Nodes(0).Nodes(4).Cells(2).HostedControl = monedatext(CierreAnt("IVA_HIS"))
                End If

                'Alcantarilado Actual
                If IsDBNull(CierreAnt("DRENAJE")) Then
                    TreeDesglose.Nodes(0).Nodes(1).Cells(2).HostedControl = monedatext(0)
                Else
                    TreeDesglose.Nodes(0).Nodes(1).Cells(2).HostedControl = monedatext(CierreAnt("DRENAJE"))
                End If
                'End If


                'TOTALES

                'Total Consumo 

                TreeDesglose.Nodes(0).Nodes(0).Cells(3).HostedControl = monedatext(CierreAnt("consumo") + CierreAnt("rez_con"))

                'Total RECARGO
                TreeDesglose.Nodes(0).Nodes(3).Cells(3).HostedControl = monedatext(CierreAnt("rez_rec"))

                'Total IVA
                TreeDesglose.Nodes(0).Nodes(4).Cells(3).HostedControl = monedatext(CierreAnt("rez_IVA") + CierreAnt("IVA"))

                'Total Saneamiento 
                TreeDesglose.Nodes(0).Nodes(2).Cells(3).HostedControl = monedatext(CierreAnt("saneamiento") + CierreAnt("rez_san"))

                'Total Alcantarilado
                TreeDesglose.Nodes(0).Nodes(1).Cells(3).HostedControl = monedatext(CierreAnt("DRENAJE") + CierreAnt("rez_dre"))

                ' Totales abajo

                SUMA1 = CierreAnt("REZ_CON") + CierreAnt("REZ_DRE") + CierreAnt("REZ_SAN") + CierreAnt("REZ_REC") + CierreAnt("REZ_IVA")
                SUMA2 = CierreAnt("CONSUMO") + CierreAnt("DRENAJE") + CierreAnt("SANEAMIENTO") + CierreAnt("IVA")
                'If Not ultimo Then
                TreeDesglose.Nodes(0).Nodes(5).Cells(1).HostedControl = monedatext(SUMA1)
                TreeDesglose.Nodes(0).Nodes(5).Cells(2).HostedControl = monedatext(SUMA2)
                ' GRAN TOTAL
                TreeDesglose.Nodes(0).Nodes(5).Cells(3).HostedControl = monedatext(SUMA1 + SUMA2)



            Else ' si esta pagado 
                'Consumo Anterior
                TreeDesglose.Nodes(0).Nodes(0).Cells(1).HostedControl = monedatext(0)
                'Recargo Anterior
                TreeDesglose.Nodes(0).Nodes(3).Cells(1).HostedControl = monedatext(0)
                'Saneamiento Anterior
                TreeDesglose.Nodes(0).Nodes(2).Cells(1).HostedControl = monedatext(0)
                'Alcantarillado Anterior
                TreeDesglose.Nodes(0).Nodes(1).Cells(1).HostedControl = monedatext(0)
                'IVA Anterior
                TreeDesglose.Nodes(0).Nodes(4).Cells(1).HostedControl = monedatext(0)


                'Consumo Actual
                Try
                    If IsDBNull(CierreAnt("consumo")) Then
                        TreeDesglose.Nodes(0).Nodes(0).Cells(2).HostedControl = monedatext(0)
                    Else
                        TreeDesglose.Nodes(0).Nodes(0).Cells(2).HostedControl = monedatext(0)
                    End If
                    'Recargo Actual
                    TreeDesglose.Nodes(0).Nodes(3).Cells(2).HostedControl = monedatext(0)
                    'Saneamiento Actual
                    If IsDBNull(CierreAnt("SANEAMIENTO")) Then
                        TreeDesglose.Nodes(0).Nodes(2).Cells(2).HostedControl = monedatext(0)
                    Else
                        TreeDesglose.Nodes(0).Nodes(2).Cells(2).HostedControl = monedatext(0)
                    End If

                    'IVA Actual
                    If IsDBNull(CierreAnt("IVA_HIS")) Then
                        TreeDesglose.Nodes(0).Nodes(4).Cells(2).HostedControl = monedatext(0)
                    Else
                        TreeDesglose.Nodes(0).Nodes(4).Cells(2).HostedControl = monedatext(0)
                    End If

                    'Alcantarilado Actual
                    If IsDBNull(CierreAnt("DRENAJE")) Then
                        TreeDesglose.Nodes(0).Nodes(1).Cells(2).HostedControl = monedatext(0)
                    Else
                        TreeDesglose.Nodes(0).Nodes(1).Cells(2).HostedControl = monedatext(0)
                    End If
                    'End If
                Catch ex As Exception

                End Try
            End If ' si esta pagado

            Dim otrosMes As Double
            Dim otrosAct As Double = 0
            Try
                otrosMes = Val(obtenerCampo("Select Totalotrosmes('" & CierreAnt("id_comunidad") & "', " & Cuenta & ", '" & Mes & "' , " & Año & ") as Total", "Total"))

            Catch ex As Exception

            End Try

            TreeDesglose.Nodes(0).Nodes(6).Cells(1).HostedControl = monedatext(CierreAnt("REZ_OTR"))
            TreeDesglose.Nodes(0).Nodes(6).Cells(2).HostedControl = monedatext(otrosMes) 'CierreAnt("OTROS_CARGOS"))
            TreeDesglose.Nodes(0).Nodes(6).Cells(3).HostedControl = monedatext(otrosMes + CierreAnt("REZ_OTR")) 'CierreAnt("OTROS_CARGOS" + CierreAnt("REZ_OTR"))

            TreeDesglose.Nodes(0).Nodes(7).Cells(1).HostedControl = monedatext(CierreAnt("rez_otr") + SUMA1)
            TreeDesglose.Nodes(0).Nodes(7).Cells(2).HostedControl = monedatext(otrosMes + SUMA2)
            TreeDesglose.Nodes(0).Nodes(7).Cells(3).HostedControl = monedatext(CierreAnt("rez_otr") + otrosMes + SUMA1 + SUMA2)



            TreeLectura.Nodes(0).Nodes(0).Cells(1).Text = CierreAnt("lec_ant")
            'Actual
            TreeLectura.Nodes(0).Nodes(0).Cells(2).Text = CierreAnt("lec_act")
            'Consumo
            TreeLectura.Nodes(0).Nodes(1).Cells(1).Text = CierreAnt("con_M3")
            TreeLectura.Nodes(0).Nodes(2).Cells(1).Text = CierreAnt("con_prom")
            'Situacion1
            If IsDBNull(CierreAnt("CVE_MED")) Or CierreAnt("CVE_MED") = "" Then
                TreeLectura.Nodes(1).Nodes(0).Cells(1).Text = ""
            Else
                TreeLectura.Nodes(1).Nodes(0).Cells(1).Text = obtenerCampo("Select situacion from situacion where clave = '" & CierreAnt("CVE_MED") & "'", "Situacion")
            End If
            'Situacion2
            If IsDBNull(CierreAnt("CVE_PAD")) Or CierreAnt("CVE_PAD") = "" Then
                TreeLectura.Nodes(1).Nodes(1).Cells(1).Text = ""
            Else
                TreeLectura.Nodes(1).Nodes(1).Cells(1).Text = obtenerCampo("Select situacion from situacion where clave = '" & CierreAnt("CVE_PAD") & "'", "Situacion")
            End If
            'Situacion3
            If IsDBNull(CierreAnt("CVE_HID")) Or CierreAnt("CVE_HID") = "" Then
                TreeLectura.Nodes(1).Nodes(2).Cells(1).Text = ""
            Else
                TreeLectura.Nodes(1).Nodes(2).Cells(1).Text = obtenerCampo("Select situacion from situacion where clave = '" & CierreAnt("CVE_HID") & "'", "Situacion")
            End If

            If IsDBNull(CierreAnt("ACCION")) Then
                TreeLectura.Nodes(0).Nodes(3).Cells(1).Text = ""
            Else
                TreeLectura.Nodes(0).Nodes(3).Cells(1).Text = CierreAnt("ACCION")
            End If

            If IsDBNull(CierreAnt("FEC_LEC")) Then
                TreeLectura.Nodes(2).Nodes(0).Cells(1).Text = ""
            Else
                TreeLectura.Nodes(2).Nodes(0).Cells(1).Text = CierreAnt("FEC_LEC")
            End If


            If IsDBNull(CierreAnt("FEC_EMI")) Then
                TreeLectura.Nodes(2).Nodes(1).Cells(1).Text = ""
            Else
                TreeLectura.Nodes(2).Nodes(1).Cells(1).Text = CierreAnt("FEC_EMI")
            End If

            If IsDBNull(CierreAnt("FEC_VTO")) Then
                TreeLectura.Nodes(2).Nodes(2).Cells(1).Text = ""
            Else
                TreeLectura.Nodes(2).Nodes(2).Cells(1).Text = CierreAnt("FEC_VTO")
            End If
            If CierreAnt("PAGADO") = 0 Then
                TabPAGADO.Visible = False
                If CierreAnt("pagado") = 0 And CierreAnt("anticipo") > 0 Then
                    TabPAGADO.Visible = True
                    TabPAGADO.Text = "Anticipo"
                End If
            Else

                TabPAGADO.Visible = True

            End If
            Dim i As Integer
            'Detalles de Convenio
            For i = 0 To TreeMovimientos.Nodes(1).Nodes.Count - 1
                TreeMovimientos.Nodes(1).Nodes.Remove(TreeMovimientos.Nodes(1).Nodes.Item(0))
            Next i
            i = 1
            Dim Movi As IDataReader
            If Not ultimo Then
                Movi = ConsultaSql("select * from otrosconceptos where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "' and mes_periodo = '" & Mes & "' and an_per = " & Año & " and Tipo_Mov = 'Cargo' and not estado='Cancelado'").ExecuteReader
            Else
                Movi = ConsultaSql("select * from otrosconceptos where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'  and Tipo_Mov = 'Cargo' and pagado=False and not estado='Cancelado' and fec_apli<='" & UnixDateFormat(Now) & "'").ExecuteReader
            End If

            TreeMovimientos.Nodes(0).Nodes.Clear()
            Do While Movi.Read

                TreeMovimientos.Nodes(0).Nodes.Add(New DevComponents.AdvTree.Node())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(0).Text = Movi("Concepto")
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                Try
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(1).Text = (Movi("Fec_apli"))
                Catch ex As Exception
                End Try
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(2).HostedControl = monedatext(Movi("Total"))
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(3).HostedControl = monedatext(Movi("Resta"))
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(4).HostedControl = monedatext(Movi("totrec"))
                TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                If Movi("Pagado") = 0 Then
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).Text = "No"
                Else
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).Text = "Si"
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).CheckBoxStyle = eCheckBoxStyle.CheckBox
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).CheckBoxVisible = True
                    TreeMovimientos.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).Checked = True
                End If

                i += 1
            Loop
            Movi.Close()
            i = 1
            Movi = ConsultaSql("select * from otrosconceptos where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "' and mes_periodo = '" & Mes & "' and an_per = " & Año & " and Tipo_Mov = 'Abono' and not estado='Cancelado'").ExecuteReader

            TreeMovimientos.Nodes(1).Nodes.Clear()
            Do While Movi.Read

                TreeMovimientos.Nodes(1).Nodes.Add(New DevComponents.AdvTree.Node())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(0).Text = Movi("Concepto")
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(1).Text = "" & Movi("Fec_alta")
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(2).HostedControl = monedatext(Movi("Total"))
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(3).HostedControl = monedatext(Movi("Resta"))
                TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                If Movi("Pagado") = 0 Then
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Text = "No"
                    'TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxStyle = eCheckBoxStyle.CheckBox
                    'TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxVisible = True
                    'TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Checked = False
                Else
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Text = "Si"
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxStyle = eCheckBoxStyle.CheckBox
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).CheckBoxVisible = True
                    TreeMovimientos.Nodes.Item(1).Nodes.Item(i - 1).Cells(4).Checked = True
                End If
                i += 1
            Loop
            Movi.Close()


            Dim labelpagado As New Label, labelpagado2 As New Label
            labelpagado.Text = "Pagado"
            labelpagado.BackColor = Color.GreenYellow
            labelpagado.ForeColor = Color.Black
            labelpagado.Height = 15
            labelpagado2.Height = 15


            If CierreAnt("pagado") = 1 Then
                AdvACTUALIZADO.Nodes(0).Cells(1).HostedControl = labelpagado
            Else
                AdvACTUALIZADO.Nodes(0).Cells(1).HostedControl = labelpagado2
            End If



            AdvACTUALIZADO.Nodes(0).Nodes(0).Cells(1).HostedControl = monedatext(CierreAnt("CONSUMO"))
            AdvACTUALIZADO.Nodes(0).Nodes(1).Cells(1).HostedControl = monedatext(CierreAnt("DRENAJE"))
            AdvACTUALIZADO.Nodes(0).Nodes(2).Cells(1).HostedControl = monedatext(CierreAnt("SANEAMIENTO"))
            AdvACTUALIZADO.Nodes(0).Nodes(3).Cells(1).HostedControl = monedatext(CierreAnt("RECA_ACU_TOTAL"))
            AdvACTUALIZADO.Nodes(0).Nodes(4).Cells(1).HostedControl = monedatext((CierreAnt("baseconsumo") + CierreAnt("baserecargo")) * VARIABLE_IVA)
            AdvACTUALIZADO.Nodes(0).Nodes(5).Cells(1).HostedControl = monedatext(CierreAnt("CONSUMO") + CierreAnt("DRENAJE") + CierreAnt("SANEAMIENTO") + CierreAnt("RECA_ACU_TOTAL") + ((CierreAnt("baseconsumo") + CierreAnt("baserecargo")) * VARIABLE_IVA))


            ' SI HAY ANTICIPO AGREGA LA RESTA
            If CierreAnt("anticipo") > 0 And CierreAnt("pagado") = 0 Then
                'AdvACTUALIZADO.Nodes(0).Nodes.Add(New DevComponents.AdvTree.Node())
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(0).Text = "Anticipo"
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(1).HostedControl = monedatext(CierreAnt("anticipo") * -1)
            End If
            If CierreAnt("pagado") = 1 Then
                'AdvACTUALIZADO.Nodes(0).Nodes.Add(New DevComponents.AdvTree.Node())
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                'AdvACTUALIZADO.Nodes(0).Nodes(6).Cells.Add(New DevComponents.AdvTree.Cell)
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(0).Text = ""
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(1).HostedControl = Nothing

            End If

            If CierreAnt("anticipo") = 0 Then
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(0).Text = ""
                AdvACTUALIZADO.Nodes(0).Nodes(6).Cells(1).HostedControl = Nothing
            End If

            AdvACTUALIZADO.Nodes(0).Nodes(7).Cells(1).HostedControl = monedatext(CierreAnt("Saldo"))


            ' llenado pagado con
            If CierreAnt("pagado") = 1 Then
                If IsDBNull(CierreAnt("SERIE")) Then
                    LBLSERIE.Text = " "
                Else
                    LBLSERIE.Text = CierreAnt("SERIE")
                End If

                If IsDBNull(CierreAnt("FACTURA")) Then
                    LBLNUMERO.Text = " "
                Else
                    LBLNUMERO.Text = CierreAnt("FACTURA")
                End If

                If IsDBNull(CierreAnt("OFI_PAGO")) Then
                    oficina.Text = " "
                Else
                    oficina.Text = CierreAnt("OFI_PAGO")
                    Dim nomofi As String
                    nomofi = obtenerCampo("select nombre from oficinas where cod_ofi='" & CierreAnt("OFI_PAGO") & "'", "nombre")
                    If nomofi <> "0" Then
                        oficina.Text = oficina.Text & " " & nomofi
                    End If

                End If

                If IsDBNull(CierreAnt("caja")) Then
                    lblcaja.Text = " "
                Else
                    lblcaja.Text = CierreAnt("caja")
                End If

                If IsDBNull(CierreAnt("fechafac")) Then
                    lblcaja.Text = " "
                Else
                    lblfechafactura.Text = CierreAnt("fechafac")
                End If
            End If
            ' factura del anticipo sí es que hubo

            If CierreAnt("anticipo") > 0 Then
                lblmontoanticipo2.Text = Format(CierreAnt("anticipo"), "###,##0.00")

                Dim tablaanticipo As IDataReader
                tablaanticipo = Nothing
                Try
                    tablaanticipo = ConsultaSql("select * from anticipos where idmov='" & CierreAnt("idanticipo") & "'").ExecuteReader

                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message)
                    MessageBoxEx.Show("El error anterior no permitió cargar los datos del anticipo")
                End Try

                If tablaanticipo.Read() Then
                    lblfacturaanticipo.Text = tablaanticipo("recibo")
                    lblseriefacturaanticipo.Text = tablaanticipo("serie")
                    lblcajaanticipo.Text = tablaanticipo("caja")
                    lblmontoanticipo2.Text = CierreAnt("anticipo")
                    lblfechaanticipo.Text = tablaanticipo("fecha")
                End If
            End If

        End If ' si no lo leyo
    End Sub
End Class