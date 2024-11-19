<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBills
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
        Dim FProNameLabel As System.Windows.Forms.Label
        Dim FProPriceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim FProQuantityLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.CheckBillButton = New System.Windows.Forms.PictureBox()
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.FrontProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrontProductTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.FrontProductTableAdapter()
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.FrontProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.FProNameTextBox = New System.Windows.Forms.TextBox()
        Me.FProPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Minus = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Plus = New System.Windows.Forms.Button()
        Me.ReQuantity = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CurrentDate = New System.Windows.Forms.DateTimePicker()
        Me.TotalPrice = New System.Windows.Forms.TextBox()
        Me.BillNum = New System.Windows.Forms.TextBox()
        Me.FProQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FProNameLabel = New System.Windows.Forms.Label()
        FProPriceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        FProQuantityLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBillButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FProNameLabel
        '
        FProNameLabel.AutoSize = True
        FProNameLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        FProNameLabel.Location = New System.Drawing.Point(430, 139)
        FProNameLabel.Name = "FProNameLabel"
        FProNameLabel.Size = New System.Drawing.Size(44, 16)
        FProNameLabel.TabIndex = 7
        FProNameLabel.Text = "ชื่อสินค้า"
        '
        'FProPriceLabel
        '
        FProPriceLabel.AutoSize = True
        FProPriceLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        FProPriceLabel.Location = New System.Drawing.Point(366, 184)
        FProPriceLabel.Name = "FProPriceLabel"
        FProPriceLabel.Size = New System.Drawing.Size(30, 16)
        FProPriceLabel.TabIndex = 11
        FProPriceLabel.Text = "ราคา"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(707, 361)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 16)
        Label1.TabIndex = 11
        Label1.Text = "ราคารวม"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label2.Location = New System.Drawing.Point(629, 360)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 16)
        Label2.TabIndex = 7
        Label2.Text = "เลขบิล"
        '
        'FProQuantityLabel
        '
        FProQuantityLabel.AutoSize = True
        FProQuantityLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        FProQuantityLabel.Location = New System.Drawing.Point(517, 191)
        FProQuantityLabel.Name = "FProQuantityLabel"
        FProQuantityLabel.Size = New System.Drawing.Size(62, 16)
        FProQuantityLabel.TabIndex = 26
        FProQuantityLabel.Text = "ยอดคงเหลือ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.จำนวนสินค้าคงเหลือ_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(808, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Controls.Add(Me.CheckBillButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 397)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 69)
        Me.Panel2.TabIndex = 4
        '
        'Back
        '
        Me.Back.Image = Global.CafeManager.My.Resources.Resources.BackButton_removebg_preview
        Me.Back.Location = New System.Drawing.Point(3, 16)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 50)
        Me.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Back.TabIndex = 0
        Me.Back.TabStop = False
        '
        'CheckBillButton
        '
        Me.CheckBillButton.Image = Global.CafeManager.My.Resources.Resources.เช็คบิล_removebg_preview
        Me.CheckBillButton.Location = New System.Drawing.Point(650, 3)
        Me.CheckBillButton.Name = "CheckBillButton"
        Me.CheckBillButton.Size = New System.Drawing.Size(100, 50)
        Me.CheckBillButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CheckBillButton.TabIndex = 15
        Me.CheckBillButton.TabStop = False
        '
        'BalanceCafeData
        '
        Me.BalanceCafeData.DataSetName = "BalanceCafeData"
        Me.BalanceCafeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrontProductBindingSource
        '
        Me.FrontProductBindingSource.DataMember = "FrontProduct"
        Me.FrontProductBindingSource.DataSource = Me.BalanceCafeData
        '
        'FrontProductTableAdapter
        '
        Me.FrontProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.FrontProductTableAdapter = Me.FrontProductTableAdapter
        Me.TableAdapterManager.InStockProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkHistoryTableAdapter = Nothing
        '
        'FrontProductDataGridView
        '
        Me.FrontProductDataGridView.AutoGenerateColumns = False
        Me.FrontProductDataGridView.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.FrontProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FrontProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FrontProductDataGridView.DataSource = Me.FrontProductBindingSource
        Me.FrontProductDataGridView.Location = New System.Drawing.Point(0, 106)
        Me.FrontProductDataGridView.Name = "FrontProductDataGridView"
        Me.FrontProductDataGridView.Size = New System.Drawing.Size(344, 269)
        Me.FrontProductDataGridView.TabIndex = 5
        '
        'FProNameTextBox
        '
        Me.FProNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrontProductBindingSource, "FProName", True))
        Me.FProNameTextBox.Location = New System.Drawing.Point(402, 155)
        Me.FProNameTextBox.Name = "FProNameTextBox"
        Me.FProNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FProNameTextBox.TabIndex = 8
        '
        'FProPriceTextBox
        '
        Me.FProPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrontProductBindingSource, "FProPrice", True))
        Me.FProPriceTextBox.Location = New System.Drawing.Point(402, 181)
        Me.FProPriceTextBox.Name = "FProPriceTextBox"
        Me.FProPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FProPriceTextBox.TabIndex = 12
        '
        'Minus
        '
        Me.Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minus.Location = New System.Drawing.Point(402, 207)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(23, 23)
        Me.Minus.TabIndex = 17
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeManager.My.Resources.Resources.เพิ่มสินค้า_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(402, 235)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Plus
        '
        Me.Plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus.Location = New System.Drawing.Point(479, 207)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(23, 23)
        Me.Plus.TabIndex = 18
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'ReQuantity
        '
        Me.ReQuantity.Location = New System.Drawing.Point(429, 209)
        Me.ReQuantity.Name = "ReQuantity"
        Me.ReQuantity.Size = New System.Drawing.Size(47, 20)
        Me.ReQuantity.TabIndex = 16
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(607, 124)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(181, 209)
        Me.RichTextBox1.TabIndex = 25
        Me.RichTextBox1.Text = ""
        '
        'CurrentDate
        '
        Me.CurrentDate.Location = New System.Drawing.Point(607, 313)
        Me.CurrentDate.Name = "CurrentDate"
        Me.CurrentDate.Size = New System.Drawing.Size(181, 20)
        Me.CurrentDate.TabIndex = 20
        '
        'TotalPrice
        '
        Me.TotalPrice.Location = New System.Drawing.Point(682, 338)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(100, 20)
        Me.TotalPrice.TabIndex = 12
        Me.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BillNum
        '
        Me.BillNum.Location = New System.Drawing.Point(616, 338)
        Me.BillNum.Name = "BillNum"
        Me.BillNum.Size = New System.Drawing.Size(60, 20)
        Me.BillNum.TabIndex = 26
        '
        'FProQuantityTextBox
        '
        Me.FProQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrontProductBindingSource, "FProQuantity", True))
        Me.FProQuantityTextBox.Location = New System.Drawing.Point(524, 210)
        Me.FProQuantityTextBox.Name = "FProQuantityTextBox"
        Me.FProQuantityTextBox.Size = New System.Drawing.Size(45, 20)
        Me.FProQuantityTextBox.TabIndex = 27
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FProName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ชื่อสินค้า"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FProPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ราคา"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FProQuantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ยอดคงเหลือ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'CheckBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(808, 466)
        Me.Controls.Add(FProQuantityLabel)
        Me.Controls.Add(Me.FProQuantityTextBox)
        Me.Controls.Add(Me.BillNum)
        Me.Controls.Add(Me.CurrentDate)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.ReQuantity)
        Me.Controls.Add(Label2)
        Me.Controls.Add(FProNameLabel)
        Me.Controls.Add(Me.FProNameTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(FProPriceLabel)
        Me.Controls.Add(Me.TotalPrice)
        Me.Controls.Add(Me.FProPriceTextBox)
        Me.Controls.Add(Me.FrontProductDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CheckBills"
        Me.Text = "CheckBills"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBillButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents FrontProductBindingSource As BindingSource
    Friend WithEvents FrontProductTableAdapter As BalanceCafeDataTableAdapters.FrontProductTableAdapter
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Friend WithEvents FrontProductDataGridView As DataGridView
    Friend WithEvents FProNameTextBox As TextBox
    Friend WithEvents FProPriceTextBox As TextBox
    Friend WithEvents Minus As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Plus As Button
    Friend WithEvents ReQuantity As TextBox
    Friend WithEvents CheckBillButton As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CurrentDate As DateTimePicker
    Friend WithEvents TotalPrice As TextBox
    Friend WithEvents BillNum As TextBox
    Friend WithEvents FProQuantityTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
