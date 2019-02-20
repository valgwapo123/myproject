Public Class paperunit
    Private MainTable As String = "TBL_UNIT"


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
#End Region


#Region "FUnction"

    Public Sub SaveCat()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow

            .Item("UNIT_ID") = _Unit_ID
            .Item("UNIT_NAME") = _UNIT_NAME

        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)


    End Sub
#End Region

End Class
