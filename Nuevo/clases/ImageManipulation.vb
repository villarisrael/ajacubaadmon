Imports System.Drawing.Imaging

Public Class ImageManipulation
    Public Shared Function GetEncoderInfo(ByVal mimeType As String) As ImageCodecInfo
        Dim j As Integer
        Dim encoders As ImageCodecInfo()
        encoders = ImageCodecInfo.GetImageEncoders()
        For j = 0 To encoders.Length
            If encoders(j).MimeType = mimeType Then
                Return encoders(j)
            End If
        Next j
        Return Nothing
    End Function

    Public Shared Sub SaveJPGWithCompressionSetting(ByVal image As Image, ByVal szFileName As String, ByVal lCompression As Long)
        Dim eps As EncoderParameters = New EncoderParameters(1)
        eps.Param(0) = New EncoderParameter(Encoder.Quality, lCompression)
        Dim ici As ImageCodecInfo = GetEncoderInfo("image/jpeg")
        Try
            image.Save(szFileName, ici, eps)
        Catch exc As Exception
            MessageBox.Show(exc, " Atención !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = System.IO.Path.GetTempFileName()
        Dim SourceToImage As New Bitmap(img)
        Dim NeedsHorizontalCrop As Boolean = True
        Dim NeedsVerticalCrop As Boolean = False
        'Determina si la imagen es Landscape o Portrait
        If SourceToImage.Height > SourceToImage.Width Then
            NeedsHorizontalCrop = False
            NeedsVerticalCrop = True
        End If
        'Determina si la imagen excede el ancho del PictureBox
        If SourceToImage.Width < 300 Then
            NeedsHorizontalCrop = False
            If SourceToImage.Height > 220 Then
                NeedsVerticalCrop = True
            End If
        End If
        'Calcula el Factor de Ajuste
        Dim scale_factor As Single = 1
        If SourceToImage.Width > 0 Then
            If NeedsHorizontalCrop = True Then
                ' Obtiene el Factor de Ajuste
                scale_factor = 300 / SourceToImage.Width
            End If
        End If
        If SourceToImage.Height > 0 Then
            If NeedsVerticalCrop = True Then
                ' Obtiene el Factor de Ajuste
                scale_factor = 220 / SourceToImage.Height
            End If
        End If
        ' Generar un bitmap tmp para el resultado. Ajuste Proporcional
        Dim DestTmpImage As New Bitmap(CInt(SourceToImage.Width * scale_factor), CInt(SourceToImage.Height * scale_factor))
        ' Generar un objeto Gráfico para el bitmap tmp resultante
        Dim gr_desttmp As Graphics = Graphics.FromImage(DestTmpImage)
        ' Copiar la imagen origen al bitmap tmp destino
        gr_desttmp.DrawImage(SourceToImage, 0, 0, DestTmpImage.Width, DestTmpImage.Height)
        'Comprime y Guarda un Archivo Temporal para calcular su peso en Kb
        Try
            ImageManipulation.SaveJPGWithCompressionSetting(DestTmpImage, sTemp, 70)
        Catch exc As Exception
            MessageBox.Show(exc, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim fs As System.IO.FileStream
        Dim FileSize As UInt32
        fs = New System.IO.FileStream(sTemp, System.IO.FileMode.Open, System.IO.FileAccess.Read)
        FileSize = fs.Length
        Dim rawData() As Byte
        rawData = New Byte(FileSize) {}
        fs.Read(rawData, 0, FileSize)
        fs.Close()
        Return rawData
    End Function
    Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New System.IO.MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function
End Class

