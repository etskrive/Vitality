Public Class Hjem
    Dim erAnsatt As Boolean = False

    Private Sub Hjem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Vitality System"
        '   Me.Location = New Point(100, 100)
    End Sub

    Private Sub Hjem_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        'eventuelt sett inn her lagring ved exit for å bevare utfullstendig innført data
        Application.Exit()
    End Sub

    Private Sub btnBlodgiver_Click(sender As Object, e As EventArgs) Handles btnBlodgiver.Click
        btnAnsatt.Enabled = True
        btnBlodgiver.Enabled = False
        Label1.Text = "Blodgiver"
        erAnsatt = False
    End Sub

    Private Sub btnAnsatt_Click(sender As Object, e As EventArgs) Handles btnAnsatt.Click
        btnAnsatt.Enabled = False
        btnBlodgiver.Enabled = True
        Label1.Text = "Ansatt"
        erAnsatt = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If erAnsatt = True Then
            Me.Hide()
            Ansatt.Show()
        Else
            Me.Hide()
            Blodgiver.Show()
        End If
    End Sub


End Class
