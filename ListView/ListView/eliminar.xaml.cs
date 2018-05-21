using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class eliminar : ContentPage
	{
		public eliminar ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos elementos = new ListaElementos();
            detalle.ItemsSource = elementos._elementos;
        }
    }
}