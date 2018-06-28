Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.DataTable

Public Class Form1
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

    'Move header form
    Dim flag As Boolean
    Dim x, y As Integer

    Private Sub Panel_header_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_header.MouseMove
        If (flag = True) Then
            Me.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y)
        End If
    End Sub

    Private Sub Panel_header_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_header.MouseUp
        flag = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Application.Exit()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

    End Sub

    Private Sub btn_treeMenu_Click(sender As Object, e As EventArgs) Handles btn_treeMenu.Click
        Dim frm As FrmManageTREE = New FrmManageTREE()
        frm.Show()
    End Sub

    Private Sub btn_suppliesMenu_Click(sender As Object, e As EventArgs) Handles btn_suppliesMenu.Click
        Dim frm As FrmManageSUPPLIES = New FrmManageSUPPLIES()
        frm.Show()
    End Sub

    Private Sub btn_cost_Click(sender As Object, e As EventArgs) Handles btn_cost.Click
        Dim frm As FrmBaoCaoCP = New FrmBaoCaoCP()
        frm.Show()
    End Sub

    Private Sub btn_manage_Click(sender As Object, e As EventArgs) Handles btn_manage.Click
        toolbar_manage.Enabled = True
        toolbar_report.Enabled = False
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        toolbar_report.Enabled = True
        toolbar_manage.Enabled = False
    End Sub



    Private Sub btn_Up_System_Click(sender As Object, e As EventArgs) Handles btn_Up_System.Click

        'Update count tree
        Dim Query As String = "SELECT COUNT(ID_CAY) FROM [CAY] "
        connection.Open()
        Dim Command As New System.Data.SqlClient.SqlCommand(Query, connection)
        Dim Count As Integer = Command.ExecuteScalar()
        btn_Num_tree.Text = Convert.ToString(Count)
        connection.Close()

        'Update count vat tu
        Dim Query_VT As String = "SELECT COUNT(ID_VATTU) FROM [VATTU] "
        connection.Open()
        Dim Command_VT As New System.Data.SqlClient.SqlCommand(Query_VT, connection)
        Dim Count_VT As Integer = Command_VT.ExecuteScalar()
        btn_Num_VT.Text = Convert.ToString(Count_VT)
        connection.Close()

        'Update count report
        Dim Query_BC As String = "SELECT COUNT(ID_BCTT_CAY) FROM [BCTINHTRANG_CAY] "
        connection.Open()
        Dim Command_BC As New System.Data.SqlClient.SqlCommand(Query_BC, connection)
        Dim Count_BC As Integer = Command_BC.ExecuteScalar()
        btn_Num_report.Text = Convert.ToString(Count_BC)
        connection.Close()
    End Sub

    Private Sub btn_rule_Click(sender As Object, e As EventArgs) Handles btn_rule.Click
        Dim frm As FrmRULE = New FrmRULE()
        frm.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim frm As FrmBaoCaoTTCay = New FrmBaoCaoTTCay()
        frm.Show()
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        Dim frm As FrmAbout = New FrmAbout()
        frm.Show()
    End Sub

    Private Sub Panel_header_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_header.MouseDown
        flag = True
        x = e.X
        y = e.Y
    End Sub
End Class
