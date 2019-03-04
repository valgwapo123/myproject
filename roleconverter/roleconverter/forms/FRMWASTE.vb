Public Class FRMWASTE

    Private Sub FRMWASTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub
    Public Sub LoadClass()
        Dim mySql As String = "SELECT * FROM TBL_PAPERROLL "
        Dim ds As DataSet = LoadSQL(mySql)
        Dim PAPERCUTQUANTIY, PAPERCUTHEIGHT, TOTHEIGHT, TOTALROLL, USEPAPER As Integer

        '   lvList.Items.Clear() 
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("PAPERROLE_ID"))
            lv.SubItems.Add(dr("PAPERNAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("SERIAL_CODE"))
            lv.SubItems.Add(dr("Remarks"))


            ''CONVERTION 1 Roll
            'TOTALROLL = Val(dr("HEIGHT") * 100 / 100)
            'lv.SubItems.Add(Val(TOTALROLL) / Val(dr("HEIGHT")))

            Dim mySqlx As String = "SELECT SUM(TBL_PRODUCTIONPAPER.QUANTITY) AS TOTQUANTITY   FROM TBL_UNIT INNER JOIN TBL_PAPERCUT ON TBL_UNIT.UNIT_ID =TBL_PAPERCUT.UNIT_ID INNER JOIN TBL_PAPERROLL ON TBL_PAPERROLL.PAPERROLE_ID =TBL_PAPERCUT.PAPERROLE_ID  INNER JOIN TBL_PRODUCTIONPAPER ON TBL_PRODUCTIONPAPER.CUT_ID =TBL_PAPERCUT.CUT_ID   WHERE TBL_PAPERROLL.PAPERROLE_ID   ='" & dr("PAPERROLE_ID") & "'"

            Dim ds1 As DataSet = LoadSQL(mySqlx)


            For Each dr1 As DataRow In ds1.Tables(0).Rows
                PAPERCUTQUANTIY = Val(dr1("TOTQUANTITY").ToString)

            


            Next


            Dim mySqlxx As String = "SELECT TBL_UNIT.UNIT_HEIGHT  FROM TBL_UNIT INNER JOIN TBL_PAPERCUT ON TBL_UNIT.UNIT_ID =TBL_PAPERCUT.UNIT_ID INNER JOIN TBL_PAPERROLL ON TBL_PAPERROLL.PAPERROLE_ID =TBL_PAPERCUT.PAPERROLE_ID  WHERE TBL_PAPERROLL.PAPERROLE_ID  ='" & dr("PAPERROLE_ID") & "'"

            Dim ds2 As DataSet = LoadSQL(mySqlxx)


            For Each dr2 As DataRow In ds2.Tables(0).Rows

                PAPERCUTHEIGHT = Val(dr2("UNIT_HEIGHT").ToString)

                TOTHEIGHT = PAPERCUTHEIGHT * PAPERCUTQUANTIY



            Next
            Dim remain As Integer = Val(dr("HEIGHT") - Val(TOTHEIGHT))
            Dim cutpap As Double = Val(remain) * 100 / 100 / Val(dr("HEIGHT"))
            lv.SubItems.Add(1 - Val(cutpap))
            lv.SubItems.Add(Val(remain) * 100 / 100 / Val(dr("HEIGHT")))

            '    lv.SubItems.Add(Val(dr("HEIGHT")) - Val(TOTHEIGHT))
        Next




    End Sub

    '
End Class