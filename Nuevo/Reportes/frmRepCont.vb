Public Class frmRepCont
    Inherits frmRepUsu

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        MyBase.tipr = tiporep.UsuariosCont

    End Sub

    Private Sub frmRepCont_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class