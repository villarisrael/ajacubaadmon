Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class configuracion
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
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.lblgenerales = New DevComponents.DotNetBar.LabelX()
        Me.lblcobranza = New DevComponents.DotNetBar.LabelX()
        Me.lblmedicion = New DevComponents.DotNetBar.LabelX()
        Me.LblCajas = New DevComponents.DotNetBar.LabelX()
        Me.lblrequerimiento = New DevComponents.DotNetBar.LabelX()
        Me.Node3 = New DevComponents.AdvTree.Node()
        Me.Cell1 = New DevComponents.AdvTree.Cell()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.Cell2 = New DevComponents.AdvTree.Cell()
        Me.Node2 = New DevComponents.AdvTree.Node()
        Me.Cell3 = New DevComponents.AdvTree.Cell()
        Me.Node4 = New DevComponents.AdvTree.Node()
        Me.Cell4 = New DevComponents.AdvTree.Cell()
        Me.Node5 = New DevComponents.AdvTree.Node()
        Me.Cell5 = New DevComponents.AdvTree.Cell()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.BtnGenerales = New DevComponents.DotNetBar.ButtonX()
        Me.btnconvenios = New DevComponents.DotNetBar.ButtonX()
        Me.BtnMedicion = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.TxtRuta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.TxtBase = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.BtnBase = New DevComponents.DotNetBar.ButtonX()
        Me.BtnActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.GPCaja = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TXTSIT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblRutaArchivosXml = New DevComponents.DotNetBar.LabelX()
        Me.TxtXml = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnRutaXml = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtdisparada = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupMedicion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.IVA = New DevComponents.Editors.IntegerInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.IMAGENES = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.SALARIO = New DevComponents.Editors.DoubleInput()
        Me.GroupGeneral = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Convenio = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.minconvenio = New DevComponents.Editors.IntegerInput()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.anticipo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSufConvenio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.NumConvenio = New DevComponents.Editors.IntegerInput()
        Me.TxtPreConvenio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblSufijo = New System.Windows.Forms.Label()
        Me.LblNumero = New System.Windows.Forms.Label()
        Me.LblPrefijo = New System.Windows.Forms.Label()
        Me.LblNoConvenio = New System.Windows.Forms.Label()
        Me.Panelrequerimientos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.IIdiasembargo = New DevComponents.Editors.IntegerInput()
        Me.IIdiasremate = New DevComponents.Editors.IntegerInput()
        Me.IIdiascorte = New DevComponents.Editors.IntegerInput()
        Me.IIdiasaviso24 = New DevComponents.Editors.IntegerInput()
        Me.IIdiasrequeri = New DevComponents.Editors.IntegerInput()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtgas3 = New System.Windows.Forms.NumericUpDown()
        Me.txtgas2 = New System.Windows.Forms.NumericUpDown()
        Me.txtgas1 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSufRequeri = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.NumRequeri = New DevComponents.Editors.IntegerInput()
        Me.TxtPreRequeri = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcorte = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.recdocumentos = New System.Windows.Forms.NumericUpDown()
        Me.GroupDocumentos = New DevComponents.DotNetBar.Controls.GroupPanel()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdvTree1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPCaja.SuspendLayout()
        Me.GroupMedicion.SuspendLayout()
        CType(Me.IVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGeneral.SuspendLayout()
        Me.Convenio.SuspendLayout()
        CType(Me.minconvenio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anticipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumConvenio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelrequerimientos.SuspendLayout()
        CType(Me.IIdiasembargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIdiasremate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIdiascorte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIdiasaviso24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIdiasrequeri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.txtgas3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgas2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRequeri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.recdocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDocumentos.SuspendLayout()
        Me.SuspendLayout()
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
        Me.AdvTree1.Controls.Add(Me.lblgenerales)
        Me.AdvTree1.Controls.Add(Me.lblcobranza)
        Me.AdvTree1.Controls.Add(Me.lblmedicion)
        Me.AdvTree1.Controls.Add(Me.LblCajas)
        Me.AdvTree1.Controls.Add(Me.lblrequerimiento)
        Me.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.AdvTree1.Location = New System.Drawing.Point(2, 3)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node3, Me.Node1, Me.Node2, Me.Node4, Me.Node5})
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(167, 423)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.TabIndex = 0
        Me.AdvTree1.Text = "AdvTree1"
        '
        'lblgenerales
        '
        Me.lblgenerales.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblgenerales.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblgenerales.Location = New System.Drawing.Point(68, 3)
        Me.lblgenerales.Name = "lblgenerales"
        Me.lblgenerales.Size = New System.Drawing.Size(85, 32)
        Me.lblgenerales.TabIndex = 117
        Me.lblgenerales.Text = "Generales"
        '
        'lblcobranza
        '
        Me.lblcobranza.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblcobranza.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblcobranza.Location = New System.Drawing.Point(68, 38)
        Me.lblcobranza.Name = "lblcobranza"
        Me.lblcobranza.Size = New System.Drawing.Size(85, 32)
        Me.lblcobranza.TabIndex = 118
        Me.lblcobranza.Text = "Cobranza"
        '
        'lblmedicion
        '
        '
        '
        '
        Me.lblmedicion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblmedicion.Location = New System.Drawing.Point(68, 73)
        Me.lblmedicion.Name = "lblmedicion"
        Me.lblmedicion.Size = New System.Drawing.Size(66, 32)
        Me.lblmedicion.TabIndex = 117
        Me.lblmedicion.Text = "Medicion"
        '
        'LblCajas
        '
        '
        '
        '
        Me.LblCajas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblCajas.Location = New System.Drawing.Point(68, 108)
        Me.LblCajas.Name = "LblCajas"
        Me.LblCajas.Size = New System.Drawing.Size(75, 32)
        Me.LblCajas.TabIndex = 118
        Me.LblCajas.Text = "Cajas"
        '
        'lblrequerimiento
        '
        '
        '
        '
        Me.lblrequerimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblrequerimiento.Location = New System.Drawing.Point(68, 147)
        Me.lblrequerimiento.Name = "lblrequerimiento"
        Me.lblrequerimiento.Size = New System.Drawing.Size(75, 23)
        Me.lblrequerimiento.TabIndex = 5
        Me.lblrequerimiento.Text = "Requerimientos"
        '
        'Node3
        '
        Me.Node3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.Node3.Cells.Add(Me.Cell1)
        Me.Node3.Expanded = True
        Me.Node3.Image = Global.Administativo.My.Resources.Resources.run
        Me.Node3.Name = "Node3"
        '
        'Cell1
        '
        Me.Cell1.HostedControl = Me.lblgenerales
        Me.Cell1.Name = "Cell1"
        Me.Cell1.StyleMouseOver = Nothing
        '
        'Node1
        '
        Me.Node1.Cells.Add(Me.Cell2)
        Me.Node1.Image = Global.Administativo.My.Resources.Resources.Requerimientos
        Me.Node1.Name = "Node1"
        '
        'Cell2
        '
        Me.Cell2.HostedControl = Me.lblcobranza
        Me.Cell2.Name = "Cell2"
        Me.Cell2.StyleMouseOver = Nothing
        '
        'Node2
        '
        Me.Node2.Cells.Add(Me.Cell3)
        Me.Node2.Expanded = True
        Me.Node2.Image = Global.Administativo.My.Resources.Resources.karm_2
        Me.Node2.Name = "Node2"
        '
        'Cell3
        '
        Me.Cell3.HostedControl = Me.lblmedicion
        Me.Cell3.Name = "Cell3"
        Me.Cell3.StyleMouseOver = Nothing
        '
        'Node4
        '
        Me.Node4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.Node4.Cells.Add(Me.Cell4)
        Me.Node4.Image = Global.Administativo.My.Resources.Resources.agt_business
        Me.Node4.Name = "Node4"
        '
        'Cell4
        '
        Me.Cell4.HostedControl = Me.LblCajas
        Me.Cell4.Name = "Cell4"
        Me.Cell4.StyleMouseOver = Nothing
        '
        'Node5
        '
        Me.Node5.Cells.Add(Me.Cell5)
        Me.Node5.Expanded = True
        Me.Node5.Image = Global.Administativo.My.Resources.Resources.agt_family
        Me.Node5.Name = "Node5"
        '
        'Cell5
        '
        Me.Cell5.HostedControl = Me.lblrequerimiento
        Me.Cell5.Name = "Cell5"
        Me.Cell5.StyleMouseOver = Nothing
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
        'BtnGenerales
        '
        Me.BtnGenerales.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnGenerales.BackColor = System.Drawing.Color.Transparent
        Me.BtnGenerales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGenerales.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnGenerales.Image = Global.Administativo.My.Resources.Resources.run
        Me.BtnGenerales.Location = New System.Drawing.Point(42, 3)
        Me.BtnGenerales.Name = "BtnGenerales"
        Me.BtnGenerales.Size = New System.Drawing.Size(98, 35)
        Me.BtnGenerales.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.BtnGenerales.TabIndex = 0
        Me.BtnGenerales.Text = "Generales"
        '
        'btnconvenios
        '
        Me.btnconvenios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnconvenios.BackColor = System.Drawing.Color.Transparent
        Me.btnconvenios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnconvenios.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnconvenios.Image = Global.Administativo.My.Resources.Resources.Requerimientos
        Me.btnconvenios.Location = New System.Drawing.Point(28, 41)
        Me.btnconvenios.Name = "btnconvenios"
        Me.btnconvenios.Size = New System.Drawing.Size(98, 35)
        Me.btnconvenios.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.btnconvenios.TabIndex = 1
        Me.btnconvenios.Text = "Cobranza"
        '
        'BtnMedicion
        '
        Me.BtnMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnMedicion.BackColor = System.Drawing.Color.Transparent
        Me.BtnMedicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnMedicion.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnMedicion.Image = Global.Administativo.My.Resources.Resources.karm_2
        Me.BtnMedicion.Location = New System.Drawing.Point(39, 76)
        Me.BtnMedicion.Name = "BtnMedicion"
        Me.BtnMedicion.Size = New System.Drawing.Size(98, 35)
        Me.BtnMedicion.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.BtnMedicion.TabIndex = 2
        Me.BtnMedicion.Text = "Medición"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Administativo.My.Resources.Resources.fondo3
        Me.PictureBox1.Location = New System.Drawing.Point(175, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(517, 435)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 46)
        Me.BtnCancelar.TabIndex = 116
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(369, 435)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(142, 46)
        Me.BtnAceptar.TabIndex = 115
        Me.BtnAceptar.Text = "Aplicar Cambios"
        '
        'TxtRuta
        '
        '
        '
        '
        Me.TxtRuta.Border.Class = "TextBoxBorder"
        Me.TxtRuta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtRuta.Location = New System.Drawing.Point(12, 52)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(347, 20)
        Me.TxtRuta.TabIndex = 9
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBuscar.Location = New System.Drawing.Point(366, 51)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Seleccionar"
        '
        'TxtBase
        '
        '
        '
        '
        Me.TxtBase.Border.Class = "TextBoxBorder"
        Me.TxtBase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBase.Location = New System.Drawing.Point(12, 123)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(347, 20)
        Me.TxtBase.TabIndex = 13
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 93)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(308, 23)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "Selecciona la ruta de la base de datos para actualizar la caja:"
        '
        'BtnBase
        '
        Me.BtnBase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBase.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBase.Location = New System.Drawing.Point(366, 124)
        Me.BtnBase.Name = "BtnBase"
        Me.BtnBase.Size = New System.Drawing.Size(75, 23)
        Me.BtnBase.TabIndex = 15
        Me.BtnBase.Text = "Seleccionar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnActualizar.Location = New System.Drawing.Point(288, 164)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(149, 27)
        Me.BtnActualizar.TabIndex = 16
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'GPCaja
        '
        Me.GPCaja.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPCaja.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPCaja.Controls.Add(Me.BtnActualizar)
        Me.GPCaja.Controls.Add(Me.BtnBase)
        Me.GPCaja.Controls.Add(Me.LabelX4)
        Me.GPCaja.Controls.Add(Me.TxtBase)
        Me.GPCaja.Controls.Add(Me.BtnBuscar)
        Me.GPCaja.Controls.Add(Me.LabelX5)
        Me.GPCaja.Controls.Add(Me.TxtRuta)
        Me.GPCaja.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPCaja.Location = New System.Drawing.Point(172, 125)
        Me.GPCaja.Name = "GPCaja"
        Me.GPCaja.Size = New System.Drawing.Size(455, 304)
        '
        '
        '
        Me.GPCaja.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPCaja.Style.BackColorGradientAngle = 90
        Me.GPCaja.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPCaja.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPCaja.Style.BorderBottomWidth = 1
        Me.GPCaja.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPCaja.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPCaja.Style.BorderLeftWidth = 1
        Me.GPCaja.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPCaja.Style.BorderRightWidth = 1
        Me.GPCaja.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPCaja.Style.BorderTopWidth = 1
        Me.GPCaja.Style.CornerDiameter = 4
        Me.GPCaja.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPCaja.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPCaja.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPCaja.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPCaja.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPCaja.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPCaja.TabIndex = 117
        Me.GPCaja.Text = "Cajas"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(12, 19)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(239, 23)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Selecciona la ruta de los Archivos Temporales:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(27, 29)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(190, 18)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Escribe la situación nuevo medidor"
        '
        'TXTSIT
        '
        '
        '
        '
        Me.TXTSIT.Border.Class = "TextBoxBorder"
        Me.TXTSIT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTSIT.Location = New System.Drawing.Point(230, 28)
        Me.TXTSIT.MaxLength = 1
        Me.TXTSIT.Name = "TXTSIT"
        Me.TXTSIT.Size = New System.Drawing.Size(26, 20)
        Me.TXTSIT.TabIndex = 1
        '
        'LblRutaArchivosXml
        '
        Me.LblRutaArchivosXml.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblRutaArchivosXml.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblRutaArchivosXml.Location = New System.Drawing.Point(26, 58)
        Me.LblRutaArchivosXml.Name = "LblRutaArchivosXml"
        Me.LblRutaArchivosXml.Size = New System.Drawing.Size(404, 18)
        Me.LblRutaArchivosXml.TabIndex = 2
        Me.LblRutaArchivosXml.Text = "Selecciona la ruta donde se guardaran los archivos de exportacion de la terminal:" &
    ""
        '
        'TxtXml
        '
        '
        '
        '
        Me.TxtXml.Border.Class = "TextBoxBorder"
        Me.TxtXml.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtXml.Location = New System.Drawing.Point(26, 91)
        Me.TxtXml.MaxLength = 1
        Me.TxtXml.Name = "TxtXml"
        Me.TxtXml.Size = New System.Drawing.Size(323, 20)
        Me.TxtXml.TabIndex = 3
        '
        'BtnRutaXml
        '
        Me.BtnRutaXml.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnRutaXml.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnRutaXml.Location = New System.Drawing.Point(355, 90)
        Me.BtnRutaXml.Name = "BtnRutaXml"
        Me.BtnRutaXml.Size = New System.Drawing.Size(75, 23)
        Me.BtnRutaXml.TabIndex = 16
        Me.BtnRutaXml.Text = "Seleccionar"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(27, 58)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(190, 18)
        Me.LabelX7.TabIndex = 17
        Me.LabelX7.Text = "Escribe la situación disparada"
        Me.LabelX7.Visible = False
        '
        'txtdisparada
        '
        '
        '
        '
        Me.txtdisparada.Border.Class = "TextBoxBorder"
        Me.txtdisparada.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdisparada.Location = New System.Drawing.Point(293, 28)
        Me.txtdisparada.MaxLength = 1
        Me.txtdisparada.Name = "txtdisparada"
        Me.txtdisparada.Size = New System.Drawing.Size(26, 20)
        Me.txtdisparada.TabIndex = 18
        Me.txtdisparada.Visible = False
        '
        'GroupMedicion
        '
        Me.GroupMedicion.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupMedicion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupMedicion.Controls.Add(Me.txtdisparada)
        Me.GroupMedicion.Controls.Add(Me.LabelX7)
        Me.GroupMedicion.Controls.Add(Me.BtnRutaXml)
        Me.GroupMedicion.Controls.Add(Me.TxtXml)
        Me.GroupMedicion.Controls.Add(Me.LblRutaArchivosXml)
        Me.GroupMedicion.Controls.Add(Me.TXTSIT)
        Me.GroupMedicion.Controls.Add(Me.LabelX1)
        Me.GroupMedicion.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupMedicion.Location = New System.Drawing.Point(173, 135)
        Me.GroupMedicion.Name = "GroupMedicion"
        Me.GroupMedicion.Size = New System.Drawing.Size(454, 291)
        '
        '
        '
        Me.GroupMedicion.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupMedicion.Style.BackColorGradientAngle = 90
        Me.GroupMedicion.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupMedicion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupMedicion.Style.BorderBottomWidth = 1
        Me.GroupMedicion.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupMedicion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupMedicion.Style.BorderLeftWidth = 1
        Me.GroupMedicion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupMedicion.Style.BorderRightWidth = 1
        Me.GroupMedicion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupMedicion.Style.BorderTopWidth = 1
        Me.GroupMedicion.Style.CornerDiameter = 4
        Me.GroupMedicion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupMedicion.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupMedicion.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupMedicion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupMedicion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupMedicion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupMedicion.TabIndex = 111
        Me.GroupMedicion.Text = "Configuración medición"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(41, 30)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(115, 31)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Porcentaje de IVA %"
        '
        'IVA
        '
        '
        '
        '
        Me.IVA.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IVA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IVA.Location = New System.Drawing.Point(162, 32)
        Me.IVA.MaxValue = 20
        Me.IVA.MinValue = 0
        Me.IVA.Name = "IVA"
        Me.IVA.ShowUpDown = True
        Me.IVA.Size = New System.Drawing.Size(52, 20)
        Me.IVA.TabIndex = 1
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(21, 96)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(176, 21)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Selecciona la ruta de Imágenes"
        '
        'IMAGENES
        '
        '
        '
        '
        Me.IMAGENES.Border.Class = "TextBoxBorder"
        Me.IMAGENES.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IMAGENES.Location = New System.Drawing.Point(21, 119)
        Me.IMAGENES.Name = "IMAGENES"
        Me.IMAGENES.Size = New System.Drawing.Size(336, 20)
        Me.IMAGENES.TabIndex = 3
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(363, 119)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 12
        Me.ButtonX1.Text = "Seleccionar"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(41, 165)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(357, 90)
        Me.LabelX6.TabIndex = 13
        Me.LabelX6.Text = "No selecciones sitios de red, en caso de requerirlos. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "conecta el sitio de la re" &
    "d a una unidad logica y selecciona " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la ruta a esa unidad de red:"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(41, 59)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(115, 31)
        Me.LabelX10.TabIndex = 14
        Me.LabelX10.Text = "Salario minimo"
        '
        'SALARIO
        '
        '
        '
        '
        Me.SALARIO.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.SALARIO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SALARIO.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.SALARIO.Increment = 0.25R
        Me.SALARIO.Location = New System.Drawing.Point(162, 65)
        Me.SALARIO.MaxValue = 1000.0R
        Me.SALARIO.MinValue = 0R
        Me.SALARIO.Name = "SALARIO"
        Me.SALARIO.ShowUpDown = True
        Me.SALARIO.Size = New System.Drawing.Size(80, 20)
        Me.SALARIO.TabIndex = 15
        '
        'GroupGeneral
        '
        Me.GroupGeneral.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupGeneral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupGeneral.Controls.Add(Me.SALARIO)
        Me.GroupGeneral.Controls.Add(Me.LabelX10)
        Me.GroupGeneral.Controls.Add(Me.LabelX6)
        Me.GroupGeneral.Controls.Add(Me.ButtonX1)
        Me.GroupGeneral.Controls.Add(Me.IMAGENES)
        Me.GroupGeneral.Controls.Add(Me.LabelX3)
        Me.GroupGeneral.Controls.Add(Me.IVA)
        Me.GroupGeneral.Controls.Add(Me.LabelX2)
        Me.GroupGeneral.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupGeneral.Location = New System.Drawing.Point(173, 135)
        Me.GroupGeneral.Name = "GroupGeneral"
        Me.GroupGeneral.Size = New System.Drawing.Size(452, 294)
        '
        '
        '
        Me.GroupGeneral.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupGeneral.Style.BackColorGradientAngle = 90
        Me.GroupGeneral.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupGeneral.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupGeneral.Style.BorderBottomWidth = 1
        Me.GroupGeneral.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupGeneral.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupGeneral.Style.BorderLeftWidth = 1
        Me.GroupGeneral.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupGeneral.Style.BorderRightWidth = 1
        Me.GroupGeneral.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupGeneral.Style.BorderTopWidth = 1
        Me.GroupGeneral.Style.CornerDiameter = 4
        Me.GroupGeneral.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupGeneral.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupGeneral.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupGeneral.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupGeneral.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupGeneral.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupGeneral.TabIndex = 114
        Me.GroupGeneral.Text = "Configuración General"
        '
        'Convenio
        '
        Me.Convenio.CanvasColor = System.Drawing.SystemColors.Control
        Me.Convenio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Convenio.Controls.Add(Me.minconvenio)
        Me.Convenio.Controls.Add(Me.Label3)
        Me.Convenio.Controls.Add(Me.anticipo)
        Me.Convenio.Controls.Add(Me.Label1)
        Me.Convenio.Controls.Add(Me.NumConvenio)
        Me.Convenio.Controls.Add(Me.TxtPreConvenio)
        Me.Convenio.Controls.Add(Me.LblSufijo)
        Me.Convenio.Controls.Add(Me.LblNumero)
        Me.Convenio.Controls.Add(Me.LblPrefijo)
        Me.Convenio.Controls.Add(Me.LblNoConvenio)
        Me.Convenio.Controls.Add(Me.TxtSufConvenio)
        Me.Convenio.DisabledBackColor = System.Drawing.Color.Empty
        Me.Convenio.Location = New System.Drawing.Point(16, 7)
        Me.Convenio.Name = "Convenio"
        Me.Convenio.Size = New System.Drawing.Size(420, 100)
        '
        '
        '
        Me.Convenio.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Convenio.Style.BackColorGradientAngle = 90
        Me.Convenio.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Convenio.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Convenio.Style.BorderBottomWidth = 1
        Me.Convenio.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Convenio.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Convenio.Style.BorderLeftWidth = 1
        Me.Convenio.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Convenio.Style.BorderRightWidth = 1
        Me.Convenio.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Convenio.Style.BorderTopWidth = 1
        Me.Convenio.Style.CornerDiameter = 4
        Me.Convenio.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Convenio.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Convenio.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Convenio.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Convenio.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Convenio.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Convenio.TabIndex = 119
        Me.Convenio.Text = "Convenio"
        '
        'minconvenio
        '
        '
        '
        '
        Me.minconvenio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.minconvenio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.minconvenio.Location = New System.Drawing.Point(310, 54)
        Me.minconvenio.MaxValue = 100000
        Me.minconvenio.MinValue = 0
        Me.minconvenio.Name = "minconvenio"
        Me.minconvenio.ShowUpDown = True
        Me.minconvenio.Size = New System.Drawing.Size(80, 20)
        Me.minconvenio.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(187, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "$ Minimo para elaborar "
        '
        'anticipo
        '
        Me.anticipo.Location = New System.Drawing.Point(134, 53)
        Me.anticipo.Name = "anticipo"
        Me.anticipo.Size = New System.Drawing.Size(43, 20)
        Me.anticipo.TabIndex = 124
        Me.anticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "% Anticipo Convenio"
        '
        'TxtSufConvenio
        '
        '
        '
        '
        Me.TxtSufConvenio.Border.Class = "TextBoxBorder"
        Me.TxtSufConvenio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtSufConvenio.Location = New System.Drawing.Point(290, 28)
        Me.TxtSufConvenio.MaxLength = 10
        Me.TxtSufConvenio.Name = "TxtSufConvenio"
        Me.TxtSufConvenio.Size = New System.Drawing.Size(100, 20)
        Me.TxtSufConvenio.TabIndex = 122
        '
        'NumConvenio
        '
        '
        '
        '
        Me.NumConvenio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NumConvenio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NumConvenio.Location = New System.Drawing.Point(204, 28)
        Me.NumConvenio.MaxValue = 99999
        Me.NumConvenio.MinValue = 1
        Me.NumConvenio.Name = "NumConvenio"
        Me.NumConvenio.ShowUpDown = True
        Me.NumConvenio.Size = New System.Drawing.Size(80, 20)
        Me.NumConvenio.TabIndex = 1
        Me.NumConvenio.Value = 1
        '
        'TxtPreConvenio
        '
        '
        '
        '
        Me.TxtPreConvenio.Border.Class = "TextBoxBorder"
        Me.TxtPreConvenio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtPreConvenio.Location = New System.Drawing.Point(129, 28)
        Me.TxtPreConvenio.MaxLength = 11
        Me.TxtPreConvenio.Name = "TxtPreConvenio"
        Me.TxtPreConvenio.Size = New System.Drawing.Size(69, 20)
        Me.TxtPreConvenio.TabIndex = 120
        '
        'LblSufijo
        '
        Me.LblSufijo.AutoSize = True
        Me.LblSufijo.BackColor = System.Drawing.Color.Transparent
        Me.LblSufijo.Location = New System.Drawing.Point(297, 4)
        Me.LblSufijo.Name = "LblSufijo"
        Me.LblSufijo.Size = New System.Drawing.Size(33, 13)
        Me.LblSufijo.TabIndex = 119
        Me.LblSufijo.Text = "Sufijo"
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.BackColor = System.Drawing.Color.Transparent
        Me.LblNumero.Location = New System.Drawing.Point(201, 4)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(44, 13)
        Me.LblNumero.TabIndex = 0
        Me.LblNumero.Text = "Numero"
        '
        'LblPrefijo
        '
        Me.LblPrefijo.AutoSize = True
        Me.LblPrefijo.BackColor = System.Drawing.Color.Transparent
        Me.LblPrefijo.Location = New System.Drawing.Point(126, 4)
        Me.LblPrefijo.Name = "LblPrefijo"
        Me.LblPrefijo.Size = New System.Drawing.Size(36, 13)
        Me.LblPrefijo.TabIndex = 117
        Me.LblPrefijo.Text = "Prefijo"
        '
        'LblNoConvenio
        '
        Me.LblNoConvenio.AutoSize = True
        Me.LblNoConvenio.BackColor = System.Drawing.Color.Transparent
        Me.LblNoConvenio.Location = New System.Drawing.Point(12, 30)
        Me.LblNoConvenio.Name = "LblNoConvenio"
        Me.LblNoConvenio.Size = New System.Drawing.Size(52, 13)
        Me.LblNoConvenio.TabIndex = 116
        Me.LblNoConvenio.Text = "Convenio"
        '
        'Panelrequerimientos
        '
        Me.Panelrequerimientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panelrequerimientos.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panelrequerimientos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Panelrequerimientos.Controls.Add(Me.IIdiasembargo)
        Me.Panelrequerimientos.Controls.Add(Me.IIdiasremate)
        Me.Panelrequerimientos.Controls.Add(Me.IIdiascorte)
        Me.Panelrequerimientos.Controls.Add(Me.IIdiasaviso24)
        Me.Panelrequerimientos.Controls.Add(Me.IIdiasrequeri)
        Me.Panelrequerimientos.Controls.Add(Me.Label16)
        Me.Panelrequerimientos.Controls.Add(Me.Label15)
        Me.Panelrequerimientos.Controls.Add(Me.Label14)
        Me.Panelrequerimientos.Controls.Add(Me.Label13)
        Me.Panelrequerimientos.Controls.Add(Me.Label12)
        Me.Panelrequerimientos.DisabledBackColor = System.Drawing.Color.Empty
        Me.Panelrequerimientos.Location = New System.Drawing.Point(173, 122)
        Me.Panelrequerimientos.Name = "Panelrequerimientos"
        Me.Panelrequerimientos.Size = New System.Drawing.Size(459, 301)
        '
        '
        '
        Me.Panelrequerimientos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Panelrequerimientos.Style.BackColorGradientAngle = 90
        Me.Panelrequerimientos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Panelrequerimientos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Panelrequerimientos.Style.BorderBottomWidth = 1
        Me.Panelrequerimientos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panelrequerimientos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Panelrequerimientos.Style.BorderLeftWidth = 1
        Me.Panelrequerimientos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Panelrequerimientos.Style.BorderRightWidth = 1
        Me.Panelrequerimientos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Panelrequerimientos.Style.BorderTopWidth = 1
        Me.Panelrequerimientos.Style.CornerDiameter = 4
        Me.Panelrequerimientos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Panelrequerimientos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Panelrequerimientos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panelrequerimientos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Panelrequerimientos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Panelrequerimientos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Panelrequerimientos.TabIndex = 119
        Me.Panelrequerimientos.Text = "Panel de configuración de requerimientos"
        '
        'IIdiasembargo
        '
        '
        '
        '
        Me.IIdiasembargo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIdiasembargo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIdiasembargo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIdiasembargo.Location = New System.Drawing.Point(214, 91)
        Me.IIdiasembargo.Name = "IIdiasembargo"
        Me.IIdiasembargo.ShowUpDown = True
        Me.IIdiasembargo.Size = New System.Drawing.Size(80, 20)
        Me.IIdiasembargo.TabIndex = 3
        Me.IIdiasembargo.Value = 1
        '
        'IIdiasremate
        '
        '
        '
        '
        Me.IIdiasremate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIdiasremate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIdiasremate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIdiasremate.Location = New System.Drawing.Point(214, 115)
        Me.IIdiasremate.Name = "IIdiasremate"
        Me.IIdiasremate.ShowUpDown = True
        Me.IIdiasremate.Size = New System.Drawing.Size(80, 20)
        Me.IIdiasremate.TabIndex = 4
        Me.IIdiasremate.Value = 1
        '
        'IIdiascorte
        '
        '
        '
        '
        Me.IIdiascorte.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIdiascorte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIdiascorte.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIdiascorte.Location = New System.Drawing.Point(214, 67)
        Me.IIdiascorte.Name = "IIdiascorte"
        Me.IIdiascorte.ShowUpDown = True
        Me.IIdiascorte.Size = New System.Drawing.Size(80, 20)
        Me.IIdiascorte.TabIndex = 2
        Me.IIdiascorte.Value = 1
        '
        'IIdiasaviso24
        '
        '
        '
        '
        Me.IIdiasaviso24.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIdiasaviso24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIdiasaviso24.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIdiasaviso24.Location = New System.Drawing.Point(214, 43)
        Me.IIdiasaviso24.Name = "IIdiasaviso24"
        Me.IIdiasaviso24.ShowUpDown = True
        Me.IIdiasaviso24.Size = New System.Drawing.Size(80, 20)
        Me.IIdiasaviso24.TabIndex = 1
        Me.IIdiasaviso24.Value = 1
        '
        'IIdiasrequeri
        '
        '
        '
        '
        Me.IIdiasrequeri.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIdiasrequeri.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIdiasrequeri.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIdiasrequeri.Location = New System.Drawing.Point(214, 19)
        Me.IIdiasrequeri.Name = "IIdiasrequeri"
        Me.IIdiasrequeri.ShowUpDown = True
        Me.IIdiasrequeri.Size = New System.Drawing.Size(80, 20)
        Me.IIdiasrequeri.TabIndex = 0
        Me.IIdiasrequeri.Value = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(18, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(149, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Dias para emision de embargo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(18, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(175, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Dias para emision de aviso de corte"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(18, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Dias para emision de aviso de 24 horas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(18, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Dias para emision de remate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(18, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Dias para la emision requerimientos"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtgas3)
        Me.GroupPanel1.Controls.Add(Me.txtgas2)
        Me.GroupPanel1.Controls.Add(Me.txtgas1)
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.LabelX9)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.TxtSufRequeri)
        Me.GroupPanel1.Controls.Add(Me.NumRequeri)
        Me.GroupPanel1.Controls.Add(Me.TxtPreRequeri)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(17, 113)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(420, 101)
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
        Me.GroupPanel1.TabIndex = 118
        Me.GroupPanel1.Text = "Requerimientos"
        Me.GroupPanel1.Visible = False
        '
        'txtgas3
        '
        Me.txtgas3.Location = New System.Drawing.Point(306, 58)
        Me.txtgas3.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtgas3.Name = "txtgas3"
        Me.txtgas3.Size = New System.Drawing.Size(61, 20)
        Me.txtgas3.TabIndex = 128
        Me.txtgas3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtgas2
        '
        Me.txtgas2.Location = New System.Drawing.Point(230, 57)
        Me.txtgas2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtgas2.Name = "txtgas2"
        Me.txtgas2.Size = New System.Drawing.Size(61, 20)
        Me.txtgas2.TabIndex = 127
        Me.txtgas2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtgas1
        '
        Me.txtgas1.Location = New System.Drawing.Point(154, 57)
        Me.txtgas1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtgas1.Name = "txtgas1"
        Me.txtgas1.Size = New System.Drawing.Size(61, 20)
        Me.txtgas1.TabIndex = 126
        Me.txtgas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(313, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Tercero"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(233, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Segundo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(151, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "Primero"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(29, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Requerimiento"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(11, 56)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(116, 21)
        Me.LabelX9.TabIndex = 118
        Me.LabelX9.Text = "Gastos de cobranza $"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(11, 54)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(47, 11)
        Me.LabelX8.TabIndex = 117
        Me.LabelX8.Text = "Gastos de cobranza"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(324, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Sufijo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(225, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Numero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(157, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Prefijo"
        '
        'TxtSufRequeri
        '
        '
        '
        '
        Me.TxtSufRequeri.Border.Class = "TextBoxBorder"
        Me.TxtSufRequeri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtSufRequeri.Location = New System.Drawing.Point(307, 17)
        Me.TxtSufRequeri.MaxLength = 10
        Me.TxtSufRequeri.Name = "TxtSufRequeri"
        Me.TxtSufRequeri.Size = New System.Drawing.Size(100, 20)
        Me.TxtSufRequeri.TabIndex = 113
        '
        'NumRequeri
        '
        '
        '
        '
        Me.NumRequeri.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NumRequeri.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NumRequeri.Location = New System.Drawing.Point(221, 17)
        Me.NumRequeri.MaxValue = 99999
        Me.NumRequeri.MinValue = 1
        Me.NumRequeri.Name = "NumRequeri"
        Me.NumRequeri.ShowUpDown = True
        Me.NumRequeri.Size = New System.Drawing.Size(80, 20)
        Me.NumRequeri.TabIndex = 112
        Me.NumRequeri.Value = 1
        '
        'TxtPreRequeri
        '
        '
        '
        '
        Me.TxtPreRequeri.Border.Class = "TextBoxBorder"
        Me.TxtPreRequeri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtPreRequeri.Location = New System.Drawing.Point(146, 17)
        Me.TxtPreRequeri.MaxLength = 10
        Me.TxtPreRequeri.Name = "TxtPreRequeri"
        Me.TxtPreRequeri.Size = New System.Drawing.Size(69, 20)
        Me.TxtPreRequeri.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Escriba la clave del concepto de la orden de corte"
        Me.Label2.Visible = False
        '
        'txtcorte
        '
        '
        '
        '
        Me.txtcorte.Border.Class = "TextBoxBorder"
        Me.txtcorte.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcorte.Location = New System.Drawing.Point(269, 247)
        Me.txtcorte.MaxLength = 3
        Me.txtcorte.Name = "txtcorte"
        Me.txtcorte.Size = New System.Drawing.Size(50, 20)
        Me.txtcorte.TabIndex = 113
        Me.txtcorte.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(18, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "% de cobro mensual para Cargos"
        Me.Label4.Visible = False
        '
        'recdocumentos
        '
        Me.recdocumentos.Location = New System.Drawing.Point(199, 220)
        Me.recdocumentos.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.recdocumentos.Name = "recdocumentos"
        Me.recdocumentos.Size = New System.Drawing.Size(65, 20)
        Me.recdocumentos.TabIndex = 117
        Me.recdocumentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.recdocumentos.Visible = False
        '
        'GroupDocumentos
        '
        Me.GroupDocumentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GroupDocumentos.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupDocumentos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupDocumentos.Controls.Add(Me.recdocumentos)
        Me.GroupDocumentos.Controls.Add(Me.Label4)
        Me.GroupDocumentos.Controls.Add(Me.txtcorte)
        Me.GroupDocumentos.Controls.Add(Me.Label2)
        Me.GroupDocumentos.Controls.Add(Me.GroupPanel1)
        Me.GroupDocumentos.Controls.Add(Me.Convenio)
        Me.GroupDocumentos.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupDocumentos.Location = New System.Drawing.Point(173, 125)
        Me.GroupDocumentos.Name = "GroupDocumentos"
        Me.GroupDocumentos.Size = New System.Drawing.Size(454, 301)
        '
        '
        '
        Me.GroupDocumentos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupDocumentos.Style.BackColorGradientAngle = 90
        Me.GroupDocumentos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupDocumentos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDocumentos.Style.BorderBottomWidth = 1
        Me.GroupDocumentos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupDocumentos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDocumentos.Style.BorderLeftWidth = 1
        Me.GroupDocumentos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDocumentos.Style.BorderRightWidth = 1
        Me.GroupDocumentos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDocumentos.Style.BorderTopWidth = 1
        Me.GroupDocumentos.Style.CornerDiameter = 4
        Me.GroupDocumentos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupDocumentos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupDocumentos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupDocumentos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupDocumentos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupDocumentos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupDocumentos.TabIndex = 1
        Me.GroupDocumentos.Text = "Panel de configuración Convenios y Mantenimiento de tomas"
        '
        'configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 483)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AdvTree1)
        Me.Controls.Add(Me.Panelrequerimientos)
        Me.Controls.Add(Me.GroupDocumentos)
        Me.Controls.Add(Me.GroupGeneral)
        Me.Controls.Add(Me.GroupMedicion)
        Me.Controls.Add(Me.GPCaja)
        Me.DoubleBuffered = True
        Me.Name = "configuracion"
        Me.Text = "Configuración"
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdvTree1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPCaja.ResumeLayout(False)
        Me.GroupMedicion.ResumeLayout(False)
        CType(Me.IVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALARIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupGeneral.ResumeLayout(False)
        Me.Convenio.ResumeLayout(False)
        Me.Convenio.PerformLayout()
        CType(Me.minconvenio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anticipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumConvenio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelrequerimientos.ResumeLayout(False)
        Me.Panelrequerimientos.PerformLayout()
        CType(Me.IIdiasembargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIdiasremate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIdiascorte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIdiasaviso24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIdiasrequeri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.txtgas3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgas2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRequeri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.recdocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDocumentos.ResumeLayout(False)
        Me.GroupDocumentos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Node2 As DevComponents.AdvTree.Node
    Friend WithEvents Node3 As DevComponents.AdvTree.Node
    Friend WithEvents BtnGenerales As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnconvenios As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnMedicion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Cell1 As DevComponents.AdvTree.Cell
    Friend WithEvents lblgenerales As DevComponents.DotNetBar.LabelX
    Friend WithEvents Cell2 As DevComponents.AdvTree.Cell
    Friend WithEvents lblcobranza As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblmedicion As DevComponents.DotNetBar.LabelX
    Friend WithEvents Cell3 As DevComponents.AdvTree.Cell
    Friend WithEvents Node4 As DevComponents.AdvTree.Node
    Friend WithEvents LblCajas As DevComponents.DotNetBar.LabelX
    Friend WithEvents Cell4 As DevComponents.AdvTree.Cell
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Node5 As DevComponents.AdvTree.Node
    Friend WithEvents lblrequerimiento As DevComponents.DotNetBar.LabelX
    Friend WithEvents Cell5 As DevComponents.AdvTree.Cell
    Friend WithEvents TxtRuta As Controls.TextBoxX
    Friend WithEvents BtnBuscar As ButtonX
    Friend WithEvents TxtBase As Controls.TextBoxX
    Friend WithEvents LabelX4 As LabelX
    Friend WithEvents BtnBase As ButtonX
    Friend WithEvents BtnActualizar As ButtonX
    Friend WithEvents GPCaja As Controls.GroupPanel
    Friend WithEvents LabelX5 As LabelX
    Friend WithEvents LabelX1 As LabelX
    Friend WithEvents TXTSIT As Controls.TextBoxX
    Friend WithEvents LblRutaArchivosXml As LabelX
    Friend WithEvents TxtXml As Controls.TextBoxX
    Friend WithEvents BtnRutaXml As ButtonX
    Friend WithEvents LabelX7 As LabelX
    Friend WithEvents txtdisparada As Controls.TextBoxX
    Friend WithEvents GroupMedicion As Controls.GroupPanel
    Friend WithEvents LabelX2 As LabelX
    Friend WithEvents IVA As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX3 As LabelX
    Friend WithEvents IMAGENES As Controls.TextBoxX
    Friend WithEvents ButtonX1 As ButtonX
    Friend WithEvents LabelX6 As LabelX
    Friend WithEvents LabelX10 As LabelX
    Friend WithEvents SALARIO As DevComponents.Editors.DoubleInput
    Friend WithEvents GroupGeneral As Controls.GroupPanel
    Friend WithEvents Convenio As Controls.GroupPanel
    Friend WithEvents minconvenio As DevComponents.Editors.IntegerInput
    Friend WithEvents Label3 As Label
    Friend WithEvents anticipo As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSufConvenio As Controls.TextBoxX
    Friend WithEvents NumConvenio As DevComponents.Editors.IntegerInput
    Friend WithEvents TxtPreConvenio As Controls.TextBoxX
    Friend WithEvents LblSufijo As Label
    Friend WithEvents LblNumero As Label
    Friend WithEvents LblPrefijo As Label
    Friend WithEvents LblNoConvenio As Label
    Friend WithEvents Panelrequerimientos As Controls.GroupPanel
    Friend WithEvents IIdiasembargo As DevComponents.Editors.IntegerInput
    Friend WithEvents IIdiasremate As DevComponents.Editors.IntegerInput
    Friend WithEvents IIdiascorte As DevComponents.Editors.IntegerInput
    Friend WithEvents IIdiasaviso24 As DevComponents.Editors.IntegerInput
    Friend WithEvents IIdiasrequeri As DevComponents.Editors.IntegerInput
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupPanel1 As Controls.GroupPanel
    Friend WithEvents txtgas3 As NumericUpDown
    Friend WithEvents txtgas2 As NumericUpDown
    Friend WithEvents txtgas1 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelX9 As LabelX
    Friend WithEvents LabelX8 As LabelX
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtSufRequeri As Controls.TextBoxX
    Friend WithEvents NumRequeri As DevComponents.Editors.IntegerInput
    Friend WithEvents TxtPreRequeri As Controls.TextBoxX
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcorte As Controls.TextBoxX
    Friend WithEvents Label4 As Label
    Friend WithEvents recdocumentos As NumericUpDown
    Friend WithEvents GroupDocumentos As Controls.GroupPanel
End Class
