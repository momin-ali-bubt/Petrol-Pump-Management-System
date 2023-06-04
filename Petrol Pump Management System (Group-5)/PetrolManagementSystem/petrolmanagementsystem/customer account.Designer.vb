<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_account
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
        Me.cmbmode = New System.Windows.Forms.ComboBox
        Me.cmbproduct = New System.Windows.Forms.ComboBox
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.txtddno = New System.Windows.Forms.TextBox
        Me.txtbamt = New System.Windows.Forms.TextBox
        Me.grpbox = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbrate = New System.Windows.Forms.ComboBox
        Me.lblrate = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txttamt = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblno = New System.Windows.Forms.Label
        Me.lblmode = New System.Windows.Forms.Label
        Me.lblbamt = New System.Windows.Forms.Label
        Me.lblamt = New System.Windows.Forms.Label
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblproduct = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.lblslip = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbmode
        '
        Me.cmbmode.FormattingEnabled = True
        Me.cmbmode.Location = New System.Drawing.Point(404, 19)
        Me.cmbmode.Name = "cmbmode"
        Me.cmbmode.Size = New System.Drawing.Size(144, 21)
        Me.cmbmode.TabIndex = 7
        '
        'cmbproduct
        '
        Me.cmbproduct.FormattingEnabled = True
        Me.cmbproduct.Items.AddRange(New Object() {"petrol", "disel", "oil", "grice"})
        Me.cmbproduct.Location = New System.Drawing.Point(120, 81)
        Me.cmbproduct.Name = "cmbproduct"
        Me.cmbproduct.Size = New System.Drawing.Size(144, 21)
        Me.cmbproduct.TabIndex = 3
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Cyan
        Me.btnexit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(344, 287)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 40)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Cyan
        Me.btnedit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(250, 287)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 40)
        Me.btnedit.TabIndex = 12
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'txtddno
        '
        Me.txtddno.Location = New System.Drawing.Point(404, 64)
        Me.txtddno.Name = "txtddno"
        Me.txtddno.Size = New System.Drawing.Size(144, 20)
        Me.txtddno.TabIndex = 7
        '
        'txtbamt
        '
        Me.txtbamt.Location = New System.Drawing.Point(404, 111)
        Me.txtbamt.Name = "txtbamt"
        Me.txtbamt.Size = New System.Drawing.Size(144, 20)
        Me.txtbamt.TabIndex = 8
        '
        'grpbox
        '
        Me.grpbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbox.Controls.Add(Me.Button2)
        Me.grpbox.Controls.Add(Me.TextBox2)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.cmbrate)
        Me.grpbox.Controls.Add(Me.lblrate)
        Me.grpbox.Controls.Add(Me.Button1)
        Me.grpbox.Controls.Add(Me.TextBox1)
        Me.grpbox.Controls.Add(Me.DateTimePicker1)
        Me.grpbox.Controls.Add(Me.ComboBox1)
        Me.grpbox.Controls.Add(Me.txtddno)
        Me.grpbox.Controls.Add(Me.txtbamt)
        Me.grpbox.Controls.Add(Me.txttamt)
        Me.grpbox.Controls.Add(Me.txtqty)
        Me.grpbox.Controls.Add(Me.cmbmode)
        Me.grpbox.Controls.Add(Me.cmbproduct)
        Me.grpbox.Controls.Add(Me.btnexit)
        Me.grpbox.Controls.Add(Me.btnedit)
        Me.grpbox.Controls.Add(Me.btnsave)
        Me.grpbox.Controls.Add(Me.btnadd)
        Me.grpbox.Controls.Add(Me.lbldate)
        Me.grpbox.Controls.Add(Me.lblno)
        Me.grpbox.Controls.Add(Me.lblmode)
        Me.grpbox.Controls.Add(Me.lblbamt)
        Me.grpbox.Controls.Add(Me.lblamt)
        Me.grpbox.Controls.Add(Me.lblqty)
        Me.grpbox.Controls.Add(Me.lblproduct)
        Me.grpbox.Controls.Add(Me.lblname)
        Me.grpbox.Controls.Add(Me.lblslip)
        Me.grpbox.Location = New System.Drawing.Point(101, 168)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(568, 345)
        Me.grpbox.TabIndex = 5
        Me.grpbox.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cyan
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(473, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(355, 209)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(96, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = " Add amt"
        '
        'cmbrate
        '
        Me.cmbrate.FormattingEnabled = True
        Me.cmbrate.Items.AddRange(New Object() {"100", "200", "400", "600", "1000", "10000"})
        Me.cmbrate.Location = New System.Drawing.Point(120, 123)
        Me.cmbrate.Name = "cmbrate"
        Me.cmbrate.Size = New System.Drawing.Size(144, 21)
        Me.cmbrate.TabIndex = 6
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(9, 127)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(90, 16)
        Me.lblrate.TabIndex = 26
        Me.lblrate.Text = "Product Rate"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(440, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "SHOW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(404, 150)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'txttamt
        '
        Me.txttamt.Location = New System.Drawing.Point(120, 202)
        Me.txttamt.Name = "txttamt"
        Me.txttamt.Size = New System.Drawing.Size(144, 20)
        Me.txttamt.TabIndex = 5
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(120, 165)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(144, 20)
        Me.txtqty.TabIndex = 4
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Cyan
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(152, 287)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 40)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Cyan
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(56, 287)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 40)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(288, 152)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(115, 16)
        Me.lbldate.TabIndex = 9
        Me.lbldate.Text = "Transaction Date"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.Location = New System.Drawing.Point(291, 64)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(88, 16)
        Me.lblno.TabIndex = 8
        Me.lblno.Text = "Chq / DD No."
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmode.Location = New System.Drawing.Point(288, 17)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(119, 16)
        Me.lblmode.TabIndex = 7
        Me.lblmode.Text = "Mode of Payment"
        '
        'lblbamt
        '
        Me.lblbamt.AutoSize = True
        Me.lblbamt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbamt.Location = New System.Drawing.Point(288, 111)
        Me.lblbamt.Name = "lblbamt"
        Me.lblbamt.Size = New System.Drawing.Size(113, 16)
        Me.lblbamt.TabIndex = 6
        Me.lblbamt.Text = "Balance Amount"
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(9, 205)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(93, 16)
        Me.lblamt.TabIndex = 4
        Me.lblamt.Text = "Total Amount"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(9, 168)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(61, 16)
        Me.lblqty.TabIndex = 3
        Me.lblqty.Text = "Quantity"
        '
        'lblproduct
        '
        Me.lblproduct.AutoSize = True
        Me.lblproduct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproduct.Location = New System.Drawing.Point(9, 85)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(57, 16)
        Me.lblproduct.TabIndex = 2
        Me.lblproduct.Text = "Product"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(9, 53)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(109, 16)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Customer Name"
        '
        'lblslip
        '
        Me.lblslip.AutoSize = True
        Me.lblslip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblslip.Location = New System.Drawing.Point(9, 16)
        Me.lblslip.Name = "lblslip"
        Me.lblslip.Size = New System.Drawing.Size(80, 16)
        Me.lblslip.TabIndex = 0
        Me.lblslip.Text = " Cust Ac No"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(185, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "   Customer Account"
        '
        'customer_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(770, 543)
        Me.Controls.Add(Me.grpbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "customer_account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = " petrol manage-customeraccount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbmode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbproduct As System.Windows.Forms.ComboBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents txtddno As System.Windows.Forms.TextBox
    Friend WithEvents txtbamt As System.Windows.Forms.TextBox
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents txttamt As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents lblbamt As System.Windows.Forms.Label
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblproduct As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblslip As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents cmbrate As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
