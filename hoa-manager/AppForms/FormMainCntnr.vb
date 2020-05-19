Public Class FormMainCntnr
    Private Sub FormMainCntnr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Made a change

    End Sub

    Private Sub TSMI_FMC_File_New_Click(sender As Object, e As EventArgs) Handles TSMI_FMC_File_New.Click
        Dim newMDIChild As admEdit = New admEdit()
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub WindowToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
