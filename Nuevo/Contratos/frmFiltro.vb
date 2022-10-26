Public Class frmFiltro

    Protected campo As String
    Private _frm As frmBusUsuario
#Region "Constructores"
    Public Sub New(ByVal _leyenda As String, ByVal _campo As String)

        InitializeComponent()

        lblL.Text = _leyenda
        campo = _campo
    End Sub

    Public Sub New(ByVal _leyenda As String, ByVal _campo As String, ByVal frm As frmBusUsuario)

        InitializeComponent()

        lblL.Text = _leyenda
        campo = _campo
        _frm = frm
    End Sub
#End Region


    Private Sub txtBus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBus.TextChanged

        Try
            If Not _frm.Modal Then
                Try
                    _frm.consulta("" & campo & " like '%" & txtBus.Text & "%' ")
                Catch err As EvaluateException
                    If txtBus.Text <> "" Then
                        _frm.consulta("" & campo & " = " & txtBus.Text & " ")
                    Else
                        _frm.consulta("" & campo & " > 0 ")
                    End If
                End Try
            Else
                Try
                    _frm.consulta("" & campo & " like '%" & txtBus.Text & "%' ")
                Catch err As EvaluateException
                    If txtBus.Text <> "" Then
                        _frm.consulta("" & campo & " = " & txtBus.Text & " ")
                    Else
                        _frm.consulta("" & campo & " > 0 ")
                    End If
                End Try
            End If
        Catch ex As Exception
            Try
                My.Forms.frmBusUsuario.consulta("" & campo & " like '%" & txtBus.Text & "%' ")
            Catch err As EvaluateException
                If txtBus.Text <> "" Then
                    My.Forms.frmBusUsuario.consulta("" & campo & " = " & txtBus.Text & " ")
                Else
                    My.Forms.frmBusUsuario.consulta("" & campo & " > 0 ")
                End If
            End Try
        End Try


    End Sub

    Private Sub frmFiltro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyCode
        Select Case keyascii
            Case Keys.Enter
                Close()
            Case Keys.Escape
                Try
                    If Not _frm.Modal Then
                        Try
                            _frm.consulta("")
                        Catch err As EvaluateException
                            If txtBus.Text <> "" Then
                                _frm.consulta("")
                            Else
                                _frm.consulta("")
                            End If
                        End Try
                    Else
                        Try
                            _frm.consulta("")
                        Catch err As EvaluateException
                            If txtBus.Text <> "" Then
                                _frm.consulta("")
                            Else
                                _frm.consulta("")
                            End If
                        End Try
                    End If
                Catch ex As Exception
                    Try
                        My.Forms.frmBusUsuario.consulta("")
                    Catch err As EvaluateException
                        If txtBus.Text <> "" Then
                            My.Forms.frmBusUsuario.consulta("")
                        Else
                            My.Forms.frmBusUsuario.consulta("")
                        End If
                    End Try
                End Try
                Close()
        End Select
    End Sub

End Class