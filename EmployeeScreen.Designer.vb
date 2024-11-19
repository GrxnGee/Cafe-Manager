<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BuyAndBill = New System.Windows.Forms.PictureBox()
        Me.DashBoard = New System.Windows.Forms.PictureBox()
        Me.Stock = New System.Windows.Forms.PictureBox()
        Me.Product = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BuyAndBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuyAndBill
        '
        Me.BuyAndBill.Image = Global.CafeManager.My.Resources.Resources.Buy_CheckBillButton_removebg_preview
        Me.BuyAndBill.Location = New System.Drawing.Point(289, 130)
        Me.BuyAndBill.Name = "BuyAndBill"
        Me.BuyAndBill.Size = New System.Drawing.Size(215, 109)
        Me.BuyAndBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuyAndBill.TabIndex = 5
        Me.BuyAndBill.TabStop = False
        '
        'DashBoard
        '
        Me.DashBoard.Image = Global.CafeManager.My.Resources.Resources.DashBoardButton_removebg_preview
        Me.DashBoard.Location = New System.Drawing.Point(394, 245)
        Me.DashBoard.Name = "DashBoard"
        Me.DashBoard.Size = New System.Drawing.Size(189, 87)
        Me.DashBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DashBoard.TabIndex = 5
        Me.DashBoard.TabStop = False
        '
        'Stock
        '
        Me.Stock.Image = Global.CafeManager.My.Resources.Resources.CheckStovkButton_removebg_preview
        Me.Stock.Location = New System.Drawing.Point(214, 338)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(174, 87)
        Me.Stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Stock.TabIndex = 6
        Me.Stock.TabStop = False
        '
        'Product
        '
        Me.Product.Image = Global.CafeManager.My.Resources.Resources.ProductButton_removebg_preview
        Me.Product.Location = New System.Drawing.Point(214, 245)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(174, 87)
        Me.Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Product.TabIndex = 7
        Me.Product.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.LogoCafe_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(214, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'EmployeeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BuyAndBill)
        Me.Controls.Add(Me.DashBoard)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Product)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EmployeeScreen"
        Me.Text = "EmployeeScreen"
        CType(Me.BuyAndBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DashBoard As PictureBox
    Friend WithEvents Stock As PictureBox
    Friend WithEvents Product As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BuyAndBill As PictureBox
End Class
