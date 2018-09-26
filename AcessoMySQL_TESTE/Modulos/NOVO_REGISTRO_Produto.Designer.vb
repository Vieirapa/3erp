<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOVO_REGISTRO_Produto
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
        Me.btnDescartaRegistro = New System.Windows.Forms.Button()
        Me.btnSalvaRegsitro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEAN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFamilia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDescartaRegistro
        '
        Me.btnDescartaRegistro.Location = New System.Drawing.Point(487, 138)
        Me.btnDescartaRegistro.Name = "btnDescartaRegistro"
        Me.btnDescartaRegistro.Size = New System.Drawing.Size(75, 23)
        Me.btnDescartaRegistro.TabIndex = 0
        Me.btnDescartaRegistro.Text = "Descartar"
        Me.btnDescartaRegistro.UseVisualStyleBackColor = True
        '
        'btnSalvaRegsitro
        '
        Me.btnSalvaRegsitro.Location = New System.Drawing.Point(406, 138)
        Me.btnSalvaRegsitro.Name = "btnSalvaRegsitro"
        Me.btnSalvaRegsitro.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvaRegsitro.TabIndex = 1
        Me.btnSalvaRegsitro.Text = "Salva"
        Me.btnSalvaRegsitro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(25, 39)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(175, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(25, 78)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(529, 20)
        Me.txtDescricao.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrição"
        '
        'txtEAN
        '
        Me.txtEAN.Location = New System.Drawing.Point(214, 39)
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(175, 20)
        Me.txtEAN.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dógido EAN"
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(25, 117)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(175, 20)
        Me.txtFamilia.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Família"
        '
        'NOVO_REGISTRO_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 173)
        Me.Controls.Add(Me.txtFamilia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEAN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalvaRegsitro)
        Me.Controls.Add(Me.btnDescartaRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NOVO_REGISTRO_Produto"
        Me.Text = "Incluir Registro Produto"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDescartaRegistro As Button
    Friend WithEvents btnSalvaRegsitro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEAN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFamilia As TextBox
    Friend WithEvents Label4 As Label
End Class
