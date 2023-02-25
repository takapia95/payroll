Public Class Form1
    Const _cdecFica As Decimal = 0.0765D
    Const _cdecFed As Decimal = 0.22D
    Const _cdecState As Decimal = 0.04D
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal
        strIncome = txtIncome.Text
        decIncome = Convert.ToDecimal(strIncome)
        decFica = decIncome * _cdecFica
        decFederal = decIncome * _cdecFed
        decState = decIncome * _cdecState
        decNet = decIncome - decFica - decFederal - decState
        lblNet.Text = decNet.ToString("C")
        lblFederal.Text = decFederal.ToString("C2")
        lblFica.Text = decFica.ToString("C2")
        lblState.Text = decState.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFederal.Text = ""
        lblFica.Text = ""
        lblNet.Text = ""
        lblState.Text = ""
        txtIncome.Focus()
        txtIncome.Clear()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
