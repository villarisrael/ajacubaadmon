<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrFuen
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
        Me.LblClave = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtID_Fuente = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuspendLayout()
        '
        'LblClave
        '
        Me.LblClave.AutoSize = True
        Me.LblClave.Location = New System.Drawing.Point(18, 19)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(70, 13)
        Me.LblClave.TabIndex = 14
        Me.LblClave.Text = "Clave Fuente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Descipción"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(235, 94)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 30
        Me.cmdCance.Size = New System.Drawing.Size(114, 32)
        Me.cmdCance.TabIndex = 3
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(75, 94)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 30
        Me.cmdAcept.Size = New System.Drawing.Size(114, 32)
        Me.cmdAcept.TabIndex = 2
        Me.cmdAcept.Text = "Guardar"
        '
        'txtDescripcion
        '
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.FocusHighlightEnabled = True
        Me.txtDescripcion.Location = New System.Drawing.Point(94, 52)
        Me.txtDescripcion.MaxLength = 45
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(313, 20)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.WatermarkText = "Descripción"
        '
        'txtID_Fuente
        '
        '
        '
        '
        Me.txtID_Fuente.Border.Class = "TextBoxBorder"
        Me.txtID_Fuente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_Fuente.FocusHighlightEnabled = True
        Me.txtID_Fuente.Location = New System.Drawing.Point(94, 17)
        Me.txtID_Fuente.MaxLength = 3
        Me.txtID_Fuente.Name = "txtID_Fuente"
        Me.txtID_Fuente.Size = New System.Drawing.Size(112, 20)
        Me.txtID_Fuente.TabIndex = 0
        Me.txtID_Fuente.WatermarkText = "Solo tres caracteres"
        '
        'frmAgrFuen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtID_Fuente)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblClave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrFuen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la fuente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblClave As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtID_Fuente As DevComponents.DotNetBar.Controls.TextBoxX
End Class
