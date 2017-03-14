Public Class Ansatt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hjem.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

End Class