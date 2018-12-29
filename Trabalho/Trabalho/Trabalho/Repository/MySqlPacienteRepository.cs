using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace ProjAgendamento.Repository
{
    class MySqlPacienteRepository : MySqlRepository, IPacienteRepository
    {
        public MySqlPacienteRepository(IDbConnection connection) : base(connection) { }

        public void Excluir(Paciente paciente)
        {
            Connection.Execute("delete from paciente where id = @id", paciente);
        }

        public Paciente Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<Paciente>("select * from paciente where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }


        public IEnumerable<Paciente> GetByNome(string nome)
        {
            string sql = @"select pa.*, co.*, ci.*
                    from paciente pa
                    inner join convenio co on pa.convenioid = co.id
                    inner join cidade ci on pa.cidadeid = ci.id
                    where pa.nome like @nome
                    ";
            return Connection.Query<Paciente, Convenio, Cidade, Paciente>(sql,
                (paciente, convenio, cidade) =>
                {
                    paciente.Convenio = convenio;
                    paciente.Cidade = cidade;
                    return paciente;
                }, new { nome = "%" + nome + "%" });
        }

        public IEnumerable<Paciente> GetAll()
        {
          return Connection.Query<Paciente>("select * from paciente order by nome");
        }

        public IEnumerable<Situacao> GetSituacoes()
        {
            return Connection.Query<Situacao>("select * from situacao order by descricao");
        }

        public void Gravar(Paciente paciente)
        {
            if (paciente.Id == 0)
            {
                Connection.Execute("insert into paciente(nome) values (@nome)", paciente);
                paciente.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update paciente set nome = @nome where id = @id", paciente);
            }
        }
    }
}
