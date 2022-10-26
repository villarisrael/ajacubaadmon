<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrDir
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtResponsable = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.cmadCancelar = New DevComponents.DotNetBar.ButtonX
        Me.cmdAceptar = New DevComponents.DotNetBar.ButtonX
        Me.txtCod_Direc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(46, 44)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(96, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Dirección:"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.FocusHighlightEnabled = True
        Me.txtNombre.Location = New System.Drawing.Point(148, 86)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(232, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.WatermarkText = "Escriba el Nombre"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(46, 83)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(96, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Nombre:"
        '
        'txtResponsable
        '
        '
        '
        '
        Me.txtResponsable.Border.Class = "TextBoxBorder"
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable.FocusHighlightEnabled = True
        Me.txtResponsable.Location = New System.Drawing.Point(148, 129)
        Me.txtResponsable.MaxLength = 30
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(232, 20)
        Me.txtResponsable.TabIndex = 2
        Me.txtResponsable.WatermarkText = "Escriba el Responsable"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(46, 129)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(96, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Responsable:"
        '
        'cmadCancelar
        '
        Me.cmadCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmadCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmadCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmadCancelar.Location = New System.Drawing.Point(229, 178)
        Me.cmadCancelar.Name = "cmadCancelar"
        Me.cmadCancelar.PulseSpeed = 30
        Me.cmadCancelar.Size = New System.Drawing.Size(104, 34)
        Me.cmadCancelar.TabIndex = 4
        Me.cmadCancelar.Text = "Terminar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAceptar.Location = New System.Drawing.Point(93, 178)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.PulseSpeed = 30
        Me.cmdAceptar.Size = New System.Drawing.Size(104, 34)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Guardar"
        '
        'txtCod_Direc
        '
        '
        '
        '
        Me.txtCod_Direc.Border.Class = "TextBoxBorder"
        Me.txtCod_Direc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCod_Direc.FocusHighlightEnabled = True
        Me.txtCod_Direc.Location = New System.Drawing.Point(149, 46)
        Me.txtCod_Direc.MaxLength = 3
        Me.txtCod_Direc.Name = "txtCod_Direc"
        Me.txtCod_Direc.Size = New System.Drawing.Size(120, 20)
        Me.txtCod_Direc.TabIndex = 0
        Me.txtCod_Direc.WatermarkText = "Solo Tres Caracteres"
        '
        'frmAgrDir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCod_Direc)
        Me.Controls.Add(Me.cmadCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrDir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Dirección"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtResponsable As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmadCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCod_Direc As DevComponents.DotNetBar.Controls.TextBoxX
End Class
