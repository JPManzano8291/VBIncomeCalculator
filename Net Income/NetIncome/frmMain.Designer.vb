<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        gbCategory = New GroupBox()
        cbEmpStat = New ComboBox()
        GroupBox1 = New GroupBox()
        btnClear = New Button()
        btnCalculate = New Button()
        Label2 = New Label()
        Label1 = New Label()
        tbIncome = New TextBox()
        cbIncomeOpt = New ComboBox()
        GroupBox2 = New GroupBox()
        lblIncomeOpt = New Label()
        lblStatus = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        tbNetAnInc = New TextBox()
        tbNetMonPay = New TextBox()
        tbBiMonNet = New TextBox()
        gbCategory.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbCategory
        ' 
        gbCategory.Controls.Add(cbEmpStat)
        gbCategory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbCategory.Location = New Point(70, 32)
        gbCategory.Name = "gbCategory"
        gbCategory.Size = New Size(212, 163)
        gbCategory.TabIndex = 0
        gbCategory.TabStop = False
        gbCategory.Text = "Employment Status"
        ' 
        ' cbEmpStat
        ' 
        cbEmpStat.DropDownStyle = ComboBoxStyle.DropDownList
        cbEmpStat.FormattingEnabled = True
        cbEmpStat.Items.AddRange(New Object() {"Employed", "Self Employed", "Government Official"})
        cbEmpStat.Location = New Point(6, 77)
        cbEmpStat.Name = "cbEmpStat"
        cbEmpStat.Size = New Size(200, 29)
        cbEmpStat.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(btnCalculate)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbIncome)
        GroupBox1.Controls.Add(cbIncomeOpt)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(306, 32)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(443, 163)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(289, 47)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(103, 37)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(289, 104)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(103, 37)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 21)
        Label2.TabIndex = 3
        Label2.Text = "Income"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 21)
        Label1.TabIndex = 2
        Label1.Text = "Income Option"
        ' 
        ' tbIncome
        ' 
        tbIncome.Location = New Point(49, 109)
        tbIncome.Name = "tbIncome"
        tbIncome.Size = New Size(157, 29)
        tbIncome.TabIndex = 1
        ' 
        ' cbIncomeOpt
        ' 
        cbIncomeOpt.DropDownStyle = ComboBoxStyle.DropDownList
        cbIncomeOpt.FormattingEnabled = True
        cbIncomeOpt.Items.AddRange(New Object() {"Monthly Income", "Annual Income"})
        cbIncomeOpt.Location = New Point(49, 44)
        cbIncomeOpt.Name = "cbIncomeOpt"
        cbIncomeOpt.Size = New Size(157, 29)
        cbIncomeOpt.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblIncomeOpt)
        GroupBox2.Controls.Add(lblStatus)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(tbNetAnInc)
        GroupBox2.Controls.Add(tbNetMonPay)
        GroupBox2.Controls.Add(tbBiMonNet)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(53, 212)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(705, 212)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Net Pay"
        ' 
        ' lblIncomeOpt
        ' 
        lblIncomeOpt.AutoSize = True
        lblIncomeOpt.Location = New Point(440, 25)
        lblIncomeOpt.Name = "lblIncomeOpt"
        lblIncomeOpt.Size = New Size(67, 21)
        lblIncomeOpt.TabIndex = 13
        lblIncomeOpt.Text = "Income"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(209, 25)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(57, 21)
        lblStatus.TabIndex = 12
        lblStatus.Text = "Status"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(517, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 21)
        Label5.TabIndex = 11
        Label5.Text = "Net Annual Income"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(287, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 21)
        Label4.TabIndex = 10
        Label4.Text = "Net Monthly Pay"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 21)
        Label3.TabIndex = 9
        Label3.Text = "Bi-Monthly Netpay"
        ' 
        ' tbNetAnInc
        ' 
        tbNetAnInc.Location = New Point(517, 106)
        tbNetAnInc.Name = "tbNetAnInc"
        tbNetAnInc.ReadOnly = True
        tbNetAnInc.Size = New Size(157, 29)
        tbNetAnInc.TabIndex = 8
        ' 
        ' tbNetMonPay
        ' 
        tbNetMonPay.Location = New Point(276, 106)
        tbNetMonPay.Name = "tbNetMonPay"
        tbNetMonPay.ReadOnly = True
        tbNetMonPay.Size = New Size(157, 29)
        tbNetMonPay.TabIndex = 7
        ' 
        ' tbBiMonNet
        ' 
        tbBiMonNet.Location = New Point(47, 106)
        tbBiMonNet.Name = "tbBiMonNet"
        tbBiMonNet.ReadOnly = True
        tbBiMonNet.Size = New Size(157, 29)
        tbBiMonNet.TabIndex = 6
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Khaki
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(gbCategory)
        Name = "MainForm"
        Text = "Income Calculator"
        gbCategory.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbCategory As GroupBox
    Friend WithEvents cbEmpStat As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbIncomeOpt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbIncome As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbNetAnInc As TextBox
    Friend WithEvents tbNetMonPay As TextBox
    Friend WithEvents tbBiMonNet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblIncomeOpt As Label

End Class
