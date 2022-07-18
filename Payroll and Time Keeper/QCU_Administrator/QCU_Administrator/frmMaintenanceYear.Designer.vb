<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenanceYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenanceYear))
        Me.txtYearDesc = New System.Windows.Forms.TextBox()
        Me.txtYearCode = New System.Windows.Forms.TextBox()
        Me.lblYearDesc = New System.Windows.Forms.Label()
        Me.lblYearCode = New System.Windows.Forms.Label()
        Me.txtYearID = New System.Windows.Forms.TextBox()
        Me.lblYearID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lvYear = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtYearDesc
        '
        Me.txtYearDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearDesc.Location = New System.Drawing.Point(12, 127)
        Me.txtYearDesc.Name = "txtYearDesc"
        Me.txtYearDesc.Size = New System.Drawing.Size(367, 24)
        Me.txtYearDesc.TabIndex = 62
        '
        'txtYearCode
        '
        Me.txtYearCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearCode.Location = New System.Drawing.Point(12, 80)
        Me.txtYearCode.Name = "txtYearCode"
        Me.txtYearCode.Size = New System.Drawing.Size(187, 24)
        Me.txtYearCode.TabIndex = 61
        '
        'lblYearDesc
        '
        Me.lblYearDesc.AutoSize = True
        Me.lblYearDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearDesc.ForeColor = System.Drawing.Color.White
        Me.lblYearDesc.Location = New System.Drawing.Point(12, 107)
        Me.lblYearDesc.Name = "lblYearDesc"
        Me.lblYearDesc.Size = New System.Drawing.Size(108, 16)
        Me.lblYearDesc.TabIndex = 60
        Me.lblYearDesc.Text = "Year Description"
        '
        'lblYearCode
        '
        Me.lblYearCode.AutoSize = True
        Me.lblYearCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearCode.ForeColor = System.Drawing.Color.White
        Me.lblYearCode.Location = New System.Drawing.Point(12, 61)
        Me.lblYearCode.Name = "lblYearCode"
        Me.lblYearCode.Size = New System.Drawing.Size(73, 16)
        Me.lblYearCode.TabIndex = 59
        Me.lblYearCode.Text = "Year Code"
        '
        'txtYearID
        '
        Me.txtYearID.Enabled = False
        Me.txtYearID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearID.Location = New System.Drawing.Point(12, 34)
        Me.txtYearID.Name = "txtYearID"
        Me.txtYearID.Size = New System.Drawing.Size(187, 24)
        Me.txtYearID.TabIndex = 58
        '
        'lblYearID
        '
        Me.lblYearID.AutoSize = True
        Me.lblYearID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearID.ForeColor = System.Drawing.Color.White
        Me.lblYearID.Location = New System.Drawing.Point(13, 15)
        Me.lblYearID.Name = "lblYearID"
        Me.lblYearID.Size = New System.Drawing.Size(53, 16)
        Me.lblYearID.TabIndex = 57
        Me.lblYearID.Text = "Year ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(221, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 45)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Delete Year"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 45)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Add Year"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lvYear
        '
        Me.lvYear.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvYear.GridLines = True
        Me.lvYear.Location = New System.Drawing.Point(12, 163)
        Me.lvYear.Name = "lvYear"
        Me.lvYear.Size = New System.Drawing.Size(415, 168)
        Me.lvYear.TabIndex = 63
        Me.lvYear.UseCompatibleStateImageBehavior = False
        Me.lvYear.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Course ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Course Code"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course Description"
        Me.ColumnHeader3.Width = 250
        '
        'frmMaintenanceYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(439, 394)
        Me.Controls.Add(Me.lvYear)
        Me.Controls.Add(Me.txtYearDesc)
        Me.Controls.Add(Me.txtYearCode)
        Me.Controls.Add(Me.lblYearDesc)
        Me.Controls.Add(Me.lblYearCode)
        Me.Controls.Add(Me.txtYearID)
        Me.Controls.Add(Me.lblYearID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(455, 433)
        Me.MinimumSize = New System.Drawing.Size(455, 433)
        Me.Name = "frmMaintenanceYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Year Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtYearDesc As TextBox
    Friend WithEvents txtYearCode As TextBox
    Friend WithEvents lblYearDesc As Label
    Friend WithEvents lblYearCode As Label
    Friend WithEvents txtYearID As TextBox
    Friend WithEvents lblYearID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lvYear As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
