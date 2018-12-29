using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IMedicoHorarioRepository
    {
        MedicoHorario Get(int? id);
        IEnumerable<MedicoHorario> GetAll();
        void Gravar(MedicoHorario MH);
        void Excluir(MedicoHorario MH);
    }
}
