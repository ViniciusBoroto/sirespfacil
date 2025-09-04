namespace SirespFacil.Models
{
    public class ExameSolicitado
    {
        public int Id { get; set; }
        public string Exame { get; set; }
        public bool Sedacao { get; set; }
        public ClassificacaoAsa ClassificacaoAsa { get; set; }
        public Lateralidade Lateralidade { get; set; }
    }
}
