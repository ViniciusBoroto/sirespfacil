namespace SirespFacil.Models
{
    public class RessonanciaMagnetica
    {
        public int Id { get; set; }
        public CriterioDeAutorizacao? CriterioDeAutorizacao { get; set; }
        public int CriterioDeAutorizacaoId  {get;set;}
        public Solicitante? Solicitante { get; set; }
        public int? SolicitanteId {get;set;}
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double CircunferenciaAbdominal { get; set; }
        public double ValorUreia { get; set; }
        public double ValorCreatinina { get; set; }
        public List<Exame> Exames { get; set; } = new List<Exame>();
        public string Motivo { get; set; }
        public List<ExameSolicitado> ExamesSolicitados { get; set; } = new List<ExameSolicitado>();
        public Conduta Conduta { get; set; }
        public int CondutaId { get; set; }
        public Justificativa Justificativa { get; set; }
        public int JustificativaId { get; set; }
        public string DescricaoDiagnostico { get; set; }
        public string CIDPrincipal { get; set; }
        public string CIDSecundario { get; set; }
        public string CIDCausasAssociadas { get; set; }
        public List<ImplanteMetalico> ImplantesMetalicos { get; set; } = new List<ImplanteMetalico>();
        public DateOnly Data { get; set; }
        public string OutroExame { get; set; }
    }
}