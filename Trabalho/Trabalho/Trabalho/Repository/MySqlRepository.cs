using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlRepository
    {
        public MySqlConnection Connection { get; set; }

        public MySqlRepository(IDbConnection connection)
        {
            Connection = connection as MySqlConnection;
        }
    }
}
