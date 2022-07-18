Imports MySql.Data.MySqlClient
Public Class frmMaintenanceSubject
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmMaintenanceSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSubject()
    End Sub
    Private Sub loadSubject()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_subject"
            lvSubject.Items.Clear()
            Dim showSubject As ListViewItem
            dr = cmd.ExecuteReader
            While dr.Read
                showSubject = New ListViewItem(dr("subjectID").ToString)
                showSubject.SubItems.Add(dr("subjectCode"))
                showSubject.SubItems.Add(dr("subjectDesc"))
                lvSubject.Items.Add(showSubject)
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
            cmd.CommandText = "INSERT INTO tbl_subject(subjectCode,subjectDesc)VALUES(@subjectCode,@subjectDesc)"
            cmd.Parameters.AddWithValue("@subjectCode", txtSubjectCode.Text)
            cmd.Parameters.AddWithValue("@subjectDesc", txtSubjectDesc.Text)
            If txtSubjectCode.Text Is Nothing And txtSubjectDesc.Text Is Nothing Then
                MsgBox("The fields is empty!. Please try again!", MsgBoxStyle.Information, "Add Subject - Maintenance")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added subject!", MsgBoxStyle.Information, "Add Subject - Maintenance")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            conn.close()
            frmMaintenanceSubject_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub clear()
        txtSubjectCode.Text = ""
        txtSubjectDesc.Text = ""
        txtSubjectID.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim id As String = lvSubject.SelectedItems(0).SubItems(0).Text
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "DELETE FROM tbl_subject WHERE subjectID = '" & id & "'"
            cmd.ExecuteNonQuery()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmMaintenanceSubject_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub lvSubject_MouseClick(sender As Object, e As MouseEventArgs) Handles lvSubject.MouseClick
        Dim id As String = lvSubject.SelectedItems(0).SubItems(0).Text
        Dim subjectCode As String = lvSubject.SelectedItems(0).SubItems(1).Text
        Dim subjectDesc As String = lvSubject.SelectedItems(0).SubItems(2).Text
        txtSubjectID.Text = id
        txtSubjectCode.Text = subjectCode
        txtSubjectDesc.Text = subjectDesc
    End Sub
End Class