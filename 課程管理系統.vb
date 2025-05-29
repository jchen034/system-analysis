Imports MySql.Data.MySqlClient


Public Class 課程管理系統
    Private Sub 課程管理系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        ' 設定 ComboBox1 的選項
        ComboBox1.Items.Add("星期四 18:00~21:10")
        ComboBox1.Items.Add("星期日 14:00~17:10")
        ComboBox1.Items.Add("星期一 18:00~21:10")
        ComboBox1.Items.Add("星期五 18:00~21:10")
        ComboBox1.Items.Add("星期六 14:00~17:10")
        ComboBox1.Items.Add("星期六 18:00~21:10")
        ComboBox1.Items.Add("星期日 9:00~12:10")
        ComboBox1.Items.Add("星期二 18:00~21:10")


        ComboBox2.Items.Add("韓曌")
        ComboBox2.Items.Add("Maggie")
        ComboBox2.Items.Add("Tammy")
        ComboBox2.Items.Add("潘浩")
        ComboBox2.Items.Add("王基權")
        ComboBox2.Items.Add("黃松")
        ComboBox2.Items.Add("莊小寬")

        ComboBox3.Items.Add("高一國文")
        ComboBox3.Items.Add("高一英文")
        ComboBox3.Items.Add("高一數學")
        ComboBox3.Items.Add("高一物理")
        ComboBox3.Items.Add("高一化學")
        ComboBox3.Items.Add("高二國文")
        ComboBox3.Items.Add("高二英文")
        ComboBox3.Items.Add("高二數學")
        ComboBox3.Items.Add("高二物理")
        ComboBox3.Items.Add("高二化學")
        ComboBox3.Items.Add("高三國文")
        ComboBox3.Items.Add("高三英文")
        ComboBox3.Items.Add("高三數學")
        ComboBox3.Items.Add("高三物理")
        ComboBox3.Items.Add("高三化學")
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
        Me.Show()
        ClearFields()
        RichTextBox10.Clear()
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
        報表系統.Show()
        Me.Hide()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"
        ' 檢查欄位是否為空值
        If String.IsNullOrEmpty(ComboBox3.Text) OrElse
           String.IsNullOrEmpty(RichTextBox2.Text) OrElse
           String.IsNullOrEmpty(ComboBox1.Text) OrElse
           String.IsNullOrEmpty(RichTextBox5.Text) OrElse
           String.IsNullOrEmpty(ComboBox2.Text) Then
            ' 顯示欄位不得為空的錯誤訊息
            MessageBox.Show("欄位不得為空。請填寫完整課程資料。")
        Else
            ' 取得使用者輸入的資料
            Dim courseName As String = ComboBox3.SelectedItem.ToString()
            Dim courseId As String = RichTextBox2.Text
            Dim classTime As String = ComboBox1.SelectedItem.ToString()
            Dim teacherName As String = ComboBox2.SelectedItem.ToString()
            Dim courseContent As String = RichTextBox5.Text

            ' 檢查必填欄位是否為空
            If String.IsNullOrEmpty(courseName) OrElse String.IsNullOrEmpty(courseId) OrElse
            String.IsNullOrEmpty(classTime) OrElse String.IsNullOrEmpty(teacherName) OrElse
            String.IsNullOrEmpty(courseContent) Then
                MessageBox.Show("所有欄位都必須填寫。")
                Return
            End If

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' 建立 SQL INSERT 語句
                    Dim query As String = "INSERT INTO course (course_name, course_id, class_time, teacher_name, course_content) VALUES (@courseName, @courseId, @classTime, @teacherName, @courseContent)"

                    Using command As New MySqlCommand(query, connection)
                        ' 使用參數化查詢，以避免 SQL 注入攻擊
                        command.Parameters.AddWithValue("@courseName", courseName)
                        command.Parameters.AddWithValue("@courseId", courseId)
                        command.Parameters.AddWithValue("@classTime", classTime)
                        command.Parameters.AddWithValue("@teacherName", teacherName)
                        command.Parameters.AddWithValue("@courseContent", courseContent)

                        ' 執行 SQL 語句
                        command.ExecuteNonQuery()

                        ' 提示儲存成功
                        MessageBox.Show("資料已成功儲存到資料庫中。")

                        ' 清空所有欄位
                        ClearFields()
                    End Using
                End Using
            Catch ex As Exception
                ' 處理連接或儲存錯誤
                MessageBox.Show("資料儲存時發生錯誤：" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"
        ' 取得使用者輸入的查詢課程名稱或ID
        Dim searchInput As String = RichTextBox10.Text

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 建立 SQL SELECT 語句
                Dim query As String = "SELECT * FROM course WHERE course_name = @searchInput OR course_id = @searchInput"

                Using command As New MySqlCommand(query, connection)
                    ' 使用參數化查詢，以避免 SQL 注入攻擊
                    command.Parameters.AddWithValue("@searchInput", searchInput)

                    ' 執行 SQL 語句，取得查詢結果
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' 檢查是否有資料
                        If reader.Read() Then
                            ' 顯示查詢結果到對應的欄位
                            RichTextBox2.Text = reader("course_id").ToString()
                            ComboBox1.SelectedItem = reader("class_time").ToString()
                            ComboBox2.SelectedItem = reader("teacher_name").ToString()
                            ComboBox3.SelectedItem = reader("course_name").ToString()
                            RichTextBox5.Text = reader("course_content").ToString()
                        Else
                            MessageBox.Show("找不到符合條件的課程。")
                            RichTextBox10.Clear()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' 處理連接或查詢錯誤
            MessageBox.Show("查詢時發生錯誤：" & ex.Message)
        End Try
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"
        ' 檢查是否輸入了學生 ID
        If String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢課程資料。")
            Return
        End If
        ' 取得使用者輸入的資料
        Dim courseName As String = ComboBox3.SelectedItem.ToString()
        Dim courseId As String = RichTextBox2.Text
        Dim classTime As String = ComboBox1.SelectedItem.ToString()
        Dim teacherName As String = ComboBox2.SelectedItem.ToString()
        Dim courseContent As String = RichTextBox5.Text

        ' 檢查必填欄位是否為空
        If String.IsNullOrEmpty(courseName) OrElse String.IsNullOrEmpty(courseId) OrElse
        String.IsNullOrEmpty(classTime) OrElse String.IsNullOrEmpty(teacherName) OrElse
        String.IsNullOrEmpty(courseContent) Then
            MessageBox.Show("所有欄位都必須填寫。")
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 建立 SQL UPDATE 語句
                Dim query As String = "UPDATE course SET course_name = @courseName, class_time = @classTime, teacher_name = @teacherName, course_content = @courseContent WHERE course_id = @courseId"

                Using command As New MySqlCommand(query, connection)
                    ' 使用參數化查詢，以避免 SQL 注入攻擊
                    command.Parameters.AddWithValue("@courseName", courseName)
                    command.Parameters.AddWithValue("@classTime", classTime)
                    command.Parameters.AddWithValue("@teacherName", teacherName)
                    command.Parameters.AddWithValue("@courseContent", courseContent)
                    command.Parameters.AddWithValue("@courseId", courseId)

                    ' 執行 SQL 語句
                    command.ExecuteNonQuery()

                    ' 提示修改成功
                    MessageBox.Show("資料已成功修改。")

                    ' 清空所有欄位
                    ClearFields()
                    RichTextBox10.Clear()
                End Using
            End Using
        Catch ex As Exception
            ' 處理連接或修改錯誤
            MessageBox.Show("修改資料時發生錯誤：" & ex.Message)
        End Try
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"
        ' 檢查是否輸入了學生 ID
        If String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢課程資料。")
            Return
        End If
        ' 取得使用者輸入的課程 ID
        Dim courseId As String = RichTextBox2.Text

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 建立 SQL DELETE 語句
                Dim query As String = "DELETE FROM course WHERE course_id = @courseId"

                Using command As New MySqlCommand(query, connection)
                    ' 使用參數化查詢，以避免 SQL 注入攻擊
                    command.Parameters.AddWithValue("@courseId", courseId)

                    ' 執行 SQL 語句
                    command.ExecuteNonQuery()

                    ' 提示刪除成功
                    MessageBox.Show("資料已成功刪除。")

                    ' 清空所有欄位
                    ClearFields()
                    RichTextBox10.Clear()
                End Using
            End Using
        Catch ex As Exception
            ' 處理連接或刪除錯誤
            MessageBox.Show("刪除資料時發生錯誤：" & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        ComboBox3.SelectedItem = Nothing
        RichTextBox2.Clear()
        ComboBox1.SelectedItem = Nothing
        ComboBox2.SelectedItem = Nothing
        RichTextBox5.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' 退出應用程序
        Application.Exit()
    End Sub
End Class