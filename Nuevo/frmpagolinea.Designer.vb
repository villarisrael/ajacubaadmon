<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpagolinea
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MonthCalendarAdv1 = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antes de generar el archivo, es necesario que tengas actualizado tus saldos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(280, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MonthCalendarAdv1
        '
        Me.MonthCalendarAdv1.AutoSize = True
        '
        '
        '
        Me.MonthCalendarAdv1.BackgroundStyle.Class = "MonthCalendarAdv"
        Me.MonthCalendarAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MonthCalendarAdv1.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MonthCalendarAdv1.ContainerControlProcessDialogKey = True
        Me.MonthCalendarAdv1.DisplayMonth = New Date(2024, 2, 1, 0, 0, 0, 0)
        Me.MonthCalendarAdv1.Location = New System.Drawing.Point(15, 65)
        Me.MonthCalendarAdv1.Name = "MonthCalendarAdv1"
        '
        '
        '
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MonthCalendarAdv1.Size = New System.Drawing.Size(170, 131)
        Me.MonthCalendarAdv1.TabIndex = 10
        Me.MonthCalendarAdv1.Text = "MonthCalendarAdv1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Selecciona fecha de vencimiento"
        '
        'frmpagolinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 235)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonthCalendarAdv1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmpagolinea"
        Me.Text = "Pago en linea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MonthCalendarAdv1 As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents Label2 As Label
End Class
