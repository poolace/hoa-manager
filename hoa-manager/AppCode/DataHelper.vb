Imports System.Data.SqlClient
Imports System.Configuration

Module DataHelper
    Public Function GetDataTableForSQL(sql As String, Optional buttonText As String = "") As DataTable
        Dim dt As New DataTable
        Using con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("Prod").ConnectionString)
            con.Open()
            Dim sda As SqlDataAdapter = New SqlDataAdapter(sql, con)
            sda.Fill(dt)
            con.Close()
            sda = Nothing
        End Using

        If Not buttonText = "" Then
            Dim dw As New DataColumn With {
                .DefaultValue = buttonText
            }
            dt.Columns.Add(dw)
            dw.SetOrdinal(0)
        End If
        Return dt
    End Function

    Public Function GetDataGridViewForDataTable(dt As DataTable) As DataGridView
        Dim dtColCnt As Integer = dt.Columns.Count

        Dim DgvTemp As New DataGridView With {
            .ColumnCount = dtColCnt - 1
            }
        With DgvTemp
            .Columns.Insert(0, New DataGridViewButtonColumn)
            .Columns(0).Width = 40
            .Columns(0).Resizable = DataGridViewTriState.False

            For x = 1 To dtColCnt - 1
                .Columns(x).Name = dt.Columns(x).ColumnName
            Next
            .Columns(1).Visible = False

            For Each row As DataRow In dt.Rows()
                .Rows.Add(row.ItemArray)
            Next

            .RowHeadersVisible = False
            .AllowUserToAddRows = False
        End With
        Return DgvTemp
    End Function
End Module
