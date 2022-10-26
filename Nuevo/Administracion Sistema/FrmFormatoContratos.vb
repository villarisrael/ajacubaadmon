Imports DevComponents.DotNetBar

Public Class FrmFormatoContratos

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub FrmFormatoContratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As IDataReader = ConsultaSql("Select * from formatocontrato").ExecuteReader
        rs.Read()
        TxtTitulo1.Text = rs("contrato1")
        TxtTitulo2.Text = rs("contrato2")
        TxtTitulo3.Text = rs("contrato3")
        TxtClausulas1.Text = rs("clausula1")
        TxtClausulas2.Text = rs("clausula2")
        TxtClausulas3.Text = rs("clausula3")
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Ejecucion("update formatocontrato set contrato1 = '" & TxtTitulo1.Text & "', contrato2 = '" & TxtTitulo2.Text & "', contrato3 = '" & TxtTitulo3.Text & "', clausula1 = '" & TxtClausulas1.Text & "', clausula2 = '" & TxtClausulas2.Text & "', clausula3 = '" & TxtClausulas3.Text & "'")
            MessageBoxEx.Show("Cambios en los formatos realizados satisfactoriamente", "Formato de contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Formato de contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
End Class