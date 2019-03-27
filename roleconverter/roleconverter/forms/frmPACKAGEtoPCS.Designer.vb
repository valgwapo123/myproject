<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPACKAGEtoPCS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sfdPath = New System.Windows.Forms.SaveFileDialog()
        Me.ofdJeltmp = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblpath = New System.Windows.Forms.TextBox()
        Me.pbstatus = New System.Windows.Forms.ProgressBar()
        Me.lblstatuss = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Conversion"
        '
        'sfdPath
        '
        Me.sfdPath.DefaultExt = "xls"
        Me.sfdPath.Filter = "Excel File 2003|*.xls"
        '
        'ofdJeltmp
        '
        Me.ofdJeltmp.Filter = "Excel 2003|*.xls|Excel 2007|*.xlsx"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Forte", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(291, 52)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(30, 35)
        Me.btnBrowse.TabIndex = 61
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Forte", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(327, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblpath
        '
        Me.lblpath.Enabled = False
        Me.lblpath.Location = New System.Drawing.Point(61, 60)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(215, 20)
        Me.lblpath.TabIndex = 63
        '
        'pbstatus
        '
        Me.pbstatus.Location = New System.Drawing.Point(61, 114)
        Me.pbstatus.Name = "pbstatus"
        Me.pbstatus.Size = New System.Drawing.Size(348, 23)
        Me.pbstatus.TabIndex = 64
        '
        'lblstatuss
        '
        Me.lblstatuss.AutoSize = True
        Me.lblstatuss.BackColor = System.Drawing.Color.Transparent
        Me.lblstatuss.Location = New System.Drawing.Point(200, 98)
        Me.lblstatuss.Name = "lblstatuss"
        Me.lblstatuss.Size = New System.Drawing.Size(10, 13)
        Me.lblstatuss.TabIndex = 65
        Me.lblstatuss.Text = "."
        '
        'frmPACKAGEtoPCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 750)
        Me.Controls.Add(Me.lblstatuss)
        Me.Controls.Add(Me.pbstatus)
        Me.Controls.Add(Me.lblpath)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPACKAGEtoPCS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPACKAGEtoPCS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sfdPath As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdJeltmp As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblpath As System.Windows.Forms.TextBox
    Friend WithEvents pbstatus As System.Windows.Forms.ProgressBar
    Friend WithEvents lblstatuss As System.Windows.Forms.Label
End Class
