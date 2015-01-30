<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.HomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrendChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DayReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WeekReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonthReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeasonReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YearReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlmViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip.BackgroundImage = CType(resources.GetObject("MenuStrip.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip.Enabled = False
        Me.MenuStrip.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomePageToolStripMenuItem, Me.TrendChartToolStripMenuItem, Me.DataViewToolStripMenuItem, Me.ReportViewToolStripMenuItem, Me.AlmViewToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.UserViewToolStripMenuItem, Me.ExitToolStripMenuItem, Me.UserNameToolStripMenuItem, Me.DateToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1016, 32)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'HomePageToolStripMenuItem
        '
        Me.HomePageToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomePageToolStripMenuItem.Name = "HomePageToolStripMenuItem"
        Me.HomePageToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HomePageToolStripMenuItem.Size = New System.Drawing.Size(56, 28)
        Me.HomePageToolStripMenuItem.Text = "首頁"
        '
        'TrendChartToolStripMenuItem
        '
        Me.TrendChartToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TrendChartToolStripMenuItem.Name = "TrendChartToolStripMenuItem"
        Me.TrendChartToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TrendChartToolStripMenuItem.Size = New System.Drawing.Size(75, 28)
        Me.TrendChartToolStripMenuItem.Text = "趨勢圖"
        '
        'DataViewToolStripMenuItem
        '
        Me.DataViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DataViewToolStripMenuItem.Name = "DataViewToolStripMenuItem"
        Me.DataViewToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DataViewToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.DataViewToolStripMenuItem.Text = "資料瀏覽"
        '
        'ReportViewToolStripMenuItem
        '
        Me.ReportViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DayReportToolStripMenuItem, Me.WeekReportToolStripMenuItem, Me.MonthReportToolStripMenuItem, Me.SeasonReportToolStripMenuItem, Me.YearReportToolStripMenuItem})
        Me.ReportViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportViewToolStripMenuItem.Name = "ReportViewToolStripMenuItem"
        Me.ReportViewToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReportViewToolStripMenuItem.Size = New System.Drawing.Size(56, 28)
        Me.ReportViewToolStripMenuItem.Text = "報表"
        '
        'DayReportToolStripMenuItem
        '
        Me.DayReportToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.DayReportToolStripMenuItem.BackgroundImage = CType(resources.GetObject("DayReportToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.DayReportToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DayReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DayReportToolStripMenuItem.Name = "DayReportToolStripMenuItem"
        Me.DayReportToolStripMenuItem.Size = New System.Drawing.Size(175, 28)
        Me.DayReportToolStripMenuItem.Text = "日報表查詢"
        '
        'WeekReportToolStripMenuItem
        '
        Me.WeekReportToolStripMenuItem.BackgroundImage = CType(resources.GetObject("WeekReportToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.WeekReportToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.WeekReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.WeekReportToolStripMenuItem.Name = "WeekReportToolStripMenuItem"
        Me.WeekReportToolStripMenuItem.Size = New System.Drawing.Size(175, 28)
        Me.WeekReportToolStripMenuItem.Text = "週報表查詢"
        '
        'MonthReportToolStripMenuItem
        '
        Me.MonthReportToolStripMenuItem.BackgroundImage = CType(resources.GetObject("MonthReportToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.MonthReportToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MonthReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MonthReportToolStripMenuItem.Name = "MonthReportToolStripMenuItem"
        Me.MonthReportToolStripMenuItem.Size = New System.Drawing.Size(175, 28)
        Me.MonthReportToolStripMenuItem.Text = "月報表查詢"
        '
        'SeasonReportToolStripMenuItem
        '
        Me.SeasonReportToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SeasonReportToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SeasonReportToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SeasonReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SeasonReportToolStripMenuItem.Name = "SeasonReportToolStripMenuItem"
        Me.SeasonReportToolStripMenuItem.Size = New System.Drawing.Size(175, 28)
        Me.SeasonReportToolStripMenuItem.Text = "季報表查詢"
        '
        'YearReportToolStripMenuItem
        '
        Me.YearReportToolStripMenuItem.BackgroundImage = CType(resources.GetObject("YearReportToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.YearReportToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.YearReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.YearReportToolStripMenuItem.Name = "YearReportToolStripMenuItem"
        Me.YearReportToolStripMenuItem.Size = New System.Drawing.Size(175, 28)
        Me.YearReportToolStripMenuItem.Text = "年報表查詢"
        '
        'AlmViewToolStripMenuItem
        '
        Me.AlmViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AlmViewToolStripMenuItem.Name = "AlmViewToolStripMenuItem"
        Me.AlmViewToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AlmViewToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.AlmViewToolStripMenuItem.Text = "警報查詢"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(75, 28)
        Me.UserManagementToolStripMenuItem.Text = "使用者"
        '
        'UserViewToolStripMenuItem
        '
        Me.UserViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UserViewToolStripMenuItem.Name = "UserViewToolStripMenuItem"
        Me.UserViewToolStripMenuItem.Size = New System.Drawing.Size(98, 28)
        Me.UserViewToolStripMenuItem.Text = "顯示帳密"
        Me.UserViewToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(56, 28)
        Me.ExitToolStripMenuItem.Text = "登出"
        '
        'UserNameToolStripMenuItem
        '
        Me.UserNameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.UserNameToolStripMenuItem.Enabled = False
        Me.UserNameToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UserNameToolStripMenuItem.Name = "UserNameToolStripMenuItem"
        Me.UserNameToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserNameToolStripMenuItem.Size = New System.Drawing.Size(144, 28)
        Me.UserNameToolStripMenuItem.Text = "操作者：None"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DateToolStripMenuItem.Enabled = False
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.DateToolStripMenuItem.Text = "0000/00/00 00:00:00"
        Me.DateToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "金門酒廠廢水監測報表系統"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DataViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DayReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeekReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeasonReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlmViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YearReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrendChartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents UserNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
