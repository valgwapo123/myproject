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

        frmproduction.Show()
        frmproduction.Focus()
    End Sub

    Private Sub PAPERWASTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAPERWASTEDToolStripMenuItem.Click
        FRMWASTE.Show()
        FRMWASTE.Focus()
    End Sub

    Private Sub STOCKINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKINToolStripMenuItem.Click

        frmaddpaperroll.Show()
        frmaddpaperroll.Focus()
    End Sub

    Private Sub PACKAGEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACKAGEToolStripMenuItem.Click
        
    End Sub

    Private Sub PACKAGEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACKAGEToolStripMenuItem1.Click
        frmphotoset.Show()
        frmphotoset.Focus()
    End Sub
End Class
