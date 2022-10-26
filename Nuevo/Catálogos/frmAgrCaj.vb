Imports DevComponents.DotNetBar

Public Class frmAgrCaj
    Dim mtipo As Tipo
    Dim idcaja As String = ""
    Dim datcaj As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Sub New(ByVal _mtipo As Tipo, Optional ByVal _idcaja As String = "")
        InitializeComponent()
        llenarCombo(cmbOfi, "select cod_ofi, nombre from oficinas")
        mtipo = _mtipo
        idcaja = _idcaja

        If mtipo <> Tipo.Agregar Then
            txtClavCaj.ReadOnly = True
            txtClavCaj.TabStop = False
            datcaj = ConsultaSql("select * from cajas where id_caja='" & idcaja & "'").ExecuteReader()
            datcaj.Read()
            txtClavCaj.Text = datcaj("id_caja")
            txtSerCaj.Text = datcaj("serie")
            cmbOfi.SelectedValue = datcaj("cod_ofi")
            txtFol.Text = datcaj("folio")
            chkActi.Checked = CBool(datcaj("activo"))
            txtDes.Text = datcaj("descripcion")
            chkMulti.Checked = CBool(datcaj("multicajas"))
            txtRema.Text = datcaj("remanente")
            cmbTcaja.Text = datcaj("tcaja")

            If mtipo = Tipo.Ver Then
                txtFol.ReadOnly = True
                chkActi.Enabled = False
                txtDes.ReadOnly = True
                chkMulti.Enabled = False
                txtRema.ReadOnly = True
                cmbTcaja.Enabled = False
                cmdAcept.Visible = False
            End If
        Else
            chkActi.Checked = True
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmAgrCaj_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyAscii As Keys = e.KeyData
        Select Case keyAscii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub


    Private Sub txtFol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFol.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtRema_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRema.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        Dim ser As Char
        If txtClavCaj.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la caja", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClavCaj.Select()
            Exit Sub
        End If

        If txtSerCaj.Text <> "" Then ser = txtSerCaj.Text Else ser = " "

        If cmbOfi.Text = "" Then
            MessageBoxEx.Show("Establezca la oficina, por favor", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbOfi.Select()
            Exit Sub
        End If

        If txtFol.Text = "" Then
            MessageBoxEx.Show("Establezca el folio para iniciar la caja", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFol.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción de la caja", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        If cmbTcaja.Text = "" Then
            MessageBoxEx.Show("Establezca el tipo de la caja", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbTcaja.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim rs As IDataReader = ConsultaSql("select * from cajas where id_caja = '" & txtClavCaj.Text & "'").ExecuteReader
                If rs.Read Then
                    MessageBoxEx.Show("Ya existe una caja con esa clave, verifique sus datos", "Cajas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    Ejecucion("insert into cajas  (`ID_CAJA`,`Serie`,`COD_OFI`,`Folio`,`Activo`,`descripcion`,`multicajas`,`remanente`,`Tcaja`,`imagentem`) values('" & txtClavCaj.Text & "', '" & ser & "','" & cmbOfi.SelectedValue.ToString & "'," & txtFol.Text & "," & CInt(chkActi.Checked) & ",'" & txtDes.Text & "'," & CInt(chkMulti.Checked) & "," & txtRema.Text & ",'" & cmbTcaja.Text & "','NULL')")
                End If
            Else
                Ejecucion("update cajas set serie='" & ser & "', cod_ofi='" & cmbOfi.SelectedValue.ToString & "', folio=" & txtFol.Text & ", activo=" & CInt(chkActi.Checked) & ", descripcion='" & txtDes.Text & "', multicajas=" & CInt(chkMulti.Checked) & ", remanente=" & txtRema.Text & ", tcaja='" & cmbTcaja.Text & "' where id_caja='" & txtClavCaj.Text & "'")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class