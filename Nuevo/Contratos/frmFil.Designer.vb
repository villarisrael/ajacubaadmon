<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFil))
        Me.txtCampo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdOpL = New DevComponents.DotNetBar.ButtonX
        Me.cmbReg = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblAnd = New System.Windows.Forms.Label
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'txtCampo
        '
        '
        '
        '
        Me.txtCampo.Border.Class = "TextBoxBorder"
        Me.txtCampo.FocusHighlightEnabled = True
        Me.txtCampo.Location = New System.Drawing.Point(12, 26)
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(167, 20)
        Me.txtCampo.TabIndex = 1
        '
        'cmdOpL
        '
        Me.cmdOpL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdOpL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdOpL.Location = New System.Drawing.Point(199, 26)
        Me.cmdOpL.Name = "cmdOpL"
        Me.cmdOpL.PulseSpeed = 30
        Me.cmdOpL.Size = New System.Drawing.Size(45, 20)
        Me.cmdOpL.TabIndex = 2
        Me.cmdOpL.Text = "="
        '
        'cmbReg
        '
        Me.cmbReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReg.DisplayMember = "Text"
        Me.cmbReg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReg.FocusHighlightEnabled = True
        Me.cmbReg.FormattingEnabled = True
        Me.cmbReg.ItemHeight = 14
        Me.cmbReg.Location = New System.Drawing.Point(260, 26)
        Me.cmbReg.Name = "cmbReg"
        Me.cmbReg.Size = New System.Drawing.Size(167, 20)
        Me.cmbReg.TabIndex = 3
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(13, 7)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(26, 13)
        Me.lblAnd.TabIndex = 0
        Me.lblAnd.Text = "And"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Location = New System.Drawing.Point(330, 52)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 30
        Me.cmdAcept.Size = New System.Drawing.Size(97, 23)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Aceptar"
        '
        'frmFil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 79)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.cmbReg)
        Me.Controls.Add(Me.cmdOpL)
        Me.Controls.Add(Me.txtCampo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmFil"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtrar campo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCampo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdOpL As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbReg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblAnd As System.Windows.Forms.Label
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
