Imports DevComponents.DotNetBar

Public Class frmBusCat


    Private campo As String

    Private so As BindingSource


    Public Sub New(ByVal _campo As String, ByVal _so As BindingSource, ByVal _mens As String, ByVal _Tipo As Object)
        InitializeComponent()
        campo = _campo
        so = _so
        lblMsg.Text = _mens
        'Dim Cod As 

        If _Tipo.GetType.Name = "Date" OrElse _Tipo.GetType.Name = "DateTime" Then
            txtBus.Visible = False
            Fecha.Visible = True
        Else
            txtBus.Visible = True
            Fecha.Visible = False
        End If
    End Sub

    Private Sub txtBus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBus.TextChanged
        Try
            so.Filter = campo & " like '%" & txtBus.Text & "%'"
            If campo = "CUENTA" And Len(txtBus.Text) > 0 And Val(txtBus.Text) = 0 Then
                MsgBox("Debes introducir números")
                Exit Sub
            End If
        Catch ex As Exception
            Try
                If txtBus.Text <> "" Then
                    so.Filter = campo & " = " & txtBus.Text
                Else
                    so.Filter = campo & " > 0"
                End If
            Catch ex1 As Exception
                If ex1.Message.Contains("No se puede encontrar la columna") Then
                    Me.SendToBack()
                    If txtBus.Text.GetType.Name = "String" Then
                        MessageBoxEx.Show("En este campo sólo hay valores numéricos, asi que, no intente introducir letras u otros caracteres, no tiene sentido...", "Búsqueda en catálogos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBoxEx.Show("En este campo sólo hay valores de tipo letra, asi que, no intente introducir números u otros caracteres, no tiene sentido...", "Búsqueda en catálogos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    Me.Close()
                End If
            End Try

        End Try
    End Sub
    Private Sub Fecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fecha.ValueChanged
        Try
            so.Filter = campo & " = '" & UnixDateFormat(Fecha.Value) & "'"
        Catch ex As Exception

        End Try
    End Sub

    Public Function darCad() As String
        Return so.Filter
    End Function

    Private Sub frmBusCat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyCode
        Select Case keyascii
            Case Keys.Enter
                Close()
            Case Keys.Escape
                so.Filter = ""
                Close()
        End Select


    End Sub

    Private Sub frmBusCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class