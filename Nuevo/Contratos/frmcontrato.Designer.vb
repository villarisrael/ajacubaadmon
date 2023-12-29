
Imports DevComponents.DotNetBar
Partial Class frmcontrato
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Tabsolicitud = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gpDatRec = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rbDirFis = New System.Windows.Forms.RadioButton()
        Me.rbDomAu = New System.Windows.Forms.RadioButton()
        Me.rbDirUbi = New System.Windows.Forms.RadioButton()
        Me.gpUbiToma = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtUbicacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmbcalle = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDomicilio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmbubmedidor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Cmbmatcalle = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblubicacion = New DevComponents.DotNetBar.LabelX()
        Me.LblGis = New DevComponents.DotNetBar.LabelX()
        Me.LblTitGis = New DevComponents.DotNetBar.LabelX()
        Me.cmbRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtlote = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmzn = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblManzana = New System.Windows.Forms.Label()
        Me.cmbruta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtcp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnumint = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnumext = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Cmbmunicipio = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbcolonia = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Cmbcomunidad = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Cmbsector = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblcomunidad = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblsector = New System.Windows.Forms.Label()
        Me.lblcp = New System.Windows.Forms.Label()
        Me.lblcolonia = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.gpDatServ = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmbCuoValvu = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblCuoValvu = New System.Windows.Forms.Label()
        Me.cmbDescuento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.txtctoagua = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtctodrenaje = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.ChkAltoCon = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ChkGestCob = New System.Windows.Forms.CheckBox()
        Me.cmbnivsoc = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cmbgiro = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblGiro = New System.Windows.Forms.Label()
        Me.CmbEstPredio = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkSanea = New System.Windows.Forms.CheckBox()
        Me.chkAlcantarillado = New System.Windows.Forms.CheckBox()
        Me.cmbFservicio = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cmbtipouso = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbtarifa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.gpDatCont = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DTfechadeuda = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtCedulaC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CedulaC = New System.Windows.Forms.Label()
        Me.txtidentificacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtparentesco = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsolicitado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblidentificacion = New System.Windows.Forms.Label()
        Me.lblparentesco = New System.Windows.Forms.Label()
        Me.lblsolicitado = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.MaskedTextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.txtpropietario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.dtfsolicitud = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Cmbestado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.txtclave = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblsolicitud = New System.Windows.Forms.Label()
        Me.LstCalles = New System.Windows.Forms.ListBox()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel7 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.btnExaminar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.BtnActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnBorrar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.lblnombreexp = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.textDescripcion = New DevComponents.DotNetBar.TextBoxItem()
        Me.lblexaminar = New DevComponents.DotNetBar.LabelItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem4 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem5 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.mostrar = New System.Windows.Forms.DataGridView()
        Me.tabDocumentos = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.tabcFotos = New DevComponents.DotNetBar.TabControlPanel()
        Me.gpFotos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.tabfotos = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel()
        Me.DTgfecha = New System.Windows.Forms.DataGridView()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.DtgTarifa = New System.Windows.Forms.DataGridView()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.DtgNombre = New System.Windows.Forms.DataGridView()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAgregar = New DevComponents.DotNetBar.ButtonX()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.dporce = New System.Windows.Forms.NumericUpDown()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cmbtarifa2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TarifasAdicionales = New System.Windows.Forms.DataGridView()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gpClaWeb = New System.Windows.Forms.GroupBox()
        Me.txtemail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtrespsec = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtpreguntasecreta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtpass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.claveweb = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gpDatEscri = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtescritura = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtcatastral = New System.Windows.Forms.MaskedTextBox()
        Me.cmbCaracter = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.lblEscritura = New System.Windows.Forms.Label()
        Me.lblCaracter = New System.Windows.Forms.Label()
        Me.TabLegalyaudencia = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gpDatTec = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CmbMarcaMedidor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CmbDiamToma = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbDiamMed = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dtffechainst = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.nderivacion = New System.Windows.Forms.NumericUpDown()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtnumerodemedidor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTinaco = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCisterna = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAlberca = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.gpObserva = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtobservacioncontrato = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.gpDatUbi = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CMBCALLE4 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CMBCALLE3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CMBCALLE2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CMBCALLE1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtGps33 = New System.Windows.Forms.TextBox()
        Me.txtGps22 = New System.Windows.Forms.TextBox()
        Me.txtGps11 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtreferencias = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblUbicacionEspecifica = New System.Windows.Forms.Label()
        Me.lblc4 = New System.Windows.Forms.Label()
        Me.lblc3 = New System.Windows.Forms.Label()
        Me.lblc2 = New System.Windows.Forms.Label()
        Me.lblc1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Referencias = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TxtGps3 = New System.Windows.Forms.TextBox()
        Me.TxtGps2 = New System.Windows.Forms.TextBox()
        Me.TxtGps1 = New System.Windows.Forms.TextBox()
        Me.LblUbicacionGPS = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbMarcaMedidor1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiamMedidor = New System.Windows.Forms.NumericUpDown()
        Me.lblDiamToma = New System.Windows.Forms.Label()
        Me.lblTinaco = New System.Windows.Forms.Label()
        Me.lblDiamMedidor = New System.Windows.Forms.Label()
        Me.lblCisterna = New System.Windows.Forms.Label()
        Me.txtNoMedidor = New System.Windows.Forms.TextBox()
        Me.lblAlberca = New System.Windows.Forms.Label()
        Me.lblNoMedidor = New System.Windows.Forms.Label()
        Me.lblMarcaMedidor = New System.Windows.Forms.Label()
        Me.txtFactibilidad = New System.Windows.Forms.TextBox()
        Me.lblFactibilidad = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClavePredial = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.lblClavePredial = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDerivaciones = New System.Windows.Forms.Label()
        Me.txtDerivaciones = New System.Windows.Forms.TextBox()
        Me.lblpagohasta = New System.Windows.Forms.Label()
        Me.dtpPagoHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdMail = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdAgrCar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.btnver = New DevComponents.DotNetBar.ButtonItem()
        CType(Me.Tabsolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabsolicitud.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpDatRec.SuspendLayout()
        Me.gpUbiToma.SuspendLayout()
        Me.gpDatServ.SuspendLayout()
        Me.gpDatCont.SuspendLayout()
        CType(Me.DTfechadeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfsolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel7.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        CType(Me.mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabcFotos.SuspendLayout()
        Me.gpFotos.SuspendLayout()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel6.SuspendLayout()
        CType(Me.DTgfecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel5.SuspendLayout()
        CType(Me.dporce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifasAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel4.SuspendLayout()
        Me.gpClaWeb.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.gpDatEscri.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.gpDatTec.SuspendLayout()
        CType(Me.dtffechainst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nderivacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTinaco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCisterna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlberca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpObserva.SuspendLayout()
        Me.gpDatUbi.SuspendLayout()
        CType(Me.txtDiamMedidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabsolicitud
        '
        Me.Tabsolicitud.AutoCloseTabs = True
        Me.Tabsolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Tabsolicitud.CanReorderTabs = True
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel7)
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel1)
        Me.Tabsolicitud.Controls.Add(Me.tabcFotos)
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel6)
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel5)
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel4)
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel3)
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel2)
        Me.Tabsolicitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabsolicitud.Location = New System.Drawing.Point(0, 42)
        Me.Tabsolicitud.Name = "Tabsolicitud"
        Me.Tabsolicitud.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tabsolicitud.SelectedTabIndex = 0
        Me.Tabsolicitud.Size = New System.Drawing.Size(1041, 538)
        Me.Tabsolicitud.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.Tabsolicitud.TabIndex = 1
        Me.Tabsolicitud.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.Tabsolicitud.Tabs.Add(Me.TabItem3)
        Me.Tabsolicitud.Tabs.Add(Me.Referencias)
        Me.Tabsolicitud.Tabs.Add(Me.TabLegalyaudencia)
        Me.Tabsolicitud.Tabs.Add(Me.claveweb)
        Me.Tabsolicitud.Tabs.Add(Me.tabfotos)
        Me.Tabsolicitud.Tabs.Add(Me.TabItem1)
        Me.Tabsolicitud.Tabs.Add(Me.TabItem2)
        Me.Tabsolicitud.Tabs.Add(Me.tabDocumentos)
        Me.Tabsolicitud.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.Controls.Add(Me.gpDatRec)
        Me.TabControlPanel1.Controls.Add(Me.gpUbiToma)
        Me.TabControlPanel1.Controls.Add(Me.gpDatServ)
        Me.TabControlPanel1.Controls.Add(Me.gpDatCont)
        Me.TabControlPanel1.Controls.Add(Me.lblsolicitud)
        Me.TabControlPanel1.Controls.Add(Me.LstCalles)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1041, 516)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 0
        Me.TabControlPanel1.TabItem = Me.TabItem3
        '
        'gpDatRec
        '
        Me.gpDatRec.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatRec.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatRec.Controls.Add(Me.rbDirFis)
        Me.gpDatRec.Controls.Add(Me.rbDomAu)
        Me.gpDatRec.Controls.Add(Me.rbDirUbi)
        Me.gpDatRec.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatRec.Location = New System.Drawing.Point(25, 414)
        Me.gpDatRec.Name = "gpDatRec"
        Me.gpDatRec.Size = New System.Drawing.Size(966, 36)
        '
        '
        '
        Me.gpDatRec.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatRec.Style.BackColorGradientAngle = 90
        Me.gpDatRec.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatRec.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatRec.Style.BorderBottomWidth = 1
        Me.gpDatRec.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatRec.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatRec.Style.BorderLeftWidth = 1
        Me.gpDatRec.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatRec.Style.BorderRightWidth = 1
        Me.gpDatRec.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatRec.Style.BorderTopWidth = 1
        Me.gpDatRec.Style.CornerDiameter = 4
        Me.gpDatRec.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatRec.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatRec.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatRec.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatRec.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatRec.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatRec.TabIndex = 3
        Me.gpDatRec.Text = "¿En qué dirección se deben recibir notificaciones?"
        '
        'rbDirFis
        '
        Me.rbDirFis.AutoSize = True
        Me.rbDirFis.BackColor = System.Drawing.Color.Transparent
        Me.rbDirFis.Location = New System.Drawing.Point(476, -1)
        Me.rbDirFis.Name = "rbDirFis"
        Me.rbDirFis.Size = New System.Drawing.Size(97, 17)
        Me.rbDirFis.TabIndex = 2
        Me.rbDirFis.TabStop = True
        Me.rbDirFis.Text = "Domicilio Fiscal"
        Me.rbDirFis.UseVisualStyleBackColor = False
        '
        'rbDomAu
        '
        Me.rbDomAu.AutoSize = True
        Me.rbDomAu.BackColor = System.Drawing.Color.Transparent
        Me.rbDomAu.Location = New System.Drawing.Point(233, -1)
        Me.rbDomAu.Name = "rbDomAu"
        Me.rbDomAu.Size = New System.Drawing.Size(131, 17)
        Me.rbDomAu.TabIndex = 1
        Me.rbDomAu.TabStop = True
        Me.rbDomAu.Text = "Domicilio de audiencia"
        Me.rbDomAu.UseVisualStyleBackColor = False
        Me.rbDomAu.Visible = False
        '
        'rbDirUbi
        '
        Me.rbDirUbi.AutoSize = True
        Me.rbDirUbi.BackColor = System.Drawing.Color.Transparent
        Me.rbDirUbi.Location = New System.Drawing.Point(3, -1)
        Me.rbDirUbi.Name = "rbDirUbi"
        Me.rbDirUbi.Size = New System.Drawing.Size(103, 17)
        Me.rbDirUbi.TabIndex = 0
        Me.rbDirUbi.TabStop = True
        Me.rbDirUbi.Tag = ""
        Me.rbDirUbi.Text = "Ubicación Toma"
        Me.rbDirUbi.UseVisualStyleBackColor = False
        '
        'gpUbiToma
        '
        Me.gpUbiToma.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpUbiToma.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpUbiToma.Controls.Add(Me.txtUbicacion)
        Me.gpUbiToma.Controls.Add(Me.Label55)
        Me.gpUbiToma.Controls.Add(Me.Label54)
        Me.gpUbiToma.Controls.Add(Me.cmbcalle)
        Me.gpUbiToma.Controls.Add(Me.txtDomicilio)
        Me.gpUbiToma.Controls.Add(Me.Label46)
        Me.gpUbiToma.Controls.Add(Me.cmbubmedidor)
        Me.gpUbiToma.Controls.Add(Me.Label45)
        Me.gpUbiToma.Controls.Add(Me.Cmbmatcalle)
        Me.gpUbiToma.Controls.Add(Me.lblubicacion)
        Me.gpUbiToma.Controls.Add(Me.LblGis)
        Me.gpUbiToma.Controls.Add(Me.LblTitGis)
        Me.gpUbiToma.Controls.Add(Me.cmbRegion)
        Me.gpUbiToma.Controls.Add(Me.Label20)
        Me.gpUbiToma.Controls.Add(Me.txtlote)
        Me.gpUbiToma.Controls.Add(Me.txtmzn)
        Me.gpUbiToma.Controls.Add(Me.lblManzana)
        Me.gpUbiToma.Controls.Add(Me.cmbruta)
        Me.gpUbiToma.Controls.Add(Me.Label40)
        Me.gpUbiToma.Controls.Add(Me.txtcp)
        Me.gpUbiToma.Controls.Add(Me.txtnumint)
        Me.gpUbiToma.Controls.Add(Me.txtnumext)
        Me.gpUbiToma.Controls.Add(Me.Cmbmunicipio)
        Me.gpUbiToma.Controls.Add(Me.cmbcolonia)
        Me.gpUbiToma.Controls.Add(Me.Cmbcomunidad)
        Me.gpUbiToma.Controls.Add(Me.Cmbsector)
        Me.gpUbiToma.Controls.Add(Me.lblcomunidad)
        Me.gpUbiToma.Controls.Add(Me.Label8)
        Me.gpUbiToma.Controls.Add(Me.lblMunicipio)
        Me.gpUbiToma.Controls.Add(Me.Label7)
        Me.gpUbiToma.Controls.Add(Me.lblsector)
        Me.gpUbiToma.Controls.Add(Me.lblcp)
        Me.gpUbiToma.Controls.Add(Me.lblcolonia)
        Me.gpUbiToma.Controls.Add(Me.lblCalle)
        Me.gpUbiToma.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpUbiToma.Location = New System.Drawing.Point(25, 271)
        Me.gpUbiToma.Name = "gpUbiToma"
        Me.gpUbiToma.Size = New System.Drawing.Size(966, 139)
        '
        '
        '
        Me.gpUbiToma.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpUbiToma.Style.BackColorGradientAngle = 90
        Me.gpUbiToma.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpUbiToma.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUbiToma.Style.BorderBottomWidth = 1
        Me.gpUbiToma.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpUbiToma.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUbiToma.Style.BorderLeftWidth = 1
        Me.gpUbiToma.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUbiToma.Style.BorderRightWidth = 1
        Me.gpUbiToma.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUbiToma.Style.BorderTopWidth = 1
        Me.gpUbiToma.Style.CornerDiameter = 4
        Me.gpUbiToma.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpUbiToma.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpUbiToma.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpUbiToma.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpUbiToma.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpUbiToma.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpUbiToma.TabIndex = 2
        Me.gpUbiToma.Text = "Ubicación de la toma"
        '
        'txtUbicacion
        '
        '
        '
        '
        Me.txtUbicacion.Border.Class = "TextBoxBorder"
        Me.txtUbicacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.Enabled = False
        Me.txtUbicacion.FocusHighlightEnabled = True
        Me.txtUbicacion.Location = New System.Drawing.Point(892, 2)
        Me.txtUbicacion.MaxLength = 7
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(60, 20)
        Me.txtUbicacion.TabIndex = 36
        Me.txtUbicacion.Text = "01020000"
        Me.txtUbicacion.WatermarkText = "Lote en la que se ubica"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(830, 7)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(58, 13)
        Me.Label55.TabIndex = 35
        Me.Label55.Text = "Ubicacion:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(730, 7)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(31, 13)
        Me.Label54.TabIndex = 34
        Me.Label54.Text = "Lote:"
        '
        'cmbcalle
        '
        Me.cmbcalle.DisplayMember = "Text"
        Me.cmbcalle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcalle.FormattingEnabled = True
        Me.cmbcalle.ItemHeight = 14
        Me.cmbcalle.Location = New System.Drawing.Point(61, 30)
        Me.cmbcalle.Name = "cmbcalle"
        Me.cmbcalle.Size = New System.Drawing.Size(402, 20)
        Me.cmbcalle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbcalle.TabIndex = 33
        '
        'txtDomicilio
        '
        '
        '
        '
        Me.txtDomicilio.Border.Class = "TextBoxBorder"
        Me.txtDomicilio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.FocusHighlightEnabled = True
        Me.txtDomicilio.Location = New System.Drawing.Point(61, 30)
        Me.txtDomicilio.MaxLength = 120
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(402, 20)
        Me.txtDomicilio.TabIndex = 32
        Me.txtDomicilio.WatermarkText = "Escribe el domicilio del propietario"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(699, 100)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(111, 13)
        Me.Label46.TabIndex = 31
        Me.Label46.Text = "Ubicacion de Medidor"
        '
        'cmbubmedidor
        '
        Me.cmbubmedidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbubmedidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbubmedidor.DisplayMember = "Text"
        Me.cmbubmedidor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbubmedidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbubmedidor.FocusHighlightEnabled = True
        Me.cmbubmedidor.FormattingEnabled = True
        Me.cmbubmedidor.ItemHeight = 14
        Me.cmbubmedidor.Location = New System.Drawing.Point(815, 96)
        Me.cmbubmedidor.Name = "cmbubmedidor"
        Me.cmbubmedidor.Size = New System.Drawing.Size(128, 20)
        Me.cmbubmedidor.TabIndex = 11
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.ForeColor = System.Drawing.Color.Red
        Me.Label45.Location = New System.Drawing.Point(435, 100)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(85, 13)
        Me.Label45.TabIndex = 29
        Me.Label45.Text = "Material de Calle"
        '
        'Cmbmatcalle
        '
        Me.Cmbmatcalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbmatcalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbmatcalle.DisplayMember = "Text"
        Me.Cmbmatcalle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbmatcalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbmatcalle.FocusHighlightEnabled = True
        Me.Cmbmatcalle.FormattingEnabled = True
        Me.Cmbmatcalle.ItemHeight = 14
        Me.Cmbmatcalle.Location = New System.Drawing.Point(524, 96)
        Me.Cmbmatcalle.Name = "Cmbmatcalle"
        Me.Cmbmatcalle.Size = New System.Drawing.Size(130, 20)
        Me.Cmbmatcalle.TabIndex = 10
        '
        'lblubicacion
        '
        Me.lblubicacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblubicacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblubicacion.Location = New System.Drawing.Point(95, 95)
        Me.lblubicacion.Name = "lblubicacion"
        Me.lblubicacion.Size = New System.Drawing.Size(103, 11)
        Me.lblubicacion.TabIndex = 27
        Me.lblubicacion.Text = "ubicacion"
        '
        'LblGis
        '
        '
        '
        '
        Me.LblGis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblGis.Location = New System.Drawing.Point(26, 90)
        Me.LblGis.Name = "LblGis"
        Me.LblGis.Size = New System.Drawing.Size(27, 20)
        Me.LblGis.TabIndex = 26
        '
        'LblTitGis
        '
        Me.LblTitGis.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitGis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitGis.Location = New System.Drawing.Point(5, 90)
        Me.LblTitGis.Name = "LblTitGis"
        Me.LblTitGis.Size = New System.Drawing.Size(29, 23)
        Me.LblTitGis.TabIndex = 24
        Me.LblTitGis.Text = "Gis"
        '
        'cmbRegion
        '
        Me.cmbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRegion.DisplayMember = "Text"
        Me.cmbRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegion.FocusHighlightEnabled = True
        Me.cmbRegion.FormattingEnabled = True
        Me.cmbRegion.ItemHeight = 14
        Me.cmbRegion.Location = New System.Drawing.Point(66, 2)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(255, 20)
        Me.cmbRegion.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(5, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Region:"
        '
        'txtlote
        '
        '
        '
        '
        Me.txtlote.Border.Class = "TextBoxBorder"
        Me.txtlote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtlote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlote.FocusHighlightEnabled = True
        Me.txtlote.Location = New System.Drawing.Point(770, 4)
        Me.txtlote.MaxLength = 7
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(51, 20)
        Me.txtlote.TabIndex = 3
        Me.txtlote.Text = "0"
        Me.txtlote.WatermarkText = "Lote en la que se ubica"
        '
        'txtmzn
        '
        '
        '
        '
        Me.txtmzn.Border.Class = "TextBoxBorder"
        Me.txtmzn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmzn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmzn.FocusHighlightEnabled = True
        Me.txtmzn.Location = New System.Drawing.Point(631, 4)
        Me.txtmzn.MaxLength = 3
        Me.txtmzn.Name = "txtmzn"
        Me.txtmzn.Size = New System.Drawing.Size(93, 20)
        Me.txtmzn.TabIndex = 2
        Me.txtmzn.Text = "0"
        Me.txtmzn.WatermarkText = "Manzana en la que se ubica"
        '
        'lblManzana
        '
        Me.lblManzana.AutoSize = True
        Me.lblManzana.BackColor = System.Drawing.Color.Transparent
        Me.lblManzana.ForeColor = System.Drawing.Color.Black
        Me.lblManzana.Location = New System.Drawing.Point(575, 8)
        Me.lblManzana.Name = "lblManzana"
        Me.lblManzana.Size = New System.Drawing.Size(54, 13)
        Me.lblManzana.TabIndex = 10
        Me.lblManzana.Text = "Manzana:"
        '
        'cmbruta
        '
        Me.cmbruta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbruta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbruta.DisplayMember = "Text"
        Me.cmbruta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbruta.FocusHighlightEnabled = True
        Me.cmbruta.FormattingEnabled = True
        Me.cmbruta.ItemHeight = 14
        Me.cmbruta.Location = New System.Drawing.Point(370, 4)
        Me.cmbruta.Name = "cmbruta"
        Me.cmbruta.Size = New System.Drawing.Size(203, 20)
        Me.cmbruta.TabIndex = 1
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(331, 8)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 13)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Ruta:"
        '
        'txtcp
        '
        '
        '
        '
        Me.txtcp.Border.Class = "TextBoxBorder"
        Me.txtcp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcp.FocusHighlightEnabled = True
        Me.txtcp.Location = New System.Drawing.Point(807, 59)
        Me.txtcp.MaxLength = 5
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(62, 20)
        Me.txtcp.TabIndex = 9
        Me.txtcp.WatermarkText = "Código"
        '
        'txtnumint
        '
        '
        '
        '
        Me.txtnumint.Border.Class = "TextBoxBorder"
        Me.txtnumint.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnumint.FocusHighlightEnabled = True
        Me.txtnumint.Location = New System.Drawing.Point(777, 32)
        Me.txtnumint.MaxLength = 10
        Me.txtnumint.Name = "txtnumint"
        Me.txtnumint.Size = New System.Drawing.Size(84, 20)
        Me.txtnumint.TabIndex = 6
        Me.txtnumint.WatermarkText = "Acepta letras"
        '
        'txtnumext
        '
        '
        '
        '
        Me.txtnumext.Border.Class = "TextBoxBorder"
        Me.txtnumext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnumext.FocusHighlightEnabled = True
        Me.txtnumext.Location = New System.Drawing.Point(561, 32)
        Me.txtnumext.MaxLength = 10
        Me.txtnumext.Name = "txtnumext"
        Me.txtnumext.Size = New System.Drawing.Size(109, 20)
        Me.txtnumext.TabIndex = 5
        Me.txtnumext.WatermarkText = "Número de la casa"
        '
        'Cmbmunicipio
        '
        Me.Cmbmunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbmunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbmunicipio.DisplayMember = "Text"
        Me.Cmbmunicipio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbmunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbmunicipio.FocusHighlightEnabled = True
        Me.Cmbmunicipio.FormattingEnabled = True
        Me.Cmbmunicipio.ItemHeight = 14
        Me.Cmbmunicipio.Location = New System.Drawing.Point(382, 58)
        Me.Cmbmunicipio.Name = "Cmbmunicipio"
        Me.Cmbmunicipio.Size = New System.Drawing.Size(127, 20)
        Me.Cmbmunicipio.TabIndex = 7
        '
        'cmbcolonia
        '
        Me.cmbcolonia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcolonia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcolonia.DisplayMember = "Text"
        Me.cmbcolonia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcolonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcolonia.FocusHighlightEnabled = True
        Me.cmbcolonia.FormattingEnabled = True
        Me.cmbcolonia.ItemHeight = 14
        Me.cmbcolonia.Location = New System.Drawing.Point(62, 57)
        Me.cmbcolonia.Name = "cmbcolonia"
        Me.cmbcolonia.Size = New System.Drawing.Size(255, 20)
        Me.cmbcolonia.TabIndex = 5
        '
        'Cmbcomunidad
        '
        Me.Cmbcomunidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbcomunidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbcomunidad.DisplayMember = "Text"
        Me.Cmbcomunidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbcomunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcomunidad.FocusHighlightEnabled = True
        Me.Cmbcomunidad.FormattingEnabled = True
        Me.Cmbcomunidad.ItemHeight = 14
        Me.Cmbcomunidad.Location = New System.Drawing.Point(579, 61)
        Me.Cmbcomunidad.Name = "Cmbcomunidad"
        Me.Cmbcomunidad.Size = New System.Drawing.Size(190, 20)
        Me.Cmbcomunidad.TabIndex = 8
        '
        'Cmbsector
        '
        Me.Cmbsector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbsector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbsector.DisplayMember = "Text"
        Me.Cmbsector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbsector.FocusHighlightEnabled = True
        Me.Cmbsector.FormattingEnabled = True
        Me.Cmbsector.ItemHeight = 14
        Me.Cmbsector.Location = New System.Drawing.Point(66, 2)
        Me.Cmbsector.Name = "Cmbsector"
        Me.Cmbsector.Size = New System.Drawing.Size(203, 20)
        Me.Cmbsector.TabIndex = 0
        Me.Cmbsector.Visible = False
        '
        'lblcomunidad
        '
        Me.lblcomunidad.AutoSize = True
        Me.lblcomunidad.BackColor = System.Drawing.Color.Transparent
        Me.lblcomunidad.ForeColor = System.Drawing.Color.Red
        Me.lblcomunidad.Location = New System.Drawing.Point(515, 61)
        Me.lblcomunidad.Name = "lblcomunidad"
        Me.lblcomunidad.Size = New System.Drawing.Size(63, 13)
        Me.lblcomunidad.TabIndex = 4
        Me.lblcomunidad.Text = "Comunidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(690, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Número Interior"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.lblMunicipio.ForeColor = System.Drawing.Color.Red
        Me.lblMunicipio.Location = New System.Drawing.Point(326, 61)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(55, 13)
        Me.lblMunicipio.TabIndex = 0
        Me.lblMunicipio.Text = "Municipio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(472, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Número Exterior:"
        '
        'lblsector
        '
        Me.lblsector.AutoSize = True
        Me.lblsector.BackColor = System.Drawing.Color.Transparent
        Me.lblsector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsector.Location = New System.Drawing.Point(5, 6)
        Me.lblsector.Name = "lblsector"
        Me.lblsector.Size = New System.Drawing.Size(35, 13)
        Me.lblsector.TabIndex = 2
        Me.lblsector.Text = "Zona:"
        Me.lblsector.Visible = False
        '
        'lblcp
        '
        Me.lblcp.AutoSize = True
        Me.lblcp.BackColor = System.Drawing.Color.Transparent
        Me.lblcp.ForeColor = System.Drawing.Color.Black
        Me.lblcp.Location = New System.Drawing.Point(775, 65)
        Me.lblcp.Name = "lblcp"
        Me.lblcp.Size = New System.Drawing.Size(24, 13)
        Me.lblcp.TabIndex = 16
        Me.lblcp.Text = "CP:"
        '
        'lblcolonia
        '
        Me.lblcolonia.AutoSize = True
        Me.lblcolonia.BackColor = System.Drawing.Color.Transparent
        Me.lblcolonia.ForeColor = System.Drawing.Color.Red
        Me.lblcolonia.Location = New System.Drawing.Point(4, 61)
        Me.lblcolonia.Name = "lblcolonia"
        Me.lblcolonia.Size = New System.Drawing.Size(45, 13)
        Me.lblcolonia.TabIndex = 14
        Me.lblcolonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.Transparent
        Me.lblCalle.ForeColor = System.Drawing.Color.Red
        Me.lblCalle.Location = New System.Drawing.Point(6, 35)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(55, 13)
        Me.lblCalle.TabIndex = 18
        Me.lblCalle.Text = "Direccion:"
        '
        'gpDatServ
        '
        Me.gpDatServ.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatServ.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatServ.Controls.Add(Me.cmbCuoValvu)
        Me.gpDatServ.Controls.Add(Me.lblCuoValvu)
        Me.gpDatServ.Controls.Add(Me.cmbDescuento)
        Me.gpDatServ.Controls.Add(Me.lblDescuento)
        Me.gpDatServ.Controls.Add(Me.txtctoagua)
        Me.gpDatServ.Controls.Add(Me.txtctodrenaje)
        Me.gpDatServ.Controls.Add(Me.ButtonX2)
        Me.gpDatServ.Controls.Add(Me.ButtonX1)
        Me.gpDatServ.Controls.Add(Me.Label44)
        Me.gpDatServ.Controls.Add(Me.ChkAltoCon)
        Me.gpDatServ.Controls.Add(Me.Label22)
        Me.gpDatServ.Controls.Add(Me.ChkGestCob)
        Me.gpDatServ.Controls.Add(Me.cmbnivsoc)
        Me.gpDatServ.Controls.Add(Me.Label38)
        Me.gpDatServ.Controls.Add(Me.cmbgiro)
        Me.gpDatServ.Controls.Add(Me.lblGiro)
        Me.gpDatServ.Controls.Add(Me.CmbEstPredio)
        Me.gpDatServ.Controls.Add(Me.Label11)
        Me.gpDatServ.Controls.Add(Me.chkSanea)
        Me.gpDatServ.Controls.Add(Me.chkAlcantarillado)
        Me.gpDatServ.Controls.Add(Me.cmbFservicio)
        Me.gpDatServ.Controls.Add(Me.Label43)
        Me.gpDatServ.Controls.Add(Me.cmbtipouso)
        Me.gpDatServ.Controls.Add(Me.Label14)
        Me.gpDatServ.Controls.Add(Me.cmbtarifa)
        Me.gpDatServ.Controls.Add(Me.Label39)
        Me.gpDatServ.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatServ.Location = New System.Drawing.Point(25, 137)
        Me.gpDatServ.Name = "gpDatServ"
        Me.gpDatServ.Size = New System.Drawing.Size(966, 132)
        '
        '
        '
        Me.gpDatServ.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatServ.Style.BackColorGradientAngle = 90
        Me.gpDatServ.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatServ.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatServ.Style.BorderBottomWidth = 1
        Me.gpDatServ.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatServ.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatServ.Style.BorderLeftWidth = 1
        Me.gpDatServ.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatServ.Style.BorderRightWidth = 1
        Me.gpDatServ.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatServ.Style.BorderTopWidth = 1
        Me.gpDatServ.Style.CornerDiameter = 4
        Me.gpDatServ.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatServ.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatServ.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatServ.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatServ.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatServ.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatServ.TabIndex = 1
        Me.gpDatServ.Text = "Datos del servicio"
        '
        'cmbCuoValvu
        '
        Me.cmbCuoValvu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCuoValvu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuoValvu.DisplayMember = "Text"
        Me.cmbCuoValvu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCuoValvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuoValvu.FocusHighlightEnabled = True
        Me.cmbCuoValvu.FormattingEnabled = True
        Me.cmbCuoValvu.ItemHeight = 14
        Me.cmbCuoValvu.Location = New System.Drawing.Point(656, 30)
        Me.cmbCuoValvu.Name = "cmbCuoValvu"
        Me.cmbCuoValvu.Size = New System.Drawing.Size(230, 20)
        Me.cmbCuoValvu.TabIndex = 28
        '
        'lblCuoValvu
        '
        Me.lblCuoValvu.AutoSize = True
        Me.lblCuoValvu.BackColor = System.Drawing.Color.Transparent
        Me.lblCuoValvu.ForeColor = System.Drawing.Color.Red
        Me.lblCuoValvu.Location = New System.Drawing.Point(564, 33)
        Me.lblCuoValvu.Name = "lblCuoValvu"
        Me.lblCuoValvu.Size = New System.Drawing.Size(86, 13)
        Me.lblCuoValvu.TabIndex = 29
        Me.lblCuoValvu.Text = "Cuota Valvulista:"
        '
        'cmbDescuento
        '
        Me.cmbDescuento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDescuento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDescuento.DisplayMember = "Text"
        Me.cmbDescuento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDescuento.FocusHighlightEnabled = True
        Me.cmbDescuento.FormattingEnabled = True
        Me.cmbDescuento.ItemHeight = 14
        Me.cmbDescuento.Location = New System.Drawing.Point(345, 29)
        Me.cmbDescuento.Name = "cmbDescuento"
        Me.cmbDescuento.Size = New System.Drawing.Size(192, 20)
        Me.cmbDescuento.TabIndex = 26
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.BackColor = System.Drawing.Color.Transparent
        Me.lblDescuento.ForeColor = System.Drawing.Color.Red
        Me.lblDescuento.Location = New System.Drawing.Point(281, 33)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(62, 13)
        Me.lblDescuento.TabIndex = 27
        Me.lblDescuento.Text = "Descuento:"
        '
        'txtctoagua
        '
        '
        '
        '
        Me.txtctoagua.Border.Class = "TextBoxBorder"
        Me.txtctoagua.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtctoagua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtctoagua.Enabled = False
        Me.txtctoagua.FocusHighlightEnabled = True
        Me.txtctoagua.Location = New System.Drawing.Point(797, 56)
        Me.txtctoagua.MaxLength = 120
        Me.txtctoagua.Name = "txtctoagua"
        Me.txtctoagua.Size = New System.Drawing.Size(60, 20)
        Me.txtctoagua.TabIndex = 24
        Me.txtctoagua.Text = "0"
        '
        'txtctodrenaje
        '
        '
        '
        '
        Me.txtctodrenaje.Border.Class = "TextBoxBorder"
        Me.txtctodrenaje.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtctodrenaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtctodrenaje.Enabled = False
        Me.txtctodrenaje.FocusHighlightEnabled = True
        Me.txtctodrenaje.Location = New System.Drawing.Point(797, 86)
        Me.txtctodrenaje.MaxLength = 120
        Me.txtctodrenaje.Name = "txtctodrenaje"
        Me.txtctodrenaje.Size = New System.Drawing.Size(60, 20)
        Me.txtctodrenaje.TabIndex = 25
        Me.txtctodrenaje.Text = "0"
        Me.txtctodrenaje.Visible = False
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(865, 86)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(87, 21)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 23
        Me.ButtonX2.Text = "Contratar"
        Me.ButtonX2.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(865, 56)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(87, 21)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 22
        Me.ButtonX1.Text = "Contratar"
        Me.ButtonX1.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Location = New System.Drawing.Point(692, 88)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(87, 13)
        Me.Label44.TabIndex = 20
        Me.Label44.Text = "Contrato Drenaje"
        Me.Label44.Visible = False
        '
        'ChkAltoCon
        '
        Me.ChkAltoCon.AutoSize = True
        Me.ChkAltoCon.BackColor = System.Drawing.Color.Transparent
        Me.ChkAltoCon.Location = New System.Drawing.Point(451, 90)
        Me.ChkAltoCon.Name = "ChkAltoCon"
        Me.ChkAltoCon.Size = New System.Drawing.Size(102, 17)
        Me.ChkAltoCon.TabIndex = 9
        Me.ChkAltoCon.Text = "Alto Consumidor"
        Me.ChkAltoCon.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(704, 61)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Contrato Agua"
        '
        'ChkGestCob
        '
        Me.ChkGestCob.AutoSize = True
        Me.ChkGestCob.BackColor = System.Drawing.Color.Transparent
        Me.ChkGestCob.Location = New System.Drawing.Point(324, 90)
        Me.ChkGestCob.Name = "ChkGestCob"
        Me.ChkGestCob.Size = New System.Drawing.Size(124, 17)
        Me.ChkGestCob.TabIndex = 8
        Me.ChkGestCob.Text = "Gestión de cobranza"
        Me.ChkGestCob.UseVisualStyleBackColor = False
        '
        'cmbnivsoc
        '
        Me.cmbnivsoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbnivsoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbnivsoc.DisplayMember = "Text"
        Me.cmbnivsoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbnivsoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnivsoc.FocusHighlightEnabled = True
        Me.cmbnivsoc.FormattingEnabled = True
        Me.cmbnivsoc.ItemHeight = 14
        Me.cmbnivsoc.Location = New System.Drawing.Point(119, 88)
        Me.cmbnivsoc.Name = "cmbnivsoc"
        Me.cmbnivsoc.Size = New System.Drawing.Size(183, 20)
        Me.cmbnivsoc.TabIndex = 7
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Location = New System.Drawing.Point(8, 92)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(114, 13)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "Nivel socio-economico"
        '
        'cmbgiro
        '
        Me.cmbgiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbgiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgiro.DisplayMember = "Text"
        Me.cmbgiro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbgiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgiro.FocusHighlightEnabled = True
        Me.cmbgiro.FormattingEnabled = True
        Me.cmbgiro.ItemHeight = 14
        Me.cmbgiro.Location = New System.Drawing.Point(95, 58)
        Me.cmbgiro.Name = "cmbgiro"
        Me.cmbgiro.Size = New System.Drawing.Size(441, 20)
        Me.cmbgiro.TabIndex = 6
        '
        'lblGiro
        '
        Me.lblGiro.AutoSize = True
        Me.lblGiro.BackColor = System.Drawing.Color.Transparent
        Me.lblGiro.ForeColor = System.Drawing.Color.Red
        Me.lblGiro.Location = New System.Drawing.Point(8, 62)
        Me.lblGiro.Name = "lblGiro"
        Me.lblGiro.Size = New System.Drawing.Size(29, 13)
        Me.lblGiro.TabIndex = 10
        Me.lblGiro.Text = "Giro:"
        '
        'CmbEstPredio
        '
        Me.CmbEstPredio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbEstPredio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEstPredio.DisplayMember = "Text"
        Me.CmbEstPredio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbEstPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstPredio.FocusHighlightEnabled = True
        Me.CmbEstPredio.FormattingEnabled = True
        Me.CmbEstPredio.ItemHeight = 14
        Me.CmbEstPredio.Location = New System.Drawing.Point(95, 29)
        Me.CmbEstPredio.Name = "CmbEstPredio"
        Me.CmbEstPredio.Size = New System.Drawing.Size(180, 20)
        Me.CmbEstPredio.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(8, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Estado Predio:"
        '
        'chkSanea
        '
        Me.chkSanea.AutoSize = True
        Me.chkSanea.BackColor = System.Drawing.Color.Transparent
        Me.chkSanea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanea.Location = New System.Drawing.Point(557, 59)
        Me.chkSanea.Name = "chkSanea"
        Me.chkSanea.Size = New System.Drawing.Size(88, 17)
        Me.chkSanea.TabIndex = 5
        Me.chkSanea.Tag = "saneamiento"
        Me.chkSanea.Text = "Saneamiento"
        Me.chkSanea.UseVisualStyleBackColor = False
        '
        'chkAlcantarillado
        '
        Me.chkAlcantarillado.AutoSize = True
        Me.chkAlcantarillado.BackColor = System.Drawing.Color.Transparent
        Me.chkAlcantarillado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAlcantarillado.Location = New System.Drawing.Point(556, 88)
        Me.chkAlcantarillado.Name = "chkAlcantarillado"
        Me.chkAlcantarillado.Size = New System.Drawing.Size(89, 17)
        Me.chkAlcantarillado.TabIndex = 4
        Me.chkAlcantarillado.Tag = "alcantarillado"
        Me.chkAlcantarillado.Text = "Alcantarillado"
        Me.chkAlcantarillado.UseVisualStyleBackColor = False
        '
        'cmbFservicio
        '
        Me.cmbFservicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFservicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFservicio.DisplayMember = "Text"
        Me.cmbFservicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFservicio.FocusHighlightEnabled = True
        Me.cmbFservicio.FormattingEnabled = True
        Me.cmbFservicio.ItemHeight = 14
        Me.cmbFservicio.Location = New System.Drawing.Point(656, 4)
        Me.cmbFservicio.Name = "cmbFservicio"
        Me.cmbFservicio.Size = New System.Drawing.Size(230, 20)
        Me.cmbFservicio.TabIndex = 2
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.ForeColor = System.Drawing.Color.Red
        Me.Label43.Location = New System.Drawing.Point(562, 7)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(78, 13)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Forma servicio:"
        '
        'cmbtipouso
        '
        Me.cmbtipouso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipouso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipouso.DisplayMember = "Text"
        Me.cmbtipouso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipouso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipouso.DropDownWidth = 120
        Me.cmbtipouso.FocusHighlightEnabled = True
        Me.cmbtipouso.FormattingEnabled = True
        Me.cmbtipouso.ItemHeight = 14
        Me.cmbtipouso.Location = New System.Drawing.Point(95, 4)
        Me.cmbtipouso.Name = "cmbtipouso"
        Me.cmbtipouso.Size = New System.Drawing.Size(180, 20)
        Me.cmbtipouso.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(8, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tipo usuario:"
        '
        'cmbtarifa
        '
        Me.cmbtarifa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtarifa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtarifa.DisplayMember = "Text"
        Me.cmbtarifa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtarifa.DropDownWidth = 180
        Me.cmbtarifa.FocusHighlightEnabled = True
        Me.cmbtarifa.FormattingEnabled = True
        Me.cmbtarifa.ItemHeight = 14
        Me.cmbtarifa.Location = New System.Drawing.Point(324, 4)
        Me.cmbtarifa.Name = "cmbtarifa"
        Me.cmbtarifa.Size = New System.Drawing.Size(215, 20)
        Me.cmbtarifa.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(281, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(37, 13)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "Tarifa:"
        '
        'gpDatCont
        '
        Me.gpDatCont.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatCont.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatCont.Controls.Add(Me.DTfechadeuda)
        Me.gpDatCont.Controls.Add(Me.Label50)
        Me.gpDatCont.Controls.Add(Me.txtCedulaC)
        Me.gpDatCont.Controls.Add(Me.CedulaC)
        Me.gpDatCont.Controls.Add(Me.txtidentificacion)
        Me.gpDatCont.Controls.Add(Me.txtparentesco)
        Me.gpDatCont.Controls.Add(Me.txtsolicitado)
        Me.gpDatCont.Controls.Add(Me.lblidentificacion)
        Me.gpDatCont.Controls.Add(Me.lblparentesco)
        Me.gpDatCont.Controls.Add(Me.lblsolicitado)
        Me.gpDatCont.Controls.Add(Me.TxtTel)
        Me.gpDatCont.Controls.Add(Me.LblTelefono)
        Me.gpDatCont.Controls.Add(Me.txtpropietario)
        Me.gpDatCont.Controls.Add(Me.lblnombre)
        Me.gpDatCont.Controls.Add(Me.dtfsolicitud)
        Me.gpDatCont.Controls.Add(Me.Cmbestado)
        Me.gpDatCont.Controls.Add(Me.lblestado)
        Me.gpDatCont.Controls.Add(Me.lblfecha)
        Me.gpDatCont.Controls.Add(Me.txtclave)
        Me.gpDatCont.Controls.Add(Me.Label4)
        Me.gpDatCont.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatCont.Location = New System.Drawing.Point(25, 3)
        Me.gpDatCont.Name = "gpDatCont"
        Me.gpDatCont.Size = New System.Drawing.Size(966, 128)
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
        Me.gpDatCont.Text = "Datos del contrato"
        '
        'DTfechadeuda
        '
        '
        '
        '
        Me.DTfechadeuda.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTfechadeuda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfechadeuda.ButtonDropDown.Visible = True
        Me.DTfechadeuda.FocusHighlightEnabled = True
        Me.DTfechadeuda.IsPopupCalendarOpen = False
        Me.DTfechadeuda.Location = New System.Drawing.Point(831, 11)
        '
        '
        '
        '
        '
        '
        Me.DTfechadeuda.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTfechadeuda.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfechadeuda.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTfechadeuda.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTfechadeuda.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTfechadeuda.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTfechadeuda.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTfechadeuda.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTfechadeuda.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTfechadeuda.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfechadeuda.MonthCalendar.DisplayMonth = New Date(2008, 9, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DTfechadeuda.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTfechadeuda.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTfechadeuda.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTfechadeuda.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DTfechadeuda.MonthCalendar.TodayButtonVisible = True
        Me.DTfechadeuda.Name = "DTfechadeuda"
        Me.DTfechadeuda.Size = New System.Drawing.Size(83, 20)
        Me.DTfechadeuda.TabIndex = 21
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(729, 15)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(85, 13)
        Me.Label50.TabIndex = 20
        Me.Label50.Text = "Fecha de deuda"
        '
        'txtCedulaC
        '
        Me.txtCedulaC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCedulaC.Border.Class = "TextBoxBorder"
        Me.txtCedulaC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCedulaC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaC.FocusHighlightEnabled = True
        Me.txtCedulaC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaC.Location = New System.Drawing.Point(284, 6)
        Me.txtCedulaC.MaxLength = 15
        Me.txtCedulaC.Name = "txtCedulaC"
        Me.txtCedulaC.Size = New System.Drawing.Size(71, 22)
        Me.txtCedulaC.TabIndex = 1
        Me.txtCedulaC.TabStop = False
        Me.txtCedulaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CedulaC
        '
        Me.CedulaC.AutoSize = True
        Me.CedulaC.BackColor = System.Drawing.Color.Transparent
        Me.CedulaC.Location = New System.Drawing.Point(175, 12)
        Me.CedulaC.Name = "CedulaC"
        Me.CedulaC.Size = New System.Drawing.Size(87, 13)
        Me.CedulaC.TabIndex = 18
        Me.CedulaC.Text = "Cedula Catastral:"
        '
        'txtidentificacion
        '
        '
        '
        '
        Me.txtidentificacion.Border.Class = "TextBoxBorder"
        Me.txtidentificacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtidentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidentificacion.FocusHighlightEnabled = True
        Me.txtidentificacion.Location = New System.Drawing.Point(551, 87)
        Me.txtidentificacion.MaxLength = 50
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Size = New System.Drawing.Size(187, 20)
        Me.txtidentificacion.TabIndex = 6
        Me.txtidentificacion.WatermarkText = "Escribe con que identificó y el folio"
        '
        'txtparentesco
        '
        '
        '
        '
        Me.txtparentesco.Border.Class = "TextBoxBorder"
        Me.txtparentesco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtparentesco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtparentesco.FocusHighlightEnabled = True
        Me.txtparentesco.Location = New System.Drawing.Point(70, 87)
        Me.txtparentesco.MaxLength = 50
        Me.txtparentesco.Name = "txtparentesco"
        Me.txtparentesco.Size = New System.Drawing.Size(297, 20)
        Me.txtparentesco.TabIndex = 5
        Me.txtparentesco.WatermarkText = "Escribe el parentesco que tiene con el propietario"
        '
        'txtsolicitado
        '
        '
        '
        '
        Me.txtsolicitado.Border.Class = "TextBoxBorder"
        Me.txtsolicitado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsolicitado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsolicitado.FocusHighlightEnabled = True
        Me.txtsolicitado.Location = New System.Drawing.Point(70, 61)
        Me.txtsolicitado.MaxLength = 120
        Me.txtsolicitado.Name = "txtsolicitado"
        Me.txtsolicitado.Size = New System.Drawing.Size(668, 20)
        Me.txtsolicitado.TabIndex = 4
        Me.txtsolicitado.WatermarkText = "Escribe quien vino a solicitar la toma"
        '
        'lblidentificacion
        '
        Me.lblidentificacion.AutoSize = True
        Me.lblidentificacion.BackColor = System.Drawing.Color.Transparent
        Me.lblidentificacion.ForeColor = System.Drawing.Color.Black
        Me.lblidentificacion.Location = New System.Drawing.Point(462, 91)
        Me.lblidentificacion.Name = "lblidentificacion"
        Me.lblidentificacion.Size = New System.Drawing.Size(73, 13)
        Me.lblidentificacion.TabIndex = 14
        Me.lblidentificacion.Text = "Identificación:"
        '
        'lblparentesco
        '
        Me.lblparentesco.AutoSize = True
        Me.lblparentesco.BackColor = System.Drawing.Color.Transparent
        Me.lblparentesco.ForeColor = System.Drawing.Color.Black
        Me.lblparentesco.Location = New System.Drawing.Point(3, 91)
        Me.lblparentesco.Name = "lblparentesco"
        Me.lblparentesco.Size = New System.Drawing.Size(64, 13)
        Me.lblparentesco.TabIndex = 12
        Me.lblparentesco.Text = "Parentesco:"
        '
        'lblsolicitado
        '
        Me.lblsolicitado.AutoSize = True
        Me.lblsolicitado.BackColor = System.Drawing.Color.Transparent
        Me.lblsolicitado.ForeColor = System.Drawing.Color.Black
        Me.lblsolicitado.Location = New System.Drawing.Point(3, 58)
        Me.lblsolicitado.Name = "lblsolicitado"
        Me.lblsolicitado.Size = New System.Drawing.Size(56, 26)
        Me.lblsolicitado.TabIndex = 10
        Me.lblsolicitado.Text = "Solicitado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por:"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(813, 82)
        Me.TxtTel.Mask = "(###)-###-####"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(84, 20)
        Me.TxtTel.TabIndex = 8
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Location = New System.Drawing.Point(751, 89)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 8
        Me.LblTelefono.Text = "Telefono:"
        '
        'txtpropietario
        '
        '
        '
        '
        Me.txtpropietario.Border.Class = "TextBoxBorder"
        Me.txtpropietario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtpropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpropietario.FocusHighlightEnabled = True
        Me.txtpropietario.Location = New System.Drawing.Point(70, 35)
        Me.txtpropietario.MaxLength = 120
        Me.txtpropietario.Name = "txtpropietario"
        Me.txtpropietario.Size = New System.Drawing.Size(668, 20)
        Me.txtpropietario.TabIndex = 3
        Me.txtpropietario.WatermarkText = "Escribe el nombre del propietario de la toma"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.ForeColor = System.Drawing.Color.Red
        Me.lblnombre.Location = New System.Drawing.Point(3, 39)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(39, 13)
        Me.lblnombre.TabIndex = 6
        Me.lblnombre.Text = "Titular:"
        '
        'dtfsolicitud
        '
        '
        '
        '
        Me.dtfsolicitud.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtfsolicitud.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfsolicitud.ButtonDropDown.Visible = True
        Me.dtfsolicitud.FocusHighlightEnabled = True
        Me.dtfsolicitud.IsPopupCalendarOpen = False
        Me.dtfsolicitud.Location = New System.Drawing.Point(608, 11)
        '
        '
        '
        '
        '
        '
        Me.dtfsolicitud.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtfsolicitud.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfsolicitud.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtfsolicitud.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtfsolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtfsolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtfsolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtfsolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtfsolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtfsolicitud.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfsolicitud.MonthCalendar.DisplayMonth = New Date(2008, 9, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtfsolicitud.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtfsolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtfsolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtfsolicitud.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtfsolicitud.MonthCalendar.TodayButtonVisible = True
        Me.dtfsolicitud.Name = "dtfsolicitud"
        Me.dtfsolicitud.Size = New System.Drawing.Size(83, 20)
        Me.dtfsolicitud.TabIndex = 2
        '
        'Cmbestado
        '
        Me.Cmbestado.DisplayMember = "Text"
        Me.Cmbestado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbestado.FocusHighlightEnabled = True
        Me.Cmbestado.FormattingEnabled = True
        Me.Cmbestado.ItemHeight = 14
        Me.Cmbestado.Location = New System.Drawing.Point(813, 58)
        Me.Cmbestado.Name = "Cmbestado"
        Me.Cmbestado.Size = New System.Drawing.Size(116, 20)
        Me.Cmbestado.TabIndex = 7
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.Transparent
        Me.lblestado.ForeColor = System.Drawing.Color.Black
        Me.lblestado.Location = New System.Drawing.Point(751, 67)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(43, 13)
        Me.lblestado.TabIndex = 4
        Me.lblestado.Text = "Estado:"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.ForeColor = System.Drawing.Color.Black
        Me.lblfecha.Location = New System.Drawing.Point(494, 17)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(80, 13)
        Me.lblfecha.TabIndex = 2
        Me.lblfecha.Text = "Fecha Solicitud"
        '
        'txtclave
        '
        Me.txtclave.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtclave.Border.Class = "TextBoxBorder"
        Me.txtclave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtclave.Enabled = False
        Me.txtclave.FocusHighlightEnabled = True
        Me.txtclave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(66, 9)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(71, 22)
        Me.txtclave.TabIndex = 0
        Me.txtclave.TabStop = False
        Me.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'lblsolicitud
        '
        Me.lblsolicitud.AutoSize = True
        Me.lblsolicitud.Location = New System.Drawing.Point(543, 613)
        Me.lblsolicitud.Name = "lblsolicitud"
        Me.lblsolicitud.Size = New System.Drawing.Size(0, 13)
        Me.lblsolicitud.TabIndex = 126
        Me.lblsolicitud.Visible = False
        '
        'LstCalles
        '
        Me.LstCalles.FormattingEnabled = True
        Me.LstCalles.Location = New System.Drawing.Point(798, 428)
        Me.LstCalles.Name = "LstCalles"
        Me.LstCalles.Size = New System.Drawing.Size(99, 30)
        Me.LstCalles.TabIndex = 4
        Me.LstCalles.Visible = False
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel1
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Generales"
        '
        'TabControlPanel7
        '
        Me.TabControlPanel7.Controls.Add(Me.Bar1)
        Me.TabControlPanel7.Controls.Add(Me.mostrar)
        Me.TabControlPanel7.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel7.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel7.Name = "TabControlPanel7"
        Me.TabControlPanel7.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel7.Size = New System.Drawing.Size(1041, 516)
        Me.TabControlPanel7.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel7.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel7.Style.GradientAngle = 90
        Me.TabControlPanel7.TabIndex = 22
        Me.TabControlPanel7.TabItem = Me.tabDocumentos
        Me.TabControlPanel7.Visible = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.Controls.Add(Me.btnExaminar)
        Me.Bar1.Controls.Add(Me.ButtonX3)
        Me.Bar1.Controls.Add(Me.BtnActualizar)
        Me.Bar1.Controls.Add(Me.BtnBorrar)
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.lblnombreexp, Me.LabelItem2, Me.textDescripcion, Me.lblexaminar, Me.ControlContainerItem2, Me.ControlContainerItem1, Me.btnver, Me.ControlContainerItem4, Me.ControlContainerItem5})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.MenuBar = True
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1038, 43)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 24
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'btnExaminar
        '
        Me.btnExaminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExaminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExaminar.Image = Global.Administativo.My.Resources.Resources.Buscar
        Me.btnExaminar.Location = New System.Drawing.Point(331, 2)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(109, 39)
        Me.btnExaminar.TabIndex = 64
        Me.btnExaminar.Text = "Examinar"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.ButtonX3.Location = New System.Drawing.Point(444, 2)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(109, 39)
        Me.ButtonX3.TabIndex = 2
        Me.ButtonX3.Text = "Agregar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnActualizar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnActualizar.Location = New System.Drawing.Point(648, 2)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.PulseSpeed = 30
        Me.BtnActualizar.Size = New System.Drawing.Size(109, 39)
        Me.BtnActualizar.TabIndex = 25
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBorrar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.BtnBorrar.Location = New System.Drawing.Point(761, 2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.PulseSpeed = 30
        Me.BtnBorrar.Size = New System.Drawing.Size(109, 39)
        Me.BtnBorrar.TabIndex = 65
        Me.BtnBorrar.Text = "Eliminar"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Nombre:"
        '
        'lblnombreexp
        '
        Me.lblnombreexp.Name = "lblnombreexp"
        Me.lblnombreexp.Text = "<b><font color=""#000000""></font></b>"
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "Descripción: "
        '
        'textDescripcion
        '
        Me.textDescripcion.MaxLength = 250
        Me.textDescripcion.Name = "textDescripcion"
        Me.textDescripcion.TextBoxWidth = 200
        Me.textDescripcion.Tooltip = "Escribe la descripción del documento"
        Me.textDescripcion.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'lblexaminar
        '
        Me.lblexaminar.Name = "lblexaminar"
        '
        'ControlContainerItem2
        '
        Me.ControlContainerItem2.AllowItemResize = False
        Me.ControlContainerItem2.Control = Me.btnExaminar
        Me.ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem2.Name = "ControlContainerItem2"
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.Control = Me.ButtonX3
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'ControlContainerItem4
        '
        Me.ControlContainerItem4.AllowItemResize = False
        Me.ControlContainerItem4.Control = Me.BtnActualizar
        Me.ControlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem4.Name = "ControlContainerItem4"
        '
        'ControlContainerItem5
        '
        Me.ControlContainerItem5.AllowItemResize = False
        Me.ControlContainerItem5.Control = Me.BtnBorrar
        Me.ControlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem5.Name = "ControlContainerItem5"
        '
        'mostrar
        '
        Me.mostrar.AllowUserToDeleteRows = False
        Me.mostrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mostrar.Location = New System.Drawing.Point(16, 68)
        Me.mostrar.Name = "mostrar"
        Me.mostrar.ReadOnly = True
        Me.mostrar.Size = New System.Drawing.Size(744, 423)
        Me.mostrar.TabIndex = 1
        '
        'tabDocumentos
        '
        Me.tabDocumentos.AttachedControl = Me.TabControlPanel7
        Me.tabDocumentos.Name = "tabDocumentos"
        Me.tabDocumentos.Text = "Documentos"
        '
        'tabcFotos
        '
        Me.tabcFotos.Controls.Add(Me.gpFotos)
        Me.tabcFotos.DisabledBackColor = System.Drawing.Color.Empty
        Me.tabcFotos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcFotos.Location = New System.Drawing.Point(0, 22)
        Me.tabcFotos.Name = "tabcFotos"
        Me.tabcFotos.Padding = New System.Windows.Forms.Padding(1)
        Me.tabcFotos.Size = New System.Drawing.Size(1041, 516)
        Me.tabcFotos.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tabcFotos.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.tabcFotos.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.tabcFotos.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tabcFotos.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.tabcFotos.Style.GradientAngle = 90
        Me.tabcFotos.TabIndex = 5
        Me.tabcFotos.TabItem = Me.tabfotos
        '
        'gpFotos
        '
        Me.gpFotos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFotos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFotos.Controls.Add(Me.LabelX5)
        Me.gpFotos.Controls.Add(Me.LabelX4)
        Me.gpFotos.Controls.Add(Me.LabelX3)
        Me.gpFotos.Controls.Add(Me.LabelX2)
        Me.gpFotos.Controls.Add(Me.LabelX1)
        Me.gpFotos.Controls.Add(Me.pic4)
        Me.gpFotos.Controls.Add(Me.pic3)
        Me.gpFotos.Controls.Add(Me.pic2)
        Me.gpFotos.Controls.Add(Me.pic1)
        Me.gpFotos.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpFotos.Location = New System.Drawing.Point(16, 4)
        Me.gpFotos.Name = "gpFotos"
        Me.gpFotos.Size = New System.Drawing.Size(656, 542)
        '
        '
        '
        Me.gpFotos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpFotos.Style.BackColorGradientAngle = 90
        Me.gpFotos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpFotos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFotos.Style.BorderBottomWidth = 1
        Me.gpFotos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpFotos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFotos.Style.BorderLeftWidth = 1
        Me.gpFotos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFotos.Style.BorderRightWidth = 1
        Me.gpFotos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFotos.Style.BorderTopWidth = 1
        Me.gpFotos.Style.CornerDiameter = 4
        Me.gpFotos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpFotos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpFotos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpFotos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpFotos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpFotos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpFotos.TabIndex = 16
        Me.gpFotos.Text = "Fotos"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(157, 468)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(358, 37)
        Me.LabelX5.TabIndex = 20
        Me.LabelX5.Text = "AL CAMBIAR LA IMAGEN SUSTITUYE A LA ANTERIOR, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LA CUAL NO SE PUEDE RECUPERAR"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(379, 226)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(165, 23)
        Me.LabelX4.TabIndex = 19
        Me.LabelX4.Text = "Medidor 2"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(106, 226)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(165, 23)
        Me.LabelX3.TabIndex = 18
        Me.LabelX3.Text = "Medidor 1"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(379, -6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(165, 23)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "Frente 2"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(106, -6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(165, 23)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "Frente 1"
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(355, 255)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(210, 191)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 15
        Me.pic4.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(85, 255)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(210, 191)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 14
        Me.pic3.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(355, 27)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(210, 191)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 13
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(85, 29)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(210, 191)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 12
        Me.pic1.TabStop = False
        '
        'tabfotos
        '
        Me.tabfotos.AttachedControl = Me.tabcFotos
        Me.tabfotos.Name = "tabfotos"
        Me.tabfotos.Text = "Fotos del predio"
        Me.tabfotos.Visible = False
        '
        'TabControlPanel6
        '
        Me.TabControlPanel6.Controls.Add(Me.DTgfecha)
        Me.TabControlPanel6.Controls.Add(Me.Label53)
        Me.TabControlPanel6.Controls.Add(Me.Label52)
        Me.TabControlPanel6.Controls.Add(Me.DtgTarifa)
        Me.TabControlPanel6.Controls.Add(Me.Label51)
        Me.TabControlPanel6.Controls.Add(Me.DtgNombre)
        Me.TabControlPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel6.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel6.Name = "TabControlPanel6"
        Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel6.Size = New System.Drawing.Size(1041, 516)
        Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel6.Style.GradientAngle = 90
        Me.TabControlPanel6.TabIndex = 21
        Me.TabControlPanel6.TabItem = Me.TabItem2
        Me.TabControlPanel6.Text = "Movimientos"
        '
        'DTgfecha
        '
        Me.DTgfecha.AllowUserToAddRows = False
        Me.DTgfecha.AllowUserToDeleteRows = False
        Me.DTgfecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTgfecha.Location = New System.Drawing.Point(553, 34)
        Me.DTgfecha.Name = "DTgfecha"
        Me.DTgfecha.ReadOnly = True
        Me.DTgfecha.Size = New System.Drawing.Size(426, 108)
        Me.DTgfecha.TabIndex = 11
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(590, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(114, 13)
        Me.Label53.TabIndex = 10
        Me.Label53.Text = "Movimientos de Fecha"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(10, 142)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(111, 13)
        Me.Label52.TabIndex = 9
        Me.Label52.Text = "Movimientos de Tarifa"
        '
        'DtgTarifa
        '
        Me.DtgTarifa.AllowUserToAddRows = False
        Me.DtgTarifa.AllowUserToDeleteRows = False
        Me.DtgTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgTarifa.Location = New System.Drawing.Point(13, 178)
        Me.DtgTarifa.Name = "DtgTarifa"
        Me.DtgTarifa.ReadOnly = True
        Me.DtgTarifa.Size = New System.Drawing.Size(506, 105)
        Me.DtgTarifa.TabIndex = 8
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(10, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(119, 13)
        Me.Label51.TabIndex = 7
        Me.Label51.Text = "Movimientos de nombre"
        '
        'DtgNombre
        '
        Me.DtgNombre.AllowUserToAddRows = False
        Me.DtgNombre.AllowUserToDeleteRows = False
        Me.DtgNombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgNombre.Location = New System.Drawing.Point(14, 34)
        Me.DtgNombre.Name = "DtgNombre"
        Me.DtgNombre.ReadOnly = True
        Me.DtgNombre.Size = New System.Drawing.Size(506, 93)
        Me.DtgNombre.TabIndex = 6
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel6
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Movimientos"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.Label49)
        Me.TabControlPanel5.Controls.Add(Me.BtnEliminar)
        Me.TabControlPanel5.Controls.Add(Me.BtnAgregar)
        Me.TabControlPanel5.Controls.Add(Me.Label48)
        Me.TabControlPanel5.Controls.Add(Me.dporce)
        Me.TabControlPanel5.Controls.Add(Me.Label47)
        Me.TabControlPanel5.Controls.Add(Me.cmbtarifa2)
        Me.TabControlPanel5.Controls.Add(Me.TarifasAdicionales)
        Me.TabControlPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(1041, 516)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 6
        Me.TabControlPanel5.TabItem = Me.TabItem1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(762, 36)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(21, 16)
        Me.Label49.TabIndex = 28
        Me.Label49.Text = "%"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnEliminar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.BtnEliminar.Location = New System.Drawing.Point(897, 17)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 38)
        Me.BtnEliminar.TabIndex = 27
        Me.BtnEliminar.Text = "Eliminar"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAgregar.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.BtnAgregar.Location = New System.Drawing.Point(795, 17)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(102, 38)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Location = New System.Drawing.Point(293, 17)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(100, 13)
        Me.Label48.TabIndex = 25
        Me.Label48.Text = "Nombre de la Tarifa"
        '
        'dporce
        '
        Me.dporce.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dporce.Location = New System.Drawing.Point(702, 33)
        Me.dporce.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.dporce.Name = "dporce"
        Me.dporce.Size = New System.Drawing.Size(58, 20)
        Me.dporce.TabIndex = 24
        Me.dporce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dporce.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Location = New System.Drawing.Point(699, 17)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(58, 13)
        Me.Label47.TabIndex = 23
        Me.Label47.Text = "Porcentaje"
        '
        'cmbtarifa2
        '
        Me.cmbtarifa2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtarifa2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtarifa2.DisplayMember = "Text"
        Me.cmbtarifa2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtarifa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtarifa2.DropDownWidth = 180
        Me.cmbtarifa2.FocusHighlightEnabled = True
        Me.cmbtarifa2.FormattingEnabled = True
        Me.cmbtarifa2.ItemHeight = 14
        Me.cmbtarifa2.Location = New System.Drawing.Point(12, 33)
        Me.cmbtarifa2.Name = "cmbtarifa2"
        Me.cmbtarifa2.Size = New System.Drawing.Size(690, 20)
        Me.cmbtarifa2.TabIndex = 22
        '
        'TarifasAdicionales
        '
        Me.TarifasAdicionales.AllowUserToOrderColumns = True
        Me.TarifasAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TarifasAdicionales.Location = New System.Drawing.Point(13, 68)
        Me.TarifasAdicionales.Name = "TarifasAdicionales"
        Me.TarifasAdicionales.Size = New System.Drawing.Size(987, 372)
        Me.TarifasAdicionales.TabIndex = 5
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel5
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Tarifas Adicionales"
        Me.TabItem1.Visible = False
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.gpClaWeb)
        Me.TabControlPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(1041, 516)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 0
        Me.TabControlPanel4.TabItem = Me.claveweb
        '
        'gpClaWeb
        '
        Me.gpClaWeb.BackColor = System.Drawing.Color.Transparent
        Me.gpClaWeb.Controls.Add(Me.txtemail)
        Me.gpClaWeb.Controls.Add(Me.txtrespsec)
        Me.gpClaWeb.Controls.Add(Me.txtpreguntasecreta)
        Me.gpClaWeb.Controls.Add(Me.txtpass)
        Me.gpClaWeb.Controls.Add(Me.Label34)
        Me.gpClaWeb.Controls.Add(Me.Label35)
        Me.gpClaWeb.Controls.Add(Me.Label36)
        Me.gpClaWeb.Controls.Add(Me.Label37)
        Me.gpClaWeb.Location = New System.Drawing.Point(49, 43)
        Me.gpClaWeb.Name = "gpClaWeb"
        Me.gpClaWeb.Size = New System.Drawing.Size(585, 164)
        Me.gpClaWeb.TabIndex = 0
        Me.gpClaWeb.TabStop = False
        '
        'txtemail
        '
        '
        '
        '
        Me.txtemail.Border.Class = "TextBoxBorder"
        Me.txtemail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtemail.FocusHighlightEnabled = True
        Me.txtemail.Location = New System.Drawing.Point(161, 109)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(321, 20)
        Me.txtemail.TabIndex = 7
        Me.txtemail.WatermarkText = "email del usuario con la forma nombre@dominio.qqq.pp"
        '
        'txtrespsec
        '
        '
        '
        '
        Me.txtrespsec.Border.Class = "TextBoxBorder"
        Me.txtrespsec.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtrespsec.FocusHighlightEnabled = True
        Me.txtrespsec.Location = New System.Drawing.Point(161, 76)
        Me.txtrespsec.MaxLength = 100
        Me.txtrespsec.Name = "txtrespsec"
        Me.txtrespsec.Size = New System.Drawing.Size(220, 20)
        Me.txtrespsec.TabIndex = 5
        Me.txtrespsec.WatermarkText = "Escribe la respuesta secreta"
        '
        'txtpreguntasecreta
        '
        Me.txtpreguntasecreta.AcceptsTab = True
        '
        '
        '
        Me.txtpreguntasecreta.Border.Class = "TextBoxBorder"
        Me.txtpreguntasecreta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtpreguntasecreta.FocusHighlightEnabled = True
        Me.txtpreguntasecreta.Location = New System.Drawing.Point(161, 43)
        Me.txtpreguntasecreta.MaxLength = 100
        Me.txtpreguntasecreta.Name = "txtpreguntasecreta"
        Me.txtpreguntasecreta.Size = New System.Drawing.Size(215, 20)
        Me.txtpreguntasecreta.TabIndex = 3
        Me.txtpreguntasecreta.WatermarkText = "Escribe la pregunta secreta del usuario"
        '
        'txtpass
        '
        '
        '
        '
        Me.txtpass.Border.Class = "TextBoxBorder"
        Me.txtpass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtpass.FocusHighlightEnabled = True
        Me.txtpass.Location = New System.Drawing.Point(161, 15)
        Me.txtpass.MaxLength = 20
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(215, 20)
        Me.txtpass.TabIndex = 1
        Me.txtpass.WatermarkText = "Escribe el password del contrato en la web"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(46, 116)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(43, 13)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "e - mail:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(46, 83)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 13)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Respuesta secreta"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(46, 50)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(91, 13)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Pregunta secreta:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(46, 17)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 13)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Password:"
        '
        'claveweb
        '
        Me.claveweb.AttachedControl = Me.TabControlPanel4
        Me.claveweb.Name = "claveweb"
        Me.claveweb.Text = "Clave Web"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.gpDatEscri)
        Me.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(1041, 516)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabLegalyaudencia
        '
        'gpDatEscri
        '
        Me.gpDatEscri.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatEscri.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatEscri.Controls.Add(Me.txtescritura)
        Me.gpDatEscri.Controls.Add(Me.Label42)
        Me.gpDatEscri.Controls.Add(Me.txtcatastral)
        Me.gpDatEscri.Controls.Add(Me.cmbCaracter)
        Me.gpDatEscri.Controls.Add(Me.lblEscritura)
        Me.gpDatEscri.Controls.Add(Me.lblCaracter)
        Me.gpDatEscri.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatEscri.Location = New System.Drawing.Point(13, 2)
        Me.gpDatEscri.Name = "gpDatEscri"
        Me.gpDatEscri.Size = New System.Drawing.Size(587, 262)
        '
        '
        '
        Me.gpDatEscri.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatEscri.Style.BackColorGradientAngle = 90
        Me.gpDatEscri.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatEscri.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatEscri.Style.BorderBottomWidth = 1
        Me.gpDatEscri.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatEscri.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatEscri.Style.BorderLeftWidth = 1
        Me.gpDatEscri.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatEscri.Style.BorderRightWidth = 1
        Me.gpDatEscri.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatEscri.Style.BorderTopWidth = 1
        Me.gpDatEscri.Style.CornerDiameter = 4
        Me.gpDatEscri.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatEscri.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatEscri.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatEscri.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatEscri.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatEscri.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatEscri.TabIndex = 0
        Me.gpDatEscri.Text = "Datos de la escritura"
        '
        'txtescritura
        '
        Me.txtescritura.Location = New System.Drawing.Point(111, 45)
        Me.txtescritura.Multiline = True
        Me.txtescritura.Name = "txtescritura"
        Me.txtescritura.Size = New System.Drawing.Size(436, 175)
        Me.txtescritura.TabIndex = 17
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(355, 22)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(68, 13)
        Me.Label42.TabIndex = 16
        Me.Label42.Text = "Clave Unica:"
        Me.Label42.Visible = False
        '
        'txtcatastral
        '
        Me.txtcatastral.Location = New System.Drawing.Point(442, 19)
        Me.txtcatastral.Name = "txtcatastral"
        Me.txtcatastral.Size = New System.Drawing.Size(76, 20)
        Me.txtcatastral.TabIndex = 2
        Me.txtcatastral.Visible = False
        '
        'cmbCaracter
        '
        Me.cmbCaracter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCaracter.DisplayMember = "Text"
        Me.cmbCaracter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCaracter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaracter.FocusHighlightEnabled = True
        Me.cmbCaracter.FormattingEnabled = True
        Me.cmbCaracter.ItemHeight = 14
        Me.cmbCaracter.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8})
        Me.cmbCaracter.Location = New System.Drawing.Point(159, 18)
        Me.cmbCaracter.Name = "cmbCaracter"
        Me.cmbCaracter.Size = New System.Drawing.Size(124, 20)
        Me.cmbCaracter.TabIndex = 12
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Propietario"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Arrendatario"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Poseedor"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Comodatario"
        '
        'lblEscritura
        '
        Me.lblEscritura.AutoSize = True
        Me.lblEscritura.BackColor = System.Drawing.Color.Transparent
        Me.lblEscritura.Location = New System.Drawing.Point(9, 48)
        Me.lblEscritura.Name = "lblEscritura"
        Me.lblEscritura.Size = New System.Drawing.Size(96, 13)
        Me.lblEscritura.TabIndex = 4
        Me.lblEscritura.Text = "Datos de escritura:"
        '
        'lblCaracter
        '
        Me.lblCaracter.AutoSize = True
        Me.lblCaracter.BackColor = System.Drawing.Color.Transparent
        Me.lblCaracter.Location = New System.Drawing.Point(9, 22)
        Me.lblCaracter.Name = "lblCaracter"
        Me.lblCaracter.Size = New System.Drawing.Size(50, 13)
        Me.lblCaracter.TabIndex = 2
        Me.lblCaracter.Text = "Caracter:"
        '
        'TabLegalyaudencia
        '
        Me.TabLegalyaudencia.AttachedControl = Me.TabControlPanel3
        Me.TabLegalyaudencia.Name = "TabLegalyaudencia"
        Me.TabLegalyaudencia.Text = "Información catastral y legal"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.gpDatTec)
        Me.TabControlPanel2.Controls.Add(Me.gpObserva)
        Me.TabControlPanel2.Controls.Add(Me.gpDatUbi)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1041, 516)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.Referencias
        '
        'gpDatTec
        '
        Me.gpDatTec.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatTec.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatTec.Controls.Add(Me.CmbMarcaMedidor)
        Me.gpDatTec.Controls.Add(Me.CmbDiamToma)
        Me.gpDatTec.Controls.Add(Me.cmbDiamMed)
        Me.gpDatTec.Controls.Add(Me.dtffechainst)
        Me.gpDatTec.Controls.Add(Me.nderivacion)
        Me.gpDatTec.Controls.Add(Me.Label32)
        Me.gpDatTec.Controls.Add(Me.txtnumerodemedidor)
        Me.gpDatTec.Controls.Add(Me.Label19)
        Me.gpDatTec.Controls.Add(Me.txtTinaco)
        Me.gpDatTec.Controls.Add(Me.Label21)
        Me.gpDatTec.Controls.Add(Me.txtCisterna)
        Me.gpDatTec.Controls.Add(Me.Label23)
        Me.gpDatTec.Controls.Add(Me.txtAlberca)
        Me.gpDatTec.Controls.Add(Me.Label24)
        Me.gpDatTec.Controls.Add(Me.Label25)
        Me.gpDatTec.Controls.Add(Me.Label26)
        Me.gpDatTec.Controls.Add(Me.Label27)
        Me.gpDatTec.Controls.Add(Me.Label28)
        Me.gpDatTec.Controls.Add(Me.Label29)
        Me.gpDatTec.Controls.Add(Me.Label30)
        Me.gpDatTec.Controls.Add(Me.Label31)
        Me.gpDatTec.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatTec.Location = New System.Drawing.Point(12, 318)
        Me.gpDatTec.Name = "gpDatTec"
        Me.gpDatTec.Size = New System.Drawing.Size(645, 128)
        '
        '
        '
        Me.gpDatTec.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatTec.Style.BackColorGradientAngle = 90
        Me.gpDatTec.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatTec.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatTec.Style.BorderBottomWidth = 1
        Me.gpDatTec.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatTec.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatTec.Style.BorderLeftWidth = 1
        Me.gpDatTec.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatTec.Style.BorderRightWidth = 1
        Me.gpDatTec.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatTec.Style.BorderTopWidth = 1
        Me.gpDatTec.Style.CornerDiameter = 4
        Me.gpDatTec.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatTec.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatTec.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatTec.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatTec.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatTec.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatTec.TabIndex = 2
        Me.gpDatTec.Text = "Datos Técnicos de la toma"
        '
        'CmbMarcaMedidor
        '
        Me.CmbMarcaMedidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMarcaMedidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMarcaMedidor.DisplayMember = "Text"
        Me.CmbMarcaMedidor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbMarcaMedidor.FocusHighlightEnabled = True
        Me.CmbMarcaMedidor.FormattingEnabled = True
        Me.CmbMarcaMedidor.ItemHeight = 14
        Me.CmbMarcaMedidor.Location = New System.Drawing.Point(319, 1)
        Me.CmbMarcaMedidor.Name = "CmbMarcaMedidor"
        Me.CmbMarcaMedidor.Size = New System.Drawing.Size(90, 20)
        Me.CmbMarcaMedidor.TabIndex = 21
        '
        'CmbDiamToma
        '
        Me.CmbDiamToma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbDiamToma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbDiamToma.DisplayMember = "Text"
        Me.CmbDiamToma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbDiamToma.DropDownHeight = 300
        Me.CmbDiamToma.DropDownWidth = 150
        Me.CmbDiamToma.FocusHighlightEnabled = True
        Me.CmbDiamToma.FormattingEnabled = True
        Me.CmbDiamToma.IntegralHeight = False
        Me.CmbDiamToma.ItemHeight = 14
        Me.CmbDiamToma.Location = New System.Drawing.Point(432, 27)
        Me.CmbDiamToma.Name = "CmbDiamToma"
        Me.CmbDiamToma.Size = New System.Drawing.Size(158, 20)
        Me.CmbDiamToma.TabIndex = 9
        '
        'cmbDiamMed
        '
        Me.cmbDiamMed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDiamMed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDiamMed.DisplayMember = "Text"
        Me.cmbDiamMed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDiamMed.DropDownHeight = 300
        Me.cmbDiamMed.DropDownWidth = 150
        Me.cmbDiamMed.FocusHighlightEnabled = True
        Me.cmbDiamMed.FormattingEnabled = True
        Me.cmbDiamMed.IntegralHeight = False
        Me.cmbDiamMed.ItemHeight = 14
        Me.cmbDiamMed.Location = New System.Drawing.Point(141, 27)
        Me.cmbDiamMed.Name = "cmbDiamMed"
        Me.cmbDiamMed.Size = New System.Drawing.Size(158, 20)
        Me.cmbDiamMed.TabIndex = 7
        '
        'dtffechainst
        '
        '
        '
        '
        Me.dtffechainst.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtffechainst.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtffechainst.ButtonDropDown.Visible = True
        Me.dtffechainst.FocusHighlightEnabled = True
        Me.dtffechainst.IsPopupCalendarOpen = False
        Me.dtffechainst.Location = New System.Drawing.Point(432, 79)
        '
        '
        '
        '
        '
        '
        Me.dtffechainst.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtffechainst.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtffechainst.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtffechainst.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtffechainst.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtffechainst.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtffechainst.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtffechainst.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtffechainst.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtffechainst.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtffechainst.MonthCalendar.DisplayMonth = New Date(2008, 9, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtffechainst.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtffechainst.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtffechainst.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtffechainst.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtffechainst.MonthCalendar.TodayButtonVisible = True
        Me.dtffechainst.Name = "dtffechainst"
        Me.dtffechainst.Size = New System.Drawing.Size(78, 20)
        Me.dtffechainst.TabIndex = 20
        '
        'nderivacion
        '
        Me.nderivacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nderivacion.Location = New System.Drawing.Point(143, 1)
        Me.nderivacion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nderivacion.Name = "nderivacion"
        Me.nderivacion.Size = New System.Drawing.Size(59, 20)
        Me.nderivacion.TabIndex = 1
        Me.nderivacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nderivacion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(24, 5)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(61, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Derivación:"
        '
        'txtnumerodemedidor
        '
        '
        '
        '
        Me.txtnumerodemedidor.Border.Class = "TextBoxBorder"
        Me.txtnumerodemedidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnumerodemedidor.Location = New System.Drawing.Point(525, 1)
        Me.txtnumerodemedidor.Name = "txtnumerodemedidor"
        Me.txtnumerodemedidor.Size = New System.Drawing.Size(94, 20)
        Me.txtnumerodemedidor.TabIndex = 5
        Me.txtnumerodemedidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnumerodemedidor.WatermarkText = "Escribe todos los digitos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(222, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Lts"
        '
        'txtTinaco
        '
        Me.txtTinaco.DecimalPlaces = 2
        Me.txtTinaco.InterceptArrowKeys = False
        Me.txtTinaco.Location = New System.Drawing.Point(142, 79)
        Me.txtTinaco.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtTinaco.Name = "txtTinaco"
        Me.txtTinaco.Size = New System.Drawing.Size(67, 20)
        Me.txtTinaco.TabIndex = 17
        Me.txtTinaco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(498, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "m3"
        '
        'txtCisterna
        '
        Me.txtCisterna.DecimalPlaces = 2
        Me.txtCisterna.InterceptArrowKeys = False
        Me.txtCisterna.Location = New System.Drawing.Point(432, 53)
        Me.txtCisterna.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtCisterna.Name = "txtCisterna"
        Me.txtCisterna.Size = New System.Drawing.Size(55, 20)
        Me.txtCisterna.TabIndex = 14
        Me.txtCisterna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(221, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 13)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "m3"
        '
        'txtAlberca
        '
        Me.txtAlberca.DecimalPlaces = 2
        Me.txtAlberca.InterceptArrowKeys = False
        Me.txtAlberca.Location = New System.Drawing.Point(142, 53)
        Me.txtAlberca.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtAlberca.Name = "txtAlberca"
        Me.txtAlberca.Size = New System.Drawing.Size(67, 20)
        Me.txtAlberca.TabIndex = 11
        Me.txtAlberca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(318, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(108, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Diametro de la Toma:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(24, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(97, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Capacidad Tinaco:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(24, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(110, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Diametro del Medidor:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(318, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 13)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Capacidad Cisterna:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(24, 57)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 13)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "Capacidad Alberca:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(416, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(103, 13)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Número de Medidor:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(217, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Marca del Medidor:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(318, 83)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(109, 13)
        Me.Label31.TabIndex = 19
        Me.Label31.Text = "Fecha de Instalación:"
        '
        'gpObserva
        '
        Me.gpObserva.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpObserva.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpObserva.Controls.Add(Me.txtobservacioncontrato)
        Me.gpObserva.Controls.Add(Me.Label33)
        Me.gpObserva.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpObserva.Location = New System.Drawing.Point(13, 238)
        Me.gpObserva.Name = "gpObserva"
        Me.gpObserva.Size = New System.Drawing.Size(645, 74)
        '
        '
        '
        Me.gpObserva.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpObserva.Style.BackColorGradientAngle = 90
        Me.gpObserva.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpObserva.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserva.Style.BorderBottomWidth = 1
        Me.gpObserva.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpObserva.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserva.Style.BorderLeftWidth = 1
        Me.gpObserva.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserva.Style.BorderRightWidth = 1
        Me.gpObserva.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserva.Style.BorderTopWidth = 1
        Me.gpObserva.Style.CornerDiameter = 4
        Me.gpObserva.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpObserva.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpObserva.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpObserva.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpObserva.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpObserva.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpObserva.TabIndex = 1
        Me.gpObserva.Text = "Observaciones generales de la toma"
        '
        'txtobservacioncontrato
        '
        '
        '
        '
        Me.txtobservacioncontrato.Border.Class = "TextBoxBorder"
        Me.txtobservacioncontrato.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtobservacioncontrato.FocusHighlightEnabled = True
        Me.txtobservacioncontrato.Location = New System.Drawing.Point(122, 3)
        Me.txtobservacioncontrato.Multiline = True
        Me.txtobservacioncontrato.Name = "txtobservacioncontrato"
        Me.txtobservacioncontrato.Size = New System.Drawing.Size(513, 48)
        Me.txtobservacioncontrato.TabIndex = 1
        Me.txtobservacioncontrato.WatermarkText = "Escribe una observacion general al contrato"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(24, 5)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Observaciones:"
        '
        'gpDatUbi
        '
        Me.gpDatUbi.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatUbi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatUbi.Controls.Add(Me.CMBCALLE4)
        Me.gpDatUbi.Controls.Add(Me.CMBCALLE3)
        Me.gpDatUbi.Controls.Add(Me.CMBCALLE2)
        Me.gpDatUbi.Controls.Add(Me.CMBCALLE1)
        Me.gpDatUbi.Controls.Add(Me.txtGps33)
        Me.gpDatUbi.Controls.Add(Me.txtGps22)
        Me.gpDatUbi.Controls.Add(Me.txtGps11)
        Me.gpDatUbi.Controls.Add(Me.Label18)
        Me.gpDatUbi.Controls.Add(Me.Label41)
        Me.gpDatUbi.Controls.Add(Me.txtreferencias)
        Me.gpDatUbi.Controls.Add(Me.LblUbicacionEspecifica)
        Me.gpDatUbi.Controls.Add(Me.lblc4)
        Me.gpDatUbi.Controls.Add(Me.lblc3)
        Me.gpDatUbi.Controls.Add(Me.lblc2)
        Me.gpDatUbi.Controls.Add(Me.lblc1)
        Me.gpDatUbi.Controls.Add(Me.Label10)
        Me.gpDatUbi.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatUbi.Location = New System.Drawing.Point(12, 4)
        Me.gpDatUbi.Name = "gpDatUbi"
        Me.gpDatUbi.Size = New System.Drawing.Size(645, 228)
        '
        '
        '
        Me.gpDatUbi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatUbi.Style.BackColorGradientAngle = 90
        Me.gpDatUbi.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatUbi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUbi.Style.BorderBottomWidth = 1
        Me.gpDatUbi.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatUbi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUbi.Style.BorderLeftWidth = 1
        Me.gpDatUbi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUbi.Style.BorderRightWidth = 1
        Me.gpDatUbi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUbi.Style.BorderTopWidth = 1
        Me.gpDatUbi.Style.CornerDiameter = 4
        Me.gpDatUbi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatUbi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatUbi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatUbi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatUbi.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatUbi.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatUbi.TabIndex = 0
        Me.gpDatUbi.Text = "Datos de la ubicación de la toma"
        '
        'CMBCALLE4
        '
        Me.CMBCALLE4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCALLE4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE4.DisplayMember = "Text"
        Me.CMBCALLE4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE4.FocusHighlightEnabled = True
        Me.CMBCALLE4.FormattingEnabled = True
        Me.CMBCALLE4.ItemHeight = 14
        Me.CMBCALLE4.Location = New System.Drawing.Point(144, 127)
        Me.CMBCALLE4.Name = "CMBCALLE4"
        Me.CMBCALLE4.Size = New System.Drawing.Size(491, 20)
        Me.CMBCALLE4.TabIndex = 4
        '
        'CMBCALLE3
        '
        Me.CMBCALLE3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCALLE3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE3.DisplayMember = "Text"
        Me.CMBCALLE3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE3.FocusHighlightEnabled = True
        Me.CMBCALLE3.FormattingEnabled = True
        Me.CMBCALLE3.ItemHeight = 14
        Me.CMBCALLE3.Location = New System.Drawing.Point(144, 100)
        Me.CMBCALLE3.Name = "CMBCALLE3"
        Me.CMBCALLE3.Size = New System.Drawing.Size(491, 20)
        Me.CMBCALLE3.TabIndex = 3
        '
        'CMBCALLE2
        '
        Me.CMBCALLE2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCALLE2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE2.DisplayMember = "Text"
        Me.CMBCALLE2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE2.FocusHighlightEnabled = True
        Me.CMBCALLE2.FormattingEnabled = True
        Me.CMBCALLE2.ItemHeight = 14
        Me.CMBCALLE2.Location = New System.Drawing.Point(144, 73)
        Me.CMBCALLE2.Name = "CMBCALLE2"
        Me.CMBCALLE2.Size = New System.Drawing.Size(491, 20)
        Me.CMBCALLE2.TabIndex = 2
        '
        'CMBCALLE1
        '
        Me.CMBCALLE1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCALLE1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE1.DisplayMember = "Text"
        Me.CMBCALLE1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE1.FocusHighlightEnabled = True
        Me.CMBCALLE1.FormattingEnabled = True
        Me.CMBCALLE1.ItemHeight = 14
        Me.CMBCALLE1.Location = New System.Drawing.Point(144, 46)
        Me.CMBCALLE1.Name = "CMBCALLE1"
        Me.CMBCALLE1.Size = New System.Drawing.Size(491, 20)
        Me.CMBCALLE1.TabIndex = 1
        '
        'txtGps33
        '
        Me.txtGps33.Location = New System.Drawing.Point(370, 179)
        Me.txtGps33.Name = "txtGps33"
        Me.txtGps33.Size = New System.Drawing.Size(100, 20)
        Me.txtGps33.TabIndex = 8
        '
        'txtGps22
        '
        Me.txtGps22.Location = New System.Drawing.Point(253, 179)
        Me.txtGps22.Name = "txtGps22"
        Me.txtGps22.Size = New System.Drawing.Size(100, 20)
        Me.txtGps22.TabIndex = 7
        '
        'txtGps11
        '
        Me.txtGps11.Location = New System.Drawing.Point(144, 179)
        Me.txtGps11.Name = "txtGps11"
        Me.txtGps11.Size = New System.Drawing.Size(100, 20)
        Me.txtGps11.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(27, 183)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Ubicacion GPS"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(27, 158)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(101, 13)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "Clave de ubicacion:"
        '
        'txtreferencias
        '
        '
        '
        '
        Me.txtreferencias.Border.Class = "TextBoxBorder"
        Me.txtreferencias.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtreferencias.FocusHighlightEnabled = True
        Me.txtreferencias.Location = New System.Drawing.Point(85, 1)
        Me.txtreferencias.Name = "txtreferencias"
        Me.txtreferencias.Size = New System.Drawing.Size(534, 20)
        Me.txtreferencias.TabIndex = 0
        Me.txtreferencias.WatermarkText = "Referencias de ubicación de la toma"
        '
        'LblUbicacionEspecifica
        '
        Me.LblUbicacionEspecifica.AutoSize = True
        Me.LblUbicacionEspecifica.BackColor = System.Drawing.Color.Transparent
        Me.LblUbicacionEspecifica.Location = New System.Drawing.Point(21, 26)
        Me.LblUbicacionEspecifica.Name = "LblUbicacionEspecifica"
        Me.LblUbicacionEspecifica.Size = New System.Drawing.Size(167, 13)
        Me.LblUbicacionEspecifica.TabIndex = 2
        Me.LblUbicacionEspecifica.Text = "Ubicacion Especifica del domicilio"
        '
        'lblc4
        '
        Me.lblc4.AutoSize = True
        Me.lblc4.BackColor = System.Drawing.Color.Transparent
        Me.lblc4.ForeColor = System.Drawing.Color.Black
        Me.lblc4.Location = New System.Drawing.Point(59, 131)
        Me.lblc4.Name = "lblc4"
        Me.lblc4.Size = New System.Drawing.Size(69, 13)
        Me.lblc4.TabIndex = 9
        Me.lblc4.Text = "Entre calle 4:"
        '
        'lblc3
        '
        Me.lblc3.AutoSize = True
        Me.lblc3.BackColor = System.Drawing.Color.Transparent
        Me.lblc3.ForeColor = System.Drawing.Color.Black
        Me.lblc3.Location = New System.Drawing.Point(59, 104)
        Me.lblc3.Name = "lblc3"
        Me.lblc3.Size = New System.Drawing.Size(69, 13)
        Me.lblc3.TabIndex = 7
        Me.lblc3.Text = "Entre calle 3:"
        '
        'lblc2
        '
        Me.lblc2.AutoSize = True
        Me.lblc2.BackColor = System.Drawing.Color.Transparent
        Me.lblc2.ForeColor = System.Drawing.Color.Black
        Me.lblc2.Location = New System.Drawing.Point(59, 77)
        Me.lblc2.Name = "lblc2"
        Me.lblc2.Size = New System.Drawing.Size(69, 13)
        Me.lblc2.TabIndex = 5
        Me.lblc2.Text = "Entre calle 2:"
        '
        'lblc1
        '
        Me.lblc1.AutoSize = True
        Me.lblc1.BackColor = System.Drawing.Color.Transparent
        Me.lblc1.ForeColor = System.Drawing.Color.Black
        Me.lblc1.Location = New System.Drawing.Point(59, 50)
        Me.lblc1.Name = "lblc1"
        Me.lblc1.Size = New System.Drawing.Size(69, 13)
        Me.lblc1.TabIndex = 3
        Me.lblc1.Text = "Entre calle 1:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(3, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Referencias:"
        '
        'Referencias
        '
        Me.Referencias.AttachedControl = Me.TabControlPanel2
        Me.Referencias.Name = "Referencias"
        Me.Referencias.Text = "Referencias"
        '
        'TxtGps3
        '
        Me.TxtGps3.Location = New System.Drawing.Point(363, 436)
        Me.TxtGps3.Name = "TxtGps3"
        Me.TxtGps3.Size = New System.Drawing.Size(100, 20)
        Me.TxtGps3.TabIndex = 43
        '
        'TxtGps2
        '
        Me.TxtGps2.Location = New System.Drawing.Point(246, 436)
        Me.TxtGps2.Name = "TxtGps2"
        Me.TxtGps2.Size = New System.Drawing.Size(100, 20)
        Me.TxtGps2.TabIndex = 42
        '
        'TxtGps1
        '
        Me.TxtGps1.Location = New System.Drawing.Point(137, 436)
        Me.TxtGps1.Name = "TxtGps1"
        Me.TxtGps1.Size = New System.Drawing.Size(100, 20)
        Me.TxtGps1.TabIndex = 41
        '
        'LblUbicacionGPS
        '
        Me.LblUbicacionGPS.AutoSize = True
        Me.LblUbicacionGPS.Location = New System.Drawing.Point(24, 436)
        Me.LblUbicacionGPS.Name = "LblUbicacionGPS"
        Me.LblUbicacionGPS.Size = New System.Drawing.Size(80, 13)
        Me.LblUbicacionGPS.TabIndex = 40
        Me.LblUbicacionGPS.Text = "Ubicacion GPS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "m3"
        '
        'CmbMarcaMedidor1
        '
        Me.CmbMarcaMedidor1.FormattingEnabled = True
        Me.CmbMarcaMedidor1.Location = New System.Drawing.Point(568, -3)
        Me.CmbMarcaMedidor1.Name = "CmbMarcaMedidor1"
        Me.CmbMarcaMedidor1.Size = New System.Drawing.Size(223, 21)
        Me.CmbMarcaMedidor1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(674, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "m3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(674, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "pulgadas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "pulgadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "m3"
        '
        'txtDiamMedidor
        '
        Me.txtDiamMedidor.DecimalPlaces = 2
        Me.txtDiamMedidor.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.txtDiamMedidor.InterceptArrowKeys = False
        Me.txtDiamMedidor.Location = New System.Drawing.Point(137, 330)
        Me.txtDiamMedidor.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtDiamMedidor.Name = "txtDiamMedidor"
        Me.txtDiamMedidor.Size = New System.Drawing.Size(160, 20)
        Me.txtDiamMedidor.TabIndex = 24
        '
        'lblDiamToma
        '
        Me.lblDiamToma.AutoSize = True
        Me.lblDiamToma.Location = New System.Drawing.Point(381, 330)
        Me.lblDiamToma.Name = "lblDiamToma"
        Me.lblDiamToma.Size = New System.Drawing.Size(108, 13)
        Me.lblDiamToma.TabIndex = 26
        Me.lblDiamToma.Text = "Diametro de la Toma:"
        '
        'lblTinaco
        '
        Me.lblTinaco.AutoSize = True
        Me.lblTinaco.Location = New System.Drawing.Point(20, 386)
        Me.lblTinaco.Name = "lblTinaco"
        Me.lblTinaco.Size = New System.Drawing.Size(97, 13)
        Me.lblTinaco.TabIndex = 35
        Me.lblTinaco.Text = "Capacidad Tinaco:"
        '
        'lblDiamMedidor
        '
        Me.lblDiamMedidor.AutoSize = True
        Me.lblDiamMedidor.Location = New System.Drawing.Point(20, 330)
        Me.lblDiamMedidor.Name = "lblDiamMedidor"
        Me.lblDiamMedidor.Size = New System.Drawing.Size(110, 13)
        Me.lblDiamMedidor.TabIndex = 23
        Me.lblDiamMedidor.Text = "Diametro del Medidor:"
        '
        'lblCisterna
        '
        Me.lblCisterna.AutoSize = True
        Me.lblCisterna.Location = New System.Drawing.Point(381, 360)
        Me.lblCisterna.Name = "lblCisterna"
        Me.lblCisterna.Size = New System.Drawing.Size(102, 13)
        Me.lblCisterna.TabIndex = 32
        Me.lblCisterna.Text = "Capacidad Cisterna:"
        '
        'txtNoMedidor
        '
        Me.txtNoMedidor.Location = New System.Drawing.Point(501, 277)
        Me.txtNoMedidor.Name = "txtNoMedidor"
        Me.txtNoMedidor.Size = New System.Drawing.Size(223, 20)
        Me.txtNoMedidor.TabIndex = 22
        '
        'lblAlberca
        '
        Me.lblAlberca.AutoSize = True
        Me.lblAlberca.Location = New System.Drawing.Point(20, 360)
        Me.lblAlberca.Name = "lblAlberca"
        Me.lblAlberca.Size = New System.Drawing.Size(100, 13)
        Me.lblAlberca.TabIndex = 29
        Me.lblAlberca.Text = "Capacidad Alberca:"
        '
        'lblNoMedidor
        '
        Me.lblNoMedidor.AutoSize = True
        Me.lblNoMedidor.Location = New System.Drawing.Point(381, 277)
        Me.lblNoMedidor.Name = "lblNoMedidor"
        Me.lblNoMedidor.Size = New System.Drawing.Size(103, 13)
        Me.lblNoMedidor.TabIndex = 21
        Me.lblNoMedidor.Text = "Número de Medidor:"
        '
        'lblMarcaMedidor
        '
        Me.lblMarcaMedidor.AutoSize = True
        Me.lblMarcaMedidor.Location = New System.Drawing.Point(20, 277)
        Me.lblMarcaMedidor.Name = "lblMarcaMedidor"
        Me.lblMarcaMedidor.Size = New System.Drawing.Size(98, 13)
        Me.lblMarcaMedidor.TabIndex = 19
        Me.lblMarcaMedidor.Text = "Marca del Medidor:"
        '
        'txtFactibilidad
        '
        Me.txtFactibilidad.Location = New System.Drawing.Point(501, 386)
        Me.txtFactibilidad.Name = "txtFactibilidad"
        Me.txtFactibilidad.Size = New System.Drawing.Size(223, 20)
        Me.txtFactibilidad.TabIndex = 39
        '
        'lblFactibilidad
        '
        Me.lblFactibilidad.AutoSize = True
        Me.lblFactibilidad.Location = New System.Drawing.Point(381, 386)
        Me.lblFactibilidad.Name = "lblFactibilidad"
        Me.lblFactibilidad.Size = New System.Drawing.Size(63, 13)
        Me.lblFactibilidad.TabIndex = 38
        Me.lblFactibilidad.Text = "Factibilidad:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(587, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'dtpFechaInstalacion
        '
        Me.dtpFechaInstalacion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaInstalacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInstalacion.Location = New System.Drawing.Point(501, 235)
        Me.dtpFechaInstalacion.Name = "dtpFechaInstalacion"
        Me.dtpFechaInstalacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpFechaInstalacion.Size = New System.Drawing.Size(223, 20)
        Me.dtpFechaInstalacion.TabIndex = 18
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(137, 138)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(587, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fecha de Instalación:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ubicacion Especifica del domicilio"
        '
        'txtClavePredial
        '
        Me.txtClavePredial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClavePredial.Location = New System.Drawing.Point(137, 235)
        Me.txtClavePredial.Name = "txtClavePredial"
        Me.txtClavePredial.Size = New System.Drawing.Size(223, 20)
        Me.txtClavePredial.TabIndex = 16
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(137, 111)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(587, 21)
        Me.ComboBox3.TabIndex = 8
        '
        'lblClavePredial
        '
        Me.lblClavePredial.AutoSize = True
        Me.lblClavePredial.Location = New System.Drawing.Point(20, 235)
        Me.lblClavePredial.Name = "lblClavePredial"
        Me.lblClavePredial.Size = New System.Drawing.Size(72, 13)
        Me.lblClavePredial.TabIndex = 15
        Me.lblClavePredial.Text = "Clave Predial:"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(137, 84)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(587, 21)
        Me.ComboBox4.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(53, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Entre calle 4:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(53, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Entre calle 3:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(53, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Entre calle 2:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(53, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Entre calle 1:"
        '
        'lblDerivaciones
        '
        Me.lblDerivaciones.AutoSize = True
        Me.lblDerivaciones.ForeColor = System.Drawing.Color.Red
        Me.lblDerivaciones.Location = New System.Drawing.Point(355, 15)
        Me.lblDerivaciones.Name = "lblDerivaciones"
        Me.lblDerivaciones.Size = New System.Drawing.Size(72, 13)
        Me.lblDerivaciones.TabIndex = 2
        Me.lblDerivaciones.Text = "Derivaciones:"
        '
        'txtDerivaciones
        '
        Me.txtDerivaciones.Location = New System.Drawing.Point(453, 15)
        Me.txtDerivaciones.Name = "txtDerivaciones"
        Me.txtDerivaciones.Size = New System.Drawing.Size(247, 20)
        Me.txtDerivaciones.TabIndex = 3
        Me.txtDerivaciones.Tag = "derivacion"
        '
        'lblpagohasta
        '
        Me.lblpagohasta.AutoSize = True
        Me.lblpagohasta.ForeColor = System.Drawing.Color.Red
        Me.lblpagohasta.Location = New System.Drawing.Point(17, 15)
        Me.lblpagohasta.Name = "lblpagohasta"
        Me.lblpagohasta.Size = New System.Drawing.Size(78, 13)
        Me.lblpagohasta.TabIndex = 0
        Me.lblpagohasta.Text = "Pagado Hasta:"
        '
        'dtpPagoHasta
        '
        Me.dtpPagoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPagoHasta.Location = New System.Drawing.Point(137, 15)
        Me.dtpPagoHasta.Name = "dtpPagoHasta"
        Me.dtpPagoHasta.Size = New System.Drawing.Size(100, 20)
        Me.dtpPagoHasta.TabIndex = 1
        Me.dtpPagoHasta.Tag = "deudafec"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(20, 208)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(81, 13)
        Me.lblObs.TabIndex = 13
        Me.lblObs.Text = "Observaciones:"
        '
        'txtObs
        '
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Location = New System.Drawing.Point(137, 208)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(587, 22)
        Me.txtObs.TabIndex = 14
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
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdAcept, Me.cmdImp, Me.cmdMail, Me.cmdAgrCar, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(1041, 42)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 0
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
        'cmdAcept
        '
        Me.cmdAcept.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.SubItemsExpandWidth = 14
        Me.cmdAcept.Text = "Aceptar"
        '
        'cmdImp
        '
        Me.cmdImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.SubItemsExpandWidth = 14
        Me.cmdImp.Text = "Imprimir"
        Me.cmdImp.Visible = False
        '
        'cmdMail
        '
        Me.cmdMail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdMail.Image = Global.Administativo.My.Resources.Resources.email
        Me.cmdMail.Name = "cmdMail"
        Me.cmdMail.SubItemsExpandWidth = 14
        Me.cmdMail.Text = "Mandar Password"
        Me.cmdMail.Visible = False
        '
        'cmdAgrCar
        '
        Me.cmdAgrCar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdAgrCar.Image = Global.Administativo.My.Resources.Resources.otroscobros
        Me.cmdAgrCar.Name = "cmdAgrCar"
        Me.cmdAgrCar.SubItemsExpandWidth = 14
        Me.cmdAgrCar.Text = "AgregarCargo"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Cerrar"
        '
        'ControlContainerItem3
        '
        Me.ControlContainerItem3.AllowItemResize = False
        Me.ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem3.Name = "ControlContainerItem3"
        '
        'btnver
        '
        Me.btnver.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnver.Image = Global.Administativo.My.Resources.Resources.kdict1
        Me.btnver.Name = "btnver"
        Me.btnver.Text = "Visualizar"
        '
        'frmcontrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 580)
        Me.Controls.Add(Me.Tabsolicitud)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmcontrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contratos"
        CType(Me.Tabsolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabsolicitud.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.gpDatRec.ResumeLayout(False)
        Me.gpDatRec.PerformLayout()
        Me.gpUbiToma.ResumeLayout(False)
        Me.gpUbiToma.PerformLayout()
        Me.gpDatServ.ResumeLayout(False)
        Me.gpDatServ.PerformLayout()
        Me.gpDatCont.ResumeLayout(False)
        Me.gpDatCont.PerformLayout()
        CType(Me.DTfechadeuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfsolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel7.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        CType(Me.mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabcFotos.ResumeLayout(False)
        Me.gpFotos.ResumeLayout(False)
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel6.ResumeLayout(False)
        Me.TabControlPanel6.PerformLayout()
        CType(Me.DTgfecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel5.ResumeLayout(False)
        Me.TabControlPanel5.PerformLayout()
        CType(Me.dporce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifasAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel4.ResumeLayout(False)
        Me.gpClaWeb.ResumeLayout(False)
        Me.gpClaWeb.PerformLayout()
        Me.TabControlPanel3.ResumeLayout(False)
        Me.gpDatEscri.ResumeLayout(False)
        Me.gpDatEscri.PerformLayout()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.gpDatTec.ResumeLayout(False)
        Me.gpDatTec.PerformLayout()
        CType(Me.dtffechainst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nderivacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTinaco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCisterna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlberca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpObserva.ResumeLayout(False)
        Me.gpObserva.PerformLayout()
        Me.gpDatUbi.ResumeLayout(False)
        Me.gpDatUbi.PerformLayout()
        CType(Me.txtDiamMedidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LstCalles As System.Windows.Forms.ListBox
    Friend WithEvents TxtGps3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtGps2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtGps1 As System.Windows.Forms.TextBox
    Friend WithEvents LblUbicacionGPS As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbMarcaMedidor1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents Label12 As System.Windows.Forms.Label


    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDiamMedidor As System.Windows.Forms.NumericUpDown

    Friend WithEvents lblDiamToma As System.Windows.Forms.Label
    Friend WithEvents lblTinaco As System.Windows.Forms.Label
    Friend WithEvents lblDiamMedidor As System.Windows.Forms.Label
    Friend WithEvents lblCisterna As System.Windows.Forms.Label
    Friend WithEvents txtNoMedidor As System.Windows.Forms.TextBox
    Friend WithEvents lblAlberca As System.Windows.Forms.Label
    Friend WithEvents lblNoMedidor As System.Windows.Forms.Label
    Friend WithEvents lblMarcaMedidor As System.Windows.Forms.Label
    Friend WithEvents txtFactibilidad As System.Windows.Forms.TextBox
    Friend WithEvents lblFactibilidad As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaInstalacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtClavePredial As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblClavePredial As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblDerivaciones As System.Windows.Forms.Label
    Friend WithEvents txtDerivaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblpagohasta As System.Windows.Forms.Label
    Friend WithEvents dtpPagoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents gpClaWeb As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblsolicitud As System.Windows.Forms.Label
    Friend WithEvents chkSanea As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlcantarillado As System.Windows.Forms.CheckBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblManzana As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblsector As System.Windows.Forms.Label
    Friend WithEvents lblcp As System.Windows.Forms.Label
    Friend WithEvents lblcomunidad As System.Windows.Forms.Label
    Friend WithEvents lblcolonia As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblGiro As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblEscritura As System.Windows.Forms.Label
    Friend WithEvents lblCaracter As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents LblUbicacionEspecifica As System.Windows.Forms.Label
    Friend WithEvents lblc4 As System.Windows.Forms.Label
    Friend WithEvents lblc3 As System.Windows.Forms.Label
    Friend WithEvents lblc2 As System.Windows.Forms.Label
    Friend WithEvents lblc1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents rbDirUbi As System.Windows.Forms.RadioButton
    Friend WithEvents rbDirFis As System.Windows.Forms.RadioButton
    Friend WithEvents rbDomAu As System.Windows.Forms.RadioButton
    Friend WithEvents lblidentificacion As System.Windows.Forms.Label
    Friend WithEvents lblparentesco As System.Windows.Forms.Label
    Friend WithEvents lblsolicitado As System.Windows.Forms.Label
    Friend WithEvents txtGps33 As System.Windows.Forms.TextBox
    Friend WithEvents txtGps22 As System.Windows.Forms.TextBox
    Friend WithEvents txtGps11 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents nderivacion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTinaco As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCisterna As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAlberca As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents pic2 As New System.Windows.Forms.PictureBox
    Friend WithEvents pic1 As New System.Windows.Forms.PictureBox
    Friend WithEvents pic4 As New System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As New System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ChkGestCob As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAltoCon As System.Windows.Forms.CheckBox
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TarifasAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents dporce As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents CedulaC As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents lblCuoValvu As System.Windows.Forms.Label
    Friend WithEvents DTgfecha As DataGridView
    Friend WithEvents Label53 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents DtgTarifa As DataGridView
    Friend WithEvents Label51 As Label
    Friend WithEvents DtgNombre As DataGridView
    Friend WithEvents Label42 As Label
    Friend WithEvents txtcatastral As MaskedTextBox
    Private WithEvents Tabsolicitud As DevComponents.DotNetBar.TabControl
    Private WithEvents TabControlPanel1 As TabControlPanel
    Private WithEvents dtfsolicitud As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents Cmbestado As Controls.ComboBoxEx
    Private WithEvents txtclave As Controls.TextBoxX
    Private WithEvents TabItem3 As TabItem
    Private WithEvents TabControlPanel2 As TabControlPanel
    Private WithEvents Referencias As TabItem
    Private WithEvents TabControlPanel3 As TabControlPanel
    Private WithEvents TabLegalyaudencia As TabItem
    Private WithEvents TabControlPanel4 As TabControlPanel
    Private WithEvents txtpass As Controls.TextBoxX
    Private WithEvents claveweb As TabItem
    Private WithEvents txtpreguntasecreta As Controls.TextBoxX
    Private WithEvents txtrespsec As Controls.TextBoxX
    Private WithEvents txtemail As Controls.TextBoxX
    Private WithEvents cmbtarifa As Controls.ComboBoxEx
    Private WithEvents gpDatCont As Controls.GroupPanel
    Private WithEvents gpDatServ As Controls.GroupPanel
    Private WithEvents cmbFservicio As Controls.ComboBoxEx
    Private WithEvents cmbtipouso As Controls.ComboBoxEx
    Private WithEvents txtpropietario As Controls.TextBoxX
    Private WithEvents gpUbiToma As Controls.GroupPanel
    Private WithEvents txtlote As Controls.TextBoxX
    Private WithEvents txtmzn As Controls.TextBoxX
    Private WithEvents cmbruta As Controls.ComboBoxEx
    Private WithEvents txtcp As Controls.TextBoxX
    Private WithEvents txtnumint As Controls.TextBoxX
    Private WithEvents txtnumext As Controls.TextBoxX
    Private WithEvents cmbcolonia As Controls.ComboBoxEx
    Private WithEvents Cmbcomunidad As Controls.ComboBoxEx
    Private WithEvents Cmbmunicipio As Controls.ComboBoxEx
    Private WithEvents Cmbsector As Controls.ComboBoxEx
    Private WithEvents cmbgiro As Controls.ComboBoxEx
    Private WithEvents CmbEstPredio As Controls.ComboBoxEx
    Private WithEvents cmbnivsoc As Controls.ComboBoxEx
    Private WithEvents gpDatEscri As Controls.GroupPanel
    Private WithEvents gpDatUbi As Controls.GroupPanel

    Private WithEvents txtreferencias As Controls.TextBoxX
    Private WithEvents gpObserva As Controls.GroupPanel
    Private WithEvents txtobservacioncontrato As Controls.TextBoxX
    Private WithEvents gpDatRec As Controls.GroupPanel
    Private WithEvents txtidentificacion As Controls.TextBoxX
    Private WithEvents txtparentesco As Controls.TextBoxX
    Private WithEvents txtsolicitado As Controls.TextBoxX
    Private WithEvents gpDatTec As Controls.GroupPanel
    Private WithEvents dtffechainst As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents txtnumerodemedidor As Controls.TextBoxX
    Private WithEvents tabcFotos As TabControlPanel
    Private WithEvents gpFotos As Controls.GroupPanel
    Private WithEvents tabfotos As TabItem
    Private WithEvents cmbDiamMed As Controls.ComboBoxEx
    Private WithEvents LabelX4 As LabelX
    Private WithEvents LabelX3 As LabelX
    Private WithEvents LabelX2 As LabelX
    Private WithEvents LabelX1 As LabelX
    Private WithEvents LabelX5 As LabelX
    Private WithEvents CmbDiamToma As Controls.ComboBoxEx
    Private WithEvents rbOp As RibbonBar
    Private WithEvents cmdAcept As ButtonItem
    Private WithEvents cmdImp As ButtonItem
    Private WithEvents cmdMail As ButtonItem
    Private WithEvents cmdAgrCar As ButtonItem
    Private WithEvents cmdSalir As ButtonItem
    Private WithEvents cmbRegion As Controls.ComboBoxEx
    Private WithEvents LblGis As LabelX
    Private WithEvents LblTitGis As LabelX
    Private WithEvents CMBCALLE1 As Controls.ComboBoxEx
    Private WithEvents CMBCALLE2 As Controls.ComboBoxEx
    Private WithEvents CMBCALLE3 As Controls.ComboBoxEx
    Private WithEvents CMBCALLE4 As Controls.ComboBoxEx
    Private WithEvents CmbMarcaMedidor As Controls.ComboBoxEx
    Private WithEvents cmbCaracter As Controls.ComboBoxEx
    Private WithEvents lblubicacion As LabelX
    Private WithEvents ButtonX1 As ButtonX
    Private WithEvents ButtonX2 As ButtonX
    Private WithEvents Cmbmatcalle As Controls.ComboBoxEx
    Private WithEvents cmbubmedidor As Controls.ComboBoxEx
    Private WithEvents txtctodrenaje As Controls.TextBoxX
    Private WithEvents txtctoagua As Controls.TextBoxX
    Private WithEvents TabControlPanel5 As TabControlPanel
    Private WithEvents TabItem1 As TabItem
    Private WithEvents BtnEliminar As ButtonX
    Private WithEvents BtnAgregar As ButtonX
    Private WithEvents cmbtarifa2 As Controls.ComboBoxEx
    Private WithEvents txtCedulaC As Controls.TextBoxX
    Private WithEvents DTfechadeuda As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents txtDomicilio As Controls.TextBoxX
    Private WithEvents cmbDescuento As Controls.ComboBoxEx
    Private WithEvents cmbCuoValvu As Controls.ComboBoxEx
    Private WithEvents cmbcalle As Controls.ComboBoxEx
    Private WithEvents TabControlPanel6 As TabControlPanel
    Private WithEvents TabItem2 As TabItem
    Friend WithEvents TabControlPanel7 As TabControlPanel
    Friend WithEvents mostrar As DataGridView
    Friend WithEvents tabDocumentos As TabItem
    Friend WithEvents Bar1 As Bar
    Friend WithEvents LabelItem1 As LabelItem
    Friend WithEvents lblnombreexp As LabelItem
    Friend WithEvents LabelItem2 As LabelItem
    Friend WithEvents textDescripcion As TextBoxItem
    Friend WithEvents lblexaminar As LabelItem
    Private WithEvents ButtonX3 As ButtonX
    Friend WithEvents ControlContainerItem1 As ControlContainerItem
    Friend WithEvents btnExaminar As ButtonX
    Friend WithEvents ControlContainerItem2 As ControlContainerItem
    Friend WithEvents ControlContainerItem3 As ControlContainerItem
    Friend WithEvents txtescritura As TextBox
    Friend WithEvents BtnActualizar As ButtonX
    Friend WithEvents ControlContainerItem4 As ControlContainerItem
    Friend WithEvents BtnBorrar As ButtonX
    Friend WithEvents ControlContainerItem5 As ControlContainerItem
    Private WithEvents txtUbicacion As Controls.TextBoxX
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents btnver As ButtonItem
End Class
