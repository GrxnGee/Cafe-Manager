<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEmployee
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
        Dim EmpIDLabel As System.Windows.Forms.Label
        Dim EmpNameLabel As System.Windows.Forms.Label
        Dim EmpAddressLabel As System.Windows.Forms.Label
        Dim EmpWorkDateLabel As System.Windows.Forms.Label
        Dim EmpPositionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DeleteBut = New System.Windows.Forms.PictureBox()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BalanceCafeData = New CafeManager.BalanceCafeData()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New CafeManager.BalanceCafeDataTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager()
        Me.EmpNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmpAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmpWorkDateTextBox = New System.Windows.Forms.TextBox()
        Me.EmpPositionTextBox = New System.Windows.Forms.TextBox()
        Me.EmpIDbox = New System.Windows.Forms.ComboBox()
        Me.Choose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        EmpIDLabel = New System.Windows.Forms.Label()
        EmpNameLabel = New System.Windows.Forms.Label()
        EmpAddressLabel = New System.Windows.Forms.Label()
        EmpWorkDateLabel = New System.Windows.Forms.Label()
        EmpPositionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DeleteBut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpIDLabel
        '
        EmpIDLabel.AutoSize = True
        EmpIDLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpIDLabel.Location = New System.Drawing.Point(138, 204)
        EmpIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmpIDLabel.Name = "EmpIDLabel"
        EmpIDLabel.Size = New System.Drawing.Size(88, 16)
        EmpIDLabel.TabIndex = 4
        EmpIDLabel.Text = "เลือกรหัสพนักงาน"
        '
        'EmpNameLabel
        '
        EmpNameLabel.AutoSize = True
        EmpNameLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpNameLabel.Location = New System.Drawing.Point(287, 232)
        EmpNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmpNameLabel.Name = "EmpNameLabel"
        EmpNameLabel.Size = New System.Drawing.Size(59, 16)
        EmpNameLabel.TabIndex = 6
        EmpNameLabel.Text = "ชื่อพนักงาน"
        '
        'EmpAddressLabel
        '
        EmpAddressLabel.AutoSize = True
        EmpAddressLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpAddressLabel.Location = New System.Drawing.Point(287, 264)
        EmpAddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmpAddressLabel.Name = "EmpAddressLabel"
        EmpAddressLabel.Size = New System.Drawing.Size(27, 16)
        EmpAddressLabel.TabIndex = 8
        EmpAddressLabel.Text = "ที่อยู่"
        '
        'EmpWorkDateLabel
        '
        EmpWorkDateLabel.AutoSize = True
        EmpWorkDateLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpWorkDateLabel.Location = New System.Drawing.Point(287, 296)
        EmpWorkDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmpWorkDateLabel.Name = "EmpWorkDateLabel"
        EmpWorkDateLabel.Size = New System.Drawing.Size(50, 16)
        EmpWorkDateLabel.TabIndex = 10
        EmpWorkDateLabel.Text = "วันทำงาน"
        '
        'EmpPositionLabel
        '
        EmpPositionLabel.AutoSize = True
        EmpPositionLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpPositionLabel.Location = New System.Drawing.Point(287, 328)
        EmpPositionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmpPositionLabel.Name = "EmpPositionLabel"
        EmpPositionLabel.Size = New System.Drawing.Size(44, 16)
        EmpPositionLabel.TabIndex = 12
        EmpPositionLabel.Text = "ตำแหน่ง"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(112, 260)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(143, 16)
        Label1.TabIndex = 4
        Label1.Text = "*ไม่สามารถแก้ไขรหัสพนักงาน*"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DeleteBut)
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 469)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 85)
        Me.Panel2.TabIndex = 3
        '
        'DeleteBut
        '
        Me.DeleteBut.ErrorImage = Global.CafeManager.My.Resources.Resources.DeleteButtonPNG_removebg_preview
        Me.DeleteBut.Image = Global.CafeManager.My.Resources.Resources.DeleteEmpButton_removebg_preview
        Me.DeleteBut.Location = New System.Drawing.Point(335, 19)
        Me.DeleteBut.Name = "DeleteBut"
        Me.DeleteBut.Size = New System.Drawing.Size(100, 50)
        Me.DeleteBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DeleteBut.TabIndex = 3
        Me.DeleteBut.TabStop = False
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
        Me.PictureBox2.Location = New System.Drawing.Point(249, 14)
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
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.BalanceCafeData
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.FrontProductTableAdapter = Nothing
        Me.TableAdapterManager.InStockProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CafeManager.BalanceCafeDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkHistoryTableAdapter = Nothing
        '
        'EmpNameTextBox
        '
        Me.EmpNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmpName", True))
        Me.EmpNameTextBox.Location = New System.Drawing.Point(350, 229)
        Me.EmpNameTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.EmpNameTextBox.Name = "EmpNameTextBox"
        Me.EmpNameTextBox.Size = New System.Drawing.Size(84, 23)
        Me.EmpNameTextBox.TabIndex = 7
        '
        'EmpAddressTextBox
        '
        Me.EmpAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmpAddress", True))
        Me.EmpAddressTextBox.Location = New System.Drawing.Point(350, 261)
        Me.EmpAddressTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.EmpAddressTextBox.Name = "EmpAddressTextBox"
        Me.EmpAddressTextBox.Size = New System.Drawing.Size(222, 23)
        Me.EmpAddressTextBox.TabIndex = 9
        '
        'EmpWorkDateTextBox
        '
        Me.EmpWorkDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmpWorkDate", True))
        Me.EmpWorkDateTextBox.Location = New System.Drawing.Point(350, 293)
        Me.EmpWorkDateTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.EmpWorkDateTextBox.Name = "EmpWorkDateTextBox"
        Me.EmpWorkDateTextBox.Size = New System.Drawing.Size(84, 23)
        Me.EmpWorkDateTextBox.TabIndex = 11
        '
        'EmpPositionTextBox
        '
        Me.EmpPositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmpPosition", True))
        Me.EmpPositionTextBox.Location = New System.Drawing.Point(350, 325)
        Me.EmpPositionTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.EmpPositionTextBox.Name = "EmpPositionTextBox"
        Me.EmpPositionTextBox.Size = New System.Drawing.Size(84, 23)
        Me.EmpPositionTextBox.TabIndex = 13
        '
        'EmpIDbox
        '
        Me.EmpIDbox.FormattingEnabled = True
        Me.EmpIDbox.Location = New System.Drawing.Point(122, 227)
        Me.EmpIDbox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.EmpIDbox.Name = "EmpIDbox"
        Me.EmpIDbox.Size = New System.Drawing.Size(102, 24)
        Me.EmpIDbox.TabIndex = 14
        '
        'Choose
        '
        Me.Choose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Choose.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Choose.Location = New System.Drawing.Point(227, 226)
        Me.Choose.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Choose.Name = "Choose"
        Me.Choose.Size = New System.Drawing.Size(42, 28)
        Me.Choose.TabIndex = 15
        Me.Choose.Text = "เลือก"
        Me.Choose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.แก้ไขข้อมูลพนักงานหัว_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(667, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'EditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(667, 554)
        Me.Controls.Add(Me.Choose)
        Me.Controls.Add(Me.EmpIDbox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(EmpIDLabel)
        Me.Controls.Add(EmpNameLabel)
        Me.Controls.Add(Me.EmpNameTextBox)
        Me.Controls.Add(EmpAddressLabel)
        Me.Controls.Add(Me.EmpAddressTextBox)
        Me.Controls.Add(EmpWorkDateLabel)
        Me.Controls.Add(Me.EmpWorkDateTextBox)
        Me.Controls.Add(EmpPositionLabel)
        Me.Controls.Add(Me.EmpPositionTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "EditEmployee"
        Me.Text = "EditEmployee"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DeleteBut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceCafeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Friend WithEvents BalanceCafeData As BalanceCafeData
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As BalanceCafeDataTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As BalanceCafeDataTableAdapters.TableAdapterManager
    Friend WithEvents Choose As Button
    Public WithEvents PictureBox2 As PictureBox
    Public WithEvents EmpNameTextBox As TextBox
    Public WithEvents EmpAddressTextBox As TextBox
    Public WithEvents EmpWorkDateTextBox As TextBox
    Public WithEvents EmpPositionTextBox As TextBox
    Public WithEvents EmpIDbox As ComboBox
    Public WithEvents DeleteBut As PictureBox
End Class
