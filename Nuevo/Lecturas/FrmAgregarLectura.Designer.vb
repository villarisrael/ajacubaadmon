<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarLectura
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
        Me.LblComunidad = New System.Windows.Forms.Label
        Me.LblCuenta = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblAnterior = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtActual = New DevComponents.Editors.IntegerInput
        Me.CmbSituacion1 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbSituacion2 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.CmbSituacion3 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.BtnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblObservacion = New System.Windows.Forms.Label
        Me.lblHidro = New System.Windows.Forms.Label
        Me.LblPadron = New System.Windows.Forms.Label
        Me.LblMedicion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LblTitulo = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbAlgo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblmts = New System.Windows.Forms.Label
        Me.txtconsumo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.TxtActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblComunidad
        '
        Me.LblComunidad.AutoSize = True
        Me.LblComunidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComunidad.Location = New System.Drawing.Point(266, 62)
        Me.LblComunidad.Name = "LblComunidad"
        Me.LblComunidad.Size = New System.Drawing.Size(98, 19)
        Me.LblComunidad.TabIndex = 11
        Me.LblComunidad.Text = "Comunidad"
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuenta.Location = New System.Drawing.Point(83, 62)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(64, 19)
        Me.LblCuenta.TabIndex = 9
        Me.LblCuenta.Text = "Cuenta"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(83, 93)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(70, 19)
        Me.LblNombre.TabIndex = 13
        Me.LblNombre.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Lectura Anterior"
        '
        'LblAnterior
        '
        Me.LblAnterior.AutoSize = True
        Me.LblAnterior.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnterior.Location = New System.Drawing.Point(176, 126)
        Me.LblAnterior.Name = "LblAnterior"
        Me.LblAnterior.Size = New System.Drawing.Size(54, 22)
        Me.LblAnterior.TabIndex = 15
        Me.LblAnterior.Text = "1000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Lectura Actual"
        '
        'TxtActual
        '
        '
        '
        '
        Me.TxtActual.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtActual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtActual.FocusHighlightEnabled = True
        Me.TxtActual.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtActual.Location = New System.Drawing.Point(205, 166)
        Me.TxtActual.Name = "TxtActual"
        Me.TxtActual.ShowUpDown = True
        Me.TxtActual.Size = New System.Drawing.Size(102, 29)
        Me.TxtActual.TabIndex = 0
        '
        'CmbSituacion1
        '
        Me.CmbSituacion1.DisplayMember = "Text"
        Me.CmbSituacion1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSituacion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSituacion1.FocusHighlightEnabled = True
        Me.CmbSituacion1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion1.FormattingEnabled = True
        Me.CmbSituacion1.ItemHeight = 23
        Me.CmbSituacion1.Location = New System.Drawing.Point(205, 203)
        Me.CmbSituacion1.Name = "CmbSituacion1"
        Me.CmbSituacion1.Size = New System.Drawing.Size(47, 29)
        Me.CmbSituacion1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Situación Medición"
        '
        'CmbSituacion2
        '
        Me.CmbSituacion2.DisplayMember = "Text"
        Me.CmbSituacion2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSituacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSituacion2.FocusHighlightEnabled = True
        Me.CmbSituacion2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion2.FormattingEnabled = True
        Me.CmbSituacion2.ItemHeight = 23
        Me.CmbSituacion2.Location = New System.Drawing.Point(205, 238)
        Me.CmbSituacion2.Name = "CmbSituacion2"
        Me.CmbSituacion2.Size = New System.Drawing.Size(47, 29)
        Me.CmbSituacion2.TabIndex = 2
        '
        'CmbSituacion3
        '
        Me.CmbSituacion3.DisplayMember = "Text"
        Me.CmbSituacion3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSituacion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSituacion3.FocusHighlightEnabled = True
        Me.CmbSituacion3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSituacion3.FormattingEnabled = True
        Me.CmbSituacion3.ItemHeight = 23
        Me.CmbSituacion3.Location = New System.Drawing.Point(205, 273)
        Me.CmbSituacion3.Name = "CmbSituacion3"
        Me.CmbSituacion3.Size = New System.Drawing.Size(47, 29)
        Me.CmbSituacion3.TabIndex = 3
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Image = Global.Administativo.My.Resources.Resources.Salir_ln
        Me.BtnCancelar.Location = New System.Drawing.Point(333, 353)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 46)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Terminar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAceptar.Image = Global.Administativo.My.Resources.Resources.apply
        Me.BtnAceptar.Location = New System.Drawing.Point(217, 353)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 46)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Situación Padrón"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Situación Hidrómetro"
        '
        'LblObservacion
        '
        Me.LblObservacion.AutoSize = True
        Me.LblObservacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblObservacion.Location = New System.Drawing.Point(12, 307)
        Me.LblObservacion.Name = "LblObservacion"
        Me.LblObservacion.Size = New System.Drawing.Size(96, 18)
        Me.LblObservacion.TabIndex = 20
        Me.LblObservacion.Text = "Observación"
        '
        'lblHidro
        '
        Me.lblHidro.AutoSize = True
        Me.lblHidro.BackColor = System.Drawing.Color.White
        Me.lblHidro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHidro.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHidro.Location = New System.Drawing.Point(258, 273)
        Me.lblHidro.Name = "lblHidro"
        Me.lblHidro.Size = New System.Drawing.Size(2, 24)
        Me.lblHidro.TabIndex = 18
        '
        'LblPadron
        '
        Me.LblPadron.AutoSize = True
        Me.LblPadron.BackColor = System.Drawing.Color.White
        Me.LblPadron.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPadron.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPadron.Location = New System.Drawing.Point(258, 238)
        Me.LblPadron.Name = "LblPadron"
        Me.LblPadron.Size = New System.Drawing.Size(2, 24)
        Me.LblPadron.TabIndex = 15
        '
        'LblMedicion
        '
        Me.LblMedicion.AutoSize = True
        Me.LblMedicion.BackColor = System.Drawing.Color.White
        Me.LblMedicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMedicion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedicion.Location = New System.Drawing.Point(258, 203)
        Me.LblMedicion.Name = "LblMedicion"
        Me.LblMedicion.Size = New System.Drawing.Size(2, 24)
        Me.LblMedicion.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Comunidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cuenta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nombre"
        '
        'TxtObservacion
        '
        '
        '
        '
        Me.TxtObservacion.Border.Class = "TextBoxBorder"
        Me.TxtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtObservacion.FocusHighlightEnabled = True
        Me.TxtObservacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(150, 308)
        Me.TxtObservacion.MaxLength = 20
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(293, 29)
        Me.TxtObservacion.TabIndex = 4
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblTitulo.BackgroundStyle.Class = ""
        Me.LblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblTitulo.Location = New System.Drawing.Point(217, 12)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(216, 44)
        Me.LblTitulo.TabIndex = 7
        Me.LblTitulo.Text = "<b><font size=""+6"">MODIFICAR LECTURA</font></b>"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(313, 176)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(130, 19)
        Me.ButtonX1.TabIndex = 25
        Me.ButtonX1.TabStop = False
        Me.ButtonX1.Text = "Limpiar  Situaciones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(15, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "F10 = VER HISTORIAL"
        '
        'cmbAlgo
        '
        Me.cmbAlgo.DisplayMember = "Text"
        Me.cmbAlgo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAlgo.DropDownWidth = 500
        Me.cmbAlgo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlgo.FormattingEnabled = True
        Me.cmbAlgo.ItemHeight = 23
        Me.cmbAlgo.Location = New System.Drawing.Point(469, 253)
        Me.cmbAlgo.Name = "cmbAlgo"
        Me.cmbAlgo.Size = New System.Drawing.Size(221, 29)
        Me.cmbAlgo.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(466, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Algoritmo"
        '
        'lblmts
        '
        Me.lblmts.AutoSize = True
        Me.lblmts.Location = New System.Drawing.Point(466, 340)
        Me.lblmts.Name = "lblmts"
        Me.lblmts.Size = New System.Drawing.Size(0, 13)
        Me.lblmts.TabIndex = 28
        '
        'txtconsumo
        '
        '
        '
        '
        Me.txtconsumo.Border.Class = "TextBoxBorder"
        Me.txtconsumo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtconsumo.FocusHighlightEnabled = True
        Me.txtconsumo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconsumo.Location = New System.Drawing.Point(568, 302)
        Me.txtconsumo.MaxLength = 20
        Me.txtconsumo.Name = "txtconsumo"
        Me.txtconsumo.Size = New System.Drawing.Size(106, 29)
        Me.txtconsumo.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(466, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Consumo"
        '
        'FrmAgregarLectura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(714, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtconsumo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblmts)
        Me.Controls.Add(Me.cmbAlgo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHidro)
        Me.Controls.Add(Me.LblPadron)
        Me.Controls.Add(Me.LblMedicion)
        Me.Controls.Add(Me.LblObservacion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.CmbSituacion3)
        Me.Controls.Add(Me.CmbSituacion2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbSituacion1)
        Me.Controls.Add(Me.TxtActual)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblAnterior)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCuenta)
        Me.Controls.Add(Me.LblComunidad)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgregarLectura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Lectura"
        CType(Me.TxtActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblComunidad As System.Windows.Forms.Label
    Friend WithEvents LblCuenta As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblAnterior As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtActual As DevComponents.Editors.IntegerInput
    Friend WithEvents CmbSituacion1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbSituacion2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CmbSituacion3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblObservacion As System.Windows.Forms.Label
    Friend WithEvents lblHidro As System.Windows.Forms.Label
    Friend WithEvents LblPadron As System.Windows.Forms.Label
    Friend WithEvents LblMedicion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LblTitulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbAlgo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblmts As System.Windows.Forms.Label
    Friend WithEvents txtconsumo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
