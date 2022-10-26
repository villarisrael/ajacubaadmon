Option Strict Off
Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System
Imports System.ComponentModel
Imports CrystalDecisions.Windows.Forms
Public Class clsreporte
    Inherits ReportClass
    Private mvareporte As String
    Public reportDocument1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Public Sub New(ByVal repo As String, ByVal obj As Object, ByVal formula As String, ByVal Encabezado As String)
        MyBase.New()
        mvareporte = repo
        Me.reportDocument1.FileName = "rassdk://" & reporte
        Try
            reportDocument1.DataDefinition.FormulaFields("Encabezado").Text = """" & Encabezado & """"
        Catch ex As Exception
        End Try

        obj.selectionformula = formula
        obj.reportsource = reportDocument1
    End Sub
    Public Sub New(ByVal repo As String, ByVal obj As Object, ByVal formula As String)
        MyBase.New()
        mvareporte = repo
        Me.reportDocument1.FileName = "rassdk://" & reporte
        obj.selectionformula = Formula
        obj.reportsource = reportDocument1
    End Sub

    Public Sub New(ByVal repo As String, ByVal obj As Object, ByVal FechaIni As Date, ByVal FechaFin As Date)
        MyBase.New()
        mvareporte = repo
        Me.reportDocument1.FileName = "rassdk://" & reporte
        obj.selectionformula = "{pagos.fecha_Act} >=date(" & FechaIni.Date.Year & "," & FechaIni.Date.Month & "," & FechaIni.Date.Day & ") and {pagos.fecha_Act} <=date(" & FechaFin.Date.Year & "," & FechaFin.Date.Month & "," & FechaFin.Date.Day & ")"

       
        obj.reportsource = reportDocument1
    End Sub
    Public Sub New(ByVal repo As String, ByVal obj As CrystalReportViewer, ByVal formula As String, ByVal ParamArray formulas() As Object)
        MyBase.New()
        Dim i As Int16, tot As Int16
        Dim mat() As String

        mvareporte = repo
        Me.reportDocument1.FileName = "rassdk://" & reporte

        If formula <> "" AndAlso formula <> " " Then
            obj.SelectionFormula = formula
        End If

        Try
            tot = formulas.Length
            For i = 0 To tot - 1
                mat = Split(formulas(i), ", ")
                Me.reportDocument1.DataDefinition.FormulaFields(mat(0)).Text = mat(1)
            Next
        Catch ex As Exception
        End Try

        obj.ReportSource = reportDocument1
    End Sub
    Public Overrides Property ResourceName() As [String]
        Get
            Return Me.reporte
        End Get
        Set(ByVal value As [String])
            'Do nothing
        End Set
    End Property

    Public Property reporte() As String
        Get
            Return mvareporte
        End Get
        Set(ByVal value As String)
            mvareporte = value
            ' Me.reportDocument1.FileName = reporte

        End Set
    End Property

End Class
