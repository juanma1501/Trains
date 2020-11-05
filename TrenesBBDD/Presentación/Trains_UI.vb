Public Class Trains_UI

    Private train As Train
    Private trainType As TrainType
    Private state_train, state_type As Integer

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MainMenu.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
        Me.Close()
    End Sub

    Private Sub EditTrainMode(mode As Boolean)
        GBOptions.Enabled = Not mode
        ListBoxTrains.Enabled = Not mode
        ListBoxTypes.Enabled = Not mode
        TypesInfo.Enabled = Not mode
        GBTypesOption.Enabled = Not mode
        GBUpdate.Enabled = mode
        CleanTrainInfo(GBId)
        CleanTrainInfo(GBType)
    End Sub

    Private Sub EditTrainTypeMode(mode As Boolean)
        GBOptions.Enabled = Not mode
        ListBoxTrains.Enabled = Not mode
        ListBoxTypes.Enabled = Not mode
        GBTypesOption.Enabled = Not mode
        GBTrainInfo.Enabled = Not mode
        GBType.Enabled = Not mode
        GBUpdate2.Enabled = mode
        GBTypeID.Enabled = Not mode
        CleanTrainInfo(GBTypeID)
        CleanTrainInfo(GBCapacity)
        CleanTrainInfo(GBDescription)
    End Sub

    Private Sub CleanTrainInfo(gb As GroupBox)
        For Each c As Control In gb.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = ""

            ElseIf (TypeOf (c) Is ComboBox) Then
                c.ResetText()

            End If
        Next
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.state_train = 0
        EditTrainMode(True)
    End Sub

    Private Sub BtReturn_Click(sender As Object, e As EventArgs) Handles BtReturn.Click
        Dim back As Integer
        back = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (back = vbYes) Then
            EditTrainMode(False)
            GBId.Enabled = True
        End If
    End Sub

    Private Sub BtClean_Click(sender As Object, e As EventArgs) Handles BtClean.Click
        If state_train = 0 Then
            CleanTrainInfo(GBType)
            CleanTrainInfo(GBId)
        Else
            CleanTrainInfo(GBType)
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        state_type = 0
        EditTrainTypeMode(True)
    End Sub

    Private Sub Delete2_Click(sender As Object, e As EventArgs) Handles Delete2.Click
        If state_type = 0 Then
            CleanTrainInfo(GBCapacity)
            CleanTrainInfo(GBDescription)
            CleanTrainInfo(GBTypeID)
        Else
            CleanTrainInfo(GBCapacity)
            CleanTrainInfo(GBDescription)
        End If
    End Sub

    Private Sub Return2_Click(sender As Object, e As EventArgs) Handles Return2.Click
        Dim back As Integer
        back = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (back = vbYes) Then
            EditTrainTypeMode(False)
        End If
    End Sub

    Private Sub ListBoxTrains_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTrains.SelectedIndexChanged
        If ListBoxTrains.SelectedItem IsNot Nothing Then
            Dim id As String
            id = (ListBoxTrains.SelectedItem).ToString
            Dim train As New Train(id)
            train.read()
            Me.train = train
            IdBox.Text = train.TrainID
            TypeBox.Text = train.TrainType.TrainTypeID.ToString
        End If
    End Sub

    Private Sub refresh_trainTypes()
        ListBoxTypes.Items.Clear()
        Dim types As TrainType
        types = New TrainType()
        types.readAll(Connection_UI.ofdPath.FileName)

        For Each type As TrainType In types.TrainsTypeDAO.trainsList()
            ListBoxTypes.Items.Add(type.TrainTypeID)
        Next
    End Sub

    Private Sub Trains_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim trains As Train
        trains = New Train()
        Dim types As TrainType
        types = New TrainType()
        trains.readAll(Connection_UI.ofdPath.FileName)
        types.readAll(Connection_UI.ofdPath.FileName)

        For Each train As Train In trains.TrainDAO.trainList()
            ListBoxTrains.Items.Add(train.TrainID)
        Next

        For Each type As TrainType In types.TrainsTypeDAO.trainsList()
            ListBoxTypes.Items.Add(type.TrainTypeID)
        Next

    End Sub

    Private Sub ListBoxTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTypes.SelectedIndexChanged
        If ListBoxTypes.SelectedItem IsNot Nothing Then
            Dim id As Integer
            id = Convert.ToInt32(ListBoxTypes.SelectedItem)
            Dim type As New TrainType(id)
            type.read()
            trainType = type
            TrainTypeBox.Text = type.TrainTypeID.ToString
            CapacityBox.Text = type.MaxCapacity.ToString
            DescriptionBox.Text = type.TrainTypeDescriptor
        End If
    End Sub

    Private Function checkTrain() As Boolean
        Dim check As Boolean
        check = True

        If TypeBox.Text.Trim = "" Or IdBox.Text.Trim() = "" Then
            check = False
            MessageBox.Show("Please, fill the gaps.", "Fill gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return check
            Exit Function
        End If
        Return check
    End Function

    Private Function checkTrainType() As Boolean
        Dim check As Boolean
        check = True
        If CapacityBox.Text = "" Or DescriptionBox.Text = "" Then
            check = False
            MessageBox.Show("Please, write all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return check
            Exit Function
        End If
        Return check
    End Function

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If (Me.state_train = 0) Then ' It means that the button has been pressed in adding mode
            If (checkTrain()) Then
                Dim type As TrainType
                Dim idTrain As String

                Try
                    Dim idType = TypeBox.Text.Trim().ToString
                    idTrain = IdBox.Text.Trim().ToString
                    type = New TrainType(Convert.ToInt32(idType))
                    type.read()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                Me.train = New Train(idTrain, type)

                Try
                    If Me.train.insert() <> 1 Then
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                MessageBox.Show("The train with ID " & Me.train.TrainID & " has been added correctly to the DataBase.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                EditTrainMode(False)
                ListBoxTrains.Items.Add(Me.train.TrainID)


            End If
        Else ' The button has been pressed in edit mode 
            Dim type As TrainType
            Dim trainType As TrainType = Me.train.TrainType

            Try
                type = New TrainType(Convert.ToInt32(TypeBox.Text.Trim))
                type.read()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Me.train.TrainType = type

            Try
                If Me.train.update() <> 1 Then
                    Me.train.TrainType = trainType
                    MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            MessageBox.Show("Train updated correctly", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            CleanTrainInfo(GBId)
            CleanTrainInfo(GBType)
            EditTrainMode(False)
            GBId.Enabled = True

        End If

    End Sub

    Private Sub Save2_Click(sender As Object, e As EventArgs) Handles Save2.Click
        If state_type = 0 Then ' It means that the button has been pressed in adding mode
            If (checkTrainType()) Then
                Dim capacity As Integer
                Dim description As String

                Try
                    capacity = Convert.ToInt32(CapacityBox.Text.Trim())
                    description = DescriptionBox.Text.Trim()
                    Me.trainType = New TrainType(description, capacity)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                Try
                    If Me.trainType.insert() <> 1 Then
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                Try
                    Me.trainType.read()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                MessageBox.Show("The train type with has been added to DataBase", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                EditTrainTypeMode(False)
                refresh_trainTypes()

            End If
        Else ' The button has been pressed in edit mode 
            If CapacityBox.Text.Trim() <> "" And DescriptionBox.Text.Trim() <> "" Then
                Dim capacity = CapacityBox.Text.Trim()
                Dim description = DescriptionBox.Text.Trim()
                Dim capacityAux = Me.trainType.MaxCapacity
                Dim descriptionAux = Me.trainType.TrainTypeDescriptor

                Try
                    Me.trainType.MaxCapacity = Convert.ToInt32(capacity)
                    Me.trainType.TrainTypeDescriptor = description
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Try
                    If Me.trainType.update() <> 1 Then
                        Me.trainType.MaxCapacity = capacityAux
                        Me.trainType.TrainTypeDescriptor = descriptionAux
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

                MessageBox.Show("Type updated correctly", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                CleanTrainInfo(GBTypeID)
                CleanTrainInfo(GBCapacity)
                CleanTrainInfo(GBDescription)
                EditTrainTypeMode(False)
                GBTypeID.Enabled = True
            Else
                MessageBox.Show("Please, write a Max Capacity number and a Description of the type.", "Fill the gaps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ListBoxTrains.SelectedItem() Is Nothing Then
            MessageBox.Show("Please, select a train", "Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.state_train = 1
        EditTrainMode(True)
        IdBox.Text = ListBoxTrains.SelectedItem().ToString
        GBId.Enabled = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If ListBoxTypes.SelectedItem() Is Nothing Then
            MessageBox.Show("Please, select a train type", "Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        state_type = 1
        EditTrainTypeMode(True)
        TrainTypeBox.Text = ListBoxTypes.SelectedItem().ToString
        GBTypeID.Enabled = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim delete As Integer
        delete = MessageBox.Show("Are you sure you want to delete it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Try
            If (delete = vbYes) Then
                Try
                    If Me.trainType.delete() <> 1 Then
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                ListBoxTypes.Items.RemoveAt(ListBoxTypes.SelectedIndex)
                CleanTrainInfo(GBTypeID)
                CleanTrainInfo(GBCapacity)
                CleanTrainInfo(GBDescription)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub


    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim delete As Integer
        delete = MessageBox.Show("Are you sure you want to delete it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Try
            If (delete = vbYes) Then
                Try
                    If Me.train.delete() <> 1 Then
                        MessageBox.Show("INSERT <> -1", "Custom error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

                ListBoxTrains.Items.RemoveAt(ListBoxTrains.SelectedIndex)
                CleanTrainInfo(GBId)
                CleanTrainInfo(GBType)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub
End Class