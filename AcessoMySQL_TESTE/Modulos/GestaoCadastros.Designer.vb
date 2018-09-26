<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestaoCadastros
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
        Me.grupoFiltros = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCampoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.PRODUTO_DataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.lblTituloJanela = New System.Windows.Forms.Label()
        Me.lblRegistrosAlterados = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCamposFiltrados = New System.Windows.Forms.Label()
        Me.lblNroCampos = New System.Windows.Forms.Label()
        Me.btnSalvaAlteracoes = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDescartarAlteracoes = New System.Windows.Forms.Button()
        Me.btnNovoRegistro = New System.Windows.Forms.Button()
        Me.btnExluirRegistro = New System.Windows.Forms.Button()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.grupoFiltros.SuspendLayout()
        CType(Me.PRODUTO_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoFiltros
        '
        Me.grupoFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupoFiltros.Controls.Add(Me.Label3)
        Me.grupoFiltros.Controls.Add(Me.cmbCampoFiltro)
        Me.grupoFiltros.Controls.Add(Me.Label1)
        Me.grupoFiltros.Controls.Add(Me.txtFiltro)
        Me.grupoFiltros.Location = New System.Drawing.Point(284, 12)
        Me.grupoFiltros.Name = "grupoFiltros"
        Me.grupoFiltros.Size = New System.Drawing.Size(507, 66)
        Me.grupoFiltros.TabIndex = 1
        Me.grupoFiltros.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Campo"
        '
        'cmbCampoFiltro
        '
        Me.cmbCampoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampoFiltro.FormattingEnabled = True
        Me.cmbCampoFiltro.Location = New System.Drawing.Point(21, 33)
        Me.cmbCampoFiltro.Name = "cmbCampoFiltro"
        Me.cmbCampoFiltro.Size = New System.Drawing.Size(93, 21)
        Me.cmbCampoFiltro.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filtro"
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.Location = New System.Drawing.Point(120, 33)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(381, 20)
        Me.txtFiltro.TabIndex = 0
        '
        'PRODUTO_DataGrid
        '
        Me.PRODUTO_DataGrid.AllowUserToAddRows = False
        Me.PRODUTO_DataGrid.AllowUserToDeleteRows = False
        Me.PRODUTO_DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PRODUTO_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUTO_DataGrid.Location = New System.Drawing.Point(12, 136)
        Me.PRODUTO_DataGrid.Name = "PRODUTO_DataGrid"
        Me.PRODUTO_DataGrid.Size = New System.Drawing.Size(779, 364)
        Me.PRODUTO_DataGrid.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAtualizar)
        Me.GroupBox1.Controls.Add(Me.lblTituloJanela)
        Me.GroupBox1.Controls.Add(Me.lblRegistrosAlterados)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblCamposFiltrados)
        Me.GroupBox1.Controls.Add(Me.lblNroCampos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 118)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(6, 89)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(254, 23)
        Me.btnAtualizar.TabIndex = 16
        Me.btnAtualizar.Text = "Atualizar Tabela"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'lblTituloJanela
        '
        Me.lblTituloJanela.AutoSize = True
        Me.lblTituloJanela.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloJanela.Location = New System.Drawing.Point(6, 12)
        Me.lblTituloJanela.Name = "lblTituloJanela"
        Me.lblTituloJanela.Size = New System.Drawing.Size(197, 25)
        Me.lblTituloJanela.TabIndex = 6
        Me.lblTituloJanela.Text = "NOME DA TABELA"
        '
        'lblRegistrosAlterados
        '
        Me.lblRegistrosAlterados.AutoSize = True
        Me.lblRegistrosAlterados.Location = New System.Drawing.Point(169, 68)
        Me.lblRegistrosAlterados.Name = "lblRegistrosAlterados"
        Me.lblRegistrosAlterados.Size = New System.Drawing.Size(13, 13)
        Me.lblRegistrosAlterados.TabIndex = 5
        Me.lblRegistrosAlterados.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Registros com alteração"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Registros filtrados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Registros no banco"
        '
        'lblCamposFiltrados
        '
        Me.lblCamposFiltrados.AutoSize = True
        Me.lblCamposFiltrados.Location = New System.Drawing.Point(169, 54)
        Me.lblCamposFiltrados.Name = "lblCamposFiltrados"
        Me.lblCamposFiltrados.Size = New System.Drawing.Size(13, 13)
        Me.lblCamposFiltrados.TabIndex = 1
        Me.lblCamposFiltrados.Text = "0"
        '
        'lblNroCampos
        '
        Me.lblNroCampos.AutoSize = True
        Me.lblNroCampos.Location = New System.Drawing.Point(169, 40)
        Me.lblNroCampos.Name = "lblNroCampos"
        Me.lblNroCampos.Size = New System.Drawing.Size(13, 13)
        Me.lblNroCampos.TabIndex = 0
        Me.lblNroCampos.Text = "0"
        '
        'btnSalvaAlteracoes
        '
        Me.btnSalvaAlteracoes.Enabled = False
        Me.btnSalvaAlteracoes.Location = New System.Drawing.Point(256, 16)
        Me.btnSalvaAlteracoes.Name = "btnSalvaAlteracoes"
        Me.btnSalvaAlteracoes.Size = New System.Drawing.Size(118, 23)
        Me.btnSalvaAlteracoes.TabIndex = 14
        Me.btnSalvaAlteracoes.Text = "Salvar Alterações"
        Me.btnSalvaAlteracoes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDescartarAlteracoes)
        Me.GroupBox3.Controls.Add(Me.btnSalvaAlteracoes)
        Me.GroupBox3.Controls.Add(Me.btnNovoRegistro)
        Me.GroupBox3.Controls.Add(Me.btnExluirRegistro)
        Me.GroupBox3.Location = New System.Drawing.Point(284, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 46)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'btnDescartarAlteracoes
        '
        Me.btnDescartarAlteracoes.Enabled = False
        Me.btnDescartarAlteracoes.Location = New System.Drawing.Point(381, 16)
        Me.btnDescartarAlteracoes.Name = "btnDescartarAlteracoes"
        Me.btnDescartarAlteracoes.Size = New System.Drawing.Size(118, 23)
        Me.btnDescartarAlteracoes.TabIndex = 15
        Me.btnDescartarAlteracoes.Text = "Descartar Alterações"
        Me.btnDescartarAlteracoes.UseVisualStyleBackColor = True
        '
        'btnNovoRegistro
        '
        Me.btnNovoRegistro.Location = New System.Drawing.Point(131, 16)
        Me.btnNovoRegistro.Name = "btnNovoRegistro"
        Me.btnNovoRegistro.Size = New System.Drawing.Size(118, 23)
        Me.btnNovoRegistro.TabIndex = 1
        Me.btnNovoRegistro.Text = "Novo Registro"
        Me.btnNovoRegistro.UseVisualStyleBackColor = True
        '
        'btnExluirRegistro
        '
        Me.btnExluirRegistro.Enabled = False
        Me.btnExluirRegistro.Location = New System.Drawing.Point(6, 16)
        Me.btnExluirRegistro.Name = "btnExluirRegistro"
        Me.btnExluirRegistro.Size = New System.Drawing.Size(118, 23)
        Me.btnExluirRegistro.TabIndex = 0
        Me.btnExluirRegistro.Text = "Excluir Registro"
        Me.btnExluirRegistro.UseVisualStyleBackColor = True
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebug.Location = New System.Drawing.Point(300, 3)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(97, 25)
        Me.lblDebug.TabIndex = 17
        Me.lblDebug.Text = "lblDebug"
        '
        'GestaoCadastros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 512)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PRODUTO_DataGrid)
        Me.Controls.Add(Me.grupoFiltros)
        Me.Name = "GestaoCadastros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "3ERP Gerenciar Cadastros"
        Me.grupoFiltros.ResumeLayout(False)
        Me.grupoFiltros.PerformLayout()
        CType(Me.PRODUTO_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grupoFiltros As GroupBox
    Friend WithEvents PRODUTO_DataGrid As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCampoFiltro As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNroCampos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCamposFiltrados As Label
    Friend WithEvents btnSalvaAlteracoes As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnNovoRegistro As Button
    Friend WithEvents btnExluirRegistro As Button
    Friend WithEvents lblRegistrosAlterados As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDescartarAlteracoes As Button
    Friend WithEvents lblTituloJanela As Label
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents lblDebug As Label
End Class
