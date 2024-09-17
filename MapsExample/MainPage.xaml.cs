using Microsoft.Maui.Maps;

namespace MapsExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //Inicialização do Mapa
            var location = new Location(36.95,-122.0);
            var mapSpan = new MapSpan(location, 0.01,0.01);
            map.MoveToRegion(mapSpan);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
