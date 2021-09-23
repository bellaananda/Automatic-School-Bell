using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace app_bell_2
{
    class Connection
    {
        public SQLiteConnection connect()
        {
            string source = Directory.GetCurrentDirectory() + @"\bin\debug\test.db";
            SQLiteConnection k = new SQLiteConnection("data source = " + source);
            return k;
        }
    }
}
