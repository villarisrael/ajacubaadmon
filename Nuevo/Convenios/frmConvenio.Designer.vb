Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConvenio
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alcantarillado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saneamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Otros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.cbnoperiodos = New System.Windows.Forms.ComboBox()
        Me.iiprimerpago = New DevComponents.Editors.DoubleInput()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.dataConv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.gpDatCont = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.btnEditar = New DevComponents.DotNetBar.ButtonX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.cuentaAnte = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Comunidad = New System.Windows.Forms.Label()
        Me.Colonia = New System.Windows.Forms.Label()
        Me.Domicilio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nuevoadeudo = New System.Windows.Forms.Label()
        Me.descuento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cuentatxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.btnExaminar = New DevComponents.DotNetBar.ButtonX()
        Me.TxtTel = New System.Windows.Forms.MaskedTextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New DevComponents.DotNetBar.ButtonX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fecha = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.Buttoncerrar = New DevComponents.DotNetBar.ButtonX()
        Me.ToolBar = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.iiprimerpago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataConv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatCont.SuspendLayout()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.Controls.Add(Me.SuperTabControl1)
        Me.TabControlPanel1.Controls.Add(Me.Buttoncerrar)
        Me.TabControlPanel1.Controls.Add(Me.ToolBar)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1117, 761)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Location = New System.Drawing.Point(12, 65)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(1069, 594)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 132
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.DataGridViewX1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1069, 569)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mes, Me.Periodo, Me.Consumo, Me.Alcantarillado, Me.Saneamiento, Me.Recargos, Me.Otros, Me.Total1, Me.IVA})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(972, 454)
        Me.DataGridViewX1.TabIndex = 1
        '
        'Mes
        '
        Me.Mes.HeaderText = "Mes"
        Me.Mes.Name = "Mes"
        '
        'Periodo
        '
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        '
        'Consumo
        '
        Me.Consumo.HeaderText = "Consumo"
        Me.Consumo.Name = "Consumo"
        '
        'Alcantarillado
        '
        Me.Alcantarillado.HeaderText = "Alcantarillado"
        Me.Alcantarillado.Name = "Alcantarillado"
        '
        'Saneamiento
        '
        Me.Saneamiento.HeaderText = "Saneamiento"
        Me.Saneamiento.Name = "Saneamiento"
        '
        'Recargos
        '
        Me.Recargos.HeaderText = "Recargos"
        Me.Recargos.Name = "Recargos"
        '
        'Otros
        '
        Me.Otros.HeaderText = "Otros"
        Me.Otros.Name = "Otros"
        '
        'Total1
        '
        Me.Total1.HeaderText = "Total"
        Me.Total1.Name = "Total1"
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Deuda"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.cbnoperiodos)
        Me.SuperTabControlPanel1.Controls.Add(Me.iiprimerpago)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label10)
        Me.SuperTabControlPanel1.Controls.Add(Me.LabelX1)
        Me.SuperTabControlPanel1.Controls.Add(Me.ButtonX6)
        Me.SuperTabControlPanel1.Controls.Add(Me.ButtonX1)
        Me.SuperTabControlPanel1.Controls.Add(Me.dataConv)
        Me.SuperTabControlPanel1.Controls.Add(Me.gpDatCont)
        Me.SuperTabControlPanel1.Controls.Add(Me.BtnCalcular)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label5)
        Me.SuperTabControlPanel1.Controls.Add(Me.fecha)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label6)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1069, 569)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'cbnoperiodos
        '
        Me.cbnoperiodos.FormattingEnabled = True
        Me.cbnoperiodos.Location = New System.Drawing.Point(234, 307)
        Me.cbnoperiodos.Name = "cbnoperiodos"
        Me.cbnoperiodos.Size = New System.Drawing.Size(79, 21)
        Me.cbnoperiodos.TabIndex = 148
        '
        'iiprimerpago
        '
        '
        '
        '
        Me.iiprimerpago.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.iiprimerpago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.iiprimerpago.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.iiprimerpago.Increment = 1.0R
        Me.iiprimerpago.Location = New System.Drawing.Point(234, 344)
        Me.iiprimerpago.Name = "iiprimerpago"
        Me.iiprimerpago.ShowUpDown = True
        Me.iiprimerpago.Size = New System.Drawing.Size(82, 20)
        Me.iiprimerpago.TabIndex = 147
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(130, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 24)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "1 er pago:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(27, 302)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(97, 23)
        Me.LabelX1.TabIndex = 145
        Me.LabelX1.Text = "Pagos......"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.ButtonX6.Location = New System.Drawing.Point(781, 293)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(133, 39)
        Me.ButtonX6.TabIndex = 144
        Me.ButtonX6.Text = "Cancelar convenio"
        Me.ButtonX6.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Administativo.My.Resources.Resources.apply
        Me.ButtonX1.Location = New System.Drawing.Point(770, 371)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(165, 39)
        Me.ButtonX1.TabIndex = 143
        Me.ButtonX1.Text = "Confirmar convenio"
        '
        'dataConv
        '
        Me.dataConv.AllowUserToAddRows = False
        Me.dataConv.AllowUserToDeleteRows = False
        Me.dataConv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dataConv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataConv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataConv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataConv.Location = New System.Drawing.Point(22, 371)
        Me.dataConv.Name = "dataConv"
        Me.dataConv.ReadOnly = True
        Me.dataConv.Size = New System.Drawing.Size(742, 179)
        Me.dataConv.TabIndex = 142
        '
        'gpDatCont
        '
        Me.gpDatCont.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatCont.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatCont.Controls.Add(Me.RadTextBox1)
        Me.gpDatCont.Controls.Add(Me.btnEditar)
        Me.gpDatCont.Controls.Add(Me.Label9)
        Me.gpDatCont.Controls.Add(Me.ButtonX5)
        Me.gpDatCont.Controls.Add(Me.cuentaAnte)
        Me.gpDatCont.Controls.Add(Me.Label8)
        Me.gpDatCont.Controls.Add(Me.Comunidad)
        Me.gpDatCont.Controls.Add(Me.Colonia)
        Me.gpDatCont.Controls.Add(Me.Domicilio)
        Me.gpDatCont.Controls.Add(Me.Label7)
        Me.gpDatCont.Controls.Add(Me.nuevoadeudo)
        Me.gpDatCont.Controls.Add(Me.descuento)
        Me.gpDatCont.Controls.Add(Me.Label3)
        Me.gpDatCont.Controls.Add(Me.Label1)
        Me.gpDatCont.Controls.Add(Me.cuentatxt)
        Me.gpDatCont.Controls.Add(Me.total)
        Me.gpDatCont.Controls.Add(Me.Label2)
        Me.gpDatCont.Controls.Add(Me.nombre)
        Me.gpDatCont.Controls.Add(Me.btnExaminar)
        Me.gpDatCont.Controls.Add(Me.TxtTel)
        Me.gpDatCont.Controls.Add(Me.LblTelefono)
        Me.gpDatCont.Controls.Add(Me.lblnombre)
        Me.gpDatCont.Controls.Add(Me.Label4)
        Me.gpDatCont.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatCont.Location = New System.Drawing.Point(22, 14)
        Me.gpDatCont.Name = "gpDatCont"
        Me.gpDatCont.Size = New System.Drawing.Size(901, 269)
        '
        '
        '
        Me.gpDatCont.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatCont.Style.BackColorGradientAngle = 90
        Me.gpDatCont.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatCont.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatCont.Style.BorderBottomWidth = 1
        Me.gpDatCont.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatCont.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatCont.Style.BorderLeftWidth = 1
        Me.gpDatCont.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatCont.Style.BorderRightWidth = 1
        Me.gpDatCont.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatCont.Style.BorderTopWidth = 1
        Me.gpDatCont.Style.CornerDiameter = 4
        Me.gpDatCont.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatCont.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatCont.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatCont.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatCont.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatCont.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatCont.TabIndex = 137
        Me.gpDatCont.Text = "Datos del convenio"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.BackColor = System.Drawing.Color.DarkGray
        Me.RadTextBox1.Location = New System.Drawing.Point(513, 122)
        Me.RadTextBox1.MinimumSize = New System.Drawing.Size(0, 60)
        Me.RadTextBox1.Multiline = True
        Me.RadTextBox1.Name = "RadTextBox1"
        '
        '
        '
        Me.RadTextBox1.RootElement.MinSize = New System.Drawing.Size(0, 60)
        Me.RadTextBox1.Size = New System.Drawing.Size(186, 60)
        Me.RadTextBox1.TabIndex = 95
        Me.RadTextBox1.TabStop = False
        Me.RadTextBox1.Text = "Presiona el Boton de descuento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Escribe el monto del descuento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " y presiona enter" &
    ", aun  siendo 0." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al finalizar presiona Guardar"
        Me.RadTextBox1.ThemeName = "ControlDefault"
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(249, 168)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(42, 23)
        Me.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEditar.TabIndex = 94
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(727, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 20)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "%"
        Me.Label9.Visible = False
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX5.Image = Global.Administativo.My.Resources.Resources.calc
        Me.ButtonX5.Location = New System.Drawing.Point(756, 39)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(119, 38)
        Me.ButtonX5.TabIndex = 92
        Me.ButtonX5.Text = "Descuento"
        Me.ButtonX5.Visible = False
        '
        'cuentaAnte
        '
        '
        '
        '
        Me.cuentaAnte.Border.Class = "TextBoxBorder"
        Me.cuentaAnte.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cuentaAnte.Location = New System.Drawing.Point(249, 9)
        Me.cuentaAnte.Name = "cuentaAnte"
        Me.cuentaAnte.PreventEnterBeep = True
        Me.cuentaAnte.Size = New System.Drawing.Size(83, 20)
        Me.cuentaAnte.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(163, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Clave del predio:"
        '
        'Comunidad
        '
        Me.Comunidad.AutoSize = True
        Me.Comunidad.BackColor = System.Drawing.Color.Transparent
        Me.Comunidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comunidad.ForeColor = System.Drawing.Color.Black
        Me.Comunidad.Location = New System.Drawing.Point(93, 122)
        Me.Comunidad.Name = "Comunidad"
        Me.Comunidad.Size = New System.Drawing.Size(0, 20)
        Me.Comunidad.TabIndex = 89
        '
        'Colonia
        '
        Me.Colonia.AutoSize = True
        Me.Colonia.BackColor = System.Drawing.Color.Transparent
        Me.Colonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colonia.ForeColor = System.Drawing.Color.Black
        Me.Colonia.Location = New System.Drawing.Point(93, 94)
        Me.Colonia.Name = "Colonia"
        Me.Colonia.Size = New System.Drawing.Size(0, 20)
        Me.Colonia.TabIndex = 88
        '
        'Domicilio
        '
        Me.Domicilio.AutoSize = True
        Me.Domicilio.BackColor = System.Drawing.Color.Transparent
        Me.Domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Domicilio.ForeColor = System.Drawing.Color.Black
        Me.Domicilio.Location = New System.Drawing.Point(93, 67)
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Size = New System.Drawing.Size(0, 20)
        Me.Domicilio.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(5, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Domicilio:"
        '
        'nuevoadeudo
        '
        Me.nuevoadeudo.AutoSize = True
        Me.nuevoadeudo.BackColor = System.Drawing.Color.Transparent
        Me.nuevoadeudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoadeudo.Location = New System.Drawing.Point(677, 94)
        Me.nuevoadeudo.Name = "nuevoadeudo"
        Me.nuevoadeudo.Size = New System.Drawing.Size(18, 20)
        Me.nuevoadeudo.TabIndex = 84
        Me.nuevoadeudo.Text = "0"
        '
        'descuento
        '
        '
        '
        '
        Me.descuento.Border.Class = "TextBoxBorder"
        Me.descuento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descuento.Location = New System.Drawing.Point(681, 64)
        Me.descuento.Name = "descuento"
        Me.descuento.PreventEnterBeep = True
        Me.descuento.Size = New System.Drawing.Size(47, 26)
        Me.descuento.TabIndex = 83
        Me.descuento.Text = "0"
        Me.descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.descuento.Visible = False
        Me.descuento.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(509, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Adeudo negociado:..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(509, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Descuento: ...."
        Me.Label1.Visible = False
        '
        'cuentatxt
        '
        '
        '
        '
        Me.cuentatxt.Border.Class = "TextBoxBorder"
        Me.cuentatxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cuentatxt.Location = New System.Drawing.Point(66, 10)
        Me.cuentatxt.Name = "cuentatxt"
        Me.cuentatxt.PreventEnterBeep = True
        Me.cuentatxt.Size = New System.Drawing.Size(83, 20)
        Me.cuentatxt.TabIndex = 76
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.BackColor = System.Drawing.Color.Transparent
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(681, 40)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(18, 20)
        Me.total.TabIndex = 68
        Me.total.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(509, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Adeudo: ......."
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.BackColor = System.Drawing.Color.Transparent
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(63, 39)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(0, 20)
        Me.nombre.TabIndex = 66
        '
        'btnExaminar
        '
        Me.btnExaminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExaminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExaminar.Image = Global.Administativo.My.Resources.Resources.Buscar
        Me.btnExaminar.Location = New System.Drawing.Point(351, 5)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(83, 25)
        Me.btnExaminar.TabIndex = 65
        Me.btnExaminar.Text = "Buscar"
        '
        'TxtTel
        '
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(117, 168)
        Me.TxtTel.Mask = "(###)-###-####"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(126, 26)
        Me.TxtTel.TabIndex = 8
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.ForeColor = System.Drawing.Color.Red
        Me.LblTelefono.Location = New System.Drawing.Point(10, 168)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.LblTelefono.TabIndex = 8
        Me.LblTelefono.Text = "Telefono:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.Black
        Me.lblnombre.Location = New System.Drawing.Point(3, 39)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(56, 20)
        Me.lblnombre.TabIndex = 6
        Me.lblnombre.Text = "Titular:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(-1, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cuenta No."
        '
        'BtnCalcular
        '
        Me.BtnCalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCalcular.Image = Global.Administativo.My.Resources.Resources.calc
        Me.BtnCalcular.Location = New System.Drawing.Point(622, 293)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(142, 38)
        Me.BtnCalcular.TabIndex = 141
        Me.BtnCalcular.Text = "Calcular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(130, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 24)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "No. Pagos:"
        '
        'fecha
        '
        '
        '
        '
        Me.fecha.Border.Class = "TextBoxBorder"
        Me.fecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(524, 300)
        Me.fecha.Name = "fecha"
        Me.fecha.PreventEnterBeep = True
        Me.fecha.Size = New System.Drawing.Size(82, 29)
        Me.fecha.TabIndex = 140
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 24)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Días de aplazamiento:"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Convenio"
        '
        'Buttoncerrar
        '
        Me.Buttoncerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttoncerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttoncerrar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.Buttoncerrar.Location = New System.Drawing.Point(916, 665)
        Me.Buttoncerrar.Name = "Buttoncerrar"
        Me.Buttoncerrar.Size = New System.Drawing.Size(165, 39)
        Me.Buttoncerrar.TabIndex = 131
        Me.Buttoncerrar.Text = "Cerrar"
        '
        'ToolBar
        '
        Me.ToolBar.CanvasColor = System.Drawing.SystemColors.Control
        Me.ToolBar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ToolBar.Controls.Add(Me.ButtonX4)
        Me.ToolBar.Controls.Add(Me.cmdCancel)
        Me.ToolBar.Controls.Add(Me.ButtonX3)
        Me.ToolBar.DisabledBackColor = System.Drawing.Color.Empty
        Me.ToolBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolBar.Location = New System.Drawing.Point(1, 1)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(1115, 58)
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
        Me.ToolBar.TabIndex = 129
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.ButtonX4.Location = New System.Drawing.Point(136, 7)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.PulseSpeed = 30
        Me.ButtonX4.Size = New System.Drawing.Size(103, 39)
        Me.ButtonX4.TabIndex = 129
        Me.ButtonX4.Text = "Imprimir"
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCancel.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdCancel.Location = New System.Drawing.Point(257, 7)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.PulseSpeed = 30
        Me.cmdCancel.Size = New System.Drawing.Size(103, 39)
        Me.cmdCancel.TabIndex = 128
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.Visible = False
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.ButtonX3.Location = New System.Drawing.Point(8, 7)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(109, 39)
        Me.ButtonX3.TabIndex = 127
        Me.ButtonX3.Text = "Guardar"
        '
        'frmConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 761)
        Me.Controls.Add(Me.TabControlPanel1)
        Me.Name = "frmConvenio"
        Me.Text = "Convenios"
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        CType(Me.iiprimerpago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataConv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatCont.ResumeLayout(False)
        Me.gpDatCont.PerformLayout()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents TabControlPanel1 As TabControlPanel
    Private WithEvents ButtonX3 As ButtonX
    Private WithEvents ToolBar As Controls.GroupPanel
    Friend WithEvents cmdCancel As ButtonX
    Friend WithEvents Buttoncerrar As ButtonX
    Friend WithEvents ButtonX4 As ButtonX
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents SuperTabControl1 As SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As SuperTabControlPanel
    Friend WithEvents cbnoperiodos As ComboBox
    Friend WithEvents iiprimerpago As DevComponents.Editors.DoubleInput
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelX1 As LabelX
    Friend WithEvents ButtonX6 As ButtonX
    Friend WithEvents ButtonX1 As ButtonX
    Friend WithEvents dataConv As Controls.DataGridViewX
    Private WithEvents gpDatCont As Controls.GroupPanel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnEditar As ButtonX
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonX5 As ButtonX
    Friend WithEvents cuentaAnte As Controls.TextBoxX
    Friend WithEvents Label8 As Label
    Friend WithEvents Comunidad As Label
    Friend WithEvents Colonia As Label
    Friend WithEvents Domicilio As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nuevoadeudo As Label
    Friend WithEvents descuento As Controls.TextBoxX
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cuentatxt As Controls.TextBoxX
    Friend WithEvents total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre As Label
    Friend WithEvents btnExaminar As ButtonX
    Friend WithEvents TxtTel As MaskedTextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCalcular As ButtonX
    Friend WithEvents Label5 As Label
    Friend WithEvents fecha As Controls.TextBoxX
    Friend WithEvents Label6 As Label
    Friend WithEvents SuperTabItem1 As SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As SuperTabItem
    Friend WithEvents DataGridViewX1 As Controls.DataGridViewX
    Friend WithEvents Mes As DataGridViewTextBoxColumn
    Friend WithEvents Periodo As DataGridViewTextBoxColumn
    Friend WithEvents Consumo As DataGridViewTextBoxColumn
    Friend WithEvents Alcantarillado As DataGridViewTextBoxColumn
    Friend WithEvents Saneamiento As DataGridViewTextBoxColumn
    Friend WithEvents Recargos As DataGridViewTextBoxColumn
    Friend WithEvents Otros As DataGridViewTextBoxColumn
    Friend WithEvents Total1 As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
End Class
