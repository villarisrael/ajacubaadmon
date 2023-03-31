Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMREPcat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMREPcat))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.StepIndicator1 = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me.fecini = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.fecfinal = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.ChkEstadistica = New System.Windows.Forms.CheckBox()
        Me.ChkNuevaEstadistica = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(181, 18)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(130, 23)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "mes de inicio"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(428, 196)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 46)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.Location = New System.Drawing.Point(318, 196)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 46)
        Me.BtnAceptar.TabIndex = 10
        Me.BtnAceptar.Text = "Aceptar"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(389, 18)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(130, 23)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "mes final"
        '
        'StepIndicator1
        '
        Me.StepIndicator1.Location = New System.Drawing.Point(111, 279)
        Me.StepIndicator1.Name = "StepIndicator1"
        Me.StepIndicator1.Size = New System.Drawing.Size(369, 32)
        Me.StepIndicator1.StepCount = 15
        Me.StepIndicator1.TabIndex = 15
        Me.StepIndicator1.Text = "StepIndicator1"
        '
        'fecini
        '
        Me.fecini.AutoSize = True
        '
        '
        '
        Me.fecini.BackgroundStyle.Class = "MonthCalendarAdv"
        Me.fecini.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.fecini.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecini.ContainerControlProcessDialogKey = True
        Me.fecini.DisplayMonth = New Date(2019, 3, 1, 0, 0, 0, 0)
        Me.fecini.Location = New System.Drawing.Point(181, 47)
        Me.fecini.Name = "fecini"
        '
        '
        '
        Me.fecini.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fecini.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fecini.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fecini.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecini.Size = New System.Drawing.Size(170, 131)
        Me.fecini.TabIndex = 16
        Me.fecini.Text = "MonthCalendarAdv1"
        '
        'fecfinal
        '
        Me.fecfinal.AutoSize = True
        '
        '
        '
        Me.fecfinal.BackgroundStyle.Class = "MonthCalendarAdv"
        Me.fecfinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.fecfinal.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecfinal.ContainerControlProcessDialogKey = True
        Me.fecfinal.DisplayMonth = New Date(2019, 3, 1, 0, 0, 0, 0)
        Me.fecfinal.Location = New System.Drawing.Point(368, 47)
        Me.fecfinal.Name = "fecfinal"
        '
        '
        '
        Me.fecfinal.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fecfinal.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fecfinal.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fecfinal.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecfinal.Size = New System.Drawing.Size(170, 131)
        Me.fecfinal.TabIndex = 17
        Me.fecfinal.Text = "MonthCalendarAdv2"
        '
        'ChkEstadistica
        '
        Me.ChkEstadistica.AutoSize = True
        Me.ChkEstadistica.Location = New System.Drawing.Point(23, 63)
        Me.ChkEstadistica.Name = "ChkEstadistica"
        Me.ChkEstadistica.Size = New System.Drawing.Size(77, 17)
        Me.ChkEstadistica.TabIndex = 18
        Me.ChkEstadistica.Text = "Estadistica"
        Me.ChkEstadistica.UseVisualStyleBackColor = True
        '
        'ChkNuevaEstadistica
        '
        Me.ChkNuevaEstadistica.AutoSize = True
        Me.ChkNuevaEstadistica.Location = New System.Drawing.Point(23, 131)
        Me.ChkNuevaEstadistica.Name = "ChkNuevaEstadistica"
        Me.ChkNuevaEstadistica.Size = New System.Drawing.Size(112, 17)
        Me.ChkNuevaEstadistica.TabIndex = 19
        Me.ChkNuevaEstadistica.Text = "Nueva Estadistica"
        Me.ChkNuevaEstadistica.UseVisualStyleBackColor = True
        '
        'FRMREPcat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 337)
        Me.Controls.Add(Me.ChkNuevaEstadistica)
        Me.Controls.Add(Me.ChkEstadistica)
        Me.Controls.Add(Me.fecfinal)
        Me.Controls.Add(Me.fecini)
        Me.Controls.Add(Me.StepIndicator1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Name = "FRMREPcat"
        Me.Text = "Estadistica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As LabelX
    Friend WithEvents BtnCancelar As ButtonX
    Friend WithEvents BtnAceptar As ButtonX
    Friend WithEvents LabelX2 As LabelX
    Friend WithEvents StepIndicator1 As Controls.StepIndicator
    Friend WithEvents fecini As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents fecfinal As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents ChkEstadistica As CheckBox
    Friend WithEvents ChkNuevaEstadistica As CheckBox
End Class
