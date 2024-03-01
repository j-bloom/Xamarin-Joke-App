using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2Jokes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavedJokes : ContentPage
    {
        DBManager _data;
        ObservableCollection<JokeRepository> _joke;
        public SavedJokes()
        {
            InitializeComponent();
            _data = new DBManager();
            _data.CreateTable();
        }

        protected async override void OnAppearing()
        {
            _joke = await _data.CreateTable();
            jokeListView.ItemsSource = _joke;
            base.OnAppearing();
        }

        private void Deleted_MenuItem_Clicked(object sender, EventArgs e)
        {
            var joke = (sender as MenuItem).CommandParameter as JokeRepository;
            _data.deleteJoke(joke);
            _joke.Remove(joke);
        }

        public Command<JokeRepository> Remove
        {
            get
            {
                return new Command<JokeRepository>((joke) =>
                {
                    _joke.Remove(joke);
                });
            }
        }
    }
}