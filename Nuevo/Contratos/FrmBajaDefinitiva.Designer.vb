<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaDefinitiva
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LblTarifa = New System.Windows.Forms.Label
        Me.LblGiro = New System.Windows.Forms.Label
        Me.LblEstadoActual = New System.Windows.Forms.Label
        Me.LblDireccion = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblComunidad = New System.Windows.Forms.Label
        Me.LblCuenta = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.ButtonX1.Location = New System.Drawing.Point(242, 296)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.PulseSpeed = 30
        Me.ButtonX1.Size = New System.Drawing.Size(109, 39)
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "Impresión"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LblTarifa)
        Me.GroupPanel1.Controls.Add(Me.LblGiro)
        Me.GroupPanel1.Controls.Add(Me.LblEstadoActual)
        Me.GroupPanel1.Controls.Add(Me.LblDireccion)
        Me.GroupPanel1.Controls.Add(Me.LblNombre)
        Me.GroupPanel1.Controls.Add(Me.LblComunidad)
        Me.GroupPanel1.Controls.Add(Me.LblCuenta)
        Me.GroupPanel1.Location = New System.Drawing.Point(30, 26)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(553, 157)
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
        Me.GroupPanel1.TabIndex = 5
        '
        'LblTarifa
        '
        Me.LblTarifa.AutoSize = True
        Me.LblTarifa.BackColor = System.Drawing.Color.Transparent
        Me.LblTarifa.Location = New System.Drawing.Point(271, 96)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(34, 13)
        Me.LblTarifa.TabIndex = 5
        Me.LblTarifa.Text = "Tarifa"
        '
        'LblGiro
        '
        Me.LblGiro.AutoSize = True
        Me.LblGiro.BackColor = System.Drawing.Color.Transparent
        Me.LblGiro.Location = New System.Drawing.Point(24, 96)
        Me.LblGiro.Name = "LblGiro"
        Me.LblGiro.Size = New System.Drawing.Size(26, 13)
        Me.LblGiro.TabIndex = 4
        Me.LblGiro.Text = "Giro"
        '
        'LblEstadoActual
        '
        Me.LblEstadoActual.AutoSize = True
        Me.LblEstadoActual.BackColor = System.Drawing.Color.Transparent
        Me.LblEstadoActual.Location = New System.Drawing.Point(24, 120)
        Me.LblEstadoActual.Name = "LblEstadoActual"
        Me.LblEstadoActual.Size = New System.Drawing.Size(73, 13)
        Me.LblEstadoActual.TabIndex = 6
        Me.LblEstadoActual.Text = "Estado Actual"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LblDireccion.Location = New System.Drawing.Point(24, 73)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 3
        Me.LblDireccion.Text = "Direccion"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Location = New System.Drawing.Point(24, 47)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre"
        '
        'LblComunidad
        '
        Me.LblComunidad.AutoSize = True
        Me.LblComunidad.BackColor = System.Drawing.Color.Transparent
        Me.LblComunidad.Location = New System.Drawing.Point(88, 18)
        Me.LblComunidad.Name = "LblComunidad"
        Me.LblComunidad.Size = New System.Drawing.Size(60, 13)
        Me.LblComunidad.TabIndex = 1
        Me.LblComunidad.Text = "Comunidad"
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblCuenta.Location = New System.Drawing.Point(24, 18)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.LblCuenta.TabIndex = 0
        Me.LblCuenta.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Motivo del cambio:"
        '
        'TxtMotivo
        '
        '
        '
        '
        Me.TxtMotivo.Border.Class = "TextBoxBorder"
        Me.TxtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotivo.FocusHighlightEnabled = True
        Me.TxtMotivo.Location = New System.Drawing.Point(30, 223)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(553, 56)
        Me.TxtMotivo.TabIndex = 0
        Me.TxtMotivo.WatermarkText = "Escribe el motivo del cambio de estado"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.BtnCancelar.Location = New System.Drawing.Point(473, 296)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 39)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(357, 296)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 30
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 39)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "Aceptar"
        '
        'FrmBajaDefinitiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 362)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBajaDefinitiva"
        Me.Text = "Baja Definitiva"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblTarifa As System.Windows.Forms.Label
    Friend WithEvents LblGiro As System.Windows.Forms.Label
    Friend WithEvents LblEstadoActual As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblComunidad As System.Windows.Forms.Label
    Friend WithEvents LblCuenta As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMotivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
End Class
