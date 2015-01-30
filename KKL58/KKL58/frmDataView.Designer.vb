<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataView))
        Me.RadioKN = New System.Windows.Forms.RadioButton
        Me.RadioKC = New System.Windows.Forms.RadioButton
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.EndTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LabelStartDate = New System.Windows.Forms.Label
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker
        Me.StartTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LabelEndDate = New System.Windows.Forms.Label
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.ButtonPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.TextBoxOutO2 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBoxOutSS = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBoxOutAMDI = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxOutCOD = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBoxOutTemp = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBoxOutPH = New System.Windows.Forms.TextBox
        Me.TextBoxOutEC = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxInSS = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBoxInAMDI = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxInCOD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxInTemp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxInPH = New System.Windows.Forms.TextBox
        Me.TextBoxInEC = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxTimeStamp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.StartDatePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(132, 53)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(129, 33)
        Me.StartDatePicker.TabIndex = 15
        '
        'EndTimePicker
        '
        Me.EndTimePicker.CustomFormat = " HH：mm：ss"
        Me.EndTimePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndTimePicker.Location = New System.Drawing.Point(267, 90)
        Me.EndTimePicker.Name = "EndTimePicker"
        Me.EndTimePicker.ShowUpDown = True
        Me.EndTimePicker.Size = New System.Drawing.Size(141, 33)
        Me.EndTimePicker.TabIndex = 20
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
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.EndDatePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(132, 90)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(129, 33)
        Me.EndDatePicker.TabIndex = 18
        '
        'StartTimePicker
        '
        Me.StartTimePicker.CustomFormat = " HH：mm：ss"
        Me.StartTimePicker.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartTimePicker.Location = New System.Drawing.Point(267, 53)
        Me.StartTimePicker.Name = "StartTimePicker"
        Me.StartTimePicker.ShowUpDown = True
        Me.StartTimePicker.Size = New System.Drawing.Size(141, 33)
        Me.StartTimePicker.TabIndex = 19
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
        'ButtonQuery
        '
        Me.ButtonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonQuery.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonQuery.ForeColor = System.Drawing.Color.White
        Me.ButtonQuery.Location = New System.Drawing.Point(418, 56)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 30)
        Me.ButtonQuery.TabIndex = 3
        Me.ButtonQuery.Text = "查   詢"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrint.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.Color.White
        Me.ButtonPrint.Location = New System.Drawing.Point(418, 92)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(75, 30)
        Me.ButtonPrint.TabIndex = 21
        Me.ButtonPrint.Text = "列   印"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonPrint)
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
        Me.GroupBox1.Size = New System.Drawing.Size(504, 137)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TabControl.Location = New System.Drawing.Point(12, 181)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1011, 530)
        Me.TabControl.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabPage1.Controls.Add(Me.DataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1003, 497)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "資料瀏覽"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToOrderColumns = True
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(2, 1)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1000, 496)
        Me.DataGridView.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.ButtonUpdate)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.TextBoxTimeStamp)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1003, 497)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "單筆瀏覽"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(800, 413)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 30)
        Me.ButtonUpdate.TabIndex = 22
        Me.ButtonUpdate.Text = "更   新"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.TextBoxOutO2)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextBoxOutSS)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBoxOutAMDI)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TextBoxOutCOD)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TextBoxOutTemp)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TextBoxOutPH)
        Me.GroupBox3.Controls.Add(Me.TextBoxOutEC)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(495, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 264)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "放流水"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(311, 189)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 20)
        Me.Label23.TabIndex = 114
        Me.Label23.Text = "color"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(311, 224)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(45, 20)
        Me.Label42.TabIndex = 20
        Me.Label42.Text = "mg/l"
        '
        'TextBoxOutO2
        '
        Me.TextBoxOutO2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOutO2.Location = New System.Drawing.Point(172, 221)
        Me.TextBoxOutO2.Name = "TextBoxOutO2"
        Me.TextBoxOutO2.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxOutO2.TabIndex = 113
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(16, 224)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 20)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "含氧："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(311, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "℃"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(311, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "mg/l"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(311, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "mg/l"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(311, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "ms/cm"
        '
        'TextBoxOutSS
        '
        Me.TextBoxOutSS.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOutSS.Location = New System.Drawing.Point(172, 120)
        Me.TextBoxOutSS.Name = "TextBoxOutSS"
        Me.TextBoxOutSS.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxOutSS.TabIndex = 110
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(16, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "懸浮固體(SS)："
        '
        'TextBoxOutAMDI
        '
        Me.TextBoxOutAMDI.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOutAMDI.Location = New System.Drawing.Point(172, 186)
        Me.TextBoxOutAMDI.Name = "TextBoxOutAMDI"
        Me.TextBoxOutAMDI.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxOutAMDI.TabIndex = 112
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "色度(AMDI)："
        '
        'TextBoxOutCOD
        '
        Me.TextBoxOutCOD.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOutCOD.Location = New System.Drawing.Point(172, 153)
        Me.TextBoxOutCOD.Name = "TextBoxOutCOD"
        Me.TextBoxOutCOD.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxOutCOD.TabIndex = 111
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(16, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 20)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "化學需氧量(COD)："
        '
        'TextBoxOutTemp
        '
        Me.TextBoxOutTemp.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOutTemp.Location = New System.Drawing.Point(172, 87)
        Me.TextBoxOutTemp.Name = "TextBoxOutTemp"
        Me.TextBoxOutTemp.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxOutTemp.TabIndex = 109
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(16, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 20)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "溫度(TEMP)："
        '
        'TextBoxOutPH
        '
        Me.TextBoxOutPH.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOutPH.Location = New System.Drawing.Point(172, 21)
        Me.TextBoxOutPH.Name = "TextBoxOutPH"
        Me.TextBoxOutPH.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxOutPH.TabIndex = 107
        '
        'TextBoxOutEC
        '
        Me.TextBoxOutEC.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOutEC.Location = New System.Drawing.Point(172, 54)
        Me.TextBoxOutEC.Name = "TextBoxOutEC"
        Me.TextBoxOutEC.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxOutEC.TabIndex = 108
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(16, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 20)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "導電度(EC)："
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(16, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "酸鹼值(PH)："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxInSS)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBoxInAMDI)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxInCOD)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxInTemp)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBoxInPH)
        Me.GroupBox2.Controls.Add(Me.TextBoxInEC)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(109, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 264)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "進流水"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(311, 189)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 20)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "color"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(311, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 20)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "℃"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(311, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 20)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "mg/l"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(311, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "mg/l"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(311, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ms/cm"
        '
        'TextBoxInSS
        '
        Me.TextBoxInSS.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxInSS.Location = New System.Drawing.Point(172, 120)
        Me.TextBoxInSS.Name = "TextBoxInSS"
        Me.TextBoxInSS.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxInSS.TabIndex = 104
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "懸浮固體(SS)："
        '
        'TextBoxInAMDI
        '
        Me.TextBoxInAMDI.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxInAMDI.Location = New System.Drawing.Point(172, 186)
        Me.TextBoxInAMDI.Name = "TextBoxInAMDI"
        Me.TextBoxInAMDI.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxInAMDI.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "色度(AMDI)："
        '
        'TextBoxInCOD
        '
        Me.TextBoxInCOD.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxInCOD.Location = New System.Drawing.Point(172, 153)
        Me.TextBoxInCOD.Name = "TextBoxInCOD"
        Me.TextBoxInCOD.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxInCOD.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "化學需氧量(COD)："
        '
        'TextBoxInTemp
        '
        Me.TextBoxInTemp.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxInTemp.Location = New System.Drawing.Point(172, 87)
        Me.TextBoxInTemp.Name = "TextBoxInTemp"
        Me.TextBoxInTemp.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxInTemp.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "溫度(TEMP)："
        '
        'TextBoxInPH
        '
        Me.TextBoxInPH.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxInPH.Location = New System.Drawing.Point(172, 21)
        Me.TextBoxInPH.Name = "TextBoxInPH"
        Me.TextBoxInPH.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxInPH.TabIndex = 101
        '
        'TextBoxInEC
        '
        Me.TextBoxInEC.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxInEC.Location = New System.Drawing.Point(172, 54)
        Me.TextBoxInEC.Name = "TextBoxInEC"
        Me.TextBoxInEC.Size = New System.Drawing.Size(133, 29)
        Me.TextBoxInEC.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "導電度(EC)："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "酸鹼值(PH)："
        '
        'TextBoxTimeStamp
        '
        Me.TextBoxTimeStamp.Enabled = False
        Me.TextBoxTimeStamp.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxTimeStamp.Location = New System.Drawing.Point(200, 110)
        Me.TextBoxTimeStamp.Name = "TextBoxTimeStamp"
        Me.TextBoxTimeStamp.Size = New System.Drawing.Size(214, 29)
        Me.TextBoxTimeStamp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(106, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "日期/時間："
        '
        'frmDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDataView"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioKN As System.Windows.Forms.RadioButton
    Friend WithEvents RadioKC As System.Windows.Forms.RadioButton
    Friend WithEvents EndDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelStartDate As System.Windows.Forms.Label
    Friend WithEvents LabelEndDate As System.Windows.Forms.Label
    Friend WithEvents StartTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxInEC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxInPH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTimeStamp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxInCOD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxInTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxInAMDI As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxInSS As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOutO2 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOutSS As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOutAMDI As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOutCOD As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOutTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOutPH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOutEC As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
