Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EditEmployee

    Private connectionStringg As String = "Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectionStringg)

    Public Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        ManagerScreen.Show()
        Me.Close()
    End Sub

    Public Sub EmployeeSelect(sender As Object, e As EventArgs) Handles MyBase.Load

        EmpIDbox.Items.Clear()


        Dim connectionString As String = ("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT EmpID FROM Employee"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        EmpIDbox.Items.Add(reader("EmpID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub



    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim IDsearch As String = EmpIDbox.Text
        sqlConnection.Open()
        Dim sql As String = "UPDATE Employee SET EmpName = @EmpName, EmpAddress = @EmpAddress, EmpWorkDate = @EmpWorkDate, EmpPosition = @EmpPosition WHERE EmpID = @EmpID "
        Dim cmd As New SqlCommand(sql, sqlConnection)


        cmd.Parameters.AddWithValue("@EmpName", EmpNameTextBox.Text)
        cmd.Parameters.AddWithValue("@EmpAddress", EmpAddressTextBox.Text)
        cmd.Parameters.AddWithValue("@EmpWorkDate", EmpWorkDateTextBox.Text)
        cmd.Parameters.AddWithValue("@EmpPosition", EmpPositionTextBox.Text)
        cmd.Parameters.AddWithValue("@EmpID", IDsearch)


        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


        sqlConnection.Close()

        MessageBox.Show("แก้ไขข้อมูลแล้ว")
        ManagerScreen.Show()
        Me.Close()
    End Sub

    Public Sub เลือก_Click(sender As Object, e As EventArgs) Handles Choose.Click
        Dim IDsearch = EmpIDbox.Text

        Dim sql = "SELECT TOP 1 * FROM Employee WHERE EmpID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            EmpNameTextBox.Text = sqlreader.Item("EmpName")
            EmpAddressTextBox.Text = sqlreader.Item("EmpAddress")
            EmpWorkDateTextBox.Text = sqlreader.Item("EmpWorkDate")
            EmpPositionTextBox.Text = sqlreader.Item("EmpPosition")

        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Public Sub DeleteBut_Click(sender As Object, e As EventArgs) Handles DeleteBut.Click
        Dim IDdelete = EmpIDbox.Text

        Dim sql = "DELETE FROM Employee WHERE EmpID = '" & IDdelete & "' "
        Dim cmd = sqlConnection.CreateCommand


        Dim sql2 = "DELETE FROM WorkHistory WHERE EmpID = '" & IDdelete & "' "
        Dim cmd2 = sqlConnection.CreateCommand

        cmd.CommandText = sql
        cmd2.CommandText = sql2

        sqlConnection.Open()
        Dim sqlreader2 = cmd2.ExecuteReader()
        sqlConnection.Close()

        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()
        sqlConnection.Close()

        MessageBox.Show("ลบพนักงานแล้ว")
        EmployeeList.Close()
        Me.Close()
        EmployeeList.Show()
    End Sub
End Class