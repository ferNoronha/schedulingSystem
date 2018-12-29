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
            Connection.Execute("delete from convenio where id = @id", new { id=convenio.Id});
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
                Connection.Execute("insert into convenio(nome,valorunidade) values (@nome,@valorunidade)", new { nome=convenio.Nome, valorunidade = convenio.ValorUnidade});
                convenio.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update convenio set nome = @nome,valorunidade=@valorunidade where id = @id", new { nome = convenio.Nome, valorunidade = convenio.ValorUnidade, id=convenio.Id});
            }
        }
    }
}
