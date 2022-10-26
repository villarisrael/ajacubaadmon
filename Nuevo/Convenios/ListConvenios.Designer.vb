Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListConvenios
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolBar = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.BtnNuevo = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdVisualizar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnim = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdact = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.datConvenios = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolBar.SuspendLayout()
        CType(Me.datConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.CanvasColor = System.Drawing.SystemColors.Control
        Me.ToolBar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ToolBar.Controls.Add(Me.RibbonBar2)
        Me.ToolBar.DisabledBackColor = System.Drawing.Color.Empty
        Me.ToolBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(912, 96)
        '
        '
        '
        Me.ToolBar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ToolBar.Style.BackColorGradientAngle = 90
        Me.ToolBar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ToolBar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderBottomWidth = 1
        Me.ToolBar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ToolBar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderLeftWidth = 1
        Me.ToolBar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderRightWidth = 1
        Me.ToolBar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ToolBar.Style.BorderTopWidth = 1
        Me.ToolBar.Style.CornerDiameter = 4
        Me.ToolBar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ToolBar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ToolBar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ToolBar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.ToolBar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ToolBar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ToolBar.TabIndex = 10
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.DragDropSupport = True
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnNuevo, Me.cmdVisualizar, Me.btnim, Me.cmdact, Me.cmdSalir})
        Me.RibbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(346, 90)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 6
        Me.RibbonBar2.Text = "Convenios"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnNuevo.Image = Global.Administativo.My.Resources.Resources.contratos
        Me.BtnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.SubItemsExpandWidth = 14
        Me.BtnNuevo.Text = "Nuevo Convenio"
        '
        'cmdVisualizar
        '
        Me.cmdVisualizar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdVisualizar.Image = Global.Administativo.My.Resources.Resources.demo
        Me.cmdVisualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdVisualizar.Name = "cmdVisualizar"
        Me.cmdVisualizar.SubItemsExpandWidth = 14
        Me.cmdVisualizar.Text = "Visualizar"
        '
        'btnim
        '
        Me.btnim.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnim.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.btnim.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnim.Name = "btnim"
        Me.btnim.SubItemsExpandWidth = 14
        Me.btnim.Text = "Imprimir"
        Me.btnim.Visible = False
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
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.SubItemsExpandWidth = 14
        Me.cmdSalir.Text = "Cerrar"
        '
        'datConvenios
        '
        Me.datConvenios.AllowUserToAddRows = False
        Me.datConvenios.AllowUserToDeleteRows = False
        Me.datConvenios.AllowUserToOrderColumns = True
        Me.datConvenios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datConvenios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.datConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datConvenios.DefaultCellStyle = DataGridViewCellStyle1
        Me.datConvenios.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datConvenios.Location = New System.Drawing.Point(3, 102)
        Me.datConvenios.Name = "datConvenios"
        Me.datConvenios.ReadOnly = True
        Me.datConvenios.Size = New System.Drawing.Size(926, 439)
        Me.datConvenios.TabIndex = 11
        '
        'ListConvenios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 545)
        Me.Controls.Add(Me.datConvenios)
        Me.Controls.Add(Me.ToolBar)
        Me.Name = "ListConvenios"
        Me.Text = "ListConvenios"
        Me.ToolBar.ResumeLayout(False)
        CType(Me.datConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ToolBar As Controls.GroupPanel
    Private WithEvents RibbonBar2 As RibbonBar
    Private WithEvents BtnNuevo As ButtonItem
    Private WithEvents cmdVisualizar As ButtonItem
    Private WithEvents btnim As ButtonItem
    Private WithEvents cmdSalir As ButtonItem
    Friend WithEvents datConvenios As Controls.DataGridViewX
    Friend WithEvents cmdact As ButtonItem
End Class
