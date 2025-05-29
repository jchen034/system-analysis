
Imports MySql.Data.MySqlClient


Public Class 繳費系統
    Private Sub 繳費系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        RichTextBox1.ReadOnly = True
        RichTextBox2.ReadOnly = True
    End Sub
    Private Sub 學生管理_Click(sender As Object, e As EventArgs) Handles 學生管理.Click
        Me.Hide()
        學生管理系統.Show()
    End Sub

    Private Sub 繳費_Click(sender As Object, e As EventArgs) Handles 繳費.Click
        Me.Show()
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox3.Text = ""
        RichTextBox4.Text = ""
        RichTextBox10.Text = ""
    End Sub

    Private Sub 課程管理_Click(sender As Object, e As EventArgs) Handles 課程管理.Click
        Me.Hide()
        課程管理系統.Show()
    End Sub

    Private Sub 出缺勤_Click(sender As Object, e As EventArgs) Handles 出缺勤.Click
        Me.Hide()
        出缺勤系統.Show()
    End Sub
    Private Sub 成績_Click(sender As Object, e As EventArgs) Handles 成績.Click
        Me.Hide()
        成績系統.Show()
    End Sub

    Private Sub 補課_Click(sender As Object, e As EventArgs) Handles 補課.Click
        Me.Hide()
        補課系統.Show()
    End Sub

    Private Sub 報表_Click(sender As Object, e As EventArgs) Handles 報表.Click
        Me.Hide()
        報表系統.Show()
    End Sub

    Private connectionString As String = "server=127.0.0.1;user=abc;password=1234;database=test;"

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim input As String = RichTextBox10.Text.Trim()

        ' 檢查是否輸入了學生姓名或ID
        If String.IsNullOrEmpty(input) Then
            MessageBox.Show("請輸入學生姓名或ID")
            Return
        End If

        ' 檢查學生是否存在
        Dim query As String = "SELECT student_name, student_course FROM student WHERE id = @input OR student_name = @input"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 檢查是否輸入了學生姓名或ID
            If String.IsNullOrEmpty(input) Then
                MessageBox.Show("請輸入學生姓名或ID")
                Return
            End If
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@input", input)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' 學生存在，顯示學生姓名和課程
                    RichTextBox1.Text = reader("student_name").ToString()
                    RichTextBox2.Text = reader("student_course").ToString()

                    reader.Close() ' 關閉第一個 DataReader

                    ' 查詢繳費資料
                    Dim paymentQuery As String = "SELECT payment_name, payment_course, receipt_number, amount FROM payment WHERE payment_name = @paymentName AND payment_course = @paymentCourse"
                    Using paymentCommand As New MySqlCommand(paymentQuery, connection)
                        paymentCommand.Parameters.AddWithValue("@paymentName", RichTextBox1.Text)
                        paymentCommand.Parameters.AddWithValue("@paymentCourse", RichTextBox2.Text)
                        Dim paymentReader As MySqlDataReader = paymentCommand.ExecuteReader()
                        If paymentReader.Read() Then
                            ' 顯示繳費資料
                            RichTextBox1.Text = paymentReader("payment_name").ToString()
                            RichTextBox2.Text = paymentReader("payment_course").ToString()
                            RichTextBox3.Text = paymentReader("receipt_number").ToString()
                            RichTextBox4.Text = paymentReader("amount").ToString()
                            RichTextBox1.ReadOnly = True
                            RichTextBox2.ReadOnly = True
                        Else
                            ' 無繳費資料，清空欄位
                            RichTextBox3.Text = ""
                            RichTextBox4.Text = ""
                            RichTextBox10.Text = " "
                        End If
                        paymentReader.Close()
                    End Using
                Else
                    ' 無此學生，顯示提示訊息
                    MessageBox.Show("無此學生")
                    reader.Close() ' 關閉第一個 DataReader
                End If
            End Using
        End Using
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim paymentName As String = RichTextBox1.Text.Trim()
        Dim paymentCourse As String = RichTextBox2.Text.Trim()
        Dim receiptNumber As String = RichTextBox3.Text.Trim()
        Dim amount As String = RichTextBox4.Text.Trim()

        ' 檢查是否已查詢學生
        If String.IsNullOrEmpty(paymentName) OrElse String.IsNullOrEmpty(paymentCourse) Then
            MessageBox.Show("請先查詢學生")
            Return
        End If

        ' 檢查是否輸入了收據編號和金額
        If String.IsNullOrEmpty(receiptNumber) OrElse String.IsNullOrEmpty(amount) Then
            MessageBox.Show("請輸入收據編號和金額")
            Return
        End If

        ' 先刪除舊的繳費資料
        Dim deleteQuery As String = "DELETE FROM payment WHERE payment_name = @paymentName AND payment_course = @paymentCourse"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@paymentName", paymentName)
                command.Parameters.AddWithValue("@paymentCourse", paymentCourse)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        ' 儲存繳費資料到資料庫
        Dim insertQuery As String = "INSERT INTO payment (payment_name, payment_course, receipt_number, amount) VALUES (@paymentName, @paymentCourse, @receiptNumber, @amount)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@paymentName", paymentName)
                command.Parameters.AddWithValue("@paymentCourse", paymentCourse)
                command.Parameters.AddWithValue("@receiptNumber", receiptNumber)
                command.Parameters.AddWithValue("@amount", amount)
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("資料已成功儲存到資料庫中。")
            End Using
        End Using

        ' 清空欄位
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox3.Text = ""
        RichTextBox4.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim receiptNumber As String = RichTextBox3.Text.Trim()
        Dim amount As String = RichTextBox4.Text.Trim()

        ' 檢查是否已查詢學生
        If String.IsNullOrEmpty(RichTextBox1.Text) OrElse String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢學生")
            Return
        End If

        ' 檢查是否輸入了收據編號和金額
        If String.IsNullOrEmpty(receiptNumber) OrElse String.IsNullOrEmpty(amount) Then
            MessageBox.Show("請輸入收據編號和金額")
            Return
        End If

        ' 檢查繳費資料是否存在
        Dim paymentQuery As String = "SELECT payment_name, payment_course FROM payment WHERE payment_name = @paymentName AND payment_course = @paymentCourse"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(paymentQuery, connection)
                command.Parameters.AddWithValue("@paymentName", RichTextBox1.Text.Trim())
                command.Parameters.AddWithValue("@paymentCourse", RichTextBox2.Text.Trim())
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If Not reader.Read() Then
                    MessageBox.Show("此筆繳費資料不存在，無法修改")
                    reader.Close()
                    Return
                End If
                reader.Close()
            End Using
        End Using

        ' 更新繳費資料
        Dim updateQuery As String = "UPDATE payment SET receipt_number = @receiptNumber, amount = @amount WHERE payment_name = @paymentName AND payment_course = @paymentCourse"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@receiptNumber", receiptNumber)
                command.Parameters.AddWithValue("@amount", amount)
                command.Parameters.AddWithValue("@paymentName", RichTextBox1.Text.Trim())
                command.Parameters.AddWithValue("@paymentCourse", RichTextBox2.Text.Trim())
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("修改成功")
                RichTextBox10.Text = ""
            End Using
        End Using

        ' 清空欄位
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox3.Text = ""
        RichTextBox4.Text = ""
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' 檢查是否已查詢學生
        If String.IsNullOrEmpty(RichTextBox1.Text) OrElse String.IsNullOrEmpty(RichTextBox2.Text) Then
            MessageBox.Show("請先查詢學生")
            Return
        End If

        ' 檢查繳費資料是否存在
        Dim paymentQuery As String = "SELECT payment_name, payment_course FROM payment WHERE payment_name = @paymentName AND payment_course = @paymentCourse"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(paymentQuery, connection)
                command.Parameters.AddWithValue("@paymentName", RichTextBox1.Text.Trim())
                command.Parameters.AddWithValue("@paymentCourse", RichTextBox2.Text.Trim())
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If Not reader.Read() Then
                    MessageBox.Show("此筆繳費資料不存在，無法刪除")
                    reader.Close()
                    Return
                End If
                reader.Close()
            End Using
        End Using

        ' 刪除繳費資料
        Dim deleteQuery As String = "DELETE FROM payment WHERE payment_name = @paymentName AND payment_course = @paymentCourse"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@paymentName", RichTextBox1.Text.Trim())
                command.Parameters.AddWithValue("@paymentCourse", RichTextBox2.Text.Trim())
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("刪除成功")
                RichTextBox10.Text = ""
            End Using
        End Using

        ' 清空欄位
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox3.Text = ""
        RichTextBox4.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' 退出應用程序
        Application.Exit()
    End Sub
End Class