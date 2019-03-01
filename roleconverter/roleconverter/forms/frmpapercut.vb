Public Class frmpapercut
    Dim idx As Integer = 0
    Dim papercutidx As Integer = 0

    Private Sub frmpapercut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
        Loadunitcombo()
        LOADSAVED()
    End Sub
    Private Sub savelist()
    

        For Each lv As ListViewItem In ListView1.Items
            Dim bnj As New papercut
            With bnj
                .PAPER_ID = lv.SubItems(1).Text
                .CUT_NAME = lv.SubItems(2).Text
                .DESCRIPTION = lv.SubItems(3).Text

           
                .statusx = "1"
                .SAVEPRODUCTION()
                LOADSAVED()
            End With
        Next

        ListView1.Items.Clear()


    End Sub

    Public Sub searchunitID()
      
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
            lv.SubItems.Add(dr("Remarks"))
            lv.SubItems.Add(dr("Height") & " " & "Meters")

        Next
      
    End Sub


    Public Sub LOADSAVED()
        Dim mySql As String = "select  *  from TBL_UNIT INNER JOIN TBL_PAPERCUT ON TBL_UNIT.UNIT_ID= TBL_PAPERCUT.UNIT_ID INNER JOIN TBL_PAPERROLL ON  TBL_PAPERCUT.PAPERROLE_ID=TBL_PAPERROLL.PAPERROLE_ID ORDER BY TBL_UNIT.UNIT_ID DESC "
        Dim ds As DataSet = LoadSQL(mySql)

        lvlsaved.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvlsaved.Items.Add(dr("CUT_ID"))
            lv.SubItems.Add(dr("CUT_NAME").ToString)
            lv.SubItems.Add(dr("DESCRIPTION").ToString)
            lv.SubItems.Add(dr("UNIT_ID").ToString)
            lv.SubItems.Add(dr("UNIT_NAME"))
            lv.SubItems.Add(dr("REMARKS").ToString)
            lv.SubItems.Add(dr("PAPERROLE_ID1").ToString)
            lv.SubItems.Add(dr("PAPERNAME").ToString)
            lv.SubItems.Add(dr("DESCRIPTION1").ToString)
            lv.SubItems.Add(dr("SERIAL_CODE").ToString)
            lv.SubItems.Add(dr("REMARKS1").ToString)

            'Dim lv As ListViewItem = lvlsaved.Items.Add(dr("PAPERROLE_ID"))
            'lv.SubItems.Add(dr("PAPERNAME"))
            'lv.SubItems.Add(dr("CUT_ID"))
            'lv.SubItems.Add(dr("CUT_NAME"))
            'lv.SubItems.Add(dr("UNIT_ID"))
            'lv.SubItems.Add(dr("UNIT_NAME"))
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
        txtserial.Text = lvList.SelectedItems(0).SubItems(3).Text
        txtremaks.Text = lvList.SelectedItems(0).SubItems(4).Text
        txtheight.Text = lvList.SelectedItems(0).SubItems(5).Text

    End Sub



    Private Sub combounit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtpapercut.Text = "" Or txtpdescription.Text = "&Add" Then Exit Sub

        If btnadd.Text = "Add" Or btnadd.Text = "&Add" Then

            Dim lv As ListViewItem = ListView1.Items.Add(0)
            lv.SubItems.Add(idx)
            lv.SubItems.Add(txtpapercut.Text)
            lv.SubItems.Add(txtdescription.Text)
            lv.SubItems.Add(combounit.Text)

            lv.SubItems.Add(txtcutremarks.Text)
            txtdescription.Clear() : txtpapercut.Clear() : combounit.Text = "" : txtcutremarks.Clear()
            Exit Sub
        End If

        If btnadd.Text = "&Update" Then

            Dim lv As ListViewItem = ListView1.Items.Add(papercutidx)
            lv.SubItems.Add(idx)
            lv.SubItems.Add(txtpapercut.Text)
            lv.SubItems.Add(txtdescription.Text)
            lv.SubItems.Add(combounit.Text)

            lv.SubItems.Add(txtcutremarks.Text)
            txtdescription.Clear() : txtpapercut.Clear() : combounit.Text = "" : txtcutremarks.Clear()
            Exit Sub
        End If




    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        If btnadd.Text = "Add" Or btnadd.Text = "&Add" Then

            savelist()
        End If
        If btnadd.Text = "&Update" Then

            If ListView1.Items.Count = 0 Then Exit Sub



            For Each lv As ListViewItem In ListView1.Items
                Dim bnj As New papercut
                With bnj
                    .CUT_ID = lv.SubItems(0).Text
                    .PAPER_ID = lv.SubItems(1).Text
                    .CUT_NAME = lv.SubItems(2).Text
                    .DESCRIPTION = lv.SubItems(3).Text
                    '.unit_id = lv.SubItems(5).Text

                    '======search unit ID
                    Dim mySql As String = "select UNIT_ID from TBL_UNIT  WHERE STATUS='1' AND UNIT_NAME='" & lv.SubItems(4).Text & "'  "

                    Dim ds As DataSet = LoadSQL(mySql)

                    '   lvList.Items.Clear()
                    For Each dr As DataRow In ds.Tables(0).Rows

                        .unit_id = (dr("UNIT_ID")).ToString


                    Next
                    .remarks_papaercut = lv.SubItems(5).Text

                    .updatepapercut()
                    LOADSAVED()
                    ListView1.Items.Clear()
                End With
            Next

        End If
       

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        'Remove single item
        ListView1.Items.RemoveAt(ListView1.SelectedIndices(0))

        ''Remove Multiple Selected Items 
        'For Each item As ListViewItem In ListView1.SelectedItems
        '    item.Remove()
        'Next

        ''Select Item at last index
        'ListView1.Items(ListView1.Items.Count - 1).Selected = True
    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub lvList_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub

    Private Sub lvlsaved_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlsaved.DoubleClick
        If lvlsaved.SelectedItems.Count = 0 Then Exit Sub
        papercutidx = lvlsaved.SelectedItems(0).SubItems(0).Text
        txtpapercut.Text = lvlsaved.SelectedItems(0).SubItems(1).Text
        txtdescription.Text = lvlsaved.SelectedItems(0).SubItems(2).Text
        combounit.Text = lvlsaved.SelectedItems(0).SubItems(4).Text
        txtcutremarks.Text = lvlsaved.SelectedItems(0).SubItems(5).Text
        idx = lvlsaved.SelectedItems(0).SubItems(6).Text
        txtpapername.Text = lvlsaved.SelectedItems(0).SubItems(7).Text
        txtpdescription.Text = lvlsaved.SelectedItems(0).SubItems(8).Text
        txtserial.Text = lvlsaved.SelectedItems(0).SubItems(9).Text
        txtremaks.Text = lvlsaved.SelectedItems(0).SubItems(10).Text
        'txtheight.Text = lvlsaved.SelectedItems(0).SubItems(11).Text
        btncancel.Enabled = True
        btnadd.Text = "&Update"
    End Sub

    Private Sub lvlsaved_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlsaved.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btnadd.Text = "&Add"
        btncancel.Enabled = False
        txtdescription.Clear() : txtpapercut.Clear() : combounit.Text = "" : txtcutremarks.Clear() : txtcutremarks.Clear() : txtpdescription.Clear() : txtserial.Clear() : txtremaks.Clear() : txtpapername.Clear() : idx = 0

    End Sub
End Class