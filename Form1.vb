Imports System.Threading
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Diagnostics.Eventing.Reader

Public Module GlobalVariables
    Public EmpID As String
End Module

Public Class Form1


    Private connectionStringg As String = "Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectionStringg)

    Public Sub Wards(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpIDBox.Items.Clear()
        Dim connectionString As String = ("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT EmpID FROM Employee"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        EmpIDBox.Items.Add(reader("EmpID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub


    Public Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim confirmButton As PictureBox = DirectCast(sender, PictureBox)
        Dim EmpIDinsert As String = EmpIDBox.Text
        Dim Passinsert As String = EmpPassBox.Text

        If EmpIDinsert.First = "M" And Passinsert = "PassForMana" Then
            GlobalVariables.EmpID = "M"
            MessageBox.Show("ลงชื่อเข้าทำงานแล้ว")

            ManagerScreen.Show()
        ElseIf EmpIDinsert.First = "E" And Passinsert = "PassForEmp" Then
            GlobalVariables.EmpID = "E"
            MessageBox.Show("ลงชื่อเข้าทำงานแล้ว")
            EmployeeScreen.Show()
        Else
            MessageBox.Show("Wrong password please try again.")
        End If

        Dim WorkStatus As String

        Using conn As New SqlConnection("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")
            conn.Open()

            Dim sql1 As String = "INSERT INTO WorkHistory (EmpID, WhDate, WhStatus) " &
                          "VALUES (@EmpID, @WhDate, @WhStatus)"

            Using cmd As New SqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@EmpID", EmpIDBox.Text)
                cmd.Parameters.AddWithValue("@WhDate", WorkTimebox.Value)

                If WorkTimebox.Value.TimeOfDay > New TimeSpan(8, 30, 0) Then
                    WorkStatus = "Late"
                Else
                    WorkStatus = "Normal"
                End If

                cmd.Parameters.AddWithValue("@WhStatus", WorkStatus)

                cmd.ExecuteNonQuery()
            End Using
        End Using



    End Sub





End Class
