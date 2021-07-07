using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace A2Jokes.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
