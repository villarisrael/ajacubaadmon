Imports DevComponents.DotNetBar

Public Class frmAgrOfi
    Dim mtipo As Tipo
    Dim idofi As String = ""
    Dim datofi As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Sub New(ByVal _mtipo As Tipo, Optional ByVal _idofi As String = "")
        InitializeComponent()

        mtipo = _mtipo
        idofi = _idofi
        If mtipo <> Tipo.Agregar Then
            txtCodOfi.ReadOnly = True
            txtCodOfi.TabStop = False
            datofi = ConsultaSql("select * from oficinas where cod_ofi='" & idofi & "'").ExecuteReader()
            datofi.Read()
            txtCodOfi.Text = datofi("cod_ofi")
            txtDes.Text = datofi("nombre")
            txtUlFol.Text = datofi("ult_folio")
            txtpre.Text = datofi("prefijo")

            If mtipo = Tipo.Ver Then
                txtDes.ReadOnly = True
                txtUlFol.ReadOnly = True
                txtpre.ReadOnly = True
                cmdAcept.Visible = False
            End If

        End If
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub



    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        If txtCodOfi.Text = "" Then
            MessageBox.Show("Introduzca la clave de la oficina", "Oficinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodOfi.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Establezca la descripción de la oficina, por favor", "Oficinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        If txtUlFol.Text = "" Then
            MessageBoxEx.Show("Establezca el último folio para la oficina, por favor", "Oficinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUlFol.Select()
            Exit Sub
        End If


        If txtpre.Text = "" Then
            MessageBoxEx.Show("Establezca el prefijo para la oficina, por favor", "Oficinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpre.Select()
            Exit Sub
        End If


        Try
            If mtipo = Tipo.Agregar Then
                Dim rs As IDataReader = ConsultaSql("Select cod_ofi from oficinas where cod_ofi = '" & txtCodOfi.Text & "'").ExecuteReader
                If rs.Read Then
                    MessageBoxEx.Show("Ya existe esa clave de oficina, verifica tus datos", "Oficinas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    Ejecucion("insert into oficinas values('" & txtCodOfi.Text & "','" & txtDes.Text & "'," & txtUlFol.Text & ",'" & txtpre.Text & "')")
                End If

            Else
                Ejecucion("update oficinas set nombre='" & txtDes.Text & "', ult_folio=" & txtUlFol.Text & ", prefijo='" & txtpre.Text & "' where cod_ofi='" & idofi & "'")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub txtUlFol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUlFol.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub frmAgrOfi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub

End Class