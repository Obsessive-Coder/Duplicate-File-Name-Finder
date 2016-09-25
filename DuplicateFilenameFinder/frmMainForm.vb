Public Class frmMainForm

    ' Page Load
    Private Sub frmMainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Set the text of the folder location text box to the last folder location user setting.
        SetFolderLocationText()
        ' Set the text of the file extension combo box to the last file extension user setting.
        SetFileExtensionText()
        ' Set the last action to take user setting in the radio button group
        SetActionToTakeRadioButton()
        ' Enable or disable the scan button based on the text fields of the folder location and file extension.
        EnableDisableScanButton()
    End Sub

    ' Browse Folder Location Button Clicked
    Private Sub btnBrowseFolderLocationButton_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseFolderLocationButton.Click
        ' Set the folder browser selected path the the text in the folder location text box.
        fbdFolderLocationToScan.SelectedPath = txtFolderLocationTextBox.Text
        Dim result As DialogResult = fbdFolderLocationToScan.ShowDialog()
        If result.Equals(DialogResult.OK) Then
            ' Set the last folder location user setting to the selected path.
            My.Settings.LastFolderLocation = fbdFolderLocationToScan.SelectedPath

            ' Set the text of the folder locatin text box to the selected path.
            SetFolderLocationText()
        End If
    End Sub

    Private Sub btnScan_Click(sender As System.Object, e As System.EventArgs) Handles btnScan.Click
        Dim fileNameScanner As New Scanner(txtFolderLocationTextBox.Text, cbxFileExtension.Text, GetActionToTake(), chkSearchSubdirectories.Checked)
        fileNameScanner = fileNameScanner.Scan()
        Dim scannerReport As New dlgScanReport(fileNameScanner)
        scannerReport.ShowDialog()
    End Sub

    ' Folder Location Text Box Text Changed
    Private Sub txtFolderLocationTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles txtFolderLocationTextBox.TextChanged
        EnableDisableScanButton()
    End Sub

    ' Folder Location Text Box Lost Focus
    Private Sub txtFolderLocationTextBox_LostFocus(sender As Object, e As System.EventArgs) Handles txtFolderLocationTextBox.LostFocus
        If Not String.IsNullOrEmpty(txtFolderLocationTextBox.Text) Then
            My.Settings.LastFolderLocation = txtFolderLocationTextBox.Text
        End If
    End Sub

    ' File Extension Combo Box Text Changed
    Private Sub cbxFileExtension_TextChanged(sender As Object, e As System.EventArgs) Handles cbxFileExtension.TextChanged
        EnableDisableScanButton()
    End Sub

    ' File Extension Combo Box Lost Focus
    Private Sub cbxFileExtension_LostFocus(sender As Object, e As System.EventArgs) Handles cbxFileExtension.LostFocus
        If Not String.IsNullOrEmpty(cbxFileExtension.Text) Then
            My.Settings.LastFileExtension = cbxFileExtension.Text
        End If
    End Sub

    ' File Extension Combo Box Selected Index Changed
    Private Sub cbxFileExtension_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxFileExtension.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbxFileExtension.Text) Then
            My.Settings.LastFileExtension = cbxFileExtension.Text
        End If
    End Sub

    ' Enable Disable Scan Button
    Private Sub EnableDisableScanButton()
        ' This method is called when the text changes for the folder location or the file extension combo box
        If txtFolderLocationTextBox.Text.Equals(String.Empty) Or cbxFileExtension.Text.Equals(String.Empty) Then
            btnScan.Enabled = False
        Else
            btnScan.Enabled = True
        End If
    End Sub

    ' Set Folder Location Text Box Text
    Private Sub SetFolderLocationText()
        If Not My.Settings.LastFolderLocation.Equals(String.Empty) Then
            txtFolderLocationTextBox.Text = My.Settings.LastFolderLocation
        End If
    End Sub

    ' Set File Extension Combo Box Text
    Private Sub SetFileExtensionText()
        If Not My.Settings.LastFileExtension.Equals(String.Empty) Then
            cbxFileExtension.Text = My.Settings.LastFileExtension
        End If
    End Sub

    ' Set Action To Take Radio Button
    Private Sub SetActionToTakeRadioButton()
        If Not My.Settings.LastActionToTake.Equals(String.Empty) Then
            For Each radButton In gbxActionToTakeGroupBox.Controls.OfType(Of RadioButton)()
                If radButton.Text.Equals(My.Settings.LastActionToTake) Then
                    radButton.Checked = True
                    Exit For
                End If
            Next
        End If
    End Sub

    ' Get Action To Take
    Private Function GetActionToTake()
        For Each radButton In gbxActionToTakeGroupBox.Controls.OfType(Of RadioButton)()
            If radButton.Checked.Equals(True) Then
                Return radButton.Text
            End If
        Next

        ' Being as at least one radio button is checked at all times, this code should never run.
        Return String.Empty
    End Function

    Private Sub ActionToTakeRadioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles radPromptForEach.Click, _
                                                                                                        radReportOnly.Click, _
                                                                                                        radLeaveOne.Click, _
                                                                                                        radDeleteAll.Click

        Dim radButton As RadioButton = sender
        If radButton.Checked Then
            ' Upate the last action taken user setting.
            My.Settings.LastActionToTake = radButton.Text
        End If

    End Sub
End Class
