using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IAgendamentoExameRepository
    {
        AgendamentoExame Get(int? id);
        IEnumerable<AgendamentoExame> GetAll();
        IEnumerable<AgendamentoExame> GetByAgendamentoExame(int cod);
        void Gravar(AgendamentoExame AE);
        void Excluir(AgendamentoExame AE);
    }
}
