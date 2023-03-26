<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProducts
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
        ProductGV = New DataGridView()
        prodName = New DataGridViewTextBoxColumn()
        compName = New DataGridViewTextBoxColumn()
        prodPrice = New DataGridViewTextBoxColumn()
        prodQty = New DataGridViewTextBoxColumn()
        backBtn = New Button()
        CType(ProductGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(458, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(433, 46)
        Label1.TabIndex = 0
        Label1.Text = "Market Solutions System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(566, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 41)
        Label2.TabIndex = 1
        Label2.Text = "Product Listing"
        ' 
        ' ProductGV
        ' 
        ProductGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ProductGV.Columns.AddRange(New DataGridViewColumn() {prodName, compName, prodPrice, prodQty})
        ProductGV.Location = New Point(74, 292)
        ProductGV.Name = "ProductGV"
        ProductGV.RowHeadersWidth = 51
        ProductGV.RowTemplate.Height = 29
        ProductGV.Size = New Size(1176, 360)
        ProductGV.TabIndex = 2
        ' 
        ' prodName
        ' 
        prodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodName.HeaderText = "Product Name"
        prodName.MinimumWidth = 6
        prodName.Name = "prodName"
        ' 
        ' compName
        ' 
        compName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        compName.HeaderText = "Company Name"
        compName.MinimumWidth = 6
        compName.Name = "compName"
        ' 
        ' prodPrice
        ' 
        prodPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodPrice.HeaderText = "Product Price"
        prodPrice.MinimumWidth = 6
        prodPrice.Name = "prodPrice"
        ' 
        ' prodQty
        ' 
        prodQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodQty.HeaderText = "Product Quantity"
        prodQty.MinimumWidth = 6
        prodQty.Name = "prodQty"
        ' 
        ' backBtn
        ' 
        backBtn.Location = New Point(1156, 29)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(94, 29)
        backBtn.TabIndex = 3
        backBtn.Text = "< Go Back"
        backBtn.UseVisualStyleBackColor = True
        ' 
        ' ViewProducts
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(backBtn)
        Controls.Add(ProductGV)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ViewProducts"
        Text = "View Products"
        CType(ProductGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductGV As DataGridView
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents compName As DataGridViewTextBoxColumn
    Friend WithEvents prodPrice As DataGridViewTextBoxColumn
    Friend WithEvents prodQty As DataGridViewTextBoxColumn
    Friend WithEvents backBtn As Button
End Class
