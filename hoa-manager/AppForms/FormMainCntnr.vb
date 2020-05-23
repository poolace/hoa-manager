Public Class FormMainCntnr
    Private Sub FormMainCntnr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Made a change

    End Sub

    Private Sub TSMI_FMC_File_New_Click(sender As Object, e As EventArgs) Handles TSMI_FMC_File_New.Click

    End Sub

    Private Sub AddEditAddressTypeTSMI_Click(sender As Object, e As EventArgs) Handles AddEditAddressTypeTSMI.Click
        Dim newMDIChild As AdmEdit = New AdmEdit()
        FormatLookupForm(newMDIChild, "Add/Edit Address Type", "SELECT * FROM AddressType")
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub AddEditEntityTypeTSMI_Click(sender As Object, e As EventArgs) Handles AddEditEntityTypeTSMI.Click
        Dim newMDIChild As AdmEdit = New AdmEdit()
        FormatLookupForm(newMDIChild, "Add/Edit Entity Type", "SELECT * FROM EntityType")
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub AddEditPhoneTypeTSMI_Click(sender As Object, e As EventArgs) Handles AddEditPhoneTypeTSMI.Click
        Dim newMDIChild As AdmEdit = New AdmEdit()
        FormatLookupForm(newMDIChild, "Add/Edit Phone Type", "SELECT * FROM PhoneType")
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub AddEditStateTSMI_Click(sender As Object, e As EventArgs) Handles AddEditStateTSMI.Click
        Dim newMDIChild As AdmEdit = New AdmEdit()
        FormatLookupForm(newMDIChild, "Add/Edit State Table", "SELECT * FROM State")
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub QuitTSMI_Click(sender As Object, e As EventArgs) Handles QuitTSMI.Click
        Me.Close()
    End Sub
End Class
