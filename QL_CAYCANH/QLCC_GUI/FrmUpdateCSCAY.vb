Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.DataTable

Public Class FrmUpdateCSCAY
    Dim table As New DataTable("Table")
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
    Dim index As Integer

    Public Sub FiterData(valSearch As String)
        Dim searchQuery As String = "SELECT CS.ID_CHAMSOC AS '" & "ID" & "', CS.TG_CHAMSOC AS '" & "Time" & "', C.TENCAY AS '" & "Tree name" & "', V.TEN_VATTU AS '" & "Supplies" & "'
        ,CS.SL_CHAMSOC AS '" & "Number" & "', CS.TT_CAY AS '" & "Status" & "', CS.GHICHU AS '" & "Note" & "'
        FROM [CHAMSOC_CAY] CS,  [VATTU] V, [CAY] C
        WHERE CS.ID_CAY=C.ID_CAY AND CS.ID_VATTU=V.ID_VATTU
        AND CONCAT (CS.ID_CHAMSOC, CS.TG_CHAMSOC, C.TENCAY, V.TEN_VATTU, CS.TT_CAY, CS.GHICHU) LIKE'%" & tbx_search.Text & "%'"
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
    Private Sub FrmUpdateCSCAY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FiterData("")

        'connect table [VATTU]

        Dim command As New SqlCommand("SELECT * FROM [VATTU]", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        cbx_vattu.DataSource = table
        cbx_vattu.DisplayMember = "TEN_VATTU"
        cbx_vattu.ValueMember = "ID_VATTU"
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (Index >= 0) Then
            SelectRow = DataGridView1.Rows(Index)
            tbx_IDCS.Text = SelectRow.Cells(0).Value.ToString()
            dtp_TGCham.Value = Convert.ToDateTime(SelectRow.Cells(1).Value.ToString())
            tbx_TenCay.Text = SelectRow.Cells(2).Value.ToString()
            cbx_vattu.Text = SelectRow.Cells(3).Value.ToString()
            Ud_soluongCS.Value = SelectRow.Cells(4).Value.ToString()
            cbx_tinhtrang.Text = SelectRow.Cells(5).Value.ToString()
            cbx_GhiChu.Text = SelectRow.Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub tbx_search_TextChanged(sender As Object, e As EventArgs) Handles tbx_search.TextChanged
        FiterData("")
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        FiterData("")
    End Sub

    Private Sub btn_de_Click(sender As Object, e As EventArgs) Handles btn_de.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            DataGridView1.Rows.RemoveAt(index)
            Dim deleteQuery As String = "DELETE FROM [CHAMSOC_CAY] WHERE [ID_CHAMSOC] = '" & tbx_IDCS.Text & "'"
            ExcuteQuery(deleteQuery)
            MessageBox.Show("Delete care of tree successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If DataGridView1.Rows(0).IsNewRow Then
        Else
            Dim updateQuery As String = "UPDATE [CHAMSOC_CAY]
            SET [ID_CHAMSOC] = '" & tbx_IDCS.Text & "'
            ,[ID_VATTU] = '" & Convert.ToString(cbx_vattu.SelectedValue) & "'
            ,[SL_CHAMSOC] = '" & Convert.ToString(Ud_soluongCS.Value) & "'
            ,[TT_CAY] = '" & cbx_tinhtrang.Text & "'
            ,[GHICHU] = '" & cbx_GhiChu.Text & "'
            WHERE [ID_CHAMSOC] = '" & tbx_IDCS.Text & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update care of tree successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Refresh()
            FiterData("")
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class