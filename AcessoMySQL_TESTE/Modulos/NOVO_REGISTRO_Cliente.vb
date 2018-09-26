' carregando as ferramentas de um cliente MySQL
Imports MySql.Data.MySqlClient

Public Class NOVO_REGISTRO_Cliente
    ' criando a conexao com o banco de dados 
    Public MySQLConn As MySqlConnection
    Public mySQLCommand As MySqlCommand
    Public MySQLReader As MySqlDataReader


    Private Sub btnSalvaRegsitro_Click(sender As Object, e As EventArgs) Handles btnSalvaRegsitro.Click

        Dim codigo As String = txtCodigo.Text
        Dim razao As String = txtRazaoSocial.Text
        Dim fantasia As String = txtNomeFantasia.Text
        Dim cnpj As String = txtCNPJ.Text
        Dim endereco As String = txtEndereco.Text
        Dim numero As String = txtNumero.Text
        Dim bairro As String = txtBairro.Text
        Dim cidade As String = txtCidade.Text
        Dim estado As String = txtEstado.Text
        Dim cep As String = txtCEP.Text
        Dim contato As String = txtCONTATO.Text
        Dim telefone As String = txtTelefone.Text
        Dim email As String = txtEMAIL.Text

        Dim QueryInclusao As String = "INSERT INTO `3erp`.`clientes` (" &
            "`CODIGO`, " &
            "`RAZAO_SOCIAL`, " &
            "`NOME_FANTASIA`, " &
            "`CNPJ`, " &
            "`ENDERECO`, " &
            "`NR`, " &
            "`BAIRRO`, " &
            "`CIDADE`, " &
            "`ESTADO`, " &
            "`CEP`, " &
            "`NOME_CONTATO`, " &
            "`TELEFONE`, " &
            "`EMAIL`" &
            ") VALUES (" &
            "'" & codigo & "', " &
            "'" & razao & "', " &
            "'" & fantasia & "', " &
            "'" & cnpj & "', " &
            "'" & endereco & "', " &
            "'" & numero & "', " &
            "'" & bairro & "', " &
            "'" & cidade & "', " &
            "'" & estado & "', " &
            "'" & cep & "', " &
            "'" & contato & "', " &
            "'" & telefone & "', " &
            "'" & email & "'" &
            ");"

        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = LoginForm.MySQLConnectionString

        Try
            MySQLConn.Open()
            mySQLCommand = New MySqlCommand(QueryInclusao, MySQLConn)
            MySQLReader = mySQLCommand.ExecuteReader
            MySQLConn.Close()
            Me.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

        ' recarregando a tabela de clientes 
        MainForm.FormGestaoClientes.RecarregarTabelaComFiltro()

    End Sub


    Private Sub btnDescartaRegistro_Click(sender As Object, e As EventArgs) Handles btnDescartaRegistro.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class