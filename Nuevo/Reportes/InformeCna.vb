Public Class InformeCna
    Private Sub InformeCna_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        
        If mesfinal.Text = "" Then
            MsgBox("NO HAS SELECCIONADO EL MES REFERENTE")
            Exit Sub
        End If

        Try
            Ejecucion("DROP TABLE TEMCNA1;")
        Catch ex As Exception

        End Try
        Try
            Ejecucion("CREATE TABLE TEMCNA1 AS SELECT tipouso.Descripcion AS USO, SUM(IF(MEDIDO=0,1,0)) AS SINMEDIDOR,  SUM(IF(MEDIDO=0,1,0)*MCUBEQUIV) AS CONSUMOM3FIJA, SUM(IF(MEDIDO=1,1,0)) AS CONMEDIDOR,     COUNT(USUARIO.CUENTA) AS TOTAL,SUM(IF(ID_FORMA_SERVICIO=1,1,0)) AS CONTINUO, SUM(IF(USUARIO.ALCANTARILLADO=0,0,1)) AS CONECT_DREANJE FROM (cuotas,tipos_usuarios tipouso,USUARIO,ESTADOTOMA) where cuotas.parauso=tipouso.id_tipo_usuario  AND CUOTAS.ID_TARIFA=USUARIO.TARIFA  AND USUARIO.ESTADO=ESTADOTOMA.CLAVE AND ESTADOTOMA.MOSTRAR=1 group by  parauso;")
        Catch ex As Exception

        End Try
        Try
            Ejecucion("DROP TABLE TEMCNA2;")
        Catch ex As Exception

        End Try
        Try
            Ejecucion("CREATE TABLE TEMCNA2 SELECT  TIPOUSO.descripcion AS USO2,  SUM(IF (( SIT_MED='' AND SIT_HID ='' AND SIT_PAD=''), 1,0)) AS CONLECTURA,  SUM(IF(SIT_HID <>'', 1,0)) AS SINFUNCIONAR, SUM(LECTURAS.CONSUMO) AS CONSUMOM3MEDIDOS, SUM(MONTOCOBRADO) AS IMPORTEMEDIDOS, SUM(ALCANTAMEDIDOS(MONTOCOBRADO,USUARIO.TARIFA)) AS IMPORTEALCANTAMEDIDOS FROM  (cuotas, tipos_usuarios tipouso,USUARIO,LECTURAS,ESTADOTOMA)   WHERE cuotas.parauso=tipouso.id_tipo_usuario  AND CUOTAS.ID_TARIFA=USUARIO.TARIFA AND LECTURAS.MES='" & mesfinal.Text & "' AND AN_PER=" & Anofinal.Value & " AND LECTURAS.CUENTA=USUARIO.CUENTA AND USUARIO.ESTADO=ESTADOTOMA.CLAVE AND ESTADOTOMA.MOSTRAR=1 GROUP BY PARAUSO;")
        Catch ex As Exception

        End Try
        Try
            Ejecucion("DROP TABLE TEMCNA3;")
        Catch ex As Exception

        End Try

        Try
            Ejecucion("CREATE TABLE TEMCNA3 AS SELECT tipouso.descripcion AS USO3,  SUM(IF(MEDIDO=0,1,0)*PAGO_AGUA) AS IMPORTEAGUAFIJA, SUM(IF(MEDIDO=0,1,0)*PAGO_ALCANT) AS IMPORTEALCAFIJA , SUM(IF(MEDIDO=0,1,0)*CUOFIJ.SANEAMIENTO) AS IMPORTESANEAFIJA FROM (cuotas,tipos_usuarios tipouso,USUARIO,CUOFIJ,ESTADOTOMA) where cuotas.parauso=tipouso.id_tipo_usuario  AND CUOTAS.ID_TARIFA=USUARIO.TARIFA  AND CUOTAS.ID_TARIFA=CUOFIJ.TARIFA  AND CUOFIJ.PERIODO=" & Anofinal.Value & " AND USUARIO.ESTADO=ESTADOTOMA.CLAVE AND ESTADOTOMA.MOSTRAR=1 group by  parauso;")
        Catch ex As Exception

        End Try
        Try
            Ejecucion("DROP TABLE TEMCNA;")
        Catch ex As Exception

        End Try
        Try
            Ejecucion("CREATE TABLE TEMCNA SELECT   *  FROM (TEMCNA1 LEFT JOIN TEMCNA2 ON TEMCNA1.USO  = TEMCNA2.USO2) LEFT JOIN TEMCNA3 ON TEMCNA1.USO=TEMCNA3.USO3 ;")
        Catch ex As Exception

        End Try


        Try

            Ejecucion("DROP TABLE TEMCNA4;")
        Catch ex As Exception

        End Try

        Try
            Ejecucion("create table temcna4 SELECT tipouso.descripcion as Uso, SUM(IF (CUOTAS.MEDIDO=0 ,MONTOPAGADO,0)) AS MONTOFIJO,SUM(IF (CUOTAS.MEDIDO=0 ,CUOTAS.MCUBEQUIV,0)) AS M3RECAUDADOSFIJOS  FROM cuotas,tipos_usuarios tipouso,USUARIO,pago_mes,ESTADOTOMA WHERE cuotas.parauso=tipouso.id_tipo_usuario  AND CUOTAS.ID_TARIFA=USUARIO.TARIFA AND USUARIO.CUENTA=PAGO_MES.CUENTA AND PAGO_MES.ANO=" & Anofinal.Value & " AND (PAGO_MES.CONCEPTO='CONSUMO' OR PAGO_MES.CONCEPTO='REZAGO' )  AND USUARIO.ESTADO=ESTADOTOMA.CLAVE AND ESTADOTOMA.MOSTRAR=1  group by  parauso;")
        Catch ex As Exception

        End Try

        Dim frm As New frmReporte(frmReporte.Lista.CNA, "", "ENCABEZADO. '" & Anofinal.Value.ToString() & "'", "TITULO. 'REPORTE DE CNA'")
        frm.MdiParent = MDIPrincipal
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
        '   MessageBoxEx.Show("TERMINÉ")
        Me.Close()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    
    Private Sub InformeCna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Anofinal.Value = Year(Now)
    End Sub
End Class