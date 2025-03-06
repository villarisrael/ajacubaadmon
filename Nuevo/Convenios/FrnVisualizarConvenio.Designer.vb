<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrnVisualizarConvenio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblvencimiento = New DevComponents.DotNetBar.LabelX()
        Me.txtAplazamiento = New DevComponents.DotNetBar.LabelX()
        Me.txtNumeroPagos = New DevComponents.DotNetBar.LabelX()
        Me.txtTelefono = New DevComponents.DotNetBar.LabelX()
        Me.txtFechaCreacion = New DevComponents.DotNetBar.LabelX()
        Me.txtTotalAdeudo = New DevComponents.DotNetBar.LabelX()
        Me.txtidconvenio = New DevComponents.DotNetBar.LabelX()
        Me.txtNombre = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtEstado = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbltarifa = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.lblcomunidad = New DevComponents.DotNetBar.LabelX()
        Me.lblcolonia = New DevComponents.DotNetBar.LabelX()
        Me.lbldireccion = New DevComponents.DotNetBar.LabelX()
        Me.lblfecha = New DevComponents.DotNetBar.LabelX()
        Me.lbltotal = New DevComponents.DotNetBar.LabelX()
        Me.lblnombre = New DevComponents.DotNetBar.LabelX()
        Me.txtubicacion = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtestadotoma = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.dataConv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buttoncerrar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dataConv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(13, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Convenio....."
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 73)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Nombre....."
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lblvencimiento)
        Me.GroupPanel1.Controls.Add(Me.txtAplazamiento)
        Me.GroupPanel1.Controls.Add(Me.txtNumeroPagos)
        Me.GroupPanel1.Controls.Add(Me.txtTelefono)
        Me.GroupPanel1.Controls.Add(Me.txtFechaCreacion)
        Me.GroupPanel1.Controls.Add(Me.txtTotalAdeudo)
        Me.GroupPanel1.Controls.Add(Me.txtidconvenio)
        Me.GroupPanel1.Controls.Add(Me.txtNombre)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.txtEstado)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(21, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(574, 148)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Datos del Convenio...."
        '
        'lblvencimiento
        '
        Me.lblvencimiento.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblvencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblvencimiento.Location = New System.Drawing.Point(422, 25)
        Me.lblvencimiento.Name = "lblvencimiento"
        Me.lblvencimiento.Size = New System.Drawing.Size(125, 23)
        Me.lblvencimiento.TabIndex = 15
        '
        'txtAplazamiento
        '
        Me.txtAplazamiento.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtAplazamiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAplazamiento.Location = New System.Drawing.Point(517, 92)
        Me.txtAplazamiento.Name = "txtAplazamiento"
        Me.txtAplazamiento.Size = New System.Drawing.Size(30, 23)
        Me.txtAplazamiento.TabIndex = 14
        Me.txtAplazamiento.Text = "0"
        '
        'txtNumeroPagos
        '
        Me.txtNumeroPagos.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtNumeroPagos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumeroPagos.Location = New System.Drawing.Point(335, 92)
        Me.txtNumeroPagos.Name = "txtNumeroPagos"
        Me.txtNumeroPagos.Size = New System.Drawing.Size(30, 23)
        Me.txtNumeroPagos.TabIndex = 13
        Me.txtNumeroPagos.Text = "0"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTelefono.Location = New System.Drawing.Point(85, 53)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(75, 10)
        Me.txtTelefono.TabIndex = 12
        Me.txtTelefono.Text = "Telefono....."
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtFechaCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFechaCreacion.Location = New System.Drawing.Point(85, 32)
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Size = New System.Drawing.Size(75, 10)
        Me.txtFechaCreacion.TabIndex = 11
        Me.txtFechaCreacion.Text = "Fecha....."
        '
        'txtTotalAdeudo
        '
        Me.txtTotalAdeudo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtTotalAdeudo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalAdeudo.Location = New System.Drawing.Point(85, 97)
        Me.txtTotalAdeudo.Name = "txtTotalAdeudo"
        Me.txtTotalAdeudo.Size = New System.Drawing.Size(75, 10)
        Me.txtTotalAdeudo.TabIndex = 10
        Me.txtTotalAdeudo.Text = "Total"
        '
        'txtidconvenio
        '
        Me.txtidconvenio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtidconvenio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtidconvenio.Location = New System.Drawing.Point(85, 11)
        Me.txtidconvenio.Name = "txtidconvenio"
        Me.txtidconvenio.Size = New System.Drawing.Size(75, 10)
        Me.txtidconvenio.TabIndex = 8
        Me.txtidconvenio.Text = "Convenio....."
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Location = New System.Drawing.Point(85, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(433, 17)
        Me.txtNombre.TabIndex = 9
        Me.txtNombre.Text = "Nombre....."
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(13, 50)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 7
        Me.LabelX7.Text = "Telefono....."
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(382, 92)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(136, 23)
        Me.LabelX6.TabIndex = 6
        Me.LabelX6.Text = "Dias de aplazamiento...."
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(230, 92)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "No de pagos......"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(13, 27)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "Fecha....."
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEstado.Location = New System.Drawing.Point(472, 4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(75, 23)
        Me.txtEstado.TabIndex = 3
        Me.txtEstado.Text = "Estado"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(13, 92)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Total"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.lbltarifa)
        Me.GroupPanel2.Controls.Add(Me.LabelX14)
        Me.GroupPanel2.Controls.Add(Me.lblcomunidad)
        Me.GroupPanel2.Controls.Add(Me.lblcolonia)
        Me.GroupPanel2.Controls.Add(Me.lbldireccion)
        Me.GroupPanel2.Controls.Add(Me.lblfecha)
        Me.GroupPanel2.Controls.Add(Me.lbltotal)
        Me.GroupPanel2.Controls.Add(Me.lblnombre)
        Me.GroupPanel2.Controls.Add(Me.txtubicacion)
        Me.GroupPanel2.Controls.Add(Me.LabelX10)
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Controls.Add(Me.LabelX11)
        Me.GroupPanel2.Controls.Add(Me.txtestadotoma)
        Me.GroupPanel2.Controls.Add(Me.LabelX13)
        Me.GroupPanel2.Controls.Add(Me.LabelX15)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(21, 166)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(574, 171)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 3
        Me.GroupPanel2.Text = "Datos de la cuenta"
        '
        'lbltarifa
        '
        Me.lbltarifa.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbltarifa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbltarifa.Location = New System.Drawing.Point(322, 118)
        Me.lbltarifa.Name = "lbltarifa"
        Me.lbltarifa.Size = New System.Drawing.Size(97, 23)
        Me.lbltarifa.TabIndex = 16
        Me.lbltarifa.Text = "Tarifa"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(230, 118)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(75, 23)
        Me.LabelX14.TabIndex = 15
        Me.LabelX14.Text = "Tarifa....."
        '
        'lblcomunidad
        '
        Me.lblcomunidad.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblcomunidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblcomunidad.Location = New System.Drawing.Point(105, 95)
        Me.lblcomunidad.Name = "lblcomunidad"
        Me.lblcomunidad.Size = New System.Drawing.Size(333, 23)
        Me.lblcomunidad.TabIndex = 14
        Me.lblcomunidad.Text = "Comunidad....."
        '
        'lblcolonia
        '
        Me.lblcolonia.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblcolonia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblcolonia.Location = New System.Drawing.Point(105, 72)
        Me.lblcolonia.Name = "lblcolonia"
        Me.lblcolonia.Size = New System.Drawing.Size(307, 23)
        Me.lblcolonia.TabIndex = 13
        Me.lblcolonia.Text = "Colonia....."
        '
        'lbldireccion
        '
        Me.lbldireccion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbldireccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbldireccion.Location = New System.Drawing.Point(105, 49)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(333, 23)
        Me.lbldireccion.TabIndex = 12
        Me.lbldireccion.Text = "Direccion....."
        '
        'lblfecha
        '
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblfecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblfecha.Location = New System.Drawing.Point(170, 4)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(242, 23)
        Me.lblfecha.TabIndex = 11
        Me.lblfecha.Text = "Fecha cubierta"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbltotal.Location = New System.Drawing.Point(105, 118)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(97, 23)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.Text = "Total....."
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblnombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblnombre.Location = New System.Drawing.Point(105, 26)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(333, 23)
        Me.lblnombre.TabIndex = 9
        Me.lblnombre.Text = "Nombre....."
        '
        'txtubicacion
        '
        Me.txtubicacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtubicacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtubicacion.Location = New System.Drawing.Point(472, 20)
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.Size = New System.Drawing.Size(75, 23)
        Me.txtubicacion.TabIndex = 8
        Me.txtubicacion.Text = "Ubicacion"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(13, 95)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 23)
        Me.LabelX10.TabIndex = 7
        Me.LabelX10.Text = "Comunidad....."
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(13, 72)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(75, 23)
        Me.LabelX9.TabIndex = 6
        Me.LabelX9.Text = "Colonia....."
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(13, 49)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 5
        Me.LabelX8.Text = "Direccion....."
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(13, 3)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(147, 23)
        Me.LabelX11.TabIndex = 4
        Me.LabelX11.Text = "Periodo de Adeudo"
        '
        'txtestadotoma
        '
        Me.txtestadotoma.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtestadotoma.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtestadotoma.Location = New System.Drawing.Point(472, 4)
        Me.txtestadotoma.Name = "txtestadotoma"
        Me.txtestadotoma.Size = New System.Drawing.Size(75, 23)
        Me.txtestadotoma.TabIndex = 3
        Me.txtestadotoma.Text = "Estado"
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(13, 118)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(75, 23)
        Me.LabelX13.TabIndex = 2
        Me.LabelX13.Text = "Total....."
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(13, 26)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(75, 23)
        Me.LabelX15.TabIndex = 1
        Me.LabelX15.Text = "Nombre....."
        '
        'dataConv
        '
        Me.dataConv.AllowUserToAddRows = False
        Me.dataConv.AllowUserToDeleteRows = False
        Me.dataConv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dataConv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataConv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Pago, Me.Monto, Me.Pagado})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataConv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataConv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataConv.Location = New System.Drawing.Point(21, 343)
        Me.dataConv.Name = "dataConv"
        Me.dataConv.ReadOnly = True
        Me.dataConv.Size = New System.Drawing.Size(415, 170)
        Me.dataConv.TabIndex = 143
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Pago
        '
        Me.Pago.HeaderText = "Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Pagado
        '
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        '
        'Buttoncerrar
        '
        Me.Buttoncerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttoncerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttoncerrar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.Buttoncerrar.Location = New System.Drawing.Point(446, 471)
        Me.Buttoncerrar.Name = "Buttoncerrar"
        Me.Buttoncerrar.Size = New System.Drawing.Size(149, 39)
        Me.Buttoncerrar.TabIndex = 144
        Me.Buttoncerrar.Text = "Cerrar"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.ButtonX4.Location = New System.Drawing.Point(446, 343)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.PulseSpeed = 30
        Me.ButtonX4.Size = New System.Drawing.Size(149, 39)
        Me.ButtonX4.TabIndex = 145
        Me.ButtonX4.Text = "Imprimir"
        '
        'FrnVisualizarConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 522)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.Buttoncerrar)
        Me.Controls.Add(Me.dataConv)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "FrnVisualizarConvenio"
        Me.Text = "Visualizar convenio"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dataConv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtubicacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtestadotoma As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataConv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtAplazamiento As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNumeroPagos As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelefono As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFechaCreacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotalAdeudo As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtidconvenio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbltarifa As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblcomunidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblcolonia As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbldireccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblfecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbltotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblnombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents Buttoncerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblvencimiento As DevComponents.DotNetBar.LabelX
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Pago As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
End Class
