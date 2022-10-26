<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerificarLecturas
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
        Me.TxtObservacion = New System.Windows.Forms.TextBox
        Me.LblTitObservacion = New System.Windows.Forms.Label
        Me.CmbSituacion = New System.Windows.Forms.ComboBox
        Me.LblTitSituacion = New System.Windows.Forms.Label
        Me.LblTitAnterior = New System.Windows.Forms.Label
        Me.TxtLectura = New System.Windows.Forms.TextBox
        Me.LblTitLectura = New System.Windows.Forms.Label
        Me.LblTarifa = New System.Windows.Forms.Label
        Me.LblTitTarifa = New System.Windows.Forms.Label
        Me.LblEstado = New System.Windows.Forms.Label
        Me.LblTitEstado = New System.Windows.Forms.Label
        Me.LblUbicacion = New System.Windows.Forms.Label
        Me.LblTitUbicacion = New System.Windows.Forms.Label
        Me.LblMedidor = New System.Windows.Forms.Label
        Me.LblTitMedidor = New System.Windows.Forms.Label
        Me.LblDireccion = New System.Windows.Forms.Label
        Me.LblTitDireccion = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblTitNombre = New System.Windows.Forms.Label
        Me.LblTitCuenta = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.LblSector = New System.Windows.Forms.ToolStripLabel
        Me.CmbComunidad = New System.Windows.Forms.ToolStripComboBox
        Me.LblRegion = New System.Windows.Forms.ToolStripLabel
        Me.CmbRegion = New System.Windows.Forms.ToolStripComboBox
        Me.LblRuta = New System.Windows.Forms.ToolStripLabel
        Me.CmbRuta = New System.Windows.Forms.ToolStripComboBox
        Me.LblLecturista = New System.Windows.Forms.ToolStripLabel
        Me.CmbLecturistas = New System.Windows.Forms.ToolStripComboBox
        Me.CmbBuscar = New System.Windows.Forms.ToolStripButton
        Me.CmbSituacion2 = New System.Windows.Forms.ComboBox
        Me.CmbSituacion3 = New System.Windows.Forms.ComboBox
        Me.DTMEs = New System.Windows.Forms.DateTimePicker
        Me.LblNumLec = New DevComponents.DotNetBar.LabelX
        Me.BtnSiguiente = New DevComponents.DotNetBar.ButtonX
        Me.LblAnterior = New DevComponents.DotNetBar.LabelX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar
        Me.BtnReiniciar = New DevComponents.DotNetBar.ButtonItem
        Me.BtnListado = New DevComponents.DotNetBar.ButtonItem
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem
        Me.TSPeriodos = New System.Windows.Forms.ToolStrip
        Me.LblFechaLectura = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.LblAnterior2 = New DevComponents.DotNetBar.LabelX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.TxtCuenta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.ToolStrip1.SuspendLayout()
        Me.TSPeriodos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(213, 406)
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(436, 29)
        Me.TxtObservacion.TabIndex = 26
        '
        'LblTitObservacion
        '
        Me.LblTitObservacion.AutoSize = True
        Me.LblTitObservacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitObservacion.Location = New System.Drawing.Point(23, 406)
        Me.LblTitObservacion.Name = "LblTitObservacion"
        Me.LblTitObservacion.Size = New System.Drawing.Size(117, 22)
        Me.LblTitObservacion.TabIndex = 31
        Me.LblTitObservacion.Text = "Observacion"
        '
        'CmbSituacion
        '
        Me.CmbSituacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion.FormattingEnabled = True
        Me.CmbSituacion.Location = New System.Drawing.Point(213, 295)
        Me.CmbSituacion.Name = "CmbSituacion"
        Me.CmbSituacion.Size = New System.Drawing.Size(48, 30)
        Me.CmbSituacion.TabIndex = 23
        '
        'LblTitSituacion
        '
        Me.LblTitSituacion.AutoSize = True
        Me.LblTitSituacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitSituacion.Location = New System.Drawing.Point(23, 295)
        Me.LblTitSituacion.Name = "LblTitSituacion"
        Me.LblTitSituacion.Size = New System.Drawing.Size(168, 22)
        Me.LblTitSituacion.TabIndex = 28
        Me.LblTitSituacion.Text = "Situacion Medicion"
        '
        'LblTitAnterior
        '
        Me.LblTitAnterior.AutoSize = True
        Me.LblTitAnterior.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitAnterior.Location = New System.Drawing.Point(26, 193)
        Me.LblTitAnterior.Name = "LblTitAnterior"
        Me.LblTitAnterior.Size = New System.Drawing.Size(119, 18)
        Me.LblTitAnterior.TabIndex = 19
        Me.LblTitAnterior.Text = "Lectura Anterior"
        '
        'TxtLectura
        '
        Me.TxtLectura.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLectura.Location = New System.Drawing.Point(213, 255)
        Me.TxtLectura.Name = "TxtLectura"
        Me.TxtLectura.Size = New System.Drawing.Size(83, 29)
        Me.TxtLectura.TabIndex = 22
        '
        'LblTitLectura
        '
        Me.LblTitLectura.AutoSize = True
        Me.LblTitLectura.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitLectura.Location = New System.Drawing.Point(23, 255)
        Me.LblTitLectura.Name = "LblTitLectura"
        Me.LblTitLectura.Size = New System.Drawing.Size(140, 22)
        Me.LblTitLectura.TabIndex = 21
        Me.LblTitLectura.Text = "Lecturas Actual"
        '
        'LblTarifa
        '
        Me.LblTarifa.AutoSize = True
        Me.LblTarifa.BackColor = System.Drawing.Color.White
        Me.LblTarifa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTarifa.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTarifa.Location = New System.Drawing.Point(445, 161)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(2, 24)
        Me.LblTarifa.TabIndex = 18
        '
        'LblTitTarifa
        '
        Me.LblTitTarifa.AutoSize = True
        Me.LblTitTarifa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitTarifa.Location = New System.Drawing.Point(337, 161)
        Me.LblTitTarifa.Name = "LblTitTarifa"
        Me.LblTitTarifa.Size = New System.Drawing.Size(48, 18)
        Me.LblTitTarifa.TabIndex = 17
        Me.LblTitTarifa.Text = "Tarifa"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.White
        Me.LblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEstado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(133, 161)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(2, 24)
        Me.LblEstado.TabIndex = 16
        '
        'LblTitEstado
        '
        Me.LblTitEstado.AutoSize = True
        Me.LblTitEstado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitEstado.Location = New System.Drawing.Point(25, 161)
        Me.LblTitEstado.Name = "LblTitEstado"
        Me.LblTitEstado.Size = New System.Drawing.Size(58, 18)
        Me.LblTitEstado.TabIndex = 15
        Me.LblTitEstado.Text = "Estado"
        '
        'LblUbicacion
        '
        Me.LblUbicacion.AutoSize = True
        Me.LblUbicacion.BackColor = System.Drawing.Color.White
        Me.LblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUbicacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacion.Location = New System.Drawing.Point(133, 136)
        Me.LblUbicacion.Name = "LblUbicacion"
        Me.LblUbicacion.Size = New System.Drawing.Size(2, 24)
        Me.LblUbicacion.TabIndex = 14
        '
        'LblTitUbicacion
        '
        Me.LblTitUbicacion.AutoSize = True
        Me.LblTitUbicacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitUbicacion.Location = New System.Drawing.Point(25, 136)
        Me.LblTitUbicacion.Name = "LblTitUbicacion"
        Me.LblTitUbicacion.Size = New System.Drawing.Size(89, 18)
        Me.LblTitUbicacion.TabIndex = 13
        Me.LblTitUbicacion.Text = "Comunidad"
        '
        'LblMedidor
        '
        Me.LblMedidor.AutoSize = True
        Me.LblMedidor.BackColor = System.Drawing.Color.White
        Me.LblMedidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMedidor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedidor.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblMedidor.Location = New System.Drawing.Point(445, 61)
        Me.LblMedidor.Name = "LblMedidor"
        Me.LblMedidor.Size = New System.Drawing.Size(2, 24)
        Me.LblMedidor.TabIndex = 8
        '
        'LblTitMedidor
        '
        Me.LblTitMedidor.AutoSize = True
        Me.LblTitMedidor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitMedidor.Location = New System.Drawing.Point(337, 61)
        Me.LblTitMedidor.Name = "LblTitMedidor"
        Me.LblTitMedidor.Size = New System.Drawing.Size(66, 18)
        Me.LblTitMedidor.TabIndex = 7
        Me.LblTitMedidor.Text = "Medidor"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.White
        Me.LblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDireccion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(133, 111)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(2, 24)
        Me.LblDireccion.TabIndex = 12
        '
        'LblTitDireccion
        '
        Me.LblTitDireccion.AutoSize = True
        Me.LblTitDireccion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitDireccion.Location = New System.Drawing.Point(25, 111)
        Me.LblTitDireccion.Name = "LblTitDireccion"
        Me.LblTitDireccion.Size = New System.Drawing.Size(75, 18)
        Me.LblTitDireccion.TabIndex = 11
        Me.LblTitDireccion.Text = "Direccion"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.White
        Me.LblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(133, 86)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(2, 24)
        Me.LblNombre.TabIndex = 10
        '
        'LblTitNombre
        '
        Me.LblTitNombre.AutoSize = True
        Me.LblTitNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitNombre.Location = New System.Drawing.Point(25, 86)
        Me.LblTitNombre.Name = "LblTitNombre"
        Me.LblTitNombre.Size = New System.Drawing.Size(64, 18)
        Me.LblTitNombre.TabIndex = 9
        Me.LblTitNombre.Text = "Nombre"
        '
        'LblTitCuenta
        '
        Me.LblTitCuenta.AutoSize = True
        Me.LblTitCuenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitCuenta.Location = New System.Drawing.Point(26, 61)
        Me.LblTitCuenta.Name = "LblTitCuenta"
        Me.LblTitCuenta.Size = New System.Drawing.Size(58, 18)
        Me.LblTitCuenta.TabIndex = 5
        Me.LblTitCuenta.Text = "Cuenta"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblSector, Me.CmbComunidad, Me.LblRegion, Me.CmbRegion, Me.LblRuta, Me.CmbRuta, Me.LblLecturista, Me.CmbLecturistas, Me.CmbBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(987, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LblSector
        '
        Me.LblSector.Name = "LblSector"
        Me.LblSector.Size = New System.Drawing.Size(60, 22)
        Me.LblSector.Text = "Comunidad"
        '
        'CmbComunidad
        '
        Me.CmbComunidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbComunidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbComunidad.Name = "CmbComunidad"
        Me.CmbComunidad.Size = New System.Drawing.Size(200, 25)
        '
        'LblRegion
        '
        Me.LblRegion.Name = "LblRegion"
        Me.LblRegion.Size = New System.Drawing.Size(40, 22)
        Me.LblRegion.Text = "Region"
        '
        'CmbRegion
        '
        Me.CmbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRegion.Name = "CmbRegion"
        Me.CmbRegion.Size = New System.Drawing.Size(200, 25)
        '
        'LblRuta
        '
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(30, 22)
        Me.LblRuta.Text = "Ruta"
        '
        'CmbRuta
        '
        Me.CmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(121, 25)
        '
        'LblLecturista
        '
        Me.LblLecturista.Name = "LblLecturista"
        Me.LblLecturista.Size = New System.Drawing.Size(54, 22)
        Me.LblLecturista.Text = "Lecturista"
        '
        'CmbLecturistas
        '
        Me.CmbLecturistas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbLecturistas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbLecturistas.Name = "CmbLecturistas"
        Me.CmbLecturistas.Size = New System.Drawing.Size(200, 25)
        '
        'CmbBuscar
        '
        Me.CmbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbBuscar.Image = Global.Administativo.My.Resources.Resources.Buscar
        Me.CmbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbBuscar.Name = "CmbBuscar"
        Me.CmbBuscar.Size = New System.Drawing.Size(23, 22)
        Me.CmbBuscar.Text = "Buscar"
        '
        'CmbSituacion2
        '
        Me.CmbSituacion2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion2.FormattingEnabled = True
        Me.CmbSituacion2.Location = New System.Drawing.Point(213, 331)
        Me.CmbSituacion2.Name = "CmbSituacion2"
        Me.CmbSituacion2.Size = New System.Drawing.Size(48, 30)
        Me.CmbSituacion2.TabIndex = 24
        '
        'CmbSituacion3
        '
        Me.CmbSituacion3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion3.FormattingEnabled = True
        Me.CmbSituacion3.Location = New System.Drawing.Point(213, 367)
        Me.CmbSituacion3.Name = "CmbSituacion3"
        Me.CmbSituacion3.Size = New System.Drawing.Size(48, 30)
        Me.CmbSituacion3.TabIndex = 25
        '
        'DTMEs
        '
        Me.DTMEs.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTMEs.Location = New System.Drawing.Point(97, 2)
        Me.DTMEs.Name = "DTMEs"
        Me.DTMEs.Size = New System.Drawing.Size(103, 20)
        Me.DTMEs.TabIndex = 2
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
        Me.LblNumLec.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumLec.Location = New System.Drawing.Point(877, 57)
        Me.LblNumLec.Name = "LblNumLec"
        Me.LblNumLec.Size = New System.Drawing.Size(85, 22)
        Me.LblNumLec.TabIndex = 4
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSiguiente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSiguiente.Image = Global.Administativo.My.Resources.Resources._1rightarrow
        Me.BtnSiguiente.Location = New System.Drawing.Point(655, 406)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(62, 38)
        Me.BtnSiguiente.TabIndex = 27
        '
        'LblAnterior
        '
        Me.LblAnterior.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnterior.Location = New System.Drawing.Point(213, 190)
        Me.LblAnterior.Name = "LblAnterior"
        Me.LblAnterior.Size = New System.Drawing.Size(75, 23)
        Me.LblAnterior.TabIndex = 20
        Me.LblAnterior.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 22)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Situacion Padron"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 22)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Situacion Hidrometro"
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnReiniciar, Me.BtnListado, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(752, 452)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(165, 72)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 32
        Me.rbOp.Text = "Opciones"
        Me.rbOp.TitleVisible = False
        '
        'BtnReiniciar
        '
        Me.BtnReiniciar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnReiniciar.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.BtnReiniciar.ImagePaddingHorizontal = 8
        Me.BtnReiniciar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnReiniciar.Name = "BtnReiniciar"
        Me.BtnReiniciar.Text = "Reiniciar Verificacion"
        '
        'BtnListado
        '
        Me.BtnListado.Image = Global.Administativo.My.Resources.Resources.playlist
        Me.BtnListado.ImagePaddingHorizontal = 8
        Me.BtnListado.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnListado.Name = "BtnListado"
        Me.BtnListado.SubItemsExpandWidth = 14
        Me.BtnListado.Text = "Ver Listado"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImagePaddingHorizontal = 8
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Salir"
        '
        'TSPeriodos
        '
        Me.TSPeriodos.BackColor = System.Drawing.Color.Transparent
        Me.TSPeriodos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblFechaLectura, Me.ToolStripLabel3})
        Me.TSPeriodos.Location = New System.Drawing.Point(0, 0)
        Me.TSPeriodos.Name = "TSPeriodos"
        Me.TSPeriodos.Size = New System.Drawing.Size(987, 25)
        Me.TSPeriodos.TabIndex = 0
        Me.TSPeriodos.Text = "ToolStrip2"
        '
        'LblFechaLectura
        '
        Me.LblFechaLectura.Name = "LblFechaLectura"
        Me.LblFechaLectura.Size = New System.Drawing.Size(87, 22)
        Me.LblFechaLectura.Text = "Fecha de lectura"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel3.Text = "ToolStripLabel3"
        '
        'LblAnterior2
        '
        Me.LblAnterior2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnterior2.Location = New System.Drawing.Point(213, 222)
        Me.LblAnterior2.Name = "LblAnterior2"
        Me.LblAnterior2.Size = New System.Drawing.Size(75, 23)
        Me.LblAnterior2.TabIndex = 33
        Me.LblAnterior2.Text = "0"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(302, 265)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(130, 19)
        Me.ButtonX1.TabIndex = 39
        Me.ButtonX1.Text = "Limpiar  Situaciones"
        '
        'TxtCuenta
        '
        '
        '
        '
        Me.TxtCuenta.Border.Class = "TextBoxBorder"
        Me.TxtCuenta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuenta.Location = New System.Drawing.Point(133, 61)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(100, 29)
        Me.TxtCuenta.TabIndex = 40
        '
        'FrmVerificarLecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 539)
        Me.Controls.Add(Me.TxtCuenta)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.LblAnterior2)
        Me.Controls.Add(Me.rbOp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAnterior)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.LblNumLec)
        Me.Controls.Add(Me.DTMEs)
        Me.Controls.Add(Me.CmbSituacion3)
        Me.Controls.Add(Me.CmbSituacion2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.LblTitObservacion)
        Me.Controls.Add(Me.CmbSituacion)
        Me.Controls.Add(Me.LblTitSituacion)
        Me.Controls.Add(Me.LblTitAnterior)
        Me.Controls.Add(Me.TxtLectura)
        Me.Controls.Add(Me.LblTitLectura)
        Me.Controls.Add(Me.LblTarifa)
        Me.Controls.Add(Me.LblTitTarifa)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblTitEstado)
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
        Me.KeyPreview = True
        Me.Name = "FrmVerificarLecturas"
        Me.Text = "Verificacion Lecturas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TSPeriodos.ResumeLayout(False)
        Me.TSPeriodos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents LblTitObservacion As System.Windows.Forms.Label
    Friend WithEvents CmbSituacion As System.Windows.Forms.ComboBox
    Friend WithEvents LblTitSituacion As System.Windows.Forms.Label
    Friend WithEvents LblTitAnterior As System.Windows.Forms.Label
    Friend WithEvents TxtLectura As System.Windows.Forms.TextBox
    Friend WithEvents LblTitLectura As System.Windows.Forms.Label
    Friend WithEvents LblTarifa As System.Windows.Forms.Label
    Friend WithEvents LblTitTarifa As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LblTitEstado As System.Windows.Forms.Label
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
    Friend WithEvents LblSector As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbComunidad As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LblRuta As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbRuta As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents CmbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbSituacion2 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSituacion3 As System.Windows.Forms.ComboBox
    Friend WithEvents DTMEs As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblLecturista As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbLecturistas As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LblRegion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbRegion As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LblNumLec As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSiguiente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblAnterior As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents BtnReiniciar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnListado As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TSPeriodos As System.Windows.Forms.ToolStrip
    Friend WithEvents LblFechaLectura As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblAnterior2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtCuenta As DevComponents.DotNetBar.Controls.TextBoxX
End Class
