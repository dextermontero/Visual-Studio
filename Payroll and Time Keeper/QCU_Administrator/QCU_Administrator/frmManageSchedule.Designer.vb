<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageSchedule))
        Me.lvReports = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblEmployeeCode = New System.Windows.Forms.Label()
        Me.txtEmployeeCode = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnManageAdd = New System.Windows.Forms.Button()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.reload = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lvReports
        '
        Me.lvReports.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvReports.GridLines = True
        Me.lvReports.Location = New System.Drawing.Point(12, 71)
        Me.lvReports.Name = "lvReports"
        Me.lvReports.Size = New System.Drawing.Size(1024, 283)
        Me.lvReports.TabIndex = 0
        Me.lvReports.UseCompatibleStateImageBehavior = False
        Me.lvReports.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Employee Code"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "First Name"
        Me.ColumnHeader8.Width = 115
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Last Name"
        Me.ColumnHeader9.Width = 115
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Section-Subject"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Unit"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Room"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Day"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Time"
        Me.ColumnHeader6.Width = 120
        '
        'lblEmployeeCode
        '
        Me.lblEmployeeCode.AutoSize = True
        Me.lblEmployeeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeCode.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeCode.Location = New System.Drawing.Point(10, 16)
        Me.lblEmployeeCode.Name = "lblEmployeeCode"
        Me.lblEmployeeCode.Size = New System.Drawing.Size(134, 20)
        Me.lblEmployeeCode.TabIndex = 1
        Me.lblEmployeeCode.Text = "Search Employee"
        '
        'txtEmployeeCode
        '
        Me.txtEmployeeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeCode.Location = New System.Drawing.Point(13, 39)
        Me.txtEmployeeCode.Name = "txtEmployeeCode"
        Me.txtEmployeeCode.Size = New System.Drawing.Size(217, 26)
        Me.txtEmployeeCode.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(918, 371)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 33)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnManageAdd
        '
        Me.btnManageAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnManageAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnManageAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnManageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageAdd.ForeColor = System.Drawing.Color.White
        Me.btnManageAdd.Location = New System.Drawing.Point(149, 371)
        Me.btnManageAdd.Name = "btnManageAdd"
        Me.btnManageAdd.Size = New System.Drawing.Size(118, 33)
        Me.btnManageAdd.TabIndex = 10
        Me.btnManageAdd.Text = "Manage Schedule"
        Me.btnManageAdd.UseVisualStyleBackColor = False
        '
        'btnAddClass
        '
        Me.btnAddClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnAddClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddClass.ForeColor = System.Drawing.Color.White
        Me.btnAddClass.Location = New System.Drawing.Point(18, 371)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(118, 33)
        Me.btnAddClass.TabIndex = 9
        Me.btnAddClass.Text = "Add Schedule"
        Me.btnAddClass.UseVisualStyleBackColor = False
        '
        'reload
        '
        Me.reload.Interval = 1000
        '
        'frmManageSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1056, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnManageAdd)
        Me.Controls.Add(Me.btnAddClass)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtEmployeeCode)
        Me.Controls.Add(Me.lblEmployeeCode)
        Me.Controls.Add(Me.lvReports)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1072, 457)
        Me.MinimumSize = New System.Drawing.Size(1072, 457)
        Me.Name = "frmManageSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Manage Add Class Schedule Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvReports As ListView
    Friend WithEvents lblEmployeeCode As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents txtEmployeeCode As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnManageAdd As Button
    Friend WithEvents btnAddClass As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents reload As Timer
End Class
