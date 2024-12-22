Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBusUsuario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusUsuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SideBar1 = New DevComponents.DotNetBar.SideBar()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.SBOpciones = New DevComponents.DotNetBar.SideBar()
        Me.SBIFiltro = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdFiltro = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.lblTotal = New DevComponents.DotNetBar.LabelItem()
        Me.btnbitacora = New DevComponents.DotNetBar.ButtonItem()
        Me.SBIExportar = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.cmdExpExc = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdMuestra = New DevComponents.DotNetBar.ControlContainerItem()
        Me.dgMuestra1_1 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdMuestra2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.dgMuestra2 = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdMuestra3 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.dgMuestra3 = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXOpciones = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.dgvUsuario = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.mnOp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IMPRIMIRESTADODECUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgMuestra1 = New System.Windows.Forms.DataGridView()
        Me.col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1_1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbCab = New DevComponents.DotNetBar.RibbonBar()
        Me.cmdCamNom = New DevComponents.DotNetBar.ButtonItem()
        Me.btnagrbitacora = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCamMed = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCamTar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnsuspender = New DevComponents.DotNetBar.ButtonItem()
        Me.btnconectar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdDarBaja = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdBajaDef = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdReacti = New DevComponents.DotNetBar.ButtonItem()
        Me.cmbAct = New DevComponents.DotNetBar.ButtonItem()
        Me.btnaexcel = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.rbOpciones = New DevComponents.DotNetBar.RibbonBar()
        Me.cmdVisualizar = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnNuevo = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdContrato = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDatosfiscales = New DevComponents.DotNetBar.ButtonItem()
        Me.btnCompro = New DevComponents.DotNetBar.ButtonItem()
        Me.ToolBar = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rbActi = New DevComponents.DotNetBar.RibbonBar()
        Me.cmdInstaB = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdActi = New DevComponents.DotNetBar.ButtonItem()
        CType(Me.dgMuestra1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMuestra2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMuestra3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnOp.SuspendLayout()
        CType(Me.dgMuestra1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'SideBar1
        '
        Me.SideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.SideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.SideBar1.ExpandedPanel = Nothing
        Me.SideBar1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.SideBar1.Location = New System.Drawing.Point(408, 216)
        Me.SideBar1.Name = "SideBar1"
        Me.SideBar1.Size = New System.Drawing.Size(75, 23)
        Me.SideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.SideBar1.TabIndex = 5
        Me.SideBar1.Text = "SideBar1"
        Me.SideBar1.Visible = False
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = True
        Me.ControlContainerItem1.Control = Me.SideBar1
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'SBOpciones
        '
        Me.SBOpciones.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.SBOpciones.AllowDrop = True
        Me.SBOpciones.AllowExternalDrop = True
        Me.SBOpciones.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.SBOpciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.SBOpciones.ExpandedPanel = Me.SBIFiltro
        Me.SBOpciones.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.SBOpciones.Location = New System.Drawing.Point(0, 0)
        Me.SBOpciones.Name = "SBOpciones"
        Me.SBOpciones.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SBIFiltro})
        Me.SBOpciones.Size = New System.Drawing.Size(131, 633)
        Me.SBOpciones.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.SBOpciones.TabIndex = 5
        '
        'SBIFiltro
        '
        Me.SBIFiltro.FontBold = True
        Me.SBIFiltro.Name = "SBIFiltro"
        Me.SBIFiltro.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdBuscar, Me.cmdFiltro, Me.cmdImp, Me.lblTotal, Me.btnbitacora})
        Me.SBIFiltro.Text = "Búsquedas"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Icon = CType(resources.GetObject("cmdBuscar.Icon"), System.Drawing.Icon)
        Me.cmdBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdFiltro
        '
        Me.cmdFiltro.Icon = CType(resources.GetObject("cmdFiltro.Icon"), System.Drawing.Icon)
        Me.cmdFiltro.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdFiltro.Name = "cmdFiltro"
        Me.cmdFiltro.Text = "Filtrar"
        '
        'cmdImp
        '
        Me.cmdImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.Text = "Imprimir"
        Me.cmdImp.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lblTotal.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.lblTotal.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.PaddingBottom = 1
        Me.lblTotal.PaddingLeft = 10
        Me.lblTotal.PaddingTop = 1
        Me.lblTotal.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblTotal.Visible = False
        '
        'btnbitacora
        '
        Me.btnbitacora.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnbitacora.Image = Global.Administativo.My.Resources.Resources._1411172689_calendar
        Me.btnbitacora.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnbitacora.Name = "btnbitacora"
        Me.btnbitacora.Text = "Bitacora"
        '
        'SBIExportar
        '
        Me.SBIExportar.FontBold = True
        Me.SBIExportar.Name = "SBIExportar"
        Me.SBIExportar.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdExpExc})
        Me.SBIExportar.Text = "Exportar"
        '
        'cmdExpExc
        '
        Me.cmdExpExc.Image = Global.Administativo.My.Resources.Resources.image0072
        Me.cmdExpExc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdExpExc.Name = "cmdExpExc"
        Me.cmdExpExc.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdMuestra, Me.cmdMuestra2, Me.cmdMuestra3})
        Me.cmdExpExc.Text = "Exportar a Excel"
        '
        'cmdMuestra
        '
        Me.cmdMuestra.AllowItemResize = True
        Me.cmdMuestra.Control = Me.dgMuestra1_1
        Me.cmdMuestra.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.cmdMuestra.Name = "cmdMuestra"
        '
        'dgMuestra1_1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgMuestra1_1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMuestra1_1.ColumnHeadersVisible = False
        Me.dgMuestra1_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMuestra1_1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgMuestra1_1.Location = New System.Drawing.Point(191, 153)
        Me.dgMuestra1_1.Name = "dgMuestra1_1"
        Me.dgMuestra1_1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgMuestra1_1.Size = New System.Drawing.Size(180, 80)
        Me.dgMuestra1_1.TabIndex = 8
        '
        'Column6
        '
        Me.Column6.HeaderText = "Columna1"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "Columna2"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "Columna3"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
        '
        'cmdMuestra2
        '
        Me.cmdMuestra2.AllowItemResize = True
        Me.cmdMuestra2.Control = Me.dgMuestra2
        Me.cmdMuestra2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.cmdMuestra2.Name = "cmdMuestra2"
        '
        'dgMuestra2
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgMuestra2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgMuestra2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMuestra2.ColumnHeadersVisible = False
        Me.dgMuestra2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMuestra2.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgMuestra2.Location = New System.Drawing.Point(164, 194)
        Me.dgMuestra2.Name = "dgMuestra2"
        Me.dgMuestra2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgMuestra2.Size = New System.Drawing.Size(180, 80)
        Me.dgMuestra2.TabIndex = 9
        '
        'Column9
        '
        Me.Column9.HeaderText = "Columna1"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 50
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 50
        '
        'cmdMuestra3
        '
        Me.cmdMuestra3.AllowItemResize = True
        Me.cmdMuestra3.Control = Me.dgMuestra3
        Me.cmdMuestra3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.cmdMuestra3.Name = "cmdMuestra3"
        '
        'dgMuestra3
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMuestra3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgMuestra3.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgMuestra3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMuestra3.ColumnHeadersVisible = False
        Me.dgMuestra3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column13, Me.Column14})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMuestra3.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgMuestra3.Location = New System.Drawing.Point(169, 134)
        Me.dgMuestra3.Name = "dgMuestra3"
        Me.dgMuestra3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgMuestra3.Size = New System.Drawing.Size(180, 80)
        Me.dgMuestra3.TabIndex = 8
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 50
        '
        'Column13
        '
        Me.Column13.HeaderText = "Column13"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 50
        '
        'Column14
        '
        Me.Column14.HeaderText = "Column14"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 50
        '
        'EXOpciones
        '
        Me.EXOpciones.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.EXOpciones.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.EXOpciones.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.EXOpciones.ExpandableControl = Me.SBOpciones
        Me.EXOpciones.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.EXOpciones.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.EXOpciones.ExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.EXOpciones.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.EXOpciones.GripDarkColor = System.Drawing.SystemColors.ControlText
        Me.EXOpciones.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.EXOpciones.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.EXOpciones.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.EXOpciones.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.EXOpciones.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.EXOpciones.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.EXOpciones.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.EXOpciones.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.EXOpciones.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.EXOpciones.HotExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.EXOpciones.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.EXOpciones.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.EXOpciones.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.EXOpciones.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.EXOpciones.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.EXOpciones.Location = New System.Drawing.Point(131, 0)
        Me.EXOpciones.Name = "EXOpciones"
        Me.EXOpciones.Size = New System.Drawing.Size(10, 633)
        Me.EXOpciones.TabIndex = 6
        Me.EXOpciones.TabStop = False
        '
        'dgvUsuario
        '
        Me.dgvUsuario.AllowUserToAddRows = False
        Me.dgvUsuario.AllowUserToDeleteRows = False
        Me.dgvUsuario.AllowUserToOrderColumns = True
        Me.dgvUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuario.ContextMenuStrip = Me.mnOp
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuario.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUsuario.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvUsuario.Location = New System.Drawing.Point(147, 102)
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.ReadOnly = True
        Me.dgvUsuario.Size = New System.Drawing.Size(1134, 531)
        Me.dgvUsuario.TabIndex = 7
        '
        'mnOp
        '
        Me.mnOp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMPRIMIRESTADODECUENTAToolStripMenuItem})
        Me.mnOp.Name = "mnOp"
        Me.mnOp.Size = New System.Drawing.Size(190, 26)
        '
        'IMPRIMIRESTADODECUENTAToolStripMenuItem
        '
        Me.IMPRIMIRESTADODECUENTAToolStripMenuItem.Image = Global.Administativo.My.Resources.Resources.news_subscribe
        Me.IMPRIMIRESTADODECUENTAToolStripMenuItem.Name = "IMPRIMIRESTADODECUENTAToolStripMenuItem"
        Me.IMPRIMIRESTADODECUENTAToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.IMPRIMIRESTADODECUENTAToolStripMenuItem.Text = "IMPRIMIR FORMATOS"
        '
        'dgMuestra1
        '
        Me.dgMuestra1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMuestra1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col1, Me.Column1, Me.Column2})
        Me.dgMuestra1.Location = New System.Drawing.Point(137, 221)
        Me.dgMuestra1.Name = "dgMuestra1"
        Me.dgMuestra1.Size = New System.Drawing.Size(118, 85)
        Me.dgMuestra1.TabIndex = 8
        '
        'col1
        '
        Me.col1.HeaderText = "Columna1"
        Me.col1.Name = "col1"
        Me.col1.Width = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "Columna2"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = "Columna3"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 25
        '
        'DataGridView1_1
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1_1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1_1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1_1.Location = New System.Drawing.Point(193, 291)
        Me.DataGridView1_1.Name = "DataGridView1_1"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1_1.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1_1.Size = New System.Drawing.Size(130, 10)
        Me.DataGridView1_1.TabIndex = 8
        '
        'Column3
        '
        Me.Column3.HeaderText = "Columna1"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Columna2"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "Columna3"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 50
        '
        'rbCab
        '
        Me.rbCab.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbCab.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbCab.ContainerControlProcessDialogKey = True
        Me.rbCab.DragDropSupport = True
        Me.rbCab.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdCamNom, Me.btnagrbitacora, Me.cmdCamMed, Me.cmdCamTar, Me.btnsuspender, Me.btnconectar, Me.cmdDarBaja, Me.cmdBajaDef, Me.cmdReacti, Me.cmbAct, Me.btnaexcel, Me.cmdSalir})
        Me.rbCab.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbCab.Location = New System.Drawing.Point(420, 3)
        Me.rbCab.Name = "rbCab"
        Me.rbCab.Size = New System.Drawing.Size(717, 84)
        Me.rbCab.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbCab.TabIndex = 1
        Me.rbCab.Text = "Cambios"
        '
        '
        '
        Me.rbCab.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCab.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbCab.TitleVisible = False
        '
        'cmdCamNom
        '
        Me.cmdCamNom.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdCamNom.Image = Global.Administativo.My.Resources.Resources.package_editors
        Me.cmdCamNom.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdCamNom.Name = "cmdCamNom"
        Me.cmdCamNom.SubItemsExpandWidth = 14
        Me.cmdCamNom.Text = "Cambio de nombre"
        '
        'btnagrbitacora
        '
        Me.btnagrbitacora.Image = Global.Administativo.My.Resources.Resources.Apertura
        Me.btnagrbitacora.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnagrbitacora.Name = "btnagrbitacora"
        Me.btnagrbitacora.SubItemsExpandWidth = 14
        Me.btnagrbitacora.Text = "Bitacora"
        '
        'cmdCamMed
        '
        Me.cmdCamMed.Image = Global.Administativo.My.Resources.Resources.karm_2
        Me.cmdCamMed.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdCamMed.Name = "cmdCamMed"
        Me.cmdCamMed.SubItemsExpandWidth = 14
        Me.cmdCamMed.Text = "Cambio de Medidor"
        '
        'cmdCamTar
        '
        Me.cmdCamTar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdCamTar.Image = Global.Administativo.My.Resources.Resources.agt_reload
        Me.cmdCamTar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdCamTar.Name = "cmdCamTar"
        Me.cmdCamTar.SubItemsExpandWidth = 14
        Me.cmdCamTar.Text = "Cambio de tarifa"
        '
        'btnsuspender
        '
        Me.btnsuspender.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnsuspender.Image = Global.Administativo.My.Resources.Resources.LLAV
        Me.btnsuspender.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnsuspender.Name = "btnsuspender"
        Me.btnsuspender.SubItemsExpandWidth = 14
        Me.btnsuspender.Text = "Suspender"
        '
        'btnconectar
        '
        Me.btnconectar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnconectar.Image = Global.Administativo.My.Resources.Resources.conectar48
        Me.btnconectar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnconectar.Name = "btnconectar"
        Me.btnconectar.SubItemsExpandWidth = 14
        Me.btnconectar.Text = "Conectar"
        '
        'cmdDarBaja
        '
        Me.cmdDarBaja.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdDarBaja.Image = Global.Administativo.My.Resources.Resources.dar_baja
        Me.cmdDarBaja.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdDarBaja.Name = "cmdDarBaja"
        Me.cmdDarBaja.SubItemsExpandWidth = 14
        Me.cmdDarBaja.Text = "Baja temporal"
        '
        'cmdBajaDef
        '
        Me.cmdBajaDef.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdBajaDef.Image = Global.Administativo.My.Resources.Resources.edit_remove
        Me.cmdBajaDef.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdBajaDef.Name = "cmdBajaDef"
        Me.cmdBajaDef.SubItemsExpandWidth = 14
        Me.cmdBajaDef.Text = "Baja definitiva"
        '
        'cmdReacti
        '
        Me.cmdReacti.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdReacti.Image = Global.Administativo.My.Resources.Resources.activar
        Me.cmdReacti.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdReacti.Name = "cmdReacti"
        Me.cmdReacti.SubItemsExpandWidth = 14
        Me.cmdReacti.Text = "Reactivar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cuenta"
        '
        'cmbAct
        '
        Me.cmbAct.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmbAct.Image = Global.Administativo.My.Resources.Resources.cnr_update
        Me.cmbAct.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmbAct.Name = "cmbAct"
        Me.cmbAct.SubItemsExpandWidth = 14
        Me.cmbAct.Text = "Restaurar Consulta"
        '
        'btnaexcel
        '
        Me.btnaexcel.Image = Global.Administativo.My.Resources.Resources.image0072
        Me.btnaexcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnaexcel.Name = "btnaexcel"
        Me.btnaexcel.SubItemsExpandWidth = 14
        Me.btnaexcel.Text = "A excel"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Cerrar"
        '
        'rbOpciones
        '
        Me.rbOpciones.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbOpciones.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOpciones.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOpciones.ContainerControlProcessDialogKey = True
        Me.rbOpciones.DragDropSupport = True
        Me.rbOpciones.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdVisualizar, Me.BtnNuevo, Me.cmdContrato, Me.btnDatosfiscales, Me.btnCompro})
        Me.rbOpciones.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOpciones.Location = New System.Drawing.Point(3, 3)
        Me.rbOpciones.Name = "rbOpciones"
        Me.rbOpciones.Size = New System.Drawing.Size(276, 84)
        Me.rbOpciones.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOpciones.TabIndex = 0
        Me.rbOpciones.Text = "Opciones"
        '
        '
        '
        Me.rbOpciones.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOpciones.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOpciones.TitleVisible = False
        '
        'cmdVisualizar
        '
        Me.cmdVisualizar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdVisualizar.Image = Global.Administativo.My.Resources.Resources.demo
        Me.cmdVisualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdVisualizar.Name = "cmdVisualizar"
        Me.cmdVisualizar.SubItemsExpandWidth = 14
        Me.cmdVisualizar.Text = "Visualizar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnNuevo.Image = Global.Administativo.My.Resources.Resources.contratos
        Me.BtnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.SubItemsExpandWidth = 14
        Me.BtnNuevo.Text = "Nuevo Contrato"
        '
        'cmdContrato
        '
        Me.cmdContrato.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdContrato.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.cmdContrato.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdContrato.Name = "cmdContrato"
        Me.cmdContrato.SubItemsExpandWidth = 14
        Me.cmdContrato.Text = "Editar Contrato"
        '
        'btnDatosfiscales
        '
        Me.btnDatosfiscales.Image = Global.Administativo.My.Resources.Resources.compfile
        Me.btnDatosfiscales.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnDatosfiscales.Name = "btnDatosfiscales"
        Me.btnDatosfiscales.SubItemsExpandWidth = 14
        Me.btnDatosfiscales.Text = "Datos fiscales"
        '
        'btnCompro
        '
        Me.btnCompro.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnCompro.Image = Global.Administativo.My.Resources.Resources.compfile
        Me.btnCompro.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCompro.Name = "btnCompro"
        Me.btnCompro.SubItemsExpandWidth = 14
        Me.btnCompro.Text = "Datos Domicilio"
        '
        'ToolBar
        '
        Me.ToolBar.CanvasColor = System.Drawing.SystemColors.Control
        Me.ToolBar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ToolBar.Controls.Add(Me.rbActi)
        Me.ToolBar.Controls.Add(Me.rbOpciones)
        Me.ToolBar.Controls.Add(Me.rbCab)
        Me.ToolBar.DisabledBackColor = System.Drawing.Color.Empty
        Me.ToolBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolBar.Location = New System.Drawing.Point(141, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(1146, 96)
        '
        '
        '
        Me.ToolBar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ToolBar.Style.BackColorGradientAngle = 90
        Me.ToolBar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ToolBar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderBottomWidth = 1
        Me.ToolBar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ToolBar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderLeftWidth = 1
        Me.ToolBar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderRightWidth = 1
        Me.ToolBar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderTopWidth = 1
        Me.ToolBar.Style.CornerDiameter = 4
        Me.ToolBar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ToolBar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ToolBar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ToolBar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.ToolBar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ToolBar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ToolBar.TabIndex = 9
        '
        'rbActi
        '
        Me.rbActi.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbActi.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbActi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbActi.ContainerControlProcessDialogKey = True
        Me.rbActi.DragDropSupport = True
        Me.rbActi.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdInstaB, Me.cmdActi})
        Me.rbActi.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbActi.Location = New System.Drawing.Point(284, 3)
        Me.rbActi.Name = "rbActi"
        Me.rbActi.Size = New System.Drawing.Size(130, 84)
        Me.rbActi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbActi.TabIndex = 2
        '
        '
        '
        Me.rbActi.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbActi.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbActi.TitleVisible = False
        '
        'cmdInstaB
        '
        Me.cmdInstaB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdInstaB.Image = Global.Administativo.My.Resources.Resources.advancedsettings
        Me.cmdInstaB.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdInstaB.Name = "cmdInstaB"
        Me.cmdInstaB.SubItemsExpandWidth = 14
        Me.cmdInstaB.Text = "Instalación"
        '
        'cmdActi
        '
        Me.cmdActi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdActi.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdActi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdActi.Name = "cmdActi"
        Me.cmdActi.SubItemsExpandWidth = 14
        Me.cmdActi.Text = "Activación"
        '
        'frmBusUsuario
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1287, 633)
        Me.Controls.Add(Me.dgvUsuario)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.EXOpciones)
        Me.Controls.Add(Me.SBOpciones)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBusUsuario"
        Me.Text = "Búsqueda de usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgMuestra1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMuestra2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMuestra3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnOp.ResumeLayout(False)
        CType(Me.dgMuestra1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUsuario As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dgMuestra1 As System.Windows.Forms.DataGridView
    Friend WithEvents col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1_1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnOp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IMPRIMIRESTADODECUENTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgMuestra1_1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgMuestra2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgMuestra3 As System.Windows.Forms.DataGridView
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents SideBar1 As SideBar
    Private WithEvents ControlContainerItem1 As ControlContainerItem
    Private WithEvents SBOpciones As SideBar
    Private WithEvents SBIExportar As SideBarPanelItem
    Private WithEvents SBIFiltro As SideBarPanelItem
    Private WithEvents EXOpciones As ExpandableSplitter
    Private WithEvents cmdFiltro As ButtonItem
    Private WithEvents cmdBuscar As ButtonItem
    Private WithEvents rbOpciones As RibbonBar
    Private WithEvents cmdContrato As ButtonItem
    Private WithEvents cmdImp As ButtonItem
    Private WithEvents lblTotal As LabelItem
    Private WithEvents rbCab As RibbonBar
    Private WithEvents cmdCamNom As ButtonItem
    Private WithEvents cmdCamMed As ButtonItem
    Private WithEvents cmdCamTar As ButtonItem
    Private WithEvents ToolBar As Controls.GroupPanel
    Private WithEvents BtnNuevo As ButtonItem
    Private WithEvents cmdDarBaja As ButtonItem
    Private WithEvents cmdReacti As ButtonItem
    Private WithEvents cmbAct As ButtonItem
    Private WithEvents cmdVisualizar As ButtonItem
    Private WithEvents cmdSalir As ButtonItem
    Private WithEvents rbActi As RibbonBar
    Public WithEvents cmdInstaB As ButtonItem
    Public WithEvents cmdActi As ButtonItem
    Private WithEvents cmdBajaDef As ButtonItem
    Private WithEvents btnsuspender As ButtonItem
    Private WithEvents btnconectar As ButtonItem
    Private WithEvents btnaexcel As ButtonItem
    Private WithEvents cmdExpExc As ButtonItem
    Private WithEvents cmdMuestra As ControlContainerItem
    Private WithEvents cmdMuestra2 As ControlContainerItem
    Private WithEvents cmdMuestra3 As ControlContainerItem
    Private WithEvents btnDatosfiscales As ButtonItem
    Friend WithEvents btnCompro As ButtonItem
    Friend WithEvents btnbitacora As ButtonItem
    Friend WithEvents btnagrbitacora As ButtonItem
End Class
