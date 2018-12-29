using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlAgendamentoExameRepository : MySqlRepository, IAgendamentoExameRepository
    {
        public MySqlAgendamentoExameRepository(IDbConnection connection) : base(connection) { }


        public void Excluir(AgendamentoExame agendamentoExame)
        {
            Connection.Execute("delete from agendamentoexame where agendamentoid = @id", new { id=agendamentoExame.Id});
        }

        public AgendamentoExame Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<AgendamentoExame>("select * from agendamentoexame where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<AgendamentoExame> GetAll()
        {
            return Connection.Query<AgendamentoExame>("select * from agendamentoexame order by agendamentoid");
        }

        public IEnumerable<AgendamentoExame> GetByAgendamentoExame(int agendamentoid)
        {
            string sql = @"select * from agendamentoexame ae inner join exame ex on ex.id = ae.exameid where ae.agendamentoid=@id";


            return Connection.Query<AgendamentoExame,Exame,AgendamentoExame>(sql,
                (agendamentoexame,exame) => {
                    agendamentoexame.Exame = exame;
                    return agendamentoexame;
                }
                ,new { id = agendamentoid});
        }



        public void Gravar(AgendamentoExame agendamentoExame)
        {
            if (agendamentoExame.Id != 0)
            {
                Connection.Execute("insert into agendamentoexame(agendamentoid,exameid,qtde,qtdeunidade,total,valorunidade) values (@agendamentoid,@exameid,@qtde,@qtdeunidade,@total,@valorunidade)", 
                    new { agendamentoid = agendamentoExame.Id, exameid = agendamentoExame.ExameId,
                    qtde = agendamentoExame.Quantidade, qtdeunidade = agendamentoExame.QuantidadeUnidade , total = agendamentoExame.Total, valorunidade = agendamentoExame.ValorUnidade });
                agendamentoExame.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update exame set exameid = @exameid, qtde = @qtde, qtdeunidade = @qtdeunidade, total = @total, valorunidade = @valorunidade where agendamentoid = @agendamentoid", new { agendamentoid = agendamentoExame.Id, exameid = agendamentoExame.ExameId, qtde = agendamentoExame.Quantidade, qtdeunidade = agendamentoExame.QuantidadeUnidade, total = agendamentoExame.Total, valorunidade = agendamentoExame.ValorUnidade });
            }
        }

    }
}

