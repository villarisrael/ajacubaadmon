<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrConcepCis
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
        Me.txtCod_cve = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Codigo = New DevComponents.DotNetBar.LabelX()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cmadCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.inipDNor = New DevComponents.Editors.IntegerInput()
        Me.cmbDirec = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.inipDUrg = New DevComponents.Editors.IntegerInput()
        Me.cmbRespon = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkWeb = New System.Windows.Forms.CheckBox()
        CType(Me.inipDNor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inipDUrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCod_cve
        '
        '
        '
        '
        Me.txtCod_cve.Border.Class = "TextBoxBorder"
        Me.txtCod_cve.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCod_cve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCod_cve.Enabled = False
        Me.txtCod_cve.FocusHighlightEnabled = True
        Me.txtCod_cve.Location = New System.Drawing.Point(162, 29)
        Me.txtCod_cve.MaxLength = 3
        Me.txtCod_cve.Name = "txtCod_cve"
        Me.txtCod_cve.Size = New System.Drawing.Size(121, 20)
        Me.txtCod_cve.TabIndex = 0
        Me.txtCod_cve.WatermarkText = "Sólo tres caracteres"
        '
        'Codigo
        '
        '
        '
        '
        Me.Codigo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Codigo.Location = New System.Drawing.Point(38, 28)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(109, 23)
        Me.Codigo.TabIndex = 0
        Me.Codigo.Text = "Clave del Concepto:"
        '
        'txtDescripcion
        '
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.FocusHighlightEnabled = True
        Me.txtDescripcion.Location = New System.Drawing.Point(162, 68)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(221, 20)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.WatermarkText = "Escriba la Descripción"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(38, 67)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(109, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Descripción:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(38, 106)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(109, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Dirección"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(38, 145)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(109, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Departamento"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(38, 223)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(109, 23)
        Me.LabelX4.TabIndex = 10
        Me.LabelX4.Text = "Días Urgentes"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(38, 184)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(109, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Días Normales"
        '
        'cmadCancelar
        '
        Me.cmadCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmadCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmadCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmadCancelar.Location = New System.Drawing.Point(230, 306)
        Me.cmadCancelar.Name = "cmadCancelar"
        Me.cmadCancelar.PulseSpeed = 30
        Me.cmadCancelar.Size = New System.Drawing.Size(121, 40)
        Me.cmadCancelar.TabIndex = 8
        Me.cmadCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAceptar.Location = New System.Drawing.Point(80, 306)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.PulseSpeed = 30
        Me.cmdAceptar.Size = New System.Drawing.Size(121, 40)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Guardar"
        '
        'inipDNor
        '
        '
        '
        '
        Me.inipDNor.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.inipDNor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.inipDNor.FocusHighlightEnabled = True
        Me.inipDNor.Location = New System.Drawing.Point(162, 185)
        Me.inipDNor.MaxValue = 7
        Me.inipDNor.MinValue = 1
        Me.inipDNor.Name = "inipDNor"
        Me.inipDNor.ShowUpDown = True
        Me.inipDNor.Size = New System.Drawing.Size(80, 20)
        Me.inipDNor.TabIndex = 4
        Me.inipDNor.Value = 1
        Me.inipDNor.WatermarkText = "Seleccione la cantidad"
        '
        'cmbDirec
        '
        Me.cmbDirec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDirec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDirec.DisplayMember = "Text"
        Me.cmbDirec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDirec.FocusHighlightEnabled = True
        Me.cmbDirec.FormattingEnabled = True
        Me.cmbDirec.ItemHeight = 14
        Me.cmbDirec.Location = New System.Drawing.Point(162, 107)
        Me.cmbDirec.Name = "cmbDirec"
        Me.cmbDirec.Size = New System.Drawing.Size(221, 20)
        Me.cmbDirec.TabIndex = 2
        Me.cmbDirec.WatermarkText = "Seleccione la Direccion"
        '
        'inipDUrg
        '
        '
        '
        '
        Me.inipDUrg.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.inipDUrg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.inipDUrg.FocusHighlightEnabled = True
        Me.inipDUrg.Location = New System.Drawing.Point(162, 224)
        Me.inipDUrg.MaxValue = 7
        Me.inipDUrg.MinValue = 1
        Me.inipDUrg.Name = "inipDUrg"
        Me.inipDUrg.ShowUpDown = True
        Me.inipDUrg.Size = New System.Drawing.Size(80, 20)
        Me.inipDUrg.TabIndex = 5
        Me.inipDUrg.Value = 1
        Me.inipDUrg.WatermarkText = "Seleccione la catidad"
        '
        'cmbRespon
        '
        Me.cmbRespon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRespon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRespon.DisplayMember = "Text"
        Me.cmbRespon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRespon.DropDownWidth = 300
        Me.cmbRespon.FocusHighlightEnabled = True
        Me.cmbRespon.FormattingEnabled = True
        Me.cmbRespon.ItemHeight = 14
        Me.cmbRespon.Location = New System.Drawing.Point(162, 146)
        Me.cmbRespon.Name = "cmbRespon"
        Me.cmbRespon.Size = New System.Drawing.Size(221, 20)
        Me.cmbRespon.TabIndex = 3
        Me.cmbRespon.WatermarkText = "Seleccione El Responsable"
        '
        'chkWeb
        '
        Me.chkWeb.AutoSize = True
        Me.chkWeb.Location = New System.Drawing.Point(162, 263)
        Me.chkWeb.Name = "chkWeb"
        Me.chkWeb.Size = New System.Drawing.Size(137, 17)
        Me.chkWeb.TabIndex = 6
        Me.chkWeb.Text = "Mostrar en página Web"
        Me.chkWeb.UseVisualStyleBackColor = True
        '
        'frmAgrConcepCis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWeb)
        Me.Controls.Add(Me.cmbRespon)
        Me.Controls.Add(Me.inipDUrg)
        Me.Controls.Add(Me.cmbDirec)
        Me.Controls.Add(Me.inipDNor)
        Me.Controls.Add(Me.cmadCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtCod_cve)
        Me.Controls.Add(Me.Codigo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAgrConcepCis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos CIS"
        CType(Me.inipDNor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inipDUrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCod_cve As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Codigo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmadCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents inipDNor As DevComponents.Editors.IntegerInput
    Friend WithEvents cmbDirec As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents inipDUrg As DevComponents.Editors.IntegerInput
    Friend WithEvents cmbRespon As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkWeb As System.Windows.Forms.CheckBox
End Class
