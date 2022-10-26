<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgrcuo
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.IIRangoinf = New DevComponents.Editors.IntegerInput()
        Me.IIRangoSup = New DevComponents.Editors.IntegerInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.DISM = New DevComponents.Editors.DoubleInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.dim3 = New DevComponents.Editors.DoubleInput()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.IIRangoinf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIRangoSup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dim3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 43)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(111, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Rango Inferior"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 86)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(111, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Rango Superior"
        '
        'IIRangoinf
        '
        '
        '
        '
        Me.IIRangoinf.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIRangoinf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIRangoinf.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIRangoinf.Location = New System.Drawing.Point(191, 45)
        Me.IIRangoinf.MaxValue = 9999999
        Me.IIRangoinf.MinValue = 0
        Me.IIRangoinf.Name = "IIRangoinf"
        Me.IIRangoinf.ShowUpDown = True
        Me.IIRangoinf.Size = New System.Drawing.Size(80, 20)
        Me.IIRangoinf.TabIndex = 2
        '
        'IIRangoSup
        '
        '
        '
        '
        Me.IIRangoSup.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIRangoSup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIRangoSup.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIRangoSup.Location = New System.Drawing.Point(191, 86)
        Me.IIRangoSup.Name = "IIRangoSup"
        Me.IIRangoSup.ShowUpDown = True
        Me.IIRangoSup.Size = New System.Drawing.Size(80, 20)
        Me.IIRangoSup.TabIndex = 3
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 130)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(111, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Pago M3 SM"
        '
        'DISM
        '
        '
        '
        '
        Me.DISM.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DISM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DISM.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DISM.Increment = 1.0R
        Me.DISM.Location = New System.Drawing.Point(191, 132)
        Me.DISM.Name = "DISM"
        Me.DISM.ShowUpDown = True
        Me.DISM.Size = New System.Drawing.Size(80, 20)
        Me.DISM.TabIndex = 5
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 173)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(111, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Pago M3 $"
        '
        'dim3
        '
        '
        '
        '
        Me.dim3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dim3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dim3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dim3.Increment = 1.0R
        Me.dim3.Location = New System.Drawing.Point(191, 173)
        Me.dim3.Name = "dim3"
        Me.dim3.ShowUpDown = True
        Me.dim3.Size = New System.Drawing.Size(80, 20)
        Me.dim3.TabIndex = 7
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(189, 221)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 46)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(84, 221)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(87, 46)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "Aceptar"
        '
        'FrmAgrcuo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 312)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.dim3)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.DISM)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.IIRangoSup)
        Me.Controls.Add(Me.IIRangoinf)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Name = "FrmAgrcuo"
        Me.Text = "Agregar Cuota"
        CType(Me.IIRangoinf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIRangoSup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dim3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IIRangoinf As DevComponents.Editors.IntegerInput
    Friend WithEvents IIRangoSup As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DISM As DevComponents.Editors.DoubleInput
    Friend WithEvents dim3 As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
End Class
