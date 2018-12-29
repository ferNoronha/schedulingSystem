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
            Connection.Execute("delete from agendamento where id = @id", new{ id=agendamento.Id});
        }

        public void ExcluirByMedico(Agendamento agendamento)
        {
            Connection.Execute("delete from agendamento where medicoid = @medicoid", new { medicoid = agendamento.MedicoId});
        }

        public Agendamento Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Agendamento>("select * from agendamento where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<Agendamento> GetByMedico(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Agendamento>("select * from agendamento where medicoid = @medicoid", new { medicoid = id });
            }
            return null;
        }

        public IEnumerable<Agendamento> GetAgendamento(Agendamento agenda)
        {
            string sql = @"select * from agendamento ag inner join medico me on ag.medicoid = me.id
            inner join paciente pa on ag.pacienteid = pa.id
            inner join convenio co on ag.convenioid = co.id
            where medicoid = @idmedico and dataagenda between @dataagenda and @datafim";


            return Connection.Query<Agendamento,Medico,Convenio,Paciente,Agendamento>(sql,
                (agendamento, medico,convenio,paciente) => {
                    agendamento.Medico = medico;
                    agendamento.Convenio = convenio;
                    agendamento.Paciente = paciente;

                    return agendamento;
                }
                ,
                new { idmedico = agenda.MedicoId, dataagenda = agenda.dataagenda, datafim = agenda.dataagenda.Date.AddDays(1) });
        }

        public IEnumerable<Agendamento> GetAll()
        {
            return Connection.Query<Agendamento>("select * from agendamento ordem by id");
        }
        public IEnumerable<Agendamento> GetByData(DateTime dataagenda)
        {
            string sql = @"select ag.*, pa.*, co.*, me.*
                    from agendamento ag
                    inner join paciente pa on ag.pacienteid = pa.id
                    inner join convenio co on ag.convenioid = co.id
                    inner join medico me on ag.medicoid = me.id
                    where ag.dataagenda between @dataagenda and @datafim
                    ";
            return Connection.Query<Agendamento, Paciente, Convenio, Medico, Agendamento>(sql,
                (agendamento, paciente, convenio, medico) =>
                {
                    agendamento.Paciente = paciente;
                    agendamento.Convenio = convenio;
                    agendamento.Medico = medico;
                    return agendamento;
                }, new { dataagenda = dataagenda.Date, datafim=dataagenda.Date.AddDays(1) });
        }

        public int Gravar(Agendamento agendamento)
        {
            if (agendamento.Id == 0)
            {
                Connection.Execute("insert into agendamento(convenioid,data,dataagenda,medicoid,observacao,pacienteid,situacaoid,total) values (@convenioid,@data,@dataagenda,@medicoid,@observacao,@pacienteid,@situacaoid,@total)", new { convenioid=agendamento.ConvenioId, data=agendamento.data, dataagenda=agendamento.dataagenda, medicoid=agendamento.MedicoId, observacao=agendamento.observacao, pacienteid=agendamento.PacienteId, situacaoid=agendamento.Situacao.Id, total=agendamento.total });
                agendamento.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
                return agendamento.Id;

            }
            else
            {
                Connection.Execute("update agendamento set convenioid=@convenioid, data=@data, dataagenda=@dataagenda, medicoid=@medicoid, observacao=@observacao, pacienteid=@pacienteid, situacaoid=@situacao, total=@total where id = @id", new { convenioid = agendamento.ConvenioId, data = agendamento.data, dataagenda = agendamento.dataagenda, medicoid = agendamento.MedicoId, observacao = agendamento.observacao, pacienteid = agendamento.PacienteId, situacaoid = agendamento.Situacao.Id, total = agendamento.total, id=agendamento.Id });
                return agendamento.Id;
            }
        }
    }
}
