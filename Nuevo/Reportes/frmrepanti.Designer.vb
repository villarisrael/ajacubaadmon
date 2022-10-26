<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrepanti
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
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.cmbRuta = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.cmbReg = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cmbComu = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblmen = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.cmdSalir = New DevComponents.DotNetBar.ButtonX
        Me.cmdImp = New DevComponents.DotNetBar.ButtonX
        Me.cmbTipUso = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.cmbTarifa = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.SuspendLayout()
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(12, 121)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(67, 20)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Ruta:"
        '
        'cmbRuta
        '
        Me.cmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRuta.DisplayMember = "Text"
        Me.cmbRuta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRuta.FocusHighlightEnabled = True
        Me.cmbRuta.FormattingEnabled = True
        Me.cmbRuta.ItemHeight = 14
        Me.cmbRuta.Location = New System.Drawing.Point(99, 121)
        Me.cmbRuta.Name = "cmbRuta"
        Me.cmbRuta.Size = New System.Drawing.Size(175, 20)
        Me.cmbRuta.TabIndex = 6
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(12, 86)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(67, 20)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Región:"
        '
        'cmbReg
        '
        Me.cmbReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReg.DisplayMember = "Text"
        Me.cmbReg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReg.FocusHighlightEnabled = True
        Me.cmbReg.FormattingEnabled = True
        Me.cmbReg.ItemHeight = 14
        Me.cmbReg.Location = New System.Drawing.Point(99, 86)
        Me.cmbReg.Name = "cmbReg"
        Me.cmbReg.Size = New System.Drawing.Size(175, 20)
        Me.cmbReg.TabIndex = 4
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(12, 51)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(67, 20)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Comunidad:"
        '
        'cmbComu
        '
        Me.cmbComu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbComu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbComu.DisplayMember = "Text"
        Me.cmbComu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbComu.FocusHighlightEnabled = True
        Me.cmbComu.FormattingEnabled = True
        Me.cmbComu.ItemHeight = 14
        Me.cmbComu.Location = New System.Drawing.Point(99, 51)
        Me.cmbComu.Name = "cmbComu"
        Me.cmbComu.Size = New System.Drawing.Size(175, 20)
        Me.cmbComu.TabIndex = 2
        '
        'lblmen
        '
        Me.lblmen.BackColor = System.Drawing.Color.Transparent
        Me.lblmen.Location = New System.Drawing.Point(297, 53)
        Me.lblmen.Name = "lblmen"
        Me.lblmen.Size = New System.Drawing.Size(199, 18)
        Me.lblmen.TabIndex = 35
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(31, 17)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(410, 25)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Selecciona la región de donde quieres ver los anticipos existentes"
        '
        'cmdSalir
        '
        Me.cmdSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.cmdSalir.Location = New System.Drawing.Point(266, 232)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(144, 39)
        Me.cmdSalir.TabIndex = 8
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImp
        '
        Me.cmdImp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImp.Image = Global.Administativo.My.Resources.Resources.imprimir
        Me.cmdImp.Location = New System.Drawing.Point(101, 232)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.Size = New System.Drawing.Size(144, 39)
        Me.cmdImp.TabIndex = 7
        Me.cmdImp.Text = "Imprimir"
        '
        'cmbTipUso
        '
        Me.cmbTipUso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipUso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipUso.DisplayMember = "Text"
        Me.cmbTipUso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipUso.FocusHighlightEnabled = True
        Me.cmbTipUso.FormattingEnabled = True
        Me.cmbTipUso.ItemHeight = 14
        Me.cmbTipUso.Location = New System.Drawing.Point(99, 156)
        Me.cmbTipUso.Name = "cmbTipUso"
        Me.cmbTipUso.Size = New System.Drawing.Size(175, 20)
        Me.cmbTipUso.TabIndex = 36
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(12, 156)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(81, 20)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "Tipo usuarios"
        '
        'cmbTarifa
        '
        Me.cmbTarifa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTarifa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTarifa.DisplayMember = "Text"
        Me.cmbTarifa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTarifa.FocusHighlightEnabled = True
        Me.cmbTarifa.FormattingEnabled = True
        Me.cmbTarifa.ItemHeight = 14
        Me.cmbTarifa.Location = New System.Drawing.Point(99, 191)
        Me.cmbTarifa.Name = "cmbTarifa"
        Me.cmbTarifa.Size = New System.Drawing.Size(175, 20)
        Me.cmbTarifa.TabIndex = 37
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(12, 191)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(81, 20)
        Me.LabelX6.TabIndex = 5
        Me.LabelX6.Text = "Tarifa"
        '
        'frmrepanti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(511, 283)
        Me.Controls.Add(Me.cmbTarifa)
        Me.Controls.Add(Me.cmbTipUso)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdImp)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.lblmen)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.cmbRuta)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.cmbReg)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cmbComu)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrepanti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Anticipos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbRuta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbReg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbComu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblmen As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbTipUso As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbTarifa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
End Class
