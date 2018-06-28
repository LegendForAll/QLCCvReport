Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Configuration

Public Class FrmBaoCaoCP
    Private BCaoBus As BCChiPhiBUS
    Private BCaoCTBus As BCCT_ChiPhiBUS
    ' Read ConnectionString value from App.config file
    Dim connection As New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
    Dim table As New DataTable("Table")
    Dim index As Integer
    Dim TyLe As Double

    Public Sub FiterData(valSearch As String)
        Dim str As String = Convert.ToString(dtp_choose.Value.Month)

        Dim searchQuery As String = "SELECT CT.ID_VATTU AS '" & "ID Supplies" & "', V.TEN_VATTU AS '" & "Supplies" & "',SUM(SOTIEN) AS '" & "Cost" & "',COUNT(CT.ID_VATTU) AS '" & "Count" & "'  
        FROM [PHIEUMUA_VT] P, [PHIEUMUA_VTCT] CT, [VATTU] V
        WHERE P.ID_PHIEUMUA_VT=CT.ID_PHIEUMUA_VT
        AND V.ID_VATTU = CT.ID_VATTU
        AND MONTH(P.NGAYMUAVT)='" & str & "'
	    GROUP BY V.TEN_VATTU,CT.ID_VATTU"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView2.DataSource = table
    End Sub
    Public Sub FiterData1(valSearch As String)

        Dim searchQuery As String = "SELECT ID_BCCHIPHI AS '" & "ID report" & "',TG_BAOCAO AS '" & "Time" & "' FROM [BCCHIPHI]"
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
    Private Sub FrmBaoCaoCP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BCaoBus = New BCChiPhiBUS()
        'set ID auto bao cao
        Dim result As Result
        Dim nextID = "1"
        result = BCaoBus.getNextID(nextID)
        If (result.FlagResult = False) Then
            MessageBox.Show("Get the autocomplete code report failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        tbx_IDBC.Text = nextID
    End Sub

    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
        Dim BaoCao As BCChiPhiDTO
        BaoCao = New BCChiPhiDTO()

        '1. Mapping data from GUI control
        BaoCao.MS_BCChiPhi = tbx_IDBC.Text
        BaoCao.TG_BaoCao = dtp_TGBC.Value

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = BCaoBus.insert(BaoCao)

        If (result.FlagResult = True) Then
            MessageBox.Show("Add report calender successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BCaoBus = New BCChiPhiBUS()
            'set ID auto bao cao
            Dim nextID = "1"
            result = BCaoBus.getNextID(nextID)
            If (result.FlagResult = False) Then
                MessageBox.Show("Get the autocomplete code report failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            tbx_IDBC.Text = nextID

        Else
            MessageBox.Show("Add report calender unsuccessfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Update DataGridView
        DataGridView1.Refresh()
        FiterData1("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FiterData1("")
        'set ID auto chi tiet bao cao
        BCaoCTBus = New BCCT_ChiPhiBUS()
        Dim result As Result
        Dim nextID = "1"
        result = BCaoCTBus.getNextID(nextID)
        If (result.FlagResult = False) Then
            MessageBox.Show("Get the autocomplete code report failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        tbx_IDBCCT.Text = nextID
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView1.Rows(index)
            tbx_IDlich.Text = SelectRow.Cells(0).Value.ToString()
            dtp_choose.Value = Convert.ToDateTime(SelectRow.Cells(1).Value.ToString())

            'update DataGridView2
            FiterData("")

            'Tinh tong so phieu
            Dim sum As Integer = 0
            For i As Integer = 0 To DataGridView2.Rows.Count() - 1 Step +1
                sum = sum + DataGridView2.Rows(i).Cells(3).Value
            Next
            tbx_TongPhieu.Text = sum.ToString()
        End If

    End Sub


    Private Sub btn_huy_Click_1(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        If (index >= 0) Then
            SelectRow = DataGridView2.Rows(index)
            tbx_lD_VT.Text = SelectRow.Cells(0).Value.ToString()
            tbx_TenVT.Text = SelectRow.Cells(1).Value.ToString()
            tbx_SUM.Text = SelectRow.Cells(2).Value.ToString()
            tbx_Sophieu.Text = SelectRow.Cells(3).Value.ToString()

            'tinh ty le tung loai vat tu
            TyLe = (Convert.ToInt32(SelectRow.Cells(3).Value.ToString()) * 100) / Convert.ToInt32(tbx_TongPhieu.Text)
        End If
    End Sub

    Private Sub btn_ThemBCCT_Click(sender As Object, e As EventArgs) Handles btn_ThemBCCT.Click
        If DataGridView2.Rows(0).IsNewRow Then
        Else
            DataGridView2.Rows.RemoveAt(index)
            Dim InsertQuery As String = "INSERT INTO [dbo].[BCCT_CHIPHI]
                  ([ID_BCCT_CHIPHI]
                  ,[ID_BCCHIPHI]
                  ,[ID_VATTU]
                  ,[SOPHIEUMUA]
                  ,[TONG_GT]
                  ,[TYLE])
            VALUES
                  ('" & tbx_IDBCCT.Text & "'
                  ,'" & tbx_IDlich.Text & "'
                  ,'" & tbx_lD_VT.Text & "'
                  ,'" & tbx_Sophieu.Text & "'
                  ,'" & tbx_SUM.Text & "'
                  ,'" & TyLe.ToString() & "')"

            ExcuteQuery(InsertQuery)
            MessageBox.Show("Add report detail successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Refresh()

            'set ID auto chi tiet bao cao
            BCaoCTBus = New BCCT_ChiPhiBUS()
            Dim result As Result
            Dim nextID = "1"
            result = BCaoCTBus.getNextID(nextID)
            If (result.FlagResult = False) Then
                MessageBox.Show("Get the autocomplete code report failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            tbx_IDBCCT.Text = nextID
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim Frm As FrmUpdateBCCP = New FrmUpdateBCCP()
        Frm.Show()
    End Sub
End Class