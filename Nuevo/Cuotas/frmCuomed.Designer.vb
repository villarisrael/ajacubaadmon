<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuomed
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.dgCuotas = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdAgr = New System.Windows.Forms.ToolStripButton()
        Me.cmdGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrim = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnt = New System.Windows.Forms.ToolStripButton()
        Me.cmdSig = New System.Windows.Forms.ToolStripButton()
        Me.cmdUlt = New System.Windows.Forms.ToolStripButton()
        Me.id_tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rango_inf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rango_sup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarifa_agua_sm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarifa_agua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anofiscal = New DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.dgCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgCuotas)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(817, 406)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(817, 445)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'dgCuotas
        '
        Me.dgCuotas.AllowUserToAddRows = False
        Me.dgCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tarifa, Me.rango_inf, Me.rango_sup, Me.tarifa_agua_sm, Me.Tarifa_agua, Me.Anofiscal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuotas.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgCuotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCuotas.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgCuotas.Location = New System.Drawing.Point(0, 0)
        Me.dgCuotas.Name = "dgCuotas"
        Me.dgCuotas.Size = New System.Drawing.Size(817, 406)
        Me.dgCuotas.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgr, Me.cmdGuardar, Me.ToolStripButton1, Me.cmdPrim, Me.cmdAnt, Me.cmdSig, Me.cmdUlt})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(199, 39)
        Me.ToolStrip1.TabIndex = 0
        '
        'cmdAgr
        '
        Me.cmdAgr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgr.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.cmdAgr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAgr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgr.Name = "cmdAgr"
        Me.cmdAgr.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgr.Text = "ToolStripButton1"
        Me.cmdAgr.ToolTipText = "Agregar rango"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.AccessibleName = ""
        Me.cmdGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdGuardar.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.cmdGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(36, 36)
        Me.cmdGuardar.Text = "Guardar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 36)
        Me.ToolStripButton1.Text = "Eliminar Rango"
        '
        'cmdPrim
        '
        Me.cmdPrim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrim.Image = Global.Administativo.My.Resources.Resources._2leftarrow
        Me.cmdPrim.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrim.Name = "cmdPrim"
        Me.cmdPrim.Size = New System.Drawing.Size(23, 36)
        Me.cmdPrim.Text = "ToolStripButton1"
        '
        'cmdAnt
        '
        Me.cmdAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnt.Image = Global.Administativo.My.Resources.Resources._1leftarrow
        Me.cmdAnt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnt.Name = "cmdAnt"
        Me.cmdAnt.Size = New System.Drawing.Size(23, 36)
        Me.cmdAnt.Text = "ToolStripButton1"
        '
        'cmdSig
        '
        Me.cmdSig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSig.Image = Global.Administativo.My.Resources.Resources._1rightarrow
        Me.cmdSig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSig.Name = "cmdSig"
        Me.cmdSig.Size = New System.Drawing.Size(23, 36)
        Me.cmdSig.Text = "ToolStripButton1"
        '
        'cmdUlt
        '
        Me.cmdUlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdUlt.Image = Global.Administativo.My.Resources.Resources._2rightarrow
        Me.cmdUlt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUlt.Name = "cmdUlt"
        Me.cmdUlt.Size = New System.Drawing.Size(23, 36)
        Me.cmdUlt.Text = "ToolStripButton1"
        '
        'id_tarifa
        '
        Me.id_tarifa.DataPropertyName = "id_tarifa"
        DataGridViewCellStyle1.NullValue = "0"
        Me.id_tarifa.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_tarifa.HeaderText = "Tarifa"
        Me.id_tarifa.Name = "id_tarifa"
        Me.id_tarifa.ReadOnly = True
        '
        'rango_inf
        '
        Me.rango_inf.DataPropertyName = "rango_inf"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = Nothing
        Me.rango_inf.DefaultCellStyle = DataGridViewCellStyle2
        Me.rango_inf.HeaderText = "Rango inferior"
        Me.rango_inf.Name = "rango_inf"
        '
        'rango_sup
        '
        Me.rango_sup.DataPropertyName = "rango_sup"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.rango_sup.DefaultCellStyle = DataGridViewCellStyle3
        Me.rango_sup.HeaderText = "Rango superior"
        Me.rango_sup.Name = "rango_sup"
        '
        'tarifa_agua_sm
        '
        Me.tarifa_agua_sm.DataPropertyName = "vsm_agua"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = Nothing
        Me.tarifa_agua_sm.DefaultCellStyle = DataGridViewCellStyle4
        Me.tarifa_agua_sm.HeaderText = "Tarifa Consumo SM"
        Me.tarifa_agua_sm.Name = "tarifa_agua_sm"
        '
        'Tarifa_agua
        '
        Me.Tarifa_agua.DataPropertyName = "tarifa_agua"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.Format = "###,###.##"
        Me.Tarifa_agua.DefaultCellStyle = DataGridViewCellStyle5
        Me.Tarifa_agua.HeaderText = "Agua $"
        Me.Tarifa_agua.Name = "Tarifa_agua"
        Me.Tarifa_agua.ReadOnly = True
        '
        'Anofiscal
        '
        '
        '
        '
        Me.Anofiscal.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Anofiscal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Anofiscal.DataPropertyName = "anofiscal"
        Me.Anofiscal.HeaderText = "Año"
        Me.Anofiscal.Name = "Anofiscal"
        Me.Anofiscal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'frmCuomed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 445)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "frmCuomed"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuotas medidas    -> Para evitar errores cada que ingrese o modifique un dato pre" & _
            "sione la tecla <ENTER>"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.dgCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents dgCuotas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnt As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSig As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrim As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdUlt As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAgr As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents id_tarifa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rango_inf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rango_sup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tarifa_agua_sm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tarifa_agua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anofiscal As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
End Class
