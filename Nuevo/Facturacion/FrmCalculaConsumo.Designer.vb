Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalculaConsumo
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
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCalcular = New DevComponents.DotNetBar.ButtonX()
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.txtAn = New System.Windows.Forms.TextBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.CmdRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.PB = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(317, 267)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCalcular.Image = Global.Administativo.My.Resources.Resources.calc
        Me.BtnCalcular.Location = New System.Drawing.Point(220, 267)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(91, 38)
        Me.BtnCalcular.TabIndex = 3
        Me.BtnCalcular.Text = "Calcular"
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(110, 11)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(216, 44)
        Me.LblTitulo.TabIndex = 5
        Me.LblTitulo.Text = "<b><font size=""+6"">CALCULAR CONSUMO</font></b>"
        '
        'txtAn
        '
        Me.txtAn.Location = New System.Drawing.Point(172, 184)
        Me.txtAn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAn.Name = "txtAn"
        Me.txtAn.Size = New System.Drawing.Size(46, 20)
        Me.txtAn.TabIndex = 18
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC"})
        Me.cmbmes.Location = New System.Drawing.Point(107, 183)
        Me.cmbmes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(61, 21)
        Me.cmbmes.TabIndex = 17
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(59, 180)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(42, 23)
        Me.LabelX2.TabIndex = 16
        Me.LabelX2.Text = "FECHA:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.CmbRuta)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.CmdRegion)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 61)
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
        Me.GroupPanel1.TabIndex = 19
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
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(17, 32)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(28, 23)
        Me.LabelX1.TabIndex = 18
        Me.LabelX1.Text = "Ruta"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(17, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(45, 23)
        Me.LabelX3.TabIndex = 17
        Me.LabelX3.Text = "Region"
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
        'PB
        '
        '
        '
        '
        Me.PB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PB.Location = New System.Drawing.Point(22, 225)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(480, 23)
        Me.PB.TabIndex = 20
        Me.PB.Text = "ProgressBarX1"
        '
        'FrmCalculaConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 343)
        Me.ControlBox = False
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.txtAn)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmCalculaConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcula Consumo"
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCalcular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents txtAn As System.Windows.Forms.TextBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmdRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PB As Controls.ProgressBarX
End Class
