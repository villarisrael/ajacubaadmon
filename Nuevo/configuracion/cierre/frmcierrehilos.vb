Public Class frmcierrehilos
    Dim IDCOMUENTREE As String
    Dim REGIONENTREE As String
    Dim RUTAENTREE As String
    Dim CADENACOMUNIDAD As String
    Dim CADENAREGION As String
   
#Region "Carga el formulario"
    Private Sub frmcierrehilos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub frmcierrehilos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xr As IDataReader = ConsultaSql("Select rutas.id_ruta, rutas.id_region, rutas.id_comunidad, rutas.Ruta as ruta,   region.region, comunidades.comunidad as comunidad  from rutas, region, comunidades where rutas.id_region= region.id_region and rutas.id_comunidad=region.id_comunidad and region.id_comunidad= comunidades.id_comunidad order by Comunidades.comunidad, rutas.id_region, rutas.id_ruta ").ExecuteReader
        Dim COMU As IDataReader = ConsultaSql("SELECT * FROM COMUNIDADES ORDER BY COMUNIDAD").ExecuteReader
        Dim contadordecomunidades = 0
        llenarCombo(cmbCom, "select id_comunidad, comunidad from comunidades order by comunidad")

        xr.Read()
        Do While COMU.Read()
            Dim comun As String = COMU("comunidad")
            Advcomunidadregion.Nodes.Add(New DevComponents.AdvTree.Node())
            Advcomunidadregion.Nodes.Item(contadordecomunidades).Cells(0).Text = comun
            Dim contadorderegiones = 0
            Dim contadorderutas = 0

            Do While True
                If xr("COMUNIDAD") = comun Then
                    Dim REGION As String = xr("REGION")
                    Dim RUTA As String = xr("RUTA")
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes.Add(New DevComponents.AdvTree.Node)
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells(0).Text = comun
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells.Add(New DevComponents.AdvTree.Cell)
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells(1).Text = REGION
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells.Add(New DevComponents.AdvTree.Cell)
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells(2).Text = RUTA
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells.Add(New DevComponents.AdvTree.Cell)
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells(3).Text = xr("ID_COMUNIDAD")
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells.Add(New DevComponents.AdvTree.Cell)
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells(4).Text = xr("ID_REGION")
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells.Add(New DevComponents.AdvTree.Cell)
                    Advcomunidadregion.Nodes.Item(contadordecomunidades).Nodes(contadorderegiones).Cells(5).Text = xr("ID_RUTA")
                    contadorderegiones += 1
                Else
                    contadorderegiones = 0
                    Exit Do
                End If
                If Not xr.Read() Then Exit Do
            Loop
            contadordecomunidades += 1
        Loop

        Advcomunidadregion.Enabled = False
    End Sub
#End Region

