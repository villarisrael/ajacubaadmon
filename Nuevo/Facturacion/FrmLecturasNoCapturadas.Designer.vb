<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLecturasNoCapturadas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblTitulo = New DevComponents.DotNetBar.LabelX()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.DGSituaciones = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PB = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BtnImprimir = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DGSituaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(12, 46)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(582, 63)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LblTitulo.WordWrap = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(240, 445)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(139, 35)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.BtnCancelar.Location = New System.Drawing.Point(388, 445)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(139, 35)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Terminar"
        '
        'DGSituaciones
        '
        Me.DGSituaciones.AllowUserToAddRows = False
        Me.DGSituaciones.AllowUserToDeleteRows = False
        Me.DGSituaciones.AllowUserToOrderColumns = True
        Me.DGSituaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSituaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Situacion, Me.Tipo, Me.Accion})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSituaciones.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGSituaciones.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGSituaciones.Location = New System.Drawing.Point(65, 115)
        Me.DGSituaciones.MultiSelect = False
        Me.DGSituaciones.Name = "DGSituaciones"
        Me.DGSituaciones.ReadOnly = True
        Me.DGSituaciones.Size = New System.Drawing.Size(473, 250)
        Me.DGSituaciones.TabIndex = 7
        '
        'Clave
        '
        Me.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Clave.DataPropertyName = "Clave"
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        Me.Clave.Width = 59
        '
        'Situacion
        '
        Me.Situacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Situacion.DataPropertyName = "Situacion"
        Me.Situacion.HeaderText = "Situacion"
        Me.Situacion.Name = "Situacion"
        Me.Situacion.ReadOnly = True
        Me.Situacion.Width = 76
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Visible = False
        '
        'Accion
        '
        Me.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Accion.DataPropertyName = "descrip"
        Me.Accion.HeaderText = "Accion"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        Me.Accion.Width = 65
        '
        'PB
        '
        '
        '
        '
        Me.PB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PB.Location = New System.Drawing.Point(12, 391)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(579, 23)
        Me.PB.TabIndex = 6
        Me.PB.TabStop = False
        Me.PB.TextVisible = True
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(155, 2)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(292, 44)
        Me.ReflectionLabel1.TabIndex = 0
        Me.ReflectionLabel1.Text = "<b><font size=""+6"">LECTURAS NO CAPTURADAS</font></b>"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 420)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(582, 24)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "En caso de no quiera crear las lecturas, de clic en Terminar el calculo no se rea" & _
            "lizara."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnImprimir.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.BtnImprimir.Location = New System.Drawing.Point(92, 445)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(139, 35)
        Me.BtnImprimir.TabIndex = 2
        Me.BtnImprimir.Text = "Imprimir"
        '
        'FrmLecturasNoCapturadas
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(620, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DGSituaciones)
        Me.Controls.Add(Me.LblTitulo)
        Me.DoubleBuffered = True
        Me.Name = "FrmLecturasNoCapturadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturas No Capturadas"
        Me.TopMost = True
        CType(Me.DGSituaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGSituaciones As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Situacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PB As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnImprimir As DevComponents.DotNetBar.ButtonX
End Class
