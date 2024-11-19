<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProduct
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
        Dim Label1 As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.InStockProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InStockProductTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.InStockProductTableAdapter()
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.ISProNameTextBox = New System.Windows.Forms.TextBox()
        Me.ISProTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ISProPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DeleteBut = New System.Windows.Forms.PictureBox()
        ISProIDLabel = New System.Windows.Forms.Label()
        ISProNameLabel = New System.Windows.Forms.Label()
        ISProTypeLabel = New System.Windows.Forms.Label()
        ISProPriceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InStockProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeleteBut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ISProIDLabel
        '
        ISProIDLabel.AutoSize = True
        ISProIDLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProIDLabel.Location = New System.Drawing.Point(255, 159)
        ISProIDLabel.Name = "ISProIDLabel"
        ISProIDLabel.Size = New System.Drawing.Size(73, 16)
        ISProIDLabel.TabIndex = 4
        ISProIDLabel.Text = "หมายเลขสินค้า"
        '
        'ISProNameLabel
        '
        ISProNameLabel.AutoSize = True
        ISProNameLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProNameLabel.Location = New System.Drawing.Point(418, 160)
        ISProNameLabel.Name = "ISProNameLabel"
        ISProNameLabel.Size = New System.Drawing.Size(44, 16)
        ISProNameLabel.TabIndex = 6
        ISProNameLabel.Text = "ชื่อสินค้า"
        '
        'ISProTypeLabel
        '
        ISProTypeLabel.AutoSize = True
        ISProTypeLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProTypeLabel.Location = New System.Drawing.Point(255, 235)
        ISProTypeLabel.Name = "ISProTypeLabel"
        ISProTypeLabel.Size = New System.Drawing.Size(66, 16)
        ISProTypeLabel.TabIndex = 8
        ISProTypeLabel.Text = "ประเภทสินค้า"
        '
        'ISProPriceLabel
        '
        ISProPriceLabel.AutoSize = True
        ISProPriceLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ISProPriceLabel.Location = New System.Drawing.Point(418, 231)
        ISProPriceLabel.Name = "ISProPriceLabel"
        ISProPriceLabel.Size = New System.Drawing.Size(30, 16)
        ISProPriceLabel.TabIndex = 10
        ISProPriceLabel.Text = "ราคา"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(241, 199)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(150, 16)
        Label1.TabIndex = 13
        Label1.Text = "*ไม่สามารถแก้ไขหมายเลขสินค้า*"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 69)
        Me.Panel2.TabIndex = 2
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
        'ISProNameTextBox
        '
        Me.ISProNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProName", True))
        Me.ISProNameTextBox.Location = New System.Drawing.Point(421, 176)
        Me.ISProNameTextBox.Name = "ISProNameTextBox"
        Me.ISProNameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ISProNameTextBox.TabIndex = 7
        '
        'ISProTypeTextBox
        '
        Me.ISProTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProType", True))
        Me.ISProTypeTextBox.Location = New System.Drawing.Point(258, 251)
        Me.ISProTypeTextBox.Name = "ISProTypeTextBox"
        Me.ISProTypeTextBox.Size = New System.Drawing.Size(118, 20)
        Me.ISProTypeTextBox.TabIndex = 9
        '
        'ISProPriceTextBox
        '
        Me.ISProPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InStockProductBindingSource, "ISProPrice", True))
        Me.ISProPriceTextBox.Location = New System.Drawing.Point(421, 251)
        Me.ISProPriceTextBox.Name = "ISProPriceTextBox"
        Me.ISProPriceTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ISProPriceTextBox.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(258, 175)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeManager.My.Resources.Resources.ConfirmButton_removebg_preview__1_
        Me.PictureBox2.Location = New System.Drawing.Point(276, 311)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.ErrorImage = Global.CafeManager.My.Resources.Resources.แก้ไขข้อมูลสินค้าหัว_removebg_preview1
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.แก้ไขข้อมูลสินค้าหัว_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'DeleteBut
        '
        Me.DeleteBut.ErrorImage = Global.CafeManager.My.Resources.Resources.DeleteButtonPNG_removebg_preview
        Me.DeleteBut.Image = Global.CafeManager.My.Resources.Resources.DeleteButtonPNG_removebg_preview
        Me.DeleteBut.Location = New System.Drawing.Point(395, 311)
        Me.DeleteBut.Name = "DeleteBut"
        Me.DeleteBut.Size = New System.Drawing.Size(100, 50)
        Me.DeleteBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DeleteBut.TabIndex = 0
        Me.DeleteBut.TabStop = False
        '
        'EditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(ISProIDLabel)
        Me.Controls.Add(Me.DeleteBut)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(ISProNameLabel)
        Me.Controls.Add(Me.ISProNameTextBox)
        Me.Controls.Add(ISProTypeLabel)
        Me.Controls.Add(Me.ISProTypeTextBox)
        Me.Controls.Add(ISProPriceLabel)
        Me.Controls.Add(Me.ISProPriceTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "EditProduct"
        Me.Text = "EditProduct"
        Me.Panel2.ResumeLayout(False)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InStockProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeleteBut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents InStockProductBindingSource As BindingSource
    Friend WithEvents InStockProductTableAdapter As BalanceCafeDataTableAdapters.InStockProductTableAdapter
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Public WithEvents PictureBox2 As PictureBox
    Public WithEvents ISProNameTextBox As TextBox
    Public WithEvents ISProTypeTextBox As TextBox
    Public WithEvents ISProPriceTextBox As TextBox
    Public WithEvents ComboBox1 As ComboBox
    Public WithEvents DeleteBut As PictureBox
End Class
