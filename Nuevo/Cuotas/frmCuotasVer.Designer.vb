<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuotasVer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar()
        Me.ExplorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.TextBoxItem1 = New DevComponents.DotNetBar.TextBoxItem()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.dgTar = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEliminar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipou = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.alcantarillado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Saneacuo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.recargos = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ivaacon = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.ivaalca = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.IVASANE = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ExplorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ExplorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2
        Me.ExplorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.ExplorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground
        Me.ExplorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBar1.GroupImages = Nothing
        Me.ExplorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ExplorerBarGroupItem1})
        Me.ExplorerBar1.Images = Nothing
        Me.ExplorerBar1.Location = New System.Drawing.Point(0, 0)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(180, 130)
        Me.ExplorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBar1.TabIndex = 0
        Me.ExplorerBar1.Text = "ExplorerBar1"
        Me.ExplorerBar1.ThemeAware = True
        '
        'ExplorerBarGroupItem1
        '
        '
        '
        '
        Me.ExplorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItem1.Expanded = True
        Me.ExplorerBarGroupItem1.Name = "ExplorerBarGroupItem1"
        Me.ExplorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.TextBoxItem1})
        Me.ExplorerBarGroupItem1.Text = "New Group"
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem1.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'TextBoxItem1
        '
        Me.TextBoxItem1.Caption = "TextBoxItem1"
        Me.TextBoxItem1.Name = "TextBoxItem1"
        Me.TextBoxItem1.ThemeAware = True
        Me.TextBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(782, 399)
        '
        'dgTar
        '
        Me.dgTar.AllowUserToAddRows = False
        Me.dgTar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.dgTar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tarifa, Me.Tipou, Me.descripcion_cuota, Me.medido, Me.alcantarillado, Me.Saneacuo, Me.recargos, Me.ivaacon, Me.ivaalca, Me.IVASANE})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgTar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTar.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgTar.Location = New System.Drawing.Point(0, 67)
        Me.dgTar.Name = "dgTar"
        Me.dgTar.ReadOnly = True
        Me.dgTar.Size = New System.Drawing.Size(1163, 420)
        Me.dgTar.TabIndex = 0
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbOp.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.ContainerControlProcessDialogKey = True
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.cmdEditar, Me.cmdEliminar, Me.cmdImp, Me.ButtonItem2, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(1163, 67)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 0
        '
        '
        '
        Me.rbOp.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.TitleVisible = False
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Agregar"
        '
        'cmdEditar
        '
        Me.cmdEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEditar.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.cmdEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.SubItemsExpandWidth = 14
        Me.cmdEditar.Text = "Editar"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEliminar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.cmdEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.SubItemsExpandWidth = 14
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdImp
        '
        Me.cmdImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.SubItemsExpandWidth = 14
        Me.cmdImp.Text = "Imprimir"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Image = Global.Administativo.My.Resources.Resources.demo
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "Visualizar"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Salir"
        '
        'Tarifa
        '
        Me.Tarifa.DataPropertyName = "Tarifa"
        Me.Tarifa.Frozen = True
        Me.Tarifa.HeaderText = "Tarifa"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.ReadOnly = True
        Me.Tarifa.Width = 50
        '
        'Tipou
        '
        Me.Tipou.DataPropertyName = "descripcion"
        Me.Tipou.Frozen = True
        Me.Tipou.HeaderText = "Tipo usuario"
        Me.Tipou.Name = "Tipou"
        Me.Tipou.ReadOnly = True
        '
        'descripcion_cuota
        '
        Me.descripcion_cuota.DataPropertyName = "descripcion_cuota"
        Me.descripcion_cuota.Frozen = True
        Me.descripcion_cuota.HeaderText = "Descripción"
        Me.descripcion_cuota.Name = "descripcion_cuota"
        Me.descripcion_cuota.ReadOnly = True
        Me.descripcion_cuota.Width = 200
        '
        'medido
        '
        Me.medido.DataPropertyName = "medido"
        Me.medido.Frozen = True
        Me.medido.HeaderText = "Medido"
        Me.medido.Name = "medido"
        Me.medido.ReadOnly = True
        Me.medido.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.medido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'alcantarillado
        '
        Me.alcantarillado.DataPropertyName = "alcantarillado"
        Me.alcantarillado.HeaderText = "Alcantarillado"
        Me.alcantarillado.Name = "alcantarillado"
        Me.alcantarillado.ReadOnly = True
        '
        'Saneacuo
        '
        Me.Saneacuo.DataPropertyName = "saneacuo"
        Me.Saneacuo.HeaderText = "Saneamiento"
        Me.Saneacuo.Name = "Saneacuo"
        Me.Saneacuo.ReadOnly = True
        '
        'recargos
        '
        Me.recargos.DataPropertyName = "recargos"
        Me.recargos.HeaderText = "Recargos"
        Me.recargos.Name = "recargos"
        Me.recargos.ReadOnly = True
        '
        'ivaacon
        '
        Me.ivaacon.Checked = True
        Me.ivaacon.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ivaacon.CheckValue = "N"
        Me.ivaacon.DataPropertyName = "IVA_CONSUMO"
        Me.ivaacon.HeaderText = "IVA_CONSUMO"
        Me.ivaacon.Name = "ivaacon"
        Me.ivaacon.ReadOnly = True
        Me.ivaacon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ivaalca
        '
        Me.ivaalca.Checked = True
        Me.ivaalca.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ivaalca.CheckValue = "N"
        Me.ivaalca.DataPropertyName = "IVA_ALCANTARILLADO"
        Me.ivaalca.HeaderText = "IVA_ALCAN"
        Me.ivaalca.Name = "ivaalca"
        Me.ivaalca.ReadOnly = True
        Me.ivaalca.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'IVASANE
        '
        Me.IVASANE.Checked = True
        Me.IVASANE.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.IVASANE.CheckValue = "N"
        Me.IVASANE.DataPropertyName = "IVA_SANEAMIENTO"
        Me.IVASANE.HeaderText = "IVA_SANEA"
        Me.IVASANE.Name = "IVASANE"
        Me.IVASANE.ReadOnly = True
        Me.IVASANE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'frmCuotasVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 487)
        Me.Controls.Add(Me.dgTar)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.Name = "frmCuotasVer"
        Me.Text = "Consulta de Tarifas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExplorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents ExplorerBarGroupItem1 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents TextBoxItem1 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents dgTar As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEliminar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Tarifa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipou As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion_cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents alcantarillado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Saneacuo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents recargos As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ivaacon As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents ivaalca As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents IVASANE As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    ' Friend WithEvents CachedColonias11 As AcquaLiberVista.CachedColonias1
End Class
