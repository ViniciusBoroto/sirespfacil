using Microsoft.AspNetCore.Mvc;
using SirespFacil.Models.ViewModels;
using SirespFacil.Models;
using System;
using System.Collections.Generic;
using SirespFacil.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace SirespFacil.Controllers
{
    public class ResonanciasController : Controller
    {
        public AppDbContext _context { get; set; }
        public ResonanciasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var res = _context.RessonanciasMagneticas.Include(r => r.Solicitante).Include(r => r.Paciente).ToList()
            var lista = res.Select(r =>
            {
                return new RessonanciaMagneticaViewModel()
                {
                    Paciente = r.Paciente,
                    Motivo = r.Motivo,
                    Solicitante= r.Solicitante,
                };
            });

            return View(lista);
        }
    }
}
