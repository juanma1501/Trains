Imports System.ComponentModel

Public Class Ranking_UI

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    'Query 1
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles BotonCalcTripProd.Click
        Dim list_ids As New Collection
        ListBoxProducts.Items.Clear()
        Dim train As Train = New Train()
        train.readAll(Connection_UI.ofdPath.FileName)

        For Each t As Train In train.TrainDAO.trainList()
            list_ids.Add(t.TrainID.ToString)
        Next

        If String.IsNullOrEmpty(TrainIDpicker.Text) Then
            MessageBox.Show("Please, write a train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim id = TrainIDpicker.Text
        Dim exist As Boolean = False

        For Each i As String In list_ids
            If i = id Then
                exist = True
            End If
        Next

        If exist = False Then
            MessageBox.Show("This train doesn´t exist. Please change it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Convert.ToDateTime(startDatePickerQ1.Value) > Convert.ToDateTime(finishDatePickerQ1.Value) Then
            MessageBox.Show("Initial date must be smaller than end date.", "Change date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        train = New Train

        train.TrainID = id

        Try
            train.get_trips_and_products(startDatePickerQ1.Value, finishDatePickerQ1.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            Exit Sub
        End Try

        Dim k As Integer = 1
        For Each p In train.TrainDAO.trainList
            If k <> 1 Then
                ListBoxProducts.Items.Add(k - 1 & "   " & p.ToString)
            Else
                TextBoxTrip.Text = p.ToString
            End If
            k += 1
        Next

        If ListBoxProducts.Items.Count = 0 Then
            MessageBox.Show("There are no trips for the selected dates.", "No trips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    'Query 3
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles BotonCalcProdRank.Click
        ProductRankList.Items.Clear()
        Dim product As Product = New Product()
        Dim collection As Collection = New Collection

        If Convert.ToDateTime(startDatePickerQ3.Value) > Convert.ToDateTime(finishDatePickerQ3.Value) Then
            MessageBox.Show("Initial date must be smaller than end date.", "Change date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        Try
            product.get_productRank_between_dates(startDatePickerQ3.Value, finishDatePickerQ3.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            Exit Sub
        End Try

        Dim i As Integer = 1
        For Each p In product.ProductDAO.productList
            ProductRankList.Items.Add(i & "  " & p.ToString)
            i += 1
        Next

        If ProductRankList.Items.Count = 0 Then
            MessageBox.Show("There are no trips for the selected dates.", "No trips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MainMenu.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        MainMenu.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        MainMenu.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
        Me.Close()
    End Sub

    'Query 2
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TrainTypeList.Items.Clear()
        Dim trainType As TrainType = New TrainType
        Dim collection As Collection = New Collection

        If Convert.ToDateTime(startDatePickerQ2.Value) > Convert.ToDateTime(finishDatePickerQ2.Value) Then
            MessageBox.Show("Initial date must be smaller than end date.", "Change date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        Try
            trainType.get_Rank_type_by_trips_betweenDates(startDatePickerQ2.Value, finishDatePickerQ2.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            Exit Sub
        End Try

        Dim i As Integer = 1

        For Each tt In trainType.TrainsTypeDAO.trainsList
            TrainTypeList.Items.Add(i & "  " & tt.ToString)
            i += 1
        Next

        If TrainTypeList.Items.Count = 0 Then
            MessageBox.Show("There are no trips for the selected dates.", "No trips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim t As New Trip
        Dim data As Collection = t.getMostProfit()


        TextBoxProfit.Text = data(1).ToString & "€"
        TextBoxDateTrip.Text = data(3).ToString
        TextBoxTrain.Text = data(4).ToString
        TextBoxType.Text = data(5).ToString
        TextBoxProduct.Text = data(6).ToString
        TextBoxTons.Text = data(7).ToString
        TextBoxPriceDate.Text = "Price in the date of the trip " & data(2).ToString & "€"


    End Sub
End Class