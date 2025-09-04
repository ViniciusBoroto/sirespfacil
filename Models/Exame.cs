namespace SirespFacil.Models
{
    public class Exame
    {
        public int Id { get; set; }
        public TipoExame Tipo { get; set; }
        public DateOnly Data { get; set; }
    }
}
