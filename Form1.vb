Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim W As Integer
        Dim H As Decimal
        Dim Bmi As Decimal

        W = txtWeight.Text
        H = txtHeight.Text
        Bmi = W / (H * H)

        lblResult.Text = "Your BMI is " + Format(Bmi, "0.0")

        If Bmi < 18.5 Then
            MessageBox.Show("You are Underweight")
        ElseIf Bmi >= 18.5 And Bmi <= 24.9 Then
            MessageBox.Show("You are Normal")
        ElseIf Bmi >= 25 And Bmi <= 29.9 Then
            MessageBox.Show("You are Overweight")
        Else
            MessageBox.Show("You are Obesity")
        End If
    End Sub
End Class
