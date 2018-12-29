using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlExameRepository : MySqlRepository, IExameRepository
    {
        public MySqlExameRepository(IDbConnection connection) : base(connection) { }
       

        public void Excluir(Exame exame)
        {
            Connection.Execute("delete from exame where id = @id", exame);
        }

        public Exame Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Exame>("select * from exame where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<Exame> GetAll()
        {
            return Connection.Query<Exame>("select * from exame order by descricao");
        }

        public void Gravar(Exame exame)
        {
            if (exame.Id == 0)
            {
                Connection.Execute("insert into exame(nome) values (@nome)", exame);
                exame.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update exame set nome = @nome where id = @id", exame);
            }
        }
    }
}
