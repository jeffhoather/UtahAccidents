using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtahAccidents.Models;
using UtahAccidents.Models.ViewModels;

namespace UtahAccidents.Controllers
{
    public class HomeController : Controller
    {
        
        private IAccidentsRepository _repo { get; set; }

        public HomeController(IAccidentsRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var blah = _repo.Accidents.ToList();

            return View(blah);
        }

        //public IActionResult SummaryData(int pageNum = 1)
        //{
            
        //    int pageSize = 50;

        //    var x = new AccidentsViewModel
        //    {
        //        Accidents = _repo.Accidents
        //        .OrderBy(a => a.CRASH_ID)
        //        .Skip(pageSize * (pageNum - 1))
        //        .Take(pageSize),

        //        PageInfo = new PageInfo
        //        {
        //            TotalNumAccidents = _repo.Accidents.Count(),
        //            AccidentsPerPage = pageSize,
        //            CurrentPage = pageNum
        //        }
        //    };

        //    return View(x);
        //}

        [HttpGet]
        public IActionResult SummaryData(int? page)
        {
            var Accidents = _repo.Accidents
                .OrderBy(a => a.CRASH_ID);
                //.Skip(pageSize * (pageNum - 1))
                //.Take(pageSize)
            var pager = new Pager(Accidents.Count(), page);


            var viewModel = new IndexViewModel
            {
                Accidents = Accidents.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);

        }



        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult Calculator()
        {

            return View();
        }
        public IActionResult Insights()
        {

            return View();
        }

    }
}
