Public Class OperacionesUsuarioRepositorio
    Implements IUsuario(Of UsuarioDTO)

    Public Function GenerarDatosUsuario(numeroContrato As Integer) As UsuarioDTO Implements IUsuario(Of UsuarioDTO).GenerarObjeto

        Dim objetoUsuario As New UsuarioDTO()



        Try

            ' Crearnos la solicitud
            Dim datosUsuario As IDataReader = ConsultaSql($"SELECT * FROM vusuario WHERE cuenta = {numeroContrato}").ExecuteReader

            If datosUsuario.Read() = True Then

                'objetoUsuario.Nombre = If(IsDBNull(datosUsuario("Nombre")), "", datosUsuario("Nombre").ToString())
                'objetoUsuario.Giro = If(IsDBNull(datosUsuario("Giro")), "", datosUsuario("Giro").ToString())
                'objetoUsuario.Direccion = If(IsDBNull(datosUsuario("Direccion")), "", datosUsuario("Direccion").ToString())
                objetoUsuario.Cuenta = If(IsDBNull(datosUsuario("cuenta")), 0, Convert.ToInt32(datosUsuario("cuenta")))
                objetoUsuario.Nombre = If(IsDBNull(datosUsuario("nombre")), "", datosUsuario("nombre").ToString())
                objetoUsuario.Catastral = If(IsDBNull(datosUsuario("catastral")), "", datosUsuario("catastral").ToString())
                objetoUsuario.Comunidad = If(IsDBNull(datosUsuario("comunidad")), "", datosUsuario("comunidad").ToString())
                objetoUsuario.Domicilio = If(IsDBNull(datosUsuario("domicilio")), "", datosUsuario("domicilio").ToString())
                objetoUsuario.Giro = If(IsDBNull(datosUsuario("giro")), "", datosUsuario("giro").ToString())
                objetoUsuario.NumExt = If(IsDBNull(datosUsuario("numext")), "", datosUsuario("numext").ToString())
                objetoUsuario.NumInt = If(IsDBNull(datosUsuario("numint")), "", datosUsuario("numint").ToString())
                objetoUsuario.EstadoPredio = If(IsDBNull(datosUsuario("estadopredio")), 0, Convert.ToInt32(datosUsuario("estadopredio")))
                objetoUsuario.Cp = If(IsDBNull(datosUsuario("cp")), "", datosUsuario("cp").ToString())
                objetoUsuario.Id_Colonia = If(IsDBNull(datosUsuario("id_colonia")), "", datosUsuario("id_colonia").ToString())
                objetoUsuario.Colonia = If(IsDBNull(datosUsuario("colonia")), "", datosUsuario("colonia").ToString())
                objetoUsuario.Rfc = If(IsDBNull(datosUsuario("rfc")), "", datosUsuario("rfc").ToString())
                objetoUsuario.Municipio = If(IsDBNull(datosUsuario("municipio")), "", datosUsuario("municipio").ToString())
                objetoUsuario.FechaAlta = If(IsDBNull(datosUsuario("fechaalta")), Nothing, Convert.ToDateTime(datosUsuario("fechaalta")))
                objetoUsuario.Fecha_Baja = If(IsDBNull(datosUsuario("fecha_baja")), Nothing, Convert.ToDateTime(datosUsuario("fecha_baja")))
                objetoUsuario.FechaInst = If(IsDBNull(datosUsuario("fechainst")), Nothing, Convert.ToDateTime(datosUsuario("fechainst")))
                objetoUsuario.Estado = If(IsDBNull(datosUsuario("estado")), "", datosUsuario("estado").ToString())
                objetoUsuario.TipoUsu = If(IsDBNull(datosUsuario("tipousu")), "", datosUsuario("tipousu").ToString())
                objetoUsuario.NodeMedidor = If(IsDBNull(datosUsuario("nodemedidor")), "", datosUsuario("nodemedidor").ToString())



                objetoUsuario.MarcaMedidor = If(IsDBNull(datosUsuario("marcamedidor")), "", datosUsuario("marcamedidor").ToString())
                objetoUsuario.DiamMedidor = If(IsDBNull(datosUsuario("diammedidor")), "", datosUsuario("diammedidor").ToString())
                objetoUsuario.Sector = If(IsDBNull(datosUsuario("sector")), "", datosUsuario("sector").ToString())
                objetoUsuario.Ruta = If(IsDBNull(datosUsuario("ruta")), "", datosUsuario("ruta").ToString())
                objetoUsuario.Telefono = If(IsDBNull(datosUsuario("telefono")), "", datosUsuario("telefono").ToString())
                objetoUsuario.Descripcion_Cuota = If(IsDBNull(datosUsuario("descripcion_cuota")), "", datosUsuario("descripcion_cuota").ToString())
                objetoUsuario.Descripcion = If(IsDBNull(datosUsuario("descripcion")), "", datosUsuario("descripcion").ToString())
                objetoUsuario.NumLec = If(IsDBNull(datosUsuario("NumLec")), 0.0, Convert.ToDouble(datosUsuario("NumLec")))
                objetoUsuario.LecturaAct = If(IsDBNull(datosUsuario("LecturaAct")), 0.0, Convert.ToDouble(datosUsuario("LecturaAct")))
                objetoUsuario.Lote = If(IsDBNull(datosUsuario("lote")), 0, Convert.ToInt32(datosUsuario("lote")))
                objetoUsuario.Manzana = If(IsDBNull(datosUsuario("manzana")), 0, Convert.ToInt32(datosUsuario("manzana")))
                objetoUsuario.Region = If(IsDBNull(datosUsuario("region")), "", datosUsuario("region").ToString())
                objetoUsuario.Id_Comunidad = If(IsDBNull(datosUsuario("id_comunidad")), "", datosUsuario("id_comunidad").ToString())
                objetoUsuario.Convenio = If(IsDBNull(datosUsuario("convenio")), False, Convert.ToBoolean(datosUsuario("convenio")))
                objetoUsuario.Mostrar = If(IsDBNull(datosUsuario("mostrar")), False, Convert.ToBoolean(datosUsuario("mostrar")))
                objetoUsuario.ID_TIPO_USUARIO = If(IsDBNull(datosUsuario("ID_TIPO_USUARIO")), "", datosUsuario("ID_TIPO_USUARIO").ToString())
                objetoUsuario.Tarifa = If(IsDBNull(datosUsuario("tarifa")), "", datosUsuario("tarifa").ToString())
                objetoUsuario.DeudaAgua = If(IsDBNull(datosUsuario("deudaagua")), 0.0, Convert.ToDouble(datosUsuario("deudaagua")))
                objetoUsuario.DeudaAlcantarillado = If(IsDBNull(datosUsuario("Deudaalcantarillado")), 0.0, Convert.ToDouble(datosUsuario("Deudaalcantarillado")))
                objetoUsuario.Otros = If(IsDBNull(datosUsuario("otros")), 0.0, Convert.ToDouble(datosUsuario("otros")))



                objetoUsuario.Recargos = If(IsDBNull(datosUsuario("recargos")), 0.0, Convert.ToDouble(datosUsuario("recargos")))
                objetoUsuario.AlcaConsumo = If(IsDBNull(datosUsuario("alcaconsumo")), 0D, Convert.ToDecimal(datosUsuario("alcaconsumo")))
                objetoUsuario.Credito = If(IsDBNull(datosUsuario("credito")), 0.0, Convert.ToDouble(datosUsuario("credito")))
                objetoUsuario.Total = If(IsDBNull(datosUsuario("total")), 0.0, Convert.ToDouble(datosUsuario("total")))
                objetoUsuario.CamMed = If(IsDBNull(datosUsuario("CamMed")), False, Convert.ToBoolean(datosUsuario("CamMed")))
                objetoUsuario.DirUbi = If(IsDBNull(datosUsuario("DirUbi")), False, Convert.ToBoolean(datosUsuario("DirUbi")))
                objetoUsuario.DirFis = If(IsDBNull(datosUsuario("DirFis")), False, Convert.ToBoolean(datosUsuario("DirFis")))
                objetoUsuario.LecturaAnt = If(IsDBNull(datosUsuario("LecturaAnt")), 0.0, Convert.ToDouble(datosUsuario("LecturaAnt")))
                objetoUsuario.Requeri = If(IsDBNull(datosUsuario("requeri")), CType(0, Short), Convert.ToInt16(datosUsuario("requeri")))
                objetoUsuario.Cod_Gir = If(IsDBNull(datosUsuario("cod_gir")), "", datosUsuario("cod_gir").ToString())
                objetoUsuario.DirAu = If(IsDBNull(datosUsuario("dirau")), False, Convert.ToBoolean(datosUsuario("dirau")))
                objetoUsuario.Ubicacion = If(IsDBNull(datosUsuario("Ubicacion")), "", datosUsuario("Ubicacion").ToString())
                objetoUsuario.Direccion = If(IsDBNull(datosUsuario("Direccion")), "", datosUsuario("Direccion").ToString())
                objetoUsuario.Alcantarillado = If(IsDBNull(datosUsuario("Alcantarillado")), False, Convert.ToBoolean(datosUsuario("Alcantarillado")))
                objetoUsuario.Saneamiento = If(IsDBNull(datosUsuario("Saneamiento")), False, Convert.ToBoolean(datosUsuario("Saneamiento")))
                objetoUsuario.IdCuotaValvulista = If(IsDBNull(datosUsuario("idcuotavalvulista")), 0, Convert.ToInt32(datosUsuario("idcuotavalvulista")))
                objetoUsuario.NodePeriodo = If(IsDBNull(datosUsuario("nodeperiodo")), 0, Convert.ToInt32(datosUsuario("nodeperiodo")))
                objetoUsuario.PeriodoAdeudo = If(IsDBNull(datosUsuario("PeriodoAdeudo")), "", datosUsuario("PeriodoAdeudo").ToString())
                objetoUsuario.IVA = If(IsDBNull(datosUsuario("IVA")), 0.0, Convert.ToDouble(datosUsuario("IVA")))
                objetoUsuario.CuentaAnterior = If(IsDBNull(datosUsuario("cuentaAnterior")), "", datosUsuario("cuentaAnterior").ToString())



            End If



        Catch ex As Exception

            MessageBox.Show($"OCURRIO UN ERROR: {ex.ToString()}")

        End Try



        Return objetoUsuario

    End Function

End Class
