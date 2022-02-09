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
    public partial class Numery : ContentPage
    {
        public Numery()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Fire_Call(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("tel://998"));

                //PhoneDialer.Open("112");
            }
            catch (Exception)
            {
                DisplayAlert("Unable to make call", "Something gone wrong", "OK");
            }
        }

        [Obsolete]
        private void PoliceCall(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("tel://997"));

                //PhoneDialer.Open("112");
            }
            catch (Exception)
            {
                DisplayAlert("Unable to make call", "Something gone wrong", "OK");
            }
        }

        [Obsolete]
        private void AmbulanceCall(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("tel://999"));

                //PhoneDialer.Open("112");
            }
            catch (Exception)
            {
                DisplayAlert("Unable to make call", "Something gone wrong", "OK");
            }
        }
    }
}