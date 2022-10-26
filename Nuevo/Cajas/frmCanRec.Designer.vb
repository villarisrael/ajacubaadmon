<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCanRec
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
        Me.txtSerie = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtRec = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdCan = New DevComponents.DotNetBar.ButtonX
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.lblMonto = New DevComponents.DotNetBar.LabelX
        Me.lblNombre = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LblOficina = New DevComponents.DotNetBar.LabelX
        Me.LblCaja = New DevComponents.DotNetBar.LabelX
        Me.LblTitNombre = New DevComponents.DotNetBar.LabelX
        Me.LblTitTotal = New DevComponents.DotNetBar.LabelX
        Me.LblTitIva = New DevComponents.DotNetBar.LabelX
        Me.LblIva = New DevComponents.DotNetBar.LabelX
        Me.LblTitSubtotal = New DevComponents.DotNetBar.LabelX
        Me.LblSubtotal = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Linea = New DevComponents.DotNetBar.LabelX
        Me.LblEstado = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LblReferencia = New DevComponents.DotNetBar.LabelX
        Me.LblTitRef = New DevComponents.DotNetBar.LabelX
        Me.LblFpago = New DevComponents.DotNetBar.LabelX
        Me.LblTitFpago = New DevComponents.DotNetBar.LabelX
        Me.LblTarifa = New DevComponents.DotNetBar.LabelX
        Me.LblTitTarifa = New DevComponents.DotNetBar.LabelX
        Me.TxtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSerie.Border.Class = "TextBoxBorder"
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(58, 50)
        Me.txtSerie.MaxLength = 1
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(51, 20)
        Me.txtSerie.TabIndex = 5
        '
        'txtRec
        '
        '
        '
        '
        Me.txtRec.Border.Class = "TextBoxBorder"
        Me.txtRec.FocusHighlightEnabled = True
        Me.txtRec.Location = New System.Drawing.Point(173, 50)
        Me.txtRec.Name = "txtRec"
        Me.txtRec.Size = New System.Drawing.Size(106, 20)
        Me.txtRec.TabIndex = 7
        Me.txtRec.WatermarkText = "Folio del  recibo"
        '
        'cmdCan
        '
        Me.cmdCan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCan.Image = Global.AcquaLiberVista.My.Resources.Resources.CancelarEdicion
        Me.cmdCan.Location = New System.Drawing.Point(315, 346)
        Me.cmdCan.Name = "cmdCan"
        Me.cmdCan.Size = New System.Drawing.Size(93, 38)
        Me.cmdCan.TabIndex = 16
        Me.cmdCan.Text = "Salir"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Enabled = False
        Me.cmdAcept.Image = Global.AcquaLiberVista.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(216, 346)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(93, 38)
        Me.cmdAcept.TabIndex = 15
        Me.cmdAcept.Text = "Aceptar"
        '
        'LabelX5
        '
        Me.LabelX5.Location = New System.Drawing.Point(9, 50)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(43, 18)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "SERIE:"
        '
        'lblMonto
        '
        Me.lblMonto.BackColor = System.Drawing.Color.Transparent
        Me.lblMonto.Location = New System.Drawing.Point(93, 90)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(123, 18)
        Me.lblMonto.TabIndex = 13
        Me.lblMonto.Text = "$0.00"
        Me.lblMonto.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(61, 91)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(575, 18)
        Me.lblNombre.TabIndex = 10
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(115, 50)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(62, 18)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "RECIBO:"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(326, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(62, 24)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "CAJA:"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(62, 24)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "OFICINA:"
        '
        'LblOficina
        '
        Me.LblOficina.Location = New System.Drawing.Point(69, 12)
        Me.LblOficina.Name = "LblOficina"
        Me.LblOficina.Size = New System.Drawing.Size(251, 24)
        Me.LblOficina.TabIndex = 1
        Me.LblOficina.Text = "OFICINA:"
        '
        'LblCaja
        '
        Me.LblCaja.Location = New System.Drawing.Point(363, 12)
        Me.LblCaja.Name = "LblCaja"
        Me.LblCaja.Size = New System.Drawing.Size(273, 24)
        Me.LblCaja.TabIndex = 3
        Me.LblCaja.Text = "OFICINA:"
        '
        'LblTitNombre
        '
        Me.LblTitNombre.Location = New System.Drawing.Point(12, 91)
        Me.LblTitNombre.Name = "LblTitNombre"
        Me.LblTitNombre.Size = New System.Drawing.Size(43, 24)
        Me.LblTitNombre.TabIndex = 9
        Me.LblTitNombre.Text = "Nombre:"
        '
        'LblTitTotal
        '
        Me.LblTitTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTitTotal.Location = New System.Drawing.Point(19, 87)
        Me.LblTitTotal.Name = "LblTitTotal"
        Me.LblTitTotal.Size = New System.Drawing.Size(43, 24)
        Me.LblTitTotal.TabIndex = 22
        Me.LblTitTotal.Text = "Total:"
        '
        'LblTitIva
        '
        Me.LblTitIva.BackColor = System.Drawing.Color.Transparent
        Me.LblTitIva.Location = New System.Drawing.Point(19, 44)
        Me.LblTitIva.Name = "LblTitIva"
        Me.LblTitIva.Size = New System.Drawing.Size(43, 24)
        Me.LblTitIva.TabIndex = 24
        Me.LblTitIva.Text = "IVA:"
        '
        'LblIva
        '
        Me.LblIva.BackColor = System.Drawing.Color.Transparent
        Me.LblIva.Location = New System.Drawing.Point(93, 47)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(123, 18)
        Me.LblIva.TabIndex = 23
        Me.LblIva.Text = "$0.00"
        Me.LblIva.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblTitSubtotal
        '
        Me.LblTitSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTitSubtotal.Location = New System.Drawing.Point(19, 9)
        Me.LblTitSubtotal.Name = "LblTitSubtotal"
        Me.LblTitSubtotal.Size = New System.Drawing.Size(62, 24)
        Me.LblTitSubtotal.TabIndex = 26
        Me.LblTitSubtotal.Text = "SubTotal:"
        '
        'LblSubtotal
        '
        Me.LblSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.LblSubtotal.Location = New System.Drawing.Point(93, 12)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(123, 18)
        Me.LblSubtotal.TabIndex = 25
        Me.LblSubtotal.Text = "$0.00"
        Me.LblSubtotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Linea)
        Me.GroupPanel1.Controls.Add(Me.LblTitSubtotal)
        Me.GroupPanel1.Controls.Add(Me.lblMonto)
        Me.GroupPanel1.Controls.Add(Me.LblSubtotal)
        Me.GroupPanel1.Controls.Add(Me.LblTitTotal)
        Me.GroupPanel1.Controls.Add(Me.LblTitIva)
        Me.GroupPanel1.Controls.Add(Me.LblIva)
        Me.GroupPanel1.Location = New System.Drawing.Point(361, 131)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(275, 140)
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
        Me.GroupPanel1.TabIndex = 12
        Me.GroupPanel1.Text = "Totales"
        '
        'Linea
        '
        '
        '
        '
        Me.Linea.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Linea.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.Linea.BackgroundStyle.BorderBottomWidth = 1
        Me.Linea.Location = New System.Drawing.Point(3, 74)
        Me.Linea.Name = "Linea"
        Me.Linea.Size = New System.Drawing.Size(223, 10)
        Me.Linea.TabIndex = 27
        '
        'LblEstado
        '
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(326, 50)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(137, 18)
        Me.LblEstado.TabIndex = 8
        Me.LblEstado.Text = "Estado"
        Me.LblEstado.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.LblReferencia)
        Me.GroupPanel2.Controls.Add(Me.LblTitRef)
        Me.GroupPanel2.Controls.Add(Me.LblFpago)
        Me.GroupPanel2.Controls.Add(Me.LblTitFpago)
        Me.GroupPanel2.Controls.Add(Me.LblTarifa)
        Me.GroupPanel2.Controls.Add(Me.LblTitTarifa)
        Me.GroupPanel2.Location = New System.Drawing.Point(9, 131)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(346, 140)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 11
        Me.GroupPanel2.Text = "Datos del Usuario"
        '
        'LblReferencia
        '
        Me.LblReferencia.BackColor = System.Drawing.Color.Transparent
        Me.LblReferencia.Location = New System.Drawing.Point(69, 73)
        Me.LblReferencia.Name = "LblReferencia"
        Me.LblReferencia.Size = New System.Drawing.Size(261, 23)
        Me.LblReferencia.TabIndex = 5
        '
        'LblTitRef
        '
        Me.LblTitRef.BackColor = System.Drawing.Color.Transparent
        Me.LblTitRef.Location = New System.Drawing.Point(3, 73)
        Me.LblTitRef.Name = "LblTitRef"
        Me.LblTitRef.Size = New System.Drawing.Size(60, 23)
        Me.LblTitRef.TabIndex = 4
        Me.LblTitRef.Text = "Referencia:"
        '
        'LblFpago
        '
        Me.LblFpago.BackColor = System.Drawing.Color.Transparent
        Me.LblFpago.Location = New System.Drawing.Point(69, 44)
        Me.LblFpago.Name = "LblFpago"
        Me.LblFpago.Size = New System.Drawing.Size(261, 23)
        Me.LblFpago.TabIndex = 3
        '
        'LblTitFpago
        '
        Me.LblTitFpago.BackColor = System.Drawing.Color.Transparent
        Me.LblTitFpago.Location = New System.Drawing.Point(3, 44)
        Me.LblTitFpago.Name = "LblTitFpago"
        Me.LblTitFpago.Size = New System.Drawing.Size(60, 23)
        Me.LblTitFpago.TabIndex = 2
        Me.LblTitFpago.Text = "F. Pago:"
        '
        'LblTarifa
        '
        Me.LblTarifa.BackColor = System.Drawing.Color.Transparent
        Me.LblTarifa.Location = New System.Drawing.Point(69, 9)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(261, 23)
        Me.LblTarifa.TabIndex = 1
        '
        'LblTitTarifa
        '
        Me.LblTitTarifa.BackColor = System.Drawing.Color.Transparent
        Me.LblTitTarifa.Location = New System.Drawing.Point(3, 9)
        Me.LblTitTarifa.Name = "LblTitTarifa"
        Me.LblTitTarifa.Size = New System.Drawing.Size(60, 23)
        Me.LblTitTarifa.TabIndex = 0
        Me.LblTitTarifa.Text = "Tarifa:"
        '
        'TxtMotivo
        '
        '
        '
        '
        Me.TxtMotivo.Border.Class = "TextBoxBorder"
        Me.TxtMotivo.FocusHighlightEnabled = True
        Me.TxtMotivo.Location = New System.Drawing.Point(9, 308)
        Me.TxtMotivo.MaxLength = 30
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(628, 20)
        Me.TxtMotivo.TabIndex = 14
        Me.TxtMotivo.WatermarkText = "Introduce el motivo por el cual se cancelo el recibo"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(9, 279)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "Motivo:"
        '
        'frmCanRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 395)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LblTitNombre)
        Me.Controls.Add(Me.LblCaja)
        Me.Controls.Add(Me.LblOficina)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.txtRec)
        Me.Controls.Add(Me.cmdCan)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCanRec"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelar Recibo"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSerie As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRec As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdCan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMonto As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblOficina As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblCaja As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitNombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblIva As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitIva As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitSubtotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblSubtotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Linea As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblReferencia As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitRef As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblFpago As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitFpago As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTarifa As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitTarifa As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtMotivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
