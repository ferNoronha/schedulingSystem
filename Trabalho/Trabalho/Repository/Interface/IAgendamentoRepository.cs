using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IAgendamentoRepository
    {
        Agendamento Get(int? id);
        IEnumerable<Agendamento> GetAll();
        IEnumerable<Agendamento> GetAgendamento(Agendamento agendamento);
        IEnumerable<Agendamento> GetByMedico(int? id);
        int Gravar(Agendamento agendamento);
        void Excluir(Agendamento agendamento);
        void ExcluirByMedico(Agendamento agendamento);
        IEnumerable<Agendamento> GetByData(DateTime data);
    }
}
