Imports DevComponents.DotNetBar

Public Class frmAgrAlg
    Dim mtipo As Tipo
    Dim idAlg As String = ""
    Dim dAlg As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idAlg() As String
        Get
            Return idAlg
        End Get
        Set(ByVal value As String)
            idAlg = value
            dAlg = ConsultaSql("select * from algoritmos where clave=" & idAlg & "").ExecuteReader()
            dAlg.Read()
        End Set
    End Property

    Public Sub New(ByVal _mtipo As Tipo)
        InitializeComponent()
        mtipo = _mtipo
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        If cmbAcc.SelectedItem.ToString = "" Then
            MessageBoxEx.Show("Introduzca la acción", "Algoritmos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbAcc.Select()
            Exit Sub
        End If

        If txtDescrip.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción del Algoritmo", "Algoritmos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescrip.Select()
            Exit Sub
        End If

        If txtNoMes.Text = "" Then
            MessageBoxEx.Show("Intruduzca el número de meses", "Algoritmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNoMes.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Ejecucion("insert into algoritmos(descrip,accion,nodemeses) values(""" & txtDescrip.Text & """,""" & cmbAcc.Text & """," & Val(txtNoMes.Text) & ")")
            Else
                Ejecucion("update algoritmos set descrip=""" & txtDescrip.Text & """, accion='" & cmbAcc.Text & "', nodemeses=" & Val(txtNoMes.Text) & " where clave=" & idAlg & "")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Algoritmos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "Algoritmos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub frmAgrAlg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrSit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo <> Tipo.Agregar Then
            llenar()
            If mtipo = Tipo.Ver Then
                txtDescrip.ReadOnly = True
                txtNoMes.ReadOnly = True
                cmbAcc.Enabled = False
                cmdAcept.Visible = False
            End If
        End If

    End Sub
    Private Sub llenar()
        txtDescrip.Text = dAlg("descrip")
        cmbAcc.Text = dAlg("accion")
        txtNoMes.Text = dAlg("nodemeses")
    End Sub
    Private Sub txtNoMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoMes.KeyPress
        SoloNumeros(e)
    End Sub

End Class