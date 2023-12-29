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
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.Addtema = New DevComponents.DotNetBar.RibbonBar()
        Me.cmdOrg = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cbLayerToLabel = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbFieldToUse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdFontColor = New DevComponents.DotNetBar.ButtonX()
        Me.cmdLabel = New DevComponents.DotNetBar.ButtonX()
        Me.btnClearLabels = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cdlOpen = New System.Windows.Forms.ColorDialog()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtubicacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbuscar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.lblnombre = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.lblmanzana = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.lbldireccion = New DevComponents.DotNetBar.LabelX()
        Me.lblTarifa = New DevComponents.DotNetBar.LabelX()
        Me.lblcolonia = New DevComponents.DotNetBar.LabelX()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader3 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader4 = New DevComponents.AdvTree.ColumnHeader()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.lbltotal = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.MAP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.MAP1)
        Me.PanelEx1.Controls.Add(Me.lvLegend)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(164, 81)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1051, 598)
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
        Me.MAP1.Location = New System.Drawing.Point(-2, 3)
        Me.MAP1.Name = "MAP1"
        Me.MAP1.OcxState = CType(resources.GetObject("MAP1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MAP1.Size = New System.Drawing.Size(1046, 590)
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
        Me.lvLegend.Size = New System.Drawing.Size(101, 631)
        Me.lvLegend.TabIndex = 24
        Me.lvLegend.UseCompatibleStateImageBehavior = False
        Me.lvLegend.View = System.Windows.Forms.View.Details
        Me.lvLegend.Visible = False
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
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5, Me.ItemContainer1, Me.ItemContainer4})
        Me.RibbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar2.Location = New System.Drawing.Point(3, 210)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(105, 61)
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
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem11})
        '
        '
        '
        Me.ItemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Image = Global.Administativo.My.Resources.Resources.hand_2
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "ButtonItem8"
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
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 102)
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
        Me.LabelX1.Location = New System.Drawing.Point(240, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(968, 32)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "SISTEMA DE INFORMACION GEOGRAFICO,<i> <font color=""#ED1C24"">SANTA ROSALIA, BCS</f" &
    "ont></i>"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Addtema)
        Me.GroupPanel1.Controls.Add(Me.RibbonBar1)
        Me.GroupPanel1.Controls.Add(Me.RibbonBar2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(34, 96)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(117, 302)
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
        'cbLayerToLabel
        '
        Me.cbLayerToLabel.DisplayMember = "Text"
        Me.cbLayerToLabel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbLayerToLabel.FormattingEnabled = True
        Me.cbLayerToLabel.ItemHeight = 14
        Me.cbLayerToLabel.Location = New System.Drawing.Point(36, 440)
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
        Me.cbFieldToUse.Location = New System.Drawing.Point(32, 501)
        Me.cbFieldToUse.Name = "cbFieldToUse"
        Me.cbFieldToUse.Size = New System.Drawing.Size(118, 20)
        Me.cbFieldToUse.TabIndex = 7
        '
        'cmdFontColor
        '
        Me.cmdFontColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdFontColor.BackColor = System.Drawing.Color.Black
        Me.cmdFontColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdFontColor.Location = New System.Drawing.Point(120, 541)
        Me.cmdFontColor.Name = "cmdFontColor"
        Me.cmdFontColor.Size = New System.Drawing.Size(30, 20)
        Me.cmdFontColor.TabIndex = 8
        Me.cmdFontColor.Visible = False
        '
        'cmdLabel
        '
        Me.cmdLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdLabel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdLabel.Location = New System.Drawing.Point(34, 567)
        Me.cmdLabel.Name = "cmdLabel"
        Me.cmdLabel.Size = New System.Drawing.Size(118, 20)
        Me.cmdLabel.TabIndex = 9
        Me.cmdLabel.Text = "Etiquetas"
        '
        'btnClearLabels
        '
        Me.btnClearLabels.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearLabels.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearLabels.Location = New System.Drawing.Point(33, 593)
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
        Me.LabelX2.Location = New System.Drawing.Point(32, 541)
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
        Me.LabelX3.Location = New System.Drawing.Point(36, 418)
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
        Me.LabelX4.Location = New System.Drawing.Point(32, 479)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(86, 16)
        Me.LabelX4.TabIndex = 13
        Me.LabelX4.Text = "Field to use:"
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
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(167, 43)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(65, 23)
        Me.LabelX5.TabIndex = 17
        Me.LabelX5.Text = "ubicacion"
        '
        'txtubicacion
        '
        '
        '
        '
        Me.txtubicacion.Border.Class = "TextBoxBorder"
        Me.txtubicacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtubicacion.Location = New System.Drawing.Point(238, 46)
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.PreventEnterBeep = True
        Me.txtubicacion.Size = New System.Drawing.Size(100, 20)
        Me.txtubicacion.TabIndex = 18
        '
        'btnbuscar
        '
        Me.btnbuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbuscar.Location = New System.Drawing.Point(361, 42)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnbuscar.TabIndex = 19
        Me.btnbuscar.Text = "Buscar"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(1257, 84)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(109, 23)
        Me.LabelX6.TabIndex = 23
        Me.LabelX6.Text = "Nombre"
        '
        'lblnombre
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblnombre.Location = New System.Drawing.Point(1257, 113)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(262, 23)
        Me.lblnombre.TabIndex = 24
        Me.lblnombre.Text = "<font color=""#ED1C24""><b>NOMBRE</b></font>"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(1257, 142)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(69, 23)
        Me.LabelX7.TabIndex = 25
        Me.LabelX7.Text = "Manzana"
        '
        'lblmanzana
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblmanzana.Location = New System.Drawing.Point(1257, 172)
        Me.lblmanzana.Name = "lblmanzana"
        Me.lblmanzana.Size = New System.Drawing.Size(55, 23)
        Me.lblmanzana.TabIndex = 26
        Me.lblmanzana.Text = "<font color=""#ED1C24""><b>Manzana</b></font>"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(1257, 201)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 27
        Me.LabelX8.Text = "Datos"
        '
        'lbldireccion
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbldireccion.Location = New System.Drawing.Point(1257, 222)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(301, 23)
        Me.lbldireccion.TabIndex = 28
        Me.lbldireccion.Text = "<font color=""#ED1C24""><b>Direccion</b></font>"
        '
        'lblTarifa
        '
        '
        '
        '
        Me.lblTarifa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTarifa.Location = New System.Drawing.Point(1257, 280)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(301, 23)
        Me.lblTarifa.TabIndex = 29
        Me.lblTarifa.Text = "<font color=""#ED1C24""><b>Tarifa</b></font>"
        '
        'lblcolonia
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblcolonia.Location = New System.Drawing.Point(1257, 251)
        Me.lblcolonia.Name = "lblcolonia"
        Me.lblcolonia.Size = New System.Drawing.Size(301, 23)
        Me.lblcolonia.TabIndex = 31
        Me.lblcolonia.Text = "<font color=""#ED1C24""><b>Colonia</b></font>"
        '
        'AdvTree1
        '
        Me.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree1.Columns.Add(Me.ColumnHeader3)
        Me.AdvTree1.Columns.Add(Me.ColumnHeader4)
        Me.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.AdvTree1.Location = New System.Drawing.Point(1257, 354)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(280, 309)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.TabIndex = 32
        Me.AdvTree1.Text = "AdvTree1"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle1
        '
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Atributo"
        Me.ColumnHeader1.Width.Absolute = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Name = "ColumnHeader2"
        Me.ColumnHeader2.Text = "Valor"
        Me.ColumnHeader2.Width.Absolute = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Name = "ColumnHeader3"
        Me.ColumnHeader3.Text = "Propiedad"
        Me.ColumnHeader3.Width.Absolute = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Name = "ColumnHeader4"
        Me.ColumnHeader4.Text = "Valor"
        Me.ColumnHeader4.Width.Absolute = 150
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(1489, 25)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(69, 23)
        Me.LabelX9.TabIndex = 33
        Me.LabelX9.Text = "Total"
        '
        'lbltotal
        '
        '
        '
        '
        Me.lbltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(1448, 46)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(110, 23)
        Me.lbltotal.TabIndex = 34
        Me.lbltotal.Text = "0"
        Me.lbltotal.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lbltotal.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'Frmexplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1570, 697)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.AdvTree1)
        Me.Controls.Add(Me.lblcolonia)
        Me.Controls.Add(Me.lblTarifa)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.lblmanzana)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtubicacion)
        Me.Controls.Add(Me.LabelX5)
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
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Addtema As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdOrg As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cbLayerToLabel As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbFieldToUse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdFontColor As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdLabel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearLabels As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cdlOpen As System.Windows.Forms.ColorDialog
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtubicacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnbuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblnombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblmanzana As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbldireccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTarifa As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblcolonia As DevComponents.DotNetBar.LabelX
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents ColumnHeader3 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader4 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbltotal As DevComponents.DotNetBar.LabelX
End Class
