<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgCambioVerificacion
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
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.BtnSi = New DevComponents.DotNetBar.ButtonX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblActual = New System.Windows.Forms.Label
        Me.LblAntes = New System.Windows.Forms.Label
        Me.BtnNo = New DevComponents.DotNetBar.ButtonX
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(35, 35)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(330, 22)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Los valores de captura han cambiado:"
        '
        'BtnSi
        '
        Me.BtnSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSi.Location = New System.Drawing.Point(182, 201)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(105, 28)
        Me.BtnSi.TabIndex = 0
        Me.BtnSi.Text = "Si"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Administativo.My.Resources.Resources.Help
        Me.PictureBox1.Location = New System.Drawing.Point(472, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Captura Anterior"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Captura Actual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "¿Desea conservar los valores anteriores de captura?"
        '
        'LblActual
        '
        Me.LblActual.AutoSize = True
        Me.LblActual.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActual.Location = New System.Drawing.Point(280, 117)
        Me.LblActual.Name = "LblActual"
        Me.LblActual.Size = New System.Drawing.Size(0, 22)
        Me.LblActual.TabIndex = 7
        '
        'LblAntes
        '
        Me.LblAntes.AutoSize = True
        Me.LblAntes.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAntes.Location = New System.Drawing.Point(280, 75)
        Me.LblAntes.Name = "LblAntes"
        Me.LblAntes.Size = New System.Drawing.Size(0, 22)
        Me.LblAntes.TabIndex = 6
        '
        'BtnNo
        '
        Me.BtnNo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnNo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnNo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNo.Location = New System.Drawing.Point(302, 201)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(105, 28)
        Me.BtnNo.TabIndex = 1
        Me.BtnNo.Text = "No"
        '
        'DlgCambioVerificacion
        '
        Me.AcceptButton = Me.BtnSi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnNo
        Me.ClientSize = New System.Drawing.Size(563, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.LblActual)
        Me.Controls.Add(Me.LblAntes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSi)
        Me.Controls.Add(Me.LblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgCambioVerificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio en la Verificacion"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents BtnSi As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblActual As System.Windows.Forms.Label
    Friend WithEvents LblAntes As System.Windows.Forms.Label
    Friend WithEvents BtnNo As DevComponents.DotNetBar.ButtonX
End Class
