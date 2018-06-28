﻿Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmUpdatePhieuMuaVT
    Private phieumuaBus As PhieuMua_VTBUS
    Private phieumuaCTBus As PhieuMuaVT_CTBUS
    'Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        Dim searchQuery As String = "SELECT P.ID_PHIEUMUA_CT,P.ID_PHIEUMUA_VT,P.DIACHIMUA,P.SOLUONGMUA,P.SOTIEN,P.ID_VATTU,VT.TEN_VATTU 
        FROM [PHIEUMUA_VTCT] P,[VATTU] VT WHERE P.ID_VATTU = VT.ID_VATTU
        AND CONCAT (P.ID_PHIEUMUA_CT,P.ID_PHIEUMUA_VT,P.DIACHIMUA,P.SOLUONGMUA,P.SOTIEN,VT.TEN_VATTU) LIKE'%" & tbx_search.Text & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView2.DataSource = table
    End Sub
    Public Sub FiterData1(valSearch As String)
        Dim searchQuery As String = "SELECT * FROM [PHIEUMUA_VT] "
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

    Private Sub FrmUpdatePhieuMuaVT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieumuaBus = New PhieuMua_VTBUS()
        phieumuaCTBus = New PhieuMuaVT_CTBUS()

        FiterData("")
        FiterData1("")
        'connect table [VATTU]

        Dim command_vt As New SqlCommand("SELECT * FROM [VATTU]", connection)
        Dim adapter_vt As New SqlDataAdapter(command_vt)
        Dim table_vt As New DataTable()
        adapter_vt.Fill(table_vt)
        cbx_TenVatTu.DataSource = table_vt
        cbx_TenVatTu.DisplayMember = "TEN_VATTU"
        cbx_TenVatTu.ValueMember = "ID_VATTU"

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData(tbx_search.Text)
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData(tbx_search.Text)
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If DataGridView2.Rows(0).IsNewRow Then
        Else
            DataGridView2.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [PHIEUMUA_VTCT] WHERE [ID_PHIEUMUA_CT] = '" & tbx_IDPhieuCT.Text & "'"
            ExcuteQuery(deleteQuery)
            MessageBox.Show("Delete offers detail Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView2.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [dbo].[PHIEUMUA_VTCT]
                                            SET [ID_PHIEUMUA_CT] = '" & tbx_IDPhieuCT.Text & "'
                                            ,[ID_PHIEUMUA_VT] = '" & tbx_IDPhieu.Text & "'
                                            ,[DIACHIMUA] = '" & tbx_diachi.Text & "'
                                            ,[SOLUONGMUA] = '" & Convert.ToString(ud_SoluongMua.Value) & "'
                                            ,[SOTIEN] = '" & tbx_tien.Text & "'
                                            ,[ID_VATTU] = '" & cbx_TenVatTu.SelectedValue & "'
                                            WHERE [ID_PHIEUMUA_CT] = '" & tbx_IDPhieuCT.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update offers detail Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView2.Rows(index)
            tbx_IDPhieuCT.Text = SelectRow.Cells(0).Value.ToString()
            tbx_diachi.Text = SelectRow.Cells(2).Value.ToString()
            ud_SoluongMua.Value = SelectRow.Cells(3).Value.ToString()
            tbx_tien.Text = SelectRow.Cells(4).Value.ToString()
            cbx_TenVatTu.Text = SelectRow.Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDPhieu.Text = SelectRow.Cells(0).Value.ToString()
            dtp_TGMua.Value = Convert.ToDateTime(SelectRow.Cells(1).Value.ToString())
        End If
    End Sub

    Private Sub btn_del_offers_Click(sender As Object, e As EventArgs) Handles btn_del_offers.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            DataGridView1.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [PHIEUMUA_VT] WHERE [ID_PHIEUMUA_VT] = '" & tbx_IDPhieu.Text & "'"
            ExcuteQuery(deleteQuery)
            Dim deleteQuery1 As String = "DELETE FROM [PHIEUMUA_VTCT] WHERE [ID_PHIEUMUA_VT] = '" & tbx_IDPhieu.Text & "'"
            ExcuteQuery(deleteQuery1)

            MessageBox.Show("Delete offers Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData1("")
            FiterData("")
        End If
    End Sub
End Class