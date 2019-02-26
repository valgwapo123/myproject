Public Class paperroll
    Dim paperid As String
    Private MainTable As String = "TBL_PAPERROLL"
    Dim tbl As String = "TBL_PAPERROLL"
    Dim mysql As String = String.Empty
#Region "Properties"
    Private _PAPER_ID As String
    Public Property PAPER_ID() As Integer
        Get
            Return _PAPER_ID
        End Get
        Set(ByVal value As Integer)
            _PAPER_ID = value
        End Set
    End Property
    Private _PAPERNAME As String
    Public Property PAPERNAME() As String
        Get
            Return _PAPERNAME
        End Get
        Set(ByVal value As String)
            _PAPERNAME = value
        End Set
    End Property

    Private _DESCRIPTION As String
    Public Property DESCRIPTION() As String
        Get
            Return _DESCRIPTION
        End Get
        Set(ByVal value As String)
            _DESCRIPTION = value
        End Set
    End Property
    Private _REMARKS As String
    Public Property REMARKS() As String
        Get
            Return _REMARKS
        End Get
        Set(ByVal value As String)
            _REMARKS = value
        End Set
    End Property

    Private _STATUS As String
    Public Property STATUS() As String
        Get
            Return _STATUS
        End Get
        Set(ByVal value As String)
            _STATUS = value
        End Set
    End Property
    Private _unit_id As String
    Public Property unit_id() As String
        Get
            Return _unit_id
        End Get
        Set(ByVal value As String)
            _STATUS = value
        End Set
    End Property
#End Region

#Region "FUnction"

    Public Sub SaveCat()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow

            .Item("PAPERNAME") = _PAPERNAME
            .Item("DESCRIPTION") = _DESCRIPTION
            .Item("REMARKS") = _REMARKS
            .Item("STATUS") = _STATUS
        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)


    End Sub
    Friend Sub loadbyRow(ByVal dr As DataRow)
        With dr
            _PAPER_ID = .Item("PAPERROLE_ID")
            _PAPERNAME = .Item("PAPERNAME")
            _DESCRIPTION = .Item("DESCRIPTION")
            _REMARKS = .Item("REMARKS")
            _STATUS = .Item("STATUS")

        End With
    End Sub
    Public Sub Updatepaperoll()

        mysql = "select * from " & tbl & " where PAPERROLE_ID =" & PAPER_ID
        Dim ds As DataSet = LoadSQL(mysql, tbl)

        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("PAPERNAME") = _PAPERNAME
                .Item("DESCRIPTION") = _DESCRIPTION
                .Item("REMARKS") = REMARKS

            End With
            connection.SaveEntry(ds, False)

            MessageBox.Show("updated Successfully ")

        Else
           
        End If

   

    End Sub
    Public Sub Load_categoryxxx(ByVal PAPERROLEID As Integer)
        Try
            mysql = "select * from " & tbl & ""
            Dim ds As DataSet = LoadSQL(mysql, tbl)

            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("barcode not found")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                loadbyRow(dr)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Friend Sub load_category()
        mysql = "select * from " & tbl & ""
        Dim ds As DataSet = LoadSQL(mysql, tbl)

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("barcode not found")
            Exit Sub
        End If

        For Each dr As DataRow In ds.Tables(0).Rows
            loadbyRow(dr)

        Next
    End Sub
    Public Sub savepaperole()

        mysql = "select * from " & tbl
        Dim ds As DataSet = LoadSQL(mysql, tbl)

        Dim dsnewrow As DataRow
        dsnewrow = ds.Tables(0).NewRow
        With dsnewrow
            .Item("PAPERNAME") = _PAPERNAME
            .Item("DESCRIPTION") = _DESCRIPTION
            .Item("REMARKS") = _REMARKS
            .Item("STATUS") = _STATUS
        End With
        ds.Tables(0).Rows.Add(dsnewrow)
        connection.SaveEntry(ds)
    End Sub

#End Region

   

End Class
