Imports System.CodeDom.Compiler
Imports System.Data.SqlClient

Public Class RestockProduct

    Private connectionStringg As String = "Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectionStringg)

    Private Sub FrontProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FrontProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BalanceCafeData)

    End Sub

    Private Sub RestockProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BalanceCafeData.InStockProduct' table. You can move, or remove it, as needed.
        Me.InStockProductTableAdapter.Fill(Me.BalanceCafeData.InStockProduct)
        Me.FrontProductTableAdapter.Fill(Me.BalanceCafeData.FrontProduct)
    End Sub






    Dim RestockQuantity As Integer = 0


    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        RestockQuantity += 1
        UpdateQuantityTextBox()
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        RestockQuantity -= 1
        UpdateQuantityTextBox()
    End Sub


    Private Sub UpdateQuantityTextBox()
        ReQuantity.Text = RestockQuantity.ToString()
    End Sub

    '*******************************************************************************'

    Private Function calTotalQuantity() As Integer
        Dim CurQuantity As Integer
        If FProQuantityTextBox IsNot Nothing Then
            CurQuantity = Integer.Parse(FProQuantityTextBox.Text, CurQuantity)
        Else
        End If

        Dim TotalRestockQuantity As Integer = RestockQuantity + CurQuantity

        Return TotalRestockQuantity
    End Function
    '*******************************************************************************'
    Private Function calTotalISQuantity() As Integer
        Dim CurQuantity As Integer

        If ISProQuantityTextBox IsNot Nothing Then
            CurQuantity = Integer.Parse(ISProQuantityTextBox.Text, CurQuantity)
        Else
        End If
        Dim TotalRestockQuantity As Integer

        If RestockQuantity > 0 Then
            TotalRestockQuantity = CurQuantity - RestockQuantity
        Else
            TotalRestockQuantity = CurQuantity
        End If

        Return TotalRestockQuantity
    End Function


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim IDsearch As String = FProIDTextBox.Text
        Dim Namesearch As String = FProNameTextBox.Text

        Dim CurQuantity As Integer = Integer.Parse(ISProQuantityTextBox.Text, CurQuantity)

        If CurQuantity >= RestockQuantity Then
            sqlConnection.Open()
            Dim sql As String = "UPDATE FrontProduct SET FProQuantity = @FProQuantity WHERE FProID = @FProID "
            Dim cmd As New SqlCommand(sql, sqlConnection)

            cmd.Parameters.AddWithValue("@FProQuantity", calTotalQuantity())
            cmd.Parameters.AddWithValue("@FProID", IDsearch)


            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()



            '*******************************************************************************'

            Dim sql2 As String = "UPDATE InStockProduct SET ISProQuantity = @ISProQuantity WHERE ISProName = @ISProName "
            Dim cmd2 As New SqlCommand(sql2, sqlConnection)

            cmd2.Parameters.AddWithValue("@ISProQuantity", calTotalISQuantity())
            cmd2.Parameters.AddWithValue("@ISProName", Namesearch)


            Dim rowsAffected2 As Integer = cmd2.ExecuteNonQuery()


            sqlConnection.Close()


            MessageBox.Show("เติมสินค้าแล้ว")

            Dim Refresh As New RestockProduct
            Me.Close()
            Refresh.Show()
        Else
            MessageBox.Show("ไม่สามารถทำรายการได้เนื่องจากของหมด")
        End If
    End Sub


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
End Class