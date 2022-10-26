<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrCol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrCol))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId_col = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnomCol = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX()
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID_Colonia:"
        '
        'txtId_col
        '
        Me.txtId_col.AcceptsReturn = True
        '
        '
        '
        Me.txtId_col.Border.Class = "TextBoxBorder"
        Me.txtId_col.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtId_col.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId_col.FocusHighlightEnabled = True
        Me.txtId_col.Location = New System.Drawing.Point(94, 17)
        Me.txtId_col.MaxLength = 3
        Me.txtId_col.Name = "txtId_col"
        Me.txtId_col.Size = New System.Drawing.Size(111, 20)
        Me.txtId_col.TabIndex = 0
        Me.txtId_col.WatermarkText = "Sólo tres carácteres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Colonia:"
        '
        'txtnomCol
        '
        Me.txtnomCol.AcceptsReturn = True
        '
        '
        '
        Me.txtnomCol.Border.Class = "TextBoxBorder"
        Me.txtnomCol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnomCol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomCol.FocusHighlightEnabled = True
        Me.txtnomCol.Location = New System.Drawing.Point(94, 53)
        Me.txtnomCol.MaxLength = 500
        Me.txtnomCol.Name = "txtnomCol"
        Me.txtnomCol.Size = New System.Drawing.Size(266, 20)
        Me.txtnomCol.TabIndex = 2
        Me.txtnomCol.WatermarkText = "Escriba el nombre de la colonia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cp:"
        '
        'txtcp
        '
        Me.txtcp.AcceptsReturn = True
        '
        '
        '
        Me.txtcp.Border.Class = "TextBoxBorder"
        Me.txtcp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcp.FocusHighlightEnabled = True
        Me.txtcp.Location = New System.Drawing.Point(94, 93)
        Me.txtcp.MaxLength = 5
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(171, 20)
        Me.txtcp.TabIndex = 3
        Me.txtcp.WatermarkText = "Escriba el código postal "
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(212, 172)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(93, 36)
        Me.cmdCance.TabIndex = 5
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(113, 172)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(93, 36)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrCol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 246)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnomCol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_col)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrCol"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Colonias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId_col As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnomCol As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
