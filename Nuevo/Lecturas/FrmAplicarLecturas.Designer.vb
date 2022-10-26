<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAplicarLecturas
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
        Me.LblFecha = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.CmdRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX
        Me.BtnAplicar = New DevComponents.DotNetBar.ButtonX
        Me.LblComunidad = New DevComponents.DotNetBar.LabelX
        Me.CmbComunidad = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.DTMES = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel
        CType(Me.DTMES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(97, 131)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(112, 23)
        Me.LblFecha.TabIndex = 8
        Me.LblFecha.Text = "Periodo de la Lectura"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(98, 102)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Region"
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
        Me.CmdRegion.Location = New System.Drawing.Point(196, 102)
        Me.CmdRegion.Name = "CmdRegion"
        Me.CmdRegion.Size = New System.Drawing.Size(243, 20)
        Me.CmdRegion.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(283, 191)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnAplicar
        '
        Me.BtnAplicar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAplicar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAplicar.Image = Global.Administativo.My.Resources.Resources.bookmarks_list_add
        Me.BtnAplicar.Location = New System.Drawing.Point(168, 191)
        Me.BtnAplicar.Name = "BtnAplicar"
        Me.BtnAplicar.Size = New System.Drawing.Size(93, 38)
        Me.BtnAplicar.TabIndex = 3
        Me.BtnAplicar.Text = "Aplicar"
        '
        'LblComunidad
        '
        Me.LblComunidad.Location = New System.Drawing.Point(98, 73)
        Me.LblComunidad.Name = "LblComunidad"
        Me.LblComunidad.Size = New System.Drawing.Size(75, 23)
        Me.LblComunidad.TabIndex = 6
        Me.LblComunidad.Text = "Comunidad"
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
        Me.CmbComunidad.Location = New System.Drawing.Point(196, 73)
        Me.CmbComunidad.Name = "CmbComunidad"
        Me.CmbComunidad.Size = New System.Drawing.Size(243, 20)
        Me.CmbComunidad.TabIndex = 0
        '
        'DTMES
        '
        '
        '
        '
        Me.DTMES.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTMES.ButtonDropDown.Visible = True
        Me.DTMES.CustomFormat = "MMM - yy"
        Me.DTMES.FocusHighlightEnabled = True
        Me.DTMES.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.DTMES.Location = New System.Drawing.Point(239, 131)
        '
        '
        '
        Me.DTMES.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTMES.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTMES.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTMES.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTMES.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTMES.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTMES.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTMES.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTMES.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTMES.MonthCalendar.DisplayMonth = New Date(2009, 2, 1, 0, 0, 0, 0)
        Me.DTMES.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTMES.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTMES.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTMES.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTMES.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTMES.MonthCalendar.TodayButtonVisible = True
        Me.DTMES.Name = "DTMES"
        Me.DTMES.Size = New System.Drawing.Size(200, 20)
        Me.DTMES.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Location = New System.Drawing.Point(160, 12)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(216, 44)
        Me.LblTitulo.TabIndex = 5
        Me.LblTitulo.Text = "<b><font size=""+6"">APLICAR LECTURAS</font></b>"
        '
        'FrmAplicarLecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.DTMES)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.CmdRegion)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAplicar)
        Me.Controls.Add(Me.LblComunidad)
        Me.Controls.Add(Me.CmbComunidad)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAplicarLecturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicar Lecturas"
        CType(Me.DTMES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmdRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAplicar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblComunidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbComunidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents DTMES As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
End Class
