<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrendChartView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrendChartView))
        Me.KC_HOUR_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KKL58DataSet = New KKL58.KKL58DataSet
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBoxPoint = New System.Windows.Forms.ComboBox
        Me.RadioKN = New System.Windows.Forms.RadioButton
        Me.LabelStartDate = New System.Windows.Forms.Label
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.LabelEndDate = New System.Windows.Forms.Label
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker
        Me.RadioKC = New System.Windows.Forms.RadioButton
        Me.EndTimePicker = New System.Windows.Forms.DateTimePicker
        Me.StartTimePicker = New System.Windows.Forms.DateTimePicker
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.KC_HOUR_TABLETableAdapter = New KKL58.KKL58DataSetTableAdapters.KC_HOUR_TABLETableAdapter
        CType(Me.KC_HOUR_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KKL58DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReportViewer)
        Me.Panel1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 520)
        Me.Panel1.TabIndex = 30
        '
        'ReportViewer
        '
        ReportDataSource1.Name = "KKL58DataSet_KC_HOUR_TABLE"
        ReportDataSource1.Value = Me.KC_HOUR_TABLEBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "KKL58.TrendChartReport.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(1000, 520)
        Me.ReportViewer.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBoxPoint)
        Me.GroupBox1.Controls.Add(Me.RadioKN)
        Me.GroupBox1.Controls.Add(Me.LabelStartDate)
        Me.GroupBox1.Controls.Add(Me.ButtonQuery)
        Me.GroupBox1.Controls.Add(Me.LabelEndDate)
        Me.GroupBox1.Controls.Add(Me.EndDatePicker)
        Me.GroupBox1.Controls.Add(Me.RadioKC)
        Me.GroupBox1.Controls.Add(Me.EndTimePicker)
        Me.GroupBox1.Controls.Add(Me.StartTimePicker)
        Me.GroupBox1.Controls.Add(Me.StartDatePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 137)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'ComboBoxPoint
        '
        Me.ComboBoxPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPoint.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBoxPoint.FormattingEnabled = True
        Me.ComboBoxPoint.Location = New System.Drawing.Point(223, 17)
        Me.ComboBoxPoint.Name = "ComboBoxPoint"
        Me.ComboBoxPoint.Size = New System.Drawing.Size(227, 32)
        Me.ComboBoxPoint.TabIndex = 21
        '
        'RadioKN
        '
        Me.RadioKN.AutoSize = True
        Me.RadioKN.Checked = True
        Me.RadioKN.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioKN.ForeColor = System.Drawing.Color.White
        Me.RadioKN.Location = New System.Drawing.Point(18, 23)
        Me.RadioKN.Name = "RadioKN"
        Me.RadioKN.Size = New System.Drawing.Size(85, 28)
        Me.RadioKN.TabIndex = 0
        Me.RadioKN.TabStop = True
        Me.RadioKN.Text = "金寧廠"
        Me.RadioKN.UseVisualStyleBackColor = True
        '
        'LabelStartDate
        '
        Me.LabelStartDate.AutoSize = True
        Me.LabelStartDate.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelStartDate.ForeColor = System.Drawing.Color.White
        Me.LabelStartDate.Location = New System.Drawing.Point(15, 59)
        Me.LabelStartDate.Name = "LabelStartDate"
        Me.LabelStartDate.Size = New System.Drawing.Size(105, 24)
        Me.LabelStartDate.TabIndex = 17
        Me.LabelStartDate.Text = "開始日期："
        '
        'ButtonQuery
        '
        Me.ButtonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonQuery.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonQuery.ForeColor = System.Drawing.Color.White
        Me.ButtonQuery.Location = New System.Drawing.Point(457, 92)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 30)
        Me.ButtonQuery.TabIndex = 3
        Me.ButtonQuery.Text = "查   詢"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'LabelEndDate
        '
        Me.LabelEndDate.AutoSize = True
        Me.LabelEndDate.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelEndDate.ForeColor = System.Drawing.Color.White
        Me.LabelEndDate.Location = New System.Drawing.Point(15, 92)
        Me.LabelEndDate.Name = "LabelEndDate"
        Me.LabelEndDate.Size = New System.Drawing.Size(105, 24)
        Me.LabelEndDate.TabIndex = 16
        Me.LabelEndDate.Text = "結束日期："
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = " yyyy / MM / dd"
        Me.EndDatePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(132, 90)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(157, 33)
        Me.EndDatePicker.TabIndex = 18
        '
        'RadioKC
        '
        Me.RadioKC.AutoSize = True
        Me.RadioKC.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioKC.ForeColor = System.Drawing.Color.White
        Me.RadioKC.Location = New System.Drawing.Point(132, 23)
        Me.RadioKC.Name = "RadioKC"
        Me.RadioKC.Size = New System.Drawing.Size(85, 28)
        Me.RadioKC.TabIndex = 1
        Me.RadioKC.Text = "金城廠"
        Me.RadioKC.UseVisualStyleBackColor = True
        '
        'EndTimePicker
        '
        Me.EndTimePicker.CustomFormat = "  HH：mm：ss"
        Me.EndTimePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndTimePicker.Location = New System.Drawing.Point(295, 89)
        Me.EndTimePicker.Name = "EndTimePicker"
        Me.EndTimePicker.ShowUpDown = True
        Me.EndTimePicker.Size = New System.Drawing.Size(155, 33)
        Me.EndTimePicker.TabIndex = 20
        '
        'StartTimePicker
        '
        Me.StartTimePicker.CustomFormat = "  HH：mm：ss"
        Me.StartTimePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartTimePicker.Location = New System.Drawing.Point(295, 53)
        Me.StartTimePicker.Name = "StartTimePicker"
        Me.StartTimePicker.ShowUpDown = True
        Me.StartTimePicker.Size = New System.Drawing.Size(155, 33)
        Me.StartTimePicker.TabIndex = 19
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = " yyyy / MM / dd"
        Me.StartDatePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(132, 53)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(157, 33)
        Me.StartDatePicker.TabIndex = 15
        '
        'KC_HOUR_TABLETableAdapter
        '
        Me.KC_HOUR_TABLETableAdapter.ClearBeforeFill = True
        '
        'frmTrendChartView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTrendChartView"
        CType(Me.KC_HOUR_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KKL58DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioKN As System.Windows.Forms.RadioButton
    Friend WithEvents LabelStartDate As System.Windows.Forms.Label
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents LabelEndDate As System.Windows.Forms.Label
    Friend WithEvents EndDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioKC As System.Windows.Forms.RadioButton
    Friend WithEvents EndTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents KC_HOUR_TABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KKL58DataSet As KKL58.KKL58DataSet
    Friend WithEvents KC_HOUR_TABLETableAdapter As KKL58.KKL58DataSetTableAdapters.KC_HOUR_TABLETableAdapter
    Friend WithEvents ComboBoxPoint As System.Windows.Forms.ComboBox
End Class
