Public Class ManagerScreen
    Private Sub Pruduct_Click(sender As Object, e As EventArgs) Handles Pruduct.Click
        ProductList.Show()
        Me.Close()
    End Sub

    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click
        EmployeeList.Show()
        Me.Close()
    End Sub

    Private Sub Shift_Click(sender As Object, e As EventArgs) Handles Shift.Click
        EmployeeShift.Show()
        Me.Close()
    End Sub

    Private Sub Stock_Click(sender As Object, e As EventArgs) Handles Stock.Click
        StockProductList.Show()
        Me.Close()
    End Sub

    Private Sub DashBoard_Click(sender As Object, e As EventArgs) Handles DashBoard.Click
        DashBoardScreen.Show()
        Me.Close()
    End Sub
End Class