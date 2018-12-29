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
            Connection.Execute("delete from medicoconvenio where id = @id", medicoHorario);
        }

        public MedicoHorario Get(int? id)
        {
            if (id != null)
            {
                return Connection.Query<MedicoHorario>("select * from medicoHorario where id = @id", new { id = id }).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<MedicoHorario> GetAll()
        {
            return Connection.Query<MedicoHorario>("select * from exame order by nome");
        }

        public void Gravar(MedicoHorario medicoHorario)
        {
            if (medicoHorario.Id == 0)
            {
                Connection.Execute("insert into medicoHorario(nome) values (@nome)", medicoHorario);
                medicoHorario.Id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update medicoHorario set nome = @nome where id = @id", medicoHorario);
            }
        }
    }
}
