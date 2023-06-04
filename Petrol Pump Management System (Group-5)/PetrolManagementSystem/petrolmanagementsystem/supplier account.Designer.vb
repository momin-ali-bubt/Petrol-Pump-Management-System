<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplier_account
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
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblno = New System.Windows.Forms.Label
        Me.lblmode = New System.Windows.Forms.Label
        Me.lblpamt = New System.Windows.Forms.Label
        Me.lblamt = New System.Windows.Forms.Label
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblproduct = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.lblbill = New System.Windows.Forms.Label
        Me.cmbproduct = New System.Windows.Forms.ComboBox
        Me.cmbrate = New System.Windows.Forms.ComboBox
        Me.lblrate = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.txtddno = New System.Windows.Forms.TextBox
        Me.txtbamt = New System.Windows.Forms.TextBox
        Me.lblbamt = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpamt = New System.Windows.Forms.TextBox
        Me.txttamt = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.cmbname = New System.Windows.Forms.ComboBox
        Me.grpbox = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.cmbmode = New System.Windows.Forms.ComboBox
        Me.grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Cyan
        Me.btnexit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(350, 340)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 34)
        Me.btnexit.TabIndex = 16
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Cyan
        Me.btnedit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(269, 340)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 34)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Cyan
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(188, 340)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 34)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Cyan
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(107, 340)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 34)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(314, 263)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(127, 16)
        Me.lbldate.TabIndex = 9
        Me.lbldate.Text = "Transaction Date"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.Location = New System.Drawing.Point(310, 121)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(98, 16)
        Me.lblno.TabIndex = 8
        Me.lblno.Text = "Chq / DD No."
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmode.Location = New System.Drawing.Point(310, 76)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(128, 16)
        Me.lblmode.TabIndex = 7
        Me.lblmode.Text = "Mode of Payment"
        '
        'lblpamt
        '
        Me.lblpamt.AutoSize = True
        Me.lblpamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpamt.Location = New System.Drawing.Point(310, 29)
        Me.lblpamt.Name = "lblpamt"
        Me.lblpamt.Size = New System.Drawing.Size(95, 16)
        Me.lblpamt.TabIndex = 5
        Me.lblpamt.Text = "Paid Amount"
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(27, 255)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(99, 16)
        Me.lblamt.TabIndex = 4
        Me.lblamt.Text = "Total Amount"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(27, 207)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(64, 16)
        Me.lblqty.TabIndex = 3
        Me.lblqty.Text = "Quantity"
        '
        'lblproduct
        '
        Me.lblproduct.AutoSize = True
        Me.lblproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproduct.Location = New System.Drawing.Point(24, 117)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(106, 16)
        Me.lblproduct.TabIndex = 2
        Me.lblproduct.Text = "Product Name"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(24, 71)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(111, 16)
        Me.lblid.TabIndex = 1
        Me.lblid.Text = "Supplier Name"
        '
        'lblbill
        '
        Me.lblbill.AutoSize = True
        Me.lblbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbill.Location = New System.Drawing.Point(24, 20)
        Me.lblbill.Name = "lblbill"
        Me.lblbill.Size = New System.Drawing.Size(94, 16)
        Me.lblbill.TabIndex = 0
        Me.lblbill.Text = "Supp Ac No."
        '
        'cmbproduct
        '
        Me.cmbproduct.FormattingEnabled = True
        Me.cmbproduct.Location = New System.Drawing.Point(132, 114)
        Me.cmbproduct.Name = "cmbproduct"
        Me.cmbproduct.Size = New System.Drawing.Size(124, 25)
        Me.cmbproduct.TabIndex = 3
        '
        'cmbrate
        '
        Me.cmbrate.FormattingEnabled = True
        Me.cmbrate.Items.AddRange(New Object() {"100", "200", "400", "600", "1000", "10000"})
        Me.cmbrate.Location = New System.Drawing.Point(132, 153)
        Me.cmbrate.Name = "cmbrate"
        Me.cmbrate.Size = New System.Drawing.Size(124, 25)
        Me.cmbrate.TabIndex = 4
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(24, 154)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(98, 16)
        Me.lblrate.TabIndex = 25
        Me.lblrate.Text = "Product Rate"
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(450, 251)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(142, 25)
        Me.dtp1.TabIndex = 11
        '
        'txtddno
        '
        Me.txtddno.Location = New System.Drawing.Point(449, 109)
        Me.txtddno.Name = "txtddno"
        Me.txtddno.Size = New System.Drawing.Size(143, 25)
        Me.txtddno.TabIndex = 9
        '
        'txtbamt
        '
        Me.txtbamt.Location = New System.Drawing.Point(450, 207)
        Me.txtbamt.Name = "txtbamt"
        Me.txtbamt.Size = New System.Drawing.Size(143, 25)
        Me.txtbamt.TabIndex = 10
        '
        'lblbamt
        '
        Me.lblbamt.AutoSize = True
        Me.lblbamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbamt.Location = New System.Drawing.Point(316, 219)
        Me.lblbamt.Name = "lblbamt"
        Me.lblbamt.Size = New System.Drawing.Size(120, 16)
        Me.lblbamt.TabIndex = 6
        Me.lblbamt.Text = "Balance Amount"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(330, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "  Supplier Account"
        '
        'txtpamt
        '
        Me.txtpamt.Location = New System.Drawing.Point(448, 23)
        Me.txtpamt.Name = "txtpamt"
        Me.txtpamt.Size = New System.Drawing.Size(144, 25)
        Me.txtpamt.TabIndex = 7
        '
        'txttamt
        '
        Me.txttamt.Location = New System.Drawing.Point(132, 251)
        Me.txttamt.Name = "txttamt"
        Me.txttamt.Size = New System.Drawing.Size(131, 25)
        Me.txttamt.TabIndex = 6
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(132, 207)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(124, 25)
        Me.txtqty.TabIndex = 5
        '
        'cmbname
        '
        Me.cmbname.FormattingEnabled = True
        Me.cmbname.Location = New System.Drawing.Point(132, 68)
        Me.cmbname.Name = "cmbname"
        Me.cmbname.Size = New System.Drawing.Size(125, 25)
        Me.cmbname.TabIndex = 2
        '
        'grpbox
        '
        Me.grpbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbox.BackColor = System.Drawing.SystemColors.Control
        Me.grpbox.Controls.Add(Me.Button3)
        Me.grpbox.Controls.Add(Me.TextBox3)
        Me.grpbox.Controls.Add(Me.Label8)
        Me.grpbox.Controls.Add(Me.Button2)
        Me.grpbox.Controls.Add(Me.TextBox2)
        Me.grpbox.Controls.Add(Me.Label7)
        Me.grpbox.Controls.Add(Me.Label5)
        Me.grpbox.Controls.Add(Me.Label6)
        Me.grpbox.Controls.Add(Me.Label4)
        Me.grpbox.Controls.Add(Me.Label3)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.Button1)
        Me.grpbox.Controls.Add(Me.ComboBox1)
        Me.grpbox.Controls.Add(Me.cmbrate)
        Me.grpbox.Controls.Add(Me.lblrate)
        Me.grpbox.Controls.Add(Me.dtp1)
        Me.grpbox.Controls.Add(Me.txtddno)
        Me.grpbox.Controls.Add(Me.txtbamt)
        Me.grpbox.Controls.Add(Me.lblbamt)
        Me.grpbox.Controls.Add(Me.txtpamt)
        Me.grpbox.Controls.Add(Me.txttamt)
        Me.grpbox.Controls.Add(Me.txtqty)
        Me.grpbox.Controls.Add(Me.cmbname)
        Me.grpbox.Controls.Add(Me.cmbmode)
        Me.grpbox.Controls.Add(Me.cmbproduct)
        Me.grpbox.Controls.Add(Me.btnexit)
        Me.grpbox.Controls.Add(Me.btnedit)
        Me.grpbox.Controls.Add(Me.btnsave)
        Me.grpbox.Controls.Add(Me.btnadd)
        Me.grpbox.Controls.Add(Me.lbldate)
        Me.grpbox.Controls.Add(Me.lblno)
        Me.grpbox.Controls.Add(Me.lblmode)
        Me.grpbox.Controls.Add(Me.lblpamt)
        Me.grpbox.Controls.Add(Me.lblamt)
        Me.grpbox.Controls.Add(Me.lblqty)
        Me.grpbox.Controls.Add(Me.lblproduct)
        Me.grpbox.Controls.Add(Me.lblid)
        Me.grpbox.Controls.Add(Me.lblbill)
        Me.grpbox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbox.Location = New System.Drawing.Point(181, 100)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(766, 402)
        Me.grpbox.TabIndex = 8
        Me.grpbox.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(615, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 34)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Add in balance"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(449, 158)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 25)
        Me.TextBox3.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(310, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = " Previous paid amt"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cyan
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(589, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = " subtract"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(450, 291)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(96, 25)
        Me.TextBox2.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = " Withdraw amt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(598, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = " Rs/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(598, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = " Rs/"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = " Rs/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = " Rs/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = " liter"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(433, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "SHOW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(132, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(131, 25)
        Me.ComboBox1.TabIndex = 1
        '
        'cmbmode
        '
        Me.cmbmode.FormattingEnabled = True
        Me.cmbmode.Location = New System.Drawing.Point(449, 65)
        Me.cmbmode.Name = "cmbmode"
        Me.cmbmode.Size = New System.Drawing.Size(143, 25)
        Me.cmbmode.TabIndex = 8
        '
        'supplier_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(978, 560)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpbox)
        Me.Name = "supplier_account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "petrol manage-supplieraccount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents lblpamt As System.Windows.Forms.Label
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblproduct As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblbill As System.Windows.Forms.Label
    Friend WithEvents cmbproduct As System.Windows.Forms.ComboBox
    Friend WithEvents cmbrate As System.Windows.Forms.ComboBox
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtddno As System.Windows.Forms.TextBox
    Friend WithEvents txtbamt As System.Windows.Forms.TextBox
    Friend WithEvents lblbamt As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpamt As System.Windows.Forms.TextBox
    Friend WithEvents txttamt As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents cmbname As System.Windows.Forms.ComboBox
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbmode As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
