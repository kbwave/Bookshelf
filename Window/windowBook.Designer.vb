<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windowBook
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDecide = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblBookNo = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.txtSubTitle = New System.Windows.Forms.TextBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.chkRead = New System.Windows.Forms.CheckBox()
        Me.lnkImagePath = New System.Windows.Forms.LinkLabel()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDecide
        '
        Me.btnDecide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDecide.Location = New System.Drawing.Point(526, 546)
        Me.btnDecide.Name = "btnDecide"
        Me.btnDecide.Size = New System.Drawing.Size(75, 23)
        Me.btnDecide.TabIndex = 0
        Me.btnDecide.Text = "決定(&O)"
        Me.btnDecide.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(607, 546)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "閉じる(&C)"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.BackColor = System.Drawing.Color.White
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(12, 12)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(254, 298)
        Me.picImage.TabIndex = 2
        Me.picImage.TabStop = False
        '
        'lblMode
        '
        Me.lblMode.Location = New System.Drawing.Point(272, 12)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(293, 28)
        Me.lblMode.TabIndex = 3
        Me.lblMode.Text = "新規／編集"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(272, 80)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(61, 20)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "タイトル"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(365, 77)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(334, 27)
        Me.txtTitle.TabIndex = 5
        '
        'lblBookNo
        '
        Me.lblBookNo.AutoSize = True
        Me.lblBookNo.Location = New System.Drawing.Point(571, 16)
        Me.lblBookNo.Name = "lblBookNo"
        Me.lblBookNo.Size = New System.Drawing.Size(61, 20)
        Me.lblBookNo.TabIndex = 6
        Me.lblBookNo.Text = "管理番号"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Location = New System.Drawing.Point(272, 113)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(87, 20)
        Me.lblSubTitle.TabIndex = 7
        Me.lblSubTitle.Text = "サブタイトル"
        '
        'txtSubTitle
        '
        Me.txtSubTitle.Location = New System.Drawing.Point(365, 110)
        Me.txtSubTitle.Name = "txtSubTitle"
        Me.txtSubTitle.Size = New System.Drawing.Size(334, 27)
        Me.txtSubTitle.TabIndex = 8
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(272, 47)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(35, 20)
        Me.lblVolume.TabIndex = 9
        Me.lblVolume.Text = "巻数"
        '
        'txtVolume
        '
        Me.txtVolume.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtVolume.Location = New System.Drawing.Point(365, 44)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(76, 27)
        Me.txtVolume.TabIndex = 10
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(272, 146)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(61, 20)
        Me.lblCategory.TabIndex = 11
        Me.lblCategory.Text = "カテゴリ"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(365, 143)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(200, 28)
        Me.cmbCategory.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.TextBox1.Location = New System.Drawing.Point(365, 177)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 27)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(272, 180)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(35, 20)
        Me.lblValue.TabIndex = 14
        Me.lblValue.Text = "値段"
        '
        'chkRead
        '
        Me.chkRead.AutoSize = True
        Me.chkRead.Location = New System.Drawing.Point(365, 211)
        Me.chkRead.Name = "chkRead"
        Me.chkRead.Size = New System.Drawing.Size(54, 24)
        Me.chkRead.TabIndex = 15
        Me.chkRead.Text = "既読"
        Me.chkRead.UseVisualStyleBackColor = True
        '
        'lnkImagePath
        '
        Me.lnkImagePath.BackColor = System.Drawing.Color.White
        Me.lnkImagePath.Location = New System.Drawing.Point(12, 313)
        Me.lnkImagePath.Name = "lnkImagePath"
        Me.lnkImagePath.Size = New System.Drawing.Size(687, 23)
        Me.lnkImagePath.TabIndex = 16
        Me.lnkImagePath.TabStop = True
        Me.lnkImagePath.Text = "イメージパス"
        Me.lnkImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'windowBook
        '
        Me.AcceptButton = Me.btnDecide
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(711, 581)
        Me.Controls.Add(Me.lnkImagePath)
        Me.Controls.Add(Me.chkRead)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.txtSubTitle)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblBookNo)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDecide)
        Me.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "windowBook"
        Me.Text = "windowBook"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDecide As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblMode As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblBookNo As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents txtSubTitle As TextBox
    Friend WithEvents lblVolume As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblValue As Label
    Friend WithEvents chkRead As CheckBox
    Friend WithEvents lnkImagePath As LinkLabel
End Class
