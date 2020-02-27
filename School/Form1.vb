Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers() As Integer = {4, 1, 2, 3}
        lblOne.Text = numbers.Count

        For index = 0 To numbers.Count - 1
            MessageBox.Show(numbers(index))
        Next index
    End Sub
End Class
