
Imports MySql.Data.MySqlClient
Public Class 補課系統
    Private Sub 補課系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        RichTextBox1.ReadOnly = True
        RichTextBox2.ReadOnly = True
        ClearFields()

        ComboBox1.Items.Add("高一國文")
        ComboBox1.Items.Add("高一英文")
        ComboBox1.Items.Add("高一數學")
        ComboBox1.Items.Add("高一物理")
        ComboBox1.Items.Add("高一化學")
        ComboBox1.Items.Add("高二國文")
        ComboBox1.Items.Add("高二英文")
        ComboBox1.Items.Add("高二數學")
        ComboBox1.Items.Add("高二物理")
        ComboBox1.Items.Add("高二化學")
        ComboBox1.Items.Add("高三國文")
        ComboBox1.Items.Add("高三英文")
        ComboBox1.Items.Add("高三數學")
        ComboBox1.Items.Add("高三物理")
        ComboBox1.Items.Add("高三化學")


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
        Me.Show()
        ClearFields()
    End Sub

    Private Sub 報表_Click(sender As Object, e As EventArgs) Handles 報表.Click
        報表系統.Show()
        Me.Hide()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' 在這裡指定要跳轉的網址
        Dim url As String = "https://drive.google.com/drive/folders/1q8vOIAhJxgIeXNDXm0SoPST2jz2EWtfU?usp=sharing"

        ' 使用預設的瀏覽器打開網址
        Process.Start(url)
    End Sub
    Private connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchText As String = RichTextBox4.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("請輸入學生姓名或學生ID。")
            Return
        End If

        Dim query As String = "SELECT id, student_name FROM student WHERE student_name = @searchText OR id = @searchText"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@searchText", searchText)

                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    RichTextBox1.Text = reader("student_name").ToString()
                    RichTextBox2.Text = reader("id").ToString()
                Else
                    RichTextBox1.Clear()
                    RichTextBox2.Clear()
                    MessageBox.Show("找不到符合的學生。")
                End If
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim studentID As Integer
        Dim studentName As String = RichTextBox1.Text.Trim()
        Dim courseName As String = If(ComboBox1.SelectedItem IsNot Nothing, ComboBox1.SelectedItem.ToString(), "")
        Dim classDate As Date = DateTimePicker1.Value

        ' 檢查是否已查詢學生
        If String.IsNullOrEmpty(studentName) OrElse String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢學生")
            Return
        End If

        ' 檢查是否選擇課程與補課日期
        If String.IsNullOrEmpty(courseName) OrElse classDate = Date.MinValue Then
            MessageBox.Show("請選擇課程與補課日期")
            Return
        End If

        If Not Integer.TryParse(RichTextBox2.Text.Trim(), studentID) Then
            MessageBox.Show("無此學生ID。")
            Return
        End If

        ' 先刪除舊的補課資料
        Dim deleteQuery As String = "DELETE FROM makeuplesson WHERE student_id = @studentID AND course_name = @courseName AND classdate = @classDate AND student_name = @studentName"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@studentID", studentID)
                command.Parameters.AddWithValue("@courseName", courseName)
                command.Parameters.AddWithValue("@classDate", classDate)
                command.Parameters.AddWithValue("@studentName", studentName)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        ' 儲存資料
        Dim query As String = "INSERT INTO makeuplesson (student_id, course_name, classdate, student_name) VALUES (@studentID, @courseName, @classDate, @studentName)"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentID", studentID)
                command.Parameters.AddWithValue("@courseName", courseName)
                command.Parameters.AddWithValue("@classDate", classDate)
                command.Parameters.AddWithValue("@studentName", studentName)

                command.ExecuteNonQuery()
                MessageBox.Show("資料存入成功。")
                ClearFields()
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ' 檢查是否已查詢學生
        If String.IsNullOrEmpty(RichTextBox1.Text) OrElse String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢學生")
            Return
        End If

        ' 刪除補課資料
        Dim deleteQuery As String = "DELETE FROM makeuplesson WHERE student_id = @studentID AND course_name = @courseName AND classdate = @classDate AND student_name = @studentName"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@studentID", RichTextBox2.Text.Trim())
                command.Parameters.AddWithValue("@courseName", ComboBox1.SelectedItem.ToString())
                command.Parameters.AddWithValue("@classDate", DateTimePicker1.Value)
                command.Parameters.AddWithValue("@studentName", RichTextBox1.Text.Trim())
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("刪除成功")
                    ClearFields()
                Else
                    MessageBox.Show("找不到符合條件的資料，無法刪除")
                End If
            End Using
        End Using
    End Sub

    Private Sub ClearFields()
        RichTextBox1.Clear()
        RichTextBox2.Clear()
        RichTextBox4.Clear()
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' 退出應用程序
        Application.Exit()
    End Sub
End Class