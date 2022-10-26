<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfactibilidad
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
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer
        Me.btnaceptar = New DevComponents.DotNetBar.ButtonItem
        Me.btnimprimir = New DevComponents.DotNetBar.ButtonItem
        Me.btnsalir = New DevComponents.DotNetBar.ButtonItem
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.Bar1.Location = New System.Drawing.Point(0, 3)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(299, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Bar1.TabIndex = 8
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ItemContainer1
        '
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2})
        '
        'ItemContainer2
        '
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnaceptar, Me.btnimprimir, Me.btnsalir})
        '
        'btnaceptar
        '
        Me.btnaceptar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnaceptar.Image = Global.WindowsApplication1.My.Resources.Resources.yast_HD
        Me.btnaceptar.ImagePaddingHorizontal = 8
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Text = "Aceptar"
        '
        'btnimprimir
        '
        Me.btnimprimir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnimprimir.Image = Global.WindowsApplication1.My.Resources.Resources.yast_printer2
        Me.btnimprimir.ImagePaddingHorizontal = 8
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Text = "Imprimir"
        '
        'btnsalir
        '
        Me.btnsalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnsalir.Image = Global.WindowsApplication1.My.Resources.Resources._error
        Me.btnsalir.ImagePaddingHorizontal = 8
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Text = "Cerrar"
        '
        'frmfactibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 388)
        Me.Controls.Add(Me.Bar1)
        Me.Name = "frmfactibilidad"
        Me.Text = "Form1"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnaceptar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnimprimir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnsalir As DevComponents.DotNetBar.ButtonItem
End Class
