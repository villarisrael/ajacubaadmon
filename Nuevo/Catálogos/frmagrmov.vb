Public Class frmagrmov
    Public evento As String
    Private conce As New conceptocxc
    Private even As eve
    Public cadena As String
    Public foliocontrato As Long
    Public nombre As String
    Public idcomunidad As String


    Private Sub frmagrmov_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        llenaporcadena()
    End Sub

    Private Sub frmagrmov_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub



    Private Sub frmagrmov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'conectar()
        Dim idr As IDataReader
        idr = conce.conceptos(even)
        Dim numero As Integer = 0
        ' If even <> eve.Todos Then
        If idr.RecordsAffected > 0 Then
            Do While idr.Read()
                AdvTree1.Nodes.Add(New DevComponents.AdvTree.Node())
                AdvTree1.Nodes.Item(numero).Text = idr("descripcion")
                numero += 1
            Loop
        End If
        Txtconcepto.AllowDrop = True
        LBLNOMBRE.Text = nombre
        lblfoliodecontrato.Text = foliocontrato
        ' End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        evento = "Todos"
        even = eve.Todos
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal eventem As Integer, ByVal foliocon As Long, ByVal nom As String, ByVal idcom As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        even = eventem
        evento = conce.conce(even)
        foliocontrato = foliocon
        nombre = nom
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        idcomunidad = idcom
    End Sub



    Private Sub AdvTree1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles AdvTree1.DragEnter
        cadena = AdvTree1.SelectedNode.SelectedCell.Text

    End Sub

    Private Sub txtconcepto_DragDrop( _
          ByVal sender As Object, _
          ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtconcepto.DragDrop
        llenaporcadena()
    End Sub


    Private Sub txtconcepto_DragEnter( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtconcepto.DragEnter


        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Txtidconcepto_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtidconcepto.DragDrop

        llenaporcadena()
    End Sub

    Private Sub Txtidconcepto_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtidconcepto.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Public Sub llenaporcadena()
        Dim cm As New Odbc.OdbcCommand
        cm = ConsultaSql("select * from conceptoscxc where descripcion='" & cadena & "'")
        Dim ird As IDataReader
        ird = cm.ExecuteReader
        ird.Read()
        Txtidconcepto.Text = ird("id_concepto")
        Txtconcepto.Text = cadena
        lbltipomov.Text = ird("tipo")
        txtmonto.Value = ird("monto_inicial")

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim x As New movimientos
        x.concepto = Txtconcepto.Text
        x.id_comunidad = idcomunidad

        If lbltipomov.Text = "Abono" Then
            x.tipo_movimiento = movimientos.tipo.abono
        Else
            x.tipo_movimiento = movimientos.tipo.cargo
        End If
        x.folio_contrato = foliocontrato

        x.add(Val(txtmonto.Text), txtdetalle.Text, Txtidconcepto.Text, DTPicker1.Value)
        Close()
    End Sub

    
End Class