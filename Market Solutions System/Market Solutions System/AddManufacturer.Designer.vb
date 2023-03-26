<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddManufacturer
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        NameTB = New TextBox()
        PhonenoTB = New TextBox()
        AddressTB = New TextBox()
        AddBtn = New Button()
        backBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(295, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(295, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 1
        Label2.Text = "Phone no"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(295, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 2
        Label3.Text = "Address"
        ' 
        ' NameTB
        ' 
        NameTB.Location = New Point(381, 107)
        NameTB.Name = "NameTB"
        NameTB.Size = New Size(125, 27)
        NameTB.TabIndex = 3
        ' 
        ' PhonenoTB
        ' 
        PhonenoTB.Location = New Point(381, 167)
        PhonenoTB.Name = "PhonenoTB"
        PhonenoTB.Size = New Size(125, 27)
        PhonenoTB.TabIndex = 4
        ' 
        ' AddressTB
        ' 
        AddressTB.Location = New Point(381, 223)
        AddressTB.Name = "AddressTB"
        AddressTB.Size = New Size(125, 27)
        AddressTB.TabIndex = 5
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(367, 314)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(94, 29)
        AddBtn.TabIndex = 6
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' backBtn
        ' 
        backBtn.Location = New Point(660, 33)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(94, 29)
        backBtn.TabIndex = 19
        backBtn.Text = "< Go Back"
        backBtn.UseVisualStyleBackColor = True
        ' 
        ' AddManufacturer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(backBtn)
        Controls.Add(AddBtn)
        Controls.Add(AddressTB)
        Controls.Add(PhonenoTB)
        Controls.Add(NameTB)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddManufacturer"
        Text = "Manufacture"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTB As TextBox
    Friend WithEvents PhonenoTB As TextBox
    Friend WithEvents AddressTB As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents backBtn As Button
End Class
