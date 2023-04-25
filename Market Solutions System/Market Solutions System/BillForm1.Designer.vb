<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillForm1
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
        refreshBtn = New Button()
        TotalPriceLabel = New Label()
        BillDGV = New DataGridView()
        ProdName = New DataGridViewTextBoxColumn()
        ProdQty = New DataGridViewTextBoxColumn()
        saleDate = New DataGridViewTextBoxColumn()
        SaleTime = New DataGridViewTextBoxColumn()
        discount = New DataGridViewTextBoxColumn()
        CType(BillDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' refreshBtn
        ' 
        refreshBtn.Location = New Point(574, 423)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(94, 29)
        refreshBtn.TabIndex = 1
        refreshBtn.Text = "Refresh"
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' TotalPriceLabel
        ' 
        TotalPriceLabel.AutoSize = True
        TotalPriceLabel.Location = New Point(12, 393)
        TotalPriceLabel.Name = "TotalPriceLabel"
        TotalPriceLabel.Size = New Size(42, 20)
        TotalPriceLabel.TabIndex = 2
        TotalPriceLabel.Text = "Total"
        ' 
        ' BillDGV
        ' 
        BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillDGV.Columns.AddRange(New DataGridViewColumn() {ProdName, ProdQty, saleDate, SaleTime, discount})
        BillDGV.Location = New Point(34, 12)
        BillDGV.Name = "BillDGV"
        BillDGV.RowHeadersWidth = 51
        BillDGV.RowTemplate.Height = 29
        BillDGV.Size = New Size(1176, 378)
        BillDGV.TabIndex = 3
        ' 
        ' ProdName
        ' 
        ProdName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdName.HeaderText = "Product Name"
        ProdName.MinimumWidth = 6
        ProdName.Name = "ProdName"
        ProdName.ReadOnly = True
        ' 
        ' ProdQty
        ' 
        ProdQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdQty.HeaderText = "Quantity Purchased"
        ProdQty.MinimumWidth = 6
        ProdQty.Name = "ProdQty"
        ProdQty.ReadOnly = True
        ' 
        ' saleDate
        ' 
        saleDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        saleDate.HeaderText = "Sale Date"
        saleDate.MinimumWidth = 6
        saleDate.Name = "saleDate"
        saleDate.ReadOnly = True
        ' 
        ' SaleTime
        ' 
        SaleTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        SaleTime.HeaderText = "Sale Time"
        SaleTime.MinimumWidth = 6
        SaleTime.Name = "SaleTime"
        SaleTime.ReadOnly = True
        ' 
        ' discount
        ' 
        discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        discount.HeaderText = "Discount Given"
        discount.MinimumWidth = 6
        discount.Name = "discount"
        discount.ReadOnly = True
        ' 
        ' BillForm1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 464)
        Controls.Add(BillDGV)
        Controls.Add(TotalPriceLabel)
        Controls.Add(refreshBtn)
        Name = "BillForm1"
        Text = "BillForm"
        CType(BillDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PurchaseHistoryGridView As DataGridView
    Friend WithEvents refreshBtn As Button
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents ProdQty As DataGridViewTextBoxColumn
    Friend WithEvents saleDate As DataGridViewTextBoxColumn
    Friend WithEvents SaleTime As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
End Class
