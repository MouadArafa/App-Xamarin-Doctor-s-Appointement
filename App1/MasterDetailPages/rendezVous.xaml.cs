using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.MasterDetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class rendezVous : ContentPage
    {
        public rendezVous()
        {
            InitializeComponent();
            myImage.Source = (ImageSource)Application.Current.Properties["Name"];
            OurDate.MinimumDate = DateTime.Now;
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            string selecteddate = e.NewDate.ToShortDateString();
            label.Text += " le rendez-vous est : " + selecteddate;
        }
    }
}