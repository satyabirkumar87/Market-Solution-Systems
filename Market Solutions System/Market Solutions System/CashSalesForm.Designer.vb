<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashSalesForm
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
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        ItemCode = New DataGridViewTextBoxColumn()
        UniqueId = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        discount = New DataGridViewTextBoxColumn()
        amt = New DataGridViewTextBoxColumn()
        tax = New DataGridViewTextBoxColumn()
        rate = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(511, 174)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(137, 91)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(137, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 1
        Label2.Text = "Bill Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 0
        Label1.Text = "Bill No"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ItemCode, UniqueId, Quantity, discount, amt, tax, rate})
        DataGridView1.Location = New Point(12, 219)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(776, 188)
        DataGridView1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(90, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 5
        Label3.Text = "Amount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(90, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 6
        Label4.Text = "Discount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(90, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 20)
        Label5.TabIndex = 7
        Label5.Text = "Tax"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(182, 33)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(182, 91)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(182, 151)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(359, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 20)
        Label6.TabIndex = 11
        Label6.Text = "Total Amount"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(359, 91)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 20)
        Label7.TabIndex = 12
        Label7.Text = "Amount Paid"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(359, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 20)
        Label8.TabIndex = 13
        Label8.Text = "Balance"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(479, 36)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(479, 90)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 15
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(479, 151)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 27)
        TextBox7.TabIndex = 16
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(41, 442)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(646, 206)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(863, 266)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 18
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(863, 320)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 19
        Button2.Text = "Remove"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ItemCode
        ' 
        ItemCode.HeaderText = "Item Code"
        ItemCode.MinimumWidth = 6
        ItemCode.Name = "ItemCode"
        ItemCode.Width = 125
        ' 
        ' UniqueId
        ' 
        UniqueId.HeaderText = "Unique ID"
        UniqueId.MinimumWidth = 6
        UniqueId.Name = "UniqueId"
        UniqueId.Width = 125
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.MinimumWidth = 6
        Quantity.Name = "Quantity"
        Quantity.Width = 125
        ' 
        ' discount
        ' 
        discount.HeaderText = "Discount"
        discount.MinimumWidth = 6
        discount.Name = "discount"
        discount.Width = 125
        ' 
        ' amt
        ' 
        amt.HeaderText = "Amount"
        amt.MinimumWidth = 6
        amt.Name = "amt"
        amt.Width = 125
        ' 
        ' tax
        ' 
        tax.HeaderText = "Tax"
        tax.MinimumWidth = 6
        tax.Name = "tax"
        tax.Width = 125
        ' 
        ' rate
        ' 
        rate.HeaderText = "Rate"
        rate.MinimumWidth = 6
        rate.Name = "rate"
        rate.Width = 125
        ' 
        ' CashSalesForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "CashSalesForm"
        Text = "CashSalesForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents UniqueId As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents amt As DataGridViewTextBoxColumn
    Friend WithEvents tax As DataGridViewTextBoxColumn
    Friend WithEvents rate As DataGridViewTextBoxColumn
End Class
