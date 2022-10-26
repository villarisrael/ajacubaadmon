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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LblFechaAntes = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblDiametroAntes = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblNumAntes = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblMarcaAntes = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblTarifa = New System.Windows.Forms.Label
        Me.LblGiro = New System.Windows.Forms.Label
        Me.LblEstadoActual = New System.Windows.Forms.Label
        Me.LblDireccion = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblComunidad = New System.Windows.Forms.Label
        Me.LblCuenta = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.gpDatosToma = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.TxtUltimaLectura = New DevComponents.Editors.IntegerInput
        Me.LblTitUltimaLectura = New System.Windows.Forms.Label
        Me.cmbDiamMed = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.dtInsta = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnumerodemedidor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbMarMed = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.cmdGenCob = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1.SuspendLayout()
        Me.gpDatosToma.SuspendLayout()
        CType(Me.TxtUltimaLectura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInsta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LblFechaAntes)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.LblDiametroAntes)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.LblNumAntes)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.LblMarcaAntes)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.LblTarifa)
        Me.GroupPanel1.Controls.Add(Me.LblGiro)
        Me.GroupPanel1.Controls.Add(Me.LblEstadoActual)
        Me.GroupPanel1.Controls.Add(Me.LblDireccion)
        Me.GroupPanel1.Controls.Add(Me.LblNombre)
        Me.GroupPanel1.Controls.Add(Me.LblComunidad)
        Me.GroupPanel1.Controls.Add(Me.LblCuenta)
        Me.GroupPanel1.Location = New System.Drawing.Point(70, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(553, 214)
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
        Me.GroupPanel1.TabIndex = 0
        '
        'LblFechaAntes
        '
        Me.LblFechaAntes.AutoSize = True
        Me.LblFechaAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaAntes.Location = New System.Drawing.Point(422, 180)
        Me.LblFechaAntes.Name = "LblFechaAntes"
        Me.LblFechaAntes.Size = New System.Drawing.Size(108, 13)
        Me.LblFechaAntes.TabIndex = 14
        Me.LblFechaAntes.Text = "Fecha de instalación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(293, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha de instalación:"
        '
        'LblDiametroAntes
        '
        Me.LblDiametroAntes.AutoSize = True
        Me.LblDiametroAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblDiametroAntes.Location = New System.Drawing.Point(153, 180)
        Me.LblDiametroAntes.Name = "LblDiametroAntes"
        Me.LblDiametroAntes.Size = New System.Drawing.Size(110, 13)
        Me.LblDiametroAntes.TabIndex = 12
        Me.LblDiametroAntes.Text = "Diametro del Medidor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(24, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Diametro del Medidor:"
        '
        'LblNumAntes
        '
        Me.LblNumAntes.AutoSize = True
        Me.LblNumAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblNumAntes.Location = New System.Drawing.Point(422, 147)
        Me.LblNumAntes.Name = "LblNumAntes"
        Me.LblNumAntes.Size = New System.Drawing.Size(103, 13)
        Me.LblNumAntes.TabIndex = 10
        Me.LblNumAntes.Text = "Número de Medidor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(293, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Número de Medidor:"
        '
        'LblMarcaAntes
        '
        Me.LblMarcaAntes.AutoSize = True
        Me.LblMarcaAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblMarcaAntes.Location = New System.Drawing.Point(153, 147)
        Me.LblMarcaAntes.Name = "LblMarcaAntes"
        Me.LblMarcaAntes.Size = New System.Drawing.Size(98, 13)
        Me.LblMarcaAntes.TabIndex = 8
        Me.LblMarcaAntes.Text = "Marca del Medidor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(24, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Marca del Medidor:"
        '
        'LblTarifa
        '
        Me.LblTarifa.AutoSize = True
        Me.LblTarifa.BackColor = System.Drawing.Color.Transparent
        Me.LblTarifa.Location = New System.Drawing.Point(271, 96)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(34, 13)
        Me.LblTarifa.TabIndex = 5
        Me.LblTarifa.Text = "Tarifa"
        '
        'LblGiro
        '
        Me.LblGiro.AutoSize = True
        Me.LblGiro.BackColor = System.Drawing.Color.Transparent
        Me.LblGiro.Location = New System.Drawing.Point(24, 96)
        Me.LblGiro.Name = "LblGiro"
        Me.LblGiro.Size = New System.Drawing.Size(26, 13)
        Me.LblGiro.TabIndex = 4
        Me.LblGiro.Text = "Giro"
        '
        'LblEstadoActual
        '
        Me.LblEstadoActual.AutoSize = True
        Me.LblEstadoActual.BackColor = System.Drawing.Color.Transparent
        Me.LblEstadoActual.Location = New System.Drawing.Point(24, 120)
        Me.LblEstadoActual.Name = "LblEstadoActual"
        Me.LblEstadoActual.Size = New System.Drawing.Size(73, 13)
        Me.LblEstadoActual.TabIndex = 6
        Me.LblEstadoActual.Text = "Estado Actual"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LblDireccion.Location = New System.Drawing.Point(24, 73)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 3
        Me.LblDireccion.Text = "Direccion"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Location = New System.Drawing.Point(24, 47)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre"
        '
        'LblComunidad
        '
        Me.LblComunidad.AutoSize = True
        Me.LblComunidad.BackColor = System.Drawing.Color.Transparent
        Me.LblComunidad.Location = New System.Drawing.Point(88, 18)
        Me.LblComunidad.Name = "LblComunidad"
        Me.LblComunidad.Size = New System.Drawing.Size(60, 13)
        Me.LblComunidad.TabIndex = 1
        Me.LblComunidad.Text = "Comunidad"
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblCuenta.Location = New System.Drawing.Point(24, 18)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.LblCuenta.TabIndex = 0
        Me.LblCuenta.Text = "Cuenta"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.AcquaLiberVista.My.Resources.Resources.imprimir
        Me.ButtonX1.Location = New System.Drawing.Point(280, 474)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(109, 39)
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "Impresión"
        Me.ButtonX1.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.AcquaLiberVista.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(512, 474)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 39)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Salir"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.AcquaLiberVista.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(396, 474)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 39)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 384)
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
        Me.TxtMotivo.Location = New System.Drawing.Point(68, 400)
        Me.TxtMotivo.MaxLength = 400
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
        Me.gpDatosToma.Controls.Add(Me.TxtUltimaLectura)
        Me.gpDatosToma.Controls.Add(Me.LblTitUltimaLectura)
        Me.gpDatosToma.Controls.Add(Me.cmbDiamMed)
        Me.gpDatosToma.Controls.Add(Me.dtInsta)
        Me.gpDatosToma.Controls.Add(Me.Label3)
        Me.gpDatosToma.Controls.Add(Me.txtnumerodemedidor)
        Me.gpDatosToma.Controls.Add(Me.cmbMarMed)
        Me.gpDatosToma.Controls.Add(Me.Label26)
        Me.gpDatosToma.Controls.Add(Me.Label29)
        Me.gpDatosToma.Controls.Add(Me.Label30)
        Me.gpDatosToma.Location = New System.Drawing.Point(70, 232)
        Me.gpDatosToma.Name = "gpDatosToma"
        Me.gpDatosToma.Size = New System.Drawing.Size(553, 137)
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
        Me.gpDatosToma.Style.CornerDiameter = 4
        Me.gpDatosToma.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosToma.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosToma.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatosToma.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpDatosToma.TabIndex = 1
        Me.gpDatosToma.Text = "Datos del medidor"
        '
        'TxtUltimaLectura
        '
        '
        '
        '
        Me.TxtUltimaLectura.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtUltimaLectura.Location = New System.Drawing.Point(131, 79)
        Me.TxtUltimaLectura.Name = "TxtUltimaLectura"
        Me.TxtUltimaLectura.ShowUpDown = True
        Me.TxtUltimaLectura.Size = New System.Drawing.Size(149, 20)
        Me.TxtUltimaLectura.TabIndex = 9
        '
        'LblTitUltimaLectura
        '
        Me.LblTitUltimaLectura.AutoSize = True
        Me.LblTitUltimaLectura.Location = New System.Drawing.Point(17, 79)
        Me.LblTitUltimaLectura.Name = "LblTitUltimaLectura"
        Me.LblTitUltimaLectura.Size = New System.Drawing.Size(75, 13)
        Me.LblTitUltimaLectura.TabIndex = 8
        Me.LblTitUltimaLectura.Text = "Ultima Lectura"
        '
        'cmbDiamMed
        '
        Me.cmbDiamMed.DisplayMember = "Text"
        Me.cmbDiamMed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDiamMed.DropDownHeight = 300
        Me.cmbDiamMed.DropDownWidth = 150
        Me.cmbDiamMed.FormattingEnabled = True
        Me.cmbDiamMed.IntegralHeight = False
        Me.cmbDiamMed.ItemHeight = 14
        Me.cmbDiamMed.Location = New System.Drawing.Point(131, 40)
        Me.cmbDiamMed.Name = "cmbDiamMed"
        Me.cmbDiamMed.Size = New System.Drawing.Size(170, 20)
        Me.cmbDiamMed.TabIndex = 5
        '
        'dtInsta
        '
        '
        '
        '
        Me.dtInsta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtInsta.ButtonDropDown.Visible = True
        Me.dtInsta.Location = New System.Drawing.Point(421, 40)
        '
        '
        '
        Me.dtInsta.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtInsta.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
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
        Me.dtInsta.MonthCalendar.DisplayMonth = New Date(2008, 9, 1, 0, 0, 0, 0)
        Me.dtInsta.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtInsta.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtInsta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtInsta.MonthCalendar.TodayButtonVisible = True
        Me.dtInsta.Name = "dtInsta"
        Me.dtInsta.Size = New System.Drawing.Size(92, 20)
        Me.dtInsta.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(307, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de instalación:"
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
        Me.txtnumerodemedidor.Location = New System.Drawing.Point(395, 11)
        Me.txtnumerodemedidor.MaxLength = 20
        Me.txtnumerodemedidor.Name = "txtnumerodemedidor"
        Me.txtnumerodemedidor.Size = New System.Drawing.Size(131, 13)
        Me.txtnumerodemedidor.TabIndex = 3
        Me.txtnumerodemedidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnumerodemedidor.WatermarkText = "Escribe todos los digitos"
        '
        'cmbMarMed
        '
        Me.cmbMarMed.FormattingEnabled = True
        Me.cmbMarMed.Location = New System.Drawing.Point(131, 7)
        Me.cmbMarMed.Name = "cmbMarMed"
        Me.cmbMarMed.Size = New System.Drawing.Size(149, 21)
        Me.cmbMarMed.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(17, 44)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(110, 13)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Diametro del Medidor:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(286, 11)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(103, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Número de Medidor:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(17, 11)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Marca del Medidor:"
        '
        'cmdGenCob
        '
        Me.cmdGenCob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdGenCob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdGenCob.Enabled = False
        Me.cmdGenCob.Image = Global.AcquaLiberVista.My.Resources.Resources.otroscobros
        Me.cmdGenCob.Location = New System.Drawing.Point(164, 474)
        Me.cmdGenCob.Name = "cmdGenCob"
        Me.cmdGenCob.Size = New System.Drawing.Size(109, 39)
        Me.cmdGenCob.TabIndex = 9
        Me.cmdGenCob.Text = "Generar Cobro"
        '
        'FrmCambioMedidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 535)
        Me.Controls.Add(Me.cmdGenCob)
        Me.Controls.Add(Me.gpDatosToma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "FrmCambioMedidor"
        Me.Text = "Cambio de medidor"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.gpDatosToma.ResumeLayout(False)
        Me.gpDatosToma.PerformLayout()
        CType(Me.TxtUltimaLectura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInsta, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnumerodemedidor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbMarMed As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents LblFechaAntes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDiametroAntes As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblNumAntes As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblMarcaAntes As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblTitUltimaLectura As System.Windows.Forms.Label
    Friend WithEvents TxtUltimaLectura As DevComponents.Editors.IntegerInput
    Friend WithEvents cmdGenCob As DevComponents.DotNetBar.ButtonX
End Class
