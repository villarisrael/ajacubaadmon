<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListOrd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOrd))
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.MC2 = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.MC1 = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.rbMedidor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rbBrigada = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtmedidor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbBrig = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.rbTod = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCancel.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdCancel.Location = New System.Drawing.Point(232, 359)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.PulseSpeed = 30
        Me.cmdCancel.Size = New System.Drawing.Size(153, 39)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "SALIR"
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(38, 359)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.PulseSpeed = 30
        Me.cmdImp.Size = New System.Drawing.Size(153, 39)
        Me.cmdImp.TabIndex = 9
        Me.cmdImp.Text = "IMPRIMIR"
        '
        'ReflectionLabel2
        '
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Location = New System.Drawing.Point(269, 43)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(169, 26)
        Me.ReflectionLabel2.TabIndex = 18
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>FECHA FINAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'ReflectionLabel3
        '
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Location = New System.Drawing.Point(147, 11)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(183, 37)
        Me.ReflectionLabel3.TabIndex = 19
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>RANGO A IMPRIMIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(38, 43)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(169, 26)
        Me.ReflectionLabel1.TabIndex = 20
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>FECHA INICIO</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'MC2
        '
        Me.MC2.AutoSize = True
        '
        '
        '
        Me.MC2.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MC2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderBottomWidth = 1
        Me.MC2.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MC2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderLeftWidth = 1
        Me.MC2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderRightWidth = 1
        Me.MC2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderTopWidth = 1
        Me.MC2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MC2.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MC2.ContainerControlProcessDialogKey = True
        Me.MC2.DisplayMonth = New Date(2008, 11, 1, 0, 0, 0, 0)
        Me.MC2.Location = New System.Drawing.Point(270, 69)
        Me.MC2.Name = "MC2"
        '
        '
        '
        Me.MC2.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.MC2.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.MC2.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.MC2.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MC2.Size = New System.Drawing.Size(170, 131)
        Me.MC2.TabIndex = 1
        Me.MC2.Text = "MonthCalendarAdv1"
        '
        'MC1
        '
        Me.MC1.AutoSize = True
        '
        '
        '
        Me.MC1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MC1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderBottomWidth = 1
        Me.MC1.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MC1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderLeftWidth = 1
        Me.MC1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderRightWidth = 1
        Me.MC1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderTopWidth = 1
        Me.MC1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MC1.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MC1.ContainerControlProcessDialogKey = True
        Me.MC1.DisplayMonth = New Date(2008, 11, 1, 0, 0, 0, 0)
        Me.MC1.Location = New System.Drawing.Point(37, 69)
        Me.MC1.Name = "MC1"
        '
        '
        '
        Me.MC1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.MC1.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.MC1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.MC1.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MC1.Size = New System.Drawing.Size(170, 131)
        Me.MC1.TabIndex = 0
        Me.MC1.Text = "FECHA 1"
        '
        'rbMedidor
        '
        '
        '
        '
        Me.rbMedidor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbMedidor.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbMedidor.Location = New System.Drawing.Point(38, 244)
        Me.rbMedidor.Name = "rbMedidor"
        Me.rbMedidor.Size = New System.Drawing.Size(77, 27)
        Me.rbMedidor.TabIndex = 3
        Me.rbMedidor.Text = "MEDIDOR"
        '
        'rbBrigada
        '
        '
        '
        '
        Me.rbBrigada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbBrigada.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbBrigada.Location = New System.Drawing.Point(38, 274)
        Me.rbBrigada.Name = "rbBrigada"
        Me.rbBrigada.Size = New System.Drawing.Size(77, 27)
        Me.rbBrigada.TabIndex = 5
        Me.rbBrigada.Text = "BRIGADA"
        '
        'txtmedidor
        '
        '
        '
        '
        Me.txtmedidor.Border.Class = "TextBoxBorder"
        Me.txtmedidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmedidor.FocusHighlightEnabled = True
        Me.txtmedidor.Location = New System.Drawing.Point(129, 247)
        Me.txtmedidor.Name = "txtmedidor"
        Me.txtmedidor.Size = New System.Drawing.Size(89, 20)
        Me.txtmedidor.TabIndex = 4
        Me.txtmedidor.Visible = False
        '
        'cmbBrig
        '
        Me.cmbBrig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBrig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBrig.DisplayMember = "Text"
        Me.cmbBrig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBrig.FocusHighlightEnabled = True
        Me.cmbBrig.FormattingEnabled = True
        Me.cmbBrig.ItemHeight = 14
        Me.cmbBrig.Location = New System.Drawing.Point(129, 277)
        Me.cmbBrig.Name = "cmbBrig"
        Me.cmbBrig.Size = New System.Drawing.Size(226, 20)
        Me.cmbBrig.TabIndex = 6
        Me.cmbBrig.Visible = False
        '
        'rbTod
        '
        '
        '
        '
        Me.rbTod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbTod.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbTod.Checked = True
        Me.rbTod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbTod.CheckValue = "Y"
        Me.rbTod.Location = New System.Drawing.Point(38, 214)
        Me.rbTod.Name = "rbTod"
        Me.rbTod.Size = New System.Drawing.Size(77, 27)
        Me.rbTod.TabIndex = 2
        Me.rbTod.Text = "TODOS"
        '
        'frmListOrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 421)
        Me.Controls.Add(Me.rbTod)
        Me.Controls.Add(Me.cmbBrig)
        Me.Controls.Add(Me.txtmedidor)
        Me.Controls.Add(Me.rbBrigada)
        Me.Controls.Add(Me.rbMedidor)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdImp)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Controls.Add(Me.ReflectionLabel3)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.MC2)
        Me.Controls.Add(Me.MC1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmListOrd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE ÓRDENES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents MC2 As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents MC1 As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents rbMedidor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rbBrigada As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rbTod As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtmedidor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbBrig As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
