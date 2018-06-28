﻿Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Configuration

Public Class FrmUpdateDonVi
    Private DonViBus As DonViBUS
    'Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

    Dim table As New DataTable("Table")
    Dim index As Integer

    Public Sub FiterData(valSearch As String)
        'Dim searchQuery As String = "SELECT * FROM [VATTU] WHERE CONCAT (ID_VATTU,TEN_VATTU,ID_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim searchQuery As String = "SELECT ID_DONVI AS '" & "ID" & "', TEN_DONVI AS '" & "Unit name" & "' FROM [DONVI] WHERE CONCAT (ID_DONVI,TEN_DONVI) LIKE'%" & tbx_search.Text & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub
    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [DONVI] SET [ID_DONVI] = '" & tbx_IDDonVi.Text & "'
                                                            ,[TEN_DONVI] = '" & tbx_TenDonVi.Text & "'
                                                            WHERE [ID_DONVI] = '" & tbx_IDDonVi.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update don vi thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub FrmUpdateDonVi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FiterData("")
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDDonVi.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenDonVi.Text = SelectRow.Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [DONVI] SET [ID_DONVI] = '" & tbx_IDDonVi.Text & "'
                                                            ,[TEN_DONVI] = '" & "NA" & "'
                                                            WHERE [ID_DONVI] = '" & tbx_IDDonVi.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Xoa ten don vi thành công. Vui long cap nhat lai ten don vi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub
End Class