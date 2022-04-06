using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtahAccidents.Models
{
    public interface IAccidentsRepository
    {
        IQueryable<Accident> Accidents { get;  }

        public void SaveAccident(Accident a);
        public void CreateAccident(Accident a);
        public void DeleteAccident(Accident a);
    }
}
