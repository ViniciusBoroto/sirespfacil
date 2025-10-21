namespace SirespFacil.Models
{
    public class ExameSolicitado
    {
        public int Id { get; set; }
        public string Exame { get; set; }
        public bool Sedacao { get; set; }
        public int ClassificacaoAsa { get; set; }
        public Lateralidade Lateralidade { get; set; }
        public RessonanciaMagnetica RessonanciaMagnetica { get; set; }
    }
}
