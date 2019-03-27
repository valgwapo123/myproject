Public Class conversion
    Dim tbl As String = "TBL_CONVERTION"
    Private MainTable As String = "TBL_SET_PACKAGE"
    Dim subtbl As String = "TBL_CUT_PAPER"
    Dim mysql As String = String.Empty


#Region "Propertiers  and Variables"
    Private _packageID As Integer
    Public Property packageID() As Integer
        Get
            Return _packageID
        End Get
        Set(ByVal value As Integer)
            _packageID = value
        End Set
    End Property

    Private _packageNAME As String
    Public Property packageNAME() As String
        Get
            Return _packageNAME
        End Get
        Set(ByVal value As String)
            _packageNAME = value
        End Set
    End Property
    Private _packagedescription As String
    Public Property packagedescription() As String
        Get
            Return _packagedescription
        End Get
        Set(ByVal value As String)
            _packagedescription = value
        End Set
    End Property
    Private _packageremarks As String
    Public Property packageremarks() As String
        Get
            Return _packageremarks
        End Get
        Set(ByVal value As String)
            _packageremarks = value
        End Set
    End Property

    Private _PAPERCUT_ID As Integer
    Public Property PAPERCUT_ID() As Integer
        Get
            Return _PAPERCUT_ID
        End Get
        Set(ByVal value As Integer)
            _PAPERCUT_ID = value
        End Set
    End Property
    Private _PACKAGE_PCS As Integer
    Public Property PACKAGE_PCS() As Integer
        Get
            Return _PACKAGE_PCS
        End Get
        Set(ByVal value As Integer)
            _PACKAGE_PCS = value
        End Set
    End Property

    Private _package_status As Integer
    Public Property package_status() As Integer
        Get
            Return _package_status
        End Get
        Set(ByVal value As Integer)
            _package_status = value
        End Set
    End Property


    Private _cut_id As Integer
    Public Property cut_id() As Integer
        Get
            Return _cut_id
        End Get
        Set(ByVal value As Integer)
            _cut_id = value
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

    Private _CUT_DESCIPTION As String
    Public Property CUT_DESCIPTION() As String
        Get
            Return _CUT_DESCIPTION
        End Get
        Set(ByVal value As String)
            _CUT_DESCIPTION = value
        End Set
    End Property

    Private _CUT_REMARKS As String
    Public Property CUT_REMARKS() As String
        Get
            Return _CUT_REMARKS
        End Get
        Set(ByVal value As String)
            _CUT_REMARKS = value
        End Set
    End Property

    Private _CUT_STATUS As Integer
    Public Property CUT_STATUS() As Integer
        Get
            Return _CUT_STATUS
        End Get
        Set(ByVal value As Integer)
            _CUT_STATUS = value
        End Set
    End Property


    Private _cut_width As Integer
    Public Property cut_width() As Integer
        Get
            Return _CUT_STATUS
        End Get
        Set(ByVal value As Integer)
            _cut_width = value
        End Set
    End Property

    Private _cut_height As Integer
    Public Property cut_height() As Integer
        Get
            Return _cut_height
        End Get
        Set(ByVal value As Integer)
            _cut_height = value
        End Set
    End Property

#End Region
#Region "FUNCTION"


    Public Sub ADDCONVERTION()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow

          
           
            .Item("PACKAGE_BARCODE") = _packageID
            .Item("PACKAGE_NAME") = _packageNAME
            .Item("DESCRIPTION") = _packagedescription
            .Item("REMARKS") = _packageremarks
            .Item("STATUS") = _package_status

        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)
     

     
    End Sub

    Public Sub savepepercut()
        Dim mySql1 As String = String.Format("SELECT * FROM {0}", subtbl)
        Dim ds1 As DataSet = LoadSQL(mySql1, subtbl)

        Dim dsNewRow1 As DataRow
        dsNewRow1 = ds1.Tables(subtbl).NewRow
        With dsNewRow1



            .Item("CUT_TYPE_ID") = _cut_id
            .Item("CUT_NAME") = _CUT_NAME
            .Item("CUT_DESCRIPTION") = _CUT_DESCIPTION
            .Item("CUT_REMARKS") = _CUT_REMARKS
            .Item("WIDTH") = _cut_width
            .Item("HEIGHT") = _cut_height
            .Item("CUT_STATUS") = _CUT_STATUS
        End With
        ds1.Tables(subtbl).Rows.Add(dsNewRow1)
        connection.SaveEntry(ds1)

    End Sub
#End Region

End Class
