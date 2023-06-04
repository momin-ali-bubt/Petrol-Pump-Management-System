<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product_testing
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
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.lblremark = New System.Windows.Forms.Label
        Me.lbltd = New System.Windows.Forms.Label
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.lblamt = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbrate = New System.Windows.Forms.ComboBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.lblqty = New System.Windows.Forms.Label
        Me.txttvar = New System.Windows.Forms.TextBox
        Me.lbltvar = New System.Windows.Forms.Label
        Me.txtdvar = New System.Windows.Forms.TextBox
        Me.txtptemp = New System.Windows.Forms.TextBox
        Me.txtpdensity = New System.Windows.Forms.TextBox
        Me.txtctemp = New System.Windows.Forms.TextBox
        Me.txtcdensity = New System.Windows.Forms.TextBox
        Me.lbldvar = New System.Windows.Forms.Label
        Me.lblpt = New System.Windows.Forms.Label
        Me.lblpd = New System.Windows.Forms.Label
        Me.lblct = New System.Windows.Forms.Label
        Me.lblcd = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.lblsrchid = New System.Windows.Forms.Label
        Me.grpsearchbox = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        Me.grpbox = New System.Windows.Forms.GroupBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.cmbprod = New System.Windows.Forms.ComboBox
        Me.lblprod = New System.Windows.Forms.Label
        Me.grpsearchbox.SuspendLayout()
        Me.grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(174, 19)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(109, 20)
        Me.dtp1.TabIndex = 24
        '
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(443, 157)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(103, 20)
        Me.txtremark.TabIndex = 22
        '
        'lblremark
        '
        Me.lblremark.AutoSize = True
        Me.lblremark.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremark.Location = New System.Drawing.Point(299, 158)
        Me.lblremark.Name = "lblremark"
        Me.lblremark.Size = New System.Drawing.Size(102, 17)
        Me.lblremark.TabIndex = 23
        Me.lblremark.Text = "Testing Remark"
        '
        'lbltd
        '
        Me.lbltd.AutoSize = True
        Me.lbltd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltd.Location = New System.Drawing.Point(24, 21)
        Me.lbltd.Name = "lbltd"
        Me.lbltd.Size = New System.Drawing.Size(84, 17)
        Me.lbltd.TabIndex = 11
        Me.lbltd.Text = "Testing Date"
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(443, 131)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(103, 20)
        Me.txtamt.TabIndex = 12
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(299, 132)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(102, 17)
        Me.lblamt.TabIndex = 21
        Me.lblamt.Text = "Testing Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Product Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(170, -9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 55)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "   Product Testing "
        '
        'cmbrate
        '
        Me.cmbrate.FormattingEnabled = True
        Me.cmbrate.Location = New System.Drawing.Point(174, 73)
        Me.cmbrate.Name = "cmbrate"
        Me.cmbrate.Size = New System.Drawing.Size(109, 21)
        Me.cmbrate.TabIndex = 25
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(174, 155)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(109, 20)
        Me.txtqty.TabIndex = 7
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(24, 156)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(58, 17)
        Me.lblqty.TabIndex = 19
        Me.lblqty.Text = "Quantity"
        '
        'txttvar
        '
        Me.txttvar.Location = New System.Drawing.Point(443, 103)
        Me.txttvar.Name = "txttvar"
        Me.txttvar.Size = New System.Drawing.Size(103, 20)
        Me.txttvar.TabIndex = 11
        '
        'lbltvar
        '
        Me.lbltvar.AutoSize = True
        Me.lbltvar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltvar.Location = New System.Drawing.Point(299, 104)
        Me.lbltvar.Name = "lbltvar"
        Me.lbltvar.Size = New System.Drawing.Size(142, 17)
        Me.lbltvar.TabIndex = 15
        Me.lbltvar.Text = "Temperature Variation"
        '
        'txtdvar
        '
        Me.txtdvar.Location = New System.Drawing.Point(443, 71)
        Me.txtdvar.Name = "txtdvar"
        Me.txtdvar.Size = New System.Drawing.Size(103, 20)
        Me.txtdvar.TabIndex = 10
        '
        'txtptemp
        '
        Me.txtptemp.Location = New System.Drawing.Point(443, 46)
        Me.txtptemp.Name = "txtptemp"
        Me.txtptemp.Size = New System.Drawing.Size(103, 20)
        Me.txtptemp.TabIndex = 9
        '
        'txtpdensity
        '
        Me.txtpdensity.Location = New System.Drawing.Point(443, 20)
        Me.txtpdensity.Name = "txtpdensity"
        Me.txtpdensity.Size = New System.Drawing.Size(103, 20)
        Me.txtpdensity.TabIndex = 8
        '
        'txtctemp
        '
        Me.txtctemp.Location = New System.Drawing.Point(174, 127)
        Me.txtctemp.Name = "txtctemp"
        Me.txtctemp.Size = New System.Drawing.Size(109, 20)
        Me.txtctemp.TabIndex = 6
        '
        'txtcdensity
        '
        Me.txtcdensity.Location = New System.Drawing.Point(174, 101)
        Me.txtcdensity.Name = "txtcdensity"
        Me.txtcdensity.Size = New System.Drawing.Size(109, 20)
        Me.txtcdensity.TabIndex = 5
        '
        'lbldvar
        '
        Me.lbldvar.AutoSize = True
        Me.lbldvar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldvar.Location = New System.Drawing.Point(299, 72)
        Me.lbldvar.Name = "lbldvar"
        Me.lbldvar.Size = New System.Drawing.Size(111, 17)
        Me.lbldvar.TabIndex = 4
        Me.lbldvar.Text = "Density Variation"
        '
        'lblpt
        '
        Me.lblpt.AutoSize = True
        Me.lblpt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpt.Location = New System.Drawing.Point(299, 47)
        Me.lblpt.Name = "lblpt"
        Me.lblpt.Size = New System.Drawing.Size(122, 17)
        Me.lblpt.TabIndex = 3
        Me.lblpt.Text = "Pump Temperature"
        '
        'lblpd
        '
        Me.lblpd.AutoSize = True
        Me.lblpd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpd.Location = New System.Drawing.Point(299, 21)
        Me.lblpd.Name = "lblpd"
        Me.lblpd.Size = New System.Drawing.Size(91, 17)
        Me.lblpd.TabIndex = 2
        Me.lblpd.Text = "Pump Density"
        '
        'lblct
        '
        Me.lblct.AutoSize = True
        Me.lblct.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblct.Location = New System.Drawing.Point(24, 128)
        Me.lblct.Name = "lblct"
        Me.lblct.Size = New System.Drawing.Size(144, 17)
        Me.lblct.TabIndex = 1
        Me.lblct.Text = "Company Temperature"
        '
        'lblcd
        '
        Me.lblcd.AutoSize = True
        Me.lblcd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcd.Location = New System.Drawing.Point(24, 100)
        Me.lblcd.Name = "lblcd"
        Me.lblcd.Size = New System.Drawing.Size(113, 17)
        Me.lblcd.TabIndex = 0
        Me.lblcd.Text = "Company Density"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(302, 202)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 15
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblsrchid
        '
        Me.lblsrchid.AutoSize = True
        Me.lblsrchid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsrchid.Location = New System.Drawing.Point(26, 29)
        Me.lblsrchid.Name = "lblsrchid"
        Me.lblsrchid.Size = New System.Drawing.Size(84, 17)
        Me.lblsrchid.TabIndex = 0
        Me.lblsrchid.Text = "Testing Date"
        '
        'grpsearchbox
        '
        Me.grpsearchbox.Controls.Add(Me.Button1)
        Me.grpsearchbox.Controls.Add(Me.txtid)
        Me.grpsearchbox.Controls.Add(Me.lblsrchid)
        Me.grpsearchbox.Location = New System.Drawing.Point(169, 295)
        Me.grpsearchbox.Name = "grpsearchbox"
        Me.grpsearchbox.Size = New System.Drawing.Size(363, 67)
        Me.grpsearchbox.TabIndex = 11
        Me.grpsearchbox.TabStop = False
        Me.grpsearchbox.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(129, 26)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 16
        '
        'grpbox
        '
        Me.grpbox.Controls.Add(Me.cmbrate)
        Me.grpbox.Controls.Add(Me.Label2)
        Me.grpbox.Controls.Add(Me.dtp1)
        Me.grpbox.Controls.Add(Me.txtremark)
        Me.grpbox.Controls.Add(Me.lblremark)
        Me.grpbox.Controls.Add(Me.lbltd)
        Me.grpbox.Controls.Add(Me.txtamt)
        Me.grpbox.Controls.Add(Me.lblamt)
        Me.grpbox.Controls.Add(Me.txtqty)
        Me.grpbox.Controls.Add(Me.lblqty)
        Me.grpbox.Controls.Add(Me.txttvar)
        Me.grpbox.Controls.Add(Me.lbltvar)
        Me.grpbox.Controls.Add(Me.btnexit)
        Me.grpbox.Controls.Add(Me.btnsave)
        Me.grpbox.Controls.Add(Me.btnadd)
        Me.grpbox.Controls.Add(Me.cmbprod)
        Me.grpbox.Controls.Add(Me.lblprod)
        Me.grpbox.Controls.Add(Me.txtdvar)
        Me.grpbox.Controls.Add(Me.txtptemp)
        Me.grpbox.Controls.Add(Me.txtpdensity)
        Me.grpbox.Controls.Add(Me.txtctemp)
        Me.grpbox.Controls.Add(Me.txtcdensity)
        Me.grpbox.Controls.Add(Me.lbldvar)
        Me.grpbox.Controls.Add(Me.lblpt)
        Me.grpbox.Controls.Add(Me.lblpd)
        Me.grpbox.Controls.Add(Me.lblct)
        Me.grpbox.Controls.Add(Me.lblcd)
        Me.grpbox.Location = New System.Drawing.Point(64, 54)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(568, 235)
        Me.grpbox.TabIndex = 9
        Me.grpbox.TabStop = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(189, 202)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(75, 202)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cmbprod
        '
        Me.cmbprod.FormattingEnabled = True
        Me.cmbprod.Location = New System.Drawing.Point(174, 46)
        Me.cmbprod.Name = "cmbprod"
        Me.cmbprod.Size = New System.Drawing.Size(109, 21)
        Me.cmbprod.TabIndex = 2
        '
        'lblprod
        '
        Me.lblprod.AutoSize = True
        Me.lblprod.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprod.Location = New System.Drawing.Point(24, 47)
        Me.lblprod.Name = "lblprod"
        Me.lblprod.Size = New System.Drawing.Size(94, 17)
        Me.lblprod.TabIndex = 14
        Me.lblprod.Text = "Select Product"
        '
        'product_testing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 378)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpsearchbox)
        Me.Controls.Add(Me.grpbox)
        Me.Name = "product_testing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "  petrol manage-producttesting"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpsearchbox.ResumeLayout(False)
        Me.grpsearchbox.PerformLayout()
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents lblremark As System.Windows.Forms.Label
    Friend WithEvents lbltd As System.Windows.Forms.Label
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbrate As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents txttvar As System.Windows.Forms.TextBox
    Friend WithEvents lbltvar As System.Windows.Forms.Label
    Friend WithEvents txtdvar As System.Windows.Forms.TextBox
    Friend WithEvents txtptemp As System.Windows.Forms.TextBox
    Friend WithEvents txtpdensity As System.Windows.Forms.TextBox
    Friend WithEvents txtctemp As System.Windows.Forms.TextBox
    Friend WithEvents txtcdensity As System.Windows.Forms.TextBox
    Friend WithEvents lbldvar As System.Windows.Forms.Label
    Friend WithEvents lblpt As System.Windows.Forms.Label
    Friend WithEvents lblpd As System.Windows.Forms.Label
    Friend WithEvents lblct As System.Windows.Forms.Label
    Friend WithEvents lblcd As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblsrchid As System.Windows.Forms.Label
    Friend WithEvents grpsearchbox As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cmbprod As System.Windows.Forms.ComboBox
    Friend WithEvents lblprod As System.Windows.Forms.Label
End Class
