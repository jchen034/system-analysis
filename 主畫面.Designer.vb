<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 主畫面
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(主畫面))
        Me.學生管理 = New System.Windows.Forms.Button()
        Me.繳費 = New System.Windows.Forms.Button()
        Me.課程管理 = New System.Windows.Forms.Button()
        Me.出缺勤 = New System.Windows.Forms.Button()
        Me.成績 = New System.Windows.Forms.Button()
        Me.補課 = New System.Windows.Forms.Button()
        Me.報表 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '學生管理
        '
        Me.學生管理.BackColor = System.Drawing.Color.Teal
        Me.學生管理.BackgroundImage = CType(resources.GetObject("學生管理.BackgroundImage"), System.Drawing.Image)
        Me.學生管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.學生管理.Location = New System.Drawing.Point(38, 1)
        Me.學生管理.Name = "學生管理"
        Me.學生管理.Size = New System.Drawing.Size(279, 134)
        Me.學生管理.TabIndex = 0
        Me.學生管理.UseVisualStyleBackColor = False
        '
        '繳費
        '
        Me.繳費.BackgroundImage = CType(resources.GetObject("繳費.BackgroundImage"), System.Drawing.Image)
        Me.繳費.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.繳費.Location = New System.Drawing.Point(323, 1)
        Me.繳費.Name = "繳費"
        Me.繳費.Size = New System.Drawing.Size(279, 134)
        Me.繳費.TabIndex = 1
        Me.繳費.UseVisualStyleBackColor = True
        '
        '課程管理
        '
        Me.課程管理.BackgroundImage = CType(resources.GetObject("課程管理.BackgroundImage"), System.Drawing.Image)
        Me.課程管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.課程管理.Location = New System.Drawing.Point(615, 1)
        Me.課程管理.Name = "課程管理"
        Me.課程管理.Size = New System.Drawing.Size(283, 134)
        Me.課程管理.TabIndex = 2
        Me.課程管理.UseVisualStyleBackColor = True
        '
        '出缺勤
        '
        Me.出缺勤.BackgroundImage = CType(resources.GetObject("出缺勤.BackgroundImage"), System.Drawing.Image)
        Me.出缺勤.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.出缺勤.Location = New System.Drawing.Point(905, 1)
        Me.出缺勤.Name = "出缺勤"
        Me.出缺勤.Size = New System.Drawing.Size(283, 134)
        Me.出缺勤.TabIndex = 3
        Me.出缺勤.UseVisualStyleBackColor = True
        '
        '成績
        '
        Me.成績.BackgroundImage = CType(resources.GetObject("成績.BackgroundImage"), System.Drawing.Image)
        Me.成績.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.成績.Location = New System.Drawing.Point(1194, 1)
        Me.成績.Name = "成績"
        Me.成績.Size = New System.Drawing.Size(278, 134)
        Me.成績.TabIndex = 4
        Me.成績.UseVisualStyleBackColor = True
        '
        '補課
        '
        Me.補課.BackgroundImage = CType(resources.GetObject("補課.BackgroundImage"), System.Drawing.Image)
        Me.補課.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.補課.Location = New System.Drawing.Point(1478, 1)
        Me.補課.Name = "補課"
        Me.補課.Size = New System.Drawing.Size(266, 134)
        Me.補課.TabIndex = 5
        Me.補課.UseVisualStyleBackColor = True
        '
        '報表
        '
        Me.報表.BackgroundImage = CType(resources.GetObject("報表.BackgroundImage"), System.Drawing.Image)
        Me.報表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.報表.Location = New System.Drawing.Point(1750, 1)
        Me.報表.Name = "報表"
        Me.報表.Size = New System.Drawing.Size(271, 134)
        Me.報表.TabIndex = 6
        Me.報表.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(662, 224)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(12, 1010)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 54)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = False
        '
        '主畫面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.報表)
        Me.Controls.Add(Me.補課)
        Me.Controls.Add(Me.成績)
        Me.Controls.Add(Me.出缺勤)
        Me.Controls.Add(Me.課程管理)
        Me.Controls.Add(Me.繳費)
        Me.Controls.Add(Me.學生管理)
        Me.DoubleBuffered = True
        Me.Name = "主畫面"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 學生管理 As Button
    Friend WithEvents 繳費 As Button
    Friend WithEvents 課程管理 As Button
    Friend WithEvents 出缺勤 As Button
    Friend WithEvents 成績 As Button
    Friend WithEvents 補課 As Button
    Friend WithEvents 報表 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
