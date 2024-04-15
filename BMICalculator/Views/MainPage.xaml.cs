using System.Reflection;

namespace BMICalculator.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;
        public int UserWeight = 0;

        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        private void CalculateBmi(object sender, EventArgs e)
        {
            double Weight = Convert.ToInt32(Weight_input.Text);
            double Height = Convert.ToInt32(Height_input.Text);
            double Output = (Weight / (Height * Height)) * 703;
            OutputBmi.Text = $"Your BMI is {Output}";
        }
    }
}