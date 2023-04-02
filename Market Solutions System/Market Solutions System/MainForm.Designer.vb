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
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        AddManufacturerToolStripMenuItem = New ToolStripMenuItem()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SalesToolStripMenuItem, ProductToolStripMenuItem, EmployeeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SalesToolStripMenuItem
        ' 
        SalesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CashSalesToolStripMenuItem})
        SalesToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        SalesToolStripMenuItem.Size = New Size(69, 29)
        SalesToolStripMenuItem.Text = "Sales"
        ' 
        ' CashSalesToolStripMenuItem
        ' 
        CashSalesToolStripMenuItem.Name = "CashSalesToolStripMenuItem"
        CashSalesToolStripMenuItem.Size = New Size(224, 30)
        CashSalesToolStripMenuItem.Text = "Bill"
        ' 
        ' ProductToolStripMenuItem
        ' 
        ProductToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddProductToolStripMenuItem, ViewProductsToolStripMenuItem})
        ProductToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        ProductToolStripMenuItem.Size = New Size(93, 29)
        ProductToolStripMenuItem.Text = "Product"
        ' 
        ' AddProductToolStripMenuItem
        ' 
        AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        AddProductToolStripMenuItem.Size = New Size(219, 30)
        AddProductToolStripMenuItem.Text = "Add Product"
        ' 
        ' ViewProductsToolStripMenuItem
        ' 
        ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        ViewProductsToolStripMenuItem.Size = New Size(219, 30)
        ViewProductsToolStripMenuItem.Text = "View Products"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddManufacturerToolStripMenuItem})
        EmployeeToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(143, 29)
        EmployeeToolStripMenuItem.Text = "Manufacturer"
        ' 
        ' AddManufacturerToolStripMenuItem
        ' 
        AddManufacturerToolStripMenuItem.Name = "AddManufacturerToolStripMenuItem"
        AddManufacturerToolStripMenuItem.Size = New Size(255, 30)
        AddManufacturerToolStripMenuItem.Text = "Add Manufacturer"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(587, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
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
End Class
