<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListSoli
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
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.cmdAgr = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnVisualizar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCancelar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdact = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdFac = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEditF = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdVisF = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdConvCont = New DevComponents.DotNetBar.ButtonItem()
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
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdAgr, Me.cmdEditar, Me.BtnVisualizar, Me.cmdCancelar, Me.cmdBuscar, Me.cmdImp, Me.cmdact, Me.cmdFac, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(896, 66)
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
        Me.ReflectionLabel3.Location = New System.Drawing.Point(479, 12)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(379, 37)
        Me.ReflectionLabel3.TabIndex = 16
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>SOLICITUDES Y FACTIBILIDADES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'cmdAgr
        '
        Me.cmdAgr.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdAgr.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.cmdAgr.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdAgr.Name = "cmdAgr"
        Me.cmdAgr.Text = "Agregar"
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
        Me.BtnVisualizar.Text = "Visualizar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdCancelar.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCancelar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.SubItemsExpandWidth = 14
        Me.cmdCancelar.Text = "Cancelar"
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
        'cmdFac
        '
        Me.cmdFac.Image = Global.Administativo.My.Resources.Resources.Factibilidad
        Me.cmdFac.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdFac.Name = "cmdFac"
        Me.cmdFac.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdEditF, Me.cmdVisF, Me.cmdConvCont})
        Me.cmdFac.SubItemsExpandWidth = 14
        Me.cmdFac.Text = "Factibiliad"
        '
        'cmdEditF
        '
        Me.cmdEditF.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.cmdEditF.Name = "cmdEditF"
        Me.cmdEditF.Text = "Editar Factibilidad"
        '
        'cmdVisF
        '
        Me.cmdVisF.Image = Global.Administativo.My.Resources.Resources.demo
        Me.cmdVisF.Name = "cmdVisF"
        Me.cmdVisF.Text = "Visualizar Factibilidad"
        '
        'cmdConvCont
        '
        Me.cmdConvCont.Enabled = False
        Me.cmdConvCont.Image = Global.Administativo.My.Resources.Resources.compfile
        Me.cmdConvCont.Name = "cmdConvCont"
        Me.cmdConvCont.Text = "Convertir a Contrato"
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
        Me.CatControl1._catalogo = Administativo.catControl.Catalogos.Solicitud
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Me
        Me.CatControl1._Tabla = Nothing
        Me.CatControl1.Campos = ""
        Me.CatControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl1.Location = New System.Drawing.Point(0, 66)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.seleccionMultiple = False
        Me.CatControl1.Size = New System.Drawing.Size(896, 410)
        Me.CatControl1.TabIndex = 0
        '
        'frmListSoli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 476)
        Me.Controls.Add(Me.CatControl1)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.Name = "frmListSoli"
        Me.Text = "Lista de solicitudes"
        Me.rbOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CatControl1 As Administativo.catControl
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdAgr As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCancelar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdact As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnVisualizar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents cmdFac As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditF As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdConvCont As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdVisF As DevComponents.DotNetBar.ButtonItem
End Class
