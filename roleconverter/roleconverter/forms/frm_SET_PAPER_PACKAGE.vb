Public Class frm_SET_PAPER_PACKAGE

    Private Sub frm_SET_PAPER_PACKAGE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
        LOADPAPERCUT()
    End Sub
    Public Sub LoadClass()
        Dim mySql As String = "select * from TBL_SET_PACKAGE  WHERE STATUS='1' order by SET_ID"
        Dim ds As DataSet = LoadSQL(mySql)

        lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("SET_ID"))
            lv.SubItems.Add(dr("PACKAGE_NAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("REMARKS"))


        Next

    End Sub
    Public Sub LOADPAPERCUT()
        Dim mySql As String = "select  *  from TBL_UNIT INNER JOIN TBL_PAPERCUT ON TBL_UNIT.UNIT_ID= TBL_PAPERCUT.UNIT_ID INNER JOIN TBL_PAPERROLL ON  TBL_PAPERCUT.PAPERROLE_ID=TBL_PAPERROLL.PAPERROLE_ID ORDER BY TBL_PAPERCUT.PAPERROLE_ID DESC "
        Dim ds As DataSet = LoadSQL(mySql)

        lvlpapercut.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvlpapercut.Items.Add(dr("CUT_ID"))
            lv.SubItems.Add(dr("CUT_NAME").ToString)
            lv.SubItems.Add(dr("DESCRIPTION").ToString)
            lv.SubItems.Add(dr("UNIT_ID").ToString)
            lv.SubItems.Add(dr("UNIT_NAME"))
            lv.SubItems.Add(dr("REMARKS").ToString)
            lv.SubItems.Add(dr("PAPERROLE_ID1").ToString)
            lv.SubItems.Add(dr("PAPERNAME").ToString)
            lv.SubItems.Add(dr("DESCRIPTION1").ToString)
            lv.SubItems.Add(dr("SERIAL_CODE").ToString)
            lv.SubItems.Add(dr("REMARKS1").ToString)


        Next

    End Sub
End Class