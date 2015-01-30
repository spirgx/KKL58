Public Class frmHomePage

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        Dim dataAdapt As System.Data.SqlClient.SqlDataAdapter
        Dim dataStr As String
        Dim dataSet As System.Data.DataSet

        dataStr = "SELECT convert(decimal(8,1) ,IN_PH) AS IN_PH , " & _
                    "convert(decimal(8,3) ,IN_EC) AS IN_EC , " & _
                    "convert(decimal(8,1) , IN_TEMP) AS IN_TEMP, " & _
                    "convert(decimal(8,1) ,IN_SS) AS IN_SS , " & _
                    "convert(decimal(8,1) ,IN_COD) AS IN_COD, " & _
                    "convert(decimal(8,1) ,IN_AMDI) AS IN_AMDI, " & _
                    "convert(decimal(8,1) ,OUT_PH) AS OUT_PH, " & _
                    "convert(decimal(8,3) ,OUT_EC) AS OUT_EC, " & _
                    "convert(decimal(8,1) ,OUT_TEMP) AS OUT_TEMP, " & _
                    "convert(decimal(8,1) ,OUT_SS) AS OUT_SS, " & _
                    "convert(decimal(8,1) ,OUT_COD) AS OUT_COD, " & _
                    "convert(decimal(8,1) ,OUT_AMDI) AS OUT_AMDI, " & _
                    "convert(decimal(8,1) ,OUT_O2) AS OUT_O2 FROM KN_TEMP_TABLE"



        dataAdapt = New System.Data.SqlClient.SqlDataAdapter(dataStr, gDBConn)
        dataSet = New System.Data.DataSet
        dataAdapt.Fill(dataSet, "ds1")

        KN_IN_PH.Text = dataSet.Tables("ds1").Rows(0).Item("IN_PH").ToString
        KN_IN_EC.Text = dataSet.Tables("ds1").Rows(0).Item("IN_EC").ToString
        KN_IN_TEMP.Text = dataSet.Tables("ds1").Rows(0).Item("IN_temp").ToString
        KN_IN_SS.Text = dataSet.Tables("ds1").Rows(0).Item("IN_SS").ToString
        KN_IN_COD.Text = dataSet.Tables("ds1").Rows(0).Item("IN_COD").ToString
        KN_IN_AMDI.Text = dataSet.Tables("ds1").Rows(0).Item("IN_AMDI").ToString

        KN_OUT_PH.Text = dataSet.Tables("ds1").Rows(0).Item("OUT_PH").ToString
        KN_OUT_EC.Text = dataSet.Tables("ds1").Rows(0).Item("OUT_EC").ToString
        KN_OUT_TEMP.Text = dataSet.Tables("ds1").Rows(0).Item("OUT_temp").ToString
        KN_OUT_SS.Text = dataSet.Tables("ds1").Rows(0).Item("OUT_SS").ToString
        KN_OUT_COD.Text = dataSet.Tables("ds1").Rows(0).Item("OUT_COD").ToString
        KN_OUT_AMDI.Text = dataSet.Tables("ds1").Rows(0).Item("OUT_AMDI").ToString
        KN_OUT_O2.Text = dataSet.Tables("ds1").Rows(0).Item("OUT_O2").ToString

        If dataSet.Tables("ds1").Rows.Count = 0 Then
            MsgBox("沒有資料", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "錯誤")
        End If

        dataStr = "SELECT convert(decimal(8,1) ,IN_PH) AS IN_PH , " & _
                    "convert(decimal(8,3) ,IN_EC) AS IN_EC , " & _
                    "convert(decimal(8,1) , IN_TEMP) AS IN_TEMP, " & _
                    "convert(decimal(8,1) ,IN_SS) AS IN_SS , " & _
                    "convert(decimal(8,1) ,IN_COD) AS IN_COD, " & _
                    "convert(decimal(8,1) ,IN_AMDI) AS IN_AMDI, " & _
                    "convert(decimal(8,1) ,OUT_PH) AS OUT_PH, " & _
                    "convert(decimal(8,3) ,OUT_EC) AS OUT_EC, " & _
                    "convert(decimal(8,1) ,OUT_TEMP) AS OUT_TEMP, " & _
                    "convert(decimal(8,1) ,OUT_SS) AS OUT_SS, " & _
                    "convert(decimal(8,1) ,OUT_COD) AS OUT_COD, " & _
                    "convert(decimal(8,1) ,OUT_AMDI) AS OUT_AMDI, " & _
                    "convert(decimal(8,1) ,OUT_O2) AS OUT_O2 FROM KC_TEMP_TABLE"
        dataAdapt = New System.Data.SqlClient.SqlDataAdapter(dataStr, gDBConn)
        dataSet = New System.Data.DataSet
        dataAdapt.Fill(dataSet, "ds2")

        KC_IN_PH.Text = dataSet.Tables("ds2").Rows(0).Item("IN_PH").ToString
        KC_IN_EC.Text = dataSet.Tables("ds2").Rows(0).Item("IN_EC").ToString
        KC_IN_TEMP.Text = dataSet.Tables("ds2").Rows(0).Item("IN_temp").ToString
        KC_IN_SS.Text = dataSet.Tables("ds2").Rows(0).Item("IN_SS").ToString
        KC_IN_COD.Text = dataSet.Tables("ds2").Rows(0).Item("IN_COD").ToString
        KC_IN_AMDI.Text = dataSet.Tables("ds2").Rows(0).Item("IN_AMDI").ToString

        KC_OUT_PH.Text = dataSet.Tables("ds2").Rows(0).Item("OUT_PH").ToString
        KC_OUT_EC.Text = dataSet.Tables("ds2").Rows(0).Item("OUT_EC").ToString
        KC_OUT_TEMP.Text = dataSet.Tables("ds2").Rows(0).Item("OUT_temp").ToString
        KC_OUT_SS.Text = dataSet.Tables("ds2").Rows(0).Item("OUT_SS").ToString
        KC_OUT_COD.Text = dataSet.Tables("ds2").Rows(0).Item("OUT_COD").ToString
        KC_OUT_AMDI.Text = dataSet.Tables("ds2").Rows(0).Item("OUT_AMDI").ToString
        KC_OUT_O2.Text = dataSet.Tables("ds2").Rows(0).Item("OUT_O2").ToString


        If dataSet.Tables("ds2").Rows.Count = 0 Then
            MsgBox("沒有資料", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "錯誤")
        End If

        Timer1.Interval = 5000

    End Sub

    Private Sub frmHomePage_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        DisconnectFromDatabase()

    End Sub

    Private Sub frmHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Permission = 3999 Then
            GroupBox1.Visible = False
            GroupBox2.SetBounds(164, 200, 707, 339)

        End If

        If Permission = 6999 Then
            GroupBox1.SetBounds(164, 200, 707, 339)
            GroupBox2.Visible = False
        End If

        Try
            If Not ConnectToDatabase() Then
                MsgBox("資料庫連線失敗", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "錯誤")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Timer1.Start()

    End Sub

End Class