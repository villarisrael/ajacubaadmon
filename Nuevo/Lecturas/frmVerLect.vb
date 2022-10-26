Public Class frmVerLect

    Private _cuenta As Double
    Private _idcomu As String

    Public Property cuenta() As Double
        Get
            Return _cuenta
        End Get
        Set(ByVal value As Double)
            _cuenta = value
        End Set
    End Property

    Public Property idcomu() As String
        Get
            Return _idcomu
        End Get
        Set(ByVal value As String)
            _idcomu = value
        End Set
    End Property

    Private Sub frmVerLect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CatControl1.dgDAt.CellBorderStyle = DataGridViewCellBorderStyle.None
        CatControl1.dgDAt.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        'CatControl1.filtrar("select trabajadores.nombre as LECTURISTA, concat(lecturas.mes,' ', lecturas.an_per) as PERIODO,lecturas.fec_lec as 'FECHA DE LECTURA', " & _
        '"lecturas.lecturaant as 'LECTURA ANTERIOR', lecturas.lectura as 'LECTURA ACTUAL', lecturas.consumo as  " & _
        '"CONSUMO,lecturas.consumocobrado as Mts_cobrados, lecturas.sit_med as 'SIT. MEDIDOR', lecturas.sit_pad as 'SIT. PADRÓN', lecturas.sit_hid as   " & _
        '"'SIT. HIDRÓMETRO', lecturas.status as ESTADO, lecturas.fec_cap as 'FECHA DE CAPTURA',  lecturas.accion as ACCIÓN, cuotas.descripcion_cuota as TARIFA " & _
        '"from lecturas, trabajadores, cuotas " & _
        '"where  lecturas.tarifa=cuotas.id_tarifa  and lecturas.cuenta=" & _cuenta & "  order by valornummes(mes,an_per) desc")
        ''CatControl1.filtrar("select t.nombre as LECTURISTA, concat(l.mes,' ', l.an_per) as PERIODO, l.fec_lec as 'FECHA DE LECTURA', l.lectant as 'LECTURA ANTERIOR', l.lectura as 'LECTURA ACTUAL', l.consumo as  CONSUMO,l.consumocobrado as Mts_cobrados, l.sit_med as 'SIT. MEDIDOR', l.sit_pad as 'SIT. PADRÓN', l.sit_hid as   'SIT. HIDRÓMETRO', l.fec_cap as 'FECHA DE CAPTURA',  l.accion as ACCIÓN, c.descripcion_cuota as TARIFA from lecturas l, trabajadores t, cuotas c where  l.tarifa=c.id_tarifa  and l.cuenta=" & _cuenta & "  order by valornummes(mes,an_per) desc;"

        CatControl1.filtrar("select t.nombre as 'LECTURISTA', l.cuenta as 'CUENTA', concat(mes,' ',an_per) as 'PERIODO', l.fec_lec as 'FECHA DE LECTURA', l.lectant as 'LECTURA ANTERIOR', l.lectura as 'LECTURA ACTUAL', l.consumo as 'CONSUMO', l.consumocobrado as 'Mts_COBRADOS', l.sit_med as 'SIT. MEDIDOR', l.sit_pad as 'SIT. PADRÓN', l.sit_hid as 'SIT. HIDRÓMETRO', l.fec_cap  as 'FECHA DE CAPTURA' from lecturas l, trabajadores t where l.cuenta=" & _cuenta & "  and t.idTrab=l.Lecturista order by valornummes(mes,an_per) desc;")
      

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub cmdBus_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdBus.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdImp.Click
        Dim frmrep As New frmReporte(frmReporte.Lista.verLecturas, "{lecturas1.cuenta}=" & _cuenta & " }")
        frmrep.MdiParent = MDIPrincipal
        frmrep.Show()
        frmrep.WindowState = FormWindowState.Maximized

    End Sub

End Class