Imports DevComponents
Imports Microsoft.VisualBasic.DateAndTime
Imports System.Data.Odbc
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop

Module funcionesbasicas
   
    Public conn As OdbcConnection
    Public dBaseConnection As System.Data.OleDb.OleDbConnection
    Public NumCaja As Int16
    Public SerieCaja As Char
    Public rema As Double
    Public NumUser As Integer
    Public Tcaja As String, RutaImagenes As String
    Public DirDbase As String = "C:\Prueba"
    Public Empresa As String, Direccion As String, Director As String


    'Public Cobros As frmCobros
    Public dirReport As String
    Public critRez As Int16
    Public hoy As Date
    'Public bRecibos As frmVerRecibos

    Public Enum eve
        Abonos
        Cierre
        Multas
        Requerimientos
        Notas
        Otros
        Lecturas
        Ajustes
        Contratos
        Factibilidad
        Corte
        Reconexion
        Mantenimiento
        CambioNombre
        CambioTarifa
        CambioMedidor
        Cobros
        Convenios
        Todos
    End Enum


    Dim param As New ClassRegistros()
#Region "Operaciones MYSQL"

    Public Sub conectar()
        Tcaja = param.ObtTipoCaja()

        Try
            conn = New OdbcConnection("dsn=Agua")
            conn.Open()
            'Cobros = New frmCobros

            dirReport = param.obtRutaRep
            critRez = param.obtCritRez
            hoy = DateAdd("m", -critRez, Now)
            Dim emp As IDataReader = ConsultaSql("select rutaimagenes, cnombre, cdomicilio, cadminis from empresa").ExecuteReader
            emp.Read()

            RutaImagenes = emp("Rutaimagenes")
            Empresa = emp("cnombre")
            Direccion = emp("cdomicilio")
            Director = emp("cadminis")

        Catch ex As Odbc.OdbcException
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function llenaGrid(ByVal grid As DataGridView, ByVal txtSql As String) As Collection

        llenaGrid = New Collection
        Dim bs As New BindingSource
        Dim sql1 As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql1)
        Dim sqlCommandBuilder As New OdbcCommandBuilder(da)
        Dim ds As New System.Data.DataSet

        sql1.Connection = conn
        sql1.CommandText = txtSql
        sql1.CommandType = CommandType.Text
        da.Fill(ds)

        bs.DataSource = ds.Tables(0)

        grid.DataSource = bs 'ds.Tables(0)
        grid.Refresh()
        Try
            If grid.Rows.Count <> 0 Then
                grid.ClearSelection()
                grid.CurrentCell = grid(0, grid.RowCount - 1)
            End If
        Catch ex As Exception
            Throw New ArgumentOutOfRangeException("Salir")
        End Try
        llenaGrid.Add(bs)
        llenaGrid.Add(da)
    End Function

    Public Function llenarVista(ByVal txtSql As String) As DataView

        Dim sql1 As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql1)
        Dim ds As New System.Data.DataSet

        sql1.Connection = conn
        sql1.CommandText = txtSql
        sql1.CommandType = CommandType.Text

        da.Fill(ds)
        llenarVista = New DataView(ds.Tables(0))
    End Function
    Public Sub llenarCombo(ByVal combo As ComboBox, ByVal txtSql As String)
        Dim da As New OdbcDataAdapter(txtSql, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            combo.DataSource = dt
            combo.ValueMember = dt.Columns(0).ToString
            combo.DisplayMember = dt.Columns(1).ToString
            combo.SelectedIndex = -1
            'combo.Text = ""
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
            'MessageBoxEx.Show("Posible perdida de conexión")
        End Try


    End Sub
    Public Sub llenarCombo(ByVal combo As ToolStripComboBox, ByVal txtSql As String)
        Dim da As New OdbcDataAdapter(txtSql, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        combo.ComboBox.DataSource = dt
        combo.ComboBox.ValueMember = dt.Columns(0).ToString
        combo.ComboBox.DisplayMember = dt.Columns(1).ToString
        combo.Text = ""
    End Sub

    Public Sub llenarCombo(ByVal combo As ComboBox, ByVal campo As String, ByVal txtSql As String)
        Dim sql As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql)
        Dim ds As New DataSet
        sql.Connection = conn
        sql.CommandText = txtSql
        sql.CommandType = CommandType.Text

        Dim dr As System.Data.IDataReader
        dr = sql.ExecuteReader()
        combo.Items.Clear()
        While dr.Read()
            combo.Items.Add(dr(campo))
        End While
    End Sub

    Public Sub llenarCombo(ByVal combo As DevComponents.DotNetBar.ComboBoxItem, ByVal campo As String, ByVal txtSql As String)
        Dim sql As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql)
        Dim ds As New DataSet
        sql.Connection = conn
        sql.CommandText = txtSql
        sql.CommandType = CommandType.Text

        Dim dr As System.Data.IDataReader
        dr = sql.ExecuteReader()
        combo.Items.Clear()
        While dr.Read()
            combo.Items.Add(dr(campo))
        End While
    End Sub

    Public Sub llenarCombo(ByVal combo As System.Windows.Forms.ToolStripComboBox, ByVal campo As String, ByVal txtSql As String)
        Dim sql As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql)
        Dim ds As New DataSet
        sql.Connection = conn
        sql.CommandText = txtSql
        sql.CommandType = CommandType.Text

        Dim dr As System.Data.IDataReader
        dr = sql.ExecuteReader()
        combo.Items.Clear()
        While dr.Read()
            combo.Items.Add(dr(campo))
        End While
    End Sub

    Public Function ConsultaSql(ByVal txtSql As String) As OdbcCommand
        ConsultaSql = New OdbcCommand
        Dim da As New OdbcDataAdapter(ConsultaSql)
        Dim ds As New DataSet
        ConsultaSql.Connection = conn
        ConsultaSql.CommandText = txtSql
        ConsultaSql.CommandType = CommandType.Text

    End Function

    Public Sub llenarCombo(ByVal combo As ComboBox, ByVal campo As String, ByVal campo1 As String, ByVal txtSql As String)
        Dim sql As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql)
        Dim ds As New DataSet
        Dim cadena As String
        sql.Connection = conn
        sql.CommandText = txtSql
        sql.CommandType = CommandType.Text

        Dim dr As System.Data.IDataReader
        dr = sql.ExecuteReader()
        combo.Items.Clear()
        While dr.Read()
            cadena = String.Concat(dr(campo), ", ", dr(campo1))
            combo.Items.Add(cadena)
        End While
    End Sub

    Public Sub llenarCombo(ByVal combo As ComboBox, ByVal campo As String, ByVal campo1 As String, ByVal campo2 As String, ByVal txtSql As String)
        Dim sql As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql)
        Dim ds As New DataSet
        Dim cadena As String
        sql.Connection = conn
        sql.CommandText = txtSql
        sql.CommandType = CommandType.Text

        Dim dr As System.Data.IDataReader
        dr = sql.ExecuteReader()
        combo.Items.Clear()
        While dr.Read()
            cadena = String.Concat(dr(campo), ", ", dr(campo1), ", ", dr(campo2))
            combo.Items.Add(cadena)
        End While
    End Sub

    Public Sub llenarCombo(ByVal combo As ComboBox, ByVal campo As String, ByVal campo1 As String, ByVal campo2 As String, ByVal campo3 As String, ByVal txtSql As String, ByVal delimitador As String)
        Dim sql As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql)
        Dim ds As New DataSet
        Dim cadena As String
        sql.Connection = conn
        sql.CommandText = txtSql
        sql.CommandType = CommandType.Text

        Dim dr As System.Data.IDataReader
        dr = sql.ExecuteReader()
        combo.Items.Clear()
        While dr.Read()
            cadena = String.Concat(dr(campo), delimitador, dr(campo1), delimitador, dr(campo2))
            combo.Items.Add(cadena)
        End While
    End Sub

    Public Sub llenarLista(ByVal Lista As ListBox, ByVal campo As String, ByVal txtSql As String)
        Dim sql As OdbcCommand = New OdbcCommand
        Dim da As New OdbcDataAdapter(sql)
        Dim ds As New DataSet
        sql.Connection = conn
        sql.CommandText = txtSql
        sql.CommandType = CommandType.Text

        Dim dr As System.Data.IDataReader
        dr = sql.ExecuteReader()

        While dr.Read()
            Try
                Lista.Items.Add(dr(campo))
            Catch ex As Exception
                Lista.Items.Add(dr(0))
            End Try

        End While
    End Sub

    Public Sub Ejecucion(ByVal txtSql As String)
		Dim cmd As New OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = txtSql
		cmd.ExecuteNonQuery()
	End Sub

    Public Function obtenerCampo(ByVal sql As String, ByVal campo As String) As String
        Dim comDatos As OdbcCommand = New OdbcCommand
        comDatos.Connection = conn
        comDatos.CommandText = sql
        comDatos.CommandType = CommandType.Text
        Try
            Dim dr As System.Data.IDataReader
            dr = comDatos.ExecuteReader()
            dr.Read()

            obtenerCampo = dr(campo).ToString
        Catch ex As Exception
			obtenerCampo = "0"
		End Try
	End Function

