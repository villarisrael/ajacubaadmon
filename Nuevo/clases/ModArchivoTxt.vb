Imports System.IO
Module ModArchivoTxt

    Public ArchivoTxt As String

    Public Function LeerTxt(ByVal FullPath As String, Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try
            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
            Return ""
        End Try
    End Function

    Public Function GuardarTxt(ByVal strData As String, Optional ByVal ErrInfo As String = "") As Boolean
        ' Dim x As New ClassRegistros
        Dim txt As String
        txt = "c:\tablets\" & "Importacion" & NumCaja & "-" & Oficina & "-" & Format(Now.Day, "00") & "-" & Format(Now.Month, "00") & "-" & Now.Year & ".txt"

        Dim bAns As Boolean = False
        'Dim objReader As StreamWriter
        Try
            'objReader = New StreamWriter(txt)
            'objReader.WriteLine(strData)
            'objReader.Close()


            ' Crea el archivo  
            FileOpen(1, txt, OpenMode.Append)
            ' escribe el contenido  
            WriteLine(1, strData)
            FileClose(1) ' lo cierra 
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
        Return bAns
    End Function

    Public Function Guardarerroresimportacion(ByVal strData As String, ByVal ARCHIVO As String) As Boolean
        'Dim x As New ClassRegistros
        Dim bAns As Boolean = True
        Dim txt As String
        txt = "\ERRORIMPORTACION" & ARCHIVO & ".txt"

        Dim myStreamWriter As System.IO.StreamWriter
        Try
            myStreamWriter = System.IO.File.AppendText(Archivo)

            myStreamWriter.Write(strData & ";" & Chr(13))
            myStreamWriter.Flush()
            myStreamWriter.Close()
            bAns = True
        Catch ex As Exception

        End Try
        Return bAns
    End Function
    Public Sub DespliegaCombo(ByVal Combo As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'If KeyAscii = 8 Then
        'Combo.SelectedIndex = -1
        'End If
        e.KeyChar = UCase(e.KeyChar)
        Combo.DroppedDown = True
    End Sub
    Public Sub DespliegaCombo(ByVal Combo As ComboBox)
        Combo.DroppedDown = True
    End Sub
End Module
