using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace A2Jokes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Any_Joke_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RandomJokes());
        }

        async private void Pun_Joke_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PunJokes());
        }

        async private void Programming_Joke_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgrammingJokes());
        }

        async private void See_Favourites_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SavedJokes());
        }
    }
}
