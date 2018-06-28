﻿Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Configuration

Public Class FrmUpdateCay
    Private cayBus As CayBUS
    Private loaiCayBus As LoaiCayBUS
    Private vitri As ViTriCayBUS

    'Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        Dim searchQuery As String = "SELECT C.ID_CAY AS '" & "ID" & "', C.TENCAY AS '" & "Tree name" & "', L.TEN_LOAICAY AS '" & "Type" & "', VT.TEN_VITRI AS '" & "Loacation" & "', C.NGAYTRONG AS '" & "Planting date" & "'
        FROM [CAY] C, [VITRI] VT, [LOAICAY] L
        WHERE C.ID_VITRI = VT. ID_VITRI AND C.ID_LOAICAY = L.ID_LOAICAY
        AND CONCAT(C.ID_CAY, C.TENCAY, L.TEN_LOAICAY, VT.TEN_VITRI, C.NGAYTRONG) Like'%" & tbx_search.Text & "%'"

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

    Private Sub FrmUpdateCay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cayBus = New CayBUS()
        loaiCayBus = New LoaiCayBUS()
        vitri = New ViTriCayBUS()
        FiterData("")
        'connect table [LOAICAY]

        Dim command_vt As New SqlCommand("SELECT * FROM [LOAICAY]", connection)
        Dim adapter_vt As New SqlDataAdapter(command_vt)
        Dim table_vt As New DataTable()
        adapter_vt.Fill(table_vt)
        cbx_LoaiCay.DataSource = table_vt
        cbx_LoaiCay.DisplayMember = "TEN_LOAICAY"
        cbx_LoaiCay.ValueMember = "ID_LOAICAY"

        'connect table [VITRI]
        Dim command_dv As New SqlCommand("SELECT * FROM [VITRI]", connection)
        Dim adapter_dv As New SqlDataAdapter(command_dv)
        Dim table_dv As New DataTable()
        adapter_dv.Fill(table_dv)
        cbx_ViTri.DataSource = table_dv
        cbx_ViTri.DisplayMember = "TEN_VITRI"
        cbx_ViTri.ValueMember = "ID_VITRI"
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        'DELETE From [CAY] Where 
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            DataGridView1.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [CAY] WHERE [ID_CAY] = '" & tbx_IDCay.Text & "'"
            ExcuteQuery(deleteQuery)
            MessageBox.Show("Delete tree successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [dbo].[CAY]
            SET [ID_CAY] = '" & tbx_IDCay.Text & "'
            ,[TENCAY] = '" & tbx_TenCay.Text & "'
            ,[ID_LOAICAY] = '" & Convert.ToString(cbx_LoaiCay.SelectedValue) & "'
            ,[ID_VITRI] = '" & Convert.ToString(cbx_ViTri.SelectedValue) & "'
            ,[NGAYTRONG] = '" & Convert.ToString(dtp_NgayTrong.Value) & "'
            WHERE [ID_CAY] = '" & tbx_IDCay.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update tree successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDCay.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenCay.Text = SelectRow.Cells(1).Value.ToString()
            cbx_LoaiCay.Text = SelectRow.Cells(2).Value.ToString()
            cbx_ViTri.Text = SelectRow.Cells(3).Value.ToString()
            dtp_NgayTrong.Value = Convert.ToDateTime(SelectRow.Cells(4).Value.ToString())
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class