Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class 出缺勤系統
    Private Sub 出缺勤系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.Show()
        ClearFields()
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
        students.Columns.Add("到班", GetType(Boolean)).DefaultValue = False
        students.Columns.Add("缺席", GetType(Boolean)).DefaultValue = False

        Dim classDate As Date = DateTimePicker1.Value.Date
        Dim courseId As Integer = GetCourseId(selectedCourse)

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 查詢符合課程及日期的出席狀態
            Dim query As String = "SELECT student.student_name, attendance.attendance_status " &
                              "FROM student " &
                              "LEFT JOIN attendance ON student.id = attendance.student_id " &
                              "AND attendance.course_id = @courseId " &
                              "AND attendance.classdate = @classDate " &
                              "WHERE FIND_IN_SET(@selectedCourse, student.student_course) > 0"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@courseId", courseId)
                command.Parameters.AddWithValue("@classDate", classDate)
                command.Parameters.AddWithValue("@selectedCourse", selectedCourse)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim studentName As String = reader("student_name").ToString()
                        Dim attendanceStatus As String = reader("attendance_status").ToString()

                        Dim row As DataRow = students.Rows.Add(studentName, False, False)

                        If attendanceStatus = "到班" Then
                            row("到班") = True
                        ElseIf attendanceStatus = "缺席" Then
                            row("缺席") = True
                        End If
                    End While
                End Using
            End Using
        End Using

        DataGridView1.DataSource = students

        ' 顯示 course_id 在 TextBox1
        TextBox1.Text = courseId.ToString()
        ' 修改DataGridView1的欄位名稱
        DataGridView1.Columns("student_name").HeaderText = "學生姓名"
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

        ' 更新出席狀態到資料庫
        UpdateAttendanceStatus(courseId, students)

        ' 清空 DataGridView1
        DataGridView1.DataSource = Nothing

        ' 清空 TextBox1
        TextBox1.Text = ""

        ' 清空 DateTimePicker1
        DateTimePicker1.Value = DateTime.Now

        MessageBox.Show("資料儲存成功")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedCourse As String = ComboBox1.SelectedItem.ToString()

        If String.IsNullOrEmpty(selectedCourse) Then
            MessageBox.Show("請選擇課程")
            Return
        End If

        Dim courseId As Integer = GetCourseId(selectedCourse)
        Dim classDate As Date = DateTimePicker1.Value.Date

        ' 呼叫刪除出缺勤資料的函式
        Dim success As Boolean = DeleteAttendanceData(courseId, classDate)

        If success Then
            MessageBox.Show("資料刪除成功")
            ClearFields()
        Else
            MessageBox.Show("資料刪除失敗")
        End If
    End Sub

    Private Function DeleteAttendanceData(courseId As Integer, classDate As Date) As Boolean
        Dim success As Boolean = False

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 刪除該課程和日期下的出缺勤資料
            Dim deleteQuery As String = "DELETE FROM attendance WHERE course_id = @courseId AND classdate = @classDate"

            Using deleteCommand As New MySqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@courseId", courseId)
                deleteCommand.Parameters.AddWithValue("@classDate", classDate)
                deleteCommand.ExecuteNonQuery()

                success = True
            End Using
        End Using

        Return success
    End Function

    Private Sub UpdateAttendanceStatus(courseId As Integer, students As DataTable)
        Dim classDate As Date = DateTimePicker1.Value.Date

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            For Each row As DataRow In students.Rows
                Dim studentName As String = row("student_name").ToString()
                Dim studentId As Integer = GetStudentId(studentName)

                If studentId = -1 Then
                    MessageBox.Show($"找不到學生 '{studentName}' 的資料")
                    Continue For
                End If

                Dim attendanceStatus As String = If(Convert.ToBoolean(row("到班")), "到班", "缺席")

                ' 查詢是否已存在出席紀錄
                Dim query As String = "SELECT COUNT(*) FROM attendance " &
                                  "WHERE course_id = @courseId " &
                                  "AND classdate = @classDate " &
                                  "AND student_id = @studentId"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@courseId", courseId)
                    command.Parameters.AddWithValue("@classDate", classDate)
                    command.Parameters.AddWithValue("@studentId", studentId)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        ' 更新出席狀態和學生姓名
                        Dim updateQuery As String = "UPDATE attendance " &
                                                "SET attendance_status = @attendanceStatus, student_name = @studentName " &
                                                "WHERE course_id = @courseId " &
                                                "AND classdate = @classDate " &
                                                "AND student_id = @studentId"

                        Using updateCommand As New MySqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@attendanceStatus", attendanceStatus)
                            updateCommand.Parameters.AddWithValue("@studentName", studentName)
                            updateCommand.Parameters.AddWithValue("@courseId", courseId)
                            updateCommand.Parameters.AddWithValue("@classDate", classDate)
                            updateCommand.Parameters.AddWithValue("@studentId", studentId)

                            updateCommand.ExecuteNonQuery()
                        End Using
                    Else
                        ' 新增出席紀錄
                        Dim insertQuery As String = "INSERT INTO attendance (course_id, classdate, student_id, attendance_status, student_name) " &
                                                "VALUES (@courseId, @classDate, @studentId, @attendanceStatus, @studentName)"

                        Using insertCommand As New MySqlCommand(insertQuery, connection)
                            insertCommand.Parameters.AddWithValue("@courseId", courseId)
                            insertCommand.Parameters.AddWithValue("@classDate", classDate)
                            insertCommand.Parameters.AddWithValue("@studentId", studentId)
                            insertCommand.Parameters.AddWithValue("@attendanceStatus", attendanceStatus)
                            insertCommand.Parameters.AddWithValue("@studentName", studentName)

                            insertCommand.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            Next
        End Using
    End Sub


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 退出應用程序
        Application.Exit()
    End Sub

End Class