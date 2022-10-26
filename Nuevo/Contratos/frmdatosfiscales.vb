Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Public Class frmdatosfiscales

    Public cuenta As Integer
    Public quehacer As String = "INSERTAR"
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        Dim CADENA As String = "", cadena2 As String = String.Empty

        Try


            If validarEmail(txtmail.Text) = False Then
                MessageBox.Show("El e-mail no es correcto, favor de validarlo o ingresarlo nuevamente.")
                Exit Sub
            End If



            Select Case quehacer
                Case "INSERTAR"
                    CADENA = "INSERT INTO datosfiscales SET TIPO='USUARIO', CUENTA=" & cuenta & ","
                Case "ACTUALIZAR"
                    CADENA = "UPDATE datosfiscales SET "

            End Select
            CADENA = CADENA & " NOMBRE ='" & txtnombre.Text & "', CALLE='" & txtcalle.Text & "',NUMEXT='" & txtnumext.Text & "', NUMINT ='" & txtnuminterior.Text & "', COLONIA='" & txtcolonia.Text & "', POBLACION='" & txtpoblacion.Text & "' , DELEGACION='" & txtdelegacion.Text & "', ESTADO='" & txtestado.Text & "', PAIS='" & txtPais.Text & "', CP='" & txtcp.Text & "',RFC='" & txtrfc.Text & "', MAILdeenvio='" & txtmail.Text & "' , rfcbanco='" & cmbbanco.SelectedValue & "', cuentabancaria='" & txtcuentabancaria.Text & "', RegimenFiscal = " & CmbRegimenFiscal.SelectedValue

            If quehacer = "ACTUALIZAR" Then
                CADENA = CADENA & " WHERE CUENTA=" & cuenta & " AND TIPO ='USUARIO'"
            End If
            If cmbbanco.SelectedIndex >= 0 Then
                cadena2 = "update datosfiscales set rfcbanco='" & cmbbanco.SelectedValue & "', cuentabancaria='" & txtcuentabancaria.Text & "' WHERE CUENTA=" & cuenta & " AND TIPO ='USUARIO'"
            End If
            Ejecucion(CADENA)
            If cadena2 <> String.Empty Then
                Try
                    Ejecucion(cadena2)
                Catch ex As Exception

                End Try
            End If

            MessageBox.Show("Datos Fiscales guardados exitosamente")

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al guardar los datos: " & ex.ToString())
        End Try
    End Sub

    Private Sub frmdatosfiscales_Load(sender As Object, e As EventArgs) Handles Me.Load

        llenarCombo(cmbbanco, "SELECT RFC,Nombre from c_banco order by Nombre ")

        'llenarCombo(CmbRegimenFiscal, "SELECT ClaveRegimenFiscal,Descripcion from RegimenFiscal order by idRegimenFiscal ")

        llenarCombo(CmbRegimenFiscal, "SELECT ClaveRegimenFiscal, CONCAT(ClaveRegimenFiscal,' | ', Descripcion) FROM RegimenFiscal")
        CmbRegimenFiscal.SelectedValue = "601"

        Dim datosf As OdbcDataReader = ConsultaSql("SELECT * FROM datosfiscales WHERE CUENTA=" & cuenta & " AND TIPO='USUARIO'").ExecuteReader

        If datosf.Read Then
            quehacer = "ACTUALIZAR"
            Try
                txtnombre.Text = datosf("NOMBRE")
                txtcalle.Text = datosf("CALLE")
                txtnumext.Text = datosf("NUMEXT")
                txtnuminterior.Text = datosf("NUMINT")
                txtcolonia.Text = datosf("COLONIA")
                txtdelegacion.Text = datosf("DELEGACION")
                txtpoblacion.Text = datosf("POBLACION")
                txtestado.Text = datosf("ESTADO")
                txtPais.Text = datosf("PAIS")
                txtcp.Text = datosf("CP")
                txtrfc.Text = datosf("RFC")
                txtmail.Text = datosf("MAILDEENVIO")
                CmbRegimenFiscal.SelectedValue = datosf("RegimenFiscal")
                txtcuentabancaria.Text = datosf("CUENTABANCARIA")
                Try
                    cmbbanco.SelectedValue = datosf("RFCBANCO")
                Catch ex As Exception

                End Try

                'txtObservaciones.Text = "Cuenta: " & datosU("cuenta") & " Tarifa: " & datosU("descripcion_cuota") & " Medidor: " & datosU("nodemedidor")
            Catch ex As Exception


            End Try



        Else

            Dim datosU As OdbcDataReader = ConsultaSql("SELECT * FROM vusuario WHERE CUENTA=" & cuenta).ExecuteReader
            datosU.Read()
            txtnombre.Text = datosU("NOMBRE")
            txtcalle.Text = datosU("DIRECCION")
            txtnumext.Text = ""
            txtnuminterior.Text = ""
            txtcolonia.Text = datosU("COLONIA")
            txtdelegacion.Text = "" 'datosf("DELEGACION")
            txtpoblacion.Text = datosU("COMUNIDAD")
            txtestado.Text = "HIDALGO" '
            txtPais.Text = "MEXICO" 'datosf("PAIS")
            txtcp.Text = "" ' datosf("CP")
            If IsDBNull(datosU("cp")) Then

                txtcp.Text = "42400"
            ElseIf datosU("cp") = "" Or datosU("cp") = "0" Then
                txtcp.Text = "42400"
            End If
            If IsDBNull(datosU("RFC")) Then
                txtrfc.Text = "XAXX010101000"
            ElseIf datosU("rfc") = "" Then
                txtrfc.Text = "XAXX010101000"
            Else
                txtrfc.Text = "" & datosU("RFC")
            End If
            cmbbanco.SelectedIndex = -1


        End If
    End Sub

    Public Function validarEmail(ByVal correo) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(correo) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Close()
    End Sub
End Class