<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
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
        gbStatus = New GroupBox()
        rbGovOff = New RadioButton()
        rbSelfEmp = New RadioButton()
        rbEmp = New RadioButton()
        gbInOpt = New GroupBox()
        rbAnnInc = New RadioButton()
        rbMonInc = New RadioButton()
        tbInput = New TextBox()
        Label1 = New Label()
        tbBiMonPay = New TextBox()
        tbNetMonPay = New TextBox()
        tbNetAnnInc = New TextBox()
        lblBiNetPay = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnCalc = New Button()
        btnReset = New Button()
        gbStatus.SuspendLayout()
        gbInOpt.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbStatus
        ' 
        gbStatus.BackColor = SystemColors.ButtonFace
        gbStatus.Controls.Add(rbGovOff)
        gbStatus.Controls.Add(rbSelfEmp)
        gbStatus.Controls.Add(rbEmp)
        gbStatus.Location = New Point(39, 53)
        gbStatus.Name = "gbStatus"
        gbStatus.Size = New Size(266, 145)
        gbStatus.TabIndex = 0
        gbStatus.TabStop = False
        gbStatus.Text = "Status"
        ' 
        ' rbGovOff
        ' 
        rbGovOff.AutoSize = True
        rbGovOff.Location = New Point(20, 100)
        rbGovOff.Name = "rbGovOff"
        rbGovOff.Size = New Size(183, 25)
        rbGovOff.TabIndex = 2
        rbGovOff.TabStop = True
        rbGovOff.Text = "Government Official"
        rbGovOff.UseVisualStyleBackColor = True
        ' 
        ' rbSelfEmp
        ' 
        rbSelfEmp.AutoSize = True
        rbSelfEmp.Location = New Point(20, 69)
        rbSelfEmp.Name = "rbSelfEmp"
        rbSelfEmp.Size = New Size(138, 25)
        rbSelfEmp.TabIndex = 1
        rbSelfEmp.TabStop = True
        rbSelfEmp.Text = "Self Employed"
        rbSelfEmp.UseVisualStyleBackColor = True
        ' 
        ' rbEmp
        ' 
        rbEmp.AutoSize = True
        rbEmp.Location = New Point(20, 38)
        rbEmp.Name = "rbEmp"
        rbEmp.Size = New Size(105, 25)
        rbEmp.TabIndex = 0
        rbEmp.TabStop = True
        rbEmp.Text = "Employed"
        rbEmp.UseVisualStyleBackColor = True
        ' 
        ' gbInOpt
        ' 
        gbInOpt.BackColor = SystemColors.ButtonFace
        gbInOpt.Controls.Add(rbAnnInc)
        gbInOpt.Controls.Add(rbMonInc)
        gbInOpt.Location = New Point(349, 53)
        gbInOpt.Name = "gbInOpt"
        gbInOpt.Size = New Size(266, 145)
        gbInOpt.TabIndex = 1
        gbInOpt.TabStop = False
        gbInOpt.Text = "Input Option"
        ' 
        ' rbAnnInc
        ' 
        rbAnnInc.AutoSize = True
        rbAnnInc.Location = New Point(31, 88)
        rbAnnInc.Name = "rbAnnInc"
        rbAnnInc.Size = New Size(144, 25)
        rbAnnInc.TabIndex = 1
        rbAnnInc.TabStop = True
        rbAnnInc.Text = "Annual Income"
        rbAnnInc.UseVisualStyleBackColor = True
        ' 
        ' rbMonInc
        ' 
        rbMonInc.AutoSize = True
        rbMonInc.Location = New Point(31, 48)
        rbMonInc.Name = "rbMonInc"
        rbMonInc.Size = New Size(154, 25)
        rbMonInc.TabIndex = 0
        rbMonInc.TabStop = True
        rbMonInc.Text = "Monthly Income"
        rbMonInc.UseVisualStyleBackColor = True
        ' 
        ' tbInput
        ' 
        tbInput.Location = New Point(237, 269)
        tbInput.Name = "tbInput"
        tbInput.Size = New Size(182, 29)
        tbInput.TabIndex = 2
        tbInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(293, 245)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 21)
        Label1.TabIndex = 3
        Label1.Text = "Amount"
        ' 
        ' tbBiMonPay
        ' 
        tbBiMonPay.Location = New Point(73, 401)
        tbBiMonPay.Name = "tbBiMonPay"
        tbBiMonPay.ReadOnly = True
        tbBiMonPay.Size = New Size(156, 29)
        tbBiMonPay.TabIndex = 4
        tbBiMonPay.TextAlign = HorizontalAlignment.Right
        ' 
        ' tbNetMonPay
        ' 
        tbNetMonPay.Location = New Point(258, 401)
        tbNetMonPay.Name = "tbNetMonPay"
        tbNetMonPay.ReadOnly = True
        tbNetMonPay.Size = New Size(139, 29)
        tbNetMonPay.TabIndex = 5
        tbNetMonPay.TextAlign = HorizontalAlignment.Right
        ' 
        ' tbNetAnnInc
        ' 
        tbNetAnnInc.Location = New Point(428, 401)
        tbNetAnnInc.Name = "tbNetAnnInc"
        tbNetAnnInc.ReadOnly = True
        tbNetAnnInc.Size = New Size(156, 29)
        tbNetAnnInc.TabIndex = 6
        tbNetAnnInc.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblBiNetPay
        ' 
        lblBiNetPay.AutoSize = True
        lblBiNetPay.Location = New Point(73, 433)
        lblBiNetPay.Name = "lblBiNetPay"
        lblBiNetPay.Size = New Size(156, 21)
        lblBiNetPay.TabIndex = 7
        lblBiNetPay.Text = "Bi-Monthly Netpay"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(258, 433)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 21)
        Label2.TabIndex = 8
        Label2.Text = "Net Monthly Pay"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(428, 433)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 21)
        Label3.TabIndex = 9
        Label3.Text = "Net Annual Income"
        ' 
        ' btnCalc
        ' 
        btnCalc.Location = New Point(196, 322)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(109, 31)
        btnCalc.TabIndex = 10
        btnCalc.Text = "Calculate"
        btnCalc.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(349, 322)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(109, 31)
        btnReset.TabIndex = 11
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(663, 510)
        Controls.Add(btnReset)
        Controls.Add(btnCalc)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblBiNetPay)
        Controls.Add(tbNetAnnInc)
        Controls.Add(tbNetMonPay)
        Controls.Add(tbBiMonPay)
        Controls.Add(Label1)
        Controls.Add(tbInput)
        Controls.Add(gbInOpt)
        Controls.Add(gbStatus)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Net Income"
        gbStatus.ResumeLayout(False)
        gbStatus.PerformLayout()
        gbInOpt.ResumeLayout(False)
        gbInOpt.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gbStatus As GroupBox
    Friend WithEvents rbGovOff As RadioButton
    Friend WithEvents rbSelfEmp As RadioButton
    Friend WithEvents rbEmp As RadioButton
    Friend WithEvents gbInOpt As GroupBox
    Friend WithEvents rbAnnInc As RadioButton
    Friend WithEvents rbMonInc As RadioButton
    Friend WithEvents tbInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbBiMonPay As TextBox
    Friend WithEvents tbNetMonPay As TextBox
    Friend WithEvents tbNetAnnInc As TextBox
    Friend WithEvents lblBiNetPay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnReset As Button

End Class
