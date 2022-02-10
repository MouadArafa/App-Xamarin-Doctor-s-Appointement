using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.MasterDetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = image1.Source;
            await Navigation.PushAsync(new rendezVous()); 
        }
        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = image2.Source;
            await Navigation.PushAsync(new rendezVous());
        }
        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = image3.Source;
            await Navigation.PushAsync(new rendezVous());
        }
        private async void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = image4.Source;
            await Navigation.PushAsync(new rendezVous());
        }
        private async void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = image5.Source;
            await Navigation.PushAsync(new rendezVous());
        }

        private async void image6_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = image6.Source;
            await Navigation.PushAsync(new rendezVous());
        }
    }
}