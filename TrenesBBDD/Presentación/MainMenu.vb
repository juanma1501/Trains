Public Class MainMenu
    Private trip As Trip
    Private state_trip As Integer
    Property tripscol As Collection

    Private Sub Trains_Button_Click(sender As Object, e As EventArgs) Handles Trains_Button.Click
        Trains_UI.Show()
    End Sub

    Private Sub Products_Button_Click(sender As Object, e As EventArgs) Handles Products_Button.Click
        Products_UI.Show()
    End Sub

    Private Sub Ranking_Button_Click(sender As Object, e As EventArgs) Handles Ranking_Button.Click
        Ranking_UI.Show()
    End Sub

    Private Sub ListBoxTrips_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTrips.SelectedIndexChanged

        ListBoxDate.SetSelected(ListBoxTrips.SelectedIndex, True)
        Dim train As New Train((ListBoxTrips.SelectedItem()).ToString)
        train.read()

        Me.trip = New Trip(Convert.ToDateTime(ListBoxDate.SelectedItem), train)
        Me.trip.read()

        TextBoxDate.Text = trip.TripDate().ToString
        TextBoxTrainID.Text = trip.Train.TrainID
        TextBoxType.Text = trip.Train.TrainType.TrainTypeID().ToString
        TextBoxProductID.Text = trip.Product.ProductId.ToString
        TextBoxDescription.Text = trip.Product.ProductDescription
        TextBoxTons.Text = trip.TonsTransported.ToString
    End Sub

    Private Sub addTripMode(mode As Boolean)
        GBOptions.Enabled = Not mode
        GBDescription.Enabled = Not mode
        ListBoxTrips.Enabled = Not mode
        GBUpdate.Enabled = mode
        ListBoxDate.Enabled = Not mode
        GBType.Enabled = Not mode
        cleanAll()
    End Sub

    Private Sub editTripMode(mode As Boolean)
        TextBoxDate.Text = trip.TripDate().ToString
        TextBoxTrainID.Text = trip.Train.TrainID
        TextBoxType.Text = trip.Train.TrainType.TrainTypeID().ToString
        TextBoxProductID.Text = trip.Product.ProductId.ToString
        TextBoxDescription.Text = trip.Product.ProductDescription

        GBDate.Enabled = Not mode
        GBTrain.Enabled = Not mode
        GBDescription.Enabled = Not mode
        GBProductID.Enabled = Not mode
        GBUpdate.Enabled = mode
    End Sub

    Private Sub CleanTripInfo(gb As GroupBox)
        For Each c As Control In gb.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = ""

            ElseIf (TypeOf (c) Is ComboBox) Then
                c.ResetText()

            End If
        Next
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        Me.state_trip = 0
        addTripMode(True)
    End Sub


    Private Sub Trips_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim trips As Trip
        trips = New Trip()
        trips.readAll(Connection_UI.ofdPath.FileName)

        For Each trip As Trip In trips.TripsDAO.tripList()
            ListBoxTrips.Items.Add(trip.Train.TrainID)
            ListBoxDate.Items.Add(trip.TripDate)
        Next

    End Sub

    Private Sub BtCancelarPer_Click(sender As Object, e As EventArgs) Handles BtCancelarPer.Click
        Dim back As Integer
        back = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (back = vbYes) Then
            addTripMode(False)
        End If
    End Sub

    Private Sub BtLimpiarPer_Click(sender As Object, e As EventArgs) Handles BtLimpiarPer.Click
        If state_trip = 0 Then
            CleanTripInfo(GBTrainID)
            CleanTripInfo(GBDate)
            CleanTripInfo(GBProductID)
            CleanTripInfo(GBTons)
        Else
            CleanTripInfo(GBTons)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ListBoxTrips.SelectedItem Is Nothing Then
            MessageBox.Show("Please, select a trip", "Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.state_trip = 1
        editTripMode(True)
    End Sub

    Private Sub BtGuardarPer_Click(sender As Object, e As EventArgs) Handles BtGuardarPer.Click
        If state_trip = 0 Then 'Button in add mode

            If TextBoxDate.Text <> "" And TextBoxTrainID.Text <> "" And TextBoxProductID.Text <> "" And TextBoxTons.Text <> "" Then
                Dim ok As Boolean = True
                Dim d As Date
                Dim trainID As String
                Dim tons As Integer
                Dim productID As Integer
                Me.trip = New Trip


                Try
                    d = Convert.ToDateTime(TextBoxDate.Text.Trim())
                    trainID = TextBoxTrainID.Text.Trim().ToString
                    productID = Convert.ToInt32(TextBoxProductID.Text.Trim())
                    tons = Convert.ToInt32(TextBoxTons.Text.Trim())
                    Me.trip.readAll(Connection_UI.ofdPath.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source)
                    Exit Sub
                End Try


                For Each t As Trip In Me.trip.TripsDAO.tripList
                    Dim dd As Date = t.TripDate
                    Dim str As String = t.Train.TrainID
                    If (dd = d And str = trainID) Then
                        ok = False
                    End If
                    If ok = False Then
                        MessageBox.Show("A train can NOT trip twice in a day", "Repeated date", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next


                Dim product As New Product(productID)
                Dim train As New Train(trainID)

                Try
                    train.read()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source)
                    Exit Sub
                End Try

                Try
                    Dim check_train As Integer = train.TrainType.MaxCapacity
                Catch ex As Exception
                    MessageBox.Show("This train doesn´t exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End Try

                If tons <= train.TrainType.MaxCapacity Then
                    Me.trip = New Trip(d, train, product, tons)

                    Try
                        If Me.trip.insert() <> 1 Then
                            MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source)
                        Exit Sub
                    End Try

                    MessageBox.Show("Trip added to the DataBase", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    addTripMode(False)
                    update_data()
                Else
                    MessageBox.Show("This train can only transport " & train.TrainType.MaxCapacity & " tons", "Capacity", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please, fill all the necessary gaps", "Fill all gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else 'Button in edit mode
            If TextBoxTons.Text <> "" Then
                Dim tonsAux As Integer = trip.TonsTransported
                Dim user_tons As Integer

                Try
                    user_tons = Convert.ToInt32(TextBoxTons.Text.Trim)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source)
                    Exit Sub
                End Try

                If user_tons <= Me.trip.Train.TrainType.MaxCapacity Then
                    trip.TonsTransported = Convert.ToInt32(TextBoxTons.Text.Trim)

                    Try
                        If Me.trip.update() <> 1 Then
                            trip.TonsTransported = tonsAux
                            MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source)
                        Exit Sub
                    End Try

                    MessageBox.Show("Trip updated correctly", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    editTripMode(False)
                    cleanAll()
                Else
                    MessageBox.Show("This train can only transport " & Me.trip.Train.TrainType.MaxCapacity & " tons", "Capacity", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Please, set the tons number", "Fill all gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub update_data()
        ListBoxTrips.Items.Clear()
        ListBoxDate.Items.Clear()

        Dim trips As Trip
        trips = New Trip()
        trips.readAll(Connection_UI.ofdPath.FileName)

        For Each trip As Trip In trips.TripsDAO.tripList()
            ListBoxTrips.Items.Add(trip.Train.TrainID)
            ListBoxDate.Items.Add(trip.TripDate)
        Next
    End Sub

    Private Sub cleanAll()
        CleanTripInfo(GBTrainID)
        CleanTripInfo(GBDate)
        CleanTripInfo(GBProductID)
        CleanTripInfo(GBTons)
        CleanTripInfo(GBType)
        CleanTripInfo(GBDescription)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim delete As Integer
        delete = MessageBox.Show("Are you sure you want to delete it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If (delete = vbYes) Then
            Try
                If Me.trip.delete() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
                Exit Sub
            End Try
            cleanAll()
            update_data()
        End If
    End Sub
End Class