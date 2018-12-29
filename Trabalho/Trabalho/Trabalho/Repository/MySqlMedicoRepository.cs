using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlMedicoRepository : MySqlRepository, IMedicoRepository
    {
        public MySqlMedicoRepository(IDbConnection connection) : base(connection) { }


        public void Excluir(Medico medico)
        {
            Connection.Execute("delete from medico where id = @id", medico);
        }

        public Medico Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Medico>("select * from medico where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }


        public IEnumerable<Medico> GetByNome(string nome)
        {
            string sql = @"select *
                    from medico
                    where nome like @nome
                    ";
            return Connection.Query<Medico>(sql,
                new { nome = "%" + nome + "%" });
        }

        public IEnumerable<Medico> GetAll()
        {
            return Connection.Query<Medico>("select * from medico order by nome");
        }

        public void Gravar(Medico medico)
        {
            if (medico.Id == 0)
            {
                Connection.Execute("insert into medico(nome) values (@nome)", medico);
                medico.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update medico set nome = @nome where id = @id", medico);
            }
        }
    }
}
