<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedbackForm
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
        feedbackRTB = New RichTextBox()
        Label2 = New Label()
        submitBtn = New Button()
        Button1 = New Button()
        ratingSelector = New ComboBox()
        productCB = New ComboBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(489, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 1
        Label1.Text = "Select Rating"
        ' 
        ' feedbackRTB
        ' 
        feedbackRTB.Location = New Point(51, 121)
        feedbackRTB.Name = "feedbackRTB"
        feedbackRTB.Size = New Size(698, 265)
        feedbackRTB.TabIndex = 2
        feedbackRTB.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(270, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(261, 28)
        Label2.TabIndex = 3
        Label2.Text = "Please Submit A Feedback :)"
        ' 
        ' submitBtn
        ' 
        submitBtn.Location = New Point(353, 409)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(94, 29)
        submitBtn.TabIndex = 4
        submitBtn.Text = "Submit"
        submitBtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(694, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "< Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ratingSelector
        ' 
        ratingSelector.DropDownStyle = ComboBoxStyle.DropDownList
        ratingSelector.FormattingEnabled = True
        ratingSelector.Location = New Point(602, 72)
        ratingSelector.Name = "ratingSelector"
        ratingSelector.Size = New Size(94, 28)
        ratingSelector.TabIndex = 6
        ' 
        ' productCB
        ' 
        productCB.DropDownStyle = ComboBoxStyle.DropDownList
        productCB.FormattingEnabled = True
        productCB.Location = New Point(215, 72)
        productCB.Name = "productCB"
        productCB.Size = New Size(151, 28)
        productCB.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 8
        Label3.Text = "Select Product"
        ' 
        ' FeedbackForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(productCB)
        Controls.Add(ratingSelector)
        Controls.Add(Button1)
        Controls.Add(submitBtn)
        Controls.Add(Label2)
        Controls.Add(feedbackRTB)
        Controls.Add(Label1)
        Name = "FeedbackForm"
        Text = "FeedbackForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents feedbackRTB As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents submitBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ratingSelector As ComboBox
    Friend WithEvents productCB As ComboBox
    Friend WithEvents Label3 As Label
End Class
