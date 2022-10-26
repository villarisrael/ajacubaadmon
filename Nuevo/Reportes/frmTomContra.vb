Public Class frmTomContra
    Inherits frmRepUsu
    Public Sub New()
        MyBase.New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        MyBase.tipr = tiporep.TomasCont
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class