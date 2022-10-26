<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcierrehilos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcierrehilos))
        Me.DTPeriodo = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.fec_vto = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.fecini = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.Advcomunidadregion = New DevComponents.AdvTree.AdvTree
        Me.ColumnHeader4 = New DevComponents.AdvTree.ColumnHeader
        Me.ColumnHeader5 = New DevComponents.AdvTree.ColumnHeader
        Me.ColumnHeader6 = New DevComponents.AdvTree.ColumnHeader
        Me.ColumnHeader7 = New DevComponents.AdvTree.ColumnHeader
        Me.ColumnHeader8 = New DevComponents.AdvTree.ColumnHeader
        Me.ColumnHeader9 = New DevComponents.AdvTree.ColumnHeader
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle
        Me.Advverificaciones = New DevComponents.AdvTree.AdvTree
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader
        Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader
        Me.ColumnHeader3 = New DevComponents.AdvTree.ColumnHeader
        Me.Node2 = New DevComponents.AdvTree.Node
        Me.Cell3 = New DevComponents.AdvTree.Cell
        Me.Cell5 = New DevComponents.AdvTree.Cell
        Me.Temporal = New DevComponents.AdvTree.Node
        Me.Cell7 = New DevComponents.AdvTree.Cell
        Me.Cell9 = New DevComponents.AdvTree.Cell
        Me.Node1 = New DevComponents.AdvTree.Node
        Me.Cell11 = New DevComponents.AdvTree.Cell
        Me.Cell12 = New DevComponents.AdvTree.Cell
        Me.calculodeconsumo = New DevComponents.AdvTree.Node
        Me.Cell13 = New DevComponents.AdvTree.Cell
        Me.Cell14 = New DevComponents.AdvTree.Cell
        Me.cerrado = New DevComponents.AdvTree.Node
        Me.Cell15 = New DevComponents.AdvTree.Cell
        Me.Cell16 = New DevComponents.AdvTree.Cell
        Me.NodeConnector3 = New DevComponents.AdvTree.NodeConnector
        Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle
        Me.Cell1 = New DevComponents.AdvTree.Cell
        Me.Cell2 = New DevComponents.AdvTree.Cell
        Me.Creadotem = New DevComponents.AdvTree.Cell
        Me.Cell4 = New DevComponents.AdvTree.Cell
        Me.Captura = New DevComponents.AdvTree.Cell
        Me.Cell6 = New DevComponents.AdvTree.Cell
        Me.calculo = New DevComponents.AdvTree.Cell
        Me.Cell8 = New DevComponents.AdvTree.Cell
        Me.cierre = New DevComponents.AdvTree.Cell
        Me.Cell10 = New DevComponents.AdvTree.Cell
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtestado2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtestado1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.BTNCREARTEMPORAL = New System.Windows.Forms.Button
        Me.btningnorar = New System.Windows.Forms.Button
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.PB = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.Bllcierre = New DevComponents.DotNetBar.BalloonTip
        Me.PBC = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.btncerrar = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GpFCierre = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbReg = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmbCom = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdIni = New DevComponents.DotNetBar.ButtonX
        CType(Me.DTPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fec_vto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Advcomunidadregion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Advverificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpFCierre.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTPeriodo
        '
        Me.DTPeriodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.DTPeriodo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTPeriodo.ButtonDropDown.Visible = True
        Me.DTPeriodo.CustomFormat = "MMM - yyyy"
        Me.DTPeriodo.FocusHighlightEnabled = True
        Me.DTPeriodo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.DTPeriodo.Location = New System.Drawing.Point(780, 71)
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTPeriodo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTPeriodo.MonthCalendar.DisplayMonth = New Date(2009, 3, 1, 0, 0, 0, 0)
        Me.DTPeriodo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTPeriodo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTPeriodo.MonthCalendar.TodayButtonVisible = True
        Me.DTPeriodo.Name = "DTPeriodo"
        Me.DTPeriodo.Size = New System.Drawing.Size(200, 20)
        Me.DTPeriodo.TabIndex = 20
        '
        'fec_vto
        '
        Me.fec_vto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.fec_vto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fec_vto.ButtonDropDown.Visible = True
        Me.fec_vto.CustomFormat = "dd - MMM - yyyy"
        Me.fec_vto.FocusHighlightEnabled = True
        Me.fec_vto.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.fec_vto.Location = New System.Drawing.Point(780, 45)
        '
        '
        '
        Me.fec_vto.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fec_vto.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fec_vto.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fec_vto.MonthCalendar.DisplayMonth = New Date(2009, 2, 1, 0, 0, 0, 0)
        Me.fec_vto.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fec_vto.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fec_vto.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fec_vto.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fec_vto.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fec_vto.MonthCalendar.TodayButtonVisible = True
        Me.fec_vto.Name = "fec_vto"
        Me.fec_vto.Size = New System.Drawing.Size(200, 20)
        Me.fec_vto.TabIndex = 18
        '
        'fecini
        '
        Me.fecini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.fecini.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fecini.ButtonDropDown.Visible = True
        Me.fecini.CustomFormat = "dd - MMM - yyyy"
        Me.fecini.FocusHighlightEnabled = True
        Me.fecini.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.fecini.Location = New System.Drawing.Point(780, 19)
        '
        '
        '
        Me.fecini.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecini.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fecini.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fecini.MonthCalendar.DisplayMonth = New Date(2009, 2, 1, 0, 0, 0, 0)
        Me.fecini.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fecini.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecini.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fecini.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fecini.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fecini.MonthCalendar.TodayButtonVisible = True
        Me.fecini.Name = "fecini"
        Me.fecini.Size = New System.Drawing.Size(200, 20)
        Me.fecini.TabIndex = 16
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX1.Location = New System.Drawing.Point(667, 71)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(96, 19)
        Me.LabelX1.TabIndex = 19
        Me.LabelX1.Text = "Periodo a  cerrar"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX3.Location = New System.Drawing.Point(640, 19)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(123, 18)
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "Fecha de Aplicación"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX2.Location = New System.Drawing.Point(650, 43)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(113, 18)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "Fecha de vencimiento"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Advcomunidadregion
        '
        Me.Advcomunidadregion.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.Advcomunidadregion.AllowDrop = True
        Me.Advcomunidadregion.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Advcomunidadregion.BackgroundStyle.Class = "TreeBorderKey"
        Me.Bllcierre.SetBalloonCaption(Me.Advcomunidadregion, Nothing)
        Me.Bllcierre.SetBalloonText(Me.Advcomunidadregion, "Selecciona la region y arrastra")
        Me.Advcomunidadregion.Columns.Add(Me.ColumnHeader4)
        Me.Advcomunidadregion.Columns.Add(Me.ColumnHeader5)
        Me.Advcomunidadregion.Columns.Add(Me.ColumnHeader6)
        Me.Advcomunidadregion.Columns.Add(Me.ColumnHeader7)
        Me.Advcomunidadregion.Columns.Add(Me.ColumnHeader8)
        Me.Advcomunidadregion.Columns.Add(Me.ColumnHeader9)
        Me.Advcomunidadregion.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Advcomunidadregion.Location = New System.Drawing.Point(170, 129)
        Me.Advcomunidadregion.Name = "Advcomunidadregion"
        Me.Advcomunidadregion.NodesConnector = Me.NodeConnector1
        Me.Advcomunidadregion.NodeStyle = Me.ElementStyle1
        Me.Advcomunidadregion.PathSeparator = ";"
        Me.Advcomunidadregion.Size = New System.Drawing.Size(592, 282)
        Me.Advcomunidadregion.Styles.Add(Me.ElementStyle1)
        Me.Advcomunidadregion.SuspendPaint = False
        Me.Advcomunidadregion.TabIndex = 21
        Me.Advcomunidadregion.Text = "AdvTree1"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Name = "ColumnHeader4"
        Me.ColumnHeader4.Text = "Comunidad"
        Me.ColumnHeader4.Width.Absolute = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Name = "ColumnHeader5"
        Me.ColumnHeader5.Text = "Región"
        Me.ColumnHeader5.Width.Absolute = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Name = "ColumnHeader6"
        Me.ColumnHeader6.Text = "Ruta"
        Me.ColumnHeader6.Width.Absolute = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Name = "ColumnHeader7"
        Me.ColumnHeader7.Text = "IDCOMUNIDAD"
        Me.ColumnHeader7.Visible = False
        Me.ColumnHeader7.Width.Absolute = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Name = "ColumnHeader8"
        Me.ColumnHeader8.Text = "IDREGION"
        Me.ColumnHeader8.Visible = False
        Me.ColumnHeader8.Width.Absolute = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Name = "ColumnHeader9"
        Me.ColumnHeader9.Text = "IDRUTA"
        Me.ColumnHeader9.Visible = False
        Me.ColumnHeader9.Width.Absolute = 150
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle1
        '
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'Advverificaciones
        '
        Me.Advverificaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.Advverificaciones.AllowDrop = True
        Me.Advverificaciones.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Advverificaciones.BackgroundStyle.Class = "TreeBorderKey"
        Me.Advverificaciones.Columns.Add(Me.ColumnHeader1)
        Me.Advverificaciones.Columns.Add(Me.ColumnHeader2)
        Me.Advverificaciones.Columns.Add(Me.ColumnHeader3)
        Me.Advverificaciones.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Advverificaciones.Location = New System.Drawing.Point(768, 132)
        Me.Advverificaciones.Name = "Advverificaciones"
        Me.Advverificaciones.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node2, Me.Temporal, Me.Node1, Me.calculodeconsumo, Me.cerrado})
        Me.Advverificaciones.NodesConnector = Me.NodeConnector3
        Me.Advverificaciones.NodeStyle = Me.ElementStyle3
        Me.Advverificaciones.PathSeparator = ";"
        Me.Advverificaciones.Size = New System.Drawing.Size(292, 125)
        Me.Advverificaciones.Styles.Add(Me.ElementStyle3)
        Me.Advverificaciones.SuspendPaint = False
        Me.Advverificaciones.TabIndex = 23
        Me.Advverificaciones.Text = "AdvTree3"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Proceso"
        Me.ColumnHeader1.Width.Absolute = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Name = "ColumnHeader2"
        Me.ColumnHeader2.Text = "Verificación"
        Me.ColumnHeader2.Width.Absolute = 60
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Name = "ColumnHeader3"
        Me.ColumnHeader3.Text = "Acción"
        Me.ColumnHeader3.Width.Absolute = 70
        '
        'Node2
        '
        Me.Node2.Cells.Add(Me.Cell3)
        Me.Node2.Cells.Add(Me.Cell5)
        Me.Node2.Expanded = True
        Me.Node2.Name = "Node2"
        Me.Node2.Text = "Reporte toma lect."
        '
        'Cell3
        '
        Me.Cell3.Name = "Cell3"
        Me.Cell3.StyleMouseOver = Nothing
        '
        'Cell5
        '
        Me.Cell5.Name = "Cell5"
        Me.Cell5.StyleMouseOver = Nothing
        '
        'Temporal
        '
        Me.Temporal.Cells.Add(Me.Cell7)
        Me.Temporal.Cells.Add(Me.Cell9)
        Me.Temporal.Expanded = True
        Me.Temporal.Name = "Temporal"
        Me.Temporal.Text = "Creado el temporal"
        '
        'Cell7
        '
        Me.Cell7.Name = "Cell7"
        Me.Cell7.StyleMouseOver = Nothing
        '
        'Cell9
        '
        Me.Cell9.Name = "Cell9"
        Me.Cell9.StyleMouseOver = Nothing
        '
        'Node1
        '
        Me.Node1.Cells.Add(Me.Cell11)
        Me.Node1.Cells.Add(Me.Cell12)
        Me.Node1.Expanded = True
        Me.Node1.Name = "Node1"
        Me.Node1.Text = "Captura de lecturas"
        '
        'Cell11
        '
        Me.Cell11.Name = "Cell11"
        Me.Cell11.StyleMouseOver = Nothing
        '
        'Cell12
        '
        Me.Cell12.Name = "Cell12"
        Me.Cell12.StyleMouseOver = Nothing
        '
        'calculodeconsumo
        '
        Me.calculodeconsumo.Cells.Add(Me.Cell13)
        Me.calculodeconsumo.Cells.Add(Me.Cell14)
        Me.calculodeconsumo.Expanded = True
        Me.calculodeconsumo.Name = "calculodeconsumo"
        Me.calculodeconsumo.Text = "Calculo de consumo"
        '
        'Cell13
        '
        Me.Cell13.Name = "Cell13"
        Me.Cell13.StyleMouseOver = Nothing
        '
        'Cell14
        '
        Me.Cell14.Name = "Cell14"
        Me.Cell14.StyleMouseOver = Nothing
        '
        'cerrado
        '
        Me.cerrado.Cells.Add(Me.Cell15)
        Me.cerrado.Cells.Add(Me.Cell16)
        Me.cerrado.Expanded = True
        Me.cerrado.Name = "cerrado"
        Me.cerrado.Text = "Cierre"
        '
        'Cell15
        '
        Me.Cell15.Name = "Cell15"
        Me.Cell15.StyleMouseOver = Nothing
        '
        'Cell16
        '
        Me.Cell16.Name = "Cell16"
        Me.Cell16.StyleMouseOver = Nothing
        '
        'NodeConnector3
        '
        Me.NodeConnector3.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle3
        '
        Me.ElementStyle3.Name = "ElementStyle3"
        Me.ElementStyle3.TextColor = System.Drawing.SystemColors.ControlText
        '
        'Cell1
        '
        Me.Cell1.Name = "Cell1"
        Me.Cell1.StyleMouseOver = Nothing
        '
        'Cell2
        '
        Me.Cell2.Name = "Cell2"
        Me.Cell2.StyleMouseOver = Nothing
        '
        'Creadotem
        '
        Me.Creadotem.Name = "Creadotem"
        Me.Creadotem.StyleMouseOver = Nothing
        '
        'Cell4
        '
        Me.Cell4.Name = "Cell4"
        Me.Cell4.StyleMouseOver = Nothing
        '
        'Captura
        '
        Me.Captura.Name = "Captura"
        Me.Captura.StyleMouseOver = Nothing
        '
        'Cell6
        '
        Me.Cell6.Name = "Cell6"
        Me.Cell6.StyleMouseOver = Nothing
        '
        'calculo
        '
        Me.calculo.Name = "calculo"
        Me.calculo.StyleMouseOver = Nothing
        '
        'Cell8
        '
        Me.Cell8.Name = "Cell8"
        Me.Cell8.StyleMouseOver = Nothing
        '
        'cierre
        '
        Me.cierre.Name = "cierre"
        Me.cierre.StyleMouseOver = Nothing
        '
        'Cell10
        '
        Me.Cell10.Name = "Cell10"
        Me.Cell10.StyleMouseOver = Nothing
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Location = New System.Drawing.Point(170, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(430, 101)
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
        Me.GroupPanel1.TabIndex = 26
        Me.GroupPanel1.Text = "Atención"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(31, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(370, 75)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = resources.GetString("LabelX4.Text")
        '
        'txtestado2
        '
        '
        '
        '
        Me.txtestado2.Border.Class = "TextBoxBorder"
        Me.txtestado2.Location = New System.Drawing.Point(768, 282)
        Me.txtestado2.Name = "txtestado2"
        Me.txtestado2.Size = New System.Drawing.Size(292, 20)
        Me.txtestado2.TabIndex = 25
        '
        'txtestado1
        '
        '
        '
        '
        Me.txtestado1.Border.Class = "TextBoxBorder"
        Me.txtestado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestado1.Location = New System.Drawing.Point(768, 263)
        Me.txtestado1.Name = "txtestado1"
        Me.txtestado1.Size = New System.Drawing.Size(292, 23)
        Me.txtestado1.TabIndex = 24
        '
        'BTNCREARTEMPORAL
        '
        Me.BTNCREARTEMPORAL.Location = New System.Drawing.Point(969, 36)
        Me.BTNCREARTEMPORAL.Name = "BTNCREARTEMPORAL"
        Me.BTNCREARTEMPORAL.Size = New System.Drawing.Size(61, 20)
        Me.BTNCREARTEMPORAL.TabIndex = 27
        Me.BTNCREARTEMPORAL.Text = "Crear"
        Me.BTNCREARTEMPORAL.UseVisualStyleBackColor = True
        Me.BTNCREARTEMPORAL.Visible = False
        '
        'btningnorar
        '
        Me.btningnorar.Location = New System.Drawing.Point(969, 60)
        Me.btningnorar.Name = "btningnorar"
        Me.btningnorar.Size = New System.Drawing.Size(61, 20)
        Me.btningnorar.TabIndex = 28
        Me.btningnorar.Text = "Ignorar"
        Me.btningnorar.UseVisualStyleBackColor = True
        Me.btningnorar.Visible = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(969, 86)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(61, 20)
        Me.btnCalcular.TabIndex = 29
        Me.btnCalcular.Text = "Hacer"
        Me.btnCalcular.UseVisualStyleBackColor = True
        Me.btnCalcular.Visible = False
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(974, 112)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(56, 17)
        Me.PB.TabIndex = 30
        Me.PB.Text = "ProgressBarX1"
        Me.PB.Visible = False
        '
        'PBC
        '
        Me.PBC.Location = New System.Drawing.Point(170, 407)
        Me.PBC.Name = "PBC"
        Me.PBC.Size = New System.Drawing.Size(592, 48)
        Me.PBC.TabIndex = 32
        Me.PBC.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncerrar.Location = New System.Drawing.Point(768, 308)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(78, 20)
        Me.btncerrar.TabIndex = 33
        Me.btncerrar.Text = "Comenzar"
        Me.btncerrar.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(170, 461)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(144, 26)
        Me.ButtonX1.TabIndex = 34
        Me.ButtonX1.Text = "Iniciar variables de cierre"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AcquaLiberVista.My.Resources.Resources.soledad
        Me.PictureBox1.Location = New System.Drawing.Point(3, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 378)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.AcquaLiberVista.My.Resources.Resources.grafica
        Me.PictureBox2.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 101)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'GpFCierre
        '
        Me.GpFCierre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.GpFCierre.Controls.Add(Me.Label3)
        Me.GpFCierre.Controls.Add(Me.Label2)
        Me.GpFCierre.Controls.Add(Me.cmbReg)
        Me.GpFCierre.Controls.Add(Me.cmbCom)
        Me.GpFCierre.Controls.Add(Me.Label1)
        Me.GpFCierre.Controls.Add(Me.cmdIni)
        Me.GpFCierre.Location = New System.Drawing.Point(768, 334)
        Me.GpFCierre.Name = "GpFCierre"
        Me.GpFCierre.Size = New System.Drawing.Size(280, 163)
        Me.GpFCierre.TabIndex = 41
        Me.GpFCierre.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Region"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Comunidad"
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
        Me.cmbReg.Location = New System.Drawing.Point(85, 112)
        Me.cmbReg.Name = "cmbReg"
        Me.cmbReg.Size = New System.Drawing.Size(153, 20)
        Me.cmbReg.TabIndex = 1
        '
        'cmbCom
        '
        Me.cmbCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCom.DisplayMember = "Text"
        Me.cmbCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCom.FocusHighlightEnabled = True
        Me.cmbCom.FormattingEnabled = True
        Me.cmbCom.ItemHeight = 14
        Me.cmbCom.Location = New System.Drawing.Point(85, 84)
        Me.cmbCom.Name = "cmbCom"
        Me.cmbCom.Size = New System.Drawing.Size(153, 20)
        Me.cmbCom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 65)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'cmdIni
        '
        Me.cmdIni.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdIni.BackColor = System.Drawing.Color.Red
        Me.cmdIni.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdIni.Location = New System.Drawing.Point(141, 137)
        Me.cmdIni.Name = "cmdIni"
        Me.cmdIni.PulseSpeed = 30
        Me.cmdIni.Size = New System.Drawing.Size(97, 20)
        Me.cmdIni.TabIndex = 2
        Me.cmdIni.Text = "Iniciar"
        '
        'frmcierrehilos
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 499)
        Me.Controls.Add(Me.GpFCierre)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.PBC)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btningnorar)
        Me.Controls.Add(Me.BTNCREARTEMPORAL)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.txtestado2)
        Me.Controls.Add(Me.txtestado1)
        Me.Controls.Add(Me.Advverificaciones)
        Me.Controls.Add(Me.Advcomunidadregion)
        Me.Controls.Add(Me.DTPeriodo)
        Me.Controls.Add(Me.fec_vto)
        Me.Controls.Add(Me.fecini)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.KeyPreview = True
        Me.Name = "frmcierrehilos"
        Me.Text = "Cierre"
        CType(Me.DTPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fec_vto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Advcomunidadregion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Advverificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpFCierre.ResumeLayout(False)
        Me.GpFCierre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPeriodo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents fec_vto As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents fecini As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Advcomunidadregion As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents Advverificaciones As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector3 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents Temporal As DevComponents.AdvTree.Node
    Friend WithEvents ColumnHeader3 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents calculodeconsumo As DevComponents.AdvTree.Node
    Friend WithEvents cerrado As DevComponents.AdvTree.Node
    Friend WithEvents ColumnHeader4 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColumnHeader5 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents Node2 As DevComponents.AdvTree.Node
    Friend WithEvents ColumnHeader6 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader7 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader8 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents Cell1 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell2 As DevComponents.AdvTree.Cell
    Friend WithEvents Creadotem As DevComponents.AdvTree.Cell
    Friend WithEvents Cell4 As DevComponents.AdvTree.Cell
    Friend WithEvents Captura As DevComponents.AdvTree.Cell
    Friend WithEvents Cell6 As DevComponents.AdvTree.Cell
    Friend WithEvents calculo As DevComponents.AdvTree.Cell
    Friend WithEvents Cell8 As DevComponents.AdvTree.Cell
    Friend WithEvents cierre As DevComponents.AdvTree.Cell
    Friend WithEvents Cell10 As DevComponents.AdvTree.Cell
    Friend WithEvents txtestado2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtestado1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BTNCREARTEMPORAL As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader9 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents btningnorar As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents PB As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Bllcierre As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents Cell3 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell5 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell7 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell9 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell11 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell12 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell13 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell14 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell15 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell16 As DevComponents.AdvTree.Cell
    Friend WithEvents PBC As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents btncerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GpFCierre As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbReg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbCom As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdIni As DevComponents.DotNetBar.ButtonX
End Class
