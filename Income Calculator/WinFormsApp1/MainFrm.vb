Public Class MainFrm

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearInputs()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Validate inputs
        If Not ValidateInputs() Then Exit Sub
        Dim salary As Decimal = Decimal.Parse(tbInput.Text)
        Try
            If rbMonInc.Checked Then

                'Variables
                Dim yrIncome As Decimal = salary * 12
                Dim excess As Decimal
                Dim taxexcess As Decimal
                Dim ttlAnnual As Decimal
                Dim ttlPagIbigCon As Decimal
                Dim ttlGSISCon As Decimal
                Dim ttlSSSCon As Decimal
                Dim ttlPHealth As Decimal
                Dim ttlConTax As Decimal
                Dim netAnnInc As Decimal
                Dim netMonthlyPay As Decimal
                Dim netBiMonPay As Decimal

                ' Annual Tax
                If yrIncome > 250000.0 And yrIncome <= 400000.0 Then

                    excess = yrIncome - 250000.0
                    If excess > 0 Then
                        taxexcess = 0.15 * excess
                    End If

                    ttlAnnual = taxexcess

                ElseIf yrIncome > 400000 And yrIncome <= 800000 Then

                    excess = yrIncome - 400000
                    If excess > 0 Then
                        taxexcess = 0.2 * excess
                    End If
                    ttlAnnual = 22500.0 + taxexcess

                ElseIf yrIncome > 800000 And yrIncome <= 2000000 Then

                    excess = yrIncome - 800000

                    If excess > 0 Then
                        taxexcess = 0.25 * excess
                    End If

                    ttlAnnual = 102500.0 + taxexcess

                ElseIf yrIncome > 2000000 And yrIncome <= 8000000 Then

                    excess = yrIncome - 2000000
                    If excess > 0 Then
                        taxexcess = 0.3 * excess
                    End If
                    ttlAnnual = 402500.0 + taxexcess

                ElseIf yrIncome > 8000000 Then

                    excess = yrIncome - 8000000
                    If excess > 0 Then
                        taxexcess = 0.35 * excess
                    End If
                    ttlAnnual = 2202500.0 + taxexcess

                End If

                ' Pag-Ibig
                If salary <= 1500 Then

                    Dim tax As Decimal = salary * 0.01
                    ttlPagIbigCon = tax * 12

                ElseIf salary > 1500 Then

                    Dim tax As Decimal = salary * 0.02
                    ttlPagIbigCon = tax * 12

                End If

                'GSIS if Government Official

                If rbGovOff.Checked Then

                    Dim month = salary * 0.09
                    ttlGSISCon = month * 12

                Else
                    'SSS when monthly salary is min 4000 and max 30000
                    If salary >= 4000 And salary <= 30000 Then

                        Dim month = salary * 0.14
                        ttlSSSCon = month * 12

                    End If

                End If

                If salary >= 10000 And salary <= 100000 Then

                    Dim month = salary * 0.05
                    ttlPHealth = month * 12

                End If

                'Total Contribution or Tax
                ttlConTax = ttlAnnual + ttlPagIbigCon + ttlSSSCon + ttlGSISCon + ttlPHealth

                netAnnInc = yrIncome - ttlConTax
                netMonthlyPay = netAnnInc / 12
                netBiMonPay = netMonthlyPay / 2


                tbBiMonPay.Text = netBiMonPay.ToString("0.00")
                tbNetMonPay.Text = netMonthlyPay.ToString("0.00")
                tbNetAnnInc.Text = netAnnInc.ToString("0.00")

                'Calculation for Annual Income Input
            Else

                'This are Variables for calculation
                Dim yearIncome As Double = salary
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
                salary = salary / 12

                'Calculation for Pag Ibig
                If salary <= 1500 Then

                    Dim taxRate As Double = 0.01
                    Dim tax As Double

                    tax = salary * taxRate
                    totalPagIbigCon = tax * 12

                ElseIf salary > 1500 Then

                    Dim taxRate As Double = 0.02
                    Dim tax As Double

                    tax = salary * taxRate
                    totalPagIbigCon = tax * 12

                End If

                ' GSIS if Government Official

                If rbGovOff.Checked Then

                    Dim month = salary * 0.09

                    totalGSISCon = month * 12

                Else
                    'Calculation for SSS when monthly salary is min 4000 and max 30000
                    If salary >= 4000 And salary <= 30000 Then

                        Dim month = salary * 0.14
                        totalSSSCon = month * 12

                    End If

                End If

                If salary >= 10000 And salary <= 100000 Then

                    Dim month = salary * 0.05
                    totalPhilHealth = month * 12

                End If

                'Calculation for total Contribution or Tax
                totalContri_Tax = totalAnnualTax + totalPagIbigCon + totalSSSCon + totalGSISCon + totalPhilHealth

                netAnnualIncome = yearIncome - totalContri_Tax
                netMonPay = netAnnualIncome / 12
                netBiMonPay = netMonPay / 2

                tbBiMonPay.Text = netBiMonPay.ToString("0.00")
                tbNetMonPay.Text = netMonPay.ToString("0.00")
                tbNetAnnInc.Text = netAnnualIncome.ToString("0.00")

            End If

        Catch ex As Exception
            MessageBox.Show("Please Enter Valid Input Or Number for Amount")
        End Try

    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate employment status
        If Not (rbEmp.Checked OrElse rbSelfEmp.Checked OrElse rbGovOff.Checked) Then
            MessageBox.Show("Please select an employment status.")
            Return False
        End If

        ' Validate income option
        If Not (rbMonInc.Checked OrElse rbAnnInc.Checked) Then
            MessageBox.Show("Please select an income option.")
            Return False
        End If

        ' Validate income input
        If String.IsNullOrWhiteSpace(tbInput.Text) Then
            MessageBox.Show("Please enter the income.")
            Return False
        End If

        Return True
    End Function

    Private Sub ClearInputs()
        ' Clear all inputs
        rbEmp.Checked = False
        rbSelfEmp.Checked = False
        rbGovOff.Checked = False
        rbMonInc.Checked = False
        rbAnnInc.Checked = False
        tbInput.Clear()
        tbBiMonPay.Clear()
        tbNetMonPay.Clear()
        tbNetAnnInc.Clear()
    End Sub
End Class
