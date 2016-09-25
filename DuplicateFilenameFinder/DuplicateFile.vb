Imports System.IO
Public Class DuplicateFile

#Region "CONSTANTS"
    Private Const ACTION_TAKEN_NO_ACTION As String = "Unchanged"
    Private Const ACTION_TAKEN_FILE_DELETED As String = "Deleted"
    Private Const ACTION_TAKEN_FILE_MOVED As String = "Moved"
    Private Const ACTION_TAKEN_FILE_RENAMED As String = "Renamed"
    Private Const DIRECTORY_SEPERATOR As String = "\"
    Private Const FILE_EXTENSION_SEPERATOR As String = "."
#End Region

#Region "PROPERTIES"
    ' Full Path
    Private fullPathValue As String
    Public Property FullPath() As String
        Get
            Return fullPathValue
        End Get
        Set(ByVal value As String)
            fullPathValue = value
        End Set
    End Property

    ' Name (read only)
    Public ReadOnly Property Name() As String
        Get
            Return GetNameFromFullPath()
        End Get
    End Property

    ' Extension (read only)
    Public ReadOnly Property Extension() As String
        Get
            Return GetExtensionFromFullPath()
        End Get
    End Property

    ' Location (read only)
    Public ReadOnly Property Location() As String
        Get
            Return GetLocationFromFullPath()
        End Get
    End Property

    ' Status
    Private statusValue As String
    Public Property Status() As String
        Get
            Return statusValue
        End Get
        Set(value As String)
            statusValue = value
        End Set
    End Property

#End Region

#Region "PUBLIC METHODS"
    ' Intitialize
    Public Sub New(ByVal strFullPath As String)
        ' Assign the full path of the duplicate file.
        Me.fullPathValue = strFullPath
        Me.statusValue = ACTION_TAKEN_NO_ACTION
    End Sub

    ' Delete
    Public Function Delete() As String
        ' Delete the file if it exists.
        If File.Exists(Me.FullPath) Then
            ' Delete the file.
            File.Delete(Me.FullPath)
            ' Double check the file doesnt exist.
            If Not File.Exists(Me.FullPath) Then
                ' Change the status of the file to "Deleted".
                Me.Status = ACTION_TAKEN_FILE_DELETED
            End If
        End If

        ' Return the status of the file.
        Return Me.Status
    End Function

    ' Move
    Public Function Move(ByVal newFullPath As String) As String
        ' Move the file to the new loction if it exists in the
        ' original location and does not exist in the new location.
        If (File.Exists(Me.FullPath)) AndAlso (Not File.Exists(newFullPath)) Then
            ' Move the file to the new location.
            File.Move(Me.FullPath, newFullPath)
            ' Double check the file has been moved to the new location.
            If File.Exists(newFullPath) Then
                ' Change the path of the file to the new location.
                Me.fullPathValue = newFullPath
                ' Change the status of the file to "Moved".
                Me.Status = ACTION_TAKEN_FILE_MOVED
            End If
        End If

        ' Return the status of the file.
        Return Me.Status
    End Function

    Public Function Rename(ByVal strNewName As String) As String
        ' Rename the file if the original file exists and the new file name doesn't exist.
        If (File.Exists(Me.FullPath)) AndAlso _
            (Not File.Exists(Me.Location + DIRECTORY_SEPERATOR + strNewName + Me.Extension)) Then

            ' Rename the file.
            FileSystem.Rename(Me.FullPath, Me.Location + DIRECTORY_SEPERATOR + strNewName + Me.Extension)
            'Double check the file has been renamed.
            If Not File.Exists(Me.FullPath) Then
                ' Change the full path of the file to the new name
                Me.fullPathValue = Me.Location + DIRECTORY_SEPERATOR + strNewName + Me.Extension
                ' Change the status of the file to "Renamed".
                Me.Status = ACTION_TAKEN_FILE_RENAMED
            End If
        End If

        ' Return the status of the file.
        Return Me.Status
    End Function

    ' Show
    Public Sub Show()
        Process.Start(Me.Location)
    End Sub
#End Region

#Region "PRIVATE METHODS"
    ' Get File Location From Full File Path
    Private Function GetLocationFromFullPath() As String
        ' Get the file name and extension to be removed from the full file path.
        Dim strNameWithExtenstion As String = DIRECTORY_SEPERATOR + GetNameFromFullPath() + GetExtensionFromFullPath()
        ' Retrurn the file locatoin without file name or extension.
        Return Replace(Me.FullPath, strNameWithExtenstion, String.Empty)
    End Function

    ' Get File Name From Full File Path
    Private Function GetNameFromFullPath() As String
        ' Split the full file path property into substrings using the directory seperator("\").
        Dim strFolderSubstrings() As String = Me.FullPath.Split(DIRECTORY_SEPERATOR)
        ' Return only the file name of the file.
        Return Replace(strFolderSubstrings(strFolderSubstrings.Length - 1), GetExtensionFromFullPath(), "")
    End Function

    ' Get File Extension From Full File Path
    Private Function GetExtensionFromFullPath() As String
        ' The full file path reversed
        Dim intIndexOfFileExtension As Integer = Me.FullPath.IndexOf(FILE_EXTENSION_SEPERATOR)
        ' Return a substring starting at the index of the extenstion seperator(".") and ending at the end of the string.
        Return Me.FullPath.Substring(intIndexOfFileExtension, Me.FullPath.Length - (intIndexOfFileExtension))
    End Function
#End Region
End Class
