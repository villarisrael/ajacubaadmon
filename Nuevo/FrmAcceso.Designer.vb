<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcceso))
        Me.TxtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblUser = New DevComponents.DotNetBar.LabelX()
        Me.LblPwd = New DevComponents.DotNetBar.LabelX()
        Me.TxtPwd = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.Lbrfc = New DevComponents.DotNetBar.LabelX()
        Me.Lbsiglas = New DevComponents.DotNetBar.LabelX()
        Me.Lbnombre = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtUsuario
        '
        '
        '
        '
        Me.TxtUsuario.Border.Class = "TextBoxBorder"
        Me.TxtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtUsuario.FocusHighlightEnabled = True
        Me.TxtUsuario.Location = New System.Drawing.Point(130, 11)
        Me.TxtUsuario.MaxLength = 10
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(89, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'LblUser
        '
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblUser.Location = New System.Drawing.Point(52, 11)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(75, 23)
        Me.LblUser.TabIndex = 0
        Me.LblUser.Text = "Usuario"
        '
        'LblPwd
        '
        Me.LblPwd.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblPwd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblPwd.Location = New System.Drawing.Point(52, 40)
        Me.LblPwd.Name = "LblPwd"
        Me.LblPwd.Size = New System.Drawing.Size(75, 23)
        Me.LblPwd.TabIndex = 2
        Me.LblPwd.Text = "Password"
        '
        'TxtPwd
        '
        '
        '
        '
        Me.TxtPwd.Border.Class = "TextBoxBorder"
        Me.TxtPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtPwd.FocusHighlightEnabled = True
        Me.TxtPwd.Location = New System.Drawing.Point(130, 40)
        Me.TxtPwd.MaxLength = 10
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwd.Size = New System.Drawing.Size(89, 20)
        Me.TxtPwd.TabIndex = 3
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(153, 270)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 46)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(48, 270)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(87, 46)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TxtPwd)
        Me.GroupPanel1.Controls.Add(Me.TxtUsuario)
        Me.GroupPanel1.Controls.Add(Me.LblUser)
        Me.GroupPanel1.Controls.Add(Me.LblPwd)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 191)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(281, 73)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 6
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.ReflectionImage1)
        Me.GroupPanel2.Controls.Add(Me.Lbrfc)
        Me.GroupPanel2.Controls.Add(Me.Lbsiglas)
        Me.GroupPanel2.Controls.Add(Me.Lbnombre)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(14, 8)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(294, 165)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 7
        '
        'ReflectionImage1
        '
        Me.ReflectionImage1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ReflectionImage1.Location = New System.Drawing.Point(-5, -20)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(296, 105)
        Me.ReflectionImage1.TabIndex = 8
        '
        'Lbrfc
        '
        Me.Lbrfc.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.Lbrfc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbrfc.Location = New System.Drawing.Point(3, 141)
        Me.Lbrfc.Name = "Lbrfc"
        Me.Lbrfc.Size = New System.Drawing.Size(282, 18)
        Me.Lbrfc.TabIndex = 7
        Me.Lbrfc.Text = "rfc"
        Me.Lbrfc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Lbsiglas
        '
        Me.Lbsiglas.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.Lbsiglas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbsiglas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbsiglas.ForeColor = System.Drawing.Color.SeaGreen
        Me.Lbsiglas.Location = New System.Drawing.Point(2, 107)
        Me.Lbsiglas.Name = "Lbsiglas"
        Me.Lbsiglas.Size = New System.Drawing.Size(282, 24)
        Me.Lbsiglas.TabIndex = 6
        Me.Lbsiglas.Text = "siglas"
        Me.Lbsiglas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Lbnombre
        '
        Me.Lbnombre.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.Lbnombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnombre.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Lbnombre.Location = New System.Drawing.Point(3, 123)
        Me.Lbnombre.Name = "Lbnombre"
        Me.Lbnombre.Size = New System.Drawing.Size(282, 25)
        Me.Lbnombre.TabIndex = 5
        Me.Lbnombre.Text = "nombre"
        Me.Lbnombre.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(10, 91)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(266, 18)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Con licencia para:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(3, 48)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(266, 18)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Modo: Intranet"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(10, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(266, 37)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Acqua Liber "
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(320, 325)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.TopRightCornerSize = 15
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblUser As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblPwd As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtPwd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbnombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbsiglas As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbrfc As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
