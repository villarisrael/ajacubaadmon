<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepLecturasnoCapturadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepLecturasnoCapturadas))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CmbRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.LblRuta = New DevComponents.DotNetBar.LabelX()
        Me.CmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.txtAn = New System.Windows.Forms.TextBox()
        Me.LblEspera = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(72, 96)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(42, 23)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Region:"
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
        Me.CmbRegion.Location = New System.Drawing.Point(120, 102)
        Me.CmbRegion.Name = "CmbRegion"
        Me.CmbRegion.Size = New System.Drawing.Size(274, 20)
        Me.CmbRegion.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(348, 232)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(239, 232)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(93, 38)
        Me.BtnImprimir.TabIndex = 3
        Me.BtnImprimir.Text = "Imprimir"
        '
        'LblRuta
        '
        '
        '
        '
        Me.LblRuta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblRuta.Location = New System.Drawing.Point(72, 128)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(42, 23)
        Me.LblRuta.TabIndex = 8
        Me.LblRuta.Text = "Ruta:"
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
        Me.CmbRuta.Location = New System.Drawing.Point(120, 135)
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(274, 20)
        Me.CmbRuta.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(30, 11)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(416, 44)
        Me.LblTitulo.TabIndex = 5
        Me.LblTitulo.Text = "<b><font size=""+6"">REPORTE DE LECTURAS NO CAPTURADAS</font></b>"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(72, 169)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(42, 23)
        Me.LabelX2.TabIndex = 10
        Me.LabelX2.Text = "FECHA"
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC"})
        Me.cmbmes.Location = New System.Drawing.Point(142, 171)
        Me.cmbmes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(61, 21)
        Me.cmbmes.TabIndex = 14
        '
        'txtAn
        '
        Me.txtAn.Location = New System.Drawing.Point(212, 172)
        Me.txtAn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAn.Name = "txtAn"
        Me.txtAn.Size = New System.Drawing.Size(46, 20)
        Me.txtAn.TabIndex = 15
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
        Me.LblEspera.Location = New System.Drawing.Point(30, 198)
        Me.LblEspera.Name = "LblEspera"
        Me.LblEspera.Size = New System.Drawing.Size(416, 27)
        Me.LblEspera.TabIndex = 18
        Me.LblEspera.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LblEspera.Visible = False
        '
        'frmRepLecturasnoCapturadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblEspera)
        Me.Controls.Add(Me.txtAn)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.CmbRegion)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.CmbRuta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepLecturasnoCapturadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Lecturas no Capturadas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblRuta As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents txtAn As System.Windows.Forms.TextBox
    Friend WithEvents LblEspera As DevComponents.DotNetBar.LabelX
End Class
