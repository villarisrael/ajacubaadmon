<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerFiltro
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
        Me.TabOp = New DevComponents.DotNetBar.TabControl
        Me.TabCPColumnas = New DevComponents.DotNetBar.TabControlPanel
        Me.cmdFin = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdSig = New DevComponents.DotNetBar.ButtonX
        Me.cmbConsulta = New System.Windows.Forms.ListBox
        Me.cmbCol = New System.Windows.Forms.ListBox
        Me.cmdQuitT = New DevComponents.DotNetBar.ButtonX
        Me.cmdAgrT = New DevComponents.DotNetBar.ButtonX
        Me.cmdQuit = New DevComponents.DotNetBar.ButtonX
        Me.cmdAgr = New DevComponents.DotNetBar.ButtonX
        Me.tabColumnas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.cmdAnt = New DevComponents.DotNetBar.ButtonX
        Me.cmdTerminar1 = New DevComponents.DotNetBar.ButtonX
        Me.cmdSig2 = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.listFil = New System.Windows.Forms.ListBox
        Me.listBase = New System.Windows.Forms.ListBox
        Me.cmdQuitFil = New DevComponents.DotNetBar.ButtonX
        Me.cmdAgrFil = New DevComponents.DotNetBar.ButtonX
        Me.TabFiltro = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabCPOrdPor = New DevComponents.DotNetBar.TabControlPanel
        Me.cmdTerminar3 = New DevComponents.DotNetBar.ButtonX
        Me.ControlRob1 = New Administativo.ControlRob
        Me.TabOrdPor = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabOp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabOp.SuspendLayout()
        Me.TabCPColumnas.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.TabCPOrdPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabOp
        '
        Me.TabOp.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabOp.CanReorderTabs = True
        Me.TabOp.Controls.Add(Me.TabCPColumnas)
        Me.TabOp.Controls.Add(Me.TabControlPanel1)
        Me.TabOp.Controls.Add(Me.TabCPOrdPor)
        Me.TabOp.Location = New System.Drawing.Point(12, 12)
        Me.TabOp.Name = "TabOp"
        Me.TabOp.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabOp.SelectedTabIndex = 0
        Me.TabOp.Size = New System.Drawing.Size(364, 256)
        Me.TabOp.TabIndex = 0
        Me.TabOp.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabOp.Tabs.Add(Me.tabColumnas)
        Me.TabOp.Tabs.Add(Me.TabFiltro)
        Me.TabOp.Tabs.Add(Me.TabOrdPor)
        Me.TabOp.Text = "TabControl1"
        '
        'TabCPColumnas
        '
        Me.TabCPColumnas.Controls.Add(Me.cmdFin)
        Me.TabCPColumnas.Controls.Add(Me.Label1)
        Me.TabCPColumnas.Controls.Add(Me.cmdSig)
        Me.TabCPColumnas.Controls.Add(Me.cmbConsulta)
        Me.TabCPColumnas.Controls.Add(Me.cmbCol)
        Me.TabCPColumnas.Controls.Add(Me.cmdQuitT)
        Me.TabCPColumnas.Controls.Add(Me.cmdAgrT)
        Me.TabCPColumnas.Controls.Add(Me.cmdQuit)
        Me.TabCPColumnas.Controls.Add(Me.cmdAgr)
        Me.TabCPColumnas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCPColumnas.Location = New System.Drawing.Point(0, 26)
        Me.TabCPColumnas.Name = "TabCPColumnas"
        Me.TabCPColumnas.Padding = New System.Windows.Forms.Padding(1)
        Me.TabCPColumnas.Size = New System.Drawing.Size(364, 230)
        Me.TabCPColumnas.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabCPColumnas.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabCPColumnas.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabCPColumnas.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabCPColumnas.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabCPColumnas.Style.GradientAngle = 90
        Me.TabCPColumnas.TabIndex = 1
        Me.TabCPColumnas.TabItem = Me.tabColumnas
        '
        'cmdFin
        '
        Me.cmdFin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdFin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdFin.Location = New System.Drawing.Point(226, 194)
        Me.cmdFin.Name = "cmdFin"
        Me.cmdFin.Size = New System.Drawing.Size(75, 23)
        Me.cmdFin.TabIndex = 12
        Me.cmdFin.Text = "Terminar"
        Me.cmdFin.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(40, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Seleccione los campos que contrendrá la consulta"
        '
        'cmdSig
        '
        Me.cmdSig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSig.Location = New System.Drawing.Point(135, 194)
        Me.cmdSig.Name = "cmdSig"
        Me.cmdSig.Size = New System.Drawing.Size(75, 23)
        Me.cmdSig.TabIndex = 8
        Me.cmdSig.Text = "Siguiente"
        '
        'cmbConsulta
        '
        Me.cmbConsulta.FormattingEnabled = True
        Me.cmbConsulta.Location = New System.Drawing.Point(200, 30)
        Me.cmbConsulta.Name = "cmbConsulta"
        Me.cmbConsulta.Size = New System.Drawing.Size(130, 147)
        Me.cmbConsulta.TabIndex = 7
        '
        'cmbCol
        '
        Me.cmbCol.FormattingEnabled = True
        Me.cmbCol.Location = New System.Drawing.Point(25, 30)
        Me.cmbCol.Name = "cmbCol"
        Me.cmbCol.Size = New System.Drawing.Size(130, 147)
        Me.cmbCol.TabIndex = 6
        '
        'cmdQuitT
        '
        Me.cmdQuitT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdQuitT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdQuitT.Image = Global.Administativo.My.Resources.Resources._2leftarrow
        Me.cmdQuitT.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdQuitT.Location = New System.Drawing.Point(161, 153)
        Me.cmdQuitT.Name = "cmdQuitT"
        Me.cmdQuitT.Size = New System.Drawing.Size(33, 24)
        Me.cmdQuitT.TabIndex = 5
        '
        'cmdAgrT
        '
        Me.cmdAgrT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAgrT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAgrT.Image = Global.Administativo.My.Resources.Resources._2rightarrow
        Me.cmdAgrT.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdAgrT.Location = New System.Drawing.Point(161, 120)
        Me.cmdAgrT.Name = "cmdAgrT"
        Me.cmdAgrT.Size = New System.Drawing.Size(33, 24)
        Me.cmdAgrT.TabIndex = 4
        '
        'cmdQuit
        '
        Me.cmdQuit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdQuit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdQuit.Image = Global.Administativo.My.Resources.Resources._1leftarrow
        Me.cmdQuit.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdQuit.Location = New System.Drawing.Point(161, 85)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(33, 24)
        Me.cmdQuit.TabIndex = 3
        '
        'cmdAgr
        '
        Me.cmdAgr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAgr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAgr.Image = Global.Administativo.My.Resources.Resources._1rightarrow
        Me.cmdAgr.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdAgr.Location = New System.Drawing.Point(161, 50)
        Me.cmdAgr.Name = "cmdAgr"
        Me.cmdAgr.Size = New System.Drawing.Size(33, 24)
        Me.cmdAgr.TabIndex = 2
        '
        'tabColumnas
        '
        Me.tabColumnas.AttachedControl = Me.TabCPColumnas
        Me.tabColumnas.Name = "tabColumnas"
        Me.tabColumnas.Text = "Columnas"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.cmdAnt)
        Me.TabControlPanel1.Controls.Add(Me.cmdTerminar1)
        Me.TabControlPanel1.Controls.Add(Me.cmdSig2)
        Me.TabControlPanel1.Controls.Add(Me.Label2)
        Me.TabControlPanel1.Controls.Add(Me.listFil)
        Me.TabControlPanel1.Controls.Add(Me.listBase)
        Me.TabControlPanel1.Controls.Add(Me.cmdQuitFil)
        Me.TabControlPanel1.Controls.Add(Me.cmdAgrFil)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(364, 230)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 3
        Me.TabControlPanel1.TabItem = Me.TabFiltro
        '
        'cmdAnt
        '
        Me.cmdAnt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAnt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAnt.Location = New System.Drawing.Point(45, 194)
        Me.cmdAnt.Name = "cmdAnt"
        Me.cmdAnt.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnt.TabIndex = 17
        Me.cmdAnt.Text = "Anterior"
        '
        'cmdTerminar1
        '
        Me.cmdTerminar1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdTerminar1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdTerminar1.Location = New System.Drawing.Point(226, 194)
        Me.cmdTerminar1.Name = "cmdTerminar1"
        Me.cmdTerminar1.Size = New System.Drawing.Size(75, 23)
        Me.cmdTerminar1.TabIndex = 14
        Me.cmdTerminar1.Text = "Terminar"
        Me.cmdTerminar1.Visible = False
        '
        'cmdSig2
        '
        Me.cmdSig2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSig2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSig2.Location = New System.Drawing.Point(135, 194)
        Me.cmdSig2.Name = "cmdSig2"
        Me.cmdSig2.Size = New System.Drawing.Size(75, 23)
        Me.cmdSig2.TabIndex = 13
        Me.cmdSig2.Text = "Siguiente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(42, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Agregue los filtros"
        '
        'listFil
        '
        Me.listFil.FormattingEnabled = True
        Me.listFil.Location = New System.Drawing.Point(202, 31)
        Me.listFil.Name = "listFil"
        Me.listFil.Size = New System.Drawing.Size(130, 147)
        Me.listFil.TabIndex = 15
        '
        'listBase
        '
        Me.listBase.FormattingEnabled = True
        Me.listBase.Location = New System.Drawing.Point(27, 31)
        Me.listBase.Name = "listBase"
        Me.listBase.Size = New System.Drawing.Size(130, 147)
        Me.listBase.TabIndex = 14
        '
        'cmdQuitFil
        '
        Me.cmdQuitFil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdQuitFil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdQuitFil.Image = Global.Administativo.My.Resources.Resources._1leftarrow
        Me.cmdQuitFil.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdQuitFil.Location = New System.Drawing.Point(163, 107)
        Me.cmdQuitFil.Name = "cmdQuitFil"
        Me.cmdQuitFil.Size = New System.Drawing.Size(33, 24)
        Me.cmdQuitFil.TabIndex = 11
        '
        'cmdAgrFil
        '
        Me.cmdAgrFil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAgrFil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAgrFil.Image = Global.Administativo.My.Resources.Resources._1rightarrow
        Me.cmdAgrFil.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cmdAgrFil.Location = New System.Drawing.Point(163, 72)
        Me.cmdAgrFil.Name = "cmdAgrFil"
        Me.cmdAgrFil.Size = New System.Drawing.Size(33, 24)
        Me.cmdAgrFil.TabIndex = 10
        '
        'TabFiltro
        '
        Me.TabFiltro.AttachedControl = Me.TabControlPanel1
        Me.TabFiltro.Name = "TabFiltro"
        Me.TabFiltro.Text = "Filtrar"
        '
        'TabCPOrdPor
        '
        Me.TabCPOrdPor.Controls.Add(Me.cmdTerminar3)
        Me.TabCPOrdPor.Controls.Add(Me.ControlRob1)
        Me.TabCPOrdPor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCPOrdPor.Location = New System.Drawing.Point(0, 26)
        Me.TabCPOrdPor.Name = "TabCPOrdPor"
        Me.TabCPOrdPor.Padding = New System.Windows.Forms.Padding(1)
        Me.TabCPOrdPor.Size = New System.Drawing.Size(364, 230)
        Me.TabCPOrdPor.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabCPOrdPor.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabCPOrdPor.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabCPOrdPor.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabCPOrdPor.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabCPOrdPor.Style.GradientAngle = 90
        Me.TabCPOrdPor.TabIndex = 2
        Me.TabCPOrdPor.TabItem = Me.TabOrdPor
        '
        'cmdTerminar3
        '
        Me.cmdTerminar3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdTerminar3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdTerminar3.Location = New System.Drawing.Point(227, 197)
        Me.cmdTerminar3.Name = "cmdTerminar3"
        Me.cmdTerminar3.Size = New System.Drawing.Size(75, 23)
        Me.cmdTerminar3.TabIndex = 13
        Me.cmdTerminar3.Text = "Terminar"
        '
        'ControlRob1
        '
        Me.ControlRob1.BackColor = System.Drawing.Color.Transparent
        Me.ControlRob1.Location = New System.Drawing.Point(3, -4)
        Me.ControlRob1.Name = "ControlRob1"
        Me.ControlRob1.Size = New System.Drawing.Size(357, 234)
        Me.ControlRob1.TabIndex = 0
        '
        'TabOrdPor
        '
        Me.TabOrdPor.AttachedControl = Me.TabCPOrdPor
        Me.TabOrdPor.Name = "TabOrdPor"
        Me.TabOrdPor.Text = "Ordenar por "
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabCPColumnas
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Columnas"
        '
        'frmPerFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 280)
        Me.Controls.Add(Me.TabOp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmPerFiltro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro personalizado"
        CType(Me.TabOp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabOp.ResumeLayout(False)
        Me.TabCPColumnas.ResumeLayout(False)
        Me.TabCPColumnas.PerformLayout()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.TabCPOrdPor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabOp As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabCPColumnas As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabColumnas As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabCPOrdPor As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabOrdPor As DevComponents.DotNetBar.TabItem
    Friend WithEvents cmdAgr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdQuit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdQuitT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbCol As System.Windows.Forms.ListBox
    Friend WithEvents cmbConsulta As System.Windows.Forms.ListBox
    Friend WithEvents cmdSig As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ControlRob1 As Administativo.ControlRob
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabFiltro As DevComponents.DotNetBar.TabItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listFil As System.Windows.Forms.ListBox
    Friend WithEvents listBase As System.Windows.Forms.ListBox
    Friend WithEvents cmdQuitFil As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAgrFil As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents cmdTerminar3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdFin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAgrT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAnt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdTerminar1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdSig2 As DevComponents.DotNetBar.ButtonX
End Class
