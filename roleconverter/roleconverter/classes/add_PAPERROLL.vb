Public Class add_PAPERROLL
    Private MainTable As String = "TBL_ADD_PAPERROLL"

    Dim mysql As String = String.Empty
    Private isLoaded As Boolean = False
#Region "Properties"
    Private _PAPERROLL_ID As Integer
    Public Property PAPERROLL_ID() As Integer
        Get
            Return _PAPERROLL_ID
        End Get
        Set(ByVal value As Integer)
            _PAPERROLL_ID = value
        End Set
    End Property

    Private _Quantity As Integer
    Public Property Quantity() As Integer
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Integer)
            _Quantity = value
        End Set
    End Property

    Private _Statuss As Integer
    Public Property Statuss() As Integer
        Get
            Return _Statuss
        End Get
        Set(ByVal value As Integer)
            _Statuss = value
        End Set
    End Property



#End Region
#Region "FUNCTION"
    Public Sub ADDquantity()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow



            .Item("PAPERROLL_ID") = _PAPERROLL_ID
            .Item("QUANTITY") = _Quantity
            .Item("STATUS") = _Statuss
           
        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)
        MessageBox.Show("Successfully SAVE")


    End Sub
#End Region


End Class
