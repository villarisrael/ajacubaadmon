<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoMedidor
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
        Me.LblTitulo = New DevComponents.DotNetBar.LabelX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.lblm3 = New DevComponents.DotNetBar.LabelX
        Me.NCapcons = New DevComponents.Editors.IntegerInput
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbAlgo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblMsn = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.lblm32 = New DevComponents.DotNetBar.LabelX
        CType(Me.NCapcons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(10, 12)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(493, 50)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Titulo"
        Me.LblTitulo.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LblTitulo.WordWrap = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(393, 294)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 46)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        '
        'lblm3
        '
        Me.lblm3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm3.Location = New System.Drawing.Point(26, 201)
        Me.lblm3.Name = "lblm3"
        Me.lblm3.Size = New System.Drawing.Size(220, 24)
        Me.lblm3.TabIndex = 8
        Me.lblm3.Text = "CAPTURAR CONSUMO:"
        Me.lblm3.Visible = False
        '
        'NCapcons
        '
        '
        '
        '
        Me.NCapcons.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NCapcons.FocusHighlightEnabled = True
        Me.NCapcons.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NCapcons.Location = New System.Drawing.Point(252, 199)
        Me.NCapcons.MaxValue = 99999
        Me.NCapcons.MinValue = 0
        Me.NCapcons.Name = "NCapcons"
        Me.NCapcons.ShowUpDown = True
        Me.NCapcons.Size = New System.Drawing.Size(125, 29)
        Me.NCapcons.TabIndex = 6
        Me.NCapcons.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(22, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(295, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "F10 = VER HISTORIAL DE LECTURAS"
        '
        'cmbAlgo
        '
        Me.cmbAlgo.DisplayMember = "Text"
        Me.cmbAlgo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAlgo.FocusHighlightEnabled = True
        Me.cmbAlgo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlgo.FormattingEnabled = True
        Me.cmbAlgo.ItemHeight = 23
        Me.cmbAlgo.Location = New System.Drawing.Point(146, 100)
        Me.cmbAlgo.Name = "cmbAlgo"
        Me.cmbAlgo.Size = New System.Drawing.Size(335, 29)
        Me.cmbAlgo.TabIndex = 28
        '
        'lblMsn
        '
        Me.lblMsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsn.Location = New System.Drawing.Point(12, 132)
        Me.lblMsn.Name = "lblMsn"
        Me.lblMsn.Size = New System.Drawing.Size(486, 34)
        Me.lblMsn.TabIndex = 29
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 101)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(128, 24)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "ALGORITMO:"
        '
        'lblm32
        '
        Me.lblm32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm32.Location = New System.Drawing.Point(383, 201)
        Me.lblm32.Name = "lblm32"
        Me.lblm32.Size = New System.Drawing.Size(44, 24)
        Me.lblm32.TabIndex = 8
        Me.lblm32.Text = "m3"
        Me.lblm32.Visible = False
        '
        'FrmNuevoMedidor
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 349)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMsn)
        Me.Controls.Add(Me.cmbAlgo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.lblm32)
        Me.Controls.Add(Me.lblm3)
        Me.Controls.Add(Me.NCapcons)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNuevoMedidor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Medidor"
        CType(Me.NCapcons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblm3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NCapcons As DevComponents.Editors.IntegerInput
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbAlgo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblMsn As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblm32 As DevComponents.DotNetBar.LabelX
End Class
