<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreponotifica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReporteCR = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.SuspendLayout()
        '
        'ReporteCR
        '
        Me.ReporteCR.ActiveViewIndex = -1
        Me.ReporteCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReporteCR.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReporteCR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReporteCR.Location = New System.Drawing.Point(0, 0)
        Me.ReporteCR.Name = "ReporteCR"
        Me.ReporteCR.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController
        Me.ReporteCR.Size = New System.Drawing.Size(800, 450)
        Me.ReporteCR.TabIndex = 0
        Me.ReporteCR.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://C:\Users\vigma\Documents\VIGMA SIAAPI\proyecto 15 de juLio 2021\Actopan\" &
    "Administrativo\Administrativo\Nuevo\bin\Debug\Reportes\Notificaciones.rpt"
        '
        'frmreponotifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReporteCR)
        Me.Name = "frmreponotifica"
        Me.Text = "Notificaciones"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ReporteCR As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
