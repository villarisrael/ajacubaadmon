<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrComu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrComu))
        Me.txtId_com = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNomCom = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCont = New DevComponents.Editors.IntegerInput
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmbMuni = New DevComponents.DotNetBar.Controls.ComboBoxEx
        CType(Me.txtCont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtId_com
        '
        Me.txtId_com.AcceptsReturn = True
        '
        '
        '
        Me.txtId_com.Border.Class = "TextBoxBorder"
        Me.txtId_com.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId_com.FocusHighlightEnabled = True
        Me.txtId_com.Location = New System.Drawing.Point(121, 26)
        Me.txtId_com.MaxLength = 3
        Me.txtId_com.Name = "txtId_com"
        Me.txtId_com.Size = New System.Drawing.Size(111, 20)
        Me.txtId_com.TabIndex = 0
        Me.txtId_com.WatermarkText = "Sólo tres carácteres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID_Comunidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Municipio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre:"
        '
        'txtNomCom
        '
        '
        '
        '
        Me.txtNomCom.Border.Class = "TextBoxBorder"
        Me.txtNomCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomCom.FocusHighlightEnabled = True
        Me.txtNomCom.Location = New System.Drawing.Point(121, 99)
        Me.txtNomCom.MaxLength = 500
        Me.txtNomCom.Name = "txtNomCom"
        Me.txtNomCom.Size = New System.Drawing.Size(275, 20)
        Me.txtNomCom.TabIndex = 2
        Me.txtNomCom.WatermarkText = "Escriba el nombre de la comunidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contrato:"
        '
        'txtCont
        '
        '
        '
        '
        Me.txtCont.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtCont.FocusHighlightEnabled = True
        Me.txtCont.Location = New System.Drawing.Point(121, 135)
        Me.txtCont.MinValue = 0
        Me.txtCont.Name = "txtCont"
        Me.txtCont.ShowUpDown = True
        Me.txtCont.Size = New System.Drawing.Size(68, 20)
        Me.txtCont.TabIndex = 3
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(121, 177)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(87, 43)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Guardar"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(239, 177)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(87, 43)
        Me.cmdCance.TabIndex = 5
        Me.cmdCance.Text = "Terminar"
        '
        'cmbMuni
        '
        Me.cmbMuni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMuni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMuni.DisplayMember = "Text"
        Me.cmbMuni.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMuni.FocusHighlightEnabled = True
        Me.cmbMuni.FormattingEnabled = True
        Me.cmbMuni.ItemHeight = 14
        Me.cmbMuni.Location = New System.Drawing.Point(121, 62)
        Me.cmbMuni.Name = "cmbMuni"
        Me.cmbMuni.Size = New System.Drawing.Size(275, 20)
        Me.cmbMuni.TabIndex = 1
        '
        'frmAgrComu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 248)
        Me.Controls.Add(Me.cmbMuni)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomCom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_com)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrComu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Comunidades"
        CType(Me.txtCont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtId_com As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomCom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCont As DevComponents.Editors.IntegerInput
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbMuni As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
