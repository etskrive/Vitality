Public Class Form1
    Dim results As New Hashtable()
    Dim template As New Hashtable()
    Dim history As String = ""



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        template.Add(6, "A")
        template.Add(5, "B")
        template.Add(4, "C")
        template.Add(3, "D")
        template.Add(2, "E")
        template.Add(1, "F")


        results.Add("A", 0)
        results.Add("B", 0)
        results.Add("C", 0)
        results.Add("D", 0)
        results.Add("E", 0)
        results.Add("F", 0)

    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim grade As String


        grade = UCase(TextBox2.Text)


        results(grade) += 1

        ListBox1.Items.Clear()
        ListBox1.Items.Add("A: " & results("A"))
        ListBox1.Items.Add("B: " & results("B"))
        ListBox1.Items.Add("C: " & results("C"))
        ListBox1.Items.Add("D: " & results("D"))
        ListBox1.Items.Add("E: " & results("E"))
        ListBox1.Items.Add("F: " & results("F"))


        history += grade & " "
        ListBox2.Items.Clear()
        ListBox2.Items.Add(history)




    End Sub

    Private Sub ButtonAverage_Click(sender As Object, e As EventArgs) Handles ButtonAverage.Click
        Dim sum As Integer
        Dim count As Integer
        Dim average As Double
        Dim whole As Integer
        count = results("A") + results("B") + results("C") + results("D") + results("E") + results("F")
        sum = results("A") * 6 + results("B") * 5 + results("C") * 4 + results("D") * 3 + results("E") * 2 + results("F") * 1
        average = sum / count
        whole = Math.Round(average, 0)
        LabelAverage.Text = template(whole)


    End Sub


End Class

