Public Class cierre
    Public Mes As String, Año As Integer, Cuenta As Double, Comunidad As String
    '*****************************
    Private _ultimo As Boolean = False
    Private idult As IDataReader, idusu As IDataReader = Nothing
    Private rez_con As String = "", rez_alca As String = "", rez_san As String = "", rez_rec As String = "", rez_iva As String = ""
    Private act_con As String = "", act_alca As String = "", act_san As String = "", act_rec As String = "", act_iva As String = ""
    Private t_con As String = "", t_alca As String = "", t_san As String = "", t_rec As String = "", t_iva As String = ""
    Private tot_consua As String = "", tot_consun As String = "", tot_gen1 As String = "", otr_cargos As String = "", cargomconsumo As String = "", abodescu As String = "", totalmenosab As String = "", totalfinal As String = ""
    Dim PagadoUl As Boolean = False
    Dim SUMA1 As Double, SUMA2 As Double

#Region "Modificadores"
    Public Property _rez_con() As String
        Get
            Return FormatCurrency(CDbl(rez_con), 2)
        End Get
        Set(ByVal value As String)
            rez_con = value
        End Set
    End Property

    Public Property _rez_alca() As String
        Get
            Return FormatCurrency(CDbl(rez_alca), 2)
        End Get
        Set(ByVal value As String)
            rez_alca = value
        End Set
    End Property

    Public Property _rez_san() As String
        Get
            Return FormatCurrency(CDbl(rez_san), 2)
        End Get
        Set(ByVal value As String)
            rez_san = value
        End Set
    End Property

    Public Property _rez_rec() As String
        Get
            Return FormatCurrency(CDbl(rez_rec), 2)
        End Get
        Set(ByVal value As String)
            rez_rec = value
        End Set
    End Property

    Public Property _rez_iva() As String
        Get
            Return FormatCurrency(CDbl(rez_iva), 2)
        End Get
        Set(ByVal value As String)
            rez_iva = value
        End Set
    End Property

    Public Property _act_con() As String
        Get
            Return FormatCurrency(CDbl(act_con), 2)
        End Get
        Set(ByVal value As String)
            act_con = value
        End Set
    End Property

    Public Property _act_alca() As String
        Get
            Return FormatCurrency(CDbl(act_alca), 2)
        End Get
        Set(ByVal value As String)
            act_alca = value
        End Set
    End Property

    Public Property _act_san() As String
        Get
            Return FormatCurrency(CDbl(act_san), 2)
        End Get
        Set(ByVal value As String)
            act_san = value
        End Set
    End Property

    Public Property _act_rec() As String
        Get
            Return FormatCurrency(CDbl(act_rec), 2)
        End Get
        Set(ByVal value As String)
            act_rec = value
        End Set
    End Property

    Public Property _act_iva() As String
        Get
            Return FormatCurrency(CDbl(act_iva), 2)
        End Get
        Set(ByVal value As String)
            act_iva = value
        End Set
    End Property

    Public Property _tot_consua() As String
        Get
            Return FormatCurrency(CDbl(tot_consua), 2)
        End Get
        Set(ByVal value As String)
            tot_consua = value
        End Set
    End Property

    Public Property _tot_consun() As String
        Get
            Return FormatCurrency(CDbl(tot_consun), 2)
        End Get
        Set(ByVal value As String)
            tot_consun = value
        End Set
    End Property

    Public Property _tot_gen1() As String
        Get
            Return FormatCurrency(CDbl(tot_gen1), 2)
        End Get
        Set(ByVal value As String)
            tot_gen1 = value
        End Set
    End Property

    Public Property _otr_cargos() As String
        Get
            Return FormatCurrency(CDbl(otr_cargos), 2)
        End Get
        Set(ByVal value As String)
            otr_cargos = value
        End Set
    End Property

    Public Property _cargomconsumo() As String
        Get
            Try
                Return FormatCurrency(CDbl(cargomconsumo), 2)
            Catch ex As Exception
                Return FormatCurrency(0, 2)
            End Try

        End Get
        Set(ByVal value As String)
            cargomconsumo = value
        End Set
    End Property

    Public Property _abodescu() As String
        Get
            Return FormatCurrency(CDbl(abodescu), 2)
        End Get
        Set(ByVal value As String)
            abodescu = value
        End Set
    End Property

  

    

    Public Property _t_con() As String
        Get
            Return FormatCurrency(CDbl(t_con), 2)
        End Get
        Set(ByVal value As String)
            t_con = value
        End Set
    End Property

    Public Property _t_alca() As String
        Get
            Return FormatCurrency(CDbl(t_alca), 2)
        End Get
        Set(ByVal value As String)
            t_alca = value
        End Set
    End Property

    Public Property _t_san() As String
        Get
            Return FormatCurrency(CDbl(t_san), 2)
        End Get
        Set(ByVal value As String)
            t_san = value
        End Set
    End Property

    Public Property _t_rec() As String
        Get
            Return FormatCurrency(CDbl(t_rec), 2)
        End Get

        Set(ByVal value As String)
            t_rec = value
        End Set
    End Property

    Public Property _t_iva() As String
        Get
            Return FormatCurrency(CDbl(t_iva), 2)
        End Get
        Set(ByVal value As String)
            t_iva = value
        End Set
    End Property

    Public Property _totalfinal() As String
        Get
            Return FormatCurrency(CDbl(totalfinal), 2)
        End Get
        Set(ByVal value As String)
            totalfinal = value
        End Set
    End Property
