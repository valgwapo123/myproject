<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SETTINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAPERINFOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAPERCUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudtiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAPERWASTEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.STOCKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SETTINGToolStripMenuItem, Me.ProductionToolStripMenuItem, Me.AudtiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(966, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SETTINGToolStripMenuItem
        '
        Me.SETTINGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAPERINFOToolStripMenuItem, Me.PAPERCUTToolStripMenuItem, Me.UnitToolStripMenuItem})
        Me.SETTINGToolStripMenuItem.Name = "SETTINGToolStripMenuItem"
        Me.SETTINGToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SETTINGToolStripMenuItem.Text = "SETTING"
        '
        'PAPERINFOToolStripMenuItem
        '
        Me.PAPERINFOToolStripMenuItem.Name = "PAPERINFOToolStripMenuItem"
        Me.PAPERINFOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PAPERINFOToolStripMenuItem.Text = "PAPER INFO"
        '
        'PAPERCUTToolStripMenuItem
        '
        Me.PAPERCUTToolStripMenuItem.Name = "PAPERCUTToolStripMenuItem"
        Me.PAPERCUTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PAPERCUTToolStripMenuItem.Text = "PAPER CUT"
        '
        'UnitToolStripMenuItem
        '
        Me.UnitToolStripMenuItem.Name = "UnitToolStripMenuItem"
        Me.UnitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UnitToolStripMenuItem.Text = "Unit"
        '
        'ProductionToolStripMenuItem
        '
        Me.ProductionToolStripMenuItem.Name = "ProductionToolStripMenuItem"
        Me.ProductionToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ProductionToolStripMenuItem.Text = "Production"
        '
        'AudtiToolStripMenuItem
        '
        Me.AudtiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAPERWASTEDToolStripMenuItem, Me.STOCKINToolStripMenuItem})
        Me.AudtiToolStripMenuItem.Name = "AudtiToolStripMenuItem"
        Me.AudtiToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AudtiToolStripMenuItem.Text = "Inventory"
        '
        'PAPERWASTEDToolStripMenuItem
        '
        Me.PAPERWASTEDToolStripMenuItem.Name = "PAPERWASTEDToolStripMenuItem"
        Me.PAPERWASTEDToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.PAPERWASTEDToolStripMenuItem.Text = "PAPER WASTED"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(196, 130)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(8, 8)
        Me.ReportViewer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(229, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 311)
        Me.Panel1.TabIndex = 2
        '
        'STOCKINToolStripMenuItem
        '
        Me.STOCKINToolStripMenuItem.Name = "STOCKINToolStripMenuItem"
        Me.STOCKINToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.STOCKINToolStripMenuItem.Text = "STOCK IN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 614)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAPER CUT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SETTINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAPERINFOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAPERCUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AudtiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAPERWASTEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOCKINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
