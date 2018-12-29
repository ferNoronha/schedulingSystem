using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlMedicoHorarioRepository : MySqlRepository, IMedicoHorarioRepository
    {
        public MySqlMedicoHorarioRepository(IDbConnection connection) : base(connection) { }


        public void Excluir(MedicoHorario medicoHorario)
        {
            Connection.Execute("delete from medicohorario where id = @id", medicoHorario);
        }
        public void ExcluirpeloMedico(int medicoid)
        {
            Connection.Execute("delete from medicohorario where medicoid = @medicoid", new { medicoid = medicoid });
        }


        public MedicoHorario Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<MedicoHorario>("select * from medicohorario where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<MedicoHorario> GetByMedico(int medicoid)
        {
            string sql = @"select * from medicohorario mh inner join medico m on mh.medicoid = m.id where medicoid like @medicoid";
            return Connection.Query<MedicoHorario, Medico, MedicoHorario>(sql,
                (medicohorario, medico) => {

                    medicohorario.Medico = medico;
                    return medicohorario;
                },
                 new { medicoid = "%" + medicoid + "%" });
        }

        public IEnumerable<MedicoHorario> GetAll()
        {
            return Connection.Query<MedicoHorario>("select * from medicohorario");
        }

        public void Gravar(MedicoHorario medicohorario)
        {
            if (medicohorario.Id == 0)
            {
                Connection.Execute("insert into medicohorario(atende, datafinal, datainicial, horainicial, horafinal, medicoid, observacao) values (@atende, @datafinal, @datainicial, @horainicial, @horafinal, @medicoid, @observacao)", new { atende = medicohorario.atende, datafinal = medicohorario.datafinal, datainicial = medicohorario.datainicial, horainicial = medicohorario.horainicial, horafinal = medicohorario.horafinal, medicoid = medicohorario.MedicoId, observacao = medicohorario.Observacao });
                medicohorario.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update medicohorario set atende = @atende, datafinal = @datafinal, datainicial = @dataincial, horainicial = @horainicial, horafinal = @horafinal, medicoid = @medicoid, observacao = @observacao  where id = @id", new { atende = medicohorario.atende, datafinal = medicohorario.datafinal, datainicial = medicohorario.datainicial, horainicial = medicohorario.horainicial, horafinal = medicohorario.horafinal, medicoid = medicohorario.MedicoId, observacao = medicohorario.Observacao, id = medicohorario.Id});
            }
        }
    }
}
