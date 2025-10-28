using Microsoft.AspNetCore.Mvc;
using SirespFacil.Data;
using SirespFacil.Models;
using SirespFacil.Models.ViewModels;
using SirespFacil.Repositories;
using System.Diagnostics;

namespace SirespFacil.Controllers
{
    public class HomeController : Controller
    {
        public RessonanciaMagneticaRepository _ressonanciaMagneticaRepository { get; set; }

        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, RessonanciaMagneticaRepository ressonanciaMagneticaRepository, AppDbContext db)
        {
            _ressonanciaMagneticaRepository = ressonanciaMagneticaRepository;   
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new RessonanciaMagneticaViewModel
            {
                TiposCriterioAutorizacao = _db.TiposCriterioAutorizacao.ToList(),
                TiposExames = _db.TiposExames.ToList(),
                Lateralidades = _db.Lateralidades.ToList(),
                TiposCondutas = _db.Condutas.ToList(),
                TiposJustificativas = _db.Justificativas.ToList()
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public IActionResult SalvarFormulario(RessonanciaMagneticaViewModel model)
        {
            var modelDb = new RessonanciaMagnetica();
            if (model.CriterioDeAutorizacao is not null && model.CriterioDeAutorizacao.Arquivo is not null)
            {
                modelDb.CriterioDeAutorizacao = new CriterioDeAutorizacao();
                modelDb.CriterioDeAutorizacao.CaminhoArquivo = SalvarArquivo(model.CriterioDeAutorizacao.Arquivo);
            }

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

            _ressonanciaMagneticaRepository.Add(modelDb);
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
