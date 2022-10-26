<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCierraCaja
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
        Me.components = New System.ComponentModel.Container
        Me.lblTit = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.LblTitCaja = New DevComponents.DotNetBar.LabelX
        Me.LblTitOficina = New DevComponents.DotNetBar.LabelX
        Me.LblOficina = New DevComponents.DotNetBar.LabelX
        Me.LblCaja = New DevComponents.DotNetBar.LabelX
        Me.LblFecha = New DevComponents.DotNetBar.LabelX
        Me.LblTitFecha = New DevComponents.DotNetBar.LabelX
        Me.LblHora = New DevComponents.DotNetBar.LabelX
        Me.LblTitHora = New DevComponents.DotNetBar.LabelX
        Me.GbSaldos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LblOperaciones = New DevComponents.DotNetBar.LabelX
        Me.LblIngresos = New DevComponents.DotNetBar.LabelX
        Me.LblTitOperaciones = New DevComponents.DotNetBar.LabelX
        Me.LblTitIngresos = New DevComponents.DotNetBar.LabelX
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX
        Me.cmdAceptar = New DevComponents.DotNetBar.ButtonX
        Me.Hora = New System.Windows.Forms.Timer(Me.components)
        Me.GbSaldos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTit
        '
        Me.lblTit.Location = New System.Drawing.Point(280, 12)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(110, 34)
        Me.lblTit.TabIndex = 1
        Me.lblTit.Text = "<b><font size=""+6""><i>Cerrar Caja</i></font></b>"
        '
        'LblTitCaja
        '
        Me.LblTitCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitCaja.Location = New System.Drawing.Point(323, 61)
        Me.LblTitCaja.Name = "LblTitCaja"
        Me.LblTitCaja.Size = New System.Drawing.Size(41, 23)
        Me.LblTitCaja.TabIndex = 2
        Me.LblTitCaja.Text = "Caja:"
        '
        'LblTitOficina
        '
        Me.LblTitOficina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitOficina.Location = New System.Drawing.Point(12, 61)
        Me.LblTitOficina.Name = "LblTitOficina"
        Me.LblTitOficina.Size = New System.Drawing.Size(62, 23)
        Me.LblTitOficina.TabIndex = 3
        Me.LblTitOficina.Text = "Oficina:"
        '
        'LblOficina
        '
        Me.LblOficina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOficina.Location = New System.Drawing.Point(69, 61)
        Me.LblOficina.Name = "LblOficina"
        Me.LblOficina.Size = New System.Drawing.Size(248, 23)
        Me.LblOficina.TabIndex = 4
        Me.LblOficina.Text = "LabelX2"
        Me.LblOficina.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LblCaja
        '
        Me.LblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaja.Location = New System.Drawing.Point(358, 61)
        Me.LblCaja.Name = "LblCaja"
        Me.LblCaja.Size = New System.Drawing.Size(301, 23)
        Me.LblCaja.TabIndex = 5
        Me.LblCaja.Text = "LabelX2"
        Me.LblCaja.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LblFecha
        '
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(238, 90)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(116, 23)
        Me.LblFecha.TabIndex = 7
        Me.LblFecha.Text = "LabelX2"
        '
        'LblTitFecha
        '
        Me.LblTitFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitFecha.Location = New System.Drawing.Point(182, 90)
        Me.LblTitFecha.Name = "LblTitFecha"
        Me.LblTitFecha.Size = New System.Drawing.Size(63, 23)
        Me.LblTitFecha.TabIndex = 6
        Me.LblTitFecha.Text = "Fecha:"
        '
        'LblHora
        '
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(414, 90)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(115, 23)
        Me.LblHora.TabIndex = 9
        Me.LblHora.Text = "LabelX2"
        '
        'LblTitHora
        '
        Me.LblTitHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitHora.Location = New System.Drawing.Point(367, 90)
        Me.LblTitHora.Name = "LblTitHora"
        Me.LblTitHora.Size = New System.Drawing.Size(41, 23)
        Me.LblTitHora.TabIndex = 8
        Me.LblTitHora.Text = "Hora:"
        '
        'GbSaldos
        '
        Me.GbSaldos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GbSaldos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GbSaldos.Controls.Add(Me.LblOperaciones)
        Me.GbSaldos.Controls.Add(Me.LblIngresos)
        Me.GbSaldos.Controls.Add(Me.LblTitOperaciones)
        Me.GbSaldos.Controls.Add(Me.LblTitIngresos)
        Me.GbSaldos.Location = New System.Drawing.Point(121, 111)
        Me.GbSaldos.Name = "GbSaldos"
        Me.GbSaldos.Size = New System.Drawing.Size(429, 93)
        '
        '
        '
        Me.GbSaldos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GbSaldos.Style.BackColorGradientAngle = 90
        Me.GbSaldos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GbSaldos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GbSaldos.Style.BorderBottomWidth = 1
        Me.GbSaldos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GbSaldos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GbSaldos.Style.BorderLeftWidth = 1
        Me.GbSaldos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GbSaldos.Style.BorderRightWidth = 1
        Me.GbSaldos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GbSaldos.Style.BorderTopWidth = 1
        Me.GbSaldos.Style.CornerDiameter = 4
        Me.GbSaldos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GbSaldos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GbSaldos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GbSaldos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GbSaldos.TabIndex = 10
        Me.GbSaldos.Text = "Saldo al Cierre"
        '
        'LblOperaciones
        '
        Me.LblOperaciones.BackColor = System.Drawing.Color.Transparent
        Me.LblOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOperaciones.Location = New System.Drawing.Point(250, 32)
        Me.LblOperaciones.Name = "LblOperaciones"
        Me.LblOperaciones.Size = New System.Drawing.Size(75, 23)
        Me.LblOperaciones.TabIndex = 3
        Me.LblOperaciones.Text = "Operaciones"
        '
        'LblIngresos
        '
        Me.LblIngresos.BackColor = System.Drawing.Color.Transparent
        Me.LblIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresos.Location = New System.Drawing.Point(56, 32)
        Me.LblIngresos.Name = "LblIngresos"
        Me.LblIngresos.Size = New System.Drawing.Size(157, 23)
        Me.LblIngresos.TabIndex = 2
        Me.LblIngresos.Text = "Ingresos"
        '
        'LblTitOperaciones
        '
        Me.LblTitOperaciones.BackColor = System.Drawing.Color.Transparent
        Me.LblTitOperaciones.Location = New System.Drawing.Point(250, 3)
        Me.LblTitOperaciones.Name = "LblTitOperaciones"
        Me.LblTitOperaciones.Size = New System.Drawing.Size(75, 23)
        Me.LblTitOperaciones.TabIndex = 1
        Me.LblTitOperaciones.Text = "Operaciones"
        '
        'LblTitIngresos
        '
        Me.LblTitIngresos.BackColor = System.Drawing.Color.Transparent
        Me.LblTitIngresos.Location = New System.Drawing.Point(56, 3)
        Me.LblTitIngresos.Name = "LblTitIngresos"
        Me.LblTitIngresos.Size = New System.Drawing.Size(75, 23)
        Me.LblTitIngresos.TabIndex = 0
        Me.LblTitIngresos.Text = "Ingresos"
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.AcquaLiberVista.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(351, 220)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.Size = New System.Drawing.Size(139, 38)
        Me.cmdCance.TabIndex = 18
        Me.cmdCance.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAceptar.Image = Global.AcquaLiberVista.My.Resources.Resources.apply
        Me.cmdAceptar.Location = New System.Drawing.Point(180, 220)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(139, 38)
        Me.cmdAceptar.TabIndex = 17
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Hora
        '
        Me.Hora.Enabled = True
        '
        'FrmCierraCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GbSaldos)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.LblTitHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblTitFecha)
        Me.Controls.Add(Me.LblCaja)
        Me.Controls.Add(Me.LblOficina)
        Me.Controls.Add(Me.LblTitOficina)
        Me.Controls.Add(Me.LblTitCaja)
        Me.Controls.Add(Me.lblTit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCierraCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierra Caja"
        Me.GbSaldos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTit As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LblTitCaja As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitOficina As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblOficina As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblCaja As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblHora As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitHora As DevComponents.DotNetBar.LabelX
    Friend WithEvents GbSaldos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblOperaciones As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblIngresos As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitOperaciones As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitIngresos As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Hora As System.Windows.Forms.Timer
End Class
