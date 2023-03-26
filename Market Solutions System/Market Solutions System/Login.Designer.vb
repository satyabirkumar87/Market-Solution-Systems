<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.admLoginBtn = New System.Windows.Forms.Button()
        Me.admPasswordTB = New System.Windows.Forms.TextBox()
        Me.admUsernameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.custLoginBtn = New System.Windows.Forms.Button()
        Me.custPasswordTB = New System.Windows.Forms.TextBox()
        Me.custUsernameTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(641, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.admLoginBtn)
        Me.GroupBox1.Controls.Add(Me.admPasswordTB)
        Me.GroupBox1.Controls.Add(Me.admUsernameTB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 363)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin Login"
        '
        'admLoginBtn
        '
        Me.admLoginBtn.Location = New System.Drawing.Point(198, 227)
        Me.admLoginBtn.Name = "admLoginBtn"
        Me.admLoginBtn.Size = New System.Drawing.Size(94, 29)
        Me.admLoginBtn.TabIndex = 4
        Me.admLoginBtn.Text = "Login"
        Me.admLoginBtn.UseVisualStyleBackColor = True
        '
        'admPasswordTB
        '
        Me.admPasswordTB.Location = New System.Drawing.Point(281, 153)
        Me.admPasswordTB.Name = "admPasswordTB"
        Me.admPasswordTB.Size = New System.Drawing.Size(125, 27)
        Me.admPasswordTB.TabIndex = 3
        '
        'admUsernameTB
        '
        Me.admUsernameTB.Location = New System.Drawing.Point(281, 106)
        Me.admUsernameTB.Name = "admUsernameTB"
        Me.admUsernameTB.Size = New System.Drawing.Size(125, 27)
        Me.admUsernameTB.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.custLoginBtn)
        Me.GroupBox2.Controls.Add(Me.custPasswordTB)
        Me.GroupBox2.Controls.Add(Me.custUsernameTB)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(821, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 374)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Login"
        '
        'custLoginBtn
        '
        Me.custLoginBtn.Location = New System.Drawing.Point(187, 231)
        Me.custLoginBtn.Name = "custLoginBtn"
        Me.custLoginBtn.Size = New System.Drawing.Size(94, 29)
        Me.custLoginBtn.TabIndex = 4
        Me.custLoginBtn.Text = "Login"
        Me.custLoginBtn.UseVisualStyleBackColor = True
        '
        'custPasswordTB
        '
        Me.custPasswordTB.Location = New System.Drawing.Point(266, 166)
        Me.custPasswordTB.Name = "custPasswordTB"
        Me.custPasswordTB.Size = New System.Drawing.Size(125, 27)
        Me.custPasswordTB.TabIndex = 3
        '
        'custUsernameTB
        '
        Me.custUsernameTB.Location = New System.Drawing.Point(266, 114)
        Me.custUsernameTB.Name = "custUsernameTB"
        Me.custUsernameTB.Size = New System.Drawing.Size(125, 27)
        Me.custUsernameTB.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Username"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents admLoginBtn As Button
    Friend WithEvents admPasswordTB As TextBox
    Friend WithEvents admUsernameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents custLoginBtn As Button
    Friend WithEvents custPasswordTB As TextBox
    Friend WithEvents custUsernameTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
