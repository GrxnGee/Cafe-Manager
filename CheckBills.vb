Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CheckBills

    Private connectionStringg As String = "Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectionStringg)
    Private Sub FrontProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FrontProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BalanceCafeData)

    End Sub

    Private Sub CheckBills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BalanceCafeData.FrontProduct' table. You can move, or remove it, as needed.
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

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        EmployeeScreen.Show()
        Me.Close()
    End Sub


    Dim TotalPriceCount As Integer = 0
    Private Function calPrice() As Integer
        Dim Price As Integer
        If FProPriceTextBox IsNot Nothing Then
            Price = Integer.Parse(FProPriceTextBox.Text, Price)
        Else
        End If

        Dim Total As Integer = Price * RestockQuantity
        TotalPriceCount += Total
        UpdateTotalPrice()
        Return Total
    End Function

    Private Sub UpdateTotalPrice()
        TotalPrice.Text = TotalPriceCount.ToString()

    End Sub




    Dim buyQuantityCount As Integer
    Private Function calTotalQuantity() As Integer

        If ReQuantity IsNot Nothing Then
            buyQuantityCount = Integer.Parse(ReQuantity.Text, buyQuantityCount)
        Else
        End If

        Dim CurQuantity As Integer = Integer.Parse(FProQuantityTextBox.Text, CurQuantity)
        Dim TotalRestockQuantity As Integer = CurQuantity - buyQuantityCount

        Return TotalRestockQuantity
    End Function



    Private ProductNames(10) As String
    Private BuyQuantity(10) As String
    Dim PruductCount As Integer = 1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Namesearch As String = FProNameTextBox.Text
        RichTextBox1.Multiline = True

        If PruductCount <= 10 Then
            Dim ProductX As String = FProNameTextBox.Text.Trim() & "  :  " & calPrice() & "  บาท  " & "x" & RestockQuantity
            ProductNames(PruductCount - 1) = FProNameTextBox.Text.Trim()
            BuyQuantity(PruductCount - 1) = ReQuantity.Text.Trim()
            RichTextBox1.AppendText(ProductX & Environment.NewLine)
            PruductCount += 1

            sqlConnection.Open()
            Dim sql As String = "UPDATE FrontProduct SET FProQuantity = @FProQuantity WHERE FProName = @FProName "
            Dim cmd As New SqlCommand(sql, sqlConnection)

            cmd.Parameters.AddWithValue("@FProQuantity", calTotalQuantity())
            cmd.Parameters.AddWithValue("@FProName", Namesearch)


            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            sqlConnection.Close()
        Else
            MessageBox.Show("จำนวนสินค้ามากเกินไป")
        End If
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles CheckBillButton.Click
        For i As Integer = 0 To PruductCount - 2
            Using conn As New SqlConnection("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")
                conn.Open()
                Dim sql1 As String = "INSERT INTO Bill (BillID, FProName, FProPrice, TotalPrice, BuyQuantity, BillDate) " &
                            "VALUES (@BillID, @FProName, @FProPrice, @TotalPrice, @BuyQuantity, @BillDate)"

                Using cmd As New SqlCommand(sql1, conn)
                    cmd.Parameters.AddWithValue("@BillID", BillNum.Text)
                    cmd.Parameters.AddWithValue("@FProName", ProductNames(i).ToString)
                    cmd.Parameters.AddWithValue("@FProPrice", FProPriceTextBox.Text)
                    cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice.Text)
                    cmd.Parameters.AddWithValue("@BuyQuantity", Integer.Parse(BuyQuantity(i)))
                    cmd.Parameters.AddWithValue("@BillDate", CurrentDate.Value)
                    cmd.ExecuteNonQuery()
                End Using
            End Using


        Next




        MessageBox.Show("เช็คบิลแล้ว")
    End Sub
End Class