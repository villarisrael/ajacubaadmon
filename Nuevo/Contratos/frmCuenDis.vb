Public Class frmCuenDis
    Private _idcom As String
    Public _cuenta As Double = 0

    Public Sub New(ByVal idcom As String)
        InitializeComponent()
        _idcom = idcom
    End Sub

    Private Sub frmCuenDis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dat As IDataReader = ConsultaSql("select cuenta from usuario where id_comunidad='" & _idcom & "' order by cuenta").ExecuteReader()
        Dim ser As Double = 1
        While dat.Read()
            If dat("cuenta") <> ser Then
                For i = ser To dat("cuenta") - 1
                    listVac.Items.Add(i)
                Next i
                ser = dat("cuenta")
            End If
            ser += 1
        End While

        'If listVac.Items.Count <= 0 Then
        'Me.Finalize()
        'End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'My.Forms.MDIPrincipal.FRMCONTRA.txtclave.Text = listVac.SelectedItem
        _cuenta = listVac.SelectedItem
        Me.Close()
    End Sub
End Class