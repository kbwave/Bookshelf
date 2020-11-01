Module Program


    <STAThread>
    Public Sub Main()

        SaveFile.SetUp()

        Using winBookshelf As New windowBookshelf
            winBookshelf.ShowDialog()
        End Using


    End Sub



End Module
