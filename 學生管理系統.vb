Imports MySql.Data.MySqlClient

Public Class 學生管理系統
    Dim connection As MySqlConnection
    Private Sub 學生管系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        RichTextBox2.Visible = False
        Label5.Visible = False
        RichTextBox2.ReadOnly = True

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '學生管理按鍵
        Me.Show()
        RichTextBox2.Visible = False
        Label5.Visible = False
        ClearFields()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '繳費按鍵
        繳費系統.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '課程管理按鍵
        課程管理系統.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click '出缺勤按鍵
        出缺勤系統.Show()
        Me.Hide()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click '成績按鍵
        成績系統.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click '補課按鍵
        補課系統.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click '報表按鍵
        報表系統.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' 檢查欄位是否為空值
        If String.IsNullOrEmpty(RichTextBox1.Text) OrElse
           String.IsNullOrEmpty(RichTextBox3.Text) OrElse
           String.IsNullOrEmpty(RichTextBox4.Text) OrElse
           String.IsNullOrEmpty(RichTextBox5.Text) OrElse
           String.IsNullOrEmpty(RichTextBox6.Text) OrElse
           String.IsNullOrEmpty(RichTextBox7.Text) Then
            ' 顯示欄位不得為空的錯誤訊息
            MessageBox.Show("欄位不得為空。請填寫完整學生資料。")
        Else
            ' 執行儲存學生資料的程式碼
            Try
                Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"

                ' 取得使用者輸入的資料
                Dim studentname As String = RichTextBox1.Text
                Dim birthday As String = RichTextBox3.Text
                Dim idNumber As String = RichTextBox4.Text
                Dim studentPhone As String = RichTextBox5.Text
                Dim address As String = RichTextBox6.Text
                Dim parentName As String = RichTextBox7.Text
                Dim remarks As String = RichTextBox9.Text

                ' 取得性別資料
                Dim gender As String = ""
                If CheckBoxMale.Checked Then
                    gender = "男"
                ElseIf CheckBoxFemale.Checked Then
                    gender = "女"
                End If

                ' 取得課程資料
                Dim selectedCourses As New List(Of String)
                '高一
                If CheckBoxChinese1.Checked Then
                    selectedCourses.Add("高一國文")
                End If
                If CheckBoxEnglish1.Checked Then
                    selectedCourses.Add("高一英文")
                End If
                If CheckBoxMath1.Checked Then
                    selectedCourses.Add("高一數學")
                End If
                If CheckBoxPhysics1.Checked Then
                    selectedCourses.Add("高一物理")
                End If
                If CheckBoxChemistry1.Checked Then
                    selectedCourses.Add("高一化學")
                End If
                '高二
                If CheckBoxChinese2.Checked Then
                    selectedCourses.Add("高二國文")
                End If
                If CheckBoxEnglish2.Checked Then
                    selectedCourses.Add("高二英文")
                End If
                If CheckBoxMath2.Checked Then
                    selectedCourses.Add("高二數學")
                End If
                If CheckBoxPhysics2.Checked Then
                    selectedCourses.Add("高二物理")
                End If
                If CheckBoxChemistry2.Checked Then
                    selectedCourses.Add("高二化學")
                End If
                '高三
                If CheckBoxChinese3.Checked Then
                    selectedCourses.Add("高三國文")
                End If
                If CheckBoxEnglish3.Checked Then
                    selectedCourses.Add("高三英文")
                End If
                If CheckBoxMath3.Checked Then
                    selectedCourses.Add("高三數學")
                End If
                If CheckBoxPhysics3.Checked Then
                    selectedCourses.Add("高三物理")
                End If
                If CheckBoxChemistry3.Checked Then
                    selectedCourses.Add("高三化學")
                End If


                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' 建立 SQL INSERT 語句
                    Dim query As String = "INSERT INTO student (student_name, gender, birthday, id_number, student_phone, address, parent_name, student_course, remarks) VALUES (@studentname, @gender, @birthday, @idNumber, @studentPhone, @address, @parentName, @studentcourse, @remarks)"

                    Using command As New MySqlCommand(query, connection)
                        ' 使用參數化查詢，以避免 SQL 注入攻擊
                        command.Parameters.AddWithValue("@studentname", studentname)
                        command.Parameters.AddWithValue("@gender", gender)
                        command.Parameters.AddWithValue("@birthday", birthday)
                        command.Parameters.AddWithValue("@idNumber", idNumber)
                        command.Parameters.AddWithValue("@studentPhone", studentPhone)
                        command.Parameters.AddWithValue("@address", address)
                        command.Parameters.AddWithValue("@parentName", parentName)
                        command.Parameters.AddWithValue("@studentcourse", String.Join(",", selectedCourses))
                        command.Parameters.AddWithValue("@remarks", remarks)

                        ' 執行 SQL 語句
                        command.ExecuteNonQuery()

                        ' 提示儲存成功
                        MessageBox.Show("儲存成功。")

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
    Private Sub ClearFields()
        ' 清空欄位上的資料
        RichTextBox2.Clear()
        RichTextBox1.Clear()
        CheckBoxMale.Checked = False
        CheckBoxFemale.Checked = False
        RichTextBox3.Clear()
        RichTextBox4.Clear()
        RichTextBox5.Clear()
        RichTextBox6.Clear()
        RichTextBox7.Clear()
        RichTextBox10.Clear()
        CheckBoxChinese1.Checked = False
        CheckBoxEnglish1.Checked = False
        CheckBoxMath1.Checked = False
        CheckBoxPhysics1.Checked = False
        CheckBoxChemistry1.Checked = False
        CheckBoxChinese2.Checked = False
        CheckBoxEnglish2.Checked = False
        CheckBoxMath2.Checked = False
        CheckBoxPhysics2.Checked = False
        CheckBoxChemistry2.Checked = False
        CheckBoxChinese3.Checked = False
        CheckBoxEnglish3.Checked = False
        CheckBoxMath3.Checked = False
        CheckBoxPhysics3.Checked = False
        CheckBoxChemistry3.Checked = False
        RichTextBox9.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ' 檢查是否輸入了學生姓名或學生 ID
        If String.IsNullOrEmpty(RichTextBox10.Text) Then
            MessageBox.Show("請輸入學生姓名或學生 ID。")
            Return
        End If

        ' 取得欲查詢的學生姓名或學生 ID
        Dim searchValue As String = RichTextBox10.Text

        Try
            Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 建立 SQL SELECT 語句
                Dim query As String = "SELECT * FROM student WHERE student_name = @searchValue OR id = @searchValue"
                ' Dim query1 As String = "SELECT studentname, DATE(birthday) AS birthday FROM student WHERE name = @name"

                Using command As New MySqlCommand(query, connection)
                    ' 使用參數化查詢，以避免 SQL 注入攻擊
                    command.Parameters.AddWithValue("@searchValue", searchValue)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim studentID As Integer = reader.GetInt32("id")
                            Dim studentName As String = reader.GetString("student_name")
                            Dim studentBirthday As Date = reader.GetDateTime("birthday")
                            Dim studentIDNumber As String = reader.GetString("id_number")
                            Dim studentPhone As String = reader.GetString("student_phone")
                            Dim studentAddress As String = reader.GetString("address")
                            Dim parentName As String = reader.GetString("parent_name")
                            Dim remarks As String = reader.GetString("remarks")
                            Dim gender As String = reader.GetString("gender")
                            Dim studentcourse As String = reader.GetString("student_course")

                            ' 顯示學生資料
                            RichTextBox2.Visible = True
                            Label5.Visible = True
                            RichTextBox2.Text = studentID.ToString()
                            RichTextBox1.Text = studentName
                            RichTextBox3.Text = studentBirthday.ToString("yyyy/MM/dd")
                            RichTextBox4.Text = studentIDNumber
                            RichTextBox5.Text = studentPhone
                            RichTextBox6.Text = studentAddress
                            RichTextBox7.Text = parentName
                            RichTextBox9.Text = remarks
                            If gender = "男" Then
                                CheckBoxMale.Checked = True
                                CheckBoxFemale.Checked = False
                            ElseIf gender = "女" Then
                                CheckBoxMale.Checked = False
                                CheckBoxFemale.Checked = True
                            End If

                            ' 清空課程資料的checkbox
                            ClearCourseFields()

                            ' 處理課程資料
                            Dim courses() As String = studentcourse.Split(",")
                            For Each c As String In courses
                                Select Case c
                                    Case "高一國文"
                                        CheckBoxChinese1.Checked = True
                                    Case "高一英文"
                                        CheckBoxEnglish1.Checked = True
                                    Case "高一數學"
                                        CheckBoxMath1.Checked = True
                                    Case "高一物理"
                                        CheckBoxPhysics1.Checked = True
                                    Case "高一化學"
                                        CheckBoxChemistry1.Checked = True
                                    Case "高二國文"
                                        CheckBoxChinese2.Checked = True
                                    Case "高二英文"
                                        CheckBoxEnglish2.Checked = True
                                    Case "高二數學"
                                        CheckBoxMath2.Checked = True
                                    Case "高二物理"
                                        CheckBoxPhysics2.Checked = True
                                    Case "高二化學"
                                        CheckBoxChemistry2.Checked = True
                                    Case "高三國文"
                                        CheckBoxChinese3.Checked = True
                                    Case "高三英文"
                                        CheckBoxEnglish3.Checked = True
                                    Case "高三數學"
                                        CheckBoxMath3.Checked = True
                                    Case "高三物理"
                                        CheckBoxPhysics3.Checked = True
                                    Case "高三化學"
                                        CheckBoxChemistry3.Checked = True
                                End Select
                            Next
                        Else
                            ' 若未找到學生資料，清空欄位並提示
                            ClearFields()
                            ClearCourseFields()
                            MessageBox.Show("找不到該學生的資料。")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' 處理連接或查詢錯誤
            MessageBox.Show("查詢學生資料時發生錯誤：" & ex.Message)
        End Try
    End Sub

    Private Sub ClearCourseFields()
        ' 清空課程資料的checkbox
        CheckBoxChinese1.Checked = False
        CheckBoxEnglish1.Checked = False
        CheckBoxMath1.Checked = False
        CheckBoxPhysics1.Checked = False
        CheckBoxChemistry1.Checked = False
        CheckBoxChinese2.Checked = False
        CheckBoxEnglish2.Checked = False
        CheckBoxMath2.Checked = False
        CheckBoxPhysics2.Checked = False
        CheckBoxChemistry2.Checked = False
        CheckBoxChinese3.Checked = False
        CheckBoxEnglish3.Checked = False
        CheckBoxMath3.Checked = False
        CheckBoxPhysics3.Checked = False
        CheckBoxChemistry3.Checked = False
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' 檢查是否輸入了學生 ID
        If String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢學生資料。")
            Return
        End If

        ' 取得欲刪除的學生 ID
        Dim studentId As Integer = Integer.Parse(RichTextBox2.Text)

        Try
            Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 建立 SQL DELETE 語句
                Dim query As String = "DELETE FROM student WHERE id = @studentId"

                Using command As New MySqlCommand(query, connection)
                    ' 使用參數化查詢，以避免 SQL 注入攻擊
                    command.Parameters.AddWithValue("@studentId", studentId)

                    ' 執行 SQL 語句
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' 刪除成功，清空欄位並提示
                        ClearFields()
                        MessageBox.Show("學生資料已成功刪除。")
                    Else
                        ' 若未找到學生資料，提示錯誤
                        MessageBox.Show("找不到該學生的資料。")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' 處理連接或刪除錯誤
            MessageBox.Show("刪除學生資料時發生錯誤：" & ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' 檢查是否輸入了學生 ID
        If String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢學生資料。")
            Return
        End If

        ' 取得欲修改的學生 ID
        Dim studentId As Integer = Integer.Parse(RichTextBox2.Text)

        ' 取得修改後的資料
        Dim studentname As String = RichTextBox1.Text
        Dim birthday As String = RichTextBox3.Text
        Dim idNumber As String = RichTextBox4.Text
        Dim studentPhone As String = RichTextBox5.Text
        Dim address As String = RichTextBox6.Text
        Dim parentName As String = RichTextBox7.Text
        Dim remarks As String = RichTextBox9.Text

        ' 取得性別資料
        Dim gender As String = ""
        If CheckBoxMale.Checked Then
            gender = "男"
        ElseIf CheckBoxFemale.Checked Then
            gender = "女"
        End If

        ' 取得課程資料
        Dim selectedCourses As New List(Of String)
        '高一
        If CheckBoxChinese1.Checked Then
            selectedCourses.Add("高一國文")
        End If
        If CheckBoxEnglish1.Checked Then
            selectedCourses.Add("高一英文")
        End If
        If CheckBoxMath1.Checked Then
            selectedCourses.Add("高一數學")
        End If
        If CheckBoxPhysics1.Checked Then
            selectedCourses.Add("高一物理")
        End If
        If CheckBoxChemistry1.Checked Then
            selectedCourses.Add("高一化學")
        End If
        '高二
        If CheckBoxChinese2.Checked Then
            selectedCourses.Add("高二國文")
        End If
        If CheckBoxEnglish2.Checked Then
            selectedCourses.Add("高二英文")
        End If
        If CheckBoxMath2.Checked Then
            selectedCourses.Add("高二數學")
        End If
        If CheckBoxPhysics2.Checked Then
            selectedCourses.Add("高二物理")
        End If
        If CheckBoxChemistry2.Checked Then
            selectedCourses.Add("高二化學")
        End If
        '高三
        If CheckBoxChinese3.Checked Then
            selectedCourses.Add("高三國文")
        End If
        If CheckBoxEnglish3.Checked Then
            selectedCourses.Add("高三英文")
        End If
        If CheckBoxMath3.Checked Then
            selectedCourses.Add("高三數學")
        End If
        If CheckBoxPhysics3.Checked Then
            selectedCourses.Add("高三物理")
        End If
        If CheckBoxChemistry3.Checked Then
            selectedCourses.Add("高三化學")
        End If


        Try
            Dim connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 建立 SQL UPDATE 語句
                Dim query As String = "UPDATE student SET student_name = @studentname, gender = @gender, birthday = @birthday, id_number = @idNumber, student_phone = @studentPhone, address = @address, parent_name = @parentName, student_course = @studentcourse, remarks = @remarks WHERE id = @studentId"

                Using command As New MySqlCommand(query, connection)
                    ' 使用參數化查詢，以避免 SQL 注入攻擊
                    command.Parameters.AddWithValue("@studentname", studentname)
                    command.Parameters.AddWithValue("@gender", gender)
                    command.Parameters.AddWithValue("@birthday", birthday)
                    command.Parameters.AddWithValue("@idNumber", idNumber)
                    command.Parameters.AddWithValue("@studentPhone", studentPhone)
                    command.Parameters.AddWithValue("@address", address)
                    command.Parameters.AddWithValue("@parentName", parentName)
                    command.Parameters.AddWithValue("@studentcourse", String.Join(",", selectedCourses))
                    command.Parameters.AddWithValue("@remarks", remarks)
                    command.Parameters.AddWithValue("@studentId", studentId)

                    ' 執行 SQL 語句
                    command.ExecuteNonQuery()

                    ' 提示修改成功
                    MessageBox.Show("學生資料已成功修改。")
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            ' 處理連接或修改錯誤
            MessageBox.Show("修改學生資料時發生錯誤：" & ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' 退出應用程序
        Application.Exit()
    End Sub


End Class