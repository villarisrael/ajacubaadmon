Public Class frmTomBaja
    Inherits frmRepUsu
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        MyBase.tipr = tiporep.usuariosbaja
    End Sub

    Private Sub frmTomBaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class