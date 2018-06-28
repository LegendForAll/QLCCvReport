﻿Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Configuration

Public Class FrmUpdateLoaiCay
    Private LoaiCayBus As LoaiCayBUS
    'Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)

        Dim searchQuery As String = "SELECT ID_LOAICAY AS '" & "ID Type" & "',TEN_LOAICAY AS '" & "Type name" & "' FROM [LOAICAY] WHERE CONCAT (ID_LOAICAY,TEN_LOAICAY) LIKE'%" & tbx_search.Text & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = table


    End Sub
    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub FrmUpdateLoaiCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FiterData("")
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [LOAICAY] SET [ID_LOAICAY] = '" & tbx_IDLoaiCay.Text & "'
                                                            ,[TEN_LOAICAY] = '" & tbx_TenLoai.Text & "'
                                                            WHERE [ID_LOAICAY] = '" & tbx_IDLoaiCay.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update type's tree successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDLoaiCay.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenLoai.Text = SelectRow.Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [LOAICAY] SET [ID_LOAICAY] = '" & tbx_IDLoaiCay.Text & "'
                                                            ,[TEN_LOAICAY] = '" & "NA" & "'
                                                            WHERE [ID_LOAICAY] = '" & tbx_IDLoaiCay.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Delete type's tree successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub
End Class