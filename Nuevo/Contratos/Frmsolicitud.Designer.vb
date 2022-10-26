Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmsolicitud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmsolicitud))
        Me.Tabsolicitud = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gpObserv = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TxtCostoFacti = New DevComponents.Editors.DoubleInput()
        Me.LblCostoSoli = New DevComponents.DotNetBar.LabelX()
        Me.lblobservacion = New System.Windows.Forms.Label()
        Me.chkPagFac = New System.Windows.Forms.CheckBox()
        Me.txtobservaciones = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.chkCroqLoc = New System.Windows.Forms.CheckBox()
        Me.chconsdele = New System.Windows.Forms.CheckBox()
        Me.chkcrede = New System.Windows.Forms.CheckBox()
        Me.ChkPredial1 = New System.Windows.Forms.CheckBox()
        Me.gpDatToma = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CmbCalle = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDomicilio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcatastral = New System.Windows.Forms.MaskedTextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtcp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CmbEstPredio = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtnumint = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LstCalles = New System.Windows.Forms.ListBox()
        Me.txtnumext = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbcolonia = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Cmbcomunidad = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Cmbmunicipio = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblsector = New System.Windows.Forms.Label()
        Me.lblcp = New System.Windows.Forms.Label()
        Me.lblcomunidad = New System.Windows.Forms.Label()
        Me.lblcolonia = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.Cmbsector = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.gpDatUsu = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TxtTelefono3 = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelefono2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtrfc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblrfc = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.MaskedTextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.txtidentificacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtparentesco = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsolicitado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtpropietario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblidentificacion = New System.Windows.Forms.Label()
        Me.lblparentesco = New System.Windows.Forms.Label()
        Me.lblsolicitado = New System.Windows.Forms.Label()
        Me.gpDatSol = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblOrd = New DevComponents.DotNetBar.LabelX()
        Me.lblEst = New DevComponents.DotNetBar.LabelX()
        Me.cmbtipouso = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbcontrato = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblcontrato = New System.Windows.Forms.Label()
        Me.dtfsolicitud = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.txtclave = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Tab1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gpDatFac = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtComp = New System.Windows.Forms.DateTimePicker()
        Me.gpRefTomas = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtref = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CMBCALLE4 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CMBCALLE2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CMBCALLE1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CMBCALLE5 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CMBCALLE3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblcroquis32 = New System.Windows.Forms.Label()
        Me.lblcroquis31 = New System.Windows.Forms.Label()
        Me.lblcroquis30 = New System.Windows.Forms.Label()
        Me.lblcroquis29 = New System.Windows.Forms.Label()
        Me.lblcroquis28 = New System.Windows.Forms.Label()
        Me.lblcroquis27 = New System.Windows.Forms.Label()
        Me.lblcroquis26 = New System.Windows.Forms.Label()
        Me.lblcroquis25 = New System.Windows.Forms.Label()
        Me.lblcroquis16 = New System.Windows.Forms.Label()
        Me.lblcroquis15 = New System.Windows.Forms.Label()
        Me.lblcroquis14 = New System.Windows.Forms.Label()
        Me.lblcroquis13 = New System.Windows.Forms.Label()
        Me.lblcroquis12 = New System.Windows.Forms.Label()
        Me.lblcroquis11 = New System.Windows.Forms.Label()
        Me.lblcroquis10 = New System.Windows.Forms.Label()
        Me.lblcroquis9 = New System.Windows.Forms.Label()
        Me.lblcroquis24 = New System.Windows.Forms.Label()
        Me.lblcroquis23 = New System.Windows.Forms.Label()
        Me.lblcroquis22 = New System.Windows.Forms.Label()
        Me.lblcroquis21 = New System.Windows.Forms.Label()
        Me.lblcroquis20 = New System.Windows.Forms.Label()
        Me.lblcroquis19 = New System.Windows.Forms.Label()
        Me.lblcroquis18 = New System.Windows.Forms.Label()
        Me.lblcroquis17 = New System.Windows.Forms.Label()
        Me.lblcroquis8 = New System.Windows.Forms.Label()
        Me.lblcroquis7 = New System.Windows.Forms.Label()
        Me.lblcroquis6 = New System.Windows.Forms.Label()
        Me.lblcroquis5 = New System.Windows.Forms.Label()
        Me.lblcroquis4 = New System.Windows.Forms.Label()
        Me.lblcroquis3 = New System.Windows.Forms.Label()
        Me.lblcroquis2 = New System.Windows.Forms.Label()
        Me.lblcroquis1 = New System.Windows.Forms.Label()
        Me.lblc5 = New System.Windows.Forms.Label()
        Me.lblc4 = New System.Windows.Forms.Label()
        Me.lblc3 = New System.Windows.Forms.Label()
        Me.lblc2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblc1 = New System.Windows.Forms.Label()
        Me.LblCalleprincipal = New System.Windows.Forms.Label()
        Me.PicCroquis = New System.Windows.Forms.PictureBox()
        Me.LblUbicacionEspecifica = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Referencias = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.lblMen = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnOrdenTrabajo = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        CType(Me.Tabsolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabsolicitud.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpObserv.SuspendLayout()
        CType(Me.TxtCostoFacti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatToma.SuspendLayout()
        Me.gpDatUsu.SuspendLayout()
        Me.gpDatSol.SuspendLayout()
        CType(Me.dtfsolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        Me.gpDatFac.SuspendLayout()
        Me.gpRefTomas.SuspendLayout()
        CType(Me.PicCroquis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rbOp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabsolicitud
        '
        Me.Tabsolicitud.AutoCloseTabs = True
        Me.Tabsolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Tabsolicitud.CanReorderTabs = True
        Me.Tabsolicitud.Controls.Add(Me.TabControlPanel1)
        Me.Tabsolicitud.Controls.Add(Me.Tab1)
        Me.Tabsolicitud.Location = New System.Drawing.Point(0, 58)
        Me.Tabsolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tabsolicitud.Name = "Tabsolicitud"
        Me.Tabsolicitud.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tabsolicitud.SelectedTabIndex = 0
        Me.Tabsolicitud.Size = New System.Drawing.Size(1080, 625)
        Me.Tabsolicitud.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.Tabsolicitud.TabIndex = 1
        Me.Tabsolicitud.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.Tabsolicitud.Tabs.Add(Me.TabItem3)
        Me.Tabsolicitud.Tabs.Add(Me.Referencias)
        Me.Tabsolicitud.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.Controls.Add(Me.gpObserv)
        Me.TabControlPanel1.Controls.Add(Me.gpDatToma)
        Me.TabControlPanel1.Controls.Add(Me.gpDatUsu)
        Me.TabControlPanel1.Controls.Add(Me.gpDatSol)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1080, 599)
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
        'gpObserv
        '
        Me.gpObserv.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpObserv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpObserv.Controls.Add(Me.TxtCostoFacti)
        Me.gpObserv.Controls.Add(Me.LblCostoSoli)
        Me.gpObserv.Controls.Add(Me.lblobservacion)
        Me.gpObserv.Controls.Add(Me.chkPagFac)
        Me.gpObserv.Controls.Add(Me.txtobservaciones)
        Me.gpObserv.Controls.Add(Me.chkCroqLoc)
        Me.gpObserv.Controls.Add(Me.chconsdele)
        Me.gpObserv.Controls.Add(Me.chkcrede)
        Me.gpObserv.Controls.Add(Me.ChkPredial1)
        Me.gpObserv.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpObserv.Location = New System.Drawing.Point(20, 447)
        Me.gpObserv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpObserv.Name = "gpObserv"
        Me.gpObserv.Size = New System.Drawing.Size(1037, 132)
        '
        '
        '
        Me.gpObserv.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpObserv.Style.BackColorGradientAngle = 90
        Me.gpObserv.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpObserv.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserv.Style.BorderBottomWidth = 1
        Me.gpObserv.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpObserv.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserv.Style.BorderLeftWidth = 1
        Me.gpObserv.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserv.Style.BorderRightWidth = 1
        Me.gpObserv.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpObserv.Style.BorderTopWidth = 1
        Me.gpObserv.Style.CornerDiameter = 4
        Me.gpObserv.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpObserv.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpObserv.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpObserv.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpObserv.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpObserv.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpObserv.TabIndex = 3
        Me.gpObserv.Text = "Documentación comprobatoria"
        '
        'TxtCostoFacti
        '
        '
        '
        '
        Me.TxtCostoFacti.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtCostoFacti.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtCostoFacti.FocusHighlightEnabled = True
        Me.TxtCostoFacti.Increment = 1.0R
        Me.TxtCostoFacti.Location = New System.Drawing.Point(551, 82)
        Me.TxtCostoFacti.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCostoFacti.MaxValue = 2000.0R
        Me.TxtCostoFacti.MinValue = 0R
        Me.TxtCostoFacti.Name = "TxtCostoFacti"
        Me.TxtCostoFacti.ShowUpDown = True
        Me.TxtCostoFacti.Size = New System.Drawing.Size(129, 22)
        Me.TxtCostoFacti.TabIndex = 9
        Me.TxtCostoFacti.Value = 220.0R
        '
        'LblCostoSoli
        '
        Me.LblCostoSoli.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblCostoSoli.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblCostoSoli.Location = New System.Drawing.Point(389, 81)
        Me.LblCostoSoli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LblCostoSoli.Name = "LblCostoSoli"
        Me.LblCostoSoli.Size = New System.Drawing.Size(159, 28)
        Me.LblCostoSoli.TabIndex = 8
        Me.LblCostoSoli.Text = "Costo de Factibilidad:"
        '
        'lblobservacion
        '
        Me.lblobservacion.AutoSize = True
        Me.lblobservacion.BackColor = System.Drawing.Color.Transparent
        Me.lblobservacion.Location = New System.Drawing.Point(35, 0)
        Me.lblobservacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblobservacion.Name = "lblobservacion"
        Me.lblobservacion.Size = New System.Drawing.Size(92, 17)
        Me.lblobservacion.TabIndex = 0
        Me.lblobservacion.Text = "Observación:"
        '
        'chkPagFac
        '
        Me.chkPagFac.AutoSize = True
        Me.chkPagFac.BackColor = System.Drawing.Color.Transparent
        Me.chkPagFac.Enabled = False
        Me.chkPagFac.Location = New System.Drawing.Point(39, 86)
        Me.chkPagFac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPagFac.Name = "chkPagFac"
        Me.chkPagFac.Size = New System.Drawing.Size(138, 21)
        Me.chkPagFac.TabIndex = 6
        Me.chkPagFac.Text = "Pago Factibilidad"
        Me.chkPagFac.UseVisualStyleBackColor = False
        '
        'txtobservaciones
        '
        '
        '
        '
        Me.txtobservaciones.Border.Class = "TextBoxBorder"
        Me.txtobservaciones.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtobservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservaciones.FocusHighlightEnabled = True
        Me.txtobservaciones.Location = New System.Drawing.Point(136, -2)
        Me.txtobservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtobservaciones.MaxLength = 100
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(889, 22)
        Me.txtobservaciones.TabIndex = 1
        Me.txtobservaciones.WatermarkText = "Escribe alguna observación sobre la solicitud"
        '
        'chkCroqLoc
        '
        Me.chkCroqLoc.AutoSize = True
        Me.chkCroqLoc.BackColor = System.Drawing.Color.Transparent
        Me.chkCroqLoc.Location = New System.Drawing.Point(389, 58)
        Me.chkCroqLoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkCroqLoc.Name = "chkCroqLoc"
        Me.chkCroqLoc.Size = New System.Drawing.Size(175, 21)
        Me.chkCroqLoc.TabIndex = 5
        Me.chkCroqLoc.Text = "Croquis de localización"
        Me.chkCroqLoc.UseVisualStyleBackColor = False
        '
        'chconsdele
        '
        Me.chconsdele.AutoSize = True
        Me.chconsdele.BackColor = System.Drawing.Color.Transparent
        Me.chconsdele.Location = New System.Drawing.Point(39, 58)
        Me.chconsdele.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chconsdele.Name = "chconsdele"
        Me.chconsdele.Size = New System.Drawing.Size(186, 21)
        Me.chconsdele.TabIndex = 4
        Me.chconsdele.Text = "Constancia del delegado"
        Me.chconsdele.UseVisualStyleBackColor = False
        '
        'chkcrede
        '
        Me.chkcrede.AutoSize = True
        Me.chkcrede.BackColor = System.Drawing.Color.Transparent
        Me.chkcrede.Location = New System.Drawing.Point(389, 30)
        Me.chkcrede.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkcrede.Name = "chkcrede"
        Me.chkcrede.Size = New System.Drawing.Size(222, 21)
        Me.chkcrede.TabIndex = 3
        Me.chkcrede.Text = "Copia de credencial de elector"
        Me.chkcrede.UseVisualStyleBackColor = False
        '
        'ChkPredial1
        '
        Me.ChkPredial1.AutoSize = True
        Me.ChkPredial1.BackColor = System.Drawing.Color.Transparent
        Me.ChkPredial1.Location = New System.Drawing.Point(39, 30)
        Me.ChkPredial1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkPredial1.Name = "ChkPredial1"
        Me.ChkPredial1.Size = New System.Drawing.Size(313, 21)
        Me.ChkPredial1.TabIndex = 2
        Me.ChkPredial1.Text = "Copia del pago predial o constancia del ejido"
        Me.ChkPredial1.UseVisualStyleBackColor = False
        '
        'gpDatToma
        '
        Me.gpDatToma.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatToma.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatToma.Controls.Add(Me.CmbCalle)
        Me.gpDatToma.Controls.Add(Me.txtDomicilio)
        Me.gpDatToma.Controls.Add(Me.txtcatastral)
        Me.gpDatToma.Controls.Add(Me.Label42)
        Me.gpDatToma.Controls.Add(Me.txtcp)
        Me.gpDatToma.Controls.Add(Me.CmbEstPredio)
        Me.gpDatToma.Controls.Add(Me.txtnumint)
        Me.gpDatToma.Controls.Add(Me.LstCalles)
        Me.gpDatToma.Controls.Add(Me.txtnumext)
        Me.gpDatToma.Controls.Add(Me.cmbcolonia)
        Me.gpDatToma.Controls.Add(Me.Cmbcomunidad)
        Me.gpDatToma.Controls.Add(Me.Cmbmunicipio)
        Me.gpDatToma.Controls.Add(Me.Label11)
        Me.gpDatToma.Controls.Add(Me.Label8)
        Me.gpDatToma.Controls.Add(Me.Label7)
        Me.gpDatToma.Controls.Add(Me.lblMunicipio)
        Me.gpDatToma.Controls.Add(Me.lblsector)
        Me.gpDatToma.Controls.Add(Me.lblcp)
        Me.gpDatToma.Controls.Add(Me.lblcomunidad)
        Me.gpDatToma.Controls.Add(Me.lblcolonia)
        Me.gpDatToma.Controls.Add(Me.lblCalle)
        Me.gpDatToma.Controls.Add(Me.Cmbsector)
        Me.gpDatToma.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatToma.Location = New System.Drawing.Point(20, 290)
        Me.gpDatToma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpDatToma.Name = "gpDatToma"
        Me.gpDatToma.Size = New System.Drawing.Size(1037, 154)
        '
        '
        '
        Me.gpDatToma.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatToma.Style.BackColorGradientAngle = 90
        Me.gpDatToma.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatToma.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatToma.Style.BorderBottomWidth = 1
        Me.gpDatToma.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatToma.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatToma.Style.BorderLeftWidth = 1
        Me.gpDatToma.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatToma.Style.BorderRightWidth = 1
        Me.gpDatToma.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatToma.Style.BorderTopWidth = 1
        Me.gpDatToma.Style.CornerDiameter = 4
        Me.gpDatToma.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatToma.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatToma.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatToma.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatToma.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatToma.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatToma.TabIndex = 2
        Me.gpDatToma.Text = "Datos de la ubicación la toma"
        '
        'CmbCalle
        '
        Me.CmbCalle.DisplayMember = "Text"
        Me.CmbCalle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbCalle.FormattingEnabled = True
        Me.CmbCalle.ItemHeight = 14
        Me.CmbCalle.Location = New System.Drawing.Point(126, 89)
        Me.CmbCalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbCalle.Name = "CmbCalle"
        Me.CmbCalle.Size = New System.Drawing.Size(825, 20)
        Me.CmbCalle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmbCalle.TabIndex = 22
        Me.CmbCalle.Visible = False
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
        Me.txtDomicilio.Location = New System.Drawing.Point(116, 73)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilio.MaxLength = 100
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(828, 22)
        Me.txtDomicilio.TabIndex = 21
        Me.txtDomicilio.WatermarkText = "Escribe el domicilio del propietario de la toma"
        '
        'txtcatastral
        '
        Me.txtcatastral.Location = New System.Drawing.Point(856, 43)
        Me.txtcatastral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcatastral.Mask = "##-###-###-AAA"
        Me.txtcatastral.Name = "txtcatastral"
        Me.txtcatastral.Size = New System.Drawing.Size(143, 22)
        Me.txtcatastral.TabIndex = 20
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(747, 48)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(107, 17)
        Me.Label42.TabIndex = 19
        Me.Label42.Text = "Clave Catastral:"
        '
        'txtcp
        '
        '
        '
        '
        Me.txtcp.Border.Class = "TextBoxBorder"
        Me.txtcp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcp.FocusHighlightEnabled = True
        Me.txtcp.Location = New System.Drawing.Point(464, 38)
        Me.txtcp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcp.MaxLength = 5
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(83, 22)
        Me.txtcp.TabIndex = 9
        Me.txtcp.WatermarkText = "Código"
        '
        'CmbEstPredio
        '
        Me.CmbEstPredio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbEstPredio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEstPredio.DisplayMember = "Text"
        Me.CmbEstPredio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbEstPredio.FocusHighlightEnabled = True
        Me.CmbEstPredio.FormattingEnabled = True
        Me.CmbEstPredio.ItemHeight = 14
        Me.CmbEstPredio.Location = New System.Drawing.Point(620, 102)
        Me.CmbEstPredio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbEstPredio.Name = "CmbEstPredio"
        Me.CmbEstPredio.Size = New System.Drawing.Size(197, 20)
        Me.CmbEstPredio.TabIndex = 17
        '
        'txtnumint
        '
        '
        '
        '
        Me.txtnumint.Border.Class = "TextBoxBorder"
        Me.txtnumint.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnumint.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnumint.FocusHighlightEnabled = True
        Me.txtnumint.Location = New System.Drawing.Point(391, 102)
        Me.txtnumint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnumint.MaxLength = 10
        Me.txtnumint.Name = "txtnumint"
        Me.txtnumint.Size = New System.Drawing.Size(112, 22)
        Me.txtnumint.TabIndex = 15
        Me.txtnumint.WatermarkText = "Acepta letras"
        '
        'LstCalles
        '
        Me.LstCalles.FormattingEnabled = True
        Me.LstCalles.ItemHeight = 16
        Me.LstCalles.Location = New System.Drawing.Point(632, 43)
        Me.LstCalles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LstCalles.Name = "LstCalles"
        Me.LstCalles.Size = New System.Drawing.Size(88, 20)
        Me.LstCalles.TabIndex = 18
        Me.LstCalles.Visible = False
        '
        'txtnumext
        '
        '
        '
        '
        Me.txtnumext.Border.Class = "TextBoxBorder"
        Me.txtnumext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnumext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnumext.FocusHighlightEnabled = True
        Me.txtnumext.Location = New System.Drawing.Point(116, 102)
        Me.txtnumext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnumext.MaxLength = 10
        Me.txtnumext.Name = "txtnumext"
        Me.txtnumext.Size = New System.Drawing.Size(151, 22)
        Me.txtnumext.TabIndex = 13
        Me.txtnumext.WatermarkText = "Número de la casa"
        '
        'cmbcolonia
        '
        Me.cmbcolonia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcolonia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcolonia.DisplayMember = "Text"
        Me.cmbcolonia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcolonia.FocusHighlightEnabled = True
        Me.cmbcolonia.FormattingEnabled = True
        Me.cmbcolonia.ItemHeight = 14
        Me.cmbcolonia.Location = New System.Drawing.Point(116, 38)
        Me.cmbcolonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbcolonia.Name = "cmbcolonia"
        Me.cmbcolonia.Size = New System.Drawing.Size(299, 20)
        Me.cmbcolonia.TabIndex = 7
        '
        'Cmbcomunidad
        '
        Me.Cmbcomunidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbcomunidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbcomunidad.DisplayMember = "Text"
        Me.Cmbcomunidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbcomunidad.DropDownWidth = 400
        Me.Cmbcomunidad.FocusHighlightEnabled = True
        Me.Cmbcomunidad.FormattingEnabled = True
        Me.Cmbcomunidad.ItemHeight = 14
        Me.Cmbcomunidad.Location = New System.Drawing.Point(411, 4)
        Me.Cmbcomunidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cmbcomunidad.Name = "Cmbcomunidad"
        Me.Cmbcomunidad.Size = New System.Drawing.Size(268, 20)
        Me.Cmbcomunidad.TabIndex = 5
        '
        'Cmbmunicipio
        '
        Me.Cmbmunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbmunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbmunicipio.DisplayMember = "Text"
        Me.Cmbmunicipio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbmunicipio.FocusHighlightEnabled = True
        Me.Cmbmunicipio.FormattingEnabled = True
        Me.Cmbmunicipio.ItemHeight = 14
        Me.Cmbmunicipio.Location = New System.Drawing.Point(116, 6)
        Me.Cmbmunicipio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cmbmunicipio.Name = "Cmbmunicipio"
        Me.Cmbmunicipio.Size = New System.Drawing.Size(199, 20)
        Me.Cmbmunicipio.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(511, 107)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Estado Predio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(277, 107)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Número Interior"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 107)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Número Exterior:"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.lblMunicipio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMunicipio.Location = New System.Drawing.Point(7, 11)
        Me.lblMunicipio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(71, 17)
        Me.lblMunicipio.TabIndex = 0
        Me.lblMunicipio.Text = "Municipio:"
        '
        'lblsector
        '
        Me.lblsector.AutoSize = True
        Me.lblsector.BackColor = System.Drawing.Color.Transparent
        Me.lblsector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsector.Location = New System.Drawing.Point(688, 11)
        Me.lblsector.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsector.Name = "lblsector"
        Me.lblsector.Size = New System.Drawing.Size(45, 17)
        Me.lblsector.TabIndex = 2
        Me.lblsector.Text = "Zona:"
        Me.lblsector.Visible = False
        '
        'lblcp
        '
        Me.lblcp.AutoSize = True
        Me.lblcp.BackColor = System.Drawing.Color.Transparent
        Me.lblcp.ForeColor = System.Drawing.Color.Black
        Me.lblcp.Location = New System.Drawing.Point(420, 43)
        Me.lblcp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcp.Name = "lblcp"
        Me.lblcp.Size = New System.Drawing.Size(30, 17)
        Me.lblcp.TabIndex = 8
        Me.lblcp.Text = "CP:"
        '
        'lblcomunidad
        '
        Me.lblcomunidad.AutoSize = True
        Me.lblcomunidad.BackColor = System.Drawing.Color.Transparent
        Me.lblcomunidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcomunidad.Location = New System.Drawing.Point(321, 11)
        Me.lblcomunidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcomunidad.Name = "lblcomunidad"
        Me.lblcomunidad.Size = New System.Drawing.Size(83, 17)
        Me.lblcomunidad.TabIndex = 4
        Me.lblcomunidad.Text = "Comunidad:"
        '
        'lblcolonia
        '
        Me.lblcolonia.AutoSize = True
        Me.lblcolonia.BackColor = System.Drawing.Color.Transparent
        Me.lblcolonia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcolonia.Location = New System.Drawing.Point(7, 43)
        Me.lblcolonia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcolonia.Name = "lblcolonia"
        Me.lblcolonia.Size = New System.Drawing.Size(59, 17)
        Me.lblcolonia.TabIndex = 6
        Me.lblcolonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.Transparent
        Me.lblCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCalle.Location = New System.Drawing.Point(7, 75)
        Me.lblCalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(71, 17)
        Me.lblCalle.TabIndex = 10
        Me.lblCalle.Text = "Direccion:"
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
        Me.Cmbsector.Location = New System.Drawing.Point(764, 4)
        Me.Cmbsector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cmbsector.Name = "Cmbsector"
        Me.Cmbsector.Size = New System.Drawing.Size(235, 20)
        Me.Cmbsector.TabIndex = 3
        Me.Cmbsector.Visible = False
        '
        'gpDatUsu
        '
        Me.gpDatUsu.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatUsu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatUsu.Controls.Add(Me.TxtTelefono3)
        Me.gpDatUsu.Controls.Add(Me.TxtTelefono2)
        Me.gpDatUsu.Controls.Add(Me.txtrfc)
        Me.gpDatUsu.Controls.Add(Me.lblrfc)
        Me.gpDatUsu.Controls.Add(Me.TxtTel)
        Me.gpDatUsu.Controls.Add(Me.LblTelefono)
        Me.gpDatUsu.Controls.Add(Me.txtidentificacion)
        Me.gpDatUsu.Controls.Add(Me.txtparentesco)
        Me.gpDatUsu.Controls.Add(Me.txtsolicitado)
        Me.gpDatUsu.Controls.Add(Me.txtpropietario)
        Me.gpDatUsu.Controls.Add(Me.lblnombre)
        Me.gpDatUsu.Controls.Add(Me.lblidentificacion)
        Me.gpDatUsu.Controls.Add(Me.lblparentesco)
        Me.gpDatUsu.Controls.Add(Me.lblsolicitado)
        Me.gpDatUsu.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatUsu.Location = New System.Drawing.Point(21, 108)
        Me.gpDatUsu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpDatUsu.Name = "gpDatUsu"
        Me.gpDatUsu.Size = New System.Drawing.Size(1036, 175)
        '
        '
        '
        Me.gpDatUsu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatUsu.Style.BackColorGradientAngle = 90
        Me.gpDatUsu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatUsu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUsu.Style.BorderBottomWidth = 1
        Me.gpDatUsu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatUsu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUsu.Style.BorderLeftWidth = 1
        Me.gpDatUsu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUsu.Style.BorderRightWidth = 1
        Me.gpDatUsu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatUsu.Style.BorderTopWidth = 1
        Me.gpDatUsu.Style.CornerDiameter = 4
        Me.gpDatUsu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatUsu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatUsu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatUsu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatUsu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatUsu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatUsu.TabIndex = 1
        Me.gpDatUsu.Text = "Datos del usuario"
        '
        'TxtTelefono3
        '
        Me.TxtTelefono3.Location = New System.Drawing.Point(356, 119)
        Me.TxtTelefono3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelefono3.Mask = "(###)-###-####"
        Me.TxtTelefono3.Name = "TxtTelefono3"
        Me.TxtTelefono3.Size = New System.Drawing.Size(111, 22)
        Me.TxtTelefono3.TabIndex = 11
        '
        'TxtTelefono2
        '
        Me.TxtTelefono2.Location = New System.Drawing.Point(236, 119)
        Me.TxtTelefono2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelefono2.Mask = "(###)-###-####"
        Me.TxtTelefono2.Name = "TxtTelefono2"
        Me.TxtTelefono2.Size = New System.Drawing.Size(111, 22)
        Me.TxtTelefono2.TabIndex = 10
        '
        'txtrfc
        '
        '
        '
        '
        Me.txtrfc.Border.Class = "TextBoxBorder"
        Me.txtrfc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtrfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrfc.FocusHighlightEnabled = True
        Me.txtrfc.Location = New System.Drawing.Point(513, 119)
        Me.txtrfc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtrfc.MaxLength = 15
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(165, 22)
        Me.txtrfc.TabIndex = 13
        Me.txtrfc.WatermarkText = "Escribe el Registro Federal de Causantes"
        '
        'lblrfc
        '
        Me.lblrfc.AutoSize = True
        Me.lblrfc.BackColor = System.Drawing.Color.Transparent
        Me.lblrfc.Location = New System.Drawing.Point(469, 124)
        Me.lblrfc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrfc.Name = "lblrfc"
        Me.lblrfc.Size = New System.Drawing.Size(33, 17)
        Me.lblrfc.TabIndex = 12
        Me.lblrfc.Text = "Rfc:"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(116, 119)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTel.Mask = "(###)-###-####"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(111, 22)
        Me.TxtTel.TabIndex = 9
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Location = New System.Drawing.Point(17, 124)
        Me.LblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(68, 17)
        Me.LblTelefono.TabIndex = 8
        Me.LblTelefono.Text = "Telefono:"
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
        Me.txtidentificacion.Location = New System.Drawing.Point(569, 85)
        Me.txtidentificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidentificacion.MaxLength = 55
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Size = New System.Drawing.Size(455, 22)
        Me.txtidentificacion.TabIndex = 7
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
        Me.txtparentesco.Location = New System.Drawing.Point(116, 84)
        Me.txtparentesco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtparentesco.MaxLength = 50
        Me.txtparentesco.Name = "txtparentesco"
        Me.txtparentesco.Size = New System.Drawing.Size(340, 22)
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
        Me.txtsolicitado.Location = New System.Drawing.Point(116, 48)
        Me.txtsolicitado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsolicitado.MaxLength = 100
        Me.txtsolicitado.Name = "txtsolicitado"
        Me.txtsolicitado.Size = New System.Drawing.Size(908, 22)
        Me.txtsolicitado.TabIndex = 3
        Me.txtsolicitado.WatermarkText = "Escribe quien vino a solicitar la toma"
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
        Me.txtpropietario.Location = New System.Drawing.Point(116, 12)
        Me.txtpropietario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpropietario.MaxLength = 100
        Me.txtpropietario.Name = "txtpropietario"
        Me.txtpropietario.Size = New System.Drawing.Size(908, 22)
        Me.txtpropietario.TabIndex = 1
        Me.txtpropietario.WatermarkText = "Escribe el nombre del propietario de la toma"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(17, 17)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(81, 17)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Propietario:"
        '
        'lblidentificacion
        '
        Me.lblidentificacion.AutoSize = True
        Me.lblidentificacion.BackColor = System.Drawing.Color.Transparent
        Me.lblidentificacion.ForeColor = System.Drawing.Color.Black
        Me.lblidentificacion.Location = New System.Drawing.Point(464, 90)
        Me.lblidentificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidentificacion.Name = "lblidentificacion"
        Me.lblidentificacion.Size = New System.Drawing.Size(94, 17)
        Me.lblidentificacion.TabIndex = 6
        Me.lblidentificacion.Text = "Identificación:"
        '
        'lblparentesco
        '
        Me.lblparentesco.AutoSize = True
        Me.lblparentesco.BackColor = System.Drawing.Color.Transparent
        Me.lblparentesco.ForeColor = System.Drawing.Color.Black
        Me.lblparentesco.Location = New System.Drawing.Point(17, 90)
        Me.lblparentesco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblparentesco.Name = "lblparentesco"
        Me.lblparentesco.Size = New System.Drawing.Size(84, 17)
        Me.lblparentesco.TabIndex = 4
        Me.lblparentesco.Text = "Parentesco:"
        '
        'lblsolicitado
        '
        Me.lblsolicitado.AutoSize = True
        Me.lblsolicitado.BackColor = System.Drawing.Color.Transparent
        Me.lblsolicitado.ForeColor = System.Drawing.Color.Black
        Me.lblsolicitado.Location = New System.Drawing.Point(17, 53)
        Me.lblsolicitado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsolicitado.Name = "lblsolicitado"
        Me.lblsolicitado.Size = New System.Drawing.Size(98, 17)
        Me.lblsolicitado.TabIndex = 2
        Me.lblsolicitado.Text = "Solicitado por:"
        '
        'gpDatSol
        '
        Me.gpDatSol.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatSol.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatSol.Controls.Add(Me.lblOrd)
        Me.gpDatSol.Controls.Add(Me.lblEst)
        Me.gpDatSol.Controls.Add(Me.cmbtipouso)
        Me.gpDatSol.Controls.Add(Me.cmbcontrato)
        Me.gpDatSol.Controls.Add(Me.Label14)
        Me.gpDatSol.Controls.Add(Me.lblcontrato)
        Me.gpDatSol.Controls.Add(Me.dtfsolicitud)
        Me.gpDatSol.Controls.Add(Me.lblestado)
        Me.gpDatSol.Controls.Add(Me.lblfecha)
        Me.gpDatSol.Controls.Add(Me.txtclave)
        Me.gpDatSol.Controls.Add(Me.Label4)
        Me.gpDatSol.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatSol.Location = New System.Drawing.Point(20, 12)
        Me.gpDatSol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpDatSol.Name = "gpDatSol"
        Me.gpDatSol.Size = New System.Drawing.Size(1037, 89)
        '
        '
        '
        Me.gpDatSol.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatSol.Style.BackColorGradientAngle = 90
        Me.gpDatSol.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatSol.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatSol.Style.BorderBottomWidth = 1
        Me.gpDatSol.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatSol.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatSol.Style.BorderLeftWidth = 1
        Me.gpDatSol.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatSol.Style.BorderRightWidth = 1
        Me.gpDatSol.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatSol.Style.BorderTopWidth = 1
        Me.gpDatSol.Style.CornerDiameter = 4
        Me.gpDatSol.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatSol.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatSol.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatSol.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatSol.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatSol.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatSol.TabIndex = 0
        Me.gpDatSol.Text = "Datos de la solicitud"
        Me.gpDatSol.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'lblOrd
        '
        Me.lblOrd.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblOrd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblOrd.Location = New System.Drawing.Point(716, 0)
        Me.lblOrd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(141, 27)
        Me.lblOrd.TabIndex = 11
        '
        'lblEst
        '
        Me.lblEst.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        '
        '
        '
        Me.lblEst.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblEst.Location = New System.Drawing.Point(552, 1)
        Me.lblEst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblEst.Name = "lblEst"
        Me.lblEst.Size = New System.Drawing.Size(108, 26)
        Me.lblEst.TabIndex = 10
        Me.lblEst.Text = "EN PROCESO"
        '
        'cmbtipouso
        '
        Me.cmbtipouso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipouso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipouso.DisplayMember = "Text"
        Me.cmbtipouso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipouso.FocusHighlightEnabled = True
        Me.cmbtipouso.FormattingEnabled = True
        Me.cmbtipouso.ItemHeight = 14
        Me.cmbtipouso.Location = New System.Drawing.Point(452, 34)
        Me.cmbtipouso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbtipouso.Name = "cmbtipouso"
        Me.cmbtipouso.Size = New System.Drawing.Size(231, 20)
        Me.cmbtipouso.TabIndex = 9
        '
        'cmbcontrato
        '
        Me.cmbcontrato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrato.DisplayMember = "Text"
        Me.cmbcontrato.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcontrato.FocusHighlightEnabled = True
        Me.cmbcontrato.FormattingEnabled = True
        Me.cmbcontrato.ItemHeight = 14
        Me.cmbcontrato.Location = New System.Drawing.Point(113, 36)
        Me.cmbcontrato.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbcontrato.Name = "cmbcontrato"
        Me.cmbcontrato.Size = New System.Drawing.Size(209, 20)
        Me.cmbcontrato.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(353, 41)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Tipo usuario:"
        '
        'lblcontrato
        '
        Me.lblcontrato.AutoSize = True
        Me.lblcontrato.BackColor = System.Drawing.Color.Transparent
        Me.lblcontrato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcontrato.Location = New System.Drawing.Point(8, 41)
        Me.lblcontrato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontrato.Name = "lblcontrato"
        Me.lblcontrato.Size = New System.Drawing.Size(95, 17)
        Me.lblcontrato.TabIndex = 6
        Me.lblcontrato.Text = "Tipo solicitud:"
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
        Me.dtfsolicitud.Location = New System.Drawing.Point(325, 4)
        Me.dtfsolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.dtfsolicitud.Size = New System.Drawing.Size(111, 22)
        Me.dtfsolicitud.TabIndex = 3
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.Transparent
        Me.lblestado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblestado.Location = New System.Drawing.Point(485, 6)
        Me.lblestado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(56, 17)
        Me.lblestado.TabIndex = 4
        Me.lblestado.Text = "Estado:"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblfecha.Location = New System.Drawing.Point(263, 9)
        Me.lblfecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(51, 17)
        Me.lblfecha.TabIndex = 2
        Me.lblfecha.Text = "Fecha:"
        '
        'txtclave
        '
        '
        '
        '
        Me.txtclave.Border.Class = "TextBoxBorder"
        Me.txtclave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtclave.Location = New System.Drawing.Point(113, 4)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(95, 22)
        Me.txtclave.TabIndex = 1
        Me.txtclave.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Solicitud No:"
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel1
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Generales"
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.gpDatFac)
        Me.Tab1.Controls.Add(Me.gpRefTomas)
        Me.Tab1.DisabledBackColor = System.Drawing.Color.Empty
        Me.Tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab1.Location = New System.Drawing.Point(0, 26)
        Me.Tab1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(1)
        Me.Tab1.Size = New System.Drawing.Size(1080, 599)
        Me.Tab1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Tab1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Tab1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Tab1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Tab1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.Tab1.Style.GradientAngle = 90
        Me.Tab1.TabIndex = 2
        Me.Tab1.TabItem = Me.Referencias
        '
        'gpDatFac
        '
        Me.gpDatFac.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatFac.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatFac.Controls.Add(Me.Label13)
        Me.gpDatFac.Controls.Add(Me.dtComp)
        Me.gpDatFac.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatFac.Location = New System.Drawing.Point(31, 496)
        Me.gpDatFac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpDatFac.Name = "gpDatFac"
        Me.gpDatFac.Size = New System.Drawing.Size(848, 86)
        '
        '
        '
        Me.gpDatFac.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatFac.Style.BackColorGradientAngle = 90
        Me.gpDatFac.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatFac.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatFac.Style.BorderBottomWidth = 1
        Me.gpDatFac.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatFac.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatFac.Style.BorderLeftWidth = 1
        Me.gpDatFac.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatFac.Style.BorderRightWidth = 1
        Me.gpDatFac.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatFac.Style.BorderTopWidth = 1
        Me.gpDatFac.Style.CornerDiameter = 4
        Me.gpDatFac.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatFac.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatFac.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatFac.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatFac.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatFac.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatFac.TabIndex = 1
        Me.gpDatFac.Text = "Datos de la factibilidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(52, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Compromiso: "
        '
        'dtComp
        '
        Me.dtComp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtComp.Location = New System.Drawing.Point(153, 2)
        Me.dtComp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtComp.Name = "dtComp"
        Me.dtComp.Size = New System.Drawing.Size(121, 22)
        Me.dtComp.TabIndex = 1
        '
        'gpRefTomas
        '
        Me.gpRefTomas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpRefTomas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpRefTomas.Controls.Add(Me.txtref)
        Me.gpRefTomas.Controls.Add(Me.CMBCALLE4)
        Me.gpRefTomas.Controls.Add(Me.CMBCALLE2)
        Me.gpRefTomas.Controls.Add(Me.CMBCALLE1)
        Me.gpRefTomas.Controls.Add(Me.CMBCALLE5)
        Me.gpRefTomas.Controls.Add(Me.CMBCALLE3)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis32)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis31)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis30)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis29)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis28)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis27)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis26)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis25)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis16)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis15)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis14)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis13)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis12)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis11)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis10)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis9)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis24)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis23)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis22)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis21)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis20)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis19)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis18)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis17)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis8)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis7)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis6)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis5)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis4)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis3)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis2)
        Me.gpRefTomas.Controls.Add(Me.lblcroquis1)
        Me.gpRefTomas.Controls.Add(Me.lblc5)
        Me.gpRefTomas.Controls.Add(Me.lblc4)
        Me.gpRefTomas.Controls.Add(Me.lblc3)
        Me.gpRefTomas.Controls.Add(Me.lblc2)
        Me.gpRefTomas.Controls.Add(Me.Label6)
        Me.gpRefTomas.Controls.Add(Me.Label5)
        Me.gpRefTomas.Controls.Add(Me.Label3)
        Me.gpRefTomas.Controls.Add(Me.Label2)
        Me.gpRefTomas.Controls.Add(Me.Label1)
        Me.gpRefTomas.Controls.Add(Me.lblc1)
        Me.gpRefTomas.Controls.Add(Me.LblCalleprincipal)
        Me.gpRefTomas.Controls.Add(Me.PicCroquis)
        Me.gpRefTomas.Controls.Add(Me.LblUbicacionEspecifica)
        Me.gpRefTomas.Controls.Add(Me.Label10)
        Me.gpRefTomas.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpRefTomas.Location = New System.Drawing.Point(31, 5)
        Me.gpRefTomas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpRefTomas.Name = "gpRefTomas"
        Me.gpRefTomas.Size = New System.Drawing.Size(1044, 484)
        '
        '
        '
        Me.gpRefTomas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpRefTomas.Style.BackColorGradientAngle = 90
        Me.gpRefTomas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpRefTomas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRefTomas.Style.BorderBottomWidth = 1
        Me.gpRefTomas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpRefTomas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRefTomas.Style.BorderLeftWidth = 1
        Me.gpRefTomas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRefTomas.Style.BorderRightWidth = 1
        Me.gpRefTomas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRefTomas.Style.BorderTopWidth = 1
        Me.gpRefTomas.Style.CornerDiameter = 4
        Me.gpRefTomas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpRefTomas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpRefTomas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpRefTomas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpRefTomas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpRefTomas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpRefTomas.TabIndex = 0
        Me.gpRefTomas.Text = "Referencias de la toma"
        '
        'txtref
        '
        '
        '
        '
        Me.txtref.Border.Class = "TextBoxBorder"
        Me.txtref.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtref.FocusHighlightEnabled = True
        Me.txtref.Location = New System.Drawing.Point(115, 4)
        Me.txtref.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(673, 22)
        Me.txtref.TabIndex = 0
        Me.txtref.WatermarkText = "Escriba las referencias del predio"
        '
        'CMBCALLE4
        '
        Me.CMBCALLE4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE4.DisplayMember = "Text"
        Me.CMBCALLE4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCALLE4.FocusHighlightEnabled = True
        Me.CMBCALLE4.FormattingEnabled = True
        Me.CMBCALLE4.ItemHeight = 14
        Me.CMBCALLE4.Location = New System.Drawing.Point(623, 202)
        Me.CMBCALLE4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CMBCALLE4.Name = "CMBCALLE4"
        Me.CMBCALLE4.Size = New System.Drawing.Size(408, 20)
        Me.CMBCALLE4.TabIndex = 5
        '
        'CMBCALLE2
        '
        Me.CMBCALLE2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCALLE2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE2.DisplayMember = "Text"
        Me.CMBCALLE2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE2.DropDownWidth = 400
        Me.CMBCALLE2.FocusHighlightEnabled = True
        Me.CMBCALLE2.FormattingEnabled = True
        Me.CMBCALLE2.ItemHeight = 14
        Me.CMBCALLE2.Location = New System.Drawing.Point(623, 138)
        Me.CMBCALLE2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CMBCALLE2.Name = "CMBCALLE2"
        Me.CMBCALLE2.Size = New System.Drawing.Size(408, 20)
        Me.CMBCALLE2.TabIndex = 4
        '
        'CMBCALLE1
        '
        Me.CMBCALLE1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCALLE1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE1.DisplayMember = "Text"
        Me.CMBCALLE1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE1.DropDownWidth = 400
        Me.CMBCALLE1.FocusHighlightEnabled = True
        Me.CMBCALLE1.FormattingEnabled = True
        Me.CMBCALLE1.ItemHeight = 14
        Me.CMBCALLE1.Location = New System.Drawing.Point(623, 170)
        Me.CMBCALLE1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CMBCALLE1.Name = "CMBCALLE1"
        Me.CMBCALLE1.Size = New System.Drawing.Size(408, 20)
        Me.CMBCALLE1.TabIndex = 3
        '
        'CMBCALLE5
        '
        Me.CMBCALLE5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCALLE5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCALLE5.DisplayMember = "Text"
        Me.CMBCALLE5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCALLE5.DropDownWidth = 400
        Me.CMBCALLE5.FocusHighlightEnabled = True
        Me.CMBCALLE5.FormattingEnabled = True
        Me.CMBCALLE5.ItemHeight = 14
        Me.CMBCALLE5.Location = New System.Drawing.Point(623, 106)
        Me.CMBCALLE5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CMBCALLE5.Name = "CMBCALLE5"
        Me.CMBCALLE5.Size = New System.Drawing.Size(408, 20)
        Me.CMBCALLE5.TabIndex = 2
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
        Me.CMBCALLE3.Location = New System.Drawing.Point(623, 74)
        Me.CMBCALLE3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CMBCALLE3.Name = "CMBCALLE3"
        Me.CMBCALLE3.Size = New System.Drawing.Size(408, 20)
        Me.CMBCALLE3.TabIndex = 1
        '
        'lblcroquis32
        '
        Me.lblcroquis32.AutoSize = True
        Me.lblcroquis32.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis32.Location = New System.Drawing.Point(468, 263)
        Me.lblcroquis32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis32.Name = "lblcroquis32"
        Me.lblcroquis32.Size = New System.Drawing.Size(24, 17)
        Me.lblcroquis32.TabIndex = 159
        Me.lblcroquis32.Text = "    "
        '
        'lblcroquis31
        '
        Me.lblcroquis31.AutoSize = True
        Me.lblcroquis31.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis31.Location = New System.Drawing.Point(447, 263)
        Me.lblcroquis31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis31.Name = "lblcroquis31"
        Me.lblcroquis31.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis31.TabIndex = 158
        Me.lblcroquis31.Text = "   "
        '
        'lblcroquis30
        '
        Me.lblcroquis30.AutoSize = True
        Me.lblcroquis30.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis30.Location = New System.Drawing.Point(425, 263)
        Me.lblcroquis30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis30.Name = "lblcroquis30"
        Me.lblcroquis30.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis30.TabIndex = 157
        Me.lblcroquis30.Text = "   "
        '
        'lblcroquis29
        '
        Me.lblcroquis29.AutoSize = True
        Me.lblcroquis29.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis29.Location = New System.Drawing.Point(404, 263)
        Me.lblcroquis29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis29.Name = "lblcroquis29"
        Me.lblcroquis29.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis29.TabIndex = 156
        Me.lblcroquis29.Text = "   "
        '
        'lblcroquis28
        '
        Me.lblcroquis28.AutoSize = True
        Me.lblcroquis28.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis28.Location = New System.Drawing.Point(383, 263)
        Me.lblcroquis28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis28.Name = "lblcroquis28"
        Me.lblcroquis28.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis28.TabIndex = 155
        Me.lblcroquis28.Text = "   "
        '
        'lblcroquis27
        '
        Me.lblcroquis27.AutoSize = True
        Me.lblcroquis27.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis27.Location = New System.Drawing.Point(361, 263)
        Me.lblcroquis27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis27.Name = "lblcroquis27"
        Me.lblcroquis27.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis27.TabIndex = 154
        Me.lblcroquis27.Text = "   "
        '
        'lblcroquis26
        '
        Me.lblcroquis26.AutoSize = True
        Me.lblcroquis26.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis26.Location = New System.Drawing.Point(340, 263)
        Me.lblcroquis26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis26.Name = "lblcroquis26"
        Me.lblcroquis26.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis26.TabIndex = 153
        Me.lblcroquis26.Text = "   "
        '
        'lblcroquis25
        '
        Me.lblcroquis25.AutoSize = True
        Me.lblcroquis25.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis25.Location = New System.Drawing.Point(319, 263)
        Me.lblcroquis25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis25.Name = "lblcroquis25"
        Me.lblcroquis25.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis25.TabIndex = 152
        Me.lblcroquis25.Text = "   "
        '
        'lblcroquis16
        '
        Me.lblcroquis16.AutoSize = True
        Me.lblcroquis16.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis16.Location = New System.Drawing.Point(468, 223)
        Me.lblcroquis16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis16.Name = "lblcroquis16"
        Me.lblcroquis16.Size = New System.Drawing.Size(24, 17)
        Me.lblcroquis16.TabIndex = 151
        Me.lblcroquis16.Text = "    "
        '
        'lblcroquis15
        '
        Me.lblcroquis15.AutoSize = True
        Me.lblcroquis15.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis15.Location = New System.Drawing.Point(447, 223)
        Me.lblcroquis15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis15.Name = "lblcroquis15"
        Me.lblcroquis15.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis15.TabIndex = 150
        Me.lblcroquis15.Text = "   "
        '
        'lblcroquis14
        '
        Me.lblcroquis14.AutoSize = True
        Me.lblcroquis14.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis14.Location = New System.Drawing.Point(425, 223)
        Me.lblcroquis14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis14.Name = "lblcroquis14"
        Me.lblcroquis14.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis14.TabIndex = 149
        Me.lblcroquis14.Text = "   "
        '
        'lblcroquis13
        '
        Me.lblcroquis13.AutoSize = True
        Me.lblcroquis13.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis13.Location = New System.Drawing.Point(404, 223)
        Me.lblcroquis13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis13.Name = "lblcroquis13"
        Me.lblcroquis13.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis13.TabIndex = 148
        Me.lblcroquis13.Text = "   "
        '
        'lblcroquis12
        '
        Me.lblcroquis12.AutoSize = True
        Me.lblcroquis12.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis12.Location = New System.Drawing.Point(383, 223)
        Me.lblcroquis12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis12.Name = "lblcroquis12"
        Me.lblcroquis12.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis12.TabIndex = 147
        Me.lblcroquis12.Text = "   "
        '
        'lblcroquis11
        '
        Me.lblcroquis11.AutoSize = True
        Me.lblcroquis11.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis11.Location = New System.Drawing.Point(361, 223)
        Me.lblcroquis11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis11.Name = "lblcroquis11"
        Me.lblcroquis11.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis11.TabIndex = 146
        Me.lblcroquis11.Text = "   "
        '
        'lblcroquis10
        '
        Me.lblcroquis10.AutoSize = True
        Me.lblcroquis10.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis10.Location = New System.Drawing.Point(340, 223)
        Me.lblcroquis10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis10.Name = "lblcroquis10"
        Me.lblcroquis10.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis10.TabIndex = 145
        Me.lblcroquis10.Text = "   "
        '
        'lblcroquis9
        '
        Me.lblcroquis9.AutoSize = True
        Me.lblcroquis9.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis9.Location = New System.Drawing.Point(319, 223)
        Me.lblcroquis9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis9.Name = "lblcroquis9"
        Me.lblcroquis9.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis9.TabIndex = 144
        Me.lblcroquis9.Text = "   "
        '
        'lblcroquis24
        '
        Me.lblcroquis24.AutoSize = True
        Me.lblcroquis24.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis24.Location = New System.Drawing.Point(271, 263)
        Me.lblcroquis24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis24.Name = "lblcroquis24"
        Me.lblcroquis24.Size = New System.Drawing.Size(24, 17)
        Me.lblcroquis24.TabIndex = 143
        Me.lblcroquis24.Text = "    "
        '
        'lblcroquis23
        '
        Me.lblcroquis23.AutoSize = True
        Me.lblcroquis23.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis23.Location = New System.Drawing.Point(249, 263)
        Me.lblcroquis23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis23.Name = "lblcroquis23"
        Me.lblcroquis23.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis23.TabIndex = 142
        Me.lblcroquis23.Text = "   "
        '
        'lblcroquis22
        '
        Me.lblcroquis22.AutoSize = True
        Me.lblcroquis22.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis22.Location = New System.Drawing.Point(228, 263)
        Me.lblcroquis22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis22.Name = "lblcroquis22"
        Me.lblcroquis22.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis22.TabIndex = 141
        Me.lblcroquis22.Text = "   "
        '
        'lblcroquis21
        '
        Me.lblcroquis21.AutoSize = True
        Me.lblcroquis21.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis21.Location = New System.Drawing.Point(207, 263)
        Me.lblcroquis21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis21.Name = "lblcroquis21"
        Me.lblcroquis21.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis21.TabIndex = 140
        Me.lblcroquis21.Text = "   "
        '
        'lblcroquis20
        '
        Me.lblcroquis20.AutoSize = True
        Me.lblcroquis20.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis20.Location = New System.Drawing.Point(185, 263)
        Me.lblcroquis20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis20.Name = "lblcroquis20"
        Me.lblcroquis20.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis20.TabIndex = 139
        Me.lblcroquis20.Text = "   "
        '
        'lblcroquis19
        '
        Me.lblcroquis19.AutoSize = True
        Me.lblcroquis19.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis19.Location = New System.Drawing.Point(164, 263)
        Me.lblcroquis19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis19.Name = "lblcroquis19"
        Me.lblcroquis19.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis19.TabIndex = 138
        Me.lblcroquis19.Text = "   "
        '
        'lblcroquis18
        '
        Me.lblcroquis18.AutoSize = True
        Me.lblcroquis18.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis18.Location = New System.Drawing.Point(143, 263)
        Me.lblcroquis18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis18.Name = "lblcroquis18"
        Me.lblcroquis18.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis18.TabIndex = 137
        Me.lblcroquis18.Text = "   "
        '
        'lblcroquis17
        '
        Me.lblcroquis17.AutoSize = True
        Me.lblcroquis17.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis17.Location = New System.Drawing.Point(121, 263)
        Me.lblcroquis17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis17.Name = "lblcroquis17"
        Me.lblcroquis17.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis17.TabIndex = 136
        Me.lblcroquis17.Text = "   "
        '
        'lblcroquis8
        '
        Me.lblcroquis8.AutoSize = True
        Me.lblcroquis8.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis8.Location = New System.Drawing.Point(271, 223)
        Me.lblcroquis8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis8.Name = "lblcroquis8"
        Me.lblcroquis8.Size = New System.Drawing.Size(24, 17)
        Me.lblcroquis8.TabIndex = 135
        Me.lblcroquis8.Text = "    "
        '
        'lblcroquis7
        '
        Me.lblcroquis7.AutoSize = True
        Me.lblcroquis7.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis7.Location = New System.Drawing.Point(249, 223)
        Me.lblcroquis7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis7.Name = "lblcroquis7"
        Me.lblcroquis7.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis7.TabIndex = 134
        Me.lblcroquis7.Text = "   "
        '
        'lblcroquis6
        '
        Me.lblcroquis6.AutoSize = True
        Me.lblcroquis6.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis6.Location = New System.Drawing.Point(228, 223)
        Me.lblcroquis6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis6.Name = "lblcroquis6"
        Me.lblcroquis6.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis6.TabIndex = 133
        Me.lblcroquis6.Text = "   "
        '
        'lblcroquis5
        '
        Me.lblcroquis5.AutoSize = True
        Me.lblcroquis5.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis5.Location = New System.Drawing.Point(207, 223)
        Me.lblcroquis5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis5.Name = "lblcroquis5"
        Me.lblcroquis5.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis5.TabIndex = 132
        Me.lblcroquis5.Text = "   "
        '
        'lblcroquis4
        '
        Me.lblcroquis4.AutoSize = True
        Me.lblcroquis4.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis4.Location = New System.Drawing.Point(185, 223)
        Me.lblcroquis4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis4.Name = "lblcroquis4"
        Me.lblcroquis4.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis4.TabIndex = 131
        Me.lblcroquis4.Text = "   "
        '
        'lblcroquis3
        '
        Me.lblcroquis3.AutoSize = True
        Me.lblcroquis3.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis3.Location = New System.Drawing.Point(164, 223)
        Me.lblcroquis3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis3.Name = "lblcroquis3"
        Me.lblcroquis3.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis3.TabIndex = 130
        Me.lblcroquis3.Text = "   "
        '
        'lblcroquis2
        '
        Me.lblcroquis2.AutoSize = True
        Me.lblcroquis2.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis2.Location = New System.Drawing.Point(143, 223)
        Me.lblcroquis2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis2.Name = "lblcroquis2"
        Me.lblcroquis2.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis2.TabIndex = 129
        Me.lblcroquis2.Text = "   "
        '
        'lblcroquis1
        '
        Me.lblcroquis1.AutoSize = True
        Me.lblcroquis1.BackColor = System.Drawing.Color.Transparent
        Me.lblcroquis1.Location = New System.Drawing.Point(121, 223)
        Me.lblcroquis1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcroquis1.Name = "lblcroquis1"
        Me.lblcroquis1.Size = New System.Drawing.Size(20, 17)
        Me.lblcroquis1.TabIndex = 128
        Me.lblcroquis1.Text = "   "
        '
        'lblc5
        '
        Me.lblc5.AutoSize = True
        Me.lblc5.BackColor = System.Drawing.Color.White
        Me.lblc5.Location = New System.Drawing.Point(143, 398)
        Me.lblc5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblc5.Name = "lblc5"
        Me.lblc5.Size = New System.Drawing.Size(16, 17)
        Me.lblc5.TabIndex = 126
        Me.lblc5.Text = "5"
        Me.lblc5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblc4
        '
        Me.lblc4.AutoSize = True
        Me.lblc4.BackColor = System.Drawing.Color.White
        Me.lblc4.Location = New System.Drawing.Point(99, 203)
        Me.lblc4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblc4.Name = "lblc4"
        Me.lblc4.Size = New System.Drawing.Size(16, 17)
        Me.lblc4.TabIndex = 126
        Me.lblc4.Text = "4"
        Me.lblc4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblc3
        '
        Me.lblc3.AutoSize = True
        Me.lblc3.BackColor = System.Drawing.Color.White
        Me.lblc3.Location = New System.Drawing.Point(501, 203)
        Me.lblc3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblc3.Name = "lblc3"
        Me.lblc3.Size = New System.Drawing.Size(16, 17)
        Me.lblc3.TabIndex = 126
        Me.lblc3.Text = "3"
        Me.lblc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblc2
        '
        Me.lblc2.AutoSize = True
        Me.lblc2.BackColor = System.Drawing.Color.White
        Me.lblc2.Location = New System.Drawing.Point(300, 151)
        Me.lblc2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblc2.Name = "lblc2"
        Me.lblc2.Size = New System.Drawing.Size(16, 17)
        Me.lblc2.TabIndex = 126
        Me.lblc2.Text = "2"
        Me.lblc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(584, 207)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(584, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(584, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(584, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(584, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "1"
        '
        'lblc1
        '
        Me.lblc1.AutoSize = True
        Me.lblc1.BackColor = System.Drawing.Color.White
        Me.lblc1.Location = New System.Drawing.Point(143, 87)
        Me.lblc1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblc1.Name = "lblc1"
        Me.lblc1.Size = New System.Drawing.Size(16, 17)
        Me.lblc1.TabIndex = 126
        Me.lblc1.Text = "1"
        '
        'LblCalleprincipal
        '
        Me.LblCalleprincipal.AutoSize = True
        Me.LblCalleprincipal.BackColor = System.Drawing.Color.White
        Me.LblCalleprincipal.Location = New System.Drawing.Point(143, 240)
        Me.LblCalleprincipal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCalleprincipal.Name = "LblCalleprincipal"
        Me.LblCalleprincipal.Size = New System.Drawing.Size(97, 17)
        Me.LblCalleprincipal.TabIndex = 126
        Me.LblCalleprincipal.Text = "Calle Principal"
        '
        'PicCroquis
        '
        Me.PicCroquis.BackColor = System.Drawing.SystemColors.Control
        Me.PicCroquis.Image = Global.Administativo.My.Resources.Resources.Croquis
        Me.PicCroquis.Location = New System.Drawing.Point(91, 79)
        Me.PicCroquis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicCroquis.Name = "PicCroquis"
        Me.PicCroquis.Size = New System.Drawing.Size(432, 337)
        Me.PicCroquis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCroquis.TabIndex = 125
        Me.PicCroquis.TabStop = False
        '
        'LblUbicacionEspecifica
        '
        Me.LblUbicacionEspecifica.AutoSize = True
        Me.LblUbicacionEspecifica.BackColor = System.Drawing.Color.Transparent
        Me.LblUbicacionEspecifica.Location = New System.Drawing.Point(4, 31)
        Me.LblUbicacionEspecifica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUbicacionEspecifica.Name = "LblUbicacionEspecifica"
        Me.LblUbicacionEspecifica.Size = New System.Drawing.Size(219, 17)
        Me.LblUbicacionEspecifica.TabIndex = 2
        Me.LblUbicacionEspecifica.Text = "Ubicacion Especifica del domicilio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(7, 6)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Referencias:"
        '
        'Referencias
        '
        Me.Referencias.AttachedControl = Me.Tab1
        Me.Referencias.Name = "Referencias"
        Me.Referencias.Text = "Referencias"
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
        Me.rbOp.Controls.Add(Me.lblMen)
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnAceptar, Me.cmdImp, Me.BtnOrdenTrabajo, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(1096, 57)
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
        'lblMen
        '
        '
        '
        '
        Me.lblMen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMen.Location = New System.Drawing.Point(552, 4)
        Me.lblMen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMen.Name = "lblMen"
        Me.lblMen.Size = New System.Drawing.Size(505, 46)
        Me.lblMen.TabIndex = 17
        Me.lblMen.Text = "<b><font size=""+6""><i>SOLICITUD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Text = "Aceptar"
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
        'BtnOrdenTrabajo
        '
        Me.BtnOrdenTrabajo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnOrdenTrabajo.Image = Global.Administativo.My.Resources.Resources.Ordenes_de_Trabajo
        Me.BtnOrdenTrabajo.Name = "BtnOrdenTrabajo"
        Me.BtnOrdenTrabajo.SubItemsExpandWidth = 14
        Me.BtnOrdenTrabajo.Text = "Orden de Trabajo"
        Me.BtnOrdenTrabajo.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Cerrar"
        '
        'Frmsolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 722)
        Me.Controls.Add(Me.rbOp)
        Me.Controls.Add(Me.Tabsolicitud)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Frmsolicitud"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud"
        CType(Me.Tabsolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabsolicitud.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.gpObserv.ResumeLayout(False)
        Me.gpObserv.PerformLayout()
        CType(Me.TxtCostoFacti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatToma.ResumeLayout(False)
        Me.gpDatToma.PerformLayout()
        Me.gpDatUsu.ResumeLayout(False)
        Me.gpDatUsu.PerformLayout()
        Me.gpDatSol.ResumeLayout(False)
        Me.gpDatSol.PerformLayout()
        CType(Me.dtfsolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        Me.gpDatFac.ResumeLayout(False)
        Me.gpDatFac.PerformLayout()
        Me.gpRefTomas.ResumeLayout(False)
        Me.gpRefTomas.PerformLayout()
        CType(Me.PicCroquis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rbOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabsolicitud As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Tab1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Referencias As DevComponents.DotNetBar.TabItem
    Friend WithEvents LstCalles As System.Windows.Forms.ListBox
    Friend WithEvents gpDatSol As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dtfsolicitud As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents txtclave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gpDatUsu As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtidentificacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtparentesco As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsolicitado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtpropietario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblidentificacion As System.Windows.Forms.Label
    Friend WithEvents lblparentesco As System.Windows.Forms.Label
    Friend WithEvents lblsolicitado As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtrfc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblrfc As System.Windows.Forms.Label
    Friend WithEvents gpDatToma As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtcp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CmbEstPredio As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtnumint As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnumext As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbcolonia As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Cmbcomunidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Cmbmunicipio As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Cmbsector As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblsector As System.Windows.Forms.Label
    Friend WithEvents lblcp As System.Windows.Forms.Label
    Friend WithEvents lblcomunidad As System.Windows.Forms.Label
    Friend WithEvents lblcolonia As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents cmbtipouso As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbcontrato As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblcontrato As System.Windows.Forms.Label
    Friend WithEvents gpRefTomas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblUbicacionEspecifica As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtComp As System.Windows.Forms.DateTimePicker
    Friend WithEvents gpObserv As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblobservacion As System.Windows.Forms.Label
    Friend WithEvents chkPagFac As System.Windows.Forms.CheckBox
    Friend WithEvents txtobservaciones As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkCroqLoc As System.Windows.Forms.CheckBox
    Friend WithEvents chconsdele As System.Windows.Forms.CheckBox
    Friend WithEvents chkcrede As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPredial1 As System.Windows.Forms.CheckBox
    Friend WithEvents gpDatFac As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PicCroquis As System.Windows.Forms.PictureBox
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LblCalleprincipal As System.Windows.Forms.Label
    Friend WithEvents lblcroquis1 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis2 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis8 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis7 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis6 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis5 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis4 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis3 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis32 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis31 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis30 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis29 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis28 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis27 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis26 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis25 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis16 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis15 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis14 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis13 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis12 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis11 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis10 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis9 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis24 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis23 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis22 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis21 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis20 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis19 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis18 As System.Windows.Forms.Label
    Friend WithEvents lblcroquis17 As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtTelefono3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblCostoSoli As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtCostoFacti As DevComponents.Editors.DoubleInput
    Friend WithEvents BtnOrdenTrabajo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CMBCALLE3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CMBCALLE5 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CMBCALLE1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CMBCALLE2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CMBCALLE4 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblMen As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents txtref As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblEst As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblOrd As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblc3 As System.Windows.Forms.Label
    Friend WithEvents lblc2 As System.Windows.Forms.Label
    Friend WithEvents lblc1 As System.Windows.Forms.Label
    Friend WithEvents lblc5 As System.Windows.Forms.Label
    Friend WithEvents lblc4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcatastral As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtDomicilio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CmbCalle As Controls.ComboBoxEx
End Class
