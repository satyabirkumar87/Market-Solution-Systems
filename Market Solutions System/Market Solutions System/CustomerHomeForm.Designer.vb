<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerHomeForm
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
        MenuStrip3 = New MenuStrip()
        ProductToolStripMenuItem = New ToolStripMenuItem()
        PurchaseProductToolStripMenuItem = New ToolStripMenuItem()
        FeedbackToolStripMenuItem = New ToolStripMenuItem()
        RateToolStripMenuItem = New ToolStripMenuItem()
        Button1 = New Button()
        MenuStrip3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip3
        ' 
        MenuStrip3.ImageScalingSize = New Size(20, 20)
        MenuStrip3.Items.AddRange(New ToolStripItem() {ProductToolStripMenuItem, FeedbackToolStripMenuItem})
        MenuStrip3.Location = New Point(0, 0)
        MenuStrip3.Name = "MenuStrip3"
        MenuStrip3.Size = New Size(800, 33)
        MenuStrip3.TabIndex = 2
        MenuStrip3.Text = "MenuStrip3"
        ' 
        ' ProductToolStripMenuItem
        ' 
        ProductToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PurchaseProductToolStripMenuItem})
        ProductToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        ProductToolStripMenuItem.Size = New Size(93, 29)
        ProductToolStripMenuItem.Text = "Product"
        ' 
        ' PurchaseProductToolStripMenuItem
        ' 
        PurchaseProductToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        PurchaseProductToolStripMenuItem.Name = "PurchaseProductToolStripMenuItem"
        PurchaseProductToolStripMenuItem.Size = New Size(247, 30)
        PurchaseProductToolStripMenuItem.Text = "Purchase Product"
        ' 
        ' FeedbackToolStripMenuItem
        ' 
        FeedbackToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RateToolStripMenuItem})
        FeedbackToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        FeedbackToolStripMenuItem.Size = New Size(104, 29)
        FeedbackToolStripMenuItem.Text = "feedback"
        ' 
        ' RateToolStripMenuItem
        ' 
        RateToolStripMenuItem.Name = "RateToolStripMenuItem"
        RateToolStripMenuItem.Size = New Size(142, 30)
        RateToolStripMenuItem.Text = " Rate"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(678, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "< Logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CustomerHomeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(MenuStrip3)
        Name = "CustomerHomeForm"
        Text = "CustomerHomeForm"
        MenuStrip3.ResumeLayout(False)
        MenuStrip3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RateToolStripMenuItem As ToolStripMenuItem
End Class
