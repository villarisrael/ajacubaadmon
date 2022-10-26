<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmelaboracierre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmelaboracierre))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.fec_vto = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.fecini = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.Lblespere = New DevComponents.DotNetBar.LabelX
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.CmdRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LblComunidad = New DevComponents.DotNetBar.LabelX
        Me.CmbComunidad = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ProgressBarcierre1 = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.DTPeriodo = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.GroupPanel1.SuspendLayout()
        CType(Me.fec_vto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 15)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(536, 115)
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
        Me.GroupPanel1.Text = "Atención"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(31, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(483, 75)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = resources.GetString("LabelX4.Text")
        '
        'fec_vto
        '
        '
        '
        '
        Me.fec_vto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fec_vto.ButtonDropDown.Visible = True
        Me.fec_vto.CustomFormat = "dd - MMM - yyyy"
        Me.fec_vto.FocusHighlightEnabled = True
        Me.fec_vto.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.fec_vto.Location = New System.Drawing.Point(256, 276)
        '
        '
        '
        Me.fec_vto.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fec_vto.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fec_vto.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fec_vto.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fec_vto.MonthCalendar.DisplayMonth = New Date(2009, 2, 1, 0, 0, 0, 0)
        Me.fec_vto.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fec_vto.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fec_vto.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fec_vto.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fec_vto.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fec_vto.MonthCalendar.TodayButtonVisible = True
        Me.fec_vto.Name = "fec_vto"
        Me.fec_vto.Size = New System.Drawing.Size(200, 20)
        Me.fec_vto.TabIndex = 8
        '
        'fecini
        '
        '
        '
        '
        Me.fecini.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fecini.ButtonDropDown.Visible = True
        Me.fecini.CustomFormat = "dd - MMM - yyyy"
        Me.fecini.FocusHighlightEnabled = True
        Me.fecini.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.fecini.Location = New System.Drawing.Point(256, 233)
        '
        '
        '
        Me.fecini.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecini.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fecini.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fecini.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fecini.MonthCalendar.DisplayMonth = New Date(2009, 2, 1, 0, 0, 0, 0)
        Me.fecini.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fecini.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecini.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fecini.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fecini.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fecini.MonthCalendar.TodayButtonVisible = True
        Me.fecini.Name = "fecini"
        Me.fecini.Size = New System.Drawing.Size(200, 20)
        Me.fecini.TabIndex = 6
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(132, 323)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(96, 19)
        Me.LabelX1.TabIndex = 9
        Me.LabelX1.Text = "Periodo a  cerrar"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(58, 233)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(170, 18)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Fecha de Aplicación"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(58, 276)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(170, 18)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Fecha de vencimiento"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Lblespere
        '
        Me.Lblespere.BackColor = System.Drawing.Color.Navy
        Me.Lblespere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblespere.ForeColor = System.Drawing.Color.White
        Me.Lblespere.Location = New System.Drawing.Point(54, 365)
        Me.Lblespere.Name = "Lblespere"
        Me.Lblespere.Size = New System.Drawing.Size(465, 21)
        Me.Lblespere.TabIndex = 11
        Me.Lblespere.Text = "Espere por favor ...."
        Me.Lblespere.TextAlignment = System.Drawing.StringAlignment.Center
        Me.Lblespere.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.AcquaLiberVista.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(298, 429)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 14
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.AcquaLiberVista.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(182, 429)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(91, 38)
        Me.BtnAceptar.TabIndex = 13
        Me.BtnAceptar.Text = "Aceptar"
        '
        'LabelX5
        '
        Me.LabelX5.Location = New System.Drawing.Point(182, 192)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(46, 23)
        Me.LabelX5.TabIndex = 3
        Me.LabelX5.Text = "Region"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'CmdRegion
        '
        Me.CmdRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmdRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmdRegion.DisplayMember = "Text"
        Me.CmdRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmdRegion.FocusHighlightEnabled = True
        Me.CmdRegion.FormattingEnabled = True
        Me.CmdRegion.ItemHeight = 14
        Me.CmdRegion.Location = New System.Drawing.Point(256, 192)
        Me.CmdRegion.Name = "CmdRegion"
        Me.CmdRegion.Size = New System.Drawing.Size(243, 20)
        Me.CmdRegion.TabIndex = 4
        '
        'LblComunidad
        '
        Me.LblComunidad.Location = New System.Drawing.Point(166, 145)
        Me.LblComunidad.Name = "LblComunidad"
        Me.LblComunidad.Size = New System.Drawing.Size(62, 23)
        Me.LblComunidad.TabIndex = 1
        Me.LblComunidad.Text = "Comunidad"
        Me.LblComunidad.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.CmbComunidad.Location = New System.Drawing.Point(256, 145)
        Me.CmbComunidad.Name = "CmbComunidad"
        Me.CmbComunidad.Size = New System.Drawing.Size(243, 20)
        Me.CmbComunidad.TabIndex = 2
        '
        'ProgressBarcierre1
        '
        Me.ProgressBarcierre1.Location = New System.Drawing.Point(164, 397)
        Me.ProgressBarcierre1.Name = "ProgressBarcierre1"
        Me.ProgressBarcierre1.Size = New System.Drawing.Size(246, 19)
        Me.ProgressBarcierre1.TabIndex = 12
        Me.ProgressBarcierre1.TextVisible = True
        Me.ProgressBarcierre1.Visible = False
        '
        'DTPeriodo
        '
        '
        '
        '
        Me.DTPeriodo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTPeriodo.ButtonDropDown.Visible = True
        Me.DTPeriodo.CustomFormat = "MMM - yyyy"
        Me.DTPeriodo.FocusHighlightEnabled = True
        Me.DTPeriodo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.DTPeriodo.Location = New System.Drawing.Point(256, 322)
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTPeriodo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTPeriodo.MonthCalendar.DisplayMonth = New Date(2009, 3, 1, 0, 0, 0, 0)
        Me.DTPeriodo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTPeriodo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTPeriodo.MonthCalendar.TodayButtonVisible = True
        Me.DTPeriodo.Name = "DTPeriodo"
        Me.DTPeriodo.Size = New System.Drawing.Size(200, 20)
        Me.DTPeriodo.TabIndex = 10
        '
        'frmelaboracierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.DTPeriodo)
        Me.Controls.Add(Me.ProgressBarcierre1)
        Me.Controls.Add(Me.fec_vto)
        Me.Controls.Add(Me.fecini)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.Lblespere)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.CmdRegion)
        Me.Controls.Add(Me.LblComunidad)
        Me.Controls.Add(Me.CmbComunidad)
        Me.Controls.Add(Me.GroupPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmelaboracierre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elabora el cierre del ciclo de facturación"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.fec_vto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fec_vto As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents fecini As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lblespere As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmdRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblComunidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbComunidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ProgressBarcierre1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents DTPeriodo As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
