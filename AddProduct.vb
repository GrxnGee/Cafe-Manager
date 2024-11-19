Imports System.Data.SqlClient

Public Class AddProduct
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


    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Using conn As New SqlConnection("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")
            conn.Open()



            Dim sql1 As String = "INSERT INTO InStockProduct(ISProID,ISProName,ISProType,ISProPrice,ISProQuantity)" &
                            "VALUES (@ISProID, @ISProName, @ISProType, @ISProPrice, @ISProQuantity)"

            Using cmd As New SqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@ISProID", ISProIDTextBox.Text)
                cmd.Parameters.AddWithValue("@ISProName", ISProNameTextBox.Text)
                cmd.Parameters.AddWithValue("@ISProType", ISProTypeTextBox.Text)
                cmd.Parameters.AddWithValue("@ISProPrice", ISProPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@ISProQuantity", ISProQuantityTextBox.Text)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using


        Using conn As New SqlConnection("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")
            conn.Open()



            Dim sql2 As String = "INSERT INTO FrontProduct( FProID,FProName,FProType,FProPrice,FProQuantity)" &
                            "VALUES (@FProID, @FProName, @FProType, @FProPrice, @FProQuantity)"

            Using cmd2 As New SqlCommand(sql2, conn)
                cmd2.Parameters.AddWithValue("@FProID", ISProIDTextBox.Text)
                cmd2.Parameters.AddWithValue("@FProName", ISProNameTextBox.Text)
                cmd2.Parameters.AddWithValue("@FProType", ISProTypeTextBox.Text)
                cmd2.Parameters.AddWithValue("@FProPrice", ISProPriceTextBox.Text)
                cmd2.Parameters.AddWithValue("@FProQuantity", FQuantitybox.Text)
                cmd2.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using

        StockProductList.Close()
        MessageBox.Show("เพิ่มสินค้าใหม่แล้ว")
        StockProductList.Show()
        Me.Close()
    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class