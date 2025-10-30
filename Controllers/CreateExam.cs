using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SirespFacil.Data;
using SirespFacil.Models;
using SirespFacil.Models.ViewModels;
using System.Xml.Linq;

namespace SirespFacil.Controllers
{
    public class CreateExam : Controller
    {
        private AppDbContext _db;
        public CreateExam(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
