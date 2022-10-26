<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisMultasAbonos
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
        Me.LblFecha = New DevComponents.DotNetBar.LabelX
        Me.TxtFolio = New DevComponents.DotNetBar.LabelX
        Me.LblTitFecha = New DevComponents.DotNetBar.LabelX
        Me.LblFolio = New DevComponents.DotNetBar.LabelX
        Me.GpUsuario = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LblComunidad = New DevComponents.DotNetBar.LabelX
        Me.LblCuenta = New DevComponents.DotNetBar.LabelX
        Me.LblGiro = New DevComponents.DotNetBar.LabelX
        Me.LblTarifa = New DevComponents.DotNetBar.LabelX
        Me.LblEstado = New DevComponents.DotNetBar.LabelX
        Me.LblDireccion = New DevComponents.DotNetBar.LabelX
        Me.LBLNOMBRE = New DevComponents.DotNetBar.LabelX
        Me.LblUsuario = New DevComponents.DotNetBar.LabelX
        Me.GPDetalles = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmdCancel = New DevComponents.DotNetBar.ButtonX
        Me.LblTitConcepto = New DevComponents.DotNetBar.LabelX
        Me.LblConcepto = New DevComponents.DotNetBar.LabelX
        Me.LblMotivo = New DevComponents.DotNetBar.LabelX
        Me.LblTitMotivo = New DevComponents.DotNetBar.LabelX
        Me.LblVencimiento = New DevComponents.DotNetBar.LabelX
        Me.LblTitVencimiento = New DevComponents.DotNetBar.LabelX
        Me.LblSubTotal = New DevComponents.DotNetBar.LabelX
        Me.LblTitSubtotal = New DevComponents.DotNetBar.LabelX
        Me.LblIVA = New DevComponents.DotNetBar.LabelX
        Me.LblTitIva = New DevComponents.DotNetBar.LabelX
        Me.LblTotal = New DevComponents.DotNetBar.LabelX
        Me.LblTitTotal = New DevComponents.DotNetBar.LabelX
        Me.LblResta = New DevComponents.DotNetBar.LabelX
        Me.LblTitResta = New DevComponents.DotNetBar.LabelX
        Me.LblAbonos = New DevComponents.DotNetBar.LabelX
        Me.LblTitAbonos = New DevComponents.DotNetBar.LabelX
        Me.GpUsuario.SuspendLayout()
        Me.GPDetalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(366, 4)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(167, 23)
        Me.LblFecha.TabIndex = 31
        Me.LblFecha.Text = "Fecha:"
        '
        'TxtFolio
        '
        Me.TxtFolio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFolio.Location = New System.Drawing.Point(45, 1)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(274, 23)
        Me.TxtFolio.TabIndex = 28
        Me.TxtFolio.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LblTitFecha
        '
        Me.LblTitFecha.Location = New System.Drawing.Point(325, 4)
        Me.LblTitFecha.Name = "LblTitFecha"
        Me.LblTitFecha.Size = New System.Drawing.Size(35, 23)
        Me.LblTitFecha.TabIndex = 29
        Me.LblTitFecha.Text = "Fecha:"
        '
        'LblFolio
        '
        Me.LblFolio.Location = New System.Drawing.Point(13, 4)
        Me.LblFolio.Name = "LblFolio"
        Me.LblFolio.Size = New System.Drawing.Size(35, 23)
        Me.LblFolio.TabIndex = 27
        Me.LblFolio.Text = "Folio:"
        '
        'GpUsuario
        '
        Me.GpUsuario.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpUsuario.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpUsuario.Controls.Add(Me.LblComunidad)
        Me.GpUsuario.Controls.Add(Me.LblCuenta)
        Me.GpUsuario.Controls.Add(Me.LblGiro)
        Me.GpUsuario.Controls.Add(Me.LblTarifa)
        Me.GpUsuario.Controls.Add(Me.LblEstado)
        Me.GpUsuario.Controls.Add(Me.LblDireccion)
        Me.GpUsuario.Controls.Add(Me.LblUsuario)
        Me.GpUsuario.Location = New System.Drawing.Point(12, 27)
        Me.GpUsuario.Name = "GpUsuario"
        Me.GpUsuario.Size = New System.Drawing.Size(666, 105)
        '
        '
        '
        Me.GpUsuario.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpUsuario.Style.BackColorGradientAngle = 90
        Me.GpUsuario.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpUsuario.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpUsuario.Style.BorderBottomWidth = 1
        Me.GpUsuario.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpUsuario.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpUsuario.Style.BorderLeftWidth = 1
        Me.GpUsuario.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpUsuario.Style.BorderRightWidth = 1
        Me.GpUsuario.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpUsuario.Style.BorderTopWidth = 1
        Me.GpUsuario.Style.CornerDiameter = 4
        Me.GpUsuario.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpUsuario.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GpUsuario.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpUsuario.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GpUsuario.TabIndex = 30
        '
        'LblComunidad
        '
        Me.LblComunidad.BackColor = System.Drawing.Color.Transparent
        Me.LblComunidad.Location = New System.Drawing.Point(129, 1)
        Me.LblComunidad.Name = "LblComunidad"
        Me.LblComunidad.Size = New System.Drawing.Size(520, 23)
        Me.LblComunidad.TabIndex = 10
        Me.LblComunidad.Text = "Cuenta"
        '
        'LblCuenta
        '
        Me.LblCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblCuenta.Location = New System.Drawing.Point(64, 1)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(47, 23)
        Me.LblCuenta.TabIndex = 9
        Me.LblCuenta.Text = "Cuenta"
        '
        'LblGiro
        '
        Me.LblGiro.BackColor = System.Drawing.Color.Transparent
        Me.LblGiro.Location = New System.Drawing.Point(11, 45)
        Me.LblGiro.Name = "LblGiro"
        Me.LblGiro.Size = New System.Drawing.Size(638, 20)
        Me.LblGiro.TabIndex = 6
        '
        'LblTarifa
        '
        Me.LblTarifa.BackColor = System.Drawing.Color.Transparent
        Me.LblTarifa.Location = New System.Drawing.Point(219, 79)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(176, 20)
        Me.LblTarifa.TabIndex = 8
        '
        'LblEstado
        '
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Location = New System.Drawing.Point(11, 79)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(119, 20)
        Me.LblEstado.TabIndex = 7
        '
        'LblDireccion
        '
        Me.LblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LblDireccion.Location = New System.Drawing.Point(11, 20)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(638, 23)
        Me.LblDireccion.TabIndex = 5
        '
        'LBLNOMBRE
        '
        Me.LBLNOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.LBLNOMBRE.Location = New System.Drawing.Point(18, 62)
        Me.LBLNOMBRE.Name = "LBLNOMBRE"
        Me.LBLNOMBRE.Size = New System.Drawing.Size(638, 23)
        Me.LBLNOMBRE.TabIndex = 4
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Location = New System.Drawing.Point(11, 1)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(47, 23)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario:"
        '
        'GPDetalles
        '
        Me.GPDetalles.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPDetalles.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPDetalles.Controls.Add(Me.LblResta)
        Me.GPDetalles.Controls.Add(Me.LblTitResta)
        Me.GPDetalles.Controls.Add(Me.LblAbonos)
        Me.GPDetalles.Controls.Add(Me.LblTitAbonos)
        Me.GPDetalles.Controls.Add(Me.LblTotal)
        Me.GPDetalles.Controls.Add(Me.LblTitTotal)
        Me.GPDetalles.Controls.Add(Me.LblIVA)
        Me.GPDetalles.Controls.Add(Me.LblTitIva)
        Me.GPDetalles.Controls.Add(Me.LblSubTotal)
        Me.GPDetalles.Controls.Add(Me.LblTitSubtotal)
        Me.GPDetalles.Controls.Add(Me.LblVencimiento)
        Me.GPDetalles.Controls.Add(Me.LblTitVencimiento)
        Me.GPDetalles.Controls.Add(Me.LblMotivo)
        Me.GPDetalles.Controls.Add(Me.LblTitMotivo)
        Me.GPDetalles.Controls.Add(Me.LblConcepto)
        Me.GPDetalles.Controls.Add(Me.LblTitConcepto)
        Me.GPDetalles.Location = New System.Drawing.Point(12, 138)
        Me.GPDetalles.Name = "GPDetalles"
        Me.GPDetalles.Size = New System.Drawing.Size(666, 283)
        '
        '
        '
        Me.GPDetalles.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPDetalles.Style.BackColorGradientAngle = 90
        Me.GPDetalles.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPDetalles.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDetalles.Style.BorderBottomWidth = 1
        Me.GPDetalles.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPDetalles.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDetalles.Style.BorderLeftWidth = 1
        Me.GPDetalles.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDetalles.Style.BorderRightWidth = 1
        Me.GPDetalles.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDetalles.Style.BorderTopWidth = 1
        Me.GPDetalles.Style.CornerDiameter = 4
        Me.GPDetalles.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPDetalles.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPDetalles.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPDetalles.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GPDetalles.TabIndex = 32
        Me.GPDetalles.Text = "Detalles del movimiento"
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCancel.Image = Global.Administativo.My.Resources.Resources.Salir_ln777
        Me.cmdCancel.Location = New System.Drawing.Point(572, 435)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(106, 38)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cerrar"
        '
        'LblTitConcepto
        '
        Me.LblTitConcepto.BackColor = System.Drawing.Color.Transparent
        Me.LblTitConcepto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitConcepto.Location = New System.Drawing.Point(11, 13)
        Me.LblTitConcepto.Name = "LblTitConcepto"
        Me.LblTitConcepto.Size = New System.Drawing.Size(62, 19)
        Me.LblTitConcepto.TabIndex = 0
        Me.LblTitConcepto.Text = "Concepto:"
        '
        'LblConcepto
        '
        Me.LblConcepto.BackColor = System.Drawing.Color.Transparent
        Me.LblConcepto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConcepto.Location = New System.Drawing.Point(79, 13)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(576, 19)
        Me.LblConcepto.TabIndex = 1
        Me.LblConcepto.Text = "Concepto:"
        '
        'LblMotivo
        '
        Me.LblMotivo.BackColor = System.Drawing.Color.Transparent
        Me.LblMotivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMotivo.Location = New System.Drawing.Point(79, 44)
        Me.LblMotivo.Name = "LblMotivo"
        Me.LblMotivo.Size = New System.Drawing.Size(576, 19)
        Me.LblMotivo.TabIndex = 3
        Me.LblMotivo.Text = "Motivo:"
        '
        'LblTitMotivo
        '
        Me.LblTitMotivo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitMotivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitMotivo.Location = New System.Drawing.Point(11, 44)
        Me.LblTitMotivo.Name = "LblTitMotivo"
        Me.LblTitMotivo.Size = New System.Drawing.Size(62, 19)
        Me.LblTitMotivo.TabIndex = 2
        Me.LblTitMotivo.Text = "Motivo:"
        '
        'LblVencimiento
        '
        Me.LblVencimiento.BackColor = System.Drawing.Color.Transparent
        Me.LblVencimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento.Location = New System.Drawing.Point(95, 73)
        Me.LblVencimiento.Name = "LblVencimiento"
        Me.LblVencimiento.Size = New System.Drawing.Size(81, 19)
        Me.LblVencimiento.TabIndex = 5
        Me.LblVencimiento.Text = "Vencimiento:"
        '
        'LblTitVencimiento
        '
        Me.LblTitVencimiento.BackColor = System.Drawing.Color.Transparent
        Me.LblTitVencimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitVencimiento.Location = New System.Drawing.Point(11, 73)
        Me.LblTitVencimiento.Name = "LblTitVencimiento"
        Me.LblTitVencimiento.Size = New System.Drawing.Size(78, 19)
        Me.LblTitVencimiento.TabIndex = 4
        Me.LblTitVencimiento.Text = "Vencimiento:"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotal.Location = New System.Drawing.Point(140, 140)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(81, 19)
        Me.LblSubTotal.TabIndex = 7
        Me.LblSubTotal.Text = "0"
        Me.LblSubTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblTitSubtotal
        '
        Me.LblTitSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTitSubtotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitSubtotal.Location = New System.Drawing.Point(56, 140)
        Me.LblTitSubtotal.Name = "LblTitSubtotal"
        Me.LblTitSubtotal.Size = New System.Drawing.Size(78, 19)
        Me.LblTitSubtotal.TabIndex = 6
        Me.LblTitSubtotal.Text = "SubTotal:"
        '
        'LblIVA
        '
        Me.LblIVA.BackColor = System.Drawing.Color.Transparent
        Me.LblIVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIVA.Location = New System.Drawing.Point(140, 165)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.Size = New System.Drawing.Size(81, 19)
        Me.LblIVA.TabIndex = 9
        Me.LblIVA.Text = "0"
        Me.LblIVA.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblTitIva
        '
        Me.LblTitIva.BackColor = System.Drawing.Color.Transparent
        Me.LblTitIva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitIva.Location = New System.Drawing.Point(56, 165)
        Me.LblTitIva.Name = "LblTitIva"
        Me.LblTitIva.Size = New System.Drawing.Size(78, 19)
        Me.LblTitIva.TabIndex = 8
        Me.LblTitIva.Text = "IVA:"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(140, 189)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(81, 19)
        Me.LblTotal.TabIndex = 11
        Me.LblTotal.Text = "0"
        Me.LblTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblTitTotal
        '
        Me.LblTitTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTitTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitTotal.Location = New System.Drawing.Point(56, 189)
        Me.LblTitTotal.Name = "LblTitTotal"
        Me.LblTitTotal.Size = New System.Drawing.Size(78, 19)
        Me.LblTitTotal.TabIndex = 10
        Me.LblTitTotal.Text = "Total:"
        '
        'LblResta
        '
        Me.LblResta.BackColor = System.Drawing.Color.Transparent
        Me.LblResta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResta.Location = New System.Drawing.Point(424, 165)
        Me.LblResta.Name = "LblResta"
        Me.LblResta.Size = New System.Drawing.Size(81, 19)
        Me.LblResta.TabIndex = 15
        Me.LblResta.Text = "0"
        Me.LblResta.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblTitResta
        '
        Me.LblTitResta.BackColor = System.Drawing.Color.Transparent
        Me.LblTitResta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitResta.Location = New System.Drawing.Point(340, 165)
        Me.LblTitResta.Name = "LblTitResta"
        Me.LblTitResta.Size = New System.Drawing.Size(78, 19)
        Me.LblTitResta.TabIndex = 14
        Me.LblTitResta.Text = "Resta:"
        '
        'LblAbonos
        '
        Me.LblAbonos.BackColor = System.Drawing.Color.Transparent
        Me.LblAbonos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbonos.Location = New System.Drawing.Point(424, 140)
        Me.LblAbonos.Name = "LblAbonos"
        Me.LblAbonos.Size = New System.Drawing.Size(81, 19)
        Me.LblAbonos.TabIndex = 13
        Me.LblAbonos.Text = "0"
        Me.LblAbonos.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LblTitAbonos
        '
        Me.LblTitAbonos.BackColor = System.Drawing.Color.Transparent
        Me.LblTitAbonos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitAbonos.Location = New System.Drawing.Point(340, 140)
        Me.LblTitAbonos.Name = "LblTitAbonos"
        Me.LblTitAbonos.Size = New System.Drawing.Size(78, 19)
        Me.LblTitAbonos.TabIndex = 12
        Me.LblTitAbonos.Text = "Abonos:"
        '
        'FrmVisMultasAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.GPDetalles)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.TxtFolio)
        Me.Controls.Add(Me.LblTitFecha)
        Me.Controls.Add(Me.LblFolio)
        Me.Controls.Add(Me.GpUsuario)
        Me.Controls.Add(Me.LBLNOMBRE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmVisMultasAbonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVisMultasAbonos"
        Me.GpUsuario.ResumeLayout(False)
        Me.GPDetalles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtFolio As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblFolio As DevComponents.DotNetBar.LabelX
    Friend WithEvents GpUsuario As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LblComunidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblCuenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblGiro As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTarifa As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblDireccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBLNOMBRE As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents GPDetalles As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmdCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblConcepto As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitConcepto As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblMotivo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitMotivo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblVencimiento As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitVencimiento As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblResta As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitResta As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblAbonos As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitAbonos As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblIVA As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitIva As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblSubTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblTitSubtotal As DevComponents.DotNetBar.LabelX
End Class
