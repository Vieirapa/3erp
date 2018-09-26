Imports MySql.Data.MySqlClient
Imports System.Xml
Imports System.IO

Public Class EntradaNotaArmazem

    Dim xmldoc As New Xml.XmlDataDocument

    ' nome da tabela para onde aponta
    Public strTabelaFoco As String = "produtos"
    Public strChavePrimaria As String = "idproduto"

    ' criando a conexao com o banco de dados 
    Public MySQLConn As MySqlConnection
    Public mySQLCommand As MySqlCommand
    Public MySQLReader As MySqlDataReader

    ' instancia dos dados do DataSer
    Dim dbDataSet As New DataTable

    Public Sub CarregaTabela()

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
            PRODUTO_DataGrid.AutoResizeColumns()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAbrirXML.Click

        Dim xmldoc As New Xml.XmlDocument
        Dim XmlNodeItem_nNF As XmlNodeList
        Dim XmlNodeItem_cProd As XmlNodeList
        Dim XmlNodeItem_cEAN As XmlNodeList
        Dim XmlNodeItem_xProd As XmlNodeList
        Dim XmlNodeItem_NCM As XmlNodeList
        Dim XmlNodeItem_CFOP As XmlNodeList
        Dim XmlNodeItem_uCom As XmlNodeList
        Dim XmlNodeItem_qCom As XmlNodeList
        Dim XmlNodeItem_vUnCom As XmlNodeList
        Dim XmlNodeItem_vProd As XmlNodeList
        Dim XmlNodeItem_cEANTrib As XmlNodeList
        Dim XmlNodeItem_uTrib As XmlNodeList
        Dim XmlNodeItem_qTrib As XmlNodeList
        Dim XmlNodeItem_vUnTrib As XmlNodeList
        Dim XmlNodeItem_indTot As XmlNodeList
        Dim XmlNodeItem_xPed As XmlNodeList

        Dim i As Integer
        Dim str As String

        ' variaveis que seral usadas para testar se o produto existe no cadastro...
        Dim DV As New DataView(dbDataSet)
        Dim CampoProdura As String


        ' configurando o campos ListView
        lstProdutosNaNota.SmallImageList = ImageList1
        lstProdutosNaNota.FullRowSelect = True

        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()

        Dim arquivo As String
        Dim NroNota As String

        Dim bSource As New BindingSource

        For Each arquivo In OpenFileDialog1.FileNames
            txtXMLFileName.Text = arquivo

            Dim fs As New FileStream(arquivo, FileMode.Open, FileAccess.Read)
            xmldoc.Load(fs)

            XmlNodeItem_nNF = xmldoc.GetElementsByTagName("nNF")
            NroNota = XmlNodeItem_nNF(0).InnerText

            ' arrandando todos os campos de todos os produtos da nota...
            XmlNodeItem_cProd = xmldoc.GetElementsByTagName("cProd")
            XmlNodeItem_cEAN = xmldoc.GetElementsByTagName("cEAN")
            XmlNodeItem_xProd = xmldoc.GetElementsByTagName("xProd")
            XmlNodeItem_NCM = xmldoc.GetElementsByTagName("NCM")
            XmlNodeItem_CFOP = xmldoc.GetElementsByTagName("CFOP")
            XmlNodeItem_uCom = xmldoc.GetElementsByTagName("uCom")
            XmlNodeItem_qCom = xmldoc.GetElementsByTagName("qCom")
            XmlNodeItem_vUnCom = xmldoc.GetElementsByTagName("vUnCom")
            XmlNodeItem_vProd = xmldoc.GetElementsByTagName("vProd")
            XmlNodeItem_cEANTrib = xmldoc.GetElementsByTagName("cEANTrib")
            XmlNodeItem_uTrib = xmldoc.GetElementsByTagName("uTrib")
            XmlNodeItem_qTrib = xmldoc.GetElementsByTagName("qTrib")
            XmlNodeItem_vUnTrib = xmldoc.GetElementsByTagName("vUnTrib")
            XmlNodeItem_indTot = xmldoc.GetElementsByTagName("indTot")
            XmlNodeItem_xPed = xmldoc.GetElementsByTagName("xPed")

            lstProdutosNaNota.Columns.Clear()

            lstProdutosNaNota.Columns.Add("NR.NOTA")
            lstProdutosNaNota.Columns.Add("CODIGO")
            If (XmlNodeItem_cEAN.Count > 0) Then lstProdutosNaNota.Columns.Add("EAN")
            If (XmlNodeItem_xProd.Count > 0) Then lstProdutosNaNota.Columns.Add("DESCRICAO")
            If (XmlNodeItem_NCM.Count > 0) Then lstProdutosNaNota.Columns.Add("NCM")
            If (XmlNodeItem_CFOP.Count > 0) Then lstProdutosNaNota.Columns.Add("CFOP")
            If (XmlNodeItem_uCom.Count > 0) Then lstProdutosNaNota.Columns.Add("UNI.COM")
            If (XmlNodeItem_qCom.Count > 0) Then lstProdutosNaNota.Columns.Add("QTD.COM")
            If (XmlNodeItem_vUnCom.Count > 0) Then lstProdutosNaNota.Columns.Add("VAL.UNIT.COM.")
            If (XmlNodeItem_vProd.Count > 0) Then lstProdutosNaNota.Columns.Add("TOT.BRUTO")
            If (XmlNodeItem_cEANTrib.Count > 0) Then lstProdutosNaNota.Columns.Add("GTIN")
            If (XmlNodeItem_uTrib.Count > 0) Then lstProdutosNaNota.Columns.Add("UNI.TRIB.")
            If (XmlNodeItem_qTrib.Count > 0) Then lstProdutosNaNota.Columns.Add("QTD.TRIB.")
            If (XmlNodeItem_vUnTrib.Count > 0) Then lstProdutosNaNota.Columns.Add("VAL.UNIT.TRIB.")
            If (XmlNodeItem_indTot.Count > 0) Then lstProdutosNaNota.Columns.Add("VPROD.ENT.FISCAL.")
            If (XmlNodeItem_xPed.Count > 0) Then lstProdutosNaNota.Columns.Add("PED.COMPRA.")

            For i = 0 To XmlNodeItem_cProd.Count - 1
                Dim item = lstProdutosNaNota.Items.Add(NroNota)

                ' usando o campos codigo para saber se existe o produto cadastrado . . .
                'CampoProdura = "codigo like '%{0}%'"
                CampoProdura = "codigo = '{0}'"
                DV.RowFilter = String.Format(CampoProdura, XmlNodeItem_cProd(i).InnerText)
                PRODUTO_DataGrid.DataSource = DV

                If (DV.Count = 0) Then
                    ' existe produto com este codigo
                    item.ImageIndex = 1
                ElseIf (DV.Count > 1) Then
                    ' ATENCAO porque tem mais de um produto com este codigo
                    item.ImageIndex = 2
                Else
                    ' nao existe produto com este codigo
                    item.ImageIndex = 0
                End If

                If (XmlNodeItem_cProd.Count > 0) Then item.SubItems.Add(XmlNodeItem_cProd(i).InnerText)
                If (XmlNodeItem_cEAN.Count > 0) Then item.SubItems.Add(XmlNodeItem_cEAN(i).InnerText)
                If (XmlNodeItem_xProd.Count > 0) Then item.SubItems.Add(XmlNodeItem_xProd(i).InnerText)
                If (XmlNodeItem_NCM.Count > 0) Then item.SubItems.Add(XmlNodeItem_NCM(i).InnerText)
                If (XmlNodeItem_CFOP.Count > 0) Then item.SubItems.Add(XmlNodeItem_CFOP(i).InnerText)
                If (XmlNodeItem_uCom.Count > 0) Then item.SubItems.Add(XmlNodeItem_uCom(i).InnerText)
                If (XmlNodeItem_qCom.Count > 0) Then item.SubItems.Add(XmlNodeItem_qCom(i).InnerText)
                If (XmlNodeItem_vUnCom.Count > 0) Then item.SubItems.Add(XmlNodeItem_vUnCom(i).InnerText)
                If (XmlNodeItem_vProd.Count > 0) Then item.SubItems.Add(XmlNodeItem_vProd(i).InnerText)
                If (XmlNodeItem_cEANTrib.Count > 0) Then item.SubItems.Add(XmlNodeItem_cEANTrib(i).InnerText)
                If (XmlNodeItem_uTrib.Count > 0) Then item.SubItems.Add(XmlNodeItem_uTrib(i).InnerText)
                If (XmlNodeItem_qTrib.Count > 0) Then item.SubItems.Add(XmlNodeItem_qTrib(i).InnerText)
                If (XmlNodeItem_vUnTrib.Count > 0) Then item.SubItems.Add(XmlNodeItem_vUnTrib(i).InnerText)
                If (XmlNodeItem_indTot.Count > 0) Then item.SubItems.Add(XmlNodeItem_indTot(i).InnerText)
                If (XmlNodeItem_xPed.Count > 0) Then item.SubItems.Add(XmlNodeItem_xPed(i).InnerText)
            Next
        Next

        lstProdutosNaNota.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        lstProdutosNaNota.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Private Sub btnDescartarLista_Click(sender As Object, e As EventArgs) Handles btnDescartarLista.Click
        lstProdutosNaNota.Items.Clear()
    End Sub

    Private Sub EntradaNotaArmazem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' carregando a tabela de produtos do banco de dados
        CarregaTabela()
    End Sub

    Private Sub lstProdutosNaNota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProdutosNaNota.SelectedIndexChanged

        ' variaveis que seral usadas para testar se o produto existe no cadastro...
        Dim DV As New DataView(dbDataSet)
        Dim CampoProdura As String

        If (lstProdutosNaNota.SelectedItems.Count > 0) Then
            ' usando o campos codigo para saber se existe o produto cadastrado . . .
            'CampoProdura = "codigo like '%{0}%'"
            CampoProdura = "codigo = '{0}'"
            ' filtrando a linha da tabela
            DV.RowFilter = String.Format(CampoProdura, lstProdutosNaNota.SelectedItems(0).SubItems(1).Text)
            PRODUTO_DataGrid.DataSource = DV
        End If

    End Sub
End Class