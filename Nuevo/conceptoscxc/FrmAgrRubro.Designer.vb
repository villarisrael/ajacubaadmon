Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgrRubro
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
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX()
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidrubro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.chksistema = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(210, 160)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(90, 37)
        Me.cmdCance.TabIndex = 16
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(96, 160)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(90, 37)
        Me.cmdAcept.TabIndex = 15
        Me.cmdAcept.Text = "Guardar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Rubro:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.FocusHighlightEnabled = True
        Me.txtDescripcion.Location = New System.Drawing.Point(111, 59)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(247, 20)
        Me.txtDescripcion.TabIndex = 14
        Me.txtDescripcion.WatermarkText = "Escribe la  descripcion del rubro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ID_Rubro:"
        '
        'txtidrubro
        '
        Me.txtidrubro.AcceptsReturn = True
        '
        '
        '
        Me.txtidrubro.Border.Class = "TextBoxBorder"
        Me.txtidrubro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtidrubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidrubro.FocusHighlightEnabled = True
        Me.txtidrubro.Location = New System.Drawing.Point(111, 22)
        Me.txtidrubro.MaxLength = 15
        Me.txtidrubro.Name = "txtidrubro"
        Me.txtidrubro.Size = New System.Drawing.Size(111, 20)
        Me.txtidrubro.TabIndex = 13
        Me.txtidrubro.WatermarkText = "Sólo 15 carácteres"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        '
        'chksistema
        '
        '
        '
        '
        Me.chksistema.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chksistema.Location = New System.Drawing.Point(40, 95)
        Me.chksistema.Name = "chksistema"
        Me.chksistema.Size = New System.Drawing.Size(100, 23)
        Me.chksistema.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chksistema.TabIndex = 19
        Me.chksistema.Text = "Sistema"
        '
        'FrmAgrRubro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 220)
        Me.Controls.Add(Me.chksistema)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtidrubro)
        Me.DoubleBuffered = True
        Me.Name = "FrmAgrRubro"
        Me.Text = "Rubro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCance As ButtonX
    Friend WithEvents cmdAcept As ButtonX
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As Controls.TextBoxX
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidrubro As Controls.TextBoxX
    Friend WithEvents Highlighter1 As Validator.Highlighter
    Friend WithEvents chksistema As Controls.CheckBoxX
End Class
