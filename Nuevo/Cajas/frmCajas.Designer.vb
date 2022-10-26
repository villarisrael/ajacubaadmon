<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajas))
        Me.rOp = New DevComponents.DotNetBar.RibbonBar
        Me.cmdAgr = New DevComponents.DotNetBar.ButtonItem
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdAct = New DevComponents.DotNetBar.ButtonItem
        Me.cmdCance = New DevComponents.DotNetBar.ButtonItem
        Me.cmdImpCort = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdExt = New DevComponents.DotNetBar.ButtonItem
        Me.cmbComu = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.txtCuenta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.gpGrid = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.dgCob = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subTot = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Recargos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tabla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_concepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.txtSubTot = New System.Windows.Forms.TextBox
        Me.txtIva = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.PanUsuarios = New System.Windows.Forms.Panel
        Me.LblRecargoO = New DevComponents.DotNetBar.LabelX
        Me.TxtRecargoOtros = New System.Windows.Forms.TextBox
        Me.lblRedondeo = New DevComponents.DotNetBar.LabelX
        Me.LblDescuento = New DevComponents.DotNetBar.LabelX
        Me.TxtRedondeo = New System.Windows.Forms.TextBox
        Me.LblAnticipo = New DevComponents.DotNetBar.LabelX
        Me.TxtAnticipo = New System.Windows.Forms.TextBox
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtDescu = New System.Windows.Forms.TextBox
        Me.txtOtros = New System.Windows.Forms.TextBox
        Me.txtReca = New System.Windows.Forms.TextBox
        Me.txtAlcanta = New System.Windows.Forms.TextBox
        Me.txtSaneamiento = New System.Windows.Forms.TextBox
        Me.txtConsumo = New System.Windows.Forms.TextBox
        Me.txtReza = New System.Windows.Forms.TextBox
        Me.lblLinea1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.cmdAceptar = New DevComponents.DotNetBar.ButtonX
        Me.ChkConsumo = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chkOtros = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.CmbPeriodos = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.RBUsuarios = New System.Windows.Forms.RadioButton
        Me.RBFactibilidades = New System.Windows.Forms.RadioButton
        Me.RBNoPadron = New System.Windows.Forms.RadioButton
        Me.TxtSolicitud = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblFactibilidad = New DevComponents.DotNetBar.LabelX
        Me.TxtFactibilidad = New System.Windows.Forms.TextBox
        Me.PanFactibilidad = New System.Windows.Forms.Panel
        Me.CmbNousuarios = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.PanObserva = New DevComponents.DotNetBar.PanelEx
        Me.ChkDirFis = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LblDirFis4 = New DevComponents.DotNetBar.LabelX
        Me.LblDirFis3 = New DevComponents.DotNetBar.LabelX
        Me.lblDirFis2 = New DevComponents.DotNetBar.LabelX
        Me.lblDirFis1 = New DevComponents.DotNetBar.LabelX
        Me.LblTitDatosFis = New DevComponents.DotNetBar.LabelX
        Me.LblObservacion = New DevComponents.DotNetBar.LabelX
        Me.TxtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblReferencia = New DevComponents.DotNetBar.LabelX
        Me.TxtReferencia = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.CmbFormaPago = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LblFpago = New DevComponents.DotNetBar.LabelX
        Me.ExFpago = New DevComponents.DotNetBar.ExpandableSplitter
        Me.LblTitRecibo = New DevComponents.DotNetBar.LabelX
        Me.LblSerie = New DevComponents.DotNetBar.LabelX
        Me.LblRecibo = New DevComponents.DotNetBar.LabelX
        Me.LblFecha = New DevComponents.DotNetBar.LabelX
        Me.DTFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.TxtCodBar = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.BtnCalcular = New DevComponents.DotNetBar.ButtonX
        Me.LblCaja = New DevComponents.DotNetBar.LabelX
        Me.PanBuscar = New DevComponents.DotNetBar.PanelEx
        Me.BtnBusqueda = New DevComponents.DotNetBar.ButtonX
        Me.RBDomicilio = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.RBCuenta = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.RBNombre = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.CmbComunidad = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LblTitCom = New DevComponents.DotNetBar.LabelX
        Me.DGBus = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.ColCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColComunidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtbusNombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblNom = New DevComponents.DotNetBar.LabelX
        Me.ExBus = New DevComponents.DotNetBar.ExpandableSplitter
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.Factibilidadex = New DevComponents.DotNetBar.ExpandableSplitter
        Me.Panelfactibilidad = New DevComponents.DotNetBar.PanelEx
        Me.BtnBusSol = New DevComponents.DotNetBar.ButtonX
        Me.RBDomSol = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.RBCueSol = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.RBComNom = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.DGBusSol = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TxtBusSol = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblTituloSol = New DevComponents.DotNetBar.LabelX
        Me.ChkRedondeo = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.CHKIMPRIMIR = New System.Windows.Forms.CheckBox
        Me.ckarriba = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtLecActual = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtLecAnterior = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPer = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTarifa = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNumExt = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtNumInt = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtCalle = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtRfc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtCp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtCol = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtCom = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Dlgproceso = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboRob1 = New AcquaLiberVista.comboRob
        Me.gpGrid.SuspendLayout()
        CType(Me.dgCob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanUsuarios.SuspendLayout()
        Me.PanFactibilidad.SuspendLayout()
        Me.PanObserva.SuspendLayout()
        CType(Me.DTFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBuscar.SuspendLayout()
        CType(Me.DGBus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelfactibilidad.SuspendLayout()
        CType(Me.DGBusSol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dlgproceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'rOp
        '
        Me.rOp.AutoOverflowEnabled = True
        '
        '
        '
        Me.rOp.BackgroundMouseOverStyle.Class = ""
        Me.rOp.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rOp.BackgroundStyle.Class = ""
        Me.rOp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rOp.ContainerControlProcessDialogKey = True
        Me.rOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdAgr, Me.cmdBuscar, Me.cmdAct, Me.cmdCance, Me.cmdImpCort, Me.ButtonItem1, Me.ButtonItem2, Me.cmdExt})
        Me.rOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rOp.Location = New System.Drawing.Point(0, 0)
        Me.rOp.Name = "rOp"
        Me.rOp.Size = New System.Drawing.Size(915, 42)
        Me.rOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rOp.TabIndex = 0
        '
        '
        '
        Me.rOp.TitleStyle.Class = ""
        Me.rOp.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rOp.TitleStyleMouseOver.Class = ""
        Me.rOp.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rOp.TitleVisible = False
        '
        'cmdAgr
        '
        Me.cmdAgr.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdAgr.Image = Global.AcquaLiberVista.My.Resources.Resources.filenew
        Me.cmdAgr.Name = "cmdAgr"
        Me.cmdAgr.SubItemsExpandWidth = 14
        Me.cmdAgr.Text = "Agregar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdBuscar.Image = Global.AcquaLiberVista.My.Resources.Resources.Buscar
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.SubItemsExpandWidth = 14
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdAct
        '
        Me.cmdAct.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdAct.Image = Global.AcquaLiberVista.My.Resources.Resources.apply
        Me.cmdAct.Name = "cmdAct"
        Me.cmdAct.SubItemsExpandWidth = 14
        Me.cmdAct.Text = "Activar Recibo"
        Me.cmdAct.Visible = False
        '
        'cmdCance
        '
        Me.cmdCance.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdCance.Image = Global.AcquaLiberVista.My.Resources.Resources.button_cancel
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.SubItemsExpandWidth = 14
        Me.cmdCance.Text = "Cancelar Recibo"
        '
        'cmdImpCort
        '
        Me.cmdImpCort.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImpCort.Image = Global.AcquaLiberVista.My.Resources.Resources.news_subscribe
        Me.cmdImpCort.Name = "cmdImpCort"
        Me.cmdImpCort.SubItemsExpandWidth = 14
        Me.cmdImpCort.Text = "Imprimir Corte"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.AcquaLiberVista.My.Resources.Resources.compfile
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Cambiar folio"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = Global.AcquaLiberVista.My.Resources.Resources.apply
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "Habilitar Anticipo"
        '
        'cmdExt
        '
        Me.cmdExt.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdExt.Image = Global.AcquaLiberVista.My.Resources.Resources.Salir_ln
        Me.cmdExt.Name = "cmdExt"
        Me.cmdExt.SubItemsExpandWidth = 14
        Me.cmdExt.Text = "Salir"
        '
        'cmbComu
        '
        Me.cmbComu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbComu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbComu.DisplayMember = "Text"
        Me.cmbComu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbComu.DropDownHeight = 400
        Me.cmbComu.DropDownWidth = 400
        Me.cmbComu.FocusHighlightEnabled = True
        Me.cmbComu.FormattingEnabled = True
        Me.cmbComu.IntegralHeight = False
        Me.cmbComu.ItemHeight = 14
        Me.cmbComu.Location = New System.Drawing.Point(170, 117)
        Me.cmbComu.Name = "cmbComu"
        Me.cmbComu.Size = New System.Drawing.Size(187, 20)
        Me.cmbComu.TabIndex = 13
        Me.cmbComu.WatermarkText = "Seleccione la comunidad"
        '
        'txtCuenta
        '
        '
        '
        '
        Me.txtCuenta.Border.Class = "TextBoxBorder"
        Me.txtCuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCuenta.FocusHighlightEnabled = True
        Me.txtCuenta.Location = New System.Drawing.Point(130, 117)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(41, 20)
        Me.txtCuenta.TabIndex = 12
        Me.txtCuenta.WatermarkText = "Cuenta"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Location = New System.Drawing.Point(3, 119)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(46, 13)
        Me.LblTitulo.TabIndex = 10
        Me.LblTitulo.Text = "Usuario:"
        '
        'gpGrid
        '
        Me.gpGrid.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpGrid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpGrid.Controls.Add(Me.dgCob)
        Me.gpGrid.Location = New System.Drawing.Point(4, 347)
        Me.gpGrid.Name = "gpGrid"
        Me.gpGrid.Size = New System.Drawing.Size(622, 156)
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
        Me.gpGrid.Style.Class = ""
        Me.gpGrid.Style.CornerDiameter = 4
        Me.gpGrid.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpGrid.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpGrid.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpGrid.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpGrid.StyleMouseDown.Class = ""
        Me.gpGrid.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpGrid.StyleMouseOver.Class = ""
        Me.gpGrid.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpGrid.TabIndex = 22
        Me.gpGrid.Visible = False
        '
        'dgCob
        '
        Me.dgCob.AllowUserToAddRows = False
        Me.dgCob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCob.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clave, Me.Tipo, Me.cantidad, Me.concepto, Me.subTot, Me.Recargos, Me.iva, Me.Total, Me.Tabla, Me.id_concepto})
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
        Me.dgCob.Size = New System.Drawing.Size(616, 150)
        Me.dgCob.TabIndex = 0
        '
        'clave
        '
        Me.clave.HeaderText = "Clave"
        Me.clave.Name = "clave"
        Me.clave.Width = 59
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Visible = False
        Me.Tipo.Width = 53
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Visible = False
        Me.cantidad.Width = 74
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 78
        '
        'subTot
        '
        Me.subTot.HeaderText = "Resta"
        Me.subTot.Name = "subTot"
        Me.subTot.ReadOnly = True
        Me.subTot.Width = 60
        '
        'Recargos
        '
        Me.Recargos.HeaderText = "Recargos"
        Me.Recargos.Name = "Recargos"
        Me.Recargos.Width = 78
        '
        'iva
        '
        Me.iva.HeaderText = "Iva"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        Me.iva.Width = 47
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 56
        '
        'Tabla
        '
        Me.Tabla.HeaderText = "Tabla"
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Visible = False
        Me.Tabla.Width = 59
        '
        'id_concepto
        '
        Me.id_concepto.HeaderText = "id_concepto"
        Me.id_concepto.Name = "id_concepto"
        Me.id_concepto.Visible = False
        Me.id_concepto.Width = 91
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LabelX10)
        Me.Panel2.Controls.Add(Me.LabelX9)
        Me.Panel2.Controls.Add(Me.LabelX8)
        Me.Panel2.Controls.Add(Me.txtSubTot)
        Me.Panel2.Controls.Add(Me.txtIva)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Location = New System.Drawing.Point(637, 365)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 72)
        Me.Panel2.TabIndex = 24
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(11, 42)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 23)
        Me.LabelX10.TabIndex = 4
        Me.LabelX10.Text = "Total"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(11, 22)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(75, 23)
        Me.LabelX9.TabIndex = 2
        Me.LabelX9.Text = "IVA"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(11, 2)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "Subtotal"
        '
        'txtSubTot
        '
        Me.txtSubTot.BackColor = System.Drawing.Color.White
        Me.txtSubTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTot.Location = New System.Drawing.Point(92, 2)
        Me.txtSubTot.Name = "txtSubTot"
        Me.txtSubTot.ReadOnly = True
        Me.txtSubTot.Size = New System.Drawing.Size(145, 23)
        Me.txtSubTot.TabIndex = 1
        Me.txtSubTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.Color.White
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(92, 22)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(145, 23)
        Me.txtIva.TabIndex = 3
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(92, 42)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(145, 23)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanUsuarios
        '
        Me.PanUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanUsuarios.Controls.Add(Me.LblRecargoO)
        Me.PanUsuarios.Controls.Add(Me.TxtRecargoOtros)
        Me.PanUsuarios.Controls.Add(Me.lblRedondeo)
        Me.PanUsuarios.Controls.Add(Me.LblDescuento)
        Me.PanUsuarios.Controls.Add(Me.TxtRedondeo)
        Me.PanUsuarios.Controls.Add(Me.LblAnticipo)
        Me.PanUsuarios.Controls.Add(Me.TxtAnticipo)
        Me.PanUsuarios.Controls.Add(Me.LabelX6)
        Me.PanUsuarios.Controls.Add(Me.LabelX5)
        Me.PanUsuarios.Controls.Add(Me.LabelX4)
        Me.PanUsuarios.Controls.Add(Me.LabelX3)
        Me.PanUsuarios.Controls.Add(Me.LabelX2)
        Me.PanUsuarios.Controls.Add(Me.LabelX1)
        Me.PanUsuarios.Controls.Add(Me.txtDescu)
        Me.PanUsuarios.Controls.Add(Me.txtOtros)
        Me.PanUsuarios.Controls.Add(Me.txtReca)
        Me.PanUsuarios.Controls.Add(Me.txtAlcanta)
        Me.PanUsuarios.Controls.Add(Me.txtSaneamiento)
        Me.PanUsuarios.Controls.Add(Me.txtConsumo)
        Me.PanUsuarios.Controls.Add(Me.txtReza)
        Me.PanUsuarios.Controls.Add(Me.lblLinea1)
        Me.PanUsuarios.Controls.Add(Me.LabelX11)
        Me.PanUsuarios.Location = New System.Drawing.Point(637, 79)
        Me.PanUsuarios.Name = "PanUsuarios"
        Me.PanUsuarios.Size = New System.Drawing.Size(249, 250)
        Me.PanUsuarios.TabIndex = 23
        '
        'LblRecargoO
        '
        Me.LblRecargoO.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblRecargoO.BackgroundStyle.Class = ""
        Me.LblRecargoO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblRecargoO.Location = New System.Drawing.Point(11, 162)
        Me.LblRecargoO.Name = "LblRecargoO"
        Me.LblRecargoO.Size = New System.Drawing.Size(75, 23)
        Me.LblRecargoO.TabIndex = 36
        Me.LblRecargoO.Text = "Recargo Otros"
        '
        'TxtRecargoOtros
        '
        Me.TxtRecargoOtros.BackColor = System.Drawing.Color.White
        Me.TxtRecargoOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecargoOtros.Location = New System.Drawing.Point(92, 162)
        Me.TxtRecargoOtros.Name = "TxtRecargoOtros"
        Me.TxtRecargoOtros.ReadOnly = True
        Me.TxtRecargoOtros.Size = New System.Drawing.Size(145, 23)
        Me.TxtRecargoOtros.TabIndex = 37
        Me.TxtRecargoOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRedondeo
        '
        Me.lblRedondeo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblRedondeo.BackgroundStyle.Class = ""
        Me.lblRedondeo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRedondeo.Location = New System.Drawing.Point(11, 216)
        Me.lblRedondeo.Name = "lblRedondeo"
        Me.lblRedondeo.Size = New System.Drawing.Size(75, 23)
        Me.lblRedondeo.TabIndex = 35
        Me.lblRedondeo.Text = "Redondeo"
        Me.lblRedondeo.Visible = False
        '
        'LblDescuento
        '
        Me.LblDescuento.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblDescuento.BackgroundStyle.Class = ""
        Me.LblDescuento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblDescuento.Location = New System.Drawing.Point(11, 192)
        Me.LblDescuento.Name = "LblDescuento"
        Me.LblDescuento.Size = New System.Drawing.Size(75, 23)
        Me.LblDescuento.TabIndex = 20
        Me.LblDescuento.Text = "Descuento"
        '
        'TxtRedondeo
        '
        Me.TxtRedondeo.BackColor = System.Drawing.Color.IndianRed
        Me.TxtRedondeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRedondeo.Location = New System.Drawing.Point(92, 217)
        Me.TxtRedondeo.Name = "TxtRedondeo"
        Me.TxtRedondeo.ReadOnly = True
        Me.TxtRedondeo.Size = New System.Drawing.Size(145, 23)
        Me.TxtRedondeo.TabIndex = 34
        Me.TxtRedondeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtRedondeo.Visible = False
        '
        'LblAnticipo
        '
        Me.LblAnticipo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblAnticipo.BackgroundStyle.Class = ""
        Me.LblAnticipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblAnticipo.Location = New System.Drawing.Point(11, 106)
        Me.LblAnticipo.Name = "LblAnticipo"
        Me.LblAnticipo.Size = New System.Drawing.Size(75, 23)
        Me.LblAnticipo.TabIndex = 12
        Me.LblAnticipo.Text = "Anticipo"
        '
        'TxtAnticipo
        '
        Me.TxtAnticipo.BackColor = System.Drawing.Color.White
        Me.TxtAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnticipo.Location = New System.Drawing.Point(92, 106)
        Me.TxtAnticipo.Name = "TxtAnticipo"
        Me.TxtAnticipo.ReadOnly = True
        Me.TxtAnticipo.Size = New System.Drawing.Size(145, 23)
        Me.TxtAnticipo.TabIndex = 13
        Me.TxtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(11, 140)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "Otros"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(11, 83)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Recargos"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(11, 63)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Alcantarillado"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(11, 43)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Saneamiento"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(11, 23)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Consumo"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(11, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Rezagos"
        '
        'txtDescu
        '
        Me.txtDescu.BackColor = System.Drawing.Color.IndianRed
        Me.txtDescu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescu.Location = New System.Drawing.Point(92, 193)
        Me.txtDescu.Name = "txtDescu"
        Me.txtDescu.ReadOnly = True
        Me.txtDescu.Size = New System.Drawing.Size(145, 23)
        Me.txtDescu.TabIndex = 6
        Me.txtDescu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOtros
        '
        Me.txtOtros.BackColor = System.Drawing.Color.White
        Me.txtOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.Location = New System.Drawing.Point(92, 140)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.ReadOnly = True
        Me.txtOtros.Size = New System.Drawing.Size(145, 23)
        Me.txtOtros.TabIndex = 11
        Me.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReca
        '
        Me.txtReca.BackColor = System.Drawing.Color.White
        Me.txtReca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReca.Location = New System.Drawing.Point(92, 83)
        Me.txtReca.Name = "txtReca"
        Me.txtReca.ReadOnly = True
        Me.txtReca.Size = New System.Drawing.Size(145, 23)
        Me.txtReca.TabIndex = 9
        Me.txtReca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAlcanta
        '
        Me.txtAlcanta.BackColor = System.Drawing.Color.White
        Me.txtAlcanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcanta.Location = New System.Drawing.Point(92, 63)
        Me.txtAlcanta.Name = "txtAlcanta"
        Me.txtAlcanta.ReadOnly = True
        Me.txtAlcanta.Size = New System.Drawing.Size(145, 23)
        Me.txtAlcanta.TabIndex = 7
        Me.txtAlcanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaneamiento
        '
        Me.txtSaneamiento.BackColor = System.Drawing.Color.White
        Me.txtSaneamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaneamiento.Location = New System.Drawing.Point(92, 43)
        Me.txtSaneamiento.Name = "txtSaneamiento"
        Me.txtSaneamiento.ReadOnly = True
        Me.txtSaneamiento.Size = New System.Drawing.Size(145, 23)
        Me.txtSaneamiento.TabIndex = 5
        Me.txtSaneamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConsumo
        '
        Me.txtConsumo.BackColor = System.Drawing.Color.White
        Me.txtConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsumo.Location = New System.Drawing.Point(92, 23)
        Me.txtConsumo.Name = "txtConsumo"
        Me.txtConsumo.ReadOnly = True
        Me.txtConsumo.Size = New System.Drawing.Size(145, 23)
        Me.txtConsumo.TabIndex = 3
        Me.txtConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReza
        '
        Me.txtReza.BackColor = System.Drawing.Color.White
        Me.txtReza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReza.Location = New System.Drawing.Point(92, 3)
        Me.txtReza.Name = "txtReza"
        Me.txtReza.ReadOnly = True
        Me.txtReza.Size = New System.Drawing.Size(145, 23)
        Me.txtReza.TabIndex = 1
        Me.txtReza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLinea1
        '
        '
        '
        '
        Me.lblLinea1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblLinea1.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Navy
        Me.lblLinea1.BackgroundStyle.BorderBottomWidth = 4
        Me.lblLinea1.BackgroundStyle.Class = ""
        Me.lblLinea1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblLinea1.Location = New System.Drawing.Point(9, 128)
        Me.lblLinea1.Name = "lblLinea1"
        Me.lblLinea1.Size = New System.Drawing.Size(227, 8)
        Me.lblLinea1.TabIndex = 38
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX11.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Navy
        Me.LabelX11.BackgroundStyle.BorderBottomWidth = 4
        Me.LabelX11.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX11.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX11.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(9, 181)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(227, 8)
        Me.LabelX11.TabIndex = 39
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAceptar.Image = Global.AcquaLiberVista.My.Resources.Resources.apply
        Me.cmdAceptar.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cmdAceptar.Location = New System.Drawing.Point(360, 114)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(93, 24)
        Me.cmdAceptar.TabIndex = 14
        Me.cmdAceptar.Text = "Aceptar"
        '
        'ChkConsumo
        '
        '
        '
        '
        Me.ChkConsumo.BackgroundStyle.Class = ""
        Me.ChkConsumo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkConsumo.Location = New System.Drawing.Point(3, 303)
        Me.ChkConsumo.Name = "ChkConsumo"
        Me.ChkConsumo.Size = New System.Drawing.Size(91, 23)
        Me.ChkConsumo.TabIndex = 19
        Me.ChkConsumo.Text = "Pagar Hasta:"
        '
        'chkOtros
        '
        '
        '
        '
        Me.chkOtros.BackgroundStyle.Class = ""
        Me.chkOtros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkOtros.Location = New System.Drawing.Point(3, 321)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(106, 23)
        Me.chkOtros.TabIndex = 20
        Me.chkOtros.Text = "Otros Conceptos:"
        '
        'CmbPeriodos
        '
        Me.CmbPeriodos.DisplayMember = "Text"
        Me.CmbPeriodos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbPeriodos.FormattingEnabled = True
        Me.CmbPeriodos.ItemHeight = 14
        Me.CmbPeriodos.Location = New System.Drawing.Point(115, 304)
        Me.CmbPeriodos.Name = "CmbPeriodos"
        Me.CmbPeriodos.Size = New System.Drawing.Size(139, 20)
        Me.CmbPeriodos.TabIndex = 17
        '
        'RBUsuarios
        '
        Me.RBUsuarios.AutoSize = True
        Me.RBUsuarios.Checked = True
        Me.RBUsuarios.Location = New System.Drawing.Point(290, 79)
        Me.RBUsuarios.Name = "RBUsuarios"
        Me.RBUsuarios.Size = New System.Drawing.Size(66, 17)
        Me.RBUsuarios.TabIndex = 7
        Me.RBUsuarios.TabStop = True
        Me.RBUsuarios.Text = "Usuarios"
        Me.RBUsuarios.UseVisualStyleBackColor = True
        '
        'RBFactibilidades
        '
        Me.RBFactibilidades.AutoSize = True
        Me.RBFactibilidades.Location = New System.Drawing.Point(363, 79)
        Me.RBFactibilidades.Name = "RBFactibilidades"
        Me.RBFactibilidades.Size = New System.Drawing.Size(89, 17)
        Me.RBFactibilidades.TabIndex = 8
        Me.RBFactibilidades.Text = "Factibilidades"
        Me.RBFactibilidades.UseVisualStyleBackColor = True
        '
        'RBNoPadron
        '
        Me.RBNoPadron.AutoSize = True
        Me.RBNoPadron.Location = New System.Drawing.Point(458, 79)
        Me.RBNoPadron.Name = "RBNoPadron"
        Me.RBNoPadron.Size = New System.Drawing.Size(146, 17)
        Me.RBNoPadron.TabIndex = 9
        Me.RBNoPadron.Text = "Usuarios fuera del padrón"
        Me.RBNoPadron.UseVisualStyleBackColor = True
        '
        'TxtSolicitud
        '
        '
        '
        '
        Me.TxtSolicitud.Border.Class = "TextBoxBorder"
        Me.TxtSolicitud.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtSolicitud.FocusHighlightEnabled = True
        Me.TxtSolicitud.Location = New System.Drawing.Point(98, 117)
        Me.TxtSolicitud.Name = "TxtSolicitud"
        Me.TxtSolicitud.Size = New System.Drawing.Size(76, 20)
        Me.TxtSolicitud.TabIndex = 11
        Me.TxtSolicitud.Visible = False
        Me.TxtSolicitud.WatermarkText = "Factibilidad"
        '
        'LblFactibilidad
        '
        Me.LblFactibilidad.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblFactibilidad.BackgroundStyle.Class = ""
        Me.LblFactibilidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblFactibilidad.Location = New System.Drawing.Point(11, 3)
        Me.LblFactibilidad.Name = "LblFactibilidad"
        Me.LblFactibilidad.Size = New System.Drawing.Size(75, 23)
        Me.LblFactibilidad.TabIndex = 2
        Me.LblFactibilidad.Text = "Factibilidad"
        '
        'TxtFactibilidad
        '
        Me.TxtFactibilidad.BackColor = System.Drawing.Color.White
        Me.TxtFactibilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactibilidad.Location = New System.Drawing.Point(92, 3)
        Me.TxtFactibilidad.Name = "TxtFactibilidad"
        Me.TxtFactibilidad.ReadOnly = True
        Me.TxtFactibilidad.Size = New System.Drawing.Size(145, 23)
        Me.TxtFactibilidad.TabIndex = 3
        Me.TxtFactibilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanFactibilidad
        '
        Me.PanFactibilidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanFactibilidad.Controls.Add(Me.LblFactibilidad)
        Me.PanFactibilidad.Controls.Add(Me.TxtFactibilidad)
        Me.PanFactibilidad.Location = New System.Drawing.Point(637, 441)
        Me.PanFactibilidad.Name = "PanFactibilidad"
        Me.PanFactibilidad.Size = New System.Drawing.Size(249, 35)
        Me.PanFactibilidad.TabIndex = 25
        '
        'CmbNousuarios
        '
        Me.CmbNousuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbNousuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbNousuarios.DisplayMember = "Text"
        Me.CmbNousuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbNousuarios.FocusHighlightEnabled = True
        Me.CmbNousuarios.FormattingEnabled = True
        Me.CmbNousuarios.ItemHeight = 14
        Me.CmbNousuarios.Location = New System.Drawing.Point(97, 117)
        Me.CmbNousuarios.Name = "CmbNousuarios"
        Me.CmbNousuarios.Size = New System.Drawing.Size(260, 20)
        Me.CmbNousuarios.TabIndex = 12
        '
        'PanObserva
        '
        Me.PanObserva.Controls.Add(Me.ChkDirFis)
        Me.PanObserva.Controls.Add(Me.LblDirFis4)
        Me.PanObserva.Controls.Add(Me.LblDirFis3)
        Me.PanObserva.Controls.Add(Me.lblDirFis2)
        Me.PanObserva.Controls.Add(Me.lblDirFis1)
        Me.PanObserva.Controls.Add(Me.LblTitDatosFis)
        Me.PanObserva.Controls.Add(Me.LblObservacion)
        Me.PanObserva.Controls.Add(Me.TxtObservacion)
        Me.PanObserva.Controls.Add(Me.LblReferencia)
        Me.PanObserva.Controls.Add(Me.TxtReferencia)
        Me.PanObserva.Controls.Add(Me.CmbFormaPago)
        Me.PanObserva.Controls.Add(Me.LblFpago)
        Me.PanObserva.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanObserva.Location = New System.Drawing.Point(0, 443)
        Me.PanObserva.Name = "PanObserva"
        Me.PanObserva.Size = New System.Drawing.Size(1250, 170)
        Me.PanObserva.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanObserva.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanObserva.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanObserva.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanObserva.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanObserva.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanObserva.Style.GradientAngle = 90
        Me.PanObserva.TabIndex = 25
        Me.PanObserva.ThemeAware = True
        Me.PanObserva.Visible = False
        '
        'ChkDirFis
        '
        '
        '
        '
        Me.ChkDirFis.BackgroundStyle.Class = ""
        Me.ChkDirFis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkDirFis.Location = New System.Drawing.Point(834, 71)
        Me.ChkDirFis.Name = "ChkDirFis"
        Me.ChkDirFis.Size = New System.Drawing.Size(177, 23)
        Me.ChkDirFis.TabIndex = 43
        Me.ChkDirFis.Text = "Imprimir Direccion Fiscal"
        '
        'LblDirFis4
        '
        '
        '
        '
        Me.LblDirFis4.BackgroundStyle.Class = ""
        Me.LblDirFis4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblDirFis4.Location = New System.Drawing.Point(97, 131)
        Me.LblDirFis4.Name = "LblDirFis4"
        Me.LblDirFis4.Size = New System.Drawing.Size(717, 23)
        Me.LblDirFis4.TabIndex = 42
        Me.LblDirFis4.Text = "LabelX11"
        '
        'LblDirFis3
        '
        '
        '
        '
        Me.LblDirFis3.BackgroundStyle.Class = ""
        Me.LblDirFis3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblDirFis3.Location = New System.Drawing.Point(97, 108)
        Me.LblDirFis3.Name = "LblDirFis3"
        Me.LblDirFis3.Size = New System.Drawing.Size(717, 23)
        Me.LblDirFis3.TabIndex = 41
        Me.LblDirFis3.Text = "LabelX11"
        '
        'lblDirFis2
        '
        '
        '
        '
        Me.lblDirFis2.BackgroundStyle.Class = ""
        Me.lblDirFis2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDirFis2.Location = New System.Drawing.Point(98, 85)
        Me.lblDirFis2.Name = "lblDirFis2"
        Me.lblDirFis2.Size = New System.Drawing.Size(717, 23)
        Me.lblDirFis2.TabIndex = 40
        Me.lblDirFis2.Text = "LabelX11"
        '
        'lblDirFis1
        '
        '
        '
        '
        Me.lblDirFis1.BackgroundStyle.Class = ""
        Me.lblDirFis1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDirFis1.Location = New System.Drawing.Point(97, 62)
        Me.lblDirFis1.Name = "lblDirFis1"
        Me.lblDirFis1.Size = New System.Drawing.Size(717, 23)
        Me.lblDirFis1.TabIndex = 39
        Me.lblDirFis1.Text = "LabelX11"
        '
        'LblTitDatosFis
        '
        '
        '
        '
        Me.LblTitDatosFis.BackgroundStyle.Class = ""
        Me.LblTitDatosFis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitDatosFis.Location = New System.Drawing.Point(11, 64)
        Me.LblTitDatosFis.Name = "LblTitDatosFis"
        Me.LblTitDatosFis.Size = New System.Drawing.Size(86, 23)
        Me.LblTitDatosFis.TabIndex = 38
        Me.LblTitDatosFis.Text = "Datos Fiscales:"
        '
        'LblObservacion
        '
        '
        '
        '
        Me.LblObservacion.BackgroundStyle.Class = ""
        Me.LblObservacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblObservacion.Location = New System.Drawing.Point(11, 35)
        Me.LblObservacion.Name = "LblObservacion"
        Me.LblObservacion.Size = New System.Drawing.Size(81, 23)
        Me.LblObservacion.TabIndex = 4
        Me.LblObservacion.Text = "Observación:"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TxtObservacion.Border.Class = "TextBoxBorder"
        Me.TxtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtObservacion.FocusHighlightEnabled = True
        Me.TxtObservacion.Location = New System.Drawing.Point(98, 38)
        Me.TxtObservacion.MaxLength = 150
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(1116, 20)
        Me.TxtObservacion.TabIndex = 5
        '
        'LblReferencia
        '
        '
        '
        '
        Me.LblReferencia.BackgroundStyle.Class = ""
        Me.LblReferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblReferencia.Location = New System.Drawing.Point(352, 9)
        Me.LblReferencia.Name = "LblReferencia"
        Me.LblReferencia.Size = New System.Drawing.Size(61, 23)
        Me.LblReferencia.TabIndex = 2
        Me.LblReferencia.Text = "Referencia:"
        '
        'TxtReferencia
        '
        '
        '
        '
        Me.TxtReferencia.Border.Class = "TextBoxBorder"
        Me.TxtReferencia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtReferencia.FocusHighlightEnabled = True
        Me.TxtReferencia.Location = New System.Drawing.Point(439, 12)
        Me.TxtReferencia.MaxLength = 50
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(375, 20)
        Me.TxtReferencia.TabIndex = 3
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.DisplayMember = "Text"
        Me.CmbFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbFormaPago.FocusHighlightEnabled = True
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.ItemHeight = 14
        Me.CmbFormaPago.Location = New System.Drawing.Point(98, 9)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(199, 20)
        Me.CmbFormaPago.TabIndex = 1
        '
        'LblFpago
        '
        '
        '
        '
        Me.LblFpago.BackgroundStyle.Class = ""
        Me.LblFpago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblFpago.Location = New System.Drawing.Point(11, 6)
        Me.LblFpago.Name = "LblFpago"
        Me.LblFpago.Size = New System.Drawing.Size(96, 23)
        Me.LblFpago.TabIndex = 0
        Me.LblFpago.Text = "Forma de pago:"
        '
        'ExFpago
        '
        Me.ExFpago.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExFpago.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExFpago.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExFpago.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExFpago.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExFpago.ExpandableControl = Me.PanObserva
        Me.ExFpago.Expanded = False
        Me.ExFpago.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExFpago.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExFpago.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExFpago.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExFpago.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExFpago.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExFpago.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExFpago.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExFpago.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ExFpago.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ExFpago.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExFpago.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExFpago.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExFpago.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExFpago.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExFpago.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExFpago.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExFpago.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExFpago.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExFpago.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExFpago.Location = New System.Drawing.Point(0, 603)
        Me.ExFpago.Name = "ExFpago"
        Me.ExFpago.Size = New System.Drawing.Size(915, 10)
        Me.ExFpago.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExFpago.TabIndex = 26
        Me.ExFpago.TabStop = False
        '
        'LblTitRecibo
        '
        '
        '
        '
        Me.LblTitRecibo.BackgroundStyle.Class = ""
        Me.LblTitRecibo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitRecibo.Location = New System.Drawing.Point(3, 45)
        Me.LblTitRecibo.Name = "LblTitRecibo"
        Me.LblTitRecibo.Size = New System.Drawing.Size(47, 23)
        Me.LblTitRecibo.TabIndex = 1
        Me.LblTitRecibo.Text = "Factura:"
        '
        'LblSerie
        '
        Me.LblSerie.BackColor = System.Drawing.Color.Navy
        '
        '
        '
        Me.LblSerie.BackgroundStyle.Class = "TextBoxBorder"
        Me.LblSerie.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblSerie.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerie.ForeColor = System.Drawing.Color.White
        Me.LblSerie.Location = New System.Drawing.Point(81, 45)
        Me.LblSerie.Name = "LblSerie"
        Me.LblSerie.Size = New System.Drawing.Size(22, 23)
        Me.LblSerie.TabIndex = 2
        Me.LblSerie.Text = "S"
        '
        'LblRecibo
        '
        Me.LblRecibo.BackColor = System.Drawing.Color.Navy
        '
        '
        '
        Me.LblRecibo.BackgroundStyle.Class = "TextBoxBorder"
        Me.LblRecibo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblRecibo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecibo.ForeColor = System.Drawing.Color.White
        Me.LblRecibo.Location = New System.Drawing.Point(98, 45)
        Me.LblRecibo.Name = "LblRecibo"
        Me.LblRecibo.Size = New System.Drawing.Size(119, 23)
        Me.LblRecibo.TabIndex = 3
        Me.LblRecibo.Text = "0000000"
        Me.LblRecibo.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblFecha
        '
        '
        '
        '
        Me.LblFecha.BackgroundStyle.Class = ""
        Me.LblFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblFecha.Location = New System.Drawing.Point(3, 79)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(43, 17)
        Me.LblFecha.TabIndex = 5
        Me.LblFecha.Text = "Fecha:"
        '
        'DTFecha
        '
        '
        '
        '
        Me.DTFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTFecha.ButtonDropDown.Visible = True
        Me.DTFecha.CustomFormat = "dd/ MMMM / yyyy"
        Me.DTFecha.Enabled = False
        Me.DTFecha.FocusHighlightEnabled = True
        Me.DTFecha.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.DTFecha.IsPopupCalendarOpen = False
        Me.DTFecha.Location = New System.Drawing.Point(58, 79)
        '
        '
        '
        Me.DTFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTFecha.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTFecha.MonthCalendar.BackgroundStyle.Class = ""
        Me.DTFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTFecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.DTFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTFecha.MonthCalendar.DisplayMonth = New Date(2008, 11, 1, 0, 0, 0, 0)
        Me.DTFecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTFecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTFecha.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.DTFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTFecha.MonthCalendar.TodayButtonVisible = True
        Me.DTFecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(216, 20)
        Me.DTFecha.TabIndex = 6
        '
        'TxtCodBar
        '
        '
        '
        '
        Me.TxtCodBar.Border.Class = "TextBoxBorder"
        Me.TxtCodBar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtCodBar.Location = New System.Drawing.Point(459, 118)
        Me.TxtCodBar.Name = "TxtCodBar"
        Me.TxtCodBar.Size = New System.Drawing.Size(163, 20)
        Me.TxtCodBar.TabIndex = 15
        Me.TxtCodBar.WatermarkText = "Codigo de barras"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCalcular.Image = Global.AcquaLiberVista.My.Resources.Resources.agt_business
        Me.BtnCalcular.Location = New System.Drawing.Point(546, 303)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(36, 43)
        Me.BtnCalcular.TabIndex = 27
        Me.BtnCalcular.Visible = False
        '
        'LblCaja
        '
        Me.LblCaja.AutoSize = True
        '
        '
        '
        Me.LblCaja.BackgroundStyle.Class = ""
        Me.LblCaja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaja.Location = New System.Drawing.Point(227, 45)
        Me.LblCaja.Name = "LblCaja"
        Me.LblCaja.Size = New System.Drawing.Size(75, 26)
        Me.LblCaja.TabIndex = 4
        Me.LblCaja.Text = "LabelX7"
        '
        'PanBuscar
        '
        Me.PanBuscar.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanBuscar.Controls.Add(Me.BtnBusqueda)
        Me.PanBuscar.Controls.Add(Me.RBDomicilio)
        Me.PanBuscar.Controls.Add(Me.RBCuenta)
        Me.PanBuscar.Controls.Add(Me.RBNombre)
        Me.PanBuscar.Controls.Add(Me.CmbComunidad)
        Me.PanBuscar.Controls.Add(Me.LblTitCom)
        Me.PanBuscar.Controls.Add(Me.DGBus)
        Me.PanBuscar.Controls.Add(Me.txtbusNombre)
        Me.PanBuscar.Controls.Add(Me.LblNom)
        Me.PanBuscar.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanBuscar.Location = New System.Drawing.Point(770, 42)
        Me.PanBuscar.Name = "PanBuscar"
        Me.PanBuscar.Size = New System.Drawing.Size(480, 564)
        Me.PanBuscar.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanBuscar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanBuscar.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanBuscar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanBuscar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanBuscar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanBuscar.Style.GradientAngle = 90
        Me.PanBuscar.TabIndex = 0
        Me.PanBuscar.ThemeAware = True
        Me.PanBuscar.Visible = False
        '
        'BtnBusqueda
        '
        Me.BtnBusqueda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBusqueda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBusqueda.Image = Global.AcquaLiberVista.My.Resources.Resources.kdict
        Me.BtnBusqueda.Location = New System.Drawing.Point(437, 57)
        Me.BtnBusqueda.Name = "BtnBusqueda"
        Me.BtnBusqueda.Size = New System.Drawing.Size(28, 24)
        Me.BtnBusqueda.TabIndex = 7
        '
        'RBDomicilio
        '
        '
        '
        '
        Me.RBDomicilio.BackgroundStyle.Class = ""
        Me.RBDomicilio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBDomicilio.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBDomicilio.Location = New System.Drawing.Point(166, 31)
        Me.RBDomicilio.Name = "RBDomicilio"
        Me.RBDomicilio.Size = New System.Drawing.Size(75, 23)
        Me.RBDomicilio.TabIndex = 4
        Me.RBDomicilio.Text = "Domicilio"
        '
        'RBCuenta
        '
        '
        '
        '
        Me.RBCuenta.BackgroundStyle.Class = ""
        Me.RBCuenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBCuenta.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBCuenta.Location = New System.Drawing.Point(4, 31)
        Me.RBCuenta.Name = "RBCuenta"
        Me.RBCuenta.Size = New System.Drawing.Size(75, 23)
        Me.RBCuenta.TabIndex = 2
        Me.RBCuenta.Text = "Cuenta"
        '
        'RBNombre
        '
        '
        '
        '
        Me.RBNombre.BackgroundStyle.Class = ""
        Me.RBNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBNombre.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBNombre.Checked = True
        Me.RBNombre.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RBNombre.CheckValue = "Y"
        Me.RBNombre.Location = New System.Drawing.Point(85, 31)
        Me.RBNombre.Name = "RBNombre"
        Me.RBNombre.Size = New System.Drawing.Size(75, 23)
        Me.RBNombre.TabIndex = 3
        Me.RBNombre.Text = "Nombre"
        '
        'CmbComunidad
        '
        Me.CmbComunidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbComunidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbComunidad.DisplayMember = "Text"
        Me.CmbComunidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbComunidad.FocusHighlightEnabled = True
        Me.CmbComunidad.FormattingEnabled = True
        Me.CmbComunidad.ItemHeight = 14
        Me.CmbComunidad.Location = New System.Drawing.Point(70, 8)
        Me.CmbComunidad.Name = "CmbComunidad"
        Me.CmbComunidad.Size = New System.Drawing.Size(395, 20)
        Me.CmbComunidad.TabIndex = 1
        '
        'LblTitCom
        '
        '
        '
        '
        Me.LblTitCom.BackgroundStyle.Class = ""
        Me.LblTitCom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitCom.Location = New System.Drawing.Point(6, 8)
        Me.LblTitCom.Name = "LblTitCom"
        Me.LblTitCom.Size = New System.Drawing.Size(65, 23)
        Me.LblTitCom.TabIndex = 0
        Me.LblTitCom.Text = "Comunidad"
        '
        'DGBus
        '
        Me.DGBus.AllowUserToAddRows = False
        Me.DGBus.AllowUserToDeleteRows = False
        Me.DGBus.AllowUserToOrderColumns = True
        Me.DGBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCuenta, Me.ColNombre, Me.ColDomicilio, Me.ColComunidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBus.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGBus.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGBus.Location = New System.Drawing.Point(6, 90)
        Me.DGBus.Name = "DGBus"
        Me.DGBus.ReadOnly = True
        Me.DGBus.Size = New System.Drawing.Size(460, 381)
        Me.DGBus.TabIndex = 8
        '
        'ColCuenta
        '
        Me.ColCuenta.DataPropertyName = "Cuenta"
        Me.ColCuenta.HeaderText = "Cuenta"
        Me.ColCuenta.Name = "ColCuenta"
        Me.ColCuenta.ReadOnly = True
        Me.ColCuenta.Width = 50
        '
        'ColNombre
        '
        Me.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColNombre.DataPropertyName = "Nombre"
        Me.ColNombre.HeaderText = "Nombre"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.ReadOnly = True
        Me.ColNombre.Width = 69
        '
        'ColDomicilio
        '
        Me.ColDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColDomicilio.DataPropertyName = "Domicilio"
        Me.ColDomicilio.HeaderText = "Domicilio"
        Me.ColDomicilio.Name = "ColDomicilio"
        Me.ColDomicilio.ReadOnly = True
        Me.ColDomicilio.Width = 74
        '
        'ColComunidad
        '
        Me.ColComunidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColComunidad.DataPropertyName = "Comunidad"
        Me.ColComunidad.HeaderText = "Comunidad"
        Me.ColComunidad.Name = "ColComunidad"
        Me.ColComunidad.ReadOnly = True
        Me.ColComunidad.Width = 85
        '
        'txtbusNombre
        '
        '
        '
        '
        Me.txtbusNombre.Border.Class = "TextBoxBorder"
        Me.txtbusNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtbusNombre.Location = New System.Drawing.Point(57, 61)
        Me.txtbusNombre.Name = "txtbusNombre"
        Me.txtbusNombre.Size = New System.Drawing.Size(375, 20)
        Me.txtbusNombre.TabIndex = 6
        '
        'LblNom
        '
        '
        '
        '
        Me.LblNom.BackgroundStyle.Class = ""
        Me.LblNom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblNom.Location = New System.Drawing.Point(6, 60)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(45, 23)
        Me.LblNom.TabIndex = 5
        Me.LblNom.Text = "Nombre"
        '
        'ExBus
        '
        Me.ExBus.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExBus.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExBus.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExBus.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExBus.ExpandableControl = Me.PanBuscar
        Me.ExBus.Expanded = False
        Me.ExBus.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExBus.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExBus.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExBus.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExBus.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExBus.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExBus.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExBus.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExBus.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ExBus.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ExBus.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExBus.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExBus.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExBus.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExBus.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExBus.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExBus.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExBus.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExBus.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExBus.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExBus.Location = New System.Drawing.Point(905, 42)
        Me.ExBus.Name = "ExBus"
        Me.ExBus.Size = New System.Drawing.Size(10, 561)
        Me.ExBus.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExBus.TabIndex = 28
        Me.ExBus.TabStop = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.AcquaLiberVista.My.Resources.Resources.imprimir
        Me.BtnAceptar.Location = New System.Drawing.Point(546, 303)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(80, 43)
        Me.BtnAceptar.TabIndex = 18
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.Red
        Me.LabelX7.Location = New System.Drawing.Point(265, 304)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(193, 20)
        Me.LabelX7.TabIndex = 32
        '
        'Factibilidadex
        '
        Me.Factibilidadex.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Factibilidadex.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Factibilidadex.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Factibilidadex.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Factibilidadex.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.Factibilidadex.Dock = System.Windows.Forms.DockStyle.Right
        Me.Factibilidadex.ExpandableControl = Me.Panelfactibilidad
        Me.Factibilidadex.Expanded = False
        Me.Factibilidadex.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Factibilidadex.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Factibilidadex.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Factibilidadex.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.Factibilidadex.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Factibilidadex.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.Factibilidadex.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Factibilidadex.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Factibilidadex.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Factibilidadex.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Factibilidadex.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.Factibilidadex.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.Factibilidadex.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Factibilidadex.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Factibilidadex.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Factibilidadex.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.Factibilidadex.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Factibilidadex.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Factibilidadex.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Factibilidadex.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Factibilidadex.Location = New System.Drawing.Point(895, 42)
        Me.Factibilidadex.Name = "Factibilidadex"
        Me.Factibilidadex.Size = New System.Drawing.Size(10, 561)
        Me.Factibilidadex.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.Factibilidadex.TabIndex = 27
        Me.Factibilidadex.TabStop = False
        '
        'Panelfactibilidad
        '
        Me.Panelfactibilidad.CanvasColor = System.Drawing.SystemColors.Control
        Me.Panelfactibilidad.Controls.Add(Me.BtnBusSol)
        Me.Panelfactibilidad.Controls.Add(Me.RBDomSol)
        Me.Panelfactibilidad.Controls.Add(Me.RBCueSol)
        Me.Panelfactibilidad.Controls.Add(Me.RBComNom)
        Me.Panelfactibilidad.Controls.Add(Me.DGBusSol)
        Me.Panelfactibilidad.Controls.Add(Me.TxtBusSol)
        Me.Panelfactibilidad.Controls.Add(Me.LblTituloSol)
        Me.Panelfactibilidad.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panelfactibilidad.Location = New System.Drawing.Point(750, 42)
        Me.Panelfactibilidad.Name = "Panelfactibilidad"
        Me.Panelfactibilidad.Size = New System.Drawing.Size(480, 560)
        Me.Panelfactibilidad.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panelfactibilidad.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Panelfactibilidad.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Panelfactibilidad.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panelfactibilidad.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panelfactibilidad.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panelfactibilidad.Style.GradientAngle = 90
        Me.Panelfactibilidad.TabIndex = 0
        Me.Panelfactibilidad.ThemeAware = True
        Me.Panelfactibilidad.Visible = False
        '
        'BtnBusSol
        '
        Me.BtnBusSol.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBusSol.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBusSol.Image = Global.AcquaLiberVista.My.Resources.Resources.kdict
        Me.BtnBusSol.Location = New System.Drawing.Point(425, 60)
        Me.BtnBusSol.Name = "BtnBusSol"
        Me.BtnBusSol.Size = New System.Drawing.Size(26, 21)
        Me.BtnBusSol.TabIndex = 5
        '
        'RBDomSol
        '
        '
        '
        '
        Me.RBDomSol.BackgroundStyle.Class = ""
        Me.RBDomSol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBDomSol.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBDomSol.Location = New System.Drawing.Point(166, 31)
        Me.RBDomSol.Name = "RBDomSol"
        Me.RBDomSol.Size = New System.Drawing.Size(75, 23)
        Me.RBDomSol.TabIndex = 2
        Me.RBDomSol.Text = "Domicilio"
        '
        'RBCueSol
        '
        '
        '
        '
        Me.RBCueSol.BackgroundStyle.Class = ""
        Me.RBCueSol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBCueSol.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBCueSol.Location = New System.Drawing.Point(4, 31)
        Me.RBCueSol.Name = "RBCueSol"
        Me.RBCueSol.Size = New System.Drawing.Size(75, 23)
        Me.RBCueSol.TabIndex = 0
        Me.RBCueSol.Text = "Cuenta"
        '
        'RBComNom
        '
        '
        '
        '
        Me.RBComNom.BackgroundStyle.Class = ""
        Me.RBComNom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBComNom.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBComNom.Checked = True
        Me.RBComNom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RBComNom.CheckValue = "Y"
        Me.RBComNom.Location = New System.Drawing.Point(85, 31)
        Me.RBComNom.Name = "RBComNom"
        Me.RBComNom.Size = New System.Drawing.Size(75, 23)
        Me.RBComNom.TabIndex = 1
        Me.RBComNom.Text = "Nombre"
        '
        'DGBusSol
        '
        Me.DGBusSol.AllowUserToAddRows = False
        Me.DGBusSol.AllowUserToDeleteRows = False
        Me.DGBusSol.AllowUserToOrderColumns = True
        Me.DGBusSol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBusSol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBusSol.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGBusSol.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGBusSol.Location = New System.Drawing.Point(6, 90)
        Me.DGBusSol.Name = "DGBusSol"
        Me.DGBusSol.ReadOnly = True
        Me.DGBusSol.Size = New System.Drawing.Size(460, 381)
        Me.DGBusSol.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cuenta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Domicilio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Domicilio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 74
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Comunidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Comunidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 85
        '
        'TxtBusSol
        '
        '
        '
        '
        Me.TxtBusSol.Border.Class = "TextBoxBorder"
        Me.TxtBusSol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBusSol.Location = New System.Drawing.Point(57, 61)
        Me.TxtBusSol.Name = "TxtBusSol"
        Me.TxtBusSol.Size = New System.Drawing.Size(362, 20)
        Me.TxtBusSol.TabIndex = 4
        '
        'LblTituloSol
        '
        '
        '
        '
        Me.LblTituloSol.BackgroundStyle.Class = ""
        Me.LblTituloSol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTituloSol.Location = New System.Drawing.Point(6, 60)
        Me.LblTituloSol.Name = "LblTituloSol"
        Me.LblTituloSol.Size = New System.Drawing.Size(45, 23)
        Me.LblTituloSol.TabIndex = 3
        Me.LblTituloSol.Text = "Nombre"
        '
        'ChkRedondeo
        '
        '
        '
        '
        Me.ChkRedondeo.BackgroundStyle.Class = ""
        Me.ChkRedondeo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkRedondeo.Location = New System.Drawing.Point(637, 340)
        Me.ChkRedondeo.Name = "ChkRedondeo"
        Me.ChkRedondeo.Size = New System.Drawing.Size(127, 23)
        Me.ChkRedondeo.TabIndex = 44
        Me.ChkRedondeo.Text = "Redondear Centavos"
        Me.ChkRedondeo.Visible = False
        '
        'CHKIMPRIMIR
        '
        Me.CHKIMPRIMIR.AutoSize = True
        Me.CHKIMPRIMIR.Checked = True
        Me.CHKIMPRIMIR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKIMPRIMIR.Location = New System.Drawing.Point(468, 304)
        Me.CHKIMPRIMIR.Name = "CHKIMPRIMIR"
        Me.CHKIMPRIMIR.Size = New System.Drawing.Size(76, 17)
        Me.CHKIMPRIMIR.TabIndex = 45
        Me.CHKIMPRIMIR.Text = "IMPRIMIR"
        Me.CHKIMPRIMIR.UseVisualStyleBackColor = True
        '
        'ckarriba
        '
        '
        '
        '
        Me.ckarriba.BackgroundStyle.Class = ""
        Me.ckarriba.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckarriba.Location = New System.Drawing.Point(781, 347)
        Me.ckarriba.Name = "ckarriba"
        Me.ckarriba.Size = New System.Drawing.Size(94, 11)
        Me.ckarriba.TabIndex = 46
        Me.ckarriba.Text = "Arriba"
        Me.ckarriba.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AcquaLiberVista.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(619, 154)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'TxtLecActual
        '
        Me.TxtLecActual.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtLecActual.Border.Class = "CrumbBarBackgroundKey"
        Me.TxtLecActual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtLecActual.Location = New System.Drawing.Point(324, 266)
        Me.TxtLecActual.Name = "TxtLecActual"
        Me.TxtLecActual.ReadOnly = True
        Me.TxtLecActual.Size = New System.Drawing.Size(67, 15)
        Me.TxtLecActual.TabIndex = 71
        Me.TxtLecActual.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(257, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Lec Actual:"
        '
        'TxtLecAnterior
        '
        Me.TxtLecAnterior.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtLecAnterior.Border.Class = "CrumbBarBackgroundKey"
        Me.TxtLecAnterior.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtLecAnterior.Location = New System.Drawing.Point(198, 266)
        Me.TxtLecAnterior.Name = "TxtLecAnterior"
        Me.TxtLecAnterior.ReadOnly = True
        Me.TxtLecAnterior.Size = New System.Drawing.Size(53, 15)
        Me.TxtLecAnterior.TabIndex = 69
        Me.TxtLecAnterior.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(119, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Lec. Anterior:"
        '
        'txtPer
        '
        Me.txtPer.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPer.Border.Class = "CrumbBarBackgroundKey"
        Me.txtPer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPer.Location = New System.Drawing.Point(449, 266)
        Me.txtPer.Name = "txtPer"
        Me.txtPer.ReadOnly = True
        Me.txtPer.Size = New System.Drawing.Size(165, 15)
        Me.txtPer.TabIndex = 67
        Me.txtPer.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(397, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Periodo:"
        '
        'txtTarifa
        '
        Me.txtTarifa.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTarifa.Border.Class = "CrumbBarBackgroundKey"
        Me.txtTarifa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTarifa.Location = New System.Drawing.Point(420, 242)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.ReadOnly = True
        Me.txtTarifa.Size = New System.Drawing.Size(197, 15)
        Me.txtTarifa.TabIndex = 65
        Me.txtTarifa.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(377, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Tarifa:"
        '
        'txtNumExt
        '
        Me.txtNumExt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNumExt.Border.Class = "CrumbBarBackgroundKey"
        Me.txtNumExt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumExt.Location = New System.Drawing.Point(440, 219)
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.ReadOnly = True
        Me.txtNumExt.Size = New System.Drawing.Size(76, 15)
        Me.txtNumExt.TabIndex = 61
        Me.txtNumExt.TabStop = False
        '
        'txtNumInt
        '
        Me.txtNumInt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNumInt.Border.Class = "CrumbBarBackgroundKey"
        Me.txtNumInt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumInt.Location = New System.Drawing.Point(522, 219)
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.ReadOnly = True
        Me.txtNumInt.Size = New System.Drawing.Size(95, 15)
        Me.txtNumInt.TabIndex = 63
        Me.txtNumInt.TabStop = False
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCalle.Border.Class = "CrumbBarBackgroundKey"
        Me.txtCalle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCalle.Location = New System.Drawing.Point(115, 219)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(319, 15)
        Me.txtCalle.TabIndex = 57
        Me.txtCalle.TabStop = False
        '
        'txtRfc
        '
        Me.txtRfc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtRfc.Border.Class = "CrumbBarBackgroundKey"
        Me.txtRfc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRfc.Location = New System.Drawing.Point(171, 242)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.ReadOnly = True
        Me.txtRfc.Size = New System.Drawing.Size(188, 15)
        Me.txtRfc.TabIndex = 59
        Me.txtRfc.TabStop = False
        '
        'txtCp
        '
        Me.txtCp.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCp.Border.Class = "CrumbBarBackgroundKey"
        Me.txtCp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCp.Location = New System.Drawing.Point(365, 197)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.ReadOnly = True
        Me.txtCp.Size = New System.Drawing.Size(252, 15)
        Me.txtCp.TabIndex = 55
        Me.txtCp.TabStop = False
        '
        'txtCol
        '
        Me.txtCol.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCol.Border.Class = "CrumbBarBackgroundKey"
        Me.txtCol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCol.Location = New System.Drawing.Point(115, 197)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.ReadOnly = True
        Me.txtCol.Size = New System.Drawing.Size(179, 15)
        Me.txtCol.TabIndex = 53
        Me.txtCol.TabStop = False
        '
        'txtCom
        '
        Me.txtCom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCom.Border.Class = "CrumbBarBackgroundKey"
        Me.txtCom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCom.Location = New System.Drawing.Point(115, 175)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.ReadOnly = True
        Me.txtCom.Size = New System.Drawing.Size(502, 15)
        Me.txtCom.TabIndex = 51
        Me.txtCom.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombre.Border.Class = "CrumbBarBackgroundKey"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(115, 145)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(502, 24)
        Me.txtNombre.TabIndex = 49
        Me.txtNombre.TabStop = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(323, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "C. P. :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(119, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "R. F. C.:"
        '
        'Dlgproceso
        '
        Me.Dlgproceso.Controls.Add(Me.Label2)
        Me.Dlgproceso.Location = New System.Drawing.Point(120, 239)
        Me.Dlgproceso.Name = "Dlgproceso"
        Me.Dlgproceso.Size = New System.Drawing.Size(652, 134)
        Me.Dlgproceso.TabIndex = 74
        Me.Dlgproceso.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(497, 42)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Espere... ! CALCULANDO !"
        '
        'ComboRob1
        '
        Me.ComboRob1.BackColor = System.Drawing.Color.Transparent
        Me.ComboRob1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ComboRob1.cadsql = ""
        Me.ComboRob1.camagr = ""
        Me.ComboRob1.campos = Nothing
        Me.ComboRob1.dgExt = Me.dgCob
        Me.ComboRob1.Location = New System.Drawing.Point(111, 322)
        Me.ComboRob1.Name = "ComboRob1"
        Me.ComboRob1.Panel = Me.gpGrid
        Me.ComboRob1.Size = New System.Drawing.Size(433, 28)
        Me.ComboRob1.TabIndex = 21
        Me.ComboRob1.tabla = "otrosconceptos"
        '
        'frmCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 613)
        Me.Controls.Add(Me.Dlgproceso)
        Me.Controls.Add(Me.TxtLecActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtLecAnterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTarifa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumExt)
        Me.Controls.Add(Me.txtNumInt)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CHKIMPRIMIR)
        Me.Controls.Add(Me.Panelfactibilidad)
        Me.Controls.Add(Me.Factibilidadex)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.ExBus)
        Me.Controls.Add(Me.PanBuscar)
        Me.Controls.Add(Me.LblCaja)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtCodBar)
        Me.Controls.Add(Me.rOp)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblRecibo)
        Me.Controls.Add(Me.LblSerie)
        Me.Controls.Add(Me.LblTitRecibo)
        Me.Controls.Add(Me.ExFpago)
        Me.Controls.Add(Me.PanObserva)
        Me.Controls.Add(Me.PanFactibilidad)
        Me.Controls.Add(Me.RBNoPadron)
        Me.Controls.Add(Me.RBFactibilidades)
        Me.Controls.Add(Me.RBUsuarios)
        Me.Controls.Add(Me.CmbPeriodos)
        Me.Controls.Add(Me.chkOtros)
        Me.Controls.Add(Me.ChkConsumo)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanUsuarios)
        Me.Controls.Add(Me.ComboRob1)
        Me.Controls.Add(Me.gpGrid)
        Me.Controls.Add(Me.cmbComu)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.CmbNousuarios)
        Me.Controls.Add(Me.ckarriba)
        Me.Controls.Add(Me.ChkRedondeo)
        Me.Controls.Add(Me.TxtSolicitud)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "frmCajas"
        Me.Text = "Cajas"
        Me.gpGrid.ResumeLayout(False)
        CType(Me.dgCob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanUsuarios.ResumeLayout(False)
        Me.PanUsuarios.PerformLayout()
        Me.PanFactibilidad.ResumeLayout(False)
        Me.PanFactibilidad.PerformLayout()
        Me.PanObserva.ResumeLayout(False)
        CType(Me.DTFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBuscar.ResumeLayout(False)
        CType(Me.DGBus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelfactibilidad.ResumeLayout(False)
        CType(Me.DGBusSol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dlgproceso.ResumeLayout(False)
        Me.Dlgproceso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdExt As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmbComu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtCuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents gpGrid As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgCob As DevComponents.DotNetBar.Controls.DataGridViewX

    Friend WithEvents ComboRob1 As AcquaLiberVista.comboRob
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Protected WithEvents txtSubTot As System.Windows.Forms.TextBox
    Protected WithEvents txtIva As System.Windows.Forms.TextBox
    Protected WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents PanUsuarios As System.Windows.Forms.Panel
    Protected WithEvents txtDescu As System.Windows.Forms.TextBox
    Protected WithEvents txtOtros As System.Windows.Forms.TextBox
    Protected WithEvents txtReca As System.Windows.Forms.TextBox
    Protected WithEvents txtAlcanta As System.Windows.Forms.TextBox
    Protected WithEvents txtSaneamiento As System.Windows.Forms.TextBox
    Protected WithEvents txtConsumo As System.Windows.Forms.TextBox
    Protected WithEvents txtReza As System.Windows.Forms.TextBox
    Friend WithEvents cmdAgr As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblDescuento As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdAct As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImpCort As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ChkConsumo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkOtros As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LblAnticipo As DevComponents.DotNetBar.LabelX
    Protected WithEvents TxtAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents CmbPeriodos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents RBUsuarios As System.Windows.Forms.RadioButton
    Friend WithEvents RBFactibilidades As System.Windows.Forms.RadioButton
    Friend WithEvents RBNoPadron As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSolicitud As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblFactibilidad As DevComponents.DotNetBar.LabelX
    Protected WithEvents TxtFactibilidad As System.Windows.Forms.TextBox
    Friend WithEvents PanFactibilidad As System.Windows.Forms.Panel
    Friend WithEvents CmbNousuarios As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PanObserva As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ExFpago As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents LblReferencia As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtReferencia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CmbFormaPago As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblFpago As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblObservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblTitRecibo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblSerie As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblRecibo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents DTFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TxtCodBar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnCalcular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblCaja As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanBuscar As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ExBus As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents DGBus As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtbusNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblNom As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColComunidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RBDomicilio As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBCuenta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBNombre As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CmbComunidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblTitCom As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Factibilidadex As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents Panelfactibilidad As DevComponents.DotNetBar.PanelEx
    Friend WithEvents RBDomSol As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBCueSol As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBComNom As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents DGBusSol As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtBusSol As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblTituloSol As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnBusqueda As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnBusSol As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ChkDirFis As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LblDirFis4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblDirFis3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDirFis2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDirFis1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitDatosFis As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblRecargoO As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Protected WithEvents TxtRecargoOtros As System.Windows.Forms.TextBox
    Friend WithEvents lblRedondeo As DevComponents.DotNetBar.LabelX
    Protected WithEvents TxtRedondeo As System.Windows.Forms.TextBox
    Friend WithEvents lblLinea1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChkRedondeo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CHKIMPRIMIR As System.Windows.Forms.CheckBox
    Friend WithEvents ckarriba As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recargos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tabla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtLecActual As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtLecAnterior As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTarifa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNumExt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNumInt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRfc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCol As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Dlgproceso As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
