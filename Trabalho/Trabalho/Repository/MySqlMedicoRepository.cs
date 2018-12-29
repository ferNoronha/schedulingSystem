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
            Connection.Execute("delete from medico where id = @id", new { id = medico.Id});
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

        public int Gravar(Medico medico)
        {
            if (medico.Id == 0)
            {
                Connection.Execute("insert into medico(crm,fonecel1,fonecel2,nome) values (@crm,@fonecel1,@fonecel2,@nome)", new { crm=medico.Crm, fonecel1 = medico.Fonecel1, fonecel2 = medico.Fonecel2, nome = medico.Nome});
                medico.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
                return medico.Id;
            }
            else
            {
                Connection.Execute("update medico set crm = @crm, fonecel1=@fonecel1, fonecel2=@fonecel2, nome = @nome where id = @id", new { id=medico.Id, crm = medico.Crm, fonecel1 = medico.Fonecel1, fonecel2 = medico.Fonecel2, nome = medico.Nome });
                return medico.Id;
            }
        }
    }
}
