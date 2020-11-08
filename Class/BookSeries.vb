''' <summary>
''' シリーズを管理
''' </summary>
Public Class BookSeries

#Region "Member & Property"

    Private _MngNo As UInteger = CUInt(0)
    ''' <summary>
    ''' 管理番号の取得・設定(PK)
    ''' </summary>
    ''' <returns></returns>
    Public Property MngNo() As UInteger
        Get
            Return _MngNo
        End Get
        Set(ByVal value As UInteger)
            _MngNo = value
        End Set
    End Property

    Private _Title As String = Nothing
    ''' <summary>
    ''' タイトルの取得・設定
    ''' </summary>
    ''' <returns></returns>
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    Private _Books As Dictionary(Of UInteger, Book) = Nothing
    ''' <summary>
    ''' 管理する本の取得・設定(Key:BookNo, Item:Book)
    ''' </summary>
    ''' <returns></returns>
    Public Property Books() As Dictionary(Of UInteger, Book)
        Get
            Return _Books
        End Get
        Set(ByVal value As Dictionary(Of UInteger, Book))
            _Books = value
        End Set
    End Property

    ''' <summary>
    ''' 管理している本の総数
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property BooksCount() As Integer
        Get
            If Me._Books Is Nothing Then
                Return -1
            Else
                Return Me._Books.Count
            End If
        End Get
    End Property

#End Region

#Region "Event"

    ''' <summary>
    ''' インスタンス
    ''' </summary>
    Public Sub New(ByVal MngNo As UInteger)
        Me.InitMember(MngNo)
    End Sub

#End Region

#Region "Function"

    ''' <summary>
    ''' メンバの初期化
    ''' </summary>
    Private Sub InitMember(ByVal MngNo As UInteger)
        Me._MngNo = MngNo
        Me._Title = String.Empty
        Me._Books = New Dictionary(Of UInteger, Book)
    End Sub

    ''' <summary>
    ''' クローン
    ''' </summary>
    ''' <returns></returns>
    Public Function Clone() As BookSeries
        Dim clonedBookSeries As BookSeries = Nothing

        clonedBookSeries = New BookSeries(Me._MngNo)

        With clonedBookSeries
            .Title = Me._Title
            .Books = Me.MakeCloneBooks
        End With

        Return clonedBookSeries
    End Function

    ''' <summary>
    ''' クローンしたBookを作成
    ''' </summary>
    ''' <returns></returns>
    Private Function MakeCloneBooks() As Dictionary(Of UInteger, Book)
        Dim clonedBooks As Dictionary(Of UInteger, Book) = Nothing
        Dim Book As Book = Nothing

        clonedBooks = New Dictionary(Of UInteger, Book)

        If Me.BooksCount > 0 Then
            For i As Integer = 1 To Me._Books.Count
                Book = Me._Books(i)

                If Not clonedBooks.ContainsKey(Book.BookNo) Then
                    clonedBooks.Add(Book.MngNo, Book.Clone)
                End If
            Next
        End If

        Return clonedBooks
    End Function

    ''' <summary>
    ''' Bookを管理下に追加
    ''' </summary>
    ''' <param name="targetBook"></param>
    ''' <returns>True:Success,False:Fail</returns>
    Public Function AddBook(ByVal targetBook As Book) As Boolean
        Dim successed As Boolean = False

        If Me._Books Is Nothing Then Me.InitMember(targetBook.MngNo)

        If Me._Books.ContainsKey(targetBook.BookNo) Then
            successed = False
        Else
            Me._Books.Add(targetBook.BookNo, targetBook)

            successed = True
        End If

        Return successed
    End Function

#End Region

End Class
