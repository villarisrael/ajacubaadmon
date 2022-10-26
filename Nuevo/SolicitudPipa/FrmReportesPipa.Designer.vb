<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesPipa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportesPipa))
        Me.CalenReporteInicio = New System.Windows.Forms.MonthCalendar()
        Me.CalenReporteFin = New System.Windows.Forms.MonthCalendar()
        Me.DGVReportePipa = New System.Windows.Forms.DataGridView()
        Me.btnReportesPipa = New System.Windows.Forms.Button()
        Me.txtinicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CheckBoxFiltrar = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxEstatus = New System.Windows.Forms.ComboBox()
        CType(Me.DGVReportePipa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalenReporteInicio
        '
        Me.CalenReporteInicio.Location = New System.Drawing.Point(51, 47)
        Me.CalenReporteInicio.Name = "CalenReporteInicio"
        Me.CalenReporteInicio.TabIndex = 0
        '
        'CalenReporteFin
        '
        Me.CalenReporteFin.Location = New System.Drawing.Point(313, 47)
        Me.CalenReporteFin.Name = "CalenReporteFin"
        Me.CalenReporteFin.TabIndex = 1
        '
        'DGVReportePipa
        '
        Me.DGVReportePipa.AllowUserToAddRows = False
        Me.DGVReportePipa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVReportePipa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVReportePipa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVReportePipa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVReportePipa.ColumnHeadersHeight = 30
        Me.DGVReportePipa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVReportePipa.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVReportePipa.EnableHeadersVisualStyles = False
        Me.DGVReportePipa.Location = New System.Drawing.Point(24, 373)
        Me.DGVReportePipa.Name = "DGVReportePipa"
        Me.DGVReportePipa.Size = New System.Drawing.Size(1268, 343)
        Me.DGVReportePipa.TabIndex = 2
        '
        'btnReportesPipa
        '
        Me.btnReportesPipa.Image = CType(resources.GetObject("btnReportesPipa.Image"), System.Drawing.Image)
        Me.btnReportesPipa.Location = New System.Drawing.Point(1180, 317)
        Me.btnReportesPipa.Name = "btnReportesPipa"
        Me.btnReportesPipa.Size = New System.Drawing.Size(112, 50)
        Me.btnReportesPipa.TabIndex = 3
        Me.btnReportesPipa.UseVisualStyleBackColor = True
        '
        'txtinicio
        '
        Me.txtinicio.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinicio.Location = New System.Drawing.Point(665, 331)
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.Size = New System.Drawing.Size(186, 29)
        Me.txtinicio.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(534, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Reporte del:"
        '
        'txtfin
        '
        Me.txtfin.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfin.Location = New System.Drawing.Point(921, 331)
        Me.txtfin.Name = "txtfin"
        Me.txtfin.Size = New System.Drawing.Size(222, 29)
        Me.txtfin.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(869, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "al:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(534, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 26)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Reportes Solicitud de Pipa"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(570, 168)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(84, 40)
        Me.BtnBuscar.TabIndex = 18
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CheckBoxFiltrar
        '
        Me.CheckBoxFiltrar.AutoSize = True
        Me.CheckBoxFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFiltrar.Location = New System.Drawing.Point(61, 249)
        Me.CheckBoxFiltrar.Name = "CheckBoxFiltrar"
        Me.CheckBoxFiltrar.Size = New System.Drawing.Size(67, 20)
        Me.CheckBoxFiltrar.TabIndex = 19
        Me.CheckBoxFiltrar.Text = "Filtrar"
        Me.CheckBoxFiltrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBoxEstatus)
        Me.Panel1.Location = New System.Drawing.Point(51, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 134)
        Me.Panel1.TabIndex = 20
        '
        'ComboBoxEstatus
        '
        Me.ComboBoxEstatus.FormattingEnabled = True
        Me.ComboBoxEstatus.Items.AddRange(New Object() {"En Proceso", "Entregado", "No Se Entrego"})
        Me.ComboBoxEstatus.Location = New System.Drawing.Point(110, 26)
        Me.ComboBoxEstatus.Name = "ComboBoxEstatus"
        Me.ComboBoxEstatus.Size = New System.Drawing.Size(141, 21)
        Me.ComboBoxEstatus.TabIndex = 0
        '
        'FrmReportesPipa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.CheckBoxFiltrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtinicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReportesPipa)
        Me.Controls.Add(Me.DGVReportePipa)
        Me.Controls.Add(Me.CalenReporteFin)
        Me.Controls.Add(Me.CalenReporteInicio)
        Me.Name = "FrmReportesPipa"
        Me.Text = "FrmReportesPipa"
        CType(Me.DGVReportePipa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalenReporteInicio As MonthCalendar
    Friend WithEvents CalenReporteFin As MonthCalendar
    Friend WithEvents DGVReportePipa As DataGridView
    Friend WithEvents btnReportesPipa As Button
    Friend WithEvents txtinicio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CheckBoxFiltrar As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxEstatus As ComboBox
End Class
