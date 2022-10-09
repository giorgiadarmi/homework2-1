using System;

public class Form1
{
    public Random R = new Random();


    private void Button1_Click(object sender, EventArgs e)
    {
        this.Timer1.Start();
        this.RichTextBox1.AppendText("DATASET - Misure of the Temperature in Rome with the mean" + Environment.NewLine + Environment.NewLine);
    }

    public int i;

    public double CurrentArithmeticMean = 0;

    private void Timer1_Tick(object sender, EventArgs e)
    {

        // A new observation from the stream
        i = i + 1;
        var NameOfTheDay = "Day" + i;

        double MisureOfTheTemperatureForADay = this.R.Next(1, 42);
        // Update the current mean
        CurrentArithmeticMean = CurrentArithmeticMean + (MisureOfTheTemperatureForADay - CurrentArithmeticMean) / i;

        this.RichTextBox1.AppendText(NameOfTheDay.PadRight(10) + " " + MisureOfTheTemperatureForADay + "°" + Environment.NewLine + "Current Mean: " + CurrentArithmeticMean + "°" + Environment.NewLine + Environment.NewLine);
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        this.Timer1.Stop();
        this.RichTextBox1.Clear();
    }
}
