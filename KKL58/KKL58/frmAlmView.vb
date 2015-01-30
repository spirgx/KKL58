Public Class frmAlmView

    Dim StartDateTime As String
    Dim EndDateTime As String
    Dim QueryStr As String
    Dim QuerySet As System.Data.DataSet
    Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter


    Private Sub frmAlmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.WindowState = FormWindowState.Normal
        ComboAlmType.SelectedIndex = 0

        If Permission = 3999 Then
            ComboAreaList.SelectedIndex = 1
            ComboAreaList.Enabled = False
        End If

        If Permission = 6999 Then
            ComboAreaList.SelectedIndex = 0
            ComboAreaList.Enabled = False
        End If

        If Permission = 9999 Or Permission = 0 Then
            ComboAreaList.SelectedIndex = 0
            ComboAreaList.Enabled = True
        End If


        LabelOperator.Text = UserName

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

        Select Case ComboAreaList.Text.Trim
            Case "金寧廠"

                Try
                    If Not ConnectToKNAlmDB() Then
                        MsgBox("金寧廠警報資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                        Exit Sub
                    End If
                Catch ex As Exception
                End Try

            Case "金城廠"

                Try
                    If Not ConnectToKCAlmDB() Then
                        MsgBox("金城廠警報資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                        Exit Sub
                    End If
                Catch ex As Exception
                End Try

        End Select

        Dim AlmViewReport As New frmAlmViewReport

        AlmViewReport.MdiParent = frmMain

        AlmViewReport.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        AlmViewReport.WindowState = FormWindowState.Normal

        QueryStr = "SELECT * FROM "

        Select Case ComboAlmType.Text.Trim
            Case "警報"
                QueryStr = QueryStr & "v_AlarmHistory"
            Case "事件"
                QueryStr = QueryStr & "v_EventHistory"
            Case "警報及事件"
                QueryStr = QueryStr & "v_AlarmEventHistory"
        End Select

        QueryStr = QueryStr & " WHERE (EventStamp BETWEEN '" & StartDateTime & "' AND '" & EndDateTime & "') ORDER BY EventStamp,TagName"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "DataSet")

        Dim paras(7) As Microsoft.Reporting.WinForms.ReportParameter

        paras(0) = New Microsoft.Reporting.WinForms.ReportParameter("Title", "金門酒廠" & ComboAreaList.Text.Trim & "廢水監測系統資料" & ComboAlmType.Text.Trim & "報表")
        paras(1) = New Microsoft.Reporting.WinForms.ReportParameter("StartDate", Format(StartDatePicker.Value, "yyyy/MM/dd").ToString)
        paras(2) = New Microsoft.Reporting.WinForms.ReportParameter("StartTime", Format(StartTimePicker.Value, "HH:mm:ss").ToString)
        paras(3) = New Microsoft.Reporting.WinForms.ReportParameter("EndDate", Format(EndDatePicker.Value, "yyyy/MM/dd").ToString)
        paras(4) = New Microsoft.Reporting.WinForms.ReportParameter("EndTime", Format(EndTimePicker.Value, "HH:mm:ss").ToString)
        paras(5) = New Microsoft.Reporting.WinForms.ReportParameter("Area", ComboAreaList.Text.Trim)
        paras(6) = New Microsoft.Reporting.WinForms.ReportParameter("Operator", UserName)
        paras(7) = New Microsoft.Reporting.WinForms.ReportParameter("PrintDate", Convert.ToInt16(DateTime.Now.AddYears(-1911).Year) & DateTime.Now.ToString("/MM/dd HH:mm:ss"))

        AlmViewReport.ReportViewer.LocalReport.SetParameters(paras)


        AlmViewReport.ReportViewer.LocalReport.DataSources(0).Value = QuerySet.Tables("DataSet")
        AlmViewReport.ReportViewer.RefreshReport()

        AlmViewReport.Show()

        DisconnectFromDatabase()

        Me.Close()


    End Sub
End Class