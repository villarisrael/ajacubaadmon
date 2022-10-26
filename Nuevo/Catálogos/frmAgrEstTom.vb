Public Class frmAgrEstTom
    Dim mtipo As Tipo
    Dim idcom As String = ""


    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idcom() As String
        Get
            Return idcom
        End Get
        Set(ByVal value As String)
            idcom = value
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


        If txtId_est.Text = "" Then
            MessageBox.Show("Introduzca la clave del estado de la toma", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtDescrip.Text = "" Then
            MessageBox.Show("Introduzca el nombre la descripción del estado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Ejecucion("insert into estadotoma values(" & txtId_est.Text & ",""" & txtDescrip.Text & """,""" & Me.cpEst.SelectedColor.ToArgb & """," & CBool(chkMostrar.Checked) & ")")
            Else
                Ejecucion("update estadotoma set clave=""" & txtId_est.Text & """, descripcion=""" & txtDescrip.Text & """, cfondo=""" & Me.cpEst.SelectedColor.ToArgb & """, mostrar=" & chkMostrar.Checked & " where clave=" & idcom & "")
            End If
            MessageBox.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBox.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub
    Private Sub txtId_est_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId_est.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmAgrEstTom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrEstTom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If mtipo = Tipo.Editar Then
            Dim rea As IDataReader
            rea = ConsultaSql("select * from estadotoma where clave='" & idcom & "'").ExecuteReader
            rea.Read()
            txtDescrip.Text = rea("descripcion")
            txtId_est.Text = rea("clave")
            chkMostrar.Checked = rea("mostrar")
            Me.cpEst.SelectedColor = System.Drawing.Color.FromArgb(CInt(rea("cfondo")))
        End If
        If mtipo = Tipo.Ver Then
            txtDescrip.Enabled = False
            txtId_est.Enabled = False
            cmdAcept.Enabled = False
            Dim rea1 As IDataReader
            rea1 = ConsultaSql("select * from estadotoma where clave='" & idcom & "'").ExecuteReader
            rea1.Read()
            Me.cpEst.SelectedColor = System.Drawing.Color.FromArgb(CInt(rea1("cfondo")))
            cpEst.Enabled = False
        End If


    End Sub
End Class