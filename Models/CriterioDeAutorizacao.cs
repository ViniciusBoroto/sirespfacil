namespace SirespFacil.Models
{
    public class CriterioDeAutorizacao
    {
        public int Id { get; set; }
        public string CaminhoArquivo { get; set; }
        public TipoCriterioAutorizacao Tipo { get; set; }
        public RessonanciaMagnetica RessonanciaMagnetica { get; set; }
        public int RessonanciaMagticaId { get; set; }
    }
}
