using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface ISituacaoRepository
    {
        Situacao Get(int? id);
        IEnumerable<Situacao> GetAll();
    }
}
