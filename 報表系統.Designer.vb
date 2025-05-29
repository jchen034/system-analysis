<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 報表系統
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(報表系統))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.報表 = New System.Windows.Forms.Button()
        Me.補課 = New System.Windows.Forms.Button()
        Me.成績 = New System.Windows.Forms.Button()
        Me.出缺勤 = New System.Windows.Forms.Button()
        Me.課程管理 = New System.Windows.Forms.Button()
        Me.繳費 = New System.Windows.Forms.Button()
        Me.學生管理 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '報表
        '
        Me.報表.BackgroundImage = CType(resources.GetObject("報表.BackgroundImage"), System.Drawing.Image)
        Me.報表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.報表.Location = New System.Drawing.Point(1742, 0)
        Me.報表.Name = "報表"
        Me.報表.Size = New System.Drawing.Size(271, 134)
        Me.報表.TabIndex = 11
        Me.報表.UseVisualStyleBackColor = True
        '
        '補課
        '
        Me.補課.BackgroundImage = CType(resources.GetObject("補課.BackgroundImage"), System.Drawing.Image)
        Me.補課.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.補課.Location = New System.Drawing.Point(1470, 0)
        Me.補課.Name = "補課"
        Me.補課.Size = New System.Drawing.Size(266, 134)
        Me.補課.TabIndex = 10
        Me.補課.UseVisualStyleBackColor = True
        '
        '成績
        '
        Me.成績.BackgroundImage = CType(resources.GetObject("成績.BackgroundImage"), System.Drawing.Image)
        Me.成績.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.成績.Location = New System.Drawing.Point(1186, 0)
        Me.成績.Name = "成績"
        Me.成績.Size = New System.Drawing.Size(278, 134)
        Me.成績.TabIndex = 9
        Me.成績.UseVisualStyleBackColor = True
        '
        '出缺勤
        '
        Me.出缺勤.BackgroundImage = CType(resources.GetObject("出缺勤.BackgroundImage"), System.Drawing.Image)
        Me.出缺勤.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.出缺勤.Location = New System.Drawing.Point(897, 0)
        Me.出缺勤.Name = "出缺勤"
        Me.出缺勤.Size = New System.Drawing.Size(283, 134)
        Me.出缺勤.TabIndex = 8
        Me.出缺勤.UseVisualStyleBackColor = True
        '
        '課程管理
        '
        Me.課程管理.BackgroundImage = CType(resources.GetObject("課程管理.BackgroundImage"), System.Drawing.Image)
        Me.課程管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.課程管理.Location = New System.Drawing.Point(608, 0)
        Me.課程管理.Name = "課程管理"
        Me.課程管理.Size = New System.Drawing.Size(283, 134)
        Me.課程管理.TabIndex = 7
        Me.課程管理.UseVisualStyleBackColor = True
        '
        '繳費
        '
        Me.繳費.BackgroundImage = CType(resources.GetObject("繳費.BackgroundImage"), System.Drawing.Image)
        Me.繳費.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.繳費.Location = New System.Drawing.Point(323, 0)
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
        Me.學生管理.Location = New System.Drawing.Point(38, 0)
        Me.學生管理.Name = "學生管理"
        Me.學生管理.Size = New System.Drawing.Size(279, 134)
        Me.學生管理.TabIndex = 12
        Me.學生管理.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("標楷體", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
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
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(647, 295)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(1065, 497)
        Me.DataGridView1.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(277, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 103)
        Me.Button1.TabIndex = 61
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(277, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 103)
        Me.Button2.TabIndex = 62
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(277, 486)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 103)
        Me.Button3.TabIndex = 63
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(277, 606)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 103)
        Me.Button4.TabIndex = 64
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(277, 730)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(190, 97)
        Me.Button5.TabIndex = 65
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Location = New System.Drawing.Point(277, 849)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(190, 99)
        Me.Button6.TabIndex = 66
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button7.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.Location = New System.Drawing.Point(12, 1012)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 54)
        Me.Button7.TabIndex = 85
        Me.Button7.Text = "退出"
        Me.Button7.UseVisualStyleBackColor = False
        '
        '報表系統
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.繳費)
        Me.Controls.Add(Me.學生管理)
        Me.Controls.Add(Me.報表)
        Me.Controls.Add(Me.補課)
        Me.Controls.Add(Me.成績)
        Me.Controls.Add(Me.出缺勤)
        Me.Controls.Add(Me.課程管理)
        Me.DoubleBuffered = True
        Me.Name = "報表系統"
        Me.Text = "Form8"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 報表 As Button
    Friend WithEvents 補課 As Button
    Friend WithEvents 成績 As Button
    Friend WithEvents 出缺勤 As Button
    Friend WithEvents 課程管理 As Button
    Friend WithEvents 繳費 As Button
    Friend WithEvents 學生管理 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
