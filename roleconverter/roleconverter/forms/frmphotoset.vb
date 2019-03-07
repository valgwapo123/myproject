Public Class frmphotoset
    Dim tmpcat As PACKAGESET
    Private Sub frmphotoset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Or btnadd.Text = "&Add" Then

            Dim lv As ListViewItem = lvList.Items.Add(0)
            lv.SubItems.Add(txtpackagename.Text)
            lv.SubItems.Add(txtdescription.Text)
            lv.SubItems.Add(txtremaks.Text)

            txtpackagename.Clear() : txtdescription.Clear() : txtremaks.Clear()

            Exit Sub

        End If
        If btnadd.Text = "&Update" Then
            lvList.Items.Clear()

            Dim lv As ListViewItem = lvList.Items.Add(lvList.Tag)
            lv.SubItems.Add(txtpackagename.Text)
            lv.SubItems.Add(txtdescription.Text)
            lv.SubItems.Add(txtremaks.Text)

            txtpackagename.Clear() : txtdescription.Clear() : txtremaks.Clear()

            Exit Sub

        End If
    End Sub

    Public Sub LoadClassxx(ByVal ppidx)


        Dim mySql As String = "select * from TBL_SET_PACKAGE  WHERE SET_ID='" & ppidx & "'"

        Dim ds As DataSet = LoadSQL(mySql)

        lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("SET_ID"))
            lv.SubItems.Add(dr("PACKAGE_NAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("REMARKS"))

            btnadd.Text = "&Update"


            lvList.Tag = dr("SET_ID").ToString
            txtpackagename.Text = dr("PACKAGE_NAME").ToString
            txtdescription.Text = dr("DESCRIPTION").ToString
            txtremaks.Text = dr("REMARKS").ToString


        Next
    End Sub
    Public Sub LoadClass()
        Dim mySql As String = "select * from TBL_SET_PACKAGE  WHERE STATUS='1' order by SET_ID"
        Dim ds As DataSet = LoadSQL(mySql)

        lvlsaved.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvlsaved.Items.Add(dr("SET_ID"))
            lv.SubItems.Add(dr("PACKAGE_NAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("REMARKS"))
  

        Next

    End Sub

    Private Sub savelist()
        Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
        If msg = vbNo Then Exit Sub

        For Each lv As ListViewItem In lvList.Items
            Dim bnj As New PACKAGESET
            With bnj
                .PACKAGE_NAME = lv.SubItems(1).Text
                .DESCRIPTION = lv.SubItems(2).Text
                .Remarks = lv.SubItems(3).Text
                .STATUSS = "1"
                .SAVEPACKAGESET()

                LoadClass()
            End With
            lvList.Items.Clear()
            MessageBox.Show("Successfully SAVE")
        Next



    End Sub
    Private Sub Btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnremove.Click
        If lvList.SelectedItems.Count = 0 Then Exit Sub
        'Remove single item
        lvList.Items.RemoveAt(lvList.SelectedIndices(0))
        btnadd.Text = "&Add"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If btnadd.Text = "Add" Or btnadd.Text = "&Add" Then

            savelist()
        End If
        If btnadd.Text = "&Update" Then

            If lvList.Items.Count = 0 Then Exit Sub

            Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
            If msg = vbNo Then Exit Sub


            For Each lv As ListViewItem In lvList.Items
                Dim bnj As New PACKAGESET
                With bnj

                    .SET_ID = lv.SubItems(0).Text
                    .PACKAGE_NAME = lv.SubItems(1).Text
                    .DESCRIPTION = lv.SubItems(2).Text
                    .Remarks = lv.SubItems(3).Text



                    .UpdatePACKAGE_SET()
                    LoadClass()
                    lvList.Items.Clear()
                End With
            Next
            MsgBox("Successfully updated.")


        End If
    End Sub

    Private Sub lvlsaved_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlsaved.DoubleClick
        Dim setIDX As Integer
        setIDX = lvlsaved.FocusedItem.Text
        Console.WriteLine("SET ID: " & setIDX)

        tmpcat = New PACKAGESET
        tmpcat.LoadCat(setIDX)



        LoadClassxx(setIDX)


    End Sub

    Private Sub lvlsaved_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlsaved.SelectedIndexChanged
        btncancel.Enabled = True
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btncancel.Enabled = False
        btnadd.Text = "&Add"
        txtpackagename.Clear() : txtdescription.Clear() : txtremaks.Clear()
        lvList.Items.Clear()
        btncancel.Enabled = False
    End Sub
End Class