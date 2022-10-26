<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioTarifa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambioTarifa))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LblTarifa = New System.Windows.Forms.Label
        Me.LblGiro = New System.Windows.Forms.Label
        Me.LblEstadoActual = New System.Windows.Forms.Label
        Me.LblDireccion = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblComunidad = New System.Windows.Forms.Label
        Me.LblCuenta = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbtipouso = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbtarifa = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label39 = New System.Windows.Forms.Label
        Me.LblTipo = New System.Windows.Forms.Label
        Me.LblTarifaAntes = New System.Windows.Forms.Label
        Me.cmdGenCob = New DevComponents.DotNetBar.ButtonX
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
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
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
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.ButtonX1.Location = New System.Drawing.Point(215, 361)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.PulseSpeed = 30
        Me.ButtonX1.Size = New System.Drawing.Size(109, 39)
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "Impresión"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.BtnCancelar.Location = New System.Drawing.Point(445, 361)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 39)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(330, 361)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 30
        Me.BtnAceptar.Size = New System.Drawing.Size(109, 39)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Motivo del cambio:"
        '
        'TxtMotivo
        '
        '
        '
        '
        Me.TxtMotivo.Border.Class = "TextBoxBorder"
        Me.TxtMotivo.FocusHighlightEnabled = True
        Me.TxtMotivo.Location = New System.Drawing.Point(14, 287)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(553, 56)
        Me.TxtMotivo.TabIndex = 2
        Me.TxtMotivo.WatermarkText = "Escribe el motivo del cambio de Tarifa"
        '
        'cmbtipouso
        '
        Me.cmbtipouso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipouso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipouso.DisplayMember = "Text"
        Me.cmbtipouso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipouso.DropDownWidth = 120
        Me.cmbtipouso.FocusHighlightEnabled = True
        Me.cmbtipouso.FormattingEnabled = True
        Me.cmbtipouso.ItemHeight = 14
        Me.cmbtipouso.Location = New System.Drawing.Point(83, 216)
        Me.cmbtipouso.Name = "cmbtipouso"
        Me.cmbtipouso.Size = New System.Drawing.Size(196, 20)
        Me.cmbtipouso.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(9, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "Tipo usuario:"
        '
        'cmbtarifa
        '
        Me.cmbtarifa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtarifa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtarifa.DisplayMember = "Text"
        Me.cmbtarifa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtarifa.DropDownWidth = 180
        Me.cmbtarifa.FocusHighlightEnabled = True
        Me.cmbtarifa.FormattingEnabled = True
        Me.cmbtarifa.ItemHeight = 14
        Me.cmbtarifa.Location = New System.Drawing.Point(330, 216)
        Me.cmbtarifa.Name = "cmbtarifa"
        Me.cmbtarifa.Size = New System.Drawing.Size(235, 20)
        Me.cmbtarifa.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(290, 195)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(37, 13)
        Me.Label39.TabIndex = 134
        Me.Label39.Text = "Tarifa:"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.BackColor = System.Drawing.Color.Transparent
        Me.LblTipo.ForeColor = System.Drawing.Color.Black
        Me.LblTipo.Location = New System.Drawing.Point(83, 195)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(68, 13)
        Me.LblTipo.TabIndex = 137
        Me.LblTipo.Text = "Tipo usuario:"
        '
        'LblTarifaAntes
        '
        Me.LblTarifaAntes.AutoSize = True
        Me.LblTarifaAntes.BackColor = System.Drawing.Color.Transparent
        Me.LblTarifaAntes.ForeColor = System.Drawing.Color.Black
        Me.LblTarifaAntes.Location = New System.Drawing.Point(333, 195)
        Me.LblTarifaAntes.Name = "LblTarifaAntes"
        Me.LblTarifaAntes.Size = New System.Drawing.Size(68, 13)
        Me.LblTarifaAntes.TabIndex = 138
        Me.LblTarifaAntes.Text = "Tipo usuario:"
        '
        'cmdGenCob
        '
        Me.cmdGenCob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdGenCob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdGenCob.Enabled = False
        Me.cmdGenCob.Image = Global.Administativo.My.Resources.Resources.otroscobros
        Me.cmdGenCob.Location = New System.Drawing.Point(100, 361)
        Me.cmdGenCob.Name = "cmdGenCob"
        Me.cmdGenCob.PulseSpeed = 30
        Me.cmdGenCob.Size = New System.Drawing.Size(109, 39)
        Me.cmdGenCob.TabIndex = 6
        Me.cmdGenCob.Text = "Generar Cobro"
        '
        'FrmCambioTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 416)
        Me.Controls.Add(Me.cmdGenCob)
        Me.Controls.Add(Me.LblTarifaAntes)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.cmbtipouso)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbtarifa)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCambioTarifa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIO DE TARIFA"
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
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMotivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbtipouso As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbtarifa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents LblTarifaAntes As System.Windows.Forms.Label
    Friend WithEvents cmdGenCob As DevComponents.DotNetBar.ButtonX
End Class
