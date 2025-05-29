<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 成績系統
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(成績系統))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.報表 = New System.Windows.Forms.Button()
        Me.補課 = New System.Windows.Forms.Button()
        Me.成績 = New System.Windows.Forms.Button()
        Me.出缺勤 = New System.Windows.Forms.Button()
        Me.課程管理 = New System.Windows.Forms.Button()
        Me.繳費 = New System.Windows.Forms.Button()
        Me.學生管理 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '報表
        '
        Me.報表.BackgroundImage = CType(resources.GetObject("報表.BackgroundImage"), System.Drawing.Image)
        Me.報表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.報表.Location = New System.Drawing.Point(1740, -1)
        Me.報表.Name = "報表"
        Me.報表.Size = New System.Drawing.Size(271, 134)
        Me.報表.TabIndex = 10
        Me.報表.UseVisualStyleBackColor = True
        '
        '補課
        '
        Me.補課.BackgroundImage = CType(resources.GetObject("補課.BackgroundImage"), System.Drawing.Image)
        Me.補課.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.補課.Location = New System.Drawing.Point(1468, -1)
        Me.補課.Name = "補課"
        Me.補課.Size = New System.Drawing.Size(266, 134)
        Me.補課.TabIndex = 9
        Me.補課.UseVisualStyleBackColor = True
        '
        '成績
        '
        Me.成績.BackgroundImage = CType(resources.GetObject("成績.BackgroundImage"), System.Drawing.Image)
        Me.成績.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.成績.Location = New System.Drawing.Point(1184, -1)
        Me.成績.Name = "成績"
        Me.成績.Size = New System.Drawing.Size(278, 134)
        Me.成績.TabIndex = 8
        Me.成績.UseVisualStyleBackColor = True
        '
        '出缺勤
        '
        Me.出缺勤.BackgroundImage = CType(resources.GetObject("出缺勤.BackgroundImage"), System.Drawing.Image)
        Me.出缺勤.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.出缺勤.Location = New System.Drawing.Point(895, -1)
        Me.出缺勤.Name = "出缺勤"
        Me.出缺勤.Size = New System.Drawing.Size(283, 134)
        Me.出缺勤.TabIndex = 7
        Me.出缺勤.UseVisualStyleBackColor = True
        '
        '課程管理
        '
        Me.課程管理.BackgroundImage = CType(resources.GetObject("課程管理.BackgroundImage"), System.Drawing.Image)
        Me.課程管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.課程管理.Location = New System.Drawing.Point(606, -1)
        Me.課程管理.Name = "課程管理"
        Me.課程管理.Size = New System.Drawing.Size(283, 134)
        Me.課程管理.TabIndex = 13
        Me.課程管理.UseVisualStyleBackColor = True
        '
        '繳費
        '
        Me.繳費.BackgroundImage = CType(resources.GetObject("繳費.BackgroundImage"), System.Drawing.Image)
        Me.繳費.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.繳費.Location = New System.Drawing.Point(321, -1)
        Me.繳費.Name = "繳費"
        Me.繳費.Size = New System.Drawing.Size(279, 134)
        Me.繳費.TabIndex = 12
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
        Me.學生管理.TabIndex = 11
        Me.學生管理.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "選擇課程:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(730, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "上課日期:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(865, 245)
        Me.DateTimePicker1.MinDate = New Date(2023, 6, 2, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 35)
        Me.DateTimePicker1.TabIndex = 72
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(438, 249)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 31)
        Me.ComboBox1.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(1210, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "課程id:"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button12.Location = New System.Drawing.Point(1589, 232)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(86, 51)
        Me.Button12.TabIndex = 76
        Me.Button12.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(1320, 241)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 35)
        Me.TextBox1.TabIndex = 75
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("標楷體", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("標楷體", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataGridView1.Location = New System.Drawing.Point(865, 454)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(339, 462)
        Me.DataGridView1.TabIndex = 78
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1576, 732)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 81)
        Me.Button1.TabIndex = 79
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(1576, 837)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 79)
        Me.Button2.TabIndex = 80
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(12, 1014)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 54)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "退出"
        Me.Button3.UseVisualStyleBackColor = False
        '
        '成績系統
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.課程管理)
        Me.Controls.Add(Me.繳費)
        Me.Controls.Add(Me.學生管理)
        Me.Controls.Add(Me.報表)
        Me.Controls.Add(Me.補課)
        Me.Controls.Add(Me.成績)
        Me.Controls.Add(Me.出缺勤)
        Me.DoubleBuffered = True
        Me.Name = "成績系統"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
