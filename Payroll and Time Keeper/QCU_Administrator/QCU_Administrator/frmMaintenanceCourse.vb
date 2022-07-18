Imports MySql.Data.MySqlClient
Public Class frmMaintenanceCourse
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmMaintenanceCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCourse()
    End Sub
    Private Sub loadCourse()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_course"
            lvCourse.Items.Clear()
            Dim showCourse As ListViewItem
            dr = cmd.ExecuteReader
            While dr.Read
                showCourse = New ListViewItem(dr("courseID").ToString)
                showCourse.SubItems.Add(dr("courseCode"))
                showCourse.SubItems.Add(dr("courseDesc"))
                lvCourse.Items.Add(showCourse)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "INSERT INTO tbl_course(courseCode,courseDesc)VALUES(@CourseCode,@CourseDesc)"
            cmd.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text)
            cmd.Parameters.AddWithValue("@CourseDesc", txtCourseDesc.Text)
            If txtCourseCode.Text Is Nothing And txtCourseDesc.Text Is Nothing Then
                MsgBox("The fields is empty!. Please try again!", MsgBoxStyle.Information, "Add Course - Maintenance")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added course!", MsgBoxStyle.Information, "Add Course - Maintenance")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            conn.close()
            frmMaintenanceCourse_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub clear()
        txtCourseCode.Text = ""
        txtCourseDesc.Text = ""
        txtCourseID.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim id As String = lvCourse.SelectedItems(0).SubItems(0).Text
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "DELETE FROM tbl_course WHERE courseID = '" & id & "'"
            cmd.ExecuteNonQuery()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmMaintenanceCourse_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub lvCourse_MouseClick(sender As Object, e As MouseEventArgs) Handles lvCourse.MouseClick
        Dim id As String = lvCourse.SelectedItems(0).SubItems(0).Text
        Dim courseCode As String = lvCourse.SelectedItems(0).SubItems(1).Text
        Dim courseDesc As String = lvCourse.SelectedItems(0).SubItems(2).Text
        txtCourseID.Text = id
        txtCourseCode.Text = courseCode
        txtCourseDesc.Text = courseDesc
    End Sub

End Class