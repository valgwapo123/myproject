Public Class papercut
    Private MainTable As String = "TBL_PAPERCUT"
   Dim mysql As String = String.Empty

#Region "Properties"
    Private _PAPER_ID As String
    Public Property PAPER_ID() As String
        Get
            Return _PAPER_ID
        End Get
        Set(ByVal value As String)
            _PAPER_ID = value
        End Set
    End Property

    Private _CUT_NAME As String
    Public Property CUT_NAME() As String
        Get
            Return _CUT_NAME
        End Get
        Set(ByVal value As String)
            _CUT_NAME = value
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

    Private _CUT_ID As String
    Public Property CUT_ID() As String
        Get
            Return _CUT_ID
        End Get
        Set(ByVal value As String)
            _CUT_ID = value
        End Set
    End Property
    Private _unit_id As Integer
    Public Property unit_id() As Integer
        Get
            Return _unit_id
        End Get
        Set(ByVal value As Integer)
            _unit_id = value
        End Set
    End Property
    Private _remarks_papaercut As String
    Public Property remarks_papaercut() As String
        Get
            Return _remarks_papaercut
        End Get
        Set(ByVal value As String)
            _remarks_papaercut = value
        End Set
    End Property
    Private _statusx As String
    Public Property statusx() As String
        Get
            Return _statusx
        End Get
        Set(ByVal value As String)
            _statusx = value
        End Set
    End Property
#End Region

#Region "FUNCTION"
    Public Sub SAVEPRODUCTION()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow



            .Item("PAPERROLE_ID") = _PAPER_ID
            .Item("CUT_NAME") = _CUT_NAME
            .Item("DESCRIPTION") = _DESCRIPTION
            .Item("UNIT_ID") = _unit_id
            .Item("REMARKS") = _remarks_papaercut
            .Item("STATUS") = _statusx
        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)
        MessageBox.Show("Successfully SAVE")


    End Sub

    Public Sub updatepapercut()
        mysql = "select * from " & MainTable & " where CUT_ID =" & CUT_ID
        Dim ds As DataSet = LoadSQL(mysql, MainTable)

        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("CUT_NAME") = _CUT_NAME
                .Item("DESCRIPTION") = _DESCRIPTION
                .Item("UNIT_ID") = _unit_id
                .Item("REMARKS") = _remarks_papaercut


            End With
            connection.SaveEntry(ds, False)

            MessageBox.Show("UPDATED SUCCESSFULLY")



        End If

    End Sub
#End Region


End Class
