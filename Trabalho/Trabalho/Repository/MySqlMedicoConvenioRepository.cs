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


        public void Excluir(int id1)
        {
            Connection.Execute("delete from medicoconvenio where medicoid = @id", new { id = id1});
        }


        public MedicoConvenio Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<MedicoConvenio>("select * from medicoconvenio where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }
        public IEnumerable<MedicoConvenio> Getporidmed(int medicoid)
        {
            string sql = @"select * from medicoconvenio mc inner join convenio co on mc.convenioid = co.id where medicoid = @medicoid";


            return Connection.Query<MedicoConvenio,Convenio,MedicoConvenio>(sql,
                (medicoConvenio, convenio) =>
                {
                    medicoConvenio.Convenio = convenio;
                    return medicoConvenio;
                }
                ,new { medicoid = medicoid });
        }

        public IEnumerable<MedicoConvenio> GetByConvenio(int convenioid)
        {
            string sql = @"select * from medicoconvenio mc inner join medico me on mc.medicoid = me.id where convenioid = @convenioid";

            return Connection.Query<MedicoConvenio,Medico,MedicoConvenio>(sql,
              (medicoConvenio, medico) =>
              {
                  medicoConvenio.Medico = medico;
                  return medicoConvenio;
              }, new { convenioid = convenioid });
        }

        public IEnumerable<MedicoConvenio> GetAll()
        {
            return Connection.Query<MedicoConvenio>("select * from medicoconvenio");
        }

        public MedicoConvenio GetByMedicoConvenio(MedicoConvenio medicoconvenio)
        {
            return Connection.Query<MedicoConvenio>("select * from medicoconvenio where medicoid = @medicoid and convenioid = @convenioid",new { medicoid = medicoconvenio.MedicoId, convenioid = medicoconvenio.ConvenioId }).FirstOrDefault();
        }

        public void Gravar(MedicoConvenio medicoConvenio)
        {
            if (medicoConvenio.Convenio.Id != 0 || medicoConvenio.Medico.Id != 0)
            {
                Connection.Execute("insert into medicoconvenio(convenioid,medicoid) values (@convenioid, @medicoid)", new { convenioid = medicoConvenio.ConvenioId, medicoid = medicoConvenio.MedicoId});
                medicoConvenio.Medico.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update medicoconvenio set convenioid = @convenioid where medicoid = @medicoid", new { convenioid = medicoConvenio.ConvenioId, medicoid = medicoConvenio.MedicoId });
            }
        }
    }
}
