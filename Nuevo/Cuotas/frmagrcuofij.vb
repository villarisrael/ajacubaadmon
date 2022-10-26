Public Class frmagrcuofij
    Public tarifa As String
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub frmagrcuofij_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IIano.Value = Year(Now)
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim bas As New base
        Try
            'bas.conectar()

            bas.ejecutar("INSERT INTO cuofij (`tarifa`,`periodo`,`pago_agua`,`pago_alcant`,`recargo`,`saneamiento`,`SM`)  VALUES ( '" & tarifa & "'," & IIano.Value & "," & IIcuoSM.Value & "," & IIAlcanta.Value & ",0," & IIsanea.Value & "," & IIcuoSM.Value & ")")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Close()
    End Sub

    Private Sub IIcuoSm_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IIcuoSM_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IIcuoSM.ValueChanged
        IIcuodinero.Value = IIcuoSM.Value * salariominimo
    End Sub
End Class