#Region "verificacion"
    Private Sub Advcomunidadregion_AfterNodeSelect(ByVal sender As Object, ByVal e As DevComponents.AdvTree.AdvTreeNodeEventArgs) Handles Advcomunidadregion.AfterNodeSelect
        verifica()
        
    End Sub

    Public Sub verifica()
        Try
            REGIONENTREE = Advcomunidadregion.SelectedNode.Cells(4).Text
            RUTAENTREE = Advcomunidadregion.SelectedNode.Cells(5).Text
            IDCOMUENTREE = Advcomunidadregion.SelectedNode.Cells(3).Text
            Dim HJL As IDataReader = ConsultaSql("SELECT TOMALEC, CAPTURA, CALCULO, CIERRE FROM RUTAS WHERE ID_RUTA='" & RUTAENTREE & "' AND ID_COMUNIDAD='" & IDCOMUENTREE & "' AND ID_REGION ='" & REGIONENTREE & "'").ExecuteReader
            Dim _tabla As String
            If HJL.Read() Then
                Advverificaciones.Nodes(0).Cells(1).Text = HJL("tomalec")
                'Advverificaciones.Nodes(0).Cells("tomalec").Text = HJL("cread")
                _tabla = String.Concat("TmpLecturas", IDCOMUENTREE, "_", REGIONENTREE, "_", RUTAENTREE)
                Try
                    Dim temcap As IDataReader = ConsultaSql("select * from " & _tabla & " limit 1").ExecuteReader
                    Advverificaciones.Nodes(1).Cells(1).Text = "S"
                    Advverificaciones.Nodes(1).Cells(2).HostedControl = Nothing
                    BTNCREARTEMPORAL.Visible = False
                Catch ex As Exception
                    Advverificaciones.Nodes(1).Cells(1).Text = "N"
                    Advverificaciones.Nodes(1).Cells(2).HostedControl = BTNCREARTEMPORAL
                    BTNCREARTEMPORAL.Visible = True
                End Try

                Advverificaciones.Nodes(2).Cells(1).Text = HJL("captura")
                If HJL("captura") = "N" And Advverificaciones.Nodes(1).Cells(1).Text = "S" Then
                    Advverificaciones.Nodes(2).Cells(2).HostedControl = btningnorar
                    btningnorar.Visible = True
                Else
                    Advverificaciones.Nodes(2).Cells(2).HostedControl = Nothing
                End If
                Advverificaciones.Nodes(3).Cells(1).Text = HJL("calculo")
                If HJL("CALCULO") = "N" And (Advverificaciones.Nodes(2).Cells(1).Text = "S" Or Advverificaciones.Nodes(2).Cells(1).Text = "I") And Advverificaciones.Nodes(1).Cells(1).Text = "S" Then
                    Advverificaciones.Nodes(3).Cells(2).HostedControl = btnCalcular
                Else
                    Advverificaciones.Nodes(3).Cells(2).HostedControl = Nothing
                End If
                If HJL("calculo") = "S" And HJL("cierre") = "N" Then
                    txtestado1.Text = "YA ESTA LISTA PARA EL CIERRE!!!!"

                    txtestado2.Text = "Arrastra la región al area de operaciones"
                    txtestado1.ForeColor = Color.Green
                    habilitarparacerrar()
                ElseIf Not HJL("calculo") = "S" Then
                    txtestado1.Text = "AUN NO ESTA LISTA PARA EL CIERRE"
                    txtestado1.ForeColor = Color.Black
                    txtestado2.Text = "Realiza las operaciones faltantes"
                End If
                Advverificaciones.Nodes(4).Cells(1).Text = HJL("cierre")

                If HJL("cierre") = "S" Then
                    txtestado1.Text = "LA RUTA SE ENCUENTRA CERRADA"
                    txtestado1.ForeColor = Color.Red
                End If

            End If


        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "crear temporal"
    Private Sub BTNCREARTEMPORAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCREARTEMPORAL.Click
        Dim LECTURA As New ClsLecturas
        LECTURA.Comunidad = IDCOMUENTREE
        LECTURA.Region = REGIONENTREE
        LECTURA.Ruta = RUTAENTREE
        LECTURA.CreaTemporal()
        'Advverificaciones.Nodes(1).Cells(1).Text = "S"
        'Advverificaciones.Nodes(1).Cells(2).HostedControl = Nothing
        verifica()
    End Sub

#End Region

#Region "Ignora captura"
    Private Sub btningnorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningnorar.Click
        Try
            Ejecucion("update rutas set captura='I' WHERE ID_RUTA='" & RUTAENTREE & "' AND ID_REGION='" & REGIONENTREE & "' AND ID_COMUNIDAD='" & IDCOMUENTREE & "'")
            Advverificaciones.Nodes(2).Cells(1).Text = "I"
            Advverificaciones.Nodes(2).Cells(2).HostedControl = Nothing
            verifica()
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Hacer calculo de consumo"
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim Lectura As New ClsLecturas
        Lectura.Comunidad = IDCOMUENTREE
        Lectura.Region = REGIONENTREE
        '        Dim pb As New DevComponents.DotNetBar.Controls.ProgressBarX
        PB.Visible = True
        Advverificaciones.Nodes(3).Cells(2).HostedControl = PB
        Advverificaciones.Enabled = False
        Lectura.ConsumoMes(PB)
        PB.Visible = False
        Advverificaciones.Enabled = True

        Try
            Ejecucion("update rutas set calculo='S' WHERE ID_RUTA='" & RUTAENTREE & "' AND ID_REGION='" & REGIONENTREE & "' AND ID_COMUNIDAD='" & IDCOMUENTREE & "'")
            Advverificaciones.Nodes(3).Cells(1).Text = "S"
            Advverificaciones.Nodes(3).Cells(2).HostedControl = Nothing
        Catch ex As Exception

        End Try
        verifica()
    End Sub
#End Region

