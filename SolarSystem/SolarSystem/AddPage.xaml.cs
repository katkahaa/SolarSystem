using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void ButtonSend_Clicked(object sender, EventArgs e)
        {
            SolarSystemPage.PlanetsList.Add(new Planet { Category = EntryCategory.Text, Name = EntryName.Text, AboutPlanet = EntryAboutPlanet.Text });
        }
    }
}