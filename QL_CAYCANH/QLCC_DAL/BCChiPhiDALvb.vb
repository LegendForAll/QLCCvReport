Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class BCChiPhiDALvb
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As String) As Result

        nextID = String.Empty
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ID_BCCHIPHI] "
        query &= "FROM [BCCHIPHI] "
        query &= "ORDER BY [ID_BCCHIPHI] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("ID_BCCHIPHI")
                        End While
                    End If

                    'Neu trong database rong
                    If (msOnDB = "") Then
                        nextID = "CP01"
                        System.Console.WriteLine(nextID)
                    End If
                    'Neu trong database co du lieu
                    If (msOnDB <> "") Then

                        Dim tmp As String
                        Dim id As Integer
                        tmp = msOnDB.Substring(2)
                        id = Convert.ToInt32(tmp)
                        id += 1
                        If id > 9999999 Then
                            id = 1
                        End If
                        nextID = "CP" + id.ToString()
                        System.Console.WriteLine(nextID)
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Failed cost report code creation", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(bc As BCChiPhiDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [BCCHIPHI] ([ID_BCCHIPHI], [TG_BAOCAO])"
        query &= "VALUES (@ID_BCCHIPHI,@TG_BAOCAO)"

        'get MSHS
        Dim nextID = "1"
        getNextID(nextID)
        bc.MS_BCChiPhi = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_BCCHIPHI", bc.MS_BCChiPhi)
                    .Parameters.AddWithValue("@TG_BAOCAO", bc.TG_BaoCao)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "More cost report failed", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
