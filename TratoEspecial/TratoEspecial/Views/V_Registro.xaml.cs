﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TratoEspecial.Personas;
using TratoEspecial.Views;
namespace TratoEspecial
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class V_Registro : ContentPage
	{
        /// <summary>
        /// true es fisico falso es moral
        /// </summary>
        public bool v_T_Persona = true;
        protected override void OnAppearing()
        {
            NavigationPage.SetHasNavigationBar(this, false);
        }
        protected override void OnDisappearing()
        {
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public V_Registro()
        {
            InitializeComponent();
            
            Persona.Text = "Persona Fisica";
            fecha.IsEnabled = v_T_Persona;
            lugar.IsEnabled = v_T_Persona;
            tel.IsEnabled = v_T_Persona;
        }
        /// <summary>
        /// el switch, tru es fisico falso es moral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Cambio(object sender, EventArgs args)
        {
            v_T_Persona = !v_T_Persona;
            if (v_T_Persona)
            {
                giro.Text = "";
                giro.Placeholder = "Ocupacion";
                Persona.Text = "Persona Fisica";
                fecha.IsVisible = true;
                lugar.IsVisible = true;
                tel.IsVisible = true;
            }
            else
            {
                tel.IsVisible = false;
                fecha.IsVisible = false;
                lugar.IsVisible = false;
                giro.Text = "";
                giro.Placeholder = "Giro de la empresa";
                Persona.Text = "Persona Moral";
            }

        }

        private async void Enviar(string _json)
        {
            HttpClient _cli = new HttpClient();

            // create the request content and define Json  
            string _as = (string)_json;
            var content = new StringContent(_as, Encoding.UTF8, "application/json");

            //  send a POST request  
            var uri = "http://jsonplaceholder.typicode.com/posts";
            var result = await _cli.PostAsync(uri, content);

            if (result.IsSuccessStatusCode)
            {
                // si se envia todo bien
            }
            // on error throw a exception  
            result.EnsureSuccessStatusCode();

            // handling the answer  
            var resultString = await result.Content.ReadAsStringAsync();
            var post = JsonConvert.DeserializeObject(resultString);
            //aca pones lo que regresa la base de datos
           // mensaje.Text = "info de regreso";
        }
        public async void Registrar(object sender, EventArgs _args)
        {
            if (v_T_Persona)
            {
                C_Ind_Fisica _Usuario = new C_Ind_Fisica(nombre.Text, rfc.Text, fecha.Date, lugar.Text, giro.Text, tel.Text, cel.Text,
                    dom.Text, ext.Text, inte.Text, col.Text, ciu.Text, mun.Text, est.Text, cp.Text, correo.Text);

                mensaje.Text = _Usuario.Fn_GetInfo();

                HttpClient _cli = new HttpClient();
                string jsonconv = JsonConvert.SerializeObject(_Usuario);
                // create the request content and define Json  
                var content = new StringContent(jsonconv, Encoding.UTF8, "application/json");
                //  send a POST request  
                var uri = "http://jsonplaceholder.typicode.com/posts";

                var result = await _cli.PostAsync(uri, content);
                if (result.IsSuccessStatusCode)
                {
                    // si se envia todo bien
                }
                // on error throw a exception  
                result.EnsureSuccessStatusCode();

                // handling the answer  
                var resultString = await result.Content.ReadAsStringAsync();
                var post = JsonConvert.DeserializeObject(resultString);


                NavigationPage.SetHasNavigationBar(this, false);


                //te encima una nueva pagina, pone solo el boton de regresar
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new V_Informacion(1)) { Title = "Informacion" });
                //await Navigation.PushAsync(new NavigationPage(new V_Informacion(1)));
            }
            else
            {
                C_Ind_Moral _Usuario = new C_Ind_Moral(nombre.Text, rfc.Text, giro.Text, tel.Text,
                   dom.Text, ext.Text, inte.Text, col.Text, ciu.Text, mun.Text, est.Text, cp.Text, correo.Text);
                string jsonconv = JsonConvert.SerializeObject(_Usuario);
                Enviar(jsonconv);
                mensaje.Text = _Usuario.Fn_GetInfo();

                NavigationPage.SetHasNavigationBar(this, false);
                // te encima una nueva pagina, pone solo el boton de regresar
                
                //await Navigation.PushAsync(new NavigationPage(new V_Informacion(2)));
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new V_Informacion(1)) { Title = "Informacion" });
            }
        }
    }
}