using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtahAccidents.Models
{
    public class AccidentQuery
    {
        public string SearchEntry { get; set; }

        public string County { get; set; }

        public int Severity { get; set; }

    }
}
