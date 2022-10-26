<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCanMulta
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
        Me.LblDireccion = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LblTotal = New DevComponents.DotNetBar.LabelX
        Me.LblIva = New DevComponents.DotNetBar.LabelX
        Me.LblTitTotal = New DevComponents.DotNetBar.LabelX
        Me.LblTitIVA = New DevComponents.DotNetBar.LabelX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.btnok = New DevComponents.DotNetBar.ButtonX
        Me.LblTitSubTotal = New DevComponents.DotNetBar.LabelX
        Me.txtdetalle = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LBLNOMBRE = New DevComponents.DotNetBar.LabelX
        Me.LblFecha = New DevComponents.DotNetBar.LabelX
        Me.LblCuenCom = New DevComponents.DotNetBar.LabelX
        Me.LblConcepto = New DevComponents.DotNetBar.LabelX
        Me.LblVencimiento = New DevComponents.DotNetBar.LabelX
        Me.LblSubtotal = New DevComponents.DotNetBar.LabelX
        Me.LblMotivo = New DevComponents.DotNetBar.LabelX
        Me.SuspendLayout()
        '
        'LblDireccion
        '
        Me.LblDireccion.Location = New System.Drawing.Point(12, 105)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(436, 23)
        Me.LblDireccion.TabIndex = 32
        Me.LblDireccion.Text = "Direccion"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground2
        Me.LabelX7.Location = New System.Drawing.Point(9, 337)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX7.Size = New System.Drawing.Size(301, 22)
        Me.LabelX7.TabIndex = 46
        Me.LabelX7.Text = "________________________________________________"
        '
        'LblTotal
        '
        Me.LblTotal.Location = New System.Drawing.Point(114, 364)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(174, 20)
        Me.LblTotal.TabIndex = 48
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblIva
        '
        Me.LblIva.Location = New System.Drawing.Point(114, 319)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(174, 20)
        Me.LblIva.TabIndex = 45
        Me.LblIva.Text = "0.00"
        Me.LblIva.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblTitTotal
        '
        Me.LblTitTotal.Location = New System.Drawing.Point(13, 364)
        Me.LblTitTotal.Name = "LblTitTotal"
        Me.LblTitTotal.Size = New System.Drawing.Size(96, 20)
        Me.LblTitTotal.TabIndex = 47
        Me.LblTitTotal.Text = "Total"
        '
        'LblTitIVA
        '
        Me.LblTitIVA.Location = New System.Drawing.Point(13, 319)
        Me.LblTitIVA.Name = "LblTitIVA"
        Me.LblTitIVA.Size = New System.Drawing.Size(96, 20)
        Me.LblTitIVA.TabIndex = 44
        Me.LblTitIVA.Text = "IVA"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.BtnCancelar.Location = New System.Drawing.Point(290, 400)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(118, 38)
        Me.BtnCancelar.TabIndex = 50
        Me.BtnCancelar.Text = "Salir"
        '
        'LabelX6
        '
        Me.LabelX6.Location = New System.Drawing.Point(12, 197)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(64, 20)
        Me.LabelX6.TabIndex = 37
        Me.LabelX6.Text = "Vencimiento"
        '
        'btnok
        '
        Me.btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnok.Image = Global.Administativo.My.Resources.Resources.apply
        Me.btnok.Location = New System.Drawing.Point(150, 400)
        Me.btnok.Name = "btnok"
        Me.btnok.PulseSpeed = 30
        Me.btnok.Size = New System.Drawing.Size(118, 38)
        Me.btnok.TabIndex = 49
        Me.btnok.Text = "Aceptar"
        '
        'LblTitSubTotal
        '
        Me.LblTitSubTotal.Location = New System.Drawing.Point(13, 284)
        Me.LblTitSubTotal.Name = "LblTitSubTotal"
        Me.LblTitSubTotal.Size = New System.Drawing.Size(96, 20)
        Me.LblTitSubTotal.TabIndex = 42
        Me.LblTitSubTotal.Text = "Subtotal"
        '
        'txtdetalle
        '
        '
        '
        '
        Me.txtdetalle.Border.Class = "TextBoxBorder"
        Me.txtdetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdetalle.FocusHighlightEnabled = True
        Me.txtdetalle.Location = New System.Drawing.Point(8, 258)
        Me.txtdetalle.MaxLength = 400
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(514, 20)
        Me.txtdetalle.TabIndex = 41
        Me.txtdetalle.WatermarkText = "Escribe el motivo de la cancelación"
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(8, 228)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(76, 24)
        Me.LabelX4.TabIndex = 39
        Me.LabelX4.Text = "Motivo"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(12, 14)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(50, 14)
        Me.LabelX3.TabIndex = 26
        Me.LabelX3.Text = "Fecha"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(12, 134)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(64, 20)
        Me.LabelX2.TabIndex = 35
        Me.LabelX2.Text = "Concepto"
        '
        'LBLNOMBRE
        '
        Me.LBLNOMBRE.Location = New System.Drawing.Point(12, 76)
        Me.LBLNOMBRE.Name = "LBLNOMBRE"
        Me.LBLNOMBRE.Size = New System.Drawing.Size(436, 23)
        Me.LBLNOMBRE.TabIndex = 31
        Me.LBLNOMBRE.Text = "lblnombre"
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(58, 9)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(177, 23)
        Me.LblFecha.TabIndex = 51
        Me.LblFecha.Text = "Fecha"
        '
        'LblCuenCom
        '
        Me.LblCuenCom.Location = New System.Drawing.Point(12, 47)
        Me.LblCuenCom.Name = "LblCuenCom"
        Me.LblCuenCom.Size = New System.Drawing.Size(396, 23)
        Me.LblCuenCom.TabIndex = 52
        Me.LblCuenCom.Text = "CuenCom"
        '
        'LblConcepto
        '
        Me.LblConcepto.Location = New System.Drawing.Point(82, 134)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(454, 23)
        Me.LblConcepto.TabIndex = 53
        Me.LblConcepto.Text = "Concepto"
        '
        'LblVencimiento
        '
        Me.LblVencimiento.Location = New System.Drawing.Point(82, 197)
        Me.LblVencimiento.Name = "LblVencimiento"
        Me.LblVencimiento.Size = New System.Drawing.Size(177, 23)
        Me.LblVencimiento.TabIndex = 54
        Me.LblVencimiento.Text = "Fecha"
        '
        'LblSubtotal
        '
        Me.LblSubtotal.Location = New System.Drawing.Point(115, 284)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(174, 20)
        Me.LblSubtotal.TabIndex = 55
        Me.LblSubtotal.Text = "0.00"
        Me.LblSubtotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblMotivo
        '
        Me.LblMotivo.Location = New System.Drawing.Point(82, 168)
        Me.LblMotivo.Name = "LblMotivo"
        Me.LblMotivo.Size = New System.Drawing.Size(454, 23)
        Me.LblMotivo.TabIndex = 56
        Me.LblMotivo.Text = "Concepto"
        '
        'FrmCanMulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblMotivo)
        Me.Controls.Add(Me.LblSubtotal)
        Me.Controls.Add(Me.LblVencimiento)
        Me.Controls.Add(Me.LblConcepto)
        Me.Controls.Add(Me.LblCuenCom)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblIva)
        Me.Controls.Add(Me.LblTitTotal)
        Me.Controls.Add(Me.LblTitIVA)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.LblTitSubTotal)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LBLNOMBRE)
        Me.Name = "FrmCanMulta"
        Me.Text = "Cancelar Movimiento"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblDireccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblIva As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitIVA As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblTitSubTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBLNOMBRE As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblCuenCom As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblConcepto As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblSubtotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblVencimiento As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblMotivo As DevComponents.DotNetBar.LabelX
End Class
