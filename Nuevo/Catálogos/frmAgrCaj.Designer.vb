<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrCaj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrCaj))
        Me.txtClavCaj = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtSerCaj = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbOfi = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtFol = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.chkActi = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.txtDes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.chkMulti = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.txtRema = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.cmbTcaja = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Local = New DevComponents.Editors.ComboItem
        Me.Remota = New DevComponents.Editors.ComboItem
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'txtClavCaj
        '
        '
        '
        '
        Me.txtClavCaj.Border.Class = "TextBoxBorder"
        Me.txtClavCaj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClavCaj.FocusHighlightEnabled = True
        Me.txtClavCaj.Location = New System.Drawing.Point(137, 28)
        Me.txtClavCaj.MaxLength = 3
        Me.txtClavCaj.Name = "txtClavCaj"
        Me.txtClavCaj.Size = New System.Drawing.Size(119, 20)
        Me.txtClavCaj.TabIndex = 0
        Me.txtClavCaj.WatermarkText = "SÓLO TRES LETRAS"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(27, 27)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(78, 22)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "CLAVE CAJA:"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(27, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(117, 22)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "SERIE DE LA CAJA:"
        '
        'txtSerCaj
        '
        '
        '
        '
        Me.txtSerCaj.Border.Class = "TextBoxBorder"
        Me.txtSerCaj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerCaj.FocusHighlightEnabled = True
        Me.txtSerCaj.Location = New System.Drawing.Point(137, 61)
        Me.txtSerCaj.MaxLength = 1
        Me.txtSerCaj.Name = "txtSerCaj"
        Me.txtSerCaj.Size = New System.Drawing.Size(119, 20)
        Me.txtSerCaj.TabIndex = 1
        Me.txtSerCaj.WatermarkText = "SÓLO UNA LETRA"
        '
        'cmbOfi
        '
        Me.cmbOfi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOfi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOfi.DisplayMember = "Text"
        Me.cmbOfi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbOfi.FocusHighlightEnabled = True
        Me.cmbOfi.FormattingEnabled = True
        Me.cmbOfi.ItemHeight = 14
        Me.cmbOfi.Location = New System.Drawing.Point(137, 94)
        Me.cmbOfi.Name = "cmbOfi"
        Me.cmbOfi.Size = New System.Drawing.Size(294, 20)
        Me.cmbOfi.TabIndex = 2
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(27, 93)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(117, 22)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "OFICINA:"
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(27, 126)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(117, 22)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "FOLIO:"
        '
        'txtFol
        '
        '
        '
        '
        Me.txtFol.Border.Class = "TextBoxBorder"
        Me.txtFol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFol.FocusHighlightEnabled = True
        Me.txtFol.Location = New System.Drawing.Point(137, 127)
        Me.txtFol.Name = "txtFol"
        Me.txtFol.Size = New System.Drawing.Size(144, 20)
        Me.txtFol.TabIndex = 3
        Me.txtFol.WatermarkText = "FOLIO DE FACTURACIÓN"
        '
        'chkActi
        '
        Me.chkActi.Location = New System.Drawing.Point(137, 160)
        Me.chkActi.Name = "chkActi"
        Me.chkActi.Size = New System.Drawing.Size(89, 24)
        Me.chkActi.TabIndex = 4
        Me.chkActi.Text = "ACTIVADO"
        '
        'LabelX5
        '
        Me.LabelX5.Location = New System.Drawing.Point(27, 196)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(117, 22)
        Me.LabelX5.TabIndex = 1
        Me.LabelX5.Text = "DESCRIPCIÓN:"
        '
        'txtDes
        '
        '
        '
        '
        Me.txtDes.Border.Class = "TextBoxBorder"
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.FocusHighlightEnabled = True
        Me.txtDes.Location = New System.Drawing.Point(137, 197)
        Me.txtDes.MaxLength = 100
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(294, 20)
        Me.txtDes.TabIndex = 6
        Me.txtDes.WatermarkText = "ESCRIBA LA DESCRIPCIÓN DE LA CAJA"
        '
        'chkMulti
        '
        Me.chkMulti.Location = New System.Drawing.Point(271, 163)
        Me.chkMulti.Name = "chkMulti"
        Me.chkMulti.Size = New System.Drawing.Size(93, 19)
        Me.chkMulti.TabIndex = 5
        Me.chkMulti.Text = "MULTICAJAS"
        '
        'txtRema
        '
        '
        '
        '
        Me.txtRema.Border.Class = "TextBoxBorder"
        Me.txtRema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRema.FocusHighlightEnabled = True
        Me.txtRema.Location = New System.Drawing.Point(137, 230)
        Me.txtRema.Name = "txtRema"
        Me.txtRema.Size = New System.Drawing.Size(183, 20)
        Me.txtRema.TabIndex = 7
        Me.txtRema.WatermarkText = "MONTO INICIAL DE LA CAJA"
        '
        'LabelX6
        '
        Me.LabelX6.Location = New System.Drawing.Point(27, 229)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(117, 22)
        Me.LabelX6.TabIndex = 1
        Me.LabelX6.Text = "REMANENTE:"
        '
        'LabelX7
        '
        Me.LabelX7.Location = New System.Drawing.Point(27, 262)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(117, 22)
        Me.LabelX7.TabIndex = 1
        Me.LabelX7.Text = "TIPO DE CAJA:"
        '
        'cmbTcaja
        '
        Me.cmbTcaja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTcaja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTcaja.DisplayMember = "Text"
        Me.cmbTcaja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTcaja.FocusHighlightEnabled = True
        Me.cmbTcaja.FormattingEnabled = True
        Me.cmbTcaja.ItemHeight = 14
        Me.cmbTcaja.Items.AddRange(New Object() {Me.Local, Me.Remota})
        Me.cmbTcaja.Location = New System.Drawing.Point(137, 263)
        Me.cmbTcaja.Name = "cmbTcaja"
        Me.cmbTcaja.Size = New System.Drawing.Size(198, 20)
        Me.cmbTcaja.TabIndex = 8
        '
        'Local
        '
        Me.Local.Text = "Local"
        '
        'Remota
        '
        Me.Remota.Text = "Remota"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(107, 305)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(119, 36)
        Me.cmdAcept.TabIndex = 9
        Me.cmdAcept.Text = "GUARDAR"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.cmdCerrar.Location = New System.Drawing.Point(250, 305)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(119, 36)
        Me.cmdCerrar.TabIndex = 10
        Me.cmdCerrar.Text = "SALIR"
        '
        'frmAgrCaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.cmbTcaja)
        Me.Controls.Add(Me.txtRema)
        Me.Controls.Add(Me.chkMulti)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.chkActi)
        Me.Controls.Add(Me.txtFol)
        Me.Controls.Add(Me.cmbOfi)
        Me.Controls.Add(Me.txtSerCaj)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtClavCaj)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrCaj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS DE LAS CAJAS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtClavCaj As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSerCaj As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbOfi As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFol As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkActi As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkMulti As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtRema As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbTcaja As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Local As DevComponents.Editors.ComboItem
    Friend WithEvents Remota As DevComponents.Editors.ComboItem
End Class
