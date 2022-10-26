<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotElSol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMotElSol))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtMot = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.cmdCan = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(565, 27)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "ESCRIBA EL MOTIVO DE LA CANCELACIÓN"
        '
        'txtMot
        '
        '
        '
        '
        Me.txtMot.Border.Class = "TextBoxBorder"
        Me.txtMot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMot.FocusHighlightEnabled = True
        Me.txtMot.Location = New System.Drawing.Point(12, 45)
        Me.txtMot.MaxLength = 30
        Me.txtMot.Name = "txtMot"
        Me.txtMot.Size = New System.Drawing.Size(569, 20)
        Me.txtMot.TabIndex = 0
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(275, 80)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 30
        Me.cmdAcept.Size = New System.Drawing.Size(124, 33)
        Me.cmdAcept.TabIndex = 1
        Me.cmdAcept.Text = "ACEPTAR"
        '
        'cmdCan
        '
        Me.cmdCan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCan.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCan.Location = New System.Drawing.Point(418, 80)
        Me.cmdCan.Name = "cmdCan"
        Me.cmdCan.PulseSpeed = 30
        Me.cmdCan.Size = New System.Drawing.Size(124, 33)
        Me.cmdCan.TabIndex = 2
        Me.cmdCan.Text = "TERMINAR"
        '
        'frmMotElSol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 122)
        Me.Controls.Add(Me.cmdCan)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.txtMot)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMotElSol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOTIVO DE LA CANCELACIÓN"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMot As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCan As DevComponents.DotNetBar.ButtonX
End Class
