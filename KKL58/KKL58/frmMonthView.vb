Public Class frmMonthView

    Dim QueryStr As String
    Dim QuerySet As System.Data.DataSet
    Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter

    Private Sub frmMonthView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Permission = 3999 Then
            RadioKC.Checked = True
            RadioKC.SetBounds(18, 23, 74, 20)
            RadioKN.Checked = False
            RadioKN.Visible = False
        End If

        If Permission = 6999 Then
            RadioKC.Checked = False
            RadioKC.Visible = False
            RadioKN.Checked = True
        End If

        If Permission = 9999 Or Permission = 0 Then
            RadioKC.Checked = False
            RadioKC.Visible = True
            RadioKN.Checked = True
            RadioKN.Visible = True
        End If

    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        QueryStr = "SELECT CONVERT(varchar(10), TimeStamp, 120 ) as '日期', convert(decimal(8,1), AVG(IN_PH)) as '進流水酸鹼值', " & _
                            "convert(decimal(8,3), AVG(IN_EC)) as '進流水導電度',convert(decimal(8,1), AVG(IN_TEMP)) as '進流水溫度', " & _
                            "convert(decimal(8,1), AVG(IN_SS)) as '進流水懸浮固體', convert(decimal(8,1), AVG(IN_COD)) as '進流水化學需氧量', " & _
                            "convert(decimal(8,1), AVG(IN_AMDI)) as '進流水色度',convert(decimal(8,1), AVG(OUT_PH)) as '放流水酸鹼值', " & _
                            "convert(decimal(8,3), AVG(OUT_EC)) as '放流水導電度', convert(decimal(8,1), AVG(OUT_TEMP)) as '放流水溫度', " & _
                            "convert(decimal(8,1), AVG(OUT_SS)) as '放流水懸浮固體',convert(decimal(8,1), AVG(OUT_COD)) as '放流水化學需氧量', " & _
                            "convert(decimal(8,1), AVG(OUT_AMDI)) as '放流水色度', convert(decimal(8,1), AVG(OUT_O2)) as '放流水溶氧量' " & _
                            "FROM (select *, Year(TimeStamp) as Y, Month(TimeStamp) as M, Day(TimeStamp) as D From "

        If RadioKC.Checked = True Then
            QueryStr = QueryStr & "KC_HOUR_TABLE"
        End If

        If RadioKN.Checked = True Then
            QueryStr = QueryStr & "KN_HOUR_TABLE"
        End If

        QueryStr = QueryStr & " WHERE Year(TimeStamp) = '" & StartDatePicker.Value.Year.ToString & "' AND Month(TimeStamp) = '" & StartDatePicker.Value.Month.ToString & _
                            "') t GROUP BY Y, M, D, CONVERT(varchar(10), TimeStamp, 120) Order by CONVERT(varchar(10), TimeStamp, 120)"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "DataSet")

        DataGridView.DataSource = QuerySet.Tables("DataSet")


        DisconnectFromDatabase()

    End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click

        Dim AreaName As String

        AreaName = ""

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Dim MonthViewReport As New frmMonthViewReport

        MonthViewReport.MdiParent = frmMain

        MonthViewReport.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        MonthViewReport.WindowState = FormWindowState.Normal


        QueryStr = "SELECT CONVERT(varchar(10), TimeStamp, 120 ) as TimeStamp, AVG(IN_PH) as IN_PH, " & _
                           "AVG(IN_EC) as IN_EC,AVG(IN_TEMP) as IN_TEMP, AVG(IN_SS) as IN_SS, AVG(IN_COD) as IN_COD, " & _
                          "AVG(IN_AMDI) as IN_AMDI,AVG(OUT_PH) as OUT_PH, AVG(OUT_EC) as OUT_EC, AVG(OUT_TEMP) as OUT_TEMP, " & _
                         "AVG(OUT_SS) as OUT_SS,AVG(OUT_COD) as OUT_COD, AVG(OUT_AMDI) as OUT_AMDI, AVG(OUT_O2) as OUT_O2 " & _
                        "FROM (select *, Year(TimeStamp) as Y, Month(TimeStamp) as M, Day(TimeStamp) as D From "

        If RadioKC.Checked = True Then
            QueryStr = QueryStr & "KC_HOUR_TABLE"
            AreaName = "金城廠"
        End If

        If RadioKN.Checked = True Then
            QueryStr = QueryStr & "KN_HOUR_TABLE"
            AreaName = "金寧廠"
        End If

        QueryStr = QueryStr & " WHERE Year(TimeStamp) = '" & StartDatePicker.Value.Year.ToString & "' AND Month(TimeStamp) = '" & StartDatePicker.Value.Month.ToString & _
                           "') t GROUP BY Y, M, D, CONVERT(varchar(10), TimeStamp, 120) Order by CONVERT(varchar(10), TimeStamp, 120)"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "ReportSet")

        Dim paras(4) As Microsoft.Reporting.WinForms.ReportParameter

        paras(0) = New Microsoft.Reporting.WinForms.ReportParameter("Title", "金門酒廠" & AreaName & "廢水監測系統月報表")
        paras(1) = New Microsoft.Reporting.WinForms.ReportParameter("StartDate", Format(StartDatePicker.Value, "yyyy年MM月").ToString)
        paras(2) = New Microsoft.Reporting.WinForms.ReportParameter("Area", AreaName)
        paras(3) = New Microsoft.Reporting.WinForms.ReportParameter("Operator", UserName)
        paras(4) = New Microsoft.Reporting.WinForms.ReportParameter("PrintDate", Convert.ToInt16(DateTime.Now.AddYears(-1911).Year) & DateTime.Now.ToString("/MM/dd HH:mm:ss"))

        MonthViewReport.ReportViewer.LocalReport.SetParameters(paras)

        MonthViewReport.ReportViewer.LocalReport.DataSources(0).Value = QuerySet.Tables("ReportSet")
        MonthViewReport.ReportViewer.RefreshReport()

        MonthViewReport.Show()

        DisconnectFromDatabase()

        Me.Close()

    End Sub
End Class