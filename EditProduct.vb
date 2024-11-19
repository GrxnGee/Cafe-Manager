Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EditProduct
    Public connectionStringg As String = "Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectionStringg)
    Public Sub Wards(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT ISProID FROM InStockProduct"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("ISProID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT TOP 1 * FROM InStockProduct WHERE ISProID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ISProNameTextBox.Text = sqlreader.Item("ISProName")
            ISProTypeTextBox.Text = sqlreader.Item("ISProType")
            ISProPriceTextBox.Text = sqlreader.Item("ISProPrice")

        Loop


        sqlreader.Close()
        sqlConnection.Close()
    End Sub


    Public Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        StockProductList.Show()
        Me.Close()
    End Sub

    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim IDsearch As String = ComboBox1.Text
        sqlConnection.Open()


        Dim sql As String = "UPDATE InStockProduct SET ISProName = @ISProName, ISProType = @ISProType, ISProPrice = @ISProPrice WHERE ISProID = @ISProID"
        Dim cmd As New SqlCommand(sql, sqlConnection)
        cmd.Parameters.AddWithValue("@ISProName", ISProNameTextBox.Text)
        cmd.Parameters.AddWithValue("@ISProType", ISProTypeTextBox.Text)
        cmd.Parameters.AddWithValue("@ISProPrice", ISProPriceTextBox.Text)
        cmd.Parameters.AddWithValue("@ISProID", IDsearch)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


        Dim sql2 As String = "UPDATE FrontProduct SET FProName = @FProName, FProType = @FProType, FProPrice = @FProPrice WHERE FProID = @FProID"
        Dim cmd2 As New SqlCommand(sql2, sqlConnection)
        cmd2.Parameters.AddWithValue("@FProName", ISProNameTextBox.Text)
        cmd2.Parameters.AddWithValue("@FProType", ISProTypeTextBox.Text)
        cmd2.Parameters.AddWithValue("@FProPrice", ISProPriceTextBox.Text)
        cmd2.Parameters.AddWithValue("@FProID", IDsearch)
        Dim rowsAffected2 As Integer = cmd2.ExecuteNonQuery()

        sqlConnection.Close()

        MessageBox.Show("แก้ไขข้อมูลแล้ว")
        StockProductList.Close()
        Me.Close()
        StockProductList.Show()
    End Sub

    Public Sub DeleteBut_Click(sender As Object, e As EventArgs) Handles DeleteBut.Click
        Dim IDdelete = ComboBox1.Text

        Dim sql = "DELETE FROM FrontProduct WHERE FProID = '" & IDdelete & "' "
        Dim cmd = sqlConnection.CreateCommand

        Dim sql2 = "DELETE FROM InStockProduct WHERE ISProID = '" & IDdelete & "' "
        Dim cmd2 = sqlConnection.CreateCommand
        cmd.CommandText = sql
        cmd2.CommandText = sql2

        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()
        sqlConnection.Close()

        sqlConnection.Open()
        Dim sqlreader2 = cmd2.ExecuteReader()
        sqlConnection.Close()

        MessageBox.Show("ลบสินค้าออกแล้ว")
        StockProductList.Close()
        Me.Close()
        StockProductList.Show()
    End Sub

End Class