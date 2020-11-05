Public Class Connection_UI

    Private Sub Path_Button_Click(sender As Object, e As EventArgs) Handles Path_Button.Click
        Try
            Me.ofdPath.InitialDirectory = Application.StartupPath
            Me.ofdPath.Filter = "Ficheros de bases de datos (*.accdb)|*.accdb|All files(*.*)|*.*"
            If (Me.ofdPath.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                PathBox.Text = Me.ofdPath.FileName()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub Accept_Button_Click(sender As Object, e As EventArgs) Handles Accept_Button.Click
        Try
            Dim broker As BrokerDB
            broker = BrokerDB.getBroker(PathBox.Text)

            Continue_Button.Enabled = True
            StateLabel.ForeColor = Color.Green
            StateLabel.Text = "OK!!"
            Accept_Button.Enabled = True
            Path_Button.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        Path_Button.Enabled = True
        Continue_Button.Enabled = True
    End Sub

    Private Sub Continue_Button_Click(sender As Object, e As EventArgs) Handles Continue_Button.Click
        MainMenu.tripscol = New Collection
        Dim t As New Trip

        Try
            t.readAll(Me.ofdPath.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        MainMenu.tripscol = t.TripsDAO.tripList
        MainMenu.Show()
        Me.Hide()
    End Sub

End Class

