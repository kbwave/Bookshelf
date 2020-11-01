Imports System.Text

''' <summary>
''' 本の情報を管理
''' </summary>
Public Class Book
    Implements ITreatCSVkbwave

#Region "Define"

    Private Enum MemberElement As Integer
        None = -1
        MngNo
        BookNo
        Title
        SubTitle
        Volume
        Category
        Value
        Read
        ImagePath

        Num
    End Enum

#End Region

#Region "Interface"

    ''' <summary>
    ''' CSV1行から自分自身へセット
    ''' </summary>
    ''' <param name="CSVLine"></param>
    Public Sub SetMeFromCSVLine(CSVLine As String) Implements ITreatCSVkbwave.SetMeFromCSVLine
        Throw New NotImplementedException()

        Dim Elements() As String = Nothing
        Dim Element As String = Nothing

        Elements = CSVLine.Split(","c)

        For i As Integer = Elements.Length To MemberElement.Num
            Elements.Append(String.Empty)
        Next

        If Elements.Length = MemberElement.Num Then
            Element = Elements(MemberElement.MngNo).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            If Not UInteger.TryParse(Element, Me.Value) Then Me.MngNo = CUInt(0)

            Element = Elements(MemberElement.BookNo).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            If Not UInteger.TryParse(Element, Me.Value) Then Me.BookNo = CUInt(0)

            Element = Elements(MemberElement.Title).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            Me.Title = Element

            Element = Elements(MemberElement.SubTitle).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            Me.SubTitle = Element

            Element = Elements(MemberElement.Volume).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            If Not Single.TryParse(Element, Me.Volume) Then Me.Volume = 0!

            Element = Elements(MemberElement.Category).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            If Not Integer.TryParse(Element, Me.Category) Then Me.Category = CUInt(0)

            Element = Elements(MemberElement.Value).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            If Not UInteger.TryParse(Element, Me.Value) Then Me.Value = CUInt(0)

            Element = Elements(MemberElement.Read).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            If Not Boolean.TryParse(Element, Me.Read) Then Me.Read = False

            Element = Elements(MemberElement.ImagePath).Trim.PadRight(3)
            Element = Element.Substring(1, Element.Length - 2)
            Me.ImagePath = Element

            Me.PaddingElement = Elements(MemberElement.Num)
        Else

        End If
    End Sub

    ''' <summary>
    ''' 情報をCSV1行化
    ''' </summary>
    ''' <returns></returns>
    Public Function ToCSVLine() As String Implements ITreatCSVkbwave.ToCSVLine
        Throw New NotImplementedException()

        Dim info As StringBuilder = Nothing
        info = New StringBuilder

        info.Append("'" & Me.Title & "','")
        info.Append("'" & Me.SubTitle & "','")
        info.Append(Me.Volume.ToString & "','")
        info.Append(Me.Category.ToString & "','")
        info.Append(Me.Value.ToString & "','")
        info.Append(Me.Read.ToString & "',")
        info.Append(Me.ImagePath & "','")

        info.Append(Me.PaddingElement)

        Return info.ToString
    End Function

#End Region

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

    Private _BookNo As UInteger = CUInt(0)
    ''' <summary>
    ''' 本番号の設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property BookNo() As UInteger
        Get
            Return _BookNo
        End Get
        Set(ByVal value As UInteger)
            _BookNo = value
        End Set
    End Property

    Private _Title As String = Nothing
    ''' <summary>
    ''' タイトルの設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value.Trim
        End Set
    End Property

    Private _SubTitle As String = Nothing
    ''' <summary>
    ''' サブタイトルの設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property SubTitle() As String
        Get
            Return _SubTitle
        End Get
        Set(ByVal value As String)
            _SubTitle = value.Trim
        End Set
    End Property

    Private _Volume As Single = 1.0!
    ''' <summary>
    ''' 巻数の設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property Volume() As Single
        Get
            Return _Volume
        End Get
        Set(ByVal value As Single)
            _Volume = value
        End Set
    End Property

    Private _Category As UInt16 = CUInt(0)
    ''' <summary>
    ''' カテゴリーの設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property Category() As UInt16
        Get
            Return _Category
        End Get
        Set(ByVal value As UInt16)
            _Category = value
        End Set
    End Property

    Private _Value As UInt32 = CUInt(0)
    ''' <summary>
    ''' 値段の設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property Value() As UInt32
        Get
            Return _Value
        End Get
        Set(ByVal value As UInt32)
            _Value = value
        End Set
    End Property

    Private _Read As Boolean
    ''' <summary>
    ''' 既読かの設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property Read() As Boolean
        Get
            Return _Read
        End Get
        Set(ByVal value As Boolean)
            _Read = value
        End Set
    End Property

    Private _ImagePath As String = Nothing
    ''' <summary>
    ''' 画像パス(絶対パス)の取得・設定
    ''' </summary>
    ''' <returns></returns>
    Public Property ImagePath() As String
        Get
            Return _ImagePath
        End Get
        Set(ByVal value As String)
            _ImagePath = value.Trim
        End Set
    End Property

    Private _PaddingElement As String = Nothing
    ''' <summary>
    ''' 余剰分の設定・取得
    ''' </summary>
    ''' <returns></returns>
    Public Property PaddingElement() As String
        Get
            Return _PaddingElement
        End Get
        Set(ByVal value As String)
            _PaddingElement = value
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
        Me._MngNo = CUInt(0)
        Me._BookNo = CUInt(0)
        Me._Title = String.Empty
        Me._SubTitle = String.Empty
        Me._Volume = 1.0!
        Me._Category = CUInt(0)
        Me._Value = CUInt(0)
        Me._Read = False
        Me._ImagePath = String.Empty

        Me._PaddingElement = String.Empty
    End Sub

    ''' <summary>
    ''' クローン
    ''' </summary>
    ''' <returns></returns>
    Public Function Clone() As Book
        Dim clonedBook As Book = Nothing

        clonedBook = New Book

        With clonedBook
            .MngNo = Me._MngNo
            .BookNo = Me._BookNo
            .Title = Me._Title
            .SubTitle = Me._SubTitle
            .Volume = Me._Volume
            .Category = Me._Category
            .Value = Me._Value
            .Read = Me._Read
            .ImagePath = Me._ImagePath

            .PaddingElement = Me._PaddingElement
        End With

        Return clonedBook
    End Function

#End Region

End Class
