<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbUsername = New System.Windows.Forms.TextBox()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lnklabAccCreate = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'txtbUsername
        '
        Me.txtbUsername.Location = New System.Drawing.Point(112, 75)
        Me.txtbUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbUsername.Name = "txtbUsername"
        Me.txtbUsername.Size = New System.Drawing.Size(185, 26)
        Me.txtbUsername.TabIndex = 5
        '
        'txtbPassword
        '
        Me.txtbPassword.Location = New System.Drawing.Point(116, 139)
        Me.txtbPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(185, 26)
        Me.txtbPassword.TabIndex = 6
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(549, 218)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(88, 40)
        Me.btnLogIn.TabIndex = 7
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(549, 264)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 40)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lnklabAccCreate
        '
        Me.lnklabAccCreate.AutoSize = True
        Me.lnklabAccCreate.Location = New System.Drawing.Point(108, 276)
        Me.lnklabAccCreate.Name = "lnklabAccCreate"
        Me.lnklabAccCreate.Size = New System.Drawing.Size(120, 20)
        Me.lnklabAccCreate.TabIndex = 9
        Me.lnklabAccCreate.TabStop = True
        Me.lnklabAccCreate.Text = "Create Account"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.lnklabAccCreate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.txtbUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbUsername As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lnklabAccCreate As LinkLabel
End Class
