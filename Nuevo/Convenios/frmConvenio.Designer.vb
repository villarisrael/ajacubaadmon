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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ToolBar = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.dataConv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.gpDatCont = New DevComponents.DotNetBar.Controls.GroupPanel()
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
        Me.pagos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fecha = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.TabControlPanel1.SuspendLayout()
        Me.ToolBar.SuspendLayout()
        CType(Me.dataConv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatCont.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.Controls.Add(Me.ButtonX6)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX2)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel1.Controls.Add(Me.ToolBar)
        Me.TabControlPanel1.Controls.Add(Me.dataConv)
        Me.TabControlPanel1.Controls.Add(Me.gpDatCont)
        Me.TabControlPanel1.Controls.Add(Me.BtnCalcular)
        Me.TabControlPanel1.Controls.Add(Me.pagos)
        Me.TabControlPanel1.Controls.Add(Me.Label5)
        Me.TabControlPanel1.Controls.Add(Me.fecha)
        Me.TabControlPanel1.Controls.Add(Me.Label6)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(971, 616)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.ButtonX2.Location = New System.Drawing.Point(755, 523)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(165, 39)
        Me.ButtonX2.TabIndex = 131
        Me.ButtonX2.Text = "Cancelar convenio"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Administativo.My.Resources.Resources.apply
        Me.ButtonX1.Location = New System.Drawing.Point(755, 478)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(165, 39)
        Me.ButtonX1.TabIndex = 130
        Me.ButtonX1.Text = "Confirmar convenio"
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
        Me.ToolBar.Size = New System.Drawing.Size(969, 58)
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
        'dataConv
        '
        Me.dataConv.AllowUserToAddRows = False
        Me.dataConv.AllowUserToDeleteRows = False
        Me.dataConv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dataConv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataConv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataConv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataConv.Location = New System.Drawing.Point(30, 355)
        Me.dataConv.Name = "dataConv"
        Me.dataConv.ReadOnly = True
        Me.dataConv.Size = New System.Drawing.Size(636, 249)
        Me.dataConv.TabIndex = 128
        '
        'gpDatCont
        '
        Me.gpDatCont.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatCont.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
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
        Me.gpDatCont.Location = New System.Drawing.Point(25, 68)
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
        Me.gpDatCont.TabIndex = 0
        Me.gpDatCont.Text = "Datos del convenio"
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEditar.Location = New System.Drawing.Point(768, 36)
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
        Me.Label9.Location = New System.Drawing.Point(724, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "%"
        Me.Label9.Visible = False
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.Image = Global.Administativo.My.Resources.Resources.calc
        Me.ButtonX5.Location = New System.Drawing.Point(424, 97)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(97, 38)
        Me.ButtonX5.TabIndex = 92
        Me.ButtonX5.Text = "Descuento"
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
        Me.Comunidad.ForeColor = System.Drawing.Color.Black
        Me.Comunidad.Location = New System.Drawing.Point(70, 93)
        Me.Comunidad.Name = "Comunidad"
        Me.Comunidad.Size = New System.Drawing.Size(0, 13)
        Me.Comunidad.TabIndex = 89
        '
        'Colonia
        '
        Me.Colonia.AutoSize = True
        Me.Colonia.BackColor = System.Drawing.Color.Transparent
        Me.Colonia.ForeColor = System.Drawing.Color.Black
        Me.Colonia.Location = New System.Drawing.Point(70, 77)
        Me.Colonia.Name = "Colonia"
        Me.Colonia.Size = New System.Drawing.Size(0, 13)
        Me.Colonia.TabIndex = 88
        '
        'Domicilio
        '
        Me.Domicilio.AutoSize = True
        Me.Domicilio.BackColor = System.Drawing.Color.Transparent
        Me.Domicilio.ForeColor = System.Drawing.Color.Black
        Me.Domicilio.Location = New System.Drawing.Point(70, 62)
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Size = New System.Drawing.Size(0, 13)
        Me.Domicilio.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Domicilio:"
        '
        'nuevoadeudo
        '
        Me.nuevoadeudo.AutoSize = True
        Me.nuevoadeudo.BackColor = System.Drawing.Color.Transparent
        Me.nuevoadeudo.Location = New System.Drawing.Point(678, 121)
        Me.nuevoadeudo.Name = "nuevoadeudo"
        Me.nuevoadeudo.Size = New System.Drawing.Size(13, 13)
        Me.nuevoadeudo.TabIndex = 84
        Me.nuevoadeudo.Text = "0"
        Me.nuevoadeudo.Visible = False
        '
        'descuento
        '
        '
        '
        '
        Me.descuento.Border.Class = "TextBoxBorder"
        Me.descuento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.descuento.Location = New System.Drawing.Point(678, 97)
        Me.descuento.Name = "descuento"
        Me.descuento.PreventEnterBeep = True
        Me.descuento.Size = New System.Drawing.Size(47, 20)
        Me.descuento.TabIndex = 83
        Me.descuento.Text = "0"
        Me.descuento.Visible = False
        Me.descuento.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(571, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Adeudo negociado:"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(571, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Descuento:"
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
        Me.total.Location = New System.Drawing.Point(678, 81)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(13, 13)
        Me.total.TabIndex = 68
        Me.total.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(571, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Adeudo:"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.BackColor = System.Drawing.Color.Transparent
        Me.nombre.Location = New System.Drawing.Point(63, 39)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(0, 13)
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
        Me.TxtTel.Location = New System.Drawing.Point(678, 39)
        Me.TxtTel.Mask = "(###)-###-####"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(84, 20)
        Me.TxtTel.TabIndex = 8
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.ForeColor = System.Drawing.Color.Red
        Me.LblTelefono.Location = New System.Drawing.Point(571, 39)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 8
        Me.LblTelefono.Text = "Telefono:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.ForeColor = System.Drawing.Color.Black
        Me.lblnombre.Location = New System.Drawing.Point(3, 39)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(39, 13)
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
        Me.BtnCalcular.Location = New System.Drawing.Point(835, 390)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(91, 38)
        Me.BtnCalcular.TabIndex = 85
        Me.BtnCalcular.Text = "Calcular"
        '
        'pagos
        '
        '
        '
        '
        Me.pagos.Border.Class = "TextBoxBorder"
        Me.pagos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pagos.Location = New System.Drawing.Point(837, 343)
        Me.pagos.Name = "pagos"
        Me.pagos.PreventEnterBeep = True
        Me.pagos.Size = New System.Drawing.Size(82, 20)
        Me.pagos.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(713, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Pagos:"
        '
        'fecha
        '
        '
        '
        '
        Me.fecha.Border.Class = "TextBoxBorder"
        Me.fecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.Location = New System.Drawing.Point(837, 364)
        Me.fecha.Name = "fecha"
        Me.fecha.PreventEnterBeep = True
        Me.fecha.Size = New System.Drawing.Size(82, 20)
        Me.fecha.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(709, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Días de aplazamiento:"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.ButtonX6.Location = New System.Drawing.Point(826, 568)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(133, 39)
        Me.ButtonX6.TabIndex = 132
        Me.ButtonX6.Text = "Cancelar convenio"
        Me.ButtonX6.Visible = False
        '
        'frmConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 616)
        Me.Controls.Add(Me.TabControlPanel1)
        Me.Name = "frmConvenio"
        Me.Text = "Convenios"
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.ToolBar.ResumeLayout(False)
        CType(Me.dataConv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatCont.ResumeLayout(False)
        Me.gpDatCont.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents TabControlPanel1 As TabControlPanel
    Private WithEvents gpDatCont As Controls.GroupPanel
    Friend WithEvents TxtTel As MaskedTextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pagos As Controls.TextBoxX
    Friend WithEvents Label5 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre As Label
    Friend WithEvents btnExaminar As ButtonX
    Friend WithEvents cuentatxt As Controls.TextBoxX
    Private WithEvents ButtonX3 As ButtonX
    Friend WithEvents dataConv As Controls.DataGridViewX
    Friend WithEvents fecha As Controls.TextBoxX
    Friend WithEvents descuento As Controls.TextBoxX
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nuevoadeudo As Label
    Friend WithEvents BtnCalcular As ButtonX
    Private WithEvents ToolBar As Controls.GroupPanel
    Friend WithEvents cmdCancel As ButtonX
    Friend WithEvents Label7 As Label
    Friend WithEvents Colonia As Label
    Friend WithEvents Domicilio As Label
    Friend WithEvents Comunidad As Label
    Friend WithEvents ButtonX1 As ButtonX
    Friend WithEvents ButtonX2 As ButtonX
    Friend WithEvents ButtonX4 As ButtonX
    Friend WithEvents Label8 As Label
    Friend WithEvents cuentaAnte As Controls.TextBoxX
    Friend WithEvents ButtonX5 As ButtonX
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEditar As ButtonX
    Friend WithEvents ButtonX6 As ButtonX
End Class
