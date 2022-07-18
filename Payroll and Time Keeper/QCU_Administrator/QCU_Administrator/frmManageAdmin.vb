Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmManageAdmin
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmManageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadadmin()
    End Sub
    Private Sub loadadmin()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_admin"
            dr = cmd.ExecuteReader
            lvAdmin.Items.Clear()
            Dim showAdmin As ListViewItem
            While dr.Read
                showAdmin = New ListViewItem(dr("AdminName").ToString)
                showAdmin.SubItems.Add(dr("Email"))
                showAdmin.SubItems.Add(dr("Username"))
                showAdmin.SubItems.Add("••••••••••")
                lvAdmin.Items.Add(showAdmin)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
    Private Sub lvAdmin_MouseClick(sender As Object, e As MouseEventArgs) Handles lvAdmin.MouseClick
        Dim admin As String = lvAdmin.SelectedItems(0).SubItems(0).Text
        Dim email As String = lvAdmin.SelectedItems(0).SubItems(1).Text
        Dim user As String = lvAdmin.SelectedItems(0).SubItems(2).Text
        Dim pass As String = lvAdmin.SelectedItems(0).SubItems(3).Text
        txtname.Text = admin
        txtEmail.Text = email
        txtuser.Text = user
        txtpass.Text = pass
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE adminName = '" & admin & "'"
            dr = cmd.ExecuteReader
            lvAdmin.Items.Clear()
            Dim showAdmin As ListViewItem
            While dr.Read
                lblID.Text = dr("adminName")
                lblNick.Text = dr("adminNickname")
                Dim img() As Byte
                img = dr("adminProfile")
                Dim ms As New MemoryStream(img)
                pcbAdmin.Image = Image.FromStream(ms)
                pcbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                showAdmin = New ListViewItem(dr("AdminName").ToString)
                showAdmin.SubItems.Add(dr("Email"))
                showAdmin.SubItems.Add(dr("Username"))
                showAdmin.SubItems.Add("••••••••••")
                lvAdmin.Items.Add(showAdmin)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmManageAdmin_Load(e, e)
        Refresh()
        txtname.Text = ""
        lblNick.Text = ""
        txtpass.Text = ""
        txtuser.Text = ""
        pcbAdmin.Image = My.Resources.unknown
    End Sub
End Class