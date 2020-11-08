Public Class windowDebug

#Region "Member & Property"

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

    ''' <summary>
    ''' デストラクタ
    ''' </summary>
    Protected Overrides Sub Finalize()
        MyBase.Finalize()


    End Sub



#End Region

#Region "Function"

    ''' <summary>
    ''' イベントハンドラを追加
    ''' </summary>
    Private Sub AddEventHandler()
        AddHandler Me.btnAdd.Click, AddressOf ButtonClickEvent


    End Sub

    ''' <summary>
    ''' イベントハンドラを削除
    ''' </summary>
    Private Sub RemoveEventHandler()
        RemoveHandler Me.btnAdd.Click, AddressOf ButtonClickEvent


    End Sub

    ''' <summary>
    ''' ボタンクリックイベント処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonClickEvent(ByVal sender As Object, ByVal e As EventArgs)
        If Me.btnAdd.Equals(sender) Then
            Program.ShowWindowBook(New Book)

        End If
    End Sub

    'Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    'End Sub



    Private Sub InitGrdBook()
        With Me.grdBook
            .RowHeadersVisible = False
            .AllowUserToAddRows = False



        End With
    End Sub

#End Region

End Class