using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlAgendamentoExameRepository : MySqlRepository, IAgendamentoExameRepository
    {
        public MySqlAgendamentoExameRepository(IDbConnection connection) : base(connection) { }


        public void Excluir(AgendamentoExame agendamentoExame)
        {
            Connection.Execute("delete from exame where id = @id", agendamentoExame);
        }

        public AgendamentoExame Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<AgendamentoExame>("select * from agendamentoexame where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<AgendamentoExame> GetAll()
        {
            return Connection.Query<AgendamentoExame>("select * from exame order by nome");
        }

        public void Gravar(AgendamentoExame agendamentoExame)
        {
            if (agendamentoExame.Id == 0)
            {
                Connection.Execute("insert into exame(nome) values (@nome)", agendamentoExame);
                agendamentoExame.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update exame set nome = @nome where id = @id", agendamentoExame);
            }
        }

    }
}

