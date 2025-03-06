<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteConvenio
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
        Me.Fechainicio = New System.Windows.Forms.MonthCalendar()
        Me.Fechafinal = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbanalisis = New System.Windows.Forms.RadioButton()
        Me.rbdesglozado = New System.Windows.Forms.RadioButton()
        Me.rblistadonominal = New System.Windows.Forms.RadioButton()
        Me.btnimprimir = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fechainicio
        '
        Me.Fechainicio.Location = New System.Drawing.Point(40, 35)
        Me.Fechainicio.Name = "Fechainicio"
        Me.Fechainicio.TabIndex = 0
        '
        'Fechafinal
        '
        Me.Fechafinal.Location = New System.Drawing.Point(352, 35)
        Me.Fechafinal.Name = "Fechafinal"
        Me.Fechafinal.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbanalisis)
        Me.GroupBox1.Controls.Add(Me.rbdesglozado)
        Me.GroupBox1.Controls.Add(Me.rblistadonominal)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 111)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convenios"
        '
        'rbanalisis
        '
        Me.rbanalisis.AutoSize = True
        Me.rbanalisis.Location = New System.Drawing.Point(15, 65)
        Me.rbanalisis.Name = "rbanalisis"
        Me.rbanalisis.Size = New System.Drawing.Size(225, 17)
        Me.rbanalisis.TabIndex = 2
        Me.rbanalisis.Text = "Listado De convenios no presentan pagos"
        Me.rbanalisis.UseVisualStyleBackColor = True
        '
        'rbdesglozado
        '
        Me.rbdesglozado.AutoSize = True
        Me.rbdesglozado.Location = New System.Drawing.Point(15, 42)
        Me.rbdesglozado.Name = "rbdesglozado"
        Me.rbdesglozado.Size = New System.Drawing.Size(118, 17)
        Me.rbdesglozado.TabIndex = 1
        Me.rbdesglozado.Text = "Listado Desglosado"
        Me.rbdesglozado.UseVisualStyleBackColor = True
        '
        'rblistadonominal
        '
        Me.rblistadonominal.AutoSize = True
        Me.rblistadonominal.Checked = True
        Me.rblistadonominal.Location = New System.Drawing.Point(15, 19)
        Me.rblistadonominal.Name = "rblistadonominal"
        Me.rblistadonominal.Size = New System.Drawing.Size(100, 17)
        Me.rblistadonominal.TabIndex = 0
        Me.rblistadonominal.TabStop = True
        Me.rblistadonominal.Text = "Listado Nominal"
        Me.rblistadonominal.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnimprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnimprimir.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.btnimprimir.Location = New System.Drawing.Point(451, 341)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.PulseSpeed = 30
        Me.btnimprimir.Size = New System.Drawing.Size(149, 39)
        Me.btnimprimir.TabIndex = 146
        Me.btnimprimir.Text = "Imprimir"
        '
        'FrmReporteConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 418)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Fechafinal)
        Me.Controls.Add(Me.Fechainicio)
        Me.Name = "FrmReporteConvenio"
        Me.Text = "FrmReporteConvenio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Fechainicio As MonthCalendar
    Friend WithEvents Fechafinal As MonthCalendar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbanalisis As RadioButton
    Friend WithEvents rbdesglozado As RadioButton
    Friend WithEvents rblistadonominal As RadioButton
    Friend WithEvents btnimprimir As DevComponents.DotNetBar.ButtonX
End Class
