Public Class conversion
    Dim tbl As String = "TBL_CONVERTION"
    Private MainTable As String = "TBL_CONVERSION"
    Dim subtbl As String = "TBL_SET_PACKAGE"
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

    Private _packageNAME As Integer
    Public Property packageNAME() As Integer
        Get
            Return _packageNAME
        End Get
        Set(ByVal value As Integer)
            _packageNAME = value
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




#End Region
#Region "FUNCTION"


    Public Sub ADDCONVERTION()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow



            .Item("PACKAGE_ID") = _packageID
            .Item("PAPERCUT_ID") = _PAPERCUT_ID
            .Item("PACKAGE_PCS") = _PACKAGE_PCS

        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)
        MessageBox.Show("Successfully SAVE")


    End Sub
#End Region

End Class
