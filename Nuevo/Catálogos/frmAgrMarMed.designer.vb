<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrMarMed
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
        Me.txtClavMar = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.NDigitos = New DevComponents.Editors.IntegerInput
        CType(Me.NDigitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Clave de la marca:"
        '
        'txtClavMar
        '
        '
        '
        '
        Me.txtClavMar.Border.Class = "TextBoxBorder"
        Me.txtClavMar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClavMar.FocusHighlightEnabled = True
        Me.txtClavMar.Location = New System.Drawing.Point(136, 22)
        Me.txtClavMar.MaxLength = 3
        Me.txtClavMar.Name = "txtClavMar"
        Me.txtClavMar.Size = New System.Drawing.Size(110, 20)
        Me.txtClavMar.TabIndex = 1
        Me.txtClavMar.WatermarkText = "Sólo tres caracteres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
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
        Me.txtDes.Location = New System.Drawing.Point(136, 61)
        Me.txtDes.MaxLength = 45
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(201, 20)
        Me.txtDes.TabIndex = 3
        Me.txtDes.WatermarkText = "Descripción de la marca"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(205, 135)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(115, 34)
        Me.cmdCance.TabIndex = 7
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(60, 135)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(115, 34)
        Me.cmdAcept.TabIndex = 6
        Me.cmdAcept.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Digitos:"
        '
        'NDigitos
        '
        '
        '
        '
        Me.NDigitos.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NDigitos.FocusHighlightEnabled = True
        Me.NDigitos.Location = New System.Drawing.Point(136, 98)
        Me.NDigitos.MaxValue = 6
        Me.NDigitos.MinValue = 1
        Me.NDigitos.Name = "NDigitos"
        Me.NDigitos.ShowUpDown = True
        Me.NDigitos.Size = New System.Drawing.Size(58, 20)
        Me.NDigitos.TabIndex = 5
        Me.NDigitos.Value = 1
        '
        'frmAgrMarMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.NDigitos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClavMar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrMarMed"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la marca de medidor"
        CType(Me.NDigitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClavMar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NDigitos As DevComponents.Editors.IntegerInput
End Class
