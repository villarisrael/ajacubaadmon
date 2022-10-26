<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescuentos
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescuentos))
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnAgregar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRest = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnImp = New DevComponents.DotNetBar.ButtonItem()
        Me.btnVisu = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.CatControl = New Administativo.catControl()
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
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAgregar, Me.btnEditar, Me.btnBuscar, Me.btnRest, Me.btnEliminar, Me.btnImp, Me.btnVisu, Me.btnSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(707, 65)
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
        'ReflectionLabel3
        '
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Location = New System.Drawing.Point(401, 8)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(298, 45)
        Me.ReflectionLabel3.TabIndex = 16
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>CATÁLOGO DE DESCUENTOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'btnAgregar
        '
        Me.btnAgregar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnAgregar.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.btnAgregar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Text = "Agregar"
        '
        'btnEditar
        '
        Me.btnEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEditar.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.btnEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.SubItemsExpandWidth = 14
        Me.btnEditar.Text = "Editar"
        '
        'btnBuscar
        '
        Me.btnBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnBuscar.Image = Global.Administativo.My.Resources.Resources.search777
        Me.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.SubItemsExpandWidth = 14
        Me.btnBuscar.Text = "Buscar"
        '
        'btnRest
        '
        Me.btnRest.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnRest.Image = Global.Administativo.My.Resources.Resources.agt_reload
        Me.btnRest.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnRest.Name = "btnRest"
        Me.btnRest.SubItemsExpandWidth = 14
        Me.btnRest.Text = "Restaurar"
        '
        'btnEliminar
        '
        Me.btnEliminar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEliminar.Image = Global.Administativo.My.Resources.Resources.Eliminar
        Me.btnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.SubItemsExpandWidth = 14
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnImp
        '
        Me.btnImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.btnImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImp.Name = "btnImp"
        Me.btnImp.SubItemsExpandWidth = 14
        Me.btnImp.Text = "Imprimir"
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
        'btnSalir
        '
        Me.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.SubItemsExpandWidth = 14
        Me.btnSalir.Text = "Salir"
        '
        'CatControl
        '
        Me.CatControl._catalogo = Administativo.catControl.Catalogos.Municipios
        Me.CatControl._consulta = Nothing
        Me.CatControl._frm = Nothing
        Me.CatControl._Tabla = Nothing
        Me.CatControl.Campos = ""
        Me.CatControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl.Location = New System.Drawing.Point(0, 65)
        Me.CatControl.Name = "CatControl"
        Me.CatControl.seleccionMultiple = True
        Me.CatControl.Size = New System.Drawing.Size(707, 302)
        Me.CatControl.TabIndex = 2
        '
        'frmDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 367)
        Me.Controls.Add(Me.CatControl)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDescuentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descuentos"
        Me.rbOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnAgregar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRest As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnVisu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CatControl As Administativo.catControl
End Class
