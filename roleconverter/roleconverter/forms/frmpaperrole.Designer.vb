<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpaperrole
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
        Me.txtpapername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpdescription = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lvList = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtremaks = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtpaperid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtpapername
        '
        Me.txtpapername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpapername.Location = New System.Drawing.Point(149, 88)
        Me.txtpapername.Name = "txtpapername"
        Me.txtpapername.Size = New System.Drawing.Size(167, 20)
        Me.txtpapername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paper Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'txtpdescription
        '
        Me.txtpdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpdescription.Location = New System.Drawing.Point(148, 124)
        Me.txtpdescription.Name = "txtpdescription"
        Me.txtpdescription.Size = New System.Drawing.Size(167, 20)
        Me.txtpdescription.TabIndex = 1
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(344, 241)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Add"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lvList
        '
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5})
        Me.lvList.FullRowSelect = True
        Me.lvList.Location = New System.Drawing.Point(80, 270)
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(579, 204)
        Me.lvList.TabIndex = 5
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PAPER ID"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Paper Name"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Remarks"
        Me.ColumnHeader3.Width = 99
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Remarks:"
        '
        'txtremaks
        '
        Me.txtremaks.Location = New System.Drawing.Point(149, 168)
        Me.txtremaks.Name = "txtremaks"
        Me.txtremaks.Size = New System.Drawing.Size(167, 96)
        Me.txtremaks.TabIndex = 2
        Me.txtremaks.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(183, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(288, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(572, 24)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 13
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsearch.Location = New System.Drawing.Point(229, 24)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(319, 20)
        Me.txtsearch.TabIndex = 14
        '
        'txtpaperid
        '
        Me.txtpaperid.AutoSize = True
        Me.txtpaperid.Location = New System.Drawing.Point(74, 471)
        Me.txtpaperid.Name = "txtpaperid"
        Me.txtpaperid.Size = New System.Drawing.Size(0, 13)
        Me.txtpaperid.TabIndex = 15
        '
        'frmpaperrole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 739)
        Me.Controls.Add(Me.txtpaperid)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtremaks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvList)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpdescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpapername)
        Me.Name = "frmpaperrole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcategory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpapername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpdescription As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtremaks As System.Windows.Forms.RichTextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtpaperid As System.Windows.Forms.Label
End Class
