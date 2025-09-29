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
            _db.RessonanciasMagneticas.Add(ressonancia);
            _db.SaveChanges();
        }

    }
}
