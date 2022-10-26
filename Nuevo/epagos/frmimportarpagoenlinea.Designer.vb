Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAplicar = New DevComponents.DotNetBar.ButtonX()
        Me.txtservicio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.DataPagos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PG = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.cmbcaja = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblcaja = New DevComponents.DotNetBar.LabelX()
        Me.lblfolio = New DevComponents.DotNetBar.LabelX()
        Me.txtfolio = New DevComponents.Editors.IntegerInput()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.DataPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Archivo de excel del banco"
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.BtnSalir.Location = New System.Drawing.Point(808, 239)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 38)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Terminar"
        '
        'BtnAplicar
        '
        Me.BtnAplicar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAplicar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAplicar.Image = Global.Administativo.My.Resources.Resources.bookmarks_list_add
        Me.BtnAplicar.Location = New System.Drawing.Point(684, 239)
        Me.BtnAplicar.Name = "BtnAplicar"
        Me.BtnAplicar.Size = New System.Drawing.Size(93, 38)
        Me.BtnAplicar.TabIndex = 5
        Me.BtnAplicar.Text = "Aplicar"
        '
        'txtservicio
        '
        '
        '
        '
        Me.txtservicio.Border.Class = "TextBoxBorder"
        Me.txtservicio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtservicio.Location = New System.Drawing.Point(189, 19)
        Me.txtservicio.Name = "txtservicio"
        Me.txtservicio.PreventEnterBeep = True
        Me.txtservicio.Size = New System.Drawing.Size(186, 20)
        Me.txtservicio.TabIndex = 7
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(189, 49)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(49, 21)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 8
        Me.ButtonX1.Text = "..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(19, 117)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(10, 13)
        Me.lblArchivo.TabIndex = 17
        Me.lblArchivo.Text = "."
        '
        'DataPagos
        '
        Me.DataPagos.AllowUserToAddRows = False
        Me.DataPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Cuenta, Me.Nombre, Me.Total, Me.Referencia})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataPagos.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataPagos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataPagos.Location = New System.Drawing.Point(12, 76)
        Me.DataPagos.Name = "DataPagos"
        Me.DataPagos.Size = New System.Drawing.Size(650, 157)
        Me.DataPagos.TabIndex = 18
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 300
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Referencia
        '
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        '
        'PG
        '
        '
        '
        '
        Me.PG.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PG.Location = New System.Drawing.Point(12, 254)
        Me.PG.Name = "PG"
        Me.PG.Size = New System.Drawing.Size(384, 23)
        Me.PG.TabIndex = 16
        Me.PG.TextVisible = True
        Me.PG.Visible = False
        '
        'Imagen
        '
        Me.Imagen.Image = CType(resources.GetObject("Imagen.Image"), System.Drawing.Image)
        Me.Imagen.Location = New System.Drawing.Point(668, 85)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(236, 138)
        Me.Imagen.TabIndex = 19
        Me.Imagen.TabStop = False
        Me.Imagen.Visible = False
        '
        'cmbcaja
        '
        Me.cmbcaja.DisplayMember = "Text"
        Me.cmbcaja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcaja.FormattingEnabled = True
        Me.cmbcaja.ItemHeight = 14
        Me.cmbcaja.Location = New System.Drawing.Point(670, 87)
        Me.cmbcaja.Name = "cmbcaja"
        Me.cmbcaja.Size = New System.Drawing.Size(231, 20)
        Me.cmbcaja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbcaja.TabIndex = 20
        '
        'lblcaja
        '
        '
        '
        '
        Me.lblcaja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblcaja.Location = New System.Drawing.Point(668, 58)
        Me.lblcaja.Name = "lblcaja"
        Me.lblcaja.Size = New System.Drawing.Size(206, 23)
        Me.lblcaja.TabIndex = 21
        Me.lblcaja.Text = "Registrar el ingreso en la caja"
        '
        'lblfolio
        '
        Me.lblfolio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblfolio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblfolio.Location = New System.Drawing.Point(670, 117)
        Me.lblfolio.Name = "lblfolio"
        Me.lblfolio.Size = New System.Drawing.Size(75, 23)
        Me.lblfolio.TabIndex = 22
        Me.lblfolio.Text = "Folio"
        '
        'txtfolio
        '
        '
        '
        '
        Me.txtfolio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtfolio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtfolio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtfolio.Location = New System.Drawing.Point(669, 147)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.ShowUpDown = True
        Me.txtfolio.Size = New System.Drawing.Size(129, 20)
        Me.txtfolio.TabIndex = 23
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 6)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 13)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Abrir enlace"
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 289)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtfolio)
        Me.Controls.Add(Me.lblfolio)
        Me.Controls.Add(Me.lblcaja)
        Me.Controls.Add(Me.cmbcaja)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.DataPagos)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.PG)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.txtservicio)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAplicar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Formulario"
        Me.Text = "Importar pagos en linea"
        CType(Me.DataPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As ButtonX
    Friend WithEvents BtnAplicar As ButtonX
    Friend WithEvents txtservicio As Controls.TextBoxX
    Friend WithEvents ButtonX1 As ButtonX
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblArchivo As Label
    Friend WithEvents DataPagos As Controls.DataGridViewX
    Friend WithEvents PG As Controls.ProgressBarX
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents cmbcaja As Controls.ComboBoxEx
    Friend WithEvents lblcaja As LabelX
    Friend WithEvents lblfolio As LabelX
    Friend WithEvents txtfolio As DevComponents.Editors.IntegerInput
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Referencia As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
