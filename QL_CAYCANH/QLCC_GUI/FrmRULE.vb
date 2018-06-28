Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.DataTable

Public Class FrmRULE
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

    Public Sub ExcuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub btn_location_Click(sender As Object, e As EventArgs) Handles btn_location.Click
        Dim frm As FrmThemViTri = New FrmThemViTri()
        frm.Show()
    End Sub

    Private Sub btn_type_Click(sender As Object, e As EventArgs) Handles btn_type.Click
        Dim frm As FrmThemLoaiCay = New FrmThemLoaiCay()
        frm.Show()
    End Sub

    Private Sub btn_unit_Click(sender As Object, e As EventArgs) Handles btn_unit.Click
        Dim frm As FrmDonVi = New FrmDonVi()
        frm.Show()
    End Sub

    Private Sub FrmRULE_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub

    Private Sub FrmRULE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load qui dinh tien toi da
        Dim command_QD As New SqlCommand("SELECT * FROM [QUIDINH]", connection)
        Dim adapter_QD As New SqlDataAdapter(command_QD)
        Dim table_QD As New DataTable()
        adapter_QD.Fill(table_QD)
        cbx_QD_Tien.DataSource = table_QD
        cbx_QD_Tien.DisplayMember = "MONEY_MAX"
        cbx_QD_Tien.ValueMember = "ID_QD"
    End Sub

    Private Sub btn_update_money_Click(sender As Object, e As EventArgs) Handles btn_update_money.Click
        If (tbx_money.Text = "") Then
            MessageBox.Show("Money is not NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim updateQuery As String = "UPDATE [QUIDINH] SET [MONEY_MAX] = '" & tbx_money.Text & "'
                                                            WHERE [ID_QD] = '" & cbx_QD_Tien.SelectedValue & "'"
            ExcuteQuery(updateQuery)
            MessageBox.Show("Update money max successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class