Imports System.Data.SqlClient

Public Class ProductList


    Private connectionStringg As String = "Server=DESKTOP-S7LHQVM\CAFEMANAGER;Database=BalanceCafe;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectionStringg)

    Private Sub FrontProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FrontProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BalanceCafeData)

    End Sub

    Private Sub ProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BalanceCafeData.FrontProduct' table. You can move, or remove it, as needed.
        Me.FrontProductTableAdapter.Fill(Me.BalanceCafeData.FrontProduct)

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


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RestockProduct.Show()
    End Sub
End Class