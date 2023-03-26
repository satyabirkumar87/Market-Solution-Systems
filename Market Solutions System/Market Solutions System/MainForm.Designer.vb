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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.ProductToolStripMenuItem, Me.EmployeeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashSalesToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'CashSalesToolStripMenuItem
        '
        Me.CashSalesToolStripMenuItem.Name = "CashSalesToolStripMenuItem"
        Me.CashSalesToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.CashSalesToolStripMenuItem.Text = "Cash Sales"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem, Me.ViewProductsToolStripMenuItem})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.AddProductToolStripMenuItem.Text = "Add Product"
        '
        'ViewProductsToolStripMenuItem
        '
        Me.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        Me.ViewProductsToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ViewProductsToolStripMenuItem.Text = "View Products"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.EmployeeToolStripMenuItem.Text = "Customer"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashSalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
End Class
