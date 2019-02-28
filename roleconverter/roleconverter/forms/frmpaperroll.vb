Public Class frmpaperroll
    Dim SelectedCat As paperroll
    Dim tmpcat As paperroll
    Friend paperrollid
    Dim tbl As String = "TBL_PAPERROLL"
    Dim mysql As String = String.Empty
    Private Sub frmpaperroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadClass()
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
       

        If lvList.SelectedItems.Count <= 0 Then Exit Sub

        Dim PaperrollID As Integer
        PaperrollID = lvList.FocusedItem.Text
        Console.WriteLine("Paperroll ID: " & PaperrollID)

        tmpcat = New paperroll
        tmpcat.LoadCat(PaperrollID)
        'frmpaperrole.paperrollid = PaperrollID
        frmpaperrole.LoadClass(PaperrollID)
  

        frmpaperrole.Show()


        frmpaperrole.Enabled = True

        frmpaperrole.Focus()

       

        Me.Close()
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