<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrReg))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId_reg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX()
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID_Región:"
        '
        'txtId_reg
        '
        Me.txtId_reg.AcceptsReturn = True
        '
        '
        '
        Me.txtId_reg.Border.Class = "TextBoxBorder"
        Me.txtId_reg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtId_reg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId_reg.FocusHighlightEnabled = True
        Me.txtId_reg.Location = New System.Drawing.Point(100, 17)
        Me.txtId_reg.MaxLength = 3
        Me.txtId_reg.Name = "txtId_reg"
        Me.txtId_reg.Size = New System.Drawing.Size(111, 20)
        Me.txtId_reg.TabIndex = 1
        Me.txtId_reg.WatermarkText = "Sólo tres carácteres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Región:"
        '
        'txtReg
        '
        Me.txtReg.AcceptsReturn = True
        '
        '
        '
        Me.txtReg.Border.Class = "TextBoxBorder"
        Me.txtReg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtReg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReg.FocusHighlightEnabled = True
        Me.txtReg.Location = New System.Drawing.Point(100, 56)
        Me.txtReg.MaxLength = 100
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(337, 20)
        Me.txtReg.TabIndex = 2
        Me.txtReg.WatermarkText = "Escriba el nombre de la región"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.cmdCance.Location = New System.Drawing.Point(243, 107)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(93, 37)
        Me.cmdCance.TabIndex = 4
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(144, 107)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(93, 37)
        Me.cmdAcept.TabIndex = 3
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 208)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_reg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrReg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de regiones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId_reg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
