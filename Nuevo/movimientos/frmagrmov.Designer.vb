<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagrmov
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
        Me.lblfoliodecontrato = New DevComponents.DotNetBar.LabelX()
        Me.LBLNOMBRE = New DevComponents.DotNetBar.LabelX()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.Txtidconcepto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Txtconcepto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtdetalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.lbltipomov = New DevComponents.DotNetBar.LabelX()
        Me.btnok = New DevComponents.DotNetBar.ButtonX()
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.txtCuenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.dtfven = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.TxtMonto = New DevComponents.Editors.DoubleInput()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.LblTitIVA = New DevComponents.DotNetBar.LabelX()
        Me.LblTitTotal = New DevComponents.DotNetBar.LabelX()
        Me.LblTotal = New DevComponents.DotNetBar.LabelX()
        Me.LblIva = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LblDireccion = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.ChkAplicaRecargo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.DTPicker1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtubicacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfoliodecontrato
        '
        '
        '
        '
        Me.lblfoliodecontrato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblfoliodecontrato.Location = New System.Drawing.Point(29, 54)
        Me.lblfoliodecontrato.Name = "lblfoliodecontrato"
        Me.lblfoliodecontrato.Size = New System.Drawing.Size(100, 18)
        Me.lblfoliodecontrato.TabIndex = 0
        Me.lblfoliodecontrato.Text = "lblfoliodecontrato"
        '
        'LBLNOMBRE
        '
        '
        '
        '
        Me.LBLNOMBRE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBLNOMBRE.Location = New System.Drawing.Point(29, 84)
        Me.LBLNOMBRE.Name = "LBLNOMBRE"
        Me.LBLNOMBRE.Size = New System.Drawing.Size(436, 23)
        Me.LBLNOMBRE.TabIndex = 5
        Me.LBLNOMBRE.Text = "lblnombre"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.AdvTree1)
        Me.ExpandablePanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.ExpandablePanel1.Location = New System.Drawing.Point(508, 3)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(348, 487)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 26
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Conceptos"
        '
        'AdvTree1
        '
        Me.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvTree1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.AdvTree1.Location = New System.Drawing.Point(3, 25)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(342, 459)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.TabIndex = 0
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
        'Txtidconcepto
        '
        Me.Txtidconcepto.AllowDrop = True
        '
        '
        '
        Me.Txtidconcepto.Border.Class = "TextBoxBorder"
        Me.Txtidconcepto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtidconcepto.FocusHighlightEnabled = True
        Me.Txtidconcepto.Location = New System.Drawing.Point(130, 161)
        Me.Txtidconcepto.Name = "Txtidconcepto"
        Me.Txtidconcepto.Size = New System.Drawing.Size(91, 20)
        Me.Txtidconcepto.TabIndex = 8
        Me.Txtidconcepto.WatermarkText = "ID del concepto"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(29, 161)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(81, 17)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Id concepto"
        '
        'Txtconcepto
        '
        Me.Txtconcepto.AllowDrop = True
        '
        '
        '
        Me.Txtconcepto.Border.Class = "TextBoxBorder"
        Me.Txtconcepto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtconcepto.FocusHighlightEnabled = True
        Me.Txtconcepto.Location = New System.Drawing.Point(130, 190)
        Me.Txtconcepto.Name = "Txtconcepto"
        Me.Txtconcepto.Size = New System.Drawing.Size(335, 20)
        Me.Txtconcepto.TabIndex = 10
        Me.Txtconcepto.WatermarkText = "Concepto del movimiento"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(29, 190)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(64, 20)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Concepto"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(29, 252)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(76, 24)
        Me.LabelX4.TabIndex = 13
        Me.LabelX4.Text = "Motivo"
        '
        'txtdetalle
        '
        '
        '
        '
        Me.txtdetalle.Border.Class = "TextBoxBorder"
        Me.txtdetalle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdetalle.FocusHighlightEnabled = True
        Me.txtdetalle.Location = New System.Drawing.Point(29, 282)
        Me.txtdetalle.MaxLength = 50
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(436, 20)
        Me.txtdetalle.TabIndex = 15
        Me.txtdetalle.WatermarkText = "Escribe el motivo detallado, sólo sí es necesario"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(29, 323)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(96, 20)
        Me.LabelX5.TabIndex = 16
        Me.LabelX5.Text = "Monto $"
        '
        'lbltipomov
        '
        '
        '
        '
        Me.lbltipomov.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbltipomov.Location = New System.Drawing.Point(130, 246)
        Me.lbltipomov.Name = "lbltipomov"
        Me.lbltipomov.Size = New System.Drawing.Size(55, 18)
        Me.lbltipomov.TabIndex = 14
        '
        'btnok
        '
        Me.btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnok.Image = Global.Administativo.My.Resources.Resources.apply
        Me.btnok.Location = New System.Drawing.Point(243, 439)
        Me.btnok.Name = "btnok"
        Me.btnok.PulseSpeed = 30
        Me.btnok.Size = New System.Drawing.Size(118, 38)
        Me.btnok.TabIndex = 24
        Me.btnok.Text = "Aceptar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdBuscar.FocusCuesEnabled = False
        Me.cmdBuscar.Image = Global.Administativo.My.Resources.Resources.search777
        Me.cmdBuscar.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.cmdBuscar.Location = New System.Drawing.Point(221, 3)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.PulseSpeed = 30
        Me.cmdBuscar.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.cmdBuscar.Size = New System.Drawing.Size(31, 31)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.TabStop = False
        Me.cmdBuscar.Visible = False
        '
        'txtCuenta
        '
        '
        '
        '
        Me.txtCuenta.Border.Class = "TextBoxBorder"
        Me.txtCuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCuenta.FocusHighlightEnabled = True
        Me.txtCuenta.Location = New System.Drawing.Point(29, 54)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.WatermarkText = "Número de cuenta"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(29, 220)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(64, 20)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Vencimiento"
        '
        'dtfven
        '
        '
        '
        '
        Me.dtfven.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtfven.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfven.ButtonDropDown.Visible = True
        Me.dtfven.FocusHighlightEnabled = True
        Me.dtfven.IsPopupCalendarOpen = False
        Me.dtfven.Location = New System.Drawing.Point(130, 220)
        '
        '
        '
        '
        '
        '
        Me.dtfven.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtfven.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfven.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtfven.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtfven.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtfven.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtfven.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtfven.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtfven.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtfven.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfven.MonthCalendar.DisplayMonth = New Date(2008, 10, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtfven.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtfven.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtfven.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtfven.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfven.MonthCalendar.TodayButtonVisible = True
        Me.dtfven.Name = "dtfven"
        Me.dtfven.Size = New System.Drawing.Size(122, 20)
        Me.dtfven.TabIndex = 12
        '
        'TxtMonto
        '
        '
        '
        '
        Me.TxtMonto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtMonto.ButtonFreeText.Checked = True
        Me.TxtMonto.FocusHighlightEnabled = True
        Me.TxtMonto.Increment = 1.0R
        Me.TxtMonto.Location = New System.Drawing.Point(130, 323)
        Me.TxtMonto.MaxValue = 1.0E+21R
        Me.TxtMonto.MinValue = 0R
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.ShowUpDown = True
        Me.TxtMonto.Size = New System.Drawing.Size(174, 20)
        Me.TxtMonto.TabIndex = 17
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(383, 439)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(118, 38)
        Me.BtnCancelar.TabIndex = 25
        Me.BtnCancelar.Text = "Cancelar"
        '
        'LblTitIVA
        '
        '
        '
        '
        Me.LblTitIVA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitIVA.Location = New System.Drawing.Point(29, 358)
        Me.LblTitIVA.Name = "LblTitIVA"
        Me.LblTitIVA.Size = New System.Drawing.Size(96, 20)
        Me.LblTitIVA.TabIndex = 19
        Me.LblTitIVA.Text = "IVA"
        '
        'LblTitTotal
        '
        '
        '
        '
        Me.LblTitTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitTotal.Location = New System.Drawing.Point(29, 403)
        Me.LblTitTotal.Name = "LblTitTotal"
        Me.LblTitTotal.Size = New System.Drawing.Size(96, 20)
        Me.LblTitTotal.TabIndex = 22
        Me.LblTitTotal.Text = "Total"
        '
        'LblTotal
        '
        '
        '
        '
        Me.LblTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTotal.Location = New System.Drawing.Point(130, 403)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(174, 20)
        Me.LblTotal.TabIndex = 23
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblIva
        '
        '
        '
        '
        Me.LblIva.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblIva.Location = New System.Drawing.Point(130, 358)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(174, 20)
        Me.LblIva.TabIndex = 20
        Me.LblIva.Text = "0.00"
        Me.LblIva.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground2
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(25, 376)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX7.Size = New System.Drawing.Size(301, 22)
        Me.LabelX7.TabIndex = 21
        Me.LabelX7.Text = "________________________________________________"
        '
        'LblDireccion
        '
        '
        '
        '
        Me.LblDireccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblDireccion.Location = New System.Drawing.Point(29, 113)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(436, 23)
        Me.LblDireccion.TabIndex = 6
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(330, 224)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(171, 52)
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
        Me.GroupPanel1.TabIndex = 30
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(3, 3)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(153, 34)
        Me.LabelX8.TabIndex = 1
        Me.LabelX8.Text = "Para agregar un cargo arraste un concepto hacia afuera=>"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX8.WordWrap = True
        '
        'ChkAplicaRecargo
        '
        '
        '
        '
        Me.ChkAplicaRecargo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkAplicaRecargo.Checked = True
        Me.ChkAplicaRecargo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAplicaRecargo.CheckValue = "Y"
        Me.ChkAplicaRecargo.Location = New System.Drawing.Point(330, 323)
        Me.ChkAplicaRecargo.Name = "ChkAplicaRecargo"
        Me.ChkAplicaRecargo.Size = New System.Drawing.Size(144, 23)
        Me.ChkAplicaRecargo.TabIndex = 31
        Me.ChkAplicaRecargo.Text = "Aplicar Interes Moratorio"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(26, 22)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(44, 13)
        Me.Label42.TabIndex = 32
        Me.Label42.Text = "Cuenta:"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(276, 15)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(50, 14)
        Me.LabelX9.TabIndex = 0
        Me.LabelX9.Text = "Fecha"
        '
        'DTPicker1
        '
        '
        '
        '
        Me.DTPicker1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTPicker1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTPicker1.ButtonDropDown.Visible = True
        Me.DTPicker1.CustomFormat = "dd / MMM / yyyy"
        Me.DTPicker1.FocusHighlightEnabled = True
        Me.DTPicker1.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.DTPicker1.IsPopupCalendarOpen = False
        Me.DTPicker1.Location = New System.Drawing.Point(328, 15)
        '
        '
        '
        '
        '
        '
        Me.DTPicker1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTPicker1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTPicker1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTPicker1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTPicker1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTPicker1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTPicker1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTPicker1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTPicker1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTPicker1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTPicker1.MonthCalendar.DisplayMonth = New Date(2008, 12, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DTPicker1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTPicker1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTPicker1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTPicker1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTPicker1.MonthCalendar.TodayButtonVisible = True
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(137, 20)
        Me.DTPicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(157, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Ubicacion:"
        '
        'txtubicacion
        '
        '
        '
        '
        Me.txtubicacion.Border.Class = "TextBoxBorder"
        Me.txtubicacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtubicacion.FocusHighlightEnabled = True
        Me.txtubicacion.Location = New System.Drawing.Point(170, 54)
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.Size = New System.Drawing.Size(100, 20)
        Me.txtubicacion.TabIndex = 37
        Me.txtubicacion.WatermarkText = "Número de cuenta"
        '
        'frmagrmov
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtubicacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.ChkAplicaRecargo)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblIva)
        Me.Controls.Add(Me.LblTitTotal)
        Me.Controls.Add(Me.LblTitIVA)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.DTPicker1)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.dtfven)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.lbltipomov)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.Txtconcepto)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Txtidconcepto)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.LBLNOMBRE)
        Me.Controls.Add(Me.lblfoliodecontrato)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmagrmov"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento a usuario"
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfoliodecontrato As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBLNOMBRE As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents Txtidconcepto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txtconcepto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbltipomov As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtfven As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TxtMonto As DevComponents.Editors.DoubleInput
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblTitIVA As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblIva As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblDireccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChkAplicaRecargo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DTPicker1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label1 As Label
    Friend WithEvents txtubicacion As DevComponents.DotNetBar.Controls.TextBoxX
End Class
