Imports System.Xml

Public Class EntradaNotaArmazem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        TextBox1.Text = OpenFileDialog1.ShowDialog()



    End Sub
End Class