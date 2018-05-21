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
	public partial class master : ContentPage
	{
		public master ()
		{
			InitializeComponent ();
		}


        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushModalAsync(new agregar());
        }

        private async void btnEditar_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushModalAsync(new editar());

        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushModalAsync(new eliminar());

        }

        private async void btnBuscar_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushModalAsync(new buscar());

        }


    }


}