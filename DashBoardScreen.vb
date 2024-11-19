Imports System.Data.SqlClient

Public Class DashBoardScreen
    Private connectionString As String = "Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT BillID FROM Bill GROUP BY BillID"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("BillID").ToString())
                    End While
                End Using
            End Using
        End Using

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        BillDataGridView.Rows.Clear()
        Dim IDsearch As String = ComboBox1.Text
        Dim sql As String = "SELECT BillID, FProName, FProPrice, BuyQuantity
                        FROM Bill
                        WHERE BillID = @IDsearch ORDER BY BillID"

        Using sqlConnection As New SqlConnection("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")
            sqlConnection.Open()

            Using cmd As New SqlCommand(sql, sqlConnection)
                cmd.Parameters.AddWithValue("@IDsearch", IDsearch)

                Using sqlreader As SqlDataReader = cmd.ExecuteReader()


                    While sqlreader.Read()
                        BillDataGridView.Rows.Add(sqlreader("BillID"), sqlreader("FProName"), sqlreader("FProPrice"), sqlreader("BuyQuantity"))
                    End While


                End Using
            End Using

            sqlConnection.Close()
        End Using

        Chart1.Series("BuyBH").Points.Clear()
        RetrieveBuyBehaviour()
    End Sub

    Private Sub RetrieveBuyBehaviour()
        Dim connectionString As String = ("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim WardNum = ComboBox1.Text

            Dim sql As String = "SELECT FProName, BuyQuantity
                             FROM Bill
                             WHERE BillID = @IDsearch"

            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@IDsearch", WardNum)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim FProNameName As String = reader.GetString(reader.GetOrdinal("FProName"))
                        Dim BuyQuantityName As Integer = Convert.ToInt32(reader("BuyQuantity"))

                        Chart1.Series("BuyBH").Points.AddXY(FProNameName, BuyQuantityName)
                    End While
                End Using
            End Using
        End Using
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
