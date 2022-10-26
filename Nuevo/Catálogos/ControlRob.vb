Imports DevComponents.DotNetBar
Public Class ControlRob


    Protected _tabu As New TabControl

#Region "Modificadores"
    Public Property tabu() As TabControl
        Get
            Return _tabu
        End Get
        Set(ByVal value As TabControl)
            _tabu = value
        End Set
    End Property
#End Region

    Private Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        Try
            cmbConsulta.Items.Add(cmbCol.SelectedItem)
            cmbCol.Items.Remove(cmbCol.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ControlRob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click
        Try
            cmbCol.Items.Add(cmbConsulta.SelectedItem)
            cmbConsulta.Items.Remove(cmbConsulta.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para quitarlo de la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmdAgrT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgrT.Click
        Try
            For i = 0 To cmbCol.Items.Count - 1
                cmbConsulta.Items.Add(cmbCol.Items(i))
            Next

            cmbCol.Items.Clear()

        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmdQuitT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitT.Click
        Try
            For i = 0 To cmbConsulta.Items.Count - 1
                cmbCol.Items.Add(cmbConsulta.Items(i))
            Next

            cmbConsulta.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmdSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSig.Click
        _tabu.SelectNextTab()
    End Sub

    Private Sub cmdAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnterior.Click
        _tabu.SelectPreviousTab()
    End Sub
End Class
