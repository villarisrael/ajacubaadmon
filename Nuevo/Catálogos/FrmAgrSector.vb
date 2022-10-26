Imports DevComponents.DotNetBar

Public Class FrmAgrSector
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum
    Public Mtipo As Tipo, Clave As String

    Private Sub FrmAgrSector_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmAgrSector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Mtipo = Tipo.Agregar Then
            'TxtClave.Text = llenarcero(Val(obtenerCampo("Select max(clavesec) as mayor from sectores", "mayor")) + 1, 3)
            TxtNombre.Text = ""
        Else
            TxtClave.Text = Clave
            TxtNombre.Text = obtenerCampo("Select descripcion from sectores where clavesec = '" & Clave & "'", "descripcion")
        End If
        If Mtipo = Tipo.Ver Then
            TxtClave.Enabled = False
            TxtNombre.Enabled = False
            BtnAceptar.Visible = False
            'TxtClave.TabStop = False
            'TxtNombre.TabStop = False
        End If

        If Mtipo = Tipo.Editar Then
            TxtClave.Enabled = False
            'TxtClave.TabStop = False

        End If


    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If TxtClave.Text = "" Then
            MessageBoxEx.Show("ESCRIBA LA CLAVE DEL SECTOR, POR FAVOR", "SECOTRES", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtClave.Select()
            Exit Sub
        End If
        If TxtNombre.Text = "" Then
            MessageBoxEx.Show("ESCRIBA EL NOMBRE DEL SECTOR, POR FAVOR", "SECTORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNombre.Select()
        Else
            If Mtipo = Tipo.Agregar Then
                If obtenerCampo("select count(*) as tot from sectores where clavesec='" & TxtClave.Text & "'", "tot") > 0 Then
                    MessageBoxEx.Show("LA CLAVE DEL SECTOR YA EXISTE, VERIFIQUE SUS DATOS POR FAVOR", "SECTORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Ejecucion("insert into sectores (clavesec, descripcion) values ('" & TxtClave.Text & "', '" & TxtNombre.Text & "')")

            Else
                Ejecucion("update sectores set descripcion = '" & TxtNombre.Text & "' where clavesec = '" & TxtClave.Text & "'")
            End If
            MessageBoxEx.Show("DATOS GUARDADOS EXITOSAMENTE", "SECTORES", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        End If
    End Sub

    Public Sub New(ByVal Tip As Tipo)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Mtipo = Tip
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