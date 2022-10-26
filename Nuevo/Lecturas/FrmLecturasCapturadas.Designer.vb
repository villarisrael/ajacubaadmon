<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLecturasCapturadas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgLecturas = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnModificar = New DevComponents.DotNetBar.ButtonItem()
        Me.Lecturas = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnBuscar = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnEliminar = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnActualizar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnvercalculos = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mzn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consumocobrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sit_med = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sit_Padron = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sit_Lec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alerta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Algoritmo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoconsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montocobrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgLecturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rbOp.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgLecturas
        '
        Me.DgLecturas.AllowUserToAddRows = False
        Me.DgLecturas.AllowUserToOrderColumns = True
        Me.DgLecturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLecturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cuenta, Me.Mzn, Me.Lote, Me.Nombre, Me.Lectura, Me.Consumo, Me.consumocobrado, Me.Sit_med, Me.Sit_Padron, Me.Sit_Lec, Me.Observaciones, Me.Alerta, Me.Accion, Me.Algoritmo, Me.montoconsumo, Me.Montocobrado, Me.montoiva, Me.alg})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgLecturas.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgLecturas.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DgLecturas.Location = New System.Drawing.Point(0, 64)
        Me.DgLecturas.MultiSelect = False
        Me.DgLecturas.Name = "DgLecturas"
        Me.DgLecturas.ReadOnly = True
        Me.DgLecturas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgLecturas.Size = New System.Drawing.Size(923, 420)
        Me.DgLecturas.TabIndex = 1
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbOp.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.ContainerControlProcessDialogKey = True
        Me.rbOp.Controls.Add(Me.LblTitulo)
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnModificar, Me.Lecturas, Me.BtnBuscar, Me.BtnEliminar, Me.BtnActualizar, Me.btnvercalculos, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(923, 64)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 0
        Me.rbOp.Text = "Opciones"
        '
        '
        '
        Me.rbOp.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.TitleVisible = False
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(401, 3)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(272, 44)
        Me.LblTitulo.TabIndex = 27
        Me.LblTitulo.Text = "<b><font size=""+6"">LECTURAS CAPTURADAS</font></b>"
        '
        'BtnModificar
        '
        Me.BtnModificar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnModificar.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.BtnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Text = "Modificar"
        '
        'Lecturas
        '
        Me.Lecturas.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Lecturas.Image = Global.Administativo.My.Resources.Resources.karm_2
        Me.Lecturas.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Lecturas.Name = "Lecturas"
        Me.Lecturas.SubItemsExpandWidth = 14
        Me.Lecturas.Text = "Historial"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnBuscar.Image = Global.Administativo.My.Resources.Resources.Buscar
        Me.BtnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.SubItemsExpandWidth = 14
        Me.BtnBuscar.Text = "Buscar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnEliminar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.BtnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.SubItemsExpandWidth = 14
        Me.BtnEliminar.Text = "Eliminar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnActualizar.Image = Global.Administativo.My.Resources.Resources.cambioestado
        Me.BtnActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.SubItemsExpandWidth = 14
        Me.BtnActualizar.Text = "Actualizar"
        '
        'btnvercalculos
        '
        Me.btnvercalculos.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnvercalculos.Image = Global.Administativo.My.Resources.Resources.calc
        Me.btnvercalculos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnvercalculos.Name = "btnvercalculos"
        Me.btnvercalculos.SubItemsExpandWidth = 14
        Me.btnvercalculos.Text = "Ver Calculos"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.back
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Regresar"
        '
        'Cuenta
        '
        Me.Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cuenta.DataPropertyName = "Cuenta"
        Me.Cuenta.Frozen = True
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.ReadOnly = True
        Me.Cuenta.Width = 66
        '
        'Mzn
        '
        Me.Mzn.DataPropertyName = "mzn"
        Me.Mzn.HeaderText = "Manzana"
        Me.Mzn.Name = "Mzn"
        Me.Mzn.ReadOnly = True
        Me.Mzn.Width = 76
        '
        'Lote
        '
        Me.Lote.DataPropertyName = "lote"
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        Me.Lote.ReadOnly = True
        Me.Lote.Width = 53
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 69
        '
        'Lectura
        '
        Me.Lectura.DataPropertyName = "Lectura"
        Me.Lectura.HeaderText = "Lectura"
        Me.Lectura.Name = "Lectura"
        Me.Lectura.ReadOnly = True
        Me.Lectura.Width = 68
        '
        'Consumo
        '
        Me.Consumo.DataPropertyName = "Consumo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Consumo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Consumo.HeaderText = "Consumo Mts3"
        Me.Consumo.Name = "Consumo"
        Me.Consumo.ReadOnly = True
        Me.Consumo.Width = 50
        '
        'consumocobrado
        '
        Me.consumocobrado.DataPropertyName = "consumocobrado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        Me.consumocobrado.DefaultCellStyle = DataGridViewCellStyle2
        Me.consumocobrado.HeaderText = "Mts3 cobrados"
        Me.consumocobrado.Name = "consumocobrado"
        Me.consumocobrado.ReadOnly = True
        Me.consumocobrado.Width = 50
        '
        'Sit_med
        '
        Me.Sit_med.DataPropertyName = "sit_med"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        Me.Sit_med.DefaultCellStyle = DataGridViewCellStyle3
        Me.Sit_med.HeaderText = "Sit_Med"
        Me.Sit_med.MinimumWidth = 2
        Me.Sit_med.Name = "Sit_med"
        Me.Sit_med.ReadOnly = True
        Me.Sit_med.Width = 20
        '
        'Sit_Padron
        '
        Me.Sit_Padron.DataPropertyName = "sit_pad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        Me.Sit_Padron.DefaultCellStyle = DataGridViewCellStyle4
        Me.Sit_Padron.HeaderText = "Sit_Padron"
        Me.Sit_Padron.MinimumWidth = 2
        Me.Sit_Padron.Name = "Sit_Padron"
        Me.Sit_Padron.ReadOnly = True
        Me.Sit_Padron.Width = 20
        '
        'Sit_Lec
        '
        Me.Sit_Lec.DataPropertyName = "sit_hid"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        Me.Sit_Lec.DefaultCellStyle = DataGridViewCellStyle5
        Me.Sit_Lec.HeaderText = "Sit_Lec"
        Me.Sit_Lec.MinimumWidth = 2
        Me.Sit_Lec.Name = "Sit_Lec"
        Me.Sit_Lec.ReadOnly = True
        Me.Sit_Lec.Width = 20
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "observa"
        Me.Observaciones.HeaderText = "Observa"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 72
        '
        'Alerta
        '
        Me.Alerta.DataPropertyName = "Alerta"
        Me.Alerta.HeaderText = "Alerta"
        Me.Alerta.Name = "Alerta"
        Me.Alerta.ReadOnly = True
        Me.Alerta.Visible = False
        Me.Alerta.Width = 59
        '
        'Accion
        '
        Me.Accion.DataPropertyName = "Accion"
        Me.Accion.HeaderText = "Acción"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        Me.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Accion.Width = 46
        '
        'Algoritmo
        '
        Me.Algoritmo.DataPropertyName = "algoritmo"
        Me.Algoritmo.HeaderText = "Algoritmo"
        Me.Algoritmo.Name = "Algoritmo"
        Me.Algoritmo.ReadOnly = True
        Me.Algoritmo.Width = 75
        '
        'montoconsumo
        '
        Me.montoconsumo.DataPropertyName = "montoconsumo"
        Me.montoconsumo.HeaderText = "$ consumo"
        Me.montoconsumo.Name = "montoconsumo"
        Me.montoconsumo.ReadOnly = True
        Me.montoconsumo.Visible = False
        Me.montoconsumo.Width = 84
        '
        'Montocobrado
        '
        Me.Montocobrado.DataPropertyName = "Montocobrado"
        Me.Montocobrado.HeaderText = "Monto cobrado"
        Me.Montocobrado.Name = "Montocobrado"
        Me.Montocobrado.ReadOnly = True
        Me.Montocobrado.Visible = False
        '
        'montoiva
        '
        Me.montoiva.DataPropertyName = "montoiva"
        Me.montoiva.HeaderText = "$ I.V.A."
        Me.montoiva.Name = "montoiva"
        Me.montoiva.ReadOnly = True
        Me.montoiva.Visible = False
        Me.montoiva.Width = 67
        '
        'alg
        '
        Me.alg.DataPropertyName = "alg"
        Me.alg.HeaderText = "alg"
        Me.alg.Name = "alg"
        Me.alg.ReadOnly = True
        Me.alg.Visible = False
        Me.alg.Width = 46
        '
        'FrmLecturasCapturadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 484)
        Me.Controls.Add(Me.DgLecturas)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.Name = "FrmLecturasCapturadas"
        Me.Text = "Lecturas Capturadas"
        CType(Me.DgLecturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rbOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgLecturas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents BtnModificar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnEliminar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnActualizar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Lecturas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnvercalculos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Mzn As DataGridViewTextBoxColumn
    Friend WithEvents Lote As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Lectura As DataGridViewTextBoxColumn
    Friend WithEvents Consumo As DataGridViewTextBoxColumn
    Friend WithEvents consumocobrado As DataGridViewTextBoxColumn
    Friend WithEvents Sit_med As DataGridViewTextBoxColumn
    Friend WithEvents Sit_Padron As DataGridViewTextBoxColumn
    Friend WithEvents Sit_Lec As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Alerta As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewTextBoxColumn
    Friend WithEvents Algoritmo As DataGridViewTextBoxColumn
    Friend WithEvents montoconsumo As DataGridViewTextBoxColumn
    Friend WithEvents Montocobrado As DataGridViewTextBoxColumn
    Friend WithEvents montoiva As DataGridViewTextBoxColumn
    Friend WithEvents alg As DataGridViewTextBoxColumn
End Class
