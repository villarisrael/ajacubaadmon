Imports System.Data.Odbc

Public Class RepositorioConvenios
    Private Conexion As String = "DSN=agua"


    Public Function ObtenerListado(fechaInicio As Date, fechaFin As Date) As List(Of ConvenioPago)
        Dim consulta As String = "SELECT idEncConvenio, idCuenta, Nombre, Telefono, Total, fechacreacion, pagos, aplazamiento, estado, mesvencimiento, periodovencimiento 
                              FROM encconvenio 
                              WHERE fechacreacion BETWEEN ? AND ? 
                              ORDER BY fechacreacion ASC"

        Dim listaConvenios As New List(Of ConvenioPago)

        Using con As New OdbcConnection(Conexion)
            con.Open()
            Using cmd As New OdbcCommand(consulta, con)
                cmd.Parameters.AddWithValue("?", fechaInicio.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("?", fechaFin.ToString("yyyy-MM-dd"))

                Dim reader As OdbcDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim convenio As New ConvenioPago()
                    convenio.idConvenio = Convert.ToInt32(reader("idEncConvenio"))
                    convenio.IdCuenta = Convert.ToInt32(reader("idCuenta"))
                    convenio.Nombre = reader("Nombre").ToString()
                    convenio.Telefono = reader("Telefono").ToString()
                    convenio.TotalDeuda = Convert.ToDecimal(reader("Total"))
                    convenio.fechacreacion = Convert.ToDateTime(reader("fechacreacion"))
                    convenio.NumeroPagos = Convert.ToInt32(reader("pagos"))
                    convenio.Aplazamiento = Convert.ToInt32(reader("aplazamiento"))
                    convenio.Estado = reader("estado").ToString()
                    convenio.Mes = reader("mesvencimiento").ToString()
                    convenio.Periodo = Convert.ToInt32(reader("periodovencimiento"))

                    ' Agregar a la lista
                    listaConvenios.Add(convenio)
                End While
            End Using
        End Using

        Return listaConvenios
    End Function

    ' Método para obtener un convenio por cuenta
    Public Function ObtenerConvenioPorCuenta(idCuenta As Integer) As ConvenioPago
        Dim consulta As String = "SELECT * FROM vusuario WHERE cuenta = ?"
        Using con As New OdbcConnection(Conexion)
            con.Open()
            Using cmd As New OdbcCommand(consulta, con)
                cmd.Parameters.AddWithValue("?", idCuenta)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim C As New ConvenioPago()
                    C.IdCuenta = Convert.ToInt32(reader("cuenta"))
                    C.Nombre = reader("Nombre")
                    C.Domicilio = reader("Direccion")
                    C.Colonia = reader("Colonia")
                    C.Tarifa = reader("Descripcion_cuota")
                    C.Telefono = reader("telefono").ToString()
                    C.TotalDeuda = Convert.ToDecimal(reader("total"))
                    C.Ubicacion = reader("Ubicacion")
                    C.PeriodosAdeudados = Convert.ToInt32(reader("Nodeperiodo").ToString())
                    C.Mes = MonthName(DateTime.Now.Month - 1).ToUpper.Substring(0, 3)
                    C.Periodo = DateTime.Now.Year
                    C.convenio = Convert.ToBoolean(reader("convenio"))
                    Return C
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Public Function ObtenerConvenioPorUbicacion(Ubicacion As String) As ConvenioPago
        Dim consulta As String = "SELECT * FROM vusuario WHERE Ubicacion = ?"
        Using con As New OdbcConnection(Conexion)
            con.Open()
            Using cmd As New OdbcCommand(consulta, con)
                cmd.Parameters.AddWithValue("?", Ubicacion)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim C As New ConvenioPago()
                    C.IdCuenta = Convert.ToInt32(reader("cuenta"))
                    C.Nombre = reader("Nombre")
                    C.Domicilio = reader("Direccion")
                    C.Colonia = reader("Colonia")
                    C.Tarifa = reader("Descripcion_cuota")
                    C.Telefono = reader("telefono").ToString()
                    C.TotalDeuda = Convert.ToDecimal(reader("total"))
                    C.Ubicacion = reader("Ubicacion")
                    C.PeriodosAdeudados = Convert.ToInt32(reader("Nodeperiodo").ToString())
                    C.Mes = MonthName(DateTime.Now.Month).ToUpper.Substring(0, 3)
                    C.Periodo = DateTime.Now.Year

                    C.convenio = Convert.ToBoolean(reader("convenio"))
                    Return C
                End If
            End Using
        End Using
        Return Nothing
    End Function



    ' Método para guardar un convenio
    Public Sub GuardarConvenio(convenio As ConvenioPago, grid As DataGridView)
        Try
            Ejecucion("INSERT INTO encConvenio (idCuenta, Nombre, telefono, total, fechacreacion, pagos, aplazamiento,estado, mesvencimiento, periodovencimiento) VALUES (" & convenio.IdCuenta & ",'" & convenio.Nombre & "','" & convenio.Telefono & "'," & convenio.TotalDeuda & ",'" & DateTime.Now.ToString("yyyy/MM/dd") & "'," & convenio.NumeroPagos & "," & convenio.Aplazamiento & ",'Activo','" & convenio.Mes & "'," & convenio.Periodo & ")")
            Dim numeroconvenio = obtenerCampo("Select max(idencconvenio)  as Dato from encconvenio", "Dato")
            For Each linea As DataGridViewRow In grid.Rows
                Dim consulta2 As String = "INSERT INTO escconv (No_convenio, Fecha, Monto, pagado, no_pagare) VALUES (" & numeroconvenio & ",'" & Convert.ToDateTime(linea.Cells(0).Value).ToString("yyyy/MM/dd") & "'," & linea.Cells(2).Value.ToString().Replace("$", "").Replace(",", "") & ",'0','" & linea.Cells(1).Value & "')"
                Ejecucion(consulta2)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Function ObtenerConvenioPorId(idEncConvenio As Integer) As ConvenioPago
        Dim consulta As String = "SELECT idEncConvenio, idCuenta, Nombre, Telefono, Total, fechacreacion, pagos, aplazamiento, estado , mesvencimiento, periodovencimiento
                                  FROM encconvenio 
                                  WHERE idEncConvenio = ?"

        Dim convenio As ConvenioPago = New ConvenioPago()

        Using con As New OdbcConnection(Conexion)
            con.Open()
            Using cmd As New OdbcCommand(consulta, con)
                cmd.Parameters.AddWithValue("?", idEncConvenio)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()
                If reader.Read() Then

                    convenio.IdCuenta = Convert.ToInt32(reader("idCuenta"))
                    convenio.Nombre = reader("Nombre").ToString()
                    convenio.Telefono = reader("Telefono").ToString()
                    convenio.TotalDeuda = Convert.ToDecimal(reader("Total"))

                    convenio.IdConvenio = idEncConvenio
                    convenio.fechacreacion = Convert.ToDateTime(reader("fechacreacion"))
                    convenio.NumeroPagos = Convert.ToInt32(reader("pagos"))
                    convenio.Aplazamiento = Convert.ToInt32(reader("aplazamiento"))
                    convenio.Estado = reader("estado").ToString()
                    convenio.Mes = reader("mesvencimiento").ToString()
                    convenio.Periodo = reader("Periodovencimiento")
                End If
            End Using
        End Using

        ' Si el convenio existe, cargar los pagos desde `escconv`
        If convenio IsNot Nothing Then
            convenio.Pagos = ObtenerPagosPorConvenio(idEncConvenio)
        End If

        Return convenio
    End Function

    ' Método auxiliar para obtener los pagos de un convenio
    Private Function ObtenerPagosPorConvenio(idEncConvenio As Integer) As List(Of PagoConvenio)
        Dim consulta As String = "SELECT FolioIn, Fecha, Monto, Pagado, no_pagare 
                                  FROM escconv 
                                  WHERE No_convenio = ? 
                                  ORDER BY Fecha ASC"

        Dim listaPagos As New List(Of PagoConvenio)

        Using con As New OdbcConnection(Conexion)
            con.Open()
            Using cmd As New OdbcCommand(consulta, con)
                cmd.Parameters.AddWithValue("?", idEncConvenio)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim pago As New PagoConvenio With {
                        .IdPago = Convert.ToInt32(reader("FolioIn")),
                        .FechaPago = Convert.ToDateTime(reader("Fecha")),
                        .Monto = Convert.ToDecimal(reader("Monto")),
                        .Pagado = Convert.ToBoolean(reader("Pagado")),
                        .NoPagare = reader("no_pagare").ToString()
                    }
                    listaPagos.Add(pago)
                End While
            End Using
        End Using

        Return listaPagos
    End Function

    Public Function CancelarConvenio(idEncConvenio As Integer) As Boolean
        Try
            Ejecucion("UPDATE encconvenio SET estado = 'Cancelado' WHERE idEncConvenio = " & idEncConvenio)
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

End Class
