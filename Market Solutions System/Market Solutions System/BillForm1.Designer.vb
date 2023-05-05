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
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.BillDGV = New System.Windows.Forms.DataGridView()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.backbtn = New System.Windows.Forms.Button()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'refreshBtn
        '
        Me.refreshBtn.Location = New System.Drawing.Point(574, 423)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(94, 29)
        Me.refreshBtn.TabIndex = 1
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.AutoSize = True
        Me.TotalPriceLabel.Location = New System.Drawing.Point(12, 393)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(42, 20)
        Me.TotalPriceLabel.TabIndex = 2
        Me.TotalPriceLabel.Text = "Total"
        '
        'BillDGV
        '
        Me.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdName, Me.ProdQty, Me.saleDate, Me.SaleTime, Me.discount})
        Me.BillDGV.Location = New System.Drawing.Point(34, 12)
        Me.BillDGV.Name = "BillDGV"
        Me.BillDGV.RowHeadersWidth = 51
        Me.BillDGV.RowTemplate.Height = 29
        Me.BillDGV.Size = New System.Drawing.Size(1176, 378)
        Me.BillDGV.TabIndex = 3
        '
        'ProdName
        '
        Me.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdName.HeaderText = "Product Name"
        Me.ProdName.MinimumWidth = 6
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        '
        'ProdQty
        '
        Me.ProdQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdQty.HeaderText = "Quantity Purchased"
        Me.ProdQty.MinimumWidth = 6
        Me.ProdQty.Name = "ProdQty"
        Me.ProdQty.ReadOnly = True
        '
        'saleDate
        '
        Me.saleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.saleDate.HeaderText = "Sale Date"
        Me.saleDate.MinimumWidth = 6
        Me.saleDate.Name = "saleDate"
        Me.saleDate.ReadOnly = True
        '
        'SaleTime
        '
        Me.SaleTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SaleTime.HeaderText = "Sale Time"
        Me.SaleTime.MinimumWidth = 6
        Me.SaleTime.Name = "SaleTime"
        Me.SaleTime.ReadOnly = True
        '
        'discount
        '
        Me.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.discount.HeaderText = "Discount Given"
        Me.discount.MinimumWidth = 6
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(756, 410)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(94, 29)
        Me.backbtn.TabIndex = 4
        Me.backbtn.Text = "Go Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'BillForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 464)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.BillDGV)
        Me.Controls.Add(Me.TotalPriceLabel)
        Me.Controls.Add(Me.refreshBtn)
        Me.Name = "BillForm1"
        Me.Text = "BillForm"
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents backbtn As Button
End Class
