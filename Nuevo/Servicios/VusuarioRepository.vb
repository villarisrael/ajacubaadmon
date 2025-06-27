Imports System.Data.Odbc
Imports System.Collections.Generic

Public Class VUsuarioRepository
    Private ReadOnly _connectionString As String = "DSN=agua;" ' Reemplaza con tu configuración

    ''' <summary>
    ''' Obtiene todos los registros de la vista vusuario.
    ''' </summary>
    ''' <returns>Lista de VUsuario</returns>
    Public Function ObtenerUsuarios() As List(Of UsuarioDTO)
        Dim usuarios As New List(Of UsuarioDTO)()

        Using connection As New OdbcConnection(_connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM vusuario;"
                Using command As New OdbcCommand(query, connection)
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim usuario As New UsuarioDTO With {
                                .Cuenta = reader("cuenta").ToString(),
                                .Nombre = reader("nombre").ToString(),
                                .ClaveCatastral = reader("catastral").ToString(),
                                .Comunidad = reader("comunidad").ToString(),
                                .Domicilio = reader("Domicilio").ToString(),
                                .Giro = reader("Giro").ToString(),
                                .NumExt = reader("numext").ToString(),
                                .NumInt = reader("numint").ToString(),
                                .EstadoPredio = reader("estadopredio").ToString(),
                                .Cp = reader("cp").ToString(),
                                .IDColonia = Convert.ToInt32(reader("id_colonia")),
                                .Colonia = reader("colonia").ToString(),
                                .Rfc = reader("rfc").ToString(),
                                .Municipio = reader("Municipio").ToString(),
                                .FechaAlta = If(IsDBNull(reader("fechaalta")), Nothing, Convert.ToDateTime(reader("fechaalta"))),
                                .FechaBaja = If(IsDBNull(reader("fecha_baja")), Nothing, Convert.ToDateTime(reader("fecha_baja"))),
                                .FechaInst = If(IsDBNull(reader("fechainst")), Nothing, Convert.ToDateTime(reader("fechainst"))),
                                .Estado = reader("Estado").ToString(),
                                .TipoUsuario = reader("TipoUsu").ToString(),
                                .NodoMedidor = reader("nodemedidor").ToString(),
                                .MarcaMedidor = reader("marcamedidor").ToString(),
                                .DiametroMedidor = reader("diammedidor").ToString(),
                                .Sector = reader("sector").ToString(),
                                .Ruta = reader("ruta").ToString(),
                                .Telefono = reader("telefono").ToString(),
                                .DescripcionCuota = reader("descripcion_cuota").ToString(),
                                .Descripcion = reader("descripcion").ToString(),
                                .NumLec = Convert.ToInt32(reader("NumLec")),
                                .LecturaActual = Convert.ToDecimal(reader("LecturaAct")),
                                .Lote = reader("lote").ToString(),
                                .Manzana = reader("manzana").ToString(),
                                .Region = reader("Region").ToString(),
                                .IDComunidad = Convert.ToInt32(reader("id_comunidad")),
                                .Convenio = reader("convenio").ToString(),
                                .Mostrar = Convert.ToBoolean(reader("Mostrar")),
                                .IDTipoUsuario = Convert.ToInt32(reader("ID_TIPO_USUARIO")),
                                .Tarifa = Convert.ToDecimal(reader("tarifa")),
                                .Consumo = Convert.ToDecimal(reader("consumo")),
                                .DeudaAgua = Convert.ToDecimal(reader("deudaagua")),
                                .DeudaAlcantarillado = Convert.ToDecimal(reader("Deudaalcantarillado")),
                                .Otros = Convert.ToDecimal(reader("otros")),
                                .Recargos = Convert.ToDecimal(reader("recargos")),
                                .AlcaConsumo = Convert.ToDecimal(reader("alcaconsumo")),
                                .Credito = Convert.ToDecimal(reader("credito")),
                                .Total = Convert.ToDecimal(reader("total")),
                                .CamMed = reader("CamMed").ToString(),
                                .DireccionUbicacion = reader("DirUbi").ToString(),
                                .DireccionFisica = reader("DirFis").ToString(),
                                .LecturaAnterior = Convert.ToDecimal(reader("LecturaAnt")),
                                .Requerimiento = reader("requeri").ToString(),
                                .CodigoGiro = reader("cod_gir").ToString(),
                                .DireccionAutorizada = reader("dirau").ToString(),
                                .Ubicacion = reader("Ubicacion").ToString(),
                                .Direccion = reader("Direccion").ToString(),
                                .Alcantarillado = Convert.ToDecimal(reader("Alcantarillado")),
                                .Saneamiento = Convert.ToDecimal(reader("Saneamiento")),
                                .IdCuotaValvulista = Convert.ToInt32(reader("idcuotavalvulista")),
                                .NodoPeriodo = Convert.ToInt32(reader("nodeperiodo")),
                                .PeriodoAdeudo = Convert.ToInt32(reader("PeriodoAdeudo")),
                                .IVA = Convert.ToDecimal(reader("IVA")),
                                .CuentaAnterior = reader("cuentaanterior").ToString(),
                                .CedulaCatastral = reader("CEDULA_CATASTRAL").ToString(),
                                .IdDescuento = Convert.ToInt32(reader("iddescuento")),
                                .Alta = If(IsDBNull(reader("alta")), Nothing, Convert.ToDateTime(reader("alta")))
                            }
                            usuarios.Add(usuario)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return usuarios
    End Function


    ''' <summary>
    ''' Obtiene un usuario por su cuenta.
    ''' </summary>
    ''' <param name="cuenta">Cuenta del usuario</param>
    ''' <returns>Objeto VUsuario si existe, Nothing si no se encuentra</returns>
    Public Function ObtenerUsuarioPorCuenta(cuenta As String) As UsuarioDTO
        Dim usuario As New UsuarioDTO()

        Using connection As New OdbcConnection(_connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM vusuario WHERE cuenta = ?;"
                Using command As New OdbcCommand(query, connection)
                    command.Parameters.AddWithValue("?", cuenta)

                    Using reader As OdbcDataReader = command.ExecuteReader()
                        If reader.Read() Then

                            usuario.Cuenta = reader("cuenta").ToString()
                            usuario.Nombre = reader("nombre").ToString()
                            usuario.ClaveCatastral = reader("catastral").ToString()
                            usuario.Comunidad = reader("comunidad").ToString()
                            usuario.Domicilio = reader("Domicilio").ToString()
                            usuario.Giro = reader("Giro").ToString()
                            usuario.NumExt = reader("numext").ToString()
                            usuario.NumInt = reader("numint").ToString()
                            '  usuario.EstadoPredio = reader("estadopredio").ToString()
                            usuario.CP = reader("cp").ToString()
                            ' usuario.IDColonia = Convert.ToInt32(reader("id_colonia"))
                            usuario.Colonia = reader("colonia").ToString()
                            usuario.RFC = reader("rfc").ToString()
                            usuario.Municipio = reader("Municipio").ToString()

                            usuario.Estado = reader("Estado").ToString()
                            usuario.TipoUsuario = reader("TipoUsu").ToString()
                            usuario.NodoMedidor = reader("nodemedidor").ToString()
                            usuario.MarcaMedidor = reader("marcamedidor").ToString()
                            usuario.DiametroMedidor = reader("diammedidor").ToString()
                            usuario.Sector = reader("sector").ToString()
                            usuario.Ruta = reader("ruta").ToString()
                            usuario.Telefono = reader("telefono").ToString()
                            usuario.DescripcionCuota = reader("descripcion_cuota").ToString()
                            usuario.Descripcion = reader("descripcion").ToString()
                            usuario.NumLec = Convert.ToInt32(reader("NumLec"))
                            usuario.LecturaActual = Convert.ToDecimal(reader("LecturaAct"))
                            usuario.Lote = reader("lote").ToString()
                            usuario.Manzana = reader("manzana").ToString()
                            usuario.Region = reader("Region").ToString()
                            usuario.IDComunidad = Convert.ToInt32(reader("id_comunidad"))
                            usuario.Convenio = reader("convenio").ToString()
                            usuario.Mostrar = Convert.ToBoolean(reader("Mostrar"))
                            usuario.IDTipoUsuario = Convert.ToInt32(reader("ID_TIPO_USUARIO"))
                            usuario.Tarifa = reader("tarifa")
                            usuario.Consumo = Convert.ToDecimal(reader("consumo"))
                            usuario.DeudaAgua = Convert.ToDecimal(reader("deudaagua"))
                            usuario.Alcaconsumo = Convert.ToDecimal(reader("alcaconsumo"))
                            usuario.DeudaAlcantarillado = Convert.ToDecimal(reader("Deudaalcantarillado"))
                            usuario.Otros = Convert.ToDecimal(reader("otros"))
                            usuario.Recargos = Convert.ToDecimal(reader("recargos"))

                            usuario.Credito = Convert.ToDecimal(reader("credito"))
                            usuario.Total = Convert.ToDecimal(reader("total"))
                            usuario.CamMed = reader("CamMed").ToString()

                            usuario.Requerimiento = reader("requeri").ToString()
                            usuario.CodigoGiro = reader("cod_gir").ToString()

                            usuario.Ubicacion = reader("Ubicacion").ToString()
                            usuario.Direccion = reader("Direccion").ToString()
                            usuario.Alcantarillado = Convert.ToDecimal(reader("Alcantarillado"))
                            usuario.Saneamiento = Convert.ToDecimal(reader("Saneamiento"))
                            usuario.IDCuotaValvulista = Convert.ToInt32(reader("idcuotavalvulista"))
                            usuario.NodoPeriodo = Convert.ToInt32(reader("nodeperiodo"))
                            usuario.PeriodoAdeudo = reader("PeriodoAdeudo")
                            usuario.IVA = Convert.ToDecimal(reader("IVA"))
                            usuario.CuentaAnterior = reader("cuentaanterior").ToString()
                            usuario.CedulaCatastral = reader("CEDULA_CATASTRAL").ToString()
                            usuario.IDDescuento = Convert.ToInt32(reader("iddescuento"))


                        End If
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return usuario
    End Function
End Class

