<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstCuenta))
        Me.chkCierres = New System.Windows.Forms.CheckBox
        Me.chkLecturas = New System.Windows.Forms.CheckBox
        Me.chkOrdt = New System.Windows.Forms.CheckBox
        Me.chkCargos = New System.Windows.Forms.CheckBox
        Me.chkAbonos = New System.Windows.Forms.CheckBox
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX
        Me.cmdSal = New DevComponents.DotNetBar.ButtonX
        Me.txtLect = New DevComponents.Editors.IntegerInput
        Me.lbl1 = New DevComponents.DotNetBar.LabelX
        CType(Me.txtLect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCierres
        '
        Me.chkCierres.AutoSize = True
        Me.chkCierres.Location = New System.Drawing.Point(42, 22)
        Me.chkCierres.Name = "chkCierres"
        Me.chkCierres.Size = New System.Drawing.Size(117, 17)
        Me.chkCierres.TabIndex = 0
        Me.chkCierres.Text = "Estados de cuenta"
        Me.chkCierres.UseVisualStyleBackColor = True
        '
        'chkLecturas
        '
        Me.chkLecturas.AutoSize = True
        Me.chkLecturas.Location = New System.Drawing.Point(42, 63)
        Me.chkLecturas.Name = "chkLecturas"
        Me.chkLecturas.Size = New System.Drawing.Size(69, 17)
        Me.chkLecturas.TabIndex = 1
        Me.chkLecturas.Text = "Lecturas"
        Me.chkLecturas.UseVisualStyleBackColor = True
        '
        'chkOrdt
        '
        Me.chkOrdt.AutoSize = True
        Me.chkOrdt.Location = New System.Drawing.Point(42, 104)
        Me.chkOrdt.Name = "chkOrdt"
        Me.chkOrdt.Size = New System.Drawing.Size(118, 17)
        Me.chkOrdt.TabIndex = 2
        Me.chkOrdt.Text = "Órdenes de trabajo"
        Me.chkOrdt.UseVisualStyleBackColor = True
        '
        'chkCargos
        '
        Me.chkCargos.AutoSize = True
        Me.chkCargos.Location = New System.Drawing.Point(42, 145)
        Me.chkCargos.Name = "chkCargos"
        Me.chkCargos.Size = New System.Drawing.Size(61, 17)
        Me.chkCargos.TabIndex = 3
        Me.chkCargos.Text = "Cargos"
        Me.chkCargos.UseVisualStyleBackColor = True
        '
        'chkAbonos
        '
        Me.chkAbonos.AutoSize = True
        Me.chkAbonos.Location = New System.Drawing.Point(42, 186)
        Me.chkAbonos.Name = "chkAbonos"
        Me.chkAbonos.Size = New System.Drawing.Size(64, 17)
        Me.chkAbonos.TabIndex = 4
        Me.chkAbonos.Text = "Abonos"
        Me.chkAbonos.UseVisualStyleBackColor = True
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(92, 237)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.PulseSpeed = 30
        Me.cmdImp.Size = New System.Drawing.Size(121, 40)
        Me.cmdImp.TabIndex = 5
        Me.cmdImp.Text = "Imprimir"
        '
        'cmdSal
        '
        Me.cmdSal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSal.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.cmdSal.Location = New System.Drawing.Point(241, 237)
        Me.cmdSal.Name = "cmdSal"
        Me.cmdSal.PulseSpeed = 30
        Me.cmdSal.Size = New System.Drawing.Size(121, 40)
        Me.cmdSal.TabIndex = 6
        Me.cmdSal.Text = "Salir"
        '
        'txtLect
        '
        '
        '
        '
        Me.txtLect.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtLect.Location = New System.Drawing.Point(139, 61)
        Me.txtLect.MinValue = 1
        Me.txtLect.Name = "txtLect"
        Me.txtLect.ShowUpDown = True
        Me.txtLect.Size = New System.Drawing.Size(63, 20)
        Me.txtLect.TabIndex = 7
        Me.txtLect.Value = 12
        Me.txtLect.Visible = False
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(210, 64)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(55, 15)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "Lecturas"
        Me.lbl1.Visible = False
        '
        'frmEstCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 289)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtLect)
        Me.Controls.Add(Me.cmdSal)
        Me.Controls.Add(Me.cmdImp)
        Me.Controls.Add(Me.chkAbonos)
        Me.Controls.Add(Me.chkCargos)
        Me.Controls.Add(Me.chkOrdt)
        Me.Controls.Add(Me.chkLecturas)
        Me.Controls.Add(Me.chkCierres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEstCuenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de cuenta"
        CType(Me.txtLect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCierres As System.Windows.Forms.CheckBox
    Friend WithEvents chkLecturas As System.Windows.Forms.CheckBox
    Friend WithEvents chkOrdt As System.Windows.Forms.CheckBox
    Friend WithEvents chkCargos As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbonos As System.Windows.Forms.CheckBox
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdSal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtLect As DevComponents.Editors.IntegerInput
    Friend WithEvents lbl1 As DevComponents.DotNetBar.LabelX
End Class
