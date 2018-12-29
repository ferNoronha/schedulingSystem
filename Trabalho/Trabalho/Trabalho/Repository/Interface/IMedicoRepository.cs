using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IMedicoRepository
    {
        Medico Get(int? id);
        IEnumerable<Medico> GetAll();
        IEnumerable<Medico> GetByNome(string nome);
        void Gravar(Medico medico);
        void Excluir(Medico medico);
    }
}
