Public Class Payroll

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        GrossTextBox.Text = BasicTextBox.Text + +OverTimeTextBox.Text + +ThirteenTextBox.Text + +MidYearTexBox.Text + +OtherBonusTextBox.Text + +ExtraTextBox.Text + +HonorariaTextBox.Text + +AllowanceTextBox.Text + +OtherIncomeTextBox.Text
        TaxTextBox.Text = BasicTextBox.Text * 0.2
        SSSTextBox.Text = BasicTextBox.Text * 0.08
        DeductionTextBox.Text = TaxTextBox.Text + +PagIbigTextBox.Text + +PhilHealthTextBox.Text + +LoansTextBox.Text + +InsuranceTextBox.Text + +OtherDeductionTextBox.Text
        NetPayTextBox.Text = GrossTextBox.Text - DeductionTextBox.Text
        FirstQuincenaTextBox.Text = NetPayTextBox.Text / 2
        SecondQuincenaTextBox.Text = FirstQuincenaTextBox.Text
    End Sub
End Class
