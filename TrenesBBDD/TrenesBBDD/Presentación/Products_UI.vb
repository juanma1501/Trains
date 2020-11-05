Public Class Products_UI

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MainMenu.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
        Me.Close()
    End Sub

    Private Sub CleanProductInfo(gb As GroupBox)
        For Each c As Control In gb.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = ""

            ElseIf (TypeOf (c) Is ComboBox) Then
                c.ResetText()

            End If
        Next
    End Sub

    Private Sub EditProductMode(mode As Boolean)
        CleanProductInfo(GBDate)
        CleanProductInfo(GBDescription)
        CleanProductInfo(GBEuros)
        CleanProductInfo(GBId)
        GBOption.Enabled = Not mode
        GBPriceInfo.Enabled = Not mode
        GBPriceOption.Enabled = Not mode
        ListBoxPrices.Enabled = Not mode
        GBUpdate.Enabled = mode
        ListBoxProducts.Enabled = Not mode
    End Sub

    Private Sub EditPriceMode(mode As Boolean)
        CleanProductInfo(GBEuros)
        CleanProductInfo(GBPrice)
        CleanProductInfo(GBDate)
        GBProductInfo.Enabled = Not mode
        GBUdpdatePrice.Enabled = mode
        ListBoxPrices.Enabled = Not mode
        ListBoxProducts.Enabled = Not mode
        GBPriceOption.Enabled = Not mode
        GBOption.Enabled = Not mode
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        EditProductMode(True)
    End Sub

    Private Sub BTReturn_Click(sender As Object, e As EventArgs) Handles BTReturn.Click
        Dim back As Integer
        back = MsgBox("Are you sure you want to exit Edition Mode? Not saved data will be delete.", vbYesNo + vbDefaultButton2, "Close Edition Mode.")
        If (back = vbYes) Then
            EditProductMode(False)
        End If
    End Sub

    Private Sub Products_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim product As Product
        product = New Product()
        product.readAll()

        Dim price As Price
        price = New Price()
        price.readAll()

        GBPriceInfo.Hide()

        For Each p As Product In product.ProductDAO.productList()
            ListBoxProducts.Items.Add(p.ProductDescription)
        Next

        For Each p As Price In price.PriceDAO.priceList()
            ListBoxPrices.Items.Add(p.Product.ProductId & "       " & p.PriceDate & "       " & p.EurosPerTon)
        Next
    End Sub

    Private Sub ListBoxProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProducts.SelectedIndexChanged
        If ListBoxProducts.SelectedItem IsNot Nothing Then
            Dim des As String
            des = ListBoxProducts.SelectedItem
            Dim product As New Product(des)
            product.read()
            TextBoxId.Text = product.ProductId
            TextBoxDescription.Text = product.ProductDescription
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim back As Integer
        back = MsgBox("Are you sure you want to exit Edition Mode? Not saved data will be delete.", vbYesNo + vbDefaultButton2, "Close Edition Mode.")
        If (back = vbYes) Then
            EditPriceMode(False)
            GBPriceInfo.Hide()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        EditPriceMode(True)
        GBPriceInfo.Show()
    End Sub

    Private Sub ListBoxPrices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrices.SelectedIndexChanged
        If ListBoxPrices.SelectedItem IsNot Nothing Then
            Dim id As Integer
            id = ListBoxPrices.SelectedItem
            Dim price As New Price(id)
            price.read()
            TextBoxPriceID.Text = id
            TextBoxDate.Text = price.PriceDate.ToString
            TextBoxEuros.Text = price.EurosPerTon.ToString
        End If
    End Sub


End Class