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
        IEnumerable<MedicoConvenio> GetByConvenio(int convenioid);
        IEnumerable<MedicoConvenio> Getporidmed(int id);
        MedicoConvenio GetByMedicoConvenio(MedicoConvenio medicoconvenio);
        void Gravar(MedicoConvenio MC);
        void Excluir(int i);
    }
}
