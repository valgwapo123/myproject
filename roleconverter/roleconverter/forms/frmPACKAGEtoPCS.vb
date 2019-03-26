Public Class frmPACKAGEtoPCS

    Private Sub frmPACKAGEtoPCS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsetpackage()
    End Sub

    Public Sub loadsetpackage()
        Dim mySql As String = "select * from TBL_SET_PACKAGE  WHERE STATUS='1' order by SET_ID"
        Dim ds As DataSet = LoadSQL(mySql)

        '   lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("SET_ID"))
            lv.SubItems.Add(dr("PACKAGE_NAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("REMARKS"))


        Next

    End Sub

End Class