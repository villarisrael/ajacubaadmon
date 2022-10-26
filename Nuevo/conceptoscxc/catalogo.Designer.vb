<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catalogo
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.btnagregar = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.btnimprimir = New DevComponents.DotNetBar.ButtonItem
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonItem
        Me.txttextoabuscar = New DevComponents.DotNetBar.TextBoxItem
        Me.CMBCAMPOBUSQUEDA = New DevComponents.DotNetBar.ComboBoxItem
        Me.btnbuscar = New DevComponents.DotNetBar.ButtonItem
        Me.btnactualizar = New DevComponents.DotNetBar.ButtonItem
        Me.btncerrar = New DevComponents.DotNetBar.ButtonItem
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnagregar, Me.ButtonItem2, Me.btnimprimir, Me.btnEliminar, Me.txttextoabuscar, Me.CMBCAMPOBUSQUEDA, Me.btnbuscar, Me.btnactualizar, Me.btncerrar})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(706, 26)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'btnagregar
        '
        Me.btnagregar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        '        Me.btnagregar.Image = Global.AcquaLiberVista.My.Resources.Resources.kmenuedit
        Me.btnagregar.ImagePaddingHorizontal = 8
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Text = "Agregar"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        '        Me.ButtonItem2.Image = Global.AcquaLiberVista.My.Resources.Resources.kwrite
        Me.ButtonItem2.ImagePaddingHorizontal = 8
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Editar"
        '
        'btnimprimir
        '
        Me.btnimprimir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        '        Me.btnimprimir.Image = Global.AcquaLiberVista.My.Resources.Resources.yast_printer2
        Me.btnimprimir.ImagePaddingHorizontal = 8
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Text = "Imprimir"
        '
        'btnEliminar
        '
        Me.btnEliminar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        ' Me.btnEliminar.Image = Global.AcquaLiberVista.My.Resources.Resources._error
        Me.btnEliminar.ImagePaddingHorizontal = 8
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Text = "Eliminar"
        '
        'txttextoabuscar
        '
        Me.txttextoabuscar.Name = "txttextoabuscar"
        Me.txttextoabuscar.TextBoxWidth = 164
        Me.txttextoabuscar.WatermarkColor = System.Drawing.SystemColors.GrayText
        Me.txttextoabuscar.WatermarkText = "Contenido a buscar"
        '
        'CMBCAMPOBUSQUEDA
        '
        Me.CMBCAMPOBUSQUEDA.ComboWidth = 120
        Me.CMBCAMPOBUSQUEDA.DropDownHeight = 106
        Me.CMBCAMPOBUSQUEDA.DropDownWidth = 140
        Me.CMBCAMPOBUSQUEDA.Name = "CMBCAMPOBUSQUEDA"
        Me.CMBCAMPOBUSQUEDA.WatermarkText = "Campo de busqueda"
        '
        'btnbuscar
        '
        Me.btnbuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        '        Me.btnbuscar.Image = Global.AcquaLiberVista.My.Resources.Resources.kdict
        Me.btnbuscar.ImagePaddingHorizontal = 8
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Text = "Buscar"
        '
        'btnactualizar
        '
        '        Me.btnactualizar.Image = Global.AcquaLiberVista.My.Resources.Resources.yast_route
        Me.btnactualizar.ImagePaddingHorizontal = 8
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Text = "ButtonItem1"
        '
        'btncerrar
        '
        Me.btncerrar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        'Me.btncerrar.Image = Global.AcquaLiberVista.My.Resources.Resources._error
        Me.btncerrar.ImagePaddingHorizontal = 8
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Text = "Cerrar"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 32)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(706, 440)
        Me.DataGridViewX1.TabIndex = 1
        '
        'catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.Bar1)
        Me.Name = "catalogo"
        Me.Size = New System.Drawing.Size(706, 475)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents btnagregar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnimprimir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txttextoabuscar As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents CMBCAMPOBUSQUEDA As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents btnbuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btncerrar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnactualizar As DevComponents.DotNetBar.ButtonItem

End Class
