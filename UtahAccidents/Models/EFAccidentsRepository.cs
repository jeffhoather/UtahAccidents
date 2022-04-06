using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtahAccidents.Models
{
    public class EFAccidentsRepository : IAccidentsRepository
    {
        private AccidentsDbContext _context { get; set; }

        public EFAccidentsRepository (AccidentsDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Accident> Accidents => _context.Accidents;

        public void SaveAccident(Accident a)
        {
            _context.SaveChanges();
        }

        public void CreateAccident(Accident a)
        {
            _context.Add(a);
            _context.SaveChanges();
        }

        public void DeleteAccident(Accident a)
        {
            _context.Remove(a);
            _context.SaveChanges();
        }
    }
}
