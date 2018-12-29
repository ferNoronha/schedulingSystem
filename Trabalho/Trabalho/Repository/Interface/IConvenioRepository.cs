using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IConvenioRepository
    {
        Convenio Get(int? id);
        IEnumerable<Convenio> GetAll();
        IEnumerable<Convenio> GetByNome(String nome);
        void Gravar(Convenio convenio);
        void Excluir(Convenio convenio);
    }
}
