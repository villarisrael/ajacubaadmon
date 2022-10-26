Imports DevComponents.DotNetBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEpagos
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.StepIndicator1 = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me.PBExcel = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.btncrear = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtnombredelservicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'StepIndicator1
        '
        Me.StepIndicator1.CurrentStep = 0
        Me.StepIndicator1.Location = New System.Drawing.Point(12, 177)
        Me.StepIndicator1.Name = "StepIndicator1"
        Me.StepIndicator1.Size = New System.Drawing.Size(532, 26)
        Me.StepIndicator1.StepCount = 2
        Me.StepIndicator1.TabIndex = 0
        Me.StepIndicator1.Text = "StepIndicator1"
        '
        'PBExcel
        '
        '
        '
        '
        Me.PBExcel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PBExcel.Location = New System.Drawing.Point(11, 221)
        Me.PBExcel.Name = "PBExcel"
        Me.PBExcel.Size = New System.Drawing.Size(537, 23)
        Me.PBExcel.TabIndex = 1
        Me.PBExcel.Text = "ProgressBarX1"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(205, 137)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(150, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Paso 2 Calculando Saldo"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(391, 137)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(163, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Paso 3 Creando Excel"
        '
        'btncrear
        '
        Me.btncrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncrear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncrear.Location = New System.Drawing.Point(12, 100)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(537, 31)
        Me.btncrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btncrear.TabIndex = 5
        Me.btncrear.Text = "Crear Layout"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Red
        Me.LabelX4.Location = New System.Drawing.Point(17, 274)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(472, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Este proceso es tardado sea paciente!!!!"
        '
        'txtnombredelservicio
        '
        Me.txtnombredelservicio.Location = New System.Drawing.Point(12, 55)
        Me.txtnombredelservicio.Name = "txtnombredelservicio"
        Me.txtnombredelservicio.Size = New System.Drawing.Size(150, 20)
        Me.txtnombredelservicio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ejemplo ENE2020"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Escribe el nombre de un servicio con el que va subir a pagos en linea"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 137)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(150, 23)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Paso 1 Creando el serivicio"
        '
        'frmEpagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 328)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombredelservicio)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.PBExcel)
        Me.Controls.Add(Me.StepIndicator1)
        Me.DoubleBuffered = True
        Me.Name = "frmEpagos"
        Me.Text = "Exportacion a excel de saldos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StepIndicator1 As Controls.StepIndicator
    Friend WithEvents PBExcel As Controls.ProgressBarX
    Friend WithEvents LabelX2 As LabelX
    Friend WithEvents LabelX3 As LabelX
    Friend WithEvents btncrear As ButtonX
    Friend WithEvents LabelX4 As LabelX
    Friend WithEvents txtnombredelservicio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelX1 As LabelX
End Class
