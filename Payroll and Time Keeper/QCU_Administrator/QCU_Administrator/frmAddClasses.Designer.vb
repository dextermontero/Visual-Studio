<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddClasses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSelectCourse = New System.Windows.Forms.Label()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.lblSelectYear = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbYear)
        Me.GroupBox1.Controls.Add(Me.lblSelectYear)
        Me.GroupBox1.Controls.Add(Me.cbCourse)
        Me.GroupBox1.Controls.Add(Me.lblSelectCourse)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(925, 484)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblSelectCourse
        '
        Me.lblSelectCourse.AutoSize = True
        Me.lblSelectCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectCourse.Location = New System.Drawing.Point(6, 16)
        Me.lblSelectCourse.Name = "lblSelectCourse"
        Me.lblSelectCourse.Size = New System.Drawing.Size(127, 20)
        Me.lblSelectCourse.TabIndex = 0
        Me.lblSelectCourse.Text = "Select Course "
        '
        'cbCourse
        '
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.DropDownWidth = 330
        Me.cbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Location = New System.Drawing.Point(10, 39)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(158, 28)
        Me.cbCourse.TabIndex = 1
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.DropDownWidth = 106
        Me.cbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(10, 93)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(158, 28)
        Me.cbYear.TabIndex = 3
        '
        'lblSelectYear
        '
        Me.lblSelectYear.AutoSize = True
        Me.lblSelectYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectYear.Location = New System.Drawing.Point(6, 70)
        Me.lblSelectYear.Name = "lblSelectYear"
        Me.lblSelectYear.Size = New System.Drawing.Size(108, 20)
        Me.lblSelectYear.TabIndex = 2
        Me.lblSelectYear.Text = "Select Year "
        '
        'frmAddClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddClasses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Class"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents lblSelectCourse As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents lblSelectYear As Label
End Class
