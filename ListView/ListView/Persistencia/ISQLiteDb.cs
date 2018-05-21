using System;
using System.Collections.Generic;
using System.Text;
using ListView;
using SQLite;

namespace ListView.Persistencia
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
