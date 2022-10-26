<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrCalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrCalle))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtId_calle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomCall = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX()
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ID_Calle:"
        '
        'txtId_calle
        '
        Me.txtId_calle.AcceptsReturn = True
        '
        '
        '
        Me.txtId_calle.Border.Class = "TextBoxBorder"
        Me.txtId_calle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtId_calle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId_calle.FocusHighlightEnabled = True
        Me.txtId_calle.Location = New System.Drawing.Point(91, 16)
        Me.txtId_calle.MaxLength = 5
        Me.txtId_calle.Name = "txtId_calle"
        Me.txtId_calle.Size = New System.Drawing.Size(111, 20)
        Me.txtId_calle.TabIndex = 2
        Me.txtId_calle.WatermarkText = "Sólo tres carácteres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Calle:"
        '
        'txtNomCall
        '
        Me.txtNomCall.AcceptsReturn = True
        '
        '
        '
        Me.txtNomCall.Border.Class = "TextBoxBorder"
        Me.txtNomCall.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNomCall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomCall.FocusHighlightEnabled = True
        Me.txtNomCall.Location = New System.Drawing.Point(91, 53)
        Me.txtNomCall.MaxLength = 100
        Me.txtNomCall.Name = "txtNomCall"
        Me.txtNomCall.Size = New System.Drawing.Size(247, 20)
        Me.txtNomCall.TabIndex = 3
        Me.txtNomCall.WatermarkText = "Escribe el nombre de la calle"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion1
        Me.cmdCance.Location = New System.Drawing.Point(253, 94)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(90, 37)
        Me.cmdCance.TabIndex = 5
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.cmdAcept.Location = New System.Drawing.Point(139, 94)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(90, 37)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrCalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 147)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNomCall)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtId_calle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrCalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Calles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtId_calle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNomCall As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
