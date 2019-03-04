Public Class frmproduction
    Dim idx, prodid As String
    Dim cutidx As String
    Dim tmpcat As production

    Private Sub txtquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub frmproduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
        ALREADYPROCESS()
    End Sub
    Private Sub productionlistviewupdateclick()

        Dim paperproduction As Integer
        paperproduction = LVLPROD.FocusedItem.Text
        Console.WriteLine("Paperroll ID: " & paperproduction)

        tmpcat = New production
        tmpcat.LoadCat(paperproduction)

        LOADUPDATELIST(paperproduction)
     



    End Sub
    'lOAD PRODUCT WANT TO UPDATED
    Public Sub LOADUPDATELIST(ByVal ppidx As Integer)


        Dim mySql As String = "select   TBL_PRODUCTIONPAPER.PROD_ID AS PRODUCTIONID," _
    & " TBL_PRODUCTIONPAPER.CUT_ID AS CUTID  ," _
    & " TBL_PAPERCUT.CUT_NAME AS CUTNAME ," _
    & " TBL_PAPERCUT.DESCRIPTION AS CUTDESCRIPTION, " _
    & " TBL_UNIT.UNIT_NAME AS UNIT_NAME, " _
    & " TBL_PAPERCUT.REMARKS AS REMARKS, " _
    & " TBL_PRODUCTIONPAPER.QUANTITY AS QUANTITY " _
    & "  from TBL_PRODUCTIONPAPER" _
    & "  INNER JOIN TBL_PAPERCUT ON TBL_PRODUCTIONPAPER.CUT_ID = TBL_PAPERCUT.CUT_ID" _
    & "  INNER JOIN TBL_UNIT ON TBL_UNIT.UNIT_ID = TBL_PAPERCUT.UNIT_ID" _
   & "  WHERE TBL_PRODUCTIONPAPER.PROD_ID='" & ppidx & "'"

        Dim ds As DataSet = LoadSQL(mySql)

        lvlproduction.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvlproduction.Items.Add(dr("PRODUCTIONID"))
            lv.SubItems.Add(dr("CUTID"))
            lv.SubItems.Add(dr("CUTNAME"))
            lv.SubItems.Add(dr("CUTDESCRIPTION"))
            lv.SubItems.Add(dr("UNIT_NAME"))
            lv.SubItems.Add(dr("REMARKS"))
            lv.SubItems.Add(dr("QUANTITY"))


            prodid = dr("PRODUCTIONID")
            cutidx = dr("CUTID").ToString
            txtpapercut.Text = dr("CUTNAME").ToString
            txtdescription.Text = dr("CUTDESCRIPTION").ToString
            txtunit.Text = dr("UNIT_NAME").ToString
            txtremaks.Text = dr("REMARKS").ToString
            txtquantity.Text = dr("QUANTITY").ToString
            txtcutremarks.Text = dr("REMARKS").ToString
        ' call list view a

            btncancel.Enabled = True
        Next
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

 
    'LOAD PRODUCTION ALREADY TRANSACT
    Public Sub ALREADYPROCESS()
        Dim mySql As String = "SELECT DISTINCT TBL_PRODUCTIONPAPER.PROD_ID AS PROD_ID" _
    & ",TBL_PAPERCUT.CUT_ID AS CUT_ID" _
    & ",TBL_PAPERCUT.CUT_NAME AS CUT_NAME " _
    & ",TBL_PAPERCUT.DESCRIPTION AS DESCRIPTION " _
    & ",TBL_UNIT.UNIT_NAME AS UNITNAME" _
    & ", TBL_PAPERCUT.REMARKS AS REMARKSPAPERCUT" _
    & ",TBL_PRODUCTIONPAPER.QUANTITY AS QUANTITY" _
    & ",TBL_PAPERROLL.PAPERROLE_ID AS PAPERROLLID" _
    & " ,TBL_PAPERROLL.PAPERNAME AS PAPERNAME " _
    & ",TBL_PAPERROLL.DESCRIPTION AS PAPERDESCRIPT" _
    & ",TBL_PAPERROLL.REMARKS AS PAPERREMARKS" _
    & ",TBL_PAPERROLL.SERIAL_CODE AS SERIALCODE  " _
      & ",TBL_PAPERROLL.HEIGHT AS HEIGHT  " _
    & " FROM TBL_PRODUCTIONPAPER " _
    & " INNER JOIN TBL_PAPERCUT ON TBL_PAPERCUT.CUT_ID =TBL_PRODUCTIONPAPER.CUT_ID " _
    & "INNER JOIN TBL_UNIT ON TBL_UNIT.UNIT_ID =TBL_PAPERCUT.UNIT_ID " _
    & "INNER JOIN TBL_PAPERROLL ON TBL_PAPERROLL.PAPERROLE_ID= TBL_PAPERCUT.PAPERROLE_ID" _
    & " WHERE TBL_PRODUCTIONPAPER.STATUS='1';"
        Dim ds As DataSet = LoadSQL(mySql)

        LVLPROD.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = LVLPROD.Items.Add(dr("PROD_ID"))
            lv.SubItems.Add(dr("QUANTITY") & "PCS")
            lv.SubItems.Add(dr("CUT_ID"))
            lv.SubItems.Add(dr("CUT_NAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("UNITNAME"))
              lv.SubItems.Add(dr("REMARKSPAPERCUT"))
            lv.SubItems.Add(dr("PAPERROLLID"))
            lv.SubItems.Add(dr("PAPERNAME"))
            lv.SubItems.Add(dr("PAPERDESCRIPT"))
            lv.SubItems.Add(dr("SERIALCODE"))
            lv.SubItems.Add(dr("HEIGHT") & "(meters)")
            lv.SubItems.Add(dr("PAPERREMARKS"))
        Next

    End Sub
    Public Sub LoadPRODUCTION()
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

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
 
    Private Sub ListView1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        cutidx = ListView1.SelectedItems(0).SubItems(0).Text
       txtpapercut.Text = ListView1.SelectedItems(0).SubItems(2).Text
        txtdescription.Text = ListView1.SelectedItems(0).SubItems(3).Text
        txtunit.Text = ListView1.SelectedItems(0).SubItems(4).Text
        txtcutremarks.Text = ListView1.SelectedItems(0).SubItems(5).Text


    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Or btnadd.Text = "&Add" Then

            Dim lv As ListViewItem = lvlproduction.Items.Add(0)
            lv.SubItems.Add(cutidx)
            lv.SubItems.Add(txtpapercut.Text)
            lv.SubItems.Add(txtdescription.Text)
            lv.SubItems.Add(txtunit.Text)

            lv.SubItems.Add(txtcutremarks.Text)
            lv.SubItems.Add(txtquantity.Text)
            txtdescription.Clear() : txtpapercut.Clear() : txtunit.Text = "" : txtcutremarks.Clear() : txtquantity.Clear()
            Exit Sub
        End If
        If btnadd.Text = "&Update" Then
            lvlproduction.Items.Clear()
            Dim lv As ListViewItem = lvlproduction.Items.Add(prodid)
            lv.SubItems.Add(cutidx)
            lv.SubItems.Add(txtpapercut.Text)
            lv.SubItems.Add(txtdescription.Text)
            lv.SubItems.Add(txtunit.Text)

            lv.SubItems.Add(txtcutremarks.Text)
            lv.SubItems.Add(txtquantity.Text)
            txtdescription.Clear() : txtpapercut.Clear() : txtunit.Text = "" : txtcutremarks.Clear() : txtquantity.Clear()

        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        If btnadd.Text = "&Add" Or btnadd.Text = "Add" Then
            savelist()
        End If

        If btnadd.Text = "&Update" Then
            For Each lv As ListViewItem In lvlproduction.Items
                Dim bnj As New production
                With bnj
                    .PRODUCTION_ID = lv.SubItems(0).Text
                    .quantity_pro = lv.SubItems(6).Text
                    .UPDATEQUANTITY()
                    lvlproduction.Items.Clear()
                    ALREADYPROCESS()
                    btnremove.Enabled = True
                    btncancel.Enabled = False
                    btnadd.Text = "&Add"
                End With
            Next
        End If
      

    End Sub
    Private Sub savelist()
        Dim msg As DialogResult = MsgBox("Do you want to save this?", MsgBoxStyle.YesNo, "Question")
        If msg = vbNo Then Exit Sub

        For Each lv As ListViewItem In lvlproduction.Items
            Dim bnj As New production
            With bnj
                .CUT_ID = lv.SubItems(1).Text
                MessageBox.Show(.CUT_ID)

                .quantity_pro = lv.SubItems(6).Text
                .statusx = "1"
           
                .SAVEPAPERCUT()
                lvlproduction.Items.Clear()
                ALREADYPROCESS()
            End With
        Next



    End Sub
    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If lvlproduction.SelectedItems.Count = 0 Then Exit Sub
        'Remove single item
        lvlproduction.Items.RemoveAt(ListView1.SelectedIndices(0))
        btnadd.Text = "&Add"
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub LVLPROD_DOUBLECLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVLPROD.DoubleClick
        Me.TabControl1.SelectedTab = Me.TabPage1
        btnadd.Text = "&Update"
        productionlistviewupdateclick()
        ListView1.Items.Clear()
        btnremove.Enabled = False
        txtpapername.Clear() : txtserial.Clear() : txtpdescription.Clear() : txtheight.Clear() : txtremaks.Clear()

    End Sub

    Private Sub LVLPROD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVLPROD.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btnremove.Enabled = True
        btncancel.Enabled = False
        btnadd.Text = "&Add"
        lvlproduction.Items.Clear()
        txtdescription.Clear() : txtpapercut.Clear() : txtunit.Text = "" : txtcutremarks.Clear() : txtquantity.Clear()

    End Sub

    Private Sub lvList_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub

    Private Sub btneditview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditview.Click
        If LVLPROD.SelectedItems.Count = 0 Then Exit Sub
        Me.TabControl1.SelectedTab = Me.TabPage1
        btnadd.Text = "&Update"
        productionlistviewupdateclick()
        ListView1.Items.Clear()
        btnremove.Enabled = False
        txtpapername.Clear() : txtserial.Clear() : txtpdescription.Clear() : txtheight.Clear() : txtremaks.Clear()
    End Sub
End Class