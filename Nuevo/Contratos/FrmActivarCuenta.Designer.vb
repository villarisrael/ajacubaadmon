<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActivarCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActivarCuenta))
        Me.MCFecha = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
        Me.Lbltitulo = New System.Windows.Forms.Label
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
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
        Me.lblMen = New System.Windows.Forms.Label
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MCFecha
        '
        Me.MCFecha.AnnuallyMarkedDates = New Date(-1) {}
        Me.MCFecha.AutoSize = True
        '
        '
        '
        Me.MCFecha.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MCFecha.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MCFecha.BackgroundStyle.BorderBottomWidth = 1
        Me.MCFecha.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MCFecha.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MCFecha.BackgroundStyle.BorderLeftWidth = 1
        Me.MCFecha.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MCFecha.BackgroundStyle.BorderRightWidth = 1
        Me.MCFecha.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MCFecha.BackgroundStyle.BorderTopWidth = 1
        Me.MCFecha.DisplayMonth = New Date(2008, 9, 1, 0, 0, 0, 0)
        Me.MCFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCFecha.Location = New System.Drawing.Point(250, 175)
        Me.MCFecha.MarkedDates = New Date(-1) {}
        Me.MCFecha.MonthlyMarkedDates = New Date(-1) {}
        Me.MCFecha.Name = "MCFecha"
        '
        '
        '
        Me.MCFecha.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.MCFecha.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.MCFecha.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.MCFecha.Size = New System.Drawing.Size(170, 128)
        Me.MCFecha.TabIndex = 1
        Me.MCFecha.Text = "MonthCalendarAdv1"
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Location = New System.Drawing.Point(65, 175)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(168, 13)
        Me.Lbltitulo.TabIndex = 1
        Me.Lbltitulo.Text = "Selecciona la fecha de activación"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(387, 392)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 30
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 46)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(503, 392)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 46)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Terminar"
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
        Me.GroupPanel1.Location = New System.Drawing.Point(38, 12)
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
        Me.GroupPanel1.TabIndex = 0
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
        Me.LblDireccion.Text = "Dirección"
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
        Me.Label2.Location = New System.Drawing.Point(68, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Observaciones:"
        '
        'TxtMotivo
        '
        '
        '
        '
        Me.TxtMotivo.Border.Class = "TextBoxBorder"
        Me.TxtMotivo.FocusHighlightEnabled = True
        Me.TxtMotivo.Location = New System.Drawing.Point(71, 324)
        Me.TxtMotivo.MaxLength = 200
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(503, 53)
        Me.TxtMotivo.TabIndex = 2
        Me.TxtMotivo.WatermarkText = "Escribe el motivo del cambio de estado"
        '
        'lblMen
        '
        Me.lblMen.AutoSize = True
        Me.lblMen.Location = New System.Drawing.Point(68, 425)
        Me.lblMen.Name = "lblMen"
        Me.lblMen.Size = New System.Drawing.Size(0, 13)
        Me.lblMen.TabIndex = 13
        '
        'FrmActivarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 468)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.lblMen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.MCFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActivarCuenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activar Cuenta"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MCFecha As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
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
    Friend WithEvents lblMen As System.Windows.Forms.Label
End Class
