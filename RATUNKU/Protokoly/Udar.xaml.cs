using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RATUNKU.Protokoly
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Udar : ContentPage
    {
        //public ICommand TapCommand => new Command<string>(OpenBrowser);
        public Udar()
        {
            InitializeComponent();
        }

        //public async void Handle_Tapped(object sender, EventArgs e)
        //{
        //    strinurl = ;
        //    await Browser.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred);
        //}
        //[Obsolete]
        //void OpenBrowser(string url)
        //{
        //    Device.OpenUri(new Uri(url));
        //}

        [Obsolete]
        private void GoMovie(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/watch?v=IAJDzYTS7CE"));
        }
    }
}