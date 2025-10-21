using Microsoft.AspNetCore.Mvc;
using SirespFacil.Models;
using SirespFacil.Models.ViewModels;
using System.Xml.Linq;

namespace SirespFacil.Controllers
{
    public class CreateExam : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarFormulario(RessonanciaMagneticaViewModel model)
        {
            var modelDb = new RessonanciaMagnetica();
            modelDb.CriterioDeAutorizacao = new CriterioDeAutorizacao();
            modelDb.CriterioDeAutorizacao.CaminhoArquivo = SalvarArquivo(model.CriterioDeAutorizacao.Arquivo);

            modelDb.Solicitante = model.Solicitante;
            modelDb.Paciente = model.Paciente;
            modelDb.Peso = model.Peso;
            modelDb.Altura = model.Altura;
            modelDb.CircunferenciaAbdominal = model.CircunferenciaAbdominal;
            modelDb.ValorUreia = model.ValorUreia;
            modelDb.ValorCreatinina = model.ValorCreatinina;
            modelDb.Motivo = model.Motivo;
            modelDb.ExamesSolicitados = model.ExamesSolicitados;
            modelDb.Conduta = model.Conduta;
            modelDb.Justificativa = model.Justificativa;
            modelDb.DescricaoDiagnostico = model.DescricaoDiagnostico;
            modelDb.CIDPrincipal = model.CIDPrincipal;
            modelDb.CIDSecundario = model.CIDSecundario;
            modelDb.CIDCausasAssociadas = model.CIDCausasAssociadas;
            modelDb.ImplantesMetalicos = model.ImplantesMetalicos;
            modelDb.Data = model.Data;
            foreach (var exame in model.Exames)
            {
                var exameDb = new Exame
                {
                    Tipo = exame.Tipo,
                    Data = exame.Data
                };
                var caminhos = SalvarArquivos(exame.Arquivos);
                exameDb.CaminhosArquivos = caminhos;
            }

            // salvar no banco a referência (exame + caminhos dos arquivos)
            return RedirectToAction("Index");
        }
        private List<string> SalvarArquivos(List<IFormFile> files)
        {
            var paths = new List<string>();
            files.ForEach(f => paths.Add(SalvarArquivo(f)));
            return paths;
        }
        private string SalvarArquivo(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return string.Empty;

            var filePath = Path.Combine("wwwroot/uploads/files/exames", Guid.NewGuid().ToString());
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return filePath;
        }
    }
}
