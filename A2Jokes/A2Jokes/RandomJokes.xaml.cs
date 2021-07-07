using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2Jokes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RandomJokes : ContentPage
    {
        JokeRepository _joke;
        RestService _restService;
        DBManager _data;
        public RandomJokes()
        {
            InitializeComponent();
            _restService = new RestService();
            _data = new DBManager();
            _data.CreateTable();
        }

        async private void Get_Joke_Button_Clicked(object sender, EventArgs e)
        {
            _joke = await _restService.GetJokeRepositoryAsync(Constants.AnyJoke);
            jokeToDisplay.Text = _joke.Joke;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            _data.insertNewJoke(_joke);
            string joke = Convert.ToString(_joke.Joke);
            DisplayAlert("Saved", "This joke has been saved!", "OK");
        }
    }
}