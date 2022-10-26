<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepCont1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepCont1))
        Me.cmbTipUsu = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.chkAmb = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chkMed = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chkFig = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX
        Me.cmdCan = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTipUsu
        '
        Me.cmbTipUsu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipUsu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipUsu.DisplayMember = "Text"
        Me.cmbTipUsu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipUsu.FocusHighlightEnabled = True
        Me.cmbTipUsu.FormattingEnabled = True
        Me.cmbTipUsu.ItemHeight = 14
        Me.cmbTipUsu.Location = New System.Drawing.Point(99, 30)
        Me.cmbTipUsu.Name = "cmbTipUsu"
        Me.cmbTipUsu.Size = New System.Drawing.Size(239, 20)
        Me.cmbTipUsu.TabIndex = 0
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(3, 28)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(90, 22)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Tipo de usuario:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.chkAmb)
        Me.GroupPanel1.Controls.Add(Me.chkMed)
        Me.GroupPanel1.Controls.Add(Me.chkFig)
        Me.GroupPanel1.Location = New System.Drawing.Point(99, 71)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(239, 114)
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
        Me.GroupPanel1.TabIndex = 2
        '
        'chkAmb
        '
        Me.chkAmb.BackColor = System.Drawing.Color.Transparent
        Me.chkAmb.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chkAmb.Location = New System.Drawing.Point(32, 79)
        Me.chkAmb.Name = "chkAmb"
        Me.chkAmb.Size = New System.Drawing.Size(125, 20)
        Me.chkAmb.TabIndex = 2
        Me.chkAmb.Text = "Ambos"
        '
        'chkMed
        '
        Me.chkMed.BackColor = System.Drawing.Color.Transparent
        Me.chkMed.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chkMed.Location = New System.Drawing.Point(32, 47)
        Me.chkMed.Name = "chkMed"
        Me.chkMed.Size = New System.Drawing.Size(125, 20)
        Me.chkMed.TabIndex = 1
        Me.chkMed.Text = "Medidos"
        '
        'chkFig
        '
        Me.chkFig.BackColor = System.Drawing.Color.Transparent
        Me.chkFig.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chkFig.Location = New System.Drawing.Point(32, 15)
        Me.chkFig.Name = "chkFig"
        Me.chkFig.Size = New System.Drawing.Size(125, 20)
        Me.chkFig.TabIndex = 0
        Me.chkFig.Text = "Fijos"
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(99, 201)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.PulseSpeed = 30
        Me.cmdImp.Size = New System.Drawing.Size(108, 36)
        Me.cmdImp.TabIndex = 3
        Me.cmdImp.Text = "Imprimir"
        '
        'cmdCan
        '
        Me.cmdCan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCan.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdCan.Location = New System.Drawing.Point(230, 201)
        Me.cmdCan.Name = "cmdCan"
        Me.cmdCan.PulseSpeed = 30
        Me.cmdCan.Size = New System.Drawing.Size(108, 36)
        Me.cmdCan.TabIndex = 4
        Me.cmdCan.Text = "Salir"
        '
        'frmRepCont1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 249)
        Me.Controls.Add(Me.cmdCan)
        Me.Controls.Add(Me.cmdImp)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cmbTipUsu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmRepCont1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de conteo"
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbTipUsu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents chkAmb As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkMed As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkFig As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCan As DevComponents.DotNetBar.ButtonX
End Class
