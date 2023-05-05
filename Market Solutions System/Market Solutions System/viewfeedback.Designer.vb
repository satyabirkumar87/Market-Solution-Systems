<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewfeedback
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
        Me.FeedDGV = New System.Windows.Forms.DataGridView()
        Me.FDID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feedback = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.backbtn = New System.Windows.Forms.Button()
        CType(Me.FeedDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FeedDGV
        '
        Me.FeedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FeedDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FDID, Me.CustID, Me.ProdName, Me.Rating, Me.Feedback})
        Me.FeedDGV.Location = New System.Drawing.Point(154, 16)
        Me.FeedDGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FeedDGV.Name = "FeedDGV"
        Me.FeedDGV.RowHeadersWidth = 51
        Me.FeedDGV.RowTemplate.Height = 25
        Me.FeedDGV.Size = New System.Drawing.Size(622, 381)
        Me.FeedDGV.TabIndex = 0
        '
        'FDID
        '
        Me.FDID.HeaderText = "FeedBack ID"
        Me.FDID.MinimumWidth = 6
        Me.FDID.Name = "FDID"
        Me.FDID.Width = 125
        '
        'CustID
        '
        Me.CustID.HeaderText = "Customer ID"
        Me.CustID.MinimumWidth = 6
        Me.CustID.Name = "CustID"
        Me.CustID.Width = 125
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "Product Name"
        Me.ProdName.MinimumWidth = 6
        Me.ProdName.Name = "ProdName"
        Me.ProdName.Width = 125
        '
        'Rating
        '
        Me.Rating.HeaderText = "Rating"
        Me.Rating.MinimumWidth = 6
        Me.Rating.Name = "Rating"
        Me.Rating.Width = 125
        '
        'Feedback
        '
        Me.Feedback.HeaderText = "FeedBack"
        Me.Feedback.MinimumWidth = 6
        Me.Feedback.Name = "Feedback"
        Me.Feedback.Width = 125
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(764, 428)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(94, 29)
        Me.backbtn.TabIndex = 1
        Me.backbtn.Text = "Go Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'viewfeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.FeedDGV)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "viewfeedback"
        Me.Text = "viewfeedback"
        CType(Me.FeedDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FeedDGV As DataGridView
    Friend WithEvents FDID As DataGridViewTextBoxColumn
    Friend WithEvents CustID As DataGridViewTextBoxColumn
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents Rating As DataGridViewTextBoxColumn
    Friend WithEvents Feedback As DataGridViewTextBoxColumn
    Friend WithEvents backbtn As Button
End Class
