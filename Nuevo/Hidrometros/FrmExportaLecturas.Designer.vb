<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportaLecturas
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
        Me.PB = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCalcular = New DevComponents.DotNetBar.ButtonX()
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Dialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Dialogocrear = New System.Windows.Forms.SaveFileDialog()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CmbRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkRutas = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.lblSelectrutas = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.Folderdialogo = New System.Windows.Forms.FolderBrowserDialog()
        Me.gpObs = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtObs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmenCance1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMenAgra = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtVen1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.CmbMes = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.IIPeriodo = New DevComponents.Editors.IntegerInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel1.SuspendLayout()
        Me.gpObs.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.IIPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB
        '
        '
        '
        '
        Me.PB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PB.Location = New System.Drawing.Point(10, 454)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(806, 10)
        Me.PB.TabIndex = 4
        Me.PB.TabStop = False
        Me.PB.TextVisible = True
        Me.PB.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(723, 470)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.PulseSpeed = 40
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCalcular.Image = Global.Administativo.My.Resources.Resources.Exportar
        Me.BtnCalcular.Location = New System.Drawing.Point(612, 470)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.PulseSpeed = 40
        Me.BtnCalcular.Size = New System.Drawing.Size(93, 38)
        Me.BtnCalcular.TabIndex = 2
        Me.BtnCalcular.Text = "Exportar"
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(52, -8)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(352, 44)
        Me.LblTitulo.TabIndex = 26
        Me.LblTitulo.Text = "<b><font size=""+6"">EXPORTAR LISTADO DE LECTURAS</font></b>"
        '
        'Dialogo
        '
        Me.Dialogo.FileName = "LecturasCe.sdf"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.CmbRegion)
        Me.GroupPanel1.Controls.Add(Me.chkRutas)
        Me.GroupPanel1.Controls.Add(Me.lblSelectrutas)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(6, 30)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(441, 166)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Indica la ruta a exportar"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(50, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(42, 23)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "Region:"
        '
        'CmbRegion
        '
        Me.CmbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRegion.DisplayMember = "Text"
        Me.CmbRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbRegion.FocusHighlightEnabled = True
        Me.CmbRegion.FormattingEnabled = True
        Me.CmbRegion.ItemHeight = 16
        Me.CmbRegion.Location = New System.Drawing.Point(98, 10)
        Me.CmbRegion.Name = "CmbRegion"
        Me.CmbRegion.Size = New System.Drawing.Size(274, 22)
        Me.CmbRegion.TabIndex = 9
        '
        'chkRutas
        '
        '
        '
        '
        Me.chkRutas.Border.Class = "ListViewBorder"
        Me.chkRutas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkRutas.CheckBoxes = True
        Me.chkRutas.DisabledBackColor = System.Drawing.Color.Empty
        Me.chkRutas.Location = New System.Drawing.Point(7, 61)
        Me.chkRutas.Name = "chkRutas"
        Me.chkRutas.Size = New System.Drawing.Size(422, 66)
        Me.chkRutas.TabIndex = 2
        Me.chkRutas.UseCompatibleStateImageBehavior = False
        Me.chkRutas.View = System.Windows.Forms.View.List
        '
        'lblSelectrutas
        '
        Me.lblSelectrutas.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblSelectrutas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblSelectrutas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectrutas.Location = New System.Drawing.Point(7, 31)
        Me.lblSelectrutas.Name = "lblSelectrutas"
        Me.lblSelectrutas.Size = New System.Drawing.Size(148, 24)
        Me.lblSelectrutas.TabIndex = 11
        Me.lblSelectrutas.Text = "Seleccione las Rutas..."
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(58, 161)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 14)
        Me.LabelX2.TabIndex = 11
        Me.LabelX2.Text = "Ruta:"
        Me.LabelX2.Visible = False
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        Me.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        '
        'gpObs
        '
        Me.gpObs.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpObs.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpObs.Controls.Add(Me.txtObs)
        Me.gpObs.Controls.Add(Me.txtmenCance1)
        Me.gpObs.Controls.Add(Me.txtMenAgra)
        Me.gpObs.Controls.Add(Me.txtVen1)
        Me.gpObs.Controls.Add(Me.LabelX9)
        Me.gpObs.Controls.Add(Me.LabelX10)
        Me.gpObs.Controls.Add(Me.LabelX8)
        Me.gpObs.Controls.Add(Me.LabelX7)
        Me.gpObs.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpObs.Location = New System.Drawing.Point(8, 202)
        Me.gpObs.Name = "gpObs"
        Me.gpObs.Size = New System.Drawing.Size(808, 247)
        '
        '
        '
        Me.gpObs.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpObs.Style.BackColorGradientAngle = 90
        Me.gpObs.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpObs.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObs.Style.BorderBottomWidth = 1
        Me.gpObs.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpObs.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObs.Style.BorderLeftWidth = 1
        Me.gpObs.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObs.Style.BorderRightWidth = 1
        Me.gpObs.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObs.Style.BorderTopWidth = 1
        Me.gpObs.Style.CornerDiameter = 4
        Me.gpObs.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpObs.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpObs.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpObs.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpObs.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpObs.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpObs.TabIndex = 1
        Me.gpObs.Text = "MENSAJES DE IMPRESIÓN"
        '
        'txtObs
        '
        '
        '
        '
        Me.txtObs.Border.Class = "TextBoxBorder"
        Me.txtObs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.FocusHighlightEnabled = True
        Me.txtObs.Location = New System.Drawing.Point(19, 17)
        Me.txtObs.MaxLength = 55
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObs.Size = New System.Drawing.Size(760, 20)
        Me.txtObs.TabIndex = 0
        Me.txtObs.Text = "EVITE EL CORTE, PAGUE A TIEMPO"
        '
        'txtmenCance1
        '
        '
        '
        '
        Me.txtmenCance1.Border.Class = "TextBoxBorder"
        Me.txtmenCance1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmenCance1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmenCance1.FocusHighlightEnabled = True
        Me.txtmenCance1.Location = New System.Drawing.Point(19, 121)
        Me.txtmenCance1.Multiline = True
        Me.txtmenCance1.Name = "txtmenCance1"
        Me.txtmenCance1.Size = New System.Drawing.Size(760, 54)
        Me.txtmenCance1.TabIndex = 2
        Me.txtmenCance1.Text = "SU REZAGO ES DE $M MES DESDE $ES $AÑO PAGUE"
        '
        'txtMenAgra
        '
        '
        '
        '
        Me.txtMenAgra.Border.Class = "TextBoxBorder"
        Me.txtMenAgra.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMenAgra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMenAgra.FocusHighlightEnabled = True
        Me.txtMenAgra.Location = New System.Drawing.Point(19, 195)
        Me.txtMenAgra.MaxLength = 55
        Me.txtMenAgra.Name = "txtMenAgra"
        Me.txtMenAgra.Size = New System.Drawing.Size(760, 20)
        Me.txtMenAgra.TabIndex = 3
        Me.txtMenAgra.Text = "*****  GRACIAS POR SU  PRONTO PAGO  *****"
        Me.txtMenAgra.Visible = False
        '
        'txtVen1
        '
        '
        '
        '
        Me.txtVen1.Border.Class = "TextBoxBorder"
        Me.txtVen1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVen1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVen1.FocusHighlightEnabled = True
        Me.txtVen1.Location = New System.Drawing.Point(19, 57)
        Me.txtVen1.MaxLength = 55
        Me.txtVen1.Multiline = True
        Me.txtVen1.Name = "txtVen1"
        Me.txtVen1.Size = New System.Drawing.Size(760, 44)
        Me.txtVen1.TabIndex = 1
        Me.txtVen1.Text = "SU REZAGO ES DE $M MES DESDE $ES $AÑO PAGUE ANTES"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(19, 178)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(254, 21)
        Me.LabelX9.TabIndex = 8
        Me.LabelX9.Text = "MENSAJE DE PRONTO PAGO"
        Me.LabelX9.Visible = False
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(19, 104)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(176, 21)
        Me.LabelX10.TabIndex = 8
        Me.LabelX10.Text = "MENSAJE DE CANCELACIÓN"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(19, 41)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(176, 21)
        Me.LabelX8.TabIndex = 8
        Me.LabelX8.Text = "MENSAJE DE VENCIMIENTO"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(19, 0)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(133, 21)
        Me.LabelX7.TabIndex = 8
        Me.LabelX7.Text = "MENSAJE DE PRONTO PAGO"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.IIPeriodo)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.CmbMes)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(465, 30)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(323, 145)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 27
        Me.GroupPanel2.Text = "Indica la ruta a exportar"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(7, 9)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(42, 23)
        Me.LabelX3.TabIndex = 11
        Me.LabelX3.Text = "Mes:"
        '
        'CmbMes
        '
        Me.CmbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMes.DisplayMember = "Text"
        Me.CmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbMes.FocusHighlightEnabled = True
        Me.CmbMes.FormattingEnabled = True
        Me.CmbMes.ItemHeight = 14
        Me.CmbMes.Items.AddRange(New Object() {Me.ComboItem13, Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
        Me.CmbMes.Location = New System.Drawing.Point(161, 12)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(114, 20)
        Me.CmbMes.TabIndex = 9
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(7, 31)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(148, 24)
        Me.LabelX4.TabIndex = 11
        Me.LabelX4.Text = "Periodo"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "ENE"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "FEB"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "MAR"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "ABR"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "MAY"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "JUN"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "JUL"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "AGO"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "SEP"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "OCT"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "NOV"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "DIC"
        '
        'IIPeriodo
        '
        '
        '
        '
        Me.IIPeriodo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIPeriodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIPeriodo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIPeriodo.Location = New System.Drawing.Point(194, 39)
        Me.IIPeriodo.MaxValue = 2100
        Me.IIPeriodo.MinValue = 2010
        Me.IIPeriodo.Name = "IIPeriodo"
        Me.IIPeriodo.ShowUpDown = True
        Me.IIPeriodo.Size = New System.Drawing.Size(80, 20)
        Me.IIPeriodo.TabIndex = 12
        Me.IIPeriodo.Value = 2010
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(7, 74)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(218, 23)
        Me.LabelX5.TabIndex = 13
        Me.LabelX5.Text = "Indica el mes de lectura que va exportar."
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "Ninguno"
        '
        'FrmExportaLecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.gpObs)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.BtnCalcular)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "FrmExportaLecturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Listado de Lecturas"
        Me.GroupPanel1.ResumeLayout(False)
        Me.gpObs.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.IIPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PB As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCalcular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Dialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Dialogocrear As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents Folderdialogo As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gpObs As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtmenCance1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMenAgra As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtVen1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtObs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblSelectrutas As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkRutas As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbMes As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IIPeriodo As DevComponents.Editors.IntegerInput
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
End Class
