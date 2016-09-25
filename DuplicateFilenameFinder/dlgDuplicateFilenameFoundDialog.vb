Imports System.Windows.Forms

Public Class dlgDuplicateFilenameFoundDialog
#Region "PROPERTIES"
    Private duplicateFilesListValue As List(Of DuplicateFile)
    Public ReadOnly Property DuplicateFilesList() As List(Of DuplicateFile)
        Get
            Return duplicateFilesListValue
        End Get
    End Property
#End Region
#Region "PAGE EVENTS"
    Public Sub New(ByVal lstDuplicateFiles As List(Of DuplicateFile))
        InitializeComponent()

        Me.duplicateFilesListValue = lstDuplicateFiles
    End Sub

    Private Sub dlgDuplicateFilenameFoundDialog_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        For Each dupFile As DuplicateFile In Me.DuplicateFilesList
            ' Create a duplicate file control and add it to the flow layour panel.
            Dim newDuplicateFileControl As New ucDuplicateFileUserControl(dupFile)
            flpDuplicateFileControlsFlowLayoutPanel.Controls.Add(newDuplicateFileControl)
        Next
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region
End Class
