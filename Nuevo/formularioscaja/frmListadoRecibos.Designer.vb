<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoRecibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoRecibos))
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dtfinal = New System.Windows.Forms.DateTimePicker()
        Me.dtinicio = New System.Windows.Forms.DateTimePicker()
        Me.superTabrecibos = New DevComponents.DotNetBar.SuperTabControl()
        Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Maestro = New DevComponents.DotNetBar.SuperTabItem()
        Me.superTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.dataGridViewRectifica = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.RectificaTab = New DevComponents.DotNetBar.SuperTabItem()
        Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.advDetalles = New DevComponents.AdvTree.AdvTree()
        Me.nodeConnector2 = New DevComponents.AdvTree.NodeConnector()
        Me.elementStyle2 = New DevComponents.DotNetBar.ElementStyle()
        Me.Esclavo = New DevComponents.DotNetBar.SuperTabItem()
        Me.btncerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btncargar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtcaja = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblcuantos = New DevComponents.DotNetBar.LabelX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblreciboseleccionado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IIfolioinicio = New DevComponents.Editors.IntegerInput()
        Me.IIfoliofinal = New DevComponents.Editors.IntegerInput()
        Me.IIsumando = New DevComponents.Editors.IntegerInput()
        Me.btnRenumerar = New DevComponents.DotNetBar.ButtonX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.superTabrecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabrecibos.SuspendLayout()
        Me.superTabControlPanel1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControlPanel3.SuspendLayout()
        CType(Me.dataGridViewRectifica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControlPanel2.SuspendLayout()
        CType(Me.advDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.IIfolioinicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIfoliofinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIsumando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(10, 34)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(14, 13)
        Me.label2.TabIndex = 26
        Me.label2.Text = "A"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(21, 13)
        Me.label1.TabIndex = 25
        Me.label1.Text = "De"
        '
        'dtfinal
        '
        Me.dtfinal.Location = New System.Drawing.Point(59, 28)
        Me.dtfinal.Name = "dtfinal"
        Me.dtfinal.Size = New System.Drawing.Size(200, 20)
        Me.dtfinal.TabIndex = 1
        '
        'dtinicio
        '
        Me.dtinicio.Location = New System.Drawing.Point(59, 2)
        Me.dtinicio.Name = "dtinicio"
        Me.dtinicio.Size = New System.Drawing.Size(200, 20)
        Me.dtinicio.TabIndex = 0
        '
        'superTabrecibos
        '
        '
        '
        '
        '
        '
        '
        Me.superTabrecibos.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.superTabrecibos.ControlBox.MenuBox.Name = ""
        Me.superTabrecibos.ControlBox.Name = ""
        Me.superTabrecibos.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabrecibos.ControlBox.MenuBox, Me.superTabrecibos.ControlBox.CloseBox})
        Me.superTabrecibos.Controls.Add(Me.superTabControlPanel1)
        Me.superTabrecibos.Controls.Add(Me.superTabControlPanel3)
        Me.superTabrecibos.Controls.Add(Me.superTabControlPanel2)
        Me.superTabrecibos.Location = New System.Drawing.Point(6, 62)
        Me.superTabrecibos.Name = "superTabrecibos"
        Me.superTabrecibos.ReorderTabsEnabled = True
        Me.superTabrecibos.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.superTabrecibos.SelectedTabIndex = 0
        Me.superTabrecibos.Size = New System.Drawing.Size(800, 500)
        Me.superTabrecibos.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.superTabrecibos.TabIndex = 27
        Me.superTabrecibos.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Maestro, Me.Esclavo, Me.RectificaTab})
        Me.superTabrecibos.Text = "superTabControl1"
        '
        'superTabControlPanel1
        '
        Me.superTabControlPanel1.Controls.Add(Me.toolStrip1)
        Me.superTabControlPanel1.Controls.Add(Me.dataGridView1)
        Me.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.superTabControlPanel1.Name = "superTabControlPanel1"
        Me.superTabControlPanel1.Size = New System.Drawing.Size(800, 475)
        Me.superTabControlPanel1.TabIndex = 1
        Me.superTabControlPanel1.TabItem = Me.Maestro
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.AllowUserToOrderColumns = True
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(6, 28)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(788, 440)
        Me.dataGridView1.TabIndex = 0
        '
        'Maestro
        '
        Me.Maestro.AttachedControl = Me.superTabControlPanel1
        Me.Maestro.GlobalItem = False
        Me.Maestro.Name = "Maestro"
        Me.Maestro.Text = "Maestro"
        '
        'superTabControlPanel3
        '
        Me.superTabControlPanel3.Controls.Add(Me.dataGridViewRectifica)
        Me.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.superTabControlPanel3.Name = "superTabControlPanel3"
        Me.superTabControlPanel3.Size = New System.Drawing.Size(708, 312)
        Me.superTabControlPanel3.TabIndex = 0
        Me.superTabControlPanel3.TabItem = Me.RectificaTab
        Me.superTabControlPanel3.Visible = False
        '
        'dataGridViewRectifica
        '
        Me.dataGridViewRectifica.AllowUserToAddRows = False
        Me.dataGridViewRectifica.AllowUserToDeleteRows = False
        Me.dataGridViewRectifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewRectifica.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewRectifica.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataGridViewRectifica.Location = New System.Drawing.Point(3, 3)
        Me.dataGridViewRectifica.Name = "dataGridViewRectifica"
        Me.dataGridViewRectifica.ReadOnly = True
        Me.dataGridViewRectifica.Size = New System.Drawing.Size(597, 327)
        Me.dataGridViewRectifica.TabIndex = 0
        '
        'RectificaTab
        '
        Me.RectificaTab.AttachedControl = Me.superTabControlPanel3
        Me.RectificaTab.GlobalItem = False
        Me.RectificaTab.Name = "RectificaTab"
        Me.RectificaTab.Text = "Rectifica"
        '
        'superTabControlPanel2
        '
        Me.superTabControlPanel2.Controls.Add(Me.advDetalles)
        Me.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.superTabControlPanel2.Name = "superTabControlPanel2"
        Me.superTabControlPanel2.Size = New System.Drawing.Size(708, 337)
        Me.superTabControlPanel2.TabIndex = 0
        Me.superTabControlPanel2.TabItem = Me.Esclavo
        Me.superTabControlPanel2.Visible = False
        '
        'advDetalles
        '
        Me.advDetalles.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.advDetalles.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.advDetalles.BackgroundStyle.Class = "TreeBorderKey"
        Me.advDetalles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.advDetalles.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.advDetalles.Location = New System.Drawing.Point(3, 3)
        Me.advDetalles.Name = "advDetalles"
        Me.advDetalles.NodesConnector = Me.nodeConnector2
        Me.advDetalles.NodeStyle = Me.elementStyle2
        Me.advDetalles.PathSeparator = ";"
        Me.advDetalles.Size = New System.Drawing.Size(724, 191)
        Me.advDetalles.Styles.Add(Me.elementStyle2)
        Me.advDetalles.TabIndex = 0
        Me.advDetalles.Text = "advTree1"
        '
        'nodeConnector2
        '
        Me.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText
        '
        'elementStyle2
        '
        Me.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.elementStyle2.Name = "elementStyle2"
        Me.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText
        '
        'Esclavo
        '
        Me.Esclavo.AttachedControl = Me.superTabControlPanel2
        Me.Esclavo.GlobalItem = False
        Me.Esclavo.Name = "Esclavo"
        Me.Esclavo.Text = "Esclavo"
        '
        'btncerrar
        '
        Me.btncerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(818, 11)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(89, 37)
        Me.btncerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btncerrar.TabIndex = 4
        Me.btncerrar.Text = "Cerrar"
        '
        'btncargar
        '
        Me.btncargar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncargar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncargar.Image = CType(resources.GetObject("btncargar.Image"), System.Drawing.Image)
        Me.btncargar.Location = New System.Drawing.Point(710, 11)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(102, 37)
        Me.btncargar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btncargar.TabIndex = 2
        Me.btncargar.Text = "Cargar"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(289, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 20)
        Me.LabelX1.TabIndex = 28
        Me.LabelX1.Text = "Caja"
        '
        'txtcaja
        '
        '
        '
        '
        Me.txtcaja.Border.Class = "TextBoxBorder"
        Me.txtcaja.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcaja.Location = New System.Drawing.Point(343, 2)
        Me.txtcaja.Name = "txtcaja"
        Me.txtcaja.PreventEnterBeep = True
        Me.txtcaja.Size = New System.Drawing.Size(102, 20)
        Me.txtcaja.TabIndex = 29
        '
        'lblcuantos
        '
        '
        '
        '
        Me.lblcuantos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblcuantos.Location = New System.Drawing.Point(291, 30)
        Me.lblcuantos.Name = "lblcuantos"
        Me.lblcuantos.Size = New System.Drawing.Size(184, 17)
        Me.lblcuantos.TabIndex = 30
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblreciboseleccionado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1022, 22)
        Me.StatusStrip1.TabIndex = 31
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblreciboseleccionado
        '
        Me.lblreciboseleccionado.Name = "lblreciboseleccionado"
        Me.lblreciboseleccionado.Size = New System.Drawing.Size(0, 17)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Folio Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Folio Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sumar"
        '
        'IIfolioinicio
        '
        '
        '
        '
        Me.IIfolioinicio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIfolioinicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIfolioinicio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIfolioinicio.Location = New System.Drawing.Point(97, 50)
        Me.IIfolioinicio.Name = "IIfolioinicio"
        Me.IIfolioinicio.ShowUpDown = True
        Me.IIfolioinicio.Size = New System.Drawing.Size(80, 20)
        Me.IIfolioinicio.TabIndex = 1
        '
        'IIfoliofinal
        '
        '
        '
        '
        Me.IIfoliofinal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIfoliofinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIfoliofinal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIfoliofinal.Location = New System.Drawing.Point(97, 75)
        Me.IIfoliofinal.Name = "IIfoliofinal"
        Me.IIfoliofinal.ShowUpDown = True
        Me.IIfoliofinal.Size = New System.Drawing.Size(80, 20)
        Me.IIfoliofinal.TabIndex = 2
        '
        'IIsumando
        '
        '
        '
        '
        Me.IIsumando.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IIsumando.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IIsumando.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IIsumando.Location = New System.Drawing.Point(97, 100)
        Me.IIsumando.Name = "IIsumando"
        Me.IIsumando.ShowUpDown = True
        Me.IIsumando.Size = New System.Drawing.Size(50, 20)
        Me.IIsumando.TabIndex = 3
        '
        'btnRenumerar
        '
        Me.btnRenumerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRenumerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRenumerar.Location = New System.Drawing.Point(98, 128)
        Me.btnRenumerar.Name = "btnRenumerar"
        Me.btnRenumerar.Size = New System.Drawing.Size(75, 23)
        Me.btnRenumerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRenumerar.TabIndex = 6
        Me.btnRenumerar.Text = "Renumerar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Serie"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(98, 25)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(37, 20)
        Me.txtserie.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtserie)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnRenumerar)
        Me.GroupBox1.Controls.Add(Me.IIsumando)
        Me.GroupBox1.Controls.Add(Me.IIfoliofinal)
        Me.GroupBox1.Controls.Add(Me.IIfolioinicio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(806, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 157)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Renumerar"
        Me.GroupBox1.Visible = False
        '
        'frmListadoRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 600)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblcuantos)
        Me.Controls.Add(Me.txtcaja)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.superTabrecibos)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dtfinal)
        Me.Controls.Add(Me.dtinicio)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btncargar)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmListadoRecibos"
        Me.Text = "Listado de recibos"
        CType(Me.superTabrecibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabrecibos.ResumeLayout(False)
        Me.superTabControlPanel1.ResumeLayout(False)
        Me.superTabControlPanel1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControlPanel3.ResumeLayout(False)
        CType(Me.dataGridViewRectifica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControlPanel2.ResumeLayout(False)
        CType(Me.advDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.IIfolioinicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIfoliofinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIsumando, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents dtfinal As System.Windows.Forms.DateTimePicker
    Private WithEvents dtinicio As System.Windows.Forms.DateTimePicker
    Private WithEvents btncerrar As DevComponents.DotNetBar.ButtonX
    Private WithEvents btncargar As DevComponents.DotNetBar.ButtonX
    Private WithEvents superTabrecibos As DevComponents.DotNetBar.SuperTabControl
    Private WithEvents superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents Maestro As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents advDetalles As DevComponents.AdvTree.AdvTree
    Private WithEvents nodeConnector2 As DevComponents.AdvTree.NodeConnector
    Private WithEvents elementStyle2 As DevComponents.DotNetBar.ElementStyle
    Private WithEvents Esclavo As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents superTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents dataGridViewRectifica As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents RectificaTab As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcaja As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblcuantos As DevComponents.DotNetBar.LabelX
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblreciboseleccionado As ToolStripStatusLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IIfolioinicio As DevComponents.Editors.IntegerInput
    Friend WithEvents IIfoliofinal As DevComponents.Editors.IntegerInput
    Friend WithEvents IIsumando As DevComponents.Editors.IntegerInput
    Friend WithEvents btnRenumerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class