Public Class Connection_UI

    Private Sub Path_Button_Click(sender As Object, e As EventArgs) Handles Path_Button.Click
        Try
            Dim ruta_archivo As New OpenFileDialog
            ruta_archivo.InitialDirectory = "c:\"
            ruta_archivo.Filter = "Ficheros de bases de datos (*.accdb)|*.accdb|All files(*.*)|*.*"
            If (ruta_archivo.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                PathBox.Text = ruta_archivo.FileName()
                Accept_Button.Enabled = True



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)

        End Try
    End Sub

    Private Sub Accept_Button_Click(sender As Object, e As EventArgs) Handles Accept_Button.Click
        Try
            Continue_Button.Enabled = True
            StateLabel.ForeColor = Color.Green
            StateLabel.Text = "OK!!"
            Accept_Button.Enabled = False
            Path_Button.Enabled = False
            Dim agente = BrokerDB.getBroker(PathBox.Text)
            Dim comprobarBaseDatos As DataBaseBroker
            comprobarBaseDatos = New DataBaseBroker

        Catch ex As Exception
            StateLabel.Text = "ERROR"
            StateLabel.ForeColor = Color.Red
            Accept_Button.Enabled = True
            Path_Button.Enabled = True
            MessageBox.Show("Debe selecionar la base de datos IMDB valida")
        End Try
    End Sub

    Private Sub Continue_Button_Click(sender As Object, e As EventArgs) Handles Continue_Button.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

End Class
