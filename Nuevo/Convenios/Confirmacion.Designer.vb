Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Confirmacion
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TxtPwd = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LblUser = New DevComponents.DotNetBar.LabelX()
        Me.LblPwd = New DevComponents.DotNetBar.LabelX()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 41)
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
        Me.GroupPanel1.TabIndex = 9
        '
        'TxtPwd
        '
        '
        '
        '
        Me.TxtPwd.Border.Class = "TextBoxBorder"
        Me.TxtPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtPwd.FocusHighlightEnabled = True
        Me.TxtPwd.Location = New System.Drawing.Point(130, 35)
        Me.TxtPwd.MaxLength = 10
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwd.Size = New System.Drawing.Size(89, 20)
        Me.TxtPwd.TabIndex = 3
        '
        'TxtUsuario
        '
        '
        '
        '
        Me.TxtUsuario.Border.Class = "TextBoxBorder"
        Me.TxtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtUsuario.FocusHighlightEnabled = True
        Me.TxtUsuario.Location = New System.Drawing.Point(130, 6)
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
        Me.LblUser.Location = New System.Drawing.Point(52, 6)
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
        Me.LblPwd.Location = New System.Drawing.Point(52, 35)
        Me.LblPwd.Name = "LblPwd"
        Me.LblPwd.Size = New System.Drawing.Size(75, 23)
        Me.LblPwd.TabIndex = 2
        Me.LblPwd.Text = "Password"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.CancelarEdicion
        Me.BtnCancelar.Location = New System.Drawing.Point(153, 133)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 46)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(48, 133)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(87, 46)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Autorizado por:"
        '
        'Confirmacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(307, 187)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Name = "Confirmacion"
        Me.Text = "Confirmacion"
        Me.TopMost = True
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As Controls.GroupPanel
    Friend WithEvents TxtPwd As Controls.TextBoxX
    Friend WithEvents TxtUsuario As Controls.TextBoxX
    Friend WithEvents LblUser As LabelX
    Friend WithEvents LblPwd As LabelX
    Friend WithEvents BtnCancelar As ButtonX
    Friend WithEvents BtnAceptar As ButtonX
    Friend WithEvents LabelX1 As LabelX
End Class
