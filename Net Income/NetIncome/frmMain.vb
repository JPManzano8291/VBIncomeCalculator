Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Will Check if the combo box have Selected Item or Not
        If cbEmpStat.SelectedItem IsNot Nothing Then
            lblStatus.Text = cbEmpStat.SelectedItem.ToString()
        Else
            MessageBox.Show("Please Select an Item From the  Emploment Status Combo Box.")
        End If

        If cbIncomeOpt.SelectedItem IsNot Nothing Then
            lblIncomeOpt.Text = cbIncomeOpt.SelectedItem.ToString()
        Else
            MessageBox.Show("Please Select an Item From the Income Option Combo Box.")
        End If

        Try
            'Operation of Salary Input
            Dim income As Double = Double.Parse(tbIncome.Text)

            If cbIncomeOpt.SelectedItem.ToString = "Monthly Income" Then

                'This are Variables for calculation
                Dim yearIncome As Double = income * 12
                Dim excess As Double
                Dim taxExcess As Double
                Dim totalAnnualTax As Double
                Dim totalPagIbigCon As Double
                Dim totalGSISCon As Double
                Dim totalSSSCon As Double
                Dim totalPhilHealth As Double
                Dim totalContri_Tax As Double
                'Outputs
                Dim netAnnualIncome As Double
                Dim netMonPay As Double
                Dim netBiMonPay As Double

                'Calculation For Annual Tax
                If yearIncome > 250000.0 And yearIncome <= 400000.0 Then

                    Dim taxRate As Double = 0.15
                    excess = yearIncome - 250000.0


                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = taxExcess

                ElseIf yearIncome > 400000 And yearIncome <= 800000 Then

                    Dim taxRate As Double = 0.2
                    Dim fixTax As Double = 22500.0

                    excess = yearIncome - 400000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess

                ElseIf yearIncome > 800000 And yearIncome <= 2000000 Then

                    Dim taxRate As Double = 0.25
                    Dim fixTax As Double = 102500.0

                    excess = yearIncome - 800000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess

                ElseIf yearIncome > 2000000 And yearIncome <= 8000000 Then

                    Dim taxRate As Double = 0.3
                    Dim fixTax As Double = 402500.0

                    excess = yearIncome - 2000000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess

                ElseIf yearIncome > 8000000 Then

                    Dim taxRate As Double = 0.35
                    Dim fixTax As Double = 2202500.0

                    excess = yearIncome - 8000000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess
                End If

                'Calculation for Pag Ibig
                If income <= 1500 Then

                    Dim taxRate As Double = 0.01
                    Dim tax As Double

                    tax = income * taxRate
                    totalPagIbigCon = tax * 12

                ElseIf income > 1500 Then

                    Dim taxRate As Double = 0.02
                    Dim tax As Double

                    tax = income * taxRate
                    totalPagIbigCon = tax * 12

                End If

                'Calculation for GSIS if Government Official

                If cbEmpStat.SelectedItem.ToString = "Government Official" Then

                    Dim month = income * 0.09

                    totalGSISCon = month * 12

                Else
                    'Calculation for SSS when monthly salary is min 4000 and max 30000
                    If income >= 4000 And income <= 30000 Then

                        Dim month = income * 0.14
                        totalSSSCon = month * 12

                    End If

                End If

                If income >= 10000 And income <= 100000 Then

                    Dim month = income * 0.05
                    totalPhilHealth = month * 12

                End If

                'Calculation for total Contribution or Tax
                totalContri_Tax = totalAnnualTax + totalPagIbigCon + totalSSSCon + totalGSISCon + totalPhilHealth

                netAnnualIncome = yearIncome - totalContri_Tax

                netMonPay = netAnnualIncome / 12
                netBiMonPay = netMonPay / 2

                tbBiMonNet.Text = netBiMonPay.ToString("0.00")
                tbNetMonPay.Text = netMonPay.ToString("0.00")
                tbNetAnInc.Text = netAnnualIncome.ToString("0.00")

                'Calculation for Annual Income Input
            Else

                'This are Variables for calculation
                Dim yearIncome As Double = income
                Dim excess As Double
                Dim taxExcess As Double
                Dim totalAnnualTax As Double
                Dim totalPagIbigCon As Double
                Dim totalGSISCon As Double
                Dim totalSSSCon As Double
                Dim totalPhilHealth As Double
                Dim totalContri_Tax As Double
                'Outputs
                Dim netAnnualIncome As Double
                Dim netMonPay As Double
                Dim netBiMonPay As Double

                'Calculation For Annual Tax
                If yearIncome > 250000.0 And yearIncome <= 400000.0 Then

                    Dim taxRate As Double = 0.15
                    excess = yearIncome - 250000.0


                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = taxExcess

                ElseIf yearIncome > 400000 And yearIncome <= 800000 Then

                    Dim taxRate As Double = 0.2
                    Dim fixTax As Double = 22500.0

                    excess = yearIncome - 400000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess

                ElseIf yearIncome > 800000 And yearIncome <= 2000000 Then

                    Dim taxRate As Double = 0.25
                    Dim fixTax As Double = 102500.0

                    excess = yearIncome - 800000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess

                ElseIf yearIncome > 2000000 And yearIncome <= 8000000 Then

                    Dim taxRate As Double = 0.3
                    Dim fixTax As Double = 402500.0

                    excess = yearIncome - 2000000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess

                ElseIf yearIncome > 8000000 Then

                    Dim taxRate As Double = 0.35
                    Dim fixTax As Double = 2202500.0

                    excess = yearIncome - 8000000

                    If excess > 0 Then
                        taxExcess = taxRate * excess
                    End If

                    totalAnnualTax = fixTax + taxExcess
                End If

                'Conversion from annual to Monthly
                income = income / 12

                'Calculation for Pag Ibig
                If income <= 1500 Then

                    Dim taxRate As Double = 0.01
                    Dim tax As Double

                    tax = income * taxRate
                    totalPagIbigCon = tax * 12

                ElseIf income > 1500 Then

                    Dim taxRate As Double = 0.02
                    Dim tax As Double

                    tax = income * taxRate
                    totalPagIbigCon = tax * 12

                End If

                'Calculation for GSIS if Government Official

                If cbEmpStat.SelectedItem.ToString = "Government Official" Then

                    Dim month = income * 0.09

                    totalGSISCon = month * 12

                Else
                    'Calculation for SSS when monthly salary is min 4000 and max 30000
                    If income >= 4000 And income <= 30000 Then

                        Dim month = income * 0.14
                        totalSSSCon = month * 12

                    End If

                End If

                If income >= 10000 And income <= 100000 Then

                    Dim month = income * 0.05
                    totalPhilHealth = month * 12

                End If

                'Calculation for total Contribution or Tax
                totalContri_Tax = totalAnnualTax + totalPagIbigCon + totalSSSCon + totalGSISCon + totalPhilHealth

                netAnnualIncome = yearIncome - totalContri_Tax

                netMonPay = netAnnualIncome / 12
                netBiMonPay = netMonPay / 2

                tbBiMonNet.Text = netBiMonPay.ToString("0.00")
                tbNetMonPay.Text = netMonPay.ToString("0.00")
                tbNetAnInc.Text = netAnnualIncome.ToString("0.00")

            End If

        Catch ex As Exception
            MessageBox.Show("Please Enter a Valid Number For Income")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        cbEmpStat.SelectedIndex = -1
        cbIncomeOpt.SelectedIndex = -1
        tbIncome.Text = ""
        tbBiMonNet.Text = ""
        tbNetMonPay.Text = ""
        tbNetAnInc.Text = ""

    End Sub
End Class
