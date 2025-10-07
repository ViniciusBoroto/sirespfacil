namespace SirespFacil.Models
{
    public class Solicitante
    {
        public int Id { get; set; }
        public Unidade Unidade { get; set; }
        public Medico Medico { get; set; }
        public List<RessonanciaMagnetica> RessonanciaMagneticas { get; set; }
    }
}
