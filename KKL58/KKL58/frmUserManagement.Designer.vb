<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManagement))
        Me.ButtonModifyUser = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxUser = New System.Windows.Forms.TextBox
        Me.ButtonNewUser = New System.Windows.Forms.Button
        Me.ButtonDeleteUser = New System.Windows.Forms.Button
        Me.TextBoxPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxNewPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxCheckPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.ButtonCencel = New System.Windows.Forms.Button
        Me.權限設定 = New System.Windows.Forms.Label
        Me.ComboBoxPermission = New System.Windows.Forms.ComboBox
        Me.ComboBoxUser = New System.Windows.Forms.ComboBox
        Me.ButtonUserView = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ButtonModifyUser
        '
        Me.ButtonModifyUser.BackColor = System.Drawing.Color.Transparent
        Me.ButtonModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonModifyUser.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonModifyUser.ForeColor = System.Drawing.Color.White
        Me.ButtonModifyUser.Location = New System.Drawing.Point(128, 12)
        Me.ButtonModifyUser.Name = "ButtonModifyUser"
        Me.ButtonModifyUser.Size = New System.Drawing.Size(100, 30)
        Me.ButtonModifyUser.TabIndex = 1
        Me.ButtonModifyUser.Text = "修改密碼"
        Me.ButtonModifyUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "使用者名稱："
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxUser.Location = New System.Drawing.Point(127, 60)
        Me.TextBoxUser.MaxLength = 10
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(217, 29)
        Me.TextBoxUser.TabIndex = 4
        '
        'ButtonNewUser
        '
        Me.ButtonNewUser.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNewUser.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonNewUser.ForeColor = System.Drawing.Color.White
        Me.ButtonNewUser.Location = New System.Drawing.Point(12, 12)
        Me.ButtonNewUser.Name = "ButtonNewUser"
        Me.ButtonNewUser.Size = New System.Drawing.Size(100, 30)
        Me.ButtonNewUser.TabIndex = 5
        Me.ButtonNewUser.Text = "新增使用者"
        Me.ButtonNewUser.UseVisualStyleBackColor = False
        '
        'ButtonDeleteUser
        '
        Me.ButtonDeleteUser.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDeleteUser.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonDeleteUser.ForeColor = System.Drawing.Color.White
        Me.ButtonDeleteUser.Location = New System.Drawing.Point(244, 12)
        Me.ButtonDeleteUser.Name = "ButtonDeleteUser"
        Me.ButtonDeleteUser.Size = New System.Drawing.Size(100, 30)
        Me.ButtonDeleteUser.TabIndex = 6
        Me.ButtonDeleteUser.Text = "刪除使用者"
        Me.ButtonDeleteUser.UseVisualStyleBackColor = False
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(127, 100)
        Me.TextBoxPassword.MaxLength = 10
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBoxPassword.Size = New System.Drawing.Size(217, 29)
        Me.TextBoxPassword.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "使用者密碼："
        '
        'TextBoxNewPassword
        '
        Me.TextBoxNewPassword.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxNewPassword.Location = New System.Drawing.Point(127, 140)
        Me.TextBoxNewPassword.MaxLength = 10
        Me.TextBoxNewPassword.Name = "TextBoxNewPassword"
        Me.TextBoxNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBoxNewPassword.Size = New System.Drawing.Size(217, 29)
        Me.TextBoxNewPassword.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "新密碼："
        '
        'TextBoxCheckPassword
        '
        Me.TextBoxCheckPassword.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxCheckPassword.Location = New System.Drawing.Point(127, 180)
        Me.TextBoxCheckPassword.MaxLength = 10
        Me.TextBoxCheckPassword.Name = "TextBoxCheckPassword"
        Me.TextBoxCheckPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBoxCheckPassword.Size = New System.Drawing.Size(217, 29)
        Me.TextBoxCheckPassword.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "確認密碼："
        '
        'ButtonOK
        '
        Me.ButtonOK.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonOK.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonOK.ForeColor = System.Drawing.Color.White
        Me.ButtonOK.Location = New System.Drawing.Point(166, 262)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(82, 30)
        Me.ButtonOK.TabIndex = 13
        Me.ButtonOK.Text = "確    定"
        Me.ButtonOK.UseVisualStyleBackColor = False
        '
        'ButtonCencel
        '
        Me.ButtonCencel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCencel.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonCencel.ForeColor = System.Drawing.Color.White
        Me.ButtonCencel.Location = New System.Drawing.Point(264, 262)
        Me.ButtonCencel.Name = "ButtonCencel"
        Me.ButtonCencel.Size = New System.Drawing.Size(80, 30)
        Me.ButtonCencel.TabIndex = 14
        Me.ButtonCencel.Tag = ""
        Me.ButtonCencel.Text = "取    消"
        Me.ButtonCencel.UseVisualStyleBackColor = False
        '
        '權限設定
        '
        Me.權限設定.AutoSize = True
        Me.權限設定.BackColor = System.Drawing.Color.Transparent
        Me.權限設定.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.權限設定.ForeColor = System.Drawing.Color.White
        Me.權限設定.Location = New System.Drawing.Point(10, 224)
        Me.權限設定.Name = "權限設定"
        Me.權限設定.Size = New System.Drawing.Size(105, 24)
        Me.權限設定.TabIndex = 15
        Me.權限設定.Text = "權限設定："
        '
        'ComboBoxPermission
        '
        Me.ComboBoxPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPermission.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBoxPermission.FormattingEnabled = True
        Me.ComboBoxPermission.Location = New System.Drawing.Point(127, 221)
        Me.ComboBoxPermission.Name = "ComboBoxPermission"
        Me.ComboBoxPermission.Size = New System.Drawing.Size(217, 28)
        Me.ComboBoxPermission.TabIndex = 16
        '
        'ComboBoxUser
        '
        Me.ComboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUser.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBoxUser.FormattingEnabled = True
        Me.ComboBoxUser.Location = New System.Drawing.Point(128, 61)
        Me.ComboBoxUser.Name = "ComboBoxUser"
        Me.ComboBoxUser.Size = New System.Drawing.Size(216, 28)
        Me.ComboBoxUser.TabIndex = 17
        '
        'ButtonUserView
        '
        Me.ButtonUserView.BackColor = System.Drawing.Color.Transparent
        Me.ButtonUserView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUserView.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonUserView.ForeColor = System.Drawing.Color.White
        Me.ButtonUserView.Location = New System.Drawing.Point(12, 262)
        Me.ButtonUserView.Name = "ButtonUserView"
        Me.ButtonUserView.Size = New System.Drawing.Size(122, 30)
        Me.ButtonUserView.TabIndex = 18
        Me.ButtonUserView.Text = "所有使用者"
        Me.ButtonUserView.UseVisualStyleBackColor = False
        Me.ButtonUserView.Visible = False
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(359, 304)
        Me.Controls.Add(Me.ButtonUserView)
        Me.Controls.Add(Me.ComboBoxUser)
        Me.Controls.Add(Me.ComboBoxPermission)
        Me.Controls.Add(Me.權限設定)
        Me.Controls.Add(Me.ButtonCencel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBoxCheckPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNewPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonDeleteUser)
        Me.Controls.Add(Me.ButtonNewUser)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonModifyUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "使用者管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonModifyUser As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUser As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNewUser As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteUser As System.Windows.Forms.Button
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCheckPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCencel As System.Windows.Forms.Button
    Friend WithEvents 權限設定 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPermission As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxUser As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonUserView As System.Windows.Forms.Button
End Class
