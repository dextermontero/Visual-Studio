<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageEmployee
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageEmployee))
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.txtSearchEmployee = New System.Windows.Forms.TextBox()
        Me.lblSearchEmployee = New System.Windows.Forms.Label()
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnManageEmployee = New System.Windows.Forms.Button()
        Me.reload = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.Location = New System.Drawing.Point(12, 376)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(118, 33)
        Me.btnAddEmployee.TabIndex = 9
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'txtSearchEmployee
        '
        Me.txtSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmployee.Location = New System.Drawing.Point(12, 43)
        Me.txtSearchEmployee.Name = "txtSearchEmployee"
        Me.txtSearchEmployee.Size = New System.Drawing.Size(244, 27)
        Me.txtSearchEmployee.TabIndex = 8
        '
        'lblSearchEmployee
        '
        Me.lblSearchEmployee.AutoSize = True
        Me.lblSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchEmployee.ForeColor = System.Drawing.Color.White
        Me.lblSearchEmployee.Location = New System.Drawing.Point(12, 15)
        Me.lblSearchEmployee.Name = "lblSearchEmployee"
        Me.lblSearchEmployee.Size = New System.Drawing.Size(134, 20)
        Me.lblSearchEmployee.TabIndex = 7
        Me.lblSearchEmployee.Text = "Search Employee"
        '
        'lvEmployee
        '
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.Location = New System.Drawing.Point(12, 83)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(1032, 283)
        Me.lvEmployee.TabIndex = 6
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Employee Code"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Middle Name"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last Name"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Department"
        Me.ColumnHeader4.Width = 155
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Position"
        Me.ColumnHeader5.Width = 143
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date Hired"
        Me.ColumnHeader6.Width = 140
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Job Type"
        Me.ColumnHeader8.Width = 130
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(926, 376)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 33)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnManageEmployee
        '
        Me.btnManageEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnManageEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnManageEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageEmployee.ForeColor = System.Drawing.Color.White
        Me.btnManageEmployee.Location = New System.Drawing.Point(138, 376)
        Me.btnManageEmployee.Name = "btnManageEmployee"
        Me.btnManageEmployee.Size = New System.Drawing.Size(118, 33)
        Me.btnManageEmployee.TabIndex = 11
        Me.btnManageEmployee.Text = "Manage Employee"
        Me.btnManageEmployee.UseVisualStyleBackColor = False
        '
        'reload
        '
        Me.reload.Interval = 1000
        '
        'frmManageEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1056, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnManageEmployee)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.txtSearchEmployee)
        Me.Controls.Add(Me.lblSearchEmployee)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1072, 457)
        Me.MinimumSize = New System.Drawing.Size(1072, 457)
        Me.Name = "frmManageEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Manage Employee Infomation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents txtSearchEmployee As TextBox
    Friend WithEvents lblSearchEmployee As Label
    Friend WithEvents lvEmployee As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnClose As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnManageEmployee As Button
    Friend WithEvents reload As Timer
End Class
