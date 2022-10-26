Public Class FrmAgrcuo
    Public tarifa As String

    Private Sub IIRangoinf_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IIRangoinf.ValueChanged
        IIRangoSup.MinValue = IIRangoinf.Value

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim bas As New base
        Try
            bas.conectar()
            bas.ejecutar("insert into medidor (id_tarifa,rango_inf, Rango_sup, vsm_agua, tarifa_agua, anofiscal) values ('" & tarifa & "', " & IIRangoinf.Value & "," & IIRangoSup.Value & "," & DISM.Value & "," & dim3.Value & ",year(curdate()) )")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Close()
    End Sub

    Private Sub DISM_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISM.ValueChanged
        Dim salario As Double
        salario = obtenerCampo("select salario from empresa limit 1", "salario")
        dim3.Value = DISM.Value * salario

    End Sub
End Class