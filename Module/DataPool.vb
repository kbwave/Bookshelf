''' <summary>
''' データを管理するモジュール
''' </summary>
Module DataPool

    Private _Bookshelfs As Bookshelf = Nothing


#Region "Function"

    ''' <summary>
    ''' モジュールの使用準備
    ''' </summary>
    Public Sub SetUp()

        SetDatas()

    End Sub

    ''' <summary>
    ''' クラスの準備
    ''' </summary>
    Private Sub InstanceData()
        _Bookshelfs = New Bookshelf
    End Sub

    ''' <summary>
    ''' クラスにデータをセット
    ''' </summary>
    Private Sub SetDatas()
        'Constant
        InstanceData()


    End Sub


#End Region

End Module
