<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmimportalecturas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmimportalecturas))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.abrirarchivo = New System.Windows.Forms.OpenFileDialog()
        Me.lblarchivo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltemporal = New System.Windows.Forms.Label()
        Me.Tabla = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmblecturista = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem5 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem6 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem7 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem8 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem9 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem10 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem11 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem12 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem13 = New DevComponents.DotNetBar.LabelItem()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtAn = New System.Windows.Forms.TextBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.PB = New DevComponents.DotNetBar.Controls.ProgressBarX()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(350, 23)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(134, 24)
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Seleccionar archivo (s)"
        '
        'abrirarchivo
        '
        Me.abrirarchivo.FileName = "OpenFileDialog1"
        '
        'lblarchivo
        '
        Me.lblarchivo.AutoSize = True
        Me.lblarchivo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblarchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarchivo.Location = New System.Drawing.Point(275, 58)
        Me.lblarchivo.Name = "lblarchivo"
        Me.lblarchivo.Size = New System.Drawing.Size(0, 20)
        Me.lblarchivo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Archivo"
        '
        'lbltemporal
        '
        Me.lbltemporal.AutoSize = True
        Me.lbltemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltemporal.Location = New System.Drawing.Point(275, 126)
        Me.lbltemporal.Name = "lbltemporal"
        Me.lbltemporal.Size = New System.Drawing.Size(0, 20)
        Me.lbltemporal.TabIndex = 3
        Me.lbltemporal.Visible = False
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        Me.Tabla.AllowUserToDeleteRows = False
        Me.Tabla.AllowUserToOrderColumns = True
        Me.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tabla.DefaultCellStyle = DataGridViewCellStyle1
        Me.Tabla.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Tabla.Location = New System.Drawing.Point(275, 121)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        Me.Tabla.Size = New System.Drawing.Size(686, 301)
        Me.Tabla.TabIndex = 5
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(818, 63)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.PulseSpeed = 30
        Me.ButtonX2.Size = New System.Drawing.Size(99, 25)
        Me.ButtonX2.TabIndex = 6
        Me.ButtonX2.Text = "Importar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Basedatos.ico")
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(287, 67)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(57, 14)
        Me.LabelX2.TabIndex = 10
        Me.LabelX2.Text = "Lecturista:"
        '
        'cmblecturista
        '
        Me.cmblecturista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmblecturista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblecturista.DisplayMember = "Text"
        Me.cmblecturista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmblecturista.FocusHighlightEnabled = True
        Me.cmblecturista.FormattingEnabled = True
        Me.cmblecturista.ItemHeight = 14
        Me.cmblecturista.Location = New System.Drawing.Point(350, 67)
        Me.cmblecturista.Name = "cmblecturista"
        Me.cmblecturista.Size = New System.Drawing.Size(171, 20)
        Me.cmblecturista.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 145)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'ItemPanel1
        '
        '
        '
        '
        Me.ItemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.ItemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderBottomWidth = 1
        Me.ItemPanel1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ItemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderLeftWidth = 1
        Me.ItemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderRightWidth = 1
        Me.ItemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderTopWidth = 1
        Me.ItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanel1.BackgroundStyle.PaddingBottom = 1
        Me.ItemPanel1.BackgroundStyle.PaddingLeft = 1
        Me.ItemPanel1.BackgroundStyle.PaddingRight = 1
        Me.ItemPanel1.BackgroundStyle.PaddingTop = 1
        Me.ItemPanel1.ContainerControlProcessDialogKey = True
        Me.ItemPanel1.DragDropSupport = True
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.LabelItem2, Me.LabelItem3, Me.LabelItem4, Me.LabelItem5, Me.LabelItem6, Me.LabelItem7, Me.LabelItem8, Me.LabelItem9, Me.LabelItem10, Me.LabelItem11, Me.LabelItem12, Me.LabelItem13})
        Me.ItemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemPanel1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ItemPanel1.Location = New System.Drawing.Point(6, 174)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(249, 286)
        Me.ItemPanel1.TabIndex = 12
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "<font color=""#ED1C24""><i>Paso 1</i></font> Presiona el botón Seleccionar Archivo," & _
            " "
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "y busca el archivo Archlecturas.xlm que generó " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelItem3
        '
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "la terminal, con seguridad esta es la carpeta"
        '
        'LabelItem4
        '
        Me.LabelItem4.Name = "LabelItem4"
        Me.LabelItem4.Text = "sincronizada del dispositivo en <i>Mis documentos.</i>"
        '
        'LabelItem5
        '
        Me.LabelItem5.Name = "LabelItem5"
        '
        'LabelItem6
        '
        Me.LabelItem6.Name = "LabelItem6"
        Me.LabelItem6.Text = "<font color=""#ED1C24""><i>Paso 2</i> </font>Selecciona del combo Lecturista, el "
        '
        'LabelItem7
        '
        Me.LabelItem7.Name = "LabelItem7"
        Me.LabelItem7.Text = "nombre de la persona que tomó las lecturas."
        '
        'LabelItem8
        '
        Me.LabelItem8.Name = "LabelItem8"
        '
        'LabelItem9
        '
        Me.LabelItem9.Name = "LabelItem9"
        Me.LabelItem9.Text = "<font color=""#ED1C24""><i>Paso 3 </i></font> Presiona el botón importar, contesta " & _
            "las "
        '
        'LabelItem10
        '
        Me.LabelItem10.Name = "LabelItem10"
        Me.LabelItem10.Text = "preguntas sí te las hace."
        '
        'LabelItem11
        '
        Me.LabelItem11.Name = "LabelItem11"
        '
        'LabelItem12
        '
        Me.LabelItem12.Name = "LabelItem12"
        Me.LabelItem12.Text = "<font color=""#BA1419""><i>Nota:</i></font> Dirígete a captura de lecturas, en el"
        '
        'LabelItem13
        '
        Me.LabelItem13.Name = "LabelItem13"
        Me.LabelItem13.Text = "menú facuración, para ver los resultados."
        '
        'txtAn
        '
        Me.txtAn.Location = New System.Drawing.Point(726, 67)
        Me.txtAn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAn.Name = "txtAn"
        Me.txtAn.Size = New System.Drawing.Size(73, 20)
        Me.txtAn.TabIndex = 18
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC"})
        Me.cmbmes.Location = New System.Drawing.Point(595, 66)
        Me.cmbmes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(65, 21)
        Me.cmbmes.TabIndex = 17
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(544, 63)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(46, 23)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "Fecha:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(675, 63)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(46, 23)
        Me.LabelX3.TabIndex = 19
        Me.LabelX3.Text = "Año:"
        '
        'PB
        '
        '
        '
        '
        Me.PB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PB.Location = New System.Drawing.Point(275, 436)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(686, 23)
        Me.PB.TabIndex = 20
        Me.PB.Text = "PB"
        '
        'frmimportalecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 472)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtAn)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cmblecturista)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.lbltemporal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblarchivo)
        Me.Controls.Add(Me.ButtonX1)
        Me.DoubleBuffered = True
        Me.Name = "frmimportalecturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar lecturas de terminal"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents abrirarchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblarchivo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltemporal As System.Windows.Forms.Label
    Friend WithEvents Tabla As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmblecturista As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem5 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem6 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem7 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem8 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem9 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem10 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem11 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem12 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem13 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtAn As System.Windows.Forms.TextBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PB As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
