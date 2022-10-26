<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrTrab
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtId_Trab = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIden = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCurp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDir = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCol = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TxtTel = New System.Windows.Forms.MaskedTextBox
        Me.LblTelefono = New System.Windows.Forms.Label
        Me.txtMov = New System.Windows.Forms.MaskedTextBox
        Me.lbl2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCargo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCom = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbDep = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmbBrig = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'txtId_Trab
        '
        Me.txtId_Trab.AcceptsReturn = True
        '
        '
        '
        Me.txtId_Trab.Border.Class = "TextBoxBorder"
        Me.txtId_Trab.FocusHighlightEnabled = True
        Me.txtId_Trab.Location = New System.Drawing.Point(107, 34)
        Me.txtId_Trab.MaxLength = 500
        Me.txtId_Trab.Name = "txtId_Trab"
        Me.txtId_Trab.ReadOnly = True
        Me.txtId_Trab.Size = New System.Drawing.Size(111, 20)
        Me.txtId_Trab.TabIndex = 1
        Me.txtId_Trab.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.FocusHighlightEnabled = True
        Me.txtNombre.Location = New System.Drawing.Point(107, 64)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(274, 20)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.WatermarkText = "Escriba el nombre del empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Identificación:"
        '
        'txtIden
        '
        Me.txtIden.AcceptsReturn = True
        '
        '
        '
        Me.txtIden.Border.Class = "TextBoxBorder"
        Me.txtIden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIden.FocusHighlightEnabled = True
        Me.txtIden.Location = New System.Drawing.Point(107, 94)
        Me.txtIden.MaxLength = 60
        Me.txtIden.Name = "txtIden"
        Me.txtIden.Size = New System.Drawing.Size(274, 20)
        Me.txtIden.TabIndex = 5
        Me.txtIden.WatermarkText = "Número de indentificación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "C. U. R. P.:"
        '
        'txtCurp
        '
        Me.txtCurp.AcceptsReturn = True
        '
        '
        '
        Me.txtCurp.Border.Class = "TextBoxBorder"
        Me.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurp.FocusHighlightEnabled = True
        Me.txtCurp.Location = New System.Drawing.Point(107, 124)
        Me.txtCurp.MaxLength = 100
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(274, 20)
        Me.txtCurp.TabIndex = 7
        Me.txtCurp.WatermarkText = "Escriba la CURP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección:"
        '
        'txtDir
        '
        Me.txtDir.AcceptsReturn = True
        '
        '
        '
        Me.txtDir.Border.Class = "TextBoxBorder"
        Me.txtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDir.FocusHighlightEnabled = True
        Me.txtDir.Location = New System.Drawing.Point(107, 154)
        Me.txtDir.MaxLength = 100
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(274, 20)
        Me.txtDir.TabIndex = 9
        Me.txtDir.WatermarkText = "Escriba la dirección del empleado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Colonia:"
        '
        'txtCol
        '
        Me.txtCol.AcceptsReturn = True
        '
        '
        '
        Me.txtCol.Border.Class = "TextBoxBorder"
        Me.txtCol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCol.FocusHighlightEnabled = True
        Me.txtCol.Location = New System.Drawing.Point(107, 184)
        Me.txtCol.MaxLength = 100
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(274, 20)
        Me.txtCol.TabIndex = 11
        Me.txtCol.WatermarkText = "Escriba la colonia del empleado"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(107, 240)
        Me.TxtTel.Mask = "(###)-###-####"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(84, 20)
        Me.TxtTel.TabIndex = 15
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Location = New System.Drawing.Point(23, 240)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 14
        Me.LblTelefono.Text = "Teléfono:"
        '
        'txtMov
        '
        Me.txtMov.Location = New System.Drawing.Point(107, 270)
        Me.txtMov.Mask = "(###)-###-####"
        Me.txtMov.Name = "txtMov"
        Me.txtMov.Size = New System.Drawing.Size(84, 20)
        Me.txtMov.TabIndex = 17
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Location = New System.Drawing.Point(23, 270)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(35, 13)
        Me.lbl2.TabIndex = 16
        Me.lbl2.Text = "Móvil:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Brigada:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cargo:"
        '
        'txtCargo
        '
        Me.txtCargo.AcceptsReturn = True
        '
        '
        '
        Me.txtCargo.Border.Class = "TextBoxBorder"
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.FocusHighlightEnabled = True
        Me.txtCargo.Location = New System.Drawing.Point(107, 328)
        Me.txtCargo.MaxLength = 50
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(274, 20)
        Me.txtCargo.TabIndex = 21
        Me.txtCargo.WatermarkText = "Escriba el cargo del empleado"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(234, 401)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(115, 38)
        Me.cmdCance.TabIndex = 25
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(89, 401)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(115, 38)
        Me.cmdAcept.TabIndex = 24
        Me.cmdAcept.Text = "Guardar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Comunidad:"
        '
        'txtCom
        '
        Me.txtCom.AcceptsReturn = True
        '
        '
        '
        Me.txtCom.Border.Class = "TextBoxBorder"
        Me.txtCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCom.FocusHighlightEnabled = True
        Me.txtCom.Location = New System.Drawing.Point(107, 214)
        Me.txtCom.MaxLength = 100
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Size = New System.Drawing.Size(274, 20)
        Me.txtCom.TabIndex = 13
        Me.txtCom.WatermarkText = "Escriba la comunidad del empleado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Departamento:"
        '
        'cmbDep
        '
        Me.cmbDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDep.DisplayMember = "Text"
        Me.cmbDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDep.FocusHighlightEnabled = True
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.ItemHeight = 14
        Me.cmbDep.Location = New System.Drawing.Point(107, 354)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(271, 20)
        Me.cmbDep.TabIndex = 23
        '
        'cmbBrig
        '
        Me.cmbBrig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBrig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBrig.DisplayMember = "Text"
        Me.cmbBrig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBrig.FocusHighlightEnabled = True
        Me.cmbBrig.FormattingEnabled = True
        Me.cmbBrig.ItemHeight = 14
        Me.cmbBrig.Location = New System.Drawing.Point(107, 300)
        Me.cmbBrig.Name = "cmbBrig"
        Me.cmbBrig.Size = New System.Drawing.Size(271, 20)
        Me.cmbBrig.TabIndex = 19
        '
        'frmAgrTrab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbBrig)
        Me.Controls.Add(Me.cmbDep)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMov)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCurp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_Trab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrTrab"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId_Trab As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIden As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCurp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDir As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCol As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtMov As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbDep As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbBrig As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
