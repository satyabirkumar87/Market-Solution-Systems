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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CompCb = New System.Windows.Forms.ComboBox()
        Me.QtyTB = New System.Windows.Forms.TextBox()
        Me.ProdNameTB = New System.Windows.Forms.TextBox()
        Me.UnitPriceTB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(448, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Details _________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(22, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Company"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(697, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(22, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Product Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(689, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Unit Price"
        '
        'CompCb
        '
        Me.CompCb.FormattingEnabled = True
        Me.CompCb.Location = New System.Drawing.Point(191, 268)
        Me.CompCb.Name = "CompCb"
        Me.CompCb.Size = New System.Drawing.Size(163, 28)
        Me.CompCb.TabIndex = 9
        '
        'QtyTB
        '
        Me.QtyTB.Location = New System.Drawing.Point(888, 272)
        Me.QtyTB.Name = "QtyTB"
        Me.QtyTB.Size = New System.Drawing.Size(163, 27)
        Me.QtyTB.TabIndex = 10
        '
        'ProdNameTB
        '
        Me.ProdNameTB.Location = New System.Drawing.Point(191, 184)
        Me.ProdNameTB.Name = "ProdNameTB"
        Me.ProdNameTB.Size = New System.Drawing.Size(163, 27)
        Me.ProdNameTB.TabIndex = 11
        '
        'UnitPriceTB
        '
        Me.UnitPriceTB.Location = New System.Drawing.Point(888, 174)
        Me.UnitPriceTB.Name = "UnitPriceTB"
        Me.UnitPriceTB.Size = New System.Drawing.Size(163, 27)
        Me.UnitPriceTB.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(540, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(833, 390)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "REMOVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AddProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 492)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UnitPriceTB)
        Me.Controls.Add(Me.ProdNameTB)
        Me.Controls.Add(Me.QtyTB)
        Me.Controls.Add(Me.CompCb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddProductForm"
        Me.Text = "AddProductForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
