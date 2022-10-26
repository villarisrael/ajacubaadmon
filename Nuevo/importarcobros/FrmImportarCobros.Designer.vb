<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportarCobros
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
        Me.TxtRuta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BtnSeleccionar = New DevComponents.DotNetBar.ButtonX()
        Me.LblCopiar = New DevComponents.DotNetBar.LabelX()
        Me.BtnCopiar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.PG = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'TxtRuta
        '
        '
        '
        '
        Me.TxtRuta.Border.Class = "TextBoxBorder"
        Me.TxtRuta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtRuta.Location = New System.Drawing.Point(217, 12)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(443, 20)
        Me.TxtRuta.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(2, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(209, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Selecciona la ruta de los archivos externos"
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSeleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSeleccionar.Location = New System.Drawing.Point(666, 12)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(25, 22)
        Me.BtnSeleccionar.TabIndex = 2
        '
        'LblCopiar
        '
        Me.LblCopiar.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblCopiar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblCopiar.Location = New System.Drawing.Point(4, 47)
        Me.LblCopiar.Name = "LblCopiar"
        Me.LblCopiar.Size = New System.Drawing.Size(687, 55)
        Me.LblCopiar.TabIndex = 3
        Me.LblCopiar.Text = "Esta opcion copiara los archivos seleccionados de una caja u oficina a la computa" &
    "dora de manera permanente:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selecciona un rango de fechas y la caja:"
        '
        'BtnCopiar
        '
        Me.BtnCopiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCopiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCopiar.Location = New System.Drawing.Point(93, 175)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(150, 38)
        Me.BtnCopiar.TabIndex = 12
        Me.BtnCopiar.Text = "Copiar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnActualizar.Location = New System.Drawing.Point(249, 175)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(150, 38)
        Me.BtnActualizar.TabIndex = 13
        Me.BtnActualizar.Text = "Actualizar"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCerrar.Location = New System.Drawing.Point(405, 175)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(150, 38)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "Cerrar"
        '
        'PG
        '
        '
        '
        '
        Me.PG.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PG.Location = New System.Drawing.Point(45, 124)
        Me.PG.Name = "PG"
        Me.PG.Size = New System.Drawing.Size(581, 23)
        Me.PG.TabIndex = 15
        Me.PG.TextVisible = True
        Me.PG.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmImportarCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 248)
        Me.Controls.Add(Me.PG)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Controls.Add(Me.LblCopiar)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportarCobros"
        Me.Text = "Importar Cobros"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtRuta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCopiar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LblCopiar As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PG As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
