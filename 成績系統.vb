Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class 成績系統
    Private Sub 成績系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
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

        DataGridView1.RowTemplate.Height = 30
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
        Me.Show()
        ClearFields()
    End Sub

    Private Sub 補課_Click(sender As Object, e As EventArgs) Handles 補課.Click
        補課系統.Show()
        Me.Hide()
    End Sub

    Private Sub 報表_Click(sender As Object, e As EventArgs) Handles 報表.Click
        報表系統.Show()
        Me.Hide()
    End Sub
    Private Sub ClearFields()
        ComboBox1.SelectedItem = Nothing
        DateTimePicker1.ResetText()
        TextBox1.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub

    Private connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim selectedCourse As String = ComboBox1.SelectedItem.ToString()

        If String.IsNullOrEmpty(selectedCourse) Then
            MessageBox.Show("請選擇課程")
            Return
        End If

        Dim students As New DataTable()
        students.Columns.Add("student_name", GetType(String))
        students.Columns.Add("student_score", GetType(Integer))

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 查詢符合課程的學生姓名
            Dim query As String = "SELECT student_name FROM student WHERE FIND_IN_SET(@selectedCourse, student_course) > 0"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@selectedCourse", selectedCourse)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        students.Rows.Add(reader("student_name"), DBNull.Value)
                    End While
                End Using
            End Using
        End Using

        ' 檢查是否已有填寫過成績
        Dim courseId As Integer = GetCourseId(selectedCourse)
        Dim classDate As Date = DateTimePicker1.Value.Date
        Dim score As DataTable = GetScoreByCourseIdAndDate(courseId, classDate)

        If score.Rows.Count > 0 Then
            ' 已有填寫過成績，載入已有資料
            For Each row As DataRow In students.Rows
                Dim studentName As String = row("student_name").ToString()
                Dim studentId As Integer = GetStudentId(studentName)

                If studentId <> -1 Then
                    Dim scoreRow As DataRow = score.Select("student_id = " & studentId.ToString()).FirstOrDefault()

                    If scoreRow IsNot Nothing Then
                        row("student_score") = Convert.ToInt32(scoreRow("student_score"))
                    End If
                End If
            Next
        End If

        DataGridView1.DataSource = students

        ' 顯示 course_id 在 TextBox1
        TextBox1.Text = courseId.ToString()
        ' 修改DataGridView1的欄位名稱
        DataGridView1.Columns("student_name").HeaderText = "學生姓名"
        DataGridView1.Columns("student_score").HeaderText = "成績"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedCourse As String = ComboBox1.SelectedItem.ToString()
        If String.IsNullOrEmpty(selectedCourse) Then
            MessageBox.Show("請選擇課程")
            Return
        End If

        Dim courseId As Integer = GetCourseId(selectedCourse)

        If courseId = -1 Then
            MessageBox.Show("找不到對應的課程")
            Return
        End If

        Dim students As DataTable = DirectCast(DataGridView1.DataSource, DataTable)

        ' 儲存成績到資料庫
        Dim success As Boolean = SaveStudentScore(courseId, students)

        If success Then
            MessageBox.Show("資料儲存成功")
            ClearFields()
        Else
            MessageBox.Show("資料儲存失敗")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedCourse As String = ComboBox1.SelectedItem.ToString()

        If String.IsNullOrEmpty(selectedCourse) Then
            MessageBox.Show("請選擇課程")
            Return
        End If

        Dim courseId As Integer = GetCourseId(selectedCourse)
        Dim classDate As Date = DateTimePicker1.Value.Date

        ' 呼叫刪除成績的函式
        Dim success As Boolean = DeleteStudentScore(courseId, classDate)

        If success Then
            MessageBox.Show("資料刪除成功")
            ClearFields()
        Else
            MessageBox.Show("資料刪除失敗")
        End If
    End Sub

    Private Function DeleteStudentScore(courseId As Integer, classDate As Date) As Boolean
        Dim success As Boolean = False

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 刪除該課程和日期下的成績
            Dim deleteQuery As String = "DELETE FROM score WHERE course_id = @courseId AND classdate = @classDate"

            Using deleteCommand As New MySqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@courseId", courseId)
                deleteCommand.Parameters.AddWithValue("@classDate", classDate)
                deleteCommand.ExecuteNonQuery()

                success = True
            End Using
        End Using

        Return success
    End Function

    Private Function SaveStudentScore(courseId As Integer, students As DataTable) As Boolean
        Dim classDate As Date = DateTimePicker1.Value.Date
        Dim success As Boolean = False

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 刪除該課程和日期下的舊有成績
            Dim deleteQuery As String = "DELETE FROM score WHERE course_id = @courseId AND classdate = @classDate"

            Using deleteCommand As New MySqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@courseId", courseId)
                deleteCommand.Parameters.AddWithValue("@classDate", classDate)
                deleteCommand.ExecuteNonQuery()
            End Using

            ' 插入新的成績資料
            Dim insertQuery As String = "INSERT INTO score (course_id, classdate, student_id, student_score, student_name) " &
                           "VALUES (@courseId, @classDate, @studentId, @studentScore, @studentName)"

            Using insertCommand As New MySqlCommand(insertQuery, connection)
                insertCommand.Parameters.Add("@courseId", MySqlDbType.Int32)
                insertCommand.Parameters.Add("@classDate", MySqlDbType.Date)
                insertCommand.Parameters.Add("@studentId", MySqlDbType.Int32)
                insertCommand.Parameters.Add("@studentScore", MySqlDbType.Int32)
                insertCommand.Parameters.Add("@studentName", MySqlDbType.VarChar)

                For Each row As DataRow In students.Rows
                    Dim studentName As String = row("student_name").ToString()
                    Dim studentId As Integer = GetStudentId(studentName)
                    Dim studentScore As Integer

                    If row.IsNull("student_score") Then
                        studentScore = Nothing
                    Else
                        studentScore = Convert.ToInt32(row("student_score"))
                    End If

                    If studentId = -1 Then
                        MessageBox.Show($"找不到學生 '{studentName}' 的資料")
                        Continue For
                    End If

                    insertCommand.Parameters("@courseId").Value = courseId
                    insertCommand.Parameters("@classDate").Value = classDate
                    insertCommand.Parameters("@studentId").Value = studentId
                    insertCommand.Parameters("@studentScore").Value = studentScore
                    insertCommand.Parameters("@studentName").Value = studentName

                    insertCommand.ExecuteNonQuery()
                Next

                success = True
            End Using
        End Using

        Return success
    End Function
    Private Function GetCourseId(courseName As String) As Integer
        Dim courseId As Integer = -1

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT course_id FROM course WHERE course_name = @courseName"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@courseName", courseName)

                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    courseId = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return courseId
    End Function

    Private Function GetStudentId(studentName As String) As Integer
        Dim studentId As Integer = -1

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT id FROM student WHERE student_name = @studentName"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentName", studentName)

                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    studentId = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return studentId
    End Function

    Private Function GetScoreByCourseIdAndDate(courseId As Integer, classDate As Date) As DataTable
        Dim score As New DataTable()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT student_id, student_score FROM score WHERE course_id = @courseId AND classdate = @classDate"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@courseId", courseId)
                command.Parameters.AddWithValue("@classDate", classDate)

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(score)
                End Using
            End Using
        End Using

        Return score
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 退出應用程序
        Application.Exit()
    End Sub
End Class