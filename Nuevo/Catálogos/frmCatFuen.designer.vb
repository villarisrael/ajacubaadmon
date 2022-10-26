<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatFuen
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
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdEditar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem
        Me.btnVisu = New DevComponents.DotNetBar.ButtonItem
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem
        Me.CatControl1 = New Administativo.catControl
        Me.BtnActualizar = New DevComponents.DotNetBar.ButtonItem
        Me.rbOp.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        Me.rbOp.Controls.Add(Me.ReflectionLabel3)
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.cmdEditar, Me.cmdBuscar, Me.cmdImp, Me.btnVisu, Me.BtnActualizar, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(782, 67)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 3
        Me.rbOp.Text = "Opciones"
        Me.rbOp.TitleVisible = False
        '
        'ReflectionLabel3
        '
        Me.ReflectionLabel3.Location = New System.Drawing.Point(362, 12)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(410, 37)
        Me.ReflectionLabel3.TabIndex = 15
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>CATÁLOGO DE FUENTES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.Administativo.My.Resources.Resources.filenew
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Agregar"
        '
        'cmdEditar
        '
        Me.cmdEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEditar.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.cmdEditar.ImagePaddingHorizontal = 8
        Me.cmdEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.SubItemsExpandWidth = 14
        Me.cmdEditar.Text = "Editar"
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
        'btnVisu
        '
        Me.btnVisu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnVisu.Image = Global.Administativo.My.Resources.Resources.demo
        Me.btnVisu.ImagePaddingHorizontal = 8
        Me.btnVisu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnVisu.Name = "btnVisu"
        Me.btnVisu.SubItemsExpandWidth = 14
        Me.btnVisu.Text = "Visualizar"
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
        'CatControl1
        '
        Me.CatControl1._catalogo = Administativo.catControl.Catalogos.Fuentes
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Me
        Me.CatControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl1.Location = New System.Drawing.Point(0, 67)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.Size = New System.Drawing.Size(782, 206)
        Me.CatControl1.TabIndex = 0
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = Global.Administativo.My.Resources.Resources.agt_reload
        Me.BtnActualizar.ImagePaddingHorizontal = 8
        Me.BtnActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.SubItemsExpandWidth = 14
        Me.BtnActualizar.Text = "Actualizar"
        '
        'frmCatFuen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 273)
        Me.Controls.Add(Me.CatControl1)
        Me.Controls.Add(Me.rbOp)
        Me.Name = "frmCatFuen"
        Me.Text = "Catálogo de Fuentes"
        Me.rbOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CatControl1 As Administativo.catControl
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnVisu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnActualizar As DevComponents.DotNetBar.ButtonItem
End Class
