<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrMuni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrMuni))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtId_clave = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNomMun = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID_Municipio:"
        '
        'txtId_clave
        '
        Me.txtId_clave.AcceptsReturn = True
        '
        '
        '
        Me.txtId_clave.Border.Class = "TextBoxBorder"
        Me.txtId_clave.FocusHighlightEnabled = True
        Me.txtId_clave.Location = New System.Drawing.Point(147, 45)
        Me.txtId_clave.MaxLength = 500
        Me.txtId_clave.Name = "txtId_clave"
        Me.txtId_clave.Size = New System.Drawing.Size(111, 20)
        Me.txtId_clave.TabIndex = 0
        Me.txtId_clave.WatermarkText = "Sólo números"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre del municipio:"
        '
        'txtNomMun
        '
        Me.txtNomMun.AcceptsReturn = True
        '
        '
        '
        Me.txtNomMun.Border.Class = "TextBoxBorder"
        Me.txtNomMun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomMun.FocusHighlightEnabled = True
        Me.txtNomMun.Location = New System.Drawing.Point(147, 80)
        Me.txtNomMun.MaxLength = 500
        Me.txtNomMun.Name = "txtNomMun"
        Me.txtNomMun.Size = New System.Drawing.Size(275, 20)
        Me.txtNomMun.TabIndex = 1
        Me.txtNomMun.WatermarkText = "Sólo tres carácteres"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(220, 133)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(103, 34)
        Me.cmdCance.TabIndex = 3
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(111, 133)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(103, 34)
        Me.cmdAcept.TabIndex = 2
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrMuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 181)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomMun)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_clave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrMuni"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Municipios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId_clave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomMun As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
