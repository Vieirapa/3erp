
' carregando as ferramentas de um cliente MySQL
Imports MySql.Data.MySqlClient


Public Class LoginForm
    ' variaveis de dados sobre o local do banco de dados
    Public MySQLServername As String
    Public MySQLConnectionString As String

    ' criando a conexao com o banco de dados 
    Public MySQLConn As MySqlConnection
    Public mySQLCommand As MySqlCommand
    Public MySQLReader As MySqlDataReader

    Private Sub ConnectionTest()
        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = MySQLConnectionString

        Try
            MySQLConn.Open()
            MessageBox.Show("Conexão bem sucedida !")
            MySQLConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Sub ServerConfig()
        ' carregando as configs
        MySQLServername = cmbServerName.Text.ToString.Trim
        'MySQLConnectionString = "server=" & MySQLServername & ";userid=root;password=Guiga2002;database=3erp"
        MySQLConnectionString = "server=" & MySQLServername & ";userid=root; password=Guiga2002; SslMode = none"

        'Dim connstring = String.Format("Server=" & MySQLServername & "; database={0}; UID=root; password=Guiga2002; SslMode = none", databaseName)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' configurando o servidor
        ServerConfig()

        ' limpando os txts
        txtPass.Clear()
        txtUser.Clear()

    End Sub

    Private Sub bntEntrar_Click(sender As Object, e As EventArgs) Handles bntEntrar.Click

        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = MySQLConnectionString

        Dim querry As String =
            "select * from 3erp.users where name='" & txtUser.Text & "' and password='" & txtPass.Text & "'"

        Try
            MySQLConn.Open()

            mySQLCommand = New MySqlCommand(querry, MySQLConn)
            MySQLReader = mySQLCommand.ExecuteReader

            Dim count As Integer
            While MySQLReader.Read
                count += 1
            End While

            ' tomando decisao do que fazer ...
            If count = 1 Then
                MainForm.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Encontrei " & count & " registro(s) com este usuário e senha !")
            Else
                MessageBox.Show("Usuário/Senha não autorizados !")
            End If


            MySQLConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        ' testando a conexao 
        ConnectionTest()
    End Sub

    Private Sub cmbServerName_TextChanged(sender As Object, e As EventArgs) Handles cmbServerName.TextChanged
        ' reconfigurando o servidor
        ServerConfig()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtUser_Validated(sender As Object, e As EventArgs) Handles txtUser.Validated

    End Sub
End Class
