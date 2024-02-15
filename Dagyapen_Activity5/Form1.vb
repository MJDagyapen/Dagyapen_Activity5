Public Class Form1
    Private Sub Btndivide_Click(sender As Object, e As EventArgs) Handles Btndivide.Click
        Try
            Dim a, b As Integer
            a = txtfirstnum.Text
            b = txtsecondnum.Text
            MessageBox.Show(a / b)
            lblresult.Text = a / b
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
