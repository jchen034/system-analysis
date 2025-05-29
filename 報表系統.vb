Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class 報表系統
    Private Sub 報表系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub 學生管理_Click(sender As Object, e As EventArgs) Handles 學生管理.Click
        學生管理系統.Show()
        Me.Hide()
    End Sub

    Private Sub 繳費_Click(sender As Object, e As EventArgs) Handles 繳費.Click
        繳費系統.Show()
        Me.Hide()
    End Sub

    Private Sub 課程管理_Click(sender As Object, e As EventArgs) Handles 課程管理.Click
        課程管理系統.Show()
        Me.Hide()
    End Sub

    Private Sub 出缺勤_Click(sender As Object, e As EventArgs) Handles 出缺勤.Click
        出缺勤系統.Show()
        Me.Hide()
    End Sub
    Private Sub 成績_Click(sender As Object, e As EventArgs) Handles 成績.Click
        成績系統.Show()
        Me.Hide()
    End Sub

    Private Sub 補課_Click(sender As Object, e As EventArgs) Handles 補課.Click
        補課系統.Show()
        Me.Hide()
    End Sub

    Private Sub 報表_Click(sender As Object, e As EventArgs) Handles 報表.Click
        Me.Show()
        DataGridView1.DataSource = Nothing
    End Sub
    Private connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 查詢學生資料
        Dim query As String = "SELECT id AS '學生編號', student_name AS '學生姓名', gender AS '性別', birthday AS '生日', id_number AS '身分證字號', student_phone AS '學生電話', address AS '地址', parent_name AS '家長姓名', student_course AS '報名課程', remarks AS '備註' FROM student"
        FillDataGridView(query)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 查詢繳費資料
        Dim query As String = "SELECT payment_name AS '學生姓名', payment_course AS '報名課程', receipt_number AS '收據編號', amount AS '金額' FROM payment"
        FillDataGridView(query)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 查詢課程資料
        Dim query As String = "SELECT course_id AS '課程編號', course_name AS '課程名稱', class_time AS '上課時間', teacher_name AS '老師姓名', course_content AS '課程內容' FROM course"
        FillDataGridView(query)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' 查詢補課資料
        Dim query As String = "SELECT student_id AS '學生編號', student_name AS '學生姓名', course_name AS '課程名稱', classdate AS '補課日期' FROM makeuplesson"
        FillDataGridView(query)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query As String = "SELECT a.course_id AS '課程編號', c.course_name AS '課程名稱', a.student_id AS '學生編號', s.student_name AS '學生姓名', a.classdate AS '上課日期', a.attendance_status AS '出席狀態' FROM attendance a INNER JOIN course c ON a.course_id = c.course_id INNER JOIN student s ON a.student_id = s.id"
        FillDataGridView(query)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String = "SELECT s.course_id AS '課程編號', c.course_name AS '課程名稱', s.student_id AS '學生編號', st.student_name AS '學生姓名', s.classdate AS '上課日期', s.student_score AS '成績' FROM score s INNER JOIN course c ON s.course_id = c.course_id INNER JOIN student st ON s.student_id = st.id"
        FillDataGridView(query)
    End Sub

    Private Sub FillDataGridView(query As String)
        ' 建立資料連線並填充DataGridView
        Using conn As New MySqlConnection("server=127.0.0.1;user=abc;password=1234;database=test;")
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        End Using

        ' 設定欄位大小自動調整
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' 退出應用程序
        Application.Exit()
    End Sub
End Class