<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ledgerdetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbtype = New System.Windows.Forms.ComboBox
        Me.lbltype = New System.Windows.Forms.Label
        Me.txtcbal = New System.Windows.Forms.TextBox
        Me.txtobal = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.lblopbal = New System.Windows.Forms.Label
        Me.btnedit = New System.Windows.Forms.Button
        Me.lblname = New System.Windows.Forms.Label
        Me.btndelete = New System.Windows.Forms.Button
        Me.lblid = New System.Windows.Forms.Label
        Me.btnorder = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.grpbox = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.lblbal = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbtype
        '
        Me.cmbtype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"cash", "sales", "purchase", "materials", ""})
        Me.cmbtype.Location = New System.Drawing.Point(224, 151)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(144, 21)
        Me.cmbtype.TabIndex = 3
        '
        'lbltype
        '
        Me.lbltype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltype.AutoSize = True
        Me.lbltype.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.Location = New System.Drawing.Point(96, 154)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(98, 18)
        Me.lbltype.TabIndex = 28
        Me.lbltype.Text = "Ledger Type"
        '
        'txtcbal
        '
        Me.txtcbal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcbal.Location = New System.Drawing.Point(224, 237)
        Me.txtcbal.Name = "txtcbal"
        Me.txtcbal.Size = New System.Drawing.Size(144, 20)
        Me.txtcbal.TabIndex = 5
        '
        'txtobal
        '
        Me.txtobal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtobal.Location = New System.Drawing.Point(224, 195)
        Me.txtobal.Name = "txtobal"
        Me.txtobal.Size = New System.Drawing.Size(144, 20)
        Me.txtobal.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtname.Location = New System.Drawing.Point(224, 104)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(144, 20)
        Me.txtname.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnadd.BackColor = System.Drawing.Color.Cyan
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(17, 313)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(73, 42)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lblopbal
        '
        Me.lblopbal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblopbal.AutoSize = True
        Me.lblopbal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblopbal.Location = New System.Drawing.Point(96, 198)
        Me.lblopbal.Name = "lblopbal"
        Me.lblopbal.Size = New System.Drawing.Size(130, 18)
        Me.lblopbal.TabIndex = 2
        Me.lblopbal.Text = "Opening Balance"
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnedit.BackColor = System.Drawing.Color.Cyan
        Me.btnedit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(180, 313)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(78, 42)
        Me.btnedit.TabIndex = 9
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'lblname
        '
        Me.lblname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(98, 105)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(103, 18)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Ledger Name"
        '
        'btndelete
        '
        Me.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndelete.BackColor = System.Drawing.Color.Cyan
        Me.btndelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(264, 313)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 42)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'lblid
        '
        Me.lblid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(96, 49)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(78, 18)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Ledger ID"
        '
        'btnorder
        '
        Me.btnorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnorder.BackColor = System.Drawing.Color.Cyan
        Me.btnorder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorder.Location = New System.Drawing.Point(367, 313)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(88, 42)
        Me.btnorder.TabIndex = 11
        Me.btnorder.Text = "SHOW"
        Me.btnorder.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnexit.BackColor = System.Drawing.Color.Cyan
        Me.btnexit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(475, 313)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(71, 42)
        Me.btnexit.TabIndex = 12
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'grpbox
        '
        Me.grpbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbox.Controls.Add(Me.Label3)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.ComboBox1)
        Me.grpbox.Controls.Add(Me.cmbtype)
        Me.grpbox.Controls.Add(Me.lbltype)
        Me.grpbox.Controls.Add(Me.txtcbal)
        Me.grpbox.Controls.Add(Me.txtobal)
        Me.grpbox.Controls.Add(Me.txtname)
        Me.grpbox.Controls.Add(Me.btnadd)
        Me.grpbox.Controls.Add(Me.lblbal)
        Me.grpbox.Controls.Add(Me.btnsave)
        Me.grpbox.Controls.Add(Me.lblopbal)
        Me.grpbox.Controls.Add(Me.btnedit)
        Me.grpbox.Controls.Add(Me.lblname)
        Me.grpbox.Controls.Add(Me.btndelete)
        Me.grpbox.Controls.Add(Me.lblid)
        Me.grpbox.Controls.Add(Me.btnorder)
        Me.grpbox.Controls.Add(Me.btnexit)
        Me.grpbox.Location = New System.Drawing.Point(45, 77)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(600, 399)
        Me.grpbox.TabIndex = 10
        Me.grpbox.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = " RS/"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(393, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = " Rs/"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(224, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'lblbal
        '
        Me.lblbal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbal.AutoSize = True
        Me.lblbal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbal.Location = New System.Drawing.Point(96, 240)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(123, 18)
        Me.lblbal.TabIndex = 4
        Me.lblbal.Text = "Closing Balance"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.Color.Cyan
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(108, 313)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(66, 42)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(148, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 55)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "    Ledger Details"
        '
        'ledgerdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(697, 495)
        Me.Controls.Add(Me.grpbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ledgerdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "petrol manage- ledgerdetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents txtcbal As System.Windows.Forms.TextBox
    Friend WithEvents txtobal As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lblopbal As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents lblbal As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
