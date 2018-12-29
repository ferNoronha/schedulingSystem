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
            Connection.Execute("delete from exame where id = @id", new { id=exame.Id});
        }

        public Exame Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Exame>("select * from exame where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }
        public IEnumerable<Exame> GetByNome(string descricao)
        {
            string sql = @"select *
                    from exame
                    where descricao like @descricao
                    ";
            return Connection.Query<Exame>(sql,
                 new { descricao = "%" + descricao + "%" });
        }

        public IEnumerable<Exame> GetAll()
        {
            return Connection.Query<Exame>("select * from exame order by descricao");
        }

        public void Gravar(Exame exame)
        {
            if (exame.Id == 0)
            {
                Connection.Execute("insert into exame(descricao,qtdeunidade) values (@descricao,@qtdeunidade)", new { descricao = exame.Descricao, qtdeunidade=exame.QtdeUnidade });
                exame.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update exame set descricao = @descricao, qtdeunidade=@qtdeUnidade where id = @id", new { descricao = exame.Descricao, qtdeunidade = exame.QtdeUnidade, id=exame.Id });
            }
        }
    }
}