#End Region

    Public Function UnixDateFormat(ByVal DateString As String, Optional ByVal QuoteIt As Boolean = False, Optional ByVal IncludeTime As Boolean = False) As String
        Dim theTemp As String
        Dim mDia As Int16

        mDia = Day(CDate(DateString))
        If IsDate(DateString) Then
            theTemp = Year(CDate(DateString)) & "-" & Month(CDate(DateString)) & "-" & mDia

            If IncludeTime Then theTemp = theTemp & " " & Mid(DateString, 12, 8)
            If QuoteIt Then theTemp = Quote(theTemp)
        Else
            theTemp = " NULL "
        End If
        UnixDateFormat = theTemp
    End Function

    Public Function Quote(ByVal txt As Object, Optional ByVal IsDateValue As Boolean = False) As String
        If IsDateValue Then
            If IsDate(txt) Then
                Quote = UnixDateFormat(txt, True)
            Else
                Quote = "NULL"
            End If
        Else
            txt = Replace(txt, "'", "\'")
            Do While InStr(txt, "\\'")
                txt = Replace(txt, "\\'", "\'")
            Loop

            Do While InStr(txt, "\\")
                txt = Replace(txt, "\\", "\'")
            Loop
            txt = Replace(txt, "\\'", "\'")

            Quote = "'" & txt & "'"
        End If
    End Function

    Function VerificaColor(ByVal Color As String) As System.Drawing.Color
        Select Case Color
            Case "AliceBlue" : VerificaColor = Drawing.Color.AliceBlue
            Case "AntiqueWhite" : VerificaColor = Drawing.Color.AntiqueWhite
            Case "Aqua" : VerificaColor = Drawing.Color.Aqua
            Case "Aquamarine" : VerificaColor = Drawing.Color.Aquamarine
            Case "Azure" : VerificaColor = Drawing.Color.Azure
            Case "Beige" : VerificaColor = Drawing.Color.Beige
            Case "Bisque" : VerificaColor = Drawing.Color.Bisque
            Case "Black" : VerificaColor = Drawing.Color.Black
            Case "BlanchedAlmond" : VerificaColor = Drawing.Color.BlanchedAlmond
            Case "Blue" : VerificaColor = Drawing.Color.Blue
            Case "BlueViolet" : VerificaColor = Drawing.Color.BlueViolet
            Case "Brown" : VerificaColor = Drawing.Color.Brown
            Case "BurlyWood" : VerificaColor = Drawing.Color.BurlyWood
            Case "CadetBlue" : VerificaColor = Drawing.Color.CadetBlue
            Case "Chartreuse" : VerificaColor = Drawing.Color.Chartreuse
            Case "Chocolate" : VerificaColor = Drawing.Color.Chocolate
            Case "Coral" : VerificaColor = Drawing.Color.Coral
            Case "CornflowerBlue" : VerificaColor = Drawing.Color.CornflowerBlue
            Case "Cornsilk" : VerificaColor = Drawing.Color.Cornsilk
            Case "Crimson" : VerificaColor = Drawing.Color.Crimson
            Case "Cyan" : VerificaColor = Drawing.Color.Cyan
            Case "DarkBlue" : VerificaColor = Drawing.Color.DarkBlue
            Case "DarkCyan" : VerificaColor = Drawing.Color.DarkCyan
            Case "DarkGoldenrod" : VerificaColor = Drawing.Color.DarkGoldenrod
            Case "DarkGray" : VerificaColor = Drawing.Color.DarkGray
            Case "DarkGreen" : VerificaColor = Drawing.Color.DarkGreen
            Case "DarkKhaki" : VerificaColor = Drawing.Color.DarkKhaki
            Case "DarkMagenta" : VerificaColor = Drawing.Color.DarkMagenta
            Case "DarkOliveGreen" : VerificaColor = Drawing.Color.DarkOliveGreen
            Case "DarkOrange" : VerificaColor = Drawing.Color.DarkOrange
            Case "DarkOrchid" : VerificaColor = Drawing.Color.DarkOrchid
            Case "DarkRed" : VerificaColor = Drawing.Color.DarkRed
            Case "DarkSalmon" : VerificaColor = Drawing.Color.DarkSalmon
            Case "DarkSeaGreen" : VerificaColor = Drawing.Color.DarkSeaGreen
            Case "DarkSlateBlue" : VerificaColor = Drawing.Color.DarkSlateBlue
            Case "DarkSlateGray" : VerificaColor = Drawing.Color.DarkSlateGray
            Case "DarkTurquoise" : VerificaColor = Drawing.Color.DarkTurquoise
            Case "DarkViolet" : VerificaColor = Drawing.Color.DarkViolet
            Case "DeepPink" : VerificaColor = Drawing.Color.DeepPink
            Case "DeepSkyBlue" : VerificaColor = Drawing.Color.DeepSkyBlue
            Case "DimGray" : VerificaColor = Drawing.Color.DimGray
            Case "DodgerBlue" : VerificaColor = Drawing.Color.DodgerBlue
            Case "Firebrick" : VerificaColor = Drawing.Color.Firebrick
            Case "FloralWhite" : VerificaColor = Drawing.Color.FloralWhite
            Case "ForestGreen" : VerificaColor = Drawing.Color.ForestGreen
            Case "Fuchsia" : VerificaColor = Drawing.Color.Fuchsia
            Case "Gainsboro" : VerificaColor = Drawing.Color.Gainsboro
            Case "GhostWhite" : VerificaColor = Drawing.Color.GhostWhite
            Case "Gold" : VerificaColor = Drawing.Color.Gold
            Case "Goldenrod" : VerificaColor = Drawing.Color.Goldenrod
            Case "Gray" : VerificaColor = Drawing.Color.Gray
            Case "Green" : VerificaColor = Drawing.Color.Green
            Case "GreenYellow" : VerificaColor = Drawing.Color.GreenYellow
            Case "Honeydew" : VerificaColor = Drawing.Color.Honeydew
            Case "HotPink" : VerificaColor = Drawing.Color.HotPink
            Case "IndianRed" : VerificaColor = Drawing.Color.IndianRed
            Case "Indigo" : VerificaColor = Drawing.Color.Indigo
            Case "Ivory" : VerificaColor = Drawing.Color.Ivory
            Case "Khaki" : VerificaColor = Drawing.Color.Khaki
            Case "Lavender" : VerificaColor = Drawing.Color.Lavender
            Case "LavenderBlush" : VerificaColor = Drawing.Color.LavenderBlush
            Case "LawnGreen" : VerificaColor = Drawing.Color.LawnGreen
            Case "LemonChiffon" : VerificaColor = Drawing.Color.LemonChiffon
            Case "LightBlue" : VerificaColor = Drawing.Color.LightBlue
            Case "LightCoral" : VerificaColor = Drawing.Color.LightCoral
            Case "LightCyan" : VerificaColor = Drawing.Color.LightCyan
            Case "LightGoldenrodYellow" : VerificaColor = Drawing.Color.LightGoldenrodYellow
            Case "LightGray" : VerificaColor = Drawing.Color.LightGray
            Case "LightGreen" : VerificaColor = Drawing.Color.LightGreen
            Case "LightPink" : VerificaColor = Drawing.Color.LightPink
            Case "LightSalmon" : VerificaColor = Drawing.Color.LightSalmon
            Case "LightSeaGreen" : VerificaColor = Drawing.Color.LightSeaGreen
            Case "LightSkyBlue" : VerificaColor = Drawing.Color.LightSkyBlue
            Case "LightSlateGray" : VerificaColor = Drawing.Color.LightSlateGray
            Case "LightSteelBlue" : VerificaColor = Drawing.Color.LightSteelBlue
            Case "LightYellow" : VerificaColor = Drawing.Color.LightYellow
            Case "Lime" : VerificaColor = Drawing.Color.Lime
            Case "LimeGreen" : VerificaColor = Drawing.Color.LimeGreen
            Case "Linen" : VerificaColor = Drawing.Color.Linen
            Case "Magenta" : VerificaColor = Drawing.Color.Magenta
            Case "Maroon" : VerificaColor = Drawing.Color.Maroon
            Case "MediumAquamarine" : VerificaColor = Drawing.Color.MediumAquamarine
            Case "MediumBlue" : VerificaColor = Drawing.Color.MediumBlue
            Case "MediumOrchid" : VerificaColor = Drawing.Color.MediumOrchid
            Case "MediumPurple" : VerificaColor = Drawing.Color.MediumPurple
            Case "MediumSeaGreen" : VerificaColor = Drawing.Color.MediumSeaGreen
            Case "MediumSlateBlue" : VerificaColor = Drawing.Color.MediumSlateBlue
            Case "MediumSpringGreen" : VerificaColor = Drawing.Color.MediumSpringGreen
            Case "MediumTurquoise" : VerificaColor = Drawing.Color.MediumTurquoise
            Case "MediumVioletRed" : VerificaColor = Drawing.Color.MidnightBlue
            Case "MidnightBlue" : VerificaColor = Drawing.Color.MidnightBlue
            Case "MintCream" : VerificaColor = Drawing.Color.MintCream
            Case "MistyRose" : VerificaColor = Drawing.Color.MistyRose
            Case "Moccasin" : VerificaColor = Drawing.Color.Moccasin
            Case "NavajoWhite" : VerificaColor = Drawing.Color.NavajoWhite
            Case "Navy" : VerificaColor = Drawing.Color.Navy
            Case "OldLace" : VerificaColor = Drawing.Color.OldLace
            Case "Olive" : VerificaColor = Drawing.Color.Olive
            Case "OliveDrab" : VerificaColor = Drawing.Color.OliveDrab
            Case "Orange" : VerificaColor = Drawing.Color.Orange
            Case "OrangeRed" : VerificaColor = Drawing.Color.OrangeRed
            Case "Orchid" : VerificaColor = Drawing.Color.Orchid
            Case "PaleGoldenrod" : VerificaColor = Drawing.Color.PaleGoldenrod
            Case "PaleGreen" : VerificaColor = Drawing.Color.PaleGreen
            Case "PaleTurquoise" : VerificaColor = Drawing.Color.PaleTurquoise
            Case "PaleVioletRed" : VerificaColor = Drawing.Color.PaleVioletRed
            Case "PapayaWhip" : VerificaColor = Drawing.Color.PapayaWhip
            Case "PeachPuff" : VerificaColor = Drawing.Color.PeachPuff
            Case "Peru" : VerificaColor = Drawing.Color.Peru
            Case "Pink" : VerificaColor = Drawing.Color.Pink
            Case "Plum" : VerificaColor = Drawing.Color.Plum
            Case "PowderBlue" : VerificaColor = Drawing.Color.PowderBlue
            Case "Purple" : VerificaColor = Drawing.Color.Purple
            Case "Red" : VerificaColor = Drawing.Color.Red
            Case "RosyBrown" : VerificaColor = Drawing.Color.RosyBrown
            Case "RoyalBlue" : VerificaColor = Drawing.Color.RoyalBlue
            Case "SaddleBrown" : VerificaColor = Drawing.Color.SaddleBrown
            Case "Salmon" : VerificaColor = Drawing.Color.Salmon
            Case "SandyBrown" : VerificaColor = Drawing.Color.SandyBrown
            Case "SeaGreen" : VerificaColor = Drawing.Color.SeaGreen
            Case "SeaShell" : VerificaColor = Drawing.Color.SeaShell
            Case "Sienna" : VerificaColor = Drawing.Color.Sienna
            Case "Silver" : VerificaColor = Drawing.Color.Silver
            Case "SkyBlue" : VerificaColor = Drawing.Color.SkyBlue
            Case "SlateBlue" : VerificaColor = Drawing.Color.SlateBlue
            Case "SlateGray" : VerificaColor = Drawing.Color.SlateGray
            Case "Snow" : VerificaColor = Drawing.Color.Snow
            Case "SpringGreen" : VerificaColor = Drawing.Color.SpringGreen
            Case "SteelBlue" : VerificaColor = Drawing.Color.SteelBlue
            Case "Tan" : VerificaColor = Drawing.Color.Tan
            Case "Teal" : VerificaColor = Drawing.Color.Teal
            Case "Thistle" : VerificaColor = Drawing.Color.Thistle
            Case "Tomato" : VerificaColor = Drawing.Color.Tomato
            Case "Transparent" : VerificaColor = Drawing.Color.Transparent
            Case "Turquoise" : VerificaColor = Drawing.Color.Turquoise
            Case "Violet" : VerificaColor = Drawing.Color.Violet
            Case "Wheat" : VerificaColor = Drawing.Color.Wheat
            Case "White" : VerificaColor = Drawing.Color.White
            Case "WhiteSmoke" : VerificaColor = Drawing.Color.WhiteSmoke
            Case "Yellow" : VerificaColor = Drawing.Color.Yellow
            Case "YellowGreen" : VerificaColor = Drawing.Color.YellowGreen
        End Select
    End Function

    Function BuscarEnCollecction(ByVal Bus As Collection, ByVal Cad As String) As Integer
        For i As Integer = 1 To Bus.Count
            If Bus.Item(i).ToString = Cad Then
                BuscarEnCollecction = i - 1
                Exit Function
            Else
                BuscarEnCollecction = 0
            End If
        Next
    End Function

    Public Function llenarcero(ByRef var As String, ByRef cuantas As Short) As String
        If Len(var) < cuantas Then
            Do While Len(var) < cuantas
                var = "0" & Trim(var)
            Loop
            llenarcero = var
        Else
            llenarcero = var
        End If
    End Function


    Public Sub formatofecha(ByRef txt As TextBox)
        txt.MaxLength = 10
        If Len(txt.Text) = 2 Or Len(txt.Text) = 5 Then
            txt.Text = txt.Text & "/"
            txt.SelectionStart = Len(txt.Text)
        End If
        If Len(txt.Text) = 10 Then
            Dim validarFecha As Boolean = IsDate(txt.Text)
            If validarFecha = False Then
                MessageBox.Show("El formato de fecha no es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt.Text = ""
                txt.Focus()
            End If
        End If
    End Sub
    Public Sub formatofecha(ByRef txt As ToolStripTextBox)
        txt.MaxLength = 10
        If Len(txt.Text) = 2 Or Len(txt.Text) = 5 Then
            txt.Text = txt.Text & "/"
            txt.SelectionStart = Len(txt.Text)
        End If
        If Len(txt.Text) = 10 Then
            Dim validarFecha As Boolean = IsDate(txt.Text)
            If validarFecha = False Then
                MessageBox.Show("El formato de fecha no es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt.Text = ""
                txt.Focus()
            End If
        End If
    End Sub
    Public Function DiasHabiles(ByVal DateIn As DateTime, ByVal ShiftDate As Integer) As DateTime
        Dim i As Integer = 1, DateTemp As Date, Dias As Integer
        While i <= ShiftDate
            DateTemp = DateAdd(DateInterval.Day, i, DateIn)
            If Not DateTemp.DayOfWeek = DayOfWeek.Sunday Then
                Dias += 1
            Else
                Dias += 1
                ShiftDate += 1
            End If
            i += 1
        End While
        DiasHabiles = DateAdd(DateInterval.Day, Dias, DateIn)
    End Function

    Public Function Mayusculas(ByVal txt As TextBox) As String
        Mayusculas = UCase(txt.Text)
        txt.SelectionStart = Len(txt.Text)
    End Function
    Public Function Minusculas(ByVal txt As TextBox) As String
        Minusculas = LCase(txt.Text)
        txt.SelectionStart = Len(txt.Text)
    End Function

    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Public Sub DataTableToExcel(ByVal pDataTable As DataTable, ByVal estilo As Int16)
		Dim vFileName As String = Path.GetTempFileName()
		FileOpen(1, vFileName, OpenMode.Output)
		Dim sb As String = ""
        Dim dc As DataColumn
        For Each dc In pDataTable.Columns
            sb &= dc.Caption & Microsoft.VisualBasic.ControlChars.Tab
        Next
        PrintLine(1, sb)

        Dim i As Integer = 0
        Dim dr As DataRow
        For Each dr In pDataTable.Rows
            i = 0 : sb = ""
            For Each dc In pDataTable.Columns
                If Not IsDBNull(dr(i)) Then
                    sb &= CStr(dr(i)) & Microsoft.VisualBasic.ControlChars.Tab
                Else
                    sb &= Microsoft.VisualBasic.ControlChars.Tab
                End If
                i += 1
            Next

            PrintLine(1, sb)
        Next
        FileClose(1)
        TextToExcel(vFileName, estilo)

    End Sub

    Public Sub TextToExcel(ByVal pFileName As String, ByVal estilo As Int16)

        Dim vFormato As Excel.XlRangeAutoFormat

        Dim vCultura As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        Dim Exc As Excel.Application = New Excel.Application
        Exc.Workbooks.OpenText(pFileName, , , , Excel.XlTextQualifier.xlTextQualifierNone, , True)

        Dim Wb As Excel.Workbook = Exc.ActiveWorkbook
        Dim Ws As Excel.Worksheet = Wb.ActiveSheet

        'Se le indica el formato al que queremos exportarlo
        Dim valor As Integer = estilo
        If valor > -1 Then
            Select Case valor
                Case 0 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatNone
                Case 1 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatSimple
                Case 2 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1
                Case 3 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2
                Case 4 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic3
                Case 5 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting1
                Case 6 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting2
                Case 7 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting3
                Case 8 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting4
                Case 9 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor1
                Case 10 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor2
                Case 11 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor3
                Case 12 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList1
                Case 13 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList2
                Case 14 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList3
                Case 15 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects1
                Case 16 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects2
            End Select

            Ws.Range(Ws.Cells(1, 1), Ws.Cells(Ws.UsedRange.Rows.Count, Ws.UsedRange.Columns.Count)).AutoFormat(vFormato)

            pFileName = Path.GetTempFileName.Replace("tmp", "xls")
            File.Delete(pFileName)
            Exc.ActiveWorkbook.SaveAs(pFileName, Excel.XlTextQualifier.xlTextQualifierNone - 1)
        End If
        Exc.Quit()

        Ws = Nothing
        Wb = Nothing
        Exc = Nothing

        GC.Collect()

        If valor > -1 Then
            Dim p As System.Diagnostics.Process = New System.Diagnostics.Process
            p.EnableRaisingEvents = False
            Process.Start("Excel.exe", pFileName)
        End If
        System.Threading.Thread.CurrentThread.CurrentCulture = vCultura
    End Sub

    Public Function AppPath() As String
        Return System.Windows.Forms.Application.StartupPath
    End Function

    ''Public Function mesanterior(ByVal fecha As Date) As Date
    ''    Dim mes As Integer
    ''    Dim año As Integer
    ''    año = Year(fecha)
    ''    mes = Month(fecha)
    ''    If mes >= 2 Then
    ''        mes = mes - 1
    ''    ElseIf mes = 1 Then
    ''        mes = 12
    ''        año = año - 1
    ''    End If
    ''    Dim dia As Integer
    ''    Select Case mes
    ''        Case 1, 3, 5, 7, 8, 10, 12
    ''            dia = 31
    ''        Case 2
    ''            dia = 28
    ''        Case 4, 6, 9, 11
    ''            dia = 30
    ''    End Select
    ''    Return CDate("" & dia & "/" & mes & "/" & año & "")
    ''End Function

    Public Function mesanterior(ByVal fecha As Date) As Date
        Return DateAdd("m", -1, fecha)
    End Function

    Public Function cadenames(ByVal fecha As Date) As String
        Dim cadena As String = ""
        'cadena = NOMBREDEMES(Month(fecha)) & " " & Year(fecha)
        cadena = MonthName(fecha.Month).ToUpper & " " & fecha.Year
        Return (cadena)
    End Function
    Public Function NumeroMes(ByVal Nmes As String) As Integer
        Select Case Nmes.ToLower
            Case "enero", "ene"
                NumeroMes = 1
            Case "febrero", "feb"
                NumeroMes = 2
            Case "marzo", "mar"
                NumeroMes = 3
            Case "abril", "abr"
                NumeroMes = 4
            Case "mayo", "may"
                NumeroMes = 5
            Case "junio", "jun"
                NumeroMes = 6
            Case "julio", "jul"
                NumeroMes = 7
            Case "agosto", "ago"
                NumeroMes = 8
            Case "septiembre", "sep"
                NumeroMes = 9
            Case "octubre", "oct"
                NumeroMes = 10
            Case "noviembre", "nov"
                NumeroMes = 11
            Case "diciembre", "dic"
                NumeroMes = 12
        End Select
    End Function

    Public Function NOMBREDEMES(ByVal MES As Integer) As String
        Dim mescad As String = ""
        Select Case MES
            Case 1
                mescad = "Enero"
            Case 2
                mescad = "Febrero"
            Case 3
                mescad = "Marzo"
            Case 4
                mescad = "Abril"
            Case 5
                mescad = "Mayo"
            Case 6
                mescad = "Junio"
            Case 7
                mescad = "Julio"
            Case 8
                mescad = "Agosto"
            Case 9
                mescad = "Septiembre"
            Case 10
                mescad = "Octubre"
            Case 11
                mescad = "Noviembre"
            Case 12
                mescad = "Diciembre"
        End Select
        Return mescad
    End Function

    'Pasarle a esta rutina la fecha que queremos averiguar  
    Public Function UltimoDia(ByVal Fecha As Date)
        'Dim Primer As Date
        Dim Ultimo As Date
        'Usamos la funcion DAteSerial para obtener el primero y el ultimo dia  
        'Primer = DateSerial(Year(Fecha), Month(Fecha) + 0, 1)
        Ultimo = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)
        'MsgBox(" Primer día : " & Primer & vbNewLine & _
        '" Último día : " & Ultimo, vbInformation)
        Return Ultimo
    End Function


#Region "Operaciones DBase"

    Public Sub conectarDbase()
        Try
            Dim x As New ClassRegistros
            DirDbase = x.obtRutaDbase
            Dim ConnectionString As String
            ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DirDbase & ";Extended Properties=dBase III"
            dBaseConnection = New System.Data.OleDb.OleDbConnection(ConnectionString)
            dBaseConnection.Open()
            CrearTemporalesDbase()
        Catch ex As Odbc.OdbcException
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function ConsultaSqlDbase(ByVal txtSql As String) As OleDb.OleDbCommand
        ConsultaSqlDbase = New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter(ConsultaSqlDbase)
        Dim ds As New DataSet
        ConsultaSqlDbase.Connection = dBaseConnection
        ConsultaSqlDbase.CommandText = txtSql
        ConsultaSqlDbase.CommandType = CommandType.Text
    End Function

    Public Sub EjecucionDbase(ByVal txtSql As String)
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = dBaseConnection
        cmd.CommandText = txtSql
        cmd.ExecuteNonQuery()
    End Sub

    Public Function obtenerCampoDbase(ByVal sql As String, ByVal campo As String) As String
        Dim comDatos As New OleDb.OleDbCommand
        comDatos.Connection = dBaseConnection
        comDatos.CommandText = sql
        comDatos.CommandType = CommandType.Text
        Try
            Dim dr As System.Data.IDataReader
            dr = comDatos.ExecuteReader()
            dr.Read()
            obtenerCampoDbase = dr(campo).ToString
        Catch ex As Exception
            obtenerCampoDbase = "0"
        End Try

    End Function

    Public Sub CrearTemporalesDbase()
        Dim TabCaja As New StringBuilder
        'Crea temporal de aperturas
        TabCaja.Append("CREATE TABLE `croape` (")
        TabCaja.Append("`COD_OFI` character(3),")
        TabCaja.Append("`CAJA` character(3),")
        TabCaja.Append("`SERIE` character(3),")
        TabCaja.Append("`FEC_APE` date,")
        TabCaja.Append("`HOR_APE` character(8),")
        TabCaja.Append("`CAJ_APE` character(3),")
        TabCaja.Append("`FEC_CIE` date,")
        TabCaja.Append("`HOR_CIE` character(8),")
        TabCaja.Append("`CAJ_CIE` character(3),")
        TabCaja.Append("`SAL_INI` numeric(19,2),")
        TabCaja.Append("`ING_TOT` numeric(19,2),")
        TabCaja.Append("`NUM_OPE` numeric(19,0),")
        TabCaja.Append("`FOL_INI` numeric(19,0),")
        TabCaja.Append("`FOL_FIN` numeric(19,0),")
        TabCaja.Append("`STATUS` character(1),")
        TabCaja.Append("`STATUSA` character(1),")
        TabCaja.Append("`id_mov` numeric(19,2),")
        TabCaja.Append("`Maquina` character(30),")
        TabCaja.Append("`TCaja` character(30) )")

        If Dir(DirDbase & "\croape.dbf") = "" Then
            EjecucionDbase(TabCaja.ToString)
        End If
        'Crea temporal de cajas
        TabCaja.Remove(0, TabCaja.Length)
        TabCaja.Append("CREATE TABLE `cajas` (")
        TabCaja.Append("`ID_CAJA` character(3),")
        TabCaja.Append("`Serie` character(1),")
        TabCaja.Append("`COD_OFI` character(3),")
        TabCaja.Append("`Folio` numeric(19,0),")
        TabCaja.Append("`Activo` numeric(4),")
        TabCaja.Append("`descripcion` character(100),")
        TabCaja.Append("`multicajas` numeric(1),")
        TabCaja.Append("`remanente` numeric(19,2),")
        TabCaja.Append("`TCaja` character(30) )")

        If Dir(DirDbase & "\cajas.dbf") = "" Then
            EjecucionDbase(TabCaja.ToString)
        End If

        'Crea temporal de Otros conceptos
        TabCaja.Remove(0, TabCaja.Length)
        TabCaja.Append("CREATE TABLE `otrosconceptos` ( ")
        TabCaja.Append("`Clave` numeric(15,0),")
        TabCaja.Append("`Cuenta` numeric(15,0),")
        TabCaja.Append("`Concepto` character(150),")
        TabCaja.Append("`Total` numeric(15,2),")
        TabCaja.Append("`Subtotal` numeric(15,2),")
        TabCaja.Append("`IVA` numeric(15,2),")
        TabCaja.Append("`Pagado` numeric(1),")
        TabCaja.Append("`vencimiento` date,")
        TabCaja.Append("`Observa` character(200),")
        TabCaja.Append("`tabla` character(50),")
        TabCaja.Append("`Folio` character(200),")
        TabCaja.Append("`Estado` character(20),")
        TabCaja.Append("`Motivo` character(50),")
        TabCaja.Append("`Fec_apli` date,")
        TabCaja.Append("`Per_apli` character(100),")
        TabCaja.Append("`Usuarioalta` character(45),")
        TabCaja.Append("`Fec_alta` date,")
        TabCaja.Append("`usuariobaja` character(45),")
        TabCaja.Append("`fecha_baja` date,")
        TabCaja.Append("`usuariocambio` character(45),")
        TabCaja.Append("`fecha_ult_camb` date,")
        TabCaja.Append("`id_comunidad` character(3),")
        TabCaja.Append("`Abonos` numeric(15,2),")
        TabCaja.Append("`Resta` numeric(15,2),")
        TabCaja.Append("`tipo_mov` character(20),")
        TabCaja.Append("`MES_PERIODO` character(3),")
        TabCaja.Append("`AN_PER` numeric(10)) ")

        If Dir(DirDbase & "\OTROSCON.DBF") = "" Then
            EjecucionDbase(TabCaja.ToString)
        End If

        'Crea temporal de pagos
        TabCaja.Remove(0, TabCaja.Length)
        TabCaja.Append("CREATE TABLE `pagos` (")
        TabCaja.Append("`fecha_Act` date,")
        TabCaja.Append("`CUENTA` numeric(19,0),")
        TabCaja.Append("`id_comunidad` character(3),")
        TabCaja.Append("`PER_INI` character(3),")
        TabCaja.Append("`ANO_INI` numeric(11),")
        TabCaja.Append("`PER_FIN` character(3),")
        TabCaja.Append("`ANO_FIN` numeric(11),")
        TabCaja.Append("`rezagos` numeric(19,2),")
        TabCaja.Append("`pagos` numeric(19,2),")
        TabCaja.Append("`recargos` numeric(19,2),")
        TabCaja.Append("`otros` numeric(19,2),")
        TabCaja.Append("`IVA` numeric(19,2),")
        TabCaja.Append("`alcantarillado` numeric(19,2),")
        TabCaja.Append("`saneamiento` numeric(15,2),")
        TabCaja.Append("`subtotal` numeric(15,2),")
        TabCaja.Append("`montoDescuento` numeric(15,2),")
        TabCaja.Append("`total` numeric(19,2),")
        TabCaja.Append("`nombre` character(50),")
        TabCaja.Append("`recibo` numeric(15,0),")
        TabCaja.Append("`cancelado` character(1),")
        TabCaja.Append("`descuento` numeric(15,2),")
        TabCaja.Append("`perDesc` character(100),")
        TabCaja.Append("`Serie` character(1),")
        TabCaja.Append("`Usuario` numeric(4),")
        TabCaja.Append("`tarifa` character(3),")
        TabCaja.Append("`ccodpago` character(2),")
        TabCaja.Append("`Referencia` character(50),")
        TabCaja.Append("`Bloqueado` numeric(1),")
        TabCaja.Append("`montonota` numeric(15,2),")
        TabCaja.Append("`TipUsu` character(1),")
        TabCaja.Append("`COD_OFI` character(3),")
        TabCaja.Append("`ID_CAJA` character(3),")
        TabCaja.Append("`Anticipo` numeric(15,2), ")
        TabCaja.Append("`Observacion` character(150), ")
        TabCaja.Append("`Hora` character(8) ) ")

        If Dir(DirDbase & "\pagos.dbf") = "" Then
            EjecucionDbase(TabCaja.ToString)
        End If

        'Crea temporal de pagos otros
        TabCaja.Remove(0, TabCaja.Length)

        TabCaja.Append("CREATE TABLE `pagotros` ( ")
        TabCaja.Append("`Recibo` numeric(15),")
        TabCaja.Append("`COD_OFI` character(3),")
        TabCaja.Append("`id_caja` character(3),")
        TabCaja.Append("`serie` character(1),")
        TabCaja.Append("`Cuenta` numeric(15),")
        TabCaja.Append("`ID_COMUNIDAD` character(3),")
        TabCaja.Append("`Usuario` numeric(10),")
        TabCaja.Append("`Fecha` date,")
        TabCaja.Append("`NumConcepto` character(100),")
        TabCaja.Append("`Concepto` character(200),")
        TabCaja.Append("`Cantidad` numeric(10),")
        TabCaja.Append("`pDesc` numeric(15,2),")
        TabCaja.Append("`SubTotal` numeric(19,2),")
        TabCaja.Append("`IVA` numeric(19,2),")
        TabCaja.Append("`Total` numeric(19,2),")
        TabCaja.Append("`Cancelado` character(1),")
        TabCaja.Append("`Ccodpago` character(2),")
        TabCaja.Append("`Referencia` character(50) ) ")

        If Dir(DirDbase & "\pagotros.dbf") = "" Then
            EjecucionDbase(TabCaja.ToString)
        End If

        'Crea temporal de estados
        TabCaja.Remove(0, TabCaja.Length)
        TabCaja.Append("CREATE TABLE `estados` (")
        TabCaja.Append("`pagado` numeric(1),")
        TabCaja.Append("`Factura` numeric(15,0),")
        TabCaja.Append("`Serie` character(1),")
        TabCaja.Append("`Caja` character(3),")
        TabCaja.Append("`Fecha` date,")
        TabCaja.Append("`OFI_PAGO` character(3),")
        TabCaja.Append("`cod_usu` character(3),")
        TabCaja.Append("`Cuenta` numeric(10),")
        TabCaja.Append("`ID_Comunidad` character(3),")
        TabCaja.Append("`Periodo_Fin` character(3),")
        TabCaja.Append("`Anio_Fin` numeric(19,2) )")
        If Dir(DirDbase & "\estados.dbf") = "" Then
            EjecucionDbase(TabCaja.ToString)
        End If
    End Sub

#End Region

    Function monedatext(ByVal monto As Double) As Label
        Dim mon As New Label
        mon.Text = Format(monto, "#,###,##0.00")
        mon.TextAlign = ContentAlignment.MiddleRight
        If monto >= 0 Then mon.ForeColor = Color.Black
        If monto < 0 Then mon.ForeColor = Color.Red
        mon.Height = 15
        monedatext = mon
    End Function

    Function regIva(ByVal total As Double) As Collection
        regIva = New Collection
        Dim pIva As Integer = obtenerCampo("select Porciva from empresa", "Porciva") + 100
        Dim subt As Double = 0, miva As Double = 0
        subt = Math.Round((total * 100) / pIva, 2)
        miva = Math.Round(total - subt, 2)
        regIva.Add(subt)
        regIva.Add(miva)
    End Function
End Module
