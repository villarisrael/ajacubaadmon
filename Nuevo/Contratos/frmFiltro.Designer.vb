<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltro
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
        Me.txtBus = New System.Windows.Forms.TextBox
        Me.lblL = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtBus
        '
        Me.txtBus.Location = New System.Drawing.Point(24, 36)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.Size = New System.Drawing.Size(337, 20)
        Me.txtBus.TabIndex = 0
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Location = New System.Drawing.Point(24, 17)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(0, 13)
        Me.lblL.TabIndex = 1
        '
        'frmFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 89)
        Me.Controls.Add(Me.lblL)
        Me.Controls.Add(Me.txtBus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBus As System.Windows.Forms.TextBox
    Friend WithEvents lblL As System.Windows.Forms.Label
End Class
