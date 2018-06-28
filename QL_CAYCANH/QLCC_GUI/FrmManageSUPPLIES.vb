Public Class FrmManageSUPPLIES
    Private Sub FrmManageSUPPLIES_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub

    Private Sub btn_Supplies_Click(sender As Object, e As EventArgs) Handles btn_Supplies.Click
        Dim frm As Frm_ThemVatTu = New Frm_ThemVatTu()
        frm.Show()
    End Sub

    Private Sub btn_offers_Click(sender As Object, e As EventArgs) Handles btn_offers.Click
        Dim frm As FrmPhieuMuaVT = New FrmPhieuMuaVT()
        frm.Show()
    End Sub
End Class