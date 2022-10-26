<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepCalculoConsumo
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CmdRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.LblRuta = New DevComponents.DotNetBar.LabelX()
        Me.CmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LblDomestico = New DevComponents.DotNetBar.LabelX()
        Me.LblComercial = New DevComponents.DotNetBar.LabelX()
        Me.LblIndustrial = New DevComponents.DotNetBar.LabelX()
        Me.LblPublico = New DevComponents.DotNetBar.LabelX()
        Me.LblGobierno = New DevComponents.DotNetBar.LabelX()
        Me.LblEspeciales = New DevComponents.DotNetBar.LabelX()
        Me.NDomestico = New DevComponents.Editors.IntegerInput()
        Me.NComercial = New DevComponents.Editors.IntegerInput()
        Me.NIndustrial = New DevComponents.Editors.IntegerInput()
        Me.NPublico = New DevComponents.Editors.IntegerInput()
        Me.NGobierno = New DevComponents.Editors.IntegerInput()
        Me.NEspeciales = New DevComponents.Editors.IntegerInput()
        Me.GPFiltro = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.cmbTarifa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtAn = New System.Windows.Forms.TextBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        CType(Me.NDomestico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIndustrial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPublico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NGobierno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NEspeciales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(35, 62)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "Region"
        '
        'CmdRegion
        '
        Me.CmdRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmdRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmdRegion.DisplayMember = "Text"
        Me.CmdRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmdRegion.FocusHighlightEnabled = True
        Me.CmdRegion.FormattingEnabled = True
        Me.CmdRegion.ItemHeight = 14
        Me.CmdRegion.Location = New System.Drawing.Point(129, 63)
        Me.CmdRegion.Name = "CmdRegion"
        Me.CmdRegion.Size = New System.Drawing.Size(327, 20)
        Me.CmdRegion.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(363, 350)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnImprimir.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.BtnImprimir.Location = New System.Drawing.Point(248, 350)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(93, 38)
        Me.BtnImprimir.TabIndex = 6
        Me.BtnImprimir.Text = "Imprimir"
        '
        'LblRuta
        '
        '
        '
        '
        Me.LblRuta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblRuta.Location = New System.Drawing.Point(35, 94)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(75, 23)
        Me.LblRuta.TabIndex = 9
        Me.LblRuta.Text = "Ruta"
        '
        'CmbRuta
        '
        Me.CmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRuta.DisplayMember = "Text"
        Me.CmbRuta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbRuta.FocusHighlightEnabled = True
        Me.CmbRuta.FormattingEnabled = True
        Me.CmbRuta.ItemHeight = 14
        Me.CmbRuta.Location = New System.Drawing.Point(129, 95)
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(243, 20)
        Me.CmbRuta.TabIndex = 2
        '
        'LblDomestico
        '
        Me.LblDomestico.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblDomestico.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblDomestico.Location = New System.Drawing.Point(14, 17)
        Me.LblDomestico.Name = "LblDomestico"
        Me.LblDomestico.Size = New System.Drawing.Size(88, 23)
        Me.LblDomestico.TabIndex = 0
        Me.LblDomestico.Text = "Domestico $ >= "
        '
        'LblComercial
        '
        Me.LblComercial.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblComercial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblComercial.Location = New System.Drawing.Point(14, 46)
        Me.LblComercial.Name = "LblComercial"
        Me.LblComercial.Size = New System.Drawing.Size(88, 23)
        Me.LblComercial.TabIndex = 2
        Me.LblComercial.Text = "Comercial  $ >= "
        '
        'LblIndustrial
        '
        Me.LblIndustrial.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblIndustrial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblIndustrial.Location = New System.Drawing.Point(227, 20)
        Me.LblIndustrial.Name = "LblIndustrial"
        Me.LblIndustrial.Size = New System.Drawing.Size(88, 23)
        Me.LblIndustrial.TabIndex = 4
        Me.LblIndustrial.Text = "Industrial    $ >= "
        '
        'LblPublico
        '
        Me.LblPublico.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblPublico.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblPublico.Location = New System.Drawing.Point(227, 49)
        Me.LblPublico.Name = "LblPublico"
        Me.LblPublico.Size = New System.Drawing.Size(88, 23)
        Me.LblPublico.TabIndex = 6
        Me.LblPublico.Text = "Publico       $ >= "
        '
        'LblGobierno
        '
        Me.LblGobierno.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblGobierno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblGobierno.Location = New System.Drawing.Point(14, 118)
        Me.LblGobierno.Name = "LblGobierno"
        Me.LblGobierno.Size = New System.Drawing.Size(88, 23)
        Me.LblGobierno.TabIndex = 8
        Me.LblGobierno.Text = "Gobierno     $ >= "
        Me.LblGobierno.Visible = False
        '
        'LblEspeciales
        '
        Me.LblEspeciales.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblEspeciales.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblEspeciales.Location = New System.Drawing.Point(14, 147)
        Me.LblEspeciales.Name = "LblEspeciales"
        Me.LblEspeciales.Size = New System.Drawing.Size(88, 23)
        Me.LblEspeciales.TabIndex = 10
        Me.LblEspeciales.Text = "Especiales  $ >= "
        Me.LblEspeciales.Visible = False
        '
        'NDomestico
        '
        '
        '
        '
        Me.NDomestico.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NDomestico.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NDomestico.FocusHighlightEnabled = True
        Me.NDomestico.Location = New System.Drawing.Point(108, 20)
        Me.NDomestico.MinValue = 0
        Me.NDomestico.Name = "NDomestico"
        Me.NDomestico.ShowUpDown = True
        Me.NDomestico.Size = New System.Drawing.Size(113, 20)
        Me.NDomestico.TabIndex = 1
        '
        'NComercial
        '
        '
        '
        '
        Me.NComercial.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NComercial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NComercial.FocusHighlightEnabled = True
        Me.NComercial.Location = New System.Drawing.Point(108, 49)
        Me.NComercial.MinValue = 0
        Me.NComercial.Name = "NComercial"
        Me.NComercial.ShowUpDown = True
        Me.NComercial.Size = New System.Drawing.Size(113, 20)
        Me.NComercial.TabIndex = 3
        '
        'NIndustrial
        '
        '
        '
        '
        Me.NIndustrial.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NIndustrial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NIndustrial.FocusHighlightEnabled = True
        Me.NIndustrial.Location = New System.Drawing.Point(321, 23)
        Me.NIndustrial.MinValue = 0
        Me.NIndustrial.Name = "NIndustrial"
        Me.NIndustrial.ShowUpDown = True
        Me.NIndustrial.Size = New System.Drawing.Size(113, 20)
        Me.NIndustrial.TabIndex = 5
        '
        'NPublico
        '
        '
        '
        '
        Me.NPublico.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NPublico.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NPublico.FocusHighlightEnabled = True
        Me.NPublico.Location = New System.Drawing.Point(321, 52)
        Me.NPublico.MinValue = 0
        Me.NPublico.Name = "NPublico"
        Me.NPublico.ShowUpDown = True
        Me.NPublico.Size = New System.Drawing.Size(113, 20)
        Me.NPublico.TabIndex = 7
        '
        'NGobierno
        '
        '
        '
        '
        Me.NGobierno.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NGobierno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NGobierno.FocusHighlightEnabled = True
        Me.NGobierno.Location = New System.Drawing.Point(108, 121)
        Me.NGobierno.MinValue = 0
        Me.NGobierno.Name = "NGobierno"
        Me.NGobierno.ShowUpDown = True
        Me.NGobierno.Size = New System.Drawing.Size(113, 20)
        Me.NGobierno.TabIndex = 9
        Me.NGobierno.Visible = False
        '
        'NEspeciales
        '
        '
        '
        '
        Me.NEspeciales.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NEspeciales.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NEspeciales.FocusHighlightEnabled = True
        Me.NEspeciales.Location = New System.Drawing.Point(108, 150)
        Me.NEspeciales.MinValue = 0
        Me.NEspeciales.Name = "NEspeciales"
        Me.NEspeciales.ShowUpDown = True
        Me.NEspeciales.Size = New System.Drawing.Size(113, 20)
        Me.NEspeciales.TabIndex = 11
        Me.NEspeciales.Visible = False
        '
        'GPFiltro
        '
        Me.GPFiltro.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPFiltro.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPFiltro.Controls.Add(Me.NEspeciales)
        Me.GPFiltro.Controls.Add(Me.NGobierno)
        Me.GPFiltro.Controls.Add(Me.LblDomestico)
        Me.GPFiltro.Controls.Add(Me.NPublico)
        Me.GPFiltro.Controls.Add(Me.LblComercial)
        Me.GPFiltro.Controls.Add(Me.NIndustrial)
        Me.GPFiltro.Controls.Add(Me.LblIndustrial)
        Me.GPFiltro.Controls.Add(Me.NComercial)
        Me.GPFiltro.Controls.Add(Me.LblPublico)
        Me.GPFiltro.Controls.Add(Me.NDomestico)
        Me.GPFiltro.Controls.Add(Me.LblGobierno)
        Me.GPFiltro.Controls.Add(Me.LblEspeciales)
        Me.GPFiltro.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPFiltro.Location = New System.Drawing.Point(35, 160)
        Me.GPFiltro.Name = "GPFiltro"
        Me.GPFiltro.Size = New System.Drawing.Size(465, 100)
        '
        '
        '
        Me.GPFiltro.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPFiltro.Style.BackColorGradientAngle = 90
        Me.GPFiltro.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPFiltro.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFiltro.Style.BorderBottomWidth = 1
        Me.GPFiltro.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPFiltro.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFiltro.Style.BorderLeftWidth = 1
        Me.GPFiltro.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFiltro.Style.BorderRightWidth = 1
        Me.GPFiltro.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFiltro.Style.BorderTopWidth = 1
        Me.GPFiltro.Style.CornerDiameter = 4
        Me.GPFiltro.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPFiltro.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPFiltro.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPFiltro.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPFiltro.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPFiltro.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPFiltro.TabIndex = 5
        Me.GPFiltro.Text = "Filtrado"
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(85, 1)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(381, 44)
        Me.LblTitulo.TabIndex = 6
        Me.LblTitulo.Text = "<b><font size=""+6"">REPORTE DE CALCULO DE CONSUMO</font></b>"
        '
        'cmbTarifa
        '
        Me.cmbTarifa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTarifa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTarifa.DisplayMember = "Text"
        Me.cmbTarifa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTarifa.FocusHighlightEnabled = True
        Me.cmbTarifa.FormattingEnabled = True
        Me.cmbTarifa.ItemHeight = 14
        Me.cmbTarifa.Location = New System.Drawing.Point(129, 132)
        Me.cmbTarifa.Name = "cmbTarifa"
        Me.cmbTarifa.Size = New System.Drawing.Size(242, 20)
        Me.cmbTarifa.TabIndex = 4
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(35, 131)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(88, 23)
        Me.LabelX3.TabIndex = 9
        Me.LabelX3.Text = "Tarifa"
        '
        'txtAn
        '
        Me.txtAn.Location = New System.Drawing.Point(175, 287)
        Me.txtAn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAn.Name = "txtAn"
        Me.txtAn.Size = New System.Drawing.Size(46, 20)
        Me.txtAn.TabIndex = 18
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC"})
        Me.cmbmes.Location = New System.Drawing.Point(105, 286)
        Me.cmbmes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(61, 21)
        Me.cmbmes.TabIndex = 17
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(35, 284)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(42, 23)
        Me.LabelX2.TabIndex = 16
        Me.LabelX2.Text = "FECHA"
        '
        'FrmRepCalculoConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAn)
        Me.Controls.Add(Me.cmbTarifa)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.CmdRegion)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.CmbRuta)
        Me.Controls.Add(Me.GPFiltro)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRepCalculoConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de calculo de consumo"
        CType(Me.NDomestico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIndustrial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPublico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NGobierno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NEspeciales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmdRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblRuta As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblDomestico As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblComercial As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblIndustrial As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblPublico As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblGobierno As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblEspeciales As DevComponents.DotNetBar.LabelX
    Friend WithEvents NDomestico As DevComponents.Editors.IntegerInput
    Friend WithEvents NComercial As DevComponents.Editors.IntegerInput
    Friend WithEvents NIndustrial As DevComponents.Editors.IntegerInput
    Friend WithEvents NPublico As DevComponents.Editors.IntegerInput
    Friend WithEvents NGobierno As DevComponents.Editors.IntegerInput
    Friend WithEvents NEspeciales As DevComponents.Editors.IntegerInput
    Friend WithEvents GPFiltro As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents cmbTarifa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAn As System.Windows.Forms.TextBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
