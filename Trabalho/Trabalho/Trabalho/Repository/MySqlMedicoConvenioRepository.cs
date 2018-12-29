using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlMedicoConvenioRepository : MySqlRepository, IMedicoConvenioRepository
    {
        public MySqlMedicoConvenioRepository(IDbConnection connection) : base(connection) { }


        public void Excluir(MedicoConvenio medicoConvenio)
        {
            Connection.Execute("delete from medicoconvenio where id = @id", medicoConvenio);
        }

        public MedicoConvenio Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<MedicoConvenio>("select * from medicoconvenio where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<MedicoConvenio> GetAll()
        {
            return Connection.Query<MedicoConvenio>("select * from exame order by nome");
        }

        public void Gravar(MedicoConvenio medicoConvenio)
        {
            if (medicoConvenio.Convenio.Id == 0 || medicoConvenio.Medico.Id == 0)
            {
                Connection.Execute("insert into medicoconvenio(nome) values (@nome)", medicoConvenio);
                medicoConvenio.Medico.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update medicoconvenio set nome = @nome where id = @id", medicoConvenio);
            }
        }
    }
}
