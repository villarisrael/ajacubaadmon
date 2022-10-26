<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrDepa
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodDep = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRespo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.txtNomDep = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbDir = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código del departamento:"
        '
        'txtCodDep
        '
        Me.txtCodDep.AcceptsReturn = True
        '
        '
        '
        Me.txtCodDep.Border.Class = "TextBoxBorder"
        Me.txtCodDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodDep.FocusHighlightEnabled = True
        Me.txtCodDep.Location = New System.Drawing.Point(204, 43)
        Me.txtCodDep.MaxLength = 3
        Me.txtCodDep.Name = "txtCodDep"
        Me.txtCodDep.Size = New System.Drawing.Size(87, 20)
        Me.txtCodDep.TabIndex = 0
        Me.txtCodDep.WatermarkText = "Sólo tres letras"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre del departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Responsable:"
        '
        'txtRespo
        '
        Me.txtRespo.AcceptsReturn = True
        '
        '
        '
        Me.txtRespo.Border.Class = "TextBoxBorder"
        Me.txtRespo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRespo.FocusHighlightEnabled = True
        Me.txtRespo.Location = New System.Drawing.Point(204, 119)
        Me.txtRespo.MaxLength = 30
        Me.txtRespo.Name = "txtRespo"
        Me.txtRespo.Size = New System.Drawing.Size(272, 20)
        Me.txtRespo.TabIndex = 2
        Me.txtRespo.WatermarkText = "Escriba el nombre del responsable del departamento"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(289, 202)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 30
        Me.cmdCance.Size = New System.Drawing.Size(115, 34)
        Me.cmdCance.TabIndex = 5
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(144, 202)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 30
        Me.cmdAcept.Size = New System.Drawing.Size(115, 34)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Guardar"
        '
        'txtNomDep
        '
        '
        '
        '
        Me.txtNomDep.Border.Class = "TextBoxBorder"
        Me.txtNomDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomDep.FocusHighlightEnabled = True
        Me.txtNomDep.Location = New System.Drawing.Point(204, 81)
        Me.txtNomDep.Name = "txtNomDep"
        Me.txtNomDep.Size = New System.Drawing.Size(272, 20)
        Me.txtNomDep.TabIndex = 1
        Me.txtNomDep.WatermarkText = "Escriba el nombre del departamento"
        '
        'cmbDir
        '
        Me.cmbDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDir.DisplayMember = "Text"
        Me.cmbDir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDir.FocusHighlightEnabled = True
        Me.cmbDir.FormattingEnabled = True
        Me.cmbDir.ItemHeight = 14
        Me.cmbDir.Location = New System.Drawing.Point(204, 157)
        Me.cmbDir.Name = "cmbDir"
        Me.cmbDir.Size = New System.Drawing.Size(272, 20)
        Me.cmbDir.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dirección:"
        '
        'frmAgrDepa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbDir)
        Me.Controls.Add(Me.txtNomDep)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRespo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodDep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrDepa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodDep As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRespo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNomDep As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbDir As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
