Public Class frmconceptoscxc



    Private Sub frmconceptoscxc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lstcamposgrid As New ListView
        Dim lsttipobus As New ListView
        Dim lstanchogrid As New ListView
        Dim lstnombrecampogrid As New ListView
        Dim lstcamposbusqueda As New ListView
        Dim lstnomcamposbus As New ListView

        lstcamposgrid.Items.Add("id_concepto")
        lstcamposgrid.Items.Add("descripcion")
        lstcamposgrid.Items.Add("tipo")
        lstcamposgrid.Items.Add("Monto_inicial")
        lstcamposgrid.Items.Add("momento")
        lstcamposgrid.Items.Add("evento")

        lstcamposbusqueda.Items.Add("id_concepto")
        lstcamposbusqueda.Items.Add("descripcion")
        lstcamposbusqueda.Items.Add("tipo")
        lstcamposbusqueda.Items.Add("momento")
        lstcamposbusqueda.Items.Add("evento")

        lstnomcamposbus.Items.Add("Id Concepto")
        lstnomcamposbus.Items.Add("Descripcion")
        lstnomcamposbus.Items.Add("Tipo")
        lstnomcamposbus.Items.Add("Momento")
        lstnomcamposbus.Items.Add("Evento")


        lsttipobus.Items.Add("String")
        lsttipobus.Items.Add("String")
        lsttipobus.Items.Add("String")
        lsttipobus.Items.Add("String")
        lsttipobus.Items.Add("String")

        lstnombrecampogrid.Items.Add("ID concepto")
        lstnombrecampogrid.Items.Add("Descripción")
        lstnombrecampogrid.Items.Add("Tipo")
        lstnombrecampogrid.Items.Add("Monto")
        lstnombrecampogrid.Items.Add("Momento")
        lstnombrecampogrid.Items.Add("Evento")

        lstanchogrid.Items.Add("80")
        lstanchogrid.Items.Add("200")
        lstanchogrid.Items.Add("100")
        lstanchogrid.Items.Add("80")
        lstanchogrid.Items.Add("100")
        lstanchogrid.Items.Add("100")

        Catalogo1.camposgrid = lstcamposgrid
        Catalogo1.encabezadosdecampos = lstnombrecampogrid
        Catalogo1.anchosgrid = lstanchogrid
        Catalogo1.campollave = "id_concepto"
        Catalogo1.tipollave = "String"
        Catalogo1.tablaborrado = "conceptoscxc"
        Catalogo1.tablasfrom = "conceptoscxc"
        Catalogo1.wherederelacion = ""
        Catalogo1.listacamposbusqueda = lstnomcamposbus
        Catalogo1.listacamposbustabla = lstcamposbusqueda
        Catalogo1.listatipocambus = lsttipobus
        Catalogo1.quees = "conceptoscxc"
        Me.MdiParent = MDIPrincipal
        Me.WindowState = FormWindowState.Maximized
        Catalogo1.preparar(Me)



    End Sub


    
   
    
 
End Class