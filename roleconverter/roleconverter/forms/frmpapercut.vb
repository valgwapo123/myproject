Public Class frmpapercut
    Dim idx As Integer = 0

    Private Sub frmpapercut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
        Loadunitcombo()
    End Sub
    Public Sub LoadClass()
        Dim mySql As String = "select * from TBL_PAPERROLL  WHERE STATUS='1' order by PAPERROLE_ID"
        Dim ds As DataSet = LoadSQL(mySql)

        '   lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("PAPERROLE_ID"))
            lv.SubItems.Add(dr("PAPERNAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("Remarks"))
         

        Next
      
    End Sub
    Public Sub Loadunitcombo()
        Dim mySql As String = "select * from TBL_UNIT"
        Dim ds As DataSet = LoadSQL(mySql)

        '   lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows

            Dim bnj As New paperunit
            With bnj
                .Unit_ID = dr.Item("Unit_ID")
                .UNIT_NAME = (dr.Item("UNIT_NAME"))
                combounit.Items.Add(.UNIT_NAME)
            End With



        Next

      

    End Sub
    'Private Sub LoadClass()
    '    Dim mySql As String = "select * from TBL_UNIT  WHERE STATUS='1'  "
    '    Dim ds As DataSet = LoadSQL(mySql)

    '    ListView2.Items.Clear()
    '    For Each dr As DataRow In ds.Tables(0).Rows
    '        Dim lv As ListViewItem = ListView2.Items.Add(dr("UNIT_ID"))
    '        lv.SubItems.Add(dr("UNIT_NAME"))
    '        lv.SubItems.Add(dr("UNIT_WIDTH"))
    '        lv.SubItems.Add("X")
    '        lv.SubItems.Add(dr("UNIT_HEIGHT"))


    '    Next
    'End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Friend Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        frmpaperroll.Show()

        Dim ax As Integer

        ax = 1
        frmpaperroll.formindentifier(ax)
        frmpaperroll.Focus()
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

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub btnunit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lvList_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        If lvList.SelectedItems.Count = 0 Then Exit Sub
        idx = lvList.SelectedItems(0).SubItems(0).Text
        txtpapername.Text = lvList.SelectedItems(0).SubItems(1).Text
        txtpdescription.Text = lvList.SelectedItems(0).SubItems(2).Text
        txtremaks.Text = lvList.SelectedItems(0).SubItems(3).Text

    End Sub



    Private Sub combounit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combounit.SelectedIndexChanged
      

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        'additemlistview()
        Dim lv As ListViewItem = ListView1.Items.Add(0)
        lv.SubItems.Add(idx)
        lv.SubItems.Add(txtpapername.Text)
        lv.SubItems.Add(combounit.Text)
        lv.SubItems.Add("processing")
        Exit Sub

    End Sub

End Class