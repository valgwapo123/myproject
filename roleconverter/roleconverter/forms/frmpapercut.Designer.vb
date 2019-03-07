<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpapercut
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvlsaved = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtcutremarks = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.combounit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpapercut = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.txtremaks = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpdescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpapername = New System.Windows.Forms.TextBox()
        Me.lvList = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvlsaved)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btnsave)
        Me.TabPage1.Controls.Add(Me.btnremove)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lvList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1178, 732)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ADD PAPER CUT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvlsaved
        '
        Me.lvlsaved.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader13, Me.ColumnHeader12, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader6, Me.ColumnHeader11, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader22})
        Me.lvlsaved.FullRowSelect = True
        Me.lvlsaved.Location = New System.Drawing.Point(9, 575)
        Me.lvlsaved.Name = "lvlsaved"
        Me.lvlsaved.Size = New System.Drawing.Size(1154, 161)
        Me.lvlsaved.TabIndex = 47
        Me.lvlsaved.UseCompatibleStateImageBehavior = False
        Me.lvlsaved.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "cutid"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Paper Cut"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Description"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Unitid"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Unit"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Remarks"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PAPER ID"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "PAPER NAME"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Description"
        Me.ColumnHeader19.Width = 100
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Serial Code"
        Me.ColumnHeader20.Width = 120
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Remarks"
        Me.ColumnHeader22.Width = 200
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader14, Me.ColumnHeader5, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(437, 255)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(709, 128)
        Me.ListView1.TabIndex = 41
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "cutid"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "paperroleid"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Paper Cut"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Description"
        Me.ColumnHeader14.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Remarks"
        Me.ColumnHeader8.Width = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.txtcutremarks)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Controls.Add(Me.combounit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtdescription)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtpapercut)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 290)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 279)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PAPER CUT"
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Location = New System.Drawing.Point(276, 236)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 39
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'txtcutremarks
        '
        Me.txtcutremarks.Location = New System.Drawing.Point(103, 163)
        Me.txtcutremarks.Name = "txtcutremarks"
        Me.txtcutremarks.Size = New System.Drawing.Size(167, 96)
        Me.txtcutremarks.TabIndex = 3
        Me.txtcutremarks.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Remarks:"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(276, 203)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'combounit
        '
        Me.combounit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combounit.FormattingEnabled = True
        Me.combounit.Location = New System.Drawing.Point(103, 118)
        Me.combounit.Name = "combounit"
        Me.combounit.Size = New System.Drawing.Size(168, 21)
        Me.combounit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Unit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Description:"
        '
        'txtdescription
        '
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(102, 76)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(167, 20)
        Me.txtdescription.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Paper Name:"
        '
        'txtpapercut
        '
        Me.txtpapercut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpapercut.Location = New System.Drawing.Point(103, 40)
        Me.txtpapercut.Name = "txtpapercut"
        Me.txtpapercut.Size = New System.Drawing.Size(167, 20)
        Me.txtpapercut.TabIndex = 0
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(629, 402)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 45
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(736, 402)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(75, 23)
        Me.btnremove.TabIndex = 46
        Me.btnremove.Text = "REMOVE"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtserial)
        Me.GroupBox1.Controls.Add(Me.txtheight)
        Me.GroupBox1.Controls.Add(Me.txtremaks)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtpdescription)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpapername)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 278)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAPER  DETAILS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Height:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "SERIAL CODE:"
        '
        'txtserial
        '
        Me.txtserial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserial.Enabled = False
        Me.txtserial.Location = New System.Drawing.Point(102, 118)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(167, 20)
        Me.txtserial.TabIndex = 35
        '
        'txtheight
        '
        Me.txtheight.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtheight.Enabled = False
        Me.txtheight.Location = New System.Drawing.Point(104, 161)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(167, 20)
        Me.txtheight.TabIndex = 37
        '
        'txtremaks
        '
        Me.txtremaks.Enabled = False
        Me.txtremaks.Location = New System.Drawing.Point(104, 206)
        Me.txtremaks.Name = "txtremaks"
        Me.txtremaks.Size = New System.Drawing.Size(167, 54)
        Me.txtremaks.TabIndex = 2
        Me.txtremaks.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Remarks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Description:"
        '
        'txtpdescription
        '
        Me.txtpdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpdescription.Enabled = False
        Me.txtpdescription.Location = New System.Drawing.Point(102, 76)
        Me.txtpdescription.Name = "txtpdescription"
        Me.txtpdescription.Size = New System.Drawing.Size(167, 20)
        Me.txtpdescription.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Paper Name:"
        '
        'txtpapername
        '
        Me.txtpapername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpapername.Enabled = False
        Me.txtpapername.Location = New System.Drawing.Point(103, 40)
        Me.txtpapername.Name = "txtpapername"
        Me.txtpapername.Size = New System.Drawing.Size(167, 20)
        Me.txtpapername.TabIndex = 0
        '
        'lvList
        '
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader21, Me.ColumnHeader18, Me.ColumnHeader23})
        Me.lvList.FullRowSelect = True
        Me.lvList.Location = New System.Drawing.Point(437, 29)
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(709, 169)
        Me.lvList.TabIndex = 42
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "PAPER ID"
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Paper Name"
        Me.ColumnHeader16.Width = 200
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Description"
        Me.ColumnHeader17.Width = 200
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "SERIAL CODE"
        Me.ColumnHeader21.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Remarks"
        Me.ColumnHeader18.Width = 99
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Height "
        Me.ColumnHeader23.Width = 100
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1186, 758)
        Me.TabControl1.TabIndex = 0
        '
        'frmpapercut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmpapercut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpapercut"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvlsaved As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcutremarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents combounit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpapercut As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtremaks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpapername As System.Windows.Forms.TextBox
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Protected WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtserial As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtheight As System.Windows.Forms.TextBox
End Class
