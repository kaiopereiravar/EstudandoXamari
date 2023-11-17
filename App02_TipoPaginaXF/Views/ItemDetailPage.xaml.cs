using App02_TipoPaginaXF.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App02_TipoPaginaXF.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}