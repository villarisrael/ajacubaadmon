<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadisticasMensuales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstadisticasMensuales))
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btncancelar = New Telerik.WinControls.UI.RadButton()
        Me.btnaceptar = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RBNumTomas = New System.Windows.Forms.RadioButton()
        Me.RBNumDescargas = New System.Windows.Forms.RadioButton()
        Me.RBVolServicio = New System.Windows.Forms.RadioButton()
        Me.RBAguaFacturada = New System.Windows.Forms.RadioButton()
        Me.txtComunidad = New System.Windows.Forms.TextBox()
        Me.CmbPeriodo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CmbMeses = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnaceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.CmbMeses)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox3.Controls.Add(Me.CmbPeriodo)
        Me.RadGroupBox3.Controls.Add(Me.txtComunidad)
        Me.RadGroupBox3.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox3.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox3.HeaderText = "Filtro"
        Me.RadGroupBox3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadGroupBox3.Location = New System.Drawing.Point(45, 46)
        Me.RadGroupBox3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Padding = New System.Windows.Forms.Padding(4, 27, 4, 2)
        '
        '
        '
        Me.RadGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(4, 27, 4, 2)
        Me.RadGroupBox3.Size = New System.Drawing.Size(772, 205)
        Me.RadGroupBox3.TabIndex = 4
        Me.RadGroupBox3.Text = "Filtro"
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = True
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(33, 134)
        Me.RadLabel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(81, 26)
        Me.RadLabel1.TabIndex = 35
        Me.RadLabel1.Text = "PERIODO"
        '
        'RadLabel6
        '
        Me.RadLabel6.AutoSize = True
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(11, 31)
        Me.RadLabel6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(114, 26)
        Me.RadLabel6.TabIndex = 22
        Me.RadLabel6.Text = "COMUNIDAD"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.btncancelar)
        Me.RadGroupBox2.Controls.Add(Me.btnaceptar)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox2.HeaderText = "ACCIONES"
        Me.RadGroupBox2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadGroupBox2.Location = New System.Drawing.Point(45, 261)
        Me.RadGroupBox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Padding = New System.Windows.Forms.Padding(4, 27, 4, 2)
        '
        '
        '
        Me.RadGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(4, 27, 4, 2)
        Me.RadGroupBox2.Size = New System.Drawing.Size(772, 103)
        Me.RadGroupBox2.TabIndex = 5
        Me.RadGroupBox2.Text = "ACCIONES"
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(567, 32)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(172, 52)
        Me.btncancelar.TabIndex = 1
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btnaceptar.Location = New System.Drawing.Point(28, 32)
        Me.btnaceptar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(172, 52)
        Me.btnaceptar.TabIndex = 0
        Me.btnaceptar.Text = "ACEPTAR"
        Me.btnaceptar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.RBAguaFacturada)
        Me.RadPanel1.Controls.Add(Me.RBVolServicio)
        Me.RadPanel1.Controls.Add(Me.RBNumDescargas)
        Me.RadPanel1.Controls.Add(Me.RBNumTomas)
        Me.RadPanel1.Location = New System.Drawing.Point(480, 22)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(286, 177)
        Me.RadPanel1.TabIndex = 37
        '
        'RBNumTomas
        '
        Me.RBNumTomas.AutoSize = True
        Me.RBNumTomas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNumTomas.Location = New System.Drawing.Point(21, 9)
        Me.RBNumTomas.Name = "RBNumTomas"
        Me.RBNumTomas.Size = New System.Drawing.Size(175, 27)
        Me.RBNumTomas.TabIndex = 0
        Me.RBNumTomas.TabStop = True
        Me.RBNumTomas.Text = "Número de tomas"
        Me.RBNumTomas.UseVisualStyleBackColor = True
        '
        'RBNumDescargas
        '
        Me.RBNumDescargas.AutoSize = True
        Me.RBNumDescargas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNumDescargas.Location = New System.Drawing.Point(21, 48)
        Me.RBNumDescargas.Name = "RBNumDescargas"
        Me.RBNumDescargas.Size = New System.Drawing.Size(204, 27)
        Me.RBNumDescargas.TabIndex = 1
        Me.RBNumDescargas.TabStop = True
        Me.RBNumDescargas.Text = "Número de descargas"
        Me.RBNumDescargas.UseVisualStyleBackColor = True
        '
        'RBVolServicio
        '
        Me.RBVolServicio.AutoSize = True
        Me.RBVolServicio.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBVolServicio.Location = New System.Drawing.Point(21, 89)
        Me.RBVolServicio.Name = "RBVolServicio"
        Me.RBVolServicio.Size = New System.Drawing.Size(203, 27)
        Me.RBVolServicio.TabIndex = 2
        Me.RBVolServicio.TabStop = True
        Me.RBVolServicio.Text = "Volumen por Servicio"
        Me.RBVolServicio.UseVisualStyleBackColor = True
        '
        'RBAguaFacturada
        '
        Me.RBAguaFacturada.AutoSize = True
        Me.RBAguaFacturada.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBAguaFacturada.Location = New System.Drawing.Point(21, 133)
        Me.RBAguaFacturada.Name = "RBAguaFacturada"
        Me.RBAguaFacturada.Size = New System.Drawing.Size(156, 27)
        Me.RBAguaFacturada.TabIndex = 3
        Me.RBAguaFacturada.TabStop = True
        Me.RBAguaFacturada.Text = "Agua Facturada"
        Me.RBAguaFacturada.UseVisualStyleBackColor = True
        '
        'txtComunidad
        '
        Me.txtComunidad.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComunidad.Location = New System.Drawing.Point(133, 29)
        Me.txtComunidad.Name = "txtComunidad"
        Me.txtComunidad.Size = New System.Drawing.Size(307, 30)
        Me.txtComunidad.TabIndex = 38
        '
        'CmbPeriodo
        '
        Me.CmbPeriodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPeriodo.FormattingEnabled = True
        Me.CmbPeriodo.ItemHeight = 22
        Me.CmbPeriodo.Location = New System.Drawing.Point(133, 134)
        Me.CmbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbPeriodo.Name = "CmbPeriodo"
        Me.CmbPeriodo.Size = New System.Drawing.Size(111, 28)
        Me.CmbPeriodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmbPeriodo.TabIndex = 39
        '
        'CmbMeses
        '
        Me.CmbMeses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMeses.FormattingEnabled = True
        Me.CmbMeses.ItemHeight = 22
        Me.CmbMeses.Location = New System.Drawing.Point(133, 82)
        Me.CmbMeses.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbMeses.Name = "CmbMeses"
        Me.CmbMeses.Size = New System.Drawing.Size(188, 28)
        Me.CmbMeses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmbMeses.TabIndex = 41
        '
        'RadLabel2
        '
        Me.RadLabel2.AutoSize = True
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(72, 84)
        Me.RadLabel2.Margin = New System.Windows.Forms.Padding(5)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 26)
        Me.RadLabel2.TabIndex = 40
        Me.RadLabel2.Text = "MES"
        '
        'FrmEstadisticasMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 393)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmEstadisticasMensuales"
        Me.Text = "FrmEstadisticasMensuales"
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnaceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btncancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnaceptar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RBAguaFacturada As RadioButton
    Friend WithEvents RBVolServicio As RadioButton
    Friend WithEvents RBNumDescargas As RadioButton
    Friend WithEvents RBNumTomas As RadioButton
    Friend WithEvents txtComunidad As TextBox
    Friend WithEvents CmbMeses As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CmbPeriodo As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
