using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.Views
{
    public partial class AboutPage : ContentPage
    {
        string currentInput = string.Empty;
        double firstNumber = 0;
        string selectedOperator = string.Empty;

        public AboutPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentInput += button.Text;
            resultEntry.Text = currentInput;
        }

        void ClearClicked(object sender, EventArgs e)
        {
            currentInput = string.Empty;
            firstNumber = 0;
            selectedOperator = string.Empty;
            resultEntry.Text = string.Empty;
        }

        void CalculateClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !string.IsNullOrEmpty(selectedOperator))
            {
                double secondNumber = double.Parse(currentInput);
                double result = 0;

                switch (selectedOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                            resultEntry.Text = "Error";
                        break;
                }
                resultEntry.Text = result.ToString();
                currentInput = result.ToString();
                firstNumber = result;
                selectedOperator = string.Empty;
            }
        }
    }
}