<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpEstC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpEstC))
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.MC2 = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
        Me.MC1 = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
        Me.chkDetalle = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCancel.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdCancel.Location = New System.Drawing.Point(248, 240)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.PulseSpeed = 30
        Me.cmdCancel.Size = New System.Drawing.Size(153, 39)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "SALIR"
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(54, 240)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.PulseSpeed = 30
        Me.cmdImp.Size = New System.Drawing.Size(153, 39)
        Me.cmdImp.TabIndex = 3
        Me.cmdImp.Text = "IMPRIMIR"
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.Location = New System.Drawing.Point(258, 55)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(169, 26)
        Me.ReflectionLabel2.TabIndex = 11
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>FECHA FINAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'ReflectionLabel3
        '
        Me.ReflectionLabel3.Location = New System.Drawing.Point(136, 23)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(183, 37)
        Me.ReflectionLabel3.TabIndex = 12
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>RANGO A IMPRIMIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.Location = New System.Drawing.Point(27, 55)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(169, 26)
        Me.ReflectionLabel1.TabIndex = 13
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>FECHA INICIO</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'MC2
        '
        Me.MC2.AnnuallyMarkedDates = New Date(-1) {}
        Me.MC2.AutoSize = True
        '
        '
        '
        Me.MC2.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MC2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderBottomWidth = 1
        Me.MC2.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MC2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderLeftWidth = 1
        Me.MC2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderRightWidth = 1
        Me.MC2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC2.BackgroundStyle.BorderTopWidth = 1
        Me.MC2.DisplayMonth = New Date(2008, 11, 1, 0, 0, 0, 0)
        Me.MC2.Location = New System.Drawing.Point(259, 81)
        Me.MC2.MarkedDates = New Date(-1) {}
        Me.MC2.MonthlyMarkedDates = New Date(-1) {}
        Me.MC2.Name = "MC2"
        '
        '
        '
        Me.MC2.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.MC2.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.MC2.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.MC2.Size = New System.Drawing.Size(170, 128)
        Me.MC2.TabIndex = 1
        Me.MC2.Text = "MonthCalendarAdv1"
        '
        'MC1
        '
        Me.MC1.AnnuallyMarkedDates = New Date(-1) {}
        Me.MC1.AutoSize = True
        '
        '
        '
        Me.MC1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MC1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderBottomWidth = 1
        Me.MC1.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MC1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderLeftWidth = 1
        Me.MC1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderRightWidth = 1
        Me.MC1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MC1.BackgroundStyle.BorderTopWidth = 1
        Me.MC1.DisplayMonth = New Date(2008, 11, 1, 0, 0, 0, 0)
        Me.MC1.Location = New System.Drawing.Point(26, 81)
        Me.MC1.MarkedDates = New Date(-1) {}
        Me.MC1.MonthlyMarkedDates = New Date(-1) {}
        Me.MC1.Name = "MC1"
        '
        '
        '
        Me.MC1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.MC1.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.MC1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.MC1.Size = New System.Drawing.Size(170, 128)
        Me.MC1.TabIndex = 0
        Me.MC1.Text = "FECHA 1"
        '
        'chkDetalle
        '
        Me.chkDetalle.Location = New System.Drawing.Point(26, 215)
        Me.chkDetalle.Name = "chkDetalle"
        Me.chkDetalle.Size = New System.Drawing.Size(212, 25)
        Me.chkDetalle.TabIndex = 2
        Me.chkDetalle.Text = "MOSTRAR DETALLES"
        '
        'frmImpEstC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 291)
        Me.Controls.Add(Me.chkDetalle)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdImp)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Controls.Add(Me.ReflectionLabel3)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.MC2)
        Me.Controls.Add(Me.MC1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmImpEstC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESTADÍSTICAS POR CALIDAD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents MC2 As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents MC1 As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents chkDetalle As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
