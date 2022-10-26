Partial Class dtsDatosReporte
    Partial Class DatosDataTable

        Private Sub DatosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nodemedidorColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

      

    End Class

    Partial Class DataTable1DataTable



    End Class

End Class
