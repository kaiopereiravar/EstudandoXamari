using App02_TipoPaginaXF.Services;
using App02_TipoPaginaXF.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new App02_TipoPaginaXF.TypePage.Carousel.IntroducaoApp();//teve que ser alterado o caminho para que ele rodasse essa tela primeiro
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
