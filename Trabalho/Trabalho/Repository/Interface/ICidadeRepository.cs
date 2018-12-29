using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface ICidadeRepository
    {
        Cidade Get(int? id);
        IEnumerable<Cidade> GetAll();
        IEnumerable<Cidade> GetByNome(String nome);
        void Gravar(Cidade cidade);
        void Excluir(Cidade cidade);
    }
}
