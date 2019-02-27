Public Class frmpaperroll
    Dim SelectedCat As paperroll
    Private Sub frmpaperroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub
    'Private Sub loadcategory(Optional ByVal str As String = "select * from TBL_PAPERROLL order by PAPERROLE_ID asc")
    '    ''Dim ds As DataSet = LoadSQL(str, "TBL_PAPERROLL")

    '    ''If ds.Tables(0).Rows.Count = 0 Then lvList.Items.Clear() : Exit Sub

    '    ''lvList.Items.Clear()
    '    ''For Each dr As DataRow In ds.Tables(0).Rows
    '    ''    Dim bnj As New paperroll
    '    ''    bnj.Load_categoryxxx(dr.Item("PAPERROLE_ID"))

    '    ''    additem(bnj)


    '    'Next

    'End Sub
    Private Sub LoadClass()
        Dim mySql As String = "select * from TBL_PAPERROLL  WHERE STATUS='1' order by PAPERROLE_ID "
        Dim ds As DataSet = LoadSQL(mySql)

        lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("PAPERROLE_ID"))
            lv.SubItems.Add(dr("PAPERNAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("Remarks"))
            If dr("STATUS") = "1" Then
                lv.SubItems.Add("ACTIVE")
            Else
                lv.SubItems.Add("NOT ACTIVE")
            End If

        Next
    End Sub
    Private Sub additem(ByVal bn As paperroll)
        With bn
            Dim lv As ListViewItem = lvList.Items.Add(.PAPER_ID)
            lv.SubItems.Add(.PAPERNAME)
            lv.SubItems.Add(.DESCRIPTION)
            lv.SubItems.Add(.REMARKS)
            lv.SubItems.Add(.STATUS)
            lv.Tag = .PAPER_ID
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        listviewclick()

    End Sub
    Private Sub listviewclick()
        frmpaperrole.lvList.Items.Clear()

        Dim Z As Integer = 0, nRow As Integer = 0

        With lvList
            If .SelectedItems.Count > 0 Then
                nRow = CInt(.SelectedIndices(0))

                Z = 0


                frmpaperrole.txtpaperid.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1


                frmpaperrole.txtpapername.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1

                frmpaperrole.txtpdescription.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                frmpaperrole.txtremaks.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                frmpaperrole.btnsave.Text = "Update"


            End If
        End With

        frmpaperrole.Enabled = True
        Me.Close()
        frmpaperrole.Focus()


        Dim lv As ListViewItem = frmpaperrole.lvList.Items.Add(frmpaperrole.txtpaperid.Text)
        lv.SubItems.Add(frmpaperrole.txtpapername.Text)
        lv.SubItems.Add(frmpaperrole.txtpdescription.Text)
        lv.SubItems.Add(frmpaperrole.txtremaks.Text)
        lv.SubItems.Add("processing")




        frmpaperrole.txtpaperid.Visible = False


    End Sub

    Private Sub lvList_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        listviewclick()
    End Sub
    Private Sub selectbarcode()
        If lvList.SelectedItems.Count = 0 Then Exit Sub
        lvList.Items.Clear()
        Dim i As Integer = lvList.FocusedItem.Tag
        Dim bn As New paperroll
        bn.Load_categoryxxx(i)
        With bn
            Dim lv As ListViewItem = frmpaperrole.lvList.Items.Add(.PAPER_ID)
            lv.SubItems.Add(.PAPERNAME)
            lv.SubItems.Add(.DESCRIPTION)
            lv.SubItems.Add(.REMARKS)
            lv.SubItems.Add(.REMARKS)
            lv.SubItems.Add(.STATUS)
            lv.Tag = .PAPER_ID
        End With



    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub
End Class