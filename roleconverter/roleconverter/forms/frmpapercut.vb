Public Class frmpapercut

    Private Sub frmpapercut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
    End Sub
    Private Sub LoadClass()
        Dim mySql As String = "select * from TBL_UNIT  WHERE STATUS='1'  "
        Dim ds As DataSet = LoadSQL(mySql)

        ListView2.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = ListView2.Items.Add(dr("UNIT_ID"))
            lv.SubItems.Add(dr("UNIT_NAME"))
            lv.SubItems.Add(dr("UNIT_WIDTH"))
            lv.SubItems.Add("X")
            lv.SubItems.Add(dr("UNIT_HEIGHT"))
         

        Next
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmpaperroll.Show()
        frmpaperroll.Focus()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count = 0 Then Exit Sub

        txtunit.Text = ListView2.SelectedItems(0).SubItems(1).Text
        GroupBox1.Visible = False
      
    End Sub

    Private Sub btnunit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnunit.Click
        GroupBox1.Visible = True
        ListView2.Focus()

    End Sub
End Class