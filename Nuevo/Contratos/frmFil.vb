Public Class frmFil
    Protected _campo As String
    Protected _Cadena As String
    Protected _opOrd As String
    Protected _ncampo As Int16
    Public Sub New(ByVal campo As String, ByVal ncampo As Int16)
        InitializeComponent()
        _campo = campo
        txtCampo.Text = _campo
        _ncampo = ncampo
        If campo <> "cuenta" AndAlso campo <> "numext" AndAlso campo <> "numint" AndAlso campo <> "cp" AndAlso campo <> "nodemedidor" AndAlso campo <> "manzana" AndAlso campo <> "telefono" AndAlso campo <> "lote" AndAlso campo <> "NumLec" AndAlso campo <> "LecturaAct" Then
            llenarCombo(cmbReg, "dis", "select distinct(" & _campo & ") as dis from vusuario order by " & _campo & "")
        End If
    End Sub
#Region "Modificadores"
    Public Property Cadena() As String
        Get
            Return _Cadena
        End Get
        Set(ByVal value As String)
            _Cadena = value
        End Set
    End Property

    Public Property opOrd() As String
        Get
            Return _opOrd
        End Get
        Set(ByVal value As String)
            _opOrd = value
        End Set
    End Property

#End Region

    Private Sub cmdOpL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpL.Click
        Static cont As Int16
regrezar:

        Select Case cont
            Case 0
                cmdOpL.Text = "!="
            Case 1
                cmdOpL.Text = ">"
            Case 2
                cmdOpL.Text = "<"
            Case 3
                cmdOpL.Text = "="
            Case Else
                cont = 0
                GoTo regrezar
        End Select

        cont += 1
    End Sub

    Private Sub lblAnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnd.Click
        If lblAnd.Text = "And" Then
            lblAnd.Text = "Or"
        Else
            lblAnd.Text = "And"
        End If
    End Sub

    Private Sub frmFil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmFil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        Dim vr As String = ""
        If IsNumeric(cmbReg.Text) Then
            vr = cmbReg.Text
        Else
            vr = String.Concat("'", cmbReg.Text, "'")

        End If

        If _ncampo = 0 Then
            _Cadena = String.Concat(txtCampo.Text, cmdOpL.Text, vr)
        Else
            _Cadena = String.Concat(" ", lblAnd.Text, " ", txtCampo.Text, cmdOpL.Text, vr)
        End If
        Me.Close()
    End Sub

    Private Sub cmdOpL_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOpL.GotFocus
        cmdOpL.Pulse()
        cmdOpL.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdOpL_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOpL.LostFocus
        cmdOpL.StopPulse()
    End Sub

    Private Sub cmdAcept_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAcept.GotFocus
        cmdAcept.Pulse()
        cmdAcept.StopPulseOnMouseOver = False
    End Sub


    Private Sub cmbReg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbReg.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class