#End Region
    Public Sub Mostrar()
        
        '
        Me.llenaultimo()
      
    End Sub

    Private Sub llenaultimo()
        Dim CierreAnt As IDataReader = Nothing
        Dim CierreAntHoy As IDataReader = Nothing
        Dim rconsumo As Double = 0, rrecargo As Double = 0, rsan As Double = 0, ralca As Double = 0, riva As Double = 0, otros As Double = 0
        Dim LOLEYO As Boolean = False
        Dim Tarifa As String = ""
        Dim Comu As String = ""
        idusu = ConsultaSql("select * from vusuario where  and cuenta=" & Cuenta & "").ExecuteReader()
        If idusu.Read() Then
            txtUbi.Text = String.Concat(idusu("Region"), " - ", idusu("ruta"), " - ", idusu("manzana"), " - ", idusu("lote"))
            Tarifa = idusu("descripcion_cuota")
            Comu = idusu("comunidad")

            LblCuenta.Text = Cuenta
            LblComunidad.Text = Comu
            LBLNOMBRE.Text = idusu("nombre")
            LBLCUOTA.Text = Tarifa
            If LBLCUOTA.Text = "0" Then
                LBLCUOTA.Text = ""
            End If
            'CierreAntHoy = ConsultaSql("select rezagoalcanta('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as alcanta, rezagoconsumo('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as consumo, rezagoiva('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as iva, rezagootros('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as otros, rezagorecargos('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as recargos, rezagosanea('" & Comunidad & "'," & Cuenta & ",'" & Mes & "'," & Año & ") as sanea").ExecuteReader()
            'CierreAntHoy.Read()
            ' CierreAnt = ConsultaSql("select * from usuario where id_comunidad = '" & Comunidad & "' and cuenta = " & Cuenta & "; ").ExecuteReader  'mes_periodo='" & Mes & "' and an_per=" & Año & "").ExecuteReader
           
           
           

           
            lbmesini.Text = idusu("periodo")

        LblFServ.Text = obtenerCampo("Select descripcion from formas_servicio where id_forma_servicio = '" & idusu("id_forma_servicio") & "'", "descripcion")

        If LblFServ.Text = "0" Then
            LblFServ.Text = ""
        End If
        LBLGIRO.Text = obtenerCampo("Select descripcION from  GIRO where CODGIR='" & idusu("COD_GIR") & "'", "descripcion")

        If LBLGIRO.Text = "0" Then
            LBLGIRO.Text = ""
        End If
        LBLMEDIDOR.Text = idusu("nodemedidor")
       
        'Consumo Actual
          
            ' act_alca = ralca


      
        End If 'FIN DEL IF DE SI EXISTE EL USUARIO 
    End Sub

End Class