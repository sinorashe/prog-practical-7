Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iHoursWorked As Integer
        Dim rHoursrate, rGross, rDeductions, rNettpay As Double

        iHoursWorked = Val(TextBox1.Text)
        rHoursrate = Val(TextBox2.Text)

        rGross = iHoursWorked * rHoursrate
        rDeductions = 20 / 100

        TextBox3.Text = rGross
        TextBox4.Text = rDeductions
        TextBox5.Text = rNettpay




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
