<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveProduct
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
        prodNameCB = New ComboBox()
        removeBtn = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(225, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 28)
        Label1.TabIndex = 0
        Label1.Text = "Select Product"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(277, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 41)
        Label2.TabIndex = 1
        Label2.Text = "Remove Product"
        ' 
        ' prodNameCB
        ' 
        prodNameCB.DropDownStyle = ComboBoxStyle.DropDownList
        prodNameCB.FormattingEnabled = True
        prodNameCB.Location = New Point(425, 213)
        prodNameCB.Name = "prodNameCB"
        prodNameCB.Size = New Size(151, 28)
        prodNameCB.TabIndex = 2
        ' 
        ' removeBtn
        ' 
        removeBtn.Location = New Point(349, 336)
        removeBtn.Name = "removeBtn"
        removeBtn.Size = New Size(94, 29)
        removeBtn.TabIndex = 3
        removeBtn.Text = "Remove"
        removeBtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(675, 45)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "< Go Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RemoveProduct
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(removeBtn)
        Controls.Add(prodNameCB)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "RemoveProduct"
        Text = "RemoveProduct"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents prodNameCB As ComboBox
    Friend WithEvents removeBtn As Button
    Friend WithEvents Button1 As Button
End Class
