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
    public partial class Glowna : ContentPage
    {
        public Glowna()
        {
            InitializeComponent();
        }
        void OnTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            //searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
        }
        void GetTappedItem(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item;
        }


    }
}