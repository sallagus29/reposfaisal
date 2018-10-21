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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBREQ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBUNIT = New System.Windows.Forms.TextBox()
        Me.TBINS = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TBPHONE = New System.Windows.Forms.TextBox()
        Me.TBAC = New System.Windows.Forms.TextBox()
        Me.TBDES = New System.Windows.Forms.TextBox()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.CBTRANS = New System.Windows.Forms.ComboBox()
        Me.DTPISUE = New System.Windows.Forms.DateTimePicker()
        Me.BTSEND = New System.Windows.Forms.Button()
        Me.LVrequest = New System.Windows.Forms.ListView()
        Me.TBif = New System.Windows.Forms.TextBox()
        Me.Tbo = New System.Windows.Forms.TextBox()
        Me.BTupdate = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME OF REQUESTOR"
        '
        'TBREQ
        '
        Me.TBREQ.Location = New System.Drawing.Point(163, 34)
        Me.TBREQ.Name = "TBREQ"
        Me.TBREQ.Size = New System.Drawing.Size(100, 20)
        Me.TBREQ.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID NUMBER"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "UNIT"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DATE OF ISUE"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 77)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "INSTRUCTION"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DESTINATION"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(342, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "A/C REG"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(342, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "TRANSPORTATION"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(342, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 26)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "PHONE/HP"
        '
        'TBUNIT
        '
        Me.TBUNIT.Location = New System.Drawing.Point(163, 101)
        Me.TBUNIT.Name = "TBUNIT"
        Me.TBUNIT.Size = New System.Drawing.Size(100, 20)
        Me.TBUNIT.TabIndex = 11
        '
        'TBINS
        '
        Me.TBINS.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TBINS.Location = New System.Drawing.Point(132, 186)
        Me.TBINS.Multiline = True
        Me.TBINS.Name = "TBINS"
        Me.TBINS.Size = New System.Drawing.Size(464, 77)
        Me.TBINS.TabIndex = 12
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(107, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.EditToolStripMenuItem.Text = "edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'TBPHONE
        '
        Me.TBPHONE.Location = New System.Drawing.Point(475, 141)
        Me.TBPHONE.Name = "TBPHONE"
        Me.TBPHONE.Size = New System.Drawing.Size(121, 20)
        Me.TBPHONE.TabIndex = 13
        '
        'TBAC
        '
        Me.TBAC.Location = New System.Drawing.Point(475, 63)
        Me.TBAC.Name = "TBAC"
        Me.TBAC.Size = New System.Drawing.Size(121, 20)
        Me.TBAC.TabIndex = 14
        '
        'TBDES
        '
        Me.TBDES.Location = New System.Drawing.Point(475, 34)
        Me.TBDES.Name = "TBDES"
        Me.TBDES.Size = New System.Drawing.Size(121, 20)
        Me.TBDES.TabIndex = 15
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(163, 63)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(100, 20)
        Me.TBID.TabIndex = 16
        '
        'CBTRANS
        '
        Me.CBTRANS.FormattingEnabled = True
        Me.CBTRANS.Items.AddRange(New Object() {"Pick Up", "Box", "Blind Van", "Truck", "BTT", "Forklift", "Other", "", ""})
        Me.CBTRANS.Location = New System.Drawing.Point(475, 100)
        Me.CBTRANS.Name = "CBTRANS"
        Me.CBTRANS.Size = New System.Drawing.Size(121, 21)
        Me.CBTRANS.TabIndex = 17
        '
        'DTPISUE
        '
        Me.DTPISUE.CustomFormat = "yyyy/mm/dd"
        Me.DTPISUE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPISUE.Location = New System.Drawing.Point(163, 133)
        Me.DTPISUE.Name = "DTPISUE"
        Me.DTPISUE.Size = New System.Drawing.Size(100, 20)
        Me.DTPISUE.TabIndex = 18
        '
        'BTSEND
        '
        Me.BTSEND.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTSEND.Font = New System.Drawing.Font("News706 BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSEND.Location = New System.Drawing.Point(261, 269)
        Me.BTSEND.Name = "BTSEND"
        Me.BTSEND.Size = New System.Drawing.Size(75, 23)
        Me.BTSEND.TabIndex = 19
        Me.BTSEND.Text = "KIRIM"
        Me.BTSEND.UseVisualStyleBackColor = False
        '
        'LVrequest
        '
        Me.LVrequest.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LVrequest.Location = New System.Drawing.Point(12, 310)
        Me.LVrequest.Name = "LVrequest"
        Me.LVrequest.Size = New System.Drawing.Size(646, 97)
        Me.LVrequest.TabIndex = 20
        Me.LVrequest.UseCompatibleStateImageBehavior = False
        '
        'TBif
        '
        Me.TBif.Location = New System.Drawing.Point(602, 219)
        Me.TBif.Name = "TBif"
        Me.TBif.Size = New System.Drawing.Size(56, 20)
        Me.TBif.TabIndex = 22
        '
        'Tbo
        '
        Me.Tbo.Location = New System.Drawing.Point(602, 184)
        Me.Tbo.Name = "Tbo"
        Me.Tbo.Size = New System.Drawing.Size(56, 20)
        Me.Tbo.TabIndex = 23
        '
        'BTupdate
        '
        Me.BTupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTupdate.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTupdate.Location = New System.Drawing.Point(342, 269)
        Me.BTupdate.Name = "BTupdate"
        Me.BTupdate.Size = New System.Drawing.Size(75, 23)
        Me.BTupdate.TabIndex = 24
        Me.BTupdate.Text = "UPDATE"
        Me.BTupdate.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 526)
        Me.Controls.Add(Me.BTupdate)
        Me.Controls.Add(Me.Tbo)
        Me.Controls.Add(Me.TBif)
        Me.Controls.Add(Me.LVrequest)
        Me.Controls.Add(Me.BTSEND)
        Me.Controls.Add(Me.DTPISUE)
        Me.Controls.Add(Me.CBTRANS)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.TBDES)
        Me.Controls.Add(Me.TBAC)
        Me.Controls.Add(Me.TBPHONE)
        Me.Controls.Add(Me.TBINS)
        Me.Controls.Add(Me.TBUNIT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBREQ)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBREQ As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBUNIT As System.Windows.Forms.TextBox
    Friend WithEvents TBINS As System.Windows.Forms.TextBox
    Friend WithEvents TBPHONE As System.Windows.Forms.TextBox
    Friend WithEvents TBAC As System.Windows.Forms.TextBox
    Friend WithEvents TBDES As System.Windows.Forms.TextBox
    Friend WithEvents TBID As System.Windows.Forms.TextBox
    Friend WithEvents CBTRANS As System.Windows.Forms.ComboBox
    Friend WithEvents DTPISUE As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTSEND As System.Windows.Forms.Button



    Friend WithEvents LVrequest As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBif As System.Windows.Forms.TextBox
    Friend WithEvents Tbo As System.Windows.Forms.TextBox
    Friend WithEvents BTupdate As System.Windows.Forms.Button

End Class
