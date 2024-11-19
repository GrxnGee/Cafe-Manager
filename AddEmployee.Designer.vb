<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Dim EmpNameLabel As System.Windows.Forms.Label
        Dim EmpAddressLabel As System.Windows.Forms.Label
        Dim EmpWorkDateLabel As System.Windows.Forms.Label
        Dim EmpPositionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PositionBox = New System.Windows.Forms.ComboBox()
        Me.EmpNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmpAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmpWorkDateTextBox = New System.Windows.Forms.TextBox()
        Me.EmpIDbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        EmpNameLabel = New System.Windows.Forms.Label()
        EmpAddressLabel = New System.Windows.Forms.Label()
        EmpWorkDateLabel = New System.Windows.Forms.Label()
        EmpPositionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpNameLabel
        '
        EmpNameLabel.AutoSize = True
        EmpNameLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpNameLabel.Location = New System.Drawing.Point(386, 157)
        EmpNameLabel.Name = "EmpNameLabel"
        EmpNameLabel.Size = New System.Drawing.Size(62, 16)
        EmpNameLabel.TabIndex = 18
        EmpNameLabel.Text = "ชื่อ-นามสกุล"
        '
        'EmpAddressLabel
        '
        EmpAddressLabel.AutoSize = True
        EmpAddressLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpAddressLabel.Location = New System.Drawing.Point(274, 212)
        EmpAddressLabel.Name = "EmpAddressLabel"
        EmpAddressLabel.Size = New System.Drawing.Size(27, 16)
        EmpAddressLabel.TabIndex = 20
        EmpAddressLabel.Text = "ที่อยู่"
        '
        'EmpWorkDateLabel
        '
        EmpWorkDateLabel.AutoSize = True
        EmpWorkDateLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpWorkDateLabel.Location = New System.Drawing.Point(274, 260)
        EmpWorkDateLabel.Name = "EmpWorkDateLabel"
        EmpWorkDateLabel.Size = New System.Drawing.Size(71, 16)
        EmpWorkDateLabel.TabIndex = 22
        EmpWorkDateLabel.Text = "วันที่เข้าทำงาน"
        '
        'EmpPositionLabel
        '
        EmpPositionLabel.AutoSize = True
        EmpPositionLabel.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EmpPositionLabel.Location = New System.Drawing.Point(386, 260)
        EmpPositionLabel.Name = "EmpPositionLabel"
        EmpPositionLabel.Size = New System.Drawing.Size(44, 16)
        EmpPositionLabel.TabIndex = 24
        EmpPositionLabel.Text = "ตำแหน่ง"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("JasmineUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(274, 157)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 16)
        Label1.TabIndex = 18
        Label1.Text = "รหัสพนักงาน"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Back)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 69)
        Me.Panel2.TabIndex = 4
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeManager.My.Resources.Resources.ConfirmButton_removebg_preview__1_
        Me.PictureBox2.Location = New System.Drawing.Point(348, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PositionBox
        '
        Me.PositionBox.FormattingEnabled = True
        Me.PositionBox.Location = New System.Drawing.Point(389, 276)
        Me.PositionBox.Name = "PositionBox"
        Me.PositionBox.Size = New System.Drawing.Size(100, 21)
        Me.PositionBox.TabIndex = 26
        '
        'EmpNameTextBox
        '
        Me.EmpNameTextBox.Location = New System.Drawing.Point(389, 173)
        Me.EmpNameTextBox.Name = "EmpNameTextBox"
        Me.EmpNameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.EmpNameTextBox.TabIndex = 19
        '
        'EmpAddressTextBox
        '
        Me.EmpAddressTextBox.Location = New System.Drawing.Point(277, 228)
        Me.EmpAddressTextBox.Name = "EmpAddressTextBox"
        Me.EmpAddressTextBox.Size = New System.Drawing.Size(266, 20)
        Me.EmpAddressTextBox.TabIndex = 21
        '
        'EmpWorkDateTextBox
        '
        Me.EmpWorkDateTextBox.Location = New System.Drawing.Point(277, 276)
        Me.EmpWorkDateTextBox.Name = "EmpWorkDateTextBox"
        Me.EmpWorkDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmpWorkDateTextBox.TabIndex = 23
        '
        'EmpIDbox
        '
        Me.EmpIDbox.Location = New System.Drawing.Point(277, 173)
        Me.EmpIDbox.Name = "EmpIDbox"
        Me.EmpIDbox.Size = New System.Drawing.Size(100, 20)
        Me.EmpIDbox.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.เพิ่มพนักงานหัว_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PositionBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(EmpNameLabel)
        Me.Controls.Add(Me.EmpIDbox)
        Me.Controls.Add(Me.EmpNameTextBox)
        Me.Controls.Add(EmpAddressLabel)
        Me.Controls.Add(Me.EmpAddressTextBox)
        Me.Controls.Add(EmpWorkDateLabel)
        Me.Controls.Add(Me.EmpWorkDateTextBox)
        Me.Controls.Add(EmpPositionLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AddEmployee"
        Me.Text = "AddEmployee"
        Me.Panel2.ResumeLayout(False)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Back As PictureBox
    Public WithEvents EmpNameTextBox As TextBox
    Public WithEvents EmpAddressTextBox As TextBox
    Public WithEvents EmpWorkDateTextBox As TextBox
    Public WithEvents EmpIDbox As TextBox
    Public WithEvents PictureBox2 As PictureBox
    Public WithEvents PositionBox As ComboBox
End Class
