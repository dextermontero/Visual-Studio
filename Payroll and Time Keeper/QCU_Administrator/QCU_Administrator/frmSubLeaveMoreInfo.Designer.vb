<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubLeaveMoreInfo
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearchEmployee = New System.Windows.Forms.TextBox()
        Me.lblSearchEmployee = New System.Windows.Forms.Label()
        Me.lvLeave = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pcbHeader = New System.Windows.Forms.PictureBox()
        CType(Me.pcbHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(277, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search Employee"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearchEmployee
        '
        Me.txtSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmployee.Location = New System.Drawing.Point(12, 41)
        Me.txtSearchEmployee.Name = "txtSearchEmployee"
        Me.txtSearchEmployee.Size = New System.Drawing.Size(244, 26)
        Me.txtSearchEmployee.TabIndex = 7
        '
        'lblSearchEmployee
        '
        Me.lblSearchEmployee.AutoSize = True
        Me.lblSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchEmployee.Location = New System.Drawing.Point(12, 18)
        Me.lblSearchEmployee.Name = "lblSearchEmployee"
        Me.lblSearchEmployee.Size = New System.Drawing.Size(134, 20)
        Me.lblSearchEmployee.TabIndex = 6
        Me.lblSearchEmployee.Text = "Search Employee"
        '
        'lvLeave
        '
        Me.lvLeave.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvLeave.GridLines = True
        Me.lvLeave.Location = New System.Drawing.Point(12, 79)
        Me.lvLeave.Name = "lvLeave"
        Me.lvLeave.Size = New System.Drawing.Size(807, 283)
        Me.lvLeave.TabIndex = 5
        Me.lvLeave.UseCompatibleStateImageBehavior = False
        Me.lvLeave.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Employee Code"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Employee Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Department"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Leave"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Starting Day"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Last Day"
        Me.ColumnHeader7.Width = 100
        '
        'pcbHeader
        '
        Me.pcbHeader.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.header_name
        Me.pcbHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbHeader.Location = New System.Drawing.Point(420, 17)
        Me.pcbHeader.Name = "pcbHeader"
        Me.pcbHeader.Size = New System.Drawing.Size(399, 50)
        Me.pcbHeader.TabIndex = 9
        Me.pcbHeader.TabStop = False
        '
        'frmSubLeaveMoreInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 378)
        Me.Controls.Add(Me.pcbHeader)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchEmployee)
        Me.Controls.Add(Me.lblSearchEmployee)
        Me.Controls.Add(Me.lvLeave)
        Me.MaximumSize = New System.Drawing.Size(847, 417)
        Me.MinimumSize = New System.Drawing.Size(847, 417)
        Me.Name = "frmSubLeaveMoreInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Leave Information"
        CType(Me.pcbHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbHeader As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchEmployee As TextBox
    Friend WithEvents lblSearchEmployee As Label
    Friend WithEvents lvLeave As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
