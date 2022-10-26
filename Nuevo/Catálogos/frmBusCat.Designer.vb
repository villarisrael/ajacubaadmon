<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusCat))
        Me.txtBus = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblMsg = New System.Windows.Forms.Label
        Me.Fecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBus
        '
        '
        '
        '
        Me.txtBus.Border.Class = "TextBoxBorder"
        Me.txtBus.Location = New System.Drawing.Point(39, 45)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.Size = New System.Drawing.Size(352, 20)
        Me.txtBus.TabIndex = 0
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(39, 13)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg.TabIndex = 1
        '
        'Fecha
        '
        '
        '
        '
        Me.Fecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Fecha.ButtonDropDown.Visible = True
        Me.Fecha.Location = New System.Drawing.Point(39, 45)
        '
        '
        '
        Me.Fecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Fecha.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Fecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Fecha.MonthCalendar.DisplayMonth = New Date(2008, 10, 1, 0, 0, 0, 0)
        Me.Fecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Fecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fecha.MonthCalendar.TodayButtonVisible = True
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(200, 20)
        Me.Fecha.TabIndex = 2
        '
        'frmBusCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 96)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtBus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBusCat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        Me.TopMost = True
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Fecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
