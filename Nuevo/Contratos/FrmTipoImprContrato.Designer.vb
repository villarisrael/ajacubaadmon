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
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RBBajaDefinitiva = New System.Windows.Forms.RadioButton()
        Me.RBBajaTemporal = New System.Windows.Forms.RadioButton()
        Me.RBCambioMedidor = New System.Windows.Forms.RadioButton()
        Me.RBCambioTarifa = New System.Windows.Forms.RadioButton()
        Me.RBNotificacion = New System.Windows.Forms.RadioButton()
        Me.RBContratoAlcantarillado = New System.Windows.Forms.RadioButton()
        Me.RBConstanciaNoAdeudo = New System.Windows.Forms.RadioButton()
        Me.RBCambioNombre = New System.Windows.Forms.RadioButton()
        Me.RBContratoAgua = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupPanel1.Controls.Add(Me.RBBajaDefinitiva)
        Me.GroupPanel1.Controls.Add(Me.RBBajaTemporal)
        Me.GroupPanel1.Controls.Add(Me.RBCambioMedidor)
        Me.GroupPanel1.Controls.Add(Me.RBCambioTarifa)
        Me.GroupPanel1.Controls.Add(Me.RBNotificacion)
        Me.GroupPanel1.Controls.Add(Me.RBContratoAlcantarillado)
        Me.GroupPanel1.Controls.Add(Me.RBConstanciaNoAdeudo)
        Me.GroupPanel1.Controls.Add(Me.RBCambioNombre)
        Me.GroupPanel1.Controls.Add(Me.RBContratoAgua)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(22, 22)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(480, 258)
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
        'RBBajaDefinitiva
        '
        Me.RBBajaDefinitiva.AutoSize = True
        Me.RBBajaDefinitiva.BackColor = System.Drawing.Color.Transparent
        Me.RBBajaDefinitiva.Location = New System.Drawing.Point(277, 75)
        Me.RBBajaDefinitiva.Name = "RBBajaDefinitiva"
        Me.RBBajaDefinitiva.Size = New System.Drawing.Size(149, 17)
        Me.RBBajaDefinitiva.TabIndex = 22
        Me.RBBajaDefinitiva.Text = "Formato de Baja Definitiva"
        Me.RBBajaDefinitiva.UseVisualStyleBackColor = False
        '
        'RBBajaTemporal
        '
        Me.RBBajaTemporal.AutoSize = True
        Me.RBBajaTemporal.BackColor = System.Drawing.Color.Transparent
        Me.RBBajaTemporal.Location = New System.Drawing.Point(277, 49)
        Me.RBBajaTemporal.Name = "RBBajaTemporal"
        Me.RBBajaTemporal.Size = New System.Drawing.Size(149, 17)
        Me.RBBajaTemporal.TabIndex = 21
        Me.RBBajaTemporal.Text = "Formato de Baja Temporal"
        Me.RBBajaTemporal.UseVisualStyleBackColor = False
        '
        'RBCambioMedidor
        '
        Me.RBCambioMedidor.AutoSize = True
        Me.RBCambioMedidor.BackColor = System.Drawing.Color.Transparent
        Me.RBCambioMedidor.Location = New System.Drawing.Point(277, 26)
        Me.RBCambioMedidor.Name = "RBCambioMedidor"
        Me.RBCambioMedidor.Size = New System.Drawing.Size(101, 17)
        Me.RBCambioMedidor.TabIndex = 19
        Me.RBCambioMedidor.Text = "Cambio Medidor"
        Me.RBCambioMedidor.UseVisualStyleBackColor = False
        '
        'RBCambioTarifa
        '
        Me.RBCambioTarifa.AutoSize = True
        Me.RBCambioTarifa.BackColor = System.Drawing.Color.Transparent
        Me.RBCambioTarifa.Location = New System.Drawing.Point(277, 3)
        Me.RBCambioTarifa.Name = "RBCambioTarifa"
        Me.RBCambioTarifa.Size = New System.Drawing.Size(90, 17)
        Me.RBCambioTarifa.TabIndex = 18
        Me.RBCambioTarifa.Text = "Cambio Tarifa"
        Me.RBCambioTarifa.UseVisualStyleBackColor = False
        '
        'RBNotificacion
        '
        Me.RBNotificacion.AutoSize = True
        Me.RBNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.RBNotificacion.Location = New System.Drawing.Point(18, 99)
        Me.RBNotificacion.Name = "RBNotificacion"
        Me.RBNotificacion.Size = New System.Drawing.Size(84, 17)
        Me.RBNotificacion.TabIndex = 17
        Me.RBNotificacion.Text = "Notificacion "
        Me.RBNotificacion.UseVisualStyleBackColor = False
        '
        'RBContratoAlcantarillado
        '
        Me.RBContratoAlcantarillado.AutoSize = True
        Me.RBContratoAlcantarillado.BackColor = System.Drawing.Color.Transparent
        Me.RBContratoAlcantarillado.Location = New System.Drawing.Point(18, 26)
        Me.RBContratoAlcantarillado.Name = "RBContratoAlcantarillado"
        Me.RBContratoAlcantarillado.Size = New System.Drawing.Size(131, 17)
        Me.RBContratoAlcantarillado.TabIndex = 14
        Me.RBContratoAlcantarillado.Text = "Contrato Alcantarillado"
        Me.RBContratoAlcantarillado.UseVisualStyleBackColor = False
        '
        'RBConstanciaNoAdeudo
        '
        Me.RBConstanciaNoAdeudo.AutoSize = True
        Me.RBConstanciaNoAdeudo.BackColor = System.Drawing.Color.Transparent
        Me.RBConstanciaNoAdeudo.Location = New System.Drawing.Point(18, 75)
        Me.RBConstanciaNoAdeudo.Name = "RBConstanciaNoAdeudo"
        Me.RBConstanciaNoAdeudo.Size = New System.Drawing.Size(149, 17)
        Me.RBConstanciaNoAdeudo.TabIndex = 11
        Me.RBConstanciaNoAdeudo.Text = "Constancia de No adeudo"
        Me.RBConstanciaNoAdeudo.UseVisualStyleBackColor = False
        '
        'RBCambioNombre
        '
        Me.RBCambioNombre.AutoSize = True
        Me.RBCambioNombre.BackColor = System.Drawing.Color.Transparent
        Me.RBCambioNombre.Location = New System.Drawing.Point(18, 52)
        Me.RBCambioNombre.Name = "RBCambioNombre"
        Me.RBCambioNombre.Size = New System.Drawing.Size(113, 17)
        Me.RBCambioNombre.TabIndex = 10
        Me.RBCambioNombre.Text = "Cambio de nombre"
        Me.RBCambioNombre.UseVisualStyleBackColor = False
        '
        'RBContratoAgua
        '
        Me.RBContratoAgua.AutoSize = True
        Me.RBContratoAgua.BackColor = System.Drawing.Color.Transparent
        Me.RBContratoAgua.Checked = True
        Me.RBContratoAgua.Location = New System.Drawing.Point(18, 3)
        Me.RBContratoAgua.Name = "RBContratoAgua"
        Me.RBContratoAgua.Size = New System.Drawing.Size(93, 17)
        Me.RBContratoAgua.TabIndex = 9
        Me.RBContratoAgua.TabStop = True
        Me.RBContratoAgua.Text = "Contrato Agua"
        Me.RBContratoAgua.UseVisualStyleBackColor = False
        '
        'FrmTipoImprContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 388)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
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

    End Sub
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RBCambioTarifa As RadioButton
    Public WithEvents RBNotificacion As RadioButton
    Friend WithEvents RBContratoAlcantarillado As RadioButton
    Friend WithEvents RBConstanciaNoAdeudo As RadioButton
    Friend WithEvents RBContratoAgua As RadioButton
    Friend WithEvents RBCambioMedidor As RadioButton
    Friend WithEvents RBCambioNombre As RadioButton
    Friend WithEvents RBBajaDefinitiva As RadioButton
    Friend WithEvents RBBajaTemporal As RadioButton
End Class
