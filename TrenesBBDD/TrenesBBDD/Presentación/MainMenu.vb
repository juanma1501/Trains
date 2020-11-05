Public Class MainMenu
    Private Sub Trips_Button_Click(sender As Object, e As EventArgs) Handles Trips_Button.Click
        Trips_UI.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
    End Sub

    Private Sub Trains_Button_Click(sender As Object, e As EventArgs) Handles Trains_Button.Click
        Trains_UI.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
    End Sub

    Private Sub Products_Button_Click(sender As Object, e As EventArgs) Handles Products_Button.Click
        Products_UI.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
    End Sub

    Private Sub Ranking_Button_Click(sender As Object, e As EventArgs) Handles Ranking_Button.Click
        Ranking_UI.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
    End Sub

End Class