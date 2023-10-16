<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoImprContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoImprContrato))
        Me.OptCopia = New System.Windows.Forms.RadioButton()
        Me.OptOriginal = New System.Windows.Forms.RadioButton()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rbcambiomedidor = New System.Windows.Forms.RadioButton()
        Me.rbcambiotarifa = New System.Windows.Forms.RadioButton()
        Me.rbnotcargo = New System.Windows.Forms.RadioButton()
        Me.RbComsincargo = New System.Windows.Forms.RadioButton()
        Me.Rbcomprconcargo = New System.Windows.Forms.RadioButton()
        Me.Rbcontrato6 = New System.Windows.Forms.RadioButton()
        Me.RBcontrato5 = New System.Windows.Forms.RadioButton()
        Me.RBcontrato4 = New System.Windows.Forms.RadioButton()
        Me.RBcontrato3 = New System.Windows.Forms.RadioButton()
        Me.RBcambiodenombre = New System.Windows.Forms.RadioButton()
        Me.RBcontrato1 = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptCopia
        '
        Me.OptCopia.AutoSize = True
        Me.OptCopia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCopia.Location = New System.Drawing.Point(161, 286)
        Me.OptCopia.Name = "OptCopia"
        Me.OptCopia.Size = New System.Drawing.Size(59, 20)
        Me.OptCopia.TabIndex = 2
        Me.OptCopia.Text = "Copia"
        Me.OptCopia.UseVisualStyleBackColor = True
        '
        'OptOriginal
        '
        Me.OptOriginal.AutoSize = True
        Me.OptOriginal.Checked = True
        Me.OptOriginal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOriginal.Location = New System.Drawing.Point(22, 286)
        Me.OptOriginal.Name = "OptOriginal"
        Me.OptOriginal.Size = New System.Drawing.Size(70, 20)
        Me.OptOriginal.TabIndex = 1
        Me.OptOriginal.TabStop = True
        Me.OptOriginal.Text = "Original"
        Me.OptOriginal.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(138, 312)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 46)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(22, 312)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 46)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rbcambiomedidor)
        Me.GroupPanel1.Controls.Add(Me.rbcambiotarifa)
        Me.GroupPanel1.Controls.Add(Me.rbnotcargo)
        Me.GroupPanel1.Controls.Add(Me.RbComsincargo)
        Me.GroupPanel1.Controls.Add(Me.Rbcomprconcargo)
        Me.GroupPanel1.Controls.Add(Me.Rbcontrato6)
        Me.GroupPanel1.Controls.Add(Me.RBcontrato5)
        Me.GroupPanel1.Controls.Add(Me.RBcontrato4)
        Me.GroupPanel1.Controls.Add(Me.RBcontrato3)
        Me.GroupPanel1.Controls.Add(Me.RBcambiodenombre)
        Me.GroupPanel1.Controls.Add(Me.RBcontrato1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(22, 22)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(532, 258)
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
        Me.GroupPanel1.TabIndex = 5
        Me.GroupPanel1.Text = "Formato de "
        '
        'rbcambiomedidor
        '
        Me.rbcambiomedidor.AutoSize = True
        Me.rbcambiomedidor.BackColor = System.Drawing.Color.Transparent
        Me.rbcambiomedidor.Location = New System.Drawing.Point(239, 26)
        Me.rbcambiomedidor.Name = "rbcambiomedidor"
        Me.rbcambiomedidor.Size = New System.Drawing.Size(101, 17)
        Me.rbcambiomedidor.TabIndex = 19
        Me.rbcambiomedidor.Text = "Cambio Medidor"
        Me.rbcambiomedidor.UseVisualStyleBackColor = False
        '
        'rbcambiotarifa
        '
        Me.rbcambiotarifa.AutoSize = True
        Me.rbcambiotarifa.BackColor = System.Drawing.Color.Transparent
        Me.rbcambiotarifa.Location = New System.Drawing.Point(239, 3)
        Me.rbcambiotarifa.Name = "rbcambiotarifa"
        Me.rbcambiotarifa.Size = New System.Drawing.Size(90, 17)
        Me.rbcambiotarifa.TabIndex = 18
        Me.rbcambiotarifa.Text = "Cambio Tarifa"
        Me.rbcambiotarifa.UseVisualStyleBackColor = False
        '
        'rbnotcargo
        '
        Me.rbnotcargo.AutoSize = True
        Me.rbnotcargo.BackColor = System.Drawing.Color.Transparent
        Me.rbnotcargo.Location = New System.Drawing.Point(18, 190)
        Me.rbnotcargo.Name = "rbnotcargo"
        Me.rbnotcargo.Size = New System.Drawing.Size(84, 17)
        Me.rbnotcargo.TabIndex = 17
        Me.rbnotcargo.Text = "Notificacion "
        Me.rbnotcargo.UseVisualStyleBackColor = False
        '
        'RbComsincargo
        '
        Me.RbComsincargo.AutoSize = True
        Me.RbComsincargo.BackColor = System.Drawing.Color.Transparent
        Me.RbComsincargo.Location = New System.Drawing.Point(18, 167)
        Me.RbComsincargo.Name = "RbComsincargo"
        Me.RbComsincargo.Size = New System.Drawing.Size(135, 17)
        Me.RbComsincargo.TabIndex = 16
        Me.RbComsincargo.Text = "Comprobante sin Cargo"
        Me.RbComsincargo.UseVisualStyleBackColor = False
        Me.RbComsincargo.Visible = False
        '
        'Rbcomprconcargo
        '
        Me.Rbcomprconcargo.AutoSize = True
        Me.Rbcomprconcargo.BackColor = System.Drawing.Color.Transparent
        Me.Rbcomprconcargo.Location = New System.Drawing.Point(18, 144)
        Me.Rbcomprconcargo.Name = "Rbcomprconcargo"
        Me.Rbcomprconcargo.Size = New System.Drawing.Size(139, 17)
        Me.Rbcomprconcargo.TabIndex = 15
        Me.Rbcomprconcargo.Text = "Comprobante con cargo"
        Me.Rbcomprconcargo.UseVisualStyleBackColor = False
        Me.Rbcomprconcargo.Visible = False
        '
        'Rbcontrato6
        '
        Me.Rbcontrato6.AutoSize = True
        Me.Rbcontrato6.BackColor = System.Drawing.Color.Transparent
        Me.Rbcontrato6.Location = New System.Drawing.Point(18, 26)
        Me.Rbcontrato6.Name = "Rbcontrato6"
        Me.Rbcontrato6.Size = New System.Drawing.Size(88, 17)
        Me.Rbcontrato6.TabIndex = 14
        Me.Rbcontrato6.Text = "Alcantarillado"
        Me.Rbcontrato6.UseVisualStyleBackColor = False
        '
        'RBcontrato5
        '
        Me.RBcontrato5.AutoSize = True
        Me.RBcontrato5.BackColor = System.Drawing.Color.Transparent
        Me.RBcontrato5.Location = New System.Drawing.Point(18, 121)
        Me.RBcontrato5.Name = "RBcontrato5"
        Me.RBcontrato5.Size = New System.Drawing.Size(115, 17)
        Me.RBcontrato5.TabIndex = 13
        Me.RBcontrato5.Text = "Contrato Editable 3"
        Me.RBcontrato5.UseVisualStyleBackColor = False
        Me.RBcontrato5.Visible = False
        '
        'RBcontrato4
        '
        Me.RBcontrato4.AutoSize = True
        Me.RBcontrato4.BackColor = System.Drawing.Color.Transparent
        Me.RBcontrato4.Location = New System.Drawing.Point(18, 98)
        Me.RBcontrato4.Name = "RBcontrato4"
        Me.RBcontrato4.Size = New System.Drawing.Size(115, 17)
        Me.RBcontrato4.TabIndex = 12
        Me.RBcontrato4.Text = "Contrato Editable 2"
        Me.RBcontrato4.UseVisualStyleBackColor = False
        Me.RBcontrato4.Visible = False
        '
        'RBcontrato3
        '
        Me.RBcontrato3.AutoSize = True
        Me.RBcontrato3.BackColor = System.Drawing.Color.Transparent
        Me.RBcontrato3.Location = New System.Drawing.Point(18, 75)
        Me.RBcontrato3.Name = "RBcontrato3"
        Me.RBcontrato3.Size = New System.Drawing.Size(149, 17)
        Me.RBcontrato3.TabIndex = 11
        Me.RBcontrato3.Text = "Constancia de No adeudo"
        Me.RBcontrato3.UseVisualStyleBackColor = False
        '
        'RBcambiodenombre
        '
        Me.RBcambiodenombre.AutoSize = True
        Me.RBcambiodenombre.BackColor = System.Drawing.Color.Transparent
        Me.RBcambiodenombre.Location = New System.Drawing.Point(18, 52)
        Me.RBcambiodenombre.Name = "RBcambiodenombre"
        Me.RBcambiodenombre.Size = New System.Drawing.Size(155, 17)
        Me.RBcambiodenombre.TabIndex = 10
        Me.RBcambiodenombre.Text = "Contrato cambio de nombre"
        Me.RBcambiodenombre.UseVisualStyleBackColor = False
        '
        'RBcontrato1
        '
        Me.RBcontrato1.AutoSize = True
        Me.RBcontrato1.BackColor = System.Drawing.Color.Transparent
        Me.RBcontrato1.Checked = True
        Me.RBcontrato1.Location = New System.Drawing.Point(18, 3)
        Me.RBcontrato1.Name = "RBcontrato1"
        Me.RBcontrato1.Size = New System.Drawing.Size(93, 17)
        Me.RBcontrato1.TabIndex = 9
        Me.RBcontrato1.TabStop = True
        Me.RBcontrato1.Text = "Contrato Agua"
        Me.RBcontrato1.UseVisualStyleBackColor = False
        '
        'FrmTipoImprContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 388)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.OptOriginal)
        Me.Controls.Add(Me.OptCopia)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmTipoImprContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Impresión"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OptCopia As System.Windows.Forms.RadioButton
    Friend WithEvents OptOriginal As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbcambiotarifa As RadioButton
    Public WithEvents rbnotcargo As RadioButton
    Public WithEvents RbComsincargo As RadioButton
    Public WithEvents Rbcomprconcargo As RadioButton
    Friend WithEvents Rbcontrato6 As RadioButton
    Friend WithEvents RBcontrato5 As RadioButton
    Friend WithEvents RBcontrato4 As RadioButton
    Friend WithEvents RBcontrato3 As RadioButton
    Friend WithEvents RBcontrato1 As RadioButton
    Friend WithEvents rbcambiomedidor As RadioButton
    Friend WithEvents RBcambiodenombre As RadioButton
End Class
