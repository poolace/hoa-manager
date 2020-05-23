Public Class AdmEdit
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ParentForm.ActiveMdiChild.Close()
    End Sub
End Class