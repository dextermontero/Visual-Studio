Imports MySql.Data.MySqlClient
Public Class frmMaintenanceYear
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmMaintenanceYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadyear()
    End Sub
    Private Sub loadyear()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_year"
            lvYear.Items.Clear()
            Dim showYear As ListViewItem
            dr = cmd.ExecuteReader
            While dr.Read
                showYear = New ListViewItem(dr("yearID").ToString)
                showYear.SubItems.Add(dr("yearCode"))
                showYear.SubItems.Add(dr("yearDesc"))
                lvYear.Items.Add(showYear)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Private Sub lvYear_MouseClick(sender As Object, e As MouseEventArgs) Handles lvYear.MouseClick
        Dim id As String = lvYear.SelectedItems(0).SubItems(0).Text
        Dim roomCode As String = lvYear.SelectedItems(0).SubItems(1).Text
        Dim roomDesc As String = lvYear.SelectedItems(0).SubItems(2).Text
        txtYearID.Text = id
        txtYearCode.Text = roomCode
        txtYearDesc.Text = roomDesc
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "INSERT INTO tbl_year(yearCode,yearDesc)VALUES(@CourseCode,@CourseDesc)"
            cmd.Parameters.AddWithValue("@CourseCode", txtYearCode.Text)
            cmd.Parameters.AddWithValue("@CourseDesc", txtYearDesc.Text)
            If txtYearCode.Text Is Nothing And txtYearDesc.Text Is Nothing Then
                MsgBox("The fields is empty!. Please try again!", MsgBoxStyle.Information, "Add Year - Maintenance")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added year!", MsgBoxStyle.Information, "Add Year - Maintenance")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            conn.close()
            frmMaintenanceYear_Load(e, e)
            Refresh()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim id As String = lvYear.SelectedItems(0).SubItems(0).Text
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "DELETE FROM tbl_year WHERE yearID = '" & id & "'"
            cmd.ExecuteNonQuery()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmMaintenanceYear_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub clear()
        txtYearCode.Text = ""
        txtYearDesc.Text = ""
        txtYearID.Text = ""
    End Sub
End Class