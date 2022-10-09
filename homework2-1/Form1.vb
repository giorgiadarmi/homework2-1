Public Class Form1

    Public R As New Random


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Timer1.Start()
        Me.RichTextBox1.AppendText("DATASET - Misure of the Temperature in Rome with the mean" & Environment.NewLine & Environment.NewLine)
    End Sub

    Public i As Integer

    Public CurrentArithmeticMean As Double = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'A new observation from the stream
        i = i + 1
        Dim NameOfTheDay = "Day" & i

        Dim MisureOfTheTemperatureForADay As Double = Me.R.Next(1, 42)
        'Update the current mean
        CurrentArithmeticMean = CurrentArithmeticMean + (MisureOfTheTemperatureForADay - CurrentArithmeticMean) / i

        Me.RichTextBox1.AppendText(NameOfTheDay.PadRight(10) & " " & MisureOfTheTemperatureForADay & "°" & Environment.NewLine &
                                   "Current Mean: " & CurrentArithmeticMean & "°" & Environment.NewLine & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Timer1.Stop()
        Me.RichTextBox1.Clear()
    End Sub
End Class
