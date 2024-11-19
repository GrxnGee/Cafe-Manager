Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddEmployee
    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles PositionBox.Click
        PositionBox.Items.Clear()
        PositionBox.Items.Add("Manager")
        PositionBox.Items.Add("Employee")
    End Sub

    Private Sub Choose_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Using conn As New SqlConnection("Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;")
            conn.Open()

            Dim sql1 As String = "INSERT INTO Employee(EmpID,EmpName,EmpAddress,EmpWorkDate,EmpPosition) " &
                            "VALUES (@EmpID, @EmpName, @EmpAddress, @EmpWorkDate, @EmpPosition)"

            Using cmd As New SqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@EmpID", EmpIDbox.Text)
                cmd.Parameters.AddWithValue("@EmpName", EmpNameTextBox.Text)
                cmd.Parameters.AddWithValue("@EmpAddress", EmpAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@EmpWorkDate", EmpWorkDateTextBox.Text)
                cmd.Parameters.AddWithValue("@EmpPosition", PositionBox.Text)

                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("เพิ่มพนักงานแล้ว")
        EmployeeList.Close()
        Me.Close()
        EmployeeList.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        ManagerScreen.Show()
        Me.Close()
    End Sub
End Class