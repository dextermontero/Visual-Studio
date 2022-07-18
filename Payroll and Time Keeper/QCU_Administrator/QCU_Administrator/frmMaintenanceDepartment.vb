Imports MySql.Data.MySqlClient
Public Class frmMaintenanceDepartment
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDepartment()
    End Sub
    Private Sub loadDepartment()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_department"
            lvDepartment.Items.Clear()
            Dim showCourse As ListViewItem
            dr = cmd.ExecuteReader
            While dr.Read
                showCourse = New ListViewItem(dr("departmentID").ToString)
                showCourse.SubItems.Add(dr("departmentCode"))
                showCourse.SubItems.Add(dr("departmentDesc"))
                lvDepartment.Items.Add(showCourse)
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
            cmd.CommandText = "INSERT INTO tbl_department(departmentCode,departmentDesc)VALUES(@departmentCode,@departmentDescription)"
            cmd.Parameters.AddWithValue("@departmentCode", txtDepartmentCode.Text)
            cmd.Parameters.AddWithValue("@departmentDescription", txtDepartmentDesc.Text)
            If txtDepartmentCode.Text Is Nothing And txtDepartmentDesc.Text Is Nothing Then
                MsgBox("The fields is empty!. Please try again!", MsgBoxStyle.Information, "Add Department - Maintenance")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added department!", MsgBoxStyle.Information, "Add departament - Maintenance")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmDepartment_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub clear()
        txtDepartmentCode.Text = ""
        txtDepartmentDesc.Text = ""
        txtDepartmentID.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim id As String = lvDepartment.SelectedItems(0).SubItems(0).Text
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "DELETE FROM tbl_department WHERE departmentID = '" & id & "'"
            cmd.ExecuteNonQuery()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmDepartment_Load(e, e)
            Refresh()
        End Try
    End Sub

    Private Sub lvDepartment_MouseClick(sender As Object, e As MouseEventArgs) Handles lvDepartment.MouseClick
        Dim id As String = lvDepartment.SelectedItems(0).SubItems(0).Text
        Dim courseCode As String = lvDepartment.SelectedItems(0).SubItems(1).Text
        Dim courseDesc As String = lvDepartment.SelectedItems(0).SubItems(2).Text
        txtDepartmentID.Text = id
        txtDepartmentCode.Text = courseCode
        txtDepartmentDesc.Text = courseDesc
    End Sub
End Class