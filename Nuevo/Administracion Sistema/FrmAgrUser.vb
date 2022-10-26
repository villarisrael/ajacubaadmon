Imports DevComponents.DotNetBar

Public Class FrmAgrUser
    Private _Num As Integer
    Enum Tipo
        Nuevo
        Edicion
        Vizualizar
    End Enum
    Private _Tip As Tipo

    Public Property Modo() As Tipo
        Get
            Return _Tip
        End Get
        Set(ByVal value As Tipo)
            _Tip = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return _Num
        End Get
        Set(ByVal value As String)
            _Num = value
        End Set
    End Property


    Dim tabla As New Hashtable

    Private Sub FrmAgrUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearMenu()
        Dim Enc As New Encriptar
        Select Case _Tip
            Case Tipo.Nuevo
                TxtNombre.Text = ""
                TxtPass.Text = ""
                TxtUsername.Text = ""
            Case Tipo.Edicion
                Dim us As IDataReader = ConsultaSql("Select Nombre, User, letra,status from letras where ccodusuario = " & _Num & "").ExecuteReader
                us.Read()

                TxtNombre.Text = us("nombre")
                Enc.palabra = us("letra")
                TxtPass.Text = Enc.Desencriptada
                Enc.palabra = us("user")
                If CBool(us("status")) Then
                    ChkStatus.Checked = True
                Else
                    ChkStatus.Checked = False
                End If
                TxtUsername.Text = Enc.Desencriptada
                llenaopciones()
            Case Tipo.Vizualizar
                Dim us As IDataReader = ConsultaSql("Select Nombre, User, letra,status from letras where ccodusuario = " & _Num & "").ExecuteReader
                us.Read()

                TxtNombre.Text = us("nombre")
                Enc.palabra = us("letra")
                TxtPass.Text = Enc.Desencriptada
                Enc.palabra = us("user")

                TxtUsername.Text = Enc.Desencriptada
                If CBool(us("status")) Then
                    ChkStatus.Checked = True
                Else
                    ChkStatus.Checked = True
                End If

                TxtNombre.ReadOnly = True
                TxtPass.ReadOnly = True
                TxtUsername.ReadOnly = True
                BtnAceptar.Visible = False
                BtnCancelar.Select()
                llenaopciones()
        End Select
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        'FrmListadoUsers.Actualizar()
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        Dim crip As New Encriptar
        Dim Nombre As String, User As String, Pwd As String
        Dim va As Integer
        Select Case _Tip
            Case Tipo.Nuevo


                If ChkStatus.Checked = True Then
                    va = 1
                Else
                    va = 0
                End If
                crip.palabra = TxtPass.Text
                Pwd = crip.Encriptada
                crip.palabra = TxtUsername.Text
                User = crip.Encriptada
                Ejecucion("Insert into letras ( nombre, user, letra,status,Pwd) values ( '" & TxtNombre.Text & "', '" & User & "', '" & Pwd & "'," & va & ",'" & Pwd & "') ")

                GuardarMapa()
            Case Tipo.Edicion


                crip.palabra = TxtPass.Text
                Pwd = crip.Encriptada
                crip.palabra = TxtUsername.Text
                User = crip.Encriptada

                If ChkStatus.Checked = True Then
                    va = 1
                Else
                    va = 0
                End If
                Ejecucion("Update letras set nombre = '" & TxtNombre.Text & "', user = '" & User & "', pwd='" & Pwd & "',letra = '" & Pwd & "',status=" & va & " where CcodUsuario = " & _Num & " ")

                GuardarMapa()
        End Select
        FrmListadoUsers.CatControl1.Actualizar()
        Close()
    End Sub

    Private Sub GuardarMapa()
        Dim Cad2 As New StringBuilder, va As Integer
        Cad2.Append("delete from menu where ccodmenu=" & _Num)
        Ejecucion(Cad2.ToString)
        Dim Cad As String

        For i = 0 To Mapa.Nodes.Count - 1
            If Mapa.Nodes.Item(i).Cells(1).Checked = True Then
                va = 1
            Else
                va = 0
            End If
            Cad = "insert into menu (ccodmenu, nombre, valor) values (" & _Num & ",'" & Mapa.Nodes.Item(i).Tag & "' , " & va & ")"
            Ejecucion(Cad)
            For j = 0 To Mapa.Nodes(i).Nodes.Count - 1
                If Mapa.Nodes(i).Nodes.Item(j).Cells(1).Checked = True Then
                    va = 1
                Else
                    va = 0
                End If
                Cad = "insert into menu (ccodmenu, nombre, valor) values (" & _Num & ",'" & Mapa.Nodes(i).Nodes.Item(j).Tag & "' , " & va & ")"
                Ejecucion(Cad)

            Next
        Next


    End Sub

    Private Sub CrearMenu()
        Dim i As Integer = 0
        For i = 0 To Mapa.Nodes.Count - 1
            Mapa.Nodes.Remove(Mapa.Nodes.Item(0))
        Next i
        i = 0

        Dim f As New MDIPrincipal

        For Each elemento In f.MDIMenu.Items
            Dim tipo As String = elemento.GetType().Name
            If tipo = "RibbonTabItem" Then
                Dim tem As RibbonTabItem
                tem = TryCast(elemento, RibbonTabItem)
                If tem.Visible Then
                    Dim node As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node()
                    node.Tag = tem.Name
                    node.Text = tem.Text
                    node.Image = tem.Image


                    node.Cells.Add(New DevComponents.AdvTree.Cell(""))
                    node.Cells(1).CheckBoxVisible = True

                    For Each elementorb In tem.Panel.Controls
                        Dim tipo2 As String = elementorb.GetType().Name

                        If tipo2 = "RibbonBar" Then
                            Dim tem2 As RibbonBar
                            tem2 = TryCast(elementorb, RibbonBar)
                            For Each bt In tem2.Items
                                Dim tipo3 As String = bt.GetType().Name
                                If tipo3 = "ButtonItem" Then
                                    Dim tem3 As ButtonItem
                                    tem3 = TryCast(bt, ButtonItem)
                                    If tem3.Visible Then
                                        Dim subnodo As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node()
                                        subnodo.Tag = tem3.Name
                                        subnodo.Text = tem3.Text
                                        subnodo.Image = tem3.Image

                                        subnodo.Cells.Add(New DevComponents.AdvTree.Cell(""))
                                        subnodo.Cells(1).CheckBoxVisible = True




                                        node.Nodes.Add(subnodo)
                                    End If

                                End If
                            Next
                        End If
                    Next

                    Mapa.Nodes.Add(node)
                    ' MessageBoxEx.Show(tem.Text)
                End If
            End If

        Next


    End Sub

    Private Sub Mapa_NodeClick(ByVal sender As Object, ByVal e As DevComponents.AdvTree.TreeNodeMouseEventArgs) Handles Mapa.NodeClick
        'Dim res As Boolean = False
        'If e.Node.Checked = True Then
        '    For j = 0 To e.Node.Nodes.Count - 1
        '        e.Node.Nodes.Item(j).Checked = True
        '    Next
        'Else
        '    For j = 0 To e.Node.Nodes.Count - 1
        '        e.Node.Nodes.Item(j).Checked = False
        '    Next
        'End If
    End Sub

    Private Sub BtnHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHabilitar.Click
        For i = 0 To Mapa.Nodes.Count - 1
            Mapa.Nodes.Item(i).Cells(1).Checked = True
            For j = 0 To Mapa.Nodes(i).Nodes.Count - 1
                Mapa.Nodes(i).Nodes.Item(j).Cells(1).Checked = True
                'For h = 0 To Mapa.Nodes(i).Nodes.Item(j).Nodes.Count - 1
                '    Mapa.Nodes(i).Nodes.Item(j).Nodes.Item(h).Checked = True
                'Next
            Next
        Next
    End Sub

    Private Sub BtnDeshabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeshabilitar.Click
        For i = 0 To Mapa.Nodes.Count - 1
            Mapa.Nodes.Item(i).Cells(1).Checked = False
            For j = 0 To Mapa.Nodes(i).Nodes.Count - 1
                Mapa.Nodes(i).Nodes.Item(j).Cells(1).Checked = False
                'For h = 0 To Mapa.Nodes(i).Nodes.Item(j).Nodes.Count - 1
                '    Mapa.Nodes(i).Nodes.Item(j).Nodes.Item(h).Checked = True
                'Next
            Next
        Next
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

    Private Sub BtnHabilitar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHabilitar.GotFocus
        BtnHabilitar.Pulse()
        BtnHabilitar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnHabilitar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHabilitar.LostFocus
        BtnHabilitar.StopPulse()
    End Sub

    Private Sub BtnDeshabilitar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDeshabilitar.GotFocus
        BtnDeshabilitar.Pulse()
        BtnDeshabilitar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnDeshabilitar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnDeshabilitar.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
        End Select
    End Sub

    Private Sub BtnDeshabilitar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDeshabilitar.LostFocus
        BtnDeshabilitar.StopPulse()
    End Sub


    Public Sub llenaopciones()
        tabla.Clear()

        Dim us As IDataReader = ConsultaSql("Select *  from menu where ccodmenu = " & _Num & "").ExecuteReader
        Do While us.Read
            tabla.Add(us("nombre"), CBool(us("valor")))
        Loop
        us.Close()

        For i = 0 To Mapa.Nodes.Count - 1
            Mapa.Nodes.Item(i).Cells(1).Checked = tabla(Mapa.Nodes.Item(i).Tag)
            For j = 0 To Mapa.Nodes(i).Nodes.Count - 1
                Mapa.Nodes(i).Nodes.Item(j).Cells(1).Checked = tabla(Mapa.Nodes(i).Nodes.Item(j).Tag)
                'For h = 0 To Mapa.Nodes(i).Nodes.Item(j).Nodes.Count - 1
                '    Mapa.Nodes(i).Nodes.Item(j).Nodes.Item(h).Checked = True
                'Next
            Next
        Next

    End Sub

End Class