namespace SirespFacil.Models
{
    public class RessonanciaMagnetica
    {
        public int Id { get; set; }
        public List<CriterioDeAutorizacao> CriteriosDeAutorizacao { get; set; } = new();
        public Solicitante? Solicitante { get; set; }
        public int? SolicitanteId {get;set;}
        public Paciente Paciente { get; set; } = new();
        public int PacienteId { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double CircunferenciaAbdominal { get; set; }
        public double ValorUreia { get; set; }
        public double ValorCreatinina { get; set; }
        public List<Exame> Exames { get; set; } = new List<Exame>();
        public string Motivo { get; set; } = "NA";
        public List<ExameSolicitado> ExamesSolicitados { get; set; } = new List<ExameSolicitado>();
        public Conduta Conduta { get; set; } = new();
        public int CondutaId { get; set; }
        public Justificativa Justificativa { get; set; } = new();
        public int JustificativaId { get; set; }
        public string DescricaoDiagnostico { get; set; } = "NA";
        public string CIDPrincipal { get; set; } = "NA";
        public string CIDSecundario { get; set; } = "NA";
        public string CIDCausasAssociadas { get; set; } = "NA";
        public List<ImplanteMetalico> ImplantesMetalicos { get; set; } = new List<ImplanteMetalico>();
        public DateOnly Data { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string OutroExame { get; set; } = "";
    }
}