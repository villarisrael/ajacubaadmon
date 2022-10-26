<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerLect
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
        Me.components = New System.ComponentModel.Container
        Me.cmdSalir = New DevComponents.DotNetBar.BubbleButton
        Me.bubbleBar1 = New DevComponents.DotNetBar.BubbleBar
        Me.bubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.cmdImp = New DevComponents.DotNetBar.BubbleButton
        Me.cmdBus = New DevComponents.DotNetBar.BubbleButton

        Me.CatControl1 = New Administativo.catControl
        CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImageLarge = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.TooltipText = "SALIR"
        '
        'bubbleBar1
        '
        Me.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.bubbleBar1.AntiAlias = True
        Me.bubbleBar1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bubbleBar1.ButtonBackAreaStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile
        Me.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.bubbleBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bubbleBar1.ImageSizeLarge = New System.Drawing.Size(64, 64)
        Me.bubbleBar1.ImageSizeNormal = New System.Drawing.Size(32, 32)
        Me.bubbleBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.bubbleBar1.Location = New System.Drawing.Point(0, 394)
        Me.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.bubbleBar1.Name = "bubbleBar1"
        Me.bubbleBar1.SelectedTab = Me.bubbleBarTab1
        Me.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.bubbleBar1.Size = New System.Drawing.Size(1109, 58)
        Me.bubbleBar1.TabIndex = 1
        Me.bubbleBar1.Tabs.Add(Me.bubbleBarTab1)
        Me.bubbleBar1.Text = "bubbleBar1"
        Me.bubbleBar1.TooltipFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bubbleBarTab1
        '
        Me.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.bubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.cmdImp, Me.cmdBus, Me.cmdSalir})
        Me.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bubbleBarTab1.Name = "bubbleBarTab1"
        Me.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.bubbleBarTab1.Text = "Opciones"
        Me.bubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'cmdImp
        '
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.ImageLarge = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.TooltipText = "IMPRIMIR"
        Me.cmdImp.Visible = False
        '
        'cmdBus
        '
        Me.cmdBus.Image = Global.Administativo.My.Resources.Resources.search777
        Me.cmdBus.ImageLarge = Global.Administativo.My.Resources.Resources.search777
        Me.cmdBus.Name = "cmdBus"
        Me.cmdBus.TooltipText = "BUSCAR"
        Me.cmdBus.Visible = False
        '
        'CatControl1
        '
        Me.CatControl1._catalogo = Administativo.catControl.Catalogos.VerLect
        Me.CatControl1._consulta = Nothing
        Me.CatControl1._frm = Me

        Me.CatControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatControl1.Location = New System.Drawing.Point(0, 0)
        Me.CatControl1.Name = "CatControl1"
        Me.CatControl1.seleccionMultiple = True
        Me.CatControl1.Size = New System.Drawing.Size(1109, 394)
        Me.CatControl1.TabIndex = 0
        '
        'frmVerLect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1109, 452)
        Me.Controls.Add(Me.CatControl1)
        Me.Controls.Add(Me.bubbleBar1)
        Me.MaximizeBox = False
        Me.Name = "frmVerLect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL DE LECTURAS"
        CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CatControl1 As Administativo.catControl
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents bubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents cmdImp As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdBus As DevComponents.DotNetBar.BubbleButton

End Class
