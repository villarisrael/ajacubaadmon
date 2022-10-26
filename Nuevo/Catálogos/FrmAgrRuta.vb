Imports DevComponents.DotNetBar

Public Class FrmAgrRuta
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum
    Public Sub New(ByVal tip As Tipo)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Mtipo = tip
    End Sub
    Public Mtipo As Tipo, Clave As String
    Public Sector As String, id_comunidad As String, id_comunidadf As String



    Private Sub FrmAgrRuta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmAgrRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llenarCombo(CmbSector, "select id_region as clave, region from region order by region")

        If Mtipo = Tipo.Agregar Then
            'TxtClave.Text = llenarcero(Val(obtenerCampo("Select max(id_ruta) as mayor from rutas", "mayor")) + 1, 3)
            'Clave = TxtClave.Text
            TxtClave.Text = ""
            TxtNombre.Text = ""

        Else
            CmbSector.Text = obtenerCampo("Select region from region where id_region = '" & Sector & "'", "region")
            TxtNombre.Text = obtenerCampo("Select ruta from rutas where id_ruta = '" & Clave & "' and id_region = '" & Sector & "' ", "ruta")

            TxtClave.Text = Clave
            'CmbSector.Enabled = False
            TxtClave.Enabled = False
            'TxtNombre.Focus()
        End If

        If Mtipo = Tipo.Ver Then

            CmbSector.Enabled = False
            TxtClave.Enabled = False
            TxtNombre.Enabled = False
            BtnAceptar.Visible = False
            BtnCancelar.Select()
        End If

        If Mtipo = Tipo.Editar Then
            TxtNombre.Select()

        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Sector = Mid(CmbSector.SelectedValue.ToString, 1, 3)


        If CmbSector.Text = "" Then
            MessageBoxEx.Show("ESPECIFIQUE LA REGIÓN", "RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CmbSector.Select()
            Exit Sub
        End If
        If TxtClave.Text = "" Then
            MessageBoxEx.Show("ESPECIFIQUE LA CLAVE DE LA RUTA POR FAVOR", "RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Select()
            Exit Sub
        End If
        If TxtNombre.Text = "" Then
            MessageBoxEx.Show("ESPECIFIQUE EL NOMBRE DE LA RUTA, POR FAVOR", "RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNombre.Focus()
            Exit Sub
        End If
        If Mtipo = Tipo.Agregar Then
            If obtenerCampo("select count(*) as tot from rutas where id_ruta = '" & TxtClave.Text & "' and id_region = '" & Sector & "' and id_comunidad='" & id_comunidad & "'", "tot") > 0 Then
                MessageBoxEx.Show("LA CLAVE DE LA RUTA YA EXISTE, VERIFIQUE SUS DATOS POR FAVOR", "RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Ejecucion("insert into rutas(id_ruta,ruta,id_region) values('" & TxtClave.Text & "','" & TxtNombre.Text & "', '" & Sector & "')")


        Else
            Ejecucion("update rutas set ruta = '" & TxtNombre.Text & "', id_region='" & Sector & "' where id_ruta = '" & TxtClave.Text & "'")
        End If
        MessageBoxEx.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CmbSector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSector.KeyPress
        DespliegaCombo(CmbSector, e)
        'e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbSector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSector.SelectedIndexChanged
        If Mtipo = Tipo.Agregar Then
            If Not IsNothing(CmbSector.SelectedValue) Then
                If CmbSector.SelectedValue.ToString <> "System.Data.DataRowView" Then
                    Sector = Mid(CmbSector.SelectedValue.ToString, 1, 3)
                    id_comunidad = Mid(CmbSector.SelectedValue.ToString, 4)


                    'TxtClave.Text = llenarcero(Val(obtenerCampo("Select max(id_ruta) as mayor from rutas where id_region='" & Sector & "'", "mayor")) + 1, 3)
                End If
            End If
        Else
            If Not IsNothing(CmbSector.SelectedValue) Then
                If CmbSector.SelectedValue.ToString <> "System.Data.DataRowView" Then


                End If
            End If
        End If
    End Sub

    Private Sub BtnAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.GotFocus
        BtnAceptar.Pulse()
        BtnAceptar.StopPulseOnMouseOver = False

    End Sub

    Private Sub BtnAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.LostFocus
        BtnAceptar.StopPulse()
    End Sub

    Private Sub BtnCancelar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.GotFocus
        BtnCancelar.Pulse()
        BtnCancelar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnCancelar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.LostFocus
        BtnCancelar.StopPulse()
    End Sub
End Class