Imports MapWinGIS
Imports AxMapWinGIS

Public Class Frmexplorer

    Public sf As MapWinGIS.Shapefile
    Dim handle_Renamed As Integer
    Dim handle As Long
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        MAP1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn
        '  optCursorMode(0).Checked = True
        MAP1.SendSelectBoxFinal = True
        MAP1.SendMouseUp = True

        'add the header to the list view
        lvLegend.Columns.Add("Nombre")
        lvLegend.Columns.Add("Handle")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MAP1.ZoomToMaxExtents()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MAP1.ZoomToPrev()
    End Sub


    Private Sub AddShapefile(ByRef Filename As String)
        Dim FileSys As New Scripting.FileSystemObject
        'UPGRADE_NOTE: handle se actualizó a handle_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'


        Dim ErrMsg As String
        Dim Item As System.Windows.Forms.ListViewItem

        If LCase(Mid(Filename.ToString, Len(Filename) - 2, 3)) = "shp" Then
            sf = New MapWinGIS.Shapefile
            If sf.Open(Filename) = False Then
                ErrMsg = sf.ErrorMsg(sf.LastErrorCode)
                MsgBox("El archivo , " & Filename & " ha fallado por las siguientes razones:" & vbCrLf & ErrMsg, MsgBoxStyle.Critical)
                Exit Sub
            Else
                handle_Renamed = MAP1.AddLayer(sf, True)

                'exit if this is not a vaild layer handle
                If handle_Renamed < 0 Then Exit Sub

                'set the name of this layer
                MAP1.set_LayerName(handle_Renamed, FileSys.GetFileName(sf.Filename))

                'add the layer to the legend
                'UPGRADE_WARNING: El límite inferior de la colección lvLegend.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'lvLegend.Items.Insert(1, MAP1.get_LayerName(handle_Renamed))
                'Item = New ListViewItem()
                'Item.SubItems.Add(CStr(handle_Renamed))
                'Item.Tag = CStr(handle_Renamed)
                'Item.Checked = True

                'set random colors for the fill color and outline color
                Try
                    ' MAP1.set_ShapeLayerFillColor(handle_Renamed, 16738740)
                    MAP1.set_ShapeLayerDrawLine(handle_Renamed, 4915330)



                    MAP1.Redraw()
                    MAP1.Refresh()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MsgBox("El archivo, " & Filename & " no es un shapefile.")
        End If
    End Sub


    Private Sub cmdOrg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrg.Click
        Dim Filename As String
        Dim FileSys As New Scripting.FileSystemObject
        Dim sf As New MapWinGIS.Shapefile
        'UPGRADE_WARNING: La propiedad CancelError de CommonDialog no se admite en Visual Basic .NET. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        'cdlOpen.CancelError = True
        On Error GoTo ERRORHANDLER
        'UPGRADE_WARNING: Filter tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        cdlOpenOpen.Filter = sf.CdlgFilter 'this gives you a filter for shapefiles
        cdlOpenOpen.ShowDialog()
        Filename = cdlOpenOpen.FileName
        If FileSys.FileExists(Filename) = False Then
            MsgBox("EL ARCHIVO, " & Filename & " NO FUE ENCONTRADO.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            AddShapefile(Filename)
            ''clear all the items in the combo box
            cbLayerToLabel.Items.Clear()

            ''add all the layers of the map to the combo box
            Dim i As Long, handle As Long, layerName As String
            For i = 0 To MAP1.NumLayers - 1
                handle = MAP1.get_LayerHandle(i)
                layerName = MAP1.get_LayerName(handle)
                cbLayerToLabel.Items.Add(handle & " - " & layerName)
            Next
            cbLayerToLabel.SelectedIndex = 0
            cbFieldToUse.Items.Clear()


            ''add all the fields for this layer to the combo box
            If cbLayerToLabel.Items.Count > 0 And cbLayerToLabel.Text <> "" Then
                handle = Split(cbLayerToLabel.Text, " - ")(0)


                sf = MAP1.get_GetObject(handle)

                For i = 0 To sf.NumFields - 1
                    cbFieldToUse.Items.Add(i & " - " & sf.Field(i).Name)
                Next
                cbFieldToUse.SelectedIndex = 0
            End If
        End If

        Exit Sub
ERRORHANDLER:
        'dialog was cancelled
    End Sub

    Private Sub ButtonItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        'UPGRADE_NOTE: handle se actualizó a handle_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim handle_Renamed As Integer

        'check to make sure the selected item is not nothing
        If (lvLegend.FocusedItem Is Nothing) Then Exit Sub

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lvLegend.SelectedItem.Tag. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        handle_Renamed = lvLegend.FocusedItem.Tag

        'remove this layer from the map
        MAP1.RemoveLayer((handle_Renamed))

        'remove this layer from the legend
        Dim i As Integer
        For i = 1 To lvLegend.Items.Count
            'UPGRADE_WARNING: El límite inferior de la colección lvLegend.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If (lvLegend.Items.Item(i).Tag = handle_Renamed) Then
                lvLegend.Items.RemoveAt((i))
            End If
        Next
    End Sub

    Private Sub ButtonItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        On Error Resume Next
        MAP1.RemoveAllLayers()

        'remove all layers in the legend
        lvLegend.Items.Clear()
    End Sub

    Private Sub ButtonItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        MAP1.ZoomToMaxExtents()
    End Sub

    Private Sub ButtonItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        MAP1.ZoomToPrev()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        MAP1.CursorMode = MapWinGIS.tkCursorMode.cmPan
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        MAP1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut
    End Sub


    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        MAP1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn
    End Sub


    Private Sub lvLegend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLegend.Click
        Dim i As Long

        ''cycle through all the layers and unselect any selected shapes
        For i = 0 To MAP1.NumLayers - 1
            handle = MAP1.get_LayerHandle(i)
            'MAP1.get_ShapeLayerLineColor(handle) = MAP1.get_ShapeLayerLineColor(handle)
            'MAP1.ShapeLayerFillColor(handle) = MAP1.ShapeLayerFillColor(handle)
        Next
    End Sub

    Private Sub lvLegend_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvLegend.ItemCheck
        Dim Item As System.Windows.Forms.ListViewItem = lvLegend.Items(e.Index)
        'UPGRADE_NOTE: handle se actualizó a handle_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim handle_Renamed As Integer
        Dim i As Integer

        'cycle through all of the layers to set visibility
        For i = 1 To lvLegend.Items.Count

            'get the handle of the layer
            'UPGRADE_WARNING: El límite inferior de la colección lvLegend.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lvLegend.ListItems().Tag. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            handle_Renamed = lvLegend.Items.Item(i).Tag

            'UPGRADE_WARNING: El límite inferior de la colección lvLegend.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If (lvLegend.Items.Item(i).Checked = True) Then
                MAP1.set_LayerVisible(handle_Renamed, True)
            Else
                MAP1.set_LayerVisible(handle_Renamed, False)
            End If
        Next
    End Sub


    Private Sub Frmexplorer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub btnClearLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearLabels.Click
        Dim i As Long, handle As Long

        ''clear all labels for each layer
        For i = 0 To MAP1.NumLayers - 1
            handle = MAP1.get_LayerHandle(i)
            MAP1.ClearLabels(handle)
        Next
        MAP1.Redraw()
    End Sub

    Private Sub cmdFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFontColor.Click
        Dim newColor As Color
        '   cdlOpen.CancelError = True
        On Error GoTo ERRORHANDLER
        cdlOpen.ShowDialog()
        On Error GoTo 0
        newColor = cdlOpen.Color
        cmdFontColor.BackColor = newColor
ERRORHANDLER:
        'cancel was clicked
    End Sub

    Private Sub cmdLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLabel.Click


        Dim fieldIndex As Long
        Dim text As String
        Dim i As Long

        If (cbLayerToLabel.Text = "" Or cbFieldToUse.Text = "") Then Exit Sub

        On Error Resume Next

        ''get the layer handle
        handle = Split(cbLayerToLabel.Text, " - ")(0)

        ''get the field index
        fieldIndex = Split(cbFieldToUse.Text, " - ")(0)

        sf = MAP1.get_GetObject(handle)
        For i = 0 To sf.NumShapes - 1
            text = sf.CellValue(fieldIndex, i)
            MAP1.AddLabel(handle, text, 466561, sf.Shape(i).Extents.xMin, sf.Shape(i).Extents.yMin, MapWinGIS.tkHJustification.hjCenter)
        Next i
        MAP1.Redraw()
    End Sub

    Private Sub cbLayerToLabel_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLayerToLabel.DropDown

    End Sub

    Private Sub cbLayerToLabel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLayerToLabel.SelectedIndexChanged

    End Sub

    Private Sub cbFieldToUse_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFieldToUse.DropDown
        ''clear all the items in the combo box

    End Sub
    Private Sub MostrarPoligonoPorAtributo(atributo As Int32)
        Dim valorBuscado As String = txtubicacion.Text.Trim()
        Dim datos As IDataReader = ConsultaSql("select * from vusuario where ubicacion='" & txtubicacion.Text & "'").ExecuteReader
        If datos.Read Then
            Dim total As Decimal = Decimal.Parse(datos("Total"))
            lblnombre.Text = "<font color=""#ED1C24""><b>" & datos("Nombre") & "</b></font>"
            lbltotal.Text = "<font color=""#ED1C24""><b>" & total.ToString("C") & "</b></font>"
            lblcolonia.Text = "<font color=""#ED1C24""><b>" & datos("Colonia") & "</b></font>"
            lblTarifa.Text = "<font color=""#ED1C24""><b>" & datos("descripcion_cuota") & "</b></font>"
            lbldireccion.Text = "<font color=""#ED1C24""><b>" & datos("direccion") & "</b></font>"
        End If


        If Not String.IsNullOrEmpty(valorBuscado) Then
            ' Iterar a través de las capas del mapa
            For i As Integer = 0 To MAP1.NumLayers - 1
                Dim capa As Shapefile = sf

                ' Verificar si la capa es un shapefile y si tiene un campo de atributo en la posición 0
                If capa IsNot Nothing AndAlso capa.NumFields > 0 Then
                    ' Obtener el índice del campo de atributo en la posición 0
                    Dim indiceCampo As Integer = 0

                    ' Verificar si el valor buscado existe en el campo de atributo
                    If capa.Field(atributo).Name = "Clave" Then
                        ' Mostrar el polígono correspondiente
                        MostrarPoligono(capa, atributo, valorBuscado)
                        Return
                    End If
                End If
            Next

            MessageBox.Show($"No se encontró un polígono con el valor {valorBuscado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ingrese un valor válido en TextBox1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Este método muestra el polígono correspondiente al valor del atributo
    Private Sub MostrarPoligono(capa As Shapefile, indiceCampo As Integer, valorBuscado As String)
        ' Iterar a través de las formas en la capa
        Dim encontrado As Boolean = False
        Dim ext As MapWinGIS.Extents = capa.Extents

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For j As Integer = 0 To capa.NumShapes - 1
            Dim valorAtributo As String
            ' Obtener el valor del atributo en la posición 0 de la forma actual
            Try
                valorAtributo = capa.CellValue(indiceCampo, j).ToString()
            Catch ex As Exception
                valorAtributo = ""
            End Try

            Dim condicion As String = "clave = '" & valorBuscado & "'"

            ' Verificar si el valor del atributo coincide con el valor buscado
            If valorAtributo = valorBuscado Then
                capa.SelectShapes(capa.Shape(j).Extents, MapWinGIS.SelectMode.INCLUSION, 2)

                AdvTree1.Nodes.Clear()
                For k = 2 To 30
                    Dim celda As New DevComponents.AdvTree.Cell
                    celda.Text = capa.CellValue(k, j)
                    Dim nodo As New DevComponents.AdvTree.Node
                    nodo.Cells(0).Text = capa.Field(k).Name
                    nodo.Cells.Add(celda)
                    AdvTree1.Nodes.Add(nodo)
                Next
                ' Seleccionar y resaltar el polígono
                lblmanzana.Text = "<font color=""#ED1C24""><b>" & capa.CellValue(13, j) & "</b></font>"
                Dim punto As Point = capa.Shape(j).Point(1)

                MAP1.DrawCircle(punto.x, punto.y, 60, 4915330, True)
                MAP1.set_ShapeFillColor(handle, j, 10744576)
                MAP1.set_ShapeLineColor(handle, j, 4915330)
                MAP1.set_ShapeDrawLine(handle, j, True)
                MAP1.set_ShapeDrawFill(handle, j, True)
                Dim text As String
                text = sf.CellValue(indiceCampo, j)
                MAP1.AddLabel(handle, text, 466561, sf.Shape(j).Extents.xMin, sf.Shape(j).Extents.yMin, MapWinGIS.tkHJustification.hjCenter)
                MAP1.ZoomToShape(handle, j)
                MAP1.ZoomOut(10.0)
                encontrado = True
            Else
                MAP1.set_ShapeLineColor(0, j, 4915330)
                MAP1.set_ShapeDrawLine(0, j, True)

                MAP1.set_ShapeFillColor(0, j, 1447446)
                MAP1.set_ShapeDrawFill(0, j, True)
                '  MAP1.ZoomToShape(0, j)
            End If
        Next


        MAP1.Redraw()
        ' Redibujar el mapa


        ' Centrar el mapa en el polígono seleccionado

        If encontrado = False Then
            MessageBox.Show($"No se encontró un polígono con el valor {valorBuscado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' 
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        MostrarPoligonoPorAtributo(1)
    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click
        MAP1.CursorMode = MapWinGIS.tkCursorMode.cmPan
    End Sub

    Private Sub cbFieldToUse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFieldToUse.SelectedIndexChanged

    End Sub
End Class