<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRob
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdSig = New DevComponents.DotNetBar.ButtonX
        Me.cmbConsulta = New System.Windows.Forms.ListBox
        Me.cmbCol = New System.Windows.Forms.ListBox
        Me.cmdQuitT = New DevComponents.DotNetBar.ButtonX
        Me.cmdAgrT = New DevComponents.DotNetBar.ButtonX
        Me.cmdQuit = New DevComponents.DotNetBar.ButtonX
        Me.cmdAgr = New DevComponents.DotNetBar.ButtonX
        Me.cmdAnterior = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(37, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Seleccione los campos que contrendrá la consulta"
        '
        'cmdSig
        '
        Me.cmdSig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSig.Location = New System.Drawing.Point(132, 200)
        Me.cmdSig.Name = "cmdSig"
        Me.cmdSig.Size = New System.Drawing.Size(75, 23)
        Me.cmdSig.TabIndex = 24
        Me.cmdSig.Text = "Siguiente"
        '
        'cmbConsulta
        '
        Me.cmbConsulta.FormattingEnabled = True
        Me.cmbConsulta.Location = New System.Drawing.Point(197, 36)
        Me.cmbConsulta.Name = "cmbConsulta"
        Me.cmbConsulta.Size = New System.Drawing.Size(130, 147)
        Me.cmbConsulta.TabIndex = 23
        '
        'cmbCol
        '
        Me.cmbCol.FormattingEnabled = True
        Me.cmbCol.Location = New System.Drawing.Point(22, 36)
        Me.cmbCol.Name = "cmbCol"
        Me.cmbCol.Size = New System.Drawing.Size(130, 147)
        Me.cmbCol.TabIndex = 22
        '
        'cmdQuitT
        '
        Me.cmdQuitT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdQuitT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdQuitT.Image = Global.Administativo.My.Resources.Resources._2leftarrow
        Me.cmdQuitT.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdQuitT.Location = New System.Drawing.Point(158, 161)
        Me.cmdQuitT.Name = "cmdQuitT"
        Me.cmdQuitT.Size = New System.Drawing.Size(33, 24)
        Me.cmdQuitT.TabIndex = 21
        '
        'cmdAgrT
        '
        Me.cmdAgrT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAgrT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAgrT.Image = Global.Administativo.My.Resources.Resources._2rightarrow
        Me.cmdAgrT.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdAgrT.Location = New System.Drawing.Point(158, 126)
        Me.cmdAgrT.Name = "cmdAgrT"
        Me.cmdAgrT.Size = New System.Drawing.Size(33, 24)
        Me.cmdAgrT.TabIndex = 20
        '
        'cmdQuit
        '
        Me.cmdQuit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdQuit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdQuit.Image = Global.Administativo.My.Resources.Resources._1leftarrow
        Me.cmdQuit.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdQuit.Location = New System.Drawing.Point(158, 91)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(33, 24)
        Me.cmdQuit.TabIndex = 19
        '
        'cmdAgr
        '
        Me.cmdAgr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAgr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAgr.Image = Global.Administativo.My.Resources.Resources._1rightarrow
        Me.cmdAgr.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdAgr.Location = New System.Drawing.Point(158, 56)
        Me.cmdAgr.Name = "cmdAgr"
        Me.cmdAgr.Size = New System.Drawing.Size(33, 24)
        Me.cmdAgr.TabIndex = 18
        '
        'cmdAnterior
        '
        Me.cmdAnterior.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAnterior.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAnterior.Location = New System.Drawing.Point(40, 200)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 26
        Me.cmdAnterior.Text = "Anterior"
        '
        'ControlRob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSig)
        Me.Controls.Add(Me.cmbConsulta)
        Me.Controls.Add(Me.cmbCol)
        Me.Controls.Add(Me.cmdQuitT)
        Me.Controls.Add(Me.cmdAgrT)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdAgr)
        Me.Name = "ControlRob"
        Me.Size = New System.Drawing.Size(346, 238)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSig As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbConsulta As System.Windows.Forms.ListBox
    Friend WithEvents cmbCol As System.Windows.Forms.ListBox
    Friend WithEvents cmdQuitT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAgrT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdQuit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAgr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAnterior As DevComponents.DotNetBar.ButtonX

End Class
