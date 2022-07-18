Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class frmRegisterAdministrator
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            Dim opf As New OpenFileDialog
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif|All files(*.*)|*.*"
            If opf.ShowDialog = DialogResult.OK Then
                pcbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                pcbAdmin.Image = Image.FromFile(opf.FileName)
            End If
        Catch ex As Exception
            MsgBox("Invalid Image Format", MsgBoxStyle.Information, "Choose Image")
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtName.Text = Nothing Or txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
                MsgBox("Please fill up all Fields", MsgBoxStyle.Information, "Admintration Register")
            Else
                If emailChecker(txtEmail.Text) = False Then
                    MsgBox("Invalid Email Address! Please Try again...", MsgBoxStyle.Information, "Admintration Register")
                Else
                    Dim ms As New MemoryStream
                    pcbAdmin.Image.Save(ms, pcbAdmin.Image.RawFormat)
                    conn.close()
                    cmd.Connection = conn.open
                    cmd.CommandText = "INSERT INTO tbl_admin(adminNickname,adminName,Username,Password,adminProfile,Email)VALUES(@adminNickname,@adminName,@Username,@Password,@adminProfile,@Email)"
                    cmd.Parameters.AddWithValue("@adminNickname", txtName.Text)
                    cmd.Parameters.AddWithValue("@adminName", txtName.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("adminProfile", ms.ToArray)

                    If MsgBox("Registration Successfully! Do you want to go to Login form?", MsgBoxStyle.YesNo, "QCU - Administration Register") = MsgBoxResult.Yes Then
                        cmd.ExecuteNonQuery()
                        Me.Close()
                        frmLoginAdministrator.Show()
                        frmLoginAdministrator.reload.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
    Function emailChecker(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailcheck As Match = Regex.Match(emailaddress, pattern)
        If emailcheck.Success Then
            emailChecker = True
        Else
            emailChecker = False
        End If
    End Function
    Private Sub frmRegisterAdministrator_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmLoginAdministrator.Show()
    End Sub
End Class