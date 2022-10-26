Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgrCxC
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId_com = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDescrip = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkSis = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEvento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Contratos = New DevComponents.Editors.ComboItem()
        Me.Multas = New DevComponents.Editors.ComboItem()
        Me.Inspecciones = New DevComponents.Editors.ComboItem()
        Me.Otros = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.chkAplIva = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmdAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonX()
        Me.txtMontoIni = New DevComponents.Editors.DoubleInput()
        Me.cmbRubro = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtporce = New DevComponents.Editors.DoubleInput()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtctacont = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DIsalario = New DevComponents.Editors.DoubleInput()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtunidadsat = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtclavesat = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.txtMontoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtporce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIsalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_Concepto:"
        '
        'txtId_com
        '
        Me.txtId_com.AcceptsReturn = True
        '
        '
        '
        Me.txtId_com.Border.Class = "TextBoxBorder"
        Me.txtId_com.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtId_com.FocusHighlightEnabled = True
        Me.txtId_com.Location = New System.Drawing.Point(135, 34)
        Me.txtId_com.MaxLength = 6
        Me.txtId_com.Name = "txtId_com"
        Me.txtId_com.Size = New System.Drawing.Size(111, 20)
        Me.txtId_com.TabIndex = 0
        Me.txtId_com.WatermarkText = "Sólo seis caracteres"
        '
        'txtDescrip
        '
        '
        '
        '
        Me.txtDescrip.Border.Class = "TextBoxBorder"
        Me.txtDescrip.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescrip.FocusHighlightEnabled = True
        Me.txtDescrip.Location = New System.Drawing.Point(135, 63)
        Me.txtDescrip.MaxLength = 250
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(389, 20)
        Me.txtDescrip.TabIndex = 1
        Me.txtDescrip.WatermarkText = "Escriba la descripción del concepto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Monto Inicial Salario Minimo:"
        '
        'chkSis
        '
        '
        '
        '
        Me.chkSis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkSis.Location = New System.Drawing.Point(85, 283)
        Me.chkSis.Name = "chkSis"
        Me.chkSis.Size = New System.Drawing.Size(100, 27)
        Me.chkSis.TabIndex = 7
        Me.chkSis.Text = "Sistema"
        Me.chkSis.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Evento:"
        '
        'cmbEvento
        '
        Me.cmbEvento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEvento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEvento.DisplayMember = "Text"
        Me.cmbEvento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEvento.FocusHighlightEnabled = True
        Me.cmbEvento.FormattingEnabled = True
        Me.cmbEvento.ItemHeight = 15
        Me.cmbEvento.Items.AddRange(New Object() {Me.Contratos, Me.Multas, Me.Inspecciones, Me.Otros, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem1})
        Me.cmbEvento.Location = New System.Drawing.Point(135, 150)
        Me.cmbEvento.Name = "cmbEvento"
        Me.cmbEvento.Size = New System.Drawing.Size(154, 21)
        Me.cmbEvento.TabIndex = 4
        Me.cmbEvento.WatermarkText = "Evento del concepto"
        '
        'Contratos
        '
        Me.Contratos.Text = "Contratos"
        '
        'Multas
        '
        Me.Multas.Text = "Multas"
        '
        'Inspecciones
        '
        Me.Inspecciones.Text = "Inspecciones"
        '
        'Otros
        '
        Me.Otros.Text = "Otros"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "CamNom"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "CamUbi"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "CamTar"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "CamMed"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Reconexion"
        '
        'chkAplIva
        '
        '
        '
        '
        Me.chkAplIva.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAplIva.Location = New System.Drawing.Point(183, 283)
        Me.chkAplIva.Name = "chkAplIva"
        Me.chkAplIva.Size = New System.Drawing.Size(100, 27)
        Me.chkAplIva.TabIndex = 9
        Me.chkAplIva.Text = "Aplica Iva"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAceptar.Location = New System.Drawing.Point(150, 326)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(111, 36)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdSalir
        '
        Me.cmdSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.cmdSalir.Location = New System.Drawing.Point(299, 326)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(111, 36)
        Me.cmdSalir.TabIndex = 11
        Me.cmdSalir.Text = "Terminar"
        '
        'txtMontoIni
        '
        '
        '
        '
        Me.txtMontoIni.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtMontoIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMontoIni.Enabled = False
        Me.txtMontoIni.FocusHighlightEnabled = True
        Me.txtMontoIni.Increment = 1.0R
        Me.txtMontoIni.Location = New System.Drawing.Point(373, 125)
        Me.txtMontoIni.MaxValue = 999999.0R
        Me.txtMontoIni.MinValue = 0R
        Me.txtMontoIni.Name = "txtMontoIni"
        Me.txtMontoIni.ShowUpDown = True
        Me.txtMontoIni.Size = New System.Drawing.Size(101, 20)
        Me.txtMontoIni.TabIndex = 3
        '
        'cmbRubro
        '
        Me.cmbRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRubro.DisplayMember = "Text"
        Me.cmbRubro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRubro.FocusHighlightEnabled = True
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.ItemHeight = 14
        Me.cmbRubro.Location = New System.Drawing.Point(135, 208)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.Size = New System.Drawing.Size(154, 20)
        Me.cmbRubro.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Rubro:"
        '
        'txtporce
        '
        '
        '
        '
        Me.txtporce.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtporce.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtporce.FocusHighlightEnabled = True
        Me.txtporce.Increment = 1.0R
        Me.txtporce.Location = New System.Drawing.Point(135, 234)
        Me.txtporce.MaxValue = 999999.0R
        Me.txtporce.MinValue = 0R
        Me.txtporce.Name = "txtporce"
        Me.txtporce.ShowUpDown = True
        Me.txtporce.Size = New System.Drawing.Size(57, 20)
        Me.txtporce.TabIndex = 7
        Me.txtporce.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Porcentaje"
        Me.Label8.Visible = False
        '
        'txtctacont
        '
        '
        '
        '
        Me.txtctacont.Border.Class = "TextBoxBorder"
        Me.txtctacont.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtctacont.FocusHighlightEnabled = True
        Me.txtctacont.Location = New System.Drawing.Point(135, 263)
        Me.txtctacont.Name = "txtctacont"
        Me.txtctacont.Size = New System.Drawing.Size(166, 20)
        Me.txtctacont.TabIndex = 8
        Me.txtctacont.WatermarkText = "Cuenta Contable"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Cta. Contable:"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(347, 125)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(20, 19)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "$"
        '
        'DIsalario
        '
        '
        '
        '
        Me.DIsalario.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DIsalario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DIsalario.DisplayFormat = "###,###.####"
        Me.DIsalario.FocusHighlightEnabled = True
        Me.DIsalario.Increment = 1.0R
        Me.DIsalario.Location = New System.Drawing.Point(188, 124)
        Me.DIsalario.MaxValue = 999999.0R
        Me.DIsalario.MinValue = 0R
        Me.DIsalario.Name = "DIsalario"
        Me.DIsalario.ShowUpDown = True
        Me.DIsalario.Size = New System.Drawing.Size(101, 20)
        Me.DIsalario.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Clave SAT:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(321, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Unidad Sat"
        '
        'txtunidadsat
        '
        '
        '
        '
        Me.txtunidadsat.Border.Class = "TextBoxBorder"
        Me.txtunidadsat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtunidadsat.Location = New System.Drawing.Point(389, 239)
        Me.txtunidadsat.Name = "txtunidadsat"
        Me.txtunidadsat.PreventEnterBeep = True
        Me.txtunidadsat.Size = New System.Drawing.Size(46, 20)
        Me.txtunidadsat.TabIndex = 18
        '
        'txtclavesat
        '
        '
        '
        '
        Me.txtclavesat.Border.Class = "TextBoxBorder"
        Me.txtclavesat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtclavesat.Location = New System.Drawing.Point(389, 267)
        Me.txtclavesat.Name = "txtclavesat"
        Me.txtclavesat.PreventEnterBeep = True
        Me.txtclavesat.Size = New System.Drawing.Size(135, 20)
        Me.txtclavesat.TabIndex = 19
        '
        'frmAgrCxC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 374)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtclavesat)
        Me.Controls.Add(Me.txtunidadsat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DIsalario)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtctacont)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtporce)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbRubro)
        Me.Controls.Add(Me.txtMontoIni)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.chkAplIva)
        Me.Controls.Add(Me.cmbEvento)
        Me.Controls.Add(Me.chkSis)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_com)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrCxC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos por cobrar"
        CType(Me.txtMontoIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtporce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIsalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Contratos As DevComponents.Editors.ComboItem
    Friend WithEvents Multas As DevComponents.Editors.ComboItem
    Friend WithEvents Inspecciones As DevComponents.Editors.ComboItem
    Friend WithEvents Otros As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Private WithEvents txtId_com As Controls.TextBoxX
    Private WithEvents txtDescrip As Controls.TextBoxX
    Private WithEvents chkSis As Controls.CheckBoxX
    Private WithEvents cmbEvento As Controls.ComboBoxEx
    Private WithEvents chkAplIva As Controls.CheckBoxX
    Private WithEvents cmdAceptar As ButtonX
    Private WithEvents cmdSalir As ButtonX
    Private WithEvents txtMontoIni As DevComponents.Editors.DoubleInput
    Private WithEvents cmbRubro As Controls.ComboBoxEx
    Private WithEvents txtporce As DevComponents.Editors.DoubleInput
    Private WithEvents txtctacont As Controls.TextBoxX
    Private WithEvents LabelX1 As LabelX
    Private WithEvents DIsalario As DevComponents.Editors.DoubleInput
    Private WithEvents txtunidadsat As Controls.TextBoxX
    Private WithEvents txtclavesat As Controls.TextBoxX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
End Class
