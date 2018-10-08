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
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.TBbentuk = New System.Windows.Forms.TextBox()
        Me.BTUpdate = New System.Windows.Forms.Button()
        Me.LVPengajuan = New System.Windows.Forms.ListView()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTAdd = New System.Windows.Forms.Button()
        Me.TBKP = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TBJP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBB = New System.Windows.Forms.ComboBox()
        Me.TBP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btedit = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBid
        '
        Me.TBid.Location = New System.Drawing.Point(44, 397)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(100, 20)
        Me.TBid.TabIndex = 33
        '
        'TBbentuk
        '
        Me.TBbentuk.Location = New System.Drawing.Point(116, 371)
        Me.TBbentuk.Name = "TBbentuk"
        Me.TBbentuk.Size = New System.Drawing.Size(100, 20)
        Me.TBbentuk.TabIndex = 32
        '
        'BTUpdate
        '
        Me.BTUpdate.Location = New System.Drawing.Point(730, 110)
        Me.BTUpdate.Name = "BTUpdate"
        Me.BTUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BTUpdate.TabIndex = 31
        Me.BTUpdate.Text = "Update"
        Me.BTUpdate.UseVisualStyleBackColor = True
        '
        'LVPengajuan
        '
        Me.LVPengajuan.Location = New System.Drawing.Point(393, 50)
        Me.LVPengajuan.Name = "LVPengajuan"
        Me.LVPengajuan.Size = New System.Drawing.Size(331, 219)
        Me.LVPengajuan.TabIndex = 29
        Me.LVPengajuan.UseCompatibleStateImageBehavior = False
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'BTAdd
        '
        Me.BTAdd.Location = New System.Drawing.Point(730, 47)
        Me.BTAdd.Name = "BTAdd"
        Me.BTAdd.Size = New System.Drawing.Size(75, 23)
        Me.BTAdd.TabIndex = 30
        Me.BTAdd.Text = "Add"
        Me.BTAdd.UseVisualStyleBackColor = True
        '
        'TBKP
        '
        Me.TBKP.Location = New System.Drawing.Point(204, 213)
        Me.TBKP.Multiline = True
        Me.TBKP.Name = "TBKP"
        Me.TBKP.Size = New System.Drawing.Size(157, 56)
        Me.TBKP.TabIndex = 28
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(204, 187)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton3.TabIndex = 27
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Giro"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(204, 164)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton2.TabIndex = 26
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cek Bank"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(204, 141)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 25
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tunai"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TBJP
        '
        Me.TBJP.Location = New System.Drawing.Point(204, 103)
        Me.TBJP.Name = "TBJP"
        Me.TBJP.Size = New System.Drawing.Size(157, 20)
        Me.TBJP.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Bentuk Dana"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Keperluan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Jumlah Permintaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Bidang"
        '
        'CBB
        '
        Me.CBB.FormattingEnabled = True
        Me.CBB.Items.AddRange(New Object() {"Akademik", "Keuangan", "Marketing"})
        Me.CBB.Location = New System.Drawing.Point(204, 76)
        Me.CBB.Name = "CBB"
        Me.CBB.Size = New System.Drawing.Size(157, 21)
        Me.CBB.TabIndex = 19
        '
        'TBP
        '
        Me.TBP.Location = New System.Drawing.Point(204, 50)
        Me.TBP.Name = "TBP"
        Me.TBP.Size = New System.Drawing.Size(157, 20)
        Me.TBP.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nama Pelaksana"
        '
        'Btedit
        '
        Me.Btedit.Location = New System.Drawing.Point(730, 248)
        Me.Btedit.Name = "Btedit"
        Me.Btedit.Size = New System.Drawing.Size(75, 23)
        Me.Btedit.TabIndex = 34
        Me.Btedit.Text = "edit"
        Me.Btedit.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(730, 164)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(75, 23)
        Me.btdelete.TabIndex = 35
        Me.btdelete.Text = "delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 298)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.Btedit)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.TBbentuk)
        Me.Controls.Add(Me.BTUpdate)
        Me.Controls.Add(Me.LVPengajuan)
        Me.Controls.Add(Me.BTAdd)
        Me.Controls.Add(Me.TBKP)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TBJP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBB)
        Me.Controls.Add(Me.TBP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBid As System.Windows.Forms.TextBox
    Friend WithEvents TBbentuk As System.Windows.Forms.TextBox
    Friend WithEvents BTUpdate As System.Windows.Forms.Button
    Friend WithEvents LVPengajuan As System.Windows.Forms.ListView
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTAdd As System.Windows.Forms.Button
    Friend WithEvents TBKP As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TBJP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBB As System.Windows.Forms.ComboBox
    Friend WithEvents TBP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btedit As System.Windows.Forms.Button
    Friend WithEvents btdelete As System.Windows.Forms.Button

End Class
