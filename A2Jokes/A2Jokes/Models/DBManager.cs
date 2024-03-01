using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SQLite;
using A2Jokes.Persistence;
using Xamarin.Forms;

namespace A2Jokes
{
    public class DBManager
    {
        private SQLiteAsyncConnection _connection;

        public DBManager()
        {
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }
        
        public async Task<ObservableCollection<JokeRepository>> CreateTable()
        {
            await _connection.CreateTableAsync<JokeRepository>();
            var joke = await _connection.Table<JokeRepository>().ToListAsync();
            var _joke = new ObservableCollection<JokeRepository>(joke);
            return _joke;
        }

        public void insertNewJoke(JokeRepository joke)
        {
            _connection.InsertAsync(joke);
        }

        public void deleteJoke(JokeRepository joke)
        {
            _connection.DeleteAsync(joke);
        }

        public void updateJoke(JokeRepository joke)
        {
            _connection.UpdateAsync(joke);
        }
    }
}
