using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace CalculateDistance
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnCounterClicked(object sender, EventArgs e)
		{
            var myLocation = await Geolocation.GetLocationAsync();

			var otherLocation = new Location(58.9438705, 5.7118685);

			var distance = myLocation.CalculateDistance(otherLocation, DistanceUnits.Kilometers);

			CounterLabel.Text = $"Distance to Brustadbua: {distance:0.##} km";
		}
	}
}
