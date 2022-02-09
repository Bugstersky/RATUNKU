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
    public partial class Strzelec : ContentPage
    {
        public Strzelec()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void GoMovie(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/watch?v=__7Qw7PcJ9o"));
        }
    }
}