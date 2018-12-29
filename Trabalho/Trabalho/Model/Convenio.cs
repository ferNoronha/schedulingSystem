namespace Trabalho.Model
{
    public class Convenio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnidade { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}