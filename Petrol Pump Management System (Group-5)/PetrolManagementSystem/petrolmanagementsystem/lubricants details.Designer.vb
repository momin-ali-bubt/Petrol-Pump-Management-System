<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lubricants_details
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
        Me.btnadd = New System.Windows.Forms.Button
        Me.lblorderlevel = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.lblrate = New System.Windows.Forms.Label
        Me.btnedit = New System.Windows.Forms.Button
        Me.lblname = New System.Windows.Forms.Label
        Me.btndelete = New System.Windows.Forms.Button
        Me.lblid = New System.Windows.Forms.Label
        Me.btnorder = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.cmbpkgsize = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.grpbox = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Cyan
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(32, 302)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(66, 38)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lblorderlevel
        '
        Me.lblorderlevel.AutoSize = True
        Me.lblorderlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorderlevel.Location = New System.Drawing.Point(96, 220)
        Me.lblorderlevel.Name = "lblorderlevel"
        Me.lblorderlevel.Size = New System.Drawing.Size(131, 16)
        Me.lblorderlevel.TabIndex = 4
        Me.lblorderlevel.Text = "Lubricant Quantity"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Cyan
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(121, 302)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(66, 38)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(96, 182)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(108, 16)
        Me.lblrate.TabIndex = 2
        Me.lblrate.Text = "Lubricant Rate"
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Cyan
        Me.btnedit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(203, 302)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(64, 38)
        Me.btnedit.TabIndex = 9
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(96, 92)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(116, 16)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Lubricant Name"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Cyan
        Me.btndelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(286, 302)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(83, 38)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(96, 37)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(90, 16)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Lubricant ID"
        '
        'btnorder
        '
        Me.btnorder.BackColor = System.Drawing.Color.Cyan
        Me.btnorder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorder.Location = New System.Drawing.Point(387, 302)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(66, 38)
        Me.btnorder.TabIndex = 11
        Me.btnorder.Text = "SHOW"
        Me.btnorder.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Cyan
        Me.btnexit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(483, 302)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(66, 38)
        Me.btnexit.TabIndex = 12
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'cmbpkgsize
        '
        Me.cmbpkgsize.FormattingEnabled = True
        Me.cmbpkgsize.Location = New System.Drawing.Point(235, 138)
        Me.cmbpkgsize.Name = "cmbpkgsize"
        Me.cmbpkgsize.Size = New System.Drawing.Size(144, 21)
        Me.cmbpkgsize.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Lubricant Pkg Size"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(163, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 55)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "   Lubricant Details"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(235, 217)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(144, 20)
        Me.txtqty.TabIndex = 5
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(235, 179)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(144, 20)
        Me.txtrate.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(235, 95)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(144, 20)
        Me.txtname.TabIndex = 2
        '
        'grpbox
        '
        Me.grpbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbox.Controls.Add(Me.Label5)
        Me.grpbox.Controls.Add(Me.Label4)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.ComboBox1)
        Me.grpbox.Controls.Add(Me.cmbpkgsize)
        Me.grpbox.Controls.Add(Me.Label3)
        Me.grpbox.Controls.Add(Me.txtqty)
        Me.grpbox.Controls.Add(Me.txtrate)
        Me.grpbox.Controls.Add(Me.txtname)
        Me.grpbox.Controls.Add(Me.btnadd)
        Me.grpbox.Controls.Add(Me.lblorderlevel)
        Me.grpbox.Controls.Add(Me.btnsave)
        Me.grpbox.Controls.Add(Me.lblrate)
        Me.grpbox.Controls.Add(Me.btnedit)
        Me.grpbox.Controls.Add(Me.lblname)
        Me.grpbox.Controls.Add(Me.btndelete)
        Me.grpbox.Controls.Add(Me.lblid)
        Me.grpbox.Controls.Add(Me.btnorder)
        Me.grpbox.Controls.Add(Me.btnexit)
        Me.grpbox.Location = New System.Drawing.Point(52, 92)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(606, 347)
        Me.grpbox.TabIndex = 10
        Me.grpbox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(411, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = " liter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(409, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = " Rs/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = " liter"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(235, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'lubricants_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(703, 478)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpbox)
        Me.Name = "lubricants_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "petrol manage-lubricants_details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lblorderlevel As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents cmbpkgsize As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
