<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvenio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvenio))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.GroupPerPag = New System.Windows.Forms.GroupBox
        Me.GroupAuto = New System.Windows.Forms.GroupBox
        Me.cmdCancelPer = New System.Windows.Forms.Button
        Me.txtPeriodos = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dterPag = New System.Windows.Forms.DateTimePicker
        Me.rdAuto = New System.Windows.Forms.RadioButton
        Me.rdManual = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmdCanPag = New System.Windows.Forms.Button
        Me.cmdMostrart = New System.Windows.Forms.Button
        Me.dgPag = New System.Windows.Forms.DataGridView
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNoPagares = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPeriodo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtRestante = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtVencimiento = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMotivo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTarifa = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNoConvenio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton
        Me.cmdCancelar = New System.Windows.Forms.ToolStripButton
        Me.cmdEliminar = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.CortarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.no_convenio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nopag = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label15 = New System.Windows.Forms.Label
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.LeftToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.GroupPerPag.SuspendLayout()
        Me.GroupAuto.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgPag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupPerPag)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox4)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox3)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(803, 496)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.Controls.Add(Me.ToolStrip2)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(840, 521)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'GroupPerPag
        '
        Me.GroupPerPag.Controls.Add(Me.GroupAuto)
        Me.GroupPerPag.Controls.Add(Me.rdAuto)
        Me.GroupPerPag.Controls.Add(Me.rdManual)
        Me.GroupPerPag.Location = New System.Drawing.Point(612, 22)
        Me.GroupPerPag.Name = "GroupPerPag"
        Me.GroupPerPag.Size = New System.Drawing.Size(170, 285)
        Me.GroupPerPag.TabIndex = 19
        Me.GroupPerPag.TabStop = False
        Me.GroupPerPag.Text = "Establecer periodos de pago"
        '
        'GroupAuto
        '
        Me.GroupAuto.Controls.Add(Me.Label15)
        Me.GroupAuto.Controls.Add(Me.cmdCancelPer)
        Me.GroupAuto.Controls.Add(Me.txtPeriodos)
        Me.GroupAuto.Controls.Add(Me.Label13)
        Me.GroupAuto.Controls.Add(Me.Label12)
        Me.GroupAuto.Controls.Add(Me.dterPag)
        Me.GroupAuto.Location = New System.Drawing.Point(9, 20)
        Me.GroupAuto.Name = "GroupAuto"
        Me.GroupAuto.Size = New System.Drawing.Size(155, 144)
        Me.GroupAuto.TabIndex = 20
        Me.GroupAuto.TabStop = False
        Me.GroupAuto.Visible = False
        '
        'cmdCancelPer
        '
        Me.cmdCancelPer.Location = New System.Drawing.Point(31, 118)
        Me.cmdCancelPer.Name = "cmdCancelPer"
        Me.cmdCancelPer.Size = New System.Drawing.Size(99, 20)
        Me.cmdCancelPer.TabIndex = 21
        Me.cmdCancelPer.Text = "Cancelar"
        Me.cmdCancelPer.UseVisualStyleBackColor = True
        '
        'txtPeriodos
        '
        Me.txtPeriodos.Location = New System.Drawing.Point(31, 76)
        Me.txtPeriodos.Name = "txtPeriodos"
        Me.txtPeriodos.Size = New System.Drawing.Size(99, 20)
        Me.txtPeriodos.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Periodos de :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Primer Pago:"
        '
        'dterPag
        '
        Me.dterPag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dterPag.Location = New System.Drawing.Point(31, 32)
        Me.dterPag.Name = "dterPag"
        Me.dterPag.Size = New System.Drawing.Size(99, 20)
        Me.dterPag.TabIndex = 2
        '
        'rdAuto
        '
        Me.rdAuto.AutoSize = True
        Me.rdAuto.Location = New System.Drawing.Point(31, 37)
        Me.rdAuto.Name = "rdAuto"
        Me.rdAuto.Size = New System.Drawing.Size(78, 17)
        Me.rdAuto.TabIndex = 1
        Me.rdAuto.TabStop = True
        Me.rdAuto.Text = "Automático"
        Me.rdAuto.UseVisualStyleBackColor = True
        '
        'rdManual
        '
        Me.rdManual.AutoSize = True
        Me.rdManual.Location = New System.Drawing.Point(31, 86)
        Me.rdManual.Name = "rdManual"
        Me.rdManual.Size = New System.Drawing.Size(60, 17)
        Me.rdManual.TabIndex = 0
        Me.rdManual.TabStop = True
        Me.rdManual.Text = "Manual"
        Me.rdManual.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdCanPag)
        Me.GroupBox4.Controls.Add(Me.cmdMostrart)
        Me.GroupBox4.Controls.Add(Me.dgPag)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtNoPagares)
        Me.GroupBox4.Location = New System.Drawing.Point(36, 313)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(746, 176)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'cmdCanPag
        '
        Me.cmdCanPag.Location = New System.Drawing.Point(376, 19)
        Me.cmdCanPag.Name = "cmdCanPag"
        Me.cmdCanPag.Size = New System.Drawing.Size(100, 20)
        Me.cmdCanPag.TabIndex = 20
        Me.cmdCanPag.Text = "Cancelar Pagarés"
        Me.cmdCanPag.UseVisualStyleBackColor = True
        '
        'cmdMostrart
        '
        Me.cmdMostrart.Location = New System.Drawing.Point(246, 19)
        Me.cmdMostrart.Name = "cmdMostrart"
        Me.cmdMostrart.Size = New System.Drawing.Size(100, 20)
        Me.cmdMostrart.TabIndex = 19
        Me.cmdMostrart.Text = "Mostrar Pagarés"
        Me.cmdMostrart.UseVisualStyleBackColor = True
        '
        'dgPag
        '
        Me.dgPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPag.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_convenio, Me.monto, Me.Periodo, Me.nopag, Me.fecha})
        Me.dgPag.Location = New System.Drawing.Point(16, 45)
        Me.dgPag.Name = "dgPag"
        Me.dgPag.Size = New System.Drawing.Size(714, 121)
        Me.dgPag.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "No de pagarés:"
        '
        'txtNoPagares
        '
        Me.txtNoPagares.Location = New System.Drawing.Point(104, 19)
        Me.txtNoPagares.Name = "txtNoPagares"
        Me.txtNoPagares.Size = New System.Drawing.Size(116, 20)
        Me.txtNoPagares.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPeriodo)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtRestante)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.dtVencimiento)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtMotivo)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(561, 116)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(399, 19)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.ReadOnly = True
        Me.txtPeriodo.Size = New System.Drawing.Size(133, 20)
        Me.txtPeriodo.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(313, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Periodo:"
        '
        'txtRestante
        '
        Me.txtRestante.Location = New System.Drawing.Point(399, 49)
        Me.txtRestante.Name = "txtRestante"
        Me.txtRestante.Size = New System.Drawing.Size(133, 20)
        Me.txtRestante.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(313, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Restante:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(103, 49)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(143, 20)
        Me.txtMonto.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Monto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Motivo:"
        '
        'dtVencimiento
        '
        Me.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVencimiento.Location = New System.Drawing.Point(103, 19)
        Me.dtVencimiento.Name = "dtVencimiento"
        Me.dtVencimiento.Size = New System.Drawing.Size(143, 20)
        Me.dtVencimiento.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Vencimiento:"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(103, 79)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(429, 27)
        Me.txtMotivo.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTarifa)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDir)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCuenta)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 109)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'txtTarifa
        '
        Me.txtTarifa.Location = New System.Drawing.Point(367, 19)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(165, 20)
        Me.txtTarifa.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tarifa:"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(107, 79)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(425, 20)
        Me.txtDir.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(107, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(425, 20)
        Me.txtNombre.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(107, 19)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(109, 20)
        Me.txtCuenta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. Cuenta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNoConvenio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 48)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(399, 19)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(133, 20)
        Me.dtFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'txtNoConvenio
        '
        Me.txtNoConvenio.Location = New System.Drawing.Point(107, 19)
        Me.txtNoConvenio.Name = "txtNoConvenio"
        Me.txtNoConvenio.ReadOnly = True
        Me.txtNoConvenio.Size = New System.Drawing.Size(185, 20)
        Me.txtNoConvenio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Convenio:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdCancelar, Me.cmdEliminar, Me.cmdImprimir, Me.cmdSalir})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 5)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(37, 245)
        Me.ToolStrip2.TabIndex = 0
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = Global.WindowsApplication1.My.Resources.Resources.Nuevo
        Me.cmdAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(35, 36)
        Me.cmdAgregar.Text = "ToolStripButton1"
        Me.cmdAgregar.ToolTipText = "Nuevo convenio"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = Global.WindowsApplication1.My.Resources.Resources.Editar
        Me.cmdEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(35, 36)
        Me.cmdEditar.Text = "ToolStripButton2"
        Me.cmdEditar.ToolTipText = "Editar Convenio"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.CancelarEdicion
        Me.cmdCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(35, 36)
        Me.cmdCancelar.Text = "ToolStripButton3"
        Me.cmdCancelar.ToolTipText = "Cancelar "
        '
        'cmdEliminar
        '
        Me.cmdEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminar.Image = Global.WindowsApplication1.My.Resources.Resources.Eliminar
        Me.cmdEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(35, 36)
        Me.cmdEliminar.Text = "ToolStripButton4"
        Me.cmdEliminar.ToolTipText = "Eliminar Convenio"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.imprimir
        Me.cmdImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(35, 36)
        Me.cmdImprimir.Text = "ToolStripButton5"
        Me.cmdImprimir.ToolTipText = "Imprimir Convenio"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = Global.WindowsApplication1.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(35, 36)
        Me.cmdSalir.Text = "ToolStripButton1"
        Me.cmdSalir.ToolTipText = "Salir de convenio"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(208, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Abrir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CortarToolStripButton
        '
        Me.CortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CortarToolStripButton.Image = CType(resources.GetObject("CortarToolStripButton.Image"), System.Drawing.Image)
        Me.CortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripButton.Name = "CortarToolStripButton"
        Me.CortarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CortarToolStripButton.Text = "Cort&ar"
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        '
        'PegarToolStripButton
        '
        Me.PegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), System.Drawing.Image)
        Me.PegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripButton.Name = "PegarToolStripButton"
        Me.PegarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PegarToolStripButton.Text = "&Pegar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'no_convenio
        '
        Me.no_convenio.HeaderText = "No. de Convenio"
        Me.no_convenio.Name = "no_convenio"
        Me.no_convenio.Width = 180
        '
        'monto
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.monto.DefaultCellStyle = DataGridViewCellStyle5
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        '
        'Periodo
        '
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.Width = 180
        '
        'nopag
        '
        Me.nopag.HeaderText = "No. de Pagaré"
        Me.nopag.Name = "nopag"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "semanas"
        '
        'frmConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(840, 521)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenios"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.GroupPerPag.ResumeLayout(False)
        Me.GroupPerPag.PerformLayout()
        Me.GroupAuto.ResumeLayout(False)
        Me.GroupAuto.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgPag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PegarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNoConvenio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRestante As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNoPagares As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgPag As System.Windows.Forms.DataGridView
    Friend WithEvents cmdMostrart As System.Windows.Forms.Button
    Friend WithEvents cmdCanPag As System.Windows.Forms.Button
    Friend WithEvents GroupPerPag As System.Windows.Forms.GroupBox
    Friend WithEvents rdManual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupAuto As System.Windows.Forms.GroupBox
    Friend WithEvents rdAuto As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dterPag As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPeriodos As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelPer As System.Windows.Forms.Button
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents no_convenio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
