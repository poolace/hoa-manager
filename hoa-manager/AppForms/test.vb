Imports System.Data.SqlClient
Imports System.Configuration
Public Class test
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get datatable
        Dim sql As String = "SELECT * FROM State"
        Dim dt As DataTable = GetDataTableForSQL(sql, "Edit")

        Dim dgv As DataGridView = GetDataGridViewForDataTable(dt)
        Me.Controls.Add(dgv)
        With dgv
            .Location = New Point(10, 10)
            .Width = Me.Width - 36
            .Size = New Drawing.Size(Me.Width - 36, Me.Height - 100)
        End With

    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex() = 0 Then
            'MsgBox("Clicked a button for " & dgv.Rows(e.RowIndex).Cells(1).Value.ToString)
        End If
    End Sub


End Class