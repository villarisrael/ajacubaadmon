<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcalculasaldo
    Inherits System.Windows.Forms.Form

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
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PB = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCalcular = New DevComponents.DotNetBar.ButtonX()
        Me.rbComunidad = New System.Windows.Forms.RadioButton()
        Me.rbruta = New System.Windows.Forms.RadioButton()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmbComunidades = New System.Windows.Forms.ComboBox()
        Me.lblComunidad = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CmdRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.rbCuenta = New System.Windows.Forms.RadioButton()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.iiCuenta = New DevComponents.Editors.IntegerInput()
        Me.lblCuenta = New DevComponents.DotNetBar.LabelX()
        Me.rbtodos = New System.Windows.Forms.RadioButton()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.iiCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(12, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(354, 44)
        Me.LblTitulo.TabIndex = 12
        Me.LblTitulo.Text = "<b><font size=""+6"">CALCULAR SALDOS</font></b>"
        '
        'PB
        '
        '
        '
        '
        Me.PB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PB.Location = New System.Drawing.Point(19, 436)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(438, 22)
        Me.PB.TabIndex = 9
        Me.PB.TabStop = False
        Me.PB.TextVisible = True
        Me.PB.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(372, 379)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCalcular.Image = Global.Administativo.My.Resources.Resources.calc
        Me.BtnCalcular.Location = New System.Drawing.Point(275, 379)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(91, 38)
        Me.BtnCalcular.TabIndex = 10
        Me.BtnCalcular.Text = "Calcular"
        '
        'rbComunidad
        '
        Me.rbComunidad.AutoSize = True
        Me.rbComunidad.Location = New System.Drawing.Point(12, 181)
        Me.rbComunidad.Name = "rbComunidad"
        Me.rbComunidad.Size = New System.Drawing.Size(78, 17)
        Me.rbComunidad.TabIndex = 16
        Me.rbComunidad.Text = "Comunidad"
        Me.rbComunidad.UseVisualStyleBackColor = True
        '
        'rbruta
        '
        Me.rbruta.AutoSize = True
        Me.rbruta.Checked = True
        Me.rbruta.Location = New System.Drawing.Point(12, 62)
        Me.rbruta.Name = "rbruta"
        Me.rbruta.Size = New System.Drawing.Size(48, 17)
        Me.rbruta.TabIndex = 15
        Me.rbruta.TabStop = True
        Me.rbruta.Text = "Ruta"
        Me.rbruta.UseVisualStyleBackColor = True
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cmbComunidades)
        Me.GroupPanel2.Controls.Add(Me.lblComunidad)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 191)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(445, 72)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 14
        Me.GroupPanel2.Text = "Comunidad"
        '
        'cmbComunidades
        '
        Me.cmbComunidades.FormattingEnabled = True
        Me.cmbComunidades.Location = New System.Drawing.Point(126, 10)
        Me.cmbComunidades.Name = "cmbComunidades"
        Me.cmbComunidades.Size = New System.Drawing.Size(292, 21)
        Me.cmbComunidades.TabIndex = 5
        '
        'lblComunidad
        '
        Me.lblComunidad.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblComunidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblComunidad.Location = New System.Drawing.Point(17, 8)
        Me.lblComunidad.Name = "lblComunidad"
        Me.lblComunidad.Size = New System.Drawing.Size(66, 23)
        Me.lblComunidad.TabIndex = 4
        Me.lblComunidad.Text = "Comunidad:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.CmbRuta)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.CmdRegion)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 73)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(445, 89)
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 13
        Me.GroupPanel1.Text = "Ruta"
        '
        'CmbRuta
        '
        Me.CmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRuta.DisplayMember = "Text"
        Me.CmbRuta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbRuta.FocusHighlightEnabled = True
        Me.CmbRuta.FormattingEnabled = True
        Me.CmbRuta.ItemHeight = 14
        Me.CmbRuta.Location = New System.Drawing.Point(126, 32)
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(292, 20)
        Me.CmbRuta.TabIndex = 19
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(17, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(28, 23)
        Me.LabelX2.TabIndex = 18
        Me.LabelX2.Text = "Ruta"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(17, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(45, 23)
        Me.LabelX1.TabIndex = 17
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
        Me.CmdRegion.Location = New System.Drawing.Point(126, 6)
        Me.CmdRegion.Name = "CmdRegion"
        Me.CmdRegion.Size = New System.Drawing.Size(292, 20)
        Me.CmdRegion.TabIndex = 16
        '
        'rbCuenta
        '
        Me.rbCuenta.AutoSize = True
        Me.rbCuenta.Location = New System.Drawing.Point(20, 292)
        Me.rbCuenta.Name = "rbCuenta"
        Me.rbCuenta.Size = New System.Drawing.Size(59, 17)
        Me.rbCuenta.TabIndex = 17
        Me.rbCuenta.Text = "Cuenta"
        Me.rbCuenta.UseVisualStyleBackColor = True
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.iiCuenta)
        Me.GroupPanel3.Controls.Add(Me.lblCuenta)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(12, 303)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(233, 61)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 15
        Me.GroupPanel3.Text = "Cuenta"
        '
        'iiCuenta
        '
        '
        '
        '
        Me.iiCuenta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.iiCuenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.iiCuenta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.iiCuenta.Location = New System.Drawing.Point(126, 11)
        Me.iiCuenta.Name = "iiCuenta"
        Me.iiCuenta.ShowUpDown = True
        Me.iiCuenta.Size = New System.Drawing.Size(94, 20)
        Me.iiCuenta.TabIndex = 5
        '
        'lblCuenta
        '
        Me.lblCuenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblCuenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCuenta.Location = New System.Drawing.Point(17, 8)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(66, 23)
        Me.lblCuenta.TabIndex = 4
        Me.lblCuenta.Text = "Cuenta:"
        '
        'rbtodos
        '
        Me.rbtodos.AutoSize = True
        Me.rbtodos.Location = New System.Drawing.Point(275, 292)
        Me.rbtodos.Name = "rbtodos"
        Me.rbtodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtodos.TabIndex = 18
        Me.rbtodos.Text = "Todos"
        Me.rbtodos.UseVisualStyleBackColor = True
        '
        'frmcalculasaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 470)
        Me.Controls.Add(Me.rbtodos)
        Me.Controls.Add(Me.rbCuenta)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.rbComunidad)
        Me.Controls.Add(Me.rbruta)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.MaximizeBox = False
        Me.Name = "frmcalculasaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcula los saldos de la gente"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.iiCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PB As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCalcular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rbComunidad As System.Windows.Forms.RadioButton
    Friend WithEvents rbruta As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbComunidades As System.Windows.Forms.ComboBox
    Friend WithEvents lblComunidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmdRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents rbCuenta As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents iiCuenta As DevComponents.Editors.IntegerInput
    Friend WithEvents lblCuenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbtodos As System.Windows.Forms.RadioButton
End Class
