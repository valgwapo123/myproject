Public Class paperunit
    Private MainTable As String = "TBL_UNIT"
    Dim mysql As String = String.Empty
    Dim tbl As String = "TBL_UNIT"
#Region "Properties"
    Private _Unit_ID As String
    Public Property Unit_ID() As String
        Get
            Return _Unit_ID
        End Get
        Set(ByVal value As String)
            _Unit_ID = value
        End Set
    End Property

    Private _UNIT_NAME As String
    Public Property UNIT_NAME() As String
        Get
            Return _UNIT_NAME
        End Get
        Set(ByVal value As String)
            _UNIT_NAME = value
        End Set
    End Property
    Private _unit_width As Integer

    Public Property unit_width() As Integer
        Get
            Return _unit_width
        End Get
        Set(ByVal value As Integer)
            _unit_width = value
        End Set
    End Property

    Private _unit_height As Integer

    Public Property unit_height() As Integer
        Get
            Return _unit_height
        End Get
        Set(ByVal value As Integer)
            _unit_height = value
        End Set
    End Property
    Private _unit_status As Integer
    Public Property unit_status() As Integer
        Get
            Return _unit_status
        End Get
        Set(ByVal value As Integer)
            _unit_status = value
        End Set
    End Property
#End Region


#Region "FUnction"

    Public Sub Saveunit()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow


            .Item("UNIT_NAME") = _UNIT_NAME

            .Item("UNIT_WIDTH") = _unit_width
            .Item("UNIT_HEIGHT") = _unit_height
            .Item("STATUS") = _unit_status

        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)


    End Sub
    Public Sub load_Barcodes(ByVal idx As Integer)
        mysql = "select * from " & tbl & "  where UNIT_ID =" & idx
        Dim ds As DataSet = LoadSQL(mysql, tbl)

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("barcode not found")
            Exit Sub
        End If

        For Each dr As DataRow In ds.Tables(0).Rows
            loadbyRow(dr)
        Next
    End Sub

    Friend Sub loadbyRow(ByVal dr As DataRow)
        With dr
            _Unit_ID = .Item("Unit_ID")
            _UNIT_NAME = .Item("UNIT_NAME")
            _unit_width = .Item("UNIT_WIDTH")
            _unit_height = .Item("UNIT_HEIGHT")
        End With
    End Sub

    Public Sub Updatebarcode()
        mysql = "select * from " & tbl & " where Unit_ID =" & _Unit_ID
        Dim ds As DataSet = LoadSQL(mysql, tbl)

        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("UNIT_NAME") = _UNIT_NAME
                .Item("UNIT_WIDTH") = _unit_width
                .Item("UNIT_HEIGHT") = _unit_height
            End With
            connection.SaveEntry(ds, False)



   
        End If

    End Sub
#End Region

End Class
