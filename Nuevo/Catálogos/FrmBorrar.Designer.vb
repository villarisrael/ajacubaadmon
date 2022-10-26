<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBorrame
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
        Me.RibbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.ColorPickerDropDown1 = New DevComponents.DotNetBar.ColorPickerDropDown
        Me.SliderItem1 = New DevComponents.DotNetBar.SliderItem
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer
        Me.RibbonBarMergeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBarMergeContainer1
        '
        Me.RibbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBarMergeContainer1.Controls.Add(Me.RibbonBar1)
        Me.RibbonBarMergeContainer1.Location = New System.Drawing.Point(41, 88)
        Me.RibbonBarMergeContainer1.Name = "RibbonBarMergeContainer1"
        Me.RibbonBarMergeContainer1.Size = New System.Drawing.Size(373, 61)
        Me.RibbonBarMergeContainer1.TabIndex = 0
        Me.RibbonBarMergeContainer1.Visible = False
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ColorPickerDropDown1, Me.SliderItem1, Me.GalleryContainer1})
        Me.RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 3)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(370, 51)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar1.TabIndex = 0
        Me.RibbonBar1.Text = "RibbonBar1"
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
        'GalleryContainer1
        '
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(58, 58)
        Me.GalleryContainer1.Name = "GalleryContainer1"
        '
        'FrmBorrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 422)
        Me.Controls.Add(Me.RibbonBarMergeContainer1)
        Me.Name = "FrmBorrar"
        Me.Text = "FrmBorrar"
        Me.RibbonBarMergeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonBarMergeContainer1 As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ColorPickerDropDown1 As DevComponents.DotNetBar.ColorPickerDropDown
    Friend WithEvents SliderItem1 As DevComponents.DotNetBar.SliderItem
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
End Class
