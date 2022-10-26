<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuspendervb
    Inherits System.Windows.Forms.Form

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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcuenta = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcalle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblmedidor = New System.Windows.Forms.Label()
        Me.lblcomunidad = New System.Windows.Forms.Label()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdGenCob = New DevComponents.DotNetBar.ButtonX()
        Me.TxtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Administativo.My.Resources.Resources.usususp
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 117)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblcuenta
        '
        Me.lblcuenta.AutoSize = True
        Me.lblcuenta.Location = New System.Drawing.Point(163, 9)
        Me.lblcuenta.Name = "lblcuenta"
        Me.lblcuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblcuenta.TabIndex = 1
        Me.lblcuenta.Text = "Cuenta"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(163, 35)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 2
        Me.lblnombre.Text = "Nombre"
        '
        'lblcalle
        '
        Me.lblcalle.AutoSize = True
        Me.lblcalle.Location = New System.Drawing.Point(163, 61)
        Me.lblcalle.Name = "lblcalle"
        Me.lblcalle.Size = New System.Drawing.Size(30, 13)
        Me.lblcalle.TabIndex = 3
        Me.lblcalle.Text = "Calle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Medidor"
        '
        'lblmedidor
        '
        Me.lblmedidor.AutoSize = True
        Me.lblmedidor.Location = New System.Drawing.Point(224, 107)
        Me.lblmedidor.Name = "lblmedidor"
        Me.lblmedidor.Size = New System.Drawing.Size(45, 13)
        Me.lblmedidor.TabIndex = 5
        Me.lblmedidor.Text = "Medidor"
        '
        'lblcomunidad
        '
        Me.lblcomunidad.AutoSize = True
        Me.lblcomunidad.Location = New System.Drawing.Point(163, 84)
        Me.lblcomunidad.Name = "lblcomunidad"
        Me.lblcomunidad.Size = New System.Drawing.Size(60, 13)
        Me.lblcomunidad.TabIndex = 6
        Me.lblcomunidad.Text = "Comunidad"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.BtnCancelar.Location = New System.Drawing.Point(517, 216)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 39)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(401, 216)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 30
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 39)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        '
        'cmdGenCob
        '
        Me.cmdGenCob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdGenCob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdGenCob.Enabled = False
        Me.cmdGenCob.Image = Global.Administativo.My.Resources.Resources.otroscobros
        Me.cmdGenCob.Location = New System.Drawing.Point(286, 216)
        Me.cmdGenCob.Name = "cmdGenCob"
        Me.cmdGenCob.PulseSpeed = 30
        Me.cmdGenCob.Size = New System.Drawing.Size(109, 39)
        Me.cmdGenCob.TabIndex = 10
        Me.cmdGenCob.Text = "Generar Cobro"
        '
        'TxtMotivo
        '
        '
        '
        '
        Me.TxtMotivo.Border.Class = "TextBoxBorder"
        Me.TxtMotivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotivo.FocusHighlightEnabled = True
        Me.TxtMotivo.Location = New System.Drawing.Point(166, 137)
        Me.TxtMotivo.MaxLength = 400
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(462, 56)
        Me.TxtMotivo.TabIndex = 12
        Me.TxtMotivo.WatermarkText = "Escribe el motivo de la suspensión"
        '
        'frmsuspendervb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(657, 280)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.cmdGenCob)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.lblcomunidad)
        Me.Controls.Add(Me.lblmedidor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblcalle)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblcuenta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmsuspendervb"
        Me.Text = "Verifica y confirma"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcuenta As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblcalle As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblmedidor As System.Windows.Forms.Label
    Friend WithEvents lblcomunidad As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdGenCob As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtMotivo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
