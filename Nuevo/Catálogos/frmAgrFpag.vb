Imports DevComponents.DotNetBar

Public Class frmAgrFpag
    Dim mtipo As Tipo
    Dim idFp As String = ""
    Dim dfp As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idFp() As String
        Get
            Return idFp
        End Get
        Set(ByVal value As String)
            idFp = value
            dfp = ConsultaSql("select * from fpago where ccodpago='" & idFp & "'").ExecuteReader()
            dfp.Read()
        End Set
    End Property

    Public Sub New(ByVal _mtipo As Tipo)
        InitializeComponent()
        mtipo = _mtipo
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        If txtClavF.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la forma de pago", "Forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClavF.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción de la forma de pago", "Forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim idv As IDataReader = ConsultaSql("select ccodpago from fpago where ccodpago='" & txtClavF.Text & "'").ExecuteReader()
                If idv.Read() Then
                    MessageBoxEx.Show("La clave esta repetida, verifique sus datos", "Forma de Pago", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtClavF.Select()
                    Exit Sub
                End If
                Ejecucion("insert into fpago values(""" & txtClavF.Text & """,""" & txtDes.Text & """," & txtDp.Value & "," & CInt(chkRef.Checked) & ")")
            Else
                Ejecucion("update fpago set cdespago='" & txtDes.Text & "', ndiasapl=" & txtDp.Value & ", referencia=" & CInt(chkRef.Checked) & " where ccodpago=""" & idFp & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub llenar()
        txtClavF.Text = dfp("ccodpago")
        txtDes.Text = dfp("cdespago")
        txtDp.Value = dfp("ndiasapl")
        chkRef.Checked = dfp("referencia")
    End Sub

    Private Sub frmAgrFpag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrFpag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo <> Tipo.Agregar Then
            llenar()
            txtClavF.Enabled = False
            If mtipo = Tipo.Ver Then
                txtDes.Enabled = False
                chkRef.Enabled = False
                cmdAcept.Enabled = False
                txtDp.Enabled = False
            End If
        End If
    End Sub
End Class