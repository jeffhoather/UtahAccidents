using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtahAccidents.Models
{
    public interface IAccidentsRepository
    {
        IQueryable<Accident> Accidents { get;  }
    }
}
