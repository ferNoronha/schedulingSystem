using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IMedicoConvenioRepository
    {
        MedicoConvenio Get(int? id);
        IEnumerable<MedicoConvenio> GetAll();
        void Gravar(MedicoConvenio MC);
        void Excluir(MedicoConvenio MC);
    }
}
