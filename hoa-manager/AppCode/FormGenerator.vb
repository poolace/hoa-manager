Imports System.Configuration
Imports System.Data.SqlClient

Module FormGenerator
    Sub FormatLookupForm(ByRef frm As Form, title As String, sql As String)
        frm.Text = title
        frm.Width = 400

        'get datatable
        Dim dt As DataTable = GetDataTableForSQL(sql, "Edit")

        Dim dgv As DataGridView = GetDataGridViewForDataTable(dt)
        With dgv
            .Name = "dynDgv"
            .Location = New Point(10, 10)
            .Width = frm.Width - 36
            .Size = New Drawing.Size(frm.Width - 36, frm.Height - 100)
            AddHandler .CellContentClick, AddressOf Dgv_Click
        End With
        frm.Controls.Add(dgv)

        Dim btnAdd As New Button
        frm.Controls.Add(btnAdd)
        With btnAdd
            .Name = "btnAdd"
            .Text = "&Add"
            .Left = dgv.Location.X
            .Top = (dgv.Location.Y + dgv.Height) + 10
            AddHandler .Click, AddressOf Button_Click
        End With

        'Dim btnClose As New Button
        'frm.Controls.Add(btnClose)
        With frm.Controls("btnClose")
            '.Name = "btnClose"
            '.Text = "&Close"
            .Left = (dgv.Location.X + dgv.Width) - .Width
            .Top = (dgv.Location.Y + dgv.Height) + 10
            'AddHandler .Click, AddressOf Button_Click
        End With
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pushedButton As Button = sender
        If pushedButton.Name = "btnAdd" Then
            'adminAdd("State")
            MsgBox("Open form to add a record.")
        End If
    End Sub
    Private Sub Dgv_Click(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs)
        If IsANonHeaderButtonCell(e) Then
            MsgBox("Open form to edit the record for " + "TBD" + ".")
        End If
    End Sub

    Private Function IsANonHeaderButtonCell(cellEvent As DataGridViewCellEventArgs) As Boolean
        'If .Controls("dynDgv").Columns(cellEvent.ColumnIndex) Is DataGridViewButtonColumn Then
        '&& Not cellEvent.RowIndex = -1 Then
        'End If
        Return True

    End Function
End Module
