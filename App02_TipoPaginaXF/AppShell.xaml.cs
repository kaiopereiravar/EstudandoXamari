using App02_TipoPaginaXF.ViewModels;
using App02_TipoPaginaXF.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App02_TipoPaginaXF
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
