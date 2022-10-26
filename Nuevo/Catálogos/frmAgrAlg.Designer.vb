<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrAlg
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
        Me.txtDescrip = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbAcc = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem5 = New DevComponents.Editors.ComboItem
        Me.ComboItem6 = New DevComponents.Editors.ComboItem
        Me.ComboItem7 = New DevComponents.Editors.ComboItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNoMes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripción:"
        '
        'txtDescrip
        '
        '
        '
        '
        Me.txtDescrip.Border.Class = "TextBoxBorder"
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.FocusHighlightEnabled = True
        Me.txtDescrip.Location = New System.Drawing.Point(121, 27)
        Me.txtDescrip.MaxLength = 100
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(230, 20)
        Me.txtDescrip.TabIndex = 0
        Me.txtDescrip.WatermarkText = "Escribe la descripción del algoritmo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Acción:"
        '
        'cmbAcc
        '
        Me.cmbAcc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAcc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAcc.DisplayMember = "Text"
        Me.cmbAcc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAcc.FocusHighlightEnabled = True
        Me.cmbAcc.FormattingEnabled = True
        Me.cmbAcc.ItemHeight = 14
        Me.cmbAcc.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.cmbAcc.Location = New System.Drawing.Point(121, 67)
        Me.cmbAcc.Name = "cmbAcc"
        Me.cmbAcc.Size = New System.Drawing.Size(230, 20)
        Me.cmbAcc.TabIndex = 1
        Me.cmbAcc.WatermarkText = "Seleccione una acción"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Promediar"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Minimo"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Cuota 1"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Cuota 2"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Cuota 3"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Cuota 4"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Consumo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Meses:"
        '
        'txtNoMes
        '
        '
        '
        '
        Me.txtNoMes.Border.Class = "TextBoxBorder"
        Me.txtNoMes.FocusHighlightEnabled = True
        Me.txtNoMes.Location = New System.Drawing.Point(121, 103)
        Me.txtNoMes.MaxLength = 2
        Me.txtNoMes.Name = "txtNoMes"
        Me.txtNoMes.Size = New System.Drawing.Size(104, 20)
        Me.txtNoMes.TabIndex = 2
        Me.txtNoMes.WatermarkText = "Número de meses"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(213, 149)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(115, 33)
        Me.cmdCance.TabIndex = 4
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(68, 149)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(115, 33)
        Me.cmdAcept.TabIndex = 3
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrAlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoMes)
        Me.Controls.Add(Me.cmbAcc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrAlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de lo algoritmos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAcc As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoMes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
End Class
