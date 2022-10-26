<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoNocapturadas
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.dgfaltantes = New System.Windows.Forms.DataGridView()
        Me.RL1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        CType(Me.dgfaltantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgfaltantes
        '
        Me.dgfaltantes.BackgroundColor = System.Drawing.Color.Black
        Me.dgfaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfaltantes.GridColor = System.Drawing.Color.Black
        Me.dgfaltantes.Location = New System.Drawing.Point(12, 88)
        Me.dgfaltantes.Name = "dgfaltantes"
        Me.dgfaltantes.Size = New System.Drawing.Size(846, 308)
        Me.dgfaltantes.TabIndex = 0
        '
        'RL1
        '
        '
        '
        '
        Me.RL1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RL1.Location = New System.Drawing.Point(12, 12)
        Me.RL1.Name = "RL1"
        Me.RL1.Size = New System.Drawing.Size(322, 70)
        Me.RL1.TabIndex = 1
        Me.RL1.Text = "<b><font size=""+6""><i>Dev</i><font color=""#B02B2C"">Listado faltantes</font></font" &
    "></b>"
        '
        'frmListadoNocapturadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(879, 459)
        Me.Controls.Add(Me.RL1)
        Me.Controls.Add(Me.dgfaltantes)
        Me.Name = "frmListadoNocapturadas"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Listado de Lecturas Faltantes"
        CType(Me.dgfaltantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgfaltantes As System.Windows.Forms.DataGridView
    Friend WithEvents RL1 As DevComponents.DotNetBar.Controls.ReflectionLabel
End Class

