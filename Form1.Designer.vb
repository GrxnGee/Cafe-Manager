<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.EmpPassBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpIDBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ConfirmButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WorkTimebox = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpPassBox
        '
        Me.EmpPassBox.Location = New System.Drawing.Point(98, 269)
        Me.EmpPassBox.Name = "EmpPassBox"
        Me.EmpPassBox.Size = New System.Drawing.Size(207, 20)
        Me.EmpPassBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("JasmineUPC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(133, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รหัสพนักงาน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("JasmineUPC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(146, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัสผ่าน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("JasmineUPC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(515, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "รูดบัตรพนักงาน"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(396, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 314)
        Me.Panel1.TabIndex = 4
        '
        'EmpIDBox
        '
        Me.EmpIDBox.FormattingEnabled = True
        Me.EmpIDBox.Location = New System.Drawing.Point(138, 201)
        Me.EmpIDBox.Name = "EmpIDBox"
        Me.EmpIDBox.Size = New System.Drawing.Size(121, 21)
        Me.EmpIDBox.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CafeManager.My.Resources.Resources.ลงชื่อเข้าใช้ระบบ_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Image = Global.CafeManager.My.Resources.Resources.ConfirmButton_removebg_preview__1_
        Me.ConfirmButton.Location = New System.Drawing.Point(135, 295)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(135, 45)
        Me.ConfirmButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ConfirmButton.TabIndex = 6
        Me.ConfirmButton.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeManager.My.Resources.Resources._4660062
        Me.PictureBox2.Location = New System.Drawing.Point(509, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(169, 196)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'WorkTimebox
        '
        Me.WorkTimebox.Location = New System.Drawing.Point(304, 430)
        Me.WorkTimebox.Name = "WorkTimebox"
        Me.WorkTimebox.Size = New System.Drawing.Size(200, 20)
        Me.WorkTimebox.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WorkTimebox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmpIDBox)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmpPassBox)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WorkTimebox As DateTimePicker
    Public WithEvents EmpPassBox As TextBox
    Public WithEvents EmpIDBox As ComboBox
    Public WithEvents ConfirmButton As PictureBox
End Class
