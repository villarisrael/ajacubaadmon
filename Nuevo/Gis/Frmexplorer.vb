Imports MapWinGIS

Public Class Frmexplorer



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
        Dim sf As MapWinGIS.Shapefile
        Dim handle_Renamed As Integer
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
                Item = lvLegend.Items.Insert(1, MAP1.get_LayerName(handle_Renamed))
                Item.SubItems.Add(CStr(handle_Renamed))
                Item.Tag = CStr(handle_Renamed)
                Item.Checked = True

                'set random colors for the fill color and outline color
                MAP1.set_ShapeLayerFillColor(handle_Renamed, System.Convert.ToUInt32(System.Drawing.ColorTranslator.FromOle(RGB((255 - 1) * Rnd(), (255 - 1) * Rnd(), (255 - 1) * Rnd()))))
                MAP1.set_ShapeLayerLineColor(handle_Renamed, System.Convert.ToUInt32(System.Drawing.ColorTranslator.FromOle(RGB((255 - 1) * Rnd(), (255 - 1) * Rnd(), (255 - 1) * Rnd()))))
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

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        MAP1.CursorMode = MapWinGIS.tkCursorMode.cmSelection
    End Sub

    Private Sub lvLegend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLegend.Click
        Dim i As Long, handle As Long

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

    ''' <summary>
    '''  ACTUALIZAR
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        'Dim Filename As String
        'Dim FileSys As New Scripting.FileSystemObject
        'cdlOpenOpen.Filter = "archivos dbf |*.dbf"
        'cdlOpenOpen.ShowDialog()
        'Filename = cdlOpenOpen.FileName
        'If FileSys.FileExists(Filename) = False Then
        '    MsgBox("El archivo, " & Filename & " no fue encontrado", MsgBoxStyle.Critical)
        '    Exit Sub
        'Else
        '    conectar()
        '    MessageBoxEx.Show("Esta operacion puede tardar varios minutos")
        '    Dim ConnectionStringGis As String
        '    Dim directorio As String
        '    Dim posi As Integer
        '    posi = Filename.LastIndexOf("\")
        '    directorio = Mid(Filename, 1, posi)
        '    ' abre la conexion de la base
        '    ConnectionStringGis = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & directorio & ";Extended Properties=dBase III"
        '    dBaseConnection = New System.Data.OleDb.OleDbConnection(ConnectionStringGis)
        '    dBaseConnection.Open()
        '    ' abre la tabla
        '    Dim ConsultaSqlDbase = New OleDb.OleDbCommand, ConsultaSql2 = New OleDb.OleDbCommand
        '    Dim da As New OleDb.OleDbDataAdapter(ConsultaSqlDbase)
        '    Dim ds As New DataSet
        '    ConsultaSqlDbase.Connection = dBaseConnection
        '    ConsultaSql2.Connection = dBaseConnection
        '    ConsultaSqlDbase.CommandText = "select * from agua"
        '    ConsultaSqlDbase.CommandType = CommandType.Text
        '    ConsultaSql2.CommandType = CommandType.Text
        '    Dim dr As IDataReader

        '    dr = ConsultaSqlDbase.ExecuteReader
        '    Dim cu As Integer
        '    Dim comu As String

        '    Do While dr.Read()
        '        cu = dr("cuenta")
        '        comu = dr("id_comunid")
        '        Dim consusu As Odbc.OdbcCommand
        '        consusu = ConsultaSql("select * from estados where cuenta=" & cu & " and id_comunidad='" & comu & "' AND ULTIMO=1")
        '        Dim xr As IDataReader

        '        xr = consusu.ExecuteReader()
        '        If xr.RecordsAffected > 0 Then
        '            xr.Read()
        '            Dim cadena As New StringBuilder
        '            cadena.Remove(0, Len(cadena.ToString))
        '            cadena.Append("update agua set id_region='" & xr("id_region") & "'")
        '            cadena.Append(", id_ruta='" & xr("id_ruta") & "',")
        '            'cadena.Append(" cod_hor=" & xr("cod_hor") & ",")
        '            cadena.Append(" cod_ser='" & xr("cod_ser") & "',")
        '            cadena.Append(" cod_toma='" & xr("cod_toma") & "',")
        '            cadena.Append(" cod_usu='" & xr("cod_usU") & "',")
        '            cadena.Append(" lote='" & xr("lote") & "',")
        '            cadena.Append(" MES_PERIOD='" & xr("MES_PERIODO") & "',")
        '            cadena.Append(" AN_PER=" & xr("AN_PER") & ",")
        '            cadena.Append(" medidor='" & xr("medidor") & "',")

        '            cadena.Append(" mzn=" & xr("mzn") & ",")

        '            cadena.Append(" tarifa='" & xr("tarifa") & "',")
        '            cadena.Append(" mesahoy=" & xr("meses_a_hoy") & ",")
        '            Dim SUMA1 As Double = 0, SUMA2 As Double = 0
        '            SUMA1 = xr("REZ_CON") + xr("REZ_DRE") + xr("REZ_SAN") + xr("REZ_REC") + xr("REZ_IVA")
        '            SUMA2 = xr("CONSUMO") + xr("DRENAJE") + xr("SANEAMIENTO") + xr("IVA")
        '            Dim totalde As Double = 0
        '            totalde = SUMA1 + SUMA2

        '            cadena.Append(" t_a_hoy=" & totalde & ",")
        '            cadena.Append("mes_rez=" & xr("mes_rez") & ",")
        '            cadena.Append("alto_cons=" & xr("alto_cons"))
        '            cadena.Append(",lec_Act=" & xr("lec_act"))
        '            cadena.Append(" where cuenta= " & cu & " and id_comunid='" & comu & "'")

        '            ConsultaSql2.CommandText = cadena.ToString
        '            ConsultaSql2.CommandType = CommandType.Text
        '            ConsultaSql2.ExecuteNonQuery()
        '            Ejecucion("update usuario set regGis=1 where cuenta=" & cu & " and id_comunidad='" & comu & "'")
        '        End If
        '    Loop
        '    MessageBoxEx.Show("Ya termine")
        'End If
    End Sub



    Private Sub RibbonBar4_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonBar4.ItemClick

    End Sub

    Private Sub btnClearLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearLabels.Click
        Dim i As Long, handle As Long

        ''clear all labels for each layer
        For i = 0 To MAP1.NumLayers - 1
            handle = MAP1.get_LayerHandle(i)
            MAP1.ClearLabels(handle)
        Next
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
        Dim sf As MapWinGIS.Shapefile
        Dim handle As Long
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
    End Sub

    Private Sub cbLayerToLabel_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLayerToLabel.DropDown
        ''clear all the items in the combo box
        cbLayerToLabel.Items.Clear()

        ''add all the layers of the map to the combo box
        Dim i As Long, handle As Long, layerName As String
        For i = 0 To MAP1.NumLayers - 1
            handle = MAP1.get_LayerHandle(i)
            layerName = MAP1.get_LayerName(handle)
            cbLayerToLabel.Items.Add(handle & " - " & layerName)
        Next
    End Sub

    Private Sub cbLayerToLabel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLayerToLabel.SelectedIndexChanged

    End Sub

    Private Sub cbFieldToUse_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFieldToUse.DropDown
        ''clear all the items in the combo box
        cbFieldToUse.Items.Clear()

        Dim i As Long, handle As Long

        ''add all the fields for this layer to the combo box
        If cbLayerToLabel.Items.Count > 0 And cbLayerToLabel.Text <> "" Then
            handle = Split(cbLayerToLabel.Text, " - ")(0)

            Dim sf As MapWinGIS.Shapefile
            sf = MAP1.get_GetObject(handle)

            For i = 0 To sf.NumFields - 1
                cbFieldToUse.Items.Add(i & " - " & sf.Field(i).Name)
            Next

        End If
    End Sub

    Private Sub cbFieldToUse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFieldToUse.SelectedIndexChanged

    End Sub

    Private Sub lvLegend_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLegend.SelectedIndexChanged

    End Sub
End Class