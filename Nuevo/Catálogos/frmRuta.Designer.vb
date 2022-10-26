<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRuta))
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEliminar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdRes = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.btnVisu = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.CatControl1 = New Administativo.catControl()
        Me.rbOp.SuspendLayout()
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
        Me.rbOp.Controls.Add(Me.ReflectionLabel3)
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.cmdEditar, Me.cmdEliminar, Me.cmdBuscar, Me.cmdRes, Me.cmdImp, Me.btnVisu, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(653, 67)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 0
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
        'ReflectionLabel3
        '
        Me.ReflectionLabel3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Location = New System.Drawing.Point(422, 12)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(219, 37)
        Me.ReflectionLabel3.TabIndex = 13
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>CATÁLOGO DE RUTAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
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
        'cmdEliminar
        '
        Me.cmdEliminar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEliminar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.cmdEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.SubItemsExpandWidth = 14
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdBuscar.Image = Global.Administativo.My.Resources.Resources.search777
        Me.cmdBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.SubItemsExpandWidth = 14
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdRes
        '
        Me.cmdRes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdRes.Image = Global.Administativo.My.Resources.Resources.agt_reload
        Me.cmdRes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdRes.Name = "cmdRes"
        Me.cmdRes.SubItemsExpandWidth = 14
        Me.cmdRes.Text = "Restaurar"
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
        'btnVisu
        '
        Me.btnVisu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnVisu.Image = Global.Administativo.My.Resources.Resources.demo
        Me.btnVisu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnVisu.Name = "btnVisu"
        Me.btnVisu.SubItemsExpandWidth = 14
        Me.btnVisu.Text = "Visualizar"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Salir"
        '
        'CatControl1
        '
        Me.CatControl1._catalogo = Administativo.catControl.Catalogos.Ruta
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Nothing
        Me.CatControl1._Tabla = Nothing
        Me.CatControl1.Campos = ""
        Me.CatControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl1.Location = New System.Drawing.Point(0, 67)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.seleccionMultiple = True
        Me.CatControl1.Size = New System.Drawing.Size(653, 334)
        Me.CatControl1.TabIndex = 0
        '
        'frmRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 401)
        Me.Controls.Add(Me.CatControl1)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de rutas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.rbOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CatControl1 As Administativo.catControl
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEliminar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnVisu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents cmdRes As DevComponents.DotNetBar.ButtonItem
End Class
