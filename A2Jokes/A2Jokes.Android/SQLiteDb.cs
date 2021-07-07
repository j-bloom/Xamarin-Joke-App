using System;
using System.IO;
using SQLite;
using A2Jokes.Droid;
using A2Jokes.Persistence;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace A2Jokes.Droid
{
    class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "SQLiteJokeDb.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}