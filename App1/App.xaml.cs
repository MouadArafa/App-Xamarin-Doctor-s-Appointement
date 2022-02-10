
using App1.MasterDetailPages;
using App1.Services;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
 
namespace App1
{
    public partial class App : Xamarin.Forms.Application
    {

        public App()
        {
            InitializeComponent();
           

            DependencyService.Register<MockDataStore>();
            MainPage = new Page2();
        

            
        }


    }
}
