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
            List<RessonanciaMagnetica> res = new List<RessonanciaMagnetica>
            {
                new RessonanciaMagnetica
                {
                    Solicitante = new Solicitante { Unidade = new Unidade { Nome = "Hospital Central" } },
                    Paciente = new Paciente { Nome = "João Silva" },
                    Data = new DateOnly(2024, 11, 20),
                    Motivo = "Dor lombar crônica",
                    Peso = 75.5,
                    Altura = 1.75,
                    CircunferenciaAbdominal = 92.0,
                    ValorUreia = 35.0,
                    ValorCreatinina = 1.1,
                    DescricaoDiagnostico = "Hérnia de disco lombar L4-L5",
                    CIDPrincipal = "M51.2",
                    CIDSecundario = "M54.5",
                    CIDCausasAssociadas = "M48.0"
                },
                new RessonanciaMagnetica
                {
                    Solicitante = new Solicitante { Unidade = new Unidade { Nome = "Clínica São Paulo" } },
                    Paciente = new Paciente { Nome = "Maria Santos" },
                    Data = new DateOnly(2024, 11, 22),
                    Motivo = "Investigação de cefaleia persistente",
                    Peso = 62.0,
                    Altura = 1.65,
                    CircunferenciaAbdominal = 78.0,
                    ValorUreia = 28.0,
                    ValorCreatinina = 0.9,
                    DescricaoDiagnostico = "Enxaqueca sem aura",
                    CIDPrincipal = "G43.0",
                    CIDSecundario = "R51",
                    CIDCausasAssociadas = "G44.2"
                }
            };

            var lista = res.Select(r =>
            {
                return new RessonanciaMagneticaViewModel()
                {
                    Paciente = r.Paciente,
                    Solicitante = r.Solicitante,
                    Data = r.Data,
                    Motivo = r.Motivo
                };
            });

            return View(lista.ToList());
        }
    }
}
