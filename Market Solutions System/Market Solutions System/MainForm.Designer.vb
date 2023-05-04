<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        MenuStrip1 = New MenuStrip()
        SalesToolStripMenuItem = New ToolStripMenuItem()
        CashSalesToolStripMenuItem = New ToolStripMenuItem()
        ProductToolStripMenuItem = New ToolStripMenuItem()
        AddProductToolStripMenuItem = New ToolStripMenuItem()
        ViewProductsToolStripMenuItem = New ToolStripMenuItem()
        RemoveProductsToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        AddManufacturerToolStripMenuItem = New ToolStripMenuItem()
        Button1 = New Button()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SalesToolStripMenuItem, ProductToolStripMenuItem, EmployeeToolStripMenuItem, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(700, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SalesToolStripMenuItem
        ' 
        SalesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CashSalesToolStripMenuItem})
        SalesToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        SalesToolStripMenuItem.Size = New Size(56, 24)
        SalesToolStripMenuItem.Text = "Sales"
        ' 
        ' CashSalesToolStripMenuItem
        ' 
        CashSalesToolStripMenuItem.Name = "CashSalesToolStripMenuItem"
        CashSalesToolStripMenuItem.Size = New Size(100, 24)
        CashSalesToolStripMenuItem.Text = "Bill"
        ' 
        ' ProductToolStripMenuItem
        ' 
        ProductToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddProductToolStripMenuItem, ViewProductsToolStripMenuItem, RemoveProductsToolStripMenuItem})
        ProductToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        ProductToolStripMenuItem.Size = New Size(76, 24)
        ProductToolStripMenuItem.Text = "Product"
        ' 
        ' AddProductToolStripMenuItem
        ' 
        AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        AddProductToolStripMenuItem.Size = New Size(201, 24)
        AddProductToolStripMenuItem.Text = "Add Product"
        ' 
        ' ViewProductsToolStripMenuItem
        ' 
        ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        ViewProductsToolStripMenuItem.Size = New Size(201, 24)
        ViewProductsToolStripMenuItem.Text = "View Products"
        ' 
        ' RemoveProductsToolStripMenuItem
        ' 
        RemoveProductsToolStripMenuItem.Name = "RemoveProductsToolStripMenuItem"
        RemoveProductsToolStripMenuItem.Size = New Size(201, 24)
        RemoveProductsToolStripMenuItem.Text = "Remove Products"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddManufacturerToolStripMenuItem})
        EmployeeToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(117, 24)
        EmployeeToolStripMenuItem.Text = "Manufacturer"
        ' 
        ' AddManufacturerToolStripMenuItem
        ' 
        AddManufacturerToolStripMenuItem.Name = "AddManufacturerToolStripMenuItem"
        AddManufacturerToolStripMenuItem.Size = New Size(207, 24)
        AddManufacturerToolStripMenuItem.Text = "Add Manufacturer"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(592, 27)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 1
        Button1.Text = "< Logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2})
        ToolStripMenuItem1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(86, 24)
        ToolStripMenuItem1.Text = "Feedback"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(180, 24)
        ToolStripMenuItem2.Text = "View"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "MainForm"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashSalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddManufacturerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents RemoveProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
