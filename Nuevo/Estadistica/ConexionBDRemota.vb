Imports System.Data.Odbc
Imports System.Threading.Tasks

Module ConexionBDRemota

    Private conRemoto As OdbcConnection

    Public Sub ConectarRemoto()
        conRemoto = New OdbcConnection("dsn=AguaRemoto")
        If conRemoto.State = ConnectionState.Closed Then
            conRemoto.Open()
        End If
    End Sub

    Public Sub DesconectarRemoto()
        If conRemoto IsNot Nothing AndAlso conRemoto.State = ConnectionState.Open Then
            conRemoto.Close()
        End If
    End Sub

    Public Async Function EjecutarConsultaRemotaAsync(ByVal sqlQuery As String) As Task
        If conRemoto Is Nothing OrElse conRemoto.State <> ConnectionState.Open Then
            Try
                conRemoto.Open()
            Catch ex As Exception

            End Try

        End If

        Try
            Dim cmd As New OdbcCommand(sqlQuery, conRemoto)
            Await cmd.ExecuteNonQueryAsync()
        Catch ex As Exception
            Dim arch As New clsDocumentoTXT
            arch.guardartxt(sqlQuery, $"c:\cajamovil\Remoto{My.Settings.IDComunidadSistema}_{Now.ToString("yyyyMMdd")}.SQL")
        End Try
    End Function

    Public Function ObtenerCampoBDRemoto(ByVal sql As String, ByVal campo As String) As String

        If conRemoto Is Nothing OrElse conRemoto.State <> ConnectionState.Open Then
            Try
                conRemoto.Open()
            Catch ex As Exception

            End Try

        End If

        Dim comDatos As OdbcCommand = New OdbcCommand
        Dim dato As String
        comDatos.Connection = conRemoto
        comDatos.CommandText = sql
        comDatos.CommandType = CommandType.Text
        Try
            Dim dr As System.Data.IDataReader
            dr = comDatos.ExecuteReader()
            Application.DoEvents()
            dr.Read()

            dato = dr(campo)
            dato.ToString()
        Catch ex As Exception
            Return "0"
        End Try

        If dato <> "" Then
            Return dato
        Else
            Return "0"
        End If
    End Function

End Module
