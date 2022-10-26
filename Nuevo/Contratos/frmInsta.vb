Imports DevComponents.DotNetBar

Public Class frmInsta

    Protected _cuenta As Double
    Protected _claComu As String
    Dim idusu As IDataReader


#Region "Constructores"
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ByVal cuenta As Double, ByVal claComu As String)
        InitializeComponent()

        _cuenta = cuenta

        _claComu = claComu
        idusu = ConsultaSql("select * from usuario where cuenta=" & cuenta & " and id_comunidad=""" & claComu & """").ExecuteReader()

        If idusu.Read() Then
            txtCuenta.Text = _cuenta
            txtNombre.Text = idusu("nombre")
            'txtDir.Text = "COMUNIDAD: " &  & " COLONIA:" & idusu("Colonia") & " CALLE: " & idusu("calle") & " NÚMERO INTERIOR: " & idusu("numint") & " NÚMERO EXTERIOR: " & idusu("numext")
            If Not IsDBNull(idusu("fechainst")) Then
                dtInsta.Value = idusu("fechainst")
                'cmdAceptar.Enabled = False
                cmdCancel.Select()
            Else
                cmdAceptar.Enabled = True
            End If
            If Not IsDBNull(idusu("marcamedidor")) Then
                cmbMarMed.Text = idusu("marcamedidor")
            End If
            If Not IsDBNull(idusu("nodemedidor")) Then
                txtnumerodemedidor.Text = idusu("nodemedidor")
            End If
            cmbDiamMed.Text = obtenerCampo("select descripcion from diametros where id_diametro=""" & idusu("diammedidor") & """", "descripcion")
            cmbMarMed.Text = obtenerCampo("select descripcion from marcasmedidor where id_marca=""" & idusu("marcamedidor") & """", "descripcion")
        End If
        If cmbDiamMed.SelectedItem = "" Or cmbDiamMed.SelectedItem = 0 Or cmbDiamMed.SelectedItem = Nothing Then
            cmbDiamMed.Text = "MEDIA PULGADA"
        End If
    End Sub
#End Region

    Private Sub frmInsta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub frmInsta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmInsta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbMarMed, "descripcion", "Select descripcion from marcasmedidor")
        llenarCombo(cmbDiamMed, "descripcion", "select * from diametros")
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtnumerodemedidor.Text = "" Then
            MessageBoxEx.Show("ESTABLEZCA EL NÚMERO DE MEDIDOR DE FAVOR " & vbCrLf & " EN CASO DE SER CUOTA FIJA ESCRIBE 0", "INSTALACIÓN DE LA TOMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnumerodemedidor.Select()

            Exit Sub
        End If
        Dim idrepm As IDataReader = ConsultaSql("select * from usuario,marcasmedidor where marcasmedidor.id_marca=usuario.marcamedidor and marcasmedidor.descripcion=""" & cmbMarMed.Text & """ and usuario.nodemedidor=""" & txtnumerodemedidor.Text & """ and NOT (usuario.cuenta =" & txtCuenta.Text & " and usuario.id_comunidad=""" & _claComu & """)").ExecuteReader()
        Dim diammed As String = ""
        Dim num As Double = 0

        If cmbDiamMed.SelectedItem <> "" Then
            diammed = "'" & obtenerCampo("select id_diametro from diametros where descripcion=""" & cmbDiamMed.SelectedItem & """ ", "id_diametro") & "'"
        Else
            diammed = "''"
        End If


        If idrepm.Read() AndAlso txtnumerodemedidor.Text <> "0" Then
            MessageBoxEx.Show("El número de medidor ya existe para la cuenta=" & idrepm("cuenta") & " de la comunidad= " & idrepm("comunidad") & "", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim mmed As String = obtenerCampo("select id_marca from marcasmedidor where descripcion=""" & cmbMarMed.Text & """", "id_marca")

        Ejecucion("update usuario set marcamedidor=""" & mmed & """, nodemedidor=""" & txtnumerodemedidor.Text & """, diammedidor=" & diammed & ",fechainst='" & UnixDateFormat(dtInsta.Value) & "', estado=5  where cuenta=" & _cuenta)
        Try
            num = obtenerCampo("select max(clave) + 1  as num from cambioestado", "num")
        Catch ex As Exception
            num = 1
        End Try

        Ejecucion("insert into cambioestado values(" & num & "," & _cuenta & ",'" & _claComu & "',5,'INSTALACIÓN DE LA TOMA','" & UnixDateFormat(Now) & "'," & NumUser & ")")


        MessageBoxEx.Show("Datos guardados satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
        Me.Close()
    End Sub


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.GotFocus
        cmdAceptar.Pulse()
        cmdAceptar.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.LostFocus
        cmdAceptar.StopPulse()
    End Sub

    Private Sub cmdCancel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.GotFocus
        cmdCancel.Pulse()
        cmdCancel.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdCancel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.LostFocus
        cmdCancel.StopPulse()
    End Sub
    Private Sub cmbMarMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMarMed.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbDiamMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDiamMed.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtnumerodemedidor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumerodemedidor.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

End Class