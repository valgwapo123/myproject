Public Class FRMWASTE

    Private Sub FRMWASTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub
    Public Sub LoadClass()
        Dim mySql As String = "SELECT * FROM TBL_PAPERROLL "
        Dim ds As DataSet = LoadSQL(mySql)
        Dim TOTALEXACQUANTIY, Rollquantity, Exactheight As String

        '   lvList.Items.Clear() 
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("PAPERROLE_ID"))
            lv.SubItems.Add(dr("PAPERNAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("SERIAL_CODE"))
            lv.SubItems.Add(dr("Remarks"))


            Dim mySqlx As String = "SELECT SUM(TBL_ADD_PAPERROLL.QUANTITY) AS TOTALQ from TBL_PAPERROLL  INNER JOIN TBL_ADD_PAPERROLL ON TBL_ADD_PAPERROLL.PAPERROLL_ID= TBL_PAPERROLL.PAPERROLE_ID   WHERE TBL_ADD_PAPERROLL.PAPERROLL_ID='" & dr("PAPERROLE_ID") & "'"

            Dim ds1 As DataSet = LoadSQL(mySqlx)

            '   lvList.Items.Clear()
            For Each dr1 As DataRow In ds1.Tables(0).Rows




                TOTALEXACQUANTIY = (dr1("TOTALQ")).ToString
                Rollquantity = Val(Val(TOTALEXACQUANTIY) * Val(dr("Height")) / Val(dr("Height")))
                'TOTAL EXACT HEIGHT . formula (QUANTITY * HEIGHT)
                Exactheight = Val(Val(TOTALEXACQUANTIY) * Val(dr("Height")))

                'Roll Quantity
                lv.SubItems.Add(Rollquantity)



            Next

            Dim mySqll As String = "SELECT SUM(TBL_PRODUCTIONPAPER.QUANTITY) AS TOTALUSED FROM TBL_PRODUCTIONPAPER INNER JOIN TBL_PAPERCUT ON TBL_PRODUCTIONPAPER.CUT_ID =TBL_PAPERCUT.CUT_ID INNER JOIN TBL_PAPERROLL ON TBL_PAPERCUT.PAPERROLE_ID=TBL_PAPERROLL.PAPERROLE_ID  WHERE TBL_PAPERROLL.PAPERROLE_ID='" & dr("PAPERROLE_ID") & "'"

            Dim dsx As DataSet = LoadSQL(mySqll)

            '   lvList.Items.Clear()
            For Each drx As DataRow In dsx.Tables(0).Rows



                lv.SubItems.Add(drx("TOTALUSED").ToString)
               


            Next
        Next




    End Sub

    '

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub
End Class