<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSolicitudPipa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSolicitudPipa))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnReportes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtEntre = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtZona = New System.Windows.Forms.TextBox()
        Me.txtInmueble = New System.Windows.Forms.TextBox()
        Me.txtLitros = New System.Windows.Forms.TextBox()
        Me.DataGridViewPipa = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEntrego = New System.Windows.Forms.TextBox()
        Me.MonthCalendarEntrega = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendarSol = New System.Windows.Forms.MonthCalendar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbEstatus = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EditarEntrega = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblIDOrden = New System.Windows.Forms.Label()
        Me.DGVAutocomplete = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblpanel = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.txtBuscarxNom = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridViewPipa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVAutocomplete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.Editar, Me.Eliminar, Me.ToolStripSeparator1, Me.btnReportes, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1364, 41)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSize = False
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(36, 38)
        Me.btnNuevo.Text = "ToolStripButton1"
        Me.btnNuevo.ToolTipText = "Agregar Nuevo"
        '
        'Editar
        '
        Me.Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(36, 38)
        Me.Editar.Text = "ToolStripButton2"
        Me.Editar.ToolTipText = "Editar Registro"
        '
        'Eliminar
        '
        Me.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(36, 38)
        Me.Eliminar.Text = "ToolStripButton3"
        Me.Eliminar.ToolTipText = "Eliminar Registro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 41)
        '
        'btnReportes
        '
        Me.btnReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(36, 38)
        Me.btnReportes.Text = "ToolStripButton4"
        Me.btnReportes.ToolTipText = "Reportes"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(200, 74)
        Me.ToolStripLabel1.Text = "Solicitud de Pipa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Entre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(374, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Referencia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(359, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Num. Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(653, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Teléfono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(670, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Zona:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(937, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fecha Solicitud:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(650, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Inmueble:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(447, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Litros:"
        '
        'txtNombre
        '
        Me.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(442, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(198, 22)
        Me.txtNombre.TabIndex = 12
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(443, 95)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(197, 22)
        Me.txtDireccion.TabIndex = 13
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(443, 123)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(197, 22)
        Me.txtReferencia.TabIndex = 14
        '
        'txtEntre
        '
        Me.txtEntre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntre.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntre.Location = New System.Drawing.Point(442, 152)
        Me.txtEntre.Name = "txtEntre"
        Me.txtEntre.Size = New System.Drawing.Size(198, 22)
        Me.txtEntre.TabIndex = 15
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(442, 180)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(198, 22)
        Me.txtCelular.TabIndex = 16
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(712, 67)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 22)
        Me.txtTelefono.TabIndex = 17
        '
        'txtZona
        '
        Me.txtZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtZona.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona.Location = New System.Drawing.Point(712, 99)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(116, 22)
        Me.txtZona.TabIndex = 18
        '
        'txtInmueble
        '
        Me.txtInmueble.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInmueble.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInmueble.Location = New System.Drawing.Point(712, 128)
        Me.txtInmueble.Name = "txtInmueble"
        Me.txtInmueble.Size = New System.Drawing.Size(88, 22)
        Me.txtInmueble.TabIndex = 19
        '
        'txtLitros
        '
        Me.txtLitros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLitros.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLitros.Location = New System.Drawing.Point(491, 26)
        Me.txtLitros.Name = "txtLitros"
        Me.txtLitros.Size = New System.Drawing.Size(88, 22)
        Me.txtLitros.TabIndex = 20
        '
        'DataGridViewPipa
        '
        Me.DataGridViewPipa.AllowUserToAddRows = False
        Me.DataGridViewPipa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewPipa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewPipa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPipa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPipa.ColumnHeadersHeight = 30
        Me.DataGridViewPipa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewPipa.EnableHeadersVisualStyles = False
        Me.DataGridViewPipa.Location = New System.Drawing.Point(10, 234)
        Me.DataGridViewPipa.Name = "DataGridViewPipa"
        Me.DataGridViewPipa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPipa.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewPipa.Size = New System.Drawing.Size(1331, 226)
        Me.DataGridViewPipa.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(709, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fecha Entrega"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Entrego:"
        '
        'txtEntrego
        '
        Me.txtEntrego.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntrego.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrego.Location = New System.Drawing.Point(86, 24)
        Me.txtEntrego.Name = "txtEntrego"
        Me.txtEntrego.Size = New System.Drawing.Size(131, 22)
        Me.txtEntrego.TabIndex = 24
        '
        'MonthCalendarEntrega
        '
        Me.MonthCalendarEntrega.Location = New System.Drawing.Point(663, 41)
        Me.MonthCalendarEntrega.Name = "MonthCalendarEntrega"
        Me.MonthCalendarEntrega.TabIndex = 25
        '
        'MonthCalendarSol
        '
        Me.MonthCalendarSol.Location = New System.Drawing.Point(851, 60)
        Me.MonthCalendarSol.Name = "MonthCalendarSol"
        Me.MonthCalendarSol.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(236, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Estatus"
        '
        'CmbEstatus
        '
        Me.CmbEstatus.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstatus.FormattingEnabled = True
        Me.CmbEstatus.Items.AddRange(New Object() {"En Proceso", "Entregado", "No Se Entrego"})
        Me.CmbEstatus.Location = New System.Drawing.Point(286, 24)
        Me.CmbEstatus.Name = "CmbEstatus"
        Me.CmbEstatus.Size = New System.Drawing.Size(122, 21)
        Me.CmbEstatus.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.EditarEntrega)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CmbEstatus)
        Me.Panel1.Controls.Add(Me.TxtObservacion)
        Me.Panel1.Controls.Add(Me.MonthCalendarEntrega)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtEntrego)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtLitros)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(21, 487)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1298, 235)
        Me.Panel1.TabIndex = 32
        '
        'EditarEntrega
        '
        Me.EditarEntrega.BackColor = System.Drawing.SystemColors.Control
        Me.EditarEntrega.ForeColor = System.Drawing.SystemColors.Control
        Me.EditarEntrega.Image = CType(resources.GetObject("EditarEntrega.Image"), System.Drawing.Image)
        Me.EditarEntrega.Location = New System.Drawing.Point(919, 161)
        Me.EditarEntrega.Name = "EditarEntrega"
        Me.EditarEntrega.Size = New System.Drawing.Size(81, 42)
        Me.EditarEntrega.TabIndex = 37
        Me.EditarEntrega.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Observaciones"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(31, 89)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(548, 108)
        Me.TxtObservacion.TabIndex = 33
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrden.Location = New System.Drawing.Point(439, 26)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(74, 17)
        Me.lblOrden.TabIndex = 33
        Me.lblOrden.Text = "Orden No. "
        '
        'lblIDOrden
        '
        Me.lblIDOrden.AutoSize = True
        Me.lblIDOrden.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDOrden.Location = New System.Drawing.Point(509, 66)
        Me.lblIDOrden.Name = "lblIDOrden"
        Me.lblIDOrden.Size = New System.Drawing.Size(0, 17)
        Me.lblIDOrden.TabIndex = 34
        '
        'DGVAutocomplete
        '
        Me.DGVAutocomplete.AllowUserToAddRows = False
        Me.DGVAutocomplete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVAutocomplete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVAutocomplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAutocomplete.Location = New System.Drawing.Point(12, 83)
        Me.DGVAutocomplete.Name = "DGVAutocomplete"
        Me.DGVAutocomplete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGVAutocomplete.Size = New System.Drawing.Size(340, 122)
        Me.DGVAutocomplete.TabIndex = 35
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(1102, 60)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 42)
        Me.btnGuardar.TabIndex = 36
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblpanel
        '
        Me.lblpanel.AutoSize = True
        Me.lblpanel.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpanel.Location = New System.Drawing.Point(60, 476)
        Me.lblpanel.Name = "lblpanel"
        Me.lblpanel.Size = New System.Drawing.Size(178, 16)
        Me.lblpanel.TabIndex = 37
        Me.lblpanel.Text = "Datos de Entrega "
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(511, 30)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(14, 13)
        Me.LabelID.TabIndex = 38
        Me.LabelID.Text = "#"
        '
        'txtBuscarxNom
        '
        Me.txtBuscarxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarxNom.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarxNom.Location = New System.Drawing.Point(1111, 196)
        Me.txtBuscarxNom.Name = "txtBuscarxNom"
        Me.txtBuscarxNom.Size = New System.Drawing.Size(230, 25)
        Me.txtBuscarxNom.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1117, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Buscar x Nombre"
        '
        'FrmSolicitudPipa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 716)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtBuscarxNom)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.lblpanel)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.DGVAutocomplete)
        Me.Controls.Add(Me.lblIDOrden)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.MonthCalendarSol)
        Me.Controls.Add(Me.DataGridViewPipa)
        Me.Controls.Add(Me.txtInmueble)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtEntre)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSolicitudPipa"
        Me.Text = "FrmSolicitudPipa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridViewPipa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVAutocomplete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents Editar As ToolStripButton
    Friend WithEvents Eliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnReportes As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents txtEntre As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtZona As TextBox
    Friend WithEvents txtInmueble As TextBox
    Friend WithEvents txtLitros As TextBox
    Friend WithEvents DataGridViewPipa As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEntrego As TextBox
    Friend WithEvents MonthCalendarEntrega As MonthCalendar
    Friend WithEvents MonthCalendarSol As MonthCalendar
    Friend WithEvents Label14 As Label
    Friend WithEvents CmbEstatus As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents lblOrden As Label
    Friend WithEvents lblIDOrden As Label
    Friend WithEvents DGVAutocomplete As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblpanel As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents EditarEntrega As Button
    Friend WithEvents txtBuscarxNom As TextBox
    Friend WithEvents Label13 As Label
End Class
