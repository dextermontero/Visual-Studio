Imports MySql.Data.MySqlClient
Public Class frmMaintenanceSection
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmMaintenanceSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsection()
    End Sub
    Private Sub loadsection()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_section"
            lvSection.Items.Clear()
            Dim showSection As ListViewItem
            dr = cmd.ExecuteReader
            While dr.Read
                showSection = New ListViewItem(dr("sectionID").ToString)
                showSection.SubItems.Add(dr("sectionCode"))
                showSection.SubItems.Add(dr("sectionDesc"))
                lvSection.Items.Add(showSection)
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
            cmd.CommandText = "INSERT INTO tbl_section(sectionCode,sectionDesc)VALUES(@sectionCode,@sectionDesc)"
            cmd.Parameters.AddWithValue("@sectionCode", txtSectionCode.Text)
            cmd.Parameters.AddWithValue("@sectionDesc", txtSectionDesc.Text)
            If txtSectionCode.Text Is Nothing And txtSectionDesc.Text Is Nothing Then
                MsgBox("The fields is empty!. Please try again!", MsgBoxStyle.Information, "Add Course - Maintenance")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added section!", MsgBoxStyle.Information, "Add Course - Maintenance")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            conn.close()
            frmMaintenanceSection_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub clear()
        txtSectionCode.Text = ""
        txtSectionDesc.Text = ""
        txtSectionID.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim id As String = lvSection.SelectedItems(0).SubItems(0).Text
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "DELETE FROM tbl_section WHERE sectionID = '" & id & "'"
            cmd.ExecuteNonQuery()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmMaintenanceSection_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub lvSection_MouseClick(sender As Object, e As MouseEventArgs) Handles lvSection.MouseClick
        Dim id As String = lvSection.SelectedItems(0).SubItems(0).Text
        Dim courseCode As String = lvSection.SelectedItems(0).SubItems(1).Text
        Dim courseDesc As String = lvSection.SelectedItems(0).SubItems(2).Text
        txtSectionID.Text = id
        txtSectionCode.Text = courseCode
        txtSectionDesc.Text = courseDesc
    End Sub
End Class