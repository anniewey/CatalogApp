using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CatalogApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

       
    }
}
