﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLCC_DTO
Imports Utility

Public Class LoaiCayDAL
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
        query &= "SELECT TOP 1 [ID_LOAICAY] "
        query &= "FROM [LOAICAY] "
        query &= "ORDER BY [ID_LOAICAY] DESC "

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
                            msOnDB = reader("ID_LOAICAY")
                        End While
                    End If

                    'Neu trong database rong
                    If (msOnDB = "") Then
                        nextID = "TP01"
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
                        nextID = "TP" + id.ToString()
                        System.Console.WriteLine(nextID)
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Failed type's tree code creation", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(lcay As LoaiCayDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LOAICAY] ([ID_LOAICAY], [TEN_LOAICAY])"
        query &= "VALUES (@ID_LOAICAY,@TEN_LOAICAY)"

        'get MSHS
        Dim nextID = "1"
        getNextID(nextID)
        lcay.MS_LoaiCay = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LOAICAY", lcay.MS_LoaiCay)
                    .Parameters.AddWithValue("@TEN_LOAICAY", lcay.TenLoai_Cay)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "More Type's tree failed", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(lcay As LoaiCayDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LOAICAY] SET"
        query &= " [TEN_LOAICAY] = @TEN_LOAICAY "
        query &= "WHERE "
        query &= " [ID_LOAICAY] = @ID_LOAICAY "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LOAICAY", lcay.MS_LoaiCay)
                    .Parameters.AddWithValue("@TEN_LOAICAY", lcay.TenLoai_Cay)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loai cay sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listLoaiCay As List(Of LoaiCayDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [ID_LOAICAY], [TEN_LOAICAY]"
        query &= " FROM [LOAICAY]"


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
                    If reader.HasRows = True Then
                        listLoaiCay.Clear()
                        While reader.Read()
                            listLoaiCay.Add(New LoaiCayDTO(reader("ID_LOAICAY"), reader("TEN_LOAICAY")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loai cay sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maLoai As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [LOAICAY] "
        query &= " WHERE "
        query &= " [ID_LOAICAY] = @ID_LOAICAY "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID_LOAICAY", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loai cay không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
