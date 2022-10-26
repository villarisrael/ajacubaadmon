<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepListadoDeudores
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.btnGenerar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.chkmasde3 = New System.Windows.Forms.CheckBox()
        Me.CmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CmdRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmbComunidades = New System.Windows.Forms.ComboBox()
        Me.lblComunidad = New DevComponents.DotNetBar.LabelX()
        Me.rbruta = New System.Windows.Forms.RadioButton()
        Me.rbComunidad = New System.Windows.Forms.RadioButton()
        Me.CBCarteraVencida = New System.Windows.Forms.CheckBox()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGenerar.Image = Global.Administativo.My.Resources.Resources.run
        Me.btnGenerar.Location = New System.Drawing.Point(261, 328)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(95, 35)
        Me.btnGenerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.btnCancelar.Location = New System.Drawing.Point(396, 328)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 35)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.chkmasde3)
        Me.GroupPanel1.Controls.Add(Me.CmbRuta)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.CmdRegion)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 44)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(469, 103)
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
        Me.GroupPanel1.TabIndex = 4
        Me.GroupPanel1.Text = "Ruta"
        '
        'chkmasde3
        '
        Me.chkmasde3.AutoSize = True
        Me.chkmasde3.Location = New System.Drawing.Point(315, 58)
        Me.chkmasde3.Name = "chkmasde3"
        Me.chkmasde3.Size = New System.Drawing.Size(103, 17)
        Me.chkmasde3.TabIndex = 8
        Me.chkmasde3.Text = "Mas de 3 meses"
        Me.chkmasde3.UseVisualStyleBackColor = True
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
        Me.LabelX2.Location = New System.Drawing.Point(45, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
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
        Me.LabelX1.Location = New System.Drawing.Point(45, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
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
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cmbComunidades)
        Me.GroupPanel2.Controls.Add(Me.lblComunidad)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(14, 216)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(469, 100)
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
        Me.GroupPanel2.TabIndex = 5
        Me.GroupPanel2.Text = "Comunidad"
        '
        'cmbComunidades
        '
        Me.cmbComunidades.FormattingEnabled = True
        Me.cmbComunidades.Location = New System.Drawing.Point(111, 26)
        Me.cmbComunidades.Name = "cmbComunidades"
        Me.cmbComunidades.Size = New System.Drawing.Size(297, 21)
        Me.cmbComunidades.TabIndex = 5
        '
        'lblComunidad
        '
        '
        '
        '
        Me.lblComunidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblComunidad.Location = New System.Drawing.Point(21, 24)
        Me.lblComunidad.Name = "lblComunidad"
        Me.lblComunidad.Size = New System.Drawing.Size(66, 23)
        Me.lblComunidad.TabIndex = 4
        Me.lblComunidad.Text = "Comunidad:"
        '
        'rbruta
        '
        Me.rbruta.AutoSize = True
        Me.rbruta.Checked = True
        Me.rbruta.Location = New System.Drawing.Point(26, 13)
        Me.rbruta.Name = "rbruta"
        Me.rbruta.Size = New System.Drawing.Size(48, 17)
        Me.rbruta.TabIndex = 6
        Me.rbruta.TabStop = True
        Me.rbruta.Text = "Ruta"
        Me.rbruta.UseVisualStyleBackColor = True
        '
        'rbComunidad
        '
        Me.rbComunidad.AutoSize = True
        Me.rbComunidad.Location = New System.Drawing.Point(26, 193)
        Me.rbComunidad.Name = "rbComunidad"
        Me.rbComunidad.Size = New System.Drawing.Size(78, 17)
        Me.rbComunidad.TabIndex = 7
        Me.rbComunidad.Text = "Comunidad"
        Me.rbComunidad.UseVisualStyleBackColor = True
        '
        'CBCarteraVencida
        '
        Me.CBCarteraVencida.AutoSize = True
        Me.CBCarteraVencida.Location = New System.Drawing.Point(382, 179)
        Me.CBCarteraVencida.Name = "CBCarteraVencida"
        Me.CBCarteraVencida.Size = New System.Drawing.Size(99, 17)
        Me.CBCarteraVencida.TabIndex = 8
        Me.CBCarteraVencida.Text = "CarteraVencida"
        Me.CBCarteraVencida.UseVisualStyleBackColor = True
        '
        'frmRepListadoDeudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 365)
        Me.Controls.Add(Me.CBCarteraVencida)
        Me.Controls.Add(Me.rbComunidad)
        Me.Controls.Add(Me.rbruta)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGenerar)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "frmRepListadoDeudores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Deudores"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbComunidades As System.Windows.Forms.ComboBox
    Friend WithEvents lblComunidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmdRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents rbruta As System.Windows.Forms.RadioButton
    Friend WithEvents rbComunidad As System.Windows.Forms.RadioButton
    Friend WithEvents chkmasde3 As System.Windows.Forms.CheckBox
    Friend WithEvents CBCarteraVencida As CheckBox
End Class
