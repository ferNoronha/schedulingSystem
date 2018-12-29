using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Model
{
    public class MedicoConvenio
    {
        public Medico Medico { get; set; }
        public Convenio Convenio { get; set; }
        public int? MedicoId { get { return Medico?.Id; } }
        public int? ConvenioId { get { return Convenio?.Id; } }

    }
}
