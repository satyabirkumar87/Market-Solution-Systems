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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProdNameCB = New System.Windows.Forms.ComboBox()
        Me.PriceTB = New System.Windows.Forms.TextBox()
        Me.QtyTB = New System.Windows.Forms.TextBox()
        Me.PurchaseBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity"
        '
        'ProdNameCB
        '
        Me.ProdNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProdNameCB.FormattingEnabled = True
        Me.ProdNameCB.Items.AddRange(New Object() {"coco cola", "Kurkure", "Kitkat", "Jam", "Bourborn", "Lays", "Top", "Amul"})
        Me.ProdNameCB.Location = New System.Drawing.Point(245, 99)
        Me.ProdNameCB.Name = "ProdNameCB"
        Me.ProdNameCB.Size = New System.Drawing.Size(151, 28)
        Me.ProdNameCB.TabIndex = 3
        '
        'PriceTB
        '
        Me.PriceTB.Location = New System.Drawing.Point(253, 165)
        Me.PriceTB.Name = "PriceTB"
        Me.PriceTB.Size = New System.Drawing.Size(125, 27)
        Me.PriceTB.TabIndex = 4
        '
        'QtyTB
        '
        Me.QtyTB.Location = New System.Drawing.Point(253, 231)
        Me.QtyTB.Name = "QtyTB"
        Me.QtyTB.Size = New System.Drawing.Size(125, 27)
        Me.QtyTB.TabIndex = 5
        '
        'PurchaseBtn
        '
        Me.PurchaseBtn.Location = New System.Drawing.Point(275, 337)
        Me.PurchaseBtn.Name = "PurchaseBtn"
        Me.PurchaseBtn.Size = New System.Drawing.Size(94, 29)
        Me.PurchaseBtn.TabIndex = 6
        Me.PurchaseBtn.Text = "Purchase"
        Me.PurchaseBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(493, 337)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(94, 29)
        Me.CancelBtn.TabIndex = 7
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(587, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.PurchaseBtn)
        Me.Controls.Add(Me.QtyTB)
        Me.Controls.Add(Me.PriceTB)
        Me.Controls.Add(Me.ProdNameCB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProductPurchase"
        Me.Text = "ProductPurchase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
