Public Class EmployeeList
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BalanceCafeData)

    End Sub

    Private Sub EmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BalanceCafeData.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.BalanceCafeData.Employee)

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        ManagerScreen.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        EditEmployee.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AddEmployee.Show()
        Me.Close()
    End Sub
End Class