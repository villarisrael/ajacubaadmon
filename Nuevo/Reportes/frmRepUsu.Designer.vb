<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepUsu))
        Me.tabRepUsu = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Chklistado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkresumen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lblmen = New DevComponents.DotNetBar.LabelX()
        Me.GPFechas = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DTfinal = New System.Windows.Forms.DateTimePicker()
        Me.DTinicio = New System.Windows.Forms.DateTimePicker()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtH = New DevComponents.Editors.IntegerInput()
        Me.txtD = New DevComponents.Editors.IntegerInput()
        Me.dtFec1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtFec2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblA = New DevComponents.DotNetBar.LabelX()
        Me.lblSol = New DevComponents.DotNetBar.LabelX()
        Me.cmbAltCons = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.AmbosA = New DevComponents.Editors.ComboItem()
        Me.siA = New DevComponents.Editors.ComboItem()
        Me.noA = New DevComponents.Editors.ComboItem()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.cmbTipSer = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.cmbMed = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.AMBOS = New DevComponents.Editors.ComboItem()
        Me.SI = New DevComponents.Editors.ComboItem()
        Me.NO = New DevComponents.Editors.ComboItem()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cmbTar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbTUsu = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cmbGiro = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.cmbCol = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmbReg = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX()
        Me.TabComuReg = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Descuentos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.chktodos = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkcondescuento = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chksindescuento = New DevComponents.DotNetBar.Controls.CheckBoxX()
        CType(Me.tabRepUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRepUsu.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel7.SuspendLayout()
        Me.GPFechas.SuspendLayout()
        Me.GroupPanel6.SuspendLayout()
        CType(Me.txtH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFec1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFec2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.Descuentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabRepUsu
        '
        Me.tabRepUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tabRepUsu.CanReorderTabs = True
        Me.tabRepUsu.Controls.Add(Me.TabControlPanel1)
        Me.tabRepUsu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabRepUsu.Location = New System.Drawing.Point(0, 0)
        Me.tabRepUsu.Name = "tabRepUsu"
        Me.tabRepUsu.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabRepUsu.SelectedTabIndex = 0
        Me.tabRepUsu.Size = New System.Drawing.Size(753, 444)
        Me.tabRepUsu.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.tabRepUsu.TabIndex = 0
        Me.tabRepUsu.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabRepUsu.Tabs.Add(Me.TabComuReg)
        Me.tabRepUsu.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel7)
        Me.TabControlPanel1.Controls.Add(Me.ReflectionLabel1)
        Me.TabControlPanel1.Controls.Add(Me.lblmen)
        Me.TabControlPanel1.Controls.Add(Me.GPFechas)
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel6)
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel3)
        Me.TabControlPanel1.Controls.Add(Me.cmdSalir)
        Me.TabControlPanel1.Controls.Add(Me.cmdImp)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(951, 418)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 0
        Me.TabControlPanel1.TabItem = Me.TabComuReg
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.Chklistado)
        Me.GroupPanel7.Controls.Add(Me.chkresumen)
        Me.GroupPanel7.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel7.Location = New System.Drawing.Point(18, 346)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(384, 56)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel7.TabIndex = 31
        Me.GroupPanel7.Text = "Subinforme"
        Me.GroupPanel7.Visible = False
        '
        'Chklistado
        '
        Me.Chklistado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.Chklistado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Chklistado.Location = New System.Drawing.Point(187, 3)
        Me.Chklistado.Name = "Chklistado"
        Me.Chklistado.Size = New System.Drawing.Size(165, 22)
        Me.Chklistado.TabIndex = 12
        Me.Chklistado.Text = "Listado"
        '
        'chkresumen
        '
        Me.chkresumen.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkresumen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkresumen.Location = New System.Drawing.Point(10, 3)
        Me.chkresumen.Name = "chkresumen"
        Me.chkresumen.Size = New System.Drawing.Size(165, 22)
        Me.chkresumen.TabIndex = 11
        Me.chkresumen.Text = "Resumen por consumo"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(295, 308)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(201, 40)
        Me.ReflectionLabel1.TabIndex = 30
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Opciones del</i><font color=""#B02B2C""> <i>reporte</i></font" & _
            "></font></b>"
        Me.ReflectionLabel1.Visible = False
        '
        'lblmen
        '
        Me.lblmen.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblmen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblmen.Location = New System.Drawing.Point(19, 305)
        Me.lblmen.Name = "lblmen"
        Me.lblmen.Size = New System.Drawing.Size(420, 28)
        Me.lblmen.TabIndex = 5
        '
        'GPFechas
        '
        Me.GPFechas.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPFechas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPFechas.Controls.Add(Me.DTfinal)
        Me.GPFechas.Controls.Add(Me.DTinicio)
        Me.GPFechas.Controls.Add(Me.LabelX4)
        Me.GPFechas.Controls.Add(Me.LabelX20)
        Me.GPFechas.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPFechas.Location = New System.Drawing.Point(485, 4)
        Me.GPFechas.Name = "GPFechas"
        Me.GPFechas.Size = New System.Drawing.Size(255, 95)
        '
        '
        '
        Me.GPFechas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPFechas.Style.BackColorGradientAngle = 90
        Me.GPFechas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPFechas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFechas.Style.BorderBottomWidth = 1
        Me.GPFechas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPFechas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFechas.Style.BorderLeftWidth = 1
        Me.GPFechas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFechas.Style.BorderRightWidth = 1
        Me.GPFechas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFechas.Style.BorderTopWidth = 1
        Me.GPFechas.Style.CornerDiameter = 4
        Me.GPFechas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPFechas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPFechas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPFechas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPFechas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPFechas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPFechas.TabIndex = 1
        Me.GPFechas.Text = "RANGO DE FECHAS"
        Me.GPFechas.Visible = False
        '
        'DTfinal
        '
        Me.DTfinal.Location = New System.Drawing.Point(121, 32)
        Me.DTfinal.Name = "DTfinal"
        Me.DTfinal.Size = New System.Drawing.Size(109, 20)
        Me.DTfinal.TabIndex = 33
        '
        'DTinicio
        '
        Me.DTinicio.Location = New System.Drawing.Point(4, 32)
        Me.DTinicio.Name = "DTinicio"
        Me.DTinicio.Size = New System.Drawing.Size(109, 20)
        Me.DTinicio.TabIndex = 32
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(157, 10)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(26, 15)
        Me.LabelX4.TabIndex = 31
        Me.LabelX4.Text = "Final"
        '
        'LabelX20
        '
        Me.LabelX20.AutoSize = True
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX20.Location = New System.Drawing.Point(48, 9)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(31, 15)
        Me.LabelX20.TabIndex = 30
        Me.LabelX20.Text = "Inicial"
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.Descuentos)
        Me.GroupPanel6.Controls.Add(Me.txtH)
        Me.GroupPanel6.Controls.Add(Me.txtD)
        Me.GroupPanel6.Controls.Add(Me.dtFec1)
        Me.GroupPanel6.Controls.Add(Me.dtFec2)
        Me.GroupPanel6.Controls.Add(Me.lblA)
        Me.GroupPanel6.Controls.Add(Me.lblSol)
        Me.GroupPanel6.Controls.Add(Me.cmbAltCons)
        Me.GroupPanel6.Controls.Add(Me.LabelX10)
        Me.GroupPanel6.Controls.Add(Me.LabelX7)
        Me.GroupPanel6.Controls.Add(Me.cmbTipSer)
        Me.GroupPanel6.Controls.Add(Me.LabelX9)
        Me.GroupPanel6.Controls.Add(Me.cmbMed)
        Me.GroupPanel6.Controls.Add(Me.LabelX6)
        Me.GroupPanel6.Controls.Add(Me.cmbTar)
        Me.GroupPanel6.Controls.Add(Me.cmbTUsu)
        Me.GroupPanel6.Controls.Add(Me.LabelX19)
        Me.GroupPanel6.Controls.Add(Me.LabelX5)
        Me.GroupPanel6.Controls.Add(Me.cmbGiro)
        Me.GroupPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel6.Location = New System.Drawing.Point(12, 115)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(728, 184)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.TabIndex = 2
        Me.GroupPanel6.Text = "Usos y giro"
        '
        'txtH
        '
        '
        '
        '
        Me.txtH.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtH.FocusHighlightEnabled = True
        Me.txtH.Location = New System.Drawing.Point(196, 81)
        Me.txtH.MaxValue = 99999
        Me.txtH.MinValue = 0
        Me.txtH.Name = "txtH"
        Me.txtH.ShowUpDown = True
        Me.txtH.Size = New System.Drawing.Size(75, 20)
        Me.txtH.TabIndex = 7
        Me.txtH.Visible = False
        '
        'txtD
        '
        '
        '
        '
        Me.txtD.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtD.FocusHighlightEnabled = True
        Me.txtD.Location = New System.Drawing.Point(96, 81)
        Me.txtD.MaxValue = 99999
        Me.txtD.MinValue = 0
        Me.txtD.Name = "txtD"
        Me.txtD.ShowUpDown = True
        Me.txtD.Size = New System.Drawing.Size(77, 20)
        Me.txtD.TabIndex = 6
        Me.txtD.Visible = False
        '
        'dtFec1
        '
        '
        '
        '
        Me.dtFec1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFec1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec1.ButtonDropDown.Visible = True
        Me.dtFec1.FocusHighlightEnabled = True
        Me.dtFec1.IsPopupCalendarOpen = False
        Me.dtFec1.Location = New System.Drawing.Point(96, 81)
        '
        '
        '
        Me.dtFec1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFec1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtFec1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtFec1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFec1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFec1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFec1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFec1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFec1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFec1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFec1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec1.MonthCalendar.DisplayMonth = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.dtFec1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFec1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFec1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFec1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFec1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFec1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec1.MonthCalendar.TodayButtonVisible = True
        Me.dtFec1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFec1.Name = "dtFec1"
        Me.dtFec1.Size = New System.Drawing.Size(79, 20)
        Me.dtFec1.TabIndex = 37
        '
        'dtFec2
        '
        '
        '
        '
        Me.dtFec2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFec2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec2.ButtonDropDown.Visible = True
        Me.dtFec2.FocusHighlightEnabled = True
        Me.dtFec2.IsPopupCalendarOpen = False
        Me.dtFec2.Location = New System.Drawing.Point(192, 81)
        '
        '
        '
        Me.dtFec2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFec2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtFec2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtFec2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFec2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFec2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFec2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFec2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFec2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFec2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFec2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec2.MonthCalendar.DisplayMonth = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.dtFec2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFec2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFec2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFec2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFec2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFec2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFec2.MonthCalendar.TodayButtonVisible = True
        Me.dtFec2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFec2.Name = "dtFec2"
        Me.dtFec2.Size = New System.Drawing.Size(79, 20)
        Me.dtFec2.TabIndex = 38
        '
        'lblA
        '
        Me.lblA.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblA.Location = New System.Drawing.Point(184, 81)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(10, 20)
        Me.lblA.TabIndex = 34
        Me.lblA.Text = "a"
        '
        'lblSol
        '
        Me.lblSol.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblSol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblSol.Location = New System.Drawing.Point(8, 81)
        Me.lblSol.Name = "lblSol"
        Me.lblSol.Size = New System.Drawing.Size(81, 20)
        Me.lblSol.TabIndex = 39
        Me.lblSol.Text = "Fecha Solicitud:"
        Me.lblSol.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cmbAltCons
        '
        Me.cmbAltCons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAltCons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAltCons.DisplayMember = "Text"
        Me.cmbAltCons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAltCons.FocusHighlightEnabled = True
        Me.cmbAltCons.FormattingEnabled = True
        Me.cmbAltCons.ItemHeight = 14
        Me.cmbAltCons.Items.AddRange(New Object() {Me.AmbosA, Me.siA, Me.noA})
        Me.cmbAltCons.Location = New System.Drawing.Point(364, 55)
        Me.cmbAltCons.Name = "cmbAltCons"
        Me.cmbAltCons.Size = New System.Drawing.Size(175, 20)
        Me.cmbAltCons.TabIndex = 5
        Me.cmbAltCons.Visible = False
        '
        'AmbosA
        '
        Me.AmbosA.Text = "Ambos"
        '
        'siA
        '
        Me.siA.Text = "Sí"
        '
        'noA
        '
        Me.noA.Text = "No"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(277, 55)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(81, 20)
        Me.LabelX10.TabIndex = 33
        Me.LabelX10.Text = "Consumo:"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX10.Visible = False
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(-11, 55)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(100, 20)
        Me.LabelX7.TabIndex = 31
        Me.LabelX7.Text = "Tipo de servicio:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX7.Visible = False
        '
        'cmbTipSer
        '
        Me.cmbTipSer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipSer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipSer.DisplayMember = "Text"
        Me.cmbTipSer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipSer.FocusHighlightEnabled = True
        Me.cmbTipSer.FormattingEnabled = True
        Me.cmbTipSer.ItemHeight = 14
        Me.cmbTipSer.Location = New System.Drawing.Point(96, 55)
        Me.cmbTipSer.Name = "cmbTipSer"
        Me.cmbTipSer.Size = New System.Drawing.Size(175, 20)
        Me.cmbTipSer.TabIndex = 4
        Me.cmbTipSer.Visible = False
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(458, 29)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(81, 20)
        Me.LabelX9.TabIndex = 29
        Me.LabelX9.Text = "Con medidor:"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cmbMed
        '
        Me.cmbMed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMed.DisplayMember = "Text"
        Me.cmbMed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMed.FocusHighlightEnabled = True
        Me.cmbMed.FormattingEnabled = True
        Me.cmbMed.ItemHeight = 14
        Me.cmbMed.Items.AddRange(New Object() {Me.AMBOS, Me.SI, Me.NO})
        Me.cmbMed.Location = New System.Drawing.Point(545, 29)
        Me.cmbMed.Name = "cmbMed"
        Me.cmbMed.Size = New System.Drawing.Size(175, 20)
        Me.cmbMed.TabIndex = 3
        '
        'AMBOS
        '
        Me.AMBOS.Text = "AMBOS"
        '
        'SI
        '
        Me.SI.Text = "SI"
        '
        'NO
        '
        Me.NO.Text = "NO"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(8, 29)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(81, 20)
        Me.LabelX6.TabIndex = 27
        Me.LabelX6.Text = "Tarifa:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cmbTar
        '
        Me.cmbTar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTar.DisplayMember = "Text"
        Me.cmbTar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTar.FocusHighlightEnabled = True
        Me.cmbTar.FormattingEnabled = True
        Me.cmbTar.ItemHeight = 14
        Me.cmbTar.Location = New System.Drawing.Point(96, 29)
        Me.cmbTar.Name = "cmbTar"
        Me.cmbTar.Size = New System.Drawing.Size(336, 20)
        Me.cmbTar.TabIndex = 2
        '
        'cmbTUsu
        '
        Me.cmbTUsu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTUsu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTUsu.DisplayMember = "Text"
        Me.cmbTUsu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTUsu.FocusHighlightEnabled = True
        Me.cmbTUsu.FormattingEnabled = True
        Me.cmbTUsu.ItemHeight = 14
        Me.cmbTUsu.Location = New System.Drawing.Point(545, 3)
        Me.cmbTUsu.Name = "cmbTUsu"
        Me.cmbTUsu.Size = New System.Drawing.Size(175, 20)
        Me.cmbTUsu.TabIndex = 1
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(458, 3)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(81, 20)
        Me.LabelX19.TabIndex = 25
        Me.LabelX19.Text = "Tipo usuario:"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(22, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(67, 20)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Giro:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cmbGiro
        '
        Me.cmbGiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGiro.DisplayMember = "Text"
        Me.cmbGiro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGiro.FocusHighlightEnabled = True
        Me.cmbGiro.FormattingEnabled = True
        Me.cmbGiro.ItemHeight = 14
        Me.cmbGiro.Location = New System.Drawing.Point(96, 3)
        Me.cmbGiro.Name = "cmbGiro"
        Me.cmbGiro.Size = New System.Drawing.Size(364, 20)
        Me.cmbGiro.TabIndex = 0
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.LabelX11)
        Me.GroupPanel3.Controls.Add(Me.cmbCol)
        Me.GroupPanel3.Controls.Add(Me.LabelX3)
        Me.GroupPanel3.Controls.Add(Me.cmbRuta)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.cmbReg)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(12, 4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(435, 95)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 0
        Me.GroupPanel3.Text = "Ubicacion"
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(10, 49)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(46, 20)
        Me.LabelX11.TabIndex = 36
        Me.LabelX11.Text = "Colonia:"
        '
        'cmbCol
        '
        Me.cmbCol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCol.DisplayMember = "Text"
        Me.cmbCol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCol.FocusHighlightEnabled = True
        Me.cmbCol.FormattingEnabled = True
        Me.cmbCol.ItemHeight = 14
        Me.cmbCol.Location = New System.Drawing.Point(62, 49)
        Me.cmbCol.Name = "cmbCol"
        Me.cmbCol.Size = New System.Drawing.Size(336, 20)
        Me.cmbCol.TabIndex = 1
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(214, 19)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(32, 20)
        Me.LabelX3.TabIndex = 33
        Me.LabelX3.Text = "Ruta:"
        '
        'cmbRuta
        '
        Me.cmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRuta.DisplayMember = "Text"
        Me.cmbRuta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRuta.FocusHighlightEnabled = True
        Me.cmbRuta.FormattingEnabled = True
        Me.cmbRuta.ItemHeight = 14
        Me.cmbRuta.Location = New System.Drawing.Point(252, 19)
        Me.cmbRuta.Name = "cmbRuta"
        Me.cmbRuta.Size = New System.Drawing.Size(146, 20)
        Me.cmbRuta.TabIndex = 3
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 19)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(43, 20)
        Me.LabelX2.TabIndex = 32
        Me.LabelX2.Text = "Región:"
        '
        'cmbReg
        '
        Me.cmbReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReg.DisplayMember = "Text"
        Me.cmbReg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReg.FocusHighlightEnabled = True
        Me.cmbReg.FormattingEnabled = True
        Me.cmbReg.ItemHeight = 14
        Me.cmbReg.Location = New System.Drawing.Point(62, 19)
        Me.cmbReg.Name = "cmbReg"
        Me.cmbReg.Size = New System.Drawing.Size(146, 20)
        Me.cmbReg.TabIndex = 2
        '
        'cmdSalir
        '
        Me.cmdSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.Location = New System.Drawing.Point(599, 363)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.PulseSpeed = 30
        Me.cmdSalir.Size = New System.Drawing.Size(144, 39)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(447, 363)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.PulseSpeed = 30
        Me.cmdImp.Size = New System.Drawing.Size(144, 39)
        Me.cmdImp.TabIndex = 3
        Me.cmdImp.Text = "Imprimir"
        '
        'TabComuReg
        '
        Me.TabComuReg.AttachedControl = Me.TabControlPanel1
        Me.TabComuReg.Name = "TabComuReg"
        Me.TabComuReg.Text = " Región - Ruta /Colonia"
        '
        'Descuentos
        '
        Me.Descuentos.CanvasColor = System.Drawing.SystemColors.Control
        Me.Descuentos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Descuentos.Controls.Add(Me.chksindescuento)
        Me.Descuentos.Controls.Add(Me.chkcondescuento)
        Me.Descuentos.Controls.Add(Me.chktodos)
        Me.Descuentos.DisabledBackColor = System.Drawing.Color.Empty
        Me.Descuentos.Location = New System.Drawing.Point(304, 85)
        Me.Descuentos.Name = "Descuentos"
        Me.Descuentos.Size = New System.Drawing.Size(415, 69)
        '
        '
        '
        Me.Descuentos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Descuentos.Style.BackColorGradientAngle = 90
        Me.Descuentos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Descuentos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Descuentos.Style.BorderBottomWidth = 1
        Me.Descuentos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Descuentos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Descuentos.Style.BorderLeftWidth = 1
        Me.Descuentos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Descuentos.Style.BorderRightWidth = 1
        Me.Descuentos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Descuentos.Style.BorderTopWidth = 1
        Me.Descuentos.Style.CornerDiameter = 4
        Me.Descuentos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Descuentos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Descuentos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Descuentos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Descuentos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Descuentos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Descuentos.TabIndex = 40
        Me.Descuentos.Text = "Descuentos"
        '
        'chktodos
        '
        Me.chktodos.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chktodos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chktodos.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chktodos.Checked = True
        Me.chktodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chktodos.CheckValue = "Y"
        Me.chktodos.Location = New System.Drawing.Point(13, 22)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(100, 23)
        Me.chktodos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chktodos.TabIndex = 0
        Me.chktodos.Text = "Todos"
        '
        'chkcondescuento
        '
        Me.chkcondescuento.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkcondescuento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkcondescuento.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chkcondescuento.Location = New System.Drawing.Point(125, 22)
        Me.chkcondescuento.Name = "chkcondescuento"
        Me.chkcondescuento.Size = New System.Drawing.Size(100, 23)
        Me.chkcondescuento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkcondescuento.TabIndex = 1
        Me.chkcondescuento.Text = "Con descuento"
        '
        'chksindescuento
        '
        Me.chksindescuento.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chksindescuento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chksindescuento.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chksindescuento.Location = New System.Drawing.Point(257, 20)
        Me.chksindescuento.Name = "chksindescuento"
        Me.chksindescuento.Size = New System.Drawing.Size(100, 23)
        Me.chksindescuento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chksindescuento.TabIndex = 2
        Me.chksindescuento.Text = "Sin descuento"
        '
        'frmRepUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 444)
        Me.Controls.Add(Me.tabRepUsu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmRepUsu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE DE PADRÓN DE USUARIO"
        CType(Me.tabRepUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRepUsu.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel7.ResumeLayout(False)
        Me.GPFechas.ResumeLayout(False)
        Me.GPFechas.PerformLayout()
        Me.GroupPanel6.ResumeLayout(False)
        CType(Me.txtH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFec1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFec2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.Descuentos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabRepUsu As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabComuReg As DevComponents.DotNetBar.TabItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbCol As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbReg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtH As DevComponents.Editors.IntegerInput
    Friend WithEvents txtD As DevComponents.Editors.IntegerInput
    Friend WithEvents dtFec1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtFec2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblA As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblSol As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbAltCons As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents AmbosA As DevComponents.Editors.ComboItem
    Friend WithEvents siA As DevComponents.Editors.ComboItem
    Friend WithEvents noA As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbTipSer As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbMed As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents AMBOS As DevComponents.Editors.ComboItem
    Friend WithEvents SI As DevComponents.Editors.ComboItem
    Friend WithEvents NO As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbTar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbTUsu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbGiro As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GPFechas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblmen As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Chklistado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkresumen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents DTfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Descuentos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents chksindescuento As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkcondescuento As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chktodos As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
