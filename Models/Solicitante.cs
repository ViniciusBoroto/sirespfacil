namespace SirespFacil.Models
{
    public class Solicitante
    {
        public int Id { get; set; }
        public Unidade Unidade { get; set; }
        public int UnidadeId { get; set; }
        public Medico Medico { get; set; }
        public int MedicoId { get; set; }
        public List<RessonanciaMagnetica> RessonanciaMagneticas { get; set; }
    }
}
