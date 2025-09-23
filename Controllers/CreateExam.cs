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
            modelDb.CriterioDeAutorizacao = model.CriterioDeAutorizacao;
            modelDb.Solicitante = model.Solicitante;
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
            foreach (var file in files)
            {
                if (file != null && file.Length > 0)
                {
                    var filePath = Path.Combine("wwwroot/uploads/files/exames", Guid.NewGuid().ToString());
                    //TODO: Salvar o caminho no banco de dados
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    paths.Add(filePath); // Apenas o nome do arquivo, o caminho completo será salvo após o upload
                }
            }
            return paths;
        }
    }
}
