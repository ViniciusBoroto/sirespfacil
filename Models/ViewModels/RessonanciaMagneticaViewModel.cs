namespace SirespFacil.Models.ViewModels
{
    public class RessonanciaMagneticaViewModel
    {
        public CriterioDeAutorizacaoViewModel CriterioDeAutorizacao { get; set; }
        public Solicitante Solicitante { get; set; }
        public Paciente Paciente { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double CircunferenciaAbdominal { get; set; }
        public double ValorUreia { get; set; }
        public double ValorCreatinina { get; set; }
        public List<ExameViewModel> Exames { get; set; } = new List<ExameViewModel>();
        public string Motivo { get; set; }
        public List<ExameSolicitado> ExamesSolicitados { get; set; } = new List<ExameSolicitado>();
        public Conduta Conduta { get; set; }
        public Justificativa Justificativa { get; set; }
        public string DescricaoDiagnostico { get; set; }
        public string CIDPrincipal { get; set; }
        public string CIDSecundario { get; set; }
        public string CIDCausasAssociadas { get; set; }
        public List<ImplanteMetalico> ImplantesMetalicos { get; set; } = new List<ImplanteMetalico>();
        public DateOnly Data { get; set; }
        public string OutroExame { get; set; }
    }
}