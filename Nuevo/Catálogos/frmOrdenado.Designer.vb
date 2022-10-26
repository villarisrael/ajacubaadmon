<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenado))
        Me.cmbCampo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.cmdSal = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'cmbCampo
        '
        Me.cmbCampo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCampo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCampo.DisplayMember = "Text"
        Me.cmbCampo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCampo.FocusHighlightEnabled = True
        Me.cmbCampo.FormattingEnabled = True
        Me.cmbCampo.ItemHeight = 14
        Me.cmbCampo.Location = New System.Drawing.Point(87, 24)
        Me.cmbCampo.Name = "cmbCampo"
        Me.cmbCampo.Size = New System.Drawing.Size(322, 20)
        Me.cmbCampo.TabIndex = 0
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(146, 67)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 30
        Me.cmdAcept.Size = New System.Drawing.Size(93, 42)
        Me.cmdAcept.TabIndex = 1
        Me.cmdAcept.Text = "ACEPTAR"
        '
        'cmdSal
        '
        Me.cmdSal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSal.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSal.Location = New System.Drawing.Point(257, 67)
        Me.cmdSal.Name = "cmdSal"
        Me.cmdSal.PulseSpeed = 30
        Me.cmdSal.Size = New System.Drawing.Size(93, 42)
        Me.cmdSal.TabIndex = 2
        Me.cmdSal.Text = "SALIR"
        '
        'frmOrdenado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 121)
        Me.Controls.Add(Me.cmdSal)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.cmbCampo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmOrdenado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDENAR POR"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbCampo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdSal As DevComponents.DotNetBar.ButtonX
End Class
