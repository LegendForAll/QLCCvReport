Public Class FrmManageTREE
    Private Sub FrmManageTREE_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub

    Private Sub btn_tree_Click(sender As Object, e As EventArgs) Handles btn_tree.Click
        Dim frm As FrmThemCay = New FrmThemCay()
        frm.Show()
    End Sub

    Private Sub btn_location_Click(sender As Object, e As EventArgs) Handles btn_location.Click
        Dim frm As FrmChangeLocationTree = New FrmChangeLocationTree()
        frm.Show()
    End Sub

    Private Sub btn_calender_Click(sender As Object, e As EventArgs) Handles btn_calender.Click
        Dim frm As FrmThemLichCS = New FrmThemLichCS()
        frm.Show()
    End Sub

    Private Sub btn_care_Click(sender As Object, e As EventArgs) Handles btn_care.Click
        Dim frm As FrmThemChamSoc = New FrmThemChamSoc()
        frm.Show()
    End Sub
End Class