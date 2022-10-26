Imports DevComponents.DotNetBar

Public Class frmantiguedad

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        cmdImp.Enabled = False
        cmdImp.Text = "Imprimiendo"
        Dim forcom As String, formreg As String, formulacomuregi As String, FORMULARUTA As String
        Dim titulo1 As String = "", TITULO2 As String = "", TITULO3 As String = ""
        Dim tabla As String = " ESTADOS "
        Dim formulames2 As String = ""
        Dim FORMULACRYSTAL As String = ""

        If cmbComu.SelectedIndex = -1 And cmbReg.SelectedValue = -1 Then
            MessageBoxEx.Show("No seleccionaste comunidad o region")
            cmdImp.Enabled = True
            Exit Sub
        End If
        'If cmbReg.SelectedValue = "" Then
        '    MessageBoxEx.Show("No seleccionaste region")
        '    Exit Sub
        'End If
        If cmbComu.SelectedIndex <> -1 Then
            forcom = " usuario.id_comunidad='" & cmbComu.SelectedValue & "'"
        End If
        titulo1 = "COMUNIDAD: " & cmbComu.Text
        formreg = ""
        titulo1 = "COMUNIDAD: " & cmbComu.Text

        If cmbReg.SelectedIndex <> -1 Then
            formreg = " AND usuario.region='" & cmbReg.SelectedValue & "'"
            titulo1 = titulo1 & " REGION: " & cmbReg.Text

        End If
        FORMULARUTA = ""
        If cmbRuta.SelectedIndex <> -1 Then
            FORMULARUTA = " AND RUTA='" & cmbRuta.SelectedValue & "'"
            titulo1 = titulo1 & " RUTA: " & cmbRuta.Text
        End If
        If cmbCol.SelectedIndex <> -1 Then
            titulo1 = titulo1 & " COLONIA: " & cmbCol.Text
            tabla = "USUARIO"
            FORMULARUTA = FORMULARUTA & " and USUARIO.id_colonia='" & cmbCol.SelectedValue & "' "
        End If


        Dim FORMULAGIROTARIFA As String = ""
        formulacomuregi = forcom & formreg & FORMULARUTA

        If cmbGiro.SelectedIndex <> -1 Then
            FORMULAGIROTARIFA = " AND usuario.COD_GIR='" & cmbGiro.SelectedValue & "' "
            TITULO2 = "GIRO: " & cmbGiro.Text
        End If
        If cmbMrT.SelectedIndex <> -1 Then
            FORMULAGIROTARIFA += " AND usuario.cod_ser='" & cmbMrT.SelectedValue & "'"
            TITULO2 += " TIPO DE USO: " & cmbMrT.Text & ""

        End If
        If cmbTipUsu.SelectedIndex <> -1 Then
            FORMULAGIROTARIFA += " AND usuario.TARIFA='" & cmbTipUsu.SelectedValue & "'"
            TITULO2 += " TARIFA: " & cmbTipUsu.Text & ""
        End If

        formulacomuregi += FORMULAGIROTARIFA
        Dim FORMULAPAGADOS As String = ""


        Dim formulames As String
        formulames = ""
        formulames = ""

        FORMULACRYSTAL = ""
        If monto2.Value > 0 Then
            FORMULACRYSTAL = " {usuario1.total}>=" & monto1.Value & " and {usuario1.total}<=" & monto2.Value
            TITULO3 = TITULO3 & " MONTOS ENTRE $ " & monto1.Text & "- $ " & monto2.Text
        End If
        ' If mes2.Value > 0 Then formulames2 &= " and MESESTRANSCURRIDOSAHOY(PER_INI, ANO_ini) between " & mes1.Value & " and " & mes2.Value & ""
        'formulames2 &= " AND valornummes(ESTADOS.MES_PERIODO,ESTADOS.AN_PER) between valornummes('" & cmbmes.Text & "'," & ano2.Value & ")  and  valornummes('" & cmbMes1.Text & "'," & ano2.Value & ") AND ESTADOS.PAGADO=1"
        Dim FORMULAFINAL As String = ""
        FORMULAFINAL = formulacomuregi & FORMULAPAGADOS & formulames & formulames2
        If Cuenta.Checked = True Then
            FORMULAFINAL = FORMULAFINAL & " ORDER BY usuario.cuenta"
        Else
            If ChKNOMBRE.Checked = True Then
                FORMULAFINAL = FORMULAFINAL & " ORDER BY NOMBRE"
            Else
                If chktotal.Checked = True Then
                    FORMULAFINAL = FORMULAFINAL & " ORDER BY usuario.total"
                Else
                    FORMULAFINAL = FORMULAFINAL & " ORDER BY RUTA, Manazana, lote"
                End If
            End If
        End If
        Try
            cmdImp.Enabled = False
            Ejecucion("DROP TABLE IF EXISTS tmpconsumorecaudacion;")
            If Mid(FORMULAFINAL, 1, 4) = " AND" Then
                ' paso
                FORMULAFINAL = Mid(FORMULAFINAL, 5)
            End If
            Ejecucion("CREATE TABLE tmpconsumorecaudacion SELECT * from usuario  WHERE " & FORMULAFINAL)
            ' acutualiza hasta que mes tiene pagado

        Catch ex As Exception

        End Try



        cmdImp.Enabled = True

        'MessageBoxEx.Show(FORMULAFINAL)

        cmdImp.Enabled = False

        Dim XREP As New frmReporte(frmReporte.Lista.antiguedad, FORMULACRYSTAL, "ENCABEZADO1. '" & titulo1.Replace(".", " ") & "'", "ENCABEZADO2. '" & TITULO2.Replace(".", " ") & "'", "ENCABEZADO3. '" & TITULO3.Replace(".", " ") & "'")
        XREP.TitleText = "REPORTE DE ANTIGUEDAD DE SALDOS"
        XREP.Text = "REPORTE DE ANTIGUEDAD DE SALDOS"
        XREP.MdiParent = My.Forms.MDIPrincipal

        XREP.WindowState = FormWindowState.Maximized

        XREP.Show()

        'Close()
        Me.cmdImp.Enabled = True
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        llenarCombo(cmbGiro, "select codgir, descripcion from giro order by descripcion")
        llenarCombo(cmbMrT, "select id_tipo_usuario, descripcion from tipos_usuarios order by descripcion")
        llenarCombo(cmbTipUsu, "select id_tarifa, descripcion_cuota from cuotas order by descripcion_cuota")
        llenarCombo(cmbComu, "select id_comunidad,comunidad from comunidades order by comunidad")
        llenarCombo(cmbAltCons, "select consumo,consumo from cuotas group by consumo order by consumo")
        llenarCombo(cmbReg, "Select id_region,region from region  order by region")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub cmbReg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReg.SelectedIndexChanged
        If Not IsNothing(cmbReg.SelectedValue) Then

            llenarCombo(cmbRuta, "SELECT id_ruta,ruta FROM RUTAS WHERE id_region='" & cmbReg.SelectedValue.ToString & "' order by ruta")
        End If
    End Sub

    Private Sub cmbComu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComu.SelectedIndexChanged
        Try
            If Not IsNothing(cmbComu.SelectedValue) Then

                llenarCombo(cmbCol, "Select id_colonia,Colonia from colonia  order by colonia")

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub



End Class