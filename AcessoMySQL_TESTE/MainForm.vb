Public Class MainForm

    Public FormGestaoClientes As New GestaoCadastros
    Public FormGestaoCadastro As New GestaoCadastros


    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click

        ' limpando os campos de login
        LoginForm.txtPass.Clear()
        LoginForm.txtUser.Clear()

        Me.Hide()
        LoginForm.Show()
    End Sub



    Private Sub ProductForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        ' limpando os campos de login
        LoginForm.txtPass.Clear()
        LoginForm.txtUser.Clear()

        LoginForm.Show()

    End Sub

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GerenciarCadastrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarCadastrosToolStripMenuItem.Click

        Me.UseWaitCursor = True

        FormGestaoCadastro = New GestaoCadastros

        ' apontando para a tabela correta
        FormGestaoCadastro.strTabelaFoco = "produtos"
        FormGestaoCadastro.lblTituloJanela.Text = "Tabela PRODUTOS"

        'Set the Parent Form of the Child window.  
        FormGestaoCadastro.MdiParent = Me
        'Display the new form.  
        FormGestaoCadastro.Show()

        ' enaquanto estiver aberta a tela de cadastros, evitar nova abertura
        GerenciarCadastrosToolStripMenuItem.Enabled = False

        Me.UseWaitCursor = False

    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click

        FormGestaoClientes = New GestaoCadastros

        ' apontando para a tabela correta
        FormGestaoClientes.strTabelaFoco = "clientes"
        FormGestaoClientes.lblTituloJanela.Text = "Tabela CLIENTES"

        'Set the Parent Form of the Child window.  
        FormGestaoClientes.MdiParent = Me
        'Display the new form.  
        FormGestaoClientes.Show()

        ' enaquanto estiver aberta a tela de cadastros, evitar nova abertura
        CadastroDeClientesToolStripMenuItem.Enabled = False
    End Sub

    Private Sub EntrarProdutoComXMLDeNotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrarProdutoComXMLDeNotaToolStripMenuItem.Click
        ' chamando a entrada de notas do armazem
        EntradaNotaArmazem.MdiParent = Me
        ' chamando a entrada
        EntradaNotaArmazem.Show()
    End Sub
End Class