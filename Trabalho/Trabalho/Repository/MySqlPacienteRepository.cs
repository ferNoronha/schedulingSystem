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
            Connection.Execute("delete from paciente where id = @id", new { id = paciente.Id });
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
                Connection.Execute("insert into paciente(bairro,cep,cidadeid,complemento,convenioid,email,fonecel1,fonecel2,fonecom,foneres,logradouro,nascimento,nome,numero,rg,sexo) values (@bairro,@cep,@cidadeid,@complemento,@convenioid,@email,@fonecel1,@fonecel2,@fonecom,@foneres,@logradouro,@nascimento,@nome,@numero,@rg,@sexo)", new { bairro = paciente.Bairro, cep = paciente.Cep, cidadeid = paciente.CidadeId, complemento = paciente.Complemento, convenioid = paciente.ConvenioId, email = paciente.Email, fonecel1 = paciente.Fonecel1, fonecel2 = paciente.Fonecel2, fonecom = paciente.Fonecom, foneres = paciente.FoneRes, logradouro = paciente.Logradouro, nascimento = paciente.Nascimento, nome = paciente.Nome, numero=paciente.Numero, rg = paciente.Rg, sexo = paciente.Sexo});
                paciente.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update paciente set bairro = @bairro, cep = @cep, cidadeid = @cidadeid, complemento = @complemento, convenioid = @convenioid, email = @email, fonecel1 = @fonecel1, fonecel2 = @fonecel2, fonecom = @fonecom, foneres = @foneres, logradouro = @logradouro, nascimento = @nascimento, nome = @nome, numero=@numero, rg = @rg, sexo = @sexo where id = @id", new { bairro = paciente.Bairro, cep = paciente.Cep, cidadeid = paciente.CidadeId, complemento = paciente.Complemento, convenioid = paciente.ConvenioId, email = paciente.Email, fonecel1 = paciente.Fonecel1, fonecel2 = paciente.Fonecel2, fonecom = paciente.Fonecom, foneres = paciente.FoneRes, logradouro = paciente.Logradouro, nascimento = paciente.Nascimento, nome = paciente.Nome, numero = paciente.Numero, rg = paciente.Rg, sexo = paciente.Sexo, id = paciente.Id});
            }
        }
    }
}
