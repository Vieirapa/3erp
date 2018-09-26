Imports MySql.Data.MySqlClient


Public Class GestaoCadastros
    ' para saber de onde venho e para onde vou 
    Dim Pai As Object

    ' nome da tabela para onde aponta
    Public strTabelaFoco As String = "produtos"
    Public strChavePrimaria As String = "idproduto"

    ' criando a conexao com o banco de dados 
    Public MySQLConn As MySqlConnection
    Public mySQLCommand As MySqlCommand
    Public MySQLReader As MySqlDataReader

    ' instancia dos dados do DataSer
    Dim dbDataSet As New DataTable

    ' criando query de alteracao
    ' todas tem o formato : 
    '      UPDATE `3erp`.`produtos` SET `produto_descricao` = '120692;18150518150528' WHERE (`produto_id` = '10624');
    Dim QueryAlteracoes As String

    Private Sub PRODUTO_GestaoCadastros_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If strTabelaFoco = "produtos" Then
            ' enaquanto estiver aberta a tela de cadastros, evitar nova abertura
            MainForm.GerenciarCadastrosToolStripMenuItem.Enabled = True
        ElseIf strTabelaFoco = "clientes" Then
            ' enaquanto estiver aberta a tela de cadastros, evitar nova abertura
            MainForm.CadastroDeClientesToolStripMenuItem.Enabled = True
        End If

        Me.Dispose()

    End Sub

    Private Sub CarregaTabela()

        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = LoginForm.MySQLConnectionString

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MySQLConn.Open()

            Dim query As String
            query = "SELECT * FROM 3erp." & strTabelaFoco
            mySQLCommand = New MySqlCommand(query, MySQLConn)
            SDA.SelectCommand = mySQLCommand
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            PRODUTO_DataGrid.DataSource = bSource
            SDA.Update(dbDataSet)
            MySQLConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

        ' criando variavel para largura final da janela
        Dim TotalWidth As Integer = 0

        ' arrancando o nome da chave primaria
        strChavePrimaria = PRODUTO_DataGrid.Columns(0).Name
        ' limpando o combo com as possibilidades de filtro
        cmbCampoFiltro.Items.Clear()
        ' varrendo as colunas para acertar largura e colher o nome para o campo de filtro
        For index = 1 To PRODUTO_DataGrid.ColumnCount - 1
            ' arrumando a largura
            PRODUTO_DataGrid.AutoResizeColumn(index)
            ' colhendo o nome para o campo de filtros
            cmbCampoFiltro.Items.Add(PRODUTO_DataGrid.Columns(index).Name)
            ' acumulando a largura
            TotalWidth += PRODUTO_DataGrid.Columns(index).Width
        Next
        ' garantindo a seleção do primeiro campo de filtro
        cmbCampoFiltro.SelectedIndex = 0

        ' garantindo que a chave primaria nao podera ser editada
        PRODUTO_DataGrid.Columns(0).ReadOnly = True
        PRODUTO_DataGrid.Columns(0).Visible = False

        ' atualizando as etiquetas de nro de registros 
        lblNroCampos.Text = dbDataSet.AsDataView.Count
        lblCamposFiltrados.Text = dbDataSet.AsDataView.Count

    End Sub

    Private Sub PRODUTO_GestaoCadastros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' carregando a tabela de produtos
        CarregaTabela()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim DV As New DataView(dbDataSet)
        Dim CampoProcura As String = cmbCampoFiltro.Text & " like '%{0}%'"
        DV.RowFilter = String.Format(CampoProcura, txtFiltro.Text)
        PRODUTO_DataGrid.DataSource = DV

        lblCamposFiltrados.Text = DV.Count.ToString

    End Sub

    Private Sub btnExluirRegistro_Click(sender As Object, e As EventArgs) Handles btnExluirRegistro.Click

        ' lista de colunas selecionadas
        Dim msg As String = ""
        Dim DeleteCarry As String = ""

        ' olhando para cada uma delas
        Dim row As DataGridViewRow
        For Each row In PRODUTO_DataGrid.SelectedRows
            msg = msg & " registro " & row.Cells(1).Value.ToString & vbCrLf
        Next

        Dim button = MsgBox("Excluir um registro é uma operação que nao pode ser desfeita." & vbCrLf & " Deseja escluir o(s) registro(s) ?" & vbCrLf & vbCrLf & msg, vbYesNo, "ATENÇÃO")

        If button = vbYes Then

            For Each row In PRODUTO_DataGrid.SelectedRows
                DeleteCarry = "DELETE FROM `3erp`.`" & strTabelaFoco & "` WHERE (`" & strChavePrimaria & "` = '" & row.Cells(0).Value & "');"
                Try
                    MySQLConn.Open()
                    mySQLCommand = New MySqlCommand(DeleteCarry, MySQLConn)
                    MySQLReader = mySQLCommand.ExecuteReader
                    MySQLConn.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                Finally
                    MySQLConn.Dispose()
                End Try
            Next

            ' recarregando a tabela com os filtros ligados
            RecarregarTabelaComFiltro()

        End If



    End Sub

    Public Sub RecarregarTabelaComFiltro()
        ' cuidando do filtro antes e depois de salvar e recarregar o banco
        Dim FilterString = txtFiltro.Text
        Dim FiltroSelecionado = cmbCampoFiltro.SelectedIndex

        ' recarregando o banco
        RecarregarTabelaSemFiltro()
        ' recolocando o filtro ativo ( se houver )
        cmbCampoFiltro.SelectedIndex = FiltroSelecionado
        txtFiltro.Text = FilterString

    End Sub

    Private Sub RecarregarTabelaSemFiltro()

        ' arrumando os acessos
        grupoFiltros.Enabled = True
        btnDescartarAlteracoes.Enabled = False
        btnNovoRegistro.Enabled = True
        btnSalvaAlteracoes.Enabled = False

        ' teste de descarte de operacoes
        dbDataSet.Clear()
        CarregaTabela()
        ' limpando os campos de nro de alteraceos e filtros
        lblRegistrosAlterados.Text = "0"
        txtFiltro.Text = ""

    End Sub

    Private Sub btnDescartarAlteracoes_Click(sender As Object, e As EventArgs) Handles btnDescartarAlteracoes.Click

        ' recarregando tabela
        RecarregarTabelaComFiltro()

    End Sub

    Private Sub btnSalvaAlteracoes_Click(sender As Object, e As EventArgs) Handles btnSalvaAlteracoes.Click

        Me.UseWaitCursor = True

        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = LoginForm.MySQLConnectionString

        Try
            MySQLConn.Open()
            mySQLCommand = New MySqlCommand(QueryAlteracoes, MySQLConn)
            MySQLReader = mySQLCommand.ExecuteReader
            MySQLConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

        ' limpando a Query de Alteracoes
        QueryAlteracoes = ""
        ' recarregando o banco
        RecarregarTabelaComFiltro()

        Me.UseWaitCursor = False

    End Sub

    Private Sub PRODUTO_DataGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PRODUTO_DataGrid.CellEndEdit

        ' carregando os campos para serem editados
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.PRODUTO_DataGrid.Rows(e.RowIndex)

            QueryAlteracoes = QueryAlteracoes &
            "UPDATE `3erp`.`" & strTabelaFoco & "` SET "
            '"`produto_codigo` = '" & row.Cells(1).Value.ToString & "', " &
            '"`produto_descricao` = '" & row.Cells(2).Value.ToString & "', " &
            '"`produto_EAN` = '" & row.Cells(3).Value.ToString & "' " &

            For index = 1 To PRODUTO_DataGrid.ColumnCount - 1
                QueryAlteracoes = QueryAlteracoes & "`" & PRODUTO_DataGrid.Columns(index).Name & "` = '" & row.Cells(index).Value.ToString & "'"
                If index < PRODUTO_DataGrid.ColumnCount - 1 Then
                    QueryAlteracoes = QueryAlteracoes & ", "
                Else
                    QueryAlteracoes = QueryAlteracoes & " "
                End If
            Next
            ' acabando a montagem da query alteracoes 
            QueryAlteracoes = QueryAlteracoes & "WHERE (`" & strChavePrimaria & "` = '" & row.Cells(0).Value.ToString & "');" & vbCrLf

            ' pintando a linha de amarelo
            PRODUTO_DataGrid.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            ' incrumentando o nro de registros com alteracoes
            lblRegistrosAlterados.Text = Val(lblRegistrosAlterados.Text) + 1

            ' arrumando os acessos
            grupoFiltros.Enabled = False
            btnDescartarAlteracoes.Enabled = True
            btnNovoRegistro.Enabled = False
            btnSalvaAlteracoes.Enabled = True

        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        ' recarregando tabela
        RecarregarTabelaComFiltro()

    End Sub

    Private Sub btnNovoRegistro_Click(sender As Object, e As EventArgs) Handles btnNovoRegistro.Click

        If strTabelaFoco = "produtos" Then
            ' chama tela para novo registro
            NOVO_REGISTRO_Produto.Show()
        ElseIf strTabelaFoco = "clientes" Then
            ' chama tela para novo registro
            NOVO_REGISTRO_Cliente.Show()
        End If

    End Sub

    Private Sub PRODUTO_DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PRODUTO_DataGrid.CellContentClick

    End Sub

    Private Sub PRODUTO_DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PRODUTO_DataGrid.CellClick

        If PRODUTO_DataGrid.CurrentRow.Selected Then
            btnExluirRegistro.Enabled = True
        Else
            btnExluirRegistro.Enabled = False
        End If

    End Sub
End Class