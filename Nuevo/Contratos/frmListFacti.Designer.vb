<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListFacti
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
        Me.cmdEditar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdCancelar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem
        Me.cmdConvCont = New DevComponents.DotNetBar.ButtonItem
        Me.cmdact = New DevComponents.DotNetBar.ButtonItem
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem
        Me.CatControl1 = New Administativo.catControl
        Me.SuspendLayout()
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdEditar, Me.cmdCancelar, Me.cmdBuscar, Me.cmdImp, Me.cmdConvCont, Me.cmdact, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(696, 70)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 0
        Me.rbOp.Text = "Opciones"
        Me.rbOp.TitleVisible = False
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
        'cmdCancelar
        '
        Me.cmdCancelar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.cmdCancelar.ImagePaddingHorizontal = 8
        Me.cmdCancelar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.SubItemsExpandWidth = 14
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.Visible = False
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
        Me.cmdImp.Visible = False
        '
        'cmdConvCont
        '
        Me.cmdConvCont.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdConvCont.Enabled = False
        Me.cmdConvCont.Image = Global.Administativo.My.Resources.Resources.compfile
        Me.cmdConvCont.ImagePaddingHorizontal = 8
        Me.cmdConvCont.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdConvCont.Name = "cmdConvCont"
        Me.cmdConvCont.Text = "Convertir a Contrato"
        '
        'cmdact
        '
        Me.cmdact.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdact.Image = Global.Administativo.My.Resources.Resources.agt_reload
        Me.cmdact.ImagePaddingHorizontal = 8
        Me.cmdact.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdact.Name = "cmdact"
        Me.cmdact.SubItemsExpandWidth = 14
        Me.cmdact.Text = "Actualizar"
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
        Me.CatControl1._catalogo = Administativo.catControl.Catalogos.Factibilidad
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Me
        Me.CatControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl1.Location = New System.Drawing.Point(0, 70)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.seleccionMultiple = True
        Me.CatControl1.Size = New System.Drawing.Size(696, 410)
        Me.CatControl1.TabIndex = 0
        '
        'frmListFacti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 480)
        Me.Controls.Add(Me.CatControl1)
        Me.Controls.Add(Me.rbOp)
        Me.Name = "frmListFacti"
        Me.Text = "Lista de Factibilidades"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CatControl1 As Administativo.catControl
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCancelar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdConvCont As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdact As DevComponents.DotNetBar.ButtonItem
End Class
