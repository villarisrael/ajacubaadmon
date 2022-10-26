Imports DevComponents.DotNetBar

Public Class frmAgrDir
    Dim mtipo As Tipo
    Dim idres As String = ""
    Dim idr As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idres() As String
        Get
            Return idres
        End Get
        Set(ByVal value As String)
            idres = value
            idr = ConsultaSql("select * from direc where cod_dir='" & idres & "'").ExecuteReader()
            If idr.Read() Then
                txtCod_Direc.Text = idr("cod_dir")
                txtNombre.Text = idr("nombre")
                If Not IsDBNull(idr("respons")) Then txtResponsable.Text = idr("respons")
            End If
        End Set
    End Property

    Public Sub New(ByVal _mtipo As Tipo)
        InitializeComponent()
        mtipo = _mtipo

        Select Case mtipo
            Case Tipo.Editar
                txtNombre.Select()
            Case Tipo.Ver
                cmadCancelar.Select()
        End Select
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtCod_Direc.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de Dirección", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCod_Direc.Select()
            Exit Sub
        End If

        If txtNombre.Text = "" Then
            MessageBoxEx.Show("Introduzca el Nombre", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Select()
            Exit Sub
        End If

        If txtResponsable.Text = "" Then
            MessageBoxEx.Show("Introduzca Responsable", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtResponsable.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim rs As IDataReader = ConsultaSql("Select * from direc where cod_dir = '" & txtCod_Direc.Text & "'").ExecuteReader
                If rs.Read Then
                    MessageBoxEx.Show("La clave de direccion ya existe, verifica tus datos", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtCod_Direc.Select()
                    Exit Sub
                Else
                    Ejecucion("insert into direc value(""" & txtCod_Direc.Text & """,""" & txtNombre.Text & """,""" & txtResponsable.Text & """)")
                End If
            Else
                Ejecucion("update direc set nombre=""" & txtNombre.Text & """, respons=""" & txtResponsable.Text & """ where cod_dir='" & idres & "'")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmadCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmadCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgrDir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrDir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Ver Then
            txtNombre.ReadOnly = True
            txtResponsable.ReadOnly = True
            txtCod_Direc.ReadOnly = True
            cmdAceptar.Visible = False
        ElseIf mtipo = Tipo.Editar Then
            txtCod_Direc.ReadOnly = True
        End If

    End Sub

    Private Sub cmdAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.GotFocus
        cmdAceptar.Pulse()
        cmdAceptar.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.LostFocus
        cmdAceptar.StopPulse()
    End Sub

    Private Sub cmadCancelar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmadCancelar.GotFocus
        cmadCancelar.Pulse()
        cmadCancelar.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmadCancelar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmadCancelar.LostFocus
        cmadCancelar.StopPulse()

    End Sub
End Class