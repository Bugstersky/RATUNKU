using RATUNKU.Protokoly;
using RATUNKU.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RATUNKU
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Numery), typeof(Numery));
            Routing.RegisterRoute(nameof(Medic_Protokoly), typeof(Medic_Protokoly));
            Routing.RegisterRoute(nameof(Udar), typeof(Udar));
            Routing.RegisterRoute(nameof(Krwotok), typeof(Krwotok));
            Routing.RegisterRoute(nameof(Omdlenia), typeof(Omdlenia));
            Routing.RegisterRoute(nameof(Paczka), typeof(Paczka));
            Routing.RegisterRoute(nameof(Strzelec), typeof(Strzelec));
            Routing.RegisterRoute(nameof(AtakCar), typeof(AtakCar));
            Routing.RegisterRoute(nameof(Wybuch), typeof(Wybuch));
            Routing.RegisterRoute(nameof(Zakladnik), typeof(Zakladnik));
            Routing.RegisterRoute(nameof(ZamachTerro), typeof(ZamachTerro));
            Routing.RegisterRoute(nameof(Zlamanie), typeof(Zlamanie));
        }

    }
}
