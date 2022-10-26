Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmdatosfiscales
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
        Me.txtcuentabancaria = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbbanco = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtdelegacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtcp = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btncancelar = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BTNGUARDAR = New Telerik.WinControls.UI.RadButton()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpoblacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcolonia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnuminterior = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumext = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcalle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbRegimenFiscal = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNGUARDAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcuentabancaria
        '
        '
        '
        '
        Me.txtcuentabancaria.Border.Class = "TextBoxBorder"
        Me.txtcuentabancaria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcuentabancaria.Location = New System.Drawing.Point(99, 312)
        Me.txtcuentabancaria.MaxLength = 10
        Me.txtcuentabancaria.Name = "txtcuentabancaria"
        Me.txtcuentabancaria.PreventEnterBeep = True
        Me.txtcuentabancaria.Size = New System.Drawing.Size(117, 20)
        Me.txtcuentabancaria.TabIndex = 71
        '
        'cmbbanco
        '
        Me.cmbbanco.DisplayMember = "Text"
        Me.cmbbanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbbanco.FormattingEnabled = True
        Me.cmbbanco.ItemHeight = 15
        Me.cmbbanco.Location = New System.Drawing.Point(99, 286)
        Me.cmbbanco.Name = "cmbbanco"
        Me.cmbbanco.Size = New System.Drawing.Size(393, 21)
        Me.cmbbanco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbbanco.TabIndex = 70
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DarkRed
        Me.Label18.Location = New System.Drawing.Point(10, 314)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Cuenta"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(10, 293)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Banco"
        '
        'txtdelegacion
        '
        Me.txtdelegacion.Location = New System.Drawing.Point(99, 126)
        Me.txtdelegacion.MaxLength = 255
        Me.txtdelegacion.Name = "txtdelegacion"
        Me.txtdelegacion.Size = New System.Drawing.Size(423, 20)
        Me.txtdelegacion.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(10, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Delegacion"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(355, 155)
        Me.txtPais.MaxLength = 255
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(167, 20)
        Me.txtPais.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(313, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Pais"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(99, 221)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(378, 20)
        Me.txtmail.TabIndex = 58
        '
        'txtcp
        '
        Me.txtcp.Location = New System.Drawing.Point(99, 195)
        Me.txtcp.Mask = "00000"
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(54, 20)
        Me.txtcp.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(10, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "*email"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.btncancelar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(29, 21)
        Me.btncancelar.Name = "btncancelar"
        '
        '
        '
        Me.btncancelar.RootElement.AccessibleDescription = Nothing
        Me.btncancelar.RootElement.AccessibleName = Nothing
        Me.btncancelar.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.btncancelar.Size = New System.Drawing.Size(97, 47)
        Me.btncancelar.TabIndex = 1
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadGroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.RadGroupBox2.Controls.Add(Me.btncancelar)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox2.HeaderText = "ACCIONES"
        Me.RadGroupBox2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadGroupBox2.Location = New System.Drawing.Point(156, 342)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        '
        '
        '
        Me.RadGroupBox2.RootElement.AccessibleDescription = Nothing
        Me.RadGroupBox2.RootElement.AccessibleName = Nothing
        Me.RadGroupBox2.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 100)
        Me.RadGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.RadGroupBox2.Size = New System.Drawing.Size(366, 78)
        Me.RadGroupBox2.TabIndex = 62
        Me.RadGroupBox2.Text = "ACCIONES"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNGUARDAR.Image = Global.Administativo.My.Resources.Resources.Guardar
        Me.BTNGUARDAR.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNGUARDAR.Location = New System.Drawing.Point(232, 21)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        '
        '
        '
        Me.BTNGUARDAR.RootElement.AccessibleDescription = Nothing
        Me.BTNGUARDAR.RootElement.AccessibleName = Nothing
        Me.BTNGUARDAR.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.BTNGUARDAR.Size = New System.Drawing.Size(97, 47)
        Me.BTNGUARDAR.TabIndex = 2
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(99, 152)
        Me.txtestado.MaxLength = 255
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(194, 20)
        Me.txtestado.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(10, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "*Estado"
        '
        'txtrfc
        '
        Me.txtrfc.Location = New System.Drawing.Point(304, 191)
        Me.txtrfc.MaxLength = 15
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(164, 20)
        Me.txtrfc.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(209, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "*RFC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(10, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "*CP"
        '
        'txtpoblacion
        '
        Me.txtpoblacion.Location = New System.Drawing.Point(99, 100)
        Me.txtpoblacion.MaxLength = 255
        Me.txtpoblacion.Name = "txtpoblacion"
        Me.txtpoblacion.Size = New System.Drawing.Size(423, 20)
        Me.txtpoblacion.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(10, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "*Poblacion"
        '
        'txtcolonia
        '
        Me.txtcolonia.Location = New System.Drawing.Point(99, 74)
        Me.txtcolonia.MaxLength = 255
        Me.txtcolonia.Name = "txtcolonia"
        Me.txtcolonia.Size = New System.Drawing.Size(423, 20)
        Me.txtcolonia.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(10, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "*Colonia"
        '
        'txtnuminterior
        '
        Me.txtnuminterior.Location = New System.Drawing.Point(304, 51)
        Me.txtnuminterior.MaxLength = 45
        Me.txtnuminterior.Name = "txtnuminterior"
        Me.txtnuminterior.Size = New System.Drawing.Size(87, 20)
        Me.txtnuminterior.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(209, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Num Interior"
        '
        'txtnumext
        '
        Me.txtnumext.Location = New System.Drawing.Point(99, 51)
        Me.txtnumext.MaxLength = 40
        Me.txtnumext.Name = "txtnumext"
        Me.txtnumext.Size = New System.Drawing.Size(87, 20)
        Me.txtnumext.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(10, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Num Exterior"
        '
        'txtcalle
        '
        Me.txtcalle.Location = New System.Drawing.Point(99, 31)
        Me.txtcalle.MaxLength = 255
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(423, 20)
        Me.txtcalle.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(10, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "*Calle"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(99, 9)
        Me.txtnombre.MaxLength = 255
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(423, 20)
        Me.txtnombre.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "*Nombre"
        '
        'CmbRegimenFiscal
        '
        Me.CmbRegimenFiscal.DisplayMember = "Text"
        Me.CmbRegimenFiscal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbRegimenFiscal.FormattingEnabled = True
        Me.CmbRegimenFiscal.ItemHeight = 15
        Me.CmbRegimenFiscal.Location = New System.Drawing.Point(99, 250)
        Me.CmbRegimenFiscal.Name = "CmbRegimenFiscal"
        Me.CmbRegimenFiscal.Size = New System.Drawing.Size(393, 21)
        Me.CmbRegimenFiscal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmbRegimenFiscal.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(10, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Régimen Fiscal"
        '
        'frmdatosfiscales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 432)
        Me.Controls.Add(Me.CmbRegimenFiscal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtcuentabancaria)
        Me.Controls.Add(Me.cmbbanco)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtdelegacion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtrfc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpoblacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcolonia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnuminterior)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnumext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmdatosfiscales"
        Me.Text = "Datos fiscales"
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNGUARDAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcuentabancaria As Controls.TextBoxX
    Friend WithEvents cmbbanco As Controls.ComboBoxEx
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtdelegacion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtmail As TextBox
    Friend WithEvents txtcp As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btncancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BTNGUARDAR As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtestado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtrfc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpoblacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcolonia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnuminterior As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnumext As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcalle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbRegimenFiscal As Controls.ComboBoxEx
    Friend WithEvents Label13 As Label
End Class
