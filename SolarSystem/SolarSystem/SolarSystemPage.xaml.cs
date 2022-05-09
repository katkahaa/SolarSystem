using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystem
{
    public class Planet
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string AboutPlanet { get; set; }
    }
    public partial class SolarSystemPage : ContentPage
    {
        public static ObservableCollection<Planet> PlanetsList { get; set; }
        public SolarSystemPage()
        {
            InitializeComponent();
            PlanetsList = new ObservableCollection<Planet>(
                new Planet[]
                {
                    new Planet {Category="Planet", Name="Earth", AboutPlanet="Blue planet"},
                    new Planet {Category="Dwarf planet", Name="Pluto", AboutPlanet="Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune. It was the first object discovered in the Kuiper belt and remains the largest known body in that area. After Pluto was discovered in 1930, it was declared the ninth planet from the Sun."},
                });
            PlanetsListView.ItemsSource = PlanetsList;
        }
        private void PlanetsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert((PlanetsListView.SelectedItem as Planet).Category + (PlanetsListView.SelectedItem as Planet).Name, (PlanetsListView.SelectedItem as Planet).AboutPlanet, "OK");
        }
    }
}