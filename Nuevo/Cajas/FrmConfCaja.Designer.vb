<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfCaja
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
        Me.TxtRuta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog
        Me.BtnBuscar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnBase = New DevComponents.DotNetBar.ButtonX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.TxtBase = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.BtnActualizar = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'TxtRuta
        '
        '
        '
        '
        Me.TxtRuta.Border.Class = "TextBoxBorder"
        Me.TxtRuta.Location = New System.Drawing.Point(27, 42)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(485, 20)
        Me.TxtRuta.TabIndex = 0
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(27, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(239, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Selecciona la ruta de los Archivos Temporales:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBuscar.Location = New System.Drawing.Point(518, 42)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Seleccionar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Location = New System.Drawing.Point(518, 71)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 39)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Guardar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.Location = New System.Drawing.Point(518, 306)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 68)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Salir"
        '
        'BtnBase
        '
        Me.BtnBase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBase.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBase.Location = New System.Drawing.Point(518, 172)
        Me.BtnBase.Name = "BtnBase"
        Me.BtnBase.Size = New System.Drawing.Size(75, 23)
        Me.BtnBase.TabIndex = 7
        Me.BtnBase.Text = "Seleccionar"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(27, 142)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(239, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Selecciona la ruta de la base de datos:"
        '
        'TxtBase
        '
        '
        '
        '
        Me.TxtBase.Border.Class = "TextBoxBorder"
        Me.TxtBase.Location = New System.Drawing.Point(27, 172)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(485, 20)
        Me.TxtBase.TabIndex = 5
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnActualizar.Location = New System.Drawing.Point(518, 201)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 39)
        Me.BtnActualizar.TabIndex = 8
        Me.BtnActualizar.Text = "Actualizar"
        '
        'FrmConfCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 386)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnBase)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.TxtBase)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.TxtRuta)
        Me.Name = "FrmConfCaja"
        Me.Text = "Configurar caja"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtRuta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BtnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnBase As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBase As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnActualizar As DevComponents.DotNetBar.ButtonX
End Class
