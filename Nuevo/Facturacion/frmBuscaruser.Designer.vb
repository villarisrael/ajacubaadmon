<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaruser
    Inherits System.Windows.Forms.Form

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
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtcolonia = New Telerik.WinControls.UI.RadTextBox()
        Me.txtcuenta = New Telerik.WinControls.UI.RadTextBox()
        Me.txtdireccion = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.lblCuenta = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtnombre = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.DTGbusqueda = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btncancelar = New Telerik.WinControls.UI.RadButton()
        Me.btnaceptar = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.txtcolonia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnaceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.txtcolonia)
        Me.RadGroupBox3.Controls.Add(Me.txtcuenta)
        Me.RadGroupBox3.Controls.Add(Me.txtdireccion)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox3.Controls.Add(Me.lblCuenta)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox3.Controls.Add(Me.txtnombre)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox3.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox3.HeaderText = "BÚSQUEDA DE USUARIOS REGISTRADOS"
        Me.RadGroupBox3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadGroupBox3.Location = New System.Drawing.Point(10, 11)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        '
        '
        '
        Me.RadGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.RadGroupBox3.Size = New System.Drawing.Size(726, 107)
        Me.RadGroupBox3.TabIndex = 13
        Me.RadGroupBox3.Text = "BÚSQUEDA DE USUARIOS REGISTRADOS"
        '
        'txtcolonia
        '
        Me.txtcolonia.Location = New System.Drawing.Point(455, 70)
        Me.txtcolonia.Name = "txtcolonia"
        Me.txtcolonia.Size = New System.Drawing.Size(246, 20)
        Me.txtcolonia.TabIndex = 3
        Me.txtcolonia.TabStop = False
        Me.txtcolonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcuenta
        '
        Me.txtcuenta.Location = New System.Drawing.Point(85, 30)
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(246, 20)
        Me.txtcuenta.TabIndex = 0
        Me.txtcuenta.TabStop = False
        Me.txtcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(455, 30)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(246, 20)
        Me.txtdireccion.TabIndex = 2
        Me.txtdireccion.TabStop = False
        Me.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel3
        '
        Me.RadLabel3.AutoSize = True
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(404, 74)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(49, 15)
        Me.RadLabel3.TabIndex = 18
        Me.RadLabel3.Text = "COLONIA:"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(36, 30)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(45, 15)
        Me.lblCuenta.TabIndex = 0
        Me.lblCuenta.Text = "CUENTA:"
        '
        'RadLabel2
        '
        Me.RadLabel2.AutoSize = True
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(395, 30)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(58, 15)
        Me.RadLabel2.TabIndex = 17
        Me.RadLabel2.Text = "DIRECCIÓN:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(85, 70)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(246, 20)
        Me.txtnombre.TabIndex = 1
        Me.txtnombre.TabStop = False
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = True
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(33, 74)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(48, 15)
        Me.RadLabel1.TabIndex = 16
        Me.RadLabel1.Text = "NOMBRE:"
        '
        'DTGbusqueda
        '
        Me.DTGbusqueda.AllowUserToAddRows = False
        Me.DTGbusqueda.AllowUserToDeleteRows = False
        Me.DTGbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DTGbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGbusqueda.DefaultCellStyle = DataGridViewCellStyle1
        Me.DTGbusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DTGbusqueda.Location = New System.Drawing.Point(10, 124)
        Me.DTGbusqueda.Name = "DTGbusqueda"
        Me.DTGbusqueda.ReadOnly = True
        Me.DTGbusqueda.Size = New System.Drawing.Size(726, 186)
        Me.DTGbusqueda.TabIndex = 12
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.btncancelar)
        Me.RadGroupBox2.Controls.Add(Me.btnaceptar)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox2.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center
        Me.RadGroupBox2.HeaderText = "ACCIONES"
        Me.RadGroupBox2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadGroupBox2.Location = New System.Drawing.Point(10, 319)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        '
        '
        '
        Me.RadGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.RadGroupBox2.Size = New System.Drawing.Size(726, 84)
        Me.RadGroupBox2.TabIndex = 11
        Me.RadGroupBox2.Text = "ACCIONES"
        '
        'btncancelar
        '
        Me.btncancelar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(569, 21)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 47)
        Me.btncancelar.TabIndex = 7
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnaceptar
        '
        Me.btnaceptar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btnaceptar.Location = New System.Drawing.Point(54, 21)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(97, 47)
        Me.btnaceptar.TabIndex = 7
        Me.btnaceptar.Text = "ACEPTAR"
        Me.btnaceptar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmBuscaruser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(744, 414)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.DTGbusqueda)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmBuscaruser"
        Me.Text = "Busqueda de usuario"
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.txtcolonia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnaceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtcolonia As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtcuenta As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtdireccion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCuenta As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtnombre As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents DTGbusqueda As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btncancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnaceptar As Telerik.WinControls.UI.RadButton
End Class
