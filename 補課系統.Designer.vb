<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 補課系統
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(補課系統))
        Me.報表 = New System.Windows.Forms.Button()
        Me.補課 = New System.Windows.Forms.Button()
        Me.成績 = New System.Windows.Forms.Button()
        Me.出缺勤 = New System.Windows.Forms.Button()
        Me.課程管理 = New System.Windows.Forms.Button()
        Me.繳費 = New System.Windows.Forms.Button()
        Me.學生管理 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '報表
        '
        Me.報表.BackgroundImage = CType(resources.GetObject("報表.BackgroundImage"), System.Drawing.Image)
        Me.報表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.報表.Location = New System.Drawing.Point(1740, -1)
        Me.報表.Name = "報表"
        Me.報表.Size = New System.Drawing.Size(271, 134)
        Me.報表.TabIndex = 11
        Me.報表.UseVisualStyleBackColor = True
        '
        '補課
        '
        Me.補課.BackgroundImage = CType(resources.GetObject("補課.BackgroundImage"), System.Drawing.Image)
        Me.補課.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.補課.Location = New System.Drawing.Point(1468, -1)
        Me.補課.Name = "補課"
        Me.補課.Size = New System.Drawing.Size(266, 134)
        Me.補課.TabIndex = 10
        Me.補課.UseVisualStyleBackColor = True
        '
        '成績
        '
        Me.成績.BackgroundImage = CType(resources.GetObject("成績.BackgroundImage"), System.Drawing.Image)
        Me.成績.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.成績.Location = New System.Drawing.Point(1184, -1)
        Me.成績.Name = "成績"
        Me.成績.Size = New System.Drawing.Size(278, 134)
        Me.成績.TabIndex = 9
        Me.成績.UseVisualStyleBackColor = True
        '
        '出缺勤
        '
        Me.出缺勤.BackgroundImage = CType(resources.GetObject("出缺勤.BackgroundImage"), System.Drawing.Image)
        Me.出缺勤.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.出缺勤.Location = New System.Drawing.Point(895, -1)
        Me.出缺勤.Name = "出缺勤"
        Me.出缺勤.Size = New System.Drawing.Size(283, 134)
        Me.出缺勤.TabIndex = 8
        Me.出缺勤.UseVisualStyleBackColor = True
        '
        '課程管理
        '
        Me.課程管理.BackgroundImage = CType(resources.GetObject("課程管理.BackgroundImage"), System.Drawing.Image)
        Me.課程管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.課程管理.Location = New System.Drawing.Point(606, -1)
        Me.課程管理.Name = "課程管理"
        Me.課程管理.Size = New System.Drawing.Size(283, 134)
        Me.課程管理.TabIndex = 14
        Me.課程管理.UseVisualStyleBackColor = True
        '
        '繳費
        '
        Me.繳費.BackgroundImage = CType(resources.GetObject("繳費.BackgroundImage"), System.Drawing.Image)
        Me.繳費.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.繳費.Location = New System.Drawing.Point(321, -1)
        Me.繳費.Name = "繳費"
        Me.繳費.Size = New System.Drawing.Size(279, 134)
        Me.繳費.TabIndex = 13
        Me.繳費.UseVisualStyleBackColor = True
        '
        '學生管理
        '
        Me.學生管理.BackColor = System.Drawing.Color.Teal
        Me.學生管理.BackgroundImage = CType(resources.GetObject("學生管理.BackgroundImage"), System.Drawing.Image)
        Me.學生管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.學生管理.Location = New System.Drawing.Point(36, -1)
        Me.學生管理.Name = "學生管理"
        Me.學生管理.Size = New System.Drawing.Size(279, 134)
        Me.學生管理.TabIndex = 12
        Me.學生管理.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(760, 526)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(284, 31)
        Me.ComboBox1.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(627, 733)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 23)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "補課影片"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(627, 638)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 23)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "補課日期"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(675, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "姓名"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(760, 413)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(284, 54)
        Me.RichTextBox1.TabIndex = 78
        Me.RichTextBox1.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(675, 534)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 23)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "課程"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(550, 360)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1025, 492)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(760, 630)
        Me.DateTimePicker1.MinDate = New Date(2023, 6, 2, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(284, 35)
        Me.DateTimePicker1.TabIndex = 88
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(1834, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 39)
        Me.Button1.TabIndex = 92
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(1532, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "查詢"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(1609, 177)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(210, 50)
        Me.RichTextBox4.TabIndex = 90
        Me.RichTextBox4.Text = ""
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(1727, 771)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 81)
        Me.Button2.TabIndex = 93
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(1168, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "學生id"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(1276, 413)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(132, 54)
        Me.RichTextBox2.TabIndex = 97
        Me.RichTextBox2.Text = ""
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.LinkLabel1.Font = New System.Drawing.Font("標楷體", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(757, 726)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(619, 77)
        Me.LinkLabel1.TabIndex = 98
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://drive.google.com/drive/folders/1q8vOIAhJxgIeXNDXm0SoPST2jz2EWtfU?usp=shar" &
    "ing"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button7.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.Location = New System.Drawing.Point(12, 1014)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 54)
        Me.Button7.TabIndex = 99
        Me.Button7.Text = "退出"
        Me.Button7.UseVisualStyleBackColor = False
        '
        '補課系統
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.課程管理)
        Me.Controls.Add(Me.繳費)
        Me.Controls.Add(Me.學生管理)
        Me.Controls.Add(Me.報表)
        Me.Controls.Add(Me.補課)
        Me.Controls.Add(Me.成績)
        Me.Controls.Add(Me.出缺勤)
        Me.DoubleBuffered = True
        Me.Name = "補課系統"
        Me.Text = "Form7"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 報表 As Button
    Friend WithEvents 補課 As Button
    Friend WithEvents 成績 As Button
    Friend WithEvents 出缺勤 As Button
    Friend WithEvents 課程管理 As Button
    Friend WithEvents 繳費 As Button
    Friend WithEvents 學生管理 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button7 As Button
End Class
