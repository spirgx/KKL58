<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmViewReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmViewReport))
        Me.v_AlarmHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WWALMDBDataSet = New KKL58.WWALMDBDataSet
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.v_AlarmHistoryTableAdapter = New KKL58.WWALMDBDataSetTableAdapters.v_AlarmHistoryTableAdapter
        CType(Me.v_AlarmHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WWALMDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'v_AlarmHistoryBindingSource
        '
        Me.v_AlarmHistoryBindingSource.DataMember = "v_AlarmHistory"
        Me.v_AlarmHistoryBindingSource.DataSource = Me.WWALMDBDataSet
        '
        'WWALMDBDataSet
        '
        Me.WWALMDBDataSet.DataSetName = "WWALMDBDataSet"
        Me.WWALMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer
        '
        ReportDataSource1.Name = "WWALMDBDataSet_v_AlarmHistory"
        ReportDataSource1.Value = Me.v_AlarmHistoryBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "KKL58.AlmViewReport.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(239, 224)
        Me.ReportViewer.TabIndex = 1
        '
        'v_AlarmHistoryTableAdapter
        '
        Me.v_AlarmHistoryTableAdapter.ClearBeforeFill = True
        '
        'frmAlmViewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.ReportViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlmViewReport"
        CType(Me.v_AlarmHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WWALMDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents v_AlarmHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WWALMDBDataSet As KKL58.WWALMDBDataSet
    Friend WithEvents v_AlarmHistoryTableAdapter As KKL58.WWALMDBDataSetTableAdapters.v_AlarmHistoryTableAdapter
End Class
