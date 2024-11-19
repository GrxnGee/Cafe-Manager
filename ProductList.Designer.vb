<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductList
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.FrontProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrontProductTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.FrontProductTableAdapter()
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.FrontProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.จำนวนสินค้าคงเหลือ_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 411)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 69)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CafeManager.My.Resources.Resources.เพิ่มสินค้า_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(350, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
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
        Me.PictureBox2.Location = New System.Drawing.Point(348, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
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
        Me.FrontProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FrontProductDataGridView.DataSource = Me.FrontProductBindingSource
        Me.FrontProductDataGridView.Location = New System.Drawing.Point(130, 106)
        Me.FrontProductDataGridView.Name = "FrontProductDataGridView"
        Me.FrontProductDataGridView.Size = New System.Drawing.Size(542, 299)
        Me.FrontProductDataGridView.TabIndex = 3
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FProType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ประเภทสินค้า"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        'ProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.FrontProductDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProductList"
        Me.Text = "ProductList"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents FrontProductBindingSource As BindingSource
    Friend WithEvents FrontProductTableAdapter As BalanceCafeDataTableAdapters.FrontProductTableAdapter
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Friend WithEvents FrontProductDataGridView As DataGridView
    Friend WithEvents Back As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
End Class
