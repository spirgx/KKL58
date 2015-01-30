Public Class frmUserManagement

    Private ActionMode As Integer = 0

    Dim QueryStr As String
    Dim QuerySet As System.Data.DataSet
    Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter
    Dim ModifyUserPermission As Integer

    Private Enum EditModeSelection
        NormalMode = 0
        UserAddMode = 1
        UserModifyMode = 2
        UserDeleteMode = 3
    End Enum

    Private Sub TextBoxPermission_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ComboBoxPermission.Text = ""
        ComboBoxPermission.ForeColor = Color.Black
    End Sub

    Private Sub TextBoxPermission_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar <> Microsoft.VisualBasic.ChrW(Keys.Back) Then '只輸出數字
            e.Handled = Not Char.IsDigit(e.KeyChar)
        End If

    End Sub

    Private Sub frmUserManagement_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'DisconnectFromDatabase()
    End Sub

    Private Sub frmUserManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ConnectToDatabase()

        Dim list As New DataTable()
        list.Columns.Add(New DataColumn("Display", System.Type.GetType("System.String")))
        list.Columns.Add(New DataColumn("Id", System.Type.GetType("System.Int32")))

        list.Rows.Add(list.NewRow())
        list.Rows.Add(list.NewRow())
        list.Rows.Add(list.NewRow())
        list.Rows(0)(0) = "金城廠"
        list.Rows(0)(1) = 3999
        list.Rows(1)(0) = "金寧廠"
        list.Rows(1)(1) = 6999
        list.Rows(2)(0) = "工安室"
        list.Rows(2)(1) = 9999

        ComboBoxPermission.DataSource = list
        ComboBoxPermission.DisplayMember = "Display"
        ComboBoxPermission.ValueMember = "Id"

        If Permission = 3999 Or Permission = 6999 Then
            ButtonNewUser.Enabled = False
            ButtonModifyUser.Enabled = True
            ButtonDeleteUser.Enabled = False
            TextBoxUser.Enabled = False
            TextBoxUser.Text = UserName
            TextBoxPassword.Enabled = False
            TextBoxNewPassword.Enabled = False
            TextBoxCheckPassword.Enabled = False
            ComboBoxPermission.Enabled = False
            ComboBoxPermission.SelectedValue = Permission
            ButtonOK.Enabled = False
            ComboBoxUser.Visible = False
            ComboBoxUser.Enabled = False
        Else
            ButtonNewUser.Enabled = True
            ButtonModifyUser.Enabled = True
            ButtonDeleteUser.Enabled = True
            TextBoxUser.Enabled = False
            TextBoxUser.Text = UserName
            TextBoxPassword.Enabled = False
            TextBoxNewPassword.Enabled = False
            TextBoxCheckPassword.Enabled = False
            ComboBoxPermission.Enabled = False
            ComboBoxPermission.SelectedValue = Permission
            ButtonOK.Enabled = False
            ComboBoxUser.Visible = False
            ComboBoxUser.Enabled = False
        End If

        If Permission = 0 Then
            ButtonUserView.Visible = True
        End If

    End Sub


    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Try

            If ActionMode = EditModeSelection.UserAddMode Then

                QueryStr = "Select * From Users Where UserName = '" & Trim(TextBoxUser.Text.Trim) & "'"
                QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
                QuerySet = New System.Data.DataSet
                QueryAdapt.Fill(QuerySet, "User")

                If QuerySet.Tables("User").Rows.Count > 0 Then
                    MsgBox("使用者已經存在！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "新增使用者")
                    TextBoxUser.Text = ""
                    TextBoxPassword.Text = ""
                    TextBoxCheckPassword.Text = ""
                    ComboBoxPermission.SelectedIndex = 0
                    Exit Sub
                End If

                If TextBoxPassword.Text.Trim <> TextBoxCheckPassword.Text.Trim Then
                    MsgBox("請確認兩次密碼是否相符！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "新增使用者")
                    TextBoxUser.Text = ""
                    TextBoxPassword.Text = ""
                    TextBoxCheckPassword.Text = ""
                    ComboBoxPermission.SelectedIndex = 0
                    Exit Sub
                End If

                If MsgBox("確定要新增使用者？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "新增使用者") = MsgBoxResult.Yes Then

                    QueryStr = "INSERT INTO Users( UserName, Password, Permission)" & _
                                    "VALUES ('" & TextBoxUser.Text.Trim & "','" & TextBoxPassword.Text.Trim & "', " & ComboBoxPermission.SelectedValue & ")"

                    QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
                    QuerySet = New System.Data.DataSet
                    QueryAdapt.Fill(QuerySet, "User")

                    TextBoxUser.Text = ""
                    TextBoxPassword.Text = ""
                    TextBoxCheckPassword.Text = ""
                    ComboBoxPermission.SelectedIndex = 0

                End If

            End If

            If ActionMode = EditModeSelection.UserModifyMode Then

                If Permission = 0 Or Permission = 9999 Then
                    QueryStr = "Select * From Users Where UserName = '" & ComboBoxUser.Text.Trim & "'"
                Else
                    QueryStr = "Select * From Users Where UserName = '" & TextBoxUser.Text.Trim & "'"
                End If


                QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
                QuerySet = New System.Data.DataSet
                QueryAdapt.Fill(QuerySet, "User")

                If Trim(QuerySet.Tables("User").Rows(0).Item("Password").ToString) <> TextBoxPassword.Text.Trim Then
                    MsgBox("舊密碼輸入錯誤！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "修改密碼")
                    TextBoxUser.Text = ""
                    TextBoxPassword.Text = ""
                    TextBoxNewPassword.Text = ""
                    TextBoxCheckPassword.Text = ""
                    ComboBoxPermission.SelectedIndex = 0
                    Exit Sub
                End If

                If TextBoxNewPassword.Text.Trim <> TextBoxCheckPassword.Text.Trim Then
                    MsgBox("請確認兩次密碼是否相符！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "修改密碼")
                    TextBoxUser.Text = ""
                    TextBoxPassword.Text = ""
                    TextBoxNewPassword.Text = ""
                    TextBoxCheckPassword.Text = ""
                    ComboBoxPermission.SelectedIndex = 0
                    Exit Sub
                End If


                If MsgBox("確定要修改密碼？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "密碼修改") = MsgBoxResult.Yes Then

                    If Permission = 0 Or Permission = 9999 Then
                        QueryStr = "UPDATE Users SET Password = '" & TextBoxNewPassword.Text.Trim & "' WHERE UserName = '" & ComboBoxUser.Text.Trim & "'"
                    Else
                        QueryStr = "UPDATE Users SET Password = '" & TextBoxNewPassword.Text.Trim & "' WHERE UserName = '" & TextBoxUser.Text.Trim & "'"
                    End If


                    QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
                    QuerySet = New System.Data.DataSet
                    QueryAdapt.Fill(QuerySet, "User")

                    TextBoxUser.Text = ""
                    TextBoxPassword.Text = ""
                    TextBoxNewPassword.Text = ""
                    TextBoxCheckPassword.Text = ""
                    ComboBoxPermission.SelectedIndex = 0
                    ComboBoxUser.Text = ""
                    ComboBoxUser.Enabled = False
                    ComboBoxUser.Visible = False
                    TextBoxUser.Enabled = False
                    TextBoxUser.Visible = True
                End If

            End If

            If ActionMode = EditModeSelection.UserDeleteMode Then

                QueryStr = "Select * From Users Where UserName = '" & TextBoxUser.Text.Trim & "'"
                QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
                QuerySet = New System.Data.DataSet
                QueryAdapt.Fill(QuerySet, "User")

                If QuerySet.Tables("User").Rows.Count > 0 Then

                    If MsgBox("確定要刪除這筆資料？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "刪除使用者") = MsgBoxResult.Yes Then

                        QueryStr = "Delete From Users Where UserName = '" & ComboBoxUser.Text & "'"
                        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
                        QuerySet = New System.Data.DataSet
                        QueryAdapt.Fill(QuerySet, "User")

                        TextBoxUser.Text = ""
                        TextBoxPassword.Text = ""
                        TextBoxNewPassword.Text = ""
                        TextBoxCheckPassword.Text = ""
                        ComboBoxPermission.SelectedIndex = 0
                        ComboBoxUser.Visible = True
                        ComboBoxUser.Enabled = True

                        Try
                            If Not ConnectToDatabase() Then
                                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                                Exit Sub
                            End If
                        Catch ex As Exception
                        End Try

                        If Permission = 0 Then
                            QueryStr = "Select * From Users Where (Permission <> 0) Order By UserName"
                        Else
                            QueryStr = "Select * From Users Where (Permission = 3999) Or (permission = 6999) Order By UserName"
                        End If
                        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
                        QuerySet = New System.Data.DataSet
                        QueryAdapt.Fill(QuerySet, "User")
                        ComboBoxUser.DataSource = QuerySet.Tables("User")
                        ComboBoxUser.DisplayMember = QuerySet.Tables("User").Columns("UserName").ToString.Trim
                        ComboBoxUser.ValueMember = QuerySet.Tables("User").Columns("Permission").ToString.Trim
                        ModifyUserPermission = ComboBoxUser.SelectedValue
                        ComboBoxPermission.SelectedValue = ModifyUserPermission

                        DisconnectFromDatabase()

                        TextBoxUser.Text = ""
                        TextBoxPassword.Text = ""
                        TextBoxNewPassword.Text = ""
                        TextBoxCheckPassword.Text = ""
                        ComboBoxPermission.SelectedIndex = 0
                        ComboBoxUser.Text = ""
                        ComboBoxUser.Enabled = False
                        ComboBoxUser.Visible = False
                        TextBoxUser.Enabled = False
                        TextBoxUser.Visible = True

                    End If

                Else

                    MsgBox("沒有這個使用者名稱！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "刪除使用者")
                    TextBoxUser.Text = ""
                    Exit Sub

                End If



            End If

            TextBoxUser.Text = UserName
            TextBoxPassword.Text = ""
            TextBoxNewPassword.Text = ""
            TextBoxCheckPassword.Text = ""
            ComboBoxPermission.SelectedIndex = 0

            TextBoxUser.Enabled = False
            TextBoxPassword.Enabled = False
            TextBoxNewPassword.Enabled = False
            TextBoxCheckPassword.Enabled = False
            ComboBoxPermission.Enabled = False
            ButtonOK.Enabled = False
            ButtonNewUser.Enabled = True
            ButtonModifyUser.Enabled = True
            ButtonDeleteUser.Enabled = True
            ComboBoxPermission.Enabled = False

            ActionMode = EditModeSelection.NormalMode
        Catch
        End Try

        DisconnectFromDatabase()

    End Sub

    Private Sub ButtonCencel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCencel.Click

        ActionMode = EditModeSelection.NormalMode
        TextBoxUser.Enabled = False
        TextBoxPassword.Enabled = False
        TextBoxNewPassword.Enabled = False
        TextBoxCheckPassword.Enabled = False
        ComboBoxPermission.Enabled = False
        ButtonOK.Enabled = False
        Me.Close()

    End Sub

    Private Sub ButtonNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewUser.Click
        TextBoxUser.Enabled = True
        TextBoxPassword.Enabled = True
        TextBoxNewPassword.Enabled = False
        TextBoxCheckPassword.Enabled = True
        ComboBoxPermission.Enabled = True
        ButtonOK.Enabled = True
        TextBoxUser.Text = ""
        TextBoxPassword.Text = ""
        TextBoxNewPassword.Text = ""
        TextBoxCheckPassword.Text = ""
        'ComboBoxPermission.Text = "請輸入1~9999"
        'ComboBoxPermission.ForeColor = Color.Gray
        ButtonNewUser.Enabled = False
        ButtonModifyUser.Enabled = False
        ButtonDeleteUser.Enabled = False
        ActionMode = EditModeSelection.UserAddMode
    End Sub

    Private Sub ButtonModifyUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyUser.Click
        If Permission = 3999 Or Permission = 6999 Then
            ComboBoxUser.Visible = False
            ComboBoxUser.Enabled = False
            TextBoxUser.Enabled = False
            TextBoxUser.Visible = True
            TextBoxPassword.Enabled = True
            TextBoxNewPassword.Enabled = True
            TextBoxCheckPassword.Enabled = True
            ComboBoxPermission.Enabled = False
            ButtonOK.Enabled = True
            ButtonNewUser.Enabled = False
            ButtonModifyUser.Enabled = False
            ButtonDeleteUser.Enabled = False
            ActionMode = EditModeSelection.UserModifyMode
        Else
            ComboBoxUser.Visible = True
            ComboBoxUser.Enabled = True
            TextBoxUser.Enabled = False
            TextBoxUser.Visible = False
            TextBoxPassword.Enabled = True
            TextBoxNewPassword.Enabled = True
            TextBoxCheckPassword.Enabled = True
            ComboBoxPermission.Enabled = False
            ButtonOK.Enabled = True
            ButtonNewUser.Enabled = False
            ButtonModifyUser.Enabled = False
            ButtonDeleteUser.Enabled = False
            ActionMode = EditModeSelection.UserModifyMode

            Try
                If Not ConnectToDatabase() Then
                    MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                    Exit Sub
                End If
            Catch ex As Exception
            End Try

            If Permission = 0 Then
                QueryStr = "Select * From Users Order By UserName"
            Else
                QueryStr = "Select * From Users Where (Permission = 3999) Or (permission = 6999) Or (UserName = '" & UserName & "') Order By UserName"
            End If
            QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
            QuerySet = New System.Data.DataSet
            QueryAdapt.Fill(QuerySet, "User")
            ComboBoxUser.DataSource = QuerySet.Tables("User")
            ComboBoxUser.DisplayMember = QuerySet.Tables("User").Columns("UserName").ToString.Trim
            ComboBoxUser.ValueMember = QuerySet.Tables("User").Columns("Permission").ToString.Trim
            ModifyUserPermission = ComboBoxUser.SelectedValue
            ComboBoxPermission.SelectedValue = ModifyUserPermission

            DisconnectFromDatabase()

        End If
    End Sub

    Private Sub ButtonDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteUser.Click


        ComboBoxUser.Visible = True
        ComboBoxUser.Enabled = True

        TextBoxUser.Enabled = False
        TextBoxUser.Visible = False
        TextBoxPassword.Enabled = False
        TextBoxNewPassword.Enabled = False
        TextBoxCheckPassword.Enabled = False
        ComboBoxPermission.Enabled = False
        ButtonOK.Enabled = True
        ButtonNewUser.Enabled = False
        ButtonModifyUser.Enabled = False
        ButtonDeleteUser.Enabled = False
        ActionMode = EditModeSelection.UserDeleteMode

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        If Permission = 0 Then
            QueryStr = "Select * From Users Where (Permission <> 0) Order By UserName"
        Else
            QueryStr = "Select * From Users Where (Permission = 3999) Or (permission = 6999) Order By UserName"
        End If
        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "User")
        ComboBoxUser.DataSource = QuerySet.Tables("User")
        ComboBoxUser.DisplayMember = QuerySet.Tables("User").Columns("UserName").ToString.Trim
        ComboBoxUser.ValueMember = QuerySet.Tables("User").Columns("Permission").ToString.Trim
        ModifyUserPermission = ComboBoxUser.SelectedValue
        ComboBoxPermission.SelectedValue = ModifyUserPermission

        DisconnectFromDatabase()




    End Sub

    Private Sub TextBoxUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxUser.KeyPress

        e.KeyChar = e.KeyChar.ToString.ToUpper().ToCharArray()(0) '輸出大寫字母

    End Sub
    
    Private Sub ComboBoxUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxUser.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxUser_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxUser.SelectedValueChanged
        ComboBoxUser.DisplayMember = QuerySet.Tables("User").Columns("UserName").ToString.Trim
        ComboBoxUser.ValueMember = QuerySet.Tables("User").Columns("Permission").ToString.Trim
        ComboBoxPermission.SelectedValue = ComboBoxUser.SelectedValue
    End Sub

    Private Sub ButtonUserView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUserView.Click

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Dim UserView As New frmUserView

        UserView.MdiParent = frmMain

        UserView.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        UserView.WindowState = FormWindowState.Normal

        QueryStr = "Select UserName As '使用者名稱', Password As '使用者密碼', " & _
                "Case Permission When 9999 then '系統管理者'" & _
                "When 3999 then '金成廠' When 6999 then '金寧廠' " & _
                "When 0 then '超級使用者' End  '權限' From Users Order By UserName"
        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "User")

        UserView.DataGridView.DataSource = QuerySet.Tables("User")
        UserView.Show()

        DisconnectFromDatabase()

    End Sub
End Class