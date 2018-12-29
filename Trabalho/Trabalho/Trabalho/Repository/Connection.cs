using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDesignPattern.Repository.MySqlRepository
{
    public class Connection
    {
        public static MySqlConnection GetConnection()
        {
            //return new MySqlConnection("Server=127.0.0.1;port=3311;Database=unoeste;Uid=root;Pwd=;");
            return new MySqlConnection("Server=lpii.mysql.uhserver.com;port=3306;Database=lpii;Uid=lpii;Pwd=fipp@lp2;");
        }
    }
}
