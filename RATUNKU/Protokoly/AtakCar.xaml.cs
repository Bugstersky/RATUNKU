using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RATUNKU.Protokoly
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AtakCar : ContentPage
    {
        public AtakCar()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Go_Car(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.avis.pl/oferta-avis/flota/samochody-dostawcze"));
        }
    }
}