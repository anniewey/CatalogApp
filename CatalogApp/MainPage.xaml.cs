using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CatalogApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        RestService _restService;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");
            _restService = new RestService();

            var content = Preferences.Get("data", "");

            if(content.Length>0)
            {
                MyListBox.ItemsSource = JsonConvert.DeserializeObject<List<CatalogData>>(content);
            }

        }

        void OnNextButtonClicked(object sender, EventArgs e)
        {
            var page = new MyPage();

            Navigation.PushAsync(page);
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            List<CatalogData> weatherData = await _restService.GetJson(GenerateRequestUri(Constants.endpoint));
            Console.WriteLine(weatherData);
            MyListBox.ItemsSource = weatherData;
        }

        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            //requestUri += $"?page={pageEntry.Text}";
            return requestUri;
        }

    }
}
