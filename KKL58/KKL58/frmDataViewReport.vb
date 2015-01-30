Imports Microsoft.Reporting.WinForms

Public Class frmDataViewReport

    Private Sub frmDataViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer.ZoomPercent = 100

        Me.WindowState = FormWindowState.Maximized
        Me.ReportViewer.Width = Me.Width - 10
        Me.ReportViewer.Height = Me.Height - 55

        If Permission = 3999 Or Permission = 6999 Then
            Me.ReportViewer.ShowExportButton = False
        Else
            Me.ReportViewer.ShowExportButton = True
        End If

        Me.ReportViewer.RefreshReport()

    End Sub
End Class