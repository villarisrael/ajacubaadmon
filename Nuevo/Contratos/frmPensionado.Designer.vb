<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPensionado
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmbReg = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.LabelX3)
        Me.GroupPanel3.Controls.Add(Me.cmbRuta)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.cmbReg)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(12, 26)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(435, 95)
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
        Me.GroupPanel3.TabIndex = 1
        Me.GroupPanel3.Text = "Ubicacion"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(214, 19)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(32, 20)
        Me.LabelX3.TabIndex = 33
        Me.LabelX3.Text = "Ruta:"
        '
        'cmbRuta
        '
        Me.cmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRuta.DisplayMember = "Text"
        Me.cmbRuta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRuta.FocusHighlightEnabled = True
        Me.cmbRuta.FormattingEnabled = True
        Me.cmbRuta.ItemHeight = 14
        Me.cmbRuta.Location = New System.Drawing.Point(252, 19)
        Me.cmbRuta.Name = "cmbRuta"
        Me.cmbRuta.Size = New System.Drawing.Size(146, 20)
        Me.cmbRuta.TabIndex = 3
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 19)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(43, 20)
        Me.LabelX2.TabIndex = 32
        Me.LabelX2.Text = "Región:"
        '
        'cmbReg
        '
        Me.cmbReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReg.DisplayMember = "Text"
        Me.cmbReg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReg.FocusHighlightEnabled = True
        Me.cmbReg.FormattingEnabled = True
        Me.cmbReg.ItemHeight = 14
        Me.cmbReg.Location = New System.Drawing.Point(62, 19)
        Me.cmbReg.Name = "cmbReg"
        Me.cmbReg.Size = New System.Drawing.Size(146, 20)
        Me.cmbReg.TabIndex = 2
        '
        'cmdSalir
        '
        Me.cmdSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.Location = New System.Drawing.Point(303, 148)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.PulseSpeed = 30
        Me.cmdSalir.Size = New System.Drawing.Size(144, 39)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(151, 148)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.PulseSpeed = 30
        Me.cmdImp.Size = New System.Drawing.Size(144, 39)
        Me.cmdImp.TabIndex = 5
        Me.cmdImp.Text = "Imprimir"
        '
        'frmPensionado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 214)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdImp)
        Me.Controls.Add(Me.GroupPanel3)
        Me.DoubleBuffered = True
        Me.Name = "frmPensionado"
        Me.Text = "Reporte de padron de pensionado"
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbReg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
End Class
