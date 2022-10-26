Public Class frmBusCat2

#Region "Variables"
    Private campo As String = ""
    Private _cadSql As String = ""
    Private Tipo As Object = Nothing
    Private _campos As String = ""
    Private _Tabla As String = ""
#End Region

#Region "Modificadores"
    Public Property cadSql() As String
        Get
            Return _cadSql
        End Get
        Set(ByVal value As String)
            _cadSql = value
        End Set
    End Property
#End Region


    Public Sub New(ByVal _campo As String, ByVal Tabla As String, ByVal campos As String, ByVal _Tipo As Object)


        InitializeComponent()

        campo = _campo
        Tipo = _Tipo
        _campos = campos
        _Tabla = Tabla

        lblMsg.Text = "Escriba el dato a buscar para el campo: " & _campo & ""

        'Dim Cod As 
        If _Tipo.GetType.Name = "Date" OrElse _Tipo.GetType.Name = "Datetime" Then
            txtBus.Visible = False
            Fecha.Visible = True
        Else
            txtBus.Visible = True
            Fecha.Visible = False
        End If
    End Sub

    Private Sub cmdBus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBus.GotFocus
        cmdBus.Pulse()
        cmdBus.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdBus_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBus.LostFocus
        cmdBus.StopPulse()
    End Sub

    Private Sub cmdBus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBus.Click
        If txtBus.Visible Then
            If txtBus.Text = "" Then
                cadSql = ""
                Exit Sub
            End If


            If Not IsNumeric(Tipo) Then
                _cadSql = "select " & _campos & " from " & _Tabla & " where " & campo & " like '%" & txtBus.Text & "%'"
            Else
                _cadSql = "select " & _campos & " from " & _Tabla & " where " & campo & " = " & txtBus.Text & ""
            End If
        Else
            _cadSql = "select " & _campos & " from " & _Tabla & " where " & campo & " = '" & UnixDateFormat(Fecha.Value) & "'"
        End If
        Me.Close()
    End Sub

    Private Sub frmBusCat2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")


        End Select
    End Sub

    Private Sub txtBus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBus.KeyPress
        If IsNumeric(Tipo) Then
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SoloNumeros(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        End If
    End Sub

 
End Class