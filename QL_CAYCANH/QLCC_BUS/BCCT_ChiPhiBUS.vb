Imports QLCC_DAL
Imports QLCC_DTO
Imports Utility

Public Class BCCT_ChiPhiBUS
    Private BaoCaoDAL As BCCT_ChiPhiDAL
    Public Sub New()
        BaoCaoDAL = New BCCT_ChiPhiDAL()
    End Sub
    Public Sub New(connectionString As String)
        BaoCaoDAL = New BCCT_ChiPhiDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As String) As Result
        Return BaoCaoDAL.getNextID(nextID)
    End Function
End Class
