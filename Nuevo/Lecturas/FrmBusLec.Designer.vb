<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusLec
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
        Me.Lbltitulo = New DevComponents.DotNetBar.LabelX
        Me.TxtBus = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuspendLayout()
        '
        'Lbltitulo
        '
        Me.Lbltitulo.Location = New System.Drawing.Point(24, 10)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(418, 23)
        Me.Lbltitulo.TabIndex = 1
        Me.Lbltitulo.Text = "LabelX1"
        '
        'TxtBus
        '
        '
        '
        '
        Me.TxtBus.Border.Class = "TextBoxBorder"
        Me.TxtBus.Location = New System.Drawing.Point(27, 50)
        Me.TxtBus.Name = "TxtBus"
        Me.TxtBus.Size = New System.Drawing.Size(440, 20)
        Me.TxtBus.TabIndex = 0
        '
        'FrmBusLec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 115)
        Me.Controls.Add(Me.TxtBus)
        Me.Controls.Add(Me.Lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusLec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBusLec"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbltitulo As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBus As DevComponents.DotNetBar.Controls.TextBoxX
End Class
