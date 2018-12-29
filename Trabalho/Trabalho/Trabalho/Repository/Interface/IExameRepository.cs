using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IExameRepository
    {
        Exame Get(int? id);
        IEnumerable<Exame> GetAll();
        void Gravar(Exame exame);
        void Excluir(Exame exame);
    }
}
