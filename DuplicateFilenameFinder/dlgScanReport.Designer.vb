<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScanReport
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
        Me.lblScanStatusValue = New System.Windows.Forms.Label()
        Me.lblTimeElapsedValue = New System.Windows.Forms.Label()
        Me.lblTimeElapsedLabel = New System.Windows.Forms.Label()
        Me.lblDuplicateFileNamesFoundValue = New System.Windows.Forms.Label()
        Me.lblDuplicateFileNamesFoundLabel = New System.Windows.Forms.Label()
        Me.lblFilesScannedValue = New System.Windows.Forms.Label()
        Me.lblFilesScannedLabel = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.flpDuplicateFileControlsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'lblScanStatusValue
        '
        Me.lblScanStatusValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScanStatusValue.AutoSize = True
        Me.lblScanStatusValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanStatusValue.ForeColor = System.Drawing.Color.Green
        Me.lblScanStatusValue.Location = New System.Drawing.Point(268, 15)
        Me.lblScanStatusValue.Name = "lblScanStatusValue"
        Me.lblScanStatusValue.Size = New System.Drawing.Size(197, 58)
        Me.lblScanStatusValue.TabIndex = 13
        Me.lblScanStatusValue.Text = "There are 88" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unchanged files"
        Me.lblScanStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeElapsedValue
        '
        Me.lblTimeElapsedValue.AutoSize = True
        Me.lblTimeElapsedValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeElapsedValue.Location = New System.Drawing.Point(128, 9)
        Me.lblTimeElapsedValue.Name = "lblTimeElapsedValue"
        Me.lblTimeElapsedValue.Size = New System.Drawing.Size(57, 13)
        Me.lblTimeElapsedValue.TabIndex = 12
        Me.lblTimeElapsedValue.Text = "88:88:88"
        '
        'lblTimeElapsedLabel
        '
        Me.lblTimeElapsedLabel.AutoSize = True
        Me.lblTimeElapsedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeElapsedLabel.Location = New System.Drawing.Point(35, 9)
        Me.lblTimeElapsedLabel.Name = "lblTimeElapsedLabel"
        Me.lblTimeElapsedLabel.Size = New System.Drawing.Size(87, 13)
        Me.lblTimeElapsedLabel.TabIndex = 11
        Me.lblTimeElapsedLabel.Text = "Time Elapsed:"
        '
        'lblDuplicateFileNamesFoundValue
        '
        Me.lblDuplicateFileNamesFoundValue.AutoSize = True
        Me.lblDuplicateFileNamesFoundValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuplicateFileNamesFoundValue.Location = New System.Drawing.Point(128, 67)
        Me.lblDuplicateFileNamesFoundValue.Name = "lblDuplicateFileNamesFoundValue"
        Me.lblDuplicateFileNamesFoundValue.Size = New System.Drawing.Size(49, 13)
        Me.lblDuplicateFileNamesFoundValue.TabIndex = 10
        Me.lblDuplicateFileNamesFoundValue.Text = "888888"
        '
        'lblDuplicateFileNamesFoundLabel
        '
        Me.lblDuplicateFileNamesFoundLabel.AutoSize = True
        Me.lblDuplicateFileNamesFoundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuplicateFileNamesFoundLabel.Location = New System.Drawing.Point(12, 67)
        Me.lblDuplicateFileNamesFoundLabel.Name = "lblDuplicateFileNamesFoundLabel"
        Me.lblDuplicateFileNamesFoundLabel.Size = New System.Drawing.Size(110, 13)
        Me.lblDuplicateFileNamesFoundLabel.TabIndex = 9
        Me.lblDuplicateFileNamesFoundLabel.Text = "Duplicates Found:"
        '
        'lblFilesScannedValue
        '
        Me.lblFilesScannedValue.AutoSize = True
        Me.lblFilesScannedValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilesScannedValue.Location = New System.Drawing.Point(128, 38)
        Me.lblFilesScannedValue.Name = "lblFilesScannedValue"
        Me.lblFilesScannedValue.Size = New System.Drawing.Size(49, 13)
        Me.lblFilesScannedValue.TabIndex = 8
        Me.lblFilesScannedValue.Text = "888888"
        '
        'lblFilesScannedLabel
        '
        Me.lblFilesScannedLabel.AutoSize = True
        Me.lblFilesScannedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilesScannedLabel.Location = New System.Drawing.Point(31, 38)
        Me.lblFilesScannedLabel.Name = "lblFilesScannedLabel"
        Me.lblFilesScannedLabel.Size = New System.Drawing.Size(91, 13)
        Me.lblFilesScannedLabel.TabIndex = 7
        Me.lblFilesScannedLabel.Text = "Files Scanned:"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.AutoSize = True
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(451, 320)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(86, 36)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Finish"
        '
        'flpDuplicateFileControlsFlowLayoutPanel
        '
        Me.flpDuplicateFileControlsFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpDuplicateFileControlsFlowLayoutPanel.AutoScroll = True
        Me.flpDuplicateFileControlsFlowLayoutPanel.AutoSize = True
        Me.flpDuplicateFileControlsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpDuplicateFileControlsFlowLayoutPanel.Location = New System.Drawing.Point(12, 92)
        Me.flpDuplicateFileControlsFlowLayoutPanel.MaximumSize = New System.Drawing.Size(525, 422)
        Me.flpDuplicateFileControlsFlowLayoutPanel.MinimumSize = New System.Drawing.Size(525, 222)
        Me.flpDuplicateFileControlsFlowLayoutPanel.Name = "flpDuplicateFileControlsFlowLayoutPanel"
        Me.flpDuplicateFileControlsFlowLayoutPanel.Size = New System.Drawing.Size(525, 222)
        Me.flpDuplicateFileControlsFlowLayoutPanel.TabIndex = 14
        '
        'dlgScanReport
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(549, 368)
        Me.Controls.Add(Me.flpDuplicateFileControlsFlowLayoutPanel)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.lblScanStatusValue)
        Me.Controls.Add(Me.lblTimeElapsedValue)
        Me.Controls.Add(Me.lblTimeElapsedLabel)
        Me.Controls.Add(Me.lblDuplicateFileNamesFoundValue)
        Me.Controls.Add(Me.lblDuplicateFileNamesFoundLabel)
        Me.Controls.Add(Me.lblFilesScannedValue)
        Me.Controls.Add(Me.lblFilesScannedLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(555, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(555, 400)
        Me.Name = "dlgScanReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scan Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScanStatusValue As System.Windows.Forms.Label
    Friend WithEvents lblTimeElapsedValue As System.Windows.Forms.Label
    Friend WithEvents lblTimeElapsedLabel As System.Windows.Forms.Label
    Friend WithEvents lblDuplicateFileNamesFoundValue As System.Windows.Forms.Label
    Friend WithEvents lblDuplicateFileNamesFoundLabel As System.Windows.Forms.Label
    Friend WithEvents lblFilesScannedValue As System.Windows.Forms.Label
    Friend WithEvents lblFilesScannedLabel As System.Windows.Forms.Label
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents flpDuplicateFileControlsFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel

End Class
