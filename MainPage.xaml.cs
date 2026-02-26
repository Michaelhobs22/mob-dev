namespace MauiBmiCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (double.TryParse(HeightEntry.Text, out double height) &&
            double.TryParse(WeightEntry.Text, out double weight) &&
            height > 0)
        {
            double bmi = weight / (height * height);
            string category = GetBmiCategory(bmi);

            ResultLabel.Text = $"BMI: {bmi:F2}\nCategory: {category}";
        }
        else
        {
            ResultLabel.Text = "Please enter valid numbers.";
        }
    }

    private string GetBmiCategory(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi < 25)
            return "Normal weight";
        else if (bmi < 30)
            return "Overweight";
        else
            return "Obese";
    }
}
