<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDuplicateFileUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblFilenameLabel = New System.Windows.Forms.Label()
        Me.lblFileNameValue = New System.Windows.Forms.Label()
        Me.lblFileLocationValue = New System.Windows.Forms.Label()
        Me.lblFileLocationLabel = New System.Windows.Forms.Label()
        Me.lnkRenameFileLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.lnkMoveFileLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.lnkShowFileLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.lnkDeleteFileLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.fbdMoveFileFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblFileStatusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFilenameLabel
        '
        Me.lblFilenameLabel.AutoSize = True
        Me.lblFilenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilenameLabel.Location = New System.Drawing.Point(4, 4)
        Me.lblFilenameLabel.Name = "lblFilenameLabel"
        Me.lblFilenameLabel.Size = New System.Drawing.Size(61, 13)
        Me.lblFilenameLabel.TabIndex = 0
        Me.lblFilenameLabel.Text = "Filename:"
        '
        'lblFileNameValue
        '
        Me.lblFileNameValue.AutoEllipsis = True
        Me.lblFileNameValue.AutoSize = True
        Me.lblFileNameValue.Location = New System.Drawing.Point(4, 21)
        Me.lblFileNameValue.MaximumSize = New System.Drawing.Size(150, 13)
        Me.lblFileNameValue.Name = "lblFileNameValue"
        Me.lblFileNameValue.Size = New System.Drawing.Size(122, 13)
        Me.lblFileNameValue.TabIndex = 1
        Me.lblFileNameValue.Text = "the name of the file with extension"
        '
        'lblFileLocationValue
        '
        Me.lblFileLocationValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFileLocationValue.AutoEllipsis = True
        Me.lblFileLocationValue.AutoSize = True
        Me.lblFileLocationValue.Location = New System.Drawing.Point(4, 59)
        Me.lblFileLocationValue.MaximumSize = New System.Drawing.Size(350, 13)
        Me.lblFileLocationValue.Name = "lblFileLocationValue"
        Me.lblFileLocationValue.Size = New System.Drawing.Size(108, 13)
        Me.lblFileLocationValue.TabIndex = 2
        Me.lblFileLocationValue.Text = "the full path of the file"
        '
        'lblFileLocationLabel
        '
        Me.lblFileLocationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFileLocationLabel.AutoSize = True
        Me.lblFileLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileLocationLabel.Location = New System.Drawing.Point(4, 43)
        Me.lblFileLocationLabel.Name = "lblFileLocationLabel"
        Me.lblFileLocationLabel.Size = New System.Drawing.Size(60, 13)
        Me.lblFileLocationLabel.TabIndex = 3
        Me.lblFileLocationLabel.Text = "Location:"
        '
        'lnkRenameFileLinkLabel
        '
        Me.lnkRenameFileLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkRenameFileLinkLabel.AutoSize = True
        Me.lnkRenameFileLinkLabel.Location = New System.Drawing.Point(416, 50)
        Me.lnkRenameFileLinkLabel.Name = "lnkRenameFileLinkLabel"
        Me.lnkRenameFileLinkLabel.Size = New System.Drawing.Size(42, 13)
        Me.lnkRenameFileLinkLabel.TabIndex = 4
        Me.lnkRenameFileLinkLabel.TabStop = True
        Me.lnkRenameFileLinkLabel.Text = "rename"
        '
        'lnkMoveFileLinkLabel
        '
        Me.lnkMoveFileLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkMoveFileLinkLabel.AutoSize = True
        Me.lnkMoveFileLinkLabel.Location = New System.Drawing.Point(464, 17)
        Me.lnkMoveFileLinkLabel.Name = "lnkMoveFileLinkLabel"
        Me.lnkMoveFileLinkLabel.Size = New System.Drawing.Size(33, 13)
        Me.lnkMoveFileLinkLabel.TabIndex = 5
        Me.lnkMoveFileLinkLabel.TabStop = True
        Me.lnkMoveFileLinkLabel.Text = "move"
        '
        'lnkShowFileLinkLabel
        '
        Me.lnkShowFileLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkShowFileLinkLabel.AutoSize = True
        Me.lnkShowFileLinkLabel.Location = New System.Drawing.Point(465, 50)
        Me.lnkShowFileLinkLabel.Name = "lnkShowFileLinkLabel"
        Me.lnkShowFileLinkLabel.Size = New System.Drawing.Size(32, 13)
        Me.lnkShowFileLinkLabel.TabIndex = 6
        Me.lnkShowFileLinkLabel.TabStop = True
        Me.lnkShowFileLinkLabel.Text = "show"
        '
        'lnkDeleteFileLinkLabel
        '
        Me.lnkDeleteFileLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkDeleteFileLinkLabel.AutoSize = True
        Me.lnkDeleteFileLinkLabel.Location = New System.Drawing.Point(422, 17)
        Me.lnkDeleteFileLinkLabel.Name = "lnkDeleteFileLinkLabel"
        Me.lnkDeleteFileLinkLabel.Size = New System.Drawing.Size(36, 13)
        Me.lnkDeleteFileLinkLabel.TabIndex = 7
        Me.lnkDeleteFileLinkLabel.TabStop = True
        Me.lnkDeleteFileLinkLabel.Text = "delete"
        '
        'fbdMoveFileFolderBrowserDialog
        '
        Me.fbdMoveFileFolderBrowserDialog.Description = "Please select or a create a new folder for the file location."
        Me.fbdMoveFileFolderBrowserDialog.SelectedPath = "Me.FilePath"
        '
        'lblFileStatusLabel
        '
        Me.lblFileStatusLabel.AutoSize = True
        Me.lblFileStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileStatusLabel.ForeColor = System.Drawing.Color.Green
        Me.lblFileStatusLabel.Location = New System.Drawing.Point(209, 13)
        Me.lblFileStatusLabel.Name = "lblFileStatusLabel"
        Me.lblFileStatusLabel.Size = New System.Drawing.Size(161, 24)
        Me.lblFileStatusLabel.TabIndex = 8
        Me.lblFileStatusLabel.Text = "NOT CHANGED"
        '
        'ucDuplicateFileUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblFileStatusLabel)
        Me.Controls.Add(Me.lnkDeleteFileLinkLabel)
        Me.Controls.Add(Me.lnkShowFileLinkLabel)
        Me.Controls.Add(Me.lnkMoveFileLinkLabel)
        Me.Controls.Add(Me.lnkRenameFileLinkLabel)
        Me.Controls.Add(Me.lblFileLocationLabel)
        Me.Controls.Add(Me.lblFileLocationValue)
        Me.Controls.Add(Me.lblFileNameValue)
        Me.Controls.Add(Me.lblFilenameLabel)
        Me.MaximumSize = New System.Drawing.Size(500, 75)
        Me.MinimumSize = New System.Drawing.Size(500, 75)
        Me.Name = "ucDuplicateFileUserControl"
        Me.Size = New System.Drawing.Size(498, 73)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFilenameLabel As System.Windows.Forms.Label
    Friend WithEvents lblFileNameValue As System.Windows.Forms.Label
    Friend WithEvents lblFileLocationValue As System.Windows.Forms.Label
    Friend WithEvents lblFileLocationLabel As System.Windows.Forms.Label
    Friend WithEvents lnkRenameFileLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkMoveFileLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkShowFileLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkDeleteFileLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents fbdMoveFileFolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblFileStatusLabel As System.Windows.Forms.Label

End Class
