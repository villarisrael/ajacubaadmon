Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCapturaLecturas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblTitObservacion = New System.Windows.Forms.Label()
        Me.LblTitSituacion = New System.Windows.Forms.Label()
        Me.LblTitAnterior = New System.Windows.Forms.Label()
        Me.LblTitLectura = New System.Windows.Forms.Label()
        Me.LblTarifa = New System.Windows.Forms.Label()
        Me.LblTitTarifa = New System.Windows.Forms.Label()
        Me.LblUbicacion = New System.Windows.Forms.Label()
        Me.LblTitUbicacion = New System.Windows.Forms.Label()
        Me.LblMedidor = New System.Windows.Forms.Label()
        Me.LblTitMedidor = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblTitDireccion = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblTitNombre = New System.Windows.Forms.Label()
        Me.LblTitCuenta = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LblRegion = New System.Windows.Forms.ToolStripLabel()
        Me.CmbRegion = New System.Windows.Forms.ToolStripComboBox()
        Me.LblRuta = New System.Windows.Forms.ToolStripLabel()
        Me.CmbRuta = New System.Windows.Forms.ToolStripComboBox()
        Me.LblLecturista = New System.Windows.Forms.ToolStripLabel()
        Me.CmbLecturistas = New System.Windows.Forms.ToolStripComboBox()
        Me.DTMEs = New System.Windows.Forms.DateTimePicker()
        Me.LblNumLec = New DevComponents.DotNetBar.LabelX()
        Me.BtnSiguiente = New DevComponents.DotNetBar.ButtonX()
        Me.LblAnterior = New DevComponents.DotNetBar.LabelX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnListado = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnFaltanteLec = New DevComponents.DotNetBar.ButtonItem()
        Me.LblMedicion = New System.Windows.Forms.Label()
        Me.LblPadron = New System.Windows.Forms.Label()
        Me.lblHidro = New System.Windows.Forms.Label()
        Me.TSPeriodos = New System.Windows.Forms.ToolStrip()
        Me.LblFechaLectura = New System.Windows.Forms.ToolStripLabel()
        Me.LblAnterior2 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCuenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CmbSituacion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CmbSituacion2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CmbSituacion3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.BtnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.Linea1 = New DevComponents.DotNetBar.LabelX()
        Me.Linea2 = New DevComponents.DotNetBar.LabelX()
        Me.GPQuitar = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.LblConsumo = New DevComponents.DotNetBar.LabelX()
        Me.LblTitConsumo = New DevComponents.DotNetBar.LabelX()
        Me.DGSit = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBLFS = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtLectura = New DevComponents.Editors.IntegerInput()
        Me.txtAn = New System.Windows.Forms.TextBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.txtcuentaanterior = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ToolStrip1.SuspendLayout()
        Me.TSPeriodos.SuspendLayout()
        CType(Me.DGSit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtLectura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitObservacion
        '
        Me.LblTitObservacion.AutoSize = True
        Me.LblTitObservacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitObservacion.Location = New System.Drawing.Point(24, 431)
        Me.LblTitObservacion.Name = "LblTitObservacion"
        Me.LblTitObservacion.Size = New System.Drawing.Size(117, 22)
        Me.LblTitObservacion.TabIndex = 34
        Me.LblTitObservacion.Text = "Observación"
        '
        'LblTitSituacion
        '
        Me.LblTitSituacion.AutoSize = True
        Me.LblTitSituacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitSituacion.Location = New System.Drawing.Point(24, 320)
        Me.LblTitSituacion.Name = "LblTitSituacion"
        Me.LblTitSituacion.Size = New System.Drawing.Size(168, 22)
        Me.LblTitSituacion.TabIndex = 25
        Me.LblTitSituacion.Text = "Situación Medición"
        '
        'LblTitAnterior
        '
        Me.LblTitAnterior.AutoSize = True
        Me.LblTitAnterior.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitAnterior.Location = New System.Drawing.Point(26, 210)
        Me.LblTitAnterior.Name = "LblTitAnterior"
        Me.LblTitAnterior.Size = New System.Drawing.Size(106, 18)
        Me.LblTitAnterior.TabIndex = 20
        Me.LblTitAnterior.Text = "Última lectura:"
        '
        'LblTitLectura
        '
        Me.LblTitLectura.AutoSize = True
        Me.LblTitLectura.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitLectura.Location = New System.Drawing.Point(24, 280)
        Me.LblTitLectura.Name = "LblTitLectura"
        Me.LblTitLectura.Size = New System.Drawing.Size(139, 22)
        Me.LblTitLectura.TabIndex = 22
        Me.LblTitLectura.Text = "Lecturas Actual"
        '
        'LblTarifa
        '
        Me.LblTarifa.AutoSize = True
        Me.LblTarifa.BackColor = System.Drawing.Color.White
        Me.LblTarifa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTarifa.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTarifa.Location = New System.Drawing.Point(134, 162)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(2, 24)
        Me.LblTarifa.TabIndex = 17
        '
        'LblTitTarifa
        '
        Me.LblTitTarifa.AutoSize = True
        Me.LblTitTarifa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitTarifa.Location = New System.Drawing.Point(26, 162)
        Me.LblTitTarifa.Name = "LblTitTarifa"
        Me.LblTitTarifa.Size = New System.Drawing.Size(46, 18)
        Me.LblTitTarifa.TabIndex = 16
        Me.LblTitTarifa.Text = "Tarifa"
        '
        'LblUbicacion
        '
        Me.LblUbicacion.AutoSize = True
        Me.LblUbicacion.BackColor = System.Drawing.Color.White
        Me.LblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUbicacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacion.Location = New System.Drawing.Point(134, 137)
        Me.LblUbicacion.Name = "LblUbicacion"
        Me.LblUbicacion.Size = New System.Drawing.Size(2, 24)
        Me.LblUbicacion.TabIndex = 13
        '
        'LblTitUbicacion
        '
        Me.LblTitUbicacion.AutoSize = True
        Me.LblTitUbicacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitUbicacion.Location = New System.Drawing.Point(26, 137)
        Me.LblTitUbicacion.Name = "LblTitUbicacion"
        Me.LblTitUbicacion.Size = New System.Drawing.Size(89, 18)
        Me.LblTitUbicacion.TabIndex = 12
        Me.LblTitUbicacion.Text = "Comunidad"
        '
        'LblMedidor
        '
        Me.LblMedidor.AutoSize = True
        Me.LblMedidor.BackColor = System.Drawing.Color.White
        Me.LblMedidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMedidor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedidor.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblMedidor.Location = New System.Drawing.Point(528, 59)
        Me.LblMedidor.Name = "LblMedidor"
        Me.LblMedidor.Size = New System.Drawing.Size(2, 24)
        Me.LblMedidor.TabIndex = 6
        '
        'LblTitMedidor
        '
        Me.LblTitMedidor.AutoSize = True
        Me.LblTitMedidor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitMedidor.Location = New System.Drawing.Point(438, 62)
        Me.LblTitMedidor.Name = "LblTitMedidor"
        Me.LblTitMedidor.Size = New System.Drawing.Size(66, 18)
        Me.LblTitMedidor.TabIndex = 5
        Me.LblTitMedidor.Text = "Medidor"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.White
        Me.LblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDireccion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(134, 112)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(2, 24)
        Me.LblDireccion.TabIndex = 11
        '
        'LblTitDireccion
        '
        Me.LblTitDireccion.AutoSize = True
        Me.LblTitDireccion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitDireccion.Location = New System.Drawing.Point(26, 112)
        Me.LblTitDireccion.Name = "LblTitDireccion"
        Me.LblTitDireccion.Size = New System.Drawing.Size(75, 18)
        Me.LblTitDireccion.TabIndex = 10
        Me.LblTitDireccion.Text = "Dirección"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.White
        Me.LblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(134, 87)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(2, 24)
        Me.LblNombre.TabIndex = 9
        '
        'LblTitNombre
        '
        Me.LblTitNombre.AutoSize = True
        Me.LblTitNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitNombre.Location = New System.Drawing.Point(26, 87)
        Me.LblTitNombre.Name = "LblTitNombre"
        Me.LblTitNombre.Size = New System.Drawing.Size(64, 18)
        Me.LblTitNombre.TabIndex = 8
        Me.LblTitNombre.Text = "Nombre"
        '
        'LblTitCuenta
        '
        Me.LblTitCuenta.AutoSize = True
        Me.LblTitCuenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitCuenta.Location = New System.Drawing.Point(26, 56)
        Me.LblTitCuenta.Name = "LblTitCuenta"
        Me.LblTitCuenta.Size = New System.Drawing.Size(58, 18)
        Me.LblTitCuenta.TabIndex = 3
        Me.LblTitCuenta.Text = "Cuenta"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblRegion, Me.CmbRegion, Me.LblRuta, Me.CmbRuta, Me.LblLecturista, Me.CmbLecturistas})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1238, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LblRegion
        '
        Me.LblRegion.Name = "LblRegion"
        Me.LblRegion.Size = New System.Drawing.Size(44, 22)
        Me.LblRegion.Text = "Región"
        '
        'CmbRegion
        '
        Me.CmbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRegion.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CmbRegion.Name = "CmbRegion"
        Me.CmbRegion.Size = New System.Drawing.Size(200, 25)
        '
        'LblRuta
        '
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(31, 22)
        Me.LblRuta.Text = "Ruta"
        '
        'CmbRuta
        '
        Me.CmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRuta.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(200, 25)
        '
        'LblLecturista
        '
        Me.LblLecturista.Name = "LblLecturista"
        Me.LblLecturista.Size = New System.Drawing.Size(58, 22)
        Me.LblLecturista.Text = "Lecturista"
        '
        'CmbLecturistas
        '
        Me.CmbLecturistas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbLecturistas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbLecturistas.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CmbLecturistas.Name = "CmbLecturistas"
        Me.CmbLecturistas.Size = New System.Drawing.Size(200, 25)
        '
        'DTMEs
        '
        Me.DTMEs.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTMEs.Location = New System.Drawing.Point(100, 3)
        Me.DTMEs.Name = "DTMEs"
        Me.DTMEs.Size = New System.Drawing.Size(99, 20)
        Me.DTMEs.TabIndex = 1
        '
        'LblNumLec
        '
        Me.LblNumLec.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LblNumLec.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LblNumLec.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LblNumLec.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LblNumLec.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LblNumLec.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblNumLec.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumLec.Location = New System.Drawing.Point(744, 52)
        Me.LblNumLec.Name = "LblNumLec"
        Me.LblNumLec.Size = New System.Drawing.Size(85, 22)
        Me.LblNumLec.TabIndex = 7
        Me.LblNumLec.Visible = False
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSiguiente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSiguiente.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.BtnSiguiente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnSiguiente.Location = New System.Drawing.Point(331, 146)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4)
        Me.BtnSiguiente.Size = New System.Drawing.Size(62, 54)
        Me.BtnSiguiente.TabIndex = 206
        Me.BtnSiguiente.Text = "Guardar"
        '
        'LblAnterior
        '
        '
        '
        '
        Me.LblAnterior.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblAnterior.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnterior.Location = New System.Drawing.Point(214, 188)
        Me.LblAnterior.Name = "LblAnterior"
        Me.LblAnterior.Size = New System.Drawing.Size(75, 23)
        Me.LblAnterior.TabIndex = 19
        Me.LblAnterior.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 22)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Situación Padrón"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 22)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Situación Hidrómetro"
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbOp.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.ContainerControlProcessDialogKey = True
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.BtnListado, Me.BtnFaltanteLec})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(633, 363)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(137, 72)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 37
        Me.rbOp.Text = "Opciones"
        '
        '
        '
        Me.rbOp.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.TitleVisible = False
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Reiniciar"
        Me.ButtonItem1.Visible = False
        '
        'BtnListado
        '
        Me.BtnListado.Image = Global.Administativo.My.Resources.Resources.playlist
        Me.BtnListado.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnListado.Name = "BtnListado"
        Me.BtnListado.SubItemsExpandWidth = 14
        Me.BtnListado.Text = "Ver Listado"
        '
        'BtnFaltanteLec
        '
        Me.BtnFaltanteLec.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnFaltanteLec.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.BtnFaltanteLec.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnFaltanteLec.Name = "BtnFaltanteLec"
        Me.BtnFaltanteLec.SubItemsExpandWidth = 14
        Me.BtnFaltanteLec.Text = "Faltantes de Captura"
        '
        'LblMedicion
        '
        Me.LblMedicion.AutoSize = True
        Me.LblMedicion.BackColor = System.Drawing.Color.White
        Me.LblMedicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMedicion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedicion.Location = New System.Drawing.Point(71, 67)
        Me.LblMedicion.Name = "LblMedicion"
        Me.LblMedicion.Size = New System.Drawing.Size(2, 24)
        Me.LblMedicion.TabIndex = 27
        '
        'LblPadron
        '
        Me.LblPadron.AutoSize = True
        Me.LblPadron.BackColor = System.Drawing.Color.White
        Me.LblPadron.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPadron.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPadron.Location = New System.Drawing.Point(71, 103)
        Me.LblPadron.Name = "LblPadron"
        Me.LblPadron.Size = New System.Drawing.Size(2, 24)
        Me.LblPadron.TabIndex = 30
        '
        'lblHidro
        '
        Me.lblHidro.AutoSize = True
        Me.lblHidro.BackColor = System.Drawing.Color.White
        Me.lblHidro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHidro.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHidro.Location = New System.Drawing.Point(71, 139)
        Me.lblHidro.Name = "lblHidro"
        Me.lblHidro.Size = New System.Drawing.Size(2, 24)
        Me.lblHidro.TabIndex = 33
        '
        'TSPeriodos
        '
        Me.TSPeriodos.BackColor = System.Drawing.Color.Transparent
        Me.TSPeriodos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblFechaLectura})
        Me.TSPeriodos.Location = New System.Drawing.Point(0, 0)
        Me.TSPeriodos.Name = "TSPeriodos"
        Me.TSPeriodos.Size = New System.Drawing.Size(1238, 25)
        Me.TSPeriodos.TabIndex = 0
        Me.TSPeriodos.Text = "ToolStrip2"
        '
        'LblFechaLectura
        '
        Me.LblFechaLectura.Name = "LblFechaLectura"
        Me.LblFechaLectura.Size = New System.Drawing.Size(93, 22)
        Me.LblFechaLectura.Text = "Fecha de lectura"
        '
        'LblAnterior2
        '
        '
        '
        '
        Me.LblAnterior2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblAnterior2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnterior2.Location = New System.Drawing.Point(214, 207)
        Me.LblAnterior2.Name = "LblAnterior2"
        Me.LblAnterior2.Size = New System.Drawing.Size(75, 23)
        Me.LblAnterior2.TabIndex = 21
        Me.LblAnterior2.Text = "0"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(106, 30)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(130, 19)
        Me.ButtonX1.TabIndex = 24
        Me.ButtonX1.TabStop = False
        Me.ButtonX1.Text = "Limpiar  Situaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Penúltima lectura:"
        '
        'TxtCuenta
        '
        '
        '
        '
        Me.TxtCuenta.Border.Class = "TextBoxBorder"
        Me.TxtCuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtCuenta.FocusHighlightEnabled = True
        Me.TxtCuenta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuenta.Location = New System.Drawing.Point(134, 59)
        Me.TxtCuenta.MaxLength = 8
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(100, 29)
        Me.TxtCuenta.TabIndex = 4
        '
        'TxtObservacion
        '
        '
        '
        '
        Me.TxtObservacion.Border.Class = "TextBoxBorder"
        Me.TxtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtObservacion.FocusHighlightEnabled = True
        Me.TxtObservacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(18, 171)
        Me.TxtObservacion.MaxLength = 45
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(307, 29)
        Me.TxtObservacion.TabIndex = 205
        '
        'CmbSituacion
        '
        Me.CmbSituacion.DisplayMember = "Text"
        Me.CmbSituacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSituacion.FocusHighlightEnabled = True
        Me.CmbSituacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion.FormattingEnabled = True
        Me.CmbSituacion.ItemHeight = 23
        Me.CmbSituacion.Location = New System.Drawing.Point(17, 62)
        Me.CmbSituacion.Name = "CmbSituacion"
        Me.CmbSituacion.Size = New System.Drawing.Size(48, 29)
        Me.CmbSituacion.TabIndex = 202
        '
        'CmbSituacion2
        '
        Me.CmbSituacion2.DisplayMember = "Text"
        Me.CmbSituacion2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSituacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSituacion2.FocusHighlightEnabled = True
        Me.CmbSituacion2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion2.FormattingEnabled = True
        Me.CmbSituacion2.ItemHeight = 23
        Me.CmbSituacion2.Location = New System.Drawing.Point(17, 103)
        Me.CmbSituacion2.Name = "CmbSituacion2"
        Me.CmbSituacion2.Size = New System.Drawing.Size(48, 29)
        Me.CmbSituacion2.TabIndex = 203
        '
        'CmbSituacion3
        '
        Me.CmbSituacion3.DisplayMember = "Text"
        Me.CmbSituacion3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSituacion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSituacion3.FocusHighlightEnabled = True
        Me.CmbSituacion3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion3.FormattingEnabled = True
        Me.CmbSituacion3.ItemHeight = 23
        Me.CmbSituacion3.Location = New System.Drawing.Point(17, 139)
        Me.CmbSituacion3.Name = "CmbSituacion3"
        Me.CmbSituacion3.Size = New System.Drawing.Size(48, 29)
        Me.CmbSituacion3.TabIndex = 204
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBuscar.Image = Global.Administativo.My.Resources.Resources.Buscar
        Me.BtnBuscar.Location = New System.Drawing.Point(867, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(130, 47)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Iniciar captura"
        '
        'Linea1
        '
        '
        '
        '
        Me.Linea1.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.Linea1.BackgroundStyle.BorderBottomWidth = 3
        Me.Linea1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Linea1.BackgroundStyle.BorderTopColor = System.Drawing.Color.DarkBlue
        Me.Linea1.BackgroundStyle.BorderTopWidth = 3
        Me.Linea1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Linea1.Location = New System.Drawing.Point(0, 51)
        Me.Linea1.Name = "Linea1"
        Me.Linea1.Size = New System.Drawing.Size(325, 10)
        Me.Linea1.TabIndex = 39
        '
        'Linea2
        '
        '
        '
        '
        Me.Linea2.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.Linea2.BackgroundStyle.BorderBottomWidth = 3
        Me.Linea2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Linea2.BackgroundStyle.BorderTopColor = System.Drawing.Color.DarkBlue
        Me.Linea2.BackgroundStyle.BorderTopWidth = 3
        Me.Linea2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Linea2.Location = New System.Drawing.Point(0, 183)
        Me.Linea2.Name = "Linea2"
        Me.Linea2.Size = New System.Drawing.Size(761, 10)
        Me.Linea2.TabIndex = 40
        '
        'GPQuitar
        '
        Me.GPQuitar.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPQuitar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPQuitar.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPQuitar.Location = New System.Drawing.Point(802, 188)
        Me.GPQuitar.Name = "GPQuitar"
        Me.GPQuitar.Size = New System.Drawing.Size(407, 180)
        '
        '
        '
        Me.GPQuitar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPQuitar.Style.BackColorGradientAngle = 90
        Me.GPQuitar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPQuitar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPQuitar.Style.BorderBottomWidth = 1
        Me.GPQuitar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPQuitar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPQuitar.Style.BorderLeftWidth = 1
        Me.GPQuitar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPQuitar.Style.BorderRightWidth = 1
        Me.GPQuitar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPQuitar.Style.BorderTopWidth = 1
        Me.GPQuitar.Style.CornerDiameter = 4
        Me.GPQuitar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPQuitar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPQuitar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPQuitar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPQuitar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPQuitar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPQuitar.TabIndex = 41
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.BtnSalir.Location = New System.Drawing.Point(1004, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(54, 47)
        Me.BtnSalir.TabIndex = 42
        '
        'LblConsumo
        '
        '
        '
        '
        Me.LblConsumo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblConsumo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsumo.Location = New System.Drawing.Point(170, 248)
        Me.LblConsumo.Name = "LblConsumo"
        Me.LblConsumo.Size = New System.Drawing.Size(75, 23)
        Me.LblConsumo.TabIndex = 43
        Me.LblConsumo.Text = "0"
        '
        'LblTitConsumo
        '
        '
        '
        '
        Me.LblTitConsumo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitConsumo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitConsumo.Location = New System.Drawing.Point(28, 248)
        Me.LblTitConsumo.Name = "LblTitConsumo"
        Me.LblTitConsumo.Size = New System.Drawing.Size(100, 23)
        Me.LblTitConsumo.TabIndex = 44
        Me.LblTitConsumo.Text = "Consumo"
        '
        'DGSit
        '
        Me.DGSit.AllowUserToAddRows = False
        Me.DGSit.AllowUserToDeleteRows = False
        Me.DGSit.AllowUserToOrderColumns = True
        Me.DGSit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Descripcion, Me.Tipo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSit.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGSit.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGSit.Location = New System.Drawing.Point(776, 183)
        Me.DGSit.Name = "DGSit"
        Me.DGSit.ReadOnly = True
        Me.DGSit.Size = New System.Drawing.Size(364, 307)
        Me.DGSit.TabIndex = 45
        '
        'Clave
        '
        Me.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Clave.DataPropertyName = "Clave"
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        Me.Clave.Width = 59
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Descripcion.DataPropertyName = "Situacion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 88
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 53
        '
        'LBLFS
        '
        Me.LBLFS.AutoSize = True
        Me.LBLFS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFS.ForeColor = System.Drawing.Color.Red
        Me.LBLFS.Location = New System.Drawing.Point(25, 474)
        Me.LBLFS.Name = "LBLFS"
        Me.LBLFS.Size = New System.Drawing.Size(544, 16)
        Me.LBLFS.TabIndex = 47
        Me.LBLFS.Text = "F4= GUARDAR   F7 = COMENZAR DE NUEVO  F10 = VER HISTORIAL DE LA CUENTA     "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtLectura)
        Me.GroupBox1.Controls.Add(Me.CmbSituacion3)
        Me.GroupBox1.Controls.Add(Me.CmbSituacion2)
        Me.GroupBox1.Controls.Add(Me.CmbSituacion)
        Me.GroupBox1.Controls.Add(Me.TxtObservacion)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.lblHidro)
        Me.GroupBox1.Controls.Add(Me.LblPadron)
        Me.GroupBox1.Controls.Add(Me.LblMedicion)
        Me.GroupBox1.Controls.Add(Me.BtnSiguiente)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 260)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 214)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        '
        'TxtLectura
        '
        '
        '
        '
        Me.TxtLectura.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtLectura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtLectura.FocusHighlightEnabled = True
        Me.TxtLectura.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TxtLectura.Location = New System.Drawing.Point(17, 19)
        Me.TxtLectura.MinValue = 0
        Me.TxtLectura.Name = "TxtLectura"
        Me.TxtLectura.ShowUpDown = True
        Me.TxtLectura.Size = New System.Drawing.Size(75, 29)
        Me.TxtLectura.TabIndex = 201
        '
        'txtAn
        '
        Me.txtAn.Location = New System.Drawing.Point(816, 25)
        Me.txtAn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAn.Name = "txtAn"
        Me.txtAn.Size = New System.Drawing.Size(46, 20)
        Me.txtAn.TabIndex = 202
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC"})
        Me.cmbmes.Location = New System.Drawing.Point(751, 26)
        Me.cmbmes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(61, 21)
        Me.cmbmes.TabIndex = 201
        '
        'txtcuentaanterior
        '
        '
        '
        '
        Me.txtcuentaanterior.Border.Class = "TextBoxBorder"
        Me.txtcuentaanterior.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcuentaanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuentaanterior.Location = New System.Drawing.Point(256, 59)
        Me.txtcuentaanterior.Name = "txtcuentaanterior"
        Me.txtcuentaanterior.PreventEnterBeep = True
        Me.txtcuentaanterior.Size = New System.Drawing.Size(138, 29)
        Me.txtcuentaanterior.TabIndex = 203
        '
        'FrmCapturaLecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAn)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.GPQuitar)
        Me.Controls.Add(Me.DGSit)
        Me.Controls.Add(Me.LblTitConsumo)
        Me.Controls.Add(Me.LblConsumo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Linea2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtCuenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblAnterior2)
        Me.Controls.Add(Me.rbOp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAnterior)
        Me.Controls.Add(Me.LblNumLec)
        Me.Controls.Add(Me.DTMEs)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LblTitObservacion)
        Me.Controls.Add(Me.LblTitSituacion)
        Me.Controls.Add(Me.LblTitAnterior)
        Me.Controls.Add(Me.LblTitLectura)
        Me.Controls.Add(Me.LblTarifa)
        Me.Controls.Add(Me.LblTitTarifa)
        Me.Controls.Add(Me.LblUbicacion)
        Me.Controls.Add(Me.LblTitUbicacion)
        Me.Controls.Add(Me.LblMedidor)
        Me.Controls.Add(Me.LblTitMedidor)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.LblTitDireccion)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblTitNombre)
        Me.Controls.Add(Me.LblTitCuenta)
        Me.Controls.Add(Me.TSPeriodos)
        Me.Controls.Add(Me.Linea1)
        Me.Controls.Add(Me.LBLFS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtcuentaanterior)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmCapturaLecturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura Lecturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TSPeriodos.ResumeLayout(False)
        Me.TSPeriodos.PerformLayout()
        CType(Me.DGSit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TxtLectura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitObservacion As System.Windows.Forms.Label
    Friend WithEvents LblTitSituacion As System.Windows.Forms.Label
    Friend WithEvents LblTitAnterior As System.Windows.Forms.Label
    Friend WithEvents LblTitLectura As System.Windows.Forms.Label
    Friend WithEvents LblTarifa As System.Windows.Forms.Label
    Friend WithEvents LblTitTarifa As System.Windows.Forms.Label
    Friend WithEvents LblUbicacion As System.Windows.Forms.Label
    Friend WithEvents LblTitUbicacion As System.Windows.Forms.Label
    Friend WithEvents LblMedidor As System.Windows.Forms.Label
    Friend WithEvents LblTitMedidor As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblTitDireccion As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblTitNombre As System.Windows.Forms.Label
    Friend WithEvents LblTitCuenta As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents LblRuta As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbRuta As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents DTMEs As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblLecturista As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbLecturistas As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LblRegion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblNumLec As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSiguiente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblAnterior As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnListado As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LblMedicion As System.Windows.Forms.Label
    Friend WithEvents LblPadron As System.Windows.Forms.Label
    Friend WithEvents lblHidro As System.Windows.Forms.Label
    Friend WithEvents TSPeriodos As System.Windows.Forms.ToolStrip
    Friend WithEvents LblFechaLectura As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblAnterior2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CmbSituacion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CmbSituacion2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CmbSituacion3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Linea1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Linea2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GPQuitar As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblConsumo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitConsumo As DevComponents.DotNetBar.LabelX
    Friend WithEvents DGSit As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnFaltanteLec As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LBLFS As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtLectura As DevComponents.Editors.IntegerInput
    Friend WithEvents txtAn As System.Windows.Forms.TextBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents txtcuentaanterior As Controls.TextBoxX
    Friend WithEvents CmbRegion As ToolStripComboBox
End Class
