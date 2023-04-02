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
        PurchaseHistoryGridView = New DataGridView()
        PrintBtn = New Button()
        TotalPriceLabel = New Label()
        CType(PurchaseHistoryGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PurchaseHistoryGridView
        ' 
        PurchaseHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PurchaseHistoryGridView.Location = New Point(12, 12)
        PurchaseHistoryGridView.Name = "PurchaseHistoryGridView"
        PurchaseHistoryGridView.RowHeadersWidth = 51
        PurchaseHistoryGridView.RowTemplate.Height = 29
        PurchaseHistoryGridView.Size = New Size(1219, 346)
        PurchaseHistoryGridView.TabIndex = 0
        ' 
        ' PrintBtn
        ' 
        PrintBtn.Location = New Point(560, 423)
        PrintBtn.Name = "PrintBtn"
        PrintBtn.Size = New Size(94, 29)
        PrintBtn.TabIndex = 1
        PrintBtn.Text = "Button1"
        PrintBtn.UseVisualStyleBackColor = True
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
        ' BillForm1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 464)
        Controls.Add(TotalPriceLabel)
        Controls.Add(PrintBtn)
        Controls.Add(PurchaseHistoryGridView)
        Name = "BillForm1"
        Text = "BillForm"
        CType(PurchaseHistoryGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PurchaseHistoryGridView As DataGridView
    Friend WithEvents PrintBtn As Button
    Friend WithEvents TotalPriceLabel As Label
End Class
