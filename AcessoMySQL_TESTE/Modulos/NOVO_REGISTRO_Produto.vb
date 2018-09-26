' carregando as ferramentas de um cliente MySQL
Imports MySql.Data.MySqlClient

Public Class NOVO_REGISTRO_Produto
    ' criando a conexao com o banco de dados 
    Public MySQLConn As MySqlConnection
    Public mySQLCommand As MySqlCommand
    Public MySQLReader As MySqlDataReader

    Private Sub btnSalvaRegsitro_Click(sender As Object, e As EventArgs) Handles btnSalvaRegsitro.Click

        ' carregando os campos 
        '( se houver tratamento de VALIDO ou INVALIDO para qualquer campo eh aqui que tem de estar !)
        Dim codigo As String = txtCodigo.Text
        Dim descricao As String = txtDescricao.Text
        Dim ean As String = txtEAN.Text
        Dim familia As String = txtFamilia.Text

        Dim QueryInclusao As String = "INSERT INTO `3erp`.`produtos` (`CODIGO`, `DESCRICAO`, `EAN`, `FAMILIA`) VALUES ('" & codigo & "', '" & descricao & "', '" & ean & "', '" & familia & "');"

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

        ' recarregando a tabela de produtos
        MainForm.FormGestaoCadastro.RecarregarTabelaComFiltro()

        ' recarregando os itens da entrada de itens
        EntradaNotaArmazem.CarregaTabela()

    End Sub
End Class