using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Dapper;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlAgendamentoRepository : MySqlRepository, IAgendamentoRepository
    {
        public MySqlAgendamentoRepository(IDbConnection connection) : base(connection)
        {
        }

        public void Excluir(Agendamento agendamento)
        {
            Connection.Execute("delete from agendamento where id = @id", agendamento);
        }

        public Agendamento Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Agendamento>("select * from curso where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<Agendamento> GetAll()
        {
            return Connection.Query<Agendamento>("select * from agendamento order by nome");
        }

        public void Gravar(Agendamento agendamento)
        {
            if (agendamento.Id == 0)
            {
                Connection.Execute("insert into curso(nome) values (@nome)", agendamento);
                agendamento.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update curso set nome = @nome where id = @id", agendamento);
            }
        }
    }
}
