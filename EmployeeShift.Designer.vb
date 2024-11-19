<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeShift
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.WorkHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.WorkHistoryTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.WorkHistoryTableAdapter()
        Me.WorkHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 453)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 69)
        Me.Panel2.TabIndex = 3
        '
        'Back
        '
        Me.Back.Image = Global.CafeManager.My.Resources.Resources.BackButton_removebg_preview
        Me.Back.Location = New System.Drawing.Point(3, 16)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 50)
        Me.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Back.TabIndex = 2
        Me.Back.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.การเข้าทำงาน_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BalanceCafeData
        '
        Me.BalanceCafeData.DataSetName = "BalanceCafeData"
        Me.BalanceCafeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkHistoryBindingSource
        '
        Me.WorkHistoryBindingSource.DataMember = "WorkHistory"
        Me.WorkHistoryBindingSource.DataSource = Me.BalanceCafeData
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.FrontProductTableAdapter = Nothing
        Me.TableAdapterManager.InStockProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkHistoryTableAdapter = Nothing
        '
        'WorkHistoryTableAdapter
        '
        Me.WorkHistoryTableAdapter.ClearBeforeFill = True
        '
        'WorkHistoryDataGridView
        '
        Me.WorkHistoryDataGridView.AutoGenerateColumns = False
        Me.WorkHistoryDataGridView.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.WorkHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.WorkHistoryDataGridView.DataSource = Me.WorkHistoryBindingSource
        Me.WorkHistoryDataGridView.Location = New System.Drawing.Point(235, 109)
        Me.WorkHistoryDataGridView.Name = "WorkHistoryDataGridView"
        Me.WorkHistoryDataGridView.Size = New System.Drawing.Size(345, 338)
        Me.WorkHistoryDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "รหัสพนักงาน"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WhDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "วันที่"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "WhStatus"
        Me.DataGridViewTextBoxColumn3.HeaderText = "สถานะ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'EmployeeShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.WorkHistoryDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EmployeeShift"
        Me.Text = "EmployeeShift"
        Me.Panel2.ResumeLayout(False)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents WorkHistoryBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Friend WithEvents WorkHistoryTableAdapter As BalanceCafeDataTableAdapters.WorkHistoryTableAdapter
    Friend WithEvents WorkHistoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
