<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagrcuofij
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
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.IIsanea = New DevComponents.Editors.DoubleInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.IIAlcanta = New DevComponents.Editors.DoubleInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.IIano = New DevComponents.Editors.IntegerInput()
        Me.IIcuoSM = New DevComponents.Editors.DoubleInput()
        Me.IIcuodinero = New DevComponents.Editors.DoubleInput()
        CType(Me.IIsanea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIAlcanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIcuoSM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIcuodinero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(214, 252)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 46)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(109, 252)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(87, 46)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        '
        'IIsanea
        '
        '
        '
        '
        Me.IIsanea.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIsanea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIsanea.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIsanea.Increment = 1.0R
        Me.IIsanea.Location = New System.Drawing.Point(216, 204)
        Me.IIsanea.Name = "IIsanea"
        Me.IIsanea.ShowUpDown = True
        Me.IIsanea.Size = New System.Drawing.Size(80, 20)
        Me.IIsanea.TabIndex = 4
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(37, 204)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(111, 23)
        Me.LabelX4.TabIndex = 16
        Me.LabelX4.Text = "Saneamiento $"
        '
        'IIAlcanta
        '
        '
        '
        '
        Me.IIAlcanta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIAlcanta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIAlcanta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIAlcanta.Increment = 1.0R
        Me.IIAlcanta.Location = New System.Drawing.Point(216, 163)
        Me.IIAlcanta.Name = "IIAlcanta"
        Me.IIAlcanta.ShowUpDown = True
        Me.IIAlcanta.Size = New System.Drawing.Size(80, 20)
        Me.IIAlcanta.TabIndex = 3
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(37, 161)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(111, 23)
        Me.LabelX3.TabIndex = 14
        Me.LabelX3.Text = "Alcantarillado $"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(37, 117)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(111, 23)
        Me.LabelX2.TabIndex = 11
        Me.LabelX2.Text = "Cuota de Agua $"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(37, 74)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(111, 23)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Cuota de Agua SM"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(37, 33)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(111, 23)
        Me.LabelX5.TabIndex = 20
        Me.LabelX5.Text = "Año"
        '
        'IIano
        '
        '
        '
        '
        Me.IIano.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIano.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIano.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIano.Location = New System.Drawing.Point(216, 36)
        Me.IIano.MaxValue = 9999999
        Me.IIano.MinValue = 0
        Me.IIano.Name = "IIano"
        Me.IIano.ShowUpDown = True
        Me.IIano.Size = New System.Drawing.Size(80, 20)
        Me.IIano.TabIndex = 0
        '
        'IIcuoSM
        '
        '
        '
        '
        Me.IIcuoSM.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIcuoSM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIcuoSM.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIcuoSM.Increment = 1.0R
        Me.IIcuoSM.Location = New System.Drawing.Point(214, 77)
        Me.IIcuoSM.Name = "IIcuoSM"
        Me.IIcuoSM.ShowUpDown = True
        Me.IIcuoSM.Size = New System.Drawing.Size(80, 20)
        Me.IIcuoSM.TabIndex = 1
        '
        'IIcuodinero
        '
        '
        '
        '
        Me.IIcuodinero.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIcuodinero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIcuodinero.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIcuodinero.Increment = 1.0R
        Me.IIcuodinero.Location = New System.Drawing.Point(214, 117)
        Me.IIcuodinero.Name = "IIcuodinero"
        Me.IIcuodinero.ShowUpDown = True
        Me.IIcuodinero.Size = New System.Drawing.Size(80, 20)
        Me.IIcuodinero.TabIndex = 2
        '
        'frmagrcuofij
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 356)
        Me.Controls.Add(Me.IIcuodinero)
        Me.Controls.Add(Me.IIcuoSM)
        Me.Controls.Add(Me.IIano)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.IIsanea)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.IIAlcanta)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Name = "frmagrcuofij"
        Me.Text = "Agergar cuota fija"
        CType(Me.IIsanea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIAlcanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIcuoSM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIcuodinero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents IIsanea As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IIAlcanta As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IIano As DevComponents.Editors.IntegerInput
    Friend WithEvents IIcuoSM As DevComponents.Editors.DoubleInput
    Friend WithEvents IIcuodinero As DevComponents.Editors.DoubleInput
End Class
