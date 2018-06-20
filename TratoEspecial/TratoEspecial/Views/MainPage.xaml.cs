using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TratoEspecial.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
        public async void Fn_Log(object sender, EventArgs _args)
        {
            await Navigation.PushAsync(new NavigationPage(new V_Login()));
        }
        public async void Fn_Reg(object sender, EventArgs _args)
        {
            await Navigation.PushAsync(new NavigationPage(new V_Registro()));
        }
        public async void Fn_Info(object sender, EventArgs _args)
        {
            //await Navigation.PushAsync(new NavigationPage(new V_Informacion()));
            await Navigation.PushAsync(new NavigationPage(new V_Informacion(1)));
        }
	}
}