<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoardScreen
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.BillTableAdapter()
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.BillDataGridView = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.BillIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FProNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FProPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BalanceCafeData
        '
        Me.BalanceCafeData.DataSetName = "BalanceCafeData"
        Me.BalanceCafeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "Bill"
        Me.BillBindingSource.DataSource = Me.BalanceCafeData
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Me.BillTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.FrontProductTableAdapter = Nothing
        Me.TableAdapterManager.InStockProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkHistoryTableAdapter = Nothing
        '
        'BillDataGridView
        '
        Me.BillDataGridView.AllowUserToOrderColumns = True
        Me.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillIDDataGridViewTextBoxColumn, Me.FProNameDataGridViewTextBoxColumn, Me.FProPriceDataGridViewTextBoxColumn, Me.BuyQuantityDataGridViewTextBoxColumn})
        Me.BillDataGridView.Location = New System.Drawing.Point(193, 58)
        Me.BillDataGridView.Name = "BillDataGridView"
        Me.BillDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.BillDataGridView.TabIndex = 1
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(175, 284)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "BuyBH"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(479, 300)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(314, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 590)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 58)
        Me.Panel2.TabIndex = 5
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
        'BillIDDataGridViewTextBoxColumn
        '
        Me.BillIDDataGridViewTextBoxColumn.HeaderText = "หมายเลขบิล"
        Me.BillIDDataGridViewTextBoxColumn.Name = "BillIDDataGridViewTextBoxColumn"
        '
        'FProNameDataGridViewTextBoxColumn
        '
        Me.FProNameDataGridViewTextBoxColumn.HeaderText = "ชื่อสินค้า"
        Me.FProNameDataGridViewTextBoxColumn.Name = "FProNameDataGridViewTextBoxColumn"
        '
        'FProPriceDataGridViewTextBoxColumn
        '
        Me.FProPriceDataGridViewTextBoxColumn.HeaderText = "ราคา"
        Me.FProPriceDataGridViewTextBoxColumn.Name = "FProPriceDataGridViewTextBoxColumn"
        '
        'BuyQuantityDataGridViewTextBoxColumn
        '
        Me.BuyQuantityDataGridViewTextBoxColumn.HeaderText = "จำนวนที่ซื้อ"
        Me.BuyQuantityDataGridViewTextBoxColumn.Name = "BuyQuantityDataGridViewTextBoxColumn"
        '
        'DashBoardScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(831, 648)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.BillDataGridView)
        Me.Name = "DashBoardScreen"
        Me.Text = "DashBoardScreen"
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents BillBindingSource As BindingSource
    Friend WithEvents BillTableAdapter As BalanceCafeDataTableAdapters.BillTableAdapter
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Friend WithEvents BillDataGridView As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Friend WithEvents BillIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FProNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FProPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
