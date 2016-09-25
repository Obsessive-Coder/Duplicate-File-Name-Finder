Public Class ucDuplicateFileUserControl

#Region "CONSTANTS"
    Private Const RENAME_FILE_INPUT_BOX_TITLE As String = "Rename File Input Box"
    Private Const RENAME_FILE_INPUT_BOX_MESSAGE As String = "Please provide a new name for the file."
    Private Const DIRECTORY_SEPERATOR As String = "\"
    Private Const FILE_EXTENSION_SEPERATOR As String = "."
#End Region

#Region "PROPERTIES"
    ' Duplicate File (read only)
    Private dupFileValue As DuplicateFile
    Public ReadOnly Property DupFile() As DuplicateFile
        Get
            Return dupFileValue
        End Get
    End Property
#End Region

#Region "PAGE EVENTS"
    Public Sub New(ByVal duplicateFile As DuplicateFile)
        InitializeComponent()
        ' set the file property to the duplicate file parameter.
        Me.dupFileValue = duplicateFile
    End Sub

    ' Page Load
    Private Sub ucDuplicateFileUserControl_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblFileNameValue.Text = Me.DupFile.Name + Me.DupFile.Extension
        lblFileLocationValue.Text = Me.DupFile.Location
        lblFileStatusLabel.Text = Me.DupFile.Status

        ChangeColorOfFileStatusLabelText()

        If Me.DupFile.Status.Equals("Deleted") Then
            Me.Enabled = False
        End If
    End Sub

    ' Delete File Link Label Clicked
    Private Sub lnkDeleteFileLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDeleteFileLinkLabel.LinkClicked
        ' Delete the file if it exists and set the label to the status of the file.
        DupFile.Delete()
        lblFileStatusLabel.Text = Me.DupFile.Status
        ChangeColorOfFileStatusLabelText()
        ' Set the enabled property of the duplicate file contol to file.exists()
        ' It will be enable if the file exists, disabled otherwise.
        Me.Enabled = System.IO.File.Exists(Me.DupFile.FullPath)
    End Sub

    ' Move File Link Button Clicked
    Private Sub lnkMoveFileLinkLabel_Click(sender As Object, e As System.EventArgs) Handles lnkMoveFileLinkLabel.Click
        ' This event is fired when the user clicks the move file link label and shows a folder browser control
        ' so the user can choose a new destination for the file.

        ' Show the folder browser dialog.
        Dim result As DialogResult = fbdMoveFileFolderBrowserDialog.ShowDialog()

        ' If the user clicked ok in the folder browser dialog then get the new file path and validate that
        ' the file exists DOES NOT exist in the desination path before moving it.
        If result.Equals(DialogResult.OK) Then
            Dim strNewFileLocation As String = fbdMoveFileFolderBrowserDialog.SelectedPath

            ' Move the file to the new location if it does not exist in the new location.
            Dim strNewFullFilePath As String = BuildFullFilePath(strNewFileLocation, Me.DupFile.Name, Me.DupFile.Extension)

            ' Move the file 
            Me.DupFile.Move(strNewFullFilePath)
            ' Change status label to current file status.
            lblFileStatusLabel.Text = Me.DupFile.Status
            ChangeColorOfFileStatusLabelText()
            ' Change the location value label text.
            lblFileLocationValue.Text = Me.DupFile.Location
        End If
    End Sub

    ' Rename File Link Button Clicked
    Private Sub lnkRenameFileLinkLabel_Click(sender As Object, e As System.EventArgs) Handles lnkRenameFileLinkLabel.Click
        ' This event fires when the user clicks the rename file link label. It shows an input box to get 
        ' the new file name from the user and changes the file name if it's different than the original.
        ' Finally change the file name property to the new file name.
            ' Show input box to get new file name from user.
            Dim strNewFileName As String = GetNewFileNameFromUser()
            ' Change the file name only if the new file name is different than the old file name.
        If Not strNewFileName.Equals(Me.DupFile.Name) Then
            ' Rename the file
            Me.DupFile.Rename(strNewFileName)
            ' Change the status label to the current status.
            lblFileStatusLabel.Text = Me.DupFile.Status
            ChangeColorOfFileStatusLabelText()
            ' Change the file name label text to the new file name.
            lblFileNameValue.Text = Me.DupFile.Name
        End If
    End Sub

    ' Show File Link Button Clicked
    Private Sub lnkShowFileLinkLabel_Click(sender As Object, e As System.EventArgs) Handles lnkShowFileLinkLabel.Click
        ' Show the folder that the file is in when the user clicks the show file link label.
        Me.DupFile.Show()
    End Sub
#End Region

#Region "PRIVATE METHODS"

    ' Get New File Name From User
    Private Function GetNewFileNameFromUser() As String
        ' This function shows an input box to the user when he clicks the 'rename file' link label.
        ' If the user provides a new name for the file and clicks 'ok' then the new file name is returned.
        ' If the user clicks cancel in the input box then the old file name is returned.

        ' The title, message, and new file name strings for the rename file input box.
        Dim title As String = RENAME_FILE_INPUT_BOX_TITLE
        Dim message As String = RENAME_FILE_INPUT_BOX_MESSAGE
        Dim strNewFileName As String

        ' Show message, title and default value
        strNewFileName = InputBox(message, title, Me.DupFile.Name)

        ' Set the new file name to the old file name if the cancel button was clicked.
        If String.IsNullOrEmpty(strNewFileName) Then
            strNewFileName = Me.DupFile.Name
        End If

        ' Return the new file name.
        Return strNewFileName
    End Function

    ' Build Full File Path
    Private Function BuildFullFilePath(ByVal strLocation As String, ByVal strName As String, ByVal strExtension As String) As String
        ' This function uses the file path and file name properties to build a string for the full file path
        ' of the file.
        Dim sb As New System.Text.StringBuilder
        sb.Append(strLocation)
        sb.Append(DIRECTORY_SEPERATOR)
        sb.Append(strName)
        sb.Append(strExtension)

        Return sb.ToString()
    End Function

    ' Change Color Of File Status Label Text
    Private Sub ChangeColorOfFileStatusLabelText()
        If Me.DupFile.Status.Equals("Unchanged") Then
            lblFileStatusLabel.ForeColor = Color.Red
        Else
            lblFileStatusLabel.ForeColor = Color.Green
        End If
    End Sub
#End Region
End Class
