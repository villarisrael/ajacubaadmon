<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrFpag
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtClavF = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtDp = New DevComponents.Editors.IntegerInput
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkRef = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        CType(Me.txtDp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Clave:"
        '
        'txtClavF
        '
        '
        '
        '
        Me.txtClavF.Border.Class = "TextBoxBorder"
        Me.txtClavF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClavF.FocusHighlightEnabled = True
        Me.txtClavF.Location = New System.Drawing.Point(112, 30)
        Me.txtClavF.MaxLength = 2
        Me.txtClavF.Name = "txtClavF"
        Me.txtClavF.Size = New System.Drawing.Size(128, 20)
        Me.txtClavF.TabIndex = 0
        Me.txtClavF.WatermarkText = "Sólo dos caracteres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción:"
        '
        'txtDes
        '
        '
        '
        '
        Me.txtDes.Border.Class = "TextBoxBorder"
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.FocusHighlightEnabled = True
        Me.txtDes.Location = New System.Drawing.Point(112, 67)
        Me.txtDes.MaxLength = 30
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(296, 20)
        Me.txtDes.TabIndex = 1
        Me.txtDes.WatermarkText = "Escribe la descripción de la forma de pago"
        '
        'txtDp
        '
        '
        '
        '
        Me.txtDp.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDp.FocusHighlightEnabled = True
        Me.txtDp.Location = New System.Drawing.Point(112, 104)
        Me.txtDp.Name = "txtDp"
        Me.txtDp.ShowUpDown = True
        Me.txtDp.Size = New System.Drawing.Size(80, 20)
        Me.txtDp.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Días de plazo:"
        '
        'chkRef
        '
        Me.chkRef.Location = New System.Drawing.Point(112, 147)
        Me.chkRef.Name = "chkRef"
        Me.chkRef.Size = New System.Drawing.Size(107, 23)
        Me.chkRef.TabIndex = 3
        Me.chkRef.Text = "Referencia"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(228, 193)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(115, 36)
        Me.cmdCance.TabIndex = 5
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(83, 193)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(115, 36)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrFpag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.chkRef)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClavF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrFpag"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la forma de pago"
        CType(Me.txtDp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClavF As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDp As DevComponents.Editors.IntegerInput
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkRef As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
