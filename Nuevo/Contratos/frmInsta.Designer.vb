<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsta))
        Me.gpDatosUsuario = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblCue = New System.Windows.Forms.Label
        Me.txtCuenta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.gpDatosToma = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbMarMed = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmbDiamMed = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.dtInsta = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnumerodemedidor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.lblc1 = New System.Windows.Forms.Label
        Me.cmdAceptar = New DevComponents.DotNetBar.ButtonX
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX
        Me.gpDatosUsuario.SuspendLayout()
        Me.gpDatosToma.SuspendLayout()
        CType(Me.dtInsta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpDatosUsuario
        '
        Me.gpDatosUsuario.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosUsuario.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosUsuario.Controls.Add(Me.Label1)
        Me.gpDatosUsuario.Controls.Add(Me.txtNombre)
        Me.gpDatosUsuario.Controls.Add(Me.lblCue)
        Me.gpDatosUsuario.Controls.Add(Me.txtCuenta)
        Me.gpDatosUsuario.Location = New System.Drawing.Point(12, 15)
        Me.gpDatosUsuario.Name = "gpDatosUsuario"
        Me.gpDatosUsuario.Size = New System.Drawing.Size(542, 86)
        '
        '
        '
        Me.gpDatosUsuario.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatosUsuario.Style.BackColorGradientAngle = 90
        Me.gpDatosUsuario.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatosUsuario.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosUsuario.Style.BorderBottomWidth = 1
        Me.gpDatosUsuario.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatosUsuario.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosUsuario.Style.BorderLeftWidth = 1
        Me.gpDatosUsuario.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosUsuario.Style.BorderRightWidth = 1
        Me.gpDatosUsuario.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosUsuario.Style.BorderTopWidth = 1
        Me.gpDatosUsuario.Style.CornerDiameter = 4
        Me.gpDatosUsuario.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosUsuario.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosUsuario.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatosUsuario.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpDatosUsuario.TabIndex = 0
        Me.gpDatosUsuario.Text = "Datos del usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(70, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(367, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TabStop = False
        '
        'lblCue
        '
        Me.lblCue.AutoSize = True
        Me.lblCue.BackColor = System.Drawing.Color.Transparent
        Me.lblCue.Location = New System.Drawing.Point(9, 6)
        Me.lblCue.Name = "lblCue"
        Me.lblCue.Size = New System.Drawing.Size(44, 13)
        Me.lblCue.TabIndex = 1
        Me.lblCue.Text = "Cuenta:"
        '
        'txtCuenta
        '
        '
        '
        '
        Me.txtCuenta.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtCuenta.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtCuenta.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtCuenta.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtCuenta.Border.Class = "TextBoxBorder"
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(70, 3)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(135, 20)
        Me.txtCuenta.TabIndex = 0
        Me.txtCuenta.TabStop = False
        '
        'gpDatosToma
        '
        Me.gpDatosToma.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosToma.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosToma.Controls.Add(Me.cmbMarMed)
        Me.gpDatosToma.Controls.Add(Me.cmbDiamMed)
        Me.gpDatosToma.Controls.Add(Me.dtInsta)
        Me.gpDatosToma.Controls.Add(Me.Label3)
        Me.gpDatosToma.Controls.Add(Me.txtnumerodemedidor)
        Me.gpDatosToma.Controls.Add(Me.Label26)
        Me.gpDatosToma.Controls.Add(Me.Label29)
        Me.gpDatosToma.Controls.Add(Me.Label30)
        Me.gpDatosToma.Controls.Add(Me.lblc1)
        Me.gpDatosToma.Location = New System.Drawing.Point(12, 107)
        Me.gpDatosToma.Name = "gpDatosToma"
        Me.gpDatosToma.Size = New System.Drawing.Size(540, 108)
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
        Me.gpDatosToma.Text = "Datos de la toma"
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
        Me.cmbMarMed.Location = New System.Drawing.Point(118, 7)
        Me.cmbMarMed.Name = "cmbMarMed"
        Me.cmbMarMed.Size = New System.Drawing.Size(162, 20)
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
        Me.cmbDiamMed.Location = New System.Drawing.Point(131, 40)
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
        Me.dtInsta.ButtonDropDown.Visible = True
        Me.dtInsta.FocusHighlightEnabled = True
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
        Me.dtInsta.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(307, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Fecha de instalación:"
        '
        'txtnumerodemedidor
        '
        '
        '
        '
        Me.txtnumerodemedidor.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtnumerodemedidor.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtnumerodemedidor.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtnumerodemedidor.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtnumerodemedidor.Border.Class = "TextBoxBorder"
        Me.txtnumerodemedidor.FocusHighlightEnabled = True
        Me.txtnumerodemedidor.Location = New System.Drawing.Point(395, 11)
        Me.txtnumerodemedidor.MaxLength = 20
        Me.txtnumerodemedidor.Name = "txtnumerodemedidor"
        Me.txtnumerodemedidor.Size = New System.Drawing.Size(131, 20)
        Me.txtnumerodemedidor.TabIndex = 1
        Me.txtnumerodemedidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnumerodemedidor.WatermarkText = "Escribe todos los dígitos"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(17, 44)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(110, 13)
        Me.Label26.TabIndex = 61
        Me.Label26.Text = "Diametro del Medidor:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(286, 11)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(103, 13)
        Me.Label29.TabIndex = 60
        Me.Label29.Text = "Número de Medidor:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(17, 11)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 13)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "Marca del Medidor:"
        '
        'lblc1
        '
        Me.lblc1.AutoSize = True
        Me.lblc1.BackColor = System.Drawing.Color.Transparent
        Me.lblc1.ForeColor = System.Drawing.Color.Black
        Me.lblc1.Location = New System.Drawing.Point(-48, -134)
        Me.lblc1.Name = "lblc1"
        Me.lblc1.Size = New System.Drawing.Size(69, 13)
        Me.lblc1.TabIndex = 55
        Me.lblc1.Text = "Entre calle 1:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAceptar.Location = New System.Drawing.Point(339, 231)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.PulseSpeed = 30
        Me.cmdAceptar.Size = New System.Drawing.Size(103, 35)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCancel.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCancel.Location = New System.Drawing.Point(448, 231)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.PulseSpeed = 30
        Me.cmdCancel.Size = New System.Drawing.Size(103, 35)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Terminar"
        '
        'frmInsta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 278)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gpDatosToma)
        Me.Controls.Add(Me.gpDatosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmInsta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instalación de la toma"
        Me.gpDatosUsuario.ResumeLayout(False)
        Me.gpDatosUsuario.PerformLayout()
        Me.gpDatosToma.ResumeLayout(False)
        Me.gpDatosToma.PerformLayout()
        CType(Me.dtInsta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpDatosUsuario As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblCue As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpDatosToma As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtnumerodemedidor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblc1 As System.Windows.Forms.Label
    Friend WithEvents dtInsta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbDiamMed As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbMarMed As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
