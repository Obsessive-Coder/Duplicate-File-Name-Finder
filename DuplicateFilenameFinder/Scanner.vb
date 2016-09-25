Imports System.IO

Public Class Scanner
#Region "CONSTANTS"
    Private Const ACTION_TO_TAKE_PROMPT_FOR_EACH As String = "Prompt for each"
    Private Const ACTION_TON_TAKE_REPORT_ONLY As String = "Report only"
    Private Const ACTION_TO_TAKE_LEAVE_ONE As String = "Leave one"
    Private Const ACTION_TO_TAKE_DELETE_ALL As String = "Delete all"
    Private Const DIRECTORY_SEPERATOR As String = "\"
#End Region

#Region "PROPERTIES"
    ' Folder Location
    Private folderLocationValue As String
    Public ReadOnly Property FolderLocation() As String
        Get
            Return folderLocationValue
        End Get
    End Property

    ' File Extension
    Private fileExtensionValue As String
    Public ReadOnly Property FileExtension() As String
        Get
            Return fileExtensionValue
        End Get
    End Property

    ' Action To Take
    Private actionToTakeValue As String
    Public ReadOnly Property ActionToTake() As String
        Get
            Return actionToTakeValue
        End Get
    End Property

    ' Is Subdirectories Included
    Private subdirectorySearchOptionValue As SearchOption
    Public ReadOnly Property SubdirectorySearchOption() As SearchOption
        Get
            Return subdirectorySearchOptionValue
        End Get
    End Property

    ' File Paths List
    Private filePathsListValue As IEnumerable(Of String)
    Public Property FilePathsList() As IEnumerable(Of String)
        Get
            Return filePathsListValue
        End Get
        Set(ByVal value As IEnumerable(Of String))
            filePathsListValue = value
        End Set
    End Property

    ' Number Of Files Scanned
    Public ReadOnly Property NumberOfFilesScanned() As Integer
        Get
            Return Me.FilePathsList.Count
        End Get
    End Property

    ' All Duplicate Files List
    Private allDuplicateFilesListValue As List(Of DuplicateFile)
    Public Property AllDuplicateFilesList() As List(Of DuplicateFile)
        Get
            Return allDuplicateFilesListValue
        End Get
        Set(ByVal value As List(Of DuplicateFile))
            allDuplicateFilesListValue = value
        End Set
    End Property

    ' Number Of Duplicates Found
    Public ReadOnly Property NumberOFDuplicatesFound() As Integer
        Get
            Return Me.AllDuplicateFilesList.Count
        End Get
    End Property


    ' ElapsedTime
    Private elapsedTimeValue As TimeSpan
    Public ReadOnly Property ElapsedTime() As TimeSpan
        Get
            Return elapsedTimeValue
        End Get
    End Property

#End Region

#Region "PAGE EVENTS"
    Public Sub New(ByVal strFolderLocation As String, ByVal strFileExtenstion As String, ByVal strActionToTake As String, ByVal boolIsSubdirectoriesIncluded As Boolean)
        Me.folderLocationValue = strFolderLocation
        Me.fileExtensionValue = strFileExtenstion
        Me.actionToTakeValue = strActionToTake
        If boolIsSubdirectoriesIncluded Then
            Me.subdirectorySearchOptionValue = SearchOption.AllDirectories
        Else
            Me.subdirectorySearchOptionValue = SearchOption.TopDirectoryOnly

        End If
    End Sub
#End Region

    ' Scan the folder and all subfolders for duplicate file names.
    Public Function Scan() As Scanner
        Dim startTime As DateTime = DateTime.Now()
        Me.AllDuplicateFilesList = New List(Of DuplicateFile)
        Try
            Me.FilePathsList = Directory.EnumerateFiles(Me.FolderLocation, "*" + Me.FileExtension, Me.SubdirectorySearchOption)

            For Each strFilePath1 As String In Me.FilePathsList
                Dim lstDuplicateFilesList As New List(Of DuplicateFile)
                Dim path1 As String = strFilePath1
                For Each strFilePath2 As String In Me.FilePathsList
                    ' Check to ensure the files being compared are not the same file from the same location.
                    If Not strFilePath1.Equals(strFilePath2) Then
                        Dim strFileName1 As String = GetFileNameFromFullFilePath(strFilePath1)
                        Dim strFileName2 As String = GetFileNameFromFullFilePath(strFilePath2)
                        ' Check if the names of the files are the same.
                        If (strFileName1.Equals(strFileName2)) Then
                            ' The Files have the same name.
                            ' Add the first file path to the list of duplicate file names if it does not exist.
                            If Not lstDuplicateFilesList.Exists(Function(x) x.FullPath.Equals(path1)) Then
                                lstDuplicateFilesList.Add(New DuplicateFile(path1))
                            End If

                            Dim path2 As String = strFilePath2
                            ' Add the second file path to the list of duplicate file names if it does not exist.
                            If Not lstDuplicateFilesList.Exists(Function(x) x.FullPath.Equals(path2)) Then
                                lstDuplicateFilesList.Add(New DuplicateFile(path2))
                            End If
                        End If
                    End If
                Next

                If Not lstDuplicateFilesList.Count.Equals(0) Then
                    If Not Me.AllDuplicateFilesList.Exists(Function(x) x.FullPath.Equals(path1)) Then
                        Me.AllDuplicateFilesList.AddRange(lstDuplicateFilesList)

                        Select Case Me.ActionToTake
                            Case ACTION_TO_TAKE_PROMPT_FOR_EACH
                                Dim duplicateFileFoundDialog As New dlgDuplicateFilenameFoundDialog(lstDuplicateFilesList)
                                duplicateFileFoundDialog.ShowDialog()
                            Case ACTION_TO_TAKE_LEAVE_ONE
                                DeleteAllButOneDuplicateFile(lstDuplicateFilesList)
                            Case ACTION_TO_TAKE_DELETE_ALL
                                DeleteAllDuplicateFiles(lstDuplicateFilesList)
                        End Select
                    End If
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Me.elapsedTimeValue = DateTime.Now - startTime
        Return Me
    End Function

    ' Get File Name From Full File Path
    Private Function GetFileNameFromFullFilePath(ByVal strFilePath As String) As String

        ' Split the full file path property into substrings using the directory seperator("\").
        Dim strFolderSubstrings() As String = strFilePath.Split(DIRECTORY_SEPERATOR)

        ' Return only the file name of the file.
        Return strFolderSubstrings(strFolderSubstrings.Length - 1)
    End Function

    ' Delete All But One Duplicate File
    Private Sub DeleteAllButOneDuplicateFile(ByVal lstDuplicateFilesList As List(Of DuplicateFile))
        For i = 0 To lstDuplicateFilesList.Count - 2
            lstDuplicateFilesList(i).Delete()
        Next
    End Sub

    ' Delete All Duplicate Files
    Private Sub DeleteAllDuplicateFiles(ByVal lstDuplicateFilesList As List(Of DuplicateFile))
        For i = 0 To lstDuplicateFilesList.Count - 1
            lstDuplicateFilesList(i).Delete()
        Next
    End Sub
End Class
