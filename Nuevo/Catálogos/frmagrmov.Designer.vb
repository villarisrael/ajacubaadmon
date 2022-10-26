<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagrmov
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
        Me.lblfoliodecontrato = New DevComponents.DotNetBar.LabelX
        Me.LBLNOMBRE = New DevComponents.DotNetBar.LabelX
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle
        Me.Txtidconcepto = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.Txtconcepto = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtdetalle = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.txtmonto = New DevComponents.Editors.IntegerInput
        Me.lbltipomov = New DevComponents.DotNetBar.LabelX
        Me.btnok = New DevComponents.DotNetBar.ButtonX
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfoliodecontrato
        '
        Me.lblfoliodecontrato.Location = New System.Drawing.Point(29, 54)
        Me.lblfoliodecontrato.Name = "lblfoliodecontrato"
        Me.lblfoliodecontrato.Size = New System.Drawing.Size(100, 18)
        Me.lblfoliodecontrato.TabIndex = 0
        Me.lblfoliodecontrato.Text = "lblfoliodecontrato"
        '
        'LBLNOMBRE
        '
        Me.LBLNOMBRE.Location = New System.Drawing.Point(29, 84)
        Me.LBLNOMBRE.Name = "LBLNOMBRE"
        Me.LBLNOMBRE.Size = New System.Drawing.Size(329, 23)
        Me.LBLNOMBRE.TabIndex = 1
        Me.LBLNOMBRE.Text = "lblnombre"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.AdvTree1)
        Me.ExpandablePanel1.Location = New System.Drawing.Point(364, 3)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(295, 397)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 2
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Conceptos"
        '
        'AdvTree1
        '
        Me.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree1.AllowDrop = True
        Me.AdvTree1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvTree1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.AdvTree1.Location = New System.Drawing.Point(3, 25)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(289, 369)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.SuspendPaint = False
        Me.AdvTree1.TabIndex = 2
        Me.AdvTree1.Text = "AdvTree1"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle1
        '
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'Txtidconcepto
        '
        Me.Txtidconcepto.AllowDrop = True
        '
        '
        '
        Me.Txtidconcepto.Border.Class = "TextBoxBorder"
        Me.Txtidconcepto.Location = New System.Drawing.Point(130, 119)
        Me.Txtidconcepto.Name = "Txtidconcepto"
        Me.Txtidconcepto.Size = New System.Drawing.Size(55, 20)
        Me.Txtidconcepto.TabIndex = 3
        Me.Txtidconcepto.WatermarkText = "ID del concepto"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(29, 119)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(81, 17)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Id concepto"
        '
        'Txtconcepto
        '
        Me.Txtconcepto.AllowDrop = True
        '
        '
        '
        Me.Txtconcepto.Border.Class = "TextBoxBorder"
        Me.Txtconcepto.Location = New System.Drawing.Point(130, 149)
        Me.Txtconcepto.Name = "Txtconcepto"
        Me.Txtconcepto.Size = New System.Drawing.Size(231, 20)
        Me.Txtconcepto.TabIndex = 5
        Me.Txtconcepto.WatermarkText = "Concepto del movimiento"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(29, 148)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(64, 20)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Concepto"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(29, 28)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(50, 14)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Fecha"
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(90, 28)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(95, 20)
        Me.DTPicker1.TabIndex = 8
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(29, 210)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(76, 24)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "Motivo"
        '
        'txtdetalle
        '
        '
        '
        '
        Me.txtdetalle.Border.Class = "TextBoxBorder"
        Me.txtdetalle.Location = New System.Drawing.Point(29, 246)
        Me.txtdetalle.MaxLength = 100
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(329, 20)
        Me.txtdetalle.TabIndex = 10
        Me.txtdetalle.WatermarkText = "Escribe el motivo detallado, solo sí es necesario"
        '
        'LabelX5
        '
        Me.LabelX5.Location = New System.Drawing.Point(33, 278)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(77, 15)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Monto $"
        '
        'txtmonto
        '
        Me.txtmonto.AntiAlias = True
        '
        '
        '
        Me.txtmonto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtmonto.Location = New System.Drawing.Point(127, 278)
        Me.txtmonto.MinValue = 0
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.ShowUpDown = True
        Me.txtmonto.Size = New System.Drawing.Size(73, 20)
        Me.txtmonto.TabIndex = 12
        '
        'lbltipomov
        '
        Me.lbltipomov.Location = New System.Drawing.Point(29, 180)
        Me.lbltipomov.Name = "lbltipomov"
        Me.lbltipomov.Size = New System.Drawing.Size(55, 18)
        Me.lbltipomov.TabIndex = 13
        '
        'btnok
        '
        Me.btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnok.Location = New System.Drawing.Point(33, 325)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(118, 29)
        Me.btnok.TabIndex = 14
        Me.btnok.Text = "Ok"
        '
        'frmagrmov
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 399)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.lbltipomov)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.DTPicker1)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.Txtconcepto)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Txtidconcepto)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.LBLNOMBRE)
        Me.Controls.Add(Me.lblfoliodecontrato)
        Me.Name = "frmagrmov"
        Me.Text = "Agregar Movimiento a usuario"
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblfoliodecontrato As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBLNOMBRE As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents Txtidconcepto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txtconcepto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtmonto As DevComponents.Editors.IntegerInput
    Friend WithEvents lbltipomov As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnok As DevComponents.DotNetBar.ButtonX
End Class
