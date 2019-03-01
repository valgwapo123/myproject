Public Class frmproduction
    Dim idx As Integer = 0
    Dim cutidx As Integer = 0
    Private Sub txtquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub frmproduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub
    Public Sub LoadClass()
        Dim mySql As String = "select * from TBL_PAPERROLL  WHERE STATUS='1' order by PAPERROLE_ID"
        Dim ds As DataSet = LoadSQL(mySql)

        '   lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("PAPERROLE_ID"))
            lv.SubItems.Add(dr("PAPERNAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("SERIAL_CODE"))
            lv.SubItems.Add(dr("Height") & " " & "Meters")
            lv.SubItems.Add(dr("Remarks"))


        Next
    End Sub

    Private Sub lvList_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        If lvList.SelectedItems.Count = 0 Then Exit Sub
        idx = lvList.SelectedItems(0).SubItems(0).Text
        txtpapername.Text = lvList.SelectedItems(0).SubItems(1).Text
        txtpdescription.Text = lvList.SelectedItems(0).SubItems(2).Text
        txtserial.Text = lvList.SelectedItems(0).SubItems(3).Text
        txtremaks.Text = lvList.SelectedItems(0).SubItems(4).Text
        txtheight.Text = lvList.SelectedItems(0).SubItems(5).Text



        Dim mySql As String = "SELECT  *  from TBL_UNIT INNER JOIN TBL_PAPERCUT ON TBL_UNIT.UNIT_ID= TBL_PAPERCUT.UNIT_ID INNER JOIN TBL_PAPERROLL ON  TBL_PAPERCUT.PAPERROLE_ID=TBL_PAPERROLL.PAPERROLE_ID WHERE TBL_PAPERCUT.PAPERROLE_ID='" & lvList.SelectedItems(0).SubItems(0).Text & "'"
        Dim ds As DataSet = LoadSQL(mySql)

        ListView1.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = ListView1.Items.Add(dr("CUT_ID"))
            lv.SubItems.Add(dr("PAPERROLE_ID").ToString)
            lv.SubItems.Add(dr("CUT_NAME").ToString)
            lv.SubItems.Add(dr("DESCRIPTION").ToString)

            lv.SubItems.Add(dr("UNIT_NAME").ToString)

            lv.SubItems.Add(dr("REMARKS").ToString)


        
        Next

    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub
 
    Private Sub ListView1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        cutidx = lvList.SelectedItems(0).SubItems(0).Text
        txtpapercut.Text = ListView1.SelectedItems(0).SubItems(2).Text
        txtdescription.Text = ListView1.SelectedItems(0).SubItems(3).Text
        txtunit.Text = ListView1.SelectedItems(0).SubItems(4).Text
        txtcutremarks.Text = ListView1.SelectedItems(0).SubItems(5).Text


    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlproduction.SelectedIndexChanged

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtpapercut.Text = "" Or txtpdescription.Text = "&Add" Then Exit Sub

        If btnadd.Text = "Add" Or btnadd.Text = "&Add" Then

            Dim lv As ListViewItem = lvlproduction.Items.Add(cutidx)
            lv.SubItems.Add(cutidx)
            lv.SubItems.Add(txtpapercut.Text)
            lv.SubItems.Add(txtdescription.Text)
            lv.SubItems.Add(txtunit.Text)

            lv.SubItems.Add(txtcutremarks.Text)
            lv.SubItems.Add(txtquantity.Text)
            txtdescription.Clear() : txtpapercut.Clear() : txtunit.Text = "" : txtcutremarks.Clear() : txtquantity.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        savelist()
    End Sub
    Private Sub savelist()
        Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
        If msg = vbNo Then Exit Sub

        For Each lv As ListViewItem In lvlproduction.Items
            Dim bnj As New production
            With bnj
                .CUT_ID = lv.SubItems(0).Text
              
                .quantity_pro = lv.SubItems(6).Text
                .statusx = "1"
           
                .SAVEPAPERCUT()
                lvlproduction.Items.Clear()
            End With
        Next



    End Sub
    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If lvlproduction.SelectedItems.Count = 0 Then Exit Sub
        'Remove single item
        lvlproduction.Items.RemoveAt(ListView1.SelectedIndices(0))
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class