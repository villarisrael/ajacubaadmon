<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresa))
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.TxtSiglas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtFax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtTelefono = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtCP = New DevComponents.Editors.IntegerInput()
        Me.TxtRFC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtMunicipio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtColonia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblSiglas = New System.Windows.Forms.Label()
        Me.LblFax = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblCp = New System.Windows.Forms.Label()
        Me.LblRfc = New System.Windows.Forms.Label()
        Me.LblMunicipio = New System.Windows.Forms.Label()
        Me.LblColonia = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbNotificar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbPagoextemporaneo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TxtAreaTecnica = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtJuridico = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtAdministrador = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblTecnica = New System.Windows.Forms.Label()
        Me.LblJuridico = New System.Windows.Forms.Label()
        Me.LblAdministrador = New System.Windows.Forms.Label()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 2
        Me.TabControl1.Size = New System.Drawing.Size(653, 426)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Text = "Generales"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.pic1)
        Me.TabControlPanel1.Controls.Add(Me.TxtSiglas)
        Me.TabControlPanel1.Controls.Add(Me.TxtFax)
        Me.TabControlPanel1.Controls.Add(Me.TxtTelefono)
        Me.TabControlPanel1.Controls.Add(Me.TxtCP)
        Me.TabControlPanel1.Controls.Add(Me.TxtRFC)
        Me.TabControlPanel1.Controls.Add(Me.TxtMunicipio)
        Me.TabControlPanel1.Controls.Add(Me.TxtColonia)
        Me.TabControlPanel1.Controls.Add(Me.TxtDireccion)
        Me.TabControlPanel1.Controls.Add(Me.TxtNombre)
        Me.TabControlPanel1.Controls.Add(Me.LblSiglas)
        Me.TabControlPanel1.Controls.Add(Me.LblFax)
        Me.TabControlPanel1.Controls.Add(Me.LblTelefono)
        Me.TabControlPanel1.Controls.Add(Me.LblCp)
        Me.TabControlPanel1.Controls.Add(Me.LblRfc)
        Me.TabControlPanel1.Controls.Add(Me.LblMunicipio)
        Me.TabControlPanel1.Controls.Add(Me.LblColonia)
        Me.TabControlPanel1.Controls.Add(Me.LblDireccion)
        Me.TabControlPanel1.Controls.Add(Me.LblNombre)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(653, 404)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(397, 187)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(210, 191)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 65
        Me.pic1.TabStop = False
        '
        'TxtSiglas
        '
        '
        '
        '
        Me.TxtSiglas.Border.Class = "TextBoxBorder"
        Me.TxtSiglas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtSiglas.Location = New System.Drawing.Point(80, 358)
        Me.TxtSiglas.Name = "TxtSiglas"
        Me.TxtSiglas.Size = New System.Drawing.Size(226, 20)
        Me.TxtSiglas.TabIndex = 51
        '
        'TxtFax
        '
        '
        '
        '
        Me.TxtFax.Border.Class = "TextBoxBorder"
        Me.TxtFax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtFax.Location = New System.Drawing.Point(80, 320)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(226, 20)
        Me.TxtFax.TabIndex = 50
        '
        'TxtTelefono
        '
        '
        '
        '
        Me.TxtTelefono.Border.Class = "TextBoxBorder"
        Me.TxtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTelefono.Location = New System.Drawing.Point(80, 278)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(226, 20)
        Me.TxtTelefono.TabIndex = 49
        '
        'TxtCP
        '
        '
        '
        '
        Me.TxtCP.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtCP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtCP.Location = New System.Drawing.Point(80, 235)
        Me.TxtCP.MaxValue = 99999
        Me.TxtCP.MinValue = 0
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.ShowUpDown = True
        Me.TxtCP.Size = New System.Drawing.Size(112, 20)
        Me.TxtCP.TabIndex = 48
        '
        'TxtRFC
        '
        '
        '
        '
        Me.TxtRFC.Border.Class = "TextBoxBorder"
        Me.TxtRFC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtRFC.Location = New System.Drawing.Point(80, 191)
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.Size = New System.Drawing.Size(226, 20)
        Me.TxtRFC.TabIndex = 47
        '
        'TxtMunicipio
        '
        '
        '
        '
        Me.TxtMunicipio.Border.Class = "TextBoxBorder"
        Me.TxtMunicipio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtMunicipio.Location = New System.Drawing.Point(80, 151)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Size = New System.Drawing.Size(554, 20)
        Me.TxtMunicipio.TabIndex = 46
        '
        'TxtColonia
        '
        '
        '
        '
        Me.TxtColonia.Border.Class = "TextBoxBorder"
        Me.TxtColonia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtColonia.Location = New System.Drawing.Point(80, 107)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(554, 20)
        Me.TxtColonia.TabIndex = 45
        '
        'TxtDireccion
        '
        '
        '
        '
        Me.TxtDireccion.Border.Class = "TextBoxBorder"
        Me.TxtDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtDireccion.Location = New System.Drawing.Point(80, 65)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(554, 20)
        Me.TxtDireccion.TabIndex = 44
        '
        'TxtNombre
        '
        '
        '
        '
        Me.TxtNombre.Border.Class = "TextBoxBorder"
        Me.TxtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtNombre.Location = New System.Drawing.Point(80, 25)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(554, 20)
        Me.TxtNombre.TabIndex = 43
        '
        'LblSiglas
        '
        Me.LblSiglas.AutoSize = True
        Me.LblSiglas.BackColor = System.Drawing.Color.Transparent
        Me.LblSiglas.Location = New System.Drawing.Point(18, 358)
        Me.LblSiglas.Name = "LblSiglas"
        Me.LblSiglas.Size = New System.Drawing.Size(35, 13)
        Me.LblSiglas.TabIndex = 42
        Me.LblSiglas.Text = "Siglas"
        '
        'LblFax
        '
        Me.LblFax.AutoSize = True
        Me.LblFax.BackColor = System.Drawing.Color.Transparent
        Me.LblFax.Location = New System.Drawing.Point(16, 322)
        Me.LblFax.Name = "LblFax"
        Me.LblFax.Size = New System.Drawing.Size(24, 13)
        Me.LblFax.TabIndex = 41
        Me.LblFax.Text = "Fax"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Location = New System.Drawing.Point(16, 280)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 40
        Me.LblTelefono.Text = "Telefono"
        '
        'LblCp
        '
        Me.LblCp.AutoSize = True
        Me.LblCp.BackColor = System.Drawing.Color.Transparent
        Me.LblCp.Location = New System.Drawing.Point(16, 235)
        Me.LblCp.Name = "LblCp"
        Me.LblCp.Size = New System.Drawing.Size(21, 13)
        Me.LblCp.TabIndex = 39
        Me.LblCp.Text = "CP"
        '
        'LblRfc
        '
        Me.LblRfc.AutoSize = True
        Me.LblRfc.BackColor = System.Drawing.Color.Transparent
        Me.LblRfc.Location = New System.Drawing.Point(16, 193)
        Me.LblRfc.Name = "LblRfc"
        Me.LblRfc.Size = New System.Drawing.Size(28, 13)
        Me.LblRfc.TabIndex = 38
        Me.LblRfc.Text = "RFC"
        '
        'LblMunicipio
        '
        Me.LblMunicipio.AutoSize = True
        Me.LblMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.LblMunicipio.Location = New System.Drawing.Point(15, 151)
        Me.LblMunicipio.Name = "LblMunicipio"
        Me.LblMunicipio.Size = New System.Drawing.Size(52, 13)
        Me.LblMunicipio.TabIndex = 37
        Me.LblMunicipio.Text = "Municipio"
        '
        'LblColonia
        '
        Me.LblColonia.AutoSize = True
        Me.LblColonia.BackColor = System.Drawing.Color.Transparent
        Me.LblColonia.Location = New System.Drawing.Point(16, 109)
        Me.LblColonia.Name = "LblColonia"
        Me.LblColonia.Size = New System.Drawing.Size(42, 13)
        Me.LblColonia.TabIndex = 36
        Me.LblColonia.Text = "Colonia"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LblDireccion.Location = New System.Drawing.Point(16, 67)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 35
        Me.LblDireccion.Text = "Direccion"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Location = New System.Drawing.Point(16, 25)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 34
        Me.LblNombre.Text = "Nombre"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Generales"
        Me.TabItem1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.PictureBox1)
        Me.TabControlPanel3.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel3.Controls.Add(Me.Label7)
        Me.TabControlPanel3.Controls.Add(Me.TextBoxX4)
        Me.TabControlPanel3.Controls.Add(Me.Label6)
        Me.TabControlPanel3.Controls.Add(Me.TextBoxX3)
        Me.TabControlPanel3.Controls.Add(Me.Label5)
        Me.TabControlPanel3.Controls.Add(Me.TextBoxX2)
        Me.TabControlPanel3.Controls.Add(Me.Label4)
        Me.TabControlPanel3.Controls.Add(Me.TextBoxX1)
        Me.TabControlPanel3.Controls.Add(Me.Label3)
        Me.TabControlPanel3.Controls.Add(Me.Label2)
        Me.TabControlPanel3.Controls.Add(Me.CmbNotificar)
        Me.TabControlPanel3.Controls.Add(Me.Label1)
        Me.TabControlPanel3.Controls.Add(Me.CmbPagoextemporaneo)
        Me.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(653, 404)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(200, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 221)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Administativo.My.Resources.Resources.Buscar
        Me.ButtonX1.Location = New System.Drawing.Point(271, 353)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(110, 46)
        Me.ButtonX1.TabIndex = 63
        Me.ButtonX1.Text = "Buscar Firma"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(265, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "FIRMA DEL DIRECTOR"
        '
        'TextBoxX4
        '
        '
        '
        '
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX4.Location = New System.Drawing.Point(486, 37)
        Me.TextBoxX4.Name = "TextBoxX4"
        Me.TextBoxX4.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxX4.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(521, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "FOLIO REMATE"
        '
        'TextBoxX3
        '
        '
        '
        '
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.Location = New System.Drawing.Point(328, 37)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxX3.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(358, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "FOLIO EMBARGO"
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Location = New System.Drawing.Point(170, 37)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxX2.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(183, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "FOLIO REQUERIMIENTO"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(12, 37)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxX1.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(31, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "FOLIO NOTIFICACION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(353, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "CONCEPTO DE MULTA POR PAGO EXTEMPORANEO"
        '
        'CmbNotificar
        '
        Me.CmbNotificar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbNotificar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbNotificar.DisplayMember = "Text"
        Me.CmbNotificar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbNotificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNotificar.FocusHighlightEnabled = True
        Me.CmbNotificar.FormattingEnabled = True
        Me.CmbNotificar.ItemHeight = 14
        Me.CmbNotificar.Location = New System.Drawing.Point(11, 81)
        Me.CmbNotificar.Name = "CmbNotificar"
        Me.CmbNotificar.Size = New System.Drawing.Size(332, 20)
        Me.CmbNotificar.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CONCEPTO DE COBRO DE HONORARIOS POR NOTIFICACION"
        '
        'CmbPagoextemporaneo
        '
        Me.CmbPagoextemporaneo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbPagoextemporaneo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPagoextemporaneo.DisplayMember = "Text"
        Me.CmbPagoextemporaneo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbPagoextemporaneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPagoextemporaneo.FocusHighlightEnabled = True
        Me.CmbPagoextemporaneo.FormattingEnabled = True
        Me.CmbPagoextemporaneo.ItemHeight = 14
        Me.CmbPagoextemporaneo.Location = New System.Drawing.Point(343, 81)
        Me.CmbPagoextemporaneo.Name = "CmbPagoextemporaneo"
        Me.CmbPagoextemporaneo.Size = New System.Drawing.Size(301, 20)
        Me.CmbPagoextemporaneo.TabIndex = 29
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Requerimiento"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.TxtAreaTecnica)
        Me.TabControlPanel2.Controls.Add(Me.TxtJuridico)
        Me.TabControlPanel2.Controls.Add(Me.TxtAdministrador)
        Me.TabControlPanel2.Controls.Add(Me.LblTecnica)
        Me.TabControlPanel2.Controls.Add(Me.LblJuridico)
        Me.TabControlPanel2.Controls.Add(Me.LblAdministrador)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(653, 404)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'TxtAreaTecnica
        '
        '
        '
        '
        Me.TxtAreaTecnica.Border.Class = "TextBoxBorder"
        Me.TxtAreaTecnica.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtAreaTecnica.Location = New System.Drawing.Point(104, 140)
        Me.TxtAreaTecnica.Name = "TxtAreaTecnica"
        Me.TxtAreaTecnica.Size = New System.Drawing.Size(526, 20)
        Me.TxtAreaTecnica.TabIndex = 50
        '
        'TxtJuridico
        '
        '
        '
        '
        Me.TxtJuridico.Border.Class = "TextBoxBorder"
        Me.TxtJuridico.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtJuridico.Location = New System.Drawing.Point(104, 80)
        Me.TxtJuridico.Name = "TxtJuridico"
        Me.TxtJuridico.Size = New System.Drawing.Size(526, 20)
        Me.TxtJuridico.TabIndex = 49
        '
        'TxtAdministrador
        '
        '
        '
        '
        Me.TxtAdministrador.Border.Class = "TextBoxBorder"
        Me.TxtAdministrador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtAdministrador.Location = New System.Drawing.Point(104, 24)
        Me.TxtAdministrador.Name = "TxtAdministrador"
        Me.TxtAdministrador.Size = New System.Drawing.Size(526, 20)
        Me.TxtAdministrador.TabIndex = 48
        '
        'LblTecnica
        '
        Me.LblTecnica.AutoSize = True
        Me.LblTecnica.BackColor = System.Drawing.Color.Transparent
        Me.LblTecnica.Location = New System.Drawing.Point(19, 140)
        Me.LblTecnica.Name = "LblTecnica"
        Me.LblTecnica.Size = New System.Drawing.Size(71, 13)
        Me.LblTecnica.TabIndex = 7
        Me.LblTecnica.Text = "Area Tecnica"
        '
        'LblJuridico
        '
        Me.LblJuridico.AutoSize = True
        Me.LblJuridico.BackColor = System.Drawing.Color.Transparent
        Me.LblJuridico.Location = New System.Drawing.Point(19, 80)
        Me.LblJuridico.Name = "LblJuridico"
        Me.LblJuridico.Size = New System.Drawing.Size(72, 13)
        Me.LblJuridico.TabIndex = 6
        Me.LblJuridico.Text = "Dept. Juridico"
        '
        'LblAdministrador
        '
        Me.LblAdministrador.AutoSize = True
        Me.LblAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.LblAdministrador.Location = New System.Drawing.Point(19, 24)
        Me.LblAdministrador.Name = "LblAdministrador"
        Me.LblAdministrador.Size = New System.Drawing.Size(70, 13)
        Me.LblAdministrador.TabIndex = 5
        Me.LblAdministrador.Text = "Administrador"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Personal"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(555, 460)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 46)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.Location = New System.Drawing.Point(445, 460)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 46)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 518)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "FrmEmpresa"
        Me.Text = "Empresa"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LblSiglas As System.Windows.Forms.Label
    Friend WithEvents LblFax As System.Windows.Forms.Label
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblCp As System.Windows.Forms.Label
    Friend WithEvents LblRfc As System.Windows.Forms.Label
    Friend WithEvents LblMunicipio As System.Windows.Forms.Label
    Friend WithEvents LblColonia As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LblTecnica As System.Windows.Forms.Label
    Friend WithEvents LblJuridico As System.Windows.Forms.Label
    Friend WithEvents LblAdministrador As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtCP As DevComponents.Editors.IntegerInput
    Friend WithEvents TxtRFC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtMunicipio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtColonia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtAreaTecnica As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtJuridico As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtAdministrador As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtSiglas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtFax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtTelefono As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbPagoextemporaneo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CmbNotificar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pic1 As PictureBox
End Class
