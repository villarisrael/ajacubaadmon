<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSituacionesCaptura
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
        Me.CmbRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.LblRuta = New DevComponents.DotNetBar.LabelX()
        Me.CmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LblSit_med = New DevComponents.DotNetBar.LabelX()
        Me.CmbSitmed = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.CmbSitpad = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.CmbSitHid = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnLimpiar = New DevComponents.DotNetBar.ButtonX()
        Me.LblEspera = New DevComponents.DotNetBar.LabelX()
        Me.txtAn = New System.Windows.Forms.TextBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(56, 72)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Región"
        '
        'CmbRegion
        '
        Me.CmbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbRegion.DisplayMember = "Text"
        Me.CmbRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbRegion.FocusHighlightEnabled = True
        Me.CmbRegion.FormattingEnabled = True
        Me.CmbRegion.ItemHeight = 14
        Me.CmbRegion.Location = New System.Drawing.Point(153, 75)
        Me.CmbRegion.Name = "CmbRegion"
        Me.CmbRegion.Size = New System.Drawing.Size(243, 20)
        Me.CmbRegion.TabIndex = 3
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(308, 369)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnImprimir.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.BtnImprimir.Location = New System.Drawing.Point(193, 369)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(93, 38)
        Me.BtnImprimir.TabIndex = 14
        Me.BtnImprimir.Text = "Imprimir"
        '
        'LblRuta
        '
        '
        '
        '
        Me.LblRuta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblRuta.Location = New System.Drawing.Point(56, 115)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(75, 23)
        Me.LblRuta.TabIndex = 4
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
        Me.CmbRuta.Location = New System.Drawing.Point(153, 118)
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(243, 20)
        Me.CmbRuta.TabIndex = 5
        '
        'LblSit_med
        '
        '
        '
        '
        Me.LblSit_med.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblSit_med.Location = New System.Drawing.Point(56, 158)
        Me.LblSit_med.Name = "LblSit_med"
        Me.LblSit_med.Size = New System.Drawing.Size(101, 23)
        Me.LblSit_med.TabIndex = 8
        Me.LblSit_med.Text = "Situación Medición"
        '
        'CmbSitmed
        '
        Me.CmbSitmed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSitmed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSitmed.DisplayMember = "Text"
        Me.CmbSitmed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSitmed.FocusHighlightEnabled = True
        Me.CmbSitmed.FormattingEnabled = True
        Me.CmbSitmed.ItemHeight = 14
        Me.CmbSitmed.Location = New System.Drawing.Point(182, 161)
        Me.CmbSitmed.Name = "CmbSitmed"
        Me.CmbSitmed.Size = New System.Drawing.Size(215, 20)
        Me.CmbSitmed.TabIndex = 9
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(56, 201)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(101, 23)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "Situación Padrón"
        '
        'CmbSitpad
        '
        Me.CmbSitpad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSitpad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSitpad.DisplayMember = "Text"
        Me.CmbSitpad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSitpad.FocusHighlightEnabled = True
        Me.CmbSitpad.FormattingEnabled = True
        Me.CmbSitpad.ItemHeight = 14
        Me.CmbSitpad.Location = New System.Drawing.Point(182, 204)
        Me.CmbSitpad.Name = "CmbSitpad"
        Me.CmbSitpad.Size = New System.Drawing.Size(215, 20)
        Me.CmbSitpad.TabIndex = 11
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(56, 244)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(120, 23)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "Situación Hidrómetro"
        '
        'CmbSitHid
        '
        Me.CmbSitHid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSitHid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSitHid.DisplayMember = "Text"
        Me.CmbSitHid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSitHid.FocusHighlightEnabled = True
        Me.CmbSitHid.FormattingEnabled = True
        Me.CmbSitHid.ItemHeight = 14
        Me.CmbSitHid.Location = New System.Drawing.Point(182, 247)
        Me.CmbSitHid.Name = "CmbSitHid"
        Me.CmbSitHid.Size = New System.Drawing.Size(215, 20)
        Me.CmbSitHid.TabIndex = 13
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(74, 21)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(283, 44)
        Me.LblTitulo.TabIndex = 25
        Me.LblTitulo.Text = "<b><font size=""+6"">SITUACIONES DE CAPTURA</font></b>"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnLimpiar.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.BtnLimpiar.Location = New System.Drawing.Point(74, 369)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(93, 38)
        Me.BtnLimpiar.TabIndex = 26
        Me.BtnLimpiar.Text = "Limpiar"
        '
        'LblEspera
        '
        Me.LblEspera.BackColor = System.Drawing.Color.Navy
        '
        '
        '
        Me.LblEspera.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEspera.ForeColor = System.Drawing.Color.White
        Me.LblEspera.Location = New System.Drawing.Point(26, 316)
        Me.LblEspera.Name = "LblEspera"
        Me.LblEspera.Size = New System.Drawing.Size(416, 27)
        Me.LblEspera.TabIndex = 30
        Me.LblEspera.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LblEspera.Visible = False
        '
        'txtAn
        '
        Me.txtAn.Location = New System.Drawing.Point(246, 281)
        Me.txtAn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAn.Name = "txtAn"
        Me.txtAn.Size = New System.Drawing.Size(46, 20)
        Me.txtAn.TabIndex = 29
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC"})
        Me.cmbmes.Location = New System.Drawing.Point(182, 280)
        Me.cmbmes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(61, 21)
        Me.cmbmes.TabIndex = 28
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(56, 276)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(42, 23)
        Me.LabelX2.TabIndex = 27
        Me.LabelX2.Text = "FECHA"
        '
        'FrmSituacionesCaptura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblEspera)
        Me.Controls.Add(Me.txtAn)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.CmbSitHid)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.CmbSitpad)
        Me.Controls.Add(Me.LblSit_med)
        Me.Controls.Add(Me.CmbSitmed)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.CmbRegion)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.CmbRuta)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSituacionesCaptura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Situaciones de Captura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblRuta As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblSit_med As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbSitmed As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbSitpad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbSitHid As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnLimpiar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblEspera As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAn As System.Windows.Forms.TextBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
