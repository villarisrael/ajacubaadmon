Public Class DlgCambioVerificacion
    Dim _Respuesta As Boolean
    Public Property Respuesta() As Boolean
        Get
            Return _Respuesta
        End Get
        Set(ByVal value As Boolean)
            _Respuesta = value
        End Set
    End Property

    Private Sub BtnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSi.Click
        _Respuesta = True
        Close()
    End Sub

    Private Sub BtnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNo.Click
        _Respuesta = False
        Close()
    End Sub

    Private Sub DlgCambioVerificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnSi.Focus()
    End Sub
End Class