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
        Me.PurchaseHistoryGridView = New System.Windows.Forms.DataGridView()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        CType(Me.PurchaseHistoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseHistoryGridView
        '
        Me.PurchaseHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseHistoryGridView.Location = New System.Drawing.Point(12, 12)
        Me.PurchaseHistoryGridView.Name = "PurchaseHistoryGridView"
        Me.PurchaseHistoryGridView.RowHeadersWidth = 51
        Me.PurchaseHistoryGridView.RowTemplate.Height = 29
        Me.PurchaseHistoryGridView.Size = New System.Drawing.Size(1219, 346)
        Me.PurchaseHistoryGridView.TabIndex = 0
        '
        'PrintBtn
        '
        Me.PrintBtn.Location = New System.Drawing.Point(560, 423)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(94, 29)
        Me.PrintBtn.TabIndex = 1
        Me.PrintBtn.Text = "Button1"
        Me.PrintBtn.UseVisualStyleBackColor = True
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
        'BillForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 464)
        Me.Controls.Add(Me.TotalPriceLabel)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.PurchaseHistoryGridView)
        Me.Name = "BillForm1"
        Me.Text = "BillForm"
        CType(Me.PurchaseHistoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PurchaseHistoryGridView As DataGridView
    Friend WithEvents PrintBtn As Button
    Friend WithEvents TotalPriceLabel As Label
End Class
