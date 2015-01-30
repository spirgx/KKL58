Imports Microsoft.Reporting.WinForms

Public Class frmTrendChartView

    Dim QueryStr As String
    Dim QuerySet As System.Data.DataSet
    Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter
    Dim StartDateTime As String
    Dim EndDateTime As String


    Private Sub frmTrendChartView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer.ZoomPercent = 100

        Me.ReportViewer.RefreshReport()

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

        Dim list As New DataTable()
        list.Columns.Add(New DataColumn("Display", System.Type.GetType("System.String")))
        list.Columns.Add(New DataColumn("Id", System.Type.GetType("System.String")))

        List.Rows.Add(List.NewRow()) '1
        List.Rows.Add(List.NewRow()) '2
        List.Rows.Add(List.NewRow()) '3 
        List.Rows.Add(List.NewRow()) '4
        List.Rows.Add(List.NewRow()) '5
        List.Rows.Add(List.NewRow()) '6
        List.Rows.Add(List.NewRow()) '7
        List.Rows.Add(List.NewRow()) '8
        List.Rows.Add(List.NewRow()) '9
        List.Rows.Add(List.NewRow()) '10
        List.Rows.Add(List.NewRow()) '11
        List.Rows.Add(List.NewRow()) '12
        List.Rows.Add(List.NewRow()) '13
        List.Rows(0)(0) = "進流水 酸鹼值PH"
        List.Rows(0)(1) = "IN_PH"
        List.Rows(1)(0) = "進流水 導電度EC"
        List.Rows(1)(1) = "IN_EC"
        List.Rows(2)(0) = "進流水 溫度值TEMP"
        List.Rows(2)(1) = "IN_TEMP"
        List.Rows(3)(0) = "進流水 懸浮固體SS"
        List.Rows(3)(1) = "IN_SS"
        List.Rows(4)(0) = "進流水 化學需氧量COD"
        List.Rows(4)(1) = "IN_COD"
        List.Rows(5)(0) = "進流水 色度AMDI"
        List.Rows(5)(1) = "IN_AMDI"
        List.Rows(6)(0) = "放流水 酸鹼值PH"
        List.Rows(6)(1) = "OUT_PH"
        List.Rows(7)(0) = "放流水 導電度EC"
        List.Rows(7)(1) = "OUT_EC"
        List.Rows(8)(0) = "放流水 溫度值TEMP"
        List.Rows(8)(1) = "OUT_TEMP"
        List.Rows(9)(0) = "放流水 懸浮固體SS"
        List.Rows(9)(1) = "OUT_SS"
        List.Rows(10)(0) = "放流水 化學需氧量COD"
        List.Rows(10)(1) = "OUT_COD"
        List.Rows(11)(0) = "放流水 色度AMDI"
        List.Rows(11)(1) = "OUT_AMDI"
        List.Rows(12)(0) = "放流水 溶氧"
        List.Rows(12)(1) = "OUT_O2"

        ComboBoxPoint.DataSource = List
        ComboBoxPoint.DisplayMember = "Display"
        ComboBoxPoint.ValueMember = "Id"
        ComboBoxPoint.SelectedIndex = 0

        If Permission = 3999 Or Permission = 6999 Then
            Me.ReportViewer.ShowExportButton = False
        Else
            Me.ReportViewer.ShowExportButton = True
        End If

    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click

        Dim AreaName As String
        AreaName = ""

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        StartDateTime = Format(StartDatePicker.Value, "yyyy/MM/dd") & " " & _
                     Format(StartTimePicker.Value, "HH:mm:ss")

        EndDateTime = Format(EndDatePicker.Value, "yyyy/MM/dd") & " " & _
                            Format(EndTimePicker.Value, "HH:mm:ss")

        If StartDateTime > EndDateTime Then
            MsgBox("結束時間小於開始時間", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
            Exit Sub
        End If

        QueryStr = "SELECT Top(48) TimeStamp, " & ComboBoxPoint.SelectedValue.ToString

        If RadioKC.Checked = True Then
            QueryStr = QueryStr & " FROM KC_HOUR_TABLE "
            AreaName = "金城廠"
        End If

        If RadioKN.Checked = True Then
            QueryStr = QueryStr & " FROM KN_HOUR_TABLE "
            AreaName = "金寧廠"
        End If

        QueryStr = QueryStr & " WHERE (TimeStamp BETWEEN '" & StartDateTime & "' AND '" & EndDateTime & "')  ORDER BY TimeStamp"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "ReportSet")

        Dim paras(7) As Microsoft.Reporting.WinForms.ReportParameter

        paras(0) = New Microsoft.Reporting.WinForms.ReportParameter("Title", "金門酒廠" & AreaName & "廢水監測系統趨勢圖")
        paras(1) = New Microsoft.Reporting.WinForms.ReportParameter("StartDate", Format(StartDatePicker.Value, "yyyy/MM/dd").ToString)
        paras(2) = New Microsoft.Reporting.WinForms.ReportParameter("StartTime", Format(StartTimePicker.Value, "HH:mm:ss").ToString)
        paras(3) = New Microsoft.Reporting.WinForms.ReportParameter("EndDate", Format(EndDatePicker.Value, "yyyy/MM/dd").ToString)
        paras(4) = New Microsoft.Reporting.WinForms.ReportParameter("EndTime", Format(EndTimePicker.Value, "HH:mm:ss").ToString)
        paras(5) = New Microsoft.Reporting.WinForms.ReportParameter("Area", AreaName & " " & ComboBoxPoint.Text)
        paras(6) = New Microsoft.Reporting.WinForms.ReportParameter("Operator", UserName)
        paras(7) = New Microsoft.Reporting.WinForms.ReportParameter("PrintDate", Convert.ToInt16(DateTime.Now.AddYears(-1911).Year) & DateTime.Now.ToString("/MM/dd HH:mm:ss"))

        Me.ReportViewer.LocalReport.SetParameters(paras)

        If QuerySet.Tables("ReportSet").Rows.Count = 48 Then
            MsgBox("趨勢圖最多只會顯示48筆(2天)的資料", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "資訊")
        End If

        Me.ReportViewer.LocalReport.DataSources(0).Value = QuerySet.Tables("ReportSet")
        Me.ReportViewer.RefreshReport()

        DisconnectFromDatabase()

    End Sub
End Class