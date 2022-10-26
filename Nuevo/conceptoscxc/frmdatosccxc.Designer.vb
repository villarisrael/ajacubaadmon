<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdatosccxc
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
        Me.txtclave = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtdescripcion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.cmbtipo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.chksistema = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.cmbmomento = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.cmbevento = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem5 = New DevComponents.Editors.ComboItem
        Me.ComboItem6 = New DevComponents.Editors.ComboItem
        Me.ComboItem7 = New DevComponents.Editors.ComboItem
        Me.ComboItem8 = New DevComponents.Editors.ComboItem
        Me.ComboItem9 = New DevComponents.Editors.ComboItem
        Me.ComboItem10 = New DevComponents.Editors.ComboItem
        Me.ComboItem11 = New DevComponents.Editors.ComboItem
        Me.ComboItem12 = New DevComponents.Editors.ComboItem
        Me.ComboItem13 = New DevComponents.Editors.ComboItem
        Me.ComboItem14 = New DevComponents.Editors.ComboItem
        Me.ComboItem15 = New DevComponents.Editors.ComboItem
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.IntegerInput1 = New DevComponents.Editors.IntegerInput
        Me.btnaceptar = New DevComponents.DotNetBar.ButtonX
        Me.btncancelar = New DevComponents.DotNetBar.ButtonX
        CType(Me.IntegerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtclave
        '
        '
        '
        '
        Me.txtclave.Border.Class = "TextBoxBorder"
        Me.txtclave.Location = New System.Drawing.Point(130, 20)
        Me.txtclave.MaxLength = 6
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(98, 20)
        Me.txtclave.TabIndex = 0
        Me.txtclave.WatermarkText = "6 CARACTERES"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(38, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(58, 10)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Clave "
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(38, 59)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(70, 18)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Descripcion"
        '
        'txtdescripcion
        '
        '
        '
        '
        Me.txtdescripcion.Border.Class = "TextBoxBorder"
        Me.txtdescripcion.Location = New System.Drawing.Point(130, 57)
        Me.txtdescripcion.MaxLength = 70
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(209, 20)
        Me.txtdescripcion.TabIndex = 3
        Me.txtdescripcion.WatermarkText = "Descripción del movimiento"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(38, 102)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(56, 20)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Tipo"
        '
        'cmbtipo
        '
        Me.cmbtipo.DisplayMember = "Text"
        Me.cmbtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.ItemHeight = 14
        Me.cmbtipo.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cmbtipo.Location = New System.Drawing.Point(130, 102)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(126, 20)
        Me.cmbtipo.TabIndex = 5
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Cargo"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Abono"
        '
        'chksistema
        '
        Me.chksistema.Location = New System.Drawing.Point(280, 102)
        Me.chksistema.Name = "chksistema"
        Me.chksistema.Size = New System.Drawing.Size(85, 19)
        Me.chksistema.TabIndex = 6
        Me.chksistema.Text = "Sistema"
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(38, 147)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(122, 19)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Momento de aplicación"
        '
        'cmbmomento
        '
        Me.cmbmomento.DisplayMember = "Text"
        Me.cmbmomento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbmomento.FormattingEnabled = True
        Me.cmbmomento.ItemHeight = 14
        Me.cmbmomento.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4})
        Me.cmbmomento.Location = New System.Drawing.Point(179, 153)
        Me.cmbmomento.Name = "cmbmomento"
        Me.cmbmomento.Size = New System.Drawing.Size(128, 20)
        Me.cmbmomento.TabIndex = 8
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Cierre"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Inmediata"
        '
        'LabelX5
        '
        Me.LabelX5.Location = New System.Drawing.Point(38, 191)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(93, 17)
        Me.LabelX5.TabIndex = 9
        Me.LabelX5.Text = "Evento"
        '
        'cmbevento
        '
        Me.cmbevento.DisplayMember = "Text"
        Me.cmbevento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbevento.FormattingEnabled = True
        Me.cmbevento.ItemHeight = 14
        Me.cmbevento.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12, Me.ComboItem13, Me.ComboItem14, Me.ComboItem15})
        Me.cmbevento.Location = New System.Drawing.Point(144, 190)
        Me.cmbevento.Name = "cmbevento"
        Me.cmbevento.Size = New System.Drawing.Size(183, 20)
        Me.cmbevento.TabIndex = 10
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Multas"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Requerimientos"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Notas"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Otros"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Contratos"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Lecturas"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Ajuste"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "Factibilidad"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "Corte"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "Reconexion"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "Mantenimiento"
        '
        'LabelX6
        '
        Me.LabelX6.Location = New System.Drawing.Point(38, 233)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(80, 20)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Monto"
        '
        'IntegerInput1
        '
        '
        '
        '
        Me.IntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IntegerInput1.Location = New System.Drawing.Point(144, 235)
        Me.IntegerInput1.Name = "IntegerInput1"
        Me.IntegerInput1.ShowUpDown = True
        Me.IntegerInput1.Size = New System.Drawing.Size(80, 20)
        Me.IntegerInput1.TabIndex = 12
        '
        'btnaceptar
        '
        Me.btnaceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnaceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnaceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.btnaceptar.Location = New System.Drawing.Point(179, 270)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(86, 58)
        Me.btnaceptar.TabIndex = 13
        Me.btnaceptar.Text = "Aceptar"
        '
        'btncancelar
        '
        Me.btncancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.btncancelar.Location = New System.Drawing.Point(276, 270)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(102, 55)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        '
        'frmdatosccxc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 340)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.IntegerInput1)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.cmbevento)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.cmbmomento)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.chksistema)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtclave)
        Me.Name = "frmdatosccxc"
        Me.Text = "Eventos"
        CType(Me.IntegerInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtclave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbtipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents chksistema As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbmomento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbevento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IntegerInput1 As DevComponents.Editors.IntegerInput
    Friend WithEvents btnaceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btncancelar As DevComponents.DotNetBar.ButtonX
End Class
