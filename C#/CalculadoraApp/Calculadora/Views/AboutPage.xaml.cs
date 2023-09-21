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

        
    }
}