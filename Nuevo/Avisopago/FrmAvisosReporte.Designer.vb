<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAvisosReporte
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crystalReportViewer1
        '
        Me.crystalReportViewer1.ActiveViewIndex = -1
        Me.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.crystalReportViewer1.Name = "crystalReportViewer1"
        Me.crystalReportViewer1.ShowCloseButton = False
        Me.crystalReportViewer1.ShowParameterPanelButton = False
        Me.crystalReportViewer1.Size = New System.Drawing.Size(794, 523)
        Me.crystalReportViewer1.TabIndex = 1
        Me.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmAvisosReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 523)
        Me.Controls.Add(Me.crystalReportViewer1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmAvisosReporte"
        Me.Text = "Avisos de pago"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents crystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
