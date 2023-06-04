Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data

Public Class MDIform
    Public con As String
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub BankAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankAccountToolStripMenuItem.Click
        baccount = New bank_Account
        baccount.Show()
    End Sub

    Private Sub CustomerAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerAccountToolStripMenuItem.Click
        caccount = New customer_account
        caccount.Show()
    End Sub

    Private Sub SupplierAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierAccountToolStripMenuItem.Click
        suppaccount = New supplier_account
        suppaccount.Show()

    End Sub

    Private Sub BankDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankDetailToolStripMenuItem.Click
        bdetails = New bank_details
        bdetails.Show()

    End Sub

    Private Sub CustomerDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailToolStripMenuItem.Click
        cdetail = New customer_detail
        cdetail.Show()
    End Sub

    Private Sub EmployeeDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailToolStripMenuItem.Click
        edetails = New emplyoees_details
        edetails.Show()
    End Sub

    Private Sub ProductDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductDetailToolStripMenuItem.Click
        pdetail = New productstockdetail
        pdetail.Show()
    End Sub

    Private Sub SupplierDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierDetailsToolStripMenuItem.Click
        suppdetail = New supplier_details
        suppdetail.Show()
    End Sub

    Private Sub LubricantDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LubricantDetailToolStripMenuItem.Click
        lbricant = New lubricants_details
        lbricant.Show()

    End Sub

    Private Sub LedgerDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgerDetailToolStripMenuItem.Click
        ledger = New ledgerdetails
        ledger.Show()
    End Sub

    Private Sub DailyTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyTransactionToolStripMenuItem.Click
        dtransaction = New ds
        dtransaction.Show()
    End Sub

    Private Sub OrderFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderFormToolStripMenuItem.Click
        porder = New product_order
        porder.Show()

    End Sub



    'Private Sub BoothTestingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    bsetting = New booth_settings
    '    bsetting.Show()
    'End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ab = New about
        ab.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub MDIform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jibon\Documents\Visual Studio 2019\Projects\petrolmanagesystem\database\db1.mdb"
        'MessageBox.Show("WELCOME TO SYSTEM")
    End Sub


    Private Sub AvailableStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProductStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductStockToolStripMenuItem.Click
        stock.Show()
    End Sub

    Private Sub CustomerAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerAccountToolStripMenuItem1.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BankAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankAccountToolStripMenuItem1.Click
        bankaccrpt.Show()
    End Sub

    Private Sub BankDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankDetailToolStripMenuItem1.Click
        bankdetailrpt.Show()
    End Sub

    'Private Sub BoothReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoothReportToolStripMenuItem.Click
    '    boothsetingrpt.Show()
    'End Sub

    Private Sub CustomerAccountToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerAccountToolStripMenuItem2.Click
        customeraccountrpt.Show()
    End Sub

    Private Sub CustomerDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailToolStripMenuItem1.Click
        customerdetailrpt.Show()
    End Sub

    Private Sub SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem.Click
        supplieraccountrpt.Show()
    End Sub

    Private Sub EmployeeDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailToolStripMenuItem1.Click
        empdetailrpt.Show()
    End Sub

    Private Sub ProductDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductDetailToolStripMenuItem1.Click
        prodetailrpt.Show()
    End Sub

    Private Sub SupplierDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierDetailToolStripMenuItem.Click
        supplierdetailrpt.Show()
    End Sub

    Private Sub LubricantDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LubricantDetailToolStripMenuItem1.Click
        lubricantdetailrpt.Show()
    End Sub

    Private Sub LedgerDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgerDetailToolStripMenuItem1.Click
        ledgerdetailrpt.Show()
    End Sub

    Private Sub ProductReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductReportToolStripMenuItem.Click
        productorderrpt.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        pdetails = New product_details
        pdetails.Show()
    End Sub

    Private Sub SupplierWithdrawToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierWithdrawToolStripMenuItem.Click
        pdetailss = New Supplier_withdraw_pump_bank_detail
        pdetailss.Show()
    End Sub

    Private Sub CustomerDipositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDipositToolStripMenuItem.Click
        cdiposit = New customer_diposit_pump_bank_detail
        cdiposit.Show()
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DToolStripMenuItem.Click
        dttt = New dttrpt
        dttt.Show()
    End Sub

    Private Sub SuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuToolStripMenuItem.Click
        suwithdraw = New suppwithrpt
        suwithdraw.Show()
    End Sub

    Private Sub CustomerDipositToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDipositToolStripMenuItem1.Click
        custdi = New custdipositrpt
        custdi.Show()
    End Sub

    Private Sub FinalAmountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalAmountToolStripMenuItem.Click
        dtttt = New Famtrpt
        dtttt.Show()
    End Sub

    Private Sub StockRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockRecordToolStripMenuItem.Click
        ppp = New prostockrpt
        ppp.Show()
    End Sub

    Private Sub BillToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem1.Click
        pppp = New billcustomer
        pppp.Show()
    End Sub
End Class
