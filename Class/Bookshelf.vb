''' <summary>
''' 本棚を管理
''' </summary>
Public Class Bookshelf

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

#End Region

End Class
