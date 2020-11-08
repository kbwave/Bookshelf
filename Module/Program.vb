Module Program


    <STAThread>
    Public Sub Main()
        Dim showWindow As Form = Nothing

        SaveFile.SetUp()
        kbwaveRegistryLogic.StartUp()

#If DEBUG Then
        showWindow = New windowDebug
#Else
        showWindow = New windowBookshelf
#End If

        Using showWindow
            showWindow.ShowDialog()
        End Using

    End Sub


    Public Function ShowWindowBook(ByRef TargetBook As Book) As DialogResult
        Dim winBook As windowBook = Nothing
        Dim dResult As DialogResult = DialogResult.Cancel

        winBook = New windowBook
        With winBook
            .TargetBook = TargetBook

            dResult = .ShowDialog()
        End With

        Return dResult
    End Function


End Module
