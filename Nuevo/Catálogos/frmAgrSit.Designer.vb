<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrSit
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtClavSit = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAlg = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.cmbtipo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Clave de la situación:"
        '
        'txtClavSit
        '
        '
        '
        '
        Me.txtClavSit.Border.Class = "TextBoxBorder"
        Me.txtClavSit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClavSit.FocusHighlightEnabled = True
        Me.txtClavSit.Location = New System.Drawing.Point(126, 27)
        Me.txtClavSit.MaxLength = 2
        Me.txtClavSit.Name = "txtClavSit"
        Me.txtClavSit.Size = New System.Drawing.Size(110, 20)
        Me.txtClavSit.TabIndex = 0
        Me.txtClavSit.WatermarkText = "Sólo dos caracteres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descripción:"
        '
        'txtDes
        '
        '
        '
        '
        Me.txtDes.Border.Class = "TextBoxBorder"
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.FocusHighlightEnabled = True
        Me.txtDes.Location = New System.Drawing.Point(126, 69)
        Me.txtDes.MaxLength = 50
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(311, 20)
        Me.txtDes.TabIndex = 1
        Me.txtDes.WatermarkText = "Escriba la descripción de la situación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Algoritmo:"
        '
        'cmbAlg
        '
        Me.cmbAlg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAlg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAlg.DisplayMember = "Text"
        Me.cmbAlg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAlg.FocusHighlightEnabled = True
        Me.cmbAlg.FormattingEnabled = True
        Me.cmbAlg.ItemHeight = 14
        Me.cmbAlg.Location = New System.Drawing.Point(126, 117)
        Me.cmbAlg.Name = "cmbAlg"
        Me.cmbAlg.Size = New System.Drawing.Size(311, 20)
        Me.cmbAlg.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tipo:"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(267, 214)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(115, 32)
        Me.cmdCance.TabIndex = 5
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(122, 214)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(115, 32)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Guardar"
        '
        'cmbtipo
        '
        Me.cmbtipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo.DisplayMember = "Text"
        Me.cmbtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipo.FocusHighlightEnabled = True
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.ItemHeight = 14
        Me.cmbtipo.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cmbtipo.Location = New System.Drawing.Point(126, 158)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(311, 20)
        Me.cmbtipo.TabIndex = 3
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Medición"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Padrón"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Hidrómetro"
        '
        'frmAgrSit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbAlg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClavSit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmAgrSit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la Situación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClavSit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAlg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbtipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
End Class
