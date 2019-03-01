Public Class Form1

    Private Sub PAPERINFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAPERINFOToolStripMenuItem.Click

        frmpaperrole.Show()

    End Sub

    Private Sub PAPERCUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAPERCUTToolStripMenuItem.Click

        frmpapercut.Show()
    End Sub

    Private Sub UnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitToolStripMenuItem.Click
        frmunit.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionToolStripMenuItem.Click

    End Sub
End Class
