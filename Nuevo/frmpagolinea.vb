Imports System.Data.Odbc
Imports System.IO

Public Class frmpagolinea
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As OdbcConnection
        conn = New OdbcConnection("dsn=Agua")

        conn.Open()
        Dim fecha As String = acompletac(MonthCalendarAdv1.SelectedDate.Month.ToString(), 2) & acompletac(MonthCalendarAdv1.SelectedDate.Day.ToString(), 2) + "" & MonthCalendarAdv1.SelectedDate.Year



        Dim da As New OdbcDataAdapter("select ubicacion,nombre,direccion, '" + fecha + "',format( consumo,2),format(alcaconsumo,2), format(deudaagua+deudaalcantarillado+otros,2),format(total-iva-recargos,2),format(iva,2),format(recargos,2),format(total,2) from vusuario where total>0", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        Dim datos As String = CSVBuilder(dt)

        Dim nombredearchivo As String

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            nombredearchivo = SaveFileDialog1.FileName
            If (nombredearchivo IsNot Nothing) Then
                Using writer As New StreamWriter(nombredearchivo, True)
                    writer.WriteLine(datos)
                End Using
            End If
            MessageBox.Show("Datos Generados en " & nombredearchivo)
        End If

        Close()
    End Sub

    Public Function acompletac(ByVal cadena As String, ByVal cuantos As Integer) As String
        Dim longi As Integer
        Dim cadenafinal As String = String.Empty
        longi = cuantos - cadena.Length
        For i = 1 To longi
            cadenafinal += "0" & cadena
        Next
        Return cadenafinal
    End Function

    Private Sub frmpagolinea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendarAdv1.SelectedDate = Now
    End Sub
End Class