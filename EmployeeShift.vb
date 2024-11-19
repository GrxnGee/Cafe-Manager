Public Class EmployeeShift



    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        ManagerScreen.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WorkHistoryTableAdapter.Fill(Me.BalanceCafeData.WorkHistory)
    End Sub
End Class