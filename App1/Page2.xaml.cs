using App1.MasterDetailPages;
using System;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : Xamarin.Forms.TabbedPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            /*await Navigation.PushAsync(new Home());*/
            App.Current.MainPage = new FlyoutPage1();
        }
    }
}