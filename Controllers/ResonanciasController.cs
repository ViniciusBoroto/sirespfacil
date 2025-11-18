using Microsoft.AspNetCore.Mvc;
using SirespFacil.Models.ViewModels;
using SirespFacil.Models;
using System;
using System.Collections.Generic;

namespace SirespFacil.Controllers
{
    public class ResonanciasController : Controller
    {
        public IActionResult Index()
        {
            // dados mockados
            var tipo1 = new TipoExame { Id = 1, Nome = "RM Crânio" };
            var tipo2 = new TipoExame { Id = 2, Nome = "RM Coluna" };

            var model = new RessonanciaMagneticaViewModel()
            {
                TiposExames = new List<TipoExame> { tipo1, tipo2 },
                Exames = new List<ExameViewModel>
                {
                    new ExameViewModel { Id = 1, Tipo = tipo1, Data = DateTime.Now.AddDays(-10) },
                    new ExameViewModel { Id = 2, Tipo = tipo2, Data = DateTime.Now.AddDays(-30) }
                }
            };

            return View(model);
        }
    }
}
