<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 繳費系統
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(繳費系統))
        Me.報表 = New System.Windows.Forms.Button()
        Me.補課 = New System.Windows.Forms.Button()
        Me.成績 = New System.Windows.Forms.Button()
        Me.出缺勤 = New System.Windows.Forms.Button()
        Me.課程管理 = New System.Windows.Forms.Button()
        Me.繳費 = New System.Windows.Forms.Button()
        Me.學生管理 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox10 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '報表
        '
        Me.報表.BackgroundImage = CType(resources.GetObject("報表.BackgroundImage"), System.Drawing.Image)
        Me.報表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.報表.Location = New System.Drawing.Point(1739, 1)
        Me.報表.Name = "報表"
        Me.報表.Size = New System.Drawing.Size(271, 134)
        Me.報表.TabIndex = 11
        Me.報表.UseVisualStyleBackColor = True
        '
        '補課
        '
        Me.補課.BackgroundImage = CType(resources.GetObject("補課.BackgroundImage"), System.Drawing.Image)
        Me.補課.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.補課.Location = New System.Drawing.Point(1467, 1)
        Me.補課.Name = "補課"
        Me.補課.Size = New System.Drawing.Size(266, 134)
        Me.補課.TabIndex = 10
        Me.補課.UseVisualStyleBackColor = True
        '
        '成績
        '
        Me.成績.BackgroundImage = CType(resources.GetObject("成績.BackgroundImage"), System.Drawing.Image)
        Me.成績.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.成績.Location = New System.Drawing.Point(1183, 1)
        Me.成績.Name = "成績"
        Me.成績.Size = New System.Drawing.Size(278, 134)
        Me.成績.TabIndex = 9
        Me.成績.UseVisualStyleBackColor = True
        '
        '出缺勤
        '
        Me.出缺勤.BackgroundImage = CType(resources.GetObject("出缺勤.BackgroundImage"), System.Drawing.Image)
        Me.出缺勤.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.出缺勤.Location = New System.Drawing.Point(894, 1)
        Me.出缺勤.Name = "出缺勤"
        Me.出缺勤.Size = New System.Drawing.Size(283, 134)
        Me.出缺勤.TabIndex = 8
        Me.出缺勤.UseVisualStyleBackColor = True
        '
        '課程管理
        '
        Me.課程管理.BackgroundImage = CType(resources.GetObject("課程管理.BackgroundImage"), System.Drawing.Image)
        Me.課程管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.課程管理.Location = New System.Drawing.Point(605, 1)
        Me.課程管理.Name = "課程管理"
        Me.課程管理.Size = New System.Drawing.Size(283, 134)
        Me.課程管理.TabIndex = 7
        Me.課程管理.UseVisualStyleBackColor = True
        '
        '繳費
        '
        Me.繳費.BackgroundImage = CType(resources.GetObject("繳費.BackgroundImage"), System.Drawing.Image)
        Me.繳費.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.繳費.Location = New System.Drawing.Point(320, 1)
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
        Me.學生管理.Location = New System.Drawing.Point(35, 1)
        Me.學生管理.Name = "學生管理"
        Me.學生管理.Size = New System.Drawing.Size(279, 134)
        Me.學生管理.TabIndex = 12
        Me.學生管理.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(800, 467)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 23)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "姓名"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(875, 449)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(284, 54)
        Me.RichTextBox1.TabIndex = 39
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(800, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "課程"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(875, 553)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(284, 54)
        Me.RichTextBox2.TabIndex = 41
        Me.RichTextBox2.Text = ""
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button12.Location = New System.Drawing.Point(1865, 194)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(69, 39)
        Me.Button12.TabIndex = 65
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(1563, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 23)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "查詢"
        '
        'RichTextBox10
        '
        Me.RichTextBox10.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox10.Location = New System.Drawing.Point(1640, 179)
        Me.RichTextBox10.Name = "RichTextBox10"
        Me.RichTextBox10.Size = New System.Drawing.Size(210, 50)
        Me.RichTextBox10.TabIndex = 63
        Me.RichTextBox10.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(800, 773)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "金額"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(875, 654)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(284, 54)
        Me.RichTextBox3.TabIndex = 68
        Me.RichTextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(752, 666)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 23)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "收據編號"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(875, 756)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(284, 54)
        Me.RichTextBox4.TabIndex = 66
        Me.RichTextBox4.Text = ""
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.Location = New System.Drawing.Point(1721, 786)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(155, 81)
        Me.Button10.TabIndex = 72
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button11.Location = New System.Drawing.Point(1721, 889)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(155, 81)
        Me.Button11.TabIndex = 71
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.Location = New System.Drawing.Point(1721, 680)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(155, 81)
        Me.Button9.TabIndex = 70
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(649, 353)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(687, 559)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button8.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button8.Location = New System.Drawing.Point(12, 1017)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 54)
        Me.Button8.TabIndex = 102
        Me.Button8.Text = "退出"
        Me.Button8.UseVisualStyleBackColor = False
        '
        '繳費系統
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.繳費)
        Me.Controls.Add(Me.學生管理)
        Me.Controls.Add(Me.報表)
        Me.Controls.Add(Me.補課)
        Me.Controls.Add(Me.成績)
        Me.Controls.Add(Me.出缺勤)
        Me.Controls.Add(Me.課程管理)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "繳費系統"
        Me.Text = "Form3"
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
    Friend WithEvents Label10 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox10 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button8 As Button
End Class
