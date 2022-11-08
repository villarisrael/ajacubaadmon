Public Class FrmLecturasNoCapturadas
#Region "Modificadores de acceso"
    Dim _Estado As Boolean

    Dim _Numero As Double, _Region As String, _Ruta As String
    Dim _Periodo As Int16
    Public mes As String
    Dim reg As String
    Dim rut As String
   
    Public Property Estado() As Boolean
        Get
            Return _Estado
        End Get
        Set(ByVal value As Boolean)
            _Estado = value
        End Set
    End Property
    Public Property Periodo() As Int16
        Get
            Return _Periodo
        End Get
        Set(ByVal value As Int16)
            _Periodo = value
        End Set
    End Property
    Public Property Regi() As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
        End Set
    End Property
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
        End Set
    End Property
    Public Property Numero() As Double
        Get
            Return _Numero
        End Get
        Set(ByVal value As Double)
            _Numero = value
        End Set
    End Property

    Public local As FrmCalculaConsumo
#End Region

    Private Sub FrmLecturasNoCapturadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reg = obtenerCampo("Select region from region where id_region = '" & _Region & "'", "region")
        rut = obtenerCampo("Select ruta from rutas where id_ruta = '" & _Ruta & "' and id_region = '" & _Region & "' ", "ruta")
        Text = "Lecturas no capturadas"
        LblTitulo.Text = "Existen " & _Numero & " usuarios que no han sido capturadas para la Region: " & reg & " y la Ruta: " & rut & ", que situación deseas aplicar para estas lecturas?"
        llenaGrid(DGSituaciones, "Select situacion.clave, situacion, tipo, descrip from situacion, algoritmos where situacion.algoritmo = algoritmos.clave and accion = 'Promediar' order by clave")
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        _Estado = False
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        BtnAceptar.Enabled = False
        BtnCancelar.Enabled = False
        BtnImprimir.Enabled = False
        Dim lec As New ClsLecturas

        lec.Region = _Region
        lec.Ruta = _Ruta
        lec.periodo = Periodo
        lec.mes = mes
        Dim Tip As String = DGSituaciones.Item(2, DGSituaciones.CurrentRow.Index).Value

        'Dim rs As IDataReader
        'Try
        '    rs = ConsultaSql("select v.cuenta, v.nombre, v.direccion, promedio(cuenta,3) as promedio from vusuario, cuotas where vusuario.mostrar = 1 and vusuario.descripcion_cuota = cuotas.descripcion_cuota and cuotas.medido <> 0 and  region = '" & _Region & "' and ruta = '" & _Ruta & "' and (cuenta not in (select cuenta from lecturas)) order by lote asc;").ExecuteReader
        'Catch ex As Exception
        '    MessageBoxEx.Show("No existe el archivo de esta ruta", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End Try
        Dim Sit_med, Sit_Hid, Sit_pad As String
        Select Case Tip
            Case "Medición"
                Sit_Med = DGSituaciones.Item(0, DGSituaciones.CurrentRow.Index).Value
            Case "Hidrómetro"
                Sit_Hid = DGSituaciones.Item(0, DGSituaciones.CurrentRow.Index).Value
            Case "Padrón"
                Sit_Pad = DGSituaciones.Item(0, DGSituaciones.CurrentRow.Index).Value
        End Select
        lec.Sit_Hid = Sit_Hid
        lec.Sit_Pad = Sit_pad
        lec.Sit_Med = Sit_med
      '  lec.mes = local.cmbmes.SelectedText
        lec.Crear(PB)
        'Dim x As New frmListadoNocapturadas
        'x.ori = local
        'x.ShowDialog()
        _Estado = True
        Close()
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        BtnAceptar.Enabled = False
        BtnCancelar.Enabled = False
        BtnImprimir.Enabled = False
        Dim lec As New ClsLecturas
        Dim sql As String

        Dim sqlConsulta As String
        ''lec.Ruta = _Ruta
        ''lec.Comunidad = _Comunidad
        ''lec.Region = _Region
        Try
            Ejecucion("Delete from repusuario")
            'Ejecucion("Create Table repusuario like select * from  vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and id_comunidad = '" & _Comunidad & "' and region = '" & _Region & "' and ruta = '" & _Ruta & "' and mostrar = 1 and (cuenta not in (select cuenta from " & lec.Tabla & ")")
            'Ejecucion("Create Table repusuario select * from  vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and id_comunidad = '" & _Comunidad & "' and region = '" & _Region & "' and ruta = '" & _Ruta & "' and mostrar = 1 and (cuenta not in (select cuenta from " & lec.Tabla & ")")
            sql = "Insert into repusuario select cuenta, nombre, comunidad, colonia, Direccion, numext, numint, nodemedidor, sector, ruta, lote, manzana, region from vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0  and region = '" & _Region & "' and ruta = '" & _Ruta & "' and mostrar = 1 and (cuenta not in (select cuenta from lecturas  ))"
            Ejecucion(sql)



        Catch ex As Exception
            ' MessageBoxEx.Show(ex.Message)
        End Try


        Dim Titulo As String = "'REGION: " & reg & " RUTA: " & rut & "'"


        'Select Case cuenta, nombre, domicilio from usuario  inner join cuotas On usuario.tarifa=cuotas.id_tarifa where  cuotas.medido=1 And  region = '001' and ruta = '003'  and cuenta not in (
        ' Select Case LECTURAS.cuenta from lecturas INNER JOIN USUARIO On lecturas.cuenta=usuario.cuenta   where lecturas.mes ="OCT" And lecturas.an_per=2022 And  
        'usuario.region = '001' and usuario.ruta = '003' );
        sqlConsulta = $"Select cuenta, nombre, domicilio from usuario  inner join cuotas On usuario.tarifa=cuotas.id_tarifa where  cuotas.medido=1 And  region = '{_Region}' and ruta = '{_Ruta}'  and cuenta not in (Select LECTURAS.cuenta from lecturas INNER JOIN USUARIO On lecturas.cuenta=usuario.cuenta   where lecturas.mes = '{mes}' And lecturas.an_per=2022 And usuario.region = '{_Region}' and usuario.ruta = '{_Ruta}')"

        Dim objReporte As New ReporteLecturasNoCaptuadas
        objReporte.GenerarReporteLecturasNoCapturadas(sqlConsulta, Titulo)


        'Dim rep As New frmReporte(frmReporte.Lista.LecNoCapturadas, "", "Titulo, " & Titulo)
        'rep.MdiParent = MDIPrincipal
        'rep.Show()
        'rep.WindowState = FormWindowState.Maximized
        '_Estado = False
        Close()
    End Sub

   
End Class
