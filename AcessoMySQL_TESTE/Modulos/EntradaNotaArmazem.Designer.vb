<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntradaNotaArmazem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradaNotaArmazem))
        Me.btnAbrirXML = New System.Windows.Forms.Button()
        Me.txtXMLFileName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lstProdutosNaNota = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCarregarLista = New System.Windows.Forms.Button()
        Me.btnDescartarLista = New System.Windows.Forms.Button()
        Me.PRODUTO_DataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.PRODUTO_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAbrirXML
        '
        Me.btnAbrirXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirXML.Location = New System.Drawing.Point(539, 379)
        Me.btnAbrirXML.Name = "btnAbrirXML"
        Me.btnAbrirXML.Size = New System.Drawing.Size(149, 23)
        Me.btnAbrirXML.TabIndex = 0
        Me.btnAbrirXML.Text = "Abrir XML"
        Me.btnAbrirXML.UseVisualStyleBackColor = True
        '
        'txtXMLFileName
        '
        Me.txtXMLFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXMLFileName.Location = New System.Drawing.Point(12, 382)
        Me.txtXMLFileName.Name = "txtXMLFileName"
        Me.txtXMLFileName.Size = New System.Drawing.Size(214, 20)
        Me.txtXMLFileName.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lstProdutosNaNota
        '
        Me.lstProdutosNaNota.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstProdutosNaNota.Location = New System.Drawing.Point(12, 12)
        Me.lstProdutosNaNota.MultiSelect = False
        Me.lstProdutosNaNota.Name = "lstProdutosNaNota"
        Me.lstProdutosNaNota.Size = New System.Drawing.Size(676, 245)
        Me.lstProdutosNaNota.TabIndex = 3
        Me.lstProdutosNaNota.UseCompatibleStateImageBehavior = False
        Me.lstProdutosNaNota.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "OK_Novo.bmp")
        Me.ImageList1.Images.SetKeyName(1, "NOK_Novo.bmp")
        Me.ImageList1.Images.SetKeyName(2, "ATENCAO_Novo.bmp")
        '
        'btnCarregarLista
        '
        Me.btnCarregarLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCarregarLista.Location = New System.Drawing.Point(385, 380)
        Me.btnCarregarLista.Name = "btnCarregarLista"
        Me.btnCarregarLista.Size = New System.Drawing.Size(149, 23)
        Me.btnCarregarLista.TabIndex = 4
        Me.btnCarregarLista.Text = "Carregar Itens"
        Me.btnCarregarLista.UseVisualStyleBackColor = True
        '
        'btnDescartarLista
        '
        Me.btnDescartarLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDescartarLista.Location = New System.Drawing.Point(230, 380)
        Me.btnDescartarLista.Name = "btnDescartarLista"
        Me.btnDescartarLista.Size = New System.Drawing.Size(149, 23)
        Me.btnDescartarLista.TabIndex = 5
        Me.btnDescartarLista.Text = "Descartar"
        Me.btnDescartarLista.UseVisualStyleBackColor = True
        '
        'PRODUTO_DataGrid
        '
        Me.PRODUTO_DataGrid.AllowUserToAddRows = False
        Me.PRODUTO_DataGrid.AllowUserToDeleteRows = False
        Me.PRODUTO_DataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PRODUTO_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUTO_DataGrid.Location = New System.Drawing.Point(12, 263)
        Me.PRODUTO_DataGrid.Name = "PRODUTO_DataGrid"
        Me.PRODUTO_DataGrid.ReadOnly = True
        Me.PRODUTO_DataGrid.Size = New System.Drawing.Size(676, 111)
        Me.PRODUTO_DataGrid.TabIndex = 6
        '
        'EntradaNotaArmazem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 415)
        Me.Controls.Add(Me.PRODUTO_DataGrid)
        Me.Controls.Add(Me.btnDescartarLista)
        Me.Controls.Add(Me.btnCarregarLista)
        Me.Controls.Add(Me.lstProdutosNaNota)
        Me.Controls.Add(Me.txtXMLFileName)
        Me.Controls.Add(Me.btnAbrirXML)
        Me.Name = "EntradaNotaArmazem"
        Me.Text = "Form1"
        CType(Me.PRODUTO_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbrirXML As Button
    Friend WithEvents txtXMLFileName As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lstProdutosNaNota As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnCarregarLista As Button
    Friend WithEvents btnDescartarLista As Button
    Friend WithEvents PRODUTO_DataGrid As DataGridView
End Class
