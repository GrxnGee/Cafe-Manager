Public Class EmployeeScreen
    Private Sub Product_Click(sender As Object, e As EventArgs) Handles Product.Click
        ProductList.Show()
        Me.Close()
    End Sub

    Private Sub Stock_Click(sender As Object, e As EventArgs) Handles Stock.Click
        StockProductList.Show()
        Me.Close()
    End Sub

    Private Sub BuyAndBill_Click(sender As Object, e As EventArgs) Handles BuyAndBill.Click
        CheckBills.Show()
        Me.Close()
    End Sub

    Private Sub DashBoard_Click(sender As Object, e As EventArgs) Handles DashBoard.Click
        DashBoardScreen.Show()
        Me.Close()
    End Sub
End Class