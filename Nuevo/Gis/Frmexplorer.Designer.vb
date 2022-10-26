Imports AxMapWinGIS.AxMap
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmexplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmexplorer))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.MAP1 = New AxMapWinGIS.AxMap()
        Me.lvLegend = New System.Windows.Forms.ListView()
        Me.cdlOpenOpen = New System.Windows.Forms.OpenFileDialog()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.Addtema = New DevComponents.DotNetBar.RibbonBar()
        Me.cmdOrg = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.cbLayerToLabel = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbFieldToUse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdFontColor = New DevComponents.DotNetBar.ButtonX()
        Me.cmdLabel = New DevComponents.DotNetBar.ButtonX()
        Me.btnClearLabels = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cdlOpen = New System.Windows.Forms.ColorDialog()
        Me.PanelEx1.SuspendLayout()
        CType(Me.MAP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.MAP1)
        Me.PanelEx1.Controls.Add(Me.lvLegend)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(132, 30)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1250, 635)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        Me.PanelEx1.Text = "PanelEx1"
        '
        'MAP1
        '
        Me.MAP1.Enabled = True
        Me.MAP1.Location = New System.Drawing.Point(186, 2)
        Me.MAP1.Name = "MAP1"
        Me.MAP1.OcxState = CType(resources.GetObject("MAP1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MAP1.Size = New System.Drawing.Size(1061, 630)
        Me.MAP1.TabIndex = 25
        '
        'lvLegend
        '
        Me.lvLegend.BackColor = System.Drawing.SystemColors.Window
        Me.lvLegend.CheckBoxes = True
        Me.lvLegend.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvLegend.FullRowSelect = True
        Me.lvLegend.HideSelection = False
        Me.lvLegend.Location = New System.Drawing.Point(3, 1)
        Me.lvLegend.Name = "lvLegend"
        Me.lvLegend.Size = New System.Drawing.Size(177, 631)
        Me.lvLegend.TabIndex = 24
        Me.lvLegend.UseCompatibleStateImageBehavior = False
        Me.lvLegend.View = System.Windows.Forms.View.Details
        '
        'cdlOpenOpen
        '
        Me.cdlOpenOpen.FileName = "OpenFileDialog1"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.DragDropSupport = True
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3, Me.ButtonItem5, Me.ItemContainer1})
        Me.RibbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar2.Location = New System.Drawing.Point(3, 201)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(105, 93)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar2.TabIndex = 3
        Me.RibbonBar2.Text = "Opciones"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem8, Me.ButtonItem7})
        '
        '
        '
        Me.ItemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Image = Global.Administativo.My.Resources.Resources.hand_2
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "ButtonItem8"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Image = Global.Administativo.My.Resources.Resources._16__Pen_tool_
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "ButtonItem7"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Image = Global.Administativo.My.Resources.Resources._16__Zoom_in_
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "ButtonItem5"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem6})
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Image = Global.Administativo.My.Resources.Resources.zoom_out_16
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "ButtonItem6"
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.DragDropSupport = True
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3, Me.ButtonItem4})
        Me.RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 102)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(106, 93)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar1.TabIndex = 1
        Me.RibbonBar1.Text = "Funciones Zoom"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = Global.Administativo.My.Resources.Resources.search777
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 14
        Me.ButtonItem3.Text = "Visión Completa"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Image = Global.Administativo.My.Resources.Resources.cnr_update
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 14
        Me.ButtonItem4.Text = "Visión Previa"
        '
        'Addtema
        '
        Me.Addtema.AutoOverflowEnabled = True
        '
        '
        '
        Me.Addtema.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Addtema.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Addtema.ContainerControlProcessDialogKey = True
        Me.Addtema.DragDropSupport = True
        Me.Addtema.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdOrg, Me.ButtonItem1, Me.ButtonItem2})
        Me.Addtema.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Addtema.Location = New System.Drawing.Point(3, 3)
        Me.Addtema.Name = "Addtema"
        Me.Addtema.Size = New System.Drawing.Size(105, 93)
        Me.Addtema.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Addtema.TabIndex = 0
        Me.Addtema.Text = "Funciones de capa"
        '
        '
        '
        Me.Addtema.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Addtema.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'cmdOrg
        '
        Me.cmdOrg.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdOrg.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.cmdOrg.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdOrg.Name = "cmdOrg"
        Me.cmdOrg.SubItemsExpandWidth = 14
        Me.cmdOrg.Text = "Agregar"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Remover"
        Me.ButtonItem1.Visible = False
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "Quitar "
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Red
        Me.LabelX1.Location = New System.Drawing.Point(208, -5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(968, 32)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "SISTEMA DE INFORMACION GEOGRAFICO,<i> <font color=""#ED1C24"">HUICHAPAN, HIDALGO</f" & _
            "ont></i>"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.RibbonBar4)
        Me.GroupPanel1.Controls.Add(Me.RibbonBar3)
        Me.GroupPanel1.Controls.Add(Me.Addtema)
        Me.GroupPanel1.Controls.Add(Me.RibbonBar1)
        Me.GroupPanel1.Controls.Add(Me.RibbonBar2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(9, 5)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(117, 501)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 5
        '
        'RibbonBar4
        '
        Me.RibbonBar4.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar4.ContainerControlProcessDialogKey = True
        Me.RibbonBar4.DragDropSupport = True
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem10})
        Me.RibbonBar4.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar4.Location = New System.Drawing.Point(3, 399)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(105, 94)
        Me.RibbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar4.TabIndex = 5
        Me.RibbonBar4.Text = "GIS Explorer"
        '
        '
        '
        Me.RibbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem10
        '
        Me.ButtonItem10.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem10.Image = Global.Administativo.My.Resources.Resources.globe2
        Me.ButtonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.SubItemsExpandWidth = 14
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = True
        Me.RibbonBar3.DragDropSupport = True
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem9})
        Me.RibbonBar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar3.Location = New System.Drawing.Point(3, 300)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(105, 93)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar3.TabIndex = 4
        Me.RibbonBar3.Text = "Exportar GIS"
        '
        '
        '
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem9
        '
        Me.ButtonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem9.Image = Global.Administativo.My.Resources.Resources.ExportarCaja
        Me.ButtonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.SubItemsExpandWidth = 14
        Me.ButtonItem9.Text = "Actualizar"
        '
        'cbLayerToLabel
        '
        Me.cbLayerToLabel.DisplayMember = "Text"
        Me.cbLayerToLabel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbLayerToLabel.FormattingEnabled = True
        Me.cbLayerToLabel.ItemHeight = 14
        Me.cbLayerToLabel.Location = New System.Drawing.Point(5, 525)
        Me.cbLayerToLabel.Name = "cbLayerToLabel"
        Me.cbLayerToLabel.Size = New System.Drawing.Size(120, 20)
        Me.cbLayerToLabel.TabIndex = 6
        '
        'cbFieldToUse
        '
        Me.cbFieldToUse.DisplayMember = "Text"
        Me.cbFieldToUse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFieldToUse.FormattingEnabled = True
        Me.cbFieldToUse.ItemHeight = 14
        Me.cbFieldToUse.Location = New System.Drawing.Point(6, 562)
        Me.cbFieldToUse.Name = "cbFieldToUse"
        Me.cbFieldToUse.Size = New System.Drawing.Size(118, 20)
        Me.cbFieldToUse.TabIndex = 7
        '
        'cmdFontColor
        '
        Me.cmdFontColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdFontColor.BackColor = System.Drawing.Color.Black
        Me.cmdFontColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdFontColor.Location = New System.Drawing.Point(94, 588)
        Me.cmdFontColor.Name = "cmdFontColor"
        Me.cmdFontColor.Size = New System.Drawing.Size(30, 20)
        Me.cmdFontColor.TabIndex = 8
        Me.cmdFontColor.Visible = False
        '
        'cmdLabel
        '
        Me.cmdLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdLabel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdLabel.Location = New System.Drawing.Point(5, 619)
        Me.cmdLabel.Name = "cmdLabel"
        Me.cmdLabel.Size = New System.Drawing.Size(118, 20)
        Me.cmdLabel.TabIndex = 9
        Me.cmdLabel.Text = "Etiquetas"
        '
        'btnClearLabels
        '
        Me.btnClearLabels.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearLabels.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearLabels.Location = New System.Drawing.Point(4, 645)
        Me.btnClearLabels.Name = "btnClearLabels"
        Me.btnClearLabels.Size = New System.Drawing.Size(119, 21)
        Me.btnClearLabels.TabIndex = 10
        Me.btnClearLabels.Text = "Borrar Etiquetas"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(8, 591)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(86, 16)
        Me.LabelX2.TabIndex = 11
        Me.LabelX2.Text = "Label Color:"
        Me.LabelX2.Visible = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(4, 507)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(86, 16)
        Me.LabelX3.TabIndex = 12
        Me.LabelX3.Text = "Layer to label:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(5, 546)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(86, 16)
        Me.LabelX4.TabIndex = 13
        Me.LabelX4.Text = "Field to use:"
        '
        'Frmexplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 697)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.btnClearLabels)
        Me.Controls.Add(Me.cmdLabel)
        Me.Controls.Add(Me.cmdFontColor)
        Me.Controls.Add(Me.cbFieldToUse)
        Me.Controls.Add(Me.cbLayerToLabel)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "Frmexplorer"
        Me.Text = "Sistema de información geográfica "
        Me.TopMost = True
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.MAP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Public WithEvents MAP1 As AxMapWinGIS.AxMap
    Public WithEvents lvLegend As System.Windows.Forms.ListView
    Friend WithEvents cdlOpenOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Addtema As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdOrg As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cbLayerToLabel As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbFieldToUse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdFontColor As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdLabel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearLabels As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cdlOpen As System.Windows.Forms.ColorDialog
End Class
