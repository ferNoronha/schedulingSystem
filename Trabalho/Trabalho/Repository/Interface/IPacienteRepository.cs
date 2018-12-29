using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Model;

namespace Trabalho.Repository.Interface
{
    public interface IPacienteRepository
    {
        Paciente Get(int? id);
        IEnumerable<Paciente> GetAll();
        IEnumerable<Paciente> GetByNome(String Nome);
        IEnumerable<Situacao> GetSituacoes();
        void Gravar(Paciente paciente);
        void Excluir(Paciente paciente);
    }
}
