<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Me.components = New System.ComponentModel.Container()
        Dim ISProIDLabel As System.Windows.Forms.Label
        Dim ISProNameLabel As System.Windows.Forms.Label
        Dim ISProTypeLabel As System.Windows.Forms.Label
        Dim ISProPriceLabel As System.Windows.Forms.Label
        Dim ISProQuantityLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.InStockProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InStockProductTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.InStockProductTableAdapter()
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.ISProIDTextBox = New System.Windows.Forms.TextBox()
        Me.ISProNameTextBox = New System.Windows.Forms.TextBox()
        Me.ISProTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ISProPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ISProQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.FQuantitybox = New System.Windows.Forms.TextBox()
        ISProIDLabel = New System.Windows.Forms.Label()
        ISProNameLabel = New System.Windows.Forms.Label()
        ISProTypeLabel = New System.Windows.Forms.Label()
        ISProPriceLabel = New System.Windows.Forms.Label()
        ISProQuantityLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InStockProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ISProIDLabel
        '
        ISProIDLabel.AutoSize = True
        ISProIDLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProIDLabel.Location = New System.Drawing.Point(223, 214)
        ISProIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ISProIDLabel.Name = "ISProIDLabel"
        ISProIDLabel.Size = New System.Drawing.Size(73, 16)
        ISProIDLabel.TabIndex = 5
        ISProIDLabel.Text = "หมายเลขสินค้า"
        '
        'ISProNameLabel
        '
        ISProNameLabel.AutoSize = True
        ISProNameLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProNameLabel.Location = New System.Drawing.Point(347, 214)
        ISProNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ISProNameLabel.Name = "ISProNameLabel"
        ISProNameLabel.Size = New System.Drawing.Size(44, 16)
        ISProNameLabel.TabIndex = 7
        ISProNameLabel.Text = "ชื่อสินค้า"
        '
        'ISProTypeLabel
        '
        ISProTypeLabel.AutoSize = True
        ISProTypeLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProTypeLabel.Location = New System.Drawing.Point(223, 278)
        ISProTypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ISProTypeLabel.Name = "ISProTypeLabel"
        ISProTypeLabel.Size = New System.Drawing.Size(66, 16)
        ISProTypeLabel.TabIndex = 9
        ISProTypeLabel.Text = "ประเภทสินค้า"
        '
        'ISProPriceLabel
        '
        ISProPriceLabel.AutoSize = True
        ISProPriceLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProPriceLabel.Location = New System.Drawing.Point(347, 278)
        ISProPriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ISProPriceLabel.Name = "ISProPriceLabel"
        ISProPriceLabel.Size = New System.Drawing.Size(30, 16)
        ISProPriceLabel.TabIndex = 11
        ISProPriceLabel.Text = "ราคา"
        '
        'ISProQuantityLabel
        '
        ISProQuantityLabel.AutoSize = True
        ISProQuantityLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProQuantityLabel.Location = New System.Drawing.Point(223, 350)
        ISProQuantityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ISProQuantityLabel.Name = "ISProQuantityLabel"
        ISProQuantityLabel.Size = New System.Drawing.Size(64, 16)
        ISProQuantityLabel.TabIndex = 13
        ISProQuantityLabel.Text = "จำนวนสต็อก"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(346, 350)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 16)
        Label1.TabIndex = 13
        Label1.Text = "จำนวนหน้าร้าน"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.เพิ่มสินค้าหัว_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(667, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 493)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 85)
        Me.Panel2.TabIndex = 5
        '
        'Back
        '
        Me.Back.Image = Global.CafeManager.My.Resources.Resources.BackButton_removebg_preview
        Me.Back.Location = New System.Drawing.Point(2, 20)
        Me.Back.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(83, 62)
        Me.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Back.TabIndex = 2
        Me.Back.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeManager.My.Resources.Resources.ConfirmButton_removebg_preview__1_
        Me.PictureBox2.Location = New System.Drawing.Point(283, 9)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'BalanceCafeData
        '
        Me.BalanceCafeData.DataSetName = "BalanceCafeData"
        Me.BalanceCafeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InStockProductBindingSource
        '
        Me.InStockProductBindingSource.DataMember = "InStockProduct"
        Me.InStockProductBindingSource.DataSource = Me.BalanceCafeData
        '
        'InStockProductTableAdapter
        '
        Me.InStockProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.FrontProductTableAdapter = Nothing
        Me.TableAdapterManager.InStockProductTableAdapter = Me.InStockProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkHistoryTableAdapter = Nothing
        '
        'ISProIDTextBox
        '
        Me.ISProIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProID", True))
        Me.ISProIDTextBox.Location = New System.Drawing.Point(226, 233)
        Me.ISProIDTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ISProIDTextBox.Name = "ISProIDTextBox"
        Me.ISProIDTextBox.Size = New System.Drawing.Size(84, 23)
        Me.ISProIDTextBox.TabIndex = 6
        '
        'ISProNameTextBox
        '
        Me.ISProNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProName", True))
        Me.ISProNameTextBox.Location = New System.Drawing.Point(349, 234)
        Me.ISProNameTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ISProNameTextBox.Name = "ISProNameTextBox"
        Me.ISProNameTextBox.Size = New System.Drawing.Size(126, 23)
        Me.ISProNameTextBox.TabIndex = 8
        '
        'ISProTypeTextBox
        '
        Me.ISProTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProType", True))
        Me.ISProTypeTextBox.Location = New System.Drawing.Point(226, 298)
        Me.ISProTypeTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ISProTypeTextBox.Name = "ISProTypeTextBox"
        Me.ISProTypeTextBox.Size = New System.Drawing.Size(84, 23)
        Me.ISProTypeTextBox.TabIndex = 10
        '
        'ISProPriceTextBox
        '
        Me.ISProPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProPrice", True))
        Me.ISProPriceTextBox.Location = New System.Drawing.Point(349, 298)
        Me.ISProPriceTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ISProPriceTextBox.Name = "ISProPriceTextBox"
        Me.ISProPriceTextBox.Size = New System.Drawing.Size(84, 23)
        Me.ISProPriceTextBox.TabIndex = 12
        '
        'ISProQuantityTextBox
        '
        Me.ISProQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProQuantity", True))
        Me.ISProQuantityTextBox.Location = New System.Drawing.Point(226, 369)
        Me.ISProQuantityTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ISProQuantityTextBox.Name = "ISProQuantityTextBox"
        Me.ISProQuantityTextBox.Size = New System.Drawing.Size(84, 23)
        Me.ISProQuantityTextBox.TabIndex = 14
        '
        'FQuantitybox
        '
        Me.FQuantitybox.Location = New System.Drawing.Point(349, 369)
        Me.FQuantitybox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.FQuantitybox.Name = "FQuantitybox"
        Me.FQuantitybox.Size = New System.Drawing.Size(84, 23)
        Me.FQuantitybox.TabIndex = 14
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(667, 578)
        Me.Controls.Add(ISProIDLabel)
        Me.Controls.Add(Me.ISProIDTextBox)
        Me.Controls.Add(ISProNameLabel)
        Me.Controls.Add(Me.ISProNameTextBox)
        Me.Controls.Add(ISProTypeLabel)
        Me.Controls.Add(Me.ISProTypeTextBox)
        Me.Controls.Add(ISProPriceLabel)
        Me.Controls.Add(Me.ISProPriceTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ISProQuantityLabel)
        Me.Controls.Add(Me.FQuantitybox)
        Me.Controls.Add(Me.ISProQuantityTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "AddProduct"
        Me.Text = "AddProduct"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InStockProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents InStockProductBindingSource As BindingSource
    Friend WithEvents InStockProductTableAdapter As BalanceCafeDataTableAdapters.InStockProductTableAdapter
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Public WithEvents PictureBox2 As PictureBox
    Public WithEvents ISProIDTextBox As TextBox
    Public WithEvents ISProNameTextBox As TextBox
    Public WithEvents ISProTypeTextBox As TextBox
    Public WithEvents ISProPriceTextBox As TextBox
    Public WithEvents ISProQuantityTextBox As TextBox
    Public WithEvents FQuantitybox As TextBox
End Class
