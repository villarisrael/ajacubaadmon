<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioMedidor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambioMedidor))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LblTarifa = New System.Windows.Forms.Label
        Me.LblGiro = New System.Windows.Forms.Label
        Me.LblEstadoActual = New System.Windows.Forms.Label
        Me.LblDireccion = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblComunidad = New System.Windows.Forms.Label
        Me.LblCuenta = New System.Windows.Forms.Label
        Me.LblFechaAntes = New System.Windows.Forms.Label
        Me.LblDiametroAntes = New System.Windows.Forms.Label
        Me.LblNumAntes = New System.Windows.Forms.Label
        Me.LblMarcaAntes = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.gpDatosToma = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbMarMed = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmbDiamMed = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.dtInsta = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.txtnumerodemedidor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.TxtUltimaLectura = New DevComponents.Editors.IntegerInput
        Me.cmdGenCob = New DevComponents.DotNetBar.ButtonX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.gpMedAnt = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblLecAnt = New System.Windows.Forms.Label
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1.SuspendLayout()
        Me.gpDatosToma.SuspendLayout()
        CType(Me.dtInsta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUltimaLectura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpMedAnt.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LblTarifa)
        Me.GroupPanel1.Controls.Add(Me.LblGiro)
        Me.GroupPanel1.Controls.Add(Me.LblEstadoActual)
        Me.GroupPanel1.Controls.Add(Me.LblDireccion)
        Me.GroupPanel1.Controls.Add(Me.LblNombre)
        Me.GroupPanel1.Controls.Add(Me.LblComunidad)
        Me.GroupPanel1.Controls.Add(Me.LblCuenta)
        Me.GroupPanel1.Location = New System.Drawing.Point(34, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(553, 107)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(169, 15)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(82, 16)
        Me.LabelX2.TabIndex = 15
        Me.LabelX2.Text = "<font color=""#903C39"">Comunidad: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(190, 77)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(41, 13)
        Me.LabelX6.TabIndex = 15
        Me.LabelX6.Text = "<font color=""#903C39"">Tarifa: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(27, 76)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 15)
        Me.LabelX7.TabIndex = 15
        Me.LabelX7.Text = "<font color=""#903C39"">Estado: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(27, 61)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 15)
        Me.LabelX5.TabIndex = 15
        Me.LabelX5.Text = "<font color=""#903C39"">Giro: </font>"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(27, 46)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 15)
        Me.LabelX4.TabIndex = 15
        Me.LabelX4.Text = "<font color=""#903C39"">Dirección: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(27, 31)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(53, 15)
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "<font color=""#903C39"">Nombre: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(27, 16)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(53, 15)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "<font color=""#903C39"">Cuenta: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblTarifa
        '
        Me.LblTarifa.AutoSize = True
        Me.LblTarifa.BackColor = System.Drawing.Color.Transparent
        Me.LblTarifa.Location = New System.Drawing.Point(237, 77)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(34, 13)
        Me.LblTarifa.TabIndex = 5
        Me.LblTarifa.Text = "Tarifa"
        '
        'LblGiro
        '
        Me.LblGiro.AutoSize = True
        Me.LblGiro.BackColor = System.Drawing.Color.Transparent
        Me.LblGiro.Location = New System.Drawing.Point(108, 62)
        Me.LblGiro.Name = "LblGiro"
        Me.LblGiro.Size = New System.Drawing.Size(26, 13)
        Me.LblGiro.TabIndex = 4
        Me.LblGiro.Text = "Giro"
        '
        'LblEstadoActual
        '
        Me.LblEstadoActual.AutoSize = True
        Me.LblEstadoActual.BackColor = System.Drawing.Color.Transparent
        Me.LblEstadoActual.Location = New System.Drawing.Point(108, 77)
        Me.LblEstadoActual.Name = "LblEstadoActual"
        Me.LblEstadoActual.Size = New System.Drawing.Size(73, 13)
        Me.LblEstadoActual.TabIndex = 6
        Me.LblEstadoActual.Text = "Estado Actual"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LblDireccion.Location = New System.Drawing.Point(108, 47)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 3
        Me.LblDireccion.Text = "Direccion"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Location = New System.Drawing.Point(108, 32)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre"
        '
        'LblComunidad
        '
        Me.LblComunidad.AutoSize = True
        Me.LblComunidad.BackColor = System.Drawing.Color.Transparent
        Me.LblComunidad.Location = New System.Drawing.Point(257, 17)
        Me.LblComunidad.Name = "LblComunidad"
        Me.LblComunidad.Size = New System.Drawing.Size(60, 13)
        Me.LblComunidad.TabIndex = 1
        Me.LblComunidad.Text = "Comunidad"
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblCuenta.Location = New System.Drawing.Point(108, 17)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.LblCuenta.TabIndex = 0
        Me.LblCuenta.Text = "Cuenta"
        '
        'LblFechaAntes
        '
        Me.LblFechaAntes.AutoSize = True
        Me.LblFechaAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaAntes.Location = New System.Drawing.Point(409, 34)
        Me.LblFechaAntes.Name = "LblFechaAntes"
        Me.LblFechaAntes.Size = New System.Drawing.Size(108, 13)
        Me.LblFechaAntes.TabIndex = 14
        Me.LblFechaAntes.Text = "Fecha de instalación:"
        '
        'LblDiametroAntes
        '
        Me.LblDiametroAntes.AutoSize = True
        Me.LblDiametroAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblDiametroAntes.Location = New System.Drawing.Point(140, 34)
        Me.LblDiametroAntes.Name = "LblDiametroAntes"
        Me.LblDiametroAntes.Size = New System.Drawing.Size(110, 13)
        Me.LblDiametroAntes.TabIndex = 12
        Me.LblDiametroAntes.Text = "Diametro del Medidor:"
        '
        'LblNumAntes
        '
        Me.LblNumAntes.AutoSize = True
        Me.LblNumAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblNumAntes.Location = New System.Drawing.Point(409, 12)
        Me.LblNumAntes.Name = "LblNumAntes"
        Me.LblNumAntes.Size = New System.Drawing.Size(103, 13)
        Me.LblNumAntes.TabIndex = 10
        Me.LblNumAntes.Text = "Número de Medidor:"
        '
        'LblMarcaAntes
        '
        Me.LblMarcaAntes.AutoSize = True
        Me.LblMarcaAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblMarcaAntes.Location = New System.Drawing.Point(140, 12)
        Me.LblMarcaAntes.Name = "LblMarcaAntes"
        Me.LblMarcaAntes.Size = New System.Drawing.Size(98, 13)
        Me.LblMarcaAntes.TabIndex = 8
        Me.LblMarcaAntes.Text = "Marca del Medidor:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.ButtonX1.Location = New System.Drawing.Point(199, 407)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.PulseSpeed = 30
        Me.ButtonX1.Size = New System.Drawing.Size(109, 39)
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "Impresión"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(431, 407)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 39)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(315, 407)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 30
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 39)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Motivo del cambio:"
        '
        'TxtMotivo
        '
        '
        '
        '
        Me.TxtMotivo.Border.Class = "TextBoxBorder"
        Me.TxtMotivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotivo.FocusHighlightEnabled = True
        Me.TxtMotivo.Location = New System.Drawing.Point(31, 345)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(553, 56)
        Me.TxtMotivo.TabIndex = 3
        Me.TxtMotivo.WatermarkText = "Escribe el motivo del cambio de estado"
        '
        'gpDatosToma
        '
        Me.gpDatosToma.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosToma.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosToma.Controls.Add(Me.cmbMarMed)
        Me.gpDatosToma.Controls.Add(Me.cmbDiamMed)
        Me.gpDatosToma.Controls.Add(Me.dtInsta)
        Me.gpDatosToma.Controls.Add(Me.txtnumerodemedidor)
        Me.gpDatosToma.Controls.Add(Me.LabelX17)
        Me.gpDatosToma.Controls.Add(Me.LabelX15)
        Me.gpDatosToma.Controls.Add(Me.LabelX16)
        Me.gpDatosToma.Controls.Add(Me.LabelX14)
        Me.gpDatosToma.Location = New System.Drawing.Point(34, 235)
        Me.gpDatosToma.Name = "gpDatosToma"
        Me.gpDatosToma.Size = New System.Drawing.Size(553, 91)
        '
        '
        '
        Me.gpDatosToma.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatosToma.Style.BackColorGradientAngle = 90
        Me.gpDatosToma.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatosToma.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosToma.Style.BorderBottomWidth = 1
        Me.gpDatosToma.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatosToma.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosToma.Style.BorderLeftWidth = 1
        Me.gpDatosToma.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosToma.Style.BorderRightWidth = 1
        Me.gpDatosToma.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosToma.Style.BorderTopWidth = 1
        Me.gpDatosToma.Style.Class = ""
        Me.gpDatosToma.Style.CornerDiameter = 4
        Me.gpDatosToma.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosToma.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosToma.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatosToma.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatosToma.StyleMouseDown.Class = ""
        Me.gpDatosToma.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatosToma.StyleMouseOver.Class = ""
        Me.gpDatosToma.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatosToma.TabIndex = 2
        Me.gpDatosToma.Text = "Datos del nuevo medidor"
        '
        'cmbMarMed
        '
        Me.cmbMarMed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMarMed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMarMed.DisplayMember = "Text"
        Me.cmbMarMed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMarMed.FocusHighlightEnabled = True
        Me.cmbMarMed.FormattingEnabled = True
        Me.cmbMarMed.ItemHeight = 14
        Me.cmbMarMed.Location = New System.Drawing.Point(127, 7)
        Me.cmbMarMed.Name = "cmbMarMed"
        Me.cmbMarMed.Size = New System.Drawing.Size(153, 20)
        Me.cmbMarMed.TabIndex = 0
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
        Me.cmbDiamMed.Location = New System.Drawing.Point(127, 32)
        Me.cmbDiamMed.Name = "cmbDiamMed"
        Me.cmbDiamMed.Size = New System.Drawing.Size(170, 20)
        Me.cmbDiamMed.TabIndex = 2
        '
        'dtInsta
        '
        '
        '
        '
        Me.dtInsta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtInsta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtInsta.ButtonDropDown.Visible = True
        Me.dtInsta.FocusHighlightEnabled = True
        Me.dtInsta.IsPopupCalendarOpen = False
        Me.dtInsta.Location = New System.Drawing.Point(421, 32)
        '
        '
        '
        Me.dtInsta.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtInsta.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtInsta.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtInsta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtInsta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtInsta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtInsta.MonthCalendar.DisplayMonth = New Date(2008, 9, 1, 0, 0, 0, 0)
        Me.dtInsta.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtInsta.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtInsta.MonthCalendar.TodayButtonVisible = True
        Me.dtInsta.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtInsta.Name = "dtInsta"
        Me.dtInsta.Size = New System.Drawing.Size(92, 20)
        Me.dtInsta.TabIndex = 3
        '
        'txtnumerodemedidor
        '
        '
        '
        '
        Me.txtnumerodemedidor.Border.BackColor = System.Drawing.Color.Black
        Me.txtnumerodemedidor.Border.BackColor2 = System.Drawing.SystemColors.ControlText
        Me.txtnumerodemedidor.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash
        Me.txtnumerodemedidor.Border.BorderColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText
        Me.txtnumerodemedidor.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText
        Me.txtnumerodemedidor.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtnumerodemedidor.Border.BorderLeftColor = System.Drawing.SystemColors.ControlText
        Me.txtnumerodemedidor.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtnumerodemedidor.Border.BorderRightColor = System.Drawing.SystemColors.ControlText
        Me.txtnumerodemedidor.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtnumerodemedidor.Border.BorderTopColor = System.Drawing.SystemColors.ControlText
        Me.txtnumerodemedidor.Border.Class = "CrumbBarBackgroundKey"
        Me.txtnumerodemedidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnumerodemedidor.FocusHighlightEnabled = True
        Me.txtnumerodemedidor.Location = New System.Drawing.Point(395, 10)
        Me.txtnumerodemedidor.MaxLength = 15
        Me.txtnumerodemedidor.Name = "txtnumerodemedidor"
        Me.txtnumerodemedidor.Size = New System.Drawing.Size(131, 15)
        Me.txtnumerodemedidor.TabIndex = 1
        Me.txtnumerodemedidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnumerodemedidor.WatermarkText = "Escribe todos los dígitos"
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX17.BackgroundStyle.Class = ""
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(307, 27)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(120, 30)
        Me.LabelX17.TabIndex = 15
        Me.LabelX17.Text = "<font color=""#903C39"">Fecha de instalación: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.Class = ""
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(286, 2)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(120, 30)
        Me.LabelX15.TabIndex = 15
        Me.LabelX15.Text = "<font color=""#903C39"">Número del medidor: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.Class = ""
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(7, 27)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(120, 30)
        Me.LabelX16.TabIndex = 15
        Me.LabelX16.Text = "<font color=""#903C39"">Diámetro del medidor: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.Class = ""
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(7, 2)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(120, 30)
        Me.LabelX14.TabIndex = 15
        Me.LabelX14.Text = "<font color=""#903C39"">Marca del medidor: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtUltimaLectura
        '
        '
        '
        '
        Me.TxtUltimaLectura.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtUltimaLectura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtUltimaLectura.FocusHighlightEnabled = True
        Me.TxtUltimaLectura.Location = New System.Drawing.Point(363, 52)
        Me.TxtUltimaLectura.MaxValue = 999999
        Me.TxtUltimaLectura.MinValue = 0
        Me.TxtUltimaLectura.Name = "TxtUltimaLectura"
        Me.TxtUltimaLectura.ShowUpDown = True
        Me.TxtUltimaLectura.Size = New System.Drawing.Size(149, 20)
        Me.TxtUltimaLectura.TabIndex = 9
        '
        'cmdGenCob
        '
        Me.cmdGenCob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdGenCob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdGenCob.Enabled = False
        Me.cmdGenCob.Image = Global.Administativo.My.Resources.Resources.otroscobros
        Me.cmdGenCob.Location = New System.Drawing.Point(83, 407)
        Me.cmdGenCob.Name = "cmdGenCob"
        Me.cmdGenCob.PulseSpeed = 30
        Me.cmdGenCob.Size = New System.Drawing.Size(109, 39)
        Me.cmdGenCob.TabIndex = 4
        Me.cmdGenCob.Text = "Generar Cobro"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(14, 3)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(100, 30)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "<font color=""#903C39"">Marca del Medidor: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(263, 3)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(125, 30)
        Me.LabelX9.TabIndex = 15
        Me.LabelX9.Text = "<font color=""#903C39"">Número de Medidor:</font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(14, 25)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(120, 30)
        Me.LabelX10.TabIndex = 15
        Me.LabelX10.Text = "<font color=""#903C39"">Diámetro del Medidor: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(263, 25)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(125, 30)
        Me.LabelX11.TabIndex = 15
        Me.LabelX11.Text = "<font color=""#903C39"">Fecha de instalación:</font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'gpMedAnt
        '
        Me.gpMedAnt.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpMedAnt.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpMedAnt.Controls.Add(Me.TxtUltimaLectura)
        Me.gpMedAnt.Controls.Add(Me.lblLecAnt)
        Me.gpMedAnt.Controls.Add(Me.LabelX11)
        Me.gpMedAnt.Controls.Add(Me.LabelX9)
        Me.gpMedAnt.Controls.Add(Me.LabelX12)
        Me.gpMedAnt.Controls.Add(Me.LabelX13)
        Me.gpMedAnt.Controls.Add(Me.LabelX10)
        Me.gpMedAnt.Controls.Add(Me.LabelX8)
        Me.gpMedAnt.Controls.Add(Me.LblMarcaAntes)
        Me.gpMedAnt.Controls.Add(Me.LblNumAntes)
        Me.gpMedAnt.Controls.Add(Me.LblFechaAntes)
        Me.gpMedAnt.Controls.Add(Me.LblDiametroAntes)
        Me.gpMedAnt.Location = New System.Drawing.Point(34, 125)
        Me.gpMedAnt.Name = "gpMedAnt"
        Me.gpMedAnt.Size = New System.Drawing.Size(553, 104)
        '
        '
        '
        Me.gpMedAnt.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpMedAnt.Style.BackColorGradientAngle = 90
        Me.gpMedAnt.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpMedAnt.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMedAnt.Style.BorderBottomWidth = 1
        Me.gpMedAnt.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpMedAnt.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMedAnt.Style.BorderLeftWidth = 1
        Me.gpMedAnt.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMedAnt.Style.BorderRightWidth = 1
        Me.gpMedAnt.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMedAnt.Style.BorderTopWidth = 1
        Me.gpMedAnt.Style.Class = ""
        Me.gpMedAnt.Style.CornerDiameter = 4
        Me.gpMedAnt.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpMedAnt.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpMedAnt.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpMedAnt.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpMedAnt.StyleMouseDown.Class = ""
        Me.gpMedAnt.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpMedAnt.StyleMouseOver.Class = ""
        Me.gpMedAnt.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpMedAnt.TabIndex = 1
        Me.gpMedAnt.Text = "Datos del medidor anterior"
        '
        'lblLecAnt
        '
        Me.lblLecAnt.AutoSize = True
        Me.lblLecAnt.Location = New System.Drawing.Point(140, 56)
        Me.lblLecAnt.Name = "lblLecAnt"
        Me.lblLecAnt.Size = New System.Drawing.Size(85, 13)
        Me.lblLecAnt.TabIndex = 16
        Me.lblLecAnt.Text = "Lectura Anterior:"
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(263, 47)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(88, 30)
        Me.LabelX12.TabIndex = 15
        Me.LabelX12.Text = "<font color=""#903C39"">Última lectura: </font>"
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.Class = ""
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(14, 47)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(120, 30)
        Me.LabelX13.TabIndex = 15
        Me.LabelX13.Text = "<font color=""#903C39"">Lectura Anterior: </font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmCambioMedidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 455)
        Me.Controls.Add(Me.gpMedAnt)
        Me.Controls.Add(Me.cmdGenCob)
        Me.Controls.Add(Me.gpDatosToma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambioMedidor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de medidor"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.gpDatosToma.ResumeLayout(False)
        CType(Me.dtInsta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUltimaLectura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpMedAnt.ResumeLayout(False)
        Me.gpMedAnt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblTarifa As System.Windows.Forms.Label
    Friend WithEvents LblGiro As System.Windows.Forms.Label
    Friend WithEvents LblEstadoActual As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblComunidad As System.Windows.Forms.Label
    Friend WithEvents LblCuenta As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMotivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpDatosToma As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbDiamMed As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dtInsta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtnumerodemedidor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblFechaAntes As System.Windows.Forms.Label
    Friend WithEvents LblDiametroAntes As System.Windows.Forms.Label
    Friend WithEvents LblNumAntes As System.Windows.Forms.Label
    Friend WithEvents LblMarcaAntes As System.Windows.Forms.Label
    Friend WithEvents TxtUltimaLectura As DevComponents.Editors.IntegerInput
    Friend WithEvents cmdGenCob As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbMarMed As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpMedAnt As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblLecAnt As System.Windows.Forms.Label
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
End Class
