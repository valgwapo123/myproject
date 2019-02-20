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
        Dim mySql As String = "select * from TBL_PAPERROLL order by PAPERROLE_ID "
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
        

            Dim Z As Integer = 0, nRow As Integer = 0

            With lvList
                If .SelectedItems.Count > 0 Then
                    nRow = CInt(.SelectedIndices(0))

                    Z = 0

                SelectedCat = New paperroll
                Dim a As String = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                With SelectedCat
                    .PAPER_ID = a
                End With


                frmpaperrole.txtpapername.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                frmpaperrole.txtpdescription.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                frmpaperrole.txtremaks.Text = .Items(nRow).SubItems(Z).Text.Trim : Z += 1
                frmpaperrole.btnsave.Text = "Update"


            End If
            End With

        Me.Close()
    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub
End Class