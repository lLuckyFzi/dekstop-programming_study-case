Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class trackerExpense
    Dim transactionList As New List(Of ModelTransaction)
    Dim isEditMode As Boolean = False
    Dim selectedItem As Integer = -1

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

        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dateValue As String = inputDate.Value.ToShortDateString()
        Dim total As Decimal
        Dim type As String = If(inputIncome.Checked, "Pemasukan", "Pengeluaran")
        Dim detail As String = inputDetail.Text

        If Not Decimal.TryParse(inputTotalMoney.Text, total) Then
            MessageBox.Show("Input is not valid! Masukkan input Jumlah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If type = "" Or detail = "" Then
            MessageBox.Show("Please input the requirement fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If isEditMode Then
            transactionList(selectedItem).Total = total
            transactionList(selectedItem).Description = detail
            transactionList(selectedItem).TransactionDate = dateValue
            transactionList(selectedItem).Type = type

            isEditMode = False
            selectedItem = -1
            btnAdd.Text = "Tambah Data"
        Else
            transactionList.Add(New ModelTransaction(dateValue, total, type, detail))
        End If

        inputDate.Value = DateTime.Now
        inputTotalMoney.Clear()
        inputDetail.Clear()
        inputIncome.Checked = False
        inputExpense.Checked = False

        showTransactions()
        balanceCount()
        ResetForm()
    End Sub

    Private Sub listData_Checkbox(sender As Object, e As EventArgs) Handles listData.ItemChecked
        Dim checkedItems As Integer = listData.CheckedItems.Count
        btnDelete.Enabled = (checkedItems > 0)
        btnEdit.Enabled = (checkedItems = 1)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i As Integer = listData.Items.Count - 1 To 0 Step -1
            If listData.Items(i).Checked Then
                transactionList.RemoveAt(i)
            End If
        Next

        showTransactions()
        balanceCount()
        ResetForm()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If listData.CheckedItems.Count <> 1 Then Exit Sub

        selectedItem = listData.CheckedItems(0).Index
        Dim data = transactionList(selectedItem)

        inputTotalMoney.Text = data.Total
        inputDetail.Text = data.Description
        inputDate.Value = data.TransactionDate
        inputIncome.Checked = (data.Type = "Pemasukan")
        inputExpense.Checked = (data.Type = "Pengeluaran")

        btnAdd.Text = "Simpan Data"
        isEditMode = True
        btnDelete.Enabled = False
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
        btnDelete.Enabled = False
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
