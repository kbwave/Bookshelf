Imports System.Text

''' <summary>
''' 本の1冊に関しての設定画面
''' </summary>
Public Class windowBook

#Region "Member & Property"

    Private _TargetBook As Book = Nothing
    ''' <summary>
    ''' 編集対象のBook情報の取得・設定
    ''' </summary>
    ''' <returns></returns>
    Public Property TargetBook() As Book
        Get
            Return _TargetBook
        End Get
        Set(ByVal value As Book)
            _TargetBook = value
        End Set
    End Property

#End Region

#Region "Event"

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.AddEventHandler()
    End Sub

#End Region

#Region "Function"

    ''' <summary>
    ''' イベントハンドラを追加
    ''' </summary>
    Private Sub AddEventHandler()
        AddHandler Me.btnDecide.Click, AddressOf ButtonClickEvent
        AddHandler Me.btnClose.Click, AddressOf ButtonClickEvent
    End Sub

    ''' <summary>
    ''' ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonClickEvent(ByVal sender As Object, ByVal e As EventArgs)
        If Me.btnDecide.Equals(sender) Then
            Me.SetBookInfo()
            Me.DialogResult = DialogResult.OK

        ElseIf Me.btnClose.Equals(sender) Then
            Me.DialogResult = DialogResult.Cancel

        End If
    End Sub



    Private Sub SetBookInfo()
        If Me._TargetBook Is Nothing Then Me._TargetBook = New Book

        If Me.IsCompleteInput(True) Then
            With Me._TargetBook
                .MngNo = CUInt(1)
                .BookNo = CUInt(1)
                .Title = Me.txtTitle.Text
                .SubTitle = Me.txtSubTitle.Text
                .Category = CUInt(0)
                .Volume = CSng(1)
                .Value = CUInt(600)

            End With
        End If
    End Sub

    ''' <summary>
    ''' 入力情報に不備がないか
    ''' </summary>
    ''' <returns></returns>
    Private Function IsCompleteInput(ByVal showMessage As Boolean) As Boolean
        Dim complete As Boolean = True
        Dim errContents As StringBuilder = Nothing

        errContents = New StringBuilder

        If String.IsNullOrWhiteSpace(Me.txtTitle.Text.Trim) Then
            errContents.AppendLine("タイトルが入力されていません。")
        End If




        Return complete
    End Function


#End Region

End Class