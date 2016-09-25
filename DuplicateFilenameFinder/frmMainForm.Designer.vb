<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.lblFolderLocationLabel = New System.Windows.Forms.Label()
        Me.txtFolderLocationTextBox = New System.Windows.Forms.TextBox()
        Me.btnBrowseFolderLocationButton = New System.Windows.Forms.Button()
        Me.fbdFolderLocationToScan = New System.Windows.Forms.FolderBrowserDialog()
        Me.gbxActionToTakeGroupBox = New System.Windows.Forms.GroupBox()
        Me.radDeleteAll = New System.Windows.Forms.RadioButton()
        Me.radLeaveOne = New System.Windows.Forms.RadioButton()
        Me.radReportOnly = New System.Windows.Forms.RadioButton()
        Me.radPromptForEach = New System.Windows.Forms.RadioButton()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.tipFileLocationTextBox = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxFileExtension = New System.Windows.Forms.ComboBox()
        Me.chkSearchSubdirectories = New System.Windows.Forms.CheckBox()
        Me.lblFileExtensionLabel = New System.Windows.Forms.Label()
        Me.gbxActionToTakeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFolderLocationLabel
        '
        Me.lblFolderLocationLabel.AutoSize = True
        Me.lblFolderLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolderLocationLabel.Location = New System.Drawing.Point(12, 10)
        Me.lblFolderLocationLabel.Name = "lblFolderLocationLabel"
        Me.lblFolderLocationLabel.Size = New System.Drawing.Size(99, 13)
        Me.lblFolderLocationLabel.TabIndex = 0
        Me.lblFolderLocationLabel.Text = "Folder Location:"
        Me.tipFileLocationTextBox.SetToolTip(Me.lblFolderLocationLabel, "The location of the directory to scan.")
        '
        'txtFolderLocationTextBox
        '
        Me.txtFolderLocationTextBox.Location = New System.Drawing.Point(12, 26)
        Me.txtFolderLocationTextBox.Name = "txtFolderLocationTextBox"
        Me.txtFolderLocationTextBox.Size = New System.Drawing.Size(268, 20)
        Me.txtFolderLocationTextBox.TabIndex = 1
        Me.tipFileLocationTextBox.SetToolTip(Me.txtFolderLocationTextBox, "The location of the directory to scan.")
        '
        'btnBrowseFolderLocationButton
        '
        Me.btnBrowseFolderLocationButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseFolderLocationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFolderLocationButton.Location = New System.Drawing.Point(286, 25)
        Me.btnBrowseFolderLocationButton.Name = "btnBrowseFolderLocationButton"
        Me.btnBrowseFolderLocationButton.Size = New System.Drawing.Size(46, 23)
        Me.btnBrowseFolderLocationButton.TabIndex = 2
        Me.btnBrowseFolderLocationButton.Text = "..."
        Me.tipFileLocationTextBox.SetToolTip(Me.btnBrowseFolderLocationButton, "Browse folder location.")
        Me.btnBrowseFolderLocationButton.UseVisualStyleBackColor = True
        '
        'fbdFolderLocationToScan
        '
        Me.fbdFolderLocationToScan.SelectedPath = "C:\"
        Me.fbdFolderLocationToScan.ShowNewFolderButton = False
        '
        'gbxActionToTakeGroupBox
        '
        Me.gbxActionToTakeGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxActionToTakeGroupBox.Controls.Add(Me.radDeleteAll)
        Me.gbxActionToTakeGroupBox.Controls.Add(Me.radLeaveOne)
        Me.gbxActionToTakeGroupBox.Controls.Add(Me.radReportOnly)
        Me.gbxActionToTakeGroupBox.Controls.Add(Me.radPromptForEach)
        Me.gbxActionToTakeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxActionToTakeGroupBox.Location = New System.Drawing.Point(12, 100)
        Me.gbxActionToTakeGroupBox.Name = "gbxActionToTakeGroupBox"
        Me.gbxActionToTakeGroupBox.Size = New System.Drawing.Size(153, 114)
        Me.gbxActionToTakeGroupBox.TabIndex = 3
        Me.gbxActionToTakeGroupBox.TabStop = False
        Me.gbxActionToTakeGroupBox.Text = "Action to take:"
        Me.tipFileLocationTextBox.SetToolTip(Me.gbxActionToTakeGroupBox, resources.GetString("gbxActionToTakeGroupBox.ToolTip"))
        '
        'radDeleteAll
        '
        Me.radDeleteAll.AutoSize = True
        Me.radDeleteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDeleteAll.Location = New System.Drawing.Point(7, 86)
        Me.radDeleteAll.Name = "radDeleteAll"
        Me.radDeleteAll.Size = New System.Drawing.Size(69, 17)
        Me.radDeleteAll.TabIndex = 3
        Me.radDeleteAll.Text = "Delete all"
        Me.tipFileLocationTextBox.SetToolTip(Me.radDeleteAll, "Deletes all files with duplicate file names.")
        Me.radDeleteAll.UseVisualStyleBackColor = True
        '
        'radLeaveOne
        '
        Me.radLeaveOne.AutoSize = True
        Me.radLeaveOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLeaveOne.Location = New System.Drawing.Point(7, 62)
        Me.radLeaveOne.Name = "radLeaveOne"
        Me.radLeaveOne.Size = New System.Drawing.Size(76, 17)
        Me.radLeaveOne.TabIndex = 2
        Me.radLeaveOne.Text = "Leave one"
        Me.tipFileLocationTextBox.SetToolTip(Me.radLeaveOne, "Deletes all files with duplicate file names except for one.")
        Me.radLeaveOne.UseVisualStyleBackColor = True
        '
        'radReportOnly
        '
        Me.radReportOnly.AutoSize = True
        Me.radReportOnly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radReportOnly.Location = New System.Drawing.Point(7, 38)
        Me.radReportOnly.Name = "radReportOnly"
        Me.radReportOnly.Size = New System.Drawing.Size(79, 17)
        Me.radReportOnly.TabIndex = 1
        Me.radReportOnly.Text = "Report only"
        Me.tipFileLocationTextBox.SetToolTip(Me.radReportOnly, "No action will be taken when a duplicate is found.")
        Me.radReportOnly.UseVisualStyleBackColor = True
        '
        'radPromptForEach
        '
        Me.radPromptForEach.AutoSize = True
        Me.radPromptForEach.Checked = True
        Me.radPromptForEach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPromptForEach.Location = New System.Drawing.Point(6, 14)
        Me.radPromptForEach.Name = "radPromptForEach"
        Me.radPromptForEach.Size = New System.Drawing.Size(100, 17)
        Me.radPromptForEach.TabIndex = 0
        Me.radPromptForEach.TabStop = True
        Me.radPromptForEach.Text = "Prompt for each"
        Me.tipFileLocationTextBox.SetToolTip(Me.radPromptForEach, "Shows a dialog for each duplicate file name found.")
        Me.radPromptForEach.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.btnScan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScan.BackColor = System.Drawing.SystemColors.Control
        Me.btnScan.Enabled = False
        Me.btnScan.Font = New System.Drawing.Font("Abadi MT Condensed Extra Bold", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnScan.Location = New System.Drawing.Point(179, 100)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(153, 114)
        Me.btnScan.TabIndex = 4
        Me.btnScan.Text = "SCAN"
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'tipFileLocationTextBox
        '
        Me.tipFileLocationTextBox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'cbxFileExtension
        '
        Me.cbxFileExtension.FormattingEnabled = True
        Me.cbxFileExtension.Items.AddRange(New Object() {"*", ".CRP", ".AIFF", ".AIF", ".AU", ".AVI", ".BAT", ".BMP", ".CLASS", ".JAVA", ".CSV", ".CVS", ".DBF", ".DIF", ".DOC", ".DOCX", ".EPS", ".EXE", ".FM3", ".GIF", ".HQX", ".HTM", ".HTML", ".JPG", "JPEG", ".MAC", ".MAP", ".MDB", ".MID", ".MIDI", ".MOV", ".QT", ".MTB", ".MTW", ".PDF", ".P65", ".T65", ".PNG", ".PPT", ".PPTX", ".PSD", ".PSP", ".QXD", ".RA", ".RTF", ".SIT", ".TAR", ".TIF", ".TXT", ".WAV", ".WK3", ".WKS", "WPD", ".WP5", ".XLS", ".XLSX", ".ZIP"})
        Me.cbxFileExtension.Location = New System.Drawing.Point(12, 71)
        Me.cbxFileExtension.Name = "cbxFileExtension"
        Me.cbxFileExtension.Size = New System.Drawing.Size(153, 21)
        Me.cbxFileExtension.TabIndex = 5
        Me.tipFileLocationTextBox.SetToolTip(Me.cbxFileExtension, "The file type to scan for. Select * for all file types.")
        '
        'chkSearchSubdirectories
        '
        Me.chkSearchSubdirectories.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSearchSubdirectories.AutoSize = True
        Me.chkSearchSubdirectories.Checked = True
        Me.chkSearchSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchSubdirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSearchSubdirectories.Location = New System.Drawing.Point(179, 73)
        Me.chkSearchSubdirectories.Name = "chkSearchSubdirectories"
        Me.chkSearchSubdirectories.Size = New System.Drawing.Size(153, 17)
        Me.chkSearchSubdirectories.TabIndex = 7
        Me.chkSearchSubdirectories.Text = "Include Subdirectories"
        Me.tipFileLocationTextBox.SetToolTip(Me.chkSearchSubdirectories, "If checked the subdirectories of the folder location will be scanned as well.")
        Me.chkSearchSubdirectories.UseVisualStyleBackColor = True
        '
        'lblFileExtensionLabel
        '
        Me.lblFileExtensionLabel.AutoSize = True
        Me.lblFileExtensionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileExtensionLabel.Location = New System.Drawing.Point(12, 55)
        Me.lblFileExtensionLabel.Name = "lblFileExtensionLabel"
        Me.lblFileExtensionLabel.Size = New System.Drawing.Size(86, 13)
        Me.lblFileExtensionLabel.TabIndex = 6
        Me.lblFileExtensionLabel.Text = "File Extension"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 225)
        Me.Controls.Add(Me.chkSearchSubdirectories)
        Me.Controls.Add(Me.lblFileExtensionLabel)
        Me.Controls.Add(Me.cbxFileExtension)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.gbxActionToTakeGroupBox)
        Me.Controls.Add(Me.btnBrowseFolderLocationButton)
        Me.Controls.Add(Me.txtFolderLocationTextBox)
        Me.Controls.Add(Me.lblFolderLocationLabel)
        Me.Name = "frmMainForm"
        Me.Text = "Duplicate Filename Finder"
        Me.gbxActionToTakeGroupBox.ResumeLayout(False)
        Me.gbxActionToTakeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFolderLocationLabel As System.Windows.Forms.Label
    Friend WithEvents txtFolderLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseFolderLocationButton As System.Windows.Forms.Button
    Friend WithEvents fbdFolderLocationToScan As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gbxActionToTakeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents radDeleteAll As System.Windows.Forms.RadioButton
    Friend WithEvents radLeaveOne As System.Windows.Forms.RadioButton
    Friend WithEvents radReportOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radPromptForEach As System.Windows.Forms.RadioButton
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents tipFileLocationTextBox As System.Windows.Forms.ToolTip
    Friend WithEvents cbxFileExtension As System.Windows.Forms.ComboBox
    Friend WithEvents lblFileExtensionLabel As System.Windows.Forms.Label
    Friend WithEvents chkSearchSubdirectories As System.Windows.Forms.CheckBox

End Class
