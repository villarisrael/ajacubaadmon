<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrOfi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrOfi))
        Me.txtCodOfi = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtDes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtUlFol = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtpre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'txtCodOfi
        '
        '
        '
        '
        Me.txtCodOfi.Border.Class = "TextBoxBorder"
        Me.txtCodOfi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodOfi.FocusHighlightEnabled = True
        Me.txtCodOfi.Location = New System.Drawing.Point(126, 24)
        Me.txtCodOfi.MaxLength = 3
        Me.txtCodOfi.Name = "txtCodOfi"
        Me.txtCodOfi.Size = New System.Drawing.Size(166, 20)
        Me.txtCodOfi.TabIndex = 0
        Me.txtCodOfi.WatermarkText = "SÓLO TRES LETRAS"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(27, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(49, 21)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "CLAVE:"
        '
        'txtDes
        '
        '
        '
        '
        Me.txtDes.Border.Class = "TextBoxBorder"
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.FocusHighlightEnabled = True
        Me.txtDes.Location = New System.Drawing.Point(126, 63)
        Me.txtDes.MaxLength = 30
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(375, 20)
        Me.txtDes.TabIndex = 1
        Me.txtDes.WatermarkText = "DESCRIPCIÓN DE LA OFICINA"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(27, 63)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(93, 21)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "DESCRIPCIÓN:"
        '
        'txtUlFol
        '
        '
        '
        '
        Me.txtUlFol.Border.Class = "TextBoxBorder"
        Me.txtUlFol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUlFol.FocusHighlightEnabled = True
        Me.txtUlFol.Location = New System.Drawing.Point(126, 102)
        Me.txtUlFol.Name = "txtUlFol"
        Me.txtUlFol.Size = New System.Drawing.Size(268, 20)
        Me.txtUlFol.TabIndex = 2
        Me.txtUlFol.WatermarkText = "ESCRIBA EL ÚLTIMO FOLIO PARA ESTA OFICINA"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(27, 102)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(93, 21)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "ÚLTIMO FOLIO:"
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(27, 141)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(93, 21)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "PREFIJO:"
        '
        'txtpre
        '
        '
        '
        '
        Me.txtpre.Border.Class = "TextBoxBorder"
        Me.txtpre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpre.FocusHighlightEnabled = True
        Me.txtpre.Location = New System.Drawing.Point(126, 141)
        Me.txtpre.MaxLength = 1
        Me.txtpre.Name = "txtpre"
        Me.txtpre.Size = New System.Drawing.Size(109, 20)
        Me.txtpre.TabIndex = 3
        Me.txtpre.WatermarkText = "UNA SÓLA LETRA"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.cmdCerrar.Location = New System.Drawing.Point(275, 181)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(119, 36)
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Text = "SALIR"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(132, 180)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(119, 36)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "GUARDAR"
        '
        'frmAgrOfi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.txtpre)
        Me.Controls.Add(Me.txtUlFol)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtCodOfi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrOfi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS DE LA OFICINA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCodOfi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUlFol As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtpre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
