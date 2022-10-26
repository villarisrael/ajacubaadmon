Imports DevComponents.DotNetBar

Public Class frmOrdTrab
    Private vinode As vienede
    Private _cuenta As Double
    Private _idcom As String
    Private _medidor As String
    Private idper As IDataReader = Nothing
    Enum vienede
        ordenes
        principal
        Hidrómetros
    End Enum

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal vengode As vienede, Optional ByVal cuenta As Double = Nothing, Optional ByVal idcom As String = Nothing, Optional ByVal medidor As Double = 0)
        InitializeComponent()
        vinode = vengode

        If vinode = vienede.principal OrElse vinode = vienede.Hidrómetros Then
            cmdAgr.Visible = False
            cmdEditar.Visible = False
            cmdCan.Visible = False
            cmdEst.Visible = False
            _cuenta = cuenta
            _idcom = idcom
            _medidor = medidor
        End If
    End Sub

    Private Sub frmOrdTrab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If vinode <> vienede.Hidrómetros Then
            MDIPrincipal.RBCis.Select()
        Else
            MDIPrincipal.RBHidrometros.Select()
        End If
    End Sub
    Private Sub frmOrdTrab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CatControl1.filtrar("select ordent.folio as Folio, ordent.nombre as Nombre, ordent.cuenta as Cuenta, comunidades.comunidad as Comunidad, ordent.ubicacion as Ubicación, ordent.status as Estado, ordent.fec_ord as Fecha, ordent.hora as Hora from ordent, comunidades where ordent.id_comunidad=comunidades.id_comunidad order by ordent.fec_ord desc, ordent.hora desc")
        '*************************
        'idper = ConsultaSql("select * from letras where ccodusuario=" & NumUser & "").ExecuteReader()
        'If idper.Read() Then
        '    If Not CBool(idper("AgrOrd")) Then cmdAgr.Visible = False
        '    If Not CBool(idper("ResultadoOrd")) Then cmdEditar.Visible = False
        '    If Not CBool(idper("EditarOrd")) Then cmdEdit.Visible = False
        '    If Not CBool(idper("EditarZonOrd")) Then cmdEditZona.Visible = False
        '    If Not CBool(idper("VisualizarOrd")) Then cmdVis.Visible = False
        '    If Not CBool(idper("CancelarOrd")) Then cmdCan.Visible = False
        '    If Not CBool(idper("RepTipQueja")) Then cmdTipQ.Visible = False
        '    If Not CBool(idper("RepCalOrd")) Then cmdCal.Visible = False
        '    If Not CBool(idper("RepListOrd")) Then cmdList.Visible = False

        '    If Not CBool(idper("RepTipQueja")) AndAlso Not CBool(idper("RepCalOrd")) AndAlso Not CBool(idper("RepListOrd")) Then
        '        cmdEst.Visible = False
        '    End If

        'End If
        '**************************************
        Ejecucion("update ordent set status=4 where fec_res is null and datediff(current_date,fec_com)>=3 and datediff(current_date,fec_com) <7 and status != 'CANCELADA'")
        Ejecucion("update ordent set status=5 where fec_res is null and datediff(current_date,fec_com)>=7 and status != 'CANCELADA'")
        Ejecucion("update ordent set status=1 where status='0' AND status <> 'CANCELADA'")
        Ejecucion("update ordent set fec_res=null where fec_res='001-01-01'")


        If vinode = vienede.principal Then
            'CatControl1.filtrar("select ordent.folio as Folio, deptos.nombre as Departamento, ordent.nombre as Nombre, ordent.cuenta as Cuenta, comunidades.comunidad as Comunidad, ordent.ubicacion as Ubicación, ordent.status as Estado, ordent.fec_ord as Fecha, ordent.hora as Hora, ordent.fec_res as Resultado, ordent.fec_com as Compromiso, ordent.indic as Indicación, cveque.descripcion as Concepto from ordent, comunidades, deptos,cveque where ordent.id_comunidad=comunidades.id_comunidad and ordent.cod_res=deptos.cod_dep and ordent.cod_cve=cveque.cod_cve and ordent.cuenta='" & _cuenta & "' and ordent.id_comunidad='" & _idcom & "' order by ordent.fec_ord desc, ordent.hora desc")
            CatControl1.filtrar("select vordent.status as Estado, vordent.folio as Folio, comunidades.comunidad as Comunidad,  vordent.cuenta as Cuenta, vordent.nombre as Nombre, vordent.Descripcion_queja as Concepto, vordent.fec_ord as Fecha, vordent.hora as Hora,  vordent.fec_res as Resultado,  vordent.fec_com as Compromiso, vordent.Departamento,  vordent.ubicacion as Ubicación   from vordent, comunidades where vordent.id_comunidad=comunidades.id_comunidad and vordent.cuenta='" & _cuenta & "' and vordent.id_comunidad='" & _idcom & "' order by vordent.fec_ord desc, vordent.hora desc")
            If CatControl1.dgDAt.RowCount <= 0 Then
                MessageBoxEx.Show("EL USUARIO NO TIENE ÓRDENES DE TRABAJO", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        ElseIf vinode = vienede.Hidrómetros Then
            'CatControl1.filtrar("select ordent.nodemedidor as 'No. Medidor', ordent.folio as Folio, deptos.nombre as Departamento, ordent.nombre as Nombre, ordent.cuenta as Cuenta, comunidades.comunidad as Comunidad, ordent.ubicacion as Ubicación, ordent.status as Estado, ordent.fec_ord as Fecha, ordent.hora as Hora, ordent.fec_res as Resultado, ordent.fec_com as Compromiso, ordent.indic as Indicación, cveque.descripcion as Concepto from ordent, comunidades, deptos,cveque where ordent.id_comunidad=comunidades.id_comunidad and ordent.cod_res=deptos.cod_dep and ordent.cod_cve=cveque.cod_cve and ordent.nodemedidor='" & _medidor & "' order by ordent.fec_ord desc, ordent.hora desc")
            CatControl1.filtrar("select vordent.nodemedidor as 'No. Medidor', vordent.folio as Folio, vordent.Departamento, vordent.nombre as Nombre, vordent.cuenta as Cuenta, comunidades.comunidad as Comunidad, vordent.ubicacion as Ubicación, vordent.status as Estado, vordent.fec_ord as Fecha, vordent.hora as Hora, vordent.fec_res as Resultado, vordent.fec_com as Compromiso, vordent.indic as Indicación, vordent.Descripcion_queja as Concepto from vordent, comunidades where vordent.id_comunidad=comunidades.id_comunidad and vordent.nodemedidor='" & _medidor & "' order by vordent.fec_ord desc, vordent.hora desc")
            If CatControl1.dgDAt.RowCount <= 0 Then
                MessageBoxEx.Show("EL MEDIDOR NO TIENE ÓRDENES DE TRABAJO", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            CatControl1.filtrar("select vordent.status as Estado,vordent.folio as Folio,comunidades.comunidad as Comunidad, vordent.cuenta as Cuenta,vordent.nombre as Nombre,vordent.Descripcion_queja as Concepto , vordent.fec_ord as Fecha,  vordent.hora as Hora, vordent.fec_res as Resultado,vordent.fec_com AS Compromiso,  vordent.Departamento, vordent.ubicacion as Ubicación from vordent, comunidades where vordent.id_comunidad=comunidades.id_comunidad order by vordent.folio  desc limit 3000")
            '  CatControl1.filtrar("select vordent.status as Estado, vordent.folio as Folio, comunidades.comunidad as Comunidad,  vordent.cuenta as Cuenta, vordent.nombre as Nombre, vordent.Descripcion_queja as Concepto, vordent.fec_ord as Fecha, vordent.hora as Hora,  vordent.fec_res as Resultado,  vordent.fec_com as Compromiso, vordent.Departamento  vordent.ubicacion as Ubicación   from vordent, comunidades where where vordent.id_comunidad=comunidades.id_comunidad order by vordent.folio desc")
        End If

    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If CatControl1.darNumReg > 0 Then
            If CatControl1.darSeleccionado("Estado").ToString <> "CANCELADA" Then 'AndAlso CatControl1.darSeleccionado("Estado").ToString <> "2" AndAlso CatControl1.darSeleccionado("Estado").ToString <> "3" Then
                CatControl1.Resultado()
            ElseIf CatControl1.darSeleccionado("Estado").ToString = "CANCELADA" Then
                MessageBoxEx.Show("NO SE PUEDE EDITAR EL RESULTADO DE LA ORDEN N º " & CatControl1.darSeleccionado("Folio") & " POR QUE ESTÁ CANCELADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf CatControl1.darSeleccionado("Estado").ToString = "2" OrElse CatControl1.darSeleccionado("Estado").ToString = "3" Then
                '    MessageBoxEx.Show("NO SE PUEDE EDITAR EL RESULTADO DE LA ORDEN N º " & CatControl1.darSeleccionado("Folio") & " POR QUE YA FUE REALIZADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim frmrep As New frmImpOrdC()
        frmrep.ShowDialog()
    End Sub
    Private Sub cmdVis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVis.Click
        CatControl1.Visualizar()
    End Sub
    Private Sub cmdTipQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTipQ.Click
        frmImpEst = Nothing

        Dim frmreptip As New frmImpEst()
        frmreptip.ShowDialog()
    End Sub
    Private Sub cmdCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCal.Click
        frmImpEstC = Nothing

        Dim frmreptip As New frmImpEstC()
        frmreptip.ShowDialog()
    End Sub

    Private Sub cmdact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdact.Click
        CatControl1.Actualizar()
    End Sub

    Private Sub cmdCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCan.Click
        If CatControl1.darNumReg() = 0 Then Exit Sub
        If CatControl1.darSeleccionado("Estado").ToString <> "CANCELADA" AndAlso CatControl1.darSeleccionado("Estado").ToString <> "2" AndAlso CatControl1.darSeleccionado("Estado").ToString <> "3" Then
            If MessageBoxEx.Show("Desea cancelar la orden: " & CatControl1.darSeleccionado("folio") & " ?", "ORDEN DE TRABAJO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Ejecucion("update ordent set status='CANCELADA' where folio=" & CatControl1.darSeleccionado("folio") & "")
                CatControl1.filtrar("select ordent.folio as Folio, ordent.nombre as Nombre, ordent.cuenta as Cuenta, comunidades.comunidad as Comunidad, ordent.ubicacion as Ubicación, ordent.status as Estado, ordent.fec_ord as Fecha, ordent.hora as Hora from ordent, comunidades where ordent.id_comunidad=comunidades.id_comunidad order by ordent.fec_ord desc, ordent.hora desc")
            End If
        ElseIf CatControl1.darSeleccionado("Estado").ToString = "CANCELADA" Then
            MessageBoxEx.Show("LA ORDEN YA ESTÁ CANCELADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CatControl1.darSeleccionado("Estado").ToString = "2" OrElse CatControl1.darSeleccionado("Estado").ToString = "3" Then
            MessageBoxEx.Show("LA ORDEN NO SE PUEDE CANCELAR POR QUE YA FUE REALIZADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cmdList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdList.Click
        frmListOrd = Nothing
        frmListOrd.ShowDialog()
    End Sub

    Private Sub mOp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mOp1.Click
        Dim folio As Double = 0
        Dim idord As IDataReader = Nothing
        Dim idsig As IDataReader = Nothing
        idord = ConsultaSql("select * from ordent where folio=" & CatControl1.darSeleccionado("Folio") & "").ExecuteReader()
        idord.Read()
        If obtenerCampo("select sig_que from cveque where cod_cve='" & idord("cod_cve") & "'", "sig_que") = "" Or obtenerCampo("select sig_que from cveque where cod_cve='" & idord("cod_cve") & "'", "sig_que") = " " Then
            MessageBoxEx.Show("Esta orden no tiene una sub - orden", "Órdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA CREAR LA SUB - ORDEN?", "ÓRDENES DE TRABAJO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Try
                folio = obtenerCampo("select max(folio) + 1 as mFolio from ordent", "mFolio")
            Catch ex As Exception
                folio = 1
            End Try



            If Not IsDBNull(idord("sig_que")) Then
                MessageBoxEx.Show("LA ORDEN YA TIENE UNA SUB-ORDEN", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            idsig = ConsultaSql("select * from cveque where cod_cve='" & obtenerCampo("select sig_que from cveque where cod_cve='" & idord("cod_cve") & "'", "sig_que") & "'").ExecuteReader()


            If idsig.Read() Then
                Ejecucion("insert into ordent(status,folio,fec_ord,hora,id_comunidad,tel,cod_cve,cod_dir" &
                          ",indic,urge,nombre,fec_com,cuenta,ubicacion,cod_res,cel,fuente,COD_ALT) values(1," & folio & ",'" & UnixDateFormat(Now) & "','" & String.Concat(Now.Hour, ":", Now.Minute, ":", Now.Second) & "','" & idord("id_comunidad") &
                          "','" & idord("tel") & "','" & idsig("cod_cve") & "','" & idsig("cod_dir") & "','RECONECTAR LA TOMA',FALSE ,'" & idord("nombre") & "','" & UnixDateFormat(idord("fec_com")) & "'," & idord("cuenta") &
                          ",'" & idord("ubicacion") & "','" & idsig("cod_res") & "','" & idord("cel") & "','" & idord("fuente") & "','" & NumUser & "')")

                Ejecucion("update ordent set sig_que='" & idsig("cod_cve") & "' where folio=" & CatControl1.darSeleccionado("Folio") & "")

                CatControl1.Actualizar()
                Dim frmagr As New frmAgrOrd(folio, frmAgrOrd._tipo.Editar)
                frmagr.MdiParent = My.Forms.MDIPrincipal
                frmagr.Show()
                frmagr.WindowState = FormWindowState.Maximized
            Else
                MessageBoxEx.Show("ESTA ORDEN NO TIENE UNA SUB-ORDEN ESTABLECIDA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub cmdCol2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCol2.Click
        CatControl1.buscar("Estado", "2")
    End Sub
    Private Sub cmdCol3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCol3.Click
        CatControl1.buscar("Estado", "3")
    End Sub
    Private Sub cmdCol1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCol1.Click
        CatControl1.buscar("Estado", "1")
    End Sub
    Private Sub cmdCol4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCol4.Click
        CatControl1.buscar("Estado", "4")
    End Sub
    Private Sub cmdCol5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCol5.Click
        CatControl1.buscar("Estado", "5")
    End Sub
    Private Sub cmdCol6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCol6.Click
        CatControl1.buscar("Estado", "CANCELADA")
    End Sub

    Private Sub cmdImpMasiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImpMasiva.Click
        'Dim ccad As String
        'Dim i As Int16 = 0

        'Ejecucion("DROP TABLE IF EXISTS `baseagua`.`ordent" & My.Computer.Name & "`;")
        'ccad = "CREATE TABLE  `baseagua`.`ordent" & My.Computer.Name & "` ("
        'ccad &= "`STATUS` varchar(10) NOT NULL DEFAULT '1',"
        'ccad &= "`FOLIO` double(19,0) NOT NULL,"
        'ccad &= "`FEC_ORD` date DEFAULT NULL,"
        'ccad &= "`HORA` time DEFAULT NULL,"
        'ccad &= "`NOMBRE` varchar(100) NOT NULL DEFAULT ' ',"
        'ccad &= "`CUENTA` double NOT NULL,"
        'ccad &= "`ID_COMUNIDAD` varchar(3) NOT NULL DEFAULT ' ',"
        'ccad &= "`UBICACION` longtext NOT NULL,"
        'ccad &= "`TEL` varchar(20) DEFAULT ' ',"
        'ccad &= "`CEL` varchar(20) DEFAULT ' ',"
        'ccad &= "`COD_CVE` varchar(3) DEFAULT NULL,"
        'ccad &= "`COD_RES` varchar(3) NOT NULL DEFAULT '0',"
        'ccad &= "`COD_REL` varchar(3) NOT NULL DEFAULT '0',"
        'ccad &= "`COD_DIR` varchar(3) DEFAULT NULL,"
        'ccad &= "`INDIC` longtext,"
        'ccad &= "`FEC_COM` date DEFAULT NULL,"
        'ccad &= "`FEC_RES` date DEFAULT NULL,"
        'ccad &= "`FOLIO_REF` double DEFAULT NULL,"
        'ccad &= "`COMENT1` longtext,"
        'ccad &= "`URGE` tinyint(1) NOT NULL DEFAULT '0',"
        'ccad &= "`REINCIDE` tinyint(1) NOT NULL DEFAULT '0',"
        'ccad &= "`REG_RESP` varchar(3) DEFAULT NULL,"
        'ccad &= "`FEC_RESP` datetime DEFAULT NULL,"
        'ccad &= "`FUENTE` int(10) unsigned NOT NULL DEFAULT '1',"
        'ccad &= "`COD_ALT` varchar(3) NOT NULL DEFAULT ' ',"
        'ccad &= "`PER_ATE` varchar(200) NOT NULL DEFAULT ' ',"
        'ccad &= "`FEC_IMP` date DEFAULT NULL,"
        'ccad &= "`FEC_RIMP` date DEFAULT NULL,"
        'ccad &= "PRIMARY KEY (`FOLIO`),"
        'ccad &= "KEY `USUARIO` (`CUENTA`) USING BTREE,"
        'ccad &= "KEY `colonia` (`ID_COMUNIDAD`) USING BTREE,"
        'ccad &= "KEY `calle` (`ID_COMUNIDAD`) USING BTREE,"
        'ccad &= "KEY `ubi` (`ID_COMUNIDAD`) USING BTREE"
        'ccad &= ") ENGINE=InnoDB DEFAULT CHARSET=latin1;"
        'Ejecucion(ccad)

        'CatControl1.Primero()
        'For i = 0 To CatControl1.dgDAt.RowCount - 1
        '    Ejecucion("insert into ordent" & My.Computer.Name & " select * from ordent where folio=" & CatControl1.darSeleccionado("Folio") & "")
        '    CatControl1.Siguiente()
        'Next
        Dim frmrep As New frmReporte(frmReporte.Lista.ordenTrabajo, "{ordent1.folio}=1")
        frmrep.Show()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CatControl1.darNumReg > 0 Then
            If CatControl1.darSeleccionado("Estado").ToString <> "CANCELADA" AndAlso CatControl1.darSeleccionado("Estado").ToString <> "2" AndAlso CatControl1.darSeleccionado("Estado").ToString <> "3" Then
                CatControl1.Editar()
            ElseIf CatControl1.darSeleccionado("Estado").ToString = "CANCELADA" Then
                MessageBoxEx.Show("NO SE PUEDE EDITAR LA ORDEN N º " & CatControl1.darSeleccionado("Folio") & " POR QUE ESTÁ CANCELADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CatControl1.darSeleccionado("Estado").ToString = "2" OrElse CatControl1.darSeleccionado("Estado").ToString = "3" Then
                MessageBoxEx.Show("NO SE PUEDE EDITAR LA ORDEN N º " & CatControl1.darSeleccionado("Folio") & " POR QUE YA FUE REALIZADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cmdEditZona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditZona.Click
        If CatControl1.darNumReg > 0 Then
            If CatControl1.darSeleccionado("Estado").ToString <> "CANCELADA" AndAlso CatControl1.darSeleccionado("Estado").ToString <> "2" AndAlso CatControl1.darSeleccionado("Estado").ToString <> "3" Then
                Dim frmagr As New frmAgrOrd(CatControl1.darSeleccionado("Folio"), frmAgrOrd._tipo.EditarBrigada)
                'frmagr.MdiParent = My.Forms.MDIPrincipal
                frmagr.ShowDialog()
                frmagr.WindowState = FormWindowState.Normal
            ElseIf CatControl1.darSeleccionado("Estado").ToString = "CANCELADA" Then
                MessageBoxEx.Show("NO SE PUEDE EDITAR LA ZONA DE LA ORDEN N º " & CatControl1.darSeleccionado("Folio") & " POR QUE ESTÁ CANCELADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CatControl1.darSeleccionado("Estado").ToString = "2" OrElse CatControl1.darSeleccionado("Estado").ToString = "3" Then
                MessageBoxEx.Show("NO SE PUEDE EDITAR LA ZONA DE LA ORDEN N º " & CatControl1.darSeleccionado("Folio") & " POR QUE YA FUE REALIZADA", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        CatControl1.Agregar()
    End Sub
End Class