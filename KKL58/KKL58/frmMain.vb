Public Class frmMain
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        UserName = "None"
        Permission = -1000
        Me.UserViewToolStripMenuItem.Visible = False

        Me.MenuStrip.Enabled = False

        Dim Login As New frmLogin
        Login.MdiParent = Me
        Login.Show()

        Me.UserNameToolStripMenuItem.Text = "使用者：" & UserName

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized


        Dim Login As New frmLogin
        Login.MdiParent = Me
        Login.Show()

        Timer.Start()

        

    End Sub

    Private Sub HomePageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomePageToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim HomePage As New frmHomePage

        HomePage.MdiParent = Me

        HomePage.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HomePage.WindowState = FormWindowState.Maximized

        HomePage.Show()

    End Sub

    Private Sub DataViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataViewToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim DataView As New frmDataView

        DataView.MdiParent = Me

        DataView.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        DataView.WindowState = FormWindowState.Maximized

        DataView.Show()

    End Sub

    Private Sub DayReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayReportToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim DayView As New frmDayView

        DayView.MdiParent = Me

        DayView.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        DayView.WindowState = FormWindowState.Maximized

        DayView.Show()

    End Sub

    Private Sub WeekReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeekReportToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim WeekView As New frmWeekView

        WeekView.MdiParent = Me

        WeekView.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        WeekView.WindowState = FormWindowState.Maximized

        WeekView.Show()

    End Sub

    Private Sub MonthReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthReportToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim MonthView As New frmMonthView

        MonthView.MdiParent = Me

        MonthView.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        MonthView.WindowState = FormWindowState.Maximized

        MonthView.Show()

    End Sub

    Private Sub SeasonReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeasonReportToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim SeasonView As New frmSeasonView

        SeasonView.MdiParent = Me

        SeasonView.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        SeasonView.WindowState = FormWindowState.Maximized

        SeasonView.Show()

    End Sub


    Private Sub YearReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearReportToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim YearView As New frmYearView

        YearView.MdiParent = Me

        YearView.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        YearView.WindowState = FormWindowState.Maximized

        YearView.Show()

    End Sub

    Private Sub AlmViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmViewToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim AlmView As New frmAlmView

        AlmView.MdiParent = Me

        AlmView.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        AlmView.WindowState = FormWindowState.Normal
        AlmView.StartPosition = FormStartPosition.CenterScreen

        AlmView.Show()

    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManagementToolStripMenuItem.Click

        'If Permission <> 9999 Then
        'MsgBox("權限不足，請使用管理者登入！", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "權限不足")
        'Exit Sub
        'End If

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim UserManagement As New frmUserManagement

        UserManagement.MdiParent = Me

        UserManagement.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        UserManagement.WindowState = FormWindowState.Normal
        UserManagement.StartPosition = FormStartPosition.CenterScreen

        UserManagement.Show()

    End Sub

    Private Sub TrendChartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrendChartToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Dim TrendChartView As New frmTrendChartView

        TrendChartView.MdiParent = Me

        TrendChartView.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        TrendChartView.WindowState = FormWindowState.Maximized

        TrendChartView.Show()

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        Me.DateToolStripMenuItem.Text = Format(Now(), "yyyy/MM/dd HH:mm:ss")

    End Sub

    Private Sub ShowPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserViewToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        Dim QueryStr As String
        Dim QuerySet As System.Data.DataSet
        Dim QueryAdapt As System.Data.SqlClient.SqlDataAdapter

        Dim UserView As New frmUserView

        UserView.MdiParent = Me

        UserView.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        UserView.WindowState = FormWindowState.Normal
        UserView.StartPosition = FormStartPosition.CenterScreen

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
