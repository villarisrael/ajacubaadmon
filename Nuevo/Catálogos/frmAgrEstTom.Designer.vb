<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrEstTom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrEstTom))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtId_est = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescrip = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cpEst = New DevComponents.DotNetBar.ColorPickerButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkMostrar = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID_Estado:"
        '
        'txtId_est
        '
        Me.txtId_est.AcceptsReturn = True
        '
        '
        '
        Me.txtId_est.Border.Class = "TextBoxBorder"
        Me.txtId_est.FocusHighlightEnabled = True
        Me.txtId_est.Location = New System.Drawing.Point(128, 21)
        Me.txtId_est.MaxLength = 3
        Me.txtId_est.Name = "txtId_est"
        Me.txtId_est.Size = New System.Drawing.Size(111, 20)
        Me.txtId_est.TabIndex = 0
        Me.txtId_est.WatermarkText = "Sólo números"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción:"
        '
        'txtDescrip
        '
        Me.txtDescrip.AcceptsReturn = True
        '
        '
        '
        Me.txtDescrip.Border.Class = "TextBoxBorder"
        Me.txtDescrip.FocusHighlightEnabled = True
        Me.txtDescrip.Location = New System.Drawing.Point(128, 59)
        Me.txtDescrip.MaxLength = 500
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(188, 20)
        Me.txtDescrip.TabIndex = 1
        Me.txtDescrip.WatermarkText = "Descripción del estado"
        '
        'cpEst
        '
        Me.cpEst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cpEst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cpEst.Image = CType(resources.GetObject("cpEst.Image"), System.Drawing.Image)
        Me.cpEst.Location = New System.Drawing.Point(128, 97)
        Me.cpEst.Name = "cpEst"
        Me.cpEst.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.cpEst.Size = New System.Drawing.Size(60, 23)
        Me.cpEst.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Color:"
        '
        'chkMostrar
        '
        Me.chkMostrar.Location = New System.Drawing.Point(128, 138)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(75, 23)
        Me.chkMostrar.TabIndex = 3
        Me.chkMostrar.Text = "Mostrar"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Location = New System.Drawing.Point(201, 197)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(115, 23)
        Me.cmdCance.TabIndex = 5
        Me.cmdCance.Text = "Cancelar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Location = New System.Drawing.Point(56, 197)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(115, 23)
        Me.cmdAcept.TabIndex = 4
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrEstTom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 246)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.chkMostrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cpEst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_est)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrEstTom"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de estado de toma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId_est As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cpEst As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkMostrar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
