using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlConvenioRepository : MySqlRepository, IConvenioRepository
    {
        public MySqlConvenioRepository(IDbConnection connection) : base(connection)
        {
        }

        public void Excluir(Convenio convenio)
        {
            Connection.Execute("delete from convenio where id = @id", convenio);
        }

        public Convenio Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Convenio>("select * from convenio where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<Convenio> GetByNome(string nome)
        {
            string sql = @"select *
                    from convenio
                    where nome like @nome
                    ";
            return Connection.Query<Convenio>(sql,
                 new { nome = "%" + nome + "%" });
        }

        public IEnumerable<Convenio> GetAll()
        {
            return Connection.Query<Convenio>("select * from convenio order by nome");
        }

        public void Gravar(Convenio convenio)
        {
            if (convenio.Id == 0)
            {
                Connection.Execute("insert into convenio(nome) values (@nome)", convenio);
                convenio.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update convenio set nome = @nome where id = @id", convenio);
            }
        }
    }
}
