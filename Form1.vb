Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first, second As Double

        first = Val(TextBox1.Text)
        second = Val(TextBox2.Text)

        If first > second Then
            TextBox3.Text = first
        Else
            TextBox3.Text = second
        End If
    End Sub
End Class
