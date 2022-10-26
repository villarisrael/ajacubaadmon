<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAseh
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
        Me.components = New System.ComponentModel.Container()
        Me.baseaguaDataSet2 = New baseaguaDataSet2
        Me.vusuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vusuarioTableAdapter = New Administativo.baseaguaDataSet2TableAdapters.vusuarioTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.aseh1 = New Administativo.aseh()
        CType(Me.baseaguaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vusuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'baseaguaDataSet2
        '
        Me.baseaguaDataSet2.DataSetName = "baseaguaDataSet2"
        Me.baseaguaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vusuarioBindingSource
        '
        Me.vusuarioBindingSource.DataMember = "vusuario"
        Me.vusuarioBindingSource.DataSource = Me.baseaguaDataSet2
        '
        'vusuarioTableAdapter
        '
        Me.vusuarioTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.aseh1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(880, 524)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel
        '
        'FrmAseh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 524)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.DoubleBuffered = True
        Me.Name = "FrmAseh"
        Me.Text = "Reporte de Aseh"
        CType(Me.baseaguaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vusuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vusuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents baseaguaDataSet2 As Administativo.baseaguaDataSet2
    Friend WithEvents vusuarioTableAdapter As Administativo.baseaguaDataSet2TableAdapters.vusuarioTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents aseh1 As Administativo.aseh
End Class
