<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CompCb = New ComboBox()
        QtyTB = New TextBox()
        ProdNameTB = New TextBox()
        UnitPriceTB = New TextBox()
        Button1 = New Button()
        backBtn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1078, 82)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(448, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 50)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(281, 35)
        Label2.TabIndex = 1
        Label2.Text = "Product Details _________"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(22, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 28)
        Label4.TabIndex = 4
        Label4.Text = "Company"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(697, 268)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 28)
        Label5.TabIndex = 5
        Label5.Text = "Quantity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(22, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 28)
        Label6.TabIndex = 6
        Label6.Text = "Product Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(689, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 28)
        Label7.TabIndex = 7
        Label7.Text = "Unit Price"
        ' 
        ' CompCb
        ' 
        CompCb.FormattingEnabled = True
        CompCb.Location = New Point(191, 268)
        CompCb.Name = "CompCb"
        CompCb.Size = New Size(163, 28)
        CompCb.TabIndex = 9
        ' 
        ' QtyTB
        ' 
        QtyTB.Location = New Point(888, 272)
        QtyTB.Name = "QtyTB"
        QtyTB.Size = New Size(163, 27)
        QtyTB.TabIndex = 10
        ' 
        ' ProdNameTB
        ' 
        ProdNameTB.Location = New Point(191, 184)
        ProdNameTB.Name = "ProdNameTB"
        ProdNameTB.Size = New Size(163, 27)
        ProdNameTB.TabIndex = 11
        ' 
        ' UnitPriceTB
        ' 
        UnitPriceTB.Location = New Point(888, 174)
        UnitPriceTB.Name = "UnitPriceTB"
        UnitPriceTB.Size = New Size(163, 27)
        UnitPriceTB.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(492, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 15
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' backBtn
        ' 
        backBtn.Location = New Point(942, 105)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(94, 29)
        backBtn.TabIndex = 18
        backBtn.Text = "< Go Back"
        backBtn.UseVisualStyleBackColor = True
        ' 
        ' AddProductForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 492)
        Controls.Add(backBtn)
        Controls.Add(Button1)
        Controls.Add(UnitPriceTB)
        Controls.Add(ProdNameTB)
        Controls.Add(QtyTB)
        Controls.Add(CompCb)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "AddProductForm"
        Text = "AddProductForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CompCb As ComboBox
    Friend WithEvents QtyTB As TextBox
    Friend WithEvents ProdNameTB As TextBox
    Friend WithEvents UnitPriceTB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents backBtn As Button
End Class
