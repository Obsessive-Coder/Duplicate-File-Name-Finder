Imports System.Windows.Forms

Public Class dlgScanReport

    Private Const SCAN_REPORT_LABEL_PREPEND_TEXT As String = "There are "
    Private Const SCAN_REPORT_LABEL_APPEND_TEXT As String = " Unchanged File"
    Private Const TIME_ELAPSED_LESS_THAN_SECOND_TEXT As String = "less than 1 second"
    ' A list of all duplicate file names
    Private fileScannerValue As Scanner
    Public ReadOnly Property FileScanner() As Scanner
        Get
            Return fileScannerValue
        End Get
    End Property

    Public Sub New(ByVal filenameScanner As Scanner)
        InitializeComponent()

        Me.fileScannerValue = filenameScanner
    End Sub

    Private Sub dlgScanReport_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim intNumberOfUnchangedFiles As Integer = 0
        For Each dupFile As DuplicateFile In Me.FileScanner.AllDuplicateFilesList
            ' Create a duplicate file control
            Dim newDuplicateFileControl As New ucDuplicateFileUserControl(dupFile)
            flpDuplicateFileControlsFlowLayoutPanel.Controls.Add(newDuplicateFileControl)
            If dupFile.Status.Equals("Unchanged") Then
                intNumberOfUnchangedFiles += 1
            End If
        Next

        If Me.FileScanner.ElapsedTime.Seconds < 1 Then
            lblTimeElapsedValue.Text = TIME_ELAPSED_LESS_THAN_SECOND_TEXT
        Else
            lblTimeElapsedValue.Text = BuildTimeElapsedText()
        End If

        lblFilesScannedValue.Text = Me.FileScanner.NumberOfFilesScanned.ToString()
        lblDuplicateFileNamesFoundValue.Text = Me.FileScanner.NumberOFDuplicatesFound.ToString()
        lblScanStatusValue.Text = BuildFileStatusLabelText(intNumberOfUnchangedFiles.ToString())
        If intNumberOfUnchangedFiles >= 1 Then
            lblScanStatusValue.ForeColor = Color.Red
        Else
            lblScanStatusValue.ForeColor = Color.Green
        End If


    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function BuildFileStatusLabelText(ByVal strNumberOfDuplicateFiles As String) As String
        Dim sb As New System.Text.StringBuilder
        sb.Append(SCAN_REPORT_LABEL_PREPEND_TEXT)
        sb.Append(strNumberOfDuplicateFiles)
        sb.Append(vbCrLf)
        sb.Append(SCAN_REPORT_LABEL_APPEND_TEXT)

        If Not strNumberOfDuplicateFiles.Equals("1") Then
            sb.Append("s")
        End If

        sb.Append("!")

        Return sb.ToString()
    End Function

    Private Function BuildTimeElapsedText() As String
        Dim sb As New System.Text.StringBuilder
        sb.Append(Me.FileScanner.ElapsedTime.Hours.ToString())
        sb.Append("h : ")
        sb.Append(Me.FileScanner.ElapsedTime.Minutes.ToString())
        sb.Append("m : ")
        sb.Append(Me.FileScanner.ElapsedTime.Seconds.ToString())
        sb.Append("s")

        Return sb.ToString()
    End Function
End Class
