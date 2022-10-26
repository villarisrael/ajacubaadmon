<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgrSector
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
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.LblClave = New System.Windows.Forms.Label
        Me.TxtClave = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TxtNombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblNombre = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.BtnCancelar.Location = New System.Drawing.Point(282, 86)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 40
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 39)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(166, 86)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 40
        Me.BtnAceptar.Size = New System.Drawing.Size(96, 39)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        '
        'LblClave
        '
        Me.LblClave.AutoSize = True
        Me.LblClave.Location = New System.Drawing.Point(23, 18)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(37, 13)
        Me.LblClave.TabIndex = 6
        Me.LblClave.Text = "Clave:"
        '
        'TxtClave
        '
        '
        '
        '
        Me.TxtClave.Border.Class = "TextBoxBorder"
        Me.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtClave.FocusHighlightEnabled = True
        Me.TxtClave.Location = New System.Drawing.Point(77, 14)
        Me.TxtClave.MaxLength = 3
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(131, 20)
        Me.TxtClave.TabIndex = 0
        Me.TxtClave.WatermarkText = "CLAVE DEL SECTOR"
        '
        'TxtNombre
        '
        '
        '
        '
        Me.TxtNombre.Border.Class = "TextBoxBorder"
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.FocusHighlightEnabled = True
        Me.TxtNombre.Location = New System.Drawing.Point(77, 44)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(458, 20)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.WatermarkText = "NOMBRE DEL SECTOR"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(23, 48)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 8
        Me.LblNombre.Text = "Nombre:"
        '
        'FrmAgrSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 141)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.LblClave)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAgrSector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogos de Sectores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblClave As System.Windows.Forms.Label
    Friend WithEvents TxtClave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblNombre As System.Windows.Forms.Label
End Class
