namespace SirespFacil.Data
{
    // Data/AppDbContext.cs
    using Microsoft.EntityFrameworkCore;
    using SirespFacil.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<RessonanciaMagnetica> RessonanciasMagneticas { get; set; }
        public DbSet<Conduta> Condutas { get; set; }

        public DbSet<CriterioDeAutorizacao> CriteriosDeAutorizacao { get; set; }

        public DbSet<Exame> Exames { get; set; }

        public DbSet<ExameSolicitado> ExameSolicitados { get; set; }

        public DbSet<ImplanteMetalico> ImplantesMetalicos { get; set; }
        public DbSet<Justificativa> Justificativas { get; set; }
        public DbSet<Lateralidade> Lateralidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<Solicitante> Solicitantes { get; set; }
        public DbSet<TipoCriterioAutorizacao> TiposCriterioAutorizacao { get; set; }
        public DbSet<TipoExame> TiposExames { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
    }
}