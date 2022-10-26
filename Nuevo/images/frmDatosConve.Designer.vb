<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosConvenio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblDir = New System.Windows.Forms.Label
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTarifa = New System.Windows.Forms.TextBox
        Me.dgConceptos = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtSubTot = New System.Windows.Forms.TextBox
        Me.Lblsubtot = New System.Windows.Forms.Label
        Me.Checkiva = New System.Windows.Forms.CheckBox
        Me.txtIva = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ChkReza = New System.Windows.Forms.CheckBox
        Me.txtDescu = New System.Windows.Forms.TextBox
        Me.txtOtros = New System.Windows.Forms.TextBox
        Me.txtReca = New System.Windows.Forms.TextBox
        Me.txtAlcanta = New System.Windows.Forms.TextBox
        Me.txtSaneamiento = New System.Windows.Forms.TextBox
        Me.txtConsumo = New System.Windows.Forms.TextBox
        Me.txtReza = New System.Windows.Forms.TextBox
        Me.Chkconsu = New System.Windows.Forms.CheckBox
        Me.Checkdescuento = New System.Windows.Forms.CheckBox
        Me.Chkotros = New System.Windows.Forms.CheckBox
        Me.ChkReca = New System.Windows.Forms.CheckBox
        Me.ChkAlca = New System.Windows.Forms.CheckBox
        Me.ChkSanea = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtfecpag = New System.Windows.Forms.TextBox
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.cmdCalcular = New System.Windows.Forms.Button
        Me.cmdAcept = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblNomDesc = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPer = New System.Windows.Forms.TextBox
        CType(Me.dgConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(87, 19)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(129, 20)
        Me.txtCuenta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(539, 20)
        Me.txtNombre.TabIndex = 2
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Location = New System.Drawing.Point(12, 122)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(55, 13)
        Me.lblDir.TabIndex = 5
        Me.lblDir.Text = "Dirección:"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(87, 114)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ReadOnly = True
        Me.txtDir.Size = New System.Drawing.Size(539, 20)
        Me.txtDir.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tarifa:"
        '
        'txtTarifa
        '
        Me.txtTarifa.Location = New System.Drawing.Point(87, 54)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.ReadOnly = True
        Me.txtTarifa.Size = New System.Drawing.Size(130, 20)
        Me.txtTarifa.TabIndex = 6
        '
        'dgConceptos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgConceptos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgConceptos.Location = New System.Drawing.Point(61, 18)
        Me.dgConceptos.Name = "dgConceptos"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgConceptos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgConceptos.Size = New System.Drawing.Size(576, 116)
        Me.dgConceptos.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Clave"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 57
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Concepto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 76
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 72
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Monto"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtSubTot)
        Me.Panel2.Controls.Add(Me.Lblsubtot)
        Me.Panel2.Controls.Add(Me.Checkiva)
        Me.Panel2.Controls.Add(Me.txtIva)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Location = New System.Drawing.Point(364, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 72)
        Me.Panel2.TabIndex = 45
        '
        'txtSubTot
        '
        Me.txtSubTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTot.Location = New System.Drawing.Point(121, 2)
        Me.txtSubTot.Name = "txtSubTot"
        Me.txtSubTot.Size = New System.Drawing.Size(145, 23)
        Me.txtSubTot.TabIndex = 47
        Me.txtSubTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lblsubtot
        '
        Me.Lblsubtot.AutoSize = True
        Me.Lblsubtot.Location = New System.Drawing.Point(8, 2)
        Me.Lblsubtot.Name = "Lblsubtot"
        Me.Lblsubtot.Size = New System.Drawing.Size(46, 13)
        Me.Lblsubtot.TabIndex = 46
        Me.Lblsubtot.Text = "Subtotal"
        '
        'Checkiva
        '
        Me.Checkiva.AutoSize = True
        Me.Checkiva.Location = New System.Drawing.Point(8, 22)
        Me.Checkiva.Name = "Checkiva"
        Me.Checkiva.Size = New System.Drawing.Size(52, 17)
        Me.Checkiva.TabIndex = 45
        Me.Checkiva.Text = "I.V.A."
        Me.Checkiva.UseVisualStyleBackColor = True
        '
        'txtIva
        '
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(121, 22)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(145, 23)
        Me.txtIva.TabIndex = 44
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(121, 42)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(145, 23)
        Me.txtTotal.TabIndex = 42
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ChkReza)
        Me.Panel1.Controls.Add(Me.txtDescu)
        Me.Panel1.Controls.Add(Me.txtOtros)
        Me.Panel1.Controls.Add(Me.txtReca)
        Me.Panel1.Controls.Add(Me.txtAlcanta)
        Me.Panel1.Controls.Add(Me.txtSaneamiento)
        Me.Panel1.Controls.Add(Me.txtConsumo)
        Me.Panel1.Controls.Add(Me.txtReza)
        Me.Panel1.Controls.Add(Me.Chkconsu)
        Me.Panel1.Controls.Add(Me.Checkdescuento)
        Me.Panel1.Controls.Add(Me.Chkotros)
        Me.Panel1.Controls.Add(Me.ChkReca)
        Me.Panel1.Controls.Add(Me.ChkAlca)
        Me.Panel1.Controls.Add(Me.ChkSanea)
        Me.Panel1.Location = New System.Drawing.Point(364, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 167)
        Me.Panel1.TabIndex = 44
        '
        'ChkReza
        '
        Me.ChkReza.AutoSize = True
        Me.ChkReza.Location = New System.Drawing.Point(9, 17)
        Me.ChkReza.Name = "ChkReza"
        Me.ChkReza.Size = New System.Drawing.Size(68, 17)
        Me.ChkReza.TabIndex = 55
        Me.ChkReza.Text = "Rezagos"
        Me.ChkReza.UseVisualStyleBackColor = True
        '
        'txtDescu
        '
        Me.txtDescu.BackColor = System.Drawing.Color.IndianRed
        Me.txtDescu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescu.Location = New System.Drawing.Point(121, 137)
        Me.txtDescu.Name = "txtDescu"
        Me.txtDescu.Size = New System.Drawing.Size(145, 23)
        Me.txtDescu.TabIndex = 52
        Me.txtDescu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOtros
        '
        Me.txtOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.Location = New System.Drawing.Point(121, 117)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(145, 23)
        Me.txtOtros.TabIndex = 45
        Me.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReca
        '
        Me.txtReca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReca.Location = New System.Drawing.Point(121, 97)
        Me.txtReca.Name = "txtReca"
        Me.txtReca.Size = New System.Drawing.Size(145, 23)
        Me.txtReca.TabIndex = 44
        Me.txtReca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAlcanta
        '
        Me.txtAlcanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcanta.Location = New System.Drawing.Point(121, 77)
        Me.txtAlcanta.Name = "txtAlcanta"
        Me.txtAlcanta.Size = New System.Drawing.Size(145, 23)
        Me.txtAlcanta.TabIndex = 43
        Me.txtAlcanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaneamiento
        '
        Me.txtSaneamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaneamiento.Location = New System.Drawing.Point(121, 57)
        Me.txtSaneamiento.Name = "txtSaneamiento"
        Me.txtSaneamiento.Size = New System.Drawing.Size(145, 23)
        Me.txtSaneamiento.TabIndex = 42
        Me.txtSaneamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConsumo
        '
        Me.txtConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsumo.Location = New System.Drawing.Point(121, 37)
        Me.txtConsumo.Name = "txtConsumo"
        Me.txtConsumo.Size = New System.Drawing.Size(145, 23)
        Me.txtConsumo.TabIndex = 41
        Me.txtConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReza
        '
        Me.txtReza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReza.Location = New System.Drawing.Point(121, 17)
        Me.txtReza.Name = "txtReza"
        Me.txtReza.Size = New System.Drawing.Size(145, 23)
        Me.txtReza.TabIndex = 54
        Me.txtReza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Chkconsu
        '
        Me.Chkconsu.AutoSize = True
        Me.Chkconsu.Location = New System.Drawing.Point(9, 37)
        Me.Chkconsu.Name = "Chkconsu"
        Me.Chkconsu.Size = New System.Drawing.Size(70, 17)
        Me.Chkconsu.TabIndex = 53
        Me.Chkconsu.Text = "Consumo"
        Me.Chkconsu.UseVisualStyleBackColor = True
        '
        'Checkdescuento
        '
        Me.Checkdescuento.AutoSize = True
        Me.Checkdescuento.Location = New System.Drawing.Point(9, 137)
        Me.Checkdescuento.Name = "Checkdescuento"
        Me.Checkdescuento.Size = New System.Drawing.Size(78, 17)
        Me.Checkdescuento.TabIndex = 51
        Me.Checkdescuento.Text = "Descuento"
        Me.Checkdescuento.UseVisualStyleBackColor = True
        '
        'Chkotros
        '
        Me.Chkotros.AutoSize = True
        Me.Chkotros.Location = New System.Drawing.Point(9, 117)
        Me.Chkotros.Name = "Chkotros"
        Me.Chkotros.Size = New System.Drawing.Size(51, 17)
        Me.Chkotros.TabIndex = 50
        Me.Chkotros.Text = "Otros"
        Me.Chkotros.UseVisualStyleBackColor = True
        '
        'ChkReca
        '
        Me.ChkReca.AutoSize = True
        Me.ChkReca.Location = New System.Drawing.Point(9, 97)
        Me.ChkReca.Name = "ChkReca"
        Me.ChkReca.Size = New System.Drawing.Size(72, 17)
        Me.ChkReca.TabIndex = 49
        Me.ChkReca.Text = "Recargos"
        Me.ChkReca.UseVisualStyleBackColor = True
        '
        'ChkAlca
        '
        Me.ChkAlca.AutoSize = True
        Me.ChkAlca.Location = New System.Drawing.Point(9, 77)
        Me.ChkAlca.Name = "ChkAlca"
        Me.ChkAlca.Size = New System.Drawing.Size(89, 17)
        Me.ChkAlca.TabIndex = 48
        Me.ChkAlca.Text = "Alcantarillado"
        Me.ChkAlca.UseVisualStyleBackColor = True
        '
        'ChkSanea
        '
        Me.ChkSanea.AutoSize = True
        Me.ChkSanea.Location = New System.Drawing.Point(9, 57)
        Me.ChkSanea.Name = "ChkSanea"
        Me.ChkSanea.Size = New System.Drawing.Size(88, 17)
        Me.ChkSanea.TabIndex = 47
        Me.ChkSanea.Text = "Saneamiento"
        Me.ChkSanea.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fecha cubierta:"
        '
        'txtfecpag
        '
        Me.txtfecpag.Location = New System.Drawing.Point(315, 54)
        Me.txtfecpag.Name = "txtfecpag"
        Me.txtfecpag.ReadOnly = True
        Me.txtfecpag.Size = New System.Drawing.Size(93, 20)
        Me.txtfecpag.TabIndex = 46
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(61, 168)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(107, 20)
        Me.dtFecha.TabIndex = 48
        '
        'cmdCalcular
        '
        Me.cmdCalcular.Location = New System.Drawing.Point(61, 201)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.Size = New System.Drawing.Size(106, 27)
        Me.cmdCalcular.TabIndex = 49
        Me.cmdCalcular.Text = "Calcular"
        Me.cmdCalcular.UseVisualStyleBackColor = True
        '
        'cmdAcept
        '
        Me.cmdAcept.Location = New System.Drawing.Point(61, 227)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(106, 27)
        Me.cmdAcept.TabIndex = 50
        Me.cmdAcept.Text = "Aceptar"
        Me.cmdAcept.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPer)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtfecpag)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTarifa)
        Me.GroupBox1.Controls.Add(Me.lblDir)
        Me.GroupBox1.Controls.Add(Me.txtDir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 154)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(227, 19)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(106, 20)
        Me.cmdBuscar.TabIndex = 52
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNomDesc)
        Me.GroupBox2.Controls.Add(Me.cmdAcept)
        Me.GroupBox2.Controls.Add(Me.cmdCalcular)
        Me.GroupBox2.Controls.Add(Me.dtFecha)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.dgConceptos)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 404)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'lblNomDesc
        '
        Me.lblNomDesc.AutoSize = True
        Me.lblNomDesc.Location = New System.Drawing.Point(224, 295)
        Me.lblNomDesc.Name = "lblNomDesc"
        Me.lblNomDesc.Size = New System.Drawing.Size(0, 13)
        Me.lblNomDesc.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(431, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Periodo:"
        '
        'txtPer
        '
        Me.txtPer.Location = New System.Drawing.Point(496, 54)
        Me.txtPer.Name = "txtPer"
        Me.txtPer.ReadOnly = True
        Me.txtPer.Size = New System.Drawing.Size(130, 20)
        Me.txtPer.TabIndex = 53
        '
        'frmDatosConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 577)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDatosConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del convenio"
        CType(Me.dgConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTarifa As System.Windows.Forms.TextBox
    Friend WithEvents dgConceptos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Protected WithEvents txtSubTot As System.Windows.Forms.TextBox
    Friend WithEvents Lblsubtot As System.Windows.Forms.Label
    Friend WithEvents Checkiva As System.Windows.Forms.CheckBox
    Protected WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Protected WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ChkReza As System.Windows.Forms.CheckBox
    Protected WithEvents txtDescu As System.Windows.Forms.TextBox
    Protected WithEvents txtOtros As System.Windows.Forms.TextBox
    Protected WithEvents txtReca As System.Windows.Forms.TextBox
    Protected WithEvents txtAlcanta As System.Windows.Forms.TextBox
    Protected WithEvents txtSaneamiento As System.Windows.Forms.TextBox
    Protected WithEvents txtConsumo As System.Windows.Forms.TextBox
    Protected WithEvents txtReza As System.Windows.Forms.TextBox
    Friend WithEvents Chkconsu As System.Windows.Forms.CheckBox
    Friend WithEvents Checkdescuento As System.Windows.Forms.CheckBox
    Friend WithEvents Chkotros As System.Windows.Forms.CheckBox
    Friend WithEvents ChkReca As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAlca As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSanea As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfecpag As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdCalcular As System.Windows.Forms.Button
    Friend WithEvents cmdAcept As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblNomDesc As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPer As System.Windows.Forms.TextBox
End Class
