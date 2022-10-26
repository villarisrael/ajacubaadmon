<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgrRuta
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblClave = New System.Windows.Forms.Label()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.LblRuta = New System.Windows.Forms.Label()
        Me.CmbSector = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TxtClave = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        '
        '
        '
        Me.TxtNombre.Border.Class = "TextBoxBorder"
        Me.TxtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.FocusHighlightEnabled = True
        Me.TxtNombre.Location = New System.Drawing.Point(90, 116)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(457, 20)
        Me.TxtNombre.TabIndex = 2
        Me.TxtNombre.WatermarkText = "Escribe el nombre de la ruta"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(21, 120)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(63, 13)
        Me.LblNombre.TabIndex = 14
        Me.LblNombre.Text = "Descripción"
        '
        'LblClave
        '
        Me.LblClave.AutoSize = True
        Me.LblClave.Location = New System.Drawing.Point(21, 90)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(34, 13)
        Me.LblClave.TabIndex = 12
        Me.LblClave.Text = "Clave"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.BtnCancelar.Location = New System.Drawing.Point(295, 185)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 40
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 35)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(190, 185)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 40
        Me.BtnAceptar.Size = New System.Drawing.Size(90, 35)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        '
        'LblRuta
        '
        Me.LblRuta.AutoSize = True
        Me.LblRuta.Location = New System.Drawing.Point(21, 17)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(41, 13)
        Me.LblRuta.TabIndex = 16
        Me.LblRuta.Text = "Región"
        '
        'CmbSector
        '
        Me.CmbSector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSector.DisplayMember = "Text"
        Me.CmbSector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSector.FocusHighlightEnabled = True
        Me.CmbSector.FormattingEnabled = True
        Me.CmbSector.ItemHeight = 14
        Me.CmbSector.Location = New System.Drawing.Point(90, 13)
        Me.CmbSector.Name = "CmbSector"
        Me.CmbSector.Size = New System.Drawing.Size(457, 20)
        Me.CmbSector.TabIndex = 0
        '
        'TxtClave
        '
        '
        '
        '
        Me.TxtClave.Border.Class = "TextBoxBorder"
        Me.TxtClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtClave.Location = New System.Drawing.Point(90, 83)
        Me.TxtClave.MaxLength = 3
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PreventEnterBeep = True
        Me.TxtClave.Size = New System.Drawing.Size(100, 20)
        Me.TxtClave.TabIndex = 18
        '
        'FrmAgrRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 237)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.CmbSector)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblClave)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAgrRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Rutas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblClave As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblRuta As System.Windows.Forms.Label
    Friend WithEvents CmbSector As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TxtClave As DevComponents.DotNetBar.Controls.TextBoxX
End Class
