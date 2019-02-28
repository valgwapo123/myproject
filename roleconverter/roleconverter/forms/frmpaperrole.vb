Public Class frmpaperrole
    Dim cat_idx As String
    Dim SelectedCat As paperroll

    Dim idx As Integer = 0

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.Text = "Add" Then
            'additemlistview()
            Dim lv As ListViewItem = lvList.Items.Add(0)
            lv.SubItems.Add(txtpapername.Text)
            lv.SubItems.Add(txtpdescription.Text)
            lv.SubItems.Add(txtremaks.Text)
            lv.SubItems.Add("processing")
            txtpapername.Clear() : txtpdescription.Clear() : txtremaks.Clear()
            Exit Sub
        End If
        If btnsave.Text = "&Update" Then
            'additemlistview()
            lvList.Items.Clear()
            Dim lv As ListViewItem = lvList.Items.Add(idx)
            lv.SubItems.Add(txtpapername.Text)
            lv.SubItems.Add(txtpdescription.Text)
            lv.SubItems.Add(txtremaks.Text)
            lv.SubItems.Add("processing")
            txtpapername.Clear() : txtpdescription.Clear() : txtremaks.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub loadcategory(Optional ByVal str As String = "select * from TBL_PAPERROLL order by PAPERROLE_ID asc")
        Dim ds As DataSet = LoadSQL(str, "TBL_PAPERROLL")

        If ds.Tables(0).Rows.Count = 0 Then lvList.Items.Clear() : Exit Sub

        lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim bnj As New paperroll
            bnj.Load_categoryxxx(dr.Item("PAPERROLE_ID"))

            additem(bnj)
        Next

    End Sub
    Private Sub additem(ByVal bn As paperroll)
        With bn
            Dim lv As ListViewItem = lvList.Items.Add(.PAPER_ID)
            lv.SubItems.Add(.PAPERNAME)
            lv.SubItems.Add(.DESCRIPTION)
            lv.SubItems.Add(.REMARKS)
            lv.SubItems.Add(.STATUS)
            lv.Tag = .PAPERNAME
        End With
    End Sub
    Private Sub savelist()
        Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
        If msg = vbNo Then Exit Sub

        For Each lv As ListViewItem In lvList.Items
            Dim bnj As New paperroll
            With bnj
                .PAPERNAME = lv.SubItems(1).Text
                .DESCRIPTION = lv.SubItems(2).Text
                .REMARKS = lv.SubItems(3).Text
                .STATUS = "1"
                .savepaperole()
            End With
        Next

        MsgBox("Successfully saved.")

    End Sub




    Friend Sub LoadCategory(ByVal c As paperroll)
        If c.PAPER_ID = Nothing Then Exit Sub

        txtpapername.Text = c.PAPERNAME
        txtpdescription.Text = c.DESCRIPTION
        txtremaks.Text = c.REMARKS
        SelectedCat = c

        btnsave.Text = "&Update"
    End Sub
    Friend Sub LoadClass(ByVal ppID As Integer)
        Dim mySql As String = "select * from TBL_PAPERROLL  WHERE PAPERROLE_ID='" & ppID & "'"

        Dim ds As DataSet = LoadSQL(mySql)

        lvList.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr.item("PAPERROLE_ID"))
            lv.SubItems.Add(dr.item("PAPERNAME"))
            lv.SubItems.Add(dr.item("DESCRIPTION"))
            lv.SubItems.Add(dr.item("Remarks"))
            If dr("STATUS") = "1" Then
                lv.SubItems.Add("ACTIVE")
            Else
                lv.SubItems.Add("NOT ACTIVE")
            End If
            Console.WriteLine("Data 1" & dr.item("PaperName"))
        Next
    End Sub
    Private Sub frmcategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loadcategory()
    End Sub
    Private Sub txtheight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdescription.GotFocus
        If txtpdescription.Text = "MM" Then
            txtpdescription.Text = ""
        End If
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdescription.LostFocus
        If txtpdescription.Text = "" Then
            txtpdescription.Text = "MM"
        End If
    End Sub

  
   

    '.Item("PAPERNAME") = _PAPERNAME
    '.Item("DESCRIPTION") = _DESCRIPTION
    '.Item("REMARKS") = _REMARKS
    '.Item("STATUS") = _STATUS
    Private Sub savelistview()

        For Each item As ListViewItem In lvList.Items
            SelectedCat = New paperroll

            With SelectedCat
                .PAPERNAME = item.SubItems(1).Text
                .DESCRIPTION = item.SubItems(2).Text
                .REMARKS = item.SubItems(3).Text
                .STATUS = "1"
            End With
            If item.Text = "" Then Exit For

        Next

        MsgBox("Successfully saved.", MsgBoxStyle.Information)

        SelectedCat.SaveCat()
    End Sub

    Private Sub save()
        Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
        If msg = vbNo Then Exit Sub

        For Each lv As ListViewItem In lvList.Items
            Dim bnj As New paperroll
            With bnj
                .PAPERNAME = lv.SubItems(1).Text
                .DESCRIPTION = lv.SubItems(2).Text
                .REMARKS = lv.SubItems(3).Text

                .savepaperole()
            End With
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If btnsave.Text = "&Update" Then

            updatelist()

            btnsave.Text = "&Add" : txtpapername.Clear() : txtpdescription.Clear() : txtremaks.Clear()
            lvList.Items.Clear()
            Exit Sub
        End If
        If btnsave.Text = "Add" Then
            Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
            If msg = vbNo Then Exit Sub

            savelist()
            lvList.Items.Clear()
            Exit Sub
        End If

      


    End Sub
    Private Sub updatelist()





        For Each item As ListViewItem In lvList.Items
            SelectedCat = New paperroll
            With SelectedCat
                .PAPER_ID = (item.SubItems(0).Text)
                .PAPERNAME = item.SubItems(1).Text
                .DESCRIPTION = item.SubItems(2).Text
                .REMARKS = item.SubItems(3).Text

                .Updatepaperoll()
            End With

        Next

    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        frmpaperroll.Show()

        Me.Enabled = False
        frmpaperroll.Focus()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub lvList_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        If lvList.SelectedItems.Count = 0 Then Exit Sub
        idx = lvList.SelectedItems(0).SubItems(0).Text
        txtpapername.Text = lvList.SelectedItems(0).SubItems(1).Text
        txtpdescription.Text = lvList.SelectedItems(0).SubItems(2).Text
        txtremaks.Text = lvList.SelectedItems(0).SubItems(3).Text
        btnsave.Text = "&Update"


    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub
End Class