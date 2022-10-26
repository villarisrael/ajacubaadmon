<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrmatcalle
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
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtClav = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuspendLayout()
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(206, 129)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(92, 34)
        Me.cmdCance.TabIndex = 16
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(108, 129)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(92, 34)
        Me.cmdAcept.TabIndex = 15
        Me.cmdAcept.Text = "Guardar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Descripción:"
        '
        'txtDes
        '
        '
        '
        '
        Me.txtDes.Border.Class = "TextBoxBorder"
        Me.txtDes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.FocusHighlightEnabled = True
        Me.txtDes.Location = New System.Drawing.Point(106, 74)
        Me.txtDes.MaxLength = 80
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(255, 20)
        Me.txtDes.TabIndex = 14
        Me.txtDes.WatermarkText = "Descripción del Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Clave :"
        '
        'txtClav
        '
        '
        '
        '
        Me.txtClav.Border.Class = "TextBoxBorder"
        Me.txtClav.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtClav.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClav.Enabled = False
        Me.txtClav.FocusHighlightEnabled = True
        Me.txtClav.Location = New System.Drawing.Point(106, 33)
        Me.txtClav.MaxLength = 3
        Me.txtClav.Name = "txtClav"
        Me.txtClav.Size = New System.Drawing.Size(110, 20)
        Me.txtClav.TabIndex = 13
        '
        'frmAgrmatcalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 196)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClav)
        Me.DoubleBuffered = True
        Me.Name = "frmAgrmatcalle"
        Me.Text = "Catalogo Material de Calle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClav As DevComponents.DotNetBar.Controls.TextBoxX
End Class
