<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class trackerExpense
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        inputTotalMoney = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        inputDetail = New TextBox()
        Label3 = New Label()
        inputDate = New DateTimePicker()
        Label4 = New Label()
        inputIncome = New RadioButton()
        inputExpense = New RadioButton()
        Label5 = New Label()
        btnAdd = New Button()
        Label6 = New Label()
        listData = New ListView()
        btnDelete = New Button()
        Label7 = New Label()
        lblBalance = New Label()
        lblExpense = New Label()
        Label9 = New Label()
        btnEdit = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(318, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 24)
        Label1.TabIndex = 0
        Label1.Text = "Tracker Expense"
        ' 
        ' inputTotalMoney
        ' 
        inputTotalMoney.BackColor = SystemColors.Menu
        inputTotalMoney.BorderStyle = BorderStyle.None
        inputTotalMoney.Location = New Point(5, 7)
        inputTotalMoney.Margin = New Padding(10, 3, 3, 3)
        inputTotalMoney.Name = "inputTotalMoney"
        inputTotalMoney.PlaceholderText = "Masukan Jumlah Uang"
        inputTotalMoney.Size = New Size(190, 16)
        inputTotalMoney.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 22)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Menu
        Panel1.Controls.Add(inputTotalMoney)
        Panel1.Location = New Point(26, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 30)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Menu
        Panel2.Controls.Add(inputDetail)
        Panel2.Location = New Point(26, 152)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 30)
        Panel2.TabIndex = 5
        ' 
        ' inputDetail
        ' 
        inputDetail.BackColor = SystemColors.Menu
        inputDetail.BorderStyle = BorderStyle.None
        inputDetail.Location = New Point(5, 7)
        inputDetail.Margin = New Padding(10, 3, 3, 3)
        inputDetail.Name = "inputDetail"
        inputDetail.PlaceholderText = "Masukan keterangan"
        inputDetail.Size = New Size(190, 16)
        inputDetail.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 22)
        Label3.TabIndex = 4
        Label3.Text = "Keterangan"
        ' 
        ' inputDate
        ' 
        inputDate.CalendarMonthBackground = SystemColors.Menu
        inputDate.CalendarTitleBackColor = SystemColors.ControlText
        inputDate.CalendarTitleForeColor = Color.Black
        inputDate.CalendarTrailingForeColor = SystemColors.ButtonHighlight
        inputDate.Location = New Point(26, 232)
        inputDate.Name = "inputDate"
        inputDate.Size = New Size(200, 23)
        inputDate.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 22)
        Label4.TabIndex = 7
        Label4.Text = "Tanggal"
        ' 
        ' inputIncome
        ' 
        inputIncome.AutoSize = True
        inputIncome.Location = New Point(31, 320)
        inputIncome.Name = "inputIncome"
        inputIncome.Size = New Size(86, 19)
        inputIncome.TabIndex = 8
        inputIncome.TabStop = True
        inputIncome.Text = "Pemasukan"
        inputIncome.UseVisualStyleBackColor = True
        ' 
        ' inputExpense
        ' 
        inputExpense.AutoSize = True
        inputExpense.Location = New Point(135, 320)
        inputExpense.Name = "inputExpense"
        inputExpense.Size = New Size(91, 19)
        inputExpense.TabIndex = 9
        inputExpense.TabStop = True
        inputExpense.Text = "Pengeluaran"
        inputExpense.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(26, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 22)
        Label5.TabIndex = 10
        Label5.Text = "Tipe"
        ' 
        ' btnAdd
        ' 
        btnAdd.AutoSize = True
        btnAdd.BackColor = Color.YellowGreen
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Poppins Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ButtonHighlight
        btnAdd.Location = New Point(26, 382)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(200, 33)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Tambah Data"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(270, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 34)
        Label6.TabIndex = 12
        Label6.Text = "Daftar"
        ' 
        ' listData
        ' 
        listData.CheckBoxes = True
        listData.FullRowSelect = True
        listData.GridLines = True
        listData.Location = New Point(270, 103)
        listData.Name = "listData"
        listData.Size = New Size(496, 261)
        listData.TabIndex = 13
        listData.UseCompatibleStateImageBehavior = False
        listData.View = View.Details
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = True
        btnDelete.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ControlLightLight
        btnDelete.Location = New Point(647, 53)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(119, 33)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(270, 366)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 34)
        Label7.TabIndex = 15
        Label7.Text = "Pemasukan: "
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.BackColor = Color.Transparent
        lblBalance.FlatStyle = FlatStyle.Flat
        lblBalance.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBalance.Location = New Point(434, 366)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(44, 34)
        lblBalance.TabIndex = 16
        lblBalance.Text = "Rp."
        ' 
        ' lblExpense
        ' 
        lblExpense.AutoSize = True
        lblExpense.BackColor = Color.Transparent
        lblExpense.FlatStyle = FlatStyle.Flat
        lblExpense.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblExpense.Location = New Point(434, 398)
        lblExpense.Name = "lblExpense"
        lblExpense.Size = New Size(44, 34)
        lblExpense.TabIndex = 18
        lblExpense.Text = "Rp."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.FlatStyle = FlatStyle.Flat
        Label9.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(270, 398)
        Label9.Name = "Label9"
        Label9.Size = New Size(146, 34)
        Label9.TabIndex = 17
        Label9.Text = "Pengeluaran: "
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSize = True
        btnEdit.BackColor = Color.DarkTurquoise
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = SystemColors.ControlLightLight
        btnEdit.Location = New Point(513, 53)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(119, 33)
        btnEdit.TabIndex = 19
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' trackerExpense
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 462)
        Controls.Add(btnEdit)
        Controls.Add(lblExpense)
        Controls.Add(Label9)
        Controls.Add(lblBalance)
        Controls.Add(Label7)
        Controls.Add(btnDelete)
        Controls.Add(listData)
        Controls.Add(Label6)
        Controls.Add(btnAdd)
        Controls.Add(Label5)
        Controls.Add(inputExpense)
        Controls.Add(inputIncome)
        Controls.Add(Label4)
        Controls.Add(inputDate)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "trackerExpense"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tracker Expense"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputTotalMoney As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents inputDetail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inputDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents inputIncome As RadioButton
    Friend WithEvents inputExpense As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents listData As ListView
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblExpense As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEdit As Button

End Class
