namespace SirespFacil.Models
{
    public class Exame
    {
        public int Id { get; set; }
        public TipoExame Tipo { get; set; }
        public List<string> Arquivos { get; set; }
        public DateOnly Data { get; set; }
    }
}
