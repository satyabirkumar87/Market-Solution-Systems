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
        FeedDGV = New DataGridView()
        FDID = New DataGridViewTextBoxColumn()
        CustID = New DataGridViewTextBoxColumn()
        ProdName = New DataGridViewTextBoxColumn()
        Rating = New DataGridViewTextBoxColumn()
        Feedback = New DataGridViewTextBoxColumn()
        CType(FeedDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FeedDGV
        ' 
        FeedDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        FeedDGV.Columns.AddRange(New DataGridViewColumn() {FDID, CustID, ProdName, Rating, Feedback})
        FeedDGV.Location = New Point(135, 12)
        FeedDGV.Name = "FeedDGV"
        FeedDGV.RowTemplate.Height = 25
        FeedDGV.Size = New Size(544, 286)
        FeedDGV.TabIndex = 0
        ' 
        ' FDID
        ' 
        FDID.HeaderText = "FeedBack ID"
        FDID.Name = "FDID"
        ' 
        ' CustID
        ' 
        CustID.HeaderText = "Customer ID"
        CustID.Name = "CustID"
        ' 
        ' ProdName
        ' 
        ProdName.HeaderText = "Product Name"
        ProdName.Name = "ProdName"
        ' 
        ' Rating
        ' 
        Rating.HeaderText = "Rating"
        Rating.Name = "Rating"
        ' 
        ' Feedback
        ' 
        Feedback.HeaderText = "FeedBack"
        Feedback.Name = "Feedback"
        ' 
        ' viewfeedback
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(FeedDGV)
        Name = "viewfeedback"
        Text = "viewfeedback"
        CType(FeedDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FeedDGV As DataGridView
    Friend WithEvents FDID As DataGridViewTextBoxColumn
    Friend WithEvents CustID As DataGridViewTextBoxColumn
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents Rating As DataGridViewTextBoxColumn
    Friend WithEvents Feedback As DataGridViewTextBoxColumn
End Class
