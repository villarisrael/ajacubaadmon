<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.ColorPickerDropDown1 = New DevComponents.DotNetBar.ColorPickerDropDown
        Me.SliderItem1 = New DevComponents.DotNetBar.SliderItem
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1, Me.ButtonItem3, Me.ColorPickerDropDown1, Me.SliderItem1})
        Me.RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(526, 68)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar1.TabIndex = 0
        Me.RibbonBar1.Text = "RibbonBar1"
        '
        'ItemContainer1
        '
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2})
        Me.ButtonItem1.Text = "ButtonItem1"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ImagePaddingHorizontal = 8
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "ButtonItem2"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ImagePaddingHorizontal = 8
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 14
        Me.ButtonItem3.Text = "ButtonItem3"
        '
        'ColorPickerDropDown1
        '
        Me.ColorPickerDropDown1.ImagePaddingHorizontal = 8
        Me.ColorPickerDropDown1.Name = "ColorPickerDropDown1"
        Me.ColorPickerDropDown1.SubItemsExpandWidth = 14
        Me.ColorPickerDropDown1.Text = "ColorPickerDropDown1"
        '
        'SliderItem1
        '
        Me.SliderItem1.Name = "SliderItem1"
        Me.SliderItem1.Text = "SliderItem1"
        Me.SliderItem1.Value = 0
        '
        'Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Tab"
        Me.Size = New System.Drawing.Size(527, 69)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ColorPickerDropDown1 As DevComponents.DotNetBar.ColorPickerDropDown
    Friend WithEvents SliderItem1 As DevComponents.DotNetBar.SliderItem

End Class
