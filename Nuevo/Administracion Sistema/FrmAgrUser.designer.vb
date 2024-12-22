<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgrUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgrUser))
        Me.LblNombre = New DevComponents.DotNetBar.LabelX()
        Me.TxtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtUsername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblUsername = New DevComponents.DotNetBar.LabelX()
        Me.TxtPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.Mapa = New DevComponents.AdvTree.AdvTree()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.ChkStatus = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.BtnHabilitar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnDeshabilitar = New DevComponents.DotNetBar.ButtonX()
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader()
        CType(Me.Mapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        '
        '
        '
        Me.LblNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblNombre.Location = New System.Drawing.Point(45, 12)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(58, 18)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        '
        '
        '
        Me.TxtNombre.Border.Class = "TextBoxBorder"
        Me.TxtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.FocusHighlightEnabled = True
        Me.TxtNombre.Location = New System.Drawing.Point(109, 10)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(396, 20)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.WatermarkText = "Escribe el nombre del usuario"
        '
        'TxtUsername
        '
        '
        '
        '
        Me.TxtUsername.Border.Class = "TextBoxBorder"
        Me.TxtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtUsername.FocusHighlightEnabled = True
        Me.TxtUsername.Location = New System.Drawing.Point(109, 40)
        Me.TxtUsername.MaxLength = 10
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(248, 20)
        Me.TxtUsername.TabIndex = 1
        Me.TxtUsername.WatermarkText = "Escribe el username o nombre corto del usuario "
        '
        'LblUsername
        '
        '
        '
        '
        Me.LblUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblUsername.Location = New System.Drawing.Point(45, 42)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(58, 18)
        Me.LblUsername.TabIndex = 2
        Me.LblUsername.Text = "Username"
        '
        'TxtPass
        '
        '
        '
        '
        Me.TxtPass.Border.Class = "TextBoxBorder"
        Me.TxtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtPass.FocusHighlightEnabled = True
        Me.TxtPass.Location = New System.Drawing.Point(109, 68)
        Me.TxtPass.MaxLength = 10
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(248, 20)
        Me.TxtPass.TabIndex = 2
        Me.TxtPass.WatermarkText = "Escribe el Password del usuario"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(45, 70)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(58, 18)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Password"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(395, 448)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.PulseSpeed = 30
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 46)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(279, 448)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.PulseSpeed = 30
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 46)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "Aceptar"
        '
        'Mapa
        '
        Me.Mapa.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.Mapa.AllowDrop = True
        Me.Mapa.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Mapa.BackgroundStyle.Class = "TreeBorderKey"
        Me.Mapa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Mapa.Columns.Add(Me.ColumnHeader1)
        Me.Mapa.Columns.Add(Me.ColumnHeader2)
        Me.Mapa.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Mapa.Location = New System.Drawing.Point(44, 140)
        Me.Mapa.Name = "Mapa"
        Me.Mapa.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
        Me.Mapa.NodesConnector = Me.NodeConnector1
        Me.Mapa.NodeStyle = Me.ElementStyle1
        Me.Mapa.PathSeparator = ";"
        Me.Mapa.Size = New System.Drawing.Size(460, 302)
        Me.Mapa.Styles.Add(Me.ElementStyle1)
        Me.Mapa.TabIndex = 5
        Me.Mapa.Text = "AdvTree1"
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Name = "Node1"
        Me.Node1.Text = "Node1"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle1
        '
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'ChkStatus
        '
        '
        '
        '
        Me.ChkStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkStatus.Checked = True
        Me.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStatus.CheckValue = "Y"
        Me.ChkStatus.Location = New System.Drawing.Point(44, 94)
        Me.ChkStatus.Name = "ChkStatus"
        Me.ChkStatus.Size = New System.Drawing.Size(71, 19)
        Me.ChkStatus.TabIndex = 12
        Me.ChkStatus.Text = "Activo"
        '
        'BtnHabilitar
        '
        Me.BtnHabilitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnHabilitar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnHabilitar.Location = New System.Drawing.Point(45, 119)
        Me.BtnHabilitar.Name = "BtnHabilitar"
        Me.BtnHabilitar.Size = New System.Drawing.Size(117, 17)
        Me.BtnHabilitar.TabIndex = 3
        Me.BtnHabilitar.Text = "Habilitar Todo"
        '
        'BtnDeshabilitar
        '
        Me.BtnDeshabilitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeshabilitar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDeshabilitar.Location = New System.Drawing.Point(168, 119)
        Me.BtnDeshabilitar.Name = "BtnDeshabilitar"
        Me.BtnDeshabilitar.Size = New System.Drawing.Size(117, 17)
        Me.BtnDeshabilitar.TabIndex = 4
        Me.BtnDeshabilitar.Text = "Deshabilitar Todo"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Control"
        Me.ColumnHeader1.Width.Absolute = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Name = "ColumnHeader2"
        Me.ColumnHeader2.Text = "Permiso"
        Me.ColumnHeader2.Width.Absolute = 50
        '
        'FrmAgrUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 506)
        Me.Controls.Add(Me.BtnDeshabilitar)
        Me.Controls.Add(Me.BtnHabilitar)
        Me.Controls.Add(Me.ChkStatus)
        Me.Controls.Add(Me.Mapa)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgrUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.Mapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblNombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtUsername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblUsername As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Mapa As DevComponents.AdvTree.AdvTree
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ChkStatus As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents BtnHabilitar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeshabilitar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
End Class
