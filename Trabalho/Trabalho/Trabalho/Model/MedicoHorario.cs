using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Model
{
    public class MedicoHorario
    {
        public int Id { get; set; }
        public Medico Medico { get; set; }
        public int? MedicoId { get { return Medico?.Id; } }
        public DateTime dataincial { get; set; }
        public DateTime datafinal { get; set; }
        public DateTime horainical { get; set; }
        public DateTime horafinal { get; set; }
        public Boolean atende{ get; set; }
        public string Observacao{ get; set; }
    }
}
