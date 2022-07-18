Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class validateScheduleDelete
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE Password = '" & txtPassword.Text & "'"
            dr = cmd.ExecuteReader
            If txtPassword.Text = Nothing Then
                MsgBox("The Field is empty. Please Try again!!!", MsgBoxStyle.Information, "Verify Password")
            Else
                If dr.Read Then
                    frmMaintenanceSchedule.lblValidate.Text = dr("Password")
                    Me.Hide()
                Else
                    MsgBox("Password did not match!. Please Try again!!!", MsgBoxStyle.Information, "Verify Password")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
            validateScheduleDelete_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub validateScheduleDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Text = ""
    End Sub
End Class