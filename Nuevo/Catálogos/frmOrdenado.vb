Imports DevComponents.DotNetBar

Public Class frmOrdenado
#Region "Variables"
    Private _tabla As String = ""
    Private _campo As String = ""
    Private idord As IDataReader = Nothing
#End Region

#Region "Constructores"
    Public Sub New(ByVal tabla As String)
        InitializeComponent()
        _tabla = tabla

        Ejecucion("delete from tmpord")
        idord = ConsultaSql("show columns from " & _tabla & "").ExecuteReader()
        While idord.Read()
            Ejecucion("insert into tmpord(campo) values('" & idord("Field") & "')")
        End While
        llenarCombo(cmbCampo, "select clave, campo from tmpord")

    End Sub
#End Region

#Region "Modificadores"
    Public Property campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property
#End Region


    Private Sub cmdSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSal.Click
        Me.Close()
    End Sub

    Private Sub cmdAcept_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAcept.GotFocus
        cmdAcept.Pulse()
        cmdAcept.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdAcept_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAcept.LostFocus
        cmdAcept.StopPulse()
    End Sub

    Private Sub cmdSal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSal.GotFocus
        cmdSal.Pulse()
        cmdSal.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdSal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSal.LostFocus
        cmdSal.StopPulse()
    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        If cmbCampo.Text <> "" Then
            _campo = cmbCampo.Text
        Else
            MessageBoxEx.Show("Especifique el campo con el cual desea ordenar, por favor", "Ordenado por", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbCampo.Select()
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub frmOrdenado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmOrdenado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class