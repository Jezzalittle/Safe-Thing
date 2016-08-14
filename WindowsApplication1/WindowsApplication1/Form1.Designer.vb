<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabCompName = New System.Windows.Forms.TextBox()
        Me.LabJobTime = New System.Windows.Forms.TextBox()
        Me.LabReminderTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEntJob = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labJobInfo = New System.Windows.Forms.Label()
        Me.txtbJobInfo = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(281, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 373)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Company Name"
        '
        'LabCompName
        '
        Me.LabCompName.Location = New System.Drawing.Point(125, 77)
        Me.LabCompName.Name = "LabCompName"
        Me.LabCompName.Size = New System.Drawing.Size(137, 20)
        Me.LabCompName.TabIndex = 2
        '
        'LabJobTime
        '
        Me.LabJobTime.Location = New System.Drawing.Point(125, 129)
        Me.LabJobTime.Name = "LabJobTime"
        Me.LabJobTime.Size = New System.Drawing.Size(137, 20)
        Me.LabJobTime.TabIndex = 3
        '
        'LabReminderTime
        '
        Me.LabReminderTime.Location = New System.Drawing.Point(125, 182)
        Me.LabReminderTime.Name = "LabReminderTime"
        Me.LabReminderTime.Size = New System.Drawing.Size(137, 20)
        Me.LabReminderTime.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Reminder Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Job Time(h)"
        '
        'BtnEntJob
        '
        Me.BtnEntJob.Location = New System.Drawing.Point(125, 417)
        Me.BtnEntJob.Name = "BtnEntJob"
        Me.BtnEntJob.Size = New System.Drawing.Size(100, 27)
        Me.BtnEntJob.TabIndex = 7
        Me.BtnEntJob.Text = "Enter Job"
        Me.BtnEntJob.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Column1
        '
        Me.Column1.HeaderText = "Company Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Time Left"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Job Start Time"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Job Finish Time "
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Reminder Time"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'labJobInfo
        '
        Me.labJobInfo.AutoSize = True
        Me.labJobInfo.Location = New System.Drawing.Point(38, 238)
        Me.labJobInfo.Name = "labJobInfo"
        Me.labJobInfo.Size = New System.Drawing.Size(45, 13)
        Me.labJobInfo.TabIndex = 8
        Me.labJobInfo.Text = "Job Info"
        '
        'txtbJobInfo
        '
        Me.txtbJobInfo.Location = New System.Drawing.Point(125, 235)
        Me.txtbJobInfo.Multiline = True
        Me.txtbJobInfo.Name = "txtbJobInfo"
        Me.txtbJobInfo.Size = New System.Drawing.Size(137, 167)
        Me.txtbJobInfo.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.txtbJobInfo)
        Me.Controls.Add(Me.labJobInfo)
        Me.Controls.Add(Me.BtnEntJob)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabReminderTime)
        Me.Controls.Add(Me.LabJobTime)
        Me.Controls.Add(Me.LabCompName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LabCompName As TextBox
    Friend WithEvents LabJobTime As TextBox
    Friend WithEvents LabReminderTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnEntJob As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents labJobInfo As Label
    Friend WithEvents txtbJobInfo As TextBox
End Class
