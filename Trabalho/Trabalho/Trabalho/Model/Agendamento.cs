using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Model
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int? ConvenioId { get { return Convenio?.Id; } }
        public Paciente Paciente { get; set; }
        public int? PacienteId { get { return Paciente?.Id; } }
        public Convenio Convenio{ get; set; }
        public int? MedicoId { get { return Medico?.Id; } }
        public Medico Medico { get; set; }
        public DateTime data{ get; set; }
        public DateTime dataagenda{ get; set; }
        public string observacao { get; set; }
        public Situacao Situacao { get; set; }
        public decimal total { get; set; }
    }
}
