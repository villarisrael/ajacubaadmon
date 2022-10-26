<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrDescuento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrDescuento))
        Me.cmbUniDesc = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdCance = New DevComponents.DotNetBar.ButtonX()
        Me.cmdAcept = New DevComponents.DotNetBar.ButtonX()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New DevComponents.Editors.IntegerInput()
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbUniDesc
        '
        Me.cmbUniDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUniDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUniDesc.DisplayMember = "Text"
        Me.cmbUniDesc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbUniDesc.DropDownWidth = 200
        Me.cmbUniDesc.FocusHighlightEnabled = True
        Me.cmbUniDesc.FormattingEnabled = True
        Me.cmbUniDesc.ItemHeight = 14
        Me.cmbUniDesc.Location = New System.Drawing.Point(148, 29)
        Me.cmbUniDesc.Name = "cmbUniDesc"
        Me.cmbUniDesc.Size = New System.Drawing.Size(218, 20)
        Me.cmbUniDesc.TabIndex = 13
        '
        'cmdCance
        '
        Me.cmdCance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCance.Image = Global.Administativo.My.Resources.Resources.button_cancel
        Me.cmdCance.Location = New System.Drawing.Point(218, 167)
        Me.cmdCance.Name = "cmdCance"
        Me.cmdCance.PulseSpeed = 40
        Me.cmdCance.Size = New System.Drawing.Size(90, 37)
        Me.cmdCance.TabIndex = 17
        Me.cmdCance.Text = "Terminar"
        '
        'cmdAcept
        '
        Me.cmdAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdAcept.Image = Global.Administativo.My.Resources.Resources.apply
        Me.cmdAcept.Location = New System.Drawing.Point(104, 167)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.PulseSpeed = 40
        Me.cmdAcept.Size = New System.Drawing.Size(90, 37)
        Me.cmdAcept.TabIndex = 16
        Me.cmdAcept.Text = "Guardar"
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(45, 71)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(61, 13)
        Me.lblPorcentaje.TabIndex = 20
        Me.lblPorcentaje.Text = "Porcentaje:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(45, 112)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 19
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.FocusHighlightEnabled = True
        Me.txtDescripcion.Location = New System.Drawing.Point(148, 105)
        Me.txtDescripcion.MaxLength = 55
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(241, 20)
        Me.txtDescripcion.TabIndex = 14
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(45, 33)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(99, 13)
        Me.lblUnidad.TabIndex = 18
        Me.lblUnidad.Text = "Unidad Descuento:"
        '
        'txtPorcentaje
        '
        '
        '
        '
        Me.txtPorcentaje.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtPorcentaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPorcentaje.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtPorcentaje.Location = New System.Drawing.Point(148, 64)
        Me.txtPorcentaje.MaxValue = 100
        Me.txtPorcentaje.MinValue = 0
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.ShowUpDown = True
        Me.txtPorcentaje.Size = New System.Drawing.Size(138, 20)
        Me.txtPorcentaje.TabIndex = 21
        '
        'frmAgrDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 241)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.cmbUniDesc)
        Me.Controls.Add(Me.cmdCance)
        Me.Controls.Add(Me.cmdAcept)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblUnidad)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAgrDescuento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Descuento"
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUniDesc As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdCance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdAcept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As DevComponents.Editors.IntegerInput
End Class
