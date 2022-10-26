<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoUsers
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
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnVisualizar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCancelar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdact = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.CatControl1 = New Administativo.catControl()
        Me.SuspendLayout()
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbOp.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.ContainerControlProcessDialogKey = True
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.cmdEditar, Me.BtnVisualizar, Me.cmdCancelar, Me.cmdBuscar, Me.cmdImp, Me.cmdact, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(676, 61)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 1
        Me.rbOp.Text = "Opciones"
        '
        '
        '
        Me.rbOp.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbOp.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbOp.TitleVisible = False
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Agregar"
        '
        'cmdEditar
        '
        Me.cmdEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEditar.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.cmdEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.SubItemsExpandWidth = 14
        Me.cmdEditar.Text = "Editar"
        '
        'BtnVisualizar
        '
        Me.BtnVisualizar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnVisualizar.Image = Global.Administativo.My.Resources.Resources.demo
        Me.BtnVisualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnVisualizar.Name = "BtnVisualizar"
        Me.BtnVisualizar.SubItemsExpandWidth = 14
        Me.BtnVisualizar.Text = "Vizualizar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCancelar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.SubItemsExpandWidth = 14
        Me.cmdCancelar.Text = "Eliminar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdBuscar.Image = Global.Administativo.My.Resources.Resources.kdict1
        Me.cmdBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.SubItemsExpandWidth = 14
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdImp
        '
        Me.cmdImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.SubItemsExpandWidth = 14
        Me.cmdImp.Text = "Imprimir"
        '
        'cmdact
        '
        Me.cmdact.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdact.Image = Global.Administativo.My.Resources.Resources.agt_reload
        Me.cmdact.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdact.Name = "cmdact"
        Me.cmdact.SubItemsExpandWidth = 14
        Me.cmdact.Text = "Actualizar"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Salir"
        '
        'CatControl1
        '
        Me.CatControl1._catalogo = Administativo.catControl.Catalogos.Users
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Nothing
        Me.CatControl1._Tabla = Nothing
        Me.CatControl1.Campos = ""
        Me.CatControl1.Location = New System.Drawing.Point(0, 67)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.seleccionMultiple = True
        Me.CatControl1.Size = New System.Drawing.Size(676, 392)
        Me.CatControl1.TabIndex = 2
        '
        'FrmListadoUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 471)
        Me.Controls.Add(Me.CatControl1)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.Name = "FrmListadoUsers"
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnVisualizar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCancelar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdact As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CatControl1 As catControl
    ' Friend WithEvents CatControl1 As Leon.catControl
End Class
