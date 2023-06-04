<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product_order
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnorder = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.cmbrate = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbsname = New System.Windows.Forms.ComboBox
        Me.grpbox = New System.Windows.Forms.GroupBox
        Me.saveorder = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.cmborder = New System.Windows.Forms.ComboBox
        Me.txtordered = New System.Windows.Forms.TextBox
        Me.lblqtyorder = New System.Windows.Forms.Label
        Me.lblrate = New System.Windows.Forms.Label
        Me.lblporder = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Supplier Name"
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Cyan
        Me.btnexit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(494, 293)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(79, 39)
        Me.btnexit.TabIndex = 10
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Cyan
        Me.btndelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(305, 298)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(79, 34)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Cyan
        Me.btnedit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(210, 298)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(79, 34)
        Me.btnedit.TabIndex = 8
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnorder
        '
        Me.btnorder.BackColor = System.Drawing.Color.Cyan
        Me.btnorder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorder.Location = New System.Drawing.Point(394, 294)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(79, 38)
        Me.btnorder.TabIndex = 7
        Me.btnorder.Text = "SHOW"
        Me.btnorder.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Cyan
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(6, 298)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(79, 38)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'cmbrate
        '
        Me.cmbrate.FormattingEnabled = True
        Me.cmbrate.Items.AddRange(New Object() {"50", "100", "200", "500", "600", "700", ""})
        Me.cmbrate.Location = New System.Drawing.Point(394, 91)
        Me.cmbrate.Name = "cmbrate"
        Me.cmbrate.Size = New System.Drawing.Size(127, 21)
        Me.cmbrate.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(139, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(99, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 55)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "   Product Order Details"
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(235, 205)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(127, 20)
        Me.txtamt.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Order Amount"
        '
        'cmbsname
        '
        Me.cmbsname.FormattingEnabled = True
        Me.cmbsname.Location = New System.Drawing.Point(394, 38)
        Me.cmbsname.Name = "cmbsname"
        Me.cmbsname.Size = New System.Drawing.Size(127, 21)
        Me.cmbsname.TabIndex = 4
        '
        'grpbox
        '
        Me.grpbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbox.Controls.Add(Me.saveorder)
        Me.grpbox.Controls.Add(Me.ComboBox1)
        Me.grpbox.Controls.Add(Me.cmbrate)
        Me.grpbox.Controls.Add(Me.DateTimePicker1)
        Me.grpbox.Controls.Add(Me.Label4)
        Me.grpbox.Controls.Add(Me.txtamt)
        Me.grpbox.Controls.Add(Me.Label3)
        Me.grpbox.Controls.Add(Me.cmbsname)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.btnexit)
        Me.grpbox.Controls.Add(Me.btndelete)
        Me.grpbox.Controls.Add(Me.btnedit)
        Me.grpbox.Controls.Add(Me.btnorder)
        Me.grpbox.Controls.Add(Me.btnadd)
        Me.grpbox.Controls.Add(Me.cmborder)
        Me.grpbox.Controls.Add(Me.txtordered)
        Me.grpbox.Controls.Add(Me.lblqtyorder)
        Me.grpbox.Controls.Add(Me.lblrate)
        Me.grpbox.Controls.Add(Me.lblporder)
        Me.grpbox.Controls.Add(Me.lblid)
        Me.grpbox.Location = New System.Drawing.Point(72, 110)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(592, 356)
        Me.grpbox.TabIndex = 13
        Me.grpbox.TabStop = False
        '
        'saveorder
        '
        Me.saveorder.BackColor = System.Drawing.Color.Cyan
        Me.saveorder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveorder.Location = New System.Drawing.Point(105, 298)
        Me.saveorder.Name = "saveorder"
        Me.saveorder.Size = New System.Drawing.Size(79, 36)
        Me.saveorder.TabIndex = 36
        Me.saveorder.Text = "SAVE"
        Me.saveorder.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'cmborder
        '
        Me.cmborder.FormattingEnabled = True
        Me.cmborder.Items.AddRange(New Object() {"petrol", "disel", "greece", "oil", "lubricant"})
        Me.cmborder.Location = New System.Drawing.Point(140, 142)
        Me.cmborder.Name = "cmborder"
        Me.cmborder.Size = New System.Drawing.Size(120, 21)
        Me.cmborder.TabIndex = 3
        '
        'txtordered
        '
        Me.txtordered.Location = New System.Drawing.Point(394, 139)
        Me.txtordered.Name = "txtordered"
        Me.txtordered.Size = New System.Drawing.Size(127, 20)
        Me.txtordered.TabIndex = 6
        '
        'lblqtyorder
        '
        Me.lblqtyorder.AutoSize = True
        Me.lblqtyorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqtyorder.Location = New System.Drawing.Point(287, 142)
        Me.lblqtyorder.Name = "lblqtyorder"
        Me.lblqtyorder.Size = New System.Drawing.Size(107, 16)
        Me.lblqtyorder.TabIndex = 3
        Me.lblqtyorder.Text = "Quantity Order"
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(287, 91)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(98, 16)
        Me.lblrate.TabIndex = 2
        Me.lblrate.Text = "Product Rate"
        '
        'lblporder
        '
        Me.lblporder.AutoSize = True
        Me.lblporder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporder.Location = New System.Drawing.Point(34, 142)
        Me.lblporder.Name = "lblporder"
        Me.lblporder.Size = New System.Drawing.Size(104, 16)
        Me.lblporder.TabIndex = 1
        Me.lblporder.Text = "Product Order"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(40, 38)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(64, 16)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Order Id"
        '
        'product_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(729, 522)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpbox)
        Me.Name = "product_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "petrol manage-productorder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cmbrate As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbsname As System.Windows.Forms.ComboBox
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents cmborder As System.Windows.Forms.ComboBox
    Friend WithEvents txtordered As System.Windows.Forms.TextBox
    Friend WithEvents lblqtyorder As System.Windows.Forms.Label
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents lblporder As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents saveorder As System.Windows.Forms.Button
End Class
