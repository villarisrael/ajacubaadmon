<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgrCargoNoUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Txtnombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblNombre = New DevComponents.DotNetBar.LabelX
        Me.lblDireccion = New DevComponents.DotNetBar.LabelX
        Me.TxtDireccion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblColonia = New DevComponents.DotNetBar.LabelX
        Me.TxtColonia = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.TxtComunidad = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.TxtNoExt = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.TxtNoInt = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.TxtTelefono = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.CmbConceptos = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LblConceptos = New DevComponents.DotNetBar.LabelX
        Me.gpGrid = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.dgCob = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.BtnAgregar = New DevComponents.DotNetBar.ButtonX
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX
        Me.cmdGuardar = New DevComponents.DotNetBar.ButtonX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.TxtCp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.TxtRfc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle
        Me.BtnQuitar = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subTot = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpGrid.SuspendLayout()
        CType(Me.dgCob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtnombre
        '
        '
        '
        '
        Me.Txtnombre.Border.Class = "TextBoxBorder"
        Me.Txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnombre.FocusHighlightEnabled = True
        Me.Txtnombre.Location = New System.Drawing.Point(92, 26)
        Me.Txtnombre.MaxLength = 150
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(762, 20)
        Me.Txtnombre.TabIndex = 1
        Me.Txtnombre.WatermarkText = "Escribe el nombre del usuario"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(20, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(45, 15)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDireccion.Location = New System.Drawing.Point(20, 102)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 15)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Dirección:"
        '
        'TxtDireccion
        '
        '
        '
        '
        Me.TxtDireccion.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtDireccion.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtDireccion.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtDireccion.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtDireccion.Border.Class = "TextBoxBorder"
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.FocusHighlightEnabled = True
        Me.TxtDireccion.Location = New System.Drawing.Point(92, 102)
        Me.TxtDireccion.MaxLength = 150
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(762, 20)
        Me.TxtDireccion.TabIndex = 7
        Me.TxtDireccion.WatermarkText = "Escribe la dirección del usuario"
        '
        'LblColonia
        '
        Me.LblColonia.AutoSize = True
        Me.LblColonia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblColonia.Location = New System.Drawing.Point(460, 66)
        Me.LblColonia.Name = "LblColonia"
        Me.LblColonia.Size = New System.Drawing.Size(43, 15)
        Me.LblColonia.TabIndex = 4
        Me.LblColonia.Text = "Colonia:"
        '
        'TxtColonia
        '
        '
        '
        '
        Me.TxtColonia.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtColonia.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtColonia.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtColonia.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtColonia.Border.Class = "TextBoxBorder"
        Me.TxtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtColonia.FocusHighlightEnabled = True
        Me.TxtColonia.Location = New System.Drawing.Point(522, 66)
        Me.TxtColonia.MaxLength = 50
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(332, 20)
        Me.TxtColonia.TabIndex = 5
        Me.TxtColonia.WatermarkText = "Escribe la colonia del usuario"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(20, 66)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(62, 15)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Comunidad:"
        '
        'TxtComunidad
        '
        '
        '
        '
        Me.TxtComunidad.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtComunidad.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtComunidad.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtComunidad.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtComunidad.Border.Class = "TextBoxBorder"
        Me.TxtComunidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtComunidad.FocusHighlightEnabled = True
        Me.TxtComunidad.Location = New System.Drawing.Point(92, 65)
        Me.TxtComunidad.MaxLength = 50
        Me.TxtComunidad.Name = "TxtComunidad"
        Me.TxtComunidad.Size = New System.Drawing.Size(332, 20)
        Me.TxtComunidad.TabIndex = 3
        Me.TxtComunidad.WatermarkText = "Escribe la comunidad del usuario"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(20, 138)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(38, 15)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "No Ext."
        '
        'TxtNoExt
        '
        '
        '
        '
        Me.TxtNoExt.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoExt.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoExt.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoExt.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoExt.Border.Class = "TextBoxBorder"
        Me.TxtNoExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNoExt.FocusHighlightEnabled = True
        Me.TxtNoExt.Location = New System.Drawing.Point(92, 138)
        Me.TxtNoExt.MaxLength = 10
        Me.TxtNoExt.Name = "TxtNoExt"
        Me.TxtNoExt.Size = New System.Drawing.Size(93, 20)
        Me.TxtNoExt.TabIndex = 9
        Me.TxtNoExt.WatermarkText = "Numero Exterior"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Location = New System.Drawing.Point(211, 138)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(35, 15)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "No Int."
        '
        'TxtNoInt
        '
        '
        '
        '
        Me.TxtNoInt.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoInt.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoInt.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoInt.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtNoInt.Border.Class = "TextBoxBorder"
        Me.TxtNoInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNoInt.FocusHighlightEnabled = True
        Me.TxtNoInt.Location = New System.Drawing.Point(265, 138)
        Me.TxtNoInt.MaxLength = 10
        Me.TxtNoInt.Name = "TxtNoInt"
        Me.TxtNoInt.Size = New System.Drawing.Size(87, 20)
        Me.TxtNoInt.TabIndex = 11
        Me.TxtNoInt.WatermarkText = "Numero Interior"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.Location = New System.Drawing.Point(386, 138)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(48, 15)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "Telefono:"
        '
        'TxtTelefono
        '
        '
        '
        '
        Me.TxtTelefono.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtTelefono.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtTelefono.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtTelefono.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtTelefono.Border.Class = "TextBoxBorder"
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.FocusHighlightEnabled = True
        Me.TxtTelefono.Location = New System.Drawing.Point(448, 138)
        Me.TxtTelefono.MaxLength = 15
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(150, 20)
        Me.TxtTelefono.TabIndex = 13
        Me.TxtTelefono.WatermarkText = "Telefono del usuario"
        '
        'CmbConceptos
        '
        Me.CmbConceptos.DisplayMember = "Text"
        Me.CmbConceptos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbConceptos.FocusHighlightEnabled = True
        Me.CmbConceptos.FormattingEnabled = True
        Me.CmbConceptos.ItemHeight = 14
        Me.CmbConceptos.Location = New System.Drawing.Point(92, 219)
        Me.CmbConceptos.MaxDropDownItems = 20
        Me.CmbConceptos.Name = "CmbConceptos"
        Me.CmbConceptos.Size = New System.Drawing.Size(438, 20)
        Me.CmbConceptos.TabIndex = 19
        Me.CmbConceptos.Visible = False
        Me.CmbConceptos.WatermarkText = "Selecciona el concepto a cobrar"
        '
        'LblConceptos
        '
        Me.LblConceptos.AutoSize = True
        Me.LblConceptos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblConceptos.Location = New System.Drawing.Point(20, 219)
        Me.LblConceptos.Name = "LblConceptos"
        Me.LblConceptos.Size = New System.Drawing.Size(58, 15)
        Me.LblConceptos.TabIndex = 18
        Me.LblConceptos.Text = "Conceptos:"
        '
        'gpGrid
        '
        Me.gpGrid.AllowDrop = True
        Me.gpGrid.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpGrid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpGrid.Controls.Add(Me.dgCob)
        Me.gpGrid.Location = New System.Drawing.Point(20, 245)
        Me.gpGrid.Name = "gpGrid"
        Me.gpGrid.Size = New System.Drawing.Size(834, 156)
        '
        '
        '
        Me.gpGrid.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpGrid.Style.BackColorGradientAngle = 90
        Me.gpGrid.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpGrid.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrid.Style.BorderBottomWidth = 1
        Me.gpGrid.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpGrid.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrid.Style.BorderLeftWidth = 1
        Me.gpGrid.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrid.Style.BorderRightWidth = 1
        Me.gpGrid.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrid.Style.BorderTopWidth = 1
        Me.gpGrid.Style.CornerDiameter = 4
        Me.gpGrid.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpGrid.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpGrid.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpGrid.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpGrid.TabIndex = 21
        '
        'dgCob
        '
        Me.dgCob.AllowDrop = True
        Me.dgCob.AllowUserToAddRows = False
        Me.dgCob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCob.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clave, Me.Tipo, Me.cantidad, Me.concepto, Me.subTot, Me.iva, Me.Total})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCob.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgCob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCob.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgCob.Location = New System.Drawing.Point(0, 0)
        Me.dgCob.Name = "dgCob"
        Me.dgCob.RowTemplate.Height = 24
        Me.dgCob.Size = New System.Drawing.Size(828, 150)
        Me.dgCob.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAgregar.Location = New System.Drawing.Point(552, 214)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(98, 27)
        Me.BtnAgregar.TabIndex = 20
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCancel.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.cmdCancel.Location = New System.Drawing.Point(748, 420)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(106, 38)
        Me.cmdCancel.TabIndex = 23
        Me.cmdCancel.Text = "Cerrar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdGuardar.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.cmdGuardar.Location = New System.Drawing.Point(622, 420)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(106, 38)
        Me.cmdGuardar.TabIndex = 22
        Me.cmdGuardar.Text = "Guardar"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.Location = New System.Drawing.Point(386, 183)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(18, 15)
        Me.LabelX5.TabIndex = 16
        Me.LabelX5.Text = "CP"
        '
        'TxtCp
        '
        '
        '
        '
        Me.TxtCp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtCp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtCp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtCp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtCp.Border.Class = "TextBoxBorder"
        Me.TxtCp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCp.FocusHighlightEnabled = True
        Me.TxtCp.Location = New System.Drawing.Point(421, 182)
        Me.TxtCp.MaxLength = 5
        Me.TxtCp.Name = "TxtCp"
        Me.TxtCp.Size = New System.Drawing.Size(82, 20)
        Me.TxtCp.TabIndex = 17
        Me.TxtCp.WatermarkText = "Codigo Postal"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.Location = New System.Drawing.Point(20, 178)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(34, 15)
        Me.LabelX6.TabIndex = 14
        Me.LabelX6.Text = "R.F.C."
        '
        'TxtRfc
        '
        '
        '
        '
        Me.TxtRfc.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtRfc.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtRfc.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtRfc.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtRfc.Border.Class = "TextBoxBorder"
        Me.TxtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRfc.FocusHighlightEnabled = True
        Me.TxtRfc.Location = New System.Drawing.Point(92, 178)
        Me.TxtRfc.MaxLength = 20
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(260, 20)
        Me.TxtRfc.TabIndex = 15
        Me.TxtRfc.WatermarkText = "Rfc"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.AdvTree1)
        Me.ExpandablePanel1.Location = New System.Drawing.Point(860, -6)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(348, 464)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 27
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
        Me.AdvTree1.AllowDrop = True
        Me.AdvTree1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvTree1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.AdvTree1.Location = New System.Drawing.Point(3, 25)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(342, 436)
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
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'BtnQuitar
        '
        Me.BtnQuitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnQuitar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnQuitar.Location = New System.Drawing.Point(710, 219)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(136, 27)
        Me.BtnQuitar.TabIndex = 28
        Me.BtnQuitar.Text = "Quitar partida"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Location = New System.Drawing.Point(683, 161)
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
        Me.GroupPanel1.TabIndex = 29
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(3, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(153, 34)
        Me.LabelX7.TabIndex = 1
        Me.LabelX7.Text = "Para agregar un cargo arraste un concepto al listado =>"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX7.WordWrap = True
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Location = New System.Drawing.Point(80, 407)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(354, 45)
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
        Me.GroupPanel2.TabIndex = 30
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(3, 3)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(291, 34)
        Me.LabelX8.TabIndex = 1
        Me.LabelX8.Text = "Solo permite editar el  total *"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX8.WordWrap = True
        '
        'clave
        '
        Me.clave.HeaderText = "Clave"
        Me.clave.Name = "clave"
        Me.clave.Width = 57
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Visible = False
        Me.Tipo.Width = 51
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 72
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 76
        '
        'subTot
        '
        Me.subTot.HeaderText = "SubTotal"
        Me.subTot.MaxInputLength = 10
        Me.subTot.Name = "subTot"
        Me.subTot.ReadOnly = True
        Me.subTot.Width = 73
        '
        'iva
        '
        Me.iva.HeaderText = "Iva"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        Me.iva.Width = 45
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MaxInputLength = 20
        Me.Total.Name = "Total"
        Me.Total.Width = 54
        '
        'FrmAgrCargoNoUsuario
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.BtnQuitar)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.TxtCp)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.TxtRfc)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.gpGrid)
        Me.Controls.Add(Me.LblConceptos)
        Me.Controls.Add(Me.CmbConceptos)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.TxtNoInt)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.TxtNoExt)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.TxtComunidad)
        Me.Controls.Add(Me.LblColonia)
        Me.Controls.Add(Me.TxtColonia)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Txtnombre)
        Me.KeyPreview = True
        Me.Name = "FrmAgrCargoNoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargo a usuario no registrado"
        Me.gpGrid.ResumeLayout(False)
        CType(Me.dgCob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents Txtnombre As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents lblNombre As DevComponents.DotNetBar.LabelX
	Friend WithEvents lblDireccion As DevComponents.DotNetBar.LabelX
	Friend WithEvents TxtDireccion As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents TxtColonia As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents LblColonia As DevComponents.DotNetBar.LabelX
	Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
	Friend WithEvents TxtComunidad As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
	Friend WithEvents TxtNoExt As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
	Friend WithEvents TxtNoInt As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
	Friend WithEvents TxtTelefono As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents CmbConceptos As DevComponents.DotNetBar.Controls.ComboBoxEx
	Friend WithEvents LblConceptos As DevComponents.DotNetBar.LabelX
	Friend WithEvents gpGrid As DevComponents.DotNetBar.Controls.GroupPanel
	Friend WithEvents dgCob As DevComponents.DotNetBar.Controls.DataGridViewX
	Friend WithEvents BtnAgregar As DevComponents.DotNetBar.ButtonX
	Friend WithEvents cmdCancel As DevComponents.DotNetBar.ButtonX
	Friend WithEvents cmdGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
	Friend WithEvents TxtCp As DevComponents.DotNetBar.Controls.TextBoxX
	Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtRfc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents BtnQuitar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
