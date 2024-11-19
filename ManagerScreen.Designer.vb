<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Employee = New System.Windows.Forms.PictureBox()
        Me.Shift = New System.Windows.Forms.PictureBox()
        Me.DashBoard = New System.Windows.Forms.PictureBox()
        Me.Stock = New System.Windows.Forms.PictureBox()
        Me.Pruduct = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pruduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee
        '
        Me.Employee.Image = Global.CafeManager.My.Resources.Resources.EmployeeListButton_removebg_preview
        Me.Employee.Location = New System.Drawing.Point(396, 127)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(174, 87)
        Me.Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Employee.TabIndex = 1
        Me.Employee.TabStop = False
        '
        'Shift
        '
        Me.Shift.Image = Global.CafeManager.My.Resources.Resources.ShiftButton_removebg_preview
        Me.Shift.Location = New System.Drawing.Point(310, 313)
        Me.Shift.Name = "Shift"
        Me.Shift.Size = New System.Drawing.Size(174, 87)
        Me.Shift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Shift.TabIndex = 1
        Me.Shift.TabStop = False
        '
        'DashBoard
        '
        Me.DashBoard.Image = Global.CafeManager.My.Resources.Resources.DashBoardButton_removebg_preview
        Me.DashBoard.Location = New System.Drawing.Point(396, 220)
        Me.DashBoard.Name = "DashBoard"
        Me.DashBoard.Size = New System.Drawing.Size(174, 87)
        Me.DashBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DashBoard.TabIndex = 1
        Me.DashBoard.TabStop = False
        '
        'Stock
        '
        Me.Stock.Image = Global.CafeManager.My.Resources.Resources.CheckStovkButton_removebg_preview
        Me.Stock.Location = New System.Drawing.Point(216, 220)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(174, 87)
        Me.Stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Stock.TabIndex = 1
        Me.Stock.TabStop = False
        '
        'Pruduct
        '
        Me.Pruduct.Image = Global.CafeManager.My.Resources.Resources.ProductButton_removebg_preview
        Me.Pruduct.Location = New System.Drawing.Point(216, 127)
        Me.Pruduct.Name = "Pruduct"
        Me.Pruduct.Size = New System.Drawing.Size(174, 87)
        Me.Pruduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pruduct.TabIndex = 1
        Me.Pruduct.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.LogoCafe_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(216, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ManagerScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Employee)
        Me.Controls.Add(Me.Shift)
        Me.Controls.Add(Me.DashBoard)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Pruduct)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ManagerScreen"
        Me.Text = "ManagerScreen"
        CType(Me.Employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pruduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pruduct As PictureBox
    Friend WithEvents Employee As PictureBox
    Friend WithEvents Stock As PictureBox
    Friend WithEvents DashBoard As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Shift As PictureBox
End Class
