Imports DevComponents.DotNetBar

Public Class frmAgrCxC
    Dim mtipo As Tipo
    Dim idcxc As String = ""
    Dim datcxc As IDataReader

    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Sub New(ByVal _mtipo As Tipo, Optional ByVal _idcxc As String = "")
        InitializeComponent()
        mtipo = _mtipo
        idcxc = _idcxc
        llenarCombo(cmbRubro, "select id_rubro, descripcion from rubros order by descripcion")
        If mtipo = Tipo.Editar OrElse mtipo = Tipo.Ver Then
            txtId_com.ReadOnly = True
            txtId_com.TabStop = False
            datcxc = ConsultaSql("select * from conceptoscxc where id_concepto='" & idcxc & "'").ExecuteReader()
            datcxc.Read()
            txtId_com.Text = datcxc("id_concepto")
            txtDescrip.Text = datcxc("descripcion")

            DIsalario.Value = datcxc("VSM")
            txtMontoIni.Text = datcxc("Monto_Inicial")
            chkSis.Checked = CBool(datcxc("sistema"))
            cmbRubro.SelectedValue = datcxc("rubro")
            cmbEvento.Text = datcxc("Evento")
            txtunidadsat.Text = datcxc("unidadsat")
            txtclavesat.Text = datcxc("clavesat")
            chkAplIva.Checked = CBool(datcxc("aplicaiva"))
            If Not DBNull.Value.Equals(datcxc("porcentaje")) Then
                txtporce.Text = datcxc("porcentaje")
            Else
                txtporce.Text = 0
            End If
            txtctacont.Text = datcxc("cta_cont")

            txtId_com.ReadOnly = True

            If chkSis.Checked Then GoTo INHABILITAR

            If mtipo = Tipo.Ver Then
INHABILITAR:

                txtDescrip.ReadOnly = True

                txtMontoIni.Enabled = False
                chkSis.Enabled = False
                cmbEvento.Enabled = False
                chkAplIva.Enabled = False

                cmdAceptar.Enabled = False
                cmbRubro.Enabled = False

            End If


        End If
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmAgrComu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtId_com.Text = "" Then
            MessageBox.Show("Introduzca la clave del concepto", "Conceptos cxc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId_com.Select()
            Exit Sub
        End If

        If txtDescrip.Text = "" Then
            MessageBox.Show("Introduzca la descripcion del concepto", "Conceptos cxc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescrip.Select()
            Exit Sub
        End If



        If txtclavesat.Text = "" Then
            MessageBox.Show("Introduzca la clave del sat al concepto por favor", "Conceptos cxc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtclavesat.Select()
            Exit Sub
        End If

        If txtunidadsat.Text = "" Then
            MessageBox.Show("Introduzca la clave de la unidad sat del concepto por favor", "Conceptos cxc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtunidadsat.Select()
            Exit Sub
        End If

        Try
            If cmbEvento.SelectedItem.ToString = "" Then
                MessageBox.Show("Establezca el evento", "Conceptos cxc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbEvento.Select()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            If mtipo = Tipo.Agregar Then
                Dim rs As IDataReader = ConsultaSql("select id_concepto from conceptoscxc where id_concepto='" & txtId_com.Text & "'").ExecuteReader
                If rs.Read Then
                    MessageBoxEx.Show("La Clave ya existe, Verifique sus datos", "Conceptos CXC", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtId_com.Select()
                    Exit Sub
                Else
                    If txtporce.Text = "" Then txtporce.Text = "0"
                    If Not cmbEvento.SelectedItem Is Nothing Then
                        Ejecucion("insert into conceptoscxc(Id_concepto,Descripcion,Monto_Inicial,Sistema,Evento,Aplicaiva,Rubro,Porcentaje,Cta_Cont,VSM,unidadsat,clavesat)values('" & txtId_com.Text & "','" & txtDescrip.Text & "'," & txtMontoIni.Value & "," & CBool(chkSis.Checked) & ",'" & cmbEvento.SelectedItem.ToString & "'," & CBool(chkAplIva.Checked) & ",'" & cmbRubro.SelectedValue.ToString & "'," & txtporce.Text & ",'" & txtctacont.Text & "', " & DIsalario.Value & ",'" & txtunidadsat.Text & "','" & txtclavesat.Text & "')")
                    Else
                        Ejecucion("insert into conceptoscxc(Id_concepto,Descripcion,Monto_Inicial,Sistema,evento,aplicaiva,rubro,porcentaje,cta_cont, VSM,unidadsat,clavesat)values('" & txtId_com.Text & "','" & txtDescrip.Text & "'," & txtMontoIni.Value & "," & CBool(chkSis.Checked) & ",'Otros'," & CBool(chkAplIva.Checked) & ",'" & cmbRubro.SelectedValue.ToString & "'," & txtporce.Text & ",'" & txtctacont.Text & "'," & DIsalario.Value & ",'" & txtunidadsat.Text & "','" & txtclavesat.Text & "')")
                    End If
                End If
            Else
                Ejecucion("update conceptoscxc set descripcion='" & txtDescrip.Text & "',monto_inicial=" & txtMontoIni.Value & ",sistema=" & CBool(chkSis.Checked) & ",evento='" & cmbEvento.SelectedItem.ToString & "',aplicaiva=" & CBool(chkAplIva.Checked) & ",rubro='" & cmbRubro.SelectedValue.ToString & "',porcentaje=" & txtporce.Text & ",cta_cont='" & txtctacont.Text & "', VSM=" & DIsalario.Value & ",Unidadsat='" & txtunidadsat.Text & "',clavesat='" & txtclavesat.Text & "' where id_concepto='" & idcxc & "'")
            End If
            MessageBox.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MsgBox(err.Message)
            'MessageBox.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        frmCatConCxC.CatControl1.Actualizar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub



    Private Sub cmbRubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRubro.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub frmAgrCxC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub DIsalario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIsalario.ValueChanged
        Dim salario As Double
        salario = obtenerCampo("select salario from empresa limit 1", "salario")
        txtMontoIni.Value = salario * DIsalario.Value
    End Sub
End Class