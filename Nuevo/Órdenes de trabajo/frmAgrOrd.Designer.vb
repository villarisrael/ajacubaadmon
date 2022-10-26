Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgrOrd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrOrd))
        Me.gpUsu = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcuenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DTfAlta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txthFalta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMED = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblMen = New DevComponents.DotNetBar.LabelX()
        Me.txtCel = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.txtTel = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.lblEst = New DevComponents.DotNetBar.LabelX()
        Me.txtUbi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.gpDatOrd = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.chkRein = New System.Windows.Forms.CheckBox()
        Me.chkUrge = New System.Windows.Forms.CheckBox()
        Me.lblmen2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cmbFue = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.txtInd = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbProb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.tmp = New System.Windows.Forms.Timer(Me.components)
        Me.gpRes = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DTfeccom = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblmen3 = New DevComponents.DotNetBar.LabelX()
        Me.dtFecRel = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblFecRel = New DevComponents.DotNetBar.LabelX()
        Me.lblBrig = New DevComponents.DotNetBar.LabelX()
        Me.lblAt = New DevComponents.DotNetBar.LabelX()
        Me.lblREs = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.cmbRel = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtPerRec = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RB = New DevComponents.DotNetBar.RibbonBar()
        Me.lblTit = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.cmdGuar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdGen = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdExit = New DevComponents.DotNetBar.ButtonItem()
        Me.lblReg = New DevComponents.DotNetBar.LabelX()
        Me.txtcomunidad = New System.Windows.Forms.TextBox()
        Me.TXTSECTOR = New System.Windows.Forms.TextBox()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TXTINMUEBLE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpUsu.SuspendLayout()
        CType(Me.DTfAlta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatOrd.SuspendLayout()
        Me.gpRes.SuspendLayout()
        CType(Me.DTfeccom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RB.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpUsu
        '
        Me.gpUsu.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpUsu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpUsu.Controls.Add(Me.TXTINMUEBLE)
        Me.gpUsu.Controls.Add(Me.LabelX8)
        Me.gpUsu.Controls.Add(Me.TXTSECTOR)
        Me.gpUsu.Controls.Add(Me.txtcomunidad)
        Me.gpUsu.Controls.Add(Me.btnbuscar)
        Me.gpUsu.Controls.Add(Me.txtNombre)
        Me.gpUsu.Controls.Add(Me.txtcuenta)
        Me.gpUsu.Controls.Add(Me.DTfAlta)
        Me.gpUsu.Controls.Add(Me.txthFalta)
        Me.gpUsu.Controls.Add(Me.txtMED)
        Me.gpUsu.Controls.Add(Me.lblMen)
        Me.gpUsu.Controls.Add(Me.txtCel)
        Me.gpUsu.Controls.Add(Me.txtTel)
        Me.gpUsu.Controls.Add(Me.lblEst)
        Me.gpUsu.Controls.Add(Me.txtUbi)
        Me.gpUsu.Controls.Add(Me.LabelX7)
        Me.gpUsu.Controls.Add(Me.LabelX1)
        Me.gpUsu.Controls.Add(Me.LabelX3)
        Me.gpUsu.Controls.Add(Me.LabelX5)
        Me.gpUsu.Controls.Add(Me.LabelX6)
        Me.gpUsu.Controls.Add(Me.LabelX11)
        Me.gpUsu.Controls.Add(Me.LabelX2)
        Me.gpUsu.Controls.Add(Me.LabelX13)
        Me.gpUsu.Controls.Add(Me.LabelX12)
        Me.gpUsu.Controls.Add(Me.LabelX19)
        Me.gpUsu.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpUsu.Location = New System.Drawing.Point(24, 66)
        Me.gpUsu.Name = "gpUsu"
        Me.gpUsu.Size = New System.Drawing.Size(1064, 203)
        '
        '
        '
        Me.gpUsu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpUsu.Style.BackColorGradientAngle = 90
        Me.gpUsu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpUsu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUsu.Style.BorderBottomWidth = 1
        Me.gpUsu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpUsu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUsu.Style.BorderLeftWidth = 1
        Me.gpUsu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUsu.Style.BorderRightWidth = 1
        Me.gpUsu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUsu.Style.BorderTopWidth = 1
        Me.gpUsu.Style.CornerDiameter = 4
        Me.gpUsu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpUsu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpUsu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpUsu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpUsu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpUsu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpUsu.TabIndex = 0
        Me.gpUsu.Text = "DATOS DEL USUARIO"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(947, 28)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(24, 23)
        Me.btnbuscar.TabIndex = 16
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        Me.btnbuscar.Visible = False
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Location = New System.Drawing.Point(465, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(527, 24)
        Me.txtNombre.TabIndex = 3
        '
        'txtcuenta
        '
        '
        '
        '
        Me.txtcuenta.Border.Class = "TextBoxBorder"
        Me.txtcuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcuenta.Location = New System.Drawing.Point(120, 27)
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(66, 24)
        Me.txtcuenta.TabIndex = 2
        '
        'DTfAlta
        '
        '
        '
        '
        Me.DTfAlta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTfAlta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfAlta.ButtonDropDown.Visible = True
        Me.DTfAlta.IsPopupCalendarOpen = False
        Me.DTfAlta.Location = New System.Drawing.Point(121, -1)
        '
        '
        '
        '
        '
        '
        Me.DTfAlta.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTfAlta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfAlta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTfAlta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTfAlta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTfAlta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTfAlta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTfAlta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTfAlta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTfAlta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfAlta.MonthCalendar.DisplayMonth = New Date(2010, 3, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DTfAlta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTfAlta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTfAlta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTfAlta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfAlta.MonthCalendar.TodayButtonVisible = True
        Me.DTfAlta.Name = "DTfAlta"
        Me.DTfAlta.Size = New System.Drawing.Size(171, 24)
        Me.DTfAlta.TabIndex = 0
        '
        'txthFalta
        '
        '
        '
        '
        Me.txthFalta.Border.Class = "TextBoxBorder"
        Me.txthFalta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txthFalta.Location = New System.Drawing.Point(440, 2)
        Me.txthFalta.Name = "txthFalta"
        Me.txthFalta.Size = New System.Drawing.Size(128, 24)
        Me.txthFalta.TabIndex = 1
        '
        'txtMED
        '
        '
        '
        '
        Me.txtMED.Border.Class = "TextBoxBorder"
        Me.txtMED.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMED.Location = New System.Drawing.Point(120, 124)
        Me.txtMED.Name = "txtMED"
        Me.txtMED.Size = New System.Drawing.Size(117, 24)
        Me.txtMED.TabIndex = 6
        '
        'lblMen
        '
        Me.lblMen.AutoSize = True
        Me.lblMen.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblMen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMen.Location = New System.Drawing.Point(800, 41)
        Me.lblMen.Name = "lblMen"
        Me.lblMen.Size = New System.Drawing.Size(0, 0)
        Me.lblMen.TabIndex = 14
        Me.lblMen.WordWrap = True
        '
        'txtCel
        '
        '
        '
        '
        Me.txtCel.BackgroundStyle.Class = "TextBoxBorder"
        Me.txtCel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCel.BeepOnError = True
        Me.txtCel.ButtonClear.Visible = True
        Me.txtCel.FocusHighlightEnabled = True
        Me.txtCel.Location = New System.Drawing.Point(669, 125)
        Me.txtCel.Mask = "(999)000-0000"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(116, 20)
        Me.txtCel.TabIndex = 8
        Me.txtCel.Text = ""
        '
        'txtTel
        '
        '
        '
        '
        Me.txtTel.BackgroundStyle.Class = "TextBoxBorder"
        Me.txtTel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTel.BeepOnError = True
        Me.txtTel.ButtonClear.Visible = True
        Me.txtTel.FocusHighlightEnabled = True
        Me.txtTel.Location = New System.Drawing.Point(422, 125)
        Me.txtTel.Mask = "(999)000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(116, 20)
        Me.txtTel.TabIndex = 7
        Me.txtTel.Text = ""
        '
        'lblEst
        '
        Me.lblEst.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblEst.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblEst.Location = New System.Drawing.Point(672, 3)
        Me.lblEst.Name = "lblEst"
        Me.lblEst.Size = New System.Drawing.Size(65, 20)
        Me.lblEst.TabIndex = 13
        Me.lblEst.Text = "ESTADO"
        '
        'txtUbi
        '
        '
        '
        '
        Me.txtUbi.Border.Class = "TextBoxBorder"
        Me.txtUbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUbi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbi.FocusHighlightEnabled = True
        Me.txtUbi.Location = New System.Drawing.Point(121, 55)
        Me.txtUbi.MaxLength = 209
        Me.txtUbi.Multiline = True
        Me.txtUbi.Name = "txtUbi"
        Me.txtUbi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtUbi.Size = New System.Drawing.Size(624, 38)
        Me.txtUbi.TabIndex = 4
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(8, 151)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(92, 20)
        Me.LabelX7.TabIndex = 1
        Me.LabelX7.Text = "REGION:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(8, 55)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(92, 20)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "UBICACIÓN:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(591, 125)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(72, 20)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "MÓVIL:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(8, 125)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(92, 20)
        Me.LabelX5.TabIndex = 1
        Me.LabelX5.Text = "MEDIDOR:"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(9, 31)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(92, 20)
        Me.LabelX6.TabIndex = 1
        Me.LabelX6.Text = "Cuenta"
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(328, 125)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(92, 20)
        Me.LabelX11.TabIndex = 1
        Me.LabelX11.Text = "TELÉFONO:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(8, 99)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(126, 20)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "COMUNIDAD:"
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(369, 3)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(78, 20)
        Me.LabelX13.TabIndex = 1
        Me.LabelX13.Text = "HORA:"
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(9, 3)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(83, 20)
        Me.LabelX12.TabIndex = 1
        Me.LabelX12.Text = "FECHA:"
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(387, 29)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(72, 20)
        Me.LabelX19.TabIndex = 1
        Me.LabelX19.Text = "NOMBRE:"
        '
        'gpDatOrd
        '
        Me.gpDatOrd.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatOrd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatOrd.Controls.Add(Me.chkRein)
        Me.gpDatOrd.Controls.Add(Me.chkUrge)
        Me.gpDatOrd.Controls.Add(Me.lblmen2)
        Me.gpDatOrd.Controls.Add(Me.LabelX4)
        Me.gpDatOrd.Controls.Add(Me.cmbFue)
        Me.gpDatOrd.Controls.Add(Me.LabelX15)
        Me.gpDatOrd.Controls.Add(Me.LabelX21)
        Me.gpDatOrd.Controls.Add(Me.txtInd)
        Me.gpDatOrd.Controls.Add(Me.cmbProb)
        Me.gpDatOrd.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatOrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.gpDatOrd.Location = New System.Drawing.Point(24, 265)
        Me.gpDatOrd.Name = "gpDatOrd"
        Me.gpDatOrd.Size = New System.Drawing.Size(1064, 140)
        '
        '
        '
        Me.gpDatOrd.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatOrd.Style.BackColorGradientAngle = 90
        Me.gpDatOrd.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatOrd.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatOrd.Style.BorderBottomWidth = 1
        Me.gpDatOrd.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatOrd.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatOrd.Style.BorderLeftWidth = 1
        Me.gpDatOrd.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatOrd.Style.BorderRightWidth = 1
        Me.gpDatOrd.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatOrd.Style.BorderTopWidth = 1
        Me.gpDatOrd.Style.CornerDiameter = 4
        Me.gpDatOrd.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatOrd.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatOrd.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatOrd.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatOrd.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatOrd.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatOrd.TabIndex = 1
        Me.gpDatOrd.Text = "DATOS DE LA ORDEN"
        '
        'chkRein
        '
        Me.chkRein.AutoSize = True
        Me.chkRein.BackColor = System.Drawing.Color.Transparent
        Me.chkRein.Location = New System.Drawing.Point(297, 83)
        Me.chkRein.Name = "chkRein"
        Me.chkRein.Size = New System.Drawing.Size(97, 22)
        Me.chkRein.TabIndex = 3
        Me.chkRein.Text = "REINCIDE"
        Me.chkRein.UseVisualStyleBackColor = False
        '
        'chkUrge
        '
        Me.chkUrge.AutoSize = True
        Me.chkUrge.BackColor = System.Drawing.Color.Transparent
        Me.chkUrge.Location = New System.Drawing.Point(162, 83)
        Me.chkUrge.Name = "chkUrge"
        Me.chkUrge.Size = New System.Drawing.Size(101, 22)
        Me.chkUrge.TabIndex = 2
        Me.chkUrge.Text = "URGENTE"
        Me.chkUrge.UseVisualStyleBackColor = False
        '
        'lblmen2
        '
        Me.lblmen2.AutoSize = True
        Me.lblmen2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblmen2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblmen2.Location = New System.Drawing.Point(730, 12)
        Me.lblmen2.Name = "lblmen2"
        Me.lblmen2.Size = New System.Drawing.Size(0, 0)
        Me.lblmen2.TabIndex = 15
        Me.lblmen2.WordWrap = True
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(423, 74)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(91, 40)
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "FUENTE:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbFue
        '
        Me.cmbFue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFue.DisplayMember = "Text"
        Me.cmbFue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFue.FocusHighlightEnabled = True
        Me.cmbFue.FormattingEnabled = True
        Me.cmbFue.ItemHeight = 19
        Me.cmbFue.Location = New System.Drawing.Point(520, 82)
        Me.cmbFue.Name = "cmbFue"
        Me.cmbFue.Size = New System.Drawing.Size(201, 25)
        Me.cmbFue.TabIndex = 4
        Me.cmbFue.WatermarkText = "OK"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(12, 37)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(123, 20)
        Me.LabelX15.TabIndex = 1
        Me.LabelX15.Text = "INDICACIONES:"
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Location = New System.Drawing.Point(12, 3)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(123, 20)
        Me.LabelX21.TabIndex = 1
        Me.LabelX21.Text = "PROBLEMA:"
        '
        'txtInd
        '
        '
        '
        '
        Me.txtInd.Border.Class = "TextBoxBorder"
        Me.txtInd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInd.FocusHighlightEnabled = True
        Me.txtInd.Location = New System.Drawing.Point(162, 30)
        Me.txtInd.MaxLength = 418
        Me.txtInd.Multiline = True
        Me.txtInd.Name = "txtInd"
        Me.txtInd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInd.Size = New System.Drawing.Size(559, 38)
        Me.txtInd.TabIndex = 1
        '
        'cmbProb
        '
        Me.cmbProb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProb.DisplayMember = "Text"
        Me.cmbProb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProb.FocusHighlightEnabled = True
        Me.cmbProb.FormattingEnabled = True
        Me.cmbProb.ItemHeight = 19
        Me.cmbProb.Location = New System.Drawing.Point(162, 3)
        Me.cmbProb.Name = "cmbProb"
        Me.cmbProb.Size = New System.Drawing.Size(559, 25)
        Me.cmbProb.TabIndex = 0
        '
        'tmp
        '
        Me.tmp.Enabled = True
        Me.tmp.Interval = 10000000
        '
        'gpRes
        '
        Me.gpRes.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpRes.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpRes.Controls.Add(Me.DTfeccom)
        Me.gpRes.Controls.Add(Me.lblmen3)
        Me.gpRes.Controls.Add(Me.dtFecRel)
        Me.gpRes.Controls.Add(Me.lblFecRel)
        Me.gpRes.Controls.Add(Me.lblBrig)
        Me.gpRes.Controls.Add(Me.lblAt)
        Me.gpRes.Controls.Add(Me.lblREs)
        Me.gpRes.Controls.Add(Me.LabelX16)
        Me.gpRes.Controls.Add(Me.cmbRel)
        Me.gpRes.Controls.Add(Me.txtPerRec)
        Me.gpRes.Controls.Add(Me.txtCom)
        Me.gpRes.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.gpRes.Location = New System.Drawing.Point(24, 407)
        Me.gpRes.Name = "gpRes"
        Me.gpRes.Size = New System.Drawing.Size(1064, 163)
        '
        '
        '
        Me.gpRes.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpRes.Style.BackColorGradientAngle = 90
        Me.gpRes.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpRes.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRes.Style.BorderBottomWidth = 1
        Me.gpRes.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpRes.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRes.Style.BorderLeftWidth = 1
        Me.gpRes.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRes.Style.BorderRightWidth = 1
        Me.gpRes.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRes.Style.BorderTopWidth = 1
        Me.gpRes.Style.CornerDiameter = 4
        Me.gpRes.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpRes.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpRes.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpRes.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpRes.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpRes.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpRes.TabIndex = 2
        Me.gpRes.Text = "RESULTADO"
        '
        'DTfeccom
        '
        '
        '
        '
        Me.DTfeccom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTfeccom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfeccom.ButtonDropDown.Visible = True
        Me.DTfeccom.IsPopupCalendarOpen = False
        Me.DTfeccom.Location = New System.Drawing.Point(183, 4)
        '
        '
        '
        '
        '
        '
        Me.DTfeccom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTfeccom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfeccom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTfeccom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTfeccom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTfeccom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTfeccom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTfeccom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTfeccom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTfeccom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfeccom.MonthCalendar.DisplayMonth = New Date(2010, 3, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DTfeccom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTfeccom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTfeccom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTfeccom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfeccom.MonthCalendar.TodayButtonVisible = True
        Me.DTfeccom.Name = "DTfeccom"
        Me.DTfeccom.Size = New System.Drawing.Size(112, 24)
        Me.DTfeccom.TabIndex = 17
        '
        'lblmen3
        '
        Me.lblmen3.AutoSize = True
        Me.lblmen3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblmen3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblmen3.Location = New System.Drawing.Point(641, 32)
        Me.lblmen3.Name = "lblmen3"
        Me.lblmen3.Size = New System.Drawing.Size(0, 0)
        Me.lblmen3.TabIndex = 16
        Me.lblmen3.WordWrap = True
        '
        'dtFecRel
        '
        '
        '
        '
        Me.dtFecRel.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFecRel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecRel.ButtonDropDown.Visible = True
        Me.dtFecRel.FocusHighlightEnabled = True
        Me.dtFecRel.IsPopupCalendarOpen = False
        Me.dtFecRel.Location = New System.Drawing.Point(465, 3)
        '
        '
        '
        '
        '
        '
        Me.dtFecRel.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtFecRel.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecRel.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFecRel.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFecRel.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFecRel.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFecRel.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFecRel.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFecRel.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFecRel.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecRel.MonthCalendar.DisplayMonth = New Date(2008, 11, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtFecRel.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFecRel.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFecRel.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFecRel.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecRel.MonthCalendar.TodayButtonVisible = True
        Me.dtFecRel.Name = "dtFecRel"
        Me.dtFecRel.Size = New System.Drawing.Size(122, 24)
        Me.dtFecRel.TabIndex = 1
        '
        'lblFecRel
        '
        Me.lblFecRel.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblFecRel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblFecRel.Location = New System.Drawing.Point(329, 5)
        Me.lblFecRel.Name = "lblFecRel"
        Me.lblFecRel.Size = New System.Drawing.Size(116, 20)
        Me.lblFecRel.TabIndex = 1
        Me.lblFecRel.Text = "FECHA REAL:"
        '
        'lblBrig
        '
        Me.lblBrig.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblBrig.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblBrig.Location = New System.Drawing.Point(8, 36)
        Me.lblBrig.Name = "lblBrig"
        Me.lblBrig.Size = New System.Drawing.Size(76, 20)
        Me.lblBrig.TabIndex = 1
        Me.lblBrig.Text = "BRIGADA:"
        '
        'lblAt
        '
        Me.lblAt.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblAt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblAt.Location = New System.Drawing.Point(10, 108)
        Me.lblAt.Name = "lblAt"
        Me.lblAt.Size = New System.Drawing.Size(169, 20)
        Me.lblAt.TabIndex = 1
        Me.lblAt.Text = "ATENDIÓ:"
        '
        'lblREs
        '
        Me.lblREs.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblREs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblREs.Location = New System.Drawing.Point(8, 71)
        Me.lblREs.Name = "lblREs"
        Me.lblREs.Size = New System.Drawing.Size(125, 20)
        Me.lblREs.TabIndex = 1
        Me.lblREs.Text = "RESULTADO:"
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(8, 5)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(167, 20)
        Me.LabelX16.TabIndex = 1
        Me.LabelX16.Text = "FECHA COMPROMISO:"
        '
        'cmbRel
        '
        Me.cmbRel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRel.DisplayMember = "Text"
        Me.cmbRel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRel.FocusHighlightEnabled = True
        Me.cmbRel.FormattingEnabled = True
        Me.cmbRel.ItemHeight = 19
        Me.cmbRel.Location = New System.Drawing.Point(183, 34)
        Me.cmbRel.Name = "cmbRel"
        Me.cmbRel.Size = New System.Drawing.Size(200, 25)
        Me.cmbRel.TabIndex = 2
        Me.cmbRel.WatermarkText = "OK"
        '
        'txtPerRec
        '
        '
        '
        '
        Me.txtPerRec.Border.Class = "TextBoxBorder"
        Me.txtPerRec.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPerRec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPerRec.FocusHighlightEnabled = True
        Me.txtPerRec.Location = New System.Drawing.Point(183, 105)
        Me.txtPerRec.Multiline = True
        Me.txtPerRec.Name = "txtPerRec"
        Me.txtPerRec.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPerRec.Size = New System.Drawing.Size(414, 26)
        Me.txtPerRec.TabIndex = 4
        '
        'txtCom
        '
        '
        '
        '
        Me.txtCom.Border.Class = "TextBoxBorder"
        Me.txtCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCom.FocusHighlightEnabled = True
        Me.txtCom.Location = New System.Drawing.Point(183, 65)
        Me.txtCom.Multiline = True
        Me.txtCom.Name = "txtCom"
        Me.txtCom.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCom.Size = New System.Drawing.Size(421, 34)
        Me.txtCom.TabIndex = 3
        '
        'RB
        '
        Me.RB.AutoOverflowEnabled = True
        '
        '
        '
        Me.RB.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RB.ContainerControlProcessDialogKey = True
        Me.RB.Controls.Add(Me.lblTit)
        Me.RB.Dock = System.Windows.Forms.DockStyle.Top
        Me.RB.DragDropSupport = True
        Me.RB.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdGuar, Me.cmdImp, Me.cmdGen, Me.cmdExit})
        Me.RB.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RB.Location = New System.Drawing.Point(0, 0)
        Me.RB.Name = "RB"
        Me.RB.Size = New System.Drawing.Size(1100, 60)
        Me.RB.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RB.TabIndex = 3
        Me.RB.TabStop = False
        Me.RB.Text = "Opciones"
        '
        '
        '
        Me.RB.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RB.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RB.TitleVisible = False
        '
        'lblTit
        '
        '
        '
        '
        Me.lblTit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTit.Location = New System.Drawing.Point(270, 12)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(622, 37)
        Me.lblTit.TabIndex = 16
        Me.lblTit.Text = "<b><font size=""+6""><i>NUEVA ORDEN DE TRABAJO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'cmdGuar
        '
        Me.cmdGuar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdGuar.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.cmdGuar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdGuar.Name = "cmdGuar"
        Me.cmdGuar.SubItemsExpandWidth = 14
        Me.cmdGuar.Text = "Guardar"
        '
        'cmdImp
        '
        Me.cmdImp.Image = CType(resources.GetObject("cmdImp.Image"), System.Drawing.Image)
        Me.cmdImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.SubItemsExpandWidth = 14
        Me.cmdImp.Text = "Imprimir"
        '
        'cmdGen
        '
        Me.cmdGen.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdGen.Image = Global.Administativo.My.Resources.Resources.otroscobros
        Me.cmdGen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdGen.Name = "cmdGen"
        Me.cmdGen.SubItemsExpandWidth = 14
        Me.cmdGen.Text = "Generar"
        Me.cmdGen.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.SubItemsExpandWidth = 14
        Me.cmdExit.Text = "Cerrar"
        '
        'lblReg
        '
        Me.lblReg.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReg.Location = New System.Drawing.Point(24, 566)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(1037, 27)
        Me.lblReg.TabIndex = 1
        '
        'txtcomunidad
        '
        Me.txtcomunidad.Location = New System.Drawing.Point(121, 96)
        Me.txtcomunidad.Name = "txtcomunidad"
        Me.txtcomunidad.Size = New System.Drawing.Size(258, 24)
        Me.txtcomunidad.TabIndex = 17
        '
        'TXTSECTOR
        '
        Me.TXTSECTOR.Location = New System.Drawing.Point(120, 151)
        Me.TXTSECTOR.Name = "TXTSECTOR"
        Me.TXTSECTOR.Size = New System.Drawing.Size(182, 24)
        Me.TXTSECTOR.TabIndex = 18
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(192, 29)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(88, 20)
        Me.LabelX8.TabIndex = 19
        Me.LabelX8.Text = "INMUEBLE"
        '
        'TXTINMUEBLE
        '
        '
        '
        '
        Me.TXTINMUEBLE.Border.Class = "TextBoxBorder"
        Me.TXTINMUEBLE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTINMUEBLE.Location = New System.Drawing.Point(277, 28)
        Me.TXTINMUEBLE.Name = "TXTINMUEBLE"
        Me.TXTINMUEBLE.Size = New System.Drawing.Size(93, 24)
        Me.TXTINMUEBLE.TabIndex = 20
        '
        'frmAgrOrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 642)
        Me.Controls.Add(Me.gpRes)
        Me.Controls.Add(Me.gpDatOrd)
        Me.Controls.Add(Me.gpUsu)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.RB)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrOrd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de órdenes de trabajo"
        Me.gpUsu.ResumeLayout(False)
        Me.gpUsu.PerformLayout()
        CType(Me.DTfAlta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatOrd.ResumeLayout(False)
        Me.gpDatOrd.PerformLayout()
        Me.gpRes.ResumeLayout(False)
        Me.gpRes.PerformLayout()
        CType(Me.DTfeccom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpUsu As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpDatOrd As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tmp As System.Windows.Forms.Timer
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbProb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtInd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpRes As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dtFecRel As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFecRel As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbRel As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtCom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblBrig As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblREs As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUbi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblEst As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbFue As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtTel As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents txtCel As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents lblMen As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblmen2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblmen3 As DevComponents.DotNetBar.LabelX

    Friend WithEvents RB As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdGuar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdGen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblAt As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPerRec As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReg As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTit As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents chkUrge As System.Windows.Forms.CheckBox
    Friend WithEvents chkRein As System.Windows.Forms.CheckBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txthFalta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMED As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DTfeccom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DTfAlta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents TXTSECTOR As TextBox
    Friend WithEvents txtcomunidad As TextBox
    Friend WithEvents LabelX8 As LabelX
    Friend WithEvents TXTINMUEBLE As Controls.TextBoxX
End Class
