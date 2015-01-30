<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmView))
        Me.LabelOperator = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboAlmType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.ComboAreaList = New System.Windows.Forms.ComboBox
        Me.LabelArea = New System.Windows.Forms.Label
        Me.EndTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LabelStartDate = New System.Windows.Forms.Label
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker
        Me.StartTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LabelEndDate = New System.Windows.Forms.Label
        Me.LabelPrinter = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelOperator
        '
        Me.LabelOperator.AutoSize = True
        Me.LabelOperator.BackColor = System.Drawing.Color.Transparent
        Me.LabelOperator.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelOperator.ForeColor = System.Drawing.Color.White
        Me.LabelOperator.Location = New System.Drawing.Point(91, 4)
        Me.LabelOperator.Name = "LabelOperator"
        Me.LabelOperator.Size = New System.Drawing.Size(75, 26)
        Me.LabelOperator.TabIndex = 8
        Me.LabelOperator.Text = "NONE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboAlmType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.StartDatePicker)
        Me.GroupBox1.Controls.Add(Me.ButtonQuery)
        Me.GroupBox1.Controls.Add(Me.ComboAreaList)
        Me.GroupBox1.Controls.Add(Me.LabelArea)
        Me.GroupBox1.Controls.Add(Me.EndTimePicker)
        Me.GroupBox1.Controls.Add(Me.LabelStartDate)
        Me.GroupBox1.Controls.Add(Me.EndDatePicker)
        Me.GroupBox1.Controls.Add(Me.StartTimePicker)
        Me.GroupBox1.Controls.Add(Me.LabelEndDate)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 192)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'ComboAlmType
        '
        Me.ComboAlmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAlmType.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboAlmType.FormattingEnabled = True
        Me.ComboAlmType.Items.AddRange(New Object() {"警報", "事件", "警報及事件"})
        Me.ComboAlmType.Location = New System.Drawing.Point(94, 19)
        Me.ComboAlmType.Name = "ComboAlmType"
        Me.ComboAlmType.Size = New System.Drawing.Size(108, 28)
        Me.ComboAlmType.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "查詢類別："
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.StartDatePicker.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(94, 83)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(108, 29)
        Me.StartDatePicker.TabIndex = 9
        '
        'ButtonQuery
        '
        Me.ButtonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonQuery.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonQuery.ForeColor = System.Drawing.Color.White
        Me.ButtonQuery.Location = New System.Drawing.Point(12, 150)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(313, 30)
        Me.ButtonQuery.TabIndex = 17
        Me.ButtonQuery.Text = "開始查詢"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'ComboAreaList
        '
        Me.ComboAreaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAreaList.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboAreaList.FormattingEnabled = True
        Me.ComboAreaList.Items.AddRange(New Object() {"金寧廠", "金城廠"})
        Me.ComboAreaList.Location = New System.Drawing.Point(94, 51)
        Me.ComboAreaList.Name = "ComboAreaList"
        Me.ComboAreaList.Size = New System.Drawing.Size(108, 28)
        Me.ComboAreaList.TabIndex = 16
        '
        'LabelArea
        '
        Me.LabelArea.AutoSize = True
        Me.LabelArea.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelArea.ForeColor = System.Drawing.Color.White
        Me.LabelArea.Location = New System.Drawing.Point(8, 55)
        Me.LabelArea.Name = "LabelArea"
        Me.LabelArea.Size = New System.Drawing.Size(89, 20)
        Me.LabelArea.TabIndex = 15
        Me.LabelArea.Text = "站        別："
        '
        'EndTimePicker
        '
        Me.EndTimePicker.CustomFormat = " HH：mm：ss"
        Me.EndTimePicker.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndTimePicker.Location = New System.Drawing.Point(208, 116)
        Me.EndTimePicker.Name = "EndTimePicker"
        Me.EndTimePicker.ShowUpDown = True
        Me.EndTimePicker.Size = New System.Drawing.Size(116, 29)
        Me.EndTimePicker.TabIndex = 14
        '
        'LabelStartDate
        '
        Me.LabelStartDate.AutoSize = True
        Me.LabelStartDate.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelStartDate.ForeColor = System.Drawing.Color.White
        Me.LabelStartDate.Location = New System.Drawing.Point(8, 85)
        Me.LabelStartDate.Name = "LabelStartDate"
        Me.LabelStartDate.Size = New System.Drawing.Size(89, 20)
        Me.LabelStartDate.TabIndex = 11
        Me.LabelStartDate.Text = "開始日期："
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.EndDatePicker.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(94, 116)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(108, 29)
        Me.EndDatePicker.TabIndex = 12
        '
        'StartTimePicker
        '
        Me.StartTimePicker.CustomFormat = " HH：mm：ss"
        Me.StartTimePicker.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartTimePicker.Location = New System.Drawing.Point(208, 83)
        Me.StartTimePicker.Name = "StartTimePicker"
        Me.StartTimePicker.ShowUpDown = True
        Me.StartTimePicker.Size = New System.Drawing.Size(116, 29)
        Me.StartTimePicker.TabIndex = 13
        '
        'LabelEndDate
        '
        Me.LabelEndDate.AutoSize = True
        Me.LabelEndDate.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelEndDate.ForeColor = System.Drawing.Color.White
        Me.LabelEndDate.Location = New System.Drawing.Point(8, 118)
        Me.LabelEndDate.Name = "LabelEndDate"
        Me.LabelEndDate.Size = New System.Drawing.Size(89, 20)
        Me.LabelEndDate.TabIndex = 10
        Me.LabelEndDate.Text = "結束日期："
        '
        'LabelPrinter
        '
        Me.LabelPrinter.AutoSize = True
        Me.LabelPrinter.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrinter.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPrinter.ForeColor = System.Drawing.Color.White
        Me.LabelPrinter.Location = New System.Drawing.Point(12, 9)
        Me.LabelPrinter.Name = "LabelPrinter"
        Me.LabelPrinter.Size = New System.Drawing.Size(73, 20)
        Me.LabelPrinter.TabIndex = 5
        Me.LabelPrinter.Text = "列印人："
        '
        'frmAlmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(364, 234)
        Me.Controls.Add(Me.LabelOperator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelPrinter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlmView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "警報查詢"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelOperator As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboAlmType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents ComboAreaList As System.Windows.Forms.ComboBox
    Friend WithEvents LabelArea As System.Windows.Forms.Label
    Friend WithEvents EndTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelStartDate As System.Windows.Forms.Label
    Friend WithEvents EndDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelEndDate As System.Windows.Forms.Label
    Friend WithEvents LabelPrinter As System.Windows.Forms.Label
End Class
