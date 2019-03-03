using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using App2.Data;
using App2.iOS;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_IOS))]

namespace App2.iOS
{
    class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}