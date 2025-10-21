using SirespFacil.Data;
using SirespFacil.Models;
using System;

namespace SirespFacil.Repositories
{
    public class RessonanciaMagneticaRepository
    {
        private readonly AppDbContext _db;

        public RessonanciaMagneticaRepository(AppDbContext context)
        {
            _db = context;
            if (_db.TiposCriterioAutorizacao.Find(1) is not null) { return; }
            _db.TiposCriterioAutorizacao.Add(new TipoCriterioAutorizacao { Nome = "EsteFormulário" });
            _db.TiposCriterioAutorizacao.Add(new TipoCriterioAutorizacao { Nome = "Laudo APAC" });
            _db.TiposCriterioAutorizacao.Add(new TipoCriterioAutorizacao { Nome = "Exame Realizado" });
            _db.TiposCriterioAutorizacao.Add(new TipoCriterioAutorizacao { Nome = "História Clínica" });
            _db.TiposCriterioAutorizacao.Add(new TipoCriterioAutorizacao { Nome = "Relatório Exame Físico" });

            _db.TiposExames.Add(new TipoExame { Nome = "Raio X" });
            _db.TiposExames.Add(new TipoExame { Nome = "Ultrassonografia" });
            _db.TiposExames.Add(new TipoExame { Nome = "Tomografia" });
            _db.TiposExames.Add(new TipoExame { Nome = "Ressonância" });

            _db.Lateralidades.Add(new Lateralidade { Nome = "Esquerda" });
            _db.Lateralidades.Add(new Lateralidade { Nome = "Direita" });
            _db.Lateralidades.Add(new Lateralidade { Nome = "Não se aplica" });

            _db.Condutas.Add(new Conduta { Nome = "Conduta Diagnóstica" });
            _db.Condutas.Add(new Conduta { Nome = "Conduta Terapêutica" });

            _db.Justificativas.Add(new Justificativa{ Nome = "Lesão" });
            _db.Justificativas.Add(new Justificativa { Nome = "Tumor" });
            _db.Justificativas.Add(new Justificativa { Nome = "Pré Cirúrgico" });
            _db.Justificativas.Add(new Justificativa { Nome = "Pós Cirúrgico" });
            _db.Justificativas.Add(new Justificativa { Nome = "Doença Vascular" });
            _db.Justificativas.Add(new Justificativa { Nome = "Doenças Aorta/Vasos" });
            _db.SaveChanges();
        }

        public IEnumerable<RessonanciaMagnetica> GetAll()
        {
            return _db.RessonanciasMagneticas.ToList();
        }

        public RessonanciaMagnetica? GetById(int id)
        {
            return _db.RessonanciasMagneticas.Find(id);
        }

        public void Add(RessonanciaMagnetica ressonancia)
        {

            if (ressonancia.CriterioDeAutorizacao is not null)
                _db.Attach(ressonancia.CriterioDeAutorizacao!.Tipo);
            if (ressonancia.Solicitante?.Id != 0)
                _db.Attach(ressonancia.Solicitante!);
            if (ressonancia.Paciente.Id != 0)
                _db.Attach(ressonancia.Paciente);
            ressonancia.ExamesSolicitados?.ForEach(es =>
            {
                _db.Attach(es.Lateralidade);
            });

            _db.Attach(ressonancia.Conduta);
            _db.Attach(ressonancia.Justificativa);
            ressonancia.Exames?.ForEach(e =>
            {
                _db.Attach(e.Tipo);
            });
            _db.RessonanciasMagneticas.Add(ressonancia);
            _db.SaveChanges();
        }

    }
}
