<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
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
        Me.rbPestaña = New DevComponents.DotNetBar.RibbonBarMergeContainer
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar
        Me.BtnMostrar = New DevComponents.DotNetBar.ButtonItem
        Me.btnmostrarfactibilidad = New DevComponents.DotNetBar.ButtonItem
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.btnDarDeBaja = New DevComponents.DotNetBar.ButtonItem
        Me.BtnReactivacion = New DevComponents.DotNetBar.ButtonItem
        Me.Baja = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.rbPestaña.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbPestaña
        '
        Me.rbPestaña.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbPestaña.Controls.Add(Me.rbOp)
        Me.rbPestaña.Location = New System.Drawing.Point(13, 85)
        Me.rbPestaña.Name = "rbPestaña"
        Me.rbPestaña.RibbonTabText = "Solicitudes"
        Me.rbPestaña.Size = New System.Drawing.Size(439, 100)
        Me.rbPestaña.TabIndex = 5
        Me.rbPestaña.Visible = False
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnMostrar, Me.btnmostrarfactibilidad, Me.ButtonItem1, Me.cmdBuscar, Me.cmdImp, Me.cmdSalir, Me.Baja, Me.ButtonItem2})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(3, 3)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(408, 97)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 0
        Me.rbOp.Text = "Opciones"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnMostrar.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.BtnMostrar.ImagePaddingHorizontal = 8
        Me.BtnMostrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.SubItemsExpandWidth = 14
        Me.BtnMostrar.Text = "nuevo"
        '
        'btnmostrarfactibilidad
        '
        Me.btnmostrarfactibilidad.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnmostrarfactibilidad.Image = Global.Administativo.My.Resources.Resources.Factibilidad
        Me.btnmostrarfactibilidad.ImagePaddingHorizontal = 8
        Me.btnmostrarfactibilidad.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnmostrarfactibilidad.Name = "btnmostrarfactibilidad"
        Me.btnmostrarfactibilidad.Text = "Editar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdBuscar.Image = Global.Administativo.My.Resources.Resources.search777
        Me.cmdBuscar.ImagePaddingHorizontal = 8
        Me.cmdBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.SubItemsExpandWidth = 14
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdImp
        '
        Me.cmdImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.ImagePaddingHorizontal = 8
        Me.cmdImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.SubItemsExpandWidth = 14
        Me.cmdImp.Text = "Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImagePaddingHorizontal = 8
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Salir"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Consultar"
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnDarDeBaja.Enabled = False
        Me.btnDarDeBaja.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion2
        Me.btnDarDeBaja.ImagePaddingHorizontal = 8
        Me.btnDarDeBaja.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Text = "Dar de Baja"
        '
        'BtnReactivacion
        '
        Me.BtnReactivacion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnReactivacion.Enabled = False
        Me.BtnReactivacion.Image = Global.Administativo.My.Resources.Resources.cnr_update
        Me.BtnReactivacion.ImagePaddingHorizontal = 8
        Me.BtnReactivacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnReactivacion.Name = "BtnReactivacion"
        Me.BtnReactivacion.SubItemsExpandWidth = 14
        Me.BtnReactivacion.Text = "Reactivacion"
        '
        'Baja
        '
        Me.Baja.ImagePaddingHorizontal = 8
        Me.Baja.Name = "Baja"
        Me.Baja.SubItemsExpandWidth = 14
        Me.Baja.Text = "Baja"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ImagePaddingHorizontal = 8
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "Reactivacion"
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 345)
        Me.Controls.Add(Me.rbPestaña)
        Me.Name = "FrmRegistro"
        Me.Text = "FrmRegistro"
        Me.rbPestaña.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbPestaña As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents BtnMostrar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnmostrarfactibilidad As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Baja As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDarDeBaja As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnReactivacion As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
End Class
