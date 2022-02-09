using RATUNKU.Protokoly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RATUNKU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Medic_Protokoly : ContentPage
    {
        public Medic_Protokoly()
        {
            InitializeComponent();
        }

        private async void P_Udar(object sender, EventArgs e)
        {
            var route = $"{nameof(Udar)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }

        private async void P_Zlamanie(object sender, EventArgs e)
        {
            var route = $"{nameof(Zlamanie)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }

        private async void P_Krwotok(object sender, EventArgs e)
        {
            var route = $"{nameof(Krwotok)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }

        private async void P_Omdlenie(object sender, EventArgs e)
        {
            var route = $"{nameof(Omdlenia)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }
        private async void P_Zamach(object sender, EventArgs e)
        {
            var route = $"{nameof(ZamachTerro)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }
        private async void P_Strzelec(object sender, EventArgs e)
        {
            var route = $"{nameof(Strzelec)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }
        private async void P_CarAttack(object sender, EventArgs e)
        {
            var route = $"{nameof(AtakCar)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }
        private async void P_Paczka(object sender, EventArgs e)
        {
            var route = $"{nameof(Paczka)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }
        private async void P_Zakladnik(object sender, EventArgs e)
        {
            var route = $"{nameof(Zakladnik)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }
         private async void P_Wybuch(object sender, EventArgs e)
        {
            var route = $"{nameof(Wybuch)}";
            await Shell.Current.GoToAsync(route);
            //await Navigation.PushAsync(new Udar());
        }





    }
}