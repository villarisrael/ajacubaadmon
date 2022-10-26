Imports DevComponents.DotNetBar

Public Class FrmAcceso

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim enc As New Encriptar, Usu As String, Pwd As String
        enc.palabra = TxtUsuario.Text
        Usu = enc.Encriptada
        enc.palabra = TxtPwd.Text
        Pwd = enc.Encriptada

        'enc.Palabra = "49535241454C"
        'Usu = enc.Desencriptada
        'enc.Palabra = "4D4153544552"
        'Pwd = enc.Desencriptada



        Dim ir As IDataReader
        Dim comando As Odbc.OdbcCommand

        comando = ConsultaSql("Select * from letras where user = '" & Usu & "' and pwd = '" & Pwd & "'")
        ir = comando.ExecuteReader
        If ir.Read() Then

            If ir("status") = False Then
                MessageBox.Show("Ingreso denegado")
                Exit Sub
            End If
            NumUser = ir("ccodusuario")
            enc.palabra = ir("User")
            Nameuser = enc.Desencriptada
            ' ir.Dispose()
            MDIPrincipal.Show()
            'Try
            '    Dim enlace As String = obtenerCampo("select rutatmp from empresa limit 1", "rutatmp")
            '    If FileDateTime(AppPath() + "\Administrativo.exe") <> FileDateTime(enlace + "Actualizacion\Administrativo.exe") Then
            '        MsgBox("Existe una nueva version")
            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            Close()

        Else
            MessageBoxEx.Show("Nombre de usuario o contraseña incorrectas, verifique sus datos", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPwd.Select()
        End If
    End Sub

    Private Sub FrmAcceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectar()

        'Dim datorequerido As IDataReader
        'datorequerido = ConsultaSql("select * from empresa").ExecuteReader
        'datorequerido.Read()


        TxtUsuario.Select()
        Dim rs As System.Data.IDataReader
        rs = ConsultaSql("Select * from empresa").ExecuteReader
        If rs.Read Then
            salariominimo = rs("salario")
            Me.Lbnombre.Text = rs("cnombre")
            Me.Lbrfc.Text = rs("cnif")
            Me.Lbsiglas.Text = rs("siglas")
        End If
        ' rs.Dispose()
        '    'Dim lec As New ClsLecturas
        '    'lec.PasaTemp()
        'Else
        '    ' Ejecucion("UPDATE empresa SET folio_repo=1")
        '    MessageBoxEx.Show("conflicto de actualización C:\Windows\ODBC.INI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Close()
        'End If

    End Sub

    Private Sub TxtUsuario_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyUp
        If e.KeyCode = Keys.Enter Then
            TxtPwd.Select()
            TxtPwd.SelectAll()
        End If
    End Sub

    Private Sub TxtPwd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPwd.KeyUp
        If e.KeyCode = Keys.Enter Then
            BtnAceptar.Select()
        End If
    End Sub

    Private Sub GroupPanel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel2.Click

    End Sub

    Private Sub LabelX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX5.Click

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Dim macdelacompu As String
        'macdelacompu = GetMAC().ToString
        'LabelX5.Text = macdelacompu
    End Sub

    Private Sub LabelX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX1.Click

    End Sub
End Class