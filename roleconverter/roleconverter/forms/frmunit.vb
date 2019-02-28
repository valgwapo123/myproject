Public Class frmunit
    Dim unitidx As String
    Dim SelectedUnit As paperunit
    Dim tmpcat As paperunit
    Friend paperunit

    Private Sub ListView1_doubleclicxk(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged
        If lvList.SelectedItems.Count = 0 Then Exit Sub
        txtunit.Text = lvList.SelectedItems(0).SubItems(1).Text
        txtwidth.Text = lvList.SelectedItems(0).SubItems(2).Text
        txtheight.Text = lvList.SelectedItems(0).SubItems(3).Text
        btnsave.Text = "&Update"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If btnsave.Text = "Add" Then
            Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
            If msg = vbNo Then Exit Sub


            savelist()
            LoadClass()
            lvList.Items.Clear()
            Exit Sub
        End If
        If btnsave.Text = "&Update"  Then
            If lvList.Items.Count = 0 Then Exit Sub

            Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
            If msg = vbNo Then Exit Sub


            For Each lv As ListViewItem In lvList.Items
                Dim bnj As New paperunit
                With bnj
                    .Unit_ID = lv.Tag
                    .UNIT_NAME = lv.SubItems(1).Text
                    .unit_width = lv.SubItems(2).Text
                    .unit_height = lv.SubItems(3).Text

                    .Updatebarcode()
                End With
            Next
            MsgBox("Successfully updated.")
        End If
    End Sub
    Private Sub savelist()
        Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
        If msg = vbNo Then Exit Sub

        For Each lv As ListViewItem In lvList.Items
            Dim bnj As New paperunit
            With bnj
                .UNIT_NAME = lv.SubItems(1).Text
                .unit_width = lv.SubItems(2).Text
                .unit_height = lv.SubItems(3).Text
                .unit_status = "1"
                .Saveunit()
            End With
        Next

        MsgBox("Successfully saved.")

    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'If btnsave.Text = "Add" Then

        '    Dim lv As ListViewItem = lvList.Items.Add(0)
        '    lv.SubItems.Add(txtunit.Text)
        '    lv.SubItems.Add(txtwidth.Text)
        '    lv.SubItems.Add(txtheight.Text)
        '    lv.SubItems.Add("PROCESSING")
        '    txtunit.Clear() : txtwidth.Clear() : txtheight.Clear()

        '    Exit Sub

        'End If
        If btnsave.Text = "&Update" Then
            Dim lv As ListViewItem = lvList.Items.Add(0)
            lv.SubItems.Add(txtunit.Text)
            lv.SubItems.Add(txtwidth.Text)
            lv.SubItems.Add(txtheight.Text)
        Else
            lvList.SelectedItems(0).SubItems(1).Text = txtunit.Text
            lvList.SelectedItems(0).SubItems(2).Text = txtwidth.Text
            lvList.SelectedItems(0).SubItems(3).Text = txtheight.Text
        End If
    End Sub

    Friend Sub LoadCategory(ByVal c As paperunit)
        If c.UNIT_NAME = Nothing Then Exit Sub

        txtunit.Text = c.UNIT_NAME
        txtwidth.Text = c.unit_width
        SelectedUnit = c


        btnsave.Text = "&Update"
    End Sub
    Private Sub listviewclick()






        Dim paperrollunit As Integer
        paperrollunit = ListView1.FocusedItem.Text
        Console.WriteLine("Paperroll ID: " & paperrollunit)

        tmpcat = New paperunit
        tmpcat.LoadCat(paperrollunit)


        Me.TabControl1.SelectedTab = Me.TabPage1

        LoadClassxx(paperrollunit)





      



    End Sub
    Public Sub LoadClassxx(ByVal ppidx)


        Dim mySql As String = "select * from TBL_UNIT  WHERE UNIT_ID='" & ppidx & "'"

        Dim ds As DataSet = LoadSQL(mySql)

        lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("UNIT_ID"))
            lv.SubItems.Add(dr("UNIT_NAME"))
            lv.SubItems.Add(dr("UNIT_WIDTH"))
            lv.SubItems.Add(dr("UNIT_HEIGHT"))
            Dim a As String
            If (dr("STATUS") = 1) Then
                a = "Active"
            Else
                a = "NOT ACTIVE"
            End If
            lv.SubItems.Add(a)


        Next
    End Sub
    Private Sub frmunit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub
    Private Sub LoadClass()
        Dim mySql As String = "select * from TBL_UNIT  WHERE STATUS='1'  order by UNIT_ID DESC"
        Dim ds As DataSet = LoadSQL(mySql)

        ListView1.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = ListView1.Items.Add(dr("UNIT_ID"))
            lv.SubItems.Add(dr("UNIT_NAME"))
            lv.SubItems.Add(dr("UNIT_WIDTH"))
            lv.SubItems.Add(dr("UNIT_HEIGHT"))
            lv.SubItems.Add(dr("STATUS"))
            lv.Tag = dr.Item("Unit_ID")
        Next
    End Sub

    Private Sub additem(ByVal bn As paperunit)
        With bn
            Dim lv As ListViewItem = lvList.Items.Add(.Unit_ID)
            lv.SubItems.Add(.UNIT_NAME)
            lv.SubItems.Add(.unit_width)
            lv.SubItems.Add(.unit_height)

            lv.Tag = .Unit_ID
        End With
    End Sub
    Private Sub ListView1_doubleclick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        listviewclick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
   
    End Sub

    Private Sub ListView1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        listviewclick()


    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class