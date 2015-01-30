Public Class frmDataView

    Dim QueryStr As String
    Dim QuerySet As System.Data.DataSet
    Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter
    Dim StartDateTime As String
    Dim EndDateTime As String
    Dim RowIndex As Integer

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioKC.CheckedChanged

    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click

        



        StartDateTime = Format(StartDatePicker.Value, "yyyy/MM/dd") & " " & _
                           Format(StartTimePicker.Value, "HH:mm:ss")

        EndDateTime = Format(EndDatePicker.Value, "yyyy/MM/dd") & " " & _
                            Format(EndTimePicker.Value, "HH:mm:ss")

        If StartDateTime > EndDateTime Then
            MsgBox("結束時間小於開始時間", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
            Exit Sub
        End If

        QueryStr = "SELECT CONVERT(varchar, TimeStamp, 120 ) as '日期 時間', convert(decimal(8,1) ,IN_PH) as '進流水酸鹼值', " & _
                    "convert(decimal(8,3) ,IN_EC) as '進流水導電度',convert(decimal(8,1) ,IN_TEMP) as '進流水溫度', convert(decimal(8,1) ,IN_SS) as '進流水懸浮固體', convert(decimal(8,1) ,IN_COD) as '進流水化學需氧量', " & _
                    "convert(decimal(8,1) ,IN_AMDI) as '進流水色度',convert(decimal(8,1) ,OUT_PH) as '放流水酸鹼值', convert(decimal(8,3) ,OUT_EC) as '放流水導電度', convert(decimal(8,1) ,OUT_TEMP) as '放流水溫度', " & _
                    "convert(decimal(8,1) ,OUT_SS) as '放流水懸浮固體',convert(decimal(8,1) ,OUT_COD) as '放流水化學需氧量', convert(decimal(8,1) ,OUT_AMDI) as '放流水色度', convert(decimal(8,1) ,OUT_O2) as '放流水溶氧量' FROM "

        If RadioKC.Checked = True Then
            QueryStr = QueryStr & "KC_HOUR_TABLE"
        End If

        If RadioKN.Checked = True Then
            QueryStr = QueryStr & "KN_HOUR_TABLE"
        End If

        QueryStr = QueryStr & " WHERE (TimeStamp BETWEEN '" & StartDateTime & "' AND '" & EndDateTime & "')  ORDER BY TimeStamp"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "DataSet")

        DataGridView.DataSource = QuerySet.Tables("DataSet")

        If Me.DataGridView.RowCount > 0 Then
            TextBoxTimeStamp.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(0).Value.ToString)
            TextBoxInPH.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(1).Value.ToString)
            TextBoxInEC.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(2).Value.ToString)
            TextBoxInTemp.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(3).Value.ToString)
            TextBoxInSS.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(4).Value.ToString)
            TextBoxInCOD.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(5).Value.ToString)
            TextBoxInAMDI.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(6).Value.ToString)
            TextBoxOutPH.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(7).Value.ToString)
            TextBoxOutEC.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(8).Value.ToString)
            TextBoxOutTemp.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(9).Value.ToString)
            TextBoxOutSS.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(10).Value.ToString)
            TextBoxOutCOD.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(11).Value.ToString)
            TextBoxOutAMDI.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(12).Value.ToString)
            TextBoxOutO2.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(13).Value.ToString)
            RowIndex = Me.DataGridView.CurrentRow.Index
        Else
            TextBoxTimeStamp.Text = ""
            TextBoxInPH.Text = ""
            TextBoxInEC.Text = ""
            TextBoxInTemp.Text = ""
            TextBoxInSS.Text = ""
            TextBoxInCOD.Text = ""
            TextBoxInAMDI.Text = ""
            TextBoxOutPH.Text = ""
            TextBoxOutEC.Text = ""
            TextBoxOutTemp.Text = ""
            TextBoxOutSS.Text = ""
            TextBoxOutCOD.Text = ""
            TextBoxOutAMDI.Text = ""
            TextBoxOutO2.Text = ""
        End If


        'DisconnectFromDatabase()

    End Sub

    Private Sub frmDataView_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        DisconnectFromDatabase()

    End Sub

    Private Sub frmDataView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        If Permission = 3999 Then
            RadioKC.Checked = True
            RadioKC.SetBounds(18, 23, 74, 20)
            RadioKN.Checked = False
            RadioKN.Visible = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            ButtonUpdate.Visible = False
        End If

        If Permission = 6999 Then
            RadioKC.Checked = False
            RadioKC.Visible = False
            RadioKN.Checked = True
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            ButtonUpdate.Visible = False
        End If

        If Permission = 9999 Or Permission = 0 Then
            RadioKC.Checked = False
            RadioKC.Visible = True
            RadioKN.Checked = True
            RadioKN.Visible = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            ButtonUpdate.Visible = True
        End If


        AddHandler TextBoxInEC.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxInTemp.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxInSS.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxInCOD.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxInAMDI.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxOutPH.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxOutEC.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxOutTemp.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxOutSS.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxOutCOD.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxOutAMDI.KeyUp, AddressOf TextBoxInPH_KeyUp
        AddHandler TextBoxOutO2.KeyUp, AddressOf TextBoxInPH_KeyUp

    End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click

        Dim AreaName As String

        AreaName = ""

        'ConnectToDatabase()

        Dim DataViewReport As New frmDataViewReport

        DataViewReport.MdiParent = frmMain

        DataViewReport.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        DataViewReport.WindowState = FormWindowState.Normal

        StartDateTime = Format(StartDatePicker.Value, "yyyy/MM/dd") & " " & _
                          Format(StartTimePicker.Value, "HH:mm:ss")

        EndDateTime = Format(EndDatePicker.Value, "yyyy/MM/dd") & " " & _
                            Format(EndTimePicker.Value, "HH:mm:ss")


        If RadioKC.Checked = True Then
            QueryStr = "SELECT * FROM KC_HOUR_TABLE WHERE (TimeStamp BETWEEN '" & _
                            StartDateTime & "' AND '" & EndDateTime & "')  ORDER BY TimeStamp"
            AreaName = "金城廠"
        End If

        If RadioKN.Checked = True Then
            QueryStr = "SELECT * FROM KN_HOUR_TABLE WHERE (TimeStamp BETWEEN '" & _
                            StartDateTime & "' AND '" & EndDateTime & "')  ORDER BY TimeStamp"
            AreaName = "金寧廠"
        End If

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "ReportSet")

        Dim paras(7) As Microsoft.Reporting.WinForms.ReportParameter

        paras(0) = New Microsoft.Reporting.WinForms.ReportParameter("Title", "金門酒廠" & AreaName & "廢水監測系統資料瀏覽報表")
        paras(1) = New Microsoft.Reporting.WinForms.ReportParameter("StartDate", Format(StartDatePicker.Value, "yyyy/MM/dd").ToString)
        paras(2) = New Microsoft.Reporting.WinForms.ReportParameter("StartTime", Format(StartTimePicker.Value, "HH:mm:ss").ToString)
        paras(3) = New Microsoft.Reporting.WinForms.ReportParameter("EndDate", Format(EndDatePicker.Value, "yyyy/MM/dd").ToString)
        paras(4) = New Microsoft.Reporting.WinForms.ReportParameter("EndTime", Format(EndTimePicker.Value, "HH:mm:ss").ToString)
        paras(5) = New Microsoft.Reporting.WinForms.ReportParameter("Area", AreaName)
        paras(6) = New Microsoft.Reporting.WinForms.ReportParameter("Operator", UserName)
        paras(7) = New Microsoft.Reporting.WinForms.ReportParameter("PrintDate", Convert.ToInt16(DateTime.Now.AddYears(-1911).Year) & DateTime.Now.ToString("/MM/dd HH:mm:ss"))

        DataViewReport.ReportViewer.LocalReport.SetParameters(paras)

        DataViewReport.ReportViewer.LocalReport.DataSources(0).Value = QuerySet.Tables("ReportSet")
        DataViewReport.ReportViewer.RefreshReport()

        DataViewReport.Show()

        Me.Close()

        

        'DisconnectFromDatabase()

    End Sub

    Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click

        If Me.DataGridView.RowCount > 0 Then
            TextBoxTimeStamp.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(0).Value.ToString)
            TextBoxInPH.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(1).Value.ToString)
            TextBoxInEC.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(2).Value.ToString)
            TextBoxInTemp.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(3).Value.ToString)
            TextBoxInSS.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(4).Value.ToString)
            TextBoxInCOD.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(5).Value.ToString)
            TextBoxInAMDI.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(6).Value.ToString)
            TextBoxOutPH.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(7).Value.ToString)
            TextBoxOutEC.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(8).Value.ToString)
            TextBoxOutTemp.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(9).Value.ToString)
            TextBoxOutSS.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(10).Value.ToString)
            TextBoxOutCOD.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(11).Value.ToString)
            TextBoxOutAMDI.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(12).Value.ToString)
            TextBoxOutO2.Text = Trim(Me.DataGridView.Rows(Me.DataGridView.CurrentRow.Index).Cells(13).Value.ToString)
            RowIndex = Me.DataGridView.CurrentRow.Index
        End If

    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click

        If MsgBox("確定要修改這筆資料？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "資料修改確認") = MsgBoxResult.Yes Then

            QueryStr = "UPDATE "

            If RadioKC.Checked = True Then
                QueryStr = QueryStr & "KC_HOUR_TABLE"
            End If

            If RadioKN.Checked = True Then
                QueryStr = QueryStr & "KN_HOUR_TABLE"
            End If

            QueryStr = QueryStr & " SET IN_PH = " & Convert.ToSingle(TextBoxInPH.Text.Trim) & ", IN_EC = " & Convert.ToSingle(TextBoxInEC.Text.Trim) & _
                                    " , IN_TEMP = " & Convert.ToSingle(TextBoxInTemp.Text.Trim) & " , IN_SS = " & Convert.ToSingle(TextBoxInSS.Text.Trim) & _
                                    " , IN_COD = " & Convert.ToSingle(TextBoxInCOD.Text.Trim) & " , IN_AMDI = " & Convert.ToSingle(TextBoxInAMDI.Text.Trim) & _
                                    " , OUT_PH = " & Convert.ToSingle(TextBoxOutPH.Text.Trim) & " , OUT_EC = " & Convert.ToSingle(TextBoxOutEC.Text.Trim) & _
                                    " , OUT_TEMP = " & Convert.ToSingle(TextBoxOutTemp.Text.Trim) & " , OUT_SS = " & Convert.ToSingle(TextBoxOutSS.Text.Trim) & _
                                    " , OUT_COD = " & Convert.ToSingle(TextBoxOutCOD.Text.Trim) & " , OUT_AMDI = " & Convert.ToSingle(TextBoxOutAMDI.Text.Trim) & _
                                    " , OUT_O2 = " & Convert.ToSingle(TextBoxOutO2.Text.Trim) & _
                                    " WHERE TimeStamp = '" & TextBoxTimeStamp.Text.Trim & "'"

            QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
            QuerySet = New System.Data.DataSet
            QueryAdapt.Fill(QuerySet, "ReportSet")

            DataGridView.DataSource = QuerySet.Tables("DataSet")
            TabControl.SelectedIndex = 0


        End If

        QueryStr = "SELECT CONVERT(varchar, TimeStamp, 120 ) as '日期 時間', convert(decimal(8,1) ,IN_PH) as '進流水酸鹼值', " & _
                    "convert(decimal(8,3) ,IN_EC) as '進流水導電度',convert(decimal(8,1) ,IN_TEMP) as '進流水溫度', convert(decimal(8,1) ,IN_SS) as '進流水懸浮固體', convert(decimal(8,1) ,IN_COD) as '進流水化學需氧量', " & _
                    "convert(decimal(8,1) ,IN_AMDI) as '進流水色度',convert(decimal(8,1) ,OUT_PH) as '放流水酸鹼值', convert(decimal(8,3) ,OUT_EC) as '放流水導電度', convert(decimal(8,1) ,OUT_TEMP) as '放流水溫度', " & _
                    "convert(decimal(8,1) ,OUT_SS) as '放流水懸浮固體',convert(decimal(8,1) ,OUT_COD) as '放流水化學需氧量', convert(decimal(8,1) ,OUT_AMDI) as '放流水色度', convert(decimal(8,1) ,OUT_O2) as '放流水溶氧量' FROM "

        If RadioKC.Checked = True Then
            QueryStr = QueryStr & "KC_HOUR_TABLE"
        End If

        If RadioKN.Checked = True Then
            QueryStr = QueryStr & "KN_HOUR_TABLE"
        End If

        QueryStr = QueryStr & " WHERE (TimeStamp BETWEEN '" & StartDateTime & "' AND '" & EndDateTime & "')  ORDER BY TimeStamp"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "DataSet")

        DataGridView.DataSource = QuerySet.Tables("DataSet")
        DataGridView.CurrentCell = DataGridView.Rows(RowIndex).Cells(0)


    End Sub

    Private Sub TextBoxInPH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxInPH.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxInPH_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxInPH.KeyUp
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{tab}")
    End Sub

    Private Sub TextBoxInEC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxInEC.KeyPress
        OutputFloat(sender, e, 3)
    End Sub

    Private Sub TextBoxInTemp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxInTemp.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxInSS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxInSS.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxInCOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxInCOD.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxInAMDI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxInAMDI.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxOutPH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOutPH.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxOutEC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOutEC.KeyPress
        OutputFloat(sender, e, 3)
    End Sub

    Private Sub TextBoxOutTemp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOutTemp.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxOutSS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOutSS.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxOutCOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOutCOD.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxOutAMDI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOutAMDI.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

    Private Sub TextBoxOutO2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxOutO2.KeyPress
        OutputFloat(sender, e, 1)
    End Sub

End Class
