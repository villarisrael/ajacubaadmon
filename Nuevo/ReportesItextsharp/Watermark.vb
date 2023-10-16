Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Watermark
    Inherits PdfPageEventHelper
    Private imagePath As String ' Ruta de la imagen de la marca de agua

    Public Sub New(imagePath As String)
        Me.imagePath = imagePath
    End Sub

    Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
        MyBase.OnEndPage(writer, document)

        ' Cargar la imagen de la marca de agua
        Dim watermarkImage As Image = Image.GetInstance(imagePath)
        watermarkImage.SetAbsolutePosition(200, 150) ' Ajusta la posición de la marca de agua
        watermarkImage.ScaleAbsolute(400, 400) ' Ajusta el tamaño de la marca de agua

        ' Agregar la imagen de la marca de agua a cada página
        Dim content As PdfContentByte = writer.DirectContentUnder
        content.AddImage(watermarkImage)
    End Sub
End Class
