<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonthView))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonPrint = New System.Windows.Forms.Button
        Me.RadioKN = New System.Windows.Forms.RadioButton
        Me.LabelStartDate = New System.Windows.Forms.Label
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.RadioKC = New System.Windows.Forms.RadioButton
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonPrint)
        Me.GroupBox1.Controls.Add(Me.RadioKN)
        Me.GroupBox1.Controls.Add(Me.LabelStartDate)
        Me.GroupBox1.Controls.Add(Me.ButtonQuery)
        Me.GroupBox1.Controls.Add(Me.RadioKC)
        Me.GroupBox1.Controls.Add(Me.StartDatePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 99)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'ButtonPrint
        '
        Me.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrint.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.Color.White
        Me.ButtonPrint.Location = New System.Drawing.Point(371, 58)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(78, 30)
        Me.ButtonPrint.TabIndex = 21
        Me.ButtonPrint.Text = "列   印"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'RadioKN
        '
        Me.RadioKN.AutoSize = True
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
        Me.ButtonQuery.Location = New System.Drawing.Point(276, 58)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 30)
        Me.ButtonQuery.TabIndex = 3
        Me.ButtonQuery.Text = "查   詢"
        Me.ButtonQuery.UseVisualStyleBackColor = True
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
        Me.RadioKC.TabStop = True
        Me.RadioKC.Text = "金城廠"
        Me.RadioKC.UseVisualStyleBackColor = True
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = " yyyy年MM月"
        Me.StartDatePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(126, 56)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.ShowUpDown = True
        Me.StartDatePicker.Size = New System.Drawing.Size(134, 33)
        Me.StartDatePicker.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView)
        Me.Panel1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 520)
        Me.Panel1.TabIndex = 26
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToOrderColumns = True
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(1000, 520)
        Me.DataGridView.TabIndex = 25
        '
        'frmMonthView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMonthView"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents RadioKN As System.Windows.Forms.RadioButton
    Friend WithEvents LabelStartDate As System.Windows.Forms.Label
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents RadioKC As System.Windows.Forms.RadioButton
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
End Class
