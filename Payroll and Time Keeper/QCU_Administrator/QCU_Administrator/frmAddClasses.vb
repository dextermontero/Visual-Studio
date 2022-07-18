Public Class frmAddClasses
    Private Sub frmAddClasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbYear.Enabled = False ' to load disable selecting year if course not already selecting
        addClass.loadCourse() ' to load courses
        addClass.loadYear() ' to load year
    End Sub
End Class