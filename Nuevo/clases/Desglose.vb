Public Class Desglose
    Public porceConsumoActual As Decimal = 0
    Public porceConsumoRezago As Decimal = 0
    Public porceAlcantarilladoActual As Decimal = 0
    Public porceAlcantarilladoRezago As Decimal = 0
    Public porceSaneamientoActual As Decimal = 0
    Public porceSaneamientoRezago As Decimal = 0
    Public porceOtros As Decimal = 0
    Public porceRecargosActual As Decimal = 0
    Public porceRecargosRezago As Decimal = 0
    Public porceIva As Decimal = 0
    Public total As Decimal = 0
    Public control As Clscontrolpago

    Public Sub Calcula(contril1 As Clscontrolpago)
        control = contril1
        Dim acuaguaactual As Decimal = 0
        Try




            For i As Integer = 1 To control.desgloseconsumo.Count

                    Dim tipoobjecto As String = control.desgloseconsumo(i).GetType().Name.ToString()



                    If tipoobjecto = "clsunidadmes" Then

                        Dim elemento As clsunidadmes

                        elemento = control.desgloseconsumo(i)
                        acuaguaactual = acuaguaactual + elemento.total
                    End If
                    If tipoobjecto = "ClsRegistrolectura" Then
                        Dim elemento As ClsRegistrolectura
                        elemento = control.desgloseconsumo(i)
                        acuaguaactual = acuaguaactual + elemento.Total
                    End If
                Next

                Dim acuaguaareazago As Decimal = 0
                For i As Integer = 1 To control.desgloserezago.Count

                Dim tipoobjecto As String = control.desgloserezago(i).GetType().Name.ToString()



                If tipoobjecto = "clsunidadmes" Then

                        Dim elemento As clsunidadmes

                        elemento = control.desgloserezago(i)
                        acuaguaareazago = acuaguaareazago + elemento.total
                    End If
                    If tipoobjecto = "ClsRegistrolectura" Then
                        Dim elemento As ClsRegistrolectura
                        elemento = control.desgloserezago(i)
                        acuaguaareazago = acuaguaareazago + elemento.Total
                    End If
                Next

                Dim acuaalcantactual As Decimal = 0
                Dim acuaalcantrezago As Decimal = 0
                For i As Integer = 1 To control.desglosealcantarillado.Count

                Dim tipoobjecto As String = control.desglosealcantarillado(i).GetType().Name.ToString()


                If tipoobjecto = "clsunidadmes" Then

                        Dim elemento As clsunidadmes

                        elemento = control.desglosealcantarillado(i)

                        If elemento.periodo = Now.Year Then
                            acuaalcantactual += elemento.total
                        Else
                            acuaalcantrezago += elemento.total
                        End If

                    End If
                    If tipoobjecto = "ClsRegistrolectura" Then
                        Dim elemento As ClsRegistrolectura
                        elemento = control.desglosealcantarillado(i)

                        If elemento.Periodo = Now.Year Then
                            acuaalcantactual += elemento.Total
                        Else
                            acuaalcantrezago += elemento.Total
                        End If
                    End If
                Next
                '''''''''''''''''
                Dim acuaSanaactual As Decimal = 0
                Dim acuaSanarezago As Decimal = 0
                For i As Integer = 1 To control.desglosesaneamiento.Count

                Dim tipoobjecto As String = control.desglosesaneamiento(i).GetType().Name.ToString()

                If tipoobjecto = "clsunidadmes" Then

                        Dim elemento As clsunidadmes

                        elemento = control.desglosesaneamiento(i)

                        If elemento.periodo = Now.Year Then
                            acuaSanaactual += elemento.total
                        Else
                            acuaSanarezago += elemento.total
                        End If

                    End If
                    If tipoobjecto = "ClsRegistrolectura" Then
                        Dim elemento As ClsRegistrolectura
                        elemento = control.desglosesaneamiento(i)

                        If elemento.Periodo = Now.Year Then
                            acuaSanaactual += elemento.Total
                        Else
                            acuaSanarezago += elemento.Total
                        End If
                    End If
                Next



                Dim acuaRecargoctual As Decimal = 0
                Dim acuaRecargorezago As Decimal = 0
                For i As Integer = 1 To control.desgloserecargo.Count

                    Dim tipoobjecto As String = control.desgloserecargo(i).GetType().Name.ToString()

                    If tipoobjecto = "clsunidadmes" Then

                        Dim elemento As clsunidadmes

                        elemento = control.desgloserecargo(i)

                        If elemento.periodo = Now.Year Then
                            acuaRecargoctual += elemento.total
                        Else
                            acuaRecargorezago += elemento.total
                        End If

                    End If
                    If tipoobjecto = "ClsRegistrolectura" Then
                        Dim elemento As ClsRegistrolectura
                        elemento = control.desgloserecargo(i)

                        If elemento.Periodo = Now.Year Then
                            acuaRecargoctual += elemento.Total
                        Else
                            acuaRecargorezago += elemento.Total
                        End If
                    End If
                Next




                Dim granTotal As Decimal = 0
            granTotal = Math.Round(control.totaldeudaconsumo, 2) + control.totaldeudaalcantarillado + control.totaldeudasaneamiento + control.totaldeudaiva + control.totaldeudarecargos + control.totaldeudaotros

            porceConsumoActual = acuaguaactual / granTotal
            porceConsumoRezago = acuaguaareazago / granTotal
            porceAlcantarilladoActual = acuaalcantactual / granTotal
            porceAlcantarilladoRezago = acuaalcantrezago / granTotal
            porceRecargosActual = acuaRecargoctual / granTotal
            porceRecargosRezago = acuaRecargorezago / granTotal
            porceSaneamientoActual = acuaSanaactual / granTotal
            porceSaneamientoRezago = acuaSanarezago / granTotal
            porceOtros = control.totaldeudaotros / granTotal
            porceIva = control.totaldeudaiva / granTotal
            total = granTotal

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


End Class
