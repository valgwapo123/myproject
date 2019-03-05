Public Class frmaddpaperroll
    Dim idx As Integer

    Private Sub frmaddpaperroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub
    Public Sub LoadClass()
        Dim mySql As String = "select * from TBL_PAPERROLL  WHERE STATUS='1' order by PAPERROLE_ID"
        Dim ds As DataSet = LoadSQL(mySql)
        Dim TOTALQROLL As String
        lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("PAPERROLE_ID").ToString)
            lv.SubItems.Add(dr("PAPERNAME").ToString)
            lv.SubItems.Add(dr("DESCRIPTION").ToString)
            lv.SubItems.Add(dr("SERIAL_CODE").ToString)
            lv.SubItems.Add(dr("Remarks").ToString)
            lv.SubItems.Add(dr("Height") & " " & "Meters")


            Dim mySqlx As String = "SELECT SUM(TBL_ADD_PAPERROLL.QUANTITY) AS TOTALQ from TBL_PAPERROLL  INNER JOIN TBL_ADD_PAPERROLL ON TBL_ADD_PAPERROLL.PAPERROLL_ID= TBL_PAPERROLL.PAPERROLE_ID   WHERE TBL_ADD_PAPERROLL.PAPERROLL_ID='" & dr("PAPERROLE_ID") & "'"

            Dim ds1 As DataSet = LoadSQL(mySqlx)

            '   lvList.Items.Clear()
            For Each dr1 As DataRow In ds1.Tables(0).Rows


                

                TOTALQROLL = (dr1("TOTALQ")).ToString

              
                lv.SubItems.Add(TOTALQROLL)



            Next


        Next


    End Sub

    Private Sub lvList_DOUBLECLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        If lvList.SelectedItems.Count = 0 Then Exit Sub
        lvList.Tag = lvList.SelectedItems(0).SubItems(0).Text
        txtpapername.Text = lvList.SelectedItems(0).SubItems(1).Text
        txtpdescription.Text = lvList.SelectedItems(0).SubItems(2).Text
        txtserial.Text = lvList.SelectedItems(0).SubItems(3).Text
        txtremaks.Text = lvList.SelectedItems(0).SubItems(4).Text
        txtheight.Text = lvList.SelectedItems(0).SubItems(5).Text
      
        txtremaining.Text = Val(lvList.SelectedItems(0).SubItems(6).Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If txtaddquantity.Text = "" Then
            txtaddquantity.Focus()

            Exit Sub
        End If
        'additemlistview()
        Dim lv As ListViewItem = lvlprocess.Items.Add(lvList.Tag)
        lv.SubItems.Add(txtpapername.Text)
        lv.SubItems.Add(txtpdescription.Text)
        lv.SubItems.Add(txtserial.Text)
        lv.SubItems.Add(txtheight.Text)
        lv.SubItems.Add(txtremaks.Text)
        lv.SubItems.Add(txtaddquantity.Text)
        txtpapername.Clear() : txtpdescription.Clear() : txtremaks.Clear() : txtserial.Clear() : txtheight.Clear() : txtremaks.Clear() : txtremaining.Clear() : txtaddquantity.Clear()



    End Sub

    Private Sub savelist()
     

    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub

    Private Sub btnsaved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaved.Click
        If lvList.Items.Count = 0 Then Exit Sub

        Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
        If msg = vbNo Then Exit Sub


        For Each lv As ListViewItem In lvlprocess.Items
            Dim bnj As New add_PAPERROLL
            With bnj

                .PAPERROLL_ID = lvList.Tag
                .Quantity = lv.SubItems(6).Text
                .Statuss = "1"

                .ADDquantity()

                lvlprocess.Items.Clear()
                LoadClass()
            End With
        Next


    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If lvlprocess.SelectedItems.Count = 0 Then Exit Sub
        'Remove single item
        lvlprocess.Items.RemoveAt(lvlprocess.SelectedIndices(0))

    End Sub
End Class