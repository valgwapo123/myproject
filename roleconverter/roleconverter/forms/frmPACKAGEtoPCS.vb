﻿Imports Microsoft.Office.Interop
Public Class frmPACKAGEtoPCS
    Dim fileName As String
    Dim tmpSavePath As String
    Private Sub frmPACKAGEtoPCS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsetpackage()
    End Sub

    Public Sub loadsetpackage()
        Dim mySql As String = "select * from TBL_SET_PACKAGE  WHERE STATUS='1' order by SET_ID"
        Dim ds As DataSet = LoadSQL(mySql)

        '   lvList.Items.Clear()
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lv As ListViewItem = lvList.Items.Add(dr("SET_ID"))
            lv.SubItems.Add(dr("PACKAGE_NAME"))
            lv.SubItems.Add(dr("DESCRIPTION"))
            lv.SubItems.Add(dr("REMARKS"))


        Next

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        ofdJeltmp.ShowDialog()

        fileName = ofdJeltmp.FileName

        If fileName = "" Then Exit Sub
        lblPath.Text = fileName

    End Sub

    Private Sub convertation()
        If lblPath.Text = "File not yet" Then Exit Sub
        'Load Excel
        Dim oXL As New Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        Dim lineNum As Integer = 0

        'SAVE
        Dim oXL1 As New Excel.Application
        Dim oWB1 As Excel.Workbook
        Dim oSheet1 As Excel.Worksheet
        oWB1 = oXL.Workbooks.Open(Application.StartupPath & "/tmp/Template.xlsx")
        oSheet1 = oWB1.Worksheets(1)

        oWB = oXL.Workbooks.Open(fileName)
        oSheet = oWB.Worksheets(1)



        Dim MaxColumn As Integer = oSheet.Cells(1, oSheet.Columns.Count).End(Excel.XlDirection.xlToLeft).column
        Dim MaxEntries As Integer = oSheet.Cells(oSheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).row

        Dim checkHeaders(MaxColumn) As String
        For cnt As Integer = 0 To MaxColumn - 1
            checkHeaders(cnt) = oSheet.Cells(1, cnt + 1).value
        Next : checkHeaders(MaxColumn) = oWB.Worksheets(1).name


        For cnt = 2 To MaxEntries
         
            Dim bnj As New conversion
            With bnj

                .packageID = oSheet.Cells(cnt, 1).value
                .PAPERCUT_ID = oSheet.Cells(cnt, 6).value
                .PACKAGE_PCS = oSheet.Cells(cnt, 10).value

                .ADDCONVERTION()

               
            End With

        Next


        oSheet = Nothing
        oWB = Nothing
        oXL.Quit()
        oXL = Nothing

        MsgBox("Completed")
         



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        convertation()
    End Sub
End Class