<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestockProduct
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
        Dim FProIDLabel As System.Windows.Forms.Label
        Dim FProNameLabel As System.Windows.Forms.Label
        Dim FProQuantityLabel As System.Windows.Forms.Label
        Dim ISProQuantityLabel As System.Windows.Forms.Label
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.FrontProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrontProductTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.FrontProductTableAdapter()
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.FrontProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FProIDTextBox = New System.Windows.Forms.TextBox()
        Me.FProNameTextBox = New System.Windows.Forms.TextBox()
        Me.FProQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.ReQuantity = New System.Windows.Forms.TextBox()
        Me.InStockProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InStockProductTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.InStockProductTableAdapter()
        Me.ISProQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FProIDLabel = New System.Windows.Forms.Label()
        FProNameLabel = New System.Windows.Forms.Label()
        FProQuantityLabel = New System.Windows.Forms.Label()
        ISProQuantityLabel = New System.Windows.Forms.Label()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InStockProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FProIDLabel
        '
        FProIDLabel.AutoSize = True
        FProIDLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        FProIDLabel.Location = New System.Drawing.Point(434, 155)
        FProIDLabel.Name = "FProIDLabel"
        FProIDLabel.Size = New System.Drawing.Size(73, 16)
        FProIDLabel.TabIndex = 3
        FProIDLabel.Text = "หมายเลขสินค้า"
        '
        'FProNameLabel
        '
        FProNameLabel.AutoSize = True
        FProNameLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        FProNameLabel.Location = New System.Drawing.Point(434, 181)
        FProNameLabel.Name = "FProNameLabel"
        FProNameLabel.Size = New System.Drawing.Size(44, 16)
        FProNameLabel.TabIndex = 5
        FProNameLabel.Text = "ชื่อสินค้า"
        '
        'FProQuantityLabel
        '
        FProQuantityLabel.AutoSize = True
        FProQuantityLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        FProQuantityLabel.Location = New System.Drawing.Point(434, 207)
        FProQuantityLabel.Name = "FProQuantityLabel"
        FProQuantityLabel.Size = New System.Drawing.Size(62, 16)
        FProQuantityLabel.TabIndex = 11
        FProQuantityLabel.Text = "ยอดคงเหลือ"
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
        Me.FrontProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5})
        Me.FrontProductDataGridView.DataSource = Me.FrontProductBindingSource
        Me.FrontProductDataGridView.Location = New System.Drawing.Point(83, 109)
        Me.FrontProductDataGridView.Name = "FrontProductDataGridView"
        Me.FrontProductDataGridView.Size = New System.Drawing.Size(340, 269)
        Me.FrontProductDataGridView.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.จำนวนสินค้าคงเหลือ_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(891, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 69)
        Me.Panel2.TabIndex = 3
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeManager.My.Resources.Resources.เพิ่มสินค้า_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(514, 258)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'FProIDTextBox
        '
        Me.FProIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrontProductBindingSource, "FProID", True))
        Me.FProIDTextBox.Location = New System.Drawing.Point(514, 152)
        Me.FProIDTextBox.Name = "FProIDTextBox"
        Me.FProIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FProIDTextBox.TabIndex = 4
        '
        'FProNameTextBox
        '
        Me.FProNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrontProductBindingSource, "FProName", True))
        Me.FProNameTextBox.Location = New System.Drawing.Point(514, 178)
        Me.FProNameTextBox.Name = "FProNameTextBox"
        Me.FProNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FProNameTextBox.TabIndex = 6
        '
        'FProQuantityTextBox
        '
        Me.FProQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrontProductBindingSource, "FProQuantity", True))
        Me.FProQuantityTextBox.Location = New System.Drawing.Point(514, 204)
        Me.FProQuantityTextBox.Name = "FProQuantityTextBox"
        Me.FProQuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FProQuantityTextBox.TabIndex = 12
        Me.FProQuantityTextBox.Text = " "
        '
        'Plus
        '
        Me.Plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus.Location = New System.Drawing.Point(591, 230)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(23, 23)
        Me.Plus.TabIndex = 13
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minus.Location = New System.Drawing.Point(514, 230)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(23, 23)
        Me.Minus.TabIndex = 13
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'ReQuantity
        '
        Me.ReQuantity.Location = New System.Drawing.Point(541, 232)
        Me.ReQuantity.Name = "ReQuantity"
        Me.ReQuantity.Size = New System.Drawing.Size(47, 20)
        Me.ReQuantity.TabIndex = 12
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
        'ISProQuantityLabel
        '
        ISProQuantityLabel.AutoSize = True
        ISProQuantityLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProQuantityLabel.Location = New System.Drawing.Point(726, 207)
        ISProQuantityLabel.Name = "ISProQuantityLabel"
        ISProQuantityLabel.Size = New System.Drawing.Size(74, 16)
        ISProQuantityLabel.TabIndex = 13
        ISProQuantityLabel.Text = "จำนวนในสต็อก"
        '
        'ISProQuantityTextBox
        '
        Me.ISProQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProQuantity", True))
        Me.ISProQuantityTextBox.Location = New System.Drawing.Point(620, 204)
        Me.ISProQuantityTextBox.Name = "ISProQuantityTextBox"
        Me.ISProQuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ISProQuantityTextBox.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FProID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "หมายเลขสินค้า"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FProName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ชื่อสินค้า"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FProQuantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ยอดตงเหลือ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'RestockProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(891, 464)
        Me.Controls.Add(ISProQuantityLabel)
        Me.Controls.Add(Me.ISProQuantityTextBox)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(FProIDLabel)
        Me.Controls.Add(Me.FProIDTextBox)
        Me.Controls.Add(FProNameLabel)
        Me.Controls.Add(Me.FProNameTextBox)
        Me.Controls.Add(FProQuantityLabel)
        Me.Controls.Add(Me.ReQuantity)
        Me.Controls.Add(Me.FProQuantityTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FrontProductDataGridView)
        Me.Name = "RestockProduct"
        Me.Text = "RestockProduct"
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InStockProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents FrontProductBindingSource As BindingSource
    Friend WithEvents FrontProductTableAdapter As BalanceCafeDataTableAdapters.FrontProductTableAdapter
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Friend WithEvents FrontProductDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FProIDTextBox As TextBox
    Friend WithEvents FProNameTextBox As TextBox
    Friend WithEvents FProQuantityTextBox As TextBox
    Friend WithEvents Plus As Button
    Friend WithEvents Minus As Button
    Friend WithEvents ReQuantity As TextBox
    Friend WithEvents InStockProductBindingSource As BindingSource
    Friend WithEvents InStockProductTableAdapter As BalanceCafeDataTableAdapters.InStockProductTableAdapter
    Friend WithEvents ISProQuantityTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
