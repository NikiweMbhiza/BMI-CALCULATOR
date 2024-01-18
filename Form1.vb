Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, bmi As Double
        weight = Val(TextBox1.Text)
        height = Val(TextBox1.Text)
        bmi = weight / (height) ^ 2
        TextBox3.Text = bmi

        If bmi < 18 Then
            TextBox4.Text = "underweight"
        ElseIf 18 <= bmi And bmi < 26 Then
            TextBox4.Text = " FIT"
        Else
            TextBox4.Text = "OVERWEIGHT"
        End If
    End Sub
End Class
