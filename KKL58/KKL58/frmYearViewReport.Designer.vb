<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearViewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYearViewReport))
        Me.KC_HOUR_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KKL58DataSet = New KKL58.KKL58DataSet
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.KC_HOUR_TABLETableAdapter = New KKL58.KKL58DataSetTableAdapters.KC_HOUR_TABLETableAdapter
        CType(Me.KC_HOUR_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KKL58DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KC_HOUR_TABLEBindingSource
        '
        Me.KC_HOUR_TABLEBindingSource.DataMember = "KC_HOUR_TABLE"
        Me.KC_HOUR_TABLEBindingSource.DataSource = Me.KKL58DataSet
        '
        'KKL58DataSet
        '
        Me.KKL58DataSet.DataSetName = "KKL58DataSet"
        Me.KKL58DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer
        '
        ReportDataSource1.Name = "KKL58DataSet_KC_HOUR_TABLE"
        ReportDataSource1.Value = Me.KC_HOUR_TABLEBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "KKL58.YearViewReport.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(268, 250)
        Me.ReportViewer.TabIndex = 1
        '
        'KC_HOUR_TABLETableAdapter
        '
        Me.KC_HOUR_TABLETableAdapter.ClearBeforeFill = True
        '
        'frmYearViewReport
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
        Me.Name = "frmYearViewReport"
        Me.Text = "Form1"
        CType(Me.KC_HOUR_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KKL58DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents KC_HOUR_TABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KKL58DataSet As KKL58.KKL58DataSet
    Friend WithEvents KC_HOUR_TABLETableAdapter As KKL58.KKL58DataSetTableAdapters.KC_HOUR_TABLETableAdapter
End Class
