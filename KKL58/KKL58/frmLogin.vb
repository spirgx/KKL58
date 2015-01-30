Public Class frmLogin

    Dim QueryStr As String
    Dim QuerySet As System.Data.DataSet
    Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try


        QueryStr = "Select * From Users Where UserName = '" & UsernameTextBox.Text.Trim & _
                                        "' And Password = '" & PasswordTextBox.Text.Trim & "'"
        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "User")

        If QuerySet.Tables("User").Rows.Count > 0 Then
            frmMain.MenuStrip.Enabled = True
            UserName = UsernameTextBox.Text.Trim
            Permission = QuerySet.Tables("User").Rows(0).Item("Permission")
            DisconnectFromDatabase()

            If Permission = 0 Then
                frmMain.UserViewToolStripMenuItem.Visible = True
            End If


            Dim HomePage As New frmHomePage

            HomePage.MdiParent = frmMain

            HomePage.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            HomePage.WindowState = FormWindowState.Maximized

            HomePage.Show()

            Me.Close()
        Else
            MsgBox("使用者或密碼錯誤！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "登入")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
            Exit Sub
        End If

        frmMain.UserNameToolStripMenuItem.Text = "使用者：" & UserName

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper().ToCharArray()(0) '輸出大寫字母
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
End Class
