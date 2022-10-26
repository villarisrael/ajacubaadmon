<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconceptoscxc
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
        Me.Catalogo1 = New Administativo.catalogo
        Me.SuspendLayout()
        '
        'Catalogo1
        '
        Me.Catalogo1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Catalogo1.Location = New System.Drawing.Point(-2, 0)
        Me.Catalogo1.Name = "Catalogo1"
        Me.Catalogo1.Size = New System.Drawing.Size(724, 511)
        Me.Catalogo1.TabIndex = 0
        '
        'frmconceptoscxc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 523)
        Me.Controls.Add(Me.Catalogo1)
        Me.Name = "frmconceptoscxc"
        Me.Text = "Conceptos de Cuentas x Cobrar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Catalogo1 As Administativo.catalogo
End Class
