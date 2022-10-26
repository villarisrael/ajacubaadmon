<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeCna
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
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Anofinal = New DevComponents.Editors.IntegerInput()
        Me.mesfinal = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.ComboItem21 = New DevComponents.Editors.ComboItem()
        Me.ComboItem22 = New DevComponents.Editors.ComboItem()
        Me.ComboItem23 = New DevComponents.Editors.ComboItem()
        Me.ComboItem24 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        CType(Me.Anofinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.Location = New System.Drawing.Point(230, 146)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(144, 39)
        Me.cmdSalir.TabIndex = 48
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(81, 146)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.Size = New System.Drawing.Size(135, 39)
        Me.cmdImp.TabIndex = 47
        Me.cmdImp.Text = "Imprimir"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(59, 23)
        Me.LabelX2.TabIndex = 13
        Me.LabelX2.Text = "Mes "
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(221, 21)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(41, 10)
        Me.LabelX4.TabIndex = 15
        Me.LabelX4.Text = "Año"
        '
        'Anofinal
        '
        '
        '
        '
        Me.Anofinal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Anofinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Anofinal.FocusHighlightEnabled = True
        Me.Anofinal.Location = New System.Drawing.Point(268, 17)
        Me.Anofinal.Name = "Anofinal"
        Me.Anofinal.ShowUpDown = True
        Me.Anofinal.Size = New System.Drawing.Size(60, 20)
        Me.Anofinal.TabIndex = 17
        '
        'mesfinal
        '
        Me.mesfinal.DisplayMember = "Text"
        Me.mesfinal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mesfinal.FocusHighlightEnabled = True
        Me.mesfinal.FormattingEnabled = True
        Me.mesfinal.ItemHeight = 14
        Me.mesfinal.Items.AddRange(New Object() {Me.ComboItem13, Me.ComboItem14, Me.ComboItem15, Me.ComboItem16, Me.ComboItem17, Me.ComboItem18, Me.ComboItem19, Me.ComboItem20, Me.ComboItem21, Me.ComboItem22, Me.ComboItem23, Me.ComboItem24})
        Me.mesfinal.Location = New System.Drawing.Point(106, 14)
        Me.mesfinal.Name = "mesfinal"
        Me.mesfinal.Size = New System.Drawing.Size(75, 20)
        Me.mesfinal.TabIndex = 18
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "ENE"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "FEB"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "MAR"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "ABR"
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "MAY"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "JUN"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "JUL"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "AGO"
        '
        'ComboItem21
        '
        Me.ComboItem21.Text = "SEP"
        '
        'ComboItem22
        '
        Me.ComboItem22.Text = "OCT"
        '
        'ComboItem23
        '
        Me.ComboItem23.Text = "NOV"
        '
        'ComboItem24
        '
        Me.ComboItem24.Text = "DIC"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.mesfinal)
        Me.GroupPanel1.Controls.Add(Me.Anofinal)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(354, 76)
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
        Me.GroupPanel1.TabIndex = 49
        Me.GroupPanel1.Text = "Periodo"
        '
        'InformeCna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 215)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdImp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "InformeCna"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Estadistico para la CNA"
        CType(Me.Anofinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Anofinal As DevComponents.Editors.IntegerInput
    Friend WithEvents mesfinal As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem21 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem22 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem23 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem24 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
