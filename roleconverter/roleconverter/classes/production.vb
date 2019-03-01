Public Class production
    Private MainTable As String = "TBL_PRODUCTIONPAPER"
    Dim mysql As String = String.Empty

#Region "Properties"



    Private _CUT_ID As String
    Public Property CUT_ID() As String
        Get
            Return _CUT_ID
        End Get
        Set(ByVal value As String)
            _CUT_ID = value
        End Set
    End Property
    Private _quantity_pro As Integer
    Public Property quantity_pro() As Integer
        Get
            Return _quantity_pro
        End Get
        Set(ByVal value As Integer)
            _quantity_pro = value
        End Set
    End Property
    Private _CREATED_DATE As String
    Public Property CREATED_DATE() As String
        Get
            Return _CREATED_DATE
        End Get
        Set(ByVal value As String)
            _CREATED_DATE = value
        End Set
    End Property
    Private _CREATED_TIME As Date
    Public Property CREATED_TIME() As Date
        Get
            Return _CREATED_TIME
        End Get
        Set(ByVal value As Date)
            _CREATED_TIME = value
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
    Public Sub SAVEPAPERCUT()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow



            .Item("CUT_ID") = _CUT_ID
            .Item("QUANTITY") = _quantity_pro
            .Item("STATUS") = _statusx
        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)
        MessageBox.Show("Successfully SAVE")
  

    End Sub
#End Region

End Class
