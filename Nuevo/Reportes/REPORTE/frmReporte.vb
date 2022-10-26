Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReporte
    Dim _mord As Int16
    Dim _totreg As Boolean
    Public objRepEsp As HistorialUsuario
    Public objRepReca As RptRecaudacion

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
        Factibilidad
        Solicitud
        Contrato
        Contrato_Provisional
        Contrato_Editable
        Contrato_Cambio_Nombre
        Listado_Lecturas
        Lecturas_Capturadas
        CalculoConsumo
        LecturasxSituacion
        ReporteUsuarios
        Convenio
        ordenTrabajo
        Reporte_Ingresos
        Requerimientos
        ListRequeri
        Requerimientos1
        reqCorte
        reqCorte1
        verLecturas
        verConve
        Estadistica_de_Calidad
        Estadistica_Tipo_Queja
        Grafica_Calidad
        ListadoOrdenes
        ListadoSolicitudes
        catCxc
        Giro
        TipoUsuario
        FormasServ
        formasPago
        Departamentos
        Situaciones
        Algoritmos
        Brigada
        Colonias
        Direccion
        Municipios
        Comunidades
        Calles
        ConceptosCIS
        Fuentes
        MarMedidor
        Sector
        Ruta
        DiametroToma
        FormaServ
        Empleados
        EstadoTomas
        Cuotas
        Region
        TipoServicio
        Estadistica_de_Calidad_Det
        Estadistica_Tipo_Queja_Det
        HistAjus
        Oficinas
        reporteCajas
        UsuariosBaja
        facturacion
        facturacionsinsub
        EtiquetasPadUsu
        TomasContratadas
        Recaudacion
        repEstadosCuenta
        Multa_Abono
        Pagares_Vencidos
        LecNoCapturadas
        repBajaDefinitiva
        repBajaTempora
        Rezago
        Rezagosinsub
        HistoriaUsuario
        Reporteanticipo
        UsuariosCont
        antiguedad
        Convenio_Prov
        Auditoria
        Reporte_Recaudacion
        TotalesRubro
    End Enum
    Public Sub New()
        InitializeComponent()
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
        Select Case Tipo
            Case Lista.repEstadosCuenta

                Dim objRep As New repEstCuenta
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
                objRep.ReportFooterSection1.SectionFormat.EnableSuppress = anti
                objRep.ReportFooterSection2.SectionFormat.EnableSuppress = est
                objRep.ReportFooterSection3.SectionFormat.EnableSuppress = otr
                objRep.ReportFooterSection4.SectionFormat.EnableSuppress = ord


        End Select

    End Sub

    'Public Sub New(ByVal Tipo As Lista, ByVal Filtro As String, ByVal anti As Boolean, ByVal est As Boolean, ByVal otr As Boolean, ByVal pag As Boolean, ByVal ord As Boolean, ByVal ParamArray args() As Object)
    '    InitializeComponent()

    '    Dim i As Int16, tot As Int16
    '    Dim mat() As String
    '    Select Case Tipo
    '        Case Lista.repEstadosCuenta

    '            Dim objRep As New repEstCuenta
    '            crvReporte.SelectionFormula = Filtro
    '            crvReporte.ReportSource = objRep
    '            tot = args.Length
    '            If Not tot < 1 Then
    '                For i = 0 To tot - 1
    '                    mat = Split(args(i), ". ")
    '                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
    '                Next
    '            End If
    '            objRep.ReportFooterSection1.SectionFormat.EnableSuppress = anti
    '            objRep.ReportFooterSection2.SectionFormat.EnableSuppress = est
    '            objRep.ReportFooterSection3.SectionFormat.EnableSuppress = otr
    '            objRep.ReportFooterSection4.SectionFormat.EnableSuppress = ord


    '    End Select

    'End Sub
    Public Sub New(ByVal Tipo As Lista, ByVal Filtro As String, ByVal ParamArray args() As Object)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim i As Int16, tot As Int16
        Dim mat() As String
        Select Case Tipo
            Case Lista.Factibilidad
                Dim objRep As New Factibilidad
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.Solicitud
                Dim objRep As New Solicitud
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length

                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.Contrato
                Dim objRep As New Contrato
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Contrato_Cambio_Nombre
                Dim objRep As New Contrato_Cambio_Nombre
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Contrato_Editable
                Dim objRep As New Contrato_Editable
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Contrato_Provisional
                Dim objRep As New Contrato_Provisional
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Listado_Lecturas
                Dim objRep As New ListaLecturas
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    'objRep.SetParameterValue(mat(0), mat(1))
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.Lecturas_Capturadas
                Dim objRep As New LecturasCapturadas
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.LecturasxSituacion
                Dim objRep As New LecturasCapturadas
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.ReporteUsuarios
                Dim objRep As New UsuariosDetalle
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep

                'Dim FieldDef As FieldDefinition

                'FieldDef = objRep.Database.Tables.Item(0).Fields.Item(_mord)
                'objRep.DataDefinition.SortFields.Item(0).Field = FieldDef
                'crvReporte.RefreshReport()
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

                crvReporte.RefreshReport()

            Case Lista.Convenio
                Dim objRep As New Convenio
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.ordenTrabajo
                Dim objRep As New ordTrab
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.Reporte_Ingresos
                Dim objRep As New Reping
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    'objRep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Requerimientos
                Dim objRep As New requeri
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.ListRequeri
                Dim objRep As New listReq
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.Requerimientos1
                Dim objRep As New requeri1
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.reqCorte
                Dim objRep As New reqOrdCort
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.reqCorte1
                Dim objRep As New reqOrdCort1
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.verLecturas
                Dim objRep As New verLect
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.verConve
                Dim objRep As New visConve
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.Estadistica_de_Calidad
                Dim objRep As New repOrdTrabCal
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")

                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Estadistica_Tipo_Queja
                Dim objRep As New repOrdTrab
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Grafica_Calidad
                Dim objRep As New repCalidad
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot <= 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.SetParameterValue(mat(0), mat(1))
                    Next
                End If
            Case Lista.ListadoOrdenes
                Dim objRep As New rptListOrd
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.ListadoSolicitudes
                Dim objRep As New RptListSol
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.catCxc
                Dim objRep As New catConceptoscxc
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

            Case Lista.Giro
                Dim objrep As New RprGiros
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.TipoUsuario
                Dim objrep As New RprTipUsuario
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.FormasServ
                Dim objrep As New RptFormaServ
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.formasPago
                Dim objrep As New RprFormPago
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Departamentos
                Dim objrep As New RptDeptos
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Situaciones
                Dim objrep As New Situaciones
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Algoritmos
                Dim objrep As New RptAlgo
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Brigada
                Dim objrep As New RptBrigada
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Colonias
                Dim objrep As New RptColonias
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Direccion
                Dim objrep As New RptDirec
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Municipios
                Dim objrep As New RptMunicipios
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Sector
                Dim objrep As New RptSector
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Ruta
                Dim objrep As New RptRutas
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.DiametroToma
                Dim objrep As New RptDiametroToma
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Empleados
                Dim objrep As New Empleados
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Comunidades
                Dim objrep As New RptComunidades
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Calles
                Dim objrep As New RptCalles
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.ConceptosCIS
                Dim objrep As New RptConcepCis
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Fuentes
                Dim objrep As New RptFuente
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.MarMedidor
                Dim objrep As New RptMarMedidor
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length

                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.EstadoTomas
                Dim objrep As New RptEstadoToma
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Cuotas
                Dim objrep As New RptCuotas
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Region
                Dim objrep As New RptRegion
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.TipoServicio
                Dim objrep As New TiposServ
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objrep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ", ")
                    objrep.SetParameterValue(mat(0), mat(1))
                Next
            Case Lista.Estadistica_de_Calidad_Det
                Dim objRep As New repOrdTrabCalDet
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

            Case Lista.Estadistica_Tipo_Queja_Det
                Dim objRep As New repOrdTrabDet
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.HistAjus
                Dim objRep As New rptHistAjus
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.reporteCajas
                Dim objRep As New repCajas
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Oficinas
                Dim objRep As New repOfi
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.UsuariosBaja
                Dim objRep As New usuBaja
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
                _totreg = objRep.HasRecords

            

            Case Lista.EtiquetasPadUsu
                Dim objRep As New etiPad
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.TomasContratadas
                Dim objRep As New repTomCont
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Recaudacion
                Dim objRep As New Reping
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ". ")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.CalculoConsumo
                Dim objRep As New CalculoConsumo
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.Multa_Abono
                Dim objRep As New repMultas
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.Pagares_Vencidos
                Dim objRep As New PagaresVencidos
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.LecNoCapturadas
                Dim objRep As New RepNoc
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.repBajaDefinitiva
                Dim objRep As New RptBajaDefinitiva
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next
            Case Lista.repBajaTempora
                Dim objRep As New RptBajaTemporal
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), ",")
                    objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next

            Case Lista.facturacion
                Dim objRep As New FACTURACION
                'crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

                objRep.ReportFooterSection2.SectionFormat.EnableSuppress = False
            Case Lista.facturacionsinsub
                Dim objRep As New FACTURACION
                'crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

                objRep.ReportFooterSection2.SectionFormat.EnableSuppress = True
            Case Lista.Rezago
                Dim objRep As New rezagos
                'crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

                objRep.ReportFooterSection1.SectionFormat.EnableSuppress = True
            Case Lista.Rezagosinsub
                Dim objRep As New rezagos
                'crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep
                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If

                objRep.ReportFooterSection2.SectionFormat.EnableSuppress = True


            Case Lista.HistoriaUsuario
                objRepEsp = New HistorialUsuario
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRepEsp
                tot = args.Length
                For i = 0 To tot - 1
                    mat = Split(args(i), " ,")
                    objRepEsp.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                Next


            Case Lista.Reporteanticipo
                Dim objRep As New Anticipos
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep

                tot = args.Length
                If Not tot < 1 Then
                    ' For i = 0 To tot - 1
                    'mat = Split(args(i), ", ")
                    objRep.DataDefinition.FormulaFields("ENCABEZADO1").Text = args(0)
                    'Next
                End If
            Case Lista.UsuariosCont
                Dim objRep As New UsuariosCont
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.antiguedad
                Dim objRep As New antiguedad
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Convenio_Prov
                Dim objRep As New Convenio_prov
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Auditoria
                Dim objRep As New RptAuditoria
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.Reporte_Recaudacion
                objRepReca = New RptRecaudacion
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRepReca

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ", ")
                        objRepReca.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
                    Next
                End If
            Case Lista.TotalesRubro
                Dim objRep As New rptTotpRub
                crvReporte.SelectionFormula = Filtro
                crvReporte.ReportSource = objRep

                tot = args.Length
                If Not tot < 1 Then
                    For i = 0 To tot - 1
                        mat = Split(args(i), ". ")
                        objRep.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
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

    Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class