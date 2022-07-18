Imports MySql.Data.MySqlClient
Public Class frmMaintenanceRoom
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmMaintenanceRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRoom()
    End Sub
    Private Sub loadRoom()
        Try

            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_room"
            lbRoom.Items.Clear()
            Dim room As ListViewItem
            dr = cmd.ExecuteReader
            While dr.Read
                room = New ListViewItem(dr("roomID").ToString)
                room.SubItems.Add(dr("roomCode"))
                room.SubItems.Add(dr("roomDesc"))
                lbRoom.Items.Add(room)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Private Sub lbRoom_MouseClick(sender As Object, e As MouseEventArgs) Handles lbRoom.MouseClick
        Dim id As String = lbRoom.SelectedItems(0).SubItems(0).Text
        Dim courseCode As String = lbRoom.SelectedItems(0).SubItems(1).Text
        Dim courseDesc As String = lbRoom.SelectedItems(0).SubItems(2).Text
        txtID.Text = id
        txtRoomCode.Text = courseCode
        txtRoomDesc.Text = courseDesc
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim id As String = lbRoom.SelectedItems(0).SubItems(0).Text
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "DELETE FROM tbl_room WHERE roomID = '" & id & "'"
            cmd.ExecuteNonQuery()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmMaintenanceRoom_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub clear()
        txtRoomCode.Text = ""
        txtRoomDesc.Text = ""
        txtID.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "INSERT INTO tbl_room(roomCode,roomDesc)VALUES(@roomCode,@roomDesc)"
            cmd.Parameters.AddWithValue("@roomCode", txtRoomCode.Text)
            cmd.Parameters.AddWithValue("@roomDesc", txtRoomDesc.Text)
            If txtRoomCode.Text Is Nothing And txtRoomDesc.Text Is Nothing Then
                MsgBox("The fields is empty!. Please try again!", MsgBoxStyle.Information, "Add Room - Maintenance")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added room!", MsgBoxStyle.Information, "Add Room - Maintenance")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            frmMaintenanceRoom_Load(e, e)
            Refresh()
        End Try
    End Sub
End Class