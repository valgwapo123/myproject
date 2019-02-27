Public Class papercut

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
#End Region
End Class
