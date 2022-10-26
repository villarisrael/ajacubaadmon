<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenesTrabajo
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LblTarifa = New System.Windows.Forms.Label
        Me.LblGiro = New System.Windows.Forms.Label
        Me.LblEstadoActual = New System.Windows.Forms.Label
        Me.LblDireccion = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblComunidad = New System.Windows.Forms.Label
        Me.LblCuenta = New System.Windows.Forms.Label
        Me.BtnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.CmbResponsable = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LblResponsable = New System.Windows.Forms.Label
        Me.TxtTarea = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblTarea = New System.Windows.Forms.Label
        Me.LblObservacion = New System.Windows.Forms.Label
        Me.TxtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupPanel1.Location = New System.Drawing.Point(24, 14)
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
        Me.GroupPanel1.TabIndex = 1
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
        'BtnImprimir
        '
        Me.BtnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnImprimir.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.BtnImprimir.Location = New System.Drawing.Point(231, 427)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(109, 39)
        Me.BtnImprimir.TabIndex = 8
        Me.BtnImprimir.Text = "Impresión"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(462, 427)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 39)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Salir"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(346, 427)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 39)
        Me.BtnAceptar.TabIndex = 9
        Me.BtnAceptar.Text = "Guardar"
        '
        'CmbResponsable
        '
        Me.CmbResponsable.DisplayMember = "Text"
        Me.CmbResponsable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbResponsable.FormattingEnabled = True
        Me.CmbResponsable.ItemHeight = 14
        Me.CmbResponsable.Location = New System.Drawing.Point(118, 192)
        Me.CmbResponsable.Name = "CmbResponsable"
        Me.CmbResponsable.Size = New System.Drawing.Size(453, 20)
        Me.CmbResponsable.TabIndex = 11
        '
        'LblResponsable
        '
        Me.LblResponsable.AutoSize = True
        Me.LblResponsable.Location = New System.Drawing.Point(21, 192)
        Me.LblResponsable.Name = "LblResponsable"
        Me.LblResponsable.Size = New System.Drawing.Size(69, 13)
        Me.LblResponsable.TabIndex = 12
        Me.LblResponsable.Text = "Responsable"
        '
        'TxtTarea
        '
        '
        '
        '
        Me.TxtTarea.Border.Class = "TextBoxBorder"
        Me.TxtTarea.Location = New System.Drawing.Point(24, 243)
        Me.TxtTarea.Multiline = True
        Me.TxtTarea.Name = "TxtTarea"
        Me.TxtTarea.Size = New System.Drawing.Size(547, 65)
        Me.TxtTarea.TabIndex = 13
        '
        'LblTarea
        '
        Me.LblTarea.AutoSize = True
        Me.LblTarea.Location = New System.Drawing.Point(23, 227)
        Me.LblTarea.Name = "LblTarea"
        Me.LblTarea.Size = New System.Drawing.Size(35, 13)
        Me.LblTarea.TabIndex = 14
        Me.LblTarea.Text = "Tarea"
        '
        'LblObservacion
        '
        Me.LblObservacion.AutoSize = True
        Me.LblObservacion.Location = New System.Drawing.Point(23, 311)
        Me.LblObservacion.Name = "LblObservacion"
        Me.LblObservacion.Size = New System.Drawing.Size(67, 13)
        Me.LblObservacion.TabIndex = 16
        Me.LblObservacion.Text = "Observacion"
        '
        'TxtObservacion
        '
        '
        '
        '
        Me.TxtObservacion.Border.Class = "TextBoxBorder"
        Me.TxtObservacion.Location = New System.Drawing.Point(24, 327)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(547, 94)
        Me.TxtObservacion.TabIndex = 15
        '
        'FrmOrdenesTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 477)
        Me.Controls.Add(Me.LblObservacion)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.LblTarea)
        Me.Controls.Add(Me.TxtTarea)
        Me.Controls.Add(Me.LblResponsable)
        Me.Controls.Add(Me.CmbResponsable)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "FrmOrdenesTrabajo"
        Me.Text = "Ordenes de Trabajo"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblTarifa As System.Windows.Forms.Label
    Friend WithEvents LblGiro As System.Windows.Forms.Label
    Friend WithEvents LblEstadoActual As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblComunidad As System.Windows.Forms.Label
    Friend WithEvents LblCuenta As System.Windows.Forms.Label
    Friend WithEvents BtnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CmbResponsable As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LblResponsable As System.Windows.Forms.Label
    Friend WithEvents TxtTarea As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblTarea As System.Windows.Forms.Label
    Friend WithEvents LblObservacion As System.Windows.Forms.Label
    Friend WithEvents TxtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
End Class
