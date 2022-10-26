<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepTomaLecturas
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
        Me.LblRuta = New DevComponents.DotNetBar.LabelX()
        Me.CmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.BtnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CmbRegion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.LblEspera = New DevComponents.DotNetBar.LabelX()
        Me.cmbtipousuario = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.chkmedidor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'LblRuta
        '
        '
        '
        '
        Me.LblRuta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblRuta.Location = New System.Drawing.Point(149, 121)
        Me.LblRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(100, 28)
        Me.LblRuta.TabIndex = 8
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
        Me.CmbRuta.Location = New System.Drawing.Point(280, 124)
        Me.CmbRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(323, 20)
        Me.CmbRuta.TabIndex = 2
        '
        'BtnImprimir
        '
        Me.BtnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnImprimir.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.BtnImprimir.Location = New System.Drawing.Point(375, 284)
        Me.BtnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(121, 47)
        Me.BtnImprimir.TabIndex = 4
        Me.BtnImprimir.Text = "Imprimir"
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(533, 284)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(124, 47)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Terminar"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(149, 85)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 28)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Region"
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
        Me.CmbRegion.Location = New System.Drawing.Point(280, 89)
        Me.CmbRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbRegion.Name = "CmbRegion"
        Me.CmbRegion.Size = New System.Drawing.Size(323, 20)
        Me.CmbRegion.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(116, 15)
        Me.LblTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(541, 54)
        Me.LblTitulo.TabIndex = 5
        Me.LblTitulo.Text = "<b><font size=""+6"">REPORTE PARA LA TOMA DE LECTURAS</font></b>"
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
        Me.LblEspera.Location = New System.Drawing.Point(116, 233)
        Me.LblEspera.Margin = New System.Windows.Forms.Padding(4)
        Me.LblEspera.Name = "LblEspera"
        Me.LblEspera.Size = New System.Drawing.Size(555, 33)
        Me.LblEspera.TabIndex = 9
        Me.LblEspera.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LblEspera.Visible = False
        '
        'cmbtipousuario
        '
        Me.cmbtipousuario.DisplayMember = "Text"
        Me.cmbtipousuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipousuario.FormattingEnabled = True
        Me.cmbtipousuario.ItemHeight = 14
        Me.cmbtipousuario.Location = New System.Drawing.Point(284, 161)
        Me.cmbtipousuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbtipousuario.Name = "cmbtipousuario"
        Me.cmbtipousuario.Size = New System.Drawing.Size(317, 20)
        Me.cmbtipousuario.TabIndex = 3
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(149, 161)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(127, 28)
        Me.LabelX2.TabIndex = 11
        Me.LabelX2.Text = "Tarifa"
        '
        'chkmedidor
        '
        '
        '
        '
        Me.chkmedidor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkmedidor.Location = New System.Drawing.Point(149, 197)
        Me.chkmedidor.Margin = New System.Windows.Forms.Padding(4)
        Me.chkmedidor.Name = "chkmedidor"
        Me.chkmedidor.Size = New System.Drawing.Size(159, 28)
        Me.chkmedidor.TabIndex = 4
        Me.chkmedidor.Text = "Con Medidor"
        '
        'FrmRepTomaLecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkmedidor)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.cmbtipousuario)
        Me.Controls.Add(Me.LblEspera)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRepTomaLecturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte para la Toma de Lecturas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblRuta As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmbRegion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LblEspera As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbtipousuario As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkmedidor As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
