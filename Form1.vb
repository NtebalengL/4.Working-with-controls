Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' MsgBox("The sum is  =" & Val(TextBox1.Text) + Val(TextBox2.Text))
        Label3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        MsgBox("The subtraction is  =" & Val(TextBox1.Text) - Val(TextBox2.Text))
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        MsgBox("The multiplication is  =" & Val(TextBox1.Text) * Val(TextBox2.Text))
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        MsgBox("The division is  =" & Val(TextBox1.Text) / Val(TextBox2.Text))
    End Sub
End Class
