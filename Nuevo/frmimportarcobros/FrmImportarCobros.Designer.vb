<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportarCobros
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
        Me.TxtRuta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.BtnSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.LblTitCaja = New DevComponents.DotNetBar.LabelX
        Me.CmbCaja = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LblTitOficina = New DevComponents.DotNetBar.LabelX
        Me.CmbOficina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LblCopiar = New DevComponents.DotNetBar.LabelX
        Me.BtnCopiar = New DevComponents.DotNetBar.ButtonX
        Me.Dialogo = New System.Windows.Forms.FolderBrowserDialog
        Me.BtnActualizar = New DevComponents.DotNetBar.ButtonX
        Me.DTInicio = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LblFini = New DevComponents.DotNetBar.LabelX
        Me.LblFechafin = New DevComponents.DotNetBar.LabelX
        Me.DtFin = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.BtnCerrar = New DevComponents.DotNetBar.ButtonX
        Me.PG = New DevComponents.DotNetBar.Controls.ProgressBarX
        CType(Me.DTInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtRuta
        '
        '
        '
        '
        Me.TxtRuta.Border.Class = "TextBoxBorder"
        Me.TxtRuta.Location = New System.Drawing.Point(217, 12)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(443, 20)
        Me.TxtRuta.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(2, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(209, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Selecciona la ruta de los archivos externos"
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSeleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSeleccionar.Image = Global.AcquaLiberVista.My.Resources.Resources.kdict
        Me.BtnSeleccionar.Location = New System.Drawing.Point(666, 12)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(25, 22)
        Me.BtnSeleccionar.TabIndex = 2
        '
        'LblTitCaja
        '
        Me.LblTitCaja.BackColor = System.Drawing.Color.Transparent
        Me.LblTitCaja.Location = New System.Drawing.Point(79, 146)
        Me.LblTitCaja.Name = "LblTitCaja"
        Me.LblTitCaja.Size = New System.Drawing.Size(203, 23)
        Me.LblTitCaja.TabIndex = 6
        Me.LblTitCaja.Text = "Caja donde se realizaron los pagos:"
        '
        'CmbCaja
        '
        Me.CmbCaja.DisplayMember = "Text"
        Me.CmbCaja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbCaja.FormattingEnabled = True
        Me.CmbCaja.ItemHeight = 14
        Me.CmbCaja.Location = New System.Drawing.Point(285, 149)
        Me.CmbCaja.Name = "CmbCaja"
        Me.CmbCaja.Size = New System.Drawing.Size(268, 20)
        Me.CmbCaja.TabIndex = 7
        '
        'LblTitOficina
        '
        Me.LblTitOficina.BackColor = System.Drawing.Color.Transparent
        Me.LblTitOficina.Location = New System.Drawing.Point(79, 117)
        Me.LblTitOficina.Name = "LblTitOficina"
        Me.LblTitOficina.Size = New System.Drawing.Size(203, 23)
        Me.LblTitOficina.TabIndex = 4
        Me.LblTitOficina.Text = "Oficina donde se realizaron los pagos:"
        '
        'CmbOficina
        '
        Me.CmbOficina.DisplayMember = "Text"
        Me.CmbOficina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbOficina.FormattingEnabled = True
        Me.CmbOficina.ItemHeight = 14
        Me.CmbOficina.Location = New System.Drawing.Point(285, 120)
        Me.CmbOficina.Name = "CmbOficina"
        Me.CmbOficina.Size = New System.Drawing.Size(268, 20)
        Me.CmbOficina.TabIndex = 5
        '
        'LblCopiar
        '
        Me.LblCopiar.BackColor = System.Drawing.Color.Transparent
        Me.LblCopiar.Location = New System.Drawing.Point(4, 47)
        Me.LblCopiar.Name = "LblCopiar"
        Me.LblCopiar.Size = New System.Drawing.Size(687, 55)
        Me.LblCopiar.TabIndex = 3
        Me.LblCopiar.Text = "Esta opcion copiara los archivos seleccionados de una caja u oficina a la computa" & _
            "dora de manera permanente:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selecciona un rango de fechas y la caja:"
        '
        'BtnCopiar
        '
        Me.BtnCopiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCopiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCopiar.Location = New System.Drawing.Point(127, 332)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(150, 38)
        Me.BtnCopiar.TabIndex = 12
        Me.BtnCopiar.Text = "Copiar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnActualizar.Location = New System.Drawing.Point(283, 332)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(150, 38)
        Me.BtnActualizar.TabIndex = 13
        Me.BtnActualizar.Text = "Actualizar"
        '
        'DTInicio
        '
        '
        '
        '
        Me.DTInicio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTInicio.ButtonDropDown.Visible = True
        Me.DTInicio.Location = New System.Drawing.Point(188, 188)
        '
        '
        '
        Me.DTInicio.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTInicio.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DTInicio.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTInicio.MonthCalendar.DisplayMonth = New Date(2009, 2, 1, 0, 0, 0, 0)
        Me.DTInicio.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTInicio.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTInicio.MonthCalendar.TodayButtonVisible = True
        Me.DTInicio.Name = "DTInicio"
        Me.DTInicio.Size = New System.Drawing.Size(200, 20)
        Me.DTInicio.TabIndex = 9
        '
        'LblFini
        '
        Me.LblFini.Location = New System.Drawing.Point(79, 185)
        Me.LblFini.Name = "LblFini"
        Me.LblFini.Size = New System.Drawing.Size(89, 23)
        Me.LblFini.TabIndex = 8
        Me.LblFini.Text = "Fecha:"
        '
        'LblFechafin
        '
        Me.LblFechafin.Location = New System.Drawing.Point(79, 222)
        Me.LblFechafin.Name = "LblFechafin"
        Me.LblFechafin.Size = New System.Drawing.Size(75, 23)
        Me.LblFechafin.TabIndex = 10
        Me.LblFechafin.Text = "Fecha de Fin"
        Me.LblFechafin.Visible = False
        '
        'DtFin
        '
        '
        '
        '
        Me.DtFin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtFin.ButtonDropDown.Visible = True
        Me.DtFin.Location = New System.Drawing.Point(188, 225)
        '
        '
        '
        Me.DtFin.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DtFin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DtFin.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtFin.MonthCalendar.DisplayMonth = New Date(2009, 2, 1, 0, 0, 0, 0)
        Me.DtFin.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DtFin.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DtFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtFin.MonthCalendar.TodayButtonVisible = True
        Me.DtFin.Name = "DtFin"
        Me.DtFin.Size = New System.Drawing.Size(200, 20)
        Me.DtFin.TabIndex = 11
        Me.DtFin.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCerrar.Location = New System.Drawing.Point(439, 332)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(150, 38)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "Cerrar"
        '
        'PG
        '
        Me.PG.Location = New System.Drawing.Point(79, 281)
        Me.PG.Name = "PG"
        Me.PG.Size = New System.Drawing.Size(581, 23)
        Me.PG.TabIndex = 15
        Me.PG.TextVisible = True
        Me.PG.Visible = False
        '
        'FrmImportarCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 497)
        Me.Controls.Add(Me.PG)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblFechafin)
        Me.Controls.Add(Me.DtFin)
        Me.Controls.Add(Me.LblFini)
        Me.Controls.Add(Me.DTInicio)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.LblTitCaja)
        Me.Controls.Add(Me.CmbCaja)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.LblTitOficina)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.CmbOficina)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Controls.Add(Me.LblCopiar)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportarCobros"
        Me.Text = "Importar Cobros"
        CType(Me.DTInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtRuta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCopiar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblCopiar As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitCaja As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbCaja As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblTitOficina As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbOficina As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Dialogo As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BtnActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DTInicio As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LblFini As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblFechafin As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtFin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents BtnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PG As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