#Region "Arrastra"
    Private Sub frmcierrehilos_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Advcomunidadregion_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Advcomunidadregion.DragEnter
        REGIONENTREE = Advcomunidadregion.SelectedNode.Cells(4).Text
        RUTAENTREE = Advcomunidadregion.SelectedNode.Cells(5).Text
        IDCOMUENTREE = Advcomunidadregion.SelectedNode.Cells(3).Text

        If REGIONENTREE = "" Then

            Exit Sub
        End If
        Dim HJL As IDataReader = ConsultaSql("SELECT TOMALEC, CAPTURA, CALCULO, CIERRE FROM RUTAS WHERE ID_RUTA='" & RUTAENTREE & "' AND ID_COMUNIDAD='" & IDCOMUENTREE & "' AND ID_REGION ='" & REGIONENTREE & "'").ExecuteReader

        If HJL.Read() Then
            If HJL("calculo") = "N" Then

                REGIONENTREE = ""
                RUTAENTREE = ""
                IDCOMUENTREE = ""
                CADENACOMUNIDAD = ""
                CADENAREGION = ""
                'AdvCierre.Enabled = False
                Exit Sub
            End If
            If HJL("cierre") = "S" Then
                REGIONENTREE = ""
                RUTAENTREE = ""
                IDCOMUENTREE = ""
                CADENACOMUNIDAD = ""
                CADENAREGION = ""

                Exit Sub
            End If
            
        End If

        REGIONENTREE = ""
        RUTAENTREE = ""
        IDCOMUENTREE = ""
        CADENACOMUNIDAD = ""
        CADENAREGION = ""
        REGIONENTREE = Advcomunidadregion.SelectedNode.Cells(4).Text
        RUTAENTREE = Advcomunidadregion.SelectedNode.Cells(5).Text
        IDCOMUENTREE = Advcomunidadregion.SelectedNode.Cells(3).Text
        CADENACOMUNIDAD = Advcomunidadregion.SelectedNode.Cells(0).Text
        CADENAREGION = Advcomunidadregion.SelectedNode.Cells(1).Text
    End Sub


   
   


   
#End Region

