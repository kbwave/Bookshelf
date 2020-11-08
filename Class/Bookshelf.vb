''' <summary>
''' 本棚を管理
''' </summary>
Public Class Bookshelf

#Region "Define"

    Private Const SaveFileNmaeCSV As String = "Bookshelf.csv"

#End Region

#Region "Member & Property"

    Private _BookSeries As Dictionary(Of UInteger, BookSeries) = Nothing
    ''' <summary>
    ''' 管理するシリーズの取得・設定
    ''' </summary>
    ''' <returns></returns>
    Public Property BookSeries() As Dictionary(Of UInteger, BookSeries)
        Get
            Return _BookSeries
        End Get
        Set(ByVal value As Dictionary(Of UInteger, BookSeries))
            _BookSeries = value
        End Set
    End Property

    ''' <summary>
    ''' 管理しているBookSeriesの総数
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property NumBookSeries() As Integer
        Get
            If Me._BookSeries Is Nothing Then
                Return -1
            Else
                Return Me._BookSeries.Count
            End If
        End Get
    End Property

#End Region

#Region "Event"

    ''' <summary>
    ''' インスタンス
    ''' </summary>
    Public Sub New()
        Me.InitMember()
    End Sub

#End Region

#Region "Function"

    ''' <summary>
    ''' メンバの初期化
    ''' </summary>
    Private Sub InitMember()
        Me._BookSeries = New Dictionary(Of UInteger, BookSeries)
    End Sub


    Public Function GetBookSeries(ByVal targetMngNo As UInteger) As BookSeries
        Dim targetBookSeries As BookSeries = Nothing

        If Me._BookSeries Is Nothing Then Me.InitMember()



        Return targetBookSeries
    End Function

    ''' <summary>
    ''' CSV1行から本を管理下に追加
    ''' </summary>
    ''' <param name="CSVLine"></param>
    ''' <returns>True:Success,False:Fail</returns>
    Public Function AddBookCSVLine(ByVal CSVLine As String) As Boolean
        Dim addBook As Book = Nothing
        Dim targetBookSeries As BookSeries = Nothing
        Dim successed As Boolean = False

        addBook = New Book
        addBook.SetMeFromCSVLine(CSVLine)

        If Not Me._BookSeries.ContainsKey(addBook.MngNo) Then
            Me._BookSeries.Add(addBook.MngNo, New BookSeries(addBook.MngNo))
        End If

        targetBookSeries = Me._BookSeries.Item(addBook.MngNo)
        successed = targetBookSeries.AddBook(addBook)

        Return successed
    End Function

#End Region

End Class
