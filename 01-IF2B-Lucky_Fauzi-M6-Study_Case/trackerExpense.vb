Public Class trackerExpense
    Dim transactionList As New List(Of ModelTransaction)

    Private Sub trackerExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With listData
            .Columns.Add("Date", 100, HorizontalAlignment.Left)
            .Columns.Add("Type", 100, HorizontalAlignment.Left)
            .Columns.Add("Total", 100, HorizontalAlignment.Left)
            .Columns.Add("Details", 200, HorizontalAlignment.Left)
            .View = View.Details
            .CheckBoxes = True
            .FullRowSelect = True
        End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dateValue As String = inputDate.Value.ToShortDateString()
        Dim total As Integer = CInt(inputTotalMoney.Text)
        Dim type As String = If(inputIncome.Checked, "Pemasukan", "Pengeluaran")
        Dim detail As String = inputDetail.Text

        transactionList.Add(New ModelTransaction(dateValue, total, type, detail))

        inputDate.Value = DateTime.Now
        inputTotalMoney.Clear()
        inputDetail.Clear()
        inputIncome.Checked = False
        inputExpense.Checked = False

        showTransactions()
        balanceCount()
        ResetForm()
    End Sub

    Public Sub showTransactions()
        listData.Items.Clear()
        For Each tr In transactionList
            Dim item As New ListViewItem(tr.TransactionDate.ToShortDateString)
            item.SubItems.Add(tr.Type)
            item.SubItems.Add(tr.Total.ToString("N0"))
            item.SubItems.Add(tr.Description)
            listData.Items.Add(item)
        Next
    End Sub

    Public Sub balanceCount()

        Dim balance As Decimal = 0
        Dim expense As Decimal = 0

        For Each tr In transactionList
            If tr.Type = "Pemasukan" Then
                balance += tr.Total
            Else
                expense += tr.Total
            End If
        Next
        lblBalance.Text = "Rp. " & balance.ToString("N0")
        lblExpense.Text = "Rp. " & expense.ToString("N0")
    End Sub

    Public Sub ResetForm()
        inputTotalMoney.Clear()
        inputDetail.Clear()
        inputIncome.Checked = False
        inputExpense.Checked = False
    End Sub
End Class

Public Class ModelTransaction
    Public Property TransactionDate As Date
    Public Property Total As Integer
    Public Property Type As String
    Public Property Description As String

    Public Sub New(tDate As Date, total As Integer, type As String, desc As String)
        Me.TransactionDate = tDate
        Me.Total = total
        Me.Type = type
        Me.Description = desc
    End Sub

End Class
