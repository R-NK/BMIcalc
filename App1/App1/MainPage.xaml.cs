using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btn1.Clicked += Btn1_Clicked;
        }
        private void Btn1_Clicked(object sender, EventArgs args)
        {
            try
            {
                this.BMI.Text = "BMI: " + CalcBMI(double.Parse(weight.Text), double.Parse(height.Text));
            }
            catch(System.FormatException)
            {
                this.BMI.Text = "Enter your weight or height!";
            }
        }
        private int CalcBMI(double weight, double height)
        {
            int bmi =(int)(weight / (height * height)); 
            return bmi;
        }
    }
}
