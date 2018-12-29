using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Model
{
    public class Paciente
    {
        public int Id { get; set; }
        public Convenio Convenio { get; set; }
        public int? ConvenioId { get { return Convenio?.Id; } }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Cidade Cidade { get; set; }
        public int? CidadeId { get { return Cidade?.Id; } }
        public DateTime Nascimento { get; set; }
        public char Sexo { get; set; }
        public string FoneRes { get; set; }
        public string Fonecel1 { get; set; }
        public string Fonecel2 { get; set; }
        public string Fonecom { get; set; }
    }
}
