Imports System.Configuration
Imports System.Data.SqlClient

Module FormGenerator
    Sub formatStateLookup(ByRef frm As Form)
        frm.Text = "Phone Type Editor"

        '***Add controls***
        Dim lPhoneType As New Label()
        lPhoneType.Text = "Phone Type:"
        lPhoneType.Location = New Point(5, 15)
        frm.Controls.Add(lPhoneType)

        Dim tPhoneType As New TextBox()
        tPhoneType.Name = "txtPhoneType"
        tPhoneType.Location = New Point(lPhoneType.Width + 5, 15)
        frm.Controls.Add(tPhoneType)

        Dim bAdd As New Button()
        bAdd.Location = New Point(tPhoneType.Left + 15, 15)
        bAdd.Text = "Add"
        frm.Controls.Add(bAdd)

        Dim dgv As DataGridView = New DataGridView()
        Dim con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("Prod").ConnectionString)
        con.Open()
        Dim query As String = "SELECT * FROM PhoneType"
        Dim sda As SqlDataAdapter = New SqlDataAdapter(query, con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        dgv.DataSource = dt
        dgv.Columns("Id").Visible = False
        con.Close()
        dgv.Location = New Point(10, 60)
        dgv.Width = 350
        dgv.Height = 250
        frm.Controls.Add(dgv)
        frm.Width = 270
        frm.Height = 115
    End Sub
End Module
