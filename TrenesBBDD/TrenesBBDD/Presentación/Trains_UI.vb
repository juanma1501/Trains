Public Class Trains_UI
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

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
        EditTrainMode(True)
    End Sub

    Private Sub BtReturn_Click(sender As Object, e As EventArgs) Handles BtReturn.Click
        Dim back As Integer
        back = MsgBox("Are you sure you want to exit Edition Mode? Not saved data will be delete.", vbYesNo + vbDefaultButton2, "Close Edition Mode.")
        If (back = vbYes) Then
            EditTrainMode(False)
        End If
    End Sub

    Private Sub BtClean_Click(sender As Object, e As EventArgs) Handles BtClean.Click
        CleanTrainInfo(GBType)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        EditTrainTypeMode(True)
    End Sub

    Private Sub Delete2_Click(sender As Object, e As EventArgs) Handles Delete2.Click
        CleanTrainInfo(GBCapacity)
        CleanTrainInfo(GBDescription)
        CleanTrainInfo(GBTypeID)
    End Sub

    Private Sub Return2_Click(sender As Object, e As EventArgs) Handles Return2.Click
        Dim back As Integer
        back = MsgBox("Are you sure you want to exit Edition Mode? Not saved data will be delete.", vbYesNo + vbDefaultButton2, "Close Edition Mode.")
        If (back = vbYes) Then
            EditTrainTypeMode(False)
        End If
    End Sub

    Private Sub ListBoxTrains_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTrains.SelectedIndexChanged
        If ListBoxTrains.SelectedItem IsNot Nothing Then
            Dim id As Integer
            id = ListBoxTrains.SelectedItem
            Dim train As New Train(id)
            train.read()
            IdBox.Text = train.TrainID
            TypeBox.Text = train.TrainType.TrainTypeDescriptor
        End If
    End Sub

    Private Sub Trains_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim trains As Train
        trains = New Train()
        Dim types As TrainType
        types = New TrainType()
        trains.readAll()
        types.readAll()

        For Each train As Train In trains.TrainDAO.trainList()
            ListBoxTrains.Items.Add(train.TrainID)
        Next

        For Each type As TrainType In types.TrainsTypeDAO.trainsList()
            ListBoxTypes.Items.Add(type.TrainTypeDescriptor)
        Next
    End Sub

    Private Sub ListBoxTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTypes.SelectedIndexChanged
        If ListBoxTypes.SelectedItem IsNot Nothing Then
            Dim des As String
            des = ListBoxTypes.SelectedItem
            Dim type As New TrainType(des)
            type.read()
            TrainTypeBox.Text = type.TrainTypeID
            CapacityBox.Text = type.MaxCapacity
            DescriptionBox.Text = type.TrainTypeDescriptor
        End If
    End Sub
End Class