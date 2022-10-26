<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdTrab
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
        Me.components = New System.ComponentModel.Container()
        Me.rbOp = New DevComponents.DotNetBar.RibbonBar()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lblOrd = New DevComponents.DotNetBar.LabelX()
        Me.cmdAgr = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEdit = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEditZona = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdVis = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCan = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdEst = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdTipQ = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCal = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdList = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdImpMasiva = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdact = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdColCat = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCol2 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCol3 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCol1 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCol4 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCol5 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdCol6 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mOp1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatControl1 = New Administativo.catControl()
        Me.rbOp.SuspendLayout()
        Me.cmsMenu.SuspendLayout()
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
        Me.rbOp.Controls.Add(Me.lblOrd)
        Me.rbOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbOp.DragDropSupport = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdAgr, Me.cmdEditar, Me.cmdEdit, Me.cmdEditZona, Me.cmdVis, Me.cmdCan, Me.cmdBuscar, Me.cmdEst, Me.cmdImpMasiva, Me.cmdact, Me.cmdColCat, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(0, 0)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(1020, 73)
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
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Location = New System.Drawing.Point(665, 12)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(228, 37)
        Me.ReflectionLabel3.TabIndex = 17
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>ÓRDENES DE TRABAJO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></b>"
        '
        'lblOrd
        '
        '
        '
        '
        Me.lblOrd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblOrd.Location = New System.Drawing.Point(651, 12)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(75, 23)
        Me.lblOrd.TabIndex = 0
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
        Me.cmdEditar.Text = "Resultado"
        '
        'cmdEdit
        '
        Me.cmdEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEdit.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.cmdEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.SubItemsExpandWidth = 14
        Me.cmdEdit.Text = "Editar"
        '
        'cmdEditZona
        '
        Me.cmdEditZona.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEditZona.Image = Global.Administativo.My.Resources.Resources.Editar777
        Me.cmdEditZona.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEditZona.Name = "cmdEditZona"
        Me.cmdEditZona.SubItemsExpandWidth = 14
        Me.cmdEditZona.Text = "Editar Zona"
        Me.cmdEditZona.Visible = False
        '
        'cmdVis
        '
        Me.cmdVis.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdVis.Image = Global.Administativo.My.Resources.Resources.kdict1
        Me.cmdVis.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdVis.Name = "cmdVis"
        Me.cmdVis.SubItemsExpandWidth = 14
        Me.cmdVis.Text = "Visualizar"
        '
        'cmdCan
        '
        Me.cmdCan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdCan.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.cmdCan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdCan.Name = "cmdCan"
        Me.cmdCan.SubItemsExpandWidth = 14
        Me.cmdCan.Text = "Cancelar"
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
        'cmdEst
        '
        Me.cmdEst.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEst.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdEst.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEst.Name = "cmdEst"
        Me.cmdEst.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdTipQ, Me.cmdCal, Me.cmdList, Me.cmdImp})
        Me.cmdEst.SubItemsExpandWidth = 14
        Me.cmdEst.Text = "Reportes"
        '
        'cmdTipQ
        '
        Me.cmdTipQ.Image = Global.Administativo.My.Resources.Resources.Ordenes_de_Trabajo
        Me.cmdTipQ.Name = "cmdTipQ"
        Me.cmdTipQ.Text = "POR TIPO DE QUEJA"
        '
        'cmdCal
        '
        Me.cmdCal.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdCal.Name = "cmdCal"
        Me.cmdCal.Text = "CALIDAD DE LAS ÓRDENES"
        '
        'cmdList
        '
        Me.cmdList.Image = Global.Administativo.My.Resources.Resources.news_subscribe
        Me.cmdList.Name = "cmdList"
        Me.cmdList.Text = "LISTADO DE ÓRDENES"
        '
        'cmdImp
        '
        Me.cmdImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.Graficacion
        Me.cmdImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.SubItemsExpandWidth = 14
        Me.cmdImp.Text = "Gráfica de calidad"
        Me.cmdImp.Visible = False
        '
        'cmdImpMasiva
        '
        Me.cmdImpMasiva.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImpMasiva.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImpMasiva.Name = "cmdImpMasiva"
        Me.cmdImpMasiva.SubItemsExpandWidth = 14
        Me.cmdImpMasiva.Text = "Impresión masiva"
        Me.cmdImpMasiva.Visible = False
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
        'cmdColCat
        '
        Me.cmdColCat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdColCat.Image = Global.Administativo.My.Resources.Resources.banOrdTrab
        Me.cmdColCat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdColCat.Name = "cmdColCat"
        Me.cmdColCat.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdCol2, Me.cmdCol3, Me.cmdCol1, Me.cmdCol4, Me.cmdCol5, Me.cmdCol6})
        Me.cmdColCat.SubItemsExpandWidth = 14
        Me.cmdColCat.Text = "Estados"
        '
        'cmdCol2
        '
        Me.cmdCol2.Image = Global.Administativo.My.Resources.Resources.Square___Green
        Me.cmdCol2.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cmdCol2.Name = "cmdCol2"
        Me.cmdCol2.Text = "Cumplidas en tiempo"
        '
        'cmdCol3
        '
        Me.cmdCol3.Image = Global.Administativo.My.Resources.Resources.Square___Blue
        Me.cmdCol3.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cmdCol3.Name = "cmdCol3"
        Me.cmdCol3.Text = "Cumplidas Fuera de tiempo"
        '
        'cmdCol1
        '
        Me.cmdCol1.Image = Global.Administativo.My.Resources.Resources.Square___Yellow
        Me.cmdCol1.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cmdCol1.Name = "cmdCol1"
        Me.cmdCol1.Text = "Sin realizar,  dentro de la fecha de cumplimiento"
        '
        'cmdCol4
        '
        Me.cmdCol4.Image = Global.Administativo.My.Resources.Resources.naranja
        Me.cmdCol4.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cmdCol4.Name = "cmdCol4"
        Me.cmdCol4.Text = "Sin realizar, con tres días de atraso"
        '
        'cmdCol5
        '
        Me.cmdCol5.Image = Global.Administativo.My.Resources.Resources.Square___Red
        Me.cmdCol5.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cmdCol5.Name = "cmdCol5"
        Me.cmdCol5.Text = "Sin realizar, con una semana de atraso o más"
        '
        'cmdCol6
        '
        Me.cmdCol6.Image = Global.Administativo.My.Resources.Resources.Square___Red
        Me.cmdCol6.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cmdCol6.Name = "cmdCol6"
        Me.cmdCol6.Text = "Canceladas"
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
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mOp1})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(179, 26)
        '
        'mOp1
        '
        Me.mOp1.Image = Global.Administativo.My.Resources.Resources.cnr_update
        Me.mOp1.Name = "mOp1"
        Me.mOp1.Size = New System.Drawing.Size(178, 22)
        Me.mOp1.Text = "CREAR SUB-ORDEN"
        '
        'CatControl1
        '
        Me.CatControl1._catalogo = Administativo.catControl.Catalogos.OrdenTrab
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Me
        Me.CatControl1._Tabla = Nothing
        Me.CatControl1.Campos = ""
        Me.CatControl1.ContextMenuStrip = Me.cmsMenu
        Me.CatControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl1.Location = New System.Drawing.Point(0, 73)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.seleccionMultiple = False
        Me.CatControl1.Size = New System.Drawing.Size(1020, 390)
        Me.CatControl1.TabIndex = 0
        '
        'frmOrdTrab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 463)
        Me.Controls.Add(Me.CatControl1)
        Me.Controls.Add(Me.rbOp)
        Me.DoubleBuffered = True
        Me.Name = "frmOrdTrab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ÓRDENES DE TRABAJO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.rbOp.ResumeLayout(False)
        Me.cmsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CatControl1 As Administativo.catControl
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdAgr As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCan As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdVis As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEst As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdTipQ As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCal As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdact As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdList As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mOp1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdColCat As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCol1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCol2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCol3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCol4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCol5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdCol6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImpMasiva As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblOrd As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents cmdEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEditZona As DevComponents.DotNetBar.ButtonItem
End Class
