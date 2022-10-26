<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrTipSer
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
        Me.txtClavSer = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbTipUsu = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAlertCon = New DevComponents.Editors.IntegerInput
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkCuoFij = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        CType(Me.txtAlertCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Clave del servicio:"
        '
        'txtClavSer
        '
        '
        '
        '
        Me.txtClavSer.Border.Class = "TextBoxBorder"
        Me.txtClavSer.Location = New System.Drawing.Point(127, 33)
        Me.txtClavSer.MaxLength = 3
        Me.txtClavSer.Name = "txtClavSer"
        Me.txtClavSer.Size = New System.Drawing.Size(110, 20)
        Me.txtClavSer.TabIndex = 0
        Me.txtClavSer.WatermarkText = "Sólo tres caracteres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción:"
        '
        'txtDes
        '
        '
        '
        '
        Me.txtDes.Border.Class = "TextBoxBorder"
        Me.txtDes.Location = New System.Drawing.Point(127, 76)
        Me.txtDes.MaxLength = 50
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(223, 20)
        Me.txtDes.TabIndex = 1
        Me.txtDes.WatermarkText = "Escriba la descripción del servicio"
        '
        'cmbTipUsu
        '
        Me.cmbTipUsu.DisplayMember = "Text"
        Me.cmbTipUsu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipUsu.FormattingEnabled = True
        Me.cmbTipUsu.ItemHeight = 14
        Me.cmbTipUsu.Location = New System.Drawing.Point(127, 118)
        Me.cmbTipUsu.Name = "cmbTipUsu"
        Me.cmbTipUsu.Size = New System.Drawing.Size(158, 20)
        Me.cmbTipUsu.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tipo de usuario:"
        '
        'txtAlertCon
        '
        '
        '
        '
        Me.txtAlertCon.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAlertCon.Location = New System.Drawing.Point(127, 160)
        Me.txtAlertCon.Name = "txtAlertCon"
        Me.txtAlertCon.ShowUpDown = True
        Me.txtAlertCon.Size = New System.Drawing.Size(80, 20)
        Me.txtAlertCon.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Alerta Consumo:"
        '
        'chkCuoFij
        '
        Me.chkCuoFij.Location = New System.Drawing.Point(127, 200)
        Me.chkCuoFij.Name = "chkCuoFij"
        Me.chkCuoFij.Size = New System.Drawing.Size(75, 23)
        Me.chkCuoFij.TabIndex = 4
        Me.chkCuoFij.Text = "Cuota Fija"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Location = New System.Drawing.Point(196, 244)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(115, 23)
        Me.cmdCance.TabIndex = 6
        Me.cmdCance.Text = "Cancelar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Location = New System.Drawing.Point(51, 244)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(115, 23)
        Me.cmdAcept.TabIndex = 5
        Me.cmdAcept.Text = "Guardar"
        '
        'frmAgrTipSer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 310)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.chkCuoFij)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAlertCon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipUsu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClavSer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrTipSer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del tipo de servicio"
        CType(Me.txtAlertCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClavSer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbTipUsu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlertCon As DevComponents.Editors.IntegerInput
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkCuoFij As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
End Class
