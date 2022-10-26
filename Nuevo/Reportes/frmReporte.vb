Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports DevComponents.DotNetBar

Public Class frmReporte
    Dim _mord As Int16
    Dim _totreg As Boolean
    Public objRepEsp As ReportDocument 'HistorialUsuario
    Public objRepReca As ReportDocument 'RptRecaudacion
    Public TEXTOFILTRO As String
    Public objrep As ReportDocument

    Public Property mord() As Int16
        Get
            Return _mord
        End Get
        Set(ByVal value As Int16)
            _mord = value
        End Set
    End Property

    Public Property totreg() As Boolean
        Get
            Return _totreg
        End Get
        Set(ByVal value As Boolean)
            _totreg = value
        End Set
    End Property

    Enum Lista
        Convenio

        Contrato_Provisional
        Contrato_Editable
        antiresumen
        antirutas
        Factibilidad
        Solicitud
        Contrato
        contrato_drenaje
        Contrato_Cambio_Nombre
        LecturasxSituacion
        ReporteUsuarios
        Reportetomcon
        Departamentos
        formasPago
        ordenTrabajo
        FormasServ
        Estadistica_de_Calidad
        TipoUsuario
        Estadistica_Tipo_Queja
        ListRequeri
        Grafica_Calidad
        ListadoOrdenes
        ListadoSolicitudes
        catCxc
        Giro
        Situaciones
        Algoritmos
        Brigada
        Colonias
        Multas
        LecNoCapturadas
        Direccion
        repBajaTempora
        Municipios
        Sector
        DiametroToma
        repBajaDefinitiva
        Tarifas
        Ruta
        Faltantesdecontrato
        UsuSis
        CNA
        Empleados
        Comunidades
        Calles
        UsuariosCont
        antiguedad
        ConceptosCIS
        Fuentes
        MarMedidor
        EstadoTomas
        Cuotas
        Region
        TipoServicio
        Estadistica_de_Calidad_Det
        Estadistica_Tipo_Queja_Det
        HistAjus
        reporteCajas
        Oficinas
        CalculoConsumo
        UsuariosBaja
        EtiquetasPadUsu
        TomasContratadas
        verLecturas
        Notificaciones
        ListaNotificaciones
        Ubicacionmedidor
        Descuentos
        MaterialCalles
        Comprobante
    End Enum

    Public Sub New()
        InitializeComponent()
        objrep = New ReportDocument
    End Sub

    Public Sub New(ByVal tipo As Lista)
        InitializeComponent()
        objrep = New ReportDocument
        Select Case tipo
            Case Lista.antiresumen
                'Dim objrep As New ReportDocument

                objrep.Load(".\reportes\antigueresumen.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                ' crvReporte.SelectionFormula = ""
                crvReporte.ReportSource = objrep
            Case Lista.antirutas
                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\antiguerutas.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                ' crvReporte.SelectionFormula = ""
                crvReporte.ReportSource = objrep



        End Select

    End Sub

    Public Sub New(ByVal archivo As String, ByVal formula As String, ByVal titulo As String, ByVal ParamArray args() As Object)
        InitializeComponent()
        Dim obj As New clsreporte(dirReport & "\" & archivo, crvReporte, formula, args)
        crvReporte.Refresh()
        Me.Text = titulo
    End Sub

    Public Sub New(ByVal Tipo As Lista, ByVal Filtro As String, ByVal anti As Boolean, ByVal est As Boolean, ByVal otr As Boolean, ByVal pag As Boolean, ByVal ord As Boolean, ByVal ParamArray args() As Object)
        InitializeComponent()

        Dim i As Int16, tot As Int16
        Dim mat() As String


    End Sub



    Public Sub New(ByVal Tipo As Lista, ByVal Filtro As String, ByVal ParamArray args() As Object)
        InitializeComponent()
        objrep = New ReportDocument
        Dim i As Int16, tot As Int16
        Dim mat() As String = Nothing
        Select Case Tipo
            Case Lista.Factibilidad
                'Dim objRep As New Factibilidad
                '
                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\factibilidad.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next

            Case Lista.Solicitud
                'Dim objRep As New Solicitud
                '   Dim objrep As New ReportDocument
                objrep.Load(".\reportes\solicitud.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length

                For i = 0 To tot - 1
                    mat = Split(args(i), "* ")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.Contrato
                'Dim objRep As New Contrato

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\contrato_agua.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Contrato_Provisional
                'Dim objRep As New Contrato

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\Contrato_Provisiconal.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next

            Case Lista.contrato_drenaje
                'Dim objRep As New Contrato

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\contrato_drenaje.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Contrato_Cambio_Nombre
                'Dim objRep As New Contrato_Cambio_Nombre

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\Contrato_Cambio_Nombre.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next



            Case Lista.LecturasxSituacion
                'Dim objRep As New LecturasCapturadas

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\LecturasCapturadas.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.ReporteUsuarios
                'Dim objRep As New UsuariosDetalle

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\UsuariosDetalle.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep

                'Dim FieldDef As FieldDefinition

                'FieldDef = objRep.Database.Tables.Item(0).Fields.Item(_mord)
                'objRep.DataDefinition.SortFields.Item(0).Field = FieldDef
                'crvReporte.RefreshReport()
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

                crvReporte.RefreshReport()
            Case Lista.Reportetomcon
                'Dim objRep As New UsuariosDetalle

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\Usuarioscontra.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep

                'Dim FieldDef As FieldDefinition

                'FieldDef = objRep.Database.Tables.Item(0).Fields.Item(_mord)
                'objRep.DataDefinition.SortFields.Item(0).Field = FieldDef
                'crvReporte.RefreshReport()
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

                crvReporte.RefreshReport()


            Case Lista.ordenTrabajo
                'Dim objRep As New ordTrab

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\ordTrab.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If





            Case Lista.Estadistica_de_Calidad
                'Dim objRep As New repOrdTrabCal

                Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repOrdTrabCal.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")

                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Estadistica_Tipo_Queja
                'Dim objRep As New repOrdTrab

                Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repOrdTrab.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Grafica_Calidad
                'Dim objRep As New repCalidad

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repCalidad.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.ListadoOrdenes
                'Dim objRep As New rptListOrd

                Dim objrep As New ReportDocument
                objrep.Load(".\reportes\rptListOrd.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.ListadoSolicitudes
                'Dim objRep As New RptListSol

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptListSol.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.catCxc
                'Dim objRep As New catConceptoscxc

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\catConceptoscxc.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

            Case Lista.Giro
                'Dim objrep As New RprGiros

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RprGiros.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.TipoUsuario
                'Dim objrep As New RprTipUsuario

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\rpttipusuario.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.FormasServ
                'Dim objrep As New RptFormaServ

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptFormaServ.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.formasPago
                'Dim objrep As New RprFormPago

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RprFormPago.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Departamentos
                'Dim objrep As New RptDeptos

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptDeptos.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Situaciones
                'Dim objrep As New Situaciones

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\Situaciones.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Algoritmos
                'Dim objrep As New RptAlgo

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptAlgo.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Brigada
                'Dim objrep As New RptBrigada

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptBrigada.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Colonias
                'Dim objrep As New RptColonias

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptColonias.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Direccion
                'Dim objrep As New RptDirec

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptDirec.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Municipios
                'Dim objrep As New RptMunicipios

                '    Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptMunicipios.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep

                'Dim FieldDef As FieldDefinition

                'FieldDef = objrep.Database.Tables.Item(0).Fields.Item(args(0).ToString)
                'objrep.DataDefinition.SortFields.Item(0).Field = FieldDef
                'tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Sector
                'Dim objrep As New RptSector

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptSector.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)


                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Ruta
                'Dim objrep As New RptRutas

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptRutas.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.DiametroToma
                'Dim objrep As New RptDiametroToma

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptDiametroToma.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Empleados
                'Dim objrep As New Empleados

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\Empleados.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Comunidades
                'Dim objrep As New RptComunidades

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptComunidades.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length

                'Dim topBottomNSortField As TopBottomNSortField = Nothing

                'Dim FieldDef As FieldDefinition

                'FieldDef = objrep.Database.Tables.Item(0).Fields.Item("comunidad")
                'objrep.DataDefinition.SortFields.Item(0).Field = FieldDef

                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
                'objrep.Refresh()

            Case Lista.Calles
                'Dim objrep As New RptCalles

                '   Dim objrep As New ReportDocument
                objrep.Load(".\reportes\Calles.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.ConceptosCIS
                'Dim objrep As New RptConcepCis

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptConcepCis.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Fuentes
                'Dim objrep As New RptFuente

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptFuente.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.MarMedidor
                'Dim objrep As New RptMarMedidor

                Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptMarMedidor.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length

                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.EstadoTomas
                'Dim objrep As New RptEstadoToma

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptEstadoToma.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Cuotas
                'Dim objrep As New RptCuotas

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptCuotas.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)


                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Region
                'Dim objrep As New RptRegion

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptRegion.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.TipoServicio
                'Dim objrep As New TiposServ

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\TiposServ.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Estadistica_de_Calidad_Det
                'Dim objRep As New repOrdTrabCalDet

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repOrdTrabCalDet.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

            Case Lista.Estadistica_Tipo_Queja_Det
                'Dim objRep As New repOrdTrabDet

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repOrdTrabDet.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.HistAjus
                'Dim objRep As New rptHistAjus

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\rptHistAjus.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.reporteCajas
                'Dim objRep As New repCajas

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repCajas.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Oficinas
                'Dim objRep As New repOfi

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repOfi.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.UsuariosBaja
                'Dim objRep As New usuBaja

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\usuBaja.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
                _totreg = objrep.HasRecords



            Case Lista.EtiquetasPadUsu
                'Dim objRep As New etiPad

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\etiPad.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.TomasContratadas
                'Dim objRep As New repTomCont

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repTomCont.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

            Case Lista.CalculoConsumo
                'Dim objRep As New CalculoConsumo

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\CalculoConsumo.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.Multas
                'Dim objRep As New repMultas

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\repMultas.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next

            Case Lista.LecNoCapturadas
                'Dim objRep As New RepNoc

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RepNoc.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.repBajaDefinitiva
                'Dim objRep As New RptBajaDefinitiva

                '  Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptBajaDefinitiva.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.repBajaTempora
                'Dim objRep As New RptBajaTemporal

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptBajaTemporal.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next



            Case Lista.Convenio
                'Dim objRep As New RptBajaTemporal

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\FormConvenio.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next






            Case Lista.UsuariosCont
                'Dim objRep As New UsuariosCont
                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\UsuariosCont.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.antiguedad
                'Dim objRep As New antiguedad

                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\antiguedad.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

''''''''''''''''''''''''''''''''''''''''''





            Case Lista.Tarifas
                Dim totadeu As Double = 0
                'Dim objRep As New RptCuotas

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\RptCuotas.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.CNA
                Dim totadeu As Double = 0
                'Dim objRep As New cnafacturado
                'Dim objrep As New ReportDocument
                objrep.Load(".\reportes\cnafacturado.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.UsuSis

                'Dim objRep As New rptUsuSis
                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\rptUsuSis.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

            Case Lista.verLecturas

                ' Dim objrep As New ReportDocument
                objrep.Load(".\reportes\verlect.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

            Case Lista.Descuentos

                objrep.Load(".\reportes\Descuentos.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Ubicacionmedidor
                objrep.Load(".\reportes\UbicacionMedidor.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.MaterialCalles
                objrep.Load(".\reportes\MaterialCalles.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Notificaciones
                objrep.Load(".\reportes\Notificaciones.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.ListaNotificaciones
                objrep.Load(".\reportes\ListadoNotificaciones.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = "'" & mat(1).ToString().Trim() & "'"
                    Next
                End If
            Case Lista.Comprobante
                objrep.Load(".\reportes\datoscontrato.rpt")

                Dim servidorreporte As String = My.Settings.servidorreporte
                Dim usuarioreporte As String = My.Settings.usuarioreporte
                Dim passreporte As String = My.Settings.passreporte
                Dim basereporte As String = My.Settings.basereporte

                objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1

                        mat = Split(args(i), ". ")
                        objrep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
        End Select
        Me.Text = Tipo.ToString
    End Sub

    Private Sub frmReporte_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBoxEx.Show("¿DESEA SALIR DEL REPORTE?", Me.TitleText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class