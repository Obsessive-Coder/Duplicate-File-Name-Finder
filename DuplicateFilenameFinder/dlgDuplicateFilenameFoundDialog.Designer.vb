<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDuplicateFilenameFoundDialog
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lblDuplicateFileFoundHeadingMessageLabel = New System.Windows.Forms.Label()
        Me.flpDuplicateFileControlsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.AutoSize = True
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(466, 320)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(71, 36)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Next"
        '
        'lblDuplicateFileFoundHeadingMessageLabel
        '
        Me.lblDuplicateFileFoundHeadingMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDuplicateFileFoundHeadingMessageLabel.AutoSize = True
        Me.lblDuplicateFileFoundHeadingMessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuplicateFileFoundHeadingMessageLabel.Location = New System.Drawing.Point(46, 9)
        Me.lblDuplicateFileFoundHeadingMessageLabel.Name = "lblDuplicateFileFoundHeadingMessageLabel"
        Me.lblDuplicateFileFoundHeadingMessageLabel.Size = New System.Drawing.Size(457, 58)
        Me.lblDuplicateFileFoundHeadingMessageLabel.TabIndex = 1
        Me.lblDuplicateFileFoundHeadingMessageLabel.Text = "Duplicate file names have been found." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What action would you like to take?"
        Me.lblDuplicateFileFoundHeadingMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpDuplicateFileControlsFlowLayoutPanel
        '
        Me.flpDuplicateFileControlsFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpDuplicateFileControlsFlowLayoutPanel.AutoScroll = True
        Me.flpDuplicateFileControlsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpDuplicateFileControlsFlowLayoutPanel.Location = New System.Drawing.Point(12, 92)
        Me.flpDuplicateFileControlsFlowLayoutPanel.MaximumSize = New System.Drawing.Size(525, 422)
        Me.flpDuplicateFileControlsFlowLayoutPanel.MinimumSize = New System.Drawing.Size(525, 222)
        Me.flpDuplicateFileControlsFlowLayoutPanel.Name = "flpDuplicateFileControlsFlowLayoutPanel"
        Me.flpDuplicateFileControlsFlowLayoutPanel.Size = New System.Drawing.Size(525, 222)
        Me.flpDuplicateFileControlsFlowLayoutPanel.TabIndex = 2
        '
        'dlgDuplicateFilenameFoundDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 368)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.flpDuplicateFileControlsFlowLayoutPanel)
        Me.Controls.Add(Me.lblDuplicateFileFoundHeadingMessageLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(555, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(555, 400)
        Me.Name = "dlgDuplicateFilenameFoundDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Duplicate File Name Found"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lblDuplicateFileFoundHeadingMessageLabel As System.Windows.Forms.Label
    Friend WithEvents flpDuplicateFileControlsFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel

End Class
