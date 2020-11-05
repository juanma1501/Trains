Public Class Products_UI

    Private state_product, state_price As Integer
    Private product As Product
    Private price As Price

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MainMenu.Show()
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
        GBId.Enabled = Not mode
        GBOption.Enabled = Not mode
        GBPriceInfo.Enabled = Not mode
        GBPriceOption.Enabled = Not mode
        ListBoxPrices.Enabled = Not mode
        ListBoxDate.Enabled = Not mode
        ListBoxEuros.Enabled = Not mode
        GBUpdate.Enabled = mode
        ListBoxProducts.Enabled = Not mode
    End Sub

    Private Sub EditPriceMode(mode As Boolean)
        CleanProductInfo(GBEuros)
        CleanProductInfo(GBPriceID)
        CleanProductInfo(GBDate)
        GBPriceID.Enabled = Not mode
        GBDate.Enabled = Not mode
        GBProductInfo.Enabled = Not mode
        GBUdpdatePrice.Enabled = mode
        ListBoxPrices.Enabled = Not mode
        ListBoxDate.Enabled = Not mode
        ListBoxEuros.Enabled = Not mode
        GBPriceOption.Enabled = Not mode
        GBOption.Enabled = Not mode
    End Sub

    Private Sub update_prices()
        ListBoxPrices.Items.Clear()
        ListBoxDate.Items.Clear()
        ListBoxEuros.Items.Clear()

        Dim price As Price
        price = New Price()
        price.readAll(Connection_UI.ofdPath.FileName)

        For Each p As Price In price.PriceDAO.priceList()
            ListBoxPrices.Items.Add(p.Product.ProductId)
            ListBoxDate.Items.Add(p.PriceDate)
            ListBoxEuros.Items.Add(p.EurosPerTon)
        Next

        CleanProductInfo(GBEuros)
        CleanProductInfo(GBDate)
        CleanProductInfo(GBPriceID)
    End Sub

    Private Sub refresh_products()
        ListBoxProducts.Items.Clear()
        Dim product As Product
        product = New Product()
        product.readAll(Connection_UI.ofdPath.FileName)

        For Each p As Product In product.ProductDAO.productList()
            ListBoxProducts.Items.Add(p.ProductId)
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.state_product = 0
        EditProductMode(True)
    End Sub

    Private Sub BTReturn_Click(sender As Object, e As EventArgs) Handles BTReturn.Click
        Dim back As Integer
        back = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (back = vbYes) Then
            EditProductMode(False)
        End If
    End Sub

    Private Sub Products_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim product As Product
        product = New Product()
        product.readAll(Connection_UI.ofdPath.FileName)

        Dim price As Price
        price = New Price()
        price.readAll(Connection_UI.ofdPath.FileName)


        For Each p As Product In product.ProductDAO.productList()
            ListBoxProducts.Items.Add(p.ProductId)
        Next

        For Each p As Price In price.PriceDAO.priceList()
            ListBoxPrices.Items.Add(p.Product.ProductId)
            ListBoxDate.Items.Add(p.PriceDate)
            ListBoxEuros.Items.Add(p.EurosPerTon)
        Next
    End Sub

    Private Sub ListBoxProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProducts.SelectedIndexChanged
        If ListBoxProducts.SelectedItem IsNot Nothing Then
            Dim id As Integer
            id = Convert.ToInt32(ListBoxProducts.SelectedItem)
            Dim product As New Product(id)
            product.read()
            Me.product = product
            TextBoxId.Text = Me.product.ProductId.ToString
            TextBoxDescription.Text = Me.product.ProductDescription
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim back As Integer
        back = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (back = vbYes) Then
            EditPriceMode(False)
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.state_price = 0
        EditPriceMode(True)
    End Sub

    Private Sub ListBoxPrices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrices.SelectedIndexChanged
        If ListBoxPrices.SelectedItem IsNot Nothing Then

            ListBoxDate.SetSelected(ListBoxPrices.SelectedIndex, True)
            ListBoxEuros.SetSelected(ListBoxPrices.SelectedIndex, True)

            TextBoxPriceID.Text = ListBoxPrices.Items(ListBoxPrices.SelectedIndex).ToString
            TextBoxDate.Text = ListBoxDate.Items(ListBoxPrices.SelectedIndex).ToString
            TextBoxEuros.Text = ListBoxEuros.Items(ListBoxPrices.SelectedIndex).ToString

            Dim p As Product = New Product(Convert.ToInt32(TextBoxPriceID.Text))
            p.read()
            Dim price As Price = New Price(p, Convert.ToDateTime(TextBoxDate.Text.Trim), Convert.ToDouble(TextBoxEuros.Text.Trim))
            Me.price = price

        End If
    End Sub

    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click
        CleanProductInfo(GBDescription)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CleanProductInfo(GBEuros)
        CleanProductInfo(GBDate)
        CleanProductInfo(GBPriceID)
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If state_product = 0 Then ' It means that the button has been pressed in adding mode
            If TextBoxDescription.Text.Trim() <> "" Then
                Try
                    product = New Product(TextBoxDescription.Text.Trim().ToString)
                    If Me.product.insert() <> 1 Then
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source)
                    Exit Sub
                End Try
                MessageBox.Show("Product added to DataBase", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                EditProductMode(False)
                refresh_products()
            Else
                MessageBox.Show("Please, write a product description.", "Fill gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else ' Pressed in edit mode
            If TextBoxDescription.Text.Trim() <> "" Then
                Dim productDescAux As String = product.ProductDescription
                Try
                    product.ProductDescription = TextBoxDescription.Text.Trim()
                    If Me.product.update() <> 1 Then
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        product.ProductDescription = productDescAux
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source)
                    Exit Sub
                End Try
                MessageBox.Show("Product updated correctly", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                CleanProductInfo(GBId)
                CleanProductInfo(GBDescription)
                EditProductMode(False)
            Else
                MessageBox.Show("Please, write a product description.", "Fill gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim delete As Integer
        delete = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If (delete = vbYes) Then
            Try
                If Me.product.delete() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            ListBoxProducts.Items.RemoveAt(ListBoxProducts.SelectedIndex)
            CleanProductInfo(GBId)
            CleanProductInfo(GBDescription)
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ListBoxProducts.SelectedItem() IsNot Nothing Then
            TextBoxId.Text = ListBoxProducts.SelectedItem().ToString
        Else
            MessageBox.Show("Please, select a product", "Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        EditProductMode(True)
        state_product = 1
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim delete As Integer
        delete = MessageBox.Show("Are you sure you want to delete this price?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If (delete = vbYes) Then
            Try
                If Me.price.delete() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
            update_prices()
        End If

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If ListBoxPrices.SelectedItem Is Nothing Then
            MessageBox.Show("Please, select a price", "Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.state_price = 1
        EditPriceMode(True)
        TextBoxPriceID.Text = price.Product.ProductId.ToString
        TextBoxDate.Text = price.PriceDate.ToString
        GBPriceID.Enabled = False
        GBDate.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If state_price = 0 Then
            If TextBoxPriceID.Text.Trim() <> "" And TextBoxDate.Text.Trim <> "" And TextBoxEuros.Text.Trim <> "" Then
                Dim dat As Date
                Dim euros As Double
                Dim product As Product

                Try
                    product = New Product(Convert.ToInt32(TextBoxPriceID.Text.Trim()))
                    dat = Convert.ToDateTime(TextBoxDate.Text.Trim())
                    euros = Convert.ToDouble(TextBoxEuros.Text.Trim())
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try


                Me.price = New Price(product, dat, euros)

                Try
                    If Me.price.insert() <> 1 Then
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                MessageBox.Show("New price to the product with ID " & Me.price.Product.ProductId & " has been added correctly.")
                update_prices()
                EditPriceMode(False)
            Else
                MessageBox.Show("Fill all the necessary gaps", "Empty gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If TextBoxEuros.Text.Trim() <> "" Then
                Dim eurPerTonAux As Double = Me.price.EurosPerTon

                Try
                    Me.price.EurosPerTon = Convert.ToDouble(TextBoxEuros.Text.Trim())
                    If Me.price.update() <> 1 Then
                        Me.price.EurosPerTon = eurPerTonAux
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    update_prices()
                    MsgBox("Price updated correctly.")
                    EditPriceMode(False)
                    GBPriceID.Enabled = True
                    GBDate.Enabled = True
                Else
                    MessageBox.Show("Fill all the necessary gaps", "Empty gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
        End If
    End Sub
End Class