<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrCatBrig
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
        Me.txtNoBrig = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.cmdAceptar = New DevComponents.DotNetBar.ButtonX
        Me.cmadCancelar = New DevComponents.DotNetBar.ButtonX
        Me.cmbDirec = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmbTrab = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(29, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(96, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Número de Brigada"
        '
        'txtNoBrig
        '
        '
        '
        '
        Me.txtNoBrig.Border.Class = "TextBoxBorder"
        Me.txtNoBrig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoBrig.Enabled = False
        Me.txtNoBrig.FocusHighlightEnabled = True
        Me.txtNoBrig.Location = New System.Drawing.Point(131, 20)
        Me.txtNoBrig.MaxLength = 3
        Me.txtNoBrig.Name = "txtNoBrig"
        Me.txtNoBrig.Size = New System.Drawing.Size(116, 20)
        Me.txtNoBrig.TabIndex = 0
        Me.txtNoBrig.WatermarkText = "Sólo Tres caracteres"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(29, 68)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Descripción"
        '
        'txtDescripcion
        '
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.FocusHighlightEnabled = True
        Me.txtDescripcion.Location = New System.Drawing.Point(131, 69)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(217, 20)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.WatermarkText = "Escriba la descripción"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(29, 117)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(96, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Dirección"
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(29, 166)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Responsable"
        Me.LabelX4.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAceptar.Location = New System.Drawing.Point(48, 166)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.PulseSpeed = 30
        Me.cmdAceptar.Size = New System.Drawing.Size(124, 36)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Guardar"
        '
        'cmadCancelar
        '
        Me.cmadCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmadCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmadCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmadCancelar.Location = New System.Drawing.Point(206, 166)
        Me.cmadCancelar.Name = "cmadCancelar"
        Me.cmadCancelar.PulseSpeed = 30
        Me.cmadCancelar.Size = New System.Drawing.Size(124, 36)
        Me.cmadCancelar.TabIndex = 5
        Me.cmadCancelar.Text = "Terminar"
        '
        'cmbDirec
        '
        Me.cmbDirec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDirec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDirec.DisplayMember = "Text"
        Me.cmbDirec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDirec.FocusHighlightEnabled = True
        Me.cmbDirec.FormattingEnabled = True
        Me.cmbDirec.ItemHeight = 14
        Me.cmbDirec.Location = New System.Drawing.Point(131, 118)
        Me.cmbDirec.Name = "cmbDirec"
        Me.cmbDirec.Size = New System.Drawing.Size(217, 20)
        Me.cmbDirec.TabIndex = 2
        Me.cmbDirec.WatermarkText = "Selecciones La Dirección"
        '
        'cmbTrab
        '
        Me.cmbTrab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTrab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTrab.DisplayMember = "Text"
        Me.cmbTrab.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTrab.FocusHighlightEnabled = True
        Me.cmbTrab.FormattingEnabled = True
        Me.cmbTrab.ItemHeight = 14
        Me.cmbTrab.Location = New System.Drawing.Point(131, 167)
        Me.cmbTrab.Name = "cmbTrab"
        Me.cmbTrab.Size = New System.Drawing.Size(217, 20)
        Me.cmbTrab.TabIndex = 3
        Me.cmbTrab.Visible = False
        Me.cmbTrab.WatermarkText = "Seleccione El Trabajador"
        '
        'frmAgrCatBrig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbDirec)
        Me.Controls.Add(Me.cmadCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtNoBrig)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cmbTrab)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrCatBrig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo Brigada"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNoBrig As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmadCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbDirec As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbTrab As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
