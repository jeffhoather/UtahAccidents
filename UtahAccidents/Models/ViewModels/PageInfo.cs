using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtahAccidents.Models.ViewModels
{
    public class PageInfo
    {
        
        public int TotalNumAccidents { get; set; }
        public int AccidentsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) Math.Ceiling((double) TotalNumAccidents / AccidentsPerPage);
        public int StartPage { get; set; }
        public int EndPage { get; set; }
    }
}
