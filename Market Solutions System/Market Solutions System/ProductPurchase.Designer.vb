<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductPurchase
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
        ProdNameCB = New ComboBox()
        PriceTB = New TextBox()
        QtyTB = New TextBox()
        PurchaseBtn = New Button()
        CancelBtn = New Button()
        Button1 = New Button()
        Label4 = New Label()
        totalTB = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 0
        Label1.Text = "Product Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(239, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 1
        Label2.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(239, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 2
        Label3.Text = "Quantity"
        ' 
        ' ProdNameCB
        ' 
        ProdNameCB.DropDownStyle = ComboBoxStyle.DropDownList
        ProdNameCB.FormattingEnabled = True
        ProdNameCB.Location = New Point(433, 99)
        ProdNameCB.Name = "ProdNameCB"
        ProdNameCB.Size = New Size(125, 28)
        ProdNameCB.TabIndex = 3
        ' 
        ' PriceTB
        ' 
        PriceTB.Location = New Point(433, 145)
        PriceTB.Name = "PriceTB"
        PriceTB.ReadOnly = True
        PriceTB.Size = New Size(125, 27)
        PriceTB.TabIndex = 4
        ' 
        ' QtyTB
        ' 
        QtyTB.Location = New Point(433, 198)
        QtyTB.Name = "QtyTB"
        QtyTB.Size = New Size(125, 27)
        QtyTB.TabIndex = 5
        ' 
        ' PurchaseBtn
        ' 
        PurchaseBtn.Location = New Point(210, 337)
        PurchaseBtn.Name = "PurchaseBtn"
        PurchaseBtn.Size = New Size(94, 29)
        PurchaseBtn.TabIndex = 6
        PurchaseBtn.Text = "Purchase"
        PurchaseBtn.UseVisualStyleBackColor = True
        ' 
        ' CancelBtn
        ' 
        CancelBtn.Location = New Point(496, 337)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(94, 29)
        CancelBtn.TabIndex = 7
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(672, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "Go Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(239, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 9
        Label4.Text = "Total"
        ' 
        ' totalTB
        ' 
        totalTB.Location = New Point(433, 244)
        totalTB.Name = "totalTB"
        totalTB.ReadOnly = True
        totalTB.Size = New Size(125, 27)
        totalTB.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(351, 337)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 11
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ProductPurchase
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(totalTB)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(CancelBtn)
        Controls.Add(PurchaseBtn)
        Controls.Add(QtyTB)
        Controls.Add(PriceTB)
        Controls.Add(ProdNameCB)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ProductPurchase"
        Text = "ProductPurchase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProdNameCB As ComboBox
    Friend WithEvents PriceTB As TextBox
    Friend WithEvents QtyTB As TextBox
    Friend WithEvents PurchaseBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents totalTB As TextBox
    Friend WithEvents Button2 As Button
End Class
