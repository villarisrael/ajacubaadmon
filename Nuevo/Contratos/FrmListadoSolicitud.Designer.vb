<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoSolicitud
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
        Me.cmdBuscar = New DevComponents.DotNetBar.ButtonItem
        Me.cmdImp = New DevComponents.DotNetBar.ButtonItem
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem
        Me.CatControl1 = New AcquaLiberVista.catControl
        Me.btnmostrarfactibilidad = New DevComponents.DotNetBar.ButtonItem
        Me.rbPestaña.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbPestaña
        '
        Me.rbPestaña.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbPestaña.Controls.Add(Me.rbOp)
        Me.rbPestaña.Location = New System.Drawing.Point(2, 160)
        Me.rbPestaña.Name = "rbPestaña"
        Me.rbPestaña.RibbonTabText = "Solicitudes"
        Me.rbPestaña.Size = New System.Drawing.Size(375, 100)
        Me.rbPestaña.TabIndex = 4
        Me.rbPestaña.Visible = False
        '
        'rbOp
        '
        Me.rbOp.AutoOverflowEnabled = True
        Me.rbOp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnMostrar, Me.btnmostrarfactibilidad, Me.cmdBuscar, Me.cmdImp, Me.cmdSalir})
        Me.rbOp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.rbOp.Location = New System.Drawing.Point(3, 3)
        Me.rbOp.Name = "rbOp"
        Me.rbOp.Size = New System.Drawing.Size(323, 97)
        Me.rbOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbOp.TabIndex = 0
        Me.rbOp.Text = "Opciones"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnMostrar.Image = Global.AcquaLiberVista.My.Resources.Resources.Editar777
        Me.BtnMostrar.ImagePaddingHorizontal = 8
        Me.BtnMostrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.SubItemsExpandWidth = 14
        Me.BtnMostrar.Text = "Mostrar Solicitud"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdBuscar.Image = Global.AcquaLiberVista.My.Resources.Resources.search777
        Me.cmdBuscar.ImagePaddingHorizontal = 8
        Me.cmdBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.SubItemsExpandWidth = 14
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdImp
        '
        Me.cmdImp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdImp.Image = Global.AcquaLiberVista.My.Resources.Resources.imprimir
        Me.cmdImp.ImagePaddingHorizontal = 8
        Me.cmdImp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.SubItemsExpandWidth = 14
        Me.cmdImp.Text = "Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSalir.Image = Global.AcquaLiberVista.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImagePaddingHorizontal = 8
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Salir"
        '
        'CatControl1
        '
        Me.CatControl1._catalogo = AcquaLiberVista.catControl.Catalogos.Municipios
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Nothing
        Me.CatControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl1.Location = New System.Drawing.Point(0, 0)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.Size = New System.Drawing.Size(681, 479)
        Me.CatControl1.TabIndex = 3
        '
        'btnmostrarfactibilidad
        '
        Me.btnmostrarfactibilidad.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnmostrarfactibilidad.Image = Global.AcquaLiberVista.My.Resources.Resources.Factibilidad
        Me.btnmostrarfactibilidad.ImagePaddingHorizontal = 8
        Me.btnmostrarfactibilidad.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnmostrarfactibilidad.Name = "btnmostrarfactibilidad"
        Me.btnmostrarfactibilidad.Text = "Mostrar Factibilidad"
        '
        'FrmListadoSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 479)
        Me.Controls.Add(Me.rbPestaña)
        Me.Controls.Add(Me.CatControl1)
        Me.Name = "FrmListadoSolicitud"
        Me.Text = "Solicitudes"
        Me.rbPestaña.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbPestaña As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents rbOp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdBuscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CatControl1 As AcquaLiberVista.catControl
    Friend WithEvents BtnMostrar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnmostrarfactibilidad As DevComponents.DotNetBar.ButtonItem
End Class
