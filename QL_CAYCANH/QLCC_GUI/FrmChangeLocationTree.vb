Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Configuration

Public Class FrmChangeLocationTree
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

    Dim table As New DataTable("Table")
    Dim index As Integer
    Public Sub FiterData(valSearch As String)
        Dim searchQuery As String = "SELECT C.ID_CAY AS '" & "ID" & "', C.TENCAY AS '" & "Tree name" & "', VT.TEN_VITRI AS '" & "Location" & "'
        FROM [CAY] C, [VITRI] VT 
        WHERE C.ID_VITRI = VT.ID_VITRI AND C.ID_VITRI = '" & Convert.ToString(cbx_Vitri_Form.SelectedValue) & "'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        dgv_from.DataSource = table
    End Sub
    Public Sub FiterData1(valSearch As String)
        Dim searchQuery As String = "SELECT C.ID_CAY AS '" & "ID" & "', C.TENCAY AS '" & "Tree name" & "', VT.TEN_VITRI AS '" & "Location" & "'
        FROM [CAY] C, [VITRI] VT 
        WHERE C.ID_VITRI = VT.ID_VITRI AND C.ID_VITRI = '" & Convert.ToString(cbx_ViTri_To.SelectedValue) & "'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        dgv_to.DataSource = table
    End Sub
    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub FrmChangeLocationTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load vi tri cay list
        'Vi tri form
        Dim command_from As New SqlCommand("SELECT * FROM [VITRI]", connection)
        Dim adapter_from As New SqlDataAdapter(command_from)
        Dim table_form As New DataTable()
        adapter_from.Fill(table_form)
        cbx_Vitri_Form.DataSource = table_form
        cbx_Vitri_Form.DisplayMember = "TEN_VITRI"
        cbx_Vitri_Form.ValueMember = "ID_VITRI"

        'Vi tri to
        Dim command_to As New SqlCommand("SELECT * FROM [VITRI]", connection)
        Dim adapter_to As New SqlDataAdapter(command_to)
        Dim table_to As New DataTable()
        adapter_to.Fill(table_to)
        cbx_ViTri_To.DataSource = table_to
        cbx_ViTri_To.DisplayMember = "TEN_VITRI"
        cbx_ViTri_To.ValueMember = "ID_VITRI"
    End Sub

    Private Sub cbx_Vitri_Form_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbx_Vitri_Form.SelectedValueChanged
        FiterData("")
    End Sub

    Private Sub cbx_ViTri_To_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbx_ViTri_To.SelectedValueChanged
        FiterData1("")
    End Sub

    Private Sub dgv_from_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_from.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = dgv_from.Rows(index)
            tbx_ID_From.Text = SelectRow.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub dgv_to_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_to.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = dgv_to.Rows(index)
            tbx_ID_To.Text = SelectRow.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub btn_from_to_Click(sender As Object, e As EventArgs) Handles btn_from_to.Click
        If (cbx_Vitri_Form.Text = cbx_ViTri_To.Text) Then
            MessageBox.Show("Conversion location is NOT the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If dgv_from.Rows(0).IsNewRow Then
            Else
                Dim updateQuery As String = "UPDATE [dbo].[CAY]
                SET [ID_CAY] = '" & tbx_ID_From.Text & "'
                ,[ID_VITRI] = '" & Convert.ToString(cbx_ViTri_To.SelectedValue) & "'
                WHERE [ID_CAY] = '" & tbx_ID_From.Text & "'"
                ExcuteQuery(updateQuery)
                MessageBox.Show("Change location's tree successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_from.Refresh()
                dgv_to.Refresh()

                'Refresh data
                FiterData("")
                FiterData1("")
            End If
        End If
    End Sub

    Private Sub btn_to_from_Click(sender As Object, e As EventArgs) Handles btn_to_from.Click
        If (cbx_Vitri_Form.Text = cbx_ViTri_To.Text) Then
            MessageBox.Show("Conversion location is NOT the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If dgv_to.Rows(0).IsNewRow Then
            Else
                Dim updateQuery As String = "UPDATE [dbo].[CAY]
            SET [ID_CAY] = '" & tbx_ID_To.Text & "'
            ,[ID_VITRI] = '" & Convert.ToString(cbx_Vitri_Form.SelectedValue) & "'
            WHERE [ID_CAY] = '" & tbx_ID_To.Text & "'"
                ExcuteQuery(updateQuery)
                MessageBox.Show("Change location's tree successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_to.Refresh()
                dgv_from.Refresh()

                'Refresh data
                FiterData("")
                FiterData1("")
            End If
        End If
    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub
End Class