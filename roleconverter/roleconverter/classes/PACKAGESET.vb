Public Class PACKAGESET

    Private MainTable As String = "TBL_SET_PACKAGE"
    Dim mysql As String = String.Empty
    Private isLoaded As Boolean = False
   
#Region "Properties"
    Private _SET_ID As Integer
    Public Property SET_ID() As Integer
        Get
            Return _SET_ID
        End Get
        Set(ByVal value As Integer)
            _SET_ID = value
        End Set
    End Property

    Private _PACKAGE_NAME As String
    Public Property PACKAGE_NAME() As String
        Get
            Return _PACKAGE_NAME
        End Get
        Set(ByVal value As String)
            _PACKAGE_NAME = value
        End Set
    End Property
    Private _Remarks As String
    Public Property Remarks() As String
        Get
            Return _Remarks
        End Get
        Set(ByVal value As String)
            _Remarks = value
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
    Private _STATUSS As String
    Public Property STATUSS() As String
        Get
            Return _STATUSS
        End Get
        Set(ByVal value As String)
            _STATUSS = value
        End Set
    End Property
#End Region




#Region "FUNCTION"

    Public Sub LoadCat(ByVal id As Integer)
        If isLoaded Then Exit Sub

        Dim mySql As String = String.Format("SELECT * FROM {0} WHERE SET_ID = '{1}'", MainTable, id)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        If ds.Tables(MainTable).Rows.Count <= 0 Then
            MsgBox("Unable to load category", MsgBoxStyle.Critical)
            Exit Sub
        End If



        isLoaded = True
    End Sub
    Public Sub SAVEPACKAGESET()
        Dim mySql As String = String.Format("SELECT * FROM {0}", MainTable)
        Dim ds As DataSet = LoadSQL(mySql, MainTable)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(MainTable).NewRow
        With dsNewRow




            .Item("PACKAGE_NAME") = _PACKAGE_NAME
            .Item("DESCRIPTION") = _DESCRIPTION
            .Item("REMARKS") = _Remarks
            .Item("STATUS") = _STATUSS


        End With
        ds.Tables(MainTable).Rows.Add(dsNewRow)
        connection.SaveEntry(ds)



    End Sub
    Public Sub UpdatePACKAGE_SET()
        mysql = "select * from " & MainTable & " where SET_ID =" & _SET_ID
        Dim ds As DataSet = LoadSQL(mysql, MainTable)

        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)

                .Item("PACKAGE_NAME") = _PACKAGE_NAME
                .Item("DESCRIPTION") = _DESCRIPTION
                .Item("REMARKS") = _Remarks
            End With
            connection.SaveEntry(ds, False)




        End If

    End Sub
#End Region

End Class
