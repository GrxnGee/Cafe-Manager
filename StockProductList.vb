Public Class StockProductList
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim empIDValue As String = GlobalVariables.EmpID
        If empIDValue = "M" Then
            ManagerScreen.Show()
            Me.Close()
        End If

        If empIDValue = "E" Then
            EmployeeScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub InStockProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.InStockProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BalanceCafeData)

    End Sub

    Private Sub StockProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BalanceCafeData.InStockProduct' table. You can move, or remove it, as needed.
        Me.InStockProductTableAdapter.Fill(Me.BalanceCafeData.InStockProduct)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AddProduct.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        EditProduct.Show()
    End Sub
End Class