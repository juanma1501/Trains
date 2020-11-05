Public Class Trips_UI
    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MainMenu.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
        Me.Close()
    End Sub


End Class