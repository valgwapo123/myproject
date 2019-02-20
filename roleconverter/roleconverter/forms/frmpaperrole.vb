﻿Public Class frmpaperrole
    Dim cat_idx As String
    Dim SelectedCat As paperroll
    Dim paperid As String

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'additemlistview()
        Dim lv As ListViewItem = lvList.Items.Add(0)
        lv.SubItems.Add(txtpapername.Text)
        lv.SubItems.Add(txtpdescription.Text)
        lv.SubItems.Add(txtremaks.Text)
        lv.SubItems.Add("processing")
        txtpapername.Clear() : txtpdescription.Clear() : txtremaks.Clear()
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

    Private Sub save()


        Dim msg As DialogResult = MsgBox("Do you want to save?", MsgBoxStyle.YesNo, "Save")
        If msg = vbNo Then Exit Sub

        SelectedCat = New paperroll
        With SelectedCat

            .PAPERNAME = txtpapername.Text
            .DESCRIPTION = txtpdescription.Text
            .REMARKS = txtremaks.Text
            .STATUS = "1"
        End With



        SelectedCat.SaveCat()

        MsgBox("Successfully saved.", MsgBoxStyle.Information)
        lvList.Items.Clear()
    End Sub


    Private Sub additemlistview()

        Dim i As Integer = 0
        For Each l In txtpapername.Lines
            lvList.Items.Add(l)
            lvList.Items(lvList.Items.Count - 1).SubItems.Add(txtpapername.Lines(i))
            lvList.Items(lvList.Items.Count - 1).SubItems.Add(txtpdescription.Lines(i))
            lvList.Items(lvList.Items.Count - 1).SubItems.Add(txtremaks.Lines(i))
            lvList.Items(lvList.Items.Count - 1).SubItems.Add("1"(i))
            i += 1
        Next
        i = 0

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

  
    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged
        Dim result As Integer = MessageBox.Show("This is the person ?", "Message", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Dim Z As Integer = 0, nRow As Integer = 0

            With lvList
                If .SelectedItems.Count > 0 Then
                    nRow = CInt(.SelectedIndices(0))

                    Z = 0



                    
                    paperid = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                        txtpapername.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                        txtpdescription.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                    txtremaks.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                    btnsave.Text = "Update"
                End If

            End With
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If btnsave.Text = "&Update" Then


            Exit Sub

        End If
        savelistview()
        btnsave.Text = "&Add" : txtpapername.Clear() : txtpdescription.Clear() : txtremaks.Clear()
    End Sub
   
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        frmpaperroll.Show()

    End Sub
End Class