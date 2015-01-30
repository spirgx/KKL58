Public Class frmDayView

    Dim QueryStr As String
    Dim QuerySet As System.Data.DataSet
    Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter
    Dim StartDateTime As String
    Dim EndDateTime As String

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try


        StartDateTime = Format(StartDatePicker.Value, "yyyy/MM/dd") & " 00:00:00"
        EndDateTime = Format(StartDatePicker.Value, "yyyy/MM/dd") & " 23:59:59"

        QueryStr = "SELECT CONVERT(varchar, TimeStamp, 120 ) as '日期 時間', convert(decimal(8,1) ,IN_PH) as '進流水酸鹼值', " & _
                            "convert(decimal(8,3) ,IN_EC) as '進流水導電度',convert(decimal(8,1) ,IN_TEMP) as '進流水溫度', convert(decimal(8,1) ,IN_SS) as '進流水懸浮固體', convert(decimal(8,1) ,IN_COD) as '進流水化學需氧量', " & _
                            "convert(decimal(8,1) ,IN_AMDI) as '進流水色度',convert(decimal(8,1) ,OUT_PH) as '放流水酸鹼值', convert(decimal(8,3) ,OUT_EC) as '放流水導電度', convert(decimal(8,1) ,OUT_TEMP) as '放流水溫度', " & _
                            "convert(decimal(8,1) ,OUT_SS) as '放流水懸浮固體',convert(decimal(8,1) ,OUT_COD) as '放流水化學需氧量', convert(decimal(8,1) ,OUT_AMDI) as '放流水色度', convert(decimal(8,1) ,OUT_O2) as '放流水溶氧量' " & _
                            "FROM "

        If RadioKC.Checked = True Then
            QueryStr = QueryStr & "KC_HOUR_TABLE"
        End If

        If RadioKN.Checked = True Then
            QueryStr = QueryStr & "KN_HOUR_TABLE "
        End If

        QueryStr = QueryStr & " WHERE (TimeStamp BETWEEN '" & _
                            StartDateTime & "' AND '" & EndDateTime & "')  ORDER BY TimeStamp"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "DataSet")

        DataGridView.DataSource = QuerySet.Tables("DataSet")


        DisconnectFromDatabase()

    End Sub

    Private Sub frmDayReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Dim DayViewReport As New frmDayViewReport

        DayViewReport.MdiParent = frmMain

        DayViewReport.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        DayViewReport.WindowState = FormWindowState.Normal

        StartDateTime = Format(StartDatePicker.Value, "yyyy/MM/dd") & " 00:00:00"
        EndDateTime = Format(StartDatePicker.Value, "yyyy/MM/dd") & " 23:59:59"


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

        Dim paras(4) As Microsoft.Reporting.WinForms.ReportParameter

        paras(0) = New Microsoft.Reporting.WinForms.ReportParameter("Title", "金門酒廠" & AreaName & "廢水監測系統日報表")
        paras(1) = New Microsoft.Reporting.WinForms.ReportParameter("StartDate", Format(StartDatePicker.Value, "yyyy/MM/dd").ToString)
        paras(2) = New Microsoft.Reporting.WinForms.ReportParameter("Area", AreaName)
        paras(3) = New Microsoft.Reporting.WinForms.ReportParameter("Operator", UserName)
        paras(4) = New Microsoft.Reporting.WinForms.ReportParameter("PrintDate", Convert.ToInt16(DateTime.Now.AddYears(-1911).Year) & DateTime.Now.ToString("/MM/dd HH:mm:ss"))

        DayViewReport.ReportViewer.LocalReport.SetParameters(paras)

        DayViewReport.ReportViewer.LocalReport.DataSources(0).Value = QuerySet.Tables("ReportSet")
        DayViewReport.ReportViewer.RefreshReport()

        DayViewReport.Show()

        DisconnectFromDatabase()

        Me.Close()

    End Sub
End Class