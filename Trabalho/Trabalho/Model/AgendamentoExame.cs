using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Model
{
    public class AgendamentoExame
    {
        public int Id { get; set; }
        public Exame Exame { get; set; }
        public int? ExameId { get { return Exame?.Id; } }
        public int Quantidade { get; set; }
        public decimal ValorUnidade { get; set; }
        public int QuantidadeUnidade { get; set; }
        public decimal Total { get; set; }

        //public int? CursoId { get { return Curso?.Id; } } // usa para fazer a gravação.
        //Instalar a biblioteca Dapper
        //SimpleInject
    }
}
