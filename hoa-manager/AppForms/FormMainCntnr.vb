Public Class FormMainCntnr
    Private Sub FormMainCntnr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Made a change

    End Sub

    Private Sub TSMI_FMC_File_New_Click(sender As Object, e As EventArgs) Handles TSMI_FMC_File_New.Click
        'Dim newMDIChild As admEdit = New admEdit()
        Dim newMDIChild As test = New test()
        formatStateLookup(newMDIChild)
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click


    End Sub
End Class
