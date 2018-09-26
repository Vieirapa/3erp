<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarCadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProducaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArmazemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComercialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrarProdutoComXMLDeNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem, Me.ProducaoToolStripMenuItem, Me.ArmazemToolStripMenuItem, Me.ComercialToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(577, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarCadastrosToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ProdutosToolStripMenuItem.Text = "Produto"
        '
        'GerenciarCadastrosToolStripMenuItem
        '
        Me.GerenciarCadastrosToolStripMenuItem.Name = "GerenciarCadastrosToolStripMenuItem"
        Me.GerenciarCadastrosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GerenciarCadastrosToolStripMenuItem.Text = "Cadastro de Produtos"
        '
        'ProducaoToolStripMenuItem
        '
        Me.ProducaoToolStripMenuItem.Name = "ProducaoToolStripMenuItem"
        Me.ProducaoToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ProducaoToolStripMenuItem.Text = "Produção"
        '
        'ArmazemToolStripMenuItem
        '
        Me.ArmazemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem})
        Me.ArmazemToolStripMenuItem.Name = "ArmazemToolStripMenuItem"
        Me.ArmazemToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ArmazemToolStripMenuItem.Text = "Armazém"
        '
        'ComercialToolStripMenuItem
        '
        Me.ComercialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeClientesToolStripMenuItem, Me.CadastroDePedidosToolStripMenuItem})
        Me.ComercialToolStripMenuItem.Name = "ComercialToolStripMenuItem"
        Me.ComercialToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ComercialToolStripMenuItem.Text = "Comercial"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes"
        '
        'CadastroDePedidosToolStripMenuItem
        '
        Me.CadastroDePedidosToolStripMenuItem.Name = "CadastroDePedidosToolStripMenuItem"
        Me.CadastroDePedidosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CadastroDePedidosToolStripMenuItem.Text = "Cadastro de Pedidos"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarProdutoComXMLDeNotaToolStripMenuItem})
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'EntrarProdutoComXMLDeNotaToolStripMenuItem
        '
        Me.EntrarProdutoComXMLDeNotaToolStripMenuItem.Name = "EntrarProdutoComXMLDeNotaToolStripMenuItem"
        Me.EntrarProdutoComXMLDeNotaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.EntrarProdutoComXMLDeNotaToolStripMenuItem.Text = "Entrar produto com XML de nota"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 326)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3ERP Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProducaoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArmazemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComercialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarCadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDePedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrarProdutoComXMLDeNotaToolStripMenuItem As ToolStripMenuItem
End Class
