using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlCidadeRepository : MySqlRepository, ICidadeRepository
    {

        public MySqlCidadeRepository(IDbConnection connection) : base(connection)
        {
        }

        public void Excluir(Cidade cidade)
        {
            Connection.Execute("delete from cidade where id = @id", new { id = cidade.Id });
        }

        public Cidade Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Cidade>("select * from cidade where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<Cidade> GetAll()
        {
            return Connection.Query<Cidade>("select * from cidade order by nome");
        }


        public IEnumerable<Cidade> GetByNome(string nome)
        {
            string sql = @"select *
                    from cidade 
                    where nome like @nome
                    ";
            return Connection.Query<Cidade>(sql,
                 new { nome = "%" + nome + "%" });
        }

        public void Gravar(Cidade cidade)
        {
            if (cidade.Id == 0)
            {
                Connection.Execute("insert into cidade(nome,uf) values (@nome,@uf)", new { nome = cidade.Nome, uf = cidade.Uf });
                cidade.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update cidade set nome = @nome, uf=@uf where id = @id", new{nome = cidade.Nome, uf = cidade.Uf, id=cidade.Id});
            }
        }
    }
}