#Region "Cierra"
    Public Sub cierra(ByVal idcomunidad As String, ByVal idregion As String)

        Dim datos As IDataReader, Ultimo As Date
        Try
            datos = ConsultaSql("SELECT Clave FROM cierre WHERE ID_COMUNIDAD='" & idcomunidad & "' AND ID_REGION='" & idregion & "'  and mes='" & MonthName(DTPeriodo.Value.Month, True) & "' and anio=" & DTPeriodo.Value.Year & "  ").ExecuteReader
            If datos.Read() Then
                MessageBoxEx.Show("Este periodo ya se realizo el cierre, por lo que no se puede realizar nuevamente", "Cierre de Mes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        Catch ex As Exception
            GoTo salir
        End Try
        Try
            datos = ConsultaSql("select mes, anio from cierre WHERE ID_COMUNIDAD='" & idcomunidad & "' AND ID_REGION='" & idregion & "'  order by valornummes(mes, anio)  desc").ExecuteReader
            If datos.Read Then
                Ultimo = CDate("01/" & datos("mes") & "/" & datos("anio"))
                If Ultimo >= DTPeriodo.Value Then
                    MessageBoxEx.Show("Existe un cierre para un mes mas reciente , el ultimo cierre es de " & datos("mes") & " " & datos("anio"), "Cierre de mes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Salir
                End If
                Ultimo = DateAdd(DateInterval.Month, 1, Ultimo)
                Ultimo = CDate("01/" & Ultimo.Month & "/" & Ultimo.Year)
                DTPeriodo.Value = CDate("01/" & DTPeriodo.Value.Month & "/" & DTPeriodo.Value.Year)
                If DTPeriodo.Value > Ultimo Then
                    'If MessageBoxEx.Show("No se puede realizar el cierre para ese mes, dado que el periodo no corresponde, el ultimo cierre es de " & datos("mes") & " " & datos("anio") & vbCrLf & "¿Desea realizar de todas formas el cierre para este mes? ", "Cierre de mes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    'AdvCierre.SelectedNode.Cells(2).HostedControl = Nothing
                    MsgBox("El periodo no corresponde, el ultimo cierre es de " & datos("mes") & " " & datos("anio") & "")
                    GoTo Salir
                    'End If
                End If
            Else
                'si la tabla cierre esta en blanco preguntar
                'If MessageBoxEx.Show("El cierre anterior a este periodo no corresponde desea continuar", "Cierre de mes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                'AdvCierre.SelectedNode.Cells(2).HostedControl = Nothing
                'AdvCierre.SelectedNode.Cells(2).Text = "El cierre anterior a este periodo no corresponde "
                'PBC.Text = "El cierre anterior a este periodo no corresponde desea continuar"
                'GoTo Salir
                'End If

            End If

        Catch ex As Exception

        End Try

        Dim l As New ClsLecturas
        Dim valida As Integer = 0
        l.Comunidad = idcomunidad
        l.Region = idregion
        l.Periodo = DTPeriodo.Value

        valida = l.verificaparacerrar()
        If valida = 0 Then
            Advcomunidadregion.Enabled = True
            PBC.Text = "No se puede hacer el cierre de esta region"
            Exit Sub
        End If
        Dim x As New classcierre
        x.Comunidad = idcomunidad
        x.Region = idregion
        x.fecini = fecini.Value
        x.fecvto = fec_vto.Value
        x.Mes = DTPeriodo.Value

        PBC.TextVisible = True

        PBC.Text = "Preparando datos ..."
        valida = x.crearcierreporregion()
        If valida = 1 Then
            Advcomunidadregion.Enabled = True
            PBC.Text = "No se puede hacer el cierre de esta región"
            GoTo Salir
        End If

        l.AplicarLectura(PBC)
        PBC.Text = "Elaborando Cierre...."
        x.CIERRA(PBC)

        PBC.Text = "Grabando datos del cierre..."
        x.GRABADATO()
        
        Ejecucion("update rutas set  Cierre= 'S' where id_comunidad = '" & x.comunidad & "' and id_region = '" & x.region & "'")
        MessageBoxEx.Show("Se ha terminado el proceso de cierre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


Salir:
        fecini.Enabled = True
        fec_vto.Enabled = True
        DTPeriodo.Enabled = True
    End Sub
#End Region

    Private Sub fecini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecini.Click
        If fecini.Value <> Nothing And fec_vto.Value <> Nothing And DTPeriodo.Value <> Nothing Then
            Advcomunidadregion.Enabled = True
        Else
            Advcomunidadregion.Enabled = False
        End If
    End Sub

    Private Sub fec_vto_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fec_vto.ValueChanged
        If fecini.Value <> Nothing And fec_vto.Value <> Nothing And DTPeriodo.Value <> Nothing Then
            Advcomunidadregion.Enabled = True
        Else
            Advcomunidadregion.Enabled = False
        End If
    End Sub

    Private Sub fecini_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecini.ValueChanged
        If fecini.Value <> Nothing And fec_vto.Value <> Nothing And DTPeriodo.Value <> Nothing Then
            Advcomunidadregion.Enabled = True
        Else
            Advcomunidadregion.Enabled = False
        End If
    End Sub

    Private Sub DTPeriodo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPeriodo.ValueChanged
        If fecini.Value <> Nothing And fec_vto.Value <> Nothing And DTPeriodo.Value <> Nothing Then
            Advcomunidadregion.Enabled = True
        Else
            Advcomunidadregion.Enabled = False
        End If
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        btncerrar.Enabled = False
        cierra(IDCOMUENTREE, REGIONENTREE)
    End Sub

    Public Sub habilitarparacerrar()
        PBC.Minimum = 0
        PBC.Maximum = 100
        PBC.Value = 0
        ' Advcomunidadregion.Enabled = False
        PBC.Visible = True
        btncerrar.Visible = True
        btncerrar.Enabled = True
        fecini.Enabled = False
        fec_vto.Enabled = False
        DTPeriodo.Enabled = False
        btncerrar.Visible = True
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        dlginiciarvariables.ShowDialog()
        If dlginiciarvariables.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Try
                Ejecucion("update rutas set cierre='N', calculo='N', aplicacion='N',Tomalec='N', CAPTURA='N'")
            Catch ex As Exception
                MsgBox("NO SE INICIALIZARON LAS VARIABLES")
            End Try
        End If
    End Sub

    Private Sub cmdIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIni.Click
        If cmbCom.Text = "" Then
            MessageBoxEx.Show("Antes de forzar el cierre especifique una comunidad, por favor", "Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If cmbReg.Text = "" Then
            MessageBoxEx.Show("Antes de forzar el cierre especifique la región, por favor", "Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If MessageBoxEx.Show("¿Desea forzar el cierre de la comunidad " & cmbCom.Text & ", region " & cmbReg.Text & "?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cmdIni.Text = "Procesando..."
            cmdIni.Enabled = False
            Ejecucion("call cierremanual('" & cmbCom.SelectedValue.ToString & "','" & cmbReg.SelectedValue.ToString & "','" & UCase(MonthName(DTPeriodo.Value.Month, True)) & "'," & DTPeriodo.Value.Year & ")")
            MessageBoxEx.Show("Cierre procesado con éxito", "Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdIni.Enabled = True
            cmdIni.Text = "Iniciar"
        End If
    End Sub

    Private Sub cmbCom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCom.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbCom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCom.SelectedIndexChanged
        If Not cmbCom.SelectedValue Is Nothing Then
            llenarCombo(cmbReg, "select id_region, region from region where id_comunidad='" & cmbCom.SelectedValue.ToString & "' order by region")

        End If
    End Sub

    Private Sub cmbReg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbReg.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmdIni_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIni.GotFocus
        cmdIni.Pulse()
        cmdIni.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdIni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIni.LostFocus
        cmdIni.StopPulse()
    End Sub
End